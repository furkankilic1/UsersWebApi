USE [GoldtagDb]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 16.09.2021 20:15:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [GoldtagDb]
GO

INSERT INTO [dbo].[Users]
           ([Name]
           ,[Email]
           ,[Password])
     VALUES
           ('Jack Black'
           ,'jackblack@gmail.com'
           ,'pass1')

INSERT INTO [dbo].[Users]
           ([Name]
           ,[Email]
           ,[Password])
     VALUES
           ('Rocky Balboa'
           ,'rockybalboa@gmail.com'
           ,'1234')

INSERT INTO [dbo].[Users]
           ([Name]
           ,[Email]
           ,[Password])
     VALUES
           ('George Bush'
           ,'georgebush@gmail.com'
           ,'abcd')
GO
