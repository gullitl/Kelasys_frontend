using System.Windows.Forms;

namespace Kelasys_frontend.Views {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnEntrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUtilisateur = new System.Windows.Forms.TextBox();
            this.txbMotDePasse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEntrer
            // 
            this.btnEntrer.Location = new System.Drawing.Point(224, 158);
            this.btnEntrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrer.Name = "btnEntrer";
            this.btnEntrer.Size = new System.Drawing.Size(109, 43);
            this.btnEntrer.TabIndex = 2;
            this.btnEntrer.Text = "Entrer";
            this.btnEntrer.UseVisualStyleBackColor = true;
            this.btnEntrer.Click += new System.EventHandler(this.BtnEntrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilisateur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe:";
            // 
            // txbUtilisateur
            // 
            this.txbUtilisateur.Location = new System.Drawing.Point(84, 49);
            this.txbUtilisateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUtilisateur.Name = "txbUtilisateur";
            this.txbUtilisateur.Size = new System.Drawing.Size(251, 20);
            this.txbUtilisateur.TabIndex = 0;
            // 
            // txbMotDePasse
            // 
            this.txbMotDePasse.Location = new System.Drawing.Point(84, 97);
            this.txbMotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMotDePasse.Name = "txbMotDePasse";
            this.txbMotDePasse.Size = new System.Drawing.Size(251, 20);
            this.txbMotDePasse.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.txbMotDePasse);
            this.Controls.Add(this.txbUtilisateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUtilisateur;
        private System.Windows.Forms.TextBox txbMotDePasse;
    }
}

