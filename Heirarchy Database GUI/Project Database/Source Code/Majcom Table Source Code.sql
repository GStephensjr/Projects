USE [AF_Heirarchy]
GO

/****** Object:  Table [dbo].[Majcom]    Script Date: 8/5/2019 12:00:19 AM ******/
DROP TABLE [dbo].[Majcom]
GO

/****** Object:  Table [dbo].[Majcom]    Script Date: 8/5/2019 12:00:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Majcom](
	[MajName] [nchar](20) NOT NULL,
	[Location] [nchar](20) NULL,
	[Commander] [nchar](20) NULL,
	[Mission] [nchar](100) NULL,
 CONSTRAINT [PK_Majcom] PRIMARY KEY CLUSTERED 
(
	[MajName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

