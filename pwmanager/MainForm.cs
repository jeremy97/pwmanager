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

        public MainForm() {
            InitializeComponent();
        }

        public MainForm(List<Info> userInfo) {
            InitializeComponent();
            info = userInfo;
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }
    }
}
