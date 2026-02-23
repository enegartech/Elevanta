namespace ElevantaApp
{
    partial class AddUserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskListBox = new ListBox();
            taskTextBox = new TextBox();
            addButton = new Button();
            completeButton = new Button();
            lblName = new Label();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            userListBox = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // taskListBox
            // 
            taskListBox.BackColor = Color.Honeydew;
            taskListBox.FormattingEnabled = true;
            taskListBox.Location = new Point(287, 12);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(219, 184);
            taskListBox.TabIndex = 0;
            taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;
            // 
            // taskTextBox
            // 
            taskTextBox.BackColor = Color.Honeydew;
            taskTextBox.Location = new Point(287, 202);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(219, 27);
            taskTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.BackColor = Color.DarkSlateGray;
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(287, 235);
            addButton.Name = "addButton";
            addButton.Size = new Size(87, 29);
            addButton.TabIndex = 2;
            addButton.Text = "Add Task";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += button1_Click;
            // 
            // completeButton
            // 
            completeButton.BackColor = Color.DarkSlateGray;
            completeButton.ForeColor = Color.White;
            completeButton.Location = new Point(389, 235);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(117, 29);
            completeButton.TabIndex = 3;
            completeButton.Text = "Complete Task";
            completeButton.UseVisualStyleBackColor = false;
            completeButton.Click += completeButton_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Honeydew;
            txtName.Location = new Point(67, 9);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 27);
            txtName.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(13, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Honeydew;
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(67, 58);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSlateGray;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(129, 96);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // userListBox
            // 
            userListBox.BackColor = Color.Honeydew;
            userListBox.FormattingEnabled = true;
            userListBox.Location = new Point(12, 140);
            userListBox.Name = "userListBox";
            userListBox.Size = new Size(217, 124);
            userListBox.TabIndex = 9;
            userListBox.SelectedIndexChanged += userListBox_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(13, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(userListBox);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(completeButton);
            Controls.Add(addButton);
            Controls.Add(taskTextBox);
            Controls.Add(taskListBox);
            Name = "AddUserForm";
            Text = "Add New User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox taskListBox;
        private TextBox taskTextBox;
        private Button addButton;
        private Button completeButton;
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSave;
        private ListBox userListBox;
        private Button btnDelete;
    }
}
