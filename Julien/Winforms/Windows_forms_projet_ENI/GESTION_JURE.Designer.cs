namespace Windows_forms_projet_ENI
{
    partial class GESTION_JURE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GESTION_JURE));
            this.gbx_search = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_fin_session = new System.Windows.Forms.Label();
            this.lbl_deb_session = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.cbx_titre = new System.Windows.Forms.ComboBox();
            this.dtp_fin_session = new System.Windows.Forms.DateTimePicker();
            this.dtp_deb_session = new System.Windows.Forms.DateTimePicker();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.dgv_gestion_jure = new System.Windows.Forms.DataGridView();
            this.dgv_gestion_jure_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestion_jure_titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_aff_jure = new System.Windows.Forms.Button();
            this.btn_del_jure = new System.Windows.Forms.Button();
            this.btn_new_jure = new System.Windows.Forms.Button();
            this.btn_upd_jure = new System.Windows.Forms.Button();
            this.gbx_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestion_jure)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_search
            // 
            this.gbx_search.Controls.Add(this.btn_search);
            this.gbx_search.Controls.Add(this.lbl_fin_session);
            this.gbx_search.Controls.Add(this.lbl_deb_session);
            this.gbx_search.Controls.Add(this.lbl_titre);
            this.gbx_search.Controls.Add(this.lbl_nom);
            this.gbx_search.Controls.Add(this.cbx_titre);
            this.gbx_search.Controls.Add(this.dtp_fin_session);
            this.gbx_search.Controls.Add(this.dtp_deb_session);
            this.gbx_search.Controls.Add(this.txt_nom);
            this.gbx_search.Location = new System.Drawing.Point(12, 12);
            this.gbx_search.Name = "gbx_search";
            this.gbx_search.Size = new System.Drawing.Size(560, 79);
            this.gbx_search.TabIndex = 0;
            this.gbx_search.TabStop = false;
            this.gbx_search.Text = " Filtre";
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(499, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(46, 46);
            this.btn_search.TabIndex = 8;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // lbl_fin_session
            // 
            this.lbl_fin_session.AutoSize = true;
            this.lbl_fin_session.Location = new System.Drawing.Point(304, 48);
            this.lbl_fin_session.Name = "lbl_fin_session";
            this.lbl_fin_session.Size = new System.Drawing.Size(10, 13);
            this.lbl_fin_session.TabIndex = 7;
            this.lbl_fin_session.Text = "-";
            // 
            // lbl_deb_session
            // 
            this.lbl_deb_session.AutoSize = true;
            this.lbl_deb_session.Location = new System.Drawing.Point(240, 22);
            this.lbl_deb_session.Name = "lbl_deb_session";
            this.lbl_deb_session.Size = new System.Drawing.Size(74, 13);
            this.lbl_deb_session.TabIndex = 6;
            this.lbl_deb_session.Text = "Date session :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(7, 48);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(34, 13);
            this.lbl_titre.TabIndex = 5;
            this.lbl_titre.Text = "Titre :";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(7, 25);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 4;
            this.lbl_nom.Text = "Nom :";
            // 
            // cbx_titre
            // 
            this.cbx_titre.FormattingEnabled = true;
            this.cbx_titre.Location = new System.Drawing.Point(48, 45);
            this.cbx_titre.Name = "cbx_titre";
            this.cbx_titre.Size = new System.Drawing.Size(164, 21);
            this.cbx_titre.TabIndex = 3;
            // 
            // dtp_fin_session
            // 
            this.dtp_fin_session.Location = new System.Drawing.Point(320, 46);
            this.dtp_fin_session.Name = "dtp_fin_session";
            this.dtp_fin_session.Size = new System.Drawing.Size(164, 20);
            this.dtp_fin_session.TabIndex = 2;
            // 
            // dtp_deb_session
            // 
            this.dtp_deb_session.Location = new System.Drawing.Point(320, 19);
            this.dtp_deb_session.Name = "dtp_deb_session";
            this.dtp_deb_session.Size = new System.Drawing.Size(164, 20);
            this.dtp_deb_session.TabIndex = 1;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(48, 19);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(164, 20);
            this.txt_nom.TabIndex = 0;
            // 
            // dgv_gestion_jure
            // 
            this.dgv_gestion_jure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gestion_jure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_gestion_jure_nom,
            this.dgv_gestion_jure_titre});
            this.dgv_gestion_jure.Location = new System.Drawing.Point(12, 97);
            this.dgv_gestion_jure.Name = "dgv_gestion_jure";
            this.dgv_gestion_jure.Size = new System.Drawing.Size(410, 302);
            this.dgv_gestion_jure.TabIndex = 5;
            // 
            // dgv_gestion_jure_nom
            // 
            this.dgv_gestion_jure_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_gestion_jure_nom.HeaderText = "Nom";
            this.dgv_gestion_jure_nom.Name = "dgv_gestion_jure_nom";
            // 
            // dgv_gestion_jure_titre
            // 
            this.dgv_gestion_jure_titre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_gestion_jure_titre.HeaderText = "Titre";
            this.dgv_gestion_jure_titre.Name = "dgv_gestion_jure_titre";
            // 
            // btn_aff_jure
            // 
            this.btn_aff_jure.Location = new System.Drawing.Point(428, 184);
            this.btn_aff_jure.Name = "btn_aff_jure";
            this.btn_aff_jure.Size = new System.Drawing.Size(144, 23);
            this.btn_aff_jure.TabIndex = 14;
            this.btn_aff_jure.Text = "Affecter juré";
            this.btn_aff_jure.UseVisualStyleBackColor = true;
            // 
            // btn_del_jure
            // 
            this.btn_del_jure.Location = new System.Drawing.Point(428, 155);
            this.btn_del_jure.Name = "btn_del_jure";
            this.btn_del_jure.Size = new System.Drawing.Size(144, 23);
            this.btn_del_jure.TabIndex = 13;
            this.btn_del_jure.Text = "Supprimer juré";
            this.btn_del_jure.UseVisualStyleBackColor = true;
            // 
            // btn_new_jure
            // 
            this.btn_new_jure.Location = new System.Drawing.Point(428, 97);
            this.btn_new_jure.Name = "btn_new_jure";
            this.btn_new_jure.Size = new System.Drawing.Size(144, 23);
            this.btn_new_jure.TabIndex = 11;
            this.btn_new_jure.Text = "Nouveau juré";
            this.btn_new_jure.UseVisualStyleBackColor = true;
            // 
            // btn_upd_jure
            // 
            this.btn_upd_jure.Location = new System.Drawing.Point(428, 126);
            this.btn_upd_jure.Name = "btn_upd_jure";
            this.btn_upd_jure.Size = new System.Drawing.Size(144, 23);
            this.btn_upd_jure.TabIndex = 12;
            this.btn_upd_jure.Text = "Modifier juré";
            this.btn_upd_jure.UseVisualStyleBackColor = true;
            // 
            // GESTION_JURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btn_aff_jure);
            this.Controls.Add(this.btn_del_jure);
            this.Controls.Add(this.btn_new_jure);
            this.Controls.Add(this.btn_upd_jure);
            this.Controls.Add(this.dgv_gestion_jure);
            this.Controls.Add(this.gbx_search);
            this.Name = "GESTION_JURE";
            this.Text = " Gestion juré";
            this.gbx_search.ResumeLayout(false);
            this.gbx_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestion_jure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_search;
        private System.Windows.Forms.Label lbl_fin_session;
        private System.Windows.Forms.Label lbl_deb_session;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.ComboBox cbx_titre;
        private System.Windows.Forms.DateTimePicker dtp_fin_session;
        private System.Windows.Forms.DateTimePicker dtp_deb_session;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_gestion_jure;
        private System.Windows.Forms.Button btn_aff_jure;
        private System.Windows.Forms.Button btn_del_jure;
        private System.Windows.Forms.Button btn_new_jure;
        private System.Windows.Forms.Button btn_upd_jure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestion_jure_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestion_jure_titre;
    }
}

