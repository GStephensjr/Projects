USE [AF_Heirarchy]
GO

/****** Object:  Table [dbo].[Groups]    Script Date: 8/5/2019 12:00:01 AM ******/
DROP TABLE [dbo].[Groups]
GO

/****** Object:  Table [dbo].[Groups]    Script Date: 8/5/2019 12:00:01 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Groups](
	[GroupName] [nchar](20) NOT NULL,
	[Location] [nchar](20) NULL,
	[Majcom] [nchar](20) NULL,
	[Wing] [nchar](20) NULL,
	[Mission] [nchar](100) NULL,
	[Commander] [nchar](20) NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[GroupName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

