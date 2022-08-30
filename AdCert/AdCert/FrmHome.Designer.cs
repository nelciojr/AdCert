namespace AdCert
{
    partial class FrmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtn15Dias = new System.Windows.Forms.RadioButton();
            this.rBtn30Dias = new System.Windows.Forms.RadioButton();
            this.rBtn45Dias = new System.Windows.Forms.RadioButton();
            this.rBtn60Dias = new System.Windows.Forms.RadioButton();
            this.dataGridViewSituacao = new System.Windows.Forms.DataGridView();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocumentSituacao = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogSituacao = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSituacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Situação Certificado";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(506, 437);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(112, 35);
            this.btnVisualizar.TabIndex = 21;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(146, 437);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(266, 437);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 35);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Vecimento:";
            // 
            // rBtn15Dias
            // 
            this.rBtn15Dias.AutoSize = true;
            this.rBtn15Dias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtn15Dias.Location = new System.Drawing.Point(108, 67);
            this.rBtn15Dias.Name = "rBtn15Dias";
            this.rBtn15Dias.Size = new System.Drawing.Size(77, 24);
            this.rBtn15Dias.TabIndex = 25;
            this.rBtn15Dias.TabStop = true;
            this.rBtn15Dias.Text = "15 Dias";
            this.rBtn15Dias.UseVisualStyleBackColor = true;
            this.rBtn15Dias.CheckedChanged += new System.EventHandler(this.rBtn15Dias_CheckedChanged);
            // 
            // rBtn30Dias
            // 
            this.rBtn30Dias.AutoSize = true;
            this.rBtn30Dias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtn30Dias.Location = new System.Drawing.Point(191, 67);
            this.rBtn30Dias.Name = "rBtn30Dias";
            this.rBtn30Dias.Size = new System.Drawing.Size(77, 24);
            this.rBtn30Dias.TabIndex = 26;
            this.rBtn30Dias.TabStop = true;
            this.rBtn30Dias.Text = "30 Dias";
            this.rBtn30Dias.UseVisualStyleBackColor = true;
            this.rBtn30Dias.CheckedChanged += new System.EventHandler(this.rBtn30Dias_CheckedChanged);
            // 
            // rBtn45Dias
            // 
            this.rBtn45Dias.AutoSize = true;
            this.rBtn45Dias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtn45Dias.Location = new System.Drawing.Point(274, 67);
            this.rBtn45Dias.Name = "rBtn45Dias";
            this.rBtn45Dias.Size = new System.Drawing.Size(77, 24);
            this.rBtn45Dias.TabIndex = 27;
            this.rBtn45Dias.TabStop = true;
            this.rBtn45Dias.Text = "45 Dias";
            this.rBtn45Dias.UseVisualStyleBackColor = true;
            this.rBtn45Dias.CheckedChanged += new System.EventHandler(this.rBtn45Dias_CheckedChanged);
            // 
            // rBtn60Dias
            // 
            this.rBtn60Dias.AutoSize = true;
            this.rBtn60Dias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtn60Dias.Location = new System.Drawing.Point(357, 67);
            this.rBtn60Dias.Name = "rBtn60Dias";
            this.rBtn60Dias.Size = new System.Drawing.Size(77, 24);
            this.rBtn60Dias.TabIndex = 28;
            this.rBtn60Dias.TabStop = true;
            this.rBtn60Dias.Text = "60 Dias";
            this.rBtn60Dias.UseVisualStyleBackColor = true;
            this.rBtn60Dias.CheckedChanged += new System.EventHandler(this.rBtn60Dias_CheckedChanged);
            // 
            // dataGridViewSituacao
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSituacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSituacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSituacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCliente,
            this.colDataFinal,
            this.colVencimento});
            this.dataGridViewSituacao.Location = new System.Drawing.Point(13, 91);
            this.dataGridViewSituacao.MultiSelect = false;
            this.dataGridViewSituacao.Name = "dataGridViewSituacao";
            this.dataGridViewSituacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSituacao.Size = new System.Drawing.Size(605, 338);
            this.dataGridViewSituacao.TabIndex = 29;
            this.dataGridViewSituacao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewSituacao_CellFormatting);
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 250;
            // 
            // colDataFinal
            // 
            this.colDataFinal.DataPropertyName = "DataFinal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDataFinal.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDataFinal.HeaderText = "Data Final";
            this.colDataFinal.Name = "colDataFinal";
            this.colDataFinal.ReadOnly = true;
            // 
            // colVencimento
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colVencimento.DefaultCellStyle = dataGridViewCellStyle4;
            this.colVencimento.HeaderText = "Situação";
            this.colVencimento.Name = "colVencimento";
            this.colVencimento.ReadOnly = true;
            this.colVencimento.Width = 200;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(386, 437);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(112, 35);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocumentSituacao
            // 
            this.printDocumentSituacao.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSituacao_PrintPage);
            // 
            // printPreviewDialogSituacao
            // 
            this.printPreviewDialogSituacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSituacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSituacao.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogSituacao.Enabled = true;
            this.printPreviewDialogSituacao.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogSituacao.Icon")));
            this.printPreviewDialogSituacao.Name = "printPreviewDialogSituacao";
            this.printPreviewDialogSituacao.Visible = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 490);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dataGridViewSituacao);
            this.Controls.Add(this.rBtn60Dias);
            this.Controls.Add(this.rBtn45Dias);
            this.Controls.Add(this.rBtn30Dias);
            this.Controls.Add(this.rBtn15Dias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.Text = "frmHome";
            this.Shown += new System.EventHandler(this.FrmHome_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSituacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtn15Dias;
        private System.Windows.Forms.RadioButton rBtn30Dias;
        private System.Windows.Forms.RadioButton rBtn45Dias;
        private System.Windows.Forms.RadioButton rBtn60Dias;
        private System.Windows.Forms.DataGridView dataGridViewSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencimento;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocumentSituacao;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogSituacao;
    }
}