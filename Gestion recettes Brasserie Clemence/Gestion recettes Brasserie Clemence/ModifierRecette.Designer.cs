namespace Gestion_recettes_Brasserie_Clemence
{
    partial class ModifierRecette
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
            this.labelRecette = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDateCrea = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.boutonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRecette
            // 
            this.labelRecette.AutoSize = true;
            this.labelRecette.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecette.Location = new System.Drawing.Point(130, 46);
            this.labelRecette.Name = "labelRecette";
            this.labelRecette.Size = new System.Drawing.Size(305, 37);
            this.labelRecette.TabIndex = 2;
            this.labelRecette.Text = "Modifier recette";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(195, 142);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(48, 18);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom :";
            // 
            // labelDateCrea
            // 
            this.labelDateCrea.AutoSize = true;
            this.labelDateCrea.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateCrea.Location = new System.Drawing.Point(91, 189);
            this.labelDateCrea.Name = "labelDateCrea";
            this.labelDateCrea.Size = new System.Drawing.Size(152, 18);
            this.labelDateCrea.TabIndex = 4;
            this.labelDateCrea.Text = "Date de création :";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(249, 142);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(133, 20);
            this.textNom.TabIndex = 5;
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(249, 189);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(133, 20);
            this.textDate.TabIndex = 6;
            // 
            // boutonRetour
            // 
            this.boutonRetour.Location = new System.Drawing.Point(12, 264);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(99, 27);
            this.boutonRetour.TabIndex = 7;
            this.boutonRetour.Text = "Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.BoutonRetour_Click);
            // 
            // boutonValider
            // 
            this.boutonValider.Location = new System.Drawing.Point(449, 264);
            this.boutonValider.Name = "boutonValider";
            this.boutonValider.Size = new System.Drawing.Size(99, 27);
            this.boutonValider.TabIndex = 8;
            this.boutonValider.Text = "Valider";
            this.boutonValider.UseVisualStyleBackColor = true;
            this.boutonValider.Click += new System.EventHandler(this.BoutonValider_Click);
            // 
            // ModifierRecette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 303);
            this.Controls.Add(this.boutonValider);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.labelDateCrea);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelRecette);
            this.Name = "ModifierRecette";
            this.Text = "ModifierRecette";
            this.Load += new System.EventHandler(this.ModifierRecette_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRecette;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelDateCrea;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonValider;
    }
}