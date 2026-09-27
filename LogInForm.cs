using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VenusApp.WebUI.Model;

namespace VenusApp.WebUI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();

            
            this.MinimumSize = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            CenterHeaderLabel();
            CenterBodyLabel();
            CenterLoginContainer();

            this.Resize += LogInForm_Resize;
            login_headerpanel.Resize += Login_headerpanel_Resize;
            login_bodypnl.Resize += Login_bodyrpanel_Resize;

            txt_password.UseSystemPasswordChar = true;
        }

        private void CenterHeaderLabel()
        {
            lbl_venusacademy.Left = (login_headerpanel.ClientSize.Width - lbl_venusacademy.Width) / 2;
            lbl_venusacademy.Top = (login_headerpanel.ClientSize.Height - lbl_venusacademy.Height) / 2;
        }

        private void CenterBodyLabel()
        {
            lbl_login.Left = (login_bodypnl.ClientSize.Width - lbl_login.Width) / 2;
            //lbl_login.Top = (login_bodypnl.ClientSize.Height - lbl_login.Height) / 2;
            lbl_login.BringToFront();
        }

        private void CenterLoginContainer()
        {
            pnlLoginContainer.Left =
                (login_bodypnl.ClientSize.Width - pnlLoginContainer.Width) / 2;

            pnlLoginContainer.Top =
                (login_bodypnl.ClientSize.Height - pnlLoginContainer.Height) / 2;

            pnlLoginContainer.BringToFront();
        }


        private void LogInForm_Resize(object sender, EventArgs e)
        {
            CenterHeaderLabel();
            CenterBodyLabel();
        }

        private void Login_headerpanel_Resize(object sender, EventArgs e)
        {
            CenterHeaderLabel();
        }

        private void Login_bodyrpanel_Resize(object sender, EventArgs e)
        {
            CenterBodyLabel();
            CenterLoginContainer();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            CenterHeaderLabel();
            CenterBodyLabel();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            pnlLoginContainer.Visible = true;
            LoadRoles();
        }

        private void lnk_lbl_registration_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegistrationForm regForm = new RegistrationForm())
            {
                regForm.StartPosition = FormStartPosition.CenterScreen;

                // Hide the current Login form
                this.Hide();

                // Open Registration form
                regForm.ShowDialog(this);

                // Return to Login when Registration closes
                this.Show();
                //this.Activate();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim() == "")
            {
                MessageBox.Show("Enter Username.");
                txt_username.Focus();
                return;
            }

            if (txt_password.Text == "")
            
            {
                MessageBox.Show("Enter Password.");
                txt_password.Focus();
                return;
            }

            if (role_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Select Role.");
                role_cmb.Focus();
                return;
            }

            AuthenticateUser();


            //this.Hide();
            //new ParentDashBoard().ShowDialog(this);
        }

        private void AuthenticateUser()
        {
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                  Initial Catalog=VenusAcademyDB;
                  User ID=sa;
                  Password=sa;
                  TrustServerCertificate=True;";

            using SqlConnection con = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand("_sp_UserLogin", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            string username = txt_username?.Text?.Trim()
                ?? throw new InvalidOperationException("Username control is not initialized.");

            string password = txt_password?.Text
                ?? throw new InvalidOperationException("Password control is not initialized.");

            var usernameParameter = new SqlParameter("@username", SqlDbType.NVarChar, 50)
            {
                Value = username
            };

            cmd.Parameters.Add(usernameParameter);
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password;
            cmd.Parameters.AddWithValue("@role_id", role_cmb.SelectedIndex + 1);

            Debug.WriteLine(cmd.GetType().AssemblyQualifiedName);
            Debug.WriteLine(usernameParameter.GetType().AssemblyQualifiedName);

            DataTable dt = new DataTable();
            using SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                UserSession.UserID = Convert.ToInt32(dt.Rows[0]["user_id"]);
                int roleID = Convert.ToInt32(dt.Rows[0]["role_id"]);
                string firstName = dt.Rows[0]["firstname"].ToString();
                string lastName = dt.Rows[0]["lastname"].ToString();

                UserSession.Username = txt_username.Text.Trim();
                UserSession.FullName = firstName + "" + lastName;
                UserSession.RoleID = roleID;
                UserSession.RoleName = dt.Rows[0]["role_name"].ToString();
                UserSession.IsLoggedIn = true;

                MessageBox.Show(
                    "Welcome " + firstName + " " + lastName,
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                OpenDashboard(roleID);

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username, Password or Role.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txt_password.Clear();
                txt_password.Focus();
            }
        }


        private void OpenDashboard(int roleID)
        {
            switch (roleID)
            {
                case 1:
                    ParentDashBoard _parentDashBoard = new ParentDashBoard();
                    //StudentDashboard frmStudent =
                    //    new StudentDashboard();

                    _parentDashBoard.Show();
                    break;

                case 2:
                    ParentDashBoard frmStudent1 = new ParentDashBoard();
                    //TeacherDashboard frmTeacher =
                    //    new TeacherDashboard();

                    //frmTeacher.Show();

                    break;

                case 3:
                    ParentDashBoard frmStudent2 = new ParentDashBoard();
                    //AdminDashboard frmAdmin =
                    //    new AdminDashboard();

                    //frmAdmin.Show();
                    frmStudent2.Show();
                    break;

                default:

                    MessageBox.Show("Invalid Role.");

                    break;
            }
        }

        private void LoadRoles()
        {
            string cs = @"Data Source=.\SQLEXPRESS;
                  Initial Catalog=VenusAcademyDB;
                  User ID=sa;
                  Password=sa;
                  TrustServerCertificate=True;";

            using SqlConnection con = new SqlConnection(cs);
            using SqlDataAdapter da = new SqlDataAdapter(
                "SELECT role_id, role_name FROM tbl_role ORDER BY role_id", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            role_cmb.DataSource = dt;
            role_cmb.DisplayMember = "role_name";
            role_cmb.ValueMember = "role_id";
            role_cmb.SelectedIndex = -1;
        }


    }
}
