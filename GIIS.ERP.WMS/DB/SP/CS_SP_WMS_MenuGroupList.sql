USE [CS_WMS]
GO

/****** Object:  StoredProcedure [dbo].[CS_SP_WMS_MenuGroupList]    Script Date: 7/3/2018 2:36:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CS_SP_WMS_MenuGroupList]
@UserID NVARCHAR(255)
,@Password NVARCHAR(255)
,@MenuGroupAsk NVARCHAR(255)
,@MenuGroupName NVARCHAR(255)
,@MenuGroupDesc NVARCHAR(255)
,@MenuAsk NVARCHAR(255)
,@MenuName NVARCHAR(255)
,@MenuUrl NVARCHAR(255)
,@ProductAsk NVARCHAR(255)
AS

DECLARE @WhereClause NVARCHAR(255) = ' WHERE 1=1 '
DECLARE @mysql NVARCHAR(1000)
DECLARE @ProdAsk bigint =0
BEGIN
SET @ProdAsk = DBO.[GetProductAsk]  (@UserID ,@Password,CAST(@ProductAsk AS bigint));

IF(@ProdAsk <> 0)
BEGIN
IF (@MenuGroupAsk <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND mg.Ask =' + @MenuGroupAsk 
END
IF (@MenuGroupName <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND mg.[Menu Group Name] =''' + @MenuGroupName +''''
END
IF (@MenuGroupDesc <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND mg.[Menu Group Description] =''' + @MenuGroupDesc +''''
END
IF (@MenuAsk <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND m.Ask =' + @MenuAsk 
END
IF (@MenuName <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND m.[Menu Name] =''' + @MenuName +''''
END

SELECT @mysql = ' SELECT mg.ask as mgAsk,mg.[Menu Group Name] as mgGpName,mg.[Menu Group Description] as mgGpDesc,
m.ask as mAsk,m.[Menu Name] as mMenuName,m.[Menu Url] as mMenuUrl
 from SYS_MENUGROUP mg 
INNER JOIN SYS_MENUGROUP_JUN mgj
ON mg.Ask = mgj.[Menu Group]
INNER JOIN SYS_MENU m 
ON m.Ask = mgj.Menu ' + @WhereClause 

EXEC (@mysql)

END
END












GO


