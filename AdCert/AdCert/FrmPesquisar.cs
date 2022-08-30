using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace AdCert
{
    public partial class FrmPesquisar : Form
    {
        public FrmPesquisar()
        {
            InitializeComponent();

            dataGridViewPesquisar.AutoGenerateColumns = false;
        }

        public void AtualizarGrid()
        {
            CertificadosNegocios certificadosNegocios = new CertificadosNegocios();

            CertificadoColecao certificadoColecao = new CertificadoColecao();

            certificadoColecao = certificadosNegocios.ConsultarCertificadosPorNome(textBoxPesquisar.Text);

            dataGridViewPesquisar.DataSource = null;
            dataGridViewPesquisar.DataSource = certificadoColecao;

            dataGridViewPesquisar.Update();
            dataGridViewPesquisar.Refresh();
        }

        private void FrmPesquisar_Shown(object sender, EventArgs e)
        {
            textBoxPesquisar.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void textBoxPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewPesquisar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja Realmente Excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            Certificado certificadoSelecionado = (dataGridViewPesquisar.SelectedRows[0].DataBoundItem as Certificado);

            CertificadosNegocios certificadosNegocios = new CertificadosNegocios();

            string retorno = certificadosNegocios.ManterCertificados(0, certificadoSelecionado);

            try
            {
                int idCertificado = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído Com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não Foi Possível Excluir.\nDetalhes: " + retorno, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPesquisar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Certificado certificadoSelecionado = (dataGridViewPesquisar.SelectedRows[0].DataBoundItem as Certificado);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Visualizar, certificadoSelecionado);
            frmCadastrar.ShowDialog();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPesquisar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Certificado certificadoSelecionado = (dataGridViewPesquisar.SelectedRows[0].DataBoundItem as Certificado);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Editar, certificadoSelecionado);
            DialogResult dialogResult = frmCadastrar.ShowDialog();
            if(dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }

         
        }

        private void dataGridViewPesquisar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Certificado certificadoSelecionado = (dataGridViewPesquisar.SelectedRows[0].DataBoundItem as Certificado);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Visualizar, certificadoSelecionado);
            frmCadastrar.ShowDialog();
        }

        private void dataGridViewPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Certificado certificadoSelecionado = (dataGridViewPesquisar.SelectedRows[0].DataBoundItem as Certificado);

                FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Visualizar, certificadoSelecionado);
                frmCadastrar.ShowDialog();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }


    }
}


