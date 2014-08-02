namespace Windows_forms_projet_ENI
{
    partial class PLANNING_SESSION
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
            this.txt_nom = new System.Windows.Forms.Label();
            this.txt_titre = new System.Windows.Forms.Label();
            this.lbl_deb_session = new System.Windows.Forms.Label();
            this.lbl_fin_session = new System.Windows.Forms.Label();
            this.txt_deb_session = new System.Windows.Forms.Label();
            this.txt_fin_session = new System.Windows.Forms.Label();
            this.gbx_date = new System.Windows.Forms.GroupBox();
            this.gbx_salle = new System.Windows.Forms.GroupBox();
            this.gbx_jure = new System.Windows.Forms.GroupBox();
            this.gbx_stagiaire = new System.Windows.Forms.GroupBox();
            this.btn_aff_jure = new System.Windows.Forms.Button();
            this.btn_aff_stagiaire = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.dgv_date = new System.Windows.Forms.DataGridView();
            this.dgv_salle = new System.Windows.Forms.DataGridView();
            this.dgv_jure = new System.Windows.Forms.DataGridView();
            this.dgv_stagiaire = new System.Windows.Forms.DataGridView();
            this.dgv_date_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_date_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_salle_salle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgv_salle_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_jure_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_jure_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_stagiaire_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_stagiaire_fin_formation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_stagiaire_heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_stagiaire_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbx_salle.SuspendLayout();
            this.gbx_jure.SuspendLayout();
            this.gbx_stagiaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stagiaire)).BeginInit();
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
            this.lbl_titre.TabIndex = 3;
            this.lbl_titre.Text = "Titre :";
            // 
            // txt_nom
            // 
            this.txt_nom.AutoSize = true;
            this.txt_nom.Location = new System.Drawing.Point(53, 15);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(80, 13);
            this.txt_nom.TabIndex = 4;
            this.txt_nom.Text = "Session CDI 52";
            // 
            // txt_titre
            // 
            this.txt_titre.AutoSize = true;
            this.txt_titre.Location = new System.Drawing.Point(53, 41);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(25, 13);
            this.txt_titre.TabIndex = 5;
            this.txt_titre.Text = "CDI";
            // 
            // lbl_deb_session
            // 
            this.lbl_deb_session.AutoSize = true;
            this.lbl_deb_session.Location = new System.Drawing.Point(164, 15);
            this.lbl_deb_session.Name = "lbl_deb_session";
            this.lbl_deb_session.Size = new System.Drawing.Size(81, 13);
            this.lbl_deb_session.TabIndex = 6;
            this.lbl_deb_session.Text = "Date de début :";
            // 
            // lbl_fin_session
            // 
            this.lbl_fin_session.AutoSize = true;
            this.lbl_fin_session.Location = new System.Drawing.Point(164, 41);
            this.lbl_fin_session.Name = "lbl_fin_session";
            this.lbl_fin_session.Size = new System.Drawing.Size(65, 13);
            this.lbl_fin_session.TabIndex = 7;
            this.lbl_fin_session.Text = "Date de fin :";
            // 
            // txt_deb_session
            // 
            this.txt_deb_session.AutoSize = true;
            this.txt_deb_session.Location = new System.Drawing.Point(251, 15);
            this.txt_deb_session.Name = "txt_deb_session";
            this.txt_deb_session.Size = new System.Drawing.Size(65, 13);
            this.txt_deb_session.TabIndex = 8;
            this.txt_deb_session.Text = "01/12/2014";
            // 
            // txt_fin_session
            // 
            this.txt_fin_session.AutoSize = true;
            this.txt_fin_session.Location = new System.Drawing.Point(251, 41);
            this.txt_fin_session.Name = "txt_fin_session";
            this.txt_fin_session.Size = new System.Drawing.Size(65, 13);
            this.txt_fin_session.TabIndex = 9;
            this.txt_fin_session.Text = "03/12/2014";
            // 
            // gbx_date
            // 
            this.gbx_date.Location = new System.Drawing.Point(12, 57);
            this.gbx_date.Name = "gbx_date";
            this.gbx_date.Size = new System.Drawing.Size(267, 100);
            this.gbx_date.TabIndex = 10;
            this.gbx_date.TabStop = false;
            this.gbx_date.Text = "Date";
            // 
            // gbx_salle
            // 
            this.gbx_salle.Controls.Add(this.dgv_salle);
            this.gbx_salle.Location = new System.Drawing.Point(12, 163);
            this.gbx_salle.Name = "gbx_salle";
            this.gbx_salle.Size = new System.Drawing.Size(267, 100);
            this.gbx_salle.TabIndex = 11;
            this.gbx_salle.TabStop = false;
            this.gbx_salle.Text = "Salle";
            // 
            // gbx_jure
            // 
            this.gbx_jure.Controls.Add(this.dgv_jure);
            this.gbx_jure.Location = new System.Drawing.Point(285, 163);
            this.gbx_jure.Name = "gbx_jure";
            this.gbx_jure.Size = new System.Drawing.Size(287, 100);
            this.gbx_jure.TabIndex = 12;
            this.gbx_jure.TabStop = false;
            this.gbx_jure.Text = "Juré";
            // 
            // gbx_stagiaire
            // 
            this.gbx_stagiaire.Controls.Add(this.dgv_stagiaire);
            this.gbx_stagiaire.Location = new System.Drawing.Point(12, 269);
            this.gbx_stagiaire.Name = "gbx_stagiaire";
            this.gbx_stagiaire.Size = new System.Drawing.Size(560, 100);
            this.gbx_stagiaire.TabIndex = 13;
            this.gbx_stagiaire.TabStop = false;
            this.gbx_stagiaire.Text = "Stagiaire";
            // 
            // btn_aff_jure
            // 
            this.btn_aff_jure.Location = new System.Drawing.Point(428, 105);
            this.btn_aff_jure.Name = "btn_aff_jure";
            this.btn_aff_jure.Size = new System.Drawing.Size(144, 23);
            this.btn_aff_jure.TabIndex = 14;
            this.btn_aff_jure.Text = "Affecter juré";
            this.btn_aff_jure.UseVisualStyleBackColor = true;
            // 
            // btn_aff_stagiaire
            // 
            this.btn_aff_stagiaire.Location = new System.Drawing.Point(428, 134);
            this.btn_aff_stagiaire.Name = "btn_aff_stagiaire";
            this.btn_aff_stagiaire.Size = new System.Drawing.Size(144, 23);
            this.btn_aff_stagiaire.TabIndex = 15;
            this.btn_aff_stagiaire.Text = "Affecter stagiaire";
            this.btn_aff_stagiaire.UseVisualStyleBackColor = true;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(428, 376);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(144, 23);
            this.btn_valider.TabIndex = 16;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // dgv_date
            // 
            this.dgv_date.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_date.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_date_date,
            this.dgv_date_delete});
            this.dgv_date.Location = new System.Drawing.Point(18, 76);
            this.dgv_date.Name = "dgv_date";
            this.dgv_date.Size = new System.Drawing.Size(255, 75);
            this.dgv_date.TabIndex = 0;
            // 
            // dgv_salle
            // 
            this.dgv_salle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_salle_salle,
            this.dgv_salle_delete});
            this.dgv_salle.Location = new System.Drawing.Point(6, 19);
            this.dgv_salle.Name = "dgv_salle";
            this.dgv_salle.Size = new System.Drawing.Size(255, 75);
            this.dgv_salle.TabIndex = 17;
            // 
            // dgv_jure
            // 
            this.dgv_jure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_jure_nom,
            this.dgv_jure_delete});
            this.dgv_jure.Location = new System.Drawing.Point(6, 19);
            this.dgv_jure.Name = "dgv_jure";
            this.dgv_jure.Size = new System.Drawing.Size(275, 75);
            this.dgv_jure.TabIndex = 18;
            // 
            // dgv_stagiaire
            // 
            this.dgv_stagiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stagiaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_stagiaire_nom,
            this.dgv_stagiaire_fin_formation,
            this.dgv_stagiaire_heure,
            this.dgv_stagiaire_delete});
            this.dgv_stagiaire.Location = new System.Drawing.Point(6, 19);
            this.dgv_stagiaire.Name = "dgv_stagiaire";
            this.dgv_stagiaire.Size = new System.Drawing.Size(548, 75);
            this.dgv_stagiaire.TabIndex = 19;
            // 
            // dgv_date_date
            // 
            this.dgv_date_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_date_date.HeaderText = "Date";
            this.dgv_date_date.Name = "dgv_date_date";
            // 
            // dgv_date_delete
            // 
            this.dgv_date_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_date_delete.HeaderText = "Delete";
            this.dgv_date_delete.Name = "dgv_date_delete";
            // 
            // dgv_salle_salle
            // 
            this.dgv_salle_salle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_salle_salle.HeaderText = "Salle";
            this.dgv_salle_salle.Name = "dgv_salle_salle";
            // 
            // dgv_salle_delete
            // 
            this.dgv_salle_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_salle_delete.HeaderText = "Delete";
            this.dgv_salle_delete.Name = "dgv_salle_delete";
            // 
            // dgv_jure_nom
            // 
            this.dgv_jure_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_jure_nom.HeaderText = "Nom";
            this.dgv_jure_nom.Name = "dgv_jure_nom";
            // 
            // dgv_jure_delete
            // 
            this.dgv_jure_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_jure_delete.HeaderText = "Delete";
            this.dgv_jure_delete.Name = "dgv_jure_delete";
            this.dgv_jure_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_jure_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // dgv_stagiaire_heure
            // 
            this.dgv_stagiaire_heure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_stagiaire_heure.HeaderText = "Heure";
            this.dgv_stagiaire_heure.Name = "dgv_stagiaire_heure";
            // 
            // dgv_stagiaire_delete
            // 
            this.dgv_stagiaire_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_stagiaire_delete.HeaderText = "Delete";
            this.dgv_stagiaire_delete.Name = "dgv_stagiaire_delete";
            // 
            // PLANNING_SESSION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.dgv_date);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_aff_stagiaire);
            this.Controls.Add(this.btn_aff_jure);
            this.Controls.Add(this.gbx_stagiaire);
            this.Controls.Add(this.gbx_jure);
            this.Controls.Add(this.gbx_salle);
            this.Controls.Add(this.gbx_date);
            this.Controls.Add(this.txt_fin_session);
            this.Controls.Add(this.txt_deb_session);
            this.Controls.Add(this.lbl_fin_session);
            this.Controls.Add(this.lbl_deb_session);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.lbl_nom);
            this.Name = "PLANNING_SESSION";
            this.Text = "Planifier session";
            this.gbx_salle.ResumeLayout(false);
            this.gbx_jure.ResumeLayout(false);
            this.gbx_stagiaire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stagiaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label txt_nom;
        private System.Windows.Forms.Label txt_titre;
        private System.Windows.Forms.Label lbl_deb_session;
        private System.Windows.Forms.Label lbl_fin_session;
        private System.Windows.Forms.Label txt_deb_session;
        private System.Windows.Forms.Label txt_fin_session;
        private System.Windows.Forms.GroupBox gbx_date;
        private System.Windows.Forms.GroupBox gbx_salle;
        private System.Windows.Forms.GroupBox gbx_jure;
        private System.Windows.Forms.GroupBox gbx_stagiaire;
        private System.Windows.Forms.Button btn_aff_jure;
        private System.Windows.Forms.Button btn_aff_stagiaire;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.DataGridView dgv_salle;
        private System.Windows.Forms.DataGridView dgv_jure;
        private System.Windows.Forms.DataGridView dgv_stagiaire;
        private System.Windows.Forms.DataGridView dgv_date;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgv_salle_salle;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_salle_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_jure_nom;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_jure_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_stagiaire_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_stagiaire_fin_formation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_stagiaire_heure;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_stagiaire_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_date_date;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_date_delete;
    }
}