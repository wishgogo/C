USE [Cake]
GO
/****** Object:  Table [dbo].[Cake]    Script Date: 2022/5/18 下午 03:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cake](
	[CakeId] [int] IDENTITY(1,1) NOT NULL,
	[ClassId] [int] NOT NULL,
	[CakeName] [nvarchar](50) NOT NULL,
	[CakeDetail] [nvarchar](900) NULL,
	[SizeDetail] [nvarchar](100) NULL,
	[CakeImage] [nvarchar](max) NOT NULL,
	[CakeState] [bit] NOT NULL,
	[CakePrice] [int] NOT NULL,
 CONSTRAINT [PK_Cake_1] PRIMARY KEY CLUSTERED 
(
	[CakeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 2022/5/18 下午 03:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[CakeId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[CarId] ASC,
	[MemberId] ASC,
	[CakeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 2022/5/18 下午 03:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[CakeClass] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Favorite]    Script Date: 2022/5/18 下午 03:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Favorite](
	[FavoriteId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[CakeId] [int] NOT NULL,
 CONSTRAINT [PK_Favorite] PRIMARY KEY CLUSTERED 
(
	[FavoriteId] ASC,
	[MemberId] ASC,
	[CakeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 2022/5/18 下午 03:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
	[CellPhone] [char](10) NOT NULL,
	[IsManager] [bit] NOT NULL,
	[MemberState] [bit] NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2022/5/18 下午 03:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[CakeId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[BuyTime] [datetime] NOT NULL,
	[OrderState] [bit] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[MemberId] ASC,
	[CakeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cake] ON 

INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (1, 1, N'提拉米蘇', N'國外進口新鮮乳酪製成慕斯，風味可口清爽，底層採用歐洲進口小麥胚芽餅製作，香味誘人，

並以進口Barry Callebaut高脂可可粉鋪灑而成，若酌以一杯濃郁咖啡，閒散於午后將是絕配。(內含微量咖啡酒)', N'八吋蛋糕(葷)，直徑約19公分(±1公分)
矮盒裝，其最大裝箱數為14盒。', N'1.png', 0, 260)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (5, 2, N'芋頭蛋糕', N'嚴選在地花蓮吉安芋頭。

內層夾餡芋頭、讓口感更滑順。

與法國進口依思妮(isigny)鮮奶油，交織出多層次的味蕾享受。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
高盒裝，其最大裝箱數為12盒。 ', N'2.png', 0, 340)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (6, 1, N'芒果提拉米蘇', N'使用臺灣愛文芒果果丁，與國外進口的新鮮乳酪建構出芒果提拉米蘇的特殊底韻，

並搭配來自歐洲的消化餅乾製作出酥脆的口感與完美的味蕾享受', N'八吋蛋糕(葷)，直徑約19公分(±1公分)
矮盒裝，其最大裝箱數為14盒。  ', N'3.png', 0, 320)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (7, 1, N'素提拉米蘇', N'由國外進口新鮮乳酪製成蛋奶素慕斯，風味可口清爽，底層採用 進口小麥胚芽餅製作，香味誘人，

並以進口Barry Callebaut高脂可可粉鋪灑而成，若酌以一杯濃郁咖啡，閒散於午后將是絕配。

植物性膠質體 (內含微量咖啡酒)', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分)
矮盒裝，其最大裝箱數為14盒。', N'4.png', 0, 260)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (8, 2, N'草莓布朗尼蛋糕
', N'58% Barry Callebaut 調溫巧克力製作構成蛋糕主體，外層披覆草莓果粒鮮奶油，中間為法國進口依思妮(isigny)鮮奶油與與美國草莓水果餡，雙層爆漿夾餡，一次品嚐雙重滿足，讓您沉醉在草莓的繽紛世界中。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
高盒裝，其最大裝箱數為12盒。', N'5.png', 0, 270)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (9, 2, N'抹茶紅豆蛋糕
', N'抹茶鮮奶慕思，茶香濃郁，入口即化，法國進口依思妮(isigny)鮮奶油

搭配嚴選台灣紅豆顆粒餡，茶香味十足的抹茶海綿蛋糕。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
高盒裝，其最大裝箱數為12盒。', N'6.png', 0, 300)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (10, 2, N'黑森林蛋糕
', N'嚴選法國進口依思妮(isigny)鮮奶油製作,表層佈滿豐富的苦甜巧克力脆片。黑巧克力布朗尼構成蛋糕主體，完美雙夾餡設計，結合進口黑櫻桃,吃出多層次口感，回味無窮。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
高盒裝，其最大裝箱數為12盒。', N'7.png', 0, 340)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (11, 2, N'瑪爾蛋糕
', N'選用58% Barry Callebaut 調溫巧克力製成甘納許淋醬,讓口感更甘甜。
美國EFCO進口藍莓顆粒夾餡,粒粒飽滿,香氣誘人。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
高盒裝，其最大裝箱數為12盒。', N'8.png', 0, 260)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (12, 2, N'金莎榛果巧克力
', N'選用58% Barry Callebaut 調溫巧克力,醇厚可可搭配美國杏仁和榛果果粒，淋上源自義大利榛果巧克力醬。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
高盒裝，其最大裝箱數為12盒。     ', N'9.png', 0, 340)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (13, 2, N'鮮奶泡芙(20入)
', N'夢幻般香脆波羅外衣，包覆著純鮮奶的頂級克林姆內餡，熬煉過程絕不添加一滴水的，濃郁乳香自然生成更增爽口。', N'直徑5公分，20入(蛋奶素) 
矮盒裝，其最大裝箱數為14盒。', N'10.png', 0, 260)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (15, 2, N'布朗尼蛋糕(25入)
', N'採用58% Barry Callebaut 調溫巧克力製作出香醇濃郁的布朗尼巧克力蛋糕

', N'直徑4公分，25入(蛋奶素) 
矮盒裝，其最大裝箱數為14盒。 ', N'11.png', 0, 320)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (17, 2, N'優格果乾磅蛋糕
', N'嚴選進口天然奶油與原味優格 調和出濃郁的奶香與柔和的酸甜甘味再拌入無花果與蔓越莓讓水果的果酸香氣互相激盪', N'長條形蛋糕(蛋奶素)，長約20公分(±1公分) 
高盒裝，其最大裝箱數為12盒。', N'12.png', 0, 260)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (19, 2, N'芋泥鮮乳捲', N'採用台灣在地芋頭,法國進口依思妮(isigny)鮮奶油
製作出可口香甜,芋泥份量十足的芋泥鮮乳捲', N'長條形蛋糕(蛋奶素)，長約19公分(±1公分) 
高盒裝，其最大裝箱數為12盒。', N'13.png', 0, 270)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (20, 3, N'蜂蜜檸檬生乳酪塔
', N'採用國外進口新鮮乳酪與進口天然奶油製作生乳酪與檸檬奶油餡,酸酸甜甜,雙重夾餡,濃郁芳香,香酥可口雙重享受。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
矮盒裝，其最大裝箱數為14盒。', N'14.png', 0, 320)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (22, 3, N'藍莓生乳酪塔', N'美國EFCO進口顆粒藍莓粒粒飽滿香氣動人，採用國外進口新鮮乳酪製作，配上精心研發焙烤乳酪派，香脆爽口，兩者搭配口感紮實獨特，無與倫比。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
矮盒裝，其最大裝箱數為14盒。', N'15.png', 0, 250)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (23, 3, N'紅豆生乳酪塔', N'嚴選台灣紅豆的香醇與乳酪的細綿，在唇舌間擴散出香甜可口的滋味', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
矮盒裝，其最大裝箱數為14盒', N'16.png', 0, 270)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (24, 4, N'日式輕乳酪蛋糕', N'嚴選國外進口新鮮乳酪,20％的乳酪含量與法國進口依思妮(isigny)鮮奶油,濃郁芳香﹑入口即化，讓您在繁忙生活中，多一份悠然與自得。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分) 
高盒裝，其最大裝箱數為12盒', N'17.png', 0, 260)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (25, 4, N'重乳酪蛋糕', N'採用天然香醇的進口新鮮乳酪蒸烤製成，63%高比率乳酪，入口即化、口感多層次，底層鋪滿進口小麥胚芽餅，酥脆爽口、香味誘人，讓幸福的滋味從入口開始。', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分)
高盒裝，其最大裝箱數為12盒。  ', N'18.png', 0, 580)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (26, 4, N'黑岩優格乳酪蛋糕', N'手工巧克力餅乾 (類似OREO餅乾口感),優格與國外進口乳酪製成,巧克力酥脆餅乾', N'八吋蛋糕(蛋奶素)，直徑約19公分(±1公分)
矮盒裝，其最大裝箱數為14盒。', N'19.png', 0, 300)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (27, 5, N'夏威夷堅果塔(12入)', N'嚴選富含不飽和脂肪酸(OMEGA-7)頂級夏威夷火山豆，淋上特調蜂蜜糖漿，再與微酸加州蔓越莓果粒拌勻，香甜中帶一絲輕微果酸與香氣，令人難忘的好滋味。', N'精緻鐵盒(12入)(蛋奶素)
矮盒裝，其最大裝箱數為18盒', N'20.png', 0, 450)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (28, 5, N'夏威夷堅果塔(6入)', N'嚴選富含不飽和脂肪酸(OMEGA-7)頂級夏威夷火山豆，淋上特調蜂蜜糖漿，再與微酸加州蔓越莓果粒拌勻，香甜中帶一絲輕微果酸與香氣，令人難忘的好滋味。', N'平裝紙盒(6入)(蛋奶素)
矮盒裝，其最大裝箱數為40盒', N'21.png', 0, 225)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (29, 5, N'法式牛軋糖', N'選用國外進口天然無塩奶油與天然玫瑰岩鹽製作，澳洲進口夏威夷火山豆，富含OMEGA-7天然油脂。完全手工熬煮製造:隨著季節變化與溫度調整 ，才能製造出香Q、軟綿可口頂級的牛軋糖。', N'淨重300g(蛋奶素)(±1公分) 
高盒裝，其最大裝箱數為36罐。', N'22.png', 0, 280)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (30, 6, N'盤叉', N'', N'一組5元有六入', N'23.png', 0, 5)
INSERT [dbo].[Cake] ([CakeId], [ClassId], [CakeName], [CakeDetail], [SizeDetail], [CakeImage], [CakeState], [CakePrice]) VALUES (31, 6, N'生日快樂蠟燭', N'', N'', N'24.png', 0, 0)
SET IDENTITY_INSERT [dbo].[Cake] OFF
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([ClassId], [CakeClass]) VALUES (3, N'生乳酪塔')
INSERT [dbo].[Class] ([ClassId], [CakeClass]) VALUES (2, N'各式蛋糕')
INSERT [dbo].[Class] ([ClassId], [CakeClass]) VALUES (4, N'乳酪蛋糕')
INSERT [dbo].[Class] ([ClassId], [CakeClass]) VALUES (5, N'夏威夷堅果塔及法式牛軋糖')
INSERT [dbo].[Class] ([ClassId], [CakeClass]) VALUES (1, N'提拉米蘇')
INSERT [dbo].[Class] ([ClassId], [CakeClass]) VALUES (6, N'盤叉蠟燭')
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberId], [Name], [Email], [PassWord], [CellPhone], [IsManager], [MemberState]) VALUES (1, N'王曉明', N'wang@gmail.com', N'123456789', N'0912345678', 0, 0)
INSERT [dbo].[Member] ([MemberId], [Name], [Email], [PassWord], [CellPhone], [IsManager], [MemberState]) VALUES (4, N'肥貓', N'fatcat@gmail.com', N'987654321', N'0987654321', 1, 0)
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Cake__D215100E1C88F3E8]    Script Date: 2022/5/18 下午 03:43:06 ******/
ALTER TABLE [dbo].[Cake] ADD UNIQUE NONCLUSTERED 
(
	[CakeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Class__FED9DE87A2C9D23B]    Script Date: 2022/5/18 下午 03:43:06 ******/
ALTER TABLE [dbo].[Class] ADD UNIQUE NONCLUSTERED 
(
	[CakeClass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Member__A9D1053432659541]    Script Date: 2022/5/18 下午 03:43:06 ******/
ALTER TABLE [dbo].[Member] ADD  CONSTRAINT [UQ__Member__A9D1053432659541] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cake]  WITH CHECK ADD  CONSTRAINT [FK_Cake_Class] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[Cake] CHECK CONSTRAINT [FK_Cake_Class]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Cake1] FOREIGN KEY([CakeId])
REFERENCES [dbo].[Cake] ([CakeId])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Cake1]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Member]
GO
ALTER TABLE [dbo].[Favorite]  WITH CHECK ADD  CONSTRAINT [FK_Favorite_Cake1] FOREIGN KEY([CakeId])
REFERENCES [dbo].[Cake] ([CakeId])
GO
ALTER TABLE [dbo].[Favorite] CHECK CONSTRAINT [FK_Favorite_Cake1]
GO
ALTER TABLE [dbo].[Favorite]  WITH CHECK ADD  CONSTRAINT [FK_Favorite_Member1] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Favorite] CHECK CONSTRAINT [FK_Favorite_Member1]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Cake1] FOREIGN KEY([CakeId])
REFERENCES [dbo].[Cake] ([CakeId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Cake1]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Member]
GO
