namespace Exercicio_Classificação_Notas_Prova_Escrita_Oral
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvGrelha = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboEscrita = new System.Windows.Forms.ComboBox();
            this.cboOral = new System.Windows.Forms.ComboBox();
            this.cboFisica = new System.Windows.Forms.ComboBox();
            this.grbLinguas = new System.Windows.Forms.GroupBox();
            this.chkRusso = new System.Windows.Forms.CheckBox();
            this.chkPortugues = new System.Windows.Forms.CheckBox();
            this.chkFrances = new System.Windows.Forms.CheckBox();
            this.chkEspanhol = new System.Windows.Forms.CheckBox();
            this.chkAlemao = new System.Windows.Forms.CheckBox();
            this.chkIngles = new System.Windows.Forms.CheckBox();
            this.btnSubmeter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ntfMy = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).BeginInit();
            this.grbLinguas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prova Escrita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prova Oral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apt. Física";
            // 
            // dgvGrelha
            // 
            this.dgvGrelha.AllowUserToAddRows = false;
            this.dgvGrelha.AllowUserToDeleteRows = false;
            this.dgvGrelha.AllowUserToResizeColumns = false;
            this.dgvGrelha.AllowUserToResizeRows = false;
            this.dgvGrelha.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrelha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvGrelha.Location = new System.Drawing.Point(267, 12);
            this.dgvGrelha.Name = "dgvGrelha";
            this.dgvGrelha.RowHeadersVisible = false;
            this.dgvGrelha.Size = new System.Drawing.Size(603, 287);
            this.dgvGrelha.TabIndex = 4;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nome";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Prova Escrita";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prova Oral";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apt. Física";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Línguas";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Situação";
            this.Column5.Name = "Column5";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(187, 20);
            this.txtNome.TabIndex = 5;
            // 
            // cboEscrita
            // 
            this.cboEscrita.FormattingEnabled = true;
            this.cboEscrita.Location = new System.Drawing.Point(88, 57);
            this.cboEscrita.Name = "cboEscrita";
            this.cboEscrita.Size = new System.Drawing.Size(35, 21);
            this.cboEscrita.TabIndex = 6;
            // 
            // cboOral
            // 
            this.cboOral.FormattingEnabled = true;
            this.cboOral.Location = new System.Drawing.Point(88, 87);
            this.cboOral.Name = "cboOral";
            this.cboOral.Size = new System.Drawing.Size(35, 21);
            this.cboOral.TabIndex = 7;
            // 
            // cboFisica
            // 
            this.cboFisica.FormattingEnabled = true;
            this.cboFisica.Location = new System.Drawing.Point(88, 116);
            this.cboFisica.Name = "cboFisica";
            this.cboFisica.Size = new System.Drawing.Size(35, 21);
            this.cboFisica.TabIndex = 8;
            // 
            // grbLinguas
            // 
            this.grbLinguas.Controls.Add(this.chkRusso);
            this.grbLinguas.Controls.Add(this.chkPortugues);
            this.grbLinguas.Controls.Add(this.chkFrances);
            this.grbLinguas.Controls.Add(this.chkEspanhol);
            this.grbLinguas.Controls.Add(this.chkAlemao);
            this.grbLinguas.Controls.Add(this.chkIngles);
            this.grbLinguas.Location = new System.Drawing.Point(15, 156);
            this.grbLinguas.Name = "grbLinguas";
            this.grbLinguas.Size = new System.Drawing.Size(200, 100);
            this.grbLinguas.TabIndex = 9;
            this.grbLinguas.TabStop = false;
            this.grbLinguas.Text = "Línguas";
            // 
            // chkRusso
            // 
            this.chkRusso.AutoSize = true;
            this.chkRusso.Location = new System.Drawing.Point(114, 66);
            this.chkRusso.Name = "chkRusso";
            this.chkRusso.Size = new System.Drawing.Size(56, 17);
            this.chkRusso.TabIndex = 5;
            this.chkRusso.Text = "Russo";
            this.chkRusso.UseVisualStyleBackColor = true;
            // 
            // chkPortugues
            // 
            this.chkPortugues.AutoSize = true;
            this.chkPortugues.Location = new System.Drawing.Point(114, 43);
            this.chkPortugues.Name = "chkPortugues";
            this.chkPortugues.Size = new System.Drawing.Size(74, 17);
            this.chkPortugues.TabIndex = 4;
            this.chkPortugues.Text = "Português";
            this.chkPortugues.UseVisualStyleBackColor = true;
            // 
            // chkFrances
            // 
            this.chkFrances.AutoSize = true;
            this.chkFrances.Location = new System.Drawing.Point(114, 20);
            this.chkFrances.Name = "chkFrances";
            this.chkFrances.Size = new System.Drawing.Size(64, 17);
            this.chkFrances.TabIndex = 3;
            this.chkFrances.Text = "Francês";
            this.chkFrances.UseVisualStyleBackColor = true;
            // 
            // chkEspanhol
            // 
            this.chkEspanhol.AutoSize = true;
            this.chkEspanhol.Location = new System.Drawing.Point(6, 66);
            this.chkEspanhol.Name = "chkEspanhol";
            this.chkEspanhol.Size = new System.Drawing.Size(70, 17);
            this.chkEspanhol.TabIndex = 2;
            this.chkEspanhol.Text = "Espanhol";
            this.chkEspanhol.UseVisualStyleBackColor = true;
            // 
            // chkAlemao
            // 
            this.chkAlemao.AutoSize = true;
            this.chkAlemao.Location = new System.Drawing.Point(7, 43);
            this.chkAlemao.Name = "chkAlemao";
            this.chkAlemao.Size = new System.Drawing.Size(61, 17);
            this.chkAlemao.TabIndex = 1;
            this.chkAlemao.Text = "Alemão";
            this.chkAlemao.UseVisualStyleBackColor = true;
            // 
            // chkIngles
            // 
            this.chkIngles.AutoSize = true;
            this.chkIngles.Location = new System.Drawing.Point(7, 20);
            this.chkIngles.Name = "chkIngles";
            this.chkIngles.Size = new System.Drawing.Size(52, 17);
            this.chkIngles.TabIndex = 0;
            this.chkIngles.Text = "Ingês";
            this.chkIngles.UseVisualStyleBackColor = true;
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Location = new System.Drawing.Point(15, 277);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(75, 36);
            this.btnSubmeter.TabIndex = 10;
            this.btnSubmeter.Text = "Submeter";
            this.btnSubmeter.UseVisualStyleBackColor = true;
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(140, 277);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 36);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // ntfMy
            // 
            this.ntfMy.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfMy.Icon")));
            this.ntfMy.Text = "notifyIcon1";
            this.ntfMy.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 327);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.grbLinguas);
            this.Controls.Add(this.cboFisica);
            this.Controls.Add(this.cboOral);
            this.Controls.Add(this.cboEscrita);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvGrelha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Classificação Geral";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).EndInit();
            this.grbLinguas.ResumeLayout(false);
            this.grbLinguas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvGrelha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboEscrita;
        private System.Windows.Forms.ComboBox cboOral;
        private System.Windows.Forms.ComboBox cboFisica;
        private System.Windows.Forms.GroupBox grbLinguas;
        private System.Windows.Forms.CheckBox chkRusso;
        private System.Windows.Forms.CheckBox chkPortugues;
        private System.Windows.Forms.CheckBox chkFrances;
        private System.Windows.Forms.CheckBox chkEspanhol;
        private System.Windows.Forms.CheckBox chkAlemao;
        private System.Windows.Forms.CheckBox chkIngles;
        private System.Windows.Forms.Button btnSubmeter;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.NotifyIcon ntfMy;
    }
}

