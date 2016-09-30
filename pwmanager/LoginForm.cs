using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwmanager {
    public partial class LoginForm : Form {
        string filePath = "";

        public LoginForm() {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Password DB Files|*.pwdb";
            if(ofd.ShowDialog() == DialogResult.OK) {
                filePath = ofd.FileName;
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

        private void unlockBtn_Click(object sender, EventArgs e) {
            using (StreamReader sr = new StreamReader(filePath)){
                string hash = sr.ReadLine();
                if(String.Compare(PasswordHash.HashPassword(pwText.Text), hash) == 0) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        if (line.Contains(":")){
                            //It's a line of account info

                        }
                        else {
                            //It's the checksum

                        }
                    }
                }
                else {
                    MessageBox.Show("Invalid password.");
                }
            }
        }
    }
}
