﻿using System;
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
        string filePath;

        public LoginForm() {
            InitializeComponent();
        }

        public LoginForm(string path) {
            InitializeComponent();

            if(path != "" && Path.GetExtension(path).ToLower() != ".pwdb") {
                filePath = path;
                int trimLen = path.LastIndexOf('\\') + 1;
                fileLbl.Text = "Selected file: " + path.Substring(trimLen);
            }
            else {
                MessageBox.Show("Openend file is not .pwdb file", "File Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openBtn_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a password database file";
            ofd.Filter = "Password DB Files|*.pwdb";
            if(ofd.ShowDialog() == DialogResult.OK) {
                filePath = ofd.FileName;
                int trimLen = ofd.FileName.LastIndexOf('\\') + 1;
                fileLbl.Text = "Selected file: " + ofd.FileName.Substring(trimLen);
                pwText.Enabled = true;
            }
        }

        private void unlockBtn_Click(object sender, EventArgs e) {
            List<Info> info = FileHandler.openFile(pwText.Text, filePath);
            if(info != null) {
                Hide();
                MainForm mf = new MainForm(info, pwText.Text);
                mf.FormClosed += (s, args) => Close();
                mf.Show();
            }
            else {
                MessageBox.Show("Invalid file");
            }
        }

        private void createBtn_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Password DB Files|*.pwdb";
            sfd.Title = "Save a password database file";
            
            if(sfd.ShowDialog() == DialogResult.OK) {
                filePath = sfd.FileName;
                FileHandler.initFile(pwCreateText.Text, filePath);
                List<Info> info = FileHandler.openFile(pwCreateText.Text, filePath);
                if (info != null) {
                    Hide();
                    MainForm mf = new MainForm(info, pwText.Text);
                    mf.FormClosed += (s, args) => Close();
                    mf.Show();
                }
            }
        }

        private void pwCreateText_TextChanged(object sender, EventArgs e) {
            if (pwCreateText.Text.Length == 0)
                createBtn.Enabled = false;
            if (pwCreateText.Text.Length > 0)
                createBtn.Enabled = true;
        }

        private void pwText_TextChanged(object sender, EventArgs e) {
            if (pwText.Text.Length == 0)
                unlockBtn.Enabled = false;
            if (pwText.Text.Length > 0)
                unlockBtn.Enabled = true;
        }
    }
}
