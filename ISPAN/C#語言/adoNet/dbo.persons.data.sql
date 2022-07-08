SET IDENTITY_INSERT [dbo].[persons] ON
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (1, N'陳大貓', N'09123456789', N'高雄市前金區中正路', N'mm@gmail.com', N'1985-05-05', 0, 1000)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (2, N'高小貓', N'09789456123', N'高雄市前鎮區', N'GG@gmail.com', N'1988-03-03', 1, 800)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (3, N'張大書', N'09775559999', N'高雄市三民區民族路', N'ZZ@gmail.com', N'1978-11-09', 1, 2000)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (4, N'林阿傑', N'09991111166', N'台南市中區中華路', N'LL@gmail.com', N'1979-01-05', 0, 1500)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (5, N'王曉明', N'09551118888', N'台中市西屯區', N'www@gmail.com', N'1992-08-20', 1, 300)
SET IDENTITY_INSERT [dbo].[persons] OFF
