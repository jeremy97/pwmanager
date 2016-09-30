using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwmanager {
    public partial class LoginForm : Form {
        
        public LoginForm() {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Password DB Files|*.pwdb";
            if(ofd.ShowDialog() == DialogResult.OK) {
                int trimLen = ofd.FileName.LastIndexOf('\\') + 1;
                fileLbl.Text = "Selected file: " + ofd.FileName.Substring(trimLen);
                pwText.Enabled = true;
                unlockBtn.Enabled = true;
            }
        }

        private void pwText_TextChanged(object sender, EventArgs e) {
            if (unlockBtn.Enabled == false && pwText.Text != "")
                unlockBtn.Enabled = true;
            if (pwText.Text == "")
                unlockBtn.Enabled = false;
        }
    }
}
