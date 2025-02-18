USE [master]

create database [MovieRentalSys]
GO

USE [MovieRentalSys]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NULL,
	[FatherName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NOT NULL,
	[Phone] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[RentCost] [int] NULL,
	[StoryLine] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MovieID] [int] NULL,
	[CustID] [int] NULL,
	[DateRented] [varchar](100) NULL,
	[DateReturned] [varchar](100) NULL,
	[TotalRent] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [FatherName], [Address], [Phone]) VALUES (1515, N'Karnpreet', N'Singh', N'Gurcharan Singh', N'Hamilton', N'12456001')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [FatherName], [Address], [Phone]) VALUES (1516, N'Ankit', N'Sharma', N'Major Sharma', N'Auckland', N'7845236554')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [FatherName], [Address], [Phone]) VALUES (1517, N'Divya', N'Sharma', N'Sunil Sharma', N'Auckland', N'7846542441')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [FatherName], [Address], [Phone]) VALUES (1518, N'Monika', N'Singh', N'Harpal Singh', N'Willington', N'7841111544')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (549, N'6.1', N'Lost Girls', N'2020', 5, N'When Mari Gilbert''s daughter disappears, police inaction drives her own investigation into the gated Long Island community where Shannan was last seen. Her search brings attention to over a dozen murdered sex workers.', N' Drama, Mystery, Thriller')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (551, N'6.5', N'Don Jon', N'2013', 2, N'A New Jersey guy dedicated to his family, friends, and church, develops unrealistic expectations from watching porn and works to find happiness and intimacy with his potential true love.', N' Comedy, Drama, Romance ')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (552, N'7.5', N'Hugo', N'2011', 2, N'In 1931 Paris, an orphan living in the walls of a train station gets wrapped up in a mystery involving his late father and an automaton.', N' Drama, Family, Fantasy')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (554, N'7.8', N'About Time', N'2013', 2, N'At the age of 21, Tim discovers he can travel in time and change what happens and has happened in his own life. His decision to make his world a better place by getting a girlfriend turns out not to be as easy as you might think', N' Comedy, Drama, Fantasy')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (555, N'5.4', N' Wonder Woman 1984', N'2020', 5, N'Diana must contend with a work colleague and businessman, whose desire for extreme wealth sends the world down a path of destruction, after an ancient artifact that grants wishes goes missing.', N'Action, Adventure, Fantasy')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (556, N'8.1', N'Soul', N'2020', 5, N'After landing the gig of a lifetime, a New York jazz pianist suddenly finds himself trapped in a strange land between Earth and the afterlife.', N'Animation, Adventure, Comedy')
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (12, 555, 1515, N'22-02-2021', N'26-02-2021', 20)
INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (13, 555, 1517, N'20-02-2021', N'28-02-2021', 40)
INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (14, 555, 1518, N'18-02-2021', N'24-02-2021', 30)
INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (15, 556, 1517, N'18-02-2021', N'24-02-2021', 30)
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uk_phone]    Script Date: 23-02-2021  ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [uk_phone] UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Movies__2CB664DC2CFD92F1]    Script Date: 23-02-2021 ******/
ALTER TABLE [dbo].[Movies] ADD UNIQUE NONCLUSTERED 
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK1] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK1]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK2] FOREIGN KEY([CustID])
REFERENCES [dbo].[Customer] ([CustID])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK2]
GO
/****** Object:  StoredProcedure [dbo].[AddCustInfo]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[AddCustInfo](@FirstName nvarchar(255),@LastName nvarchar(255),@FatherName nvarchar(255),@Address varchar(max),@Phone nvarchar(255))
  as  insert into customer(FirstName,LastName,FatherName,Address,Phone) values(@FirstName,@LastName,@FatherName,@Address,@Phone)
GO
/****** Object:  StoredProcedure [dbo].[CustBorrowMostMovies]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[CustBorrowMostMovies]
	as
	SELECT 
    rm.CustID,
	FirstName,Lastname,
    COUNT(*) CustomerCount
FROM RentedMovies rm join customer cc on cc.custid = rm.custid
GROUP BY
    rm.CustID, FirstName,Lastname
  
HAVING 
    COUNT(*) >=2;
GO
/****** Object:  StoredProcedure [dbo].[DisplayAllRentedMovies]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[DisplayAllRentedMovies]
  as
  select RMID, concat(FirstName,' ',LastName) as 'Customer Name', Address, Title as MovieTitle,
  RentCost,DateRented,DateReturned,TotalRent from RentedMovies rm 
  join Customer c on c.CustID = rm.CustID join Movies m on m.MovieID= rm.MovieID
  order by DateRented desc
GO
/****** Object:  StoredProcedure [dbo].[GetMostPopularMovies]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

   create proc [dbo].[GetMostPopularMovies]
 as
SELECT 
    rm.MovieID,title, COUNT(*) MovieCount
FROM RentedMovies rm join movies m on m.movieid = rm.movieid
GROUP BY
    rm.MovieID, title
  
HAVING 
    COUNT(*) >=2;
GO
/****** Object:  StoredProcedure [dbo].[InsertMovieTbl]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertMovieTbl](@title nvarchar(255),@year nvarchar(255),@rating nvarchar(50),
  @genre nvarchar(50),@rentcost int,@StoryLine ntext)
  as
  insert into movies values(@Rating,@Title,@Year,@RentCost,@StoryLine,@Genre)
GO
/****** Object:  StoredProcedure [dbo].[RentedMovieFromCustomerID]    Script Date: 23-02-2021 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[RentedMovieFromCustomerID](@custID int)
  as
  select rm.MovieID, Title from RentedMovies rm join movies mv on rm.movieid= mv.movieid 
  where DateRented is not null and custid=@custID group by Title, rm.MovieID
GO
/****** Object:  StoredProcedure [dbo].[RentThisMovieNow]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[RentThisMovieNow](@MovieID int,@CustID int,@RentDate varchar(100), @ReturnDate varchar(100),@TotalRent int)
  as
  insert into RentedMovies values(@MovieID,@CustID,@RentDate,@ReturnDate,@TotalRent)
GO
/****** Object:  StoredProcedure [dbo].[ShowMovieFromID]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ShowMovieFromID](@movieID int)
  as
  Select * from movies where movieid=@movieID
GO
/****** Object:  StoredProcedure [dbo].[UpdateMovieTbl]    Script Date: 23-02-2021  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[UpdateMovieTbl](@title nvarchar(255),@year nvarchar(255),@rating nvarchar(50),
  @genre varchar(50),@rentcost int,@StoryLine ntext,@movieId int)
  as
  update movies set title=@title,year=@year,Rating=@rating,
  genre=@genre,RentCost=@rentcost, storyline=@StoryLine where movieId=@movieId
GO
USE [master]
GO
ALTER DATABASE [MovieRentalSys] SET  READ_WRITE 
GO
