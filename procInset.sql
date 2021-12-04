USE [FormularionFin4teen]
GO

/****** Object:  StoredProcedure [dbo].[InsertUsuario]    Script Date: 03/12/2021 18:59:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[InsertUsuario]
@NOME varchar(30),
@SOBRENOME varchar(50),
@EMAIL varchar(100),
@TELEFONE varchar(20)

as
begin
    Insert into USUARIOS (NOME, SOBRENOME, EMAIL, TELEFONE) output Inserted.USUARIO_ID values (@NOME, @SOBRENOME, @EMAIL, @TELEFONE)
End
GO

