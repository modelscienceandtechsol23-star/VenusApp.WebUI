namespace VenusApp.WebUI
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.login_headerpanel = new System.Windows.Forms.Panel();
            this.lbl_venusacademy = new System.Windows.Forms.Label();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.login_bodypnl = new System.Windows.Forms.Panel();
            this.pnlLoginContainer = new System.Windows.Forms.Panel();
            this._rememberme = new System.Windows.Forms.CheckBox();
            this.lnk_lbl_registration = new System.Windows.Forms.LinkLabel();
            this.lnk_lbl_forgotpassword = new System.Windows.Forms.LinkLabel();
            this.role_cmb = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.login_headerpanel.SuspendLayout();
            this.login_bodypnl.SuspendLayout();
            this.pnlLoginContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_headerpanel
            // 
            this.login_headerpanel.BackColor = System.Drawing.Color.Teal;
            this.login_headerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_headerpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_headerpanel.Controls.Add(this.lbl_venusacademy);
            this.login_headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_headerpanel.Location = new System.Drawing.Point(0, 0);
            this.login_headerpanel.Name = "login_headerpanel";
            this.login_headerpanel.Size = new System.Drawing.Size(882, 140);
            this.login_headerpanel.TabIndex = 0;
            // 
            // lbl_venusacademy
            // 
            this.lbl_venusacademy.BackColor = System.Drawing.Color.Teal;
            this.lbl_venusacademy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_venusacademy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_venusacademy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venusacademy.ForeColor = System.Drawing.Color.White;
            this.lbl_venusacademy.Location = new System.Drawing.Point(408, 36);
            this.lbl_venusacademy.Name = "lbl_venusacademy";
            this.lbl_venusacademy.Size = new System.Drawing.Size(383, 61);
            this.lbl_venusacademy.TabIndex = 0;
            this.lbl_venusacademy.Text = "Venus Academy";
            this.lbl_venusacademy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_logIn
            // 
            this.btn_logIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_logIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logIn.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logIn.ForeColor = System.Drawing.Color.White;
            this.btn_logIn.Location = new System.Drawing.Point(286, 188);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(301, 35);
            this.btn_logIn.TabIndex = 19;
            this.btn_logIn.Text = "LogIn";
            this.btn_logIn.UseVisualStyleBackColor = false;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(593, 188);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(272, 35);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // login_bodypnl
            // 
            this.login_bodypnl.BackgroundImage = global::VenusApp.WebUI.Properties.Resources.images;
            this.login_bodypnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_bodypnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_bodypnl.Controls.Add(this.pnlLoginContainer);
            this.login_bodypnl.Controls.Add(this.lbl_login);
            this.login_bodypnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_bodypnl.Location = new System.Drawing.Point(0, 140);
            this.login_bodypnl.Name = "login_bodypnl";
            this.login_bodypnl.Size = new System.Drawing.Size(882, 413);
            this.login_bodypnl.TabIndex = 1;
            // 
            // pnlLoginContainer
            // 
            this.pnlLoginContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoginContainer.Controls.Add(this._rememberme);
            this.pnlLoginContainer.Controls.Add(this.lnk_lbl_registration);
            this.pnlLoginContainer.Controls.Add(this.lnk_lbl_forgotpassword);
            this.pnlLoginContainer.Controls.Add(this.btn_cancel);
            this.pnlLoginContainer.Controls.Add(this.btn_logIn);
            this.pnlLoginContainer.Controls.Add(this.role_cmb);
            this.pnlLoginContainer.Controls.Add(this.txt_password);
            this.pnlLoginContainer.Controls.Add(this.txt_username);
            this.pnlLoginContainer.Controls.Add(this.lbl_role);
            this.pnlLoginContainer.Controls.Add(this.lbl_password);
            this.pnlLoginContainer.Controls.Add(this.lbl_username);
            this.pnlLoginContainer.Location = new System.Drawing.Point(3, 79);
            this.pnlLoginContainer.Name = "pnlLoginContainer";
            this.pnlLoginContainer.Size = new System.Drawing.Size(877, 320);
            this.pnlLoginContainer.TabIndex = 2;
            // 
            // _rememberme
            // 
            this._rememberme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._rememberme.AutoSize = true;
            this._rememberme.BackColor = System.Drawing.Color.Teal;
            this._rememberme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._rememberme.Checked = true;
            this._rememberme.CheckState = System.Windows.Forms.CheckState.Checked;
            this._rememberme.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rememberme.ForeColor = System.Drawing.Color.White;
            this._rememberme.Location = new System.Drawing.Point(286, 290);
            this._rememberme.Name = "_rememberme";
            this._rememberme.Size = new System.Drawing.Size(160, 27);
            this._rememberme.TabIndex = 23;
            this._rememberme.Text = "Remember me!";
            this._rememberme.UseVisualStyleBackColor = false;
            // 
            // lnk_lbl_registration
            // 
            this.lnk_lbl_registration.ActiveLinkColor = System.Drawing.Color.White;
            this.lnk_lbl_registration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnk_lbl_registration.AutoSize = true;
            this.lnk_lbl_registration.BackColor = System.Drawing.Color.Teal;
            this.lnk_lbl_registration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnk_lbl_registration.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_lbl_registration.LinkColor = System.Drawing.Color.White;
            this.lnk_lbl_registration.Location = new System.Drawing.Point(580, 241);
            this.lnk_lbl_registration.Name = "lnk_lbl_registration";
            this.lnk_lbl_registration.Size = new System.Drawing.Size(124, 28);
            this.lnk_lbl_registration.TabIndex = 22;
            this.lnk_lbl_registration.TabStop = true;
            this.lnk_lbl_registration.Text = "Create New";
            this.lnk_lbl_registration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnk_lbl_registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_lbl_registration_LinkClicked);
            // 
            // lnk_lbl_forgotpassword
            // 
            this.lnk_lbl_forgotpassword.ActiveLinkColor = System.Drawing.Color.White;
            this.lnk_lbl_forgotpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnk_lbl_forgotpassword.AutoSize = true;
            this.lnk_lbl_forgotpassword.BackColor = System.Drawing.Color.Teal;
            this.lnk_lbl_forgotpassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnk_lbl_forgotpassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_lbl_forgotpassword.LinkColor = System.Drawing.Color.White;
            this.lnk_lbl_forgotpassword.Location = new System.Drawing.Point(286, 241);
            this.lnk_lbl_forgotpassword.Name = "lnk_lbl_forgotpassword";
            this.lnk_lbl_forgotpassword.Size = new System.Drawing.Size(168, 28);
            this.lnk_lbl_forgotpassword.TabIndex = 21;
            this.lnk_lbl_forgotpassword.TabStop = true;
            this.lnk_lbl_forgotpassword.Text = "forgot password";
            this.lnk_lbl_forgotpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // role_cmb
            // 
            this.role_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.role_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_cmb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_cmb.FormattingEnabled = true;
            this.role_cmb.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.role_cmb.Location = new System.Drawing.Point(286, 122);
            this.role_cmb.Name = "role_cmb";
            this.role_cmb.Size = new System.Drawing.Size(579, 34);
            this.role_cmb.TabIndex = 18;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.Location = new System.Drawing.Point(286, 68);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(579, 22);
            this.txt_password.TabIndex = 17;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.Location = new System.Drawing.Point(286, 14);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(579, 25);
            this.txt_username.TabIndex = 16;
            // 
            // lbl_role
            // 
            this.lbl_role.BackColor = System.Drawing.Color.Teal;
            this.lbl_role.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_role.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_role.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.White;
            this.lbl_role.Image = global::VenusApp.WebUI.Properties.Resources.images;
            this.lbl_role.Location = new System.Drawing.Point(30, 130);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(143, 26);
            this.lbl_role.TabIndex = 15;
            this.lbl_role.Text = "Role";
            this.lbl_role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_password
            // 
            this.lbl_password.BackColor = System.Drawing.Color.Teal;
            this.lbl_password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_password.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Image = global::VenusApp.WebUI.Properties.Resources.images;
            this.lbl_password.Location = new System.Drawing.Point(30, 68);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(143, 26);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            this.lbl_username.BackColor = System.Drawing.Color.Teal;
            this.lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_username.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Image = global::VenusApp.WebUI.Properties.Resources.images;
            this.lbl_username.Location = new System.Drawing.Point(30, 14);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(143, 25);
            this.lbl_username.TabIndex = 13;
            this.lbl_username.Text = "User Name";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_login
            // 
            this.lbl_login.BackColor = System.Drawing.Color.Teal;
            this.lbl_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_login.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(443, 17);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(160, 50);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "LogIn";
            this.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInForm
            // 
            this.AcceptButton = this.btn_logIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.login_bodypnl);
            this.Controls.Add(this.login_headerpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "LogInForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venus Academy";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.login_headerpanel.ResumeLayout(false);
            this.login_bodypnl.ResumeLayout(false);
            this.pnlLoginContainer.ResumeLayout(false);
            this.pnlLoginContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel login_headerpanel;
        private System.Windows.Forms.Label lbl_venusacademy;
        public System.Windows.Forms.Panel login_bodypnl;
        private System.Windows.Forms.Panel pnlLoginContainer;
        private System.Windows.Forms.CheckBox _rememberme;
        public System.Windows.Forms.LinkLabel lnk_lbl_registration;
        public System.Windows.Forms.LinkLabel lnk_lbl_forgotpassword;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_logIn;
        public System.Windows.Forms.ComboBox role_cmb;
        public System.Windows.Forms.TextBox txt_password;
        public System.Windows.Forms.TextBox txt_username;
        public System.Windows.Forms.Label lbl_role;
        public System.Windows.Forms.Label lbl_password;
        public System.Windows.Forms.Label lbl_username;
        public System.Windows.Forms.Label lbl_login;
    }
}

