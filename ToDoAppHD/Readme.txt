================================================================================================
EXECUTE BELOW SCRIPT IN	SQL SERVER AND CHANGE CONNECTION-STRING INSIDE "appsettings.json" FILE.
================================================================================================

CREATE DATABASE [ToDoAPP]

GO
USE [ToDoAPP]
GO

CREATE TABLE [dbo].[ToDo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [NVARCHAR](MAX) NOT NULL,
	[Description] [NVARCHAR](MAX),
	[Date] [DATE] NOT NULL,
	[Priority] [NVARCHAR](MAX) NOT NULL,
	[Status] [BIT] NOT NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
	(
	[ID] ASC
	)
)
GO

CREATE PROCEDURE [dbo].[SP_Add_ToDo]    
    @Title NVARCHAR (MAX),
	@Description NVARCHAR (MAX),
	@Date DATE,
	@Priority NVARCHAR (MAX),
	@Status BIT
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [ToDo]    
                (Title,
				Description,
				Date,
				Priority,
				Status
             )    
        VALUES  ( @Title,
				@Description,
				@Date,
				@Priority,
				@Status      
             );   
		SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS ToDoID;    
    END;   
GO	
	
CREATE PROCEDURE [dbo].[SP_Update_ToDo] 
		@Id INT,   
		@Title NVARCHAR (MAX),
		@Description NVARCHAR (MAX),
		@Date DATE,
		@Priority NVARCHAR (MAX),
		@Status BIT
	AS    
		BEGIN    

		UPDATE [ToDo] SET Title = @Title, 
						Description = @Description,
						Date = @Date,
						Priority = @Priority,
						Status= @Status 
						WHERE ID = @Id 
	           
		END;    
