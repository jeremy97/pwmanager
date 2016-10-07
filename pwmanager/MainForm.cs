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
    public partial class MainForm : Form {
        private List<Info> info;
        private string pw;

        public MainForm() {
            InitializeComponent();
        }

        public MainForm(List<Info> userInfo, string password) {
            InitializeComponent();
            info = userInfo;
            pw = password;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            //populate grid with user data
            for(int i = 0; i < info.Count; i++) {
                Info x = info.ElementAt(i);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGrid);
                string[] vals = { x.label, x.username, x.password };
                row.SetValues(vals);
                dataGrid.Rows.Add(row);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Password DB Files|*.pwdb";
            sfd.Title = "Save a password database file";

            if (sfd.ShowDialog() == DialogResult.OK) {
                string filePath = sfd.FileName;
                refreshInfo();
                
                FileHandler.saveFile(pw, filePath, info);
            }
        }

        private void refreshInfo() {
            dataGrid.CurrentCell = null;
            List<Info> temp = new List<Info>();
            foreach (DataGridViewRow row in dataGrid.Rows) {
                Info info = new Info();
                if (row.Cells["labelColumn"].Value != null) {
                    info.label = row.Cells["labelColumn"].Value.ToString();
                }
                if (row.Cells["usernameColumn"].Value != null) {
                    info.username = row.Cells["usernameColumn"].Value.ToString();
                }
                if (row.Cells["passwordColumn"].Value != null) {
                    info.password = row.Cells["passwordColumn"].Value.ToString();
                }
                if (info.ToString() != "::") {
                    temp.Add(info);
                }
            }
            info = temp;
        }
    }
}
