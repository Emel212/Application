USE [master]
GO
/****** Object:  Database [BtyonDB]    Script Date: 3/2/2023 7:17:51 PM ******/
CREATE DATABASE [BtyonDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BtyonDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BtyonDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BtyonDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BtyonDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BtyonDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BtyonDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BtyonDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BtyonDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BtyonDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BtyonDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BtyonDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BtyonDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BtyonDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BtyonDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BtyonDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BtyonDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BtyonDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BtyonDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BtyonDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BtyonDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BtyonDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BtyonDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BtyonDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BtyonDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BtyonDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BtyonDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BtyonDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BtyonDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BtyonDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BtyonDB] SET  MULTI_USER 
GO
ALTER DATABASE [BtyonDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BtyonDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BtyonDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BtyonDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BtyonDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BtyonDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BtyonDB] SET QUERY_STORE = OFF
GO
USE [BtyonDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Columns]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Columns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Order] [int] NULL,
	[IsVisible] [bit] NULL,
 CONSTRAINT [PK_Columns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Records]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Records](
	[Id] [int] NOT NULL,
	[CreateTime] [datetime] NULL,
	[ModifyTime] [datetime] NULL,
 CONSTRAINT [PK_Records] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemLogs]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ColumnId] [int] NULL,
	[ValueId] [int] NULL,
	[RecordId] [nvarchar](50) NULL,
	[Added] [bit] NULL,
	[Deleted] [bit] NULL,
	[Updated] [bit] NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_SystemLogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Values]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Values](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordId] [nvarchar](150) NULL,
	[ColumnId] [int] NULL,
	[Value] [nvarchar](50) NULL,
 CONSTRAINT [PK_Values] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Columns] ON 

INSERT [dbo].[Columns] ([Id], [Name], [Order], [IsVisible]) VALUES (1, N'Surname', 2, 1)
INSERT [dbo].[Columns] ([Id], [Name], [Order], [IsVisible]) VALUES (4, N'Name', 1, 1)
INSERT [dbo].[Columns] ([Id], [Name], [Order], [IsVisible]) VALUES (5, N'Adress', 4, 1)
INSERT [dbo].[Columns] ([Id], [Name], [Order], [IsVisible]) VALUES (6, N'Age', 3, 1)
INSERT [dbo].[Columns] ([Id], [Name], [Order], [IsVisible]) VALUES (14, N'Phone', 5, 1)
INSERT [dbo].[Columns] ([Id], [Name], [Order], [IsVisible]) VALUES (15, N'Email', 6, 1)
SET IDENTITY_INSERT [dbo].[Columns] OFF
GO
INSERT [dbo].[Records] ([Id], [CreateTime], [ModifyTime]) VALUES (1, CAST(N'2022-12-12T00:00:00.000' AS DateTime), CAST(N'2022-12-12T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[SystemLogs] ON 

INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (204, NULL, 5, N'1', NULL, NULL, 1, N'Record updated:ID:7')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (205, NULL, 5, N'2', NULL, NULL, 1, N'Record updated:ID:13')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (207, 1, NULL, N'1', NULL, NULL, 1, N'Columns Moved: Name(Down)-Surname(Up)')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (209, 1, NULL, N'1', NULL, NULL, 1, N'Columns Moved: Name(Up)-Surname(Down)')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (210, NULL, NULL, N'1', 1, NULL, NULL, N'Column Added=Phone Number')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (211, NULL, NULL, NULL, NULL, 1, NULL, N'Column Deleted=Phone Number')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (214, NULL, NULL, N'1', 1, NULL, NULL, N'Column Added=Phone Number')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (215, NULL, 6, N'06519b18-576e-48c5-aded-c583b9b45cb0', 1, NULL, NULL, N'Record added:ID:255')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (216, NULL, 6, N'44bb8a24-585a-4515-bcfa-ad4c06bf230b', 1, NULL, NULL, N'Record added:ID:258')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (217, NULL, 6, N'5b711015-ee27-465a-9ea7-3b8fbf28a1a8', 1, NULL, NULL, N'Record added:ID:259')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (218, NULL, 6, N'6c3c27fc-4bfb-4d51-bf55-5fee122692d5', 1, NULL, NULL, N'Record added:ID:260')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (220, 4, NULL, N'1', NULL, NULL, 1, N'Columns Moved: Surname(Up)-Name(Down)')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (222, 4, NULL, N'1', NULL, NULL, 1, N'Columns Moved: Surname(Down)-Name(Up)')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (224, NULL, NULL, NULL, NULL, 1, NULL, N'Column Deleted=Phone Number')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (225, NULL, NULL, N'1', 1, NULL, NULL, N'Column Added=Phone Number')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (226, NULL, NULL, NULL, NULL, 1, NULL, N'Column Deleted=Phone Number')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (227, NULL, NULL, N'1', 1, NULL, NULL, N'Column Added=Phone Number')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (228, NULL, NULL, NULL, NULL, 1, NULL, N'Column Deleted=Phone Number')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (229, NULL, NULL, N'1', 1, NULL, NULL, N'Column Added=Phone')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (230, NULL, NULL, NULL, NULL, 1, NULL, N'Column Deleted=Phone')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (231, 14, NULL, N'1', 1, NULL, NULL, N'Column Added=Phone')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (232, 15, NULL, N'1', 1, NULL, NULL, N'Column Added=Email')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (233, NULL, NULL, N'1', 1, NULL, NULL, N'Column Added=ADRESS2')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (234, NULL, NULL, NULL, NULL, 1, NULL, N'Column Deleted=ADRESS2')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (236, 5, NULL, N'1', NULL, NULL, 1, N'Columns Moved: Age(Up)-Adress(Down)')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (237, 4, NULL, N'1', NULL, NULL, 1, N'Column Hide : Name')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (238, NULL, 5, N'ef81f914-eee9-46ca-a1b3-397f94e41fa2', 1, NULL, NULL, N'Record added:ID:297')
INSERT [dbo].[SystemLogs] ([Id], [ColumnId], [ValueId], [RecordId], [Added], [Deleted], [Updated], [Description]) VALUES (239, NULL, 5, N'df8bc7c2-b353-4fbd-ade0-81e01b456a83', 1, NULL, NULL, N'Record added:ID:305')
SET IDENTITY_INSERT [dbo].[SystemLogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Values] ON 

INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (37, N'44bb8a24-585a-4515-bcfa-ad4c06bf230b', 4, N'Mehmet')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (38, N'44bb8a24-585a-4515-bcfa-ad4c06bf230b', 1, N'Güreli')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (39, N'44bb8a24-585a-4515-bcfa-ad4c06bf230b', 5, N'456sk')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (40, N'44bb8a24-585a-4515-bcfa-ad4c06bf230b', 6, N'78')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (131, N'06519b18-576e-48c5-aded-c583b9b45cb0', 4, N'Ayten')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (132, N'06519b18-576e-48c5-aded-c583b9b45cb0', 1, N'Özkan')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (133, N'06519b18-576e-48c5-aded-c583b9b45cb0', 5, N'd123')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (134, N'06519b18-576e-48c5-aded-c583b9b45cb0', 6, N'12')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (139, N'5b711015-ee27-465a-9ea7-3b8fbf28a1a8', 4, N'hayrettin')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (140, N'5b711015-ee27-465a-9ea7-3b8fbf28a1a8', 1, N'nebati')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (141, N'5b711015-ee27-465a-9ea7-3b8fbf28a1a8', 5, N'6545dsd')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (142, N'5b711015-ee27-465a-9ea7-3b8fbf28a1a8', 6, N'78')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (230, N'6c3c27fc-4bfb-4d51-bf55-5fee122692d5', 4, N'john')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (231, N'6c3c27fc-4bfb-4d51-bf55-5fee122692d5', 1, N'McTwoKnives')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (232, N'6c3c27fc-4bfb-4d51-bf55-5fee122692d5', 5, N'45as')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (233, N'6c3c27fc-4bfb-4d51-bf55-5fee122692d5', 6, N'19')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (276, N'44bb8a24-585a-4515-bcfa-ad4c06bf230b', 14, N'56454564')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (277, N'06519b18-576e-48c5-aded-c583b9b45cb0', 14, NULL)
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (278, N'5b711015-ee27-465a-9ea7-3b8fbf28a1a8', 14, N'654546587')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (279, N'6c3c27fc-4bfb-4d51-bf55-5fee122692d5', 14, NULL)
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (282, N'44bb8a24-585a-4515-bcfa-ad4c06bf230b', 15, NULL)
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (283, N'06519b18-576e-48c5-aded-c583b9b45cb0', 15, N'ayten@gmail.com')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (284, N'5b711015-ee27-465a-9ea7-3b8fbf28a1a8', 15, NULL)
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (285, N'6c3c27fc-4bfb-4d51-bf55-5fee122692d5', 15, NULL)
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (300, N'df8bc7c2-b353-4fbd-ade0-81e01b456a83', 4, N'emel')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (301, N'df8bc7c2-b353-4fbd-ade0-81e01b456a83', 1, N'filali')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (302, N'df8bc7c2-b353-4fbd-ade0-81e01b456a83', 6, N'27')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (303, N'df8bc7c2-b353-4fbd-ade0-81e01b456a83', 5, N'qwer')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (304, N'df8bc7c2-b353-4fbd-ade0-81e01b456a83', 14, N'123')
INSERT [dbo].[Values] ([Id], [RecordId], [ColumnId], [Value]) VALUES (305, N'df8bc7c2-b353-4fbd-ade0-81e01b456a83', 15, N'sdndn@gmail.com')
SET IDENTITY_INSERT [dbo].[Values] OFF
GO
ALTER TABLE [dbo].[Columns] ADD  CONSTRAINT [DF_Columns_IsVisible]  DEFAULT ((1)) FOR [IsVisible]
GO
ALTER TABLE [dbo].[SystemLogs]  WITH CHECK ADD  CONSTRAINT [FK_SystemLogs_Columns] FOREIGN KEY([ColumnId])
REFERENCES [dbo].[Columns] ([Id])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SystemLogs] CHECK CONSTRAINT [FK_SystemLogs_Columns]
GO
ALTER TABLE [dbo].[Values]  WITH CHECK ADD  CONSTRAINT [FK_Values_Columns] FOREIGN KEY([ColumnId])
REFERENCES [dbo].[Columns] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Values] CHECK CONSTRAINT [FK_Values_Columns]
GO
/****** Object:  StoredProcedure [dbo].[prc_HideColumn]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[prc_HideColumn]
@ColName nvarchar(50)
as
if(not exists(select ColName from HiddenCols where ColName=@ColName))
begin
insert into HiddenCols(ColName) values(@ColName)
end
else if(exists(select ColName from HiddenCols where ColName=@ColName))
begin
if((select isHidden from HiddenCols where ColName=@ColName)=1)
begin
update HiddenCols set isHidden=0 where ColName=@ColName
end
else if((select isHidden from HiddenCols where ColName=@ColName)=0)
begin
update HiddenCols set isHidden=1 where ColName=@ColName
end
end
GO
/****** Object:  Trigger [dbo].[InsertNullForNewColumn]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[InsertNullForNewColumn] ON [dbo].[Columns]
 AFTER INSERT
AS
IF(not exists(select ColumnId from [Values] where ColumnId=Id))
BEGIN

DECLARE @colId int
SET @colId=(select Id from inserted)
DECLARE @PractitionerId nvarchar(max)

DECLARE MY_CURSOR CURSOR 
  LOCAL STATIC READ_ONLY FORWARD_ONLY
FOR 
SELECT RecordId
FROM (
    SELECT RecordId, MIN(Id) AS MinColumnId
    FROM [Values]
    GROUP BY RecordId
) AS DistinctRecords
ORDER BY MinColumnId ASC
OPEN MY_CURSOR
FETCH NEXT FROM MY_CURSOR INTO @PractitionerId
WHILE @@FETCH_STATUS = 0
BEGIN 
    insert into [Values](ColumnId,RecordId,[Value]) Values(@colId,@PractitionerId,NULL)
    PRINT @PractitionerId
    FETCH NEXT FROM MY_CURSOR INTO @PractitionerId
END
CLOSE MY_CURSOR
DEALLOCATE MY_CURSOR
end



GO
ALTER TABLE [dbo].[Columns] ENABLE TRIGGER [InsertNullForNewColumn]
GO
/****** Object:  Trigger [dbo].[Logger]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[Logger] on [dbo].[Columns]
for insert
as
declare @ColumnID as int
declare @recordID as int
declare @colName as nvarchar(50)
set @ColumnID=(select top 1(Id) from [Columns] order by Id desc)
set @recordID=(select top 1(Id) from Records order by Id desc)
set @colName=(select Name from [Columns] where Id=@ColumnID)
insert into SystemLogs(ColumnId,Added,RecordId,Description) values(@ColumnID,1,@recordID,'Column Added='+@colName)
GO
ALTER TABLE [dbo].[Columns] ENABLE TRIGGER [Logger]
GO
/****** Object:  Trigger [dbo].[trg_Delete]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_Delete] on [dbo].[Columns]
for delete
as
declare @columnName as nvarchar(50)
select @columnName=deleted.Name from deleted
insert into SystemLogs(Deleted,Description) values(1,'Column Deleted='+@columnName)
GO
ALTER TABLE [dbo].[Columns] ENABLE TRIGGER [trg_Delete]
GO
/****** Object:  Trigger [dbo].[trg_Update]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_Update] on [dbo].[Columns]
for update
as
declare @ColumnId as int
declare @oldName as nvarchar(50)
declare @newName as nvarchar(50)
declare @oldOrder as int 
declare @neworder as int 
declare @secondColumn as nvarchar(50)
declare @isVisible as bit
declare @isVisibleChanged as bit
declare @recordId as int 

set @oldName=(select Name from deleted)
set @newName=(select Name from inserted)
set @ColumnId=(select Id from inserted)
set @neworder=(select [Order] from inserted)
set @oldOrder=(select [Order] from deleted)
set @secondColumn=(select Name from [Columns] where [Order] =@oldOrder)
set @isVisible =(select IsVisible from inserted)
set @isVisibleChanged=(select IsVisible from deleted)
set @recordId=(select top 1(Id) from Records order by Id desc)

if(@newName!=@oldName and @isVisible!=0)
begin
insert [SystemLogs](ColumnId,Updated,RecordId,Description) values(@ColumnId,1,@recordId,'Column name changed: '+@oldName+'-'+@newName)
end
else
if(@neworder!=@oldOrder and @isVisible!=0)
begin
if(@neworder>@oldOrder)  /*Down*/
begin
insert into [SystemLogs](ColumnId,Updated,RecordId,Description) values(@ColumnId,1,@recordId,'Columns Moved: '+@secondColumn+'(Up)-'+@newName+'(Down)')
end else if(@neworder<@oldOrder) 
begin
insert into [SystemLogs](ColumnId,Updated,RecordId,Description) values(@ColumnId,1,@recordId,'Columns Moved: '+@secondColumn+'(Down)-'+@newName+'(Up)')
end
delete from SystemLogs where Description is null
end else
if(@isVisible!=@isVisibleChanged and @isVisible=0)
begin
insert into  [SystemLogs](ColumnId,Updated,RecordId,Description) values(@ColumnId,1,@recordId,'Column Hide : '+@newName)
end
GO
ALTER TABLE [dbo].[Columns] ENABLE TRIGGER [trg_Update]
GO
/****** Object:  Trigger [dbo].[valueLogger]    Script Date: 3/2/2023 7:17:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[valueLogger] on [dbo].[Values]
for insert,Update
as 

declare @ID as nvarchar(max)
declare @value as nvarchar(50)
declare @oldvalue as nvarchar(50)
declare @recordID as nvarchar(50)
declare @valID as int
declare @Id_for_updated_record as nvarchar(max)

set @valID=(select Id from inserted)
set @value=(select [Value] from deleted)
set @oldvalue=(select [Value] from inserted)
set @recordID=(select RecordId from inserted)
set @ID=(SELECT COUNT (DISTINCT RecordId)FROM [Values])
set @Id_for_updated_record=@valID+5

if(@value!=@oldvalue)
begin
if (not exists(select*from SystemLogs where RecordId=@recordID))
begin
insert into SystemLogs(Updated,RecordId,ValueId,Description) values(1,@recordID,@Id,'Record updated:ID:'+@Id_for_updated_record+'')
end
end/**/
else
begin
if (not exists(select*from SystemLogs where RecordId=@recordID))
begin
insert into SystemLogs(Added,RecordId,ValueId,Description) values(1,@recordID,@Id,'Record added:ID:'+@Id_for_updated_record+'')
end
end 
GO
ALTER TABLE [dbo].[Values] ENABLE TRIGGER [valueLogger]
GO
USE [master]
GO
ALTER DATABASE [BtyonDB] SET  READ_WRITE 
GO
