namespace Gestion_recettes_Brasserie_Clemence
{
    partial class ModifierIngredient
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
            this.boutonAjouter = new System.Windows.Forms.Button();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.textNumeroBIO = new System.Windows.Forms.TextBox();
            this.textFournisseurIngredient = new System.Windows.Forms.TextBox();
            this.textNomIngredient = new System.Windows.Forms.TextBox();
            this.checkBIO = new System.Windows.Forms.CheckBox();
            this.labelNumeroBIO = new System.Windows.Forms.Label();
            this.labelFournisseurIngredient = new System.Windows.Forms.Label();
            this.labelNomIngredient = new System.Windows.Forms.Label();
            this.labelAjout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boutonAjouter
            // 
            this.boutonAjouter.Location = new System.Drawing.Point(194, 361);
            this.boutonAjouter.Name = "boutonAjouter";
            this.boutonAjouter.Size = new System.Drawing.Size(147, 29);
            this.boutonAjouter.TabIndex = 21;
            this.boutonAjouter.Text = "Modifier";
            this.boutonAjouter.UseVisualStyleBackColor = true;
            this.boutonAjouter.Click += new System.EventHandler(this.BoutonAjouter_Click);
            // 
            // boutonRetour
            // 
            this.boutonRetour.Location = new System.Drawing.Point(12, 409);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(114, 22);
            this.boutonRetour.TabIndex = 20;
            this.boutonRetour.Text = "Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.BoutonRetour_Click);
            // 
            // textNumeroBIO
            // 
            this.textNumeroBIO.Location = new System.Drawing.Point(313, 314);
            this.textNumeroBIO.Name = "textNumeroBIO";
            this.textNumeroBIO.Size = new System.Drawing.Size(157, 20);
            this.textNumeroBIO.TabIndex = 19;
            this.textNumeroBIO.Visible = false;
            // 
            // textFournisseurIngredient
            // 
            this.textFournisseurIngredient.Location = new System.Drawing.Point(313, 225);
            this.textFournisseurIngredient.Name = "textFournisseurIngredient";
            this.textFournisseurIngredient.Size = new System.Drawing.Size(157, 20);
            this.textFournisseurIngredient.TabIndex = 18;
            // 
            // textNomIngredient
            // 
            this.textNomIngredient.Location = new System.Drawing.Point(313, 167);
            this.textNomIngredient.Name = "textNomIngredient";
            this.textNomIngredient.Size = new System.Drawing.Size(157, 20);
            this.textNomIngredient.TabIndex = 17;
            // 
            // checkBIO
            // 
            this.checkBIO.AutoSize = true;
            this.checkBIO.Location = new System.Drawing.Point(145, 294);
            this.checkBIO.Name = "checkBIO";
            this.checkBIO.Size = new System.Drawing.Size(94, 17);
            this.checkBIO.TabIndex = 16;
            this.checkBIO.Text = "Ingrédient BIO";
            this.checkBIO.UseVisualStyleBackColor = true;
            this.checkBIO.CheckedChanged += new System.EventHandler(this.CheckBIO_CheckedChanged);
            // 
            // labelNumeroBIO
            // 
            this.labelNumeroBIO.AutoSize = true;
            this.labelNumeroBIO.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroBIO.Location = new System.Drawing.Point(75, 314);
            this.labelNumeroBIO.Name = "labelNumeroBIO";
            this.labelNumeroBIO.Size = new System.Drawing.Size(232, 18);
            this.labelNumeroBIO.TabIndex = 15;
            this.labelNumeroBIO.Text = "Numéro de l\'ingrédient BIO :";
            this.labelNumeroBIO.Visible = false;
            // 
            // labelFournisseurIngredient
            // 
            this.labelFournisseurIngredient.AutoSize = true;
            this.labelFournisseurIngredient.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFournisseurIngredient.Location = new System.Drawing.Point(67, 225);
            this.labelFournisseurIngredient.Name = "labelFournisseurIngredient";
            this.labelFournisseurIngredient.Size = new System.Drawing.Size(240, 18);
            this.labelFournisseurIngredient.TabIndex = 14;
            this.labelFournisseurIngredient.Text = "Fournisseur de l\'ingrédient :";
            // 
            // labelNomIngredient
            // 
            this.labelNomIngredient.AutoSize = true;
            this.labelNomIngredient.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomIngredient.Location = new System.Drawing.Point(131, 167);
            this.labelNomIngredient.Name = "labelNomIngredient";
            this.labelNomIngredient.Size = new System.Drawing.Size(176, 18);
            this.labelNomIngredient.TabIndex = 13;
            this.labelNomIngredient.Text = "Nom de l\'ingrédient :";
            // 
            // labelAjout
            // 
            this.labelAjout.AutoSize = true;
            this.labelAjout.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjout.Location = new System.Drawing.Point(89, 58);
            this.labelAjout.Name = "labelAjout";
            this.labelAjout.Size = new System.Drawing.Size(341, 37);
            this.labelAjout.TabIndex = 12;
            this.labelAjout.Text = "Ajouter Ingrédient";
            // 
            // ModifierIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 443);
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
            this.Name = "ModifierIngredient";
            this.Text = "ModifierIngredient";
            this.Load += new System.EventHandler(this.ModifierIngredient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonAjouter;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.TextBox textNumeroBIO;
        private System.Windows.Forms.TextBox textFournisseurIngredient;
        private System.Windows.Forms.TextBox textNomIngredient;
        private System.Windows.Forms.CheckBox checkBIO;
        private System.Windows.Forms.Label labelNumeroBIO;
        private System.Windows.Forms.Label labelFournisseurIngredient;
        private System.Windows.Forms.Label labelNomIngredient;
        private System.Windows.Forms.Label labelAjout;
    }
}