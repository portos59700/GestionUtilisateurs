namespace UtilisateursGUI
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLecture = new System.Windows.Forms.Button();
            this.btnEcriture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLecture
            // 
            this.btnLecture.Location = new System.Drawing.Point(59, 49);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(169, 46);
            this.btnLecture.TabIndex = 0;
            this.btnLecture.Text = "Lecture";
            this.btnLecture.UseVisualStyleBackColor = true;
            this.btnLecture.Click += new System.EventHandler(this.btnLecture_Click);
            // 
            // btnEcriture
            // 
            this.btnEcriture.Location = new System.Drawing.Point(59, 145);
            this.btnEcriture.Name = "btnEcriture";
            this.btnEcriture.Size = new System.Drawing.Size(169, 49);
            this.btnEcriture.TabIndex = 1;
            this.btnEcriture.Text = "Ecriture";
            this.btnEcriture.UseVisualStyleBackColor = true;
            this.btnEcriture.Click += new System.EventHandler(this.btnEcriture_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnEcriture);
            this.Controls.Add(this.btnLecture);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.Button btnEcriture;
    }
}

