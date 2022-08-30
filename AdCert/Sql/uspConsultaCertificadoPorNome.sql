CREATE PROCEDURE uspConsultaCertificadoPorNome
	@Nome varchar(100)
AS
BEGIN
	SELECT
		IdCertificado,
		Nome,
		Cpf_Cnpj,
		DataInicio,
		DataFinal,
		Senha
	FROM
		tblCertificados
	WHERE
		Nome LIKE '%' + @Nome + '%' ORDER BY Nome ASC
END