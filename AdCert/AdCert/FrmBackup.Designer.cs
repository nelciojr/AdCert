namespace AdCert
{
    partial class FrmBackup
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
            this.gBxRestore = new System.Windows.Forms.GroupBox();
            this.btnOrigemRestore = new System.Windows.Forms.Button();
            this.txtDestinoRestore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrigemRestore = new System.Windows.Forms.TextBox();
            this.progressBarRestore = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.gBxBackup = new System.Windows.Forms.GroupBox();
            this.btnSelecionarBackup = new System.Windows.Forms.Button();
            this.txtDestinoBackup = new System.Windows.Forms.TextBox();
            this.txtOrigemBackup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fBDDestinoBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.oFDRestore = new System.Windows.Forms.OpenFileDialog();
            this.errorProviderBackup = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRestore = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBxRestore.SuspendLayout();
            this.gBxBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // gBxRestore
            // 
            this.gBxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBxRestore.Controls.Add(this.btnOrigemRestore);
            this.gBxRestore.Controls.Add(this.txtDestinoRestore);
            this.gBxRestore.Controls.Add(this.label4);
            this.gBxRestore.Controls.Add(this.txtOrigemRestore);
            this.gBxRestore.Controls.Add(this.progressBarRestore);
            this.gBxRestore.Controls.Add(this.label5);
            this.gBxRestore.Controls.Add(this.btnRestore);
            this.gBxRestore.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxRestore.Location = new System.Drawing.Point(11, 268);
            this.gBxRestore.Name = "gBxRestore";
            this.gBxRestore.Size = new System.Drawing.Size(606, 200);
            this.gBxRestore.TabIndex = 1;
            this.gBxRestore.TabStop = false;
            this.gBxRestore.Text = "Restore";
            // 
            // btnOrigemRestore
            // 
            this.btnOrigemRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrigemRestore.Location = new System.Drawing.Point(483, 32);
            this.btnOrigemRestore.Name = "btnOrigemRestore";
            this.btnOrigemRestore.Size = new System.Drawing.Size(102, 27);
            this.btnOrigemRestore.TabIndex = 9;
            this.btnOrigemRestore.Text = "Selecionar";
            this.btnOrigemRestore.UseVisualStyleBackColor = true;
            this.btnOrigemRestore.Click += new System.EventHandler(this.btnOrigemRestore_Click);
            // 
            // txtDestinoRestore
            // 
            this.txtDestinoRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinoRestore.Location = new System.Drawing.Point(91, 69);
            this.txtDestinoRestore.Name = "txtDestinoRestore";
            this.txtDestinoRestore.Size = new System.Drawing.Size(494, 26);
            this.txtDestinoRestore.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destino:";
            // 
            // txtOrigemRestore
            // 
            this.txtOrigemRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigemRestore.Location = new System.Drawing.Point(92, 32);
            this.txtOrigemRestore.Name = "txtOrigemRestore";
            this.txtOrigemRestore.Size = new System.Drawing.Size(365, 26);
            this.txtOrigemRestore.TabIndex = 8;
            // 
            // progressBarRestore
            // 
            this.progressBarRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarRestore.Location = new System.Drawing.Point(20, 118);
            this.progressBarRestore.Name = "progressBarRestore";
            this.progressBarRestore.Size = new System.Drawing.Size(565, 23);
            this.progressBarRestore.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Origem:";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(483, 157);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(102, 27);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // gBxBackup
            // 
            this.gBxBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBxBackup.Controls.Add(this.btnSelecionarBackup);
            this.gBxBackup.Controls.Add(this.txtDestinoBackup);
            this.gBxBackup.Controls.Add(this.txtOrigemBackup);
            this.gBxBackup.Controls.Add(this.label3);
            this.gBxBackup.Controls.Add(this.label1);
            this.gBxBackup.Controls.Add(this.progressBarBackup);
            this.gBxBackup.Controls.Add(this.btnBackup);
            this.gBxBackup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxBackup.Location = new System.Drawing.Point(12, 62);
            this.gBxBackup.Name = "gBxBackup";
            this.gBxBackup.Size = new System.Drawing.Size(605, 200);
            this.gBxBackup.TabIndex = 2;
            this.gBxBackup.TabStop = false;
            this.gBxBackup.Text = "Backup";
            // 
            // btnSelecionarBackup
            // 
            this.btnSelecionarBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarBackup.Location = new System.Drawing.Point(482, 68);
            this.btnSelecionarBackup.Name = "btnSelecionarBackup";
            this.btnSelecionarBackup.Size = new System.Drawing.Size(102, 27);
            this.btnSelecionarBackup.TabIndex = 8;
            this.btnSelecionarBackup.Text = "Selecionar";
            this.btnSelecionarBackup.UseVisualStyleBackColor = true;
            this.btnSelecionarBackup.Click += new System.EventHandler(this.btnSelecionarBackup_Click);
            // 
            // txtDestinoBackup
            // 
            this.txtDestinoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinoBackup.Location = new System.Drawing.Point(90, 69);
            this.txtDestinoBackup.Name = "txtDestinoBackup";
            this.txtDestinoBackup.Size = new System.Drawing.Size(366, 26);
            this.txtDestinoBackup.TabIndex = 7;
            // 
            // txtOrigemBackup
            // 
            this.txtOrigemBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigemBackup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigemBackup.Location = new System.Drawing.Point(90, 32);
            this.txtOrigemBackup.Name = "txtOrigemBackup";
            this.txtOrigemBackup.Size = new System.Drawing.Size(494, 26);
            this.txtOrigemBackup.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origem:";
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarBackup.Location = new System.Drawing.Point(21, 118);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(563, 23);
            this.progressBarBackup.TabIndex = 3;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.Location = new System.Drawing.Point(482, 157);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(102, 27);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Backup e Restore";
            // 
            // oFDRestore
            // 
            this.oFDRestore.FileName = "*.bak";
            this.oFDRestore.Filter = "Arquivo de Backup | *.bak";
            // 
            // errorProviderBackup
            // 
            this.errorProviderBackup.ContainerControl = this;
            // 
            // errorProviderRestore
            // 
            this.errorProviderRestore.ContainerControl = this;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gBxBackup);
            this.Controls.Add(this.gBxRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBackup";
            this.Text = "frmBackup";
            this.gBxRestore.ResumeLayout(false);
            this.gBxRestore.PerformLayout();
            this.gBxBackup.ResumeLayout(false);
            this.gBxBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRestore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBxRestore;
        private System.Windows.Forms.GroupBox gBxBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.ProgressBar progressBarRestore;
        private System.Windows.Forms.ProgressBar progressBarBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinoRestore;
        private System.Windows.Forms.TextBox txtOrigemRestore;
        private System.Windows.Forms.TextBox txtDestinoBackup;
        private System.Windows.Forms.TextBox txtOrigemBackup;
        private System.Windows.Forms.Button btnOrigemRestore;
        private System.Windows.Forms.Button btnSelecionarBackup;
        private System.Windows.Forms.FolderBrowserDialog fBDDestinoBackup;
        private System.Windows.Forms.OpenFileDialog oFDRestore;
        private System.Windows.Forms.ErrorProvider errorProviderBackup;
        private System.Windows.Forms.ErrorProvider errorProviderRestore;
    }
}