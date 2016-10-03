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
            List<Info> temp = new List<Info>();
            foreach (DataGridViewRow row in dataGrid.Rows) {
                if(row.Cells[1].Value != null) {
                    temp.Add(new Info(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString()));
                }
            }
        }
    }
}
