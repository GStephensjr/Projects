USE [AF_Heirarchy]
GO

/****** Object:  Table [dbo].[Squadrons]    Script Date: 8/5/2019 12:01:55 AM ******/
DROP TABLE [dbo].[Squadrons]
GO

/****** Object:  Table [dbo].[Squadrons]    Script Date: 8/5/2019 12:01:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Squadrons](
	[SquadronName] [nchar](10) NOT NULL,
	[Location] [nchar](20) NULL,
	[Majcom] [nchar](20) NULL,
	[Wing] [nchar](20) NULL,
	[Group] [nchar](20) NULL,
	[Commander] [nchar](20) NULL,
 CONSTRAINT [PK_Squadrons] PRIMARY KEY CLUSTERED 
(
	[SquadronName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

