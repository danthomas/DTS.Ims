CREATE TABLE [security].[RoleFeature]
(
  [RoleId] SMALLINT NOT NULL
, [FeatureId] SMALLINT NOT NULL
, CONSTRAINT PK_RoleFeature PRIMARY KEY CLUSTERED ( [RoleId], [FeatureId] )
, CONSTRAINT FK_RoleFeature_RoleId FOREIGN KEY ( RoleId ) REFERENCES dbo.webpages_Roles ( RoleId )
, CONSTRAINT FK_RoleFeature_FeatureId FOREIGN KEY ( FeatureId ) REFERENCES security.Feature ( FeatureId )
)