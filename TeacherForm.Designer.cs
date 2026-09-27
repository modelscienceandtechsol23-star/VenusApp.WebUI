namespace VenusApp.WebUI
{
    partial class TeacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_panel = new System.Windows.Forms.Panel();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.topControlsPanel = new System.Windows.Forms.Panel();
            this.flowTop = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.headerpanel.SuspendLayout();
            this.body_panel.SuspendLayout();
            this.grid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.topControlsPanel.SuspendLayout();
            this.flowTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerpanel
            // 
            this.headerpanel.Size = new System.Drawing.Size(1745, 104);
            // 
            // body_panel
            // 
            this.body_panel.BackColor = System.Drawing.Color.Transparent;
            this.body_panel.Controls.Add(this.grid_panel);
            this.body_panel.Size = new System.Drawing.Size(1526, 656);
            this.body_panel.Controls.SetChildIndex(this.lbl_dashboard, 0);
            this.body_panel.Controls.SetChildIndex(this.grid_panel, 0);
            // 
            // login_headerpanel
            // 
            this.login_headerpanel.Size = new System.Drawing.Size(1741, 102);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.Location = new System.Drawing.Point(622, 7);
            // 
            // grid_panel
            // 
            this.grid_panel.BackColor = System.Drawing.Color.Transparent;
            this.grid_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grid_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid_panel.Controls.Add(this.dgvTeachers);
            this.grid_panel.Controls.Add(this.lblGridTitle);
            this.grid_panel.Controls.Add(this.topControlsPanel);
            this.grid_panel.Location = new System.Drawing.Point(4, 48);
            this.grid_panel.Name = "grid_panel";
            this.grid_panel.Padding = new System.Windows.Forms.Padding(12);
            this.grid_panel.Size = new System.Drawing.Size(1421, 593);
            this.grid_panel.TabIndex = 6;
            // 
            // dgvTeachers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTeachers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeachers.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeachers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTeachers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTeachers.ColumnHeadersHeight = 29;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeachers.EnableHeadersVisualStyles = false;
            this.dgvTeachers.Location = new System.Drawing.Point(12, 116);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersVisible = false;
            this.dgvTeachers.RowHeadersWidth = 51;
            this.dgvTeachers.RowTemplate.Height = 30;
            this.dgvTeachers.Size = new System.Drawing.Size(1395, 463);
            this.dgvTeachers.TabIndex = 3;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.White;
            this.lblGridTitle.Location = new System.Drawing.Point(12, 68);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(1395, 48);
            this.lblGridTitle.TabIndex = 4;
            this.lblGridTitle.Text = "Teacher List";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topControlsPanel
            // 
            this.topControlsPanel.BackColor = System.Drawing.Color.Transparent;
            this.topControlsPanel.Controls.Add(this.flowTop);
            this.topControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topControlsPanel.Location = new System.Drawing.Point(12, 12);
            this.topControlsPanel.Name = "topControlsPanel";
            this.topControlsPanel.Padding = new System.Windows.Forms.Padding(8);
            this.topControlsPanel.Size = new System.Drawing.Size(1395, 56);
            this.topControlsPanel.TabIndex = 5;
            // 
            // flowTop
            // 
            this.flowTop.Controls.Add(this.txtSearch);
            this.flowTop.Controls.Add(this.btnRefresh);
            this.flowTop.Controls.Add(this.btnSearch);
            this.flowTop.Controls.Add(this.cboFilter);
            this.flowTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTop.Location = new System.Drawing.Point(8, 8);
            this.flowTop.Name = "flowTop";
            this.flowTop.Size = new System.Drawing.Size(1379, 40);
            this.flowTop.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(520, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(529, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnRefresh.Size = new System.Drawing.Size(80, 34);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(615, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnSearch.Size = new System.Drawing.Size(76, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFilter.Items.AddRange(new object[] {
            "All"});
            this.cboFilter.Location = new System.Drawing.Point(697, 3);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(140, 28);
            this.cboFilter.TabIndex = 3;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1745, 760);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TeacherForm";
            this.headerpanel.ResumeLayout(false);
            this.body_panel.ResumeLayout(false);
            this.body_panel.PerformLayout();
            this.grid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.topControlsPanel.ResumeLayout(false);
            this.flowTop.ResumeLayout(false);
            this.flowTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel grid_panel;
        public System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Panel topControlsPanel;
        private System.Windows.Forms.FlowLayoutPanel flowTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboFilter;
    }
}
