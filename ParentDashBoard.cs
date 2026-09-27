using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VenusApp.WebUI.Model;

namespace VenusApp.WebUI
{
    public  partial class ParentDashBoard : Form
    {
        public ParentDashBoard()
        {
            InitializeComponent();
            // Keep the Dashboard heading centered when the form is
            // maximized, restored, or resized.
            body_panel.Resize += body_panel_Resize;
            CenterDashboardLabel();

            lblUserSession.Location = new Point(login_headerpanel.Width - 220, 15);

            lblUserSession.Anchor =
            AnchorStyles.Top | AnchorStyles.Right;

        }

        private void ParentDashBoard_Load(object sender, EventArgs e)
        {
           
        }

        private void body_panel_Resize(object sender, EventArgs e)
        {
            CenterDashboardLabel();
        }

        protected void CenterDashboardLabel()
        {
            if (body_panel == null || lbl_dashboard == null)
            {
                return;
            }

            int centeredX = (body_panel.ClientSize.Width - lbl_dashboard.Width) / 2;
            int topMargin = 7;

            lbl_dashboard.Location = new Point(
                Math.Max(0, centeredX),
                topMargin
            );
        }


        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

      

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_studnt_Click(object sender, EventArgs e)
        {
            // Hide the parent, open StudentForm modally, then restore the parent
            this.Hide();
            using (StudentForm studentForm = new StudentForm())
            {
                studentForm.ShowDialog();
            }
            this.Show();

        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (TeacherForm teacherForm = new TeacherForm())
            {
                teacherForm.ShowDialog();
            }
            this.Show();
        }
    }
}
