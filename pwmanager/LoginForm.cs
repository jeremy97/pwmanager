using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Cryptography;
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
                        List<Info> userInfo = new List<Info>();

                        if (line.Contains(":")){
                            //It's a line of account info
                            string[] split = line.Split(':');
                            Info temp = new Info();
                            //Load values into Info data struct for organization
                            temp.label = Encrypt.DecryptString(split[0], pwText.Text);
                            temp.username = Encrypt.DecryptString(split[1], pwText.Text);
                            temp.password = Encrypt.DecryptString(split[2], pwText.Text);
                            temp.date = Encrypt.DecryptString(split[3], pwText.Text);
                            //Put the new Info object into a list
                            userInfo.Add(temp);
                        }
                        else {
                            //It's the checksum
                            using (var md5 = MD5.Create()) {
                                var binFormatter = new BinaryFormatter();
                                var memStream = new MemoryStream();
                                binFormatter.Serialize(memStream, userInfo);

                                if(line.CompareTo(md5.ComputeHash(memStream.ToArray()).ToString()) == 0) {
                                    //Hashes match, no tampering
                                    MainForm mf = new MainForm(userInfo);
                                    mf.Show();
                                    Close();
                                    continue;
                                }
                                else {
                                    MessageBox.Show("Checksum error. File has been tampered with and cannot be opened.");
                                    continue;
                                }
                            }
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
