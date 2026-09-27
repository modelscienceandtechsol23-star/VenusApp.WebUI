namespace VenusApp.WebUI
{
    partial class ParentDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentDashBoard));
            this.headerpanel = new System.Windows.Forms.Panel();
            this.login_headerpanel = new System.Windows.Forms.Panel();
            this.lblUserSession = new System.Windows.Forms.Label();
            this.lbl_venusacademy = new System.Windows.Forms.Label();
            this.sitedasboardpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_studnt = new System.Windows.Forms.Button();
            this.btn_subject = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.btn_attendence = new System.Windows.Forms.Button();
            this.btn_enrollment = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.body_panel = new System.Windows.Forms.Panel();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.headerpanel.SuspendLayout();
            this.login_headerpanel.SuspendLayout();
            this.sitedasboardpanel.SuspendLayout();
            this.body_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.Teal;
            this.headerpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerpanel.Controls.Add(this.login_headerpanel);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1659, 104);
            this.headerpanel.TabIndex = 0;
            // 
            // login_headerpanel
            // 
            this.login_headerpanel.BackColor = System.Drawing.Color.Teal;
            this.login_headerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_headerpanel.Controls.Add(this.lblUserSession);
            this.login_headerpanel.Controls.Add(this.lbl_venusacademy);
            this.login_headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_headerpanel.Location = new System.Drawing.Point(0, 0);
            this.login_headerpanel.Margin = new System.Windows.Forms.Padding(4);
            this.login_headerpanel.Name = "login_headerpanel";
            this.login_headerpanel.Size = new System.Drawing.Size(1655, 102);
            this.login_headerpanel.TabIndex = 2;
            // 
            // lblUserSession
            // 
            this.lblUserSession.AutoSize = true;
            this.lblUserSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserSession.ForeColor = System.Drawing.Color.White;
            this.lblUserSession.Location = new System.Drawing.Point(1161, 10);
            this.lblUserSession.Name = "lblUserSession";
            this.lblUserSession.Size = new System.Drawing.Size(0, 18);
            this.lblUserSession.TabIndex = 2;
            // 
            // lbl_venusacademy
            // 
            this.lbl_venusacademy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_venusacademy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_venusacademy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_venusacademy.ForeColor = System.Drawing.Color.White;
            this.lbl_venusacademy.Location = new System.Drawing.Point(703, -18);
            this.lbl_venusacademy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_venusacademy.Name = "lbl_venusacademy";
            this.lbl_venusacademy.Size = new System.Drawing.Size(487, 77);
            this.lbl_venusacademy.TabIndex = 0;
            this.lbl_venusacademy.Text = "Venus Academy";
            this.lbl_venusacademy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sitedasboardpanel
            // 
            this.sitedasboardpanel.BackColor = System.Drawing.Color.Teal;
            this.sitedasboardpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sitedasboardpanel.Controls.Add(this.btn_studnt);
            this.sitedasboardpanel.Controls.Add(this.btn_subject);
            this.sitedasboardpanel.Controls.Add(this.btn_teacher);
            this.sitedasboardpanel.Controls.Add(this.btn_attendence);
            this.sitedasboardpanel.Controls.Add(this.btn_enrollment);
            this.sitedasboardpanel.Controls.Add(this.btn_dashboard);
            this.sitedasboardpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sitedasboardpanel.Location = new System.Drawing.Point(0, 104);
            this.sitedasboardpanel.Name = "sitedasboardpanel";
            this.sitedasboardpanel.Size = new System.Drawing.Size(219, 648);
            this.sitedasboardpanel.TabIndex = 0;
            // 
            // btn_studnt
            // 
            this.btn_studnt.AllowDrop = true;
            this.btn_studnt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_studnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_studnt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_studnt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studnt.ForeColor = System.Drawing.Color.White;
            this.btn_studnt.Location = new System.Drawing.Point(3, 3);
            this.btn_studnt.Name = "btn_studnt";
            this.btn_studnt.Size = new System.Drawing.Size(216, 40);
            this.btn_studnt.TabIndex = 0;
            this.btn_studnt.Text = "Student";
            this.btn_studnt.UseVisualStyleBackColor = false;
            this.btn_studnt.Click += new System.EventHandler(this.btn_studnt_Click);
            // 
            // btn_subject
            // 
            this.btn_subject.AllowDrop = true;
            this.btn_subject.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_subject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_subject.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subject.ForeColor = System.Drawing.Color.White;
            this.btn_subject.Location = new System.Drawing.Point(3, 49);
            this.btn_subject.Name = "btn_subject";
            this.btn_subject.Size = new System.Drawing.Size(216, 40);
            this.btn_subject.TabIndex = 1;
            this.btn_subject.Text = "Subject";
            this.btn_subject.UseVisualStyleBackColor = false;
            // 
            // btn_teacher
            // 
            this.btn_teacher.AllowDrop = true;
            this.btn_teacher.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_teacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_teacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_teacher.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher.ForeColor = System.Drawing.Color.White;
            this.btn_teacher.Location = new System.Drawing.Point(3, 95);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(216, 40);
            this.btn_teacher.TabIndex = 2;
            this.btn_teacher.Text = "Teacher";
            this.btn_teacher.UseVisualStyleBackColor = false;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // btn_attendence
            // 
            this.btn_attendence.AllowDrop = true;
            this.btn_attendence.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_attendence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_attendence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_attendence.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendence.ForeColor = System.Drawing.Color.White;
            this.btn_attendence.Location = new System.Drawing.Point(3, 141);
            this.btn_attendence.Name = "btn_attendence";
            this.btn_attendence.Size = new System.Drawing.Size(216, 40);
            this.btn_attendence.TabIndex = 4;
            this.btn_attendence.Text = "Attendence";
            this.btn_attendence.UseVisualStyleBackColor = false;
            // 
            // btn_enrollment
            // 
            this.btn_enrollment.AllowDrop = true;
            this.btn_enrollment.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_enrollment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enrollment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_enrollment.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enrollment.ForeColor = System.Drawing.Color.White;
            this.btn_enrollment.Location = new System.Drawing.Point(3, 187);
            this.btn_enrollment.Name = "btn_enrollment";
            this.btn_enrollment.Size = new System.Drawing.Size(216, 40);
            this.btn_enrollment.TabIndex = 5;
            this.btn_enrollment.Text = "Enrollment";
            this.btn_enrollment.UseVisualStyleBackColor = false;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.AllowDrop = true;
            this.btn_dashboard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Location = new System.Drawing.Point(3, 233);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(216, 40);
            this.btn_dashboard.TabIndex = 6;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            // 
            // body_panel
            // 
            this.body_panel.BackColor = System.Drawing.Color.Teal;
            this.body_panel.BackgroundImage = global::VenusApp.WebUI.Properties.Resources.classroom;
            this.body_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.body_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.body_panel.Controls.Add(this.lbl_dashboard);
            this.body_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_panel.Location = new System.Drawing.Point(219, 104);
            this.body_panel.Name = "body_panel";
            this.body_panel.Size = new System.Drawing.Size(1440, 648);
            this.body_panel.TabIndex = 1;
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.BackColor = System.Drawing.Color.Black;
            this.lbl_dashboard.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dashboard.ForeColor = System.Drawing.Color.White;
            this.lbl_dashboard.Location = new System.Drawing.Point(371, 7);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(278, 46);
            this.lbl_dashboard.TabIndex = 1;
            this.lbl_dashboard.Text = "DASH BOARD";
            // 
            // ParentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1659, 752);
            this.Controls.Add(this.body_panel);
            this.Controls.Add(this.sitedasboardpanel);
            this.Controls.Add(this.headerpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParentDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venus Academy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.headerpanel.ResumeLayout(false);
            this.login_headerpanel.ResumeLayout(false);
            this.login_headerpanel.PerformLayout();
            this.sitedasboardpanel.ResumeLayout(false);
            this.body_panel.ResumeLayout(false);
            this.body_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel headerpanel;
        public System.Windows.Forms.FlowLayoutPanel sitedasboardpanel;
        public System.Windows.Forms.Panel body_panel;
        public System.Windows.Forms.Button btn_studnt;
        public System.Windows.Forms.Panel login_headerpanel;
        private System.Windows.Forms.Label lbl_venusacademy;
        public System.Windows.Forms.Button btn_subject;
        public System.Windows.Forms.Button btn_teacher;
        public System.Windows.Forms.Button btn_attendence;
        public System.Windows.Forms.Button btn_enrollment;
        public System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Label lblUserSession;
        public System.Windows.Forms.Label lbl_dashboard;
    }
}