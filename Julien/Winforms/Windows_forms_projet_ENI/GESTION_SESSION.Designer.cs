namespace Windows_forms_projet_ENI
{
    partial class GESTION_SESSION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GESTION_SESSION));
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_fin_session = new System.Windows.Forms.Label();
            this.lbl_deb_session = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.cbx_titre = new System.Windows.Forms.ComboBox();
            this.dtp_fin_session = new System.Windows.Forms.DateTimePicker();
            this.dgv_gestion_session = new System.Windows.Forms.DataGridView();
            this.dgv_gestion_session_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestion_session_titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_deb_session = new System.Windows.Forms.DateTimePicker();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.gbx_search = new System.Windows.Forms.GroupBox();
            this.btn_fiche_synth = new System.Windows.Forms.Button();
            this.btn_plan_session = new System.Windows.Forms.Button();
            this.btn_mail_session = new System.Windows.Forms.Button();
            this.btn_aff_session = new System.Windows.Forms.Button();
            this.btn_del_session = new System.Windows.Forms.Button();
            this.btn_upd_session = new System.Windows.Forms.Button();
            this.btn_new_session = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestion_session)).BeginInit();
            this.gbx_search.SuspendLayout();
            this.SuspendLayout();
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
            // dgv_gestion_session
            // 
            this.dgv_gestion_session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gestion_session.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_gestion_session_nom,
            this.dgv_gestion_session_titre});
            this.dgv_gestion_session.Location = new System.Drawing.Point(12, 97);
            this.dgv_gestion_session.Name = "dgv_gestion_session";
            this.dgv_gestion_session.Size = new System.Drawing.Size(410, 302);
            this.dgv_gestion_session.TabIndex = 11;
            // 
            // dgv_gestion_session_nom
            // 
            this.dgv_gestion_session_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_gestion_session_nom.HeaderText = "Nom";
            this.dgv_gestion_session_nom.Name = "dgv_gestion_session_nom";
            // 
            // dgv_gestion_session_titre
            // 
            this.dgv_gestion_session_titre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_gestion_session_titre.HeaderText = "Titre";
            this.dgv_gestion_session_titre.Name = "dgv_gestion_session_titre";
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
            this.gbx_search.TabIndex = 6;
            this.gbx_search.TabStop = false;
            this.gbx_search.Text = " Filtre";
            // 
            // btn_fiche_synth
            // 
            this.btn_fiche_synth.Location = new System.Drawing.Point(428, 271);
            this.btn_fiche_synth.Name = "btn_fiche_synth";
            this.btn_fiche_synth.Size = new System.Drawing.Size(144, 23);
            this.btn_fiche_synth.TabIndex = 18;
            this.btn_fiche_synth.Text = "Editer fiche synthèse";
            this.btn_fiche_synth.UseVisualStyleBackColor = true;
            // 
            // btn_plan_session
            // 
            this.btn_plan_session.Location = new System.Drawing.Point(428, 242);
            this.btn_plan_session.Name = "btn_plan_session";
            this.btn_plan_session.Size = new System.Drawing.Size(144, 23);
            this.btn_plan_session.TabIndex = 17;
            this.btn_plan_session.Text = "Planifier session";
            this.btn_plan_session.UseVisualStyleBackColor = true;
            // 
            // btn_mail_session
            // 
            this.btn_mail_session.Location = new System.Drawing.Point(428, 213);
            this.btn_mail_session.Name = "btn_mail_session";
            this.btn_mail_session.Size = new System.Drawing.Size(144, 23);
            this.btn_mail_session.TabIndex = 16;
            this.btn_mail_session.Text = "Mail session";
            this.btn_mail_session.UseVisualStyleBackColor = true;
            // 
            // btn_aff_session
            // 
            this.btn_aff_session.Location = new System.Drawing.Point(428, 184);
            this.btn_aff_session.Name = "btn_aff_session";
            this.btn_aff_session.Size = new System.Drawing.Size(144, 23);
            this.btn_aff_session.TabIndex = 15;
            this.btn_aff_session.Text = "Affecter session";
            this.btn_aff_session.UseVisualStyleBackColor = true;
            // 
            // btn_del_session
            // 
            this.btn_del_session.Location = new System.Drawing.Point(428, 155);
            this.btn_del_session.Name = "btn_del_session";
            this.btn_del_session.Size = new System.Drawing.Size(144, 23);
            this.btn_del_session.TabIndex = 14;
            this.btn_del_session.Text = "Supprimer session";
            this.btn_del_session.UseVisualStyleBackColor = true;
            // 
            // btn_upd_session
            // 
            this.btn_upd_session.Location = new System.Drawing.Point(428, 126);
            this.btn_upd_session.Name = "btn_upd_session";
            this.btn_upd_session.Size = new System.Drawing.Size(144, 23);
            this.btn_upd_session.TabIndex = 13;
            this.btn_upd_session.Text = "Modifier session";
            this.btn_upd_session.UseVisualStyleBackColor = true;
            // 
            // btn_new_session
            // 
            this.btn_new_session.Location = new System.Drawing.Point(428, 97);
            this.btn_new_session.Name = "btn_new_session";
            this.btn_new_session.Size = new System.Drawing.Size(144, 23);
            this.btn_new_session.TabIndex = 12;
            this.btn_new_session.Text = "Nouvelle session";
            this.btn_new_session.UseVisualStyleBackColor = true;
            // 
            // GESTION_SESSION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btn_fiche_synth);
            this.Controls.Add(this.btn_plan_session);
            this.Controls.Add(this.btn_mail_session);
            this.Controls.Add(this.btn_aff_session);
            this.Controls.Add(this.btn_del_session);
            this.Controls.Add(this.btn_upd_session);
            this.Controls.Add(this.btn_new_session);
            this.Controls.Add(this.dgv_gestion_session);
            this.Controls.Add(this.gbx_search);
            this.Name = "GESTION_SESSION";
            this.Text = " Gestion session";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestion_session)).EndInit();
            this.gbx_search.ResumeLayout(false);
            this.gbx_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_fin_session;
        private System.Windows.Forms.Label lbl_deb_session;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.ComboBox cbx_titre;
        private System.Windows.Forms.DateTimePicker dtp_fin_session;
        private System.Windows.Forms.DataGridView dgv_gestion_session;
        private System.Windows.Forms.DateTimePicker dtp_deb_session;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.GroupBox gbx_search;
        private System.Windows.Forms.Button btn_fiche_synth;
        private System.Windows.Forms.Button btn_plan_session;
        private System.Windows.Forms.Button btn_mail_session;
        private System.Windows.Forms.Button btn_aff_session;
        private System.Windows.Forms.Button btn_del_session;
        private System.Windows.Forms.Button btn_upd_session;
        private System.Windows.Forms.Button btn_new_session;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestion_session_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestion_session_titre;

    }
}