using System;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Drawing;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace AdCert
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            
            dataGridViewSituacao.AutoGenerateColumns = false;
        }

        public void AtualizarGridVencimento(int Dias)
        {
            CertificadosNegocios certificadosNegocios = new CertificadosNegocios();

            CertificadoColecao certificadoColecao = new CertificadoColecao();

            certificadoColecao = certificadosNegocios.ConsultarDiasVencimento(Dias);

            dataGridViewSituacao.DataSource = null;
            dataGridViewSituacao.DataSource = certificadoColecao;

            dataGridViewSituacao.Update();
            dataGridViewSituacao.Refresh();
        }

        private void FrmHome_Shown(object sender, EventArgs e)
        {
            rBtn15Dias.Checked = true;

        }

        private void rBtn15Dias_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridVencimento(15);
        }

        private void rBtn30Dias_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridVencimento(30);
        }

        private void rBtn45Dias_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridVencimento(45);
        }

        private void rBtn60Dias_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridVencimento(60);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewSituacao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja Realmente Excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            Certificado certificadoSelecionado = (dataGridViewSituacao.SelectedRows[0].DataBoundItem as Certificado);

            CertificadosNegocios certificadosNegocios = new CertificadosNegocios();

            string retorno = certificadosNegocios.ManterCertificados(0, certificadoSelecionado);

            try
            {
                int idCertificado = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído Com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGridVencimento(15);
            }
            catch
            {
                MessageBox.Show("Não Foi Possível Excluir.\nDetalhes: " + retorno, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewSituacao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Certificado certificadoSelecionado = (dataGridViewSituacao.SelectedRows[0].DataBoundItem as Certificado);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Editar, certificadoSelecionado);
            DialogResult dialogResult = frmCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGridVencimento(15);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialogSituacao.Document = printDocumentSituacao;
            printPreviewDialogSituacao.ShowDialog();
        }

        private void printDocumentSituacao_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBitmap = new Bitmap(this.dataGridViewSituacao.Width, this.dataGridViewSituacao.Height);

            dataGridViewSituacao.DrawToBitmap(objBitmap, new Rectangle(0, 0, this.dataGridViewSituacao.Width, this.dataGridViewSituacao.Height));
            e.Graphics.DrawImage(objBitmap, 50, 120);
            e.Graphics.DrawString(label1.Text, new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new Point(120, 30));
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewSituacao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Certificado certificadoSelecionado = (dataGridViewSituacao.SelectedRows[0].DataBoundItem as Certificado);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Visualizar, certificadoSelecionado);
            frmCadastrar.ShowDialog();
        }

        private void dataGridViewSituacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSituacao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Certificado certificadoSelecionado = (dataGridViewSituacao.SelectedRows[0].DataBoundItem as Certificado);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Visualizar, certificadoSelecionado);
            frmCadastrar.ShowDialog();
        }

        private void dataGridViewSituacao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            Certificado certificado = dataGridViewSituacao.Rows[e.RowIndex].DataBoundItem as Certificado;

            if (certificado != null)
            {
                if (certificado.Dias < 0)
                {
                    dataGridViewSituacao.Rows[e.RowIndex].Cells["colVencimento"].Value = Math.Abs(certificado.Dias) + " Dias A Vencer!";
                    dataGridViewSituacao.Rows[e.RowIndex].Cells["colVencimento"].Style.BackColor = Color.Yellow;


                }
                else if (certificado.Dias == 0)
                {
                    dataGridViewSituacao.Rows[e.RowIndex].Cells["colVencimento"].Value = "Vencimento Hoje!";
                    dataGridViewSituacao.Rows[e.RowIndex].Cells["colVencimento"].Style.BackColor = Color.Orange;
                }
                else if (certificado.Dias > 0)
                {
                    dataGridViewSituacao.Rows[e.RowIndex].Cells["colVencimento"].Value = certificado.Dias + " Dias Vencidos!";
                    dataGridViewSituacao.Rows[e.RowIndex].Cells["colVencimento"].Style.BackColor = Color.Red;
                }
            }
         

        }

       
    }
}
