using OpenAI.Graders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VenusApp.WebUI
{
    public partial class StudentForm : VenusApp.WebUI.ParentDashBoard
    {
        // DataTable stored at class level so we can filter and refresh
        private DataTable studentsTable;

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        // helper to avoid repeated UI null checks
        private bool HasDetailControls => txtSearch != null && dgvStudents != null;

        public StudentForm()
        {
            InitializeComponent();
            // Set the dashboard label when the form loads so controls are initialized
            this.Load += StudentForm_Load;
        }

        private void PositionGridPanel()
        {
            try
            {
                if (body_panel == null || grid_panel == null || lbl_dashboard == null)
                    return;
                // Use the available width of the body panel and align to the left
                int margin = 20;
                int maxWidth = Math.Max(600, body_panel.ClientSize.Width - margin * 2);
                int maxHeight = Math.Max(300, Math.Min(550, body_panel.ClientSize.Height - lbl_dashboard.Bottom - 80));

                if (maxWidth <= 0 || maxHeight <= 0)
                    return;

                grid_panel.Size = new Size(maxWidth, maxHeight);

                // Position aligned to left side of the body panel (attached to left side area)
                int x = margin;
                int y = Math.Max(60, lbl_dashboard.Bottom + 8);

                grid_panel.Location = new Point(x, y);
            }
            catch
            {
                // suppress layout errors at runtime
            }
        }

        private void CustomizeGridAppearance()
        {
            // General behavior
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // make grid lines invisible by matching them to the background or removing borders
            dgvStudents.GridColor = Color.White;
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvStudents.BorderStyle = BorderStyle.None;

            // Header style
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 45, 65);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStudents.ColumnHeadersHeight = 40;
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
    
            // Cell style
            dgvStudents.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternating rows
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);

            // Column-specific formatting (if columns exist)
            // Ensure any leftover internal ID column is not visible
            if (dgvStudents.Columns.Contains("user_id"))
            {
                dgvStudents.Columns["user_id"].Visible = false;
            }

            // Full Name column produced during data load
            if (dgvStudents.Columns.Contains("FullName"))
            {
                dgvStudents.Columns["FullName"].HeaderText = "Full Name";
                dgvStudents.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvStudents.Columns["FullName"].DisplayIndex = 1;
            }

            // Hide raw name columns to keep the grid compact
            string[] hideCols = new[] { "firstname", "middlename", "lastname" };
            foreach (var c in hideCols)
            {
                if (dgvStudents.Columns.Contains(c))
                    dgvStudents.Columns[c].Visible = false;
            }

            // Username
            if (dgvStudents.Columns.Contains("username"))
            {
                dgvStudents.Columns["username"].HeaderText = "Username";
                dgvStudents.Columns["username"].Width = 120;
                dgvStudents.Columns["username"].DisplayIndex = 2;
            }

            // Date of birth
            if (dgvStudents.Columns.Contains("dob"))
            {   
                dgvStudents.Columns["dob"].HeaderText = "Date of Birth";
                dgvStudents.Columns["dob"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvStudents.Columns["dob"].Width = 120;
                dgvStudents.Columns["dob"].DisplayIndex = 3;
            }

            // CNIC
            if (dgvStudents.Columns.Contains("CNIC"))
            {
                dgvStudents.Columns["CNIC"].HeaderText = "CNIC";
                dgvStudents.Columns["CNIC"].Width = 130;
                dgvStudents.Columns["CNIC"].DisplayIndex = 4;
            }

            // Address
            if (dgvStudents.Columns.Contains("addresss"))
            {
                dgvStudents.Columns["addresss"].HeaderText = "Address";
                dgvStudents.Columns["addresss"].DisplayIndex = 5;
                dgvStudents.Columns["addresss"].Width = 220;
            }

            // Phone
            if (dgvStudents.Columns.Contains("phone"))
            {
                dgvStudents.Columns["phone"].HeaderText = "Phone";
                dgvStudents.Columns["phone"].Width = 120;
                dgvStudents.Columns["phone"].DisplayIndex = 6;
            }

            // Email
            if (dgvStudents.Columns.Contains("email"))
            {
                dgvStudents.Columns["email"].HeaderText = "Email";
                dgvStudents.Columns["email"].DisplayIndex = 7;
                dgvStudents.Columns["email"].Width = 180;
            }

            // Registration number
            if (dgvStudents.Columns.Contains("registration_no"))
            {
                dgvStudents.Columns["registration_no"].HeaderText = "Reg. No";
                dgvStudents.Columns["registration_no"].Width = 120;
                dgvStudents.Columns["registration_no"].DisplayIndex = 8;
            }

            // Role
            if (dgvStudents.Columns.Contains("role"))
            {
                dgvStudents.Columns["role"].HeaderText = "Role";
                dgvStudents.Columns["role"].Width = 100;
                dgvStudents.Columns["role"].DisplayIndex = 9;
            }

            // Gender
            if (dgvStudents.Columns.Contains("gender"))
            {
                dgvStudents.Columns["gender"].HeaderText = "Gender";
                dgvStudents.Columns["gender"].Width = 80;
                dgvStudents.Columns["gender"].DisplayIndex = 10;
            }

            // Date columns
            if (dgvStudents.Columns.Contains("dob"))
            {   
                dgvStudents.Columns["dob"].HeaderText = "Date of Birth";
                dgvStudents.Columns["dob"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvStudents.Columns["dob"].Width = 120;
            }

            if (dgvStudents.Columns.Contains("admission_date"))
            {
                dgvStudents.Columns["admission_date"].HeaderText = "Admission Date";
                dgvStudents.Columns["admission_date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvStudents.Columns["admission_date"].Width = 120;
            }

            // Final polish
            dgvStudents.ClearSelection();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            lbl_dashboard.Text = "Student Information";
            // Ensure the label is centered in the body panel
            CenterDashboardLabel();
            // Set a nicer background for this form's body panel
            try
            {
                if (body_panel != null)
                {
                    body_panel.BackgroundImage = global::VenusApp.WebUI.Properties.Resources.classroom1;
                    body_panel.BackgroundImageLayout = ImageLayout.Zoom;
                }
                // Set subtle card background for the grid
                if (grid_panel != null)
                {
                    grid_panel.BackColor = Color.White;
                }
            }
            catch { }

            LoadStudents();

            // wire up search and selection events after load
            try
            {
                if (this.txtSearch != null)
                {
                    // perform filter while typing
                    this.txtSearch.TextChanged += (s, ev) => FilterStudents(this.txtSearch.Text);
                    // Set cue banner (placeholder) for .NET Framework
                    try
                    {
                        SendMessage(this.txtSearch.Handle, EM_SETCUEBANNER, (IntPtr)1,
                            "Search students by name, reg no, email or phone...");
                    }
                    catch { }
                }

                if (this.btnRefresh != null)
                {
                    this.btnRefresh.Click += (s, ev) => LoadStudents();
                }

                if (this.btnSearch != null)
                {
                    this.btnSearch.Click += (s, ev) => FilterStudents(this.txtSearch.Text);
                }

                if (this.cboFilter != null)
                {
                    this.cboFilter.SelectedIndexChanged += (s, ev) => FilterStudents(this.txtSearch.Text);
                }

                if (this.dgvStudents != null)
                {
                    this.dgvStudents.DoubleClick += DgvStudents_DoubleClick;
                }
            }
            catch { }

            // Reposition grid when body panel resizes
            if (body_panel != null)
            {
                body_panel.Resize += (s, ev) => PositionGridPanel();
            }
        }

        private void LoadStudents()
        {
                        string cs =
            @"Data Source=.\SQLEXPRESS;
            Initial Catalog=VenusAcademyDB;
            User ID=sa;
            Password=sa;
            TrustServerCertificate=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    // Adjust the table/column names below if your database differs
                    //string sql = @"SELECT * FROM tbl_user WHERE role_id = 1 ORDER BY lastname";

                    string sql = @"
                                    SELECT
                                      u.user_id,
                                      u.firstname,
                                      u.middlename,
                                      u.lastname,
                                      u.dob,
                                      g.gender_name AS gender,
                                      u.CNIC,
                                      u.email,
                                      u.phone,
                                      s.registration_no,
                                      s.admission_date,
                                      u.username,
                                      u.addresss,
                                      r.role_name AS role
                                    FROM tbl_user AS u
                                    INNER JOIN tbl_student AS s ON u.user_id = s.user_id
                                    LEFT JOIN tbl_gender AS g ON u.genderid = g.gender_id
                                    LEFT JOIN tbl_role AS r ON u.role_id = r.role_id
                                    RIGHT JOIN tbl_student AS uss ON u.user_id = uss.user_id
                                    WHERE u.role_id = r.role_id AND r.role_name = 'Student'
                                    ORDER BY u.lastname, u.firstname;";
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                    {
                        da.Fill(dt);
                    }
                    // create a FullName column (concatenate first, middle, last)
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

                    // Remove internal/raw columns we don't want to expose in the grid
                    string[] removeCols = new[] { "user_id", "firstname", "middlename", "lastname" };
                    foreach (var c in removeCols)
                    {
                        if (dt.Columns.Contains(c))
                            dt.Columns.Remove(c);
                    }

                    // store for filtering and reuse (make case-insensitive to simplify LIKE searches)
                    studentsTable = dt;
                    try { studentsTable.CaseSensitive = false; } catch { }
                    dgvStudents.DataSource = studentsTable.DefaultView;

                    // populate filter combobox (gender) with common options: All, Male, Female
                    // This provides the expected behavior: selecting All shows all students,
                    // selecting Male shows rows where gender contains "Male" (e.g. "Male", "Male Student"),
                    // selecting Female shows rows where gender contains "Female".
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

                    // adjust grid panel position/size after data binds
                    PositionGridPanel();
                   
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while loading students: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error while loading students: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Applies filter based on search text and selected filter (gender)
        private void FilterStudents(string searchText)
        {
            try
            {
                if (studentsTable == null)
                    return;

                string filter = "";
                // text search across multiple columns
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    // escape single quotes
                    string s = searchText.Replace("'", "''");
                    filter = string.Format("(firstname LIKE '%{0}%' OR lastname LIKE '%{0}%' OR registration_no LIKE '%{0}%' OR email LIKE '%{0}%' OR phone LIKE '%{0}%')", s);
                }

                // apply gender filter from combo box if present and not 'All'
                if (this.cboFilter != null && this.cboFilter.SelectedItem != null)
                {
                    string gender = this.cboFilter.SelectedItem.ToString();
                    if (!string.IsNullOrWhiteSpace(gender) && gender != "All")
                    {
                        string g = gender.Replace("'", "''");
                        if (!string.IsNullOrEmpty(filter))
                            filter += " AND ";
                        // Use LIKE so selecting e.g. "Female" will also match "Female Student" and similar variants
                        filter += string.Format("(gender LIKE '%{0}%')", g);
                        //filter += string.Format("(gender LIKE '%{0}%')", g);
                    }
                }

                if (dgvStudents != null)
                {
                    DataView dv = studentsTable.DefaultView;
                    dv.RowFilter = filter;
                    dgvStudents.DataSource = dv;
                    CustomizeGridAppearance();
                }
            }
            catch
            {
                // ignore filter errors
            }
        }

        // Show student registration number when row is double-clicked
        private void DgvStudents_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.SelectedRows.Count == 0)
                    return;

                var row = dgvStudents.SelectedRows[0];
                if (row == null)
                    return;

                var reg = "";
                // prefer using the named column if available
                if (dgvStudents != null && dgvStudents.Columns.Contains("registration_no"))
                {
                    int idx = dgvStudents.Columns["registration_no"].Index;
                    if (row.Cells.Count > idx && row.Cells[idx].Value != null)
                        reg = row.Cells[idx].Value.ToString();
                }
                else if (row.Cells.Count > 0 && row.Cells[0].Value != null)
                {
                    reg = row.Cells[0].Value.ToString();
                }

                MessageBox.Show(this, string.Format("Registration Number: {0}", reg), "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }
    }
}
