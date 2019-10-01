USE [AF_Heirarchy]
GO

/****** Object:  Table [dbo].[Wings]    Script Date: 8/5/2019 12:02:06 AM ******/
DROP TABLE [dbo].[Wings]
GO

/****** Object:  Table [dbo].[Wings]    Script Date: 8/5/2019 12:02:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Wings](
	[WingName] [nchar](20) NOT NULL,
	[Location] [nchar](20) NULL,
	[Majcom] [nchar](20) NULL,
	[Mission] [nchar](100) NULL,
	[Commander] [nchar](20) NULL,
 CONSTRAINT [PK_Wings] PRIMARY KEY CLUSTERED 
(
	[WingName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

