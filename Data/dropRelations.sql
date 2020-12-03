ALTER TABLE [dbo].[Driver] DROP CONSTRAINT [FK_Driver_Country];

ALTER TABLE [dbo].[Circuit] DROP CONSTRAINT [FK_Circuit_Country];

ALTER TABLE [dbo].[Team] DROP CONSTRAINT [FK_Team_Country];

ALTER TABLE [dbo].[Driver] DROP CONSTRAINT [FK_Driver_Team];

ALTER TABLE [dbo].[GPResult] DROP CONSTRAINT [FK_GPResult_Team];

ALTER TABLE [dbo].[GPResult] DROP CONSTRAINT [FK_GPResult_Driver];

ALTER TABLE [dbo].[GPResult] DROP CONSTRAINT [FK_GPResult_Point];

ALTER TABLE [dbo].[GPResult] DROP CONSTRAINT [FK_GPResult_GP];

ALTER TABLE [dbo].[GP] DROP CONSTRAINT [FK_GP_Circuit];