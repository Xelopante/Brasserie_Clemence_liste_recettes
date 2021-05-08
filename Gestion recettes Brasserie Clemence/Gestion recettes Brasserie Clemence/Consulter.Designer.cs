namespace Gestion_recettes_Brasserie_Clemence
{
    partial class Consulter
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
            this.listeIngredients = new System.Windows.Forms.ListBox();
            this.labelRecette = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listeQuantite = new System.Windows.Forms.ListBox();
            this.textQuant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAjout
            // 
            this.labelAjout.AutoSize = true;
            this.labelAjout.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjout.Location = new System.Drawing.Point(216, 31);
            this.labelAjout.Name = "labelAjout";
            this.labelAjout.Size = new System.Drawing.Size(179, 37);
            this.labelAjout.TabIndex = 3;
            this.labelAjout.Text = "Consulter";
            // 
            // listeIngredients
            // 
            this.listeIngredients.FormattingEnabled = true;
            this.listeIngredients.Location = new System.Drawing.Point(291, 196);
            this.listeIngredients.Name = "listeIngredients";
            this.listeIngredients.Size = new System.Drawing.Size(132, 264);
            this.listeIngredients.TabIndex = 4;
            // 
            // labelRecette
            // 
            this.labelRecette.AutoSize = true;
            this.labelRecette.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecette.Location = new System.Drawing.Point(215, 77);
            this.labelRecette.Name = "labelRecette";
            this.labelRecette.Size = new System.Drawing.Size(180, 22);
            this.labelRecette.TabIndex = 5;
            this.labelRecette.Text = "Nom de la recette";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantité";
            // 
            // listeQuantite
            // 
            this.listeQuantite.FormattingEnabled = true;
            this.listeQuantite.Location = new System.Drawing.Point(449, 196);
            this.listeQuantite.Name = "listeQuantite";
            this.listeQuantite.Size = new System.Drawing.Size(132, 264);
            this.listeQuantite.TabIndex = 7;
            // 
            // textQuant
            // 
            this.textQuant.Location = new System.Drawing.Point(83, 255);
            this.textQuant.Name = "textQuant";
            this.textQuant.Size = new System.Drawing.Size(84, 20);
            this.textQuant.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 21);
            this.button2.TabIndex = 10;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingrédient :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantité :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "(litre, gramme, unité) :";
            // 
            // Consulter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textQuant);
            this.Controls.Add(this.listeQuantite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRecette);
            this.Controls.Add(this.listeIngredients);
            this.Controls.Add(this.labelAjout);
            this.Name = "Consulter";
            this.Text = "Consulter";
            this.Load += new System.EventHandler(this.Consulter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAjout;
        private System.Windows.Forms.ListBox listeIngredients;
        private System.Windows.Forms.Label labelRecette;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeQuantite;
        private System.Windows.Forms.TextBox textQuant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}