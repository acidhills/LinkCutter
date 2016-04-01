CREATE TABLE [link_cutter].[Link]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserId] INT NOT NULL,
	[Original] NVARCHAR(2083) NOT NULL,
	[Created] datetime default GETDATE() NOT NULL,
	[Visitors] int default 0 NOT NULL,
 	CONSTRAINT [fk_Link2User]  FOREIGN KEY(UserId) REFERENCES [link_cutter].[User](Id)
)
go
CREATE NONCLUSTERED  INDEX [ix_link_userid] on [link_cutter].[Link] (UserId)
