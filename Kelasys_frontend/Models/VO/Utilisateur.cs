using Kelasys_frontend.Enums;
using System;
using System.Collections.Generic;

namespace Kelasys_frontend.Models.VO {

    namespace Kelasys_backend.Models.VO {
        public class Utilisateur : IEquatable<Utilisateur> {
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Postnom { get; set; }
            public string Prenom { get; set; }
            public string Email { get; set; }
            public string NomUtilisateur { get; set; }
            public string MotDePasse { get; set; }
            public Sexe Sexe { get; set; }
            public DateTime DataNascimento { get; set; }
            public NiveauAcces NiveauAcces { get; set; }

            #region Equals and GetHashCode methods
            public bool Equals(Utilisateur other) {
                return other != null &&
                       Id == other.Id &&
                       Nom == other.Nom &&
                       Postnom == other.Postnom &&
                       Prenom == other.Prenom &&
                       Email == other.Email &&
                       NomUtilisateur == other.Email &&
                       MotDePasse == other.MotDePasse &&
                       Sexe == other.Sexe &&
                       DataNascimento == other.DataNascimento &&
                       NiveauAcces == other.NiveauAcces;
            }
            public override int GetHashCode() {
                int hashCode = -499023121;
                hashCode = hashCode * -1521134295 + Id.GetHashCode();
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Postnom);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomUtilisateur);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MotDePasse);
                hashCode = hashCode * -1521134295 + Sexe.GetHashCode();
                hashCode = hashCode * -1521134295 + DataNascimento.GetHashCode();
                hashCode = hashCode * -1521134295 + NiveauAcces.GetHashCode();
                return hashCode;
            }

            #endregion
        }
    }
}

