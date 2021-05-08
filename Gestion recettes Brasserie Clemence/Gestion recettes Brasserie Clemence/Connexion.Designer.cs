namespace Gestion_recettes_Brasserie_Clemence
{
    partial class Connexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelConnexion = new System.Windows.Forms.Label();
            this.boutonQuitter = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textMdp = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.boutonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConnexion
            // 
            this.labelConnexion.AutoSize = true;
            this.labelConnexion.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.Location = new System.Drawing.Point(226, 46);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(179, 37);
            this.labelConnexion.TabIndex = 0;
            this.labelConnexion.Text = "Connexion";
            // 
            // boutonQuitter
            // 
            this.boutonQuitter.Location = new System.Drawing.Point(21, 309);
            this.boutonQuitter.Name = "boutonQuitter";
            this.boutonQuitter.Size = new System.Drawing.Size(107, 25);
            this.boutonQuitter.TabIndex = 1;
            this.boutonQuitter.Text = "Quitter";
            this.boutonQuitter.UseVisualStyleBackColor = true;
            this.boutonQuitter.Click += new System.EventHandler(this.BoutonQuitter_Click);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(224, 134);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(252, 20);
            this.textLogin.TabIndex = 2;
            // 
            // textMdp
            // 
            this.textMdp.Location = new System.Drawing.Point(224, 186);
            this.textMdp.Name = "textMdp";
            this.textMdp.PasswordChar = '*';
            this.textMdp.Size = new System.Drawing.Size(252, 20);
            this.textMdp.TabIndex = 3;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(106, 134);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(112, 18);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Identifiant :";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdp.Location = new System.Drawing.Point(98, 186);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(120, 18);
            this.labelMdp.TabIndex = 5;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // boutonConnect
            // 
            this.boutonConnect.Location = new System.Drawing.Point(244, 239);
            this.boutonConnect.Name = "boutonConnect";
            this.boutonConnect.Size = new System.Drawing.Size(143, 28);
            this.boutonConnect.TabIndex = 6;
            this.boutonConnect.Text = "Valider";
            this.boutonConnect.UseVisualStyleBackColor = true;
            this.boutonConnect.Click += new System.EventHandler(this.BoutonConnect_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 352);
            this.Controls.Add(this.boutonConnect);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textMdp);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.boutonQuitter);
            this.Controls.Add(this.labelConnexion);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.Button boutonQuitter;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textMdp;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Button boutonConnect;
    }
}