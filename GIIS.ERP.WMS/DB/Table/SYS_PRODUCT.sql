USE [CS_WMS]
GO

/****** Object:  Table [dbo].[SYS_PRODUCT]    Script Date: 7/3/2018 2:38:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SYS_PRODUCT](
	[Ask] [bigint] NOT NULL DEFAULT ((0)),
	[TS] [smallint] NOT NULL DEFAULT ((0)),
	[UD] [bigint] NOT NULL DEFAULT ((0)),
	[Product Name] [nvarchar](50) NOT NULL DEFAULT (''),
	[Product Detail] [nvarchar](255) NOT NULL DEFAULT (''),
	[User Remark] [nvarchar](255) NOT NULL DEFAULT (''),
	[Display Sequance] [int] NOT NULL DEFAULT ((0))
) ON [PRIMARY]

GO


