using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FrostyLoader {
    public partial class ProccessList : Form {
        public ProccessList() {
            InitializeComponent();
        }
        public void ProccessList_Load(object sender, EventArgs e) {
            foreach(Process theprocces in Process.GetProcesses()) {
                ProcessListINForm.Items.Add(theprocces.ProcessName);
            }
        }

        private void ProcessListINForm_DoubleClick(object sender, EventArgs e) {

        }
    }
}
