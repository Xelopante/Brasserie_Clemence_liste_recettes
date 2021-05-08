namespace Gestion_recettes_Brasserie_Clemence
{
    partial class VoirIngredient
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
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.listeIngredient = new System.Windows.Forms.ListBox();
            this.labelSupprimerIngredient = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.Location = new System.Drawing.Point(169, 407);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(101, 31);
            this.boutonSupprimer.TabIndex = 9;
            this.boutonSupprimer.Text = "Supprimer";
            this.boutonSupprimer.UseVisualStyleBackColor = true;
            this.boutonSupprimer.Click += new System.EventHandler(this.BoutonSupprimer_Click);
            // 
            // boutonRetour
            // 
            this.boutonRetour.Location = new System.Drawing.Point(17, 407);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(101, 31);
            this.boutonRetour.TabIndex = 8;
            this.boutonRetour.Text = "Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.BoutonRetour_Click);
            // 
            // listeIngredient
            // 
            this.listeIngredient.FormattingEnabled = true;
            this.listeIngredient.Location = new System.Drawing.Point(113, 94);
            this.listeIngredient.Name = "listeIngredient";
            this.listeIngredient.Size = new System.Drawing.Size(212, 264);
            this.listeIngredient.TabIndex = 7;
            // 
            // labelSupprimerIngredient
            // 
            this.labelSupprimerIngredient.AutoSize = true;
            this.labelSupprimerIngredient.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupprimerIngredient.Location = new System.Drawing.Point(110, 29);
            this.labelSupprimerIngredient.Name = "labelSupprimerIngredient";
            this.labelSupprimerIngredient.Size = new System.Drawing.Size(215, 37);
            this.labelSupprimerIngredient.TabIndex = 6;
            this.labelSupprimerIngredient.Text = "Ingrédients";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // VoirIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.listeIngredient);
            this.Controls.Add(this.labelSupprimerIngredient);
            this.Name = "VoirIngredient";
            this.Text = "VoirIngredient";
            this.Load += new System.EventHandler(this.VoirIngredient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonSupprimer;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.ListBox listeIngredient;
        private System.Windows.Forms.Label labelSupprimerIngredient;
        private System.Windows.Forms.Button button1;
    }
}