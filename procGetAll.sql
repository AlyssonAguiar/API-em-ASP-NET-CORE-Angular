USE [FormularionFin4teen]
GO

/****** Object:  StoredProcedure [dbo].[GetAllUsuarios]    Script Date: 03/12/2021 18:59:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[GetAllUsuarios]

as
begin
    select USUARIO_ID, NOME, SOBRENOME, EMAIL, TELEFONE FROM USUARIOS
End
GO

