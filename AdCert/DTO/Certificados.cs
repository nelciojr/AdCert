using System;

namespace DTO
{
    public class Certificado
    {
        public int Acao { get; set; }
        public int IdCertificado { get; set; }
        public string Nome { get; set; }
        public string Cpf_Cnpj { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public string Senha { get; set; }
        public int Dias { get; set; }
    }
}
