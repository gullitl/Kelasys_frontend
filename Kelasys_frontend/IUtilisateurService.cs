using Kelasys_frontend.Models.VO.Kelasys_backend.Models.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelasys_frontend {
    interface IUtilisateurService {
        Utilisateur Login(string nomUtilisateur, string motDePasse);
    }
}
