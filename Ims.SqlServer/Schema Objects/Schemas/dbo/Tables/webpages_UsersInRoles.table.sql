CREATE TABLE [dbo].[webpages_UsersInRoles]
(
  [UserId] INT NOT NULL
, [RoleId] SMALLINT NOT NULL
, CONSTRAINT PK_webpages_UsersInRoles PRIMARY KEY CLUSTERED ( [UserId], [RoleId] )
, CONSTRAINT FK_webpages_UsersInRoles_UserId FOREIGN KEY ( UserId ) REFERENCES dbo.UserProfile ( UserId )
, CONSTRAINT FK_webpages_UsersInRoles_RoleId FOREIGN KEY ( RoleId ) REFERENCES dbo.webpages_Roles ( RoleId )
)
GO
CREATE NONCLUSTERED INDEX IX_webpages_UsersInRoles_RoleId ON [dbo].[webpages_UsersInRoles]
(
	[RoleId] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]