USE [CS_WMS]
GO

/****** Object:  StoredProcedure [dbo].[CS_SP_WMS_User]    Script Date: 7/3/2018 2:34:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CS_SP_WMS_User]
@UserID NVARCHAR(255)
,@Password NVARCHAR(255)
,@UserAsk NVARCHAR(255)
,@UserDesc NVARCHAR(255)
,@UserPhone NVARCHAR(255)
,@UserEmail NVARCHAR(255)
,@MenuGroupAsk NVARCHAR(255)
,@MenuGroupName NVARCHAR(255)
,@MenuGroupDesc NVARCHAR(255)
,@ControlGroupAsk NVARCHAR(255)
,@ControlGroupName NVARCHAR(255)
,@ControlGroupDesc NVARCHAR(255)
,@ProductAsk NVARCHAR(255)
,@ProductName NVARCHAR(255)
,@ProductDesc NVARCHAR(255)
AS

DECLARE @WhereClause NVARCHAR(MAX) = ' WHERE 1=1 '
DECLARE @mysql NVARCHAR(MAX)
DECLARE @ProdAsk bigint =0
BEGIN
SET @ProdAsk = DBO.[GetProductAsk]  (@UserID ,@Password,CAST(@ProductAsk AS bigint));

IF(@ProdAsk <> 0)
BEGIN
IF (@UserID <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND u.[User ID] =''' + @UserID +''''
END
IF (@UserAsk <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND u.Ask =' + @UserAsk 
END
IF (@UserDesc <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND u.[User Description] =''' + @UserDesc +''''
END
IF (@UserPhone <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND u.[User Phone] =''' + @UserPhone + ''''
END
IF (@UserEmail <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND u.[User Email] =''' + @UserEmail +''''
END
IF (@MenuGroupAsk <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND mg.Ask =' + @MenuGroupAsk
END
IF (@MenuGroupName <> '')
BEGIN
	SET @WhereClause = ' AND mg.[Menu Group Name] =''' + @MenuGroupName +''''
END
IF (@MenuGroupDesc <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND mg.[Menu Group Description] =''' + @MenuGroupDesc +''''
END
IF (@ControlGroupAsk <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND cg.Ask =' + @ControlGroupAsk 
END
IF (@ControlGroupName <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND cg.[Control Group Name] ='''+@ControlGroupName+''''
END
IF (@ControlGroupDesc <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND cg.[Control Group Description] ='''+@ControlGroupDesc+''''
END
IF (@ProductAsk <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND p.Ask ='+@ProductAsk
END
IF (@ProductName <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND p.[Product Name] = '''+@ProductName+''''
END
IF (@ProductDesc <> '')
BEGIN
	SET @WhereClause = @WhereClause + ' AND p.[Product Detail] ='''+@ProductDesc+''''
END

SELECT @mysql = ' SELECT u.Ask as userAsk,u.[User ID],u.[User Description],u.[User Email],u.[User Phone],u.[User Remark],
mg.Ask as menugroupAsk,mg.[Menu Group Name],mg.[Menu Group Description],
cg.Ask as controlgroupAsk,cg.[Control Group Name],cg.[Control Group Description],
p.Ask as productAsk,p.[Product Name],p.[Product Detail]
FROM SYS_USER u 
LEFT JOIN SYS_MENUGROUP_USER_JUN muj
ON u.Ask = muj.[User]
LEFT JOIN SYS_MENUGROUP mg
ON muj.[Menu Group]=mg.Ask
LEFT JOIN SYS_CONTROLGROUP_USER_JUN cuj
ON u.Ask = cuj.[User]
LEFT JOIN SYS_CONTROLGROUP cg
ON cuj.[Control Group]=cg.Ask
LEFT JOIN SYS_PRODUCT_USER_JUN puj
ON u.Ask = puj.[User]
LEFT JOIN SYS_PRODUCT p
ON puj.PRODUCT = p.Ask  ' + @WhereClause 

EXEC ( @mysql )


END
END

GO


