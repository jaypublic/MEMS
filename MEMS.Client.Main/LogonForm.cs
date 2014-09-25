using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MEMS.Client.Main
{
    public partial class LogonForm : DevExpress.XtraEditors.XtraForm
    {
        public LogonForm()
        {
            InitializeComponent();
        }

        private void LogonForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Size.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.WorkingArea.Size.Height / 2 - this.Size.Height / 2);
        }
        private Point m_frmloc;
        private Point m_mouseloc;
        private void LogonForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m_frmloc = this.Location;
                m_mouseloc = e.Location;
            }
        }

        private void LogonForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(m_frmloc.X + e.X - m_mouseloc.X, m_frmloc.Y + e.Y - m_mouseloc.Y);
            }
        }
    }
}