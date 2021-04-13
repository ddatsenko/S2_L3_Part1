using System;
using System.Windows.Forms;

namespace WіnQuestіon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mи й не сумнівалися, що Ви так думаєте!");
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNo.Top -= e.Y;
            btnNo.Left += e.X;
            if (btnNo.Top < -10 || btnNo.Top > 100) btnNo.Top = 60;
            if (btnNo.Left < -80 || btnNo.Left > 250) btnNo.Left = 120;
        }
    }
}
