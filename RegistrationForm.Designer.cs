namespace VenusApp.WebUI
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.login_headerpanel = new System.Windows.Forms.Panel();
            this.lbl_venusacademy = new System.Windows.Forms.Label();
            this.registration_bodypnl = new System.Windows.Forms.Panel();
            this.formHostPanel = new System.Windows.Forms.Panel();
            this.tbl_userRegistration_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.middlename_lbl = new System.Windows.Forms.Label();
            this.middlename_txt = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.dob_picker = new System.Windows.Forms.DateTimePicker();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.gender_cmb = new System.Windows.Forms.ComboBox();
            this.lbl_cnic = new System.Windows.Forms.Label();
            this.cnic_txt = new System.Windows.Forms.MaskedTextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.MaskedTextBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.role_cmb = new System.Windows.Forms.ComboBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.lbl_confirmPassword = new System.Windows.Forms.Label();
            this.confirmPassword_txt = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.registration_panel = new System.Windows.Forms.Panel();
            this.lbl_registrations = new System.Windows.Forms.Label();
            this.login_headerpanel.SuspendLayout();
            this.registration_bodypnl.SuspendLayout();
            this.formHostPanel.SuspendLayout();
            this.tbl_userRegistration_pnl.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.registration_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_headerpanel
            // 
            this.login_headerpanel.BackColor = System.Drawing.Color.Teal;
            this.login_headerpanel.Controls.Add(this.lbl_venusacademy);
            this.login_headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_headerpanel.Location = new System.Drawing.Point(0, 0);
            this.login_headerpanel.Margin = new System.Windows.Forms.Padding(4);
            this.login_headerpanel.Name = "login_headerpanel";
            this.login_headerpanel.Size = new System.Drawing.Size(1609, 138);
            this.login_headerpanel.TabIndex = 1;
            // 
            // lbl_venusacademy
            // 
            this.lbl_venusacademy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_venusacademy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_venusacademy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_venusacademy.ForeColor = System.Drawing.Color.White;
            this.lbl_venusacademy.Location = new System.Drawing.Point(680, 0);
            this.lbl_venusacademy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_venusacademy.Name = "lbl_venusacademy";
            this.lbl_venusacademy.Size = new System.Drawing.Size(487, 77);
            this.lbl_venusacademy.TabIndex = 0;
            this.lbl_venusacademy.Text = "Venus Academy";
            this.lbl_venusacademy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registration_bodypnl
            // 
            this.registration_bodypnl.BackgroundImage = global::VenusApp.WebUI.Properties.Resources.images;
            this.registration_bodypnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registration_bodypnl.Controls.Add(this.formHostPanel);
            this.registration_bodypnl.Controls.Add(this.registration_panel);
            this.registration_bodypnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registration_bodypnl.Location = new System.Drawing.Point(0, 138);
            this.registration_bodypnl.Margin = new System.Windows.Forms.Padding(4);
            this.registration_bodypnl.Name = "registration_bodypnl";
            this.registration_bodypnl.Size = new System.Drawing.Size(1609, 738);
            this.registration_bodypnl.TabIndex = 0;
            // 
            // formHostPanel
            // 
            this.formHostPanel.AutoScroll = true;
            this.formHostPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.formHostPanel.Controls.Add(this.tbl_userRegistration_pnl);
            this.formHostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formHostPanel.Location = new System.Drawing.Point(0, 98);
            this.formHostPanel.Margin = new System.Windows.Forms.Padding(4);
            this.formHostPanel.Name = "formHostPanel";
            this.formHostPanel.Padding = new System.Windows.Forms.Padding(38, 28, 38, 28);
            this.formHostPanel.Size = new System.Drawing.Size(1609, 640);
            this.formHostPanel.TabIndex = 0;
            // 
            // tbl_userRegistration_pnl
            // 
            this.tbl_userRegistration_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbl_userRegistration_pnl.BackgroundImage = global::VenusApp.WebUI.Properties.Resources.images;
            this.tbl_userRegistration_pnl.ColumnCount = 4;
            this.tbl_userRegistration_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbl_userRegistration_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tbl_userRegistration_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbl_userRegistration_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_firstname, 0, 0);
            this.tbl_userRegistration_pnl.Controls.Add(this.firstname_txt, 1, 0);
            this.tbl_userRegistration_pnl.Controls.Add(this.middlename_lbl, 2, 0);
            this.tbl_userRegistration_pnl.Controls.Add(this.middlename_txt, 3, 0);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_lastname, 0, 1);
            this.tbl_userRegistration_pnl.Controls.Add(this.lastname_txt, 1, 1);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_dob, 2, 1);
            this.tbl_userRegistration_pnl.Controls.Add(this.dob_picker, 3, 1);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_gender, 0, 2);
            this.tbl_userRegistration_pnl.Controls.Add(this.gender_cmb, 1, 2);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_cnic, 2, 2);
            this.tbl_userRegistration_pnl.Controls.Add(this.cnic_txt, 3, 2);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_email, 0, 3);
            this.tbl_userRegistration_pnl.Controls.Add(this.email_txt, 1, 3);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_phone, 2, 3);
            this.tbl_userRegistration_pnl.Controls.Add(this.phone_txt, 3, 3);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_role, 0, 4);
            this.tbl_userRegistration_pnl.Controls.Add(this.role_cmb, 1, 4);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_username, 2, 4);
            this.tbl_userRegistration_pnl.Controls.Add(this.username_txt, 3, 4);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_password, 0, 5);
            this.tbl_userRegistration_pnl.Controls.Add(this.password_txt, 1, 5);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_confirmPassword, 2, 5);
            this.tbl_userRegistration_pnl.Controls.Add(this.confirmPassword_txt, 3, 5);
            this.tbl_userRegistration_pnl.Controls.Add(this.lbl_address, 0, 6);
            this.tbl_userRegistration_pnl.Controls.Add(this.address_txt, 1, 6);
            this.tbl_userRegistration_pnl.Controls.Add(this.buttonPanel, 0, 7);
            this.tbl_userRegistration_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_userRegistration_pnl.Location = new System.Drawing.Point(38, 28);
            this.tbl_userRegistration_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.tbl_userRegistration_pnl.MinimumSize = new System.Drawing.Size(950, 662);
            this.tbl_userRegistration_pnl.Name = "tbl_userRegistration_pnl";
            this.tbl_userRegistration_pnl.Padding = new System.Windows.Forms.Padding(22);
            this.tbl_userRegistration_pnl.RowCount = 8;
            this.tbl_userRegistration_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tbl_userRegistration_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tbl_userRegistration_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tbl_userRegistration_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tbl_userRegistration_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tbl_userRegistration_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tbl_userRegistration_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tbl_userRegistration_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tbl_userRegistration_pnl.Size = new System.Drawing.Size(1533, 662);
            this.tbl_userRegistration_pnl.TabIndex = 0;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.BackColor = System.Drawing.Color.Teal;
            this.lbl_firstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_firstname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_firstname.ForeColor = System.Drawing.Color.White;
            this.lbl_firstname.Location = new System.Drawing.Point(27, 27);
            this.lbl_firstname.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_firstname.Size = new System.Drawing.Size(258, 62);
            this.lbl_firstname.TabIndex = 0;
            this.lbl_firstname.Text = "First Name *";
            this.lbl_firstname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstname_txt
            // 
            this.firstname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstname_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.firstname_txt.Location = new System.Drawing.Point(300, 34);
            this.firstname_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(456, 32);
            this.firstname_txt.TabIndex = 0;
            // 
            // middlename_lbl
            // 
            this.middlename_lbl.BackColor = System.Drawing.Color.Teal;
            this.middlename_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlename_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.middlename_lbl.ForeColor = System.Drawing.Color.White;
            this.middlename_lbl.Location = new System.Drawing.Point(771, 27);
            this.middlename_lbl.Margin = new System.Windows.Forms.Padding(5);
            this.middlename_lbl.Name = "middlename_lbl";
            this.middlename_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.middlename_lbl.Size = new System.Drawing.Size(258, 62);
            this.middlename_lbl.TabIndex = 1;
            this.middlename_lbl.Text = "Middle Name";
            this.middlename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // middlename_txt
            // 
            this.middlename_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlename_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.middlename_txt.Location = new System.Drawing.Point(1044, 34);
            this.middlename_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.middlename_txt.Name = "middlename_txt";
            this.middlename_txt.Size = new System.Drawing.Size(457, 32);
            this.middlename_txt.TabIndex = 1;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.BackColor = System.Drawing.Color.Teal;
            this.lbl_lastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_lastname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_lastname.ForeColor = System.Drawing.Color.White;
            this.lbl_lastname.Location = new System.Drawing.Point(27, 99);
            this.lbl_lastname.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_lastname.Size = new System.Drawing.Size(258, 62);
            this.lbl_lastname.TabIndex = 2;
            this.lbl_lastname.Text = "Last Name *";
            this.lbl_lastname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastname_txt
            // 
            this.lastname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastname_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lastname_txt.Location = new System.Drawing.Point(300, 106);
            this.lastname_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(456, 32);
            this.lastname_txt.TabIndex = 2;
            // 
            // lbl_dob
            // 
            this.lbl_dob.BackColor = System.Drawing.Color.Teal;
            this.lbl_dob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dob.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_dob.ForeColor = System.Drawing.Color.White;
            this.lbl_dob.Location = new System.Drawing.Point(771, 99);
            this.lbl_dob.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_dob.Size = new System.Drawing.Size(258, 62);
            this.lbl_dob.TabIndex = 3;
            this.lbl_dob.Text = "Date of Birth *";
            this.lbl_dob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dob_picker
            // 
            this.dob_picker.Checked = false;
            this.dob_picker.CustomFormat = "dd MMMM yyyy";
            this.dob_picker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dob_picker.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dob_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob_picker.Location = new System.Drawing.Point(1044, 106);
            this.dob_picker.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.dob_picker.Name = "dob_picker";
            this.dob_picker.ShowCheckBox = true;
            this.dob_picker.Size = new System.Drawing.Size(457, 32);
            this.dob_picker.TabIndex = 3;
            // 
            // lbl_gender
            // 
            this.lbl_gender.BackColor = System.Drawing.Color.Teal;
            this.lbl_gender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(27, 171);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_gender.Size = new System.Drawing.Size(258, 62);
            this.lbl_gender.TabIndex = 4;
            this.lbl_gender.Text = "Gender *";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gender_cmb
            // 
            this.gender_cmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gender_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_cmb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gender_cmb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gender_cmb.Location = new System.Drawing.Point(300, 178);
            this.gender_cmb.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.gender_cmb.Name = "gender_cmb";
            this.gender_cmb.Size = new System.Drawing.Size(456, 33);
            this.gender_cmb.TabIndex = 4;
            // 
            // lbl_cnic
            // 
            this.lbl_cnic.BackColor = System.Drawing.Color.Teal;
            this.lbl_cnic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cnic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_cnic.ForeColor = System.Drawing.Color.White;
            this.lbl_cnic.Location = new System.Drawing.Point(771, 171);
            this.lbl_cnic.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_cnic.Name = "lbl_cnic";
            this.lbl_cnic.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_cnic.Size = new System.Drawing.Size(258, 62);
            this.lbl_cnic.TabIndex = 5;
            this.lbl_cnic.Text = "CNIC";
            this.lbl_cnic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cnic_txt
            // 
            this.cnic_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnic_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cnic_txt.Location = new System.Drawing.Point(1044, 178);
            this.cnic_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.cnic_txt.Mask = "00000-0000000-0";
            this.cnic_txt.Name = "cnic_txt";
            this.cnic_txt.Size = new System.Drawing.Size(457, 32);
            this.cnic_txt.TabIndex = 5;
            // 
            // lbl_email
            // 
            this.lbl_email.BackColor = System.Drawing.Color.Teal;
            this.lbl_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(27, 243);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_email.Size = new System.Drawing.Size(258, 62);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email *";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // email_txt
            // 
            this.email_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.email_txt.Location = new System.Drawing.Point(300, 250);
            this.email_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(456, 32);
            this.email_txt.TabIndex = 6;
            // 
            // lbl_phone
            // 
            this.lbl_phone.BackColor = System.Drawing.Color.Teal;
            this.lbl_phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_phone.ForeColor = System.Drawing.Color.White;
            this.lbl_phone.Location = new System.Drawing.Point(771, 243);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_phone.Size = new System.Drawing.Size(258, 62);
            this.lbl_phone.TabIndex = 7;
            this.lbl_phone.Text = "Mobile Number *";
            this.lbl_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone_txt
            // 
            this.phone_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phone_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.phone_txt.Location = new System.Drawing.Point(1044, 250);
            this.phone_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.phone_txt.Mask = "0000-0000000";
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(457, 32);
            this.phone_txt.TabIndex = 7;
            // 
            // lbl_role
            // 
            this.lbl_role.BackColor = System.Drawing.Color.Teal;
            this.lbl_role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_role.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_role.ForeColor = System.Drawing.Color.White;
            this.lbl_role.Location = new System.Drawing.Point(27, 315);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_role.Size = new System.Drawing.Size(258, 62);
            this.lbl_role.TabIndex = 8;
            this.lbl_role.Text = "Role *";
            this.lbl_role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // role_cmb
            // 
            this.role_cmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.role_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_cmb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.role_cmb.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.role_cmb.Location = new System.Drawing.Point(300, 322);
            this.role_cmb.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.role_cmb.Name = "role_cmb";
            this.role_cmb.Size = new System.Drawing.Size(456, 33);
            this.role_cmb.TabIndex = 8;
            // 
            // lbl_username
            // 
            this.lbl_username.BackColor = System.Drawing.Color.Teal;
            this.lbl_username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(771, 315);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_username.Size = new System.Drawing.Size(258, 62);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "Username *";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // username_txt
            // 
            this.username_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.username_txt.Location = new System.Drawing.Point(1044, 322);
            this.username_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(457, 32);
            this.username_txt.TabIndex = 9;
            // 
            // lbl_password
            // 
            this.lbl_password.BackColor = System.Drawing.Color.Teal;
            this.lbl_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(27, 387);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_password.Size = new System.Drawing.Size(258, 62);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Password *";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_txt
            // 
            this.password_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.password_txt.Location = new System.Drawing.Point(300, 394);
            this.password_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(456, 32);
            this.password_txt.TabIndex = 10;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // lbl_confirmPassword
            // 
            this.lbl_confirmPassword.BackColor = System.Drawing.Color.Teal;
            this.lbl_confirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_confirmPassword.ForeColor = System.Drawing.Color.White;
            this.lbl_confirmPassword.Location = new System.Drawing.Point(771, 387);
            this.lbl_confirmPassword.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_confirmPassword.Name = "lbl_confirmPassword";
            this.lbl_confirmPassword.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_confirmPassword.Size = new System.Drawing.Size(258, 62);
            this.lbl_confirmPassword.TabIndex = 11;
            this.lbl_confirmPassword.Text = "Confirm Password *";
            this.lbl_confirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmPassword_txt
            // 
            this.confirmPassword_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmPassword_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.confirmPassword_txt.Location = new System.Drawing.Point(1044, 394);
            this.confirmPassword_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.confirmPassword_txt.Name = "confirmPassword_txt";
            this.confirmPassword_txt.Size = new System.Drawing.Size(457, 32);
            this.confirmPassword_txt.TabIndex = 11;
            this.confirmPassword_txt.UseSystemPasswordChar = true;
            // 
            // lbl_address
            // 
            this.lbl_address.BackColor = System.Drawing.Color.Teal;
            this.lbl_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_address.ForeColor = System.Drawing.Color.White;
            this.lbl_address.Location = new System.Drawing.Point(27, 459);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.lbl_address.Size = new System.Drawing.Size(258, 62);
            this.lbl_address.TabIndex = 12;
            this.lbl_address.Text = "Address";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // address_txt
            // 
            this.tbl_userRegistration_pnl.SetColumnSpan(this.address_txt, 3);
            this.address_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address_txt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.address_txt.Location = new System.Drawing.Point(300, 466);
            this.address_txt.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(1201, 32);
            this.address_txt.TabIndex = 12;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Teal;
            this.buttonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbl_userRegistration_pnl.SetColumnSpan(this.buttonPanel, 4);
            this.buttonPanel.Controls.Add(this.btn_cancel);
            this.buttonPanel.Controls.Add(this.btn_clear);
            this.buttonPanel.Controls.Add(this.btn_register);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonPanel.Location = new System.Drawing.Point(26, 530);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Padding = new System.Windows.Forms.Padding(6, 15, 6, 6);
            this.buttonPanel.Size = new System.Drawing.Size(1481, 106);
            this.buttonPanel.TabIndex = 13;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(1319, 15);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 52);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.SlateGray;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1159, 15);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(150, 52);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Teal;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(999, 15);
            this.btn_register.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(150, 52);
            this.btn_register.TabIndex = 13;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // registration_panel
            // 
            this.registration_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.registration_panel.Controls.Add(this.lbl_registrations);
            this.registration_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.registration_panel.Location = new System.Drawing.Point(0, 0);
            this.registration_panel.Margin = new System.Windows.Forms.Padding(4);
            this.registration_panel.Name = "registration_panel";
            this.registration_panel.Size = new System.Drawing.Size(1609, 98);
            this.registration_panel.TabIndex = 1;
            // 
            // lbl_registrations
            // 
            this.lbl_registrations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_registrations.BackColor = System.Drawing.Color.Teal;
            this.lbl_registrations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_registrations.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_registrations.ForeColor = System.Drawing.Color.White;
            this.lbl_registrations.Location = new System.Drawing.Point(680, 0);
            this.lbl_registrations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_registrations.Name = "lbl_registrations";
            this.lbl_registrations.Size = new System.Drawing.Size(357, 64);
            this.lbl_registrations.TabIndex = 0;
            this.lbl_registrations.Text = "Registration";
            this.lbl_registrations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1609, 876);
            this.Controls.Add(this.registration_bodypnl);
            this.Controls.Add(this.login_headerpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1019, 799);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venus Academy - User Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.login_headerpanel.ResumeLayout(false);
            this.registration_bodypnl.ResumeLayout(false);
            this.formHostPanel.ResumeLayout(false);
            this.tbl_userRegistration_pnl.ResumeLayout(false);
            this.tbl_userRegistration_pnl.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.registration_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel login_headerpanel;
        public System.Windows.Forms.Panel registration_bodypnl;
        public System.Windows.Forms.Panel registration_panel;
        private System.Windows.Forms.Panel formHostPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Label lbl_venusacademy;
        public System.Windows.Forms.Label lbl_registrations;
        public System.Windows.Forms.Label lbl_firstname;
        public System.Windows.Forms.Label middlename_lbl;
        public System.Windows.Forms.Label lbl_lastname;
        public System.Windows.Forms.Label lbl_dob;
        public System.Windows.Forms.Label lbl_gender;
        public System.Windows.Forms.Label lbl_cnic;
        public System.Windows.Forms.Label lbl_email;
        public System.Windows.Forms.Label lbl_phone;
        public System.Windows.Forms.Label lbl_role;
        public System.Windows.Forms.Label lbl_address;
        public System.Windows.Forms.Label lbl_username;
        public System.Windows.Forms.Label lbl_password;
        public System.Windows.Forms.Label lbl_confirmPassword;
        public System.Windows.Forms.TableLayoutPanel tbl_userRegistration_pnl;
        public System.Windows.Forms.TextBox firstname_txt;
        public System.Windows.Forms.TextBox middlename_txt;
        public System.Windows.Forms.TextBox lastname_txt;
        public System.Windows.Forms.TextBox email_txt;
        public System.Windows.Forms.TextBox address_txt;
        public System.Windows.Forms.TextBox username_txt;
        public System.Windows.Forms.TextBox password_txt;
        public System.Windows.Forms.TextBox confirmPassword_txt;
        public System.Windows.Forms.MaskedTextBox cnic_txt;
        public System.Windows.Forms.MaskedTextBox phone_txt;
        public System.Windows.Forms.ComboBox gender_cmb;
        public System.Windows.Forms.ComboBox role_cmb;
        public System.Windows.Forms.DateTimePicker dob_picker;
        public System.Windows.Forms.Button btn_register;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.Button btn_cancel;
    }
}