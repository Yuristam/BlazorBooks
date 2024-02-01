using BlazorBooks.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorBooks.Api.Data
{
    public class BlazorBooksDbContext : DbContext
    {
        public BlazorBooksDbContext(DbContextOptions<BlazorBooksDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Books
            // Finance Books
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "Rich Dad Poor Dad: What the Rich Teach Their Kids About Money That the Poor and Middle Class Do Not!",
                Description = "Rich Dad Poor Dad is Robert's story of growing up with two dads his real father and the father of his best friend, his rich dad and the ways in which both men shaped his thoughts about money and investing. The book explodes the myth that you need to earn a high income to be rich and explains the difference between working for money and having your money work for you.",
                AuthorName = "Robert Kiyosaki",
                ImageURL = "/Images/Finance/Finance1.png",
                DatePublished = DateTime.Parse("1997, 1, 1"),
                Language = Enums.Language.English,
                CountPages = 336,
                Price = 100,
                GenreId = 1
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Title = "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones",
                Description = "No matter your goals, Atomic Habits offers a proven framework for improving--every day. James Clear, one of the world's leading experts on habit formation, reveals practical strategies that will teach you exactly how to form good habits, break bad ones, and master the tiny behaviors that lead to remarkable results.",
                AuthorName = "James Clear",
                ImageURL = "/Images/Finance/Finance2.png",
                DatePublished = DateTime.Parse("2018, 10, 16"),
                Language = Enums.Language.English,
                CountPages = 320,
                Price = 100,
                GenreId = 1
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                Title = "Ikigai: The Japanese Secret to a Long and Happy Life",
                Description = "According to the Japanese, everyone has an ikigai—a reason for living. And according to the residents of the Japanese village with the world’s longest-living people, finding it is the key to a happier and longer life. Having a strong sense of ikigai—where what you love, what you’re good at, what you can get paid for, and what the world needs all overlap—means that each day is infused with meaning. It’s the reason we get up in the morning. It’s also the reason many Japanese never really retire (in fact there’s no word in Japanese that means retire in the sense it does in English): They remain active and work at what they enjoy, because they’ve found a real purpose in life—the happiness of always being busy.",
                AuthorName = "Héctor García, Francesc Miralles",
                ImageURL = "/Images/Finance/Finance3.png",
                DatePublished = DateTime.Parse("2016, 4, 1"),
                Language = Enums.Language.English,
                CountPages = 208,
                Price = 100,
                GenreId = 1
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 4,
                Title = "The Richest Man in Babylon",
                Description = "The ancient Babylonians were the first people to discover the universal laws of prosperity. In his classic bestseller, \"The Richest Man in Babylon,\" George S. Clason reveals their secrets for creating, growing, and preserving wealth.",
                AuthorName = "George S. Clason",
                ImageURL = "/Images/Finance/Finance4.png",
                DatePublished = DateTime.Parse("1926, 1, 1"),
                Language = Enums.Language.English,
                CountPages = 100,
                Price = 100,
                GenreId = 1
            });

            // Fantasy Books
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 5,
                Title = "Howl's Moving Castle",
                Description = "This entrancing classic fantasy novel is filled with surprises at every turn. An international bestseller, this much-loved book is the source for the Academy Award nominee for Best Animated Feature.\r\n\r\nSophie has the great misfortune of being the eldest of three daughters, destined to fail miserably should she ever leave home to seek her fate. But when she unwittingly attracts the ire of the Witch of the Waste, Sophie finds herself under a horrid spell that transforms her into an old lady. Her only chance at breaking it lies in the ever-moving castle in the hills: the Wizard Howl's castle.",
                AuthorName = "Diana Wynne Jones",
                ImageURL = "/Images/Fantasy/FairyTale1.png",
                DatePublished = DateTime.Parse("1986, 4, 1"),
                Language = Enums.Language.English,
                CountPages = 448,
                Price = 11.99M,
                GenreId = 2
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 6,
                Title = "Castle in the Air",
                Description = "In this stunning sequel to Howl's Moving Castle, Diana Wynne Jones has again created a large-scale, fast-paced fantasy in which people and things are never quite what they seem.\r\n\r\nAbdullah was a young and not very prosperous carpet dealer. His father, who had been disappointed in him, had left him only enough money to open a modest booth in the Bazaar. When he was not selling carpets, Abdullah spent his time daydreaming. In his dreams he was not the son of his father, but the long-lost son of a prince. There was also a princess who had been betrothed to him at birth. He was content with his life and his daydreams until, one day, a stranger sold him a magic carpet.",
                AuthorName = "Diana Wynne Jones",
                ImageURL = "/Images/Fantasy/FairyTale2.png",
                DatePublished = DateTime.Parse("1990, 1, 1"),
                Language = Enums.Language.English,
                CountPages = 400,
                Price = 11.99M,
                GenreId = 2
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 7,
                Title = "Часодеи. Часовой ключ",
                Description = "Василиса – обычная земная девочка, живущая с бабушкой, – неожиданно узнает, что ее отец – влиятельный маг Эфлары, мира, построенного на особой часовой магии. Попав в страну часодеев, фей и лютов, Василиса оказывается в центре опасной игры. Даже друзья не могут понять, кто же она сама? Неумеха, ничего не знающая о своем происхождении? Шпионка, засланная отцом, чтобы заполучить трон? Или могущественная часовщица, которая умеет управлять временем и может спасти Землю и Эфлару от грядущего столкновения?",
                AuthorName = "Наталья Щерба",
                ImageURL = "/Images/Fantasy/FairyTale3.png",
                DatePublished = DateTime.Parse("2011, 1, 1"),
                Language = Enums.Language.Russian,
                CountPages = 368,
                Price = 11.99M,
                GenreId = 2
            });

            // Grammar Books
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 8,
                Title = "FAMILY & FRIENDS 2E: 1 CLASS BOOK WITH STUDENT MULTIROM",
                Description = "Family and Friends offers a carefully graded approach to reading, writing and literacy skills in English to young learners. No other course offers you the same benefits as Family and Friends. The exceptionally strong skills training programme includes a focus on real speaking and writing output. Plus - the amazing package of integrated print and digital resources suits all teaching situations and learner types, supporting students, teachers, and parents. Use it with Little Friends and First Friends to make it an eight or nine-year course.",
                AuthorName = "Naomi Simmons",
                ImageURL = "/Images/Grammar/Educational1.png",
                DatePublished = DateTime.Parse("2008, 1, 1"),
                Language = Enums.Language.English,
                CountPages = 130,
                Price = 63.73M,
                GenreId = 3
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 9,
                Title = "Solutions Third Edition: Advanced STUDENT'S BOOK",
                Description = "Solutions offers a carefully graded approach to reading, writing and literacy skills in English to young learners. No other course offers you the same benefits as Solutions. The exceptionally strong skills training programme includes a focus on real speaking and writing output. Plus - the amazing package of integrated print and digital resources suits all teaching situations and learner types, supporting students, teachers, and parents.",
                AuthorName = "Tim Falla, Paul A Davies, Jane Hudson",
                ImageURL = "/Images/Grammar/Educational2.png",
                DatePublished = DateTime.Parse("2017, 1, 1"),
                Language = Enums.Language.English,
                CountPages = 152,
                Price = 63.73M,
                GenreId = 3
            });

            // Encyclopedia Books
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 10,
                Title = "What's the Point of Math? (DK What's the Point of?)",
                Description = "Math makes the world go around. An educational book that will give you surprising answers to everyday math challenges. \r\n\r\nThis book unpacks how math is an essential part of our everyday life in ways that you never thought of. Full of crazy facts, magic tricks, and mathematical brainteasers and beautiful illustrations show you that math is interesting, fun, and not intimidating at all!",
                AuthorName = "DK",
                ImageURL = "/Images/Encyclopedia/Encyclopedia1.png",
                DatePublished = DateTime.Parse("2020, 1, 28"),
                Language = Enums.Language.English,
                CountPages = 128,
                Price = 16.30M,
                GenreId = 4
            });

            //Add Book Genres
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 1,
                GenreName = "Finance"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 2,
                GenreName = "Fantasy"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 3,
                GenreName = "Grammar"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 4,
                GenreName = "Encyclopedia"
            });
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
