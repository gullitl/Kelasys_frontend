using Kelasys_frontend.Models.VO.Kelasys_backend.Models.VO;
using Kelasys_frontend.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelasys_frontend.Views {
    public partial class Login : Form {
        private readonly IUtilisateurService _utilisateurSevice;
        public Login() {
            Application.Run(new SplashScreen());

            InitializeComponent();
            _utilisateurSevice = UtilisateurService.Instance;
        }

        private void BtnEntrer_Click(object sender, EventArgs e) {
            _utilisateurSevice.Login(txbUtilisateur.Text, txbMotDePasse.Text);
            this.Close();
        }
    }
}
