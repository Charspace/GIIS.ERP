USE [CS_WMS]
GO

/****** Object:  Table [dbo].[SYS_PRODUCT_USER_JUN]    Script Date: 7/3/2018 2:39:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SYS_PRODUCT_USER_JUN](
	[Ask] [bigint] NOT NULL DEFAULT ((0)),
	[TS] [smallint] NOT NULL DEFAULT ((0)),
	[UD] [bigint] NOT NULL DEFAULT ((0)),
	[PRODUCT] [bigint] NOT NULL DEFAULT ((0)),
	[USER] [bigint] NOT NULL DEFAULT ((0)),
	[User Remark] [nvarchar](255) NOT NULL DEFAULT (''),
	[Display Sequence] [int] NOT NULL DEFAULT ((0))
) ON [PRIMARY]

GO


