using Kelasys_frontend.Models.VO.Kelasys_backend.Models.VO;
using System;

namespace Kelasys_frontend.Services {
    class UtilisateurService : IUtilisateurService {
        #region Singleton not quite as lazy, but thread-safe without using locks

        private static readonly UtilisateurService _instance = new UtilisateurService();

        static UtilisateurService() {
        }

        private UtilisateurService() {
        }

        public static UtilisateurService Instance {
            get {
                return _instance;
            }
        }

        #endregion

        public Utilisateur Login(string nomUtilisateur, string motDePasse) {
            Console.WriteLine(nomUtilisateur + "" + motDePasse);

            return null;
        }

    }
}
