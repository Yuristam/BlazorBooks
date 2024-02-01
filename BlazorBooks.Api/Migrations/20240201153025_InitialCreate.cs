using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorBooks.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    CountPages = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "GenreName" },
                values: new object[,]
                {
                    { 1, "Finance" },
                    { 2, "Fantasy" },
                    { 3, "Grammar" },
                    { 4, "Encyclopedia" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "CountPages", "DatePublished", "Description", "GenreId", "ImageURL", "Language", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Robert Kiyosaki", 336, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rich Dad Poor Dad is Robert's story of growing up with two dads his real father and the father of his best friend, his rich dad and the ways in which both men shaped his thoughts about money and investing. The book explodes the myth that you need to earn a high income to be rich and explains the difference between working for money and having your money work for you.", 1, "/Images/Finance/Finance1.png", 0, 100m, "Rich Dad Poor Dad: What the Rich Teach Their Kids About Money That the Poor and Middle Class Do Not!" },
                    { 2, "James Clear", 320, new DateTime(2018, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "No matter your goals, Atomic Habits offers a proven framework for improving--every day. James Clear, one of the world's leading experts on habit formation, reveals practical strategies that will teach you exactly how to form good habits, break bad ones, and master the tiny behaviors that lead to remarkable results.", 1, "/Images/Finance/Finance2.png", 0, 100m, "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones" },
                    { 3, "Héctor García, Francesc Miralles", 208, new DateTime(2016, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "According to the Japanese, everyone has an ikigai—a reason for living. And according to the residents of the Japanese village with the world’s longest-living people, finding it is the key to a happier and longer life. Having a strong sense of ikigai—where what you love, what you’re good at, what you can get paid for, and what the world needs all overlap—means that each day is infused with meaning. It’s the reason we get up in the morning. It’s also the reason many Japanese never really retire (in fact there’s no word in Japanese that means retire in the sense it does in English): They remain active and work at what they enjoy, because they’ve found a real purpose in life—the happiness of always being busy.", 1, "/Images/Finance/Finance3.png", 0, 100m, "Ikigai: The Japanese Secret to a Long and Happy Life" },
                    { 4, "George S. Clason", 100, new DateTime(1926, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The ancient Babylonians were the first people to discover the universal laws of prosperity. In his classic bestseller, \"The Richest Man in Babylon,\" George S. Clason reveals their secrets for creating, growing, and preserving wealth.", 1, "/Images/Finance/Finance4.png", 0, 100m, "The Richest Man in Babylon" },
                    { 5, "Diana Wynne Jones", 448, new DateTime(1986, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This entrancing classic fantasy novel is filled with surprises at every turn. An international bestseller, this much-loved book is the source for the Academy Award nominee for Best Animated Feature.\r\n\r\nSophie has the great misfortune of being the eldest of three daughters, destined to fail miserably should she ever leave home to seek her fate. But when she unwittingly attracts the ire of the Witch of the Waste, Sophie finds herself under a horrid spell that transforms her into an old lady. Her only chance at breaking it lies in the ever-moving castle in the hills: the Wizard Howl's castle.", 2, "/Images/Fantasy/FairyTale1.png", 0, 11.99m, "Howl's Moving Castle" },
                    { 6, "Diana Wynne Jones", 400, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In this stunning sequel to Howl's Moving Castle, Diana Wynne Jones has again created a large-scale, fast-paced fantasy in which people and things are never quite what they seem.\r\n\r\nAbdullah was a young and not very prosperous carpet dealer. His father, who had been disappointed in him, had left him only enough money to open a modest booth in the Bazaar. When he was not selling carpets, Abdullah spent his time daydreaming. In his dreams he was not the son of his father, but the long-lost son of a prince. There was also a princess who had been betrothed to him at birth. He was content with his life and his daydreams until, one day, a stranger sold him a magic carpet.", 2, "/Images/Fantasy/FairyTale2.png", 0, 11.99m, "Castle in the Air" },
                    { 7, "Наталья Щерба", 368, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Василиса – обычная земная девочка, живущая с бабушкой, – неожиданно узнает, что ее отец – влиятельный маг Эфлары, мира, построенного на особой часовой магии. Попав в страну часодеев, фей и лютов, Василиса оказывается в центре опасной игры. Даже друзья не могут понять, кто же она сама? Неумеха, ничего не знающая о своем происхождении? Шпионка, засланная отцом, чтобы заполучить трон? Или могущественная часовщица, которая умеет управлять временем и может спасти Землю и Эфлару от грядущего столкновения?", 2, "/Images/Fantasy/FairyTale3.png", 1, 11.99m, "Часодеи. Часовой ключ" },
                    { 8, "Naomi Simmons", 130, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family and Friends offers a carefully graded approach to reading, writing and literacy skills in English to young learners. No other course offers you the same benefits as Family and Friends. The exceptionally strong skills training programme includes a focus on real speaking and writing output. Plus - the amazing package of integrated print and digital resources suits all teaching situations and learner types, supporting students, teachers, and parents. Use it with Little Friends and First Friends to make it an eight or nine-year course.", 3, "/Images/Grammar/Educational1.png", 0, 63.73m, "FAMILY & FRIENDS 2E: 1 CLASS BOOK WITH STUDENT MULTIROM" },
                    { 9, "Tim Falla, Paul A Davies, Jane Hudson", 152, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solutions offers a carefully graded approach to reading, writing and literacy skills in English to young learners. No other course offers you the same benefits as Solutions. The exceptionally strong skills training programme includes a focus on real speaking and writing output. Plus - the amazing package of integrated print and digital resources suits all teaching situations and learner types, supporting students, teachers, and parents.", 3, "/Images/Grammar/Educational2.png", 0, 63.73m, "Solutions Third Edition: Advanced STUDENT'S BOOK" },
                    { 10, "DK", 128, new DateTime(2020, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Math makes the world go around. An educational book that will give you surprising answers to everyday math challenges. \r\n\r\nThis book unpacks how math is an essential part of our everyday life in ways that you never thought of. Full of crazy facts, magic tricks, and mathematical brainteasers and beautiful illustrations show you that math is interesting, fun, and not intimidating at all!", 4, "/Images/Encyclopedia/Encyclopedia1.png", 0, 16.30m, "What's the Point of Math? (DK What's the Point of?)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
