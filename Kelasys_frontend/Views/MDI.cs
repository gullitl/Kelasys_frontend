using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelasys_frontend.Views {
    public partial class MDI : Form {
        public MDI() {
            Application.Run(new Login());
            InitializeComponent();
        }
    }
}
