using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DTO;
using BLL;

namespace AdCert
{
    public partial class FrmCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;
        Certificado certificadoSelecionado;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public FrmCadastrar(AcaoNaTela acaoNaTela, Certificado certificado)
        {
            InitializeComponent();
            FrmMenu.percorrerControles(this);
            rBtnCNPJCertificado.Checked = true;
            
            this.acaoNaTelaSelecionada = acaoNaTela;
            this.certificadoSelecionado = certificado;

            if (acaoNaTela == AcaoNaTela.Cadastrar)
            {
                
                btnFechar.Visible = false;
                panelUP.Visible = false;
                panelBottom.Visible = false;
                panelLeft.Visible = false;
                panelRight.Visible = false;

            }
            else if(acaoNaTela == AcaoNaTela.Editar)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                labelCadastroCertificado.Text = "Editar Certificado";
                btnCadastrar.Text = "Cancelar";
                btnLimpar.Text = "Salvar";
                textBoxCliente.Text = certificado.Nome.ToString();

                

                if (certificado.Cpf_Cnpj.Length.Equals(18))
                {
                    textBoxCPFCNPJ.Mask = "00,000,000/0000-00";
                    
                }
                else if (certificado.Cpf_Cnpj.Length.Equals(14))
                {
                    rBtnCPFCertificado.Checked = true;
                    textBoxCPFCNPJ.Mask = "000,000,000-00";
                    
                }

                textBoxCPFCNPJ.Text = certificado.Cpf_Cnpj.ToString();

                textBoxSenha.Text = certificado.Senha.ToString();
                dTPDataInicio.Value = certificado.DataInicio;
                dTPDataFinal.Value = certificado.DataFinal;
            }

            else if (acaoNaTela == AcaoNaTela.Visualizar)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                labelCadastroCertificado.Text = "Visualizar Certificado";
                btnCadastrar.Text = "Fechar";
                btnLimpar.Hide();

                textBoxCliente.Text = certificado.Nome.ToString();
                textBoxCliente.Enabled = false;

                if (certificado.Cpf_Cnpj.Length.Equals(18))
                {
                    textBoxCPFCNPJ.Mask = "00,000,000/0000-00";

                }
                else if (certificado.Cpf_Cnpj.Length.Equals(14))
                {
                    rBtnCPFCertificado.Checked = true;
                    textBoxCPFCNPJ.Mask = "000,000,000-00";
                    

                }

                rBtnCPFCertificado.Enabled = false;
                rBtnCNPJCertificado.Enabled = false;

                textBoxCPFCNPJ.Text = certificado.Cpf_Cnpj.ToString();
                textBoxCPFCNPJ.Enabled = false;

                textBoxSenha.Text = certificado.Senha.ToString();
                textBoxSenha.Enabled = false;

                dTPDataInicio.Value = certificado.DataInicio;
                dTPDataInicio.Enabled = false;

                dTPDataFinal.Value = certificado.DataFinal;
                dTPDataFinal.Enabled = false;
            }
        }

        private void FrmCadastrar_Shown(object sender, EventArgs e)
        {
            textBoxCPFCNPJ.Focus();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (acaoNaTelaSelecionada == AcaoNaTela.Cadastrar)
            {
                if ((FrmMenu.validarMTextbox(textBoxCPFCNPJ, errorProviderCPFCNPJ) && 
                    FrmMenu.validarCampo(textBoxCliente, errorProviderCliente) && 
                    FrmMenu.validarCampo(textBoxSenha, errorProviderSenha).Equals(true)))
                { 
                    Certificado certificado = new Certificado();

                    certificado.Nome = textBoxCliente.Text;

                    if (rBtnCNPJCertificado.Checked.Equals(true))
                    {
                        if (FrmMenu.IsCnpj(textBoxCPFCNPJ.Text.ToString()))
                        {
                            certificado.Cpf_Cnpj = textBoxCPFCNPJ.Text;
                        }
                        else
                        {
                            MessageBox.Show("CNPJ Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }

                    }
                    else if (rBtnCPFCertificado.Checked.Equals(true))
                    {
                        if (FrmMenu.IsCpf(textBoxCPFCNPJ.Text.ToString()))
                        {
                            certificado.Cpf_Cnpj = textBoxCPFCNPJ.Text;
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }
                    }

                    certificado.DataInicio = dTPDataInicio.Value;
                    certificado.DataFinal = dTPDataFinal.Value;
                    certificado.Senha = textBoxSenha.Text;

                    CertificadosNegocios certificadosNegocios = new CertificadosNegocios();

                    string retorno = certificadosNegocios.ManterCertificados(1, certificado);

                    try
                    {
                        int idCertificado = Convert.ToInt32(retorno);
                        MessageBox.Show("Cadastrado Com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar_Campos();

                    }
                    catch
                    {
                        MessageBox.Show("Não Foi Possível Cadastrar.\nDetalhes: " + retorno, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Não Foi Possível Fazer o Cadastro!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else if (acaoNaTelaSelecionada == AcaoNaTela.Editar)
            {
                this.Close();
                return;
            }

            else if (acaoNaTelaSelecionada == AcaoNaTela.Visualizar)
            {
                this.Close();
                return;
            }
        }

        private void Limpar_Campos()
        {
            textBoxCliente.Clear();
            textBoxCPFCNPJ.Clear();
            textBoxSenha.Clear();
            dTPDataInicio.Value = DateTime.Now;
            dTPDataFinal.Value = DateTime.Now;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaSelecionada == AcaoNaTela.Cadastrar)
            {
                Limpar_Campos();
            }


            else if (acaoNaTelaSelecionada == AcaoNaTela.Editar)
            {
                if ((FrmMenu.validarMTextbox(textBoxCPFCNPJ, errorProviderCPFCNPJ) &&
                   FrmMenu.validarCampo(textBoxCliente, errorProviderCliente) &&
                   FrmMenu.validarCampo(textBoxSenha, errorProviderSenha).Equals(true)))
                {
                    Certificado certificado = new Certificado();

                    certificado.IdCertificado = Convert.ToInt32(certificadoSelecionado.IdCertificado);
                    certificado.Nome = textBoxCliente.Text;
                    certificado.Cpf_Cnpj = textBoxCPFCNPJ.Text;
                    certificado.DataInicio = dTPDataInicio.Value;
                    certificado.DataFinal = dTPDataFinal.Value;
                    certificado.Senha = textBoxSenha.Text;

                    CertificadosNegocios certificadosNegocios = new CertificadosNegocios();

                    string retorno = certificadosNegocios.ManterCertificados(2, certificado);

                    try
                    {
                        int idCertificado = Convert.ToInt32(retorno);
                        MessageBox.Show("Editado Com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não Foi Possível Editar.\nDetalhes: " + retorno, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não Foi Possível Fazer o Editar!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void rBtnCNPJCertificado_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCPFCNPJ.Mask = "00,000,000/0000-00";
            textBoxCPFCNPJ.Focus();
        }

        private void rBtnCPFCertificado_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCPFCNPJ.Mask = "000,000,000-00";
            textBoxCPFCNPJ.Focus();
        }


    }
}
