CREATE TABLE [security].[Feature]
(
  [FeatureId] SMALLINT NOT NULL
, [FeatureCode] VARCHAR(20) NOT NULL
, [FeatureName] NVARCHAR(50) NOT NULL
, CONSTRAINT PK_Feature PRIMARY KEY CLUSTERED ( [FeatureId] )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Feature_FeatureName ON [security].[Feature]
(
	[FeatureName] ASC
)
INCLUDE ([FeatureCode])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Feature_FeatureCode ON [security].[Feature]
(
	[FeatureCode] ASC
)
INCLUDE ([FeatureName])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]