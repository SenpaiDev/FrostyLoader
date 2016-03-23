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
using System.IO;

namespace LoaderWHichWIllWork {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            foreach (Process proc in Process.GetProcesses()) {
                listBox1.Items.Add(proc.ProcessName);
            }
        }
        
        private void listBox1_DoubleClick(object sender, EventArgs e) {
            if(listBox1.SelectedItem != null) {
                DllInjectionResult result = DllInjector.GetInstance.Inject(listBox1.SelectedItem.ToString(), Directory.GetCurrentDirectory() + "\\Titanium.dll");
                File.WriteAllText("GameInjectedInto", listBox1.SelectedItem.ToString());
                if(result == DllInjectionResult.Success) {
                    Application.Exit();
                }
            }

        }
    }
}
