USE [CS_WMS]
GO

/****** Object:  Table [dbo].[SYS_MENU]    Script Date: 7/3/2018 2:39:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SYS_MENU](
	[Ask] [bigint] NOT NULL,
	[TS] [smallint] NOT NULL,
	[UD] [bigint] NOT NULL,
	[Menu Name] [nvarchar](255) NOT NULL,
	[Menu Url] [nvarchar](255) NOT NULL,
	[Menu Pannel] [nvarchar](255) NOT NULL,
	[Menu Tab] [nvarchar](255) NOT NULL,
	[Menu Class] [nvarchar](255) NOT NULL,
	[Display Sequence] [int] NOT NULL,
	[Menu List] [nvarchar](255) NOT NULL,
	[Menu Status] [bigint] NOT NULL,
	[Remark] [nvarchar](255) NOT NULL DEFAULT (''),
	[ParentID] [int] NOT NULL,
	[Menu Type] [bigint] NOT NULL,
	[SubMenuWidth] [nvarchar](255) NOT NULL DEFAULT (''),
	[ProductAsk] [bigint] NOT NULL DEFAULT ((0))
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SYS_MENU]  WITH CHECK ADD  CONSTRAINT [FK_SYS_MENU_SYS_MENU_STAUS] FOREIGN KEY([Menu Status])
REFERENCES [dbo].[SYS_MENU_STAUS] ([Ask])
GO

ALTER TABLE [dbo].[SYS_MENU] CHECK CONSTRAINT [FK_SYS_MENU_SYS_MENU_STAUS]
GO


