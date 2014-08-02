namespace Windows_forms_projet_ENI
{
    partial class NEW_UPD_JURE
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
            this.lbl_civilite = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_dat_naissance = new System.Windows.Forms.Label();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_societe = new System.Windows.Forms.Label();
            this.lbl_lieu_naissance = new System.Windows.Forms.Label();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.lbl_cp = new System.Windows.Forms.Label();
            this.lbl_adr_1 = new System.Windows.Forms.Label();
            this.cbx_civilite = new System.Windows.Forms.ComboBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_dat_naissance = new System.Windows.Forms.TextBox();
            this.txt_distance = new System.Windows.Forms.TextBox();
            this.txt_adr_1 = new System.Windows.Forms.TextBox();
            this.txt_adr_2 = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_lieu_naissance = new System.Windows.Forms.TextBox();
            this.txt_societe = new System.Windows.Forms.TextBox();
            this.grp_homologation = new System.Windows.Forms.GroupBox();
            this.dgv_homologation = new System.Windows.Forms.DataGridView();
            this.dgv_homologation_titre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgv_homologation_dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_homologation_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.rtxt_notes = new System.Windows.Forms.RichTextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.grp_homologation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_homologation)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_civilite
            // 
            this.lbl_civilite.AutoSize = true;
            this.lbl_civilite.Location = new System.Drawing.Point(12, 15);
            this.lbl_civilite.Name = "lbl_civilite";
            this.lbl_civilite.Size = new System.Drawing.Size(43, 13);
            this.lbl_civilite.TabIndex = 1;
            this.lbl_civilite.Text = "Civilité :";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(12, 42);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 2;
            this.lbl_nom.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(12, 68);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 3;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(12, 94);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(64, 13);
            this.lbl_tel.TabIndex = 4;
            this.lbl_tel.Text = "Téléphone :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 120);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 13);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "E-mail :";
            // 
            // lbl_dat_naissance
            // 
            this.lbl_dat_naissance.AutoSize = true;
            this.lbl_dat_naissance.Location = new System.Drawing.Point(12, 146);
            this.lbl_dat_naissance.Name = "lbl_dat_naissance";
            this.lbl_dat_naissance.Size = new System.Drawing.Size(87, 13);
            this.lbl_dat_naissance.TabIndex = 6;
            this.lbl_dat_naissance.Text = "Date naissance :";
            // 
            // lbl_distance
            // 
            this.lbl_distance.AutoSize = true;
            this.lbl_distance.Location = new System.Drawing.Point(12, 172);
            this.lbl_distance.Name = "lbl_distance";
            this.lbl_distance.Size = new System.Drawing.Size(78, 13);
            this.lbl_distance.TabIndex = 7;
            this.lbl_distance.Text = "Distance A/R :";
            // 
            // lbl_societe
            // 
            this.lbl_societe.AutoSize = true;
            this.lbl_societe.Location = new System.Drawing.Point(255, 172);
            this.lbl_societe.Name = "lbl_societe";
            this.lbl_societe.Size = new System.Drawing.Size(49, 13);
            this.lbl_societe.TabIndex = 13;
            this.lbl_societe.Text = "Société :";
            // 
            // lbl_lieu_naissance
            // 
            this.lbl_lieu_naissance.AutoSize = true;
            this.lbl_lieu_naissance.Location = new System.Drawing.Point(255, 146);
            this.lbl_lieu_naissance.Name = "lbl_lieu_naissance";
            this.lbl_lieu_naissance.Size = new System.Drawing.Size(99, 13);
            this.lbl_lieu_naissance.TabIndex = 12;
            this.lbl_lieu_naissance.Text = "Lieu de naissance :";
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(255, 94);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(32, 13);
            this.lbl_ville.TabIndex = 11;
            this.lbl_ville.Text = "Ville :";
            // 
            // lbl_cp
            // 
            this.lbl_cp.AutoSize = true;
            this.lbl_cp.Location = new System.Drawing.Point(255, 68);
            this.lbl_cp.Name = "lbl_cp";
            this.lbl_cp.Size = new System.Drawing.Size(69, 13);
            this.lbl_cp.TabIndex = 10;
            this.lbl_cp.Text = "Code postal :";
            // 
            // lbl_adr_1
            // 
            this.lbl_adr_1.AutoSize = true;
            this.lbl_adr_1.Location = new System.Drawing.Point(255, 16);
            this.lbl_adr_1.Name = "lbl_adr_1";
            this.lbl_adr_1.Size = new System.Drawing.Size(51, 13);
            this.lbl_adr_1.TabIndex = 8;
            this.lbl_adr_1.Text = "Adresse :";
            // 
            // cbx_civilite
            // 
            this.cbx_civilite.FormattingEnabled = true;
            this.cbx_civilite.Location = new System.Drawing.Point(105, 12);
            this.cbx_civilite.Name = "cbx_civilite";
            this.cbx_civilite.Size = new System.Drawing.Size(144, 21);
            this.cbx_civilite.TabIndex = 14;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(105, 39);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(144, 20);
            this.txt_nom.TabIndex = 15;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(105, 65);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(144, 20);
            this.txt_prenom.TabIndex = 16;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(105, 91);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(144, 20);
            this.txt_tel.TabIndex = 17;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(105, 117);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(144, 20);
            this.txt_email.TabIndex = 18;
            // 
            // txt_dat_naissance
            // 
            this.txt_dat_naissance.Location = new System.Drawing.Point(105, 143);
            this.txt_dat_naissance.Name = "txt_dat_naissance";
            this.txt_dat_naissance.Size = new System.Drawing.Size(144, 20);
            this.txt_dat_naissance.TabIndex = 19;
            // 
            // txt_distance
            // 
            this.txt_distance.Location = new System.Drawing.Point(105, 169);
            this.txt_distance.Name = "txt_distance";
            this.txt_distance.Size = new System.Drawing.Size(144, 20);
            this.txt_distance.TabIndex = 20;
            // 
            // txt_adr_1
            // 
            this.txt_adr_1.Location = new System.Drawing.Point(360, 13);
            this.txt_adr_1.Name = "txt_adr_1";
            this.txt_adr_1.Size = new System.Drawing.Size(144, 20);
            this.txt_adr_1.TabIndex = 21;
            // 
            // txt_adr_2
            // 
            this.txt_adr_2.Location = new System.Drawing.Point(360, 39);
            this.txt_adr_2.Name = "txt_adr_2";
            this.txt_adr_2.Size = new System.Drawing.Size(144, 20);
            this.txt_adr_2.TabIndex = 22;
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(360, 65);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(144, 20);
            this.txt_cp.TabIndex = 23;
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(360, 91);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(144, 20);
            this.txt_ville.TabIndex = 24;
            // 
            // txt_lieu_naissance
            // 
            this.txt_lieu_naissance.Location = new System.Drawing.Point(360, 143);
            this.txt_lieu_naissance.Name = "txt_lieu_naissance";
            this.txt_lieu_naissance.Size = new System.Drawing.Size(144, 20);
            this.txt_lieu_naissance.TabIndex = 26;
            // 
            // txt_societe
            // 
            this.txt_societe.Location = new System.Drawing.Point(360, 169);
            this.txt_societe.Name = "txt_societe";
            this.txt_societe.Size = new System.Drawing.Size(144, 20);
            this.txt_societe.TabIndex = 27;
            // 
            // grp_homologation
            // 
            this.grp_homologation.Controls.Add(this.dgv_homologation);
            this.grp_homologation.Location = new System.Drawing.Point(15, 195);
            this.grp_homologation.Name = "grp_homologation";
            this.grp_homologation.Size = new System.Drawing.Size(557, 92);
            this.grp_homologation.TabIndex = 28;
            this.grp_homologation.TabStop = false;
            this.grp_homologation.Text = "Homologation";
            // 
            // dgv_homologation
            // 
            this.dgv_homologation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_homologation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_homologation_titre,
            this.dgv_homologation_dat,
            this.dgv_homologation_del});
            this.dgv_homologation.Location = new System.Drawing.Point(6, 19);
            this.dgv_homologation.Name = "dgv_homologation";
            this.dgv_homologation.Size = new System.Drawing.Size(545, 67);
            this.dgv_homologation.TabIndex = 0;
            // 
            // dgv_homologation_titre
            // 
            this.dgv_homologation_titre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_homologation_titre.HeaderText = "Titre";
            this.dgv_homologation_titre.Name = "dgv_homologation_titre";
            // 
            // dgv_homologation_dat
            // 
            this.dgv_homologation_dat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_homologation_dat.HeaderText = "Date homologation";
            this.dgv_homologation_dat.Name = "dgv_homologation_dat";
            // 
            // dgv_homologation_del
            // 
            this.dgv_homologation_del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_homologation_del.HeaderText = "Delete";
            this.dgv_homologation_del.Name = "dgv_homologation_del";
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Location = new System.Drawing.Point(12, 290);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(41, 13);
            this.lbl_notes.TabIndex = 29;
            this.lbl_notes.Text = "Notes :";
            // 
            // rtxt_notes
            // 
            this.rtxt_notes.Location = new System.Drawing.Point(15, 306);
            this.rtxt_notes.Name = "rtxt_notes";
            this.rtxt_notes.Size = new System.Drawing.Size(557, 64);
            this.rtxt_notes.TabIndex = 30;
            this.rtxt_notes.Text = "";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(428, 376);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(144, 23);
            this.btn_valider.TabIndex = 31;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // NEW_UPD_JURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.rtxt_notes);
            this.Controls.Add(this.lbl_notes);
            this.Controls.Add(this.grp_homologation);
            this.Controls.Add(this.txt_societe);
            this.Controls.Add(this.txt_lieu_naissance);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.txt_adr_2);
            this.Controls.Add(this.txt_adr_1);
            this.Controls.Add(this.txt_distance);
            this.Controls.Add(this.txt_dat_naissance);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.cbx_civilite);
            this.Controls.Add(this.lbl_societe);
            this.Controls.Add(this.lbl_lieu_naissance);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.lbl_cp);
            this.Controls.Add(this.lbl_adr_1);
            this.Controls.Add(this.lbl_distance);
            this.Controls.Add(this.lbl_dat_naissance);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_civilite);
            this.Name = "NEW_UPD_JURE";
            this.Text = "Nouveau / Modifier juré";
            this.grp_homologation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_homologation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_civilite;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_dat_naissance;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Label lbl_societe;
        private System.Windows.Forms.Label lbl_lieu_naissance;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.Label lbl_cp;
        private System.Windows.Forms.Label lbl_adr_1;
        private System.Windows.Forms.ComboBox cbx_civilite;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_dat_naissance;
        private System.Windows.Forms.TextBox txt_distance;
        private System.Windows.Forms.TextBox txt_adr_1;
        private System.Windows.Forms.TextBox txt_adr_2;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.TextBox txt_lieu_naissance;
        private System.Windows.Forms.TextBox txt_societe;
        private System.Windows.Forms.GroupBox grp_homologation;
        private System.Windows.Forms.DataGridView dgv_homologation;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgv_homologation_titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_homologation_dat;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_homologation_del;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.RichTextBox rtxt_notes;
        private System.Windows.Forms.Button btn_valider;
    }
}