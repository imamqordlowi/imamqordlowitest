using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTest
{
    public partial class FileConverter : Form
    {
        public FileConverter()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void adminSecurityToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            var newForm = new AdminSecurity();
            newForm.Show();
        }
    }
}
