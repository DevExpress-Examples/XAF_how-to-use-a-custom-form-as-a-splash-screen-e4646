using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomSplashForm.Win {
    public partial class SplashScreenForm : Form {
        public SplashScreenForm() {
            InitializeComponent();
        }
        internal void UpdateInfo(string info) {
            label2.Text = info;
        }
    }
}
