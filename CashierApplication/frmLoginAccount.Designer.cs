namespace CashierApplication
{
    partial class frmLoginAccount
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
            lblUsername = new Label();
            lblTitle = new Label();
            lblPass = new Label();
            userNameTxtbox = new TextBox();
            passTxtbox = new TextBox();
            logInBtn = new Button();
            showPassCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(54, 95);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(117, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(129, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Good Day Cashier!";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(54, 178);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(112, 28);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password: ";
            // 
            // userNameTxtbox
            // 
            userNameTxtbox.Font = new Font("Segoe UI", 12F);
            userNameTxtbox.Location = new Point(54, 126);
            userNameTxtbox.Name = "userNameTxtbox";
            userNameTxtbox.Size = new Size(377, 34);
            userNameTxtbox.TabIndex = 3;
            // 
            // passTxtbox
            // 
            passTxtbox.Font = new Font("Segoe UI", 12F);
            passTxtbox.Location = new Point(54, 209);
            passTxtbox.Name = "passTxtbox";
            passTxtbox.Size = new Size(377, 34);
            passTxtbox.TabIndex = 4;
            passTxtbox.UseSystemPasswordChar = true;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.Crimson;
            logInBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInBtn.Location = new Point(168, 277);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(140, 49);
            logInBtn.TabIndex = 5;
            logInBtn.Text = "Login";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // showPassCheckbox
            // 
            showPassCheckbox.AutoSize = true;
            showPassCheckbox.Font = new Font("Segoe UI", 10F);
            showPassCheckbox.Location = new Point(284, 244);
            showPassCheckbox.Name = "showPassCheckbox";
            showPassCheckbox.Size = new Size(147, 27);
            showPassCheckbox.TabIndex = 6;
            showPassCheckbox.Text = "show password";
            showPassCheckbox.UseVisualStyleBackColor = true;
            showPassCheckbox.CheckedChanged += showPassCheckbox_CheckedChanged;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(495, 360);
            Controls.Add(showPassCheckbox);
            Controls.Add(logInBtn);
            Controls.Add(passTxtbox);
            Controls.Add(userNameTxtbox);
            Controls.Add(lblPass);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Name = "frmLoginAccount";
            Text = "User Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblTitle;
        private Label lblPass;
        private TextBox userNameTxtbox;
        private TextBox passTxtbox;
        private Button logInBtn;
        private CheckBox showPassCheckbox;
    }
}