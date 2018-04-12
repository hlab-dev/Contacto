USE [master]
GO
/****** Object:  Database [Contacto]    Script Date: 2018/04/12 8:56:36 AM ******/
CREATE DATABASE [Contacto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Contacto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESSDEV\MSSQL\DATA\Contacto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Contacto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESSDEV\MSSQL\DATA\Contacto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Contacto] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Contacto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Contacto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Contacto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Contacto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Contacto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Contacto] SET ARITHABORT OFF 
GO
ALTER DATABASE [Contacto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Contacto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Contacto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Contacto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Contacto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Contacto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Contacto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Contacto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Contacto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Contacto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Contacto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Contacto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Contacto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Contacto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Contacto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Contacto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Contacto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Contacto] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Contacto] SET  MULTI_USER 
GO
ALTER DATABASE [Contacto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Contacto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Contacto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Contacto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Contacto] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Contacto] SET QUERY_STORE = OFF
GO
USE [Contacto]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Contacto]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](350) NOT NULL,
	[Latitude] [decimal](12, 9) NULL,
	[Longitude] [decimal](12, 9) NULL,
	[UserAccountId] [bigint] NOT NULL,
	[LastModifiedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerContact](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](350) NOT NULL,
	[Email] [nvarchar](350) NOT NULL,
	[Number] [nvarchar](20) NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CustomerContact] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccount](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Active] [smallint] NOT NULL,
	[RolePolicy] [nvarchar](50) NULL,
	[LastLoginDate] [datetime] NOT NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_LastModifiedDate]  DEFAULT (getdate()) FOR [LastModifiedDate]
GO
ALTER TABLE [dbo].[CustomerContact] ADD  CONSTRAINT [DF_CustomerContact_LastModifiedDate]  DEFAULT (getdate()) FOR [LastModifiedDate]
GO
ALTER TABLE [dbo].[UserAccount] ADD  CONSTRAINT [DF_UserAccount_LastLoginDate]  DEFAULT (getdate()) FOR [LastLoginDate]
GO
/****** Object:  StoredProcedure [dbo].[usp_AuthenticateUser]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[usp_AuthenticateUser] 
(
	@UserName nvarchar(50),
	@UserPassword nvarchar(50)
)
as
begin

	declare @UserFound int = (select count(*) from dbo.UserAccount where UserName = @UserName and [Password] = @UserPassword and Active = 1)

	if @UserFound > 0
	begin
		select ID 'UserAccID', [RolePolicy] from dbo.UserAccount where UserName = @UserName and [Password] = @UserPassword and Active = 1
	end
	

end
GO
/****** Object:  StoredProcedure [dbo].[usp_Customer_Add]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Customer_Add]
(
	@UserAccId bigint,
	@CustomerName nvarchar(350),
	@Latitude Decimal(12,9),
	@Longitude Decimal(12,9)
)
as
begin

	insert into [dbo].[Customer] 
		([Name], Latitude, Longitude, UserAccountId) 
	values
		(@CustomerName, @Latitude, @Longitude, @UserAccId)

end
GO
/****** Object:  StoredProcedure [dbo].[usp_Customer_Delete]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Customer_Delete]
(
	@UserAccId bigint,
	@CustomerId bigint	
)
as
begin

	declare @CustomerFound int = (select count(*) from [dbo].[Customer] where [UserAccountId] = @UserAccId and [ID] = @CustomerId)

	if @CustomerFound > 0
	begin

		delete from [dbo].[Customer]
		where [UserAccountId] = @UserAccId and [ID] = @CustomerId
	end

end
GO
/****** Object:  StoredProcedure [dbo].[usp_Customer_Delete_Contacts]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_Customer_Delete_Contacts]
(
	@UserAccId bigint,
	@CustomerId bigint	
)
as
begin

	declare @CustomerFound int = (select count(*) from [dbo].[Customer] where [UserAccountId] = @UserAccId and [ID] = @CustomerId)

	if @CustomerFound > 0
	begin

		delete from [dbo].[CustomerContact]
		where CustomerId = @CustomerId
	end

end
GO
/****** Object:  StoredProcedure [dbo].[usp_Customer_List]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_Customer_List]
(
	@UserAccId bigint
)
as
begin

	select  [ID], [Name] 'CustomerName', [Latitude] , [Longitude] from [dbo].[Customer] where [UserAccountId] = @UserAccId order by [LastModifiedDate] desc

end
GO
/****** Object:  StoredProcedure [dbo].[usp_Customer_Update]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Customer_Update]
(
	@UserAccId bigint,
	@CustomerId bigint,
	@CustomerName nvarchar(350),
	@Latitude Decimal(12,9),
	@Longitude Decimal(12,9)
)
as
begin

	declare @CustomerFound int = (select count(*) from [dbo].[Customer] where [UserAccountId] = @UserAccId and [ID] = @CustomerId)

	if @CustomerFound > 0
	begin

		update [dbo].[Customer] 
		set [Name] = @CustomerName,
		[Latitude] = @Latitude,
		[Longitude] = @Longitude,
		[LastModifiedDate] = GetDate()
		where [UserAccountId] = @UserAccId and [ID] = @CustomerId
	end

end
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerContact_Add]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_CustomerContact_Add]
(
	@CustomerId bigint,
	@ContactName nvarchar(350),
	@Email nvarchar(350),
	@Number nvarchar(20)
)
as
begin

	declare @CustomerFound int = (select count(*) from [dbo].[Customer] where [ID] = @CustomerId)

	if @CustomerFound > 0
	begin

		insert into [dbo].[CustomerContact] 
			([Name], Email, Number, CustomerId) 
		values
			(@ContactName, @Email, @Number, @CustomerId)

	end

end
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerContact_Delete]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_CustomerContact_Delete]
(	
	@CustomerId bigint,	
	@CustomerContactId bigint
)
as
begin

	declare @CustomerContactFound int = (select count(*) from [dbo].[CustomerContact] where  ID = @CustomerContactId and [CustomerId] = @CustomerId)

	if @CustomerContactFound > 0
	begin

		delete from [dbo].[CustomerContact]
		where ID = @CustomerContactId and [CustomerId] = @CustomerId
	end

end
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerContact_List]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_CustomerContact_List]
(
	@UserAccId bigint,
	@CustomerId bigint
)
as
begin

	select  CC.[ID], CC.[Name] 'ContactName', CC.[Email], CC.[Number] from [dbo].[CustomerContact] CC
	left join [dbo].[Customer] Cust with(nolock) on Cust.UserAccountId = @UserAccId and CC.ID = Cust.ID
	
	 where CC.CustomerId = @CustomerId order by CC.[LastModifiedDate] desc

end
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerContact_Update]    Script Date: 2018/04/12 8:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_CustomerContact_Update]
(
	@CustomerId bigint,
	@CustomerContactId bigint,
	@ContactName nvarchar(350),
	@Email nvarchar(350),
	@Number nvarchar(20)
)
as
begin

	declare @CustomerContactFound int = (select count(*) from [dbo].[CustomerContact] where  ID = @CustomerContactId and [CustomerId] = @CustomerId)

	if @CustomerContactFound > 0
	begin

		update [dbo].[CustomerContact] 
		set [Name] = @ContactName,
		Email = @Email,
		Number = @Number,
		[LastModifiedDate] = GetDate()
		where ID = @CustomerContactId and [CustomerId] = @CustomerId
	end

end
GO
USE [master]
GO
ALTER DATABASE [Contacto] SET  READ_WRITE 
GO

insert into dbo.UserAccount (UserName, [Password], Active) values ('Admin','Admin',1)
GO
