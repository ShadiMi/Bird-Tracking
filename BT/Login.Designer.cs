namespace Final_Project_205674047_208078212
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            usernameTbox = new TextBox();
            passwordTbox = new TextBox();
            loginLabel = new Label();
            loginMsgLabel = new Label();
            confirmBtn = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            registerLabel = new Label();
            signupLabel = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            closeBtn = new Button();
            panel3 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameTbox
            // 
            usernameTbox.BorderStyle = BorderStyle.None;
            usernameTbox.Cursor = Cursors.IBeam;
            usernameTbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTbox.ForeColor = Color.FromArgb(41, 128, 185);
            usernameTbox.Location = new Point(59, 12);
            usernameTbox.Name = "usernameTbox";
            usernameTbox.PlaceholderText = "Username";
            usernameTbox.Size = new Size(283, 20);
            usernameTbox.TabIndex = 0;
            // 
            // passwordTbox
            // 
            passwordTbox.BorderStyle = BorderStyle.None;
            passwordTbox.Cursor = Cursors.IBeam;
            passwordTbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTbox.Location = new Point(59, 12);
            passwordTbox.Name = "passwordTbox";
            passwordTbox.PlaceholderText = "Password";
            passwordTbox.Size = new Size(274, 20);
            passwordTbox.TabIndex = 1;
            passwordTbox.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(40, 130, 190);
            loginLabel.Location = new Point(6, 118);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(320, 40);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Login to your account";
            // 
            // loginMsgLabel
            // 
            loginMsgLabel.AutoSize = true;
            loginMsgLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginMsgLabel.Location = new Point(68, 10);
            loginMsgLabel.Name = "loginMsgLabel";
            loginMsgLabel.Size = new Size(252, 21);
            loginMsgLabel.TabIndex = 3;
            loginMsgLabel.Text = "Sign in to your existing account";
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.FromArgb(40, 130, 190);
            confirmBtn.Cursor = Cursors.Hand;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmBtn.ForeColor = Color.LightGray;
            confirmBtn.Location = new Point(37, 34);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(304, 63);
            confirmBtn.TabIndex = 4;
            confirmBtn.Text = "LOGIN";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(loginLabel);
            panel1.Location = new Point(300, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 530);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // panel6
            // 
            panel6.Controls.Add(registerLabel);
            panel6.Controls.Add(signupLabel);
            panel6.Location = new Point(71, 431);
            panel6.Name = "panel6";
            panel6.Size = new Size(201, 38);
            panel6.TabIndex = 12;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Cursor = Cursors.Hand;
            registerLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            registerLabel.ForeColor = Color.IndianRed;
            registerLabel.Location = new Point(140, 11);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(53, 15);
            registerLabel.TabIndex = 11;
            registerLabel.Text = "Register!";
            registerLabel.Click += registerLabel_Click;
            // 
            // signupLabel
            // 
            signupLabel.AutoSize = true;
            signupLabel.Location = new Point(3, 11);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(131, 15);
            signupLabel.TabIndex = 10;
            signupLabel.Text = "Don't have an account?";
            // 
            // panel2
            // 
            panel2.Controls.Add(confirmBtn);
            panel2.Controls.Add(loginMsgLabel);
            panel2.Location = new Point(34, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 100);
            panel2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(192, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 72);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(passwordTbox);
            panel5.Location = new Point(3, 243);
            panel5.Name = "panel5";
            panel5.Size = new Size(472, 43);
            panel5.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(usernameTbox);
            panel4.Location = new Point(3, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(472, 43);
            panel4.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.RosyBrown;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatAppearance.MouseOverBackColor = Color.White;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.ForeColor = Color.FromArgb(40, 130, 190);
            closeBtn.Location = new Point(436, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(40, 40);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 130, 190);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 530);
            panel3.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(738, 32);
            panel7.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 297);
            label2.Name = "label2";
            label2.Size = new Size(276, 23);
            label2.TabIndex = 2;
            label2.Text = "Birds Tracking&&Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 263);
            label1.Name = "label1";
            label1.Size = new Size(155, 23);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 530);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernameTbox;
        private TextBox passwordTbox;
        private Label loginLabel;
        private Label loginMsgLabel;
        private Button confirmBtn;
        private Panel panel1;
        private Button closeBtn;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Label signupLabel;
        private Panel panel2;
        private Label registerLabel;
        private Panel panel7;
    }
}