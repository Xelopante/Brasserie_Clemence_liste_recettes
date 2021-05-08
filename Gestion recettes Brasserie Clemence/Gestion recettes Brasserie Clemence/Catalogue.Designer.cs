namespace Gestion_recettes_Brasserie_Clemence
{
    partial class Catalogue
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
            this.labelCatalogue = new System.Windows.Forms.Label();
            this.labelRecette = new System.Windows.Forms.Label();
            this.listeRecette = new System.Windows.Forms.ComboBox();
            this.boutonModif = new System.Windows.Forms.Button();
            this.boutonConsult = new System.Windows.Forms.Button();
            this.boutonSupp = new System.Windows.Forms.Button();
            this.boutonDeco = new System.Windows.Forms.Button();
            this.boutonAjoutRecette = new System.Windows.Forms.Button();
            this.boutonAjoutIngredient = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelBIO = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCatalogue
            // 
            this.labelCatalogue.AutoSize = true;
            this.labelCatalogue.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatalogue.Location = new System.Drawing.Point(269, 52);
            this.labelCatalogue.Name = "labelCatalogue";
            this.labelCatalogue.Size = new System.Drawing.Size(179, 37);
            this.labelCatalogue.TabIndex = 1;
            this.labelCatalogue.Text = "Catalogue";
            // 
            // labelRecette
            // 
            this.labelRecette.AutoSize = true;
            this.labelRecette.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecette.Location = new System.Drawing.Point(194, 152);
            this.labelRecette.Name = "labelRecette";
            this.labelRecette.Size = new System.Drawing.Size(88, 18);
            this.labelRecette.TabIndex = 2;
            this.labelRecette.Text = "Recettes :";
            // 
            // listeRecette
            // 
            this.listeRecette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeRecette.FormattingEnabled = true;
            this.listeRecette.Location = new System.Drawing.Point(288, 152);
            this.listeRecette.Name = "listeRecette";
            this.listeRecette.Size = new System.Drawing.Size(187, 21);
            this.listeRecette.TabIndex = 3;
            this.listeRecette.SelectedIndexChanged += new System.EventHandler(this.listeRecette_SelectedIndexChanged);
            // 
            // boutonModif
            // 
            this.boutonModif.Location = new System.Drawing.Point(276, 266);
            this.boutonModif.Name = "boutonModif";
            this.boutonModif.Size = new System.Drawing.Size(150, 30);
            this.boutonModif.TabIndex = 4;
            this.boutonModif.Text = "Modifier";
            this.boutonModif.UseVisualStyleBackColor = true;
            this.boutonModif.Click += new System.EventHandler(this.BoutonModif_Click);
            // 
            // boutonConsult
            // 
            this.boutonConsult.Location = new System.Drawing.Point(276, 216);
            this.boutonConsult.Name = "boutonConsult";
            this.boutonConsult.Size = new System.Drawing.Size(150, 30);
            this.boutonConsult.TabIndex = 5;
            this.boutonConsult.Text = "Consulter";
            this.boutonConsult.UseVisualStyleBackColor = true;
            this.boutonConsult.Click += new System.EventHandler(this.BoutonConsult_Click);
            // 
            // boutonSupp
            // 
            this.boutonSupp.Location = new System.Drawing.Point(276, 317);
            this.boutonSupp.Name = "boutonSupp";
            this.boutonSupp.Size = new System.Drawing.Size(150, 30);
            this.boutonSupp.TabIndex = 6;
            this.boutonSupp.Text = "Supprimer";
            this.boutonSupp.UseVisualStyleBackColor = true;
            this.boutonSupp.Click += new System.EventHandler(this.BoutonSupp_Click);
            // 
            // boutonDeco
            // 
            this.boutonDeco.Location = new System.Drawing.Point(12, 416);
            this.boutonDeco.Name = "boutonDeco";
            this.boutonDeco.Size = new System.Drawing.Size(144, 22);
            this.boutonDeco.TabIndex = 7;
            this.boutonDeco.Text = "Déconnexion";
            this.boutonDeco.UseVisualStyleBackColor = true;
            this.boutonDeco.Click += new System.EventHandler(this.BoutonDeco_Click);
            // 
            // boutonAjoutRecette
            // 
            this.boutonAjoutRecette.Location = new System.Drawing.Point(537, 405);
            this.boutonAjoutRecette.Name = "boutonAjoutRecette";
            this.boutonAjoutRecette.Size = new System.Drawing.Size(150, 30);
            this.boutonAjoutRecette.TabIndex = 8;
            this.boutonAjoutRecette.Text = "Ajouter recette";
            this.boutonAjoutRecette.UseVisualStyleBackColor = true;
            this.boutonAjoutRecette.Click += new System.EventHandler(this.BoutonAjoutRecette_Click);
            // 
            // boutonAjoutIngredient
            // 
            this.boutonAjoutIngredient.Location = new System.Drawing.Point(537, 12);
            this.boutonAjoutIngredient.Name = "boutonAjoutIngredient";
            this.boutonAjoutIngredient.Size = new System.Drawing.Size(150, 30);
            this.boutonAjoutIngredient.TabIndex = 9;
            this.boutonAjoutIngredient.Text = "Ajouter ingrédient";
            this.boutonAjoutIngredient.UseVisualStyleBackColor = true;
            this.boutonAjoutIngredient.Click += new System.EventHandler(this.BoutonAjoutIngredient_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Voir ingrédients";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // labelBIO
            // 
            this.labelBIO.AutoSize = true;
            this.labelBIO.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBIO.ForeColor = System.Drawing.Color.Green;
            this.labelBIO.Location = new System.Drawing.Point(481, 152);
            this.labelBIO.Name = "labelBIO";
            this.labelBIO.Size = new System.Drawing.Size(36, 19);
            this.labelBIO.TabIndex = 13;
            this.labelBIO.Text = "BIO";
            this.labelBIO.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exporter catalogue en PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelBIO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.boutonAjoutIngredient);
            this.Controls.Add(this.boutonAjoutRecette);
            this.Controls.Add(this.boutonDeco);
            this.Controls.Add(this.boutonSupp);
            this.Controls.Add(this.boutonConsult);
            this.Controls.Add(this.boutonModif);
            this.Controls.Add(this.listeRecette);
            this.Controls.Add(this.labelRecette);
            this.Controls.Add(this.labelCatalogue);
            this.Name = "Catalogue";
            this.Text = "Catalogue";
            this.Load += new System.EventHandler(this.Catalogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCatalogue;
        private System.Windows.Forms.Label labelRecette;
        private System.Windows.Forms.ComboBox listeRecette;
        private System.Windows.Forms.Button boutonModif;
        private System.Windows.Forms.Button boutonConsult;
        private System.Windows.Forms.Button boutonSupp;
        private System.Windows.Forms.Button boutonDeco;
        private System.Windows.Forms.Button boutonAjoutRecette;
        private System.Windows.Forms.Button boutonAjoutIngredient;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelBIO;
        private System.Windows.Forms.Button button1;
    }
}