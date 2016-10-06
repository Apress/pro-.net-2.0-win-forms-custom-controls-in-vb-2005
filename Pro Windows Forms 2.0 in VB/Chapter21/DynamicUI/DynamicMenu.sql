CREATE DATABASE [DynamicMenu]
GO
use [DynamicMenu]
GO

-- Table structure for table 'Controls'
CREATE TABLE [Controls] (
[ID] int IDENTITY NOT NULL,
[ControlName] varchar(20) NOT NULL)
GO

CREATE UNIQUE CLUSTERED INDEX PK_Controls ON [Controls] (ID)
GO


-- Dumping data for table 'Controls'
--

-- Enable identity insert
SET IDENTITY_INSERT [Controls] ON
GO

INSERT INTO [Controls] ([ID], [ControlName])
VALUES(1, 'mnuNew')
GO
INSERT INTO [Controls] ([ID], [ControlName])
VALUES(2, 'mnuSave')
GO
INSERT INTO [Controls] ([ID], [ControlName])
VALUES(3, 'mnuManageHardware')
GO
INSERT INTO [Controls] ([ID], [ControlName])
VALUES(4, 'mnuSetUpUserAccounts')
GO

-- Disable identity insert
SET IDENTITY_INSERT [Controls] OFF
GO



-- Table structure for table 'Controls_Levels'
CREATE TABLE [Controls_Levels] (
[ID] int IDENTITY NOT NULL,
[Control_ID] int NOT NULL,
[Level_ID] int NOT NULL,
[State] smallint)
GO

CREATE UNIQUE CLUSTERED INDEX PK_Control_Levels ON [Controls_Levels] (ID)
GO


-- Dumping data for table 'Controls_Levels'
--

-- Enable identity insert
SET IDENTITY_INSERT [Controls_Levels] ON
GO

INSERT INTO [Controls_Levels] ([ID], [Control_ID], [Level_ID], [State])
VALUES(1, 1, 2, 1)
GO
INSERT INTO [Controls_Levels] ([ID], [Control_ID], [Level_ID], [State])
VALUES(2, 2, 2, 1)
GO
INSERT INTO [Controls_Levels] ([ID], [Control_ID], [Level_ID], [State])
VALUES(3, 3, 2, 2)
GO
INSERT INTO [Controls_Levels] ([ID], [Control_ID], [Level_ID], [State])
VALUES(4, 4, 2, 2)
GO

-- Disable identity insert
SET IDENTITY_INSERT [Controls_Levels] OFF
GO



-- Table structure for table 'Levels'
CREATE TABLE [Levels] (
[ID] int IDENTITY NOT NULL,
[LevelName] varchar(50))
GO

CREATE UNIQUE CLUSTERED INDEX PK_UserLevels ON [Levels] (ID)
GO


-- Dumping data for table 'Levels'
--

-- Enable identity insert
SET IDENTITY_INSERT [Levels] ON
GO

INSERT INTO [Levels] ([ID], [LevelName])
VALUES(1, 'Admin')
GO
INSERT INTO [Levels] ([ID], [LevelName])
VALUES(2, 'User')
GO

-- Disable identity insert
SET IDENTITY_INSERT [Levels] OFF
GO


CREATE VIEW [Permissions]
AS
SELECT     Controls.ControlName, Levels.LevelName, Controls_Levels.State
FROM         Controls INNER JOIN
                      Controls_Levels ON Controls.ID = Controls_Levels.Control_ID INNER JOIN
                      Levels ON Controls_Levels.Level_ID = Levels.ID
GO
