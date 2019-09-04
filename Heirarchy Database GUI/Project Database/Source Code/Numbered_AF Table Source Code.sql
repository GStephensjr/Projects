USE [AF_Heirarchy]
GO

/****** Object:  Table [dbo].[Numbered_AFs]    Script Date: 8/5/2019 12:00:43 AM ******/
DROP TABLE [dbo].[Numbered_AFs]
GO

/****** Object:  Table [dbo].[Numbered_AFs]    Script Date: 8/5/2019 12:00:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Numbered_AFs](
	[Number] [nchar](20) NOT NULL,
	[Location] [nchar](20) NULL,
	[Commander] [nchar](20) NULL,
	[Majcom] [nchar](20) NULL,
	[Mission] [nchar](100) NULL,
 CONSTRAINT [PK_Numbered_AFs] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

