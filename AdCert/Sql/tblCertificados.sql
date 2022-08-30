CREATE TABLE [dbo].[tblCertificados]
(
	[IdCertificado] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(100) NOT NULL,
	[Cpf_Cnpj] VARCHAR(18) NOT NULL,
    [DataInicio] DATE NOT NULL, 
    [DataFinal] DATE NOT NULL, 
    [Senha] VARCHAR(20) NOT NULL 
)