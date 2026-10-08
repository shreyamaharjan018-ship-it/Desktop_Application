using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace design
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int NextId = 1;
        List<Users> usersList = new List<Users>();
        private Users selectedUser;

        private void UserInfo_load(object sender, EventArgs e)
        {
            lblid.Text = NextId.ToString();

            comboBox1.Items.AddRange(
                "Nepal",
                "India",
                "China",
                "USA",
                "UK",
                "Swizerland"
            );

            dgvUserDetails.AutoGenerateColumns = true;
            dgvUserDetails.AllowUserToAddRows = false;
            dgvUserDetails.ReadOnly = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string gender;

            if (radmale.Checked)
            {
                gender = "Male";
            }
            else if (radfemale.Checked)
            {
                gender = "Female";
            }
            else if (radother.Checked)
            {
                gender = "gay/les";
            }
            else
            {
                MessageBox.Show("Please select your gender");
                return;
            }

            long contact;

            if (!long.TryParse(txtcontact.Text, out contact))
            {
                MessageBox.Show("Please enter a valid contact number");
                return;
            }

            Users users = new Users()
            {
                Id = NextId,
                Name = txtname.Text,
                Email = txtemail.Text,
                ContactNo = contact,
                Country = comboBox1.SelectedItem.ToString(),
                Gender = gender
            };

            usersList.Add(users);

            NextId++;

            dgvUserDetails.DataSource = null;
            dgvUserDetails.DataSource = usersList;

            lblid.Text = NextId.ToString();

            Clear();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            selectedUser.Name = txtname.Text;
            selectedUser.Email = txtemail.Text;
            selectedUser.ContactNo = long.Parse(txtcontact.Text);

            if (radmale.Checked)
                selectedUser.Gender = "Male";
            else if (radfemale.Checked)
                selectedUser.Gender = "Female";
            else if (radother.Checked)
                selectedUser.Gender = "gay/les";

            selectedUser.Country = comboBox1.Text;

            dgvUserDetails.DataSource = null;
            dgvUserDetails.DataSource = usersList;

            MessageBox.Show("User updated successfully!");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvUserDetails.CurrentRow == null)
            {
                MessageBox.Show("Please select a user");
                return;
            }

            int id = Convert.ToInt32(
                dgvUserDetails.CurrentRow.Cells["Id"].Value
            );

            Users user = usersList.Find(u => u.Id == id);

            if (user != null)
            {
                usersList.Remove(user);

                dgvUserDetails.DataSource = null;
                dgvUserDetails.DataSource = usersList;

                MessageBox.Show("Deleted successfully!");

                Clear();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtname.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";

            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";

            radmale.Checked = false;
            radfemale.Checked = false;
            radother.Checked = false;

            lblid.Text = NextId.ToString();
        }

        private void dgvUserDetails_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUserDetails.Rows[e.RowIndex];

                // set the selectedUser from the bound item
                selectedUser = row.DataBoundItem as Users;

                lblid.Text = row.Cells["Id"].Value.ToString();
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtcontact.Text = row.Cells["ContactNo"].Value.ToString();

                comboBox1.Text = row.Cells["Country"].Value.ToString();

                string gender = row.Cells["Gender"].Value.ToString();

                radmale.Checked = gender == "Male";
                radfemale.Checked = gender == "Female";
                radother.Checked = gender == "gay/les";
            }
        }
    }
}
