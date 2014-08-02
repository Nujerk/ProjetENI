namespace Windows_forms_projet_ENI
{
    partial class AFFECTER_STAGIAIRE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AFFECTER_STAGIAIRE));
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_fin_session = new System.Windows.Forms.Label();
            this.lbl_fin_formation = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.cbx_titre = new System.Windows.Forms.ComboBox();
            this.dtp_fin_fin_formation = new System.Windows.Forms.DateTimePicker();
            this.dtp_deb_fin_formation = new System.Windows.Forms.DateTimePicker();
            this.dgv_affecter_stagiaire = new System.Windows.Forms.DataGridView();
            this.dgv_affecter_stagiaire_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_affecter_stagiaire_titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_affecter_stagiaire_fin_formation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.btn_affecter_stagiaire = new System.Windows.Forms.Button();
            this.gbx_search = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_affecter_stagiaire)).BeginInit();
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
            // lbl_fin_formation
            // 
            this.lbl_fin_formation.AutoSize = true;
            this.lbl_fin_formation.Location = new System.Drawing.Point(218, 22);
            this.lbl_fin_formation.Name = "lbl_fin_formation";
            this.lbl_fin_formation.Size = new System.Drawing.Size(96, 13);
            this.lbl_fin_formation.TabIndex = 6;
            this.lbl_fin_formation.Text = "Date fin formation :";
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
            // dtp_fin_fin_formation
            // 
            this.dtp_fin_fin_formation.Location = new System.Drawing.Point(320, 46);
            this.dtp_fin_fin_formation.Name = "dtp_fin_fin_formation";
            this.dtp_fin_fin_formation.Size = new System.Drawing.Size(164, 20);
            this.dtp_fin_fin_formation.TabIndex = 2;
            // 
            // dtp_deb_fin_formation
            // 
            this.dtp_deb_fin_formation.Location = new System.Drawing.Point(320, 19);
            this.dtp_deb_fin_formation.Name = "dtp_deb_fin_formation";
            this.dtp_deb_fin_formation.Size = new System.Drawing.Size(164, 20);
            this.dtp_deb_fin_formation.TabIndex = 1;
            // 
            // dgv_affecter_stagiaire
            // 
            this.dgv_affecter_stagiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_affecter_stagiaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_affecter_stagiaire_nom,
            this.dgv_affecter_stagiaire_titre,
            this.dgv_affecter_stagiaire_fin_formation});
            this.dgv_affecter_stagiaire.Location = new System.Drawing.Point(12, 97);
            this.dgv_affecter_stagiaire.Name = "dgv_affecter_stagiaire";
            this.dgv_affecter_stagiaire.Size = new System.Drawing.Size(410, 302);
            this.dgv_affecter_stagiaire.TabIndex = 16;
            // 
            // dgv_affecter_stagiaire_nom
            // 
            this.dgv_affecter_stagiaire_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_affecter_stagiaire_nom.HeaderText = "Nom";
            this.dgv_affecter_stagiaire_nom.Name = "dgv_affecter_stagiaire_nom";
            // 
            // dgv_affecter_stagiaire_titre
            // 
            this.dgv_affecter_stagiaire_titre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_affecter_stagiaire_titre.HeaderText = "Titre";
            this.dgv_affecter_stagiaire_titre.Name = "dgv_affecter_stagiaire_titre";
            // 
            // dgv_affecter_stagiaire_fin_formation
            // 
            this.dgv_affecter_stagiaire_fin_formation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_affecter_stagiaire_fin_formation.HeaderText = "fin de formation";
            this.dgv_affecter_stagiaire_fin_formation.Name = "dgv_affecter_stagiaire_fin_formation";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(48, 19);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(164, 20);
            this.txt_nom.TabIndex = 0;
            // 
            // btn_affecter_stagiaire
            // 
            this.btn_affecter_stagiaire.Location = new System.Drawing.Point(428, 97);
            this.btn_affecter_stagiaire.Name = "btn_affecter_stagiaire";
            this.btn_affecter_stagiaire.Size = new System.Drawing.Size(144, 23);
            this.btn_affecter_stagiaire.TabIndex = 17;
            this.btn_affecter_stagiaire.Text = "Affecter stagiaire";
            this.btn_affecter_stagiaire.UseVisualStyleBackColor = true;
            // 
            // gbx_search
            // 
            this.gbx_search.Controls.Add(this.btn_search);
            this.gbx_search.Controls.Add(this.lbl_fin_session);
            this.gbx_search.Controls.Add(this.lbl_fin_formation);
            this.gbx_search.Controls.Add(this.lbl_titre);
            this.gbx_search.Controls.Add(this.lbl_nom);
            this.gbx_search.Controls.Add(this.cbx_titre);
            this.gbx_search.Controls.Add(this.dtp_fin_fin_formation);
            this.gbx_search.Controls.Add(this.dtp_deb_fin_formation);
            this.gbx_search.Controls.Add(this.txt_nom);
            this.gbx_search.Location = new System.Drawing.Point(12, 12);
            this.gbx_search.Name = "gbx_search";
            this.gbx_search.Size = new System.Drawing.Size(560, 79);
            this.gbx_search.TabIndex = 15;
            this.gbx_search.TabStop = false;
            this.gbx_search.Text = " Filtre";
            // 
            // AFFECTER_STAGIAIRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.dgv_affecter_stagiaire);
            this.Controls.Add(this.btn_affecter_stagiaire);
            this.Controls.Add(this.gbx_search);
            this.Name = "AFFECTER_STAGIAIRE";
            this.Text = "Affecter stagiaire";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_affecter_stagiaire)).EndInit();
            this.gbx_search.ResumeLayout(false);
            this.gbx_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_fin_session;
        private System.Windows.Forms.Label lbl_fin_formation;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.ComboBox cbx_titre;
        private System.Windows.Forms.DateTimePicker dtp_fin_fin_formation;
        private System.Windows.Forms.DateTimePicker dtp_deb_fin_formation;
        private System.Windows.Forms.DataGridView dgv_affecter_stagiaire;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_affecter_stagiaire;
        private System.Windows.Forms.GroupBox gbx_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_affecter_stagiaire_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_affecter_stagiaire_titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_affecter_stagiaire_fin_formation;
    }
}