
namespace WindowsFormsApp3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_prenom = new System.Windows.Forms.TextBox();
            this.text_cours = new System.Windows.Forms.TextBox();
            this.text_note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_num_etudiant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_code = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_titre = new System.Windows.Forms.TextBox();
            this.btn_ajoutCours = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(495, 58);
            this.text_nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(132, 22);
            this.text_nom.TabIndex = 2;
            this.text_nom.TextChanged += new System.EventHandler(this.text_nom_TextChanged);
            // 
            // text_prenom
            // 
            this.text_prenom.Location = new System.Drawing.Point(816, 58);
            this.text_prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(132, 22);
            this.text_prenom.TabIndex = 3;
            // 
            // text_cours
            // 
            this.text_cours.Location = new System.Drawing.Point(217, 160);
            this.text_cours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_cours.Name = "text_cours";
            this.text_cours.Size = new System.Drawing.Size(132, 22);
            this.text_cours.TabIndex = 4;
            // 
            // text_note
            // 
            this.text_note.Location = new System.Drawing.Point(217, 318);
            this.text_note.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_note.Name = "text_note";
            this.text_note.Size = new System.Drawing.Size(132, 22);
            this.text_note.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numéro du cours";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(463, 481);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(149, 28);
            this.btn_ajouter.TabIndex = 8;
            this.btn_ajouter.Text = "Initialiser";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(671, 481);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(141, 28);
            this.btn_enregistrer.TabIndex = 9;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(239, 423);
            this.message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 17);
            this.message.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numéro d\'étudiant";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // text_num_etudiant
            // 
            this.text_num_etudiant.Location = new System.Drawing.Point(217, 58);
            this.text_num_etudiant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_num_etudiant.Name = "text_num_etudiant";
            this.text_num_etudiant.Size = new System.Drawing.Size(132, 22);
            this.text_num_etudiant.TabIndex = 12;
            this.text_num_etudiant.TextChanged += new System.EventHandler(this.text_num_etudiant_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Code";
            // 
            // text_code
            // 
            this.text_code.Location = new System.Drawing.Point(217, 206);
            this.text_code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(132, 22);
            this.text_code.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Titre";
            // 
            // text_titre
            // 
            this.text_titre.Location = new System.Drawing.Point(217, 260);
            this.text_titre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_titre.Name = "text_titre";
            this.text_titre.Size = new System.Drawing.Size(132, 22);
            this.text_titre.TabIndex = 15;
            // 
            // btn_ajoutCours
            // 
            this.btn_ajoutCours.Location = new System.Drawing.Point(151, 391);
            this.btn_ajoutCours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ajoutCours.Name = "btn_ajoutCours";
            this.btn_ajoutCours.Size = new System.Drawing.Size(132, 28);
            this.btn_ajoutCours.TabIndex = 17;
            this.btn_ajoutCours.Text = "Ajouter Cours";
            this.btn_ajoutCours.UseVisualStyleBackColor = true;
            this.btn_ajoutCours.Click += new System.EventHandler(this.btn_ajoutCours_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(379, 160);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(657, 278);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 596);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_ajoutCours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_titre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_code);
            this.Controls.Add(this.text_num_etudiant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.message);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_note);
            this.Controls.Add(this.text_cours);
            this.Controls.Add(this.text_prenom);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_prenom;
        private System.Windows.Forms.TextBox text_cours;
        private System.Windows.Forms.TextBox text_note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_num_etudiant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_titre;
        private System.Windows.Forms.Button btn_ajoutCours;
        private System.Windows.Forms.ListView listView1;
    }
}

