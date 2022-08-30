CREATE PROCEDURE uspManterCertificado
	@Acao int,
	@IdCertificado int,
    @Nome varchar(100),
	@Cpf_Cnpj varchar(18),
	@DataInicio date,
	@DataFinal date,
	@Senha varchar(20)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@Acao = 0)
			BEGIN
				DELETE FROM tblCertificados
				WHERE IdCertificado = @IdCertificado

				SELECT @IdCertificado AS Retorno
			END
			ELSE IF(@Acao = 1)
			BEGIN
				IF(EXISTS(SELECT IdCertificado FROM tblCertificados WHERE Cpf_Cnpj = @Cpf_Cnpj))
					RAISERROR('CPF ou CNPJ Já Existente!',14,1);

				INSERT INTO tblCertificados (Nome, Cpf_Cnpj, DataInicio, DataFinal, Senha)
				VALUES (@Nome, @Cpf_Cnpj, @DataInicio, @DataFinal, @Senha)

				SELECT @@IDENTITY AS Retorno
			END
			ELSE IF(@Acao = 2)
			BEGIN
				UPDATE tblCertificados
				SET Nome = @Nome, Cpf_Cnpj = @Cpf_Cnpj, DataInicio = @DataInicio, DataFinal = @DataFinal, Senha = @Senha
				WHERE IdCertificado = @IdCertificado

				SELECT @IdCertificado AS Retorno
			END
			ELSE
			BEGIN
				RAISERROR('Ação Não Implementada!',14,1);
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END