namespace project
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            usernameTextBox = new TextBox();
            textBox1 = new TextBox();
            m2 = new TextBox();
            m = new TextBox();
            txtPassword = new Label();
            txtConfirmPassword = new Label();
            txtUsername = new Label();
            txtEmail = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(210, 9);
            label4.Name = "label4";
            label4.Size = new Size(175, 30);
            label4.TabIndex = 8;
            label4.Text = "Creat Account";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(184, 127);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(244, 23);
            usernameTextBox.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 10;
            // 
            // m2
            // 
            m2.Location = new Point(184, 235);
            m2.Name = "m2";
            m2.PasswordChar = '*';
            m2.Size = new Size(244, 23);
            m2.TabIndex = 11;
            // 
            // m
            // 
            m.Location = new Point(184, 182);
            m.Name = "m";
            m.PasswordChar = '*';
            m.Size = new Size(244, 23);
            m.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(37, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(95, 24);
            txtPassword.TabIndex = 13;
            txtPassword.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.AutoSize = true;
            txtConfirmPassword.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(12, 235);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(166, 24);
            txtConfirmPassword.TabIndex = 14;
            txtConfirmPassword.Text = "Confim Password";
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(37, 123);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(102, 24);
            txtUsername.TabIndex = 15;
            txtUsername.Text = "Username";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(59, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(64, 26);
            txtEmail.TabIndex = 16;
            txtEmail.Text = "Email";
            txtEmail.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(244, 285);
            button1.Name = "button1";
            button1.Size = new Size(113, 30);
            button1.TabIndex = 17;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(531, 327);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(m);
            Controls.Add(m2);
            Controls.Add(textBox1);
            Controls.Add(usernameTextBox);
            Controls.Add(label4);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox usernameTextBox;
        private TextBox textBox1;
        private TextBox m2;
        private TextBox m;
        private Label txtPassword;
        private Label txtConfirmPassword;
        private Label txtUsername;
        private Label txtEmail;
        private Button button1;
    }
}