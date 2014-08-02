namespace Windows_forms_projet_ENI
{
    partial class NEW_UPD_SESSION
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
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_deb_session = new System.Windows.Forms.Label();
            this.lbl_fin_session = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.cbx_titre = new System.Windows.Forms.ComboBox();
            this.dtp_deb_session = new System.Windows.Forms.DateTimePicker();
            this.dtp_fin_session = new System.Windows.Forms.DateTimePicker();
            this.btn_aff_stagiaire = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.dgv_stagiaire = new System.Windows.Forms.DataGridView();
            this.dgv_stagiaire_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_stagiaire_fin_formation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_stagiaire_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grp_stagiaire = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stagiaire)).BeginInit();
            this.grp_stagiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(12, 15);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nom :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(12, 41);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(34, 13);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Titre :";
            // 
            // lbl_deb_session
            // 
            this.lbl_deb_session.AutoSize = true;
            this.lbl_deb_session.Location = new System.Drawing.Point(223, 15);
            this.lbl_deb_session.Name = "lbl_deb_session";
            this.lbl_deb_session.Size = new System.Drawing.Size(81, 13);
            this.lbl_deb_session.TabIndex = 2;
            this.lbl_deb_session.Text = "Date de début :";
            // 
            // lbl_fin_session
            // 
            this.lbl_fin_session.AutoSize = true;
            this.lbl_fin_session.Location = new System.Drawing.Point(239, 41);
            this.lbl_fin_session.Name = "lbl_fin_session";
            this.lbl_fin_session.Size = new System.Drawing.Size(65, 13);
            this.lbl_fin_session.TabIndex = 3;
            this.lbl_fin_session.Text = "Date de fin :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(53, 12);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(164, 20);
            this.txt_nom.TabIndex = 4;
            // 
            // cbx_titre
            // 
            this.cbx_titre.FormattingEnabled = true;
            this.cbx_titre.Location = new System.Drawing.Point(53, 38);
            this.cbx_titre.Name = "cbx_titre";
            this.cbx_titre.Size = new System.Drawing.Size(164, 21);
            this.cbx_titre.TabIndex = 5;
            // 
            // dtp_deb_session
            // 
            this.dtp_deb_session.Location = new System.Drawing.Point(310, 12);
            this.dtp_deb_session.Name = "dtp_deb_session";
            this.dtp_deb_session.Size = new System.Drawing.Size(164, 20);
            this.dtp_deb_session.TabIndex = 6;
            // 
            // dtp_fin_session
            // 
            this.dtp_fin_session.Location = new System.Drawing.Point(310, 38);
            this.dtp_fin_session.Name = "dtp_fin_session";
            this.dtp_fin_session.Size = new System.Drawing.Size(164, 20);
            this.dtp_fin_session.TabIndex = 7;
            // 
            // btn_aff_stagiaire
            // 
            this.btn_aff_stagiaire.Location = new System.Drawing.Point(428, 64);
            this.btn_aff_stagiaire.Name = "btn_aff_stagiaire";
            this.btn_aff_stagiaire.Size = new System.Drawing.Size(144, 23);
            this.btn_aff_stagiaire.TabIndex = 0;
            this.btn_aff_stagiaire.Text = "Affecter stagiaire";
            this.btn_aff_stagiaire.UseVisualStyleBackColor = true;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(428, 376);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(144, 23);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // dgv_stagiaire
            // 
            this.dgv_stagiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stagiaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_stagiaire_nom,
            this.dgv_stagiaire_fin_formation,
            this.dgv_stagiaire_del});
            this.dgv_stagiaire.Location = new System.Drawing.Point(6, 19);
            this.dgv_stagiaire.Name = "dgv_stagiaire";
            this.dgv_stagiaire.Size = new System.Drawing.Size(548, 252);
            this.dgv_stagiaire.TabIndex = 9;
            // 
            // dgv_stagiaire_nom
            // 
            this.dgv_stagiaire_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_stagiaire_nom.HeaderText = "Nom";
            this.dgv_stagiaire_nom.Name = "dgv_stagiaire_nom";
            // 
            // dgv_stagiaire_fin_formation
            // 
            this.dgv_stagiaire_fin_formation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_stagiaire_fin_formation.HeaderText = "Fin de formation";
            this.dgv_stagiaire_fin_formation.Name = "dgv_stagiaire_fin_formation";
            // 
            // dgv_stagiaire_del
            // 
            this.dgv_stagiaire_del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_stagiaire_del.HeaderText = "Delete";
            this.dgv_stagiaire_del.Name = "dgv_stagiaire_del";
            // 
            // grp_stagiaire
            // 
            this.grp_stagiaire.Controls.Add(this.dgv_stagiaire);
            this.grp_stagiaire.Location = new System.Drawing.Point(12, 93);
            this.grp_stagiaire.Name = "grp_stagiaire";
            this.grp_stagiaire.Size = new System.Drawing.Size(560, 277);
            this.grp_stagiaire.TabIndex = 10;
            this.grp_stagiaire.TabStop = false;
            this.grp_stagiaire.Text = "Liste de stagiaire";
            // 
            // NEW_UPD_SESSION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btn_aff_stagiaire);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.dtp_fin_session);
            this.Controls.Add(this.dtp_deb_session);
            this.Controls.Add(this.cbx_titre);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_fin_session);
            this.Controls.Add(this.lbl_deb_session);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.grp_stagiaire);
            this.Name = "NEW_UPD_SESSION";
            this.Text = "Nouvelle / Modifier session";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stagiaire)).EndInit();
            this.grp_stagiaire.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_deb_session;
        private System.Windows.Forms.Label lbl_fin_session;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.ComboBox cbx_titre;
        private System.Windows.Forms.DateTimePicker dtp_deb_session;
        private System.Windows.Forms.DateTimePicker dtp_fin_session;
        private System.Windows.Forms.Button btn_aff_stagiaire;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.DataGridView dgv_stagiaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_stagiaire_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_stagiaire_fin_formation;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_stagiaire_del;
        private System.Windows.Forms.GroupBox grp_stagiaire;
    }
}