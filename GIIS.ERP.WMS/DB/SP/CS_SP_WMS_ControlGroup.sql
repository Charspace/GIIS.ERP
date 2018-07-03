USE [CS_WMS]
GO

/****** Object:  StoredProcedure [dbo].[CS_SP_WMS_ControlGroup]    Script Date: 7/3/2018 2:37:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CS_SP_WMS_ControlGroup]
@UserID NVARCHAR(255)
,@Password NVARCHAR(255)
,@ProductAsk NVARCHAR(255)
AS

DECLARE @WhereClause NVARCHAR(255) = ' WHERE 1=1 '
DECLARE @mysql NVARCHAR(1000)
DECLARE @ProdAsk bigint =0
BEGIN
SET @ProdAsk = DBO.[GetProductAsk]  (@UserID ,@Password,CAST(@ProductAsk AS bigint));
IF(@ProdAsk <> 0)
BEGIN
	SELECT * FROM SYS_CONTROLGROUP
END
END











GO


