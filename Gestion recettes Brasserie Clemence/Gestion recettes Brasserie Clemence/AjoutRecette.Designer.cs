namespace Gestion_recettes_Brasserie_Clemence
{
    partial class AjoutRecette
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
            this.labelNomRecette = new System.Windows.Forms.Label();
            this.labelDateRecette = new System.Windows.Forms.Label();
            this.labelRecette = new System.Windows.Forms.Label();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.listeIngredient = new System.Windows.Forms.ListBox();
            this.labelIngredient = new System.Windows.Forms.Label();
            this.textNomRecette = new System.Windows.Forms.TextBox();
            this.textDateRecette = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textQuantiteIngredient = new System.Windows.Forms.TextBox();
            this.comboIngredient = new System.Windows.Forms.ComboBox();
            this.boutonIngredient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNomRecette
            // 
            this.labelNomRecette.AutoSize = true;
            this.labelNomRecette.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomRecette.Location = new System.Drawing.Point(132, 151);
            this.labelNomRecette.Name = "labelNomRecette";
            this.labelNomRecette.Size = new System.Drawing.Size(160, 18);
            this.labelNomRecette.TabIndex = 0;
            this.labelNomRecette.Text = "Nom de la recette :";
            // 
            // labelDateRecette
            // 
            this.labelDateRecette.AutoSize = true;
            this.labelDateRecette.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateRecette.Location = new System.Drawing.Point(28, 206);
            this.labelDateRecette.Name = "labelDateRecette";
            this.labelDateRecette.Size = new System.Drawing.Size(264, 18);
            this.labelDateRecette.TabIndex = 1;
            this.labelDateRecette.Text = "Date de création de la recette :";
            // 
            // labelRecette
            // 
            this.labelRecette.AutoSize = true;
            this.labelRecette.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecette.Location = new System.Drawing.Point(237, 48);
            this.labelRecette.Name = "labelRecette";
            this.labelRecette.Size = new System.Drawing.Size(287, 37);
            this.labelRecette.TabIndex = 3;
            this.labelRecette.Text = "Ajouter Recette";
            // 
            // boutonRetour
            // 
            this.boutonRetour.Location = new System.Drawing.Point(12, 456);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(114, 33);
            this.boutonRetour.TabIndex = 11;
            this.boutonRetour.Text = "Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.BoutonRetour_Click);
            // 
            // listeIngredient
            // 
            this.listeIngredient.FormattingEnabled = true;
            this.listeIngredient.Location = new System.Drawing.Point(598, 95);
            this.listeIngredient.Name = "listeIngredient";
            this.listeIngredient.Size = new System.Drawing.Size(189, 329);
            this.listeIngredient.TabIndex = 12;
            // 
            // labelIngredient
            // 
            this.labelIngredient.AutoSize = true;
            this.labelIngredient.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngredient.Location = new System.Drawing.Point(618, 77);
            this.labelIngredient.Name = "labelIngredient";
            this.labelIngredient.Size = new System.Drawing.Size(154, 15);
            this.labelIngredient.TabIndex = 13;
            this.labelIngredient.Text = "Liste d\'ingrédients :";
            // 
            // textNomRecette
            // 
            this.textNomRecette.Location = new System.Drawing.Point(298, 151);
            this.textNomRecette.Name = "textNomRecette";
            this.textNomRecette.Size = new System.Drawing.Size(158, 20);
            this.textNomRecette.TabIndex = 14;
            // 
            // textDateRecette
            // 
            this.textDateRecette.Location = new System.Drawing.Point(298, 206);
            this.textDateRecette.Name = "textDateRecette";
            this.textDateRecette.Size = new System.Drawing.Size(158, 20);
            this.textDateRecette.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom de l\'ingrédient :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quantité de l\'ingrédient :";
            // 
            // textQuantiteIngredient
            // 
            this.textQuantiteIngredient.Location = new System.Drawing.Point(299, 323);
            this.textQuantiteIngredient.Name = "textQuantiteIngredient";
            this.textQuantiteIngredient.Size = new System.Drawing.Size(158, 20);
            this.textQuantiteIngredient.TabIndex = 19;
            // 
            // comboIngredient
            // 
            this.comboIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIngredient.FormattingEnabled = true;
            this.comboIngredient.Location = new System.Drawing.Point(300, 265);
            this.comboIngredient.Name = "comboIngredient";
            this.comboIngredient.Size = new System.Drawing.Size(156, 21);
            this.comboIngredient.TabIndex = 20;
            // 
            // boutonIngredient
            // 
            this.boutonIngredient.Location = new System.Drawing.Point(326, 360);
            this.boutonIngredient.Name = "boutonIngredient";
            this.boutonIngredient.Size = new System.Drawing.Size(107, 22);
            this.boutonIngredient.TabIndex = 21;
            this.boutonIngredient.Text = "Ajouter Ingrédient";
            this.boutonIngredient.UseVisualStyleBackColor = true;
            this.boutonIngredient.Click += new System.EventHandler(this.BoutonIngredient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.Location = new System.Drawing.Point(633, 430);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(116, 22);
            this.boutonSupprimer.TabIndex = 23;
            this.boutonSupprimer.Text = "Supprimer Ingrédient";
            this.boutonSupprimer.UseVisualStyleBackColor = true;
            this.boutonSupprimer.Click += new System.EventHandler(this.BoutonSupprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "(litre, gramme, unité)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "AAAA-MM-JJ";
            // 
            // AjoutRecette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boutonIngredient);
            this.Controls.Add(this.comboIngredient);
            this.Controls.Add(this.textQuantiteIngredient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDateRecette);
            this.Controls.Add(this.textNomRecette);
            this.Controls.Add(this.labelIngredient);
            this.Controls.Add(this.listeIngredient);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.labelRecette);
            this.Controls.Add(this.labelDateRecette);
            this.Controls.Add(this.labelNomRecette);
            this.Name = "AjoutRecette";
            this.Text = "AjoutRecette";
            this.Load += new System.EventHandler(this.AjoutRecette_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomRecette;
        private System.Windows.Forms.Label labelDateRecette;
        private System.Windows.Forms.Label labelRecette;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.ListBox listeIngredient;
        private System.Windows.Forms.Label labelIngredient;
        private System.Windows.Forms.TextBox textNomRecette;
        private System.Windows.Forms.TextBox textDateRecette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textQuantiteIngredient;
        private System.Windows.Forms.ComboBox comboIngredient;
        private System.Windows.Forms.Button boutonIngredient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button boutonSupprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}