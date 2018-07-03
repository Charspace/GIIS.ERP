USE [CS_WMS]
GO

/****** Object:  UserDefinedFunction [dbo].[GetProductAsk]    Script Date: 7/3/2018 2:37:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE FUNCTION [dbo].[GetProductAsk](@UserID NVARCHAR(255),@Passowrd NVARCHAR(255),@ProductAsk bigint)
                RETURNS BIGINT  
                WITH EXECUTE AS CALLER
                AS
                BEGIN
					DECLARE @UserAsk bigint =0
					DECLARE @ProdAsk bigint =0
					--SELECT @UserAsk
					SET @UserAsk = (SELECT ask FROM [dbo].[SYS_USER] WHERE [User ID] =  @UserID --'thura'-- 'eiphyuD'--
					AND [User Password] =@Passowrd )---'wj4IdPsXzjygAFKHFdRpuw==')
					--SELECT @UserAsk
						IF (@UserAsk IS NOT NULL)
						BEGIN
							IF ((SELECT COUNT(SYS_PRODUCT.Ask) 	FROM SYS_PRODUCT 
							INNER JOIN [SYS_PRODUCT_USER_JUN] ON [SYS_PRODUCT_USER_JUN].[PRODUCT] = [dbo].[SYS_PRODUCT].Ask
							WHERE [SYS_PRODUCT_USER_JUN].[USER] = @UserAsk AND [SYS_PRODUCT_USER_JUN].[PRODUCT]=@ProductAsk) = 0)
								BEGIN
									SET @ProdAsk = 0;
								END
							ELSE
								BEGIN
									SET @ProdAsk = (SELECT SYS_PRODUCT.Ask 	FROM SYS_PRODUCT 
							INNER JOIN [SYS_PRODUCT_USER_JUN] ON [SYS_PRODUCT_USER_JUN].[PRODUCT] = [dbo].[SYS_PRODUCT].Ask
							WHERE [SYS_PRODUCT_USER_JUN].[USER] = @UserAsk AND [SYS_PRODUCT_USER_JUN].[PRODUCT]=@ProductAsk)			
									RETURN @ProdAsk
								END
						END
						ELSE 
							BEGIN
							SET @ProdAsk = 0;
							END  
							
							RETURN     @ProdAsk           
                END;

GO


