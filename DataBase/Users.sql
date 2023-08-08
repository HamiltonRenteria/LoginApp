USE [TestDB]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 8/08/2023 4:27:36 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](max) NULL,
	[Email] [varchar](max) NULL,
	[Image] [varchar](max) NULL,
	[State] [int] NULL,
	[AuditCreateUser] [int] NOT NULL,
	[AuditCreateDate] [datetime2](7) NOT NULL,
	[AuditUpdateUser] [int] NULL,
	[AuditUpdateDate] [datetime2](7) NULL,
	[AuditDeleteUser] [int] NULL,
	[AuditDeleteDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


