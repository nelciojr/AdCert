using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AdCert
{
    public partial class FrmMenu : Form
    {
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

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwmd, int wmsg, int wparam, int lparam);

        public FrmMenu()
        {
            Thread thread = new Thread(new ThreadStart(StartForm));
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thread.Abort();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
           

        }

        public static void percorrerControles(Control _ctrl)
        {
            if (_ctrl.HasChildren)
            {
                foreach (Control _child in _ctrl.Controls)
                {
                    if (_ctrl.HasChildren)
                        percorrerControles(_child);
                }
            }
            else
            {
                ///Não funciona para Numeric Up Down
                if (_ctrl is TextBox ||
                _ctrl is MaskedTextBox ||
                _ctrl is ListBox ||
                _ctrl is CheckBox ||
                _ctrl is TabPage ||
                _ctrl is DateTimePicker ||
                _ctrl is ComboBox)
                {
                    /// inibe a ação do Enter para evitar o comportamento de
                    /// Accept em alguns casos
                    _ctrl.KeyDown += delegate (object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Enter)
                            e.SuppressKeyPress = true;
                    };
                    /// adiciona a tratativa à tecla Enter e envia o TAB para
                    /// promover a navegação
                    _ctrl.KeyUp += delegate (object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            // SendKeys.Send("{TAB}");
                            _ctrl.FindForm().SelectNextControl(_ctrl, true, true, true, false);
                        }
                    };
                }
            }
        }
        public static bool validarCampo(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Preencha Todos os Campos!");
                return false;

            }
        }

        public static bool validarMTextbox(MaskedTextBox maskedTextBox, ErrorProvider errorProvider)
        {
            if (maskedTextBox.Text.Contains(" "))
            {
                errorProvider.SetError(maskedTextBox, "Preencha Todos os Campos!");
                return false;

            }
            else
            {
                errorProvider.SetError(maskedTextBox, "");
                return true;

            }
        }

        public static bool validarComboBox(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrEmpty(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "");
                return true;
            }
            else
            {
                errorProvider.SetError(comboBox, "Preencha Todos os Campos!");
                return false;

            }
        }
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }



        public void StartForm()
        {
            Application.Run(new FrmSplashScreen());
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            AbrirFormNoConteiner(new FrmHome());
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AdCertNome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 170)
            {
                panelMenu.Width = 72;
            }
            else
                panelMenu.Width = 170;
        }

        private void RestaurarApp()
        {
            if (!this.Visible)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ntiBandeja.Visible = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                ntiBandeja.Visible = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
                                   
        }

        private void ntiBandeja_DoubleClick(object sender, EventArgs e)
        {
            RestaurarApp();
        }

        private void mniRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarApp();
        }

        private void mniSair_Click(object sender, EventArgs e)
        {
            ntiBandeja.Visible = false;
            Application.Exit();
        }
        public void AbrirFormNoConteiner(object FormContido)
        {
            if (this.panelConteiner.Controls.Count > 0)
                this.panelConteiner.Controls.RemoveAt(0);
            Form form = FormContido as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelConteiner.Controls.Add(form);
            this.panelConteiner.Tag = form;
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirFormNoConteiner(new FrmHome());
        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFormNoConteiner(new FrmCadastrar(AcaoNaTela.Cadastrar, null));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AbrirFormNoConteiner(new FrmPesquisar());
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            AbrirFormNoConteiner(new FrmBackup());
        }

       
    }
}
