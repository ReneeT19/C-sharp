USE [master]
GO
CREATE DATABASE EMPCOGNIXIA
Go
CREATE TABLE [dbo].[DeptInfo](
	[DepCode] [int] NOT NULL,
	[DeptName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DeptInfo] PRIMARY KEY CLUSTERED 
(
	[DepCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpProfile]    Script Date: 07/26/2021 17:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpProfile](
	[EmpCode] [int] NOT NULL,
	[EmpName] [varchar](50) NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[DeptCode] [int] NOT NULL,
 CONSTRAINT [PK_EmpProfile] PRIMARY KEY CLUSTERED 
(
	[EmpCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_EmpProfile_DeptInfo]    Script Date: 07/26/2021 17:04:26 ******/
ALTER TABLE [dbo].[EmpProfile]  WITH CHECK ADD  CONSTRAINT [FK_EmpProfile_DeptInfo] FOREIGN KEY([DeptCode])
REFERENCES [dbo].[DeptInfo] ([DepCode])
GO
ALTER TABLE [dbo].[EmpProfile] CHECK CONSTRAINT [FK_EmpProfile_DeptInfo]
GO
