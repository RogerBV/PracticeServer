USE [PracticeDb]
GO
/****** Object:  Table [dbo].[Permit]    Script Date: 2/06/2021 20:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](150) NULL,
	[EmployeeSurname] [varchar](150) NOT NULL,
	[PermitTypeId] [int] NOT NULL,
	[PermitDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermitType]    Script Date: 2/06/2021 20:30:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermitType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Permit] ON 

INSERT [dbo].[Permit] ([Id], [EmployeeName], [EmployeeSurname], [PermitTypeId], [PermitDate]) VALUES (6, N'Roger', N'Barriga', 2, CAST(N'2021-06-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Permit] ([Id], [EmployeeName], [EmployeeSurname], [PermitTypeId], [PermitDate]) VALUES (7, N'Gabriela ', N'Calderon', 2, CAST(N'2021-06-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Permit] ([Id], [EmployeeName], [EmployeeSurname], [PermitTypeId], [PermitDate]) VALUES (8, N'Roger Manuel', N'Barriga Amaya', 1, CAST(N'2021-06-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Permit] ([Id], [EmployeeName], [EmployeeSurname], [PermitTypeId], [PermitDate]) VALUES (1003, N'Cecilia ', N'Villacorta', 2, CAST(N'2021-06-09T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Permit] OFF
GO
SET IDENTITY_INSERT [dbo].[PermitType] ON 

INSERT [dbo].[PermitType] ([Id], [Description]) VALUES (1, N'Enfermedad')
INSERT [dbo].[PermitType] ([Id], [Description]) VALUES (2, N'Diligencias')
SET IDENTITY_INSERT [dbo].[PermitType] OFF
GO
ALTER TABLE [dbo].[Permit]  WITH CHECK ADD  CONSTRAINT [FK_Permit_PermitType] FOREIGN KEY([PermitTypeId])
REFERENCES [dbo].[PermitType] ([Id])
GO
ALTER TABLE [dbo].[Permit] CHECK CONSTRAINT [FK_Permit_PermitType]
GO
