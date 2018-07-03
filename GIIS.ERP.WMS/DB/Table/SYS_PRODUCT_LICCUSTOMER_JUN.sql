USE [CS_WMS]
GO

/****** Object:  Table [dbo].[SYS_PRODUCT_LICCUSTOMER_JUN]    Script Date: 7/3/2018 2:39:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SYS_PRODUCT_LICCUSTOMER_JUN](
	[Ask] [bigint] NOT NULL,
	[TS] [smallint] NOT NULL,
	[UD] [bigint] NOT NULL,
	[PRODUCT] [bigint] NOT NULL,
	[LICENSECUSTOMER] [bigint] NOT NULL,
	[User Remark] [nvarchar](255) NOT NULL,
	[Display Sequence] [int] NOT NULL
) ON [PRIMARY]

GO


