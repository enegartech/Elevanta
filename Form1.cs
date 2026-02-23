using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ElevantaApp
{
    public partial class AddUserForm : Form
    {
        private List<User> users = new List<User>();
        private User selectedUser = null;
        public AddUserForm()
        {
            InitializeComponent();
            LoadFromFile();
        }

        private void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter("users.txt"))
            {
                foreach (User user in users)
                {
                    writer.WriteLine($"{user.Name},{user.Email}");
                }
            }
        }

        private void LoadFromFile()
        {
            if (File.Exists("users.txt"))
            {
                string[] lines = File.ReadAllLines("users.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    User user = new User(parts[0], parts[1]);
                    users.Add(user);
                    userListBox.Items.Add(user);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(taskTextBox.Text))
            {
                taskListBox.Items.Add(taskTextBox.Text);
                taskTextBox.Clear();
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                taskListBox.Items.Remove(taskListBox.SelectedItem);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Validate email format
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            // Detect Edit or Add mode
            if (userListBox.SelectedItem != null)
            {
                // Edit mode
                User selectedUser = (User)userListBox.SelectedItem;

                // Check for duplicate email (excluding the current user)
                if (users.Any(u => u.Email.ToLower() == email.ToLower() && u != selectedUser))
                {
                    MessageBox.Show("This email is already registered.");
                    return;
                }

                // Apply changes
                selectedUser.Name = name;
                selectedUser.Email = email;

                // Update ListBox
                int selectedIndex = userListBox.SelectedIndex;
                userListBox.Items[selectedIndex] = selectedUser;

                MessageBox.Show("Changes saved successfully.");
            }
            else
            {
                // Add mode
                if (users.Any(u => u.Email.ToLower() == email.ToLower()))
                {
                    MessageBox.Show("This email is already registered.");
                    return;
                }

                // Create new user
                User newUser = new User(name, email);
                users.Add(newUser);

                // Add to ListBox
                userListBox.Items.Add(newUser);

                MessageBox.Show("User added successfully.");
            }

            // Clear textboxes and deselect ListBox
            txtName.Clear();
            txtEmail.Clear();
            userListBox.ClearSelected();

            // Save to file
            SaveToFile();

        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userListBox.SelectedIndex != -1)
            {
                User selectedUser = users[userListBox.SelectedIndex];

                txtName.Text = selectedUser.Name;
                txtEmail.Text = selectedUser.Email;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userListBox.SelectedItem != null && userListBox.SelectedItem is User selectedUser)
            {
                users.Remove(selectedUser);
                userListBox.Items.Remove(selectedUser);
                SaveToFile();
            }
            else
            {
                MessageBox.Show("Please select a valid user to delete.");
            }
        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

