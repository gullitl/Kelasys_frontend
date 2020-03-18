using System;
using System.Windows.Forms;

namespace Kelasys_frontend.Views {
    public partial class SplashScreen : Form {
        private int x = 0;
        public SplashScreen() {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            System.Environment.Exit(0);
        }

        private void Timer_Tick(object sender, EventArgs e) {
            this.x += 3;
            if (this.x >= 700) {
                timer.Stop();
                this.Close();
            }
        }
    }
}
