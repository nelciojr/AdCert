namespace AdCert
{
    partial class FrmCadastrar
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
            this.components = new System.ComponentModel.Container();
            this.labelCadastroCertificado = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.dTPDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dTPDataFinal = new System.Windows.Forms.DateTimePicker();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelUP = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.rBtnCNPJCertificado = new System.Windows.Forms.RadioButton();
            this.rBtnCPFCertificado = new System.Windows.Forms.RadioButton();
            this.textBoxCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.errorProviderCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCPFCNPJ = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCPFCNPJ)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCadastroCertificado
            // 
            this.labelCadastroCertificado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCadastroCertificado.AutoSize = true;
            this.labelCadastroCertificado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroCertificado.Location = new System.Drawing.Point(224, 30);
            this.labelCadastroCertificado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCadastroCertificado.Name = "labelCadastroCertificado";
            this.labelCadastroCertificado.Size = new System.Drawing.Size(182, 21);
            this.labelCadastroCertificado.TabIndex = 17;
            this.labelCadastroCertificado.Text = "Cadastrar Certificado";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCliente.Location = new System.Drawing.Point(34, 162);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(61, 20);
            this.labelCliente.TabIndex = 9;
            this.labelCliente.Text = "Cliente";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(38, 187);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(350, 27);
            this.textBoxCliente.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(362, 423);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Location = new System.Drawing.Point(482, 423);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(413, 187);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSenha.MaxLength = 14;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(170, 27);
            this.textBoxSenha.TabIndex = 2;
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSenha.Location = new System.Drawing.Point(409, 162);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(54, 20);
            this.labelSenha.TabIndex = 10;
            this.labelSenha.Text = "Senha";
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataInicio.Location = new System.Drawing.Point(34, 263);
            this.labelDataInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(89, 20);
            this.labelDataInicio.TabIndex = 11;
            this.labelDataInicio.Text = "Data Início";
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataFinal.Location = new System.Drawing.Point(409, 263);
            this.labelDataFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(81, 20);
            this.labelDataFinal.TabIndex = 12;
            this.labelDataFinal.Text = "Data Final";
            // 
            // dTPDataInicio
            // 
            this.dTPDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDataInicio.Location = new System.Drawing.Point(38, 288);
            this.dTPDataInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTPDataInicio.Name = "dTPDataInicio";
            this.dTPDataInicio.Size = new System.Drawing.Size(172, 26);
            this.dTPDataInicio.TabIndex = 3;
            // 
            // dTPDataFinal
            // 
            this.dTPDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDataFinal.Location = new System.Drawing.Point(413, 288);
            this.dTPDataFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTPDataFinal.Name = "dTPDataFinal";
            this.dTPDataFinal.Size = new System.Drawing.Size(170, 26);
            this.dTPDataFinal.TabIndex = 4;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.CadetBlue;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 475);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(630, 15);
            this.panelBottom.TabIndex = 15;
            // 
            // panelUP
            // 
            this.panelUP.BackColor = System.Drawing.Color.Teal;
            this.panelUP.Controls.Add(this.btnFechar);
            this.panelUP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUP.Location = new System.Drawing.Point(0, 0);
            this.panelUP.Name = "panelUP";
            this.panelUP.Size = new System.Drawing.Size(630, 20);
            this.panelUP.TabIndex = 13;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::AdCert.Properties.Resources.delete;
            this.btnFechar.Location = new System.Drawing.Point(608, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(20, 20);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 17;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.CadetBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 20);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(15, 455);
            this.panelLeft.TabIndex = 14;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.CadetBlue;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(615, 20);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(15, 455);
            this.panelRight.TabIndex = 16;
            // 
            // rBtnCNPJCertificado
            // 
            this.rBtnCNPJCertificado.AutoSize = true;
            this.rBtnCNPJCertificado.Location = new System.Drawing.Point(236, 91);
            this.rBtnCNPJCertificado.Name = "rBtnCNPJCertificado";
            this.rBtnCNPJCertificado.Size = new System.Drawing.Size(66, 24);
            this.rBtnCNPJCertificado.TabIndex = 7;
            this.rBtnCNPJCertificado.TabStop = true;
            this.rBtnCNPJCertificado.Text = "CNPJ";
            this.rBtnCNPJCertificado.UseVisualStyleBackColor = true;
            this.rBtnCNPJCertificado.CheckedChanged += new System.EventHandler(this.rBtnCNPJCertificado_CheckedChanged);
            // 
            // rBtnCPFCertificado
            // 
            this.rBtnCPFCertificado.AutoSize = true;
            this.rBtnCPFCertificado.Location = new System.Drawing.Point(311, 91);
            this.rBtnCPFCertificado.Name = "rBtnCPFCertificado";
            this.rBtnCPFCertificado.Size = new System.Drawing.Size(55, 24);
            this.rBtnCPFCertificado.TabIndex = 8;
            this.rBtnCPFCertificado.TabStop = true;
            this.rBtnCPFCertificado.Text = "CPF";
            this.rBtnCPFCertificado.UseVisualStyleBackColor = true;
            this.rBtnCPFCertificado.CheckedChanged += new System.EventHandler(this.rBtnCPFCertificado_CheckedChanged);
            // 
            // textBoxCPFCNPJ
            // 
            this.textBoxCPFCNPJ.Location = new System.Drawing.Point(38, 91);
            this.textBoxCPFCNPJ.Mask = "00,000,000/0000-00";
            this.textBoxCPFCNPJ.Name = "textBoxCPFCNPJ";
            this.textBoxCPFCNPJ.Size = new System.Drawing.Size(172, 26);
            this.textBoxCPFCNPJ.TabIndex = 0;
            // 
            // errorProviderCliente
            // 
            this.errorProviderCliente.ContainerControl = this;
            // 
            // errorProviderSenha
            // 
            this.errorProviderSenha.ContainerControl = this;
            // 
            // errorProviderCPFCNPJ
            // 
            this.errorProviderCPFCNPJ.ContainerControl = this;
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 490);
            this.Controls.Add(this.textBoxCPFCNPJ);
            this.Controls.Add(this.rBtnCPFCertificado);
            this.Controls.Add(this.rBtnCNPJCertificado);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelUP);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.dTPDataFinal);
            this.Controls.Add(this.dTPDataInicio);
            this.Controls.Add(this.labelDataFinal);
            this.Controls.Add(this.labelDataInicio);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelCadastroCertificado);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCadastrar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrar";
            this.Shown += new System.EventHandler(this.FrmCadastrar_Shown);
            this.panelUP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCPFCNPJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastroCertificado;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelDataInicio;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.DateTimePicker dTPDataInicio;
        private System.Windows.Forms.DateTimePicker dTPDataFinal;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelUP;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.RadioButton rBtnCNPJCertificado;
        private System.Windows.Forms.RadioButton rBtnCPFCertificado;
        private System.Windows.Forms.MaskedTextBox textBoxCPFCNPJ;
        private System.Windows.Forms.ErrorProvider errorProviderCliente;
        private System.Windows.Forms.ErrorProvider errorProviderSenha;
        private System.Windows.Forms.ErrorProvider errorProviderCPFCNPJ;
    }
}