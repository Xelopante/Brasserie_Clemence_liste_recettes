namespace Gestion_recettes_Brasserie_Clemence
{
    partial class AjoutIngredient
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
            this.labelAjout = new System.Windows.Forms.Label();
            this.labelNomIngredient = new System.Windows.Forms.Label();
            this.labelFournisseurIngredient = new System.Windows.Forms.Label();
            this.labelNumeroBIO = new System.Windows.Forms.Label();
            this.checkBIO = new System.Windows.Forms.CheckBox();
            this.textNomIngredient = new System.Windows.Forms.TextBox();
            this.textFournisseurIngredient = new System.Windows.Forms.TextBox();
            this.textNumeroBIO = new System.Windows.Forms.TextBox();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.boutonAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAjout
            // 
            this.labelAjout.AutoSize = true;
            this.labelAjout.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjout.Location = new System.Drawing.Point(124, 56);
            this.labelAjout.Name = "labelAjout";
            this.labelAjout.Size = new System.Drawing.Size(341, 37);
            this.labelAjout.TabIndex = 2;
            this.labelAjout.Text = "Ajouter Ingrédient";
            // 
            // labelNomIngredient
            // 
            this.labelNomIngredient.AutoSize = true;
            this.labelNomIngredient.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomIngredient.Location = new System.Drawing.Point(149, 161);
            this.labelNomIngredient.Name = "labelNomIngredient";
            this.labelNomIngredient.Size = new System.Drawing.Size(176, 18);
            this.labelNomIngredient.TabIndex = 3;
            this.labelNomIngredient.Text = "Nom de l\'ingrédient :";
            // 
            // labelFournisseurIngredient
            // 
            this.labelFournisseurIngredient.AutoSize = true;
            this.labelFournisseurIngredient.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFournisseurIngredient.Location = new System.Drawing.Point(85, 219);
            this.labelFournisseurIngredient.Name = "labelFournisseurIngredient";
            this.labelFournisseurIngredient.Size = new System.Drawing.Size(240, 18);
            this.labelFournisseurIngredient.TabIndex = 4;
            this.labelFournisseurIngredient.Text = "Fournisseur de l\'ingrédient :";
            // 
            // labelNumeroBIO
            // 
            this.labelNumeroBIO.AutoSize = true;
            this.labelNumeroBIO.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroBIO.Location = new System.Drawing.Point(93, 308);
            this.labelNumeroBIO.Name = "labelNumeroBIO";
            this.labelNumeroBIO.Size = new System.Drawing.Size(232, 18);
            this.labelNumeroBIO.TabIndex = 5;
            this.labelNumeroBIO.Text = "Numéro de l\'ingrédient BIO :";
            this.labelNumeroBIO.Visible = false;
            // 
            // checkBIO
            // 
            this.checkBIO.AutoSize = true;
            this.checkBIO.Location = new System.Drawing.Point(163, 288);
            this.checkBIO.Name = "checkBIO";
            this.checkBIO.Size = new System.Drawing.Size(94, 17);
            this.checkBIO.TabIndex = 6;
            this.checkBIO.Text = "Ingrédient BIO";
            this.checkBIO.UseVisualStyleBackColor = true;
            this.checkBIO.CheckedChanged += new System.EventHandler(this.CheckBIO_CheckedChanged);
            // 
            // textNomIngredient
            // 
            this.textNomIngredient.Location = new System.Drawing.Point(331, 161);
            this.textNomIngredient.Name = "textNomIngredient";
            this.textNomIngredient.Size = new System.Drawing.Size(157, 20);
            this.textNomIngredient.TabIndex = 7;
            // 
            // textFournisseurIngredient
            // 
            this.textFournisseurIngredient.Location = new System.Drawing.Point(331, 219);
            this.textFournisseurIngredient.Name = "textFournisseurIngredient";
            this.textFournisseurIngredient.Size = new System.Drawing.Size(157, 20);
            this.textFournisseurIngredient.TabIndex = 8;
            // 
            // textNumeroBIO
            // 
            this.textNumeroBIO.Location = new System.Drawing.Point(331, 308);
            this.textNumeroBIO.Name = "textNumeroBIO";
            this.textNumeroBIO.Size = new System.Drawing.Size(157, 20);
            this.textNumeroBIO.TabIndex = 9;
            this.textNumeroBIO.Visible = false;
            // 
            // boutonRetour
            // 
            this.boutonRetour.Location = new System.Drawing.Point(12, 397);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(114, 22);
            this.boutonRetour.TabIndex = 10;
            this.boutonRetour.Text = "Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.Button1_Click);
            // 
            // boutonAjouter
            // 
            this.boutonAjouter.Location = new System.Drawing.Point(212, 355);
            this.boutonAjouter.Name = "boutonAjouter";
            this.boutonAjouter.Size = new System.Drawing.Size(147, 29);
            this.boutonAjouter.TabIndex = 11;
            this.boutonAjouter.Text = "Ajouter";
            this.boutonAjouter.UseVisualStyleBackColor = true;
            this.boutonAjouter.Click += new System.EventHandler(this.BoutonAjouter_Click);
            // 
            // AjoutIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 431);
            this.Controls.Add(this.boutonAjouter);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.textNumeroBIO);
            this.Controls.Add(this.textFournisseurIngredient);
            this.Controls.Add(this.textNomIngredient);
            this.Controls.Add(this.checkBIO);
            this.Controls.Add(this.labelNumeroBIO);
            this.Controls.Add(this.labelFournisseurIngredient);
            this.Controls.Add(this.labelNomIngredient);
            this.Controls.Add(this.labelAjout);
            this.Name = "AjoutIngredient";
            this.Text = "AjoutIngredient";
            this.Load += new System.EventHandler(this.AjoutIngredient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAjout;
        private System.Windows.Forms.Label labelNomIngredient;
        private System.Windows.Forms.Label labelFournisseurIngredient;
        private System.Windows.Forms.Label labelNumeroBIO;
        private System.Windows.Forms.CheckBox checkBIO;
        private System.Windows.Forms.TextBox textNomIngredient;
        private System.Windows.Forms.TextBox textFournisseurIngredient;
        private System.Windows.Forms.TextBox textNumeroBIO;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonAjouter;
    }
}