using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VenusApp.WebUI
{
    public partial class TeacherForm : VenusApp.WebUI.ParentDashBoard
    {
        // DataTable stored at class level so we can filter and refresh
        private DataTable teachersTable;

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        public TeacherForm()
        {
            InitializeComponent();
            this.Load += TeacherForm_Load;
        }

        private void PositionGridPanel()
        {
            try
            {
                if (body_panel == null || grid_panel == null || lbl_dashboard == null)
                    return;
                int margin = 20;
                int maxWidth = Math.Max(600, body_panel.ClientSize.Width - margin * 2);
                int maxHeight = Math.Max(300, Math.Min(550, body_panel.ClientSize.Height - lbl_dashboard.Bottom - 80));

                if (maxWidth <= 0 || maxHeight <= 0)
                    return;

                grid_panel.Size = new Size(maxWidth, maxHeight);

                int x = margin;
                int y = Math.Max(60, lbl_dashboard.Bottom + 8);

                grid_panel.Location = new Point(x, y);
            }
            catch { }
        }

        private void CustomizeGridAppearance()
        {
            dgvTeachers.ReadOnly = true;
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.MultiSelect = false;
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeachers.GridColor = Color.White;
            dgvTeachers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTeachers.BorderStyle = BorderStyle.None;

            dgvTeachers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 45, 65);
            dgvTeachers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTeachers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvTeachers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvTeachers.ColumnHeadersHeight = 40;
            dgvTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvTeachers.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgvTeachers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
            dgvTeachers.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvTeachers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);

            //if (dgvTeachers.Columns.Contains("user_id"))
            //    dgvTeachers.Columns["user_id"].Visible = false;

            if (dgvTeachers.Columns.Contains("FullName"))
            {
                dgvTeachers.Columns["FullName"].HeaderText = "Full Name";
                dgvTeachers.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTeachers.Columns["FullName"].DisplayIndex = 1;
            }

            string[] hideCols = new[] { "firstname", "middlename", "lastname" };
            foreach (var c in hideCols)
            {
                if (dgvTeachers.Columns.Contains(c))
                    dgvTeachers.Columns[c].Visible = false;
            }

            if (dgvTeachers.Columns.Contains("username"))
            {
                dgvTeachers.Columns["username"].HeaderText = "Username";
                dgvTeachers.Columns["username"].Width = 120;
                dgvTeachers.Columns["username"].DisplayIndex = 2;
            }

            if (dgvTeachers.Columns.Contains("dob"))
            {
                dgvTeachers.Columns["dob"].HeaderText = "Date of Birth";
                dgvTeachers.Columns["dob"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvTeachers.Columns["dob"].Width = 120;
                dgvTeachers.Columns["dob"].DisplayIndex = 3;
            }

            if (dgvTeachers.Columns.Contains("CNIC"))
            {
                dgvTeachers.Columns["CNIC"].HeaderText = "CNIC";
                dgvTeachers.Columns["CNIC"].Width = 130;
                dgvTeachers.Columns["CNIC"].DisplayIndex = 4;
            }

            if (dgvTeachers.Columns.Contains("addresss"))
            {
                dgvTeachers.Columns["addresss"].HeaderText = "Address";
                dgvTeachers.Columns["addresss"].DisplayIndex = 5;
                dgvTeachers.Columns["addresss"].Width = 220;
            }

            if (dgvTeachers.Columns.Contains("phone"))
            {
                dgvTeachers.Columns["phone"].HeaderText = "Phone";
                dgvTeachers.Columns["phone"].Width = 120;
                dgvTeachers.Columns["phone"].DisplayIndex = 6;
            }

            if (dgvTeachers.Columns.Contains("email"))
            {
                dgvTeachers.Columns["email"].HeaderText = "Email";
                dgvTeachers.Columns["email"].DisplayIndex = 7;
                dgvTeachers.Columns["email"].Width = 180;
            }

            if (dgvTeachers.Columns.Contains("role"))
            {
                dgvTeachers.Columns["role"].HeaderText = "Role";
                dgvTeachers.Columns["role"].Width = 100;
                dgvTeachers.Columns["role"].DisplayIndex = 9;
            }

            if (dgvTeachers.Columns.Contains("gender"))
            {
                dgvTeachers.Columns["gender"].HeaderText = "Gender";
                dgvTeachers.Columns["gender"].Width = 80;
                dgvTeachers.Columns["gender"].DisplayIndex = 10;
            }

            if (dgvTeachers.Columns.Contains("hire_date"))
            {
                dgvTeachers.Columns["hire_date"].HeaderText = "Hire Date";
                dgvTeachers.Columns["hire_date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvTeachers.Columns["hire_date"].Width = 120;
            }

            dgvTeachers.ClearSelection();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            lbl_dashboard.Text = "Teacher Information";
            CenterDashboardLabel();
            try
            {
                if (body_panel != null)
                {
                    body_panel.BackgroundImage = global::VenusApp.WebUI.Properties.Resources.classroom1;
                    body_panel.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (grid_panel != null)
                {
                    grid_panel.BackColor = Color.White;
                }
            }
            catch { }

            LoadTeachers();

            try
            {
                if (this.txtSearch != null)
                {
                    this.txtSearch.TextChanged += (s, ev) => FilterTeachers(this.txtSearch.Text);
                    try
                    {
                        SendMessage(this.txtSearch.Handle, EM_SETCUEBANNER, (IntPtr)1,
                            "Search teachers by name, email, phone or username...");
                    }
                    catch { }
                }

                if (this.btnRefresh != null)
                    this.btnRefresh.Click += (s, ev) => LoadTeachers();

                if (this.btnSearch != null)
                    this.btnSearch.Click += (s, ev) => FilterTeachers(this.txtSearch.Text);

                if (this.cboFilter != null)
                    this.cboFilter.SelectedIndexChanged += (s, ev) => FilterTeachers(this.txtSearch.Text);

                if (this.dgvTeachers != null)
                    this.dgvTeachers.DoubleClick += DgvTeachers_DoubleClick;
            }
            catch { }

            if (body_panel != null)
                body_panel.Resize += (s, ev) => PositionGridPanel();
        }

        private void LoadTeachers()
        {
            string cs =
@"Data Source=.\SQLEXPRESS;
Initial Catalog=VenusAcademyDB;
User ID=sa;
Password=sa;
TrustServerCertificate=True;";

            try
            {
                using (SqlConnection  con = new SqlConnection(cs))
                {
                    string sql = @"
                                        SELECT
                                       
                                       u.firstname,
                                       u.middlename,
                                       u.lastname,
                                       u.dob,
                                       g.gender_name AS gender,
                                       u.CNIC,
                                       u.email,
                                       u.phone,
                                       t.teacher_id,
                                       t.joining_date,
                                       u.username,
                                       u.addresss,
                                       r.role_name AS role
                                     FROM tbl_user AS u
                                     INNER JOIN tbl_teacher AS t ON u.user_id = t.user_id
                                     LEFT JOIN tbl_gender AS g ON u.genderid = g.gender_id
                                     LEFT JOIN tbl_role AS r ON u.role_id = r.role_id
                                     WHERE r.role_name = 'Teacher'
                                     ORDER BY u.lastname, u.firstname;";

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                    {
                        da.Fill(dt);
                    }

                    if (!dt.Columns.Contains("FullName"))
                        dt.Columns.Add("FullName", typeof(string));

                    foreach (DataRow r in dt.Rows)
                    {
                        string fn = (r.Table.Columns.Contains("firstname") && r["firstname"] != DBNull.Value) ? r["firstname"].ToString() : "";
                        string mn = (r.Table.Columns.Contains("middlename") && r["middlename"] != DBNull.Value) ? r["middlename"].ToString() : "";
                        string ln = (r.Table.Columns.Contains("lastname") && r["lastname"] != DBNull.Value) ? r["lastname"].ToString() : "";
                        string fullName = string.Join(" ", new[] { fn, mn, ln }.Where(s => !string.IsNullOrWhiteSpace(s)));
                        r["FullName"] = fullName;
                    }

                    string[] removeCols = new[] { "firstname", "middlename", "lastname" };
                    foreach (var c in removeCols)
                    {
                        if (dt.Columns.Contains(c))
                            dt.Columns.Remove(c);
                    }

                    teachersTable = dt;
                    try { teachersTable.CaseSensitive = false; } catch { }
                    dgvTeachers.DataSource = teachersTable.DefaultView;

                    try
                    {
                        if (this.cboFilter != null)
                        {
                            this.cboFilter.Items.Clear();
                            this.cboFilter.Items.Add("All");
                            this.cboFilter.Items.Add("Male");
                            this.cboFilter.Items.Add("Female");
                            this.cboFilter.SelectedIndex = 0;
                        }
                    }
                    catch { }

                    PositionGridPanel();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while loading teachers: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error while loading teachers: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterTeachers(string searchText)
        {
            try
            {
                if (teachersTable == null)
                    return;

                string filter = "";
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    string s = searchText.Replace("'", "''");
                    filter = string.Format("(FullName LIKE '%{0}%' OR username LIKE '%{0}%' OR email LIKE '%{0}%' OR phone LIKE '%{0}%')", s);
                }

                if (this.cboFilter != null && this.cboFilter.SelectedItem != null)
                {
                    string gender = this.cboFilter.SelectedItem.ToString();
                    if (!string.IsNullOrWhiteSpace(gender) && gender != "All")
                    {
                        string g = gender.Replace("'", "''");
                        if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                        filter += string.Format("(gender LIKE '%{0}%')", g);
                    }
                }

                if (dgvTeachers != null)
                {
                    DataView dv = teachersTable.DefaultView;
                    dv.RowFilter = filter;
                    dgvTeachers.DataSource = dv;
                    CustomizeGridAppearance();
                }
            }
            catch { }
        }

        private void DgvTeachers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvTeachers.SelectedRows.Count == 0) return;
                var row = dgvTeachers.SelectedRows[0];
                if (row == null) return;

                var id = "";
                if (dgvTeachers != null && dgvTeachers.Columns.Contains("teacher_id"))
                {
                    int idx = dgvTeachers.Columns["teacher_id"].Index;
                    if (row.Cells.Count > idx && row.Cells[idx].Value != null)
                        id = row.Cells[idx].Value.ToString();
                }

                MessageBox.Show(this, string.Format("Teacher ID: {0}", id), "Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }
    }
}
