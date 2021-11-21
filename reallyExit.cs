using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmlOldViewer
{
    public partial class reallyExit : Form
    {
        public reallyExit()
        {
            InitializeComponent();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
