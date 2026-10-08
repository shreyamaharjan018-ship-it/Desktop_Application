using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ElevatorSystem
{
    public partial class MainForm : Form
    {
        private Image _imgClosed;
        private Image _imgOpen;

        private int _currentFloor = 1;
        private bool _isMoving = false;

        private System.Windows.Forms.Timer _moveTimer;

        private int _startY;
        private int _targetY;

        private DateTime _moveStartTime;

        private const int MOVE_DURATION = 2800;

        private int _floor1Y;
        private int _floor2Y;

        public MainForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            EnableDoubleBuffering(pnlShaft);

            picElevator.SizeMode =
                PictureBoxSizeMode.StretchImage;

            picElevator.BringToFront();

            this.Shown += MainForm_Shown;
            this.Resize += MainForm_Resize;
        }

        // =========================
        // FORM START
        // =========================

        private void MainForm_Shown(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer startupDelay =
                new System.Windows.Forms.Timer();

            startupDelay.Interval = 700;

            startupDelay.Tick += (s, args) =>
            {
                startupDelay.Stop();
                startupDelay.Dispose();

                LoadImages();
                SetupTimer();

                CalculateFloorPositions();

                PositionCar(1);
            };

            startupDelay.Start();
        }

        // =========================
        // DOUBLE BUFFERING
        // =========================

        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control)
                .GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(control, true, null);
        }

        // =========================
        // LOAD ELEVATOR IMAGES
        // =========================

        private void LoadImages()
        {
            try
            {
                _imgClosed =
                    LoadAndFit("elevator_closed.png");

                _imgOpen =
                    LoadAndFit("elevator_open.png");

                if (_imgClosed != null)
                {
                    picElevator.Image =
                        _imgClosed;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Image load failed:\n\n" +
                    ex.Message,
                    "Image Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Image LoadAndFit(string fileName)
        {
            string path =
                Path.Combine(
                    Application.StartupPath,
                    "Resources",
                    fileName);

            if (!File.Exists(path))
                return null;

            using (Image temp =
                   Image.FromFile(path))
            {
                return new Bitmap(
                    temp,
                    picElevator.Width,
                    picElevator.Height);
            }
        }

        // =========================
        // MOVEMENT TIMER
        // =========================

        private void SetupTimer()
        {
            _moveTimer =
                new System.Windows.Forms.Timer();

            _moveTimer.Interval = 10;

            _moveTimer.Tick += MoveTimer_Tick;
        }

        // =========================
        // FLOOR POSITIONS
        // =========================

        private void CalculateFloorPositions()
        {
            // Top floor
            _floor2Y = 0;

            // Bottom floor
            _floor1Y =
                pnlShaft.ClientSize.Height
                - picElevator.Height;

            if (_floor1Y < _floor2Y)
            {
                _floor1Y = _floor2Y;
            }
        }

        private void PositionCar(int floor)
        {
            CalculateFloorPositions();

            if (floor == 1)
            {
                picElevator.Top =
                    _floor1Y;
            }
            else
            {
                picElevator.Top =
                    _floor2Y;
            }

            // Keep elevator centered
            picElevator.Left =
                (pnlShaft.ClientSize.Width
                - picElevator.Width) / 2;

            _currentFloor = floor;

            UpdateDisplays();
        }

        // =========================
        // UPDATE FLOOR DISPLAY
        // =========================

        private void UpdateDisplays()
        {
            txtControlDisplay.Text =
                _currentFloor.ToString();

            if (_currentFloor == 1)
            {
                LblStatus1.Text = "●";
                LblStatus1.ForeColor =
                    Color.LimeGreen;

                lblStatus2.Text = "○";
                lblStatus2.ForeColor =
                    Color.Gray;
            }
            else
            {
                LblStatus1.Text = "○";
                LblStatus1.ForeColor =
                    Color.Gray;

                lblStatus2.Text = "●";
                lblStatus2.ForeColor =
                    Color.LimeGreen;
            }
        }

        // =========================
        // START MOVEMENT
        // =========================

        private void StartMoveToFloor(int targetFloor)
        {
            // Don't allow another movement
            // while the elevator is moving
            if (_isMoving)
                return;

            // Already on requested floor
            if (_currentFloor == targetFloor)
                return;

            CalculateFloorPositions();

            _isMoving = true;

            _startY =
                picElevator.Top;

            if (targetFloor == 1)
            {
                _targetY =
                    _floor1Y;
            }
            else
            {
                _targetY =
                    _floor2Y;
            }

            // Doors must be closed
            // before the elevator moves
            DoorsClose();

            // Small delay before movement
            System.Windows.Forms.Timer startDelay =
                new System.Windows.Forms.Timer();

            startDelay.Interval = 650;

            startDelay.Tick += (s, e) =>
            {
                startDelay.Stop();
                startDelay.Dispose();

                _moveStartTime =
                    DateTime.Now;

                _moveTimer.Start();
            };

            startDelay.Start();
        }

        // =========================
        // ELEVATOR MOVEMENT
        // =========================

        private void MoveTimer_Tick(
            object sender,
            EventArgs e)
        {
            double elapsed =
                (DateTime.Now -
                 _moveStartTime).TotalMilliseconds;

            double progress =
                elapsed / MOVE_DURATION;

            if (progress < 0)
                progress = 0;

            if (progress > 1)
                progress = 1;

            // Natural elevator movement
            double smoothProgress =
                NaturalElevatorMotion(progress);

            int newY =
                _startY +
                (int)(
                    (_targetY - _startY)
                    * smoothProgress
                );

            picElevator.Top =
                newY;

            // Movement finished
            if (progress >= 1.0)
            {
                picElevator.Top =
                    _targetY;

                _moveTimer.Stop();

                _isMoving = false;

                if (_targetY == _floor1Y)
                {
                    _currentFloor = 1;
                }
                else
                {
                    _currentFloor = 2;
                }

                UpdateDisplays();

                // Small pause after arriving
                StartDoorOpeningDelay();
            }
        }

        // =========================
        // NATURAL ELEVATOR MOTION
        // =========================

        private double NaturalElevatorMotion(double t)
        {
            /*
             * 0% - 12%
             * Gentle acceleration
             *
             * 12% - 82%
             * Smooth main movement
             *
             * 82% - 100%
             * Gentle deceleration
             */

            if (t < 0.12)
            {
                double x =
                    t / 0.12;

                double smooth =
                    x * x * (3 - 2 * x);

                return 0.12 * smooth;
            }

            if (t < 0.82)
            {
                double x =
                    (t - 0.12) / 0.70;

                return 0.12 +
                       (0.76 * x);
            }

            double y =
                (t - 0.82) / 0.18;

            double smoothStop =
                1 - Math.Pow(1 - y, 3);

            return 0.88 +
                   (0.12 * smoothStop);
        }

        // =========================
        // DELAY BEFORE OPENING
        // =========================

        private void StartDoorOpeningDelay()
        {
            System.Windows.Forms.Timer settleTimer =
                new System.Windows.Forms.Timer();

            settleTimer.Interval = 250;

            settleTimer.Tick += (s, e) =>
            {
                settleTimer.Stop();
                settleTimer.Dispose();

                DoorsOpenThenClose();
            };

            settleTimer.Start();
        }

        // =========================
        // CLOSE DOORS
        // =========================

        private void DoorsClose()
        {
            if (_imgClosed != null)
            {
                picElevator.Image =
                    _imgClosed;
            }
        }

        // =========================
        // OPEN DOORS
        // =========================

        private void DoorsOpenThenClose()
        {
            // Directly open the doors
            // No half-open stage
            if (_imgOpen != null)
            {
                picElevator.Image =
                    _imgOpen;
            }

            // Keep doors open for 3 seconds
            System.Windows.Forms.Timer openTimer =
                new System.Windows.Forms.Timer();

            openTimer.Interval = 3000;

            openTimer.Tick += (s, e) =>
            {
                openTimer.Stop();
                openTimer.Dispose();

                // Close directly
                DoorsClose();
            };

            openTimer.Start();
        }

        // =========================
        // FORM RESIZE
        // =========================

        private void MainForm_Resize(
            object sender,
            EventArgs e)
        {
            if (pnlShaft == null ||
                picElevator == null)
                return;

            if (_isMoving)
                return;

            CalculateFloorPositions();

            if (_currentFloor == 1)
            {
                picElevator.Top =
                    _floor1Y;
            }
            else
            {
                picElevator.Top =
                    _floor2Y;
            }

            picElevator.Left =
                (pnlShaft.ClientSize.Width
                - picElevator.Width) / 2;
        }

        // =========================
        // BUTTON EVENTS
        // =========================

        private void btnRequest1_Click_1(
            object sender,
            EventArgs e)
        {
            StartMoveToFloor(1);
        }

        private void btnRequest2_Click_1(
            object sender,
            EventArgs e)
        {
            StartMoveToFloor(2);
        }

        private void btnFloor1_Click_1(
            object sender,
            EventArgs e)
        {
            StartMoveToFloor(1);
        }

        private void btnFloor2_Click(
            object sender,
            EventArgs e)
        {
            StartMoveToFloor(2);
        }

        // =========================
        // UNUSED LABEL EVENTS
        // =========================

        private void lblFloor1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblFloor2_Click_1(
            object sender,
            EventArgs e)
        {
        }

        private void lblStatusCap2_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}