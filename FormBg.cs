using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class FormBg : Form
    {

        public const int AW_HOR_POSITIVE = 0x10000;
        public const int AW_SLIDE = 0x40000;
        public const int AW_HIDE = 0x10000;
        public const int AW_VER_NEGATIVE = 0x0004;
        public const int AW_VER_POSITIVE = 0x0008;
        public const int AW_BLEND = 0x00070000;


        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);              
        Form activeForm = null;

        public FormBg()
        {
            InitializeComponent();
            OpenChildForm(new FormCalculator(), guna2Panel1);
            buttonMinimize.CheckedState.ImageSize = new System.Drawing.Size(5, 5);

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void OpenChildForm(Form childForm, Panel parentPanel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                // childForm.Size = parentPanel.Size;
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                // childForm.Size = parentPanel.Size;

            }
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 100,  AW_VER_POSITIVE| AW_SLIDE |AW_HIDE); 
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            // Animate the form out
            AnimateWindow(this.Handle, 200, AW_VER_NEGATIVE | AW_SLIDE | AW_HIDE);

            // Minimize the form
            this.WindowState = FormWindowState.Minimized;

            // Show the form on the taskbar
            this.ShowInTaskbar = true;

           
        }

    }
}
