CREATE PROCEDURE uspConsultaDiasVencimento
	@DiasConsulta int
AS
BEGIN
	SELECT
		IdCertificado,
		Nome,
		Cpf_Cnpj,
		DataInicio,
		DataFinal,
		Senha,
		DATEDIFF(DD, DataFinal, GETDATE()) AS Dias
	FROM
		tblCertificados
	WHERE
		DataFinal BETWEEN(GETDATE()) AND (GETDATE()+@DiasConsulta) OR DataFinal < GETDATE()
	ORDER BY 
		DataFinal ASC

END