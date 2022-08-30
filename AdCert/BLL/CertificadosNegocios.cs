using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
    public class CertificadosNegocios
    {
        DataConexao dataConexao = new DataConexao();

        public string ManterCertificados(Int32 acao, Certificado certificados)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", acao);
                dataConexao.AdicionarParametros("@IdCertificado",certificados.IdCertificado);
                dataConexao.AdicionarParametros("@Nome", certificados.Nome);
                dataConexao.AdicionarParametros("@Cpf_Cnpj", certificados.Cpf_Cnpj);
                dataConexao.AdicionarParametros("@DataInicio", certificados.DataInicio);
                dataConexao.AdicionarParametros("@DataFinal", certificados.DataFinal);
                dataConexao.AdicionarParametros("@Senha", certificados.Senha);

                string idCertificados = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCertificado").ToString();

                return idCertificados;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public CertificadoColecao ConsultarCertificadosPorNome(string certificado)
        {
            try
            {
                CertificadoColecao certificadoColecao = new CertificadoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome",certificado);
                DataTable dataTableCertificados = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCertificadoPorNome");

                foreach (DataRow dataRow in dataTableCertificados.Rows)
                {

                    Certificado certificados = new Certificado();

                    certificados.IdCertificado = Convert.ToInt32(dataRow["IdCertificado"]);
                    certificados.Nome = Convert.ToString(dataRow["Nome"]);
                    certificados.Cpf_Cnpj = Convert.ToString(dataRow["Cpf_Cnpj"]);
                    certificados.DataInicio = Convert.ToDateTime(dataRow["DataInicio"]);
                    certificados.DataFinal = Convert.ToDateTime(dataRow["DataFinal"]); ;
                    certificados.Senha = Convert.ToString(dataRow["Senha"]);

                    certificadoColecao.Add(certificados);
                }

                return certificadoColecao;
            }
            catch(Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }

        public CertificadoColecao ConsultarDiasVencimento(int dias)
        {
            try
            {
                CertificadoColecao certificadoColecao = new CertificadoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@DiasConsulta", dias);
                DataTable dataTableCertificados = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaDiasVencimento");

                foreach (DataRow dataRow in dataTableCertificados.Rows)
                {

                    Certificado certificados = new Certificado();

                    certificados.IdCertificado = Convert.ToInt32(dataRow["IdCertificado"]);
                    certificados.Nome = Convert.ToString(dataRow["Nome"]);
                    certificados.Cpf_Cnpj = Convert.ToString(dataRow["Cpf_Cnpj"]);
                    certificados.DataInicio = Convert.ToDateTime(dataRow["DataInicio"]);
                    certificados.DataFinal = Convert.ToDateTime(dataRow["DataFinal"]); ;
                    certificados.Senha = Convert.ToString(dataRow["Senha"]);
                    certificados.Dias = Convert.ToInt32(dataRow["Dias"]);

                    certificadoColecao.Add(certificados);
                }

                return certificadoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }

    }
}
