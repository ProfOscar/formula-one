ALTER TABLE [dbo].[Driver]  WITH CHECK ADD  CONSTRAINT [FK_Driver_Country] FOREIGN KEY([countryCode])
REFERENCES [dbo].[Country] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Circuit]  WITH CHECK ADD  CONSTRAINT [FK_Circuit_Country] FOREIGN KEY([circuitNation])
REFERENCES [dbo].[Country] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Team]  WITH CHECK ADD  CONSTRAINT [FK_Team_Country] FOREIGN KEY([nationCode])
REFERENCES [dbo].[Country] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Driver]  WITH CHECK ADD  CONSTRAINT [FK_Driver_Team] FOREIGN KEY([teamCode])
REFERENCES [dbo].[Team] ([teamCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[GPResult]  WITH CHECK ADD  CONSTRAINT [FK_GPResult_Team] FOREIGN KEY([teamCode])
REFERENCES [dbo].[Team] ([teamCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[GPResult]  WITH CHECK ADD  CONSTRAINT [FK_GPResult_Driver] FOREIGN KEY([driverNumber])
REFERENCES [dbo].[Driver] ([driverNumber])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[GPResult]  WITH CHECK ADD  CONSTRAINT [FK_GPResult_Point] FOREIGN KEY([place])
REFERENCES [dbo].[Point] ([place])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[GPResult]  WITH CHECK ADD  CONSTRAINT [FK_GPResult_GP] FOREIGN KEY([gpID])
REFERENCES [dbo].[GP] ([gpID])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[GP]  WITH CHECK ADD  CONSTRAINT [FK_GP_Circuit] FOREIGN KEY([circuitID])
REFERENCES [dbo].[Circuit] ([circuitID])
ON UPDATE CASCADE;