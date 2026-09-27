using Microsoft.Data.SqlClient;
using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenusApp.WebUI
{
    public partial class RegistrationForm : Form
    {
        private string otherGender = string.Empty;
        public RegistrationForm()
        {
            InitializeComponent();
            dob_picker.MaxDate = DateTime.Today;
            Resize += RegistrationForm_Resize;
            Shown += RegistrationForm_Shown;
            gender_cmb.SelectedIndexChanged +=  gender_combo_SelectedIndexChanged;
        }

        private void gender_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gender_cmb.SelectedItem != null &&
                gender_cmb.SelectedItem.ToString() == "Other")
            {
                string enteredGender = ShowGenderInputDialog();

                if (!string.IsNullOrWhiteSpace(enteredGender))
                {
                    otherGender = enteredGender.Trim();
                }
                else
                {
                    otherGender = string.Empty;
                    gender_cmb.SelectedIndex = -1;
                }
            }
            else
            {
                otherGender = string.Empty;
            }
        }


        private string ShowGenderInputDialog()
        {
            Color tealColor = Color.FromArgb(0, 137, 137);
            Color darkTealColor = Color.FromArgb(0, 105, 105);

            using (Form genderForm = new Form())
            using (Label lblGender = new Label())
            using (TextBox txtGender = new TextBox())
            using (Button btnOK = new Button())
            using (Button btnCancel = new Button())
            {
                genderForm.Text = "Other Gender";
                genderForm.StartPosition = FormStartPosition.CenterParent;
                genderForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                genderForm.MaximizeBox = false;
                genderForm.MinimizeBox = false;
                genderForm.ShowInTaskbar = false;
                genderForm.ClientSize = new Size(440, 175);

                // Teal-green popup background
                genderForm.BackColor = tealColor;
                genderForm.ForeColor = Color.White;
                genderForm.Font = new Font("Segoe UI", 10F);

                lblGender.Text = "Please enter gender:";
                lblGender.AutoSize = true;
                lblGender.ForeColor = Color.White;
                lblGender.BackColor = Color.Transparent;
                lblGender.Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold
                );
                lblGender.Location = new Point(25, 25);

                txtGender.Location = new Point(25, 58);
                txtGender.Size = new Size(390, 29);
                txtGender.BackColor = Color.White;
                txtGender.ForeColor = Color.Black;
                txtGender.BorderStyle = BorderStyle.FixedSingle;
                txtGender.MaxLength = 50;

                btnOK.Text = "OK";
                btnOK.Location = new Point(230, 112);
                btnOK.Size = new Size(88, 38);
                btnOK.BackColor = darkTealColor;
                btnOK.ForeColor = Color.White;
                btnOK.FlatStyle = FlatStyle.Flat;
                btnOK.FlatAppearance.BorderColor = Color.White;
                btnOK.FlatAppearance.BorderSize = 1;
                btnOK.DialogResult = DialogResult.OK;

                btnCancel.Text = "Cancel";
                btnCancel.Location = new Point(327, 112);
                btnCancel.Size = new Size(88, 38);
                btnCancel.BackColor = Color.Firebrick;
                btnCancel.ForeColor = Color.White;
                btnCancel.FlatStyle = FlatStyle.Flat;
                btnCancel.FlatAppearance.BorderColor = Color.White;
                btnCancel.FlatAppearance.BorderSize = 1;
                btnCancel.DialogResult = DialogResult.Cancel;

                genderForm.Controls.Add(lblGender);
                genderForm.Controls.Add(txtGender);
                genderForm.Controls.Add(btnOK);
                genderForm.Controls.Add(btnCancel);

                genderForm.AcceptButton = btnOK;
                genderForm.CancelButton = btnCancel;

                genderForm.Shown += delegate
                {
                    txtGender.Focus();
                };

                if (genderForm.ShowDialog(this) == DialogResult.OK)
                {
                    return txtGender.Text.Trim();
                }

                return string.Empty;
            }
        }



        private void RegistrationForm_Shown(object sender, EventArgs e)
        {
            UpdateResponsiveLayout();
            firstname_txt.Focus();
        }

        private void RegistrationForm_Resize(object sender, EventArgs e)
        {
            UpdateResponsiveLayout();
        }

        private void UpdateResponsiveLayout()
        {
            lbl_venusacademy.Left = Math.Max(0, (login_headerpanel.ClientSize.Width - lbl_venusacademy.Width) / 2);
            lbl_venusacademy.Top = Math.Max(0, (login_headerpanel.ClientSize.Height - lbl_venusacademy.Height) / 2);
            lbl_registrations.Left = Math.Max(0, (registration_panel.ClientSize.Width - lbl_registrations.Width) / 2);
            lbl_registrations.Top = Math.Max(0, (registration_panel.ClientSize.Height - lbl_registrations.Height) / 2);

            int availableWidth = formHostPanel.ClientSize.Width - formHostPanel.Padding.Horizontal;
            tbl_userRegistration_pnl.Width = Math.Max(tbl_userRegistration_pnl.MinimumSize.Width, availableWidth);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            string error = ValidateForm();

            if (error.Length > 0)
            {
                MessageBox.Show(error,
                                "Registration",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RegisterUser();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            //string error = ValidateForm();
            //if (error.Length > 0)
            //{
            //    MessageBox.Show(error, "Please check registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Save the values to your database here using a parameterized SQL command.
            //MessageBox.Show("Registration details are valid and ready to save.", "Venus Academy",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch
            (
                phone,
                @"^03[0-9]{2}-[0-9]{7}$"
            );
        }

        private bool IsValidCNIC(string cnic)
        {
            return Regex.IsMatch
            (
                cnic,
                @"^[1-7][0-9]{4}-[0-9]{7}-[0-9]$"
            );
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch
            (
                email,
                @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
            );
        }

        private bool IsStrongPassword(string password)
        {
            return Regex.IsMatch
            (
                password,
                @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*#?&]).{8,}$"
            );
        }

        private void RegisterUser()
        {
            string conString =
@"Data Source=.\SQLEXPRESS;
Initial Catalog=VenusAcademyDB;
User ID=sa;
Password=sa;
TrustServerCertificate=False;";

            using (SqlConnection  con = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand("_sp_UserRegistration", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@firstname", firstname_txt.Text.Trim());
                cmd.Parameters.AddWithValue("@middlename", middlename_txt.Text.Trim());
                cmd.Parameters.AddWithValue("@lastname", lastname_txt.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", dob_picker.Value.Date);
                cmd.Parameters.AddWithValue("@genderid", gender_cmb.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@CNIC", cnic_txt.Text.Trim());
                cmd.Parameters.AddWithValue("@email", email_txt.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", phone_txt.Text.Trim());
                cmd.Parameters.AddWithValue("@role_id", role_cmb.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@username", username_txt.Text.Trim());
                cmd.Parameters.AddWithValue("@password", password_txt.Text);
                cmd.Parameters.AddWithValue("@confirmpassword",
                    string.IsNullOrWhiteSpace(confirmPassword_txt.Text)
                        ? password_txt.Text
                        : confirmPassword_txt.Text);
                cmd.Parameters.AddWithValue("@address", address_txt.Text.Trim());

                // OUTPUT parameters: new user id and generated registration number
                var pNewUserId = new SqlParameter("@new_user_id", SqlDbType.Int) { Direction = ParameterDirection.Output };
                var pRegNo = new SqlParameter("@registration_number", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };

                cmd.Parameters.Add(pNewUserId);
                cmd.Parameters.Add(pRegNo);

                con.Open();
                cmd.ExecuteNonQuery();

                int newUserId = pNewUserId.Value != DBNull.Value ? Convert.ToInt32(pNewUserId.Value) : 0;
                string regNumber = pRegNo.Value != DBNull.Value ? pRegNo.Value.ToString() : string.Empty;

                if (newUserId > 0)
                {
                    MessageBox.Show(
                        $"User Registered Successfully.{(string.IsNullOrWhiteSpace(regNumber) ? "" : $" Registration No: {regNumber}")}",
                        "Venus Academy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearForm();
                }
                else
                {
                    MessageBox.Show(
                        "Registration did not complete. Please check data and try again.",
                        "Venus Academy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            firstname_txt.Clear();
            middlename_txt.Clear();
            lastname_txt.Clear();

            dob_picker.Value = DateTime.Today;
            dob_picker.Checked = false;

            gender_cmb.SelectedIndex = -1;

            cnic_txt.Clear();

            email_txt.Clear();

            phone_txt.Clear();

            role_cmb.SelectedIndex = -1;

            username_txt.Clear();

            password_txt.Clear();

            confirmPassword_txt.Clear();

            address_txt.Clear();

            firstname_txt.Focus();
        }


        private string ValidateForm()
        {
            if (firstname_txt.Text.Trim() == "")
                return "Enter First Name.";

            if (lastname_txt.Text.Trim() == "")
                return "Enter Last Name.";

            if (gender_cmb.SelectedIndex == -1)
                return "Select Gender.";

            if (role_cmb.SelectedIndex == -1)
                return "Select Role.";

            if (!dob_picker.Checked)
                return "Select Date of Birth.";

            if (!IsValidEmail(email_txt.Text.Trim()))
                return "Invalid Email Address.";

            if (!IsValidPhone(phone_txt.Text.Trim()))
                return "Pakistan Mobile Number format should be 03XX-XXXXXXX.";

            if (!IsValidCNIC(cnic_txt.Text.Trim()))
                return "Pakistan CNIC format should be XXXXX-XXXXXXX-X.";

            if (username_txt.Text.Trim() == "")
                return "Enter Username.";

            if (!IsStrongPassword(password_txt.Text))
                return "Password must contain at least 8 characters, one uppercase letter, one lowercase letter, one number and one special character.";

            if (password_txt.Text != confirmPassword_txt.Text)
                return "Password and Confirm Password do not match.";

            return "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            foreach (Control control in tbl_userRegistration_pnl.Controls) ClearControl(control);
            dob_picker.Checked = false;
            firstname_txt.Focus();
        }

        private void ClearControl(Control control)
        {
            TextBoxBase text = control as TextBoxBase;
            if (text != null)
                text.Clear();
            ComboBox combo = control as ComboBox;
            if (combo != null)
                combo.SelectedIndex = -1;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the registration form?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();
            }
                
        }
    }
}
