using DbaCon;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System;
using System.IO;
using System.Windows.Forms;

namespace AdCert
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
            string localDB = Directory.GetCurrentDirectory();
            txtOrigemBackup.Text = localDB + @"\AdCertDB.mdf";
            txtDestinoRestore.Text = localDB + @"\AdCertDB.mdf";
        }

        private string converteData(string data)
        {
            data = data.Replace(" ", string.Empty);
            data = data.Replace("/", string.Empty);
            data = data.Replace(":", string.Empty);
            return data;
        }

        private void btnSelecionarBackup_Click(object sender, EventArgs e)
        {
            if(fBDDestinoBackup.ShowDialog() == DialogResult.OK)
            {
                
                txtDestinoBackup.Text = fBDDestinoBackup.SelectedPath;

            }
        }

        private void btnOrigemRestore_Click(object sender, EventArgs e)
        {
            if(oFDRestore.ShowDialog() == DialogResult.OK)
            {
                              
                txtOrigemRestore.Text = oFDRestore.FileName;

            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            progressBarBackup.Value = 0;

            if ((FrmMenu.validarCampo(txtDestinoBackup, errorProviderBackup).Equals(true)))
            {
                try
                {

                    DateTime dateTimeDB = DateTime.Now;

                    DataConexao dataConexao = new DataConexao();
                    SqlConnection sqlConnection = dataConexao.CriarConexao();

                    Server server = new Server(new ServerConnection(sqlConnection));
                    Backup backup = new Backup() { Action = BackupActionType.Database, Database = txtOrigemBackup.Text };
                    backup.Devices.AddDevice(txtDestinoBackup.Text + @"\" + converteData(Convert.ToString(dateTimeDB)) + "_AdCertDB.bak", DeviceType.File);
                    backup.Initialize = true;
                    backup.PercentComplete += Backup_PercentComplete;
                    backup.Complete += Backup_Complete;
                    backup.SqlBackupAsync(server);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não Foi Possível Fazer o Backup.\nDetalhes: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DataConexao dataConexao = new DataConexao();
                    SqlConnection sqlConnection = dataConexao.CriarConexao();
                    if (sqlConnection != null)
                        ((IDisposable)sqlConnection).Dispose();
                }
            }
        }

        private void Backup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("Backup Realizado Com Sucesso!\nDetalhes: " + e.Error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void Backup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBarBackup.Invoke((MethodInvoker)delegate
            {
                progressBarBackup.Value = e.Percent;
                progressBarBackup.Update();
            });
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            progressBarRestore.Value = 0;

            if ((FrmMenu.validarCampo(txtOrigemRestore, errorProviderRestore).Equals(true)))
            {
                try
                {

                    DataConexao dataConexao = new DataConexao();
                    SqlConnection sqlConnection = dataConexao.CriarConexao();

                    
                    Server server = new Server(new ServerConnection(sqlConnection));
                    Restore restore = new Restore() { Database = txtDestinoRestore.Text, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                    restore.Devices.AddDevice(txtOrigemRestore.Text, DeviceType.File);
                    restore.PercentComplete += Restore_PercentComplete;
                    restore.Complete += Restore_Complete;
                    restore.SqlRestoreAsync(server);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não Foi Possível Fazer o Restore.\nDetalhes: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DataConexao dataConexao = new DataConexao();
                    SqlConnection sqlConnection = dataConexao.CriarConexao();
                    if (sqlConnection != null)
                        ((IDisposable)sqlConnection).Dispose();
                }
            }
        }
        private void Restore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Restore Realizado Com Sucesso!\nDetalhes: " + e.Error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Restore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBarRestore.Invoke((MethodInvoker)delegate
            {
                progressBarRestore.Value = e.Percent;
                progressBarRestore.Update();
            });
        }

       
    }
}
