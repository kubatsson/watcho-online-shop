using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e_comm.Migrations
{
    public partial class Initialandseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChangePasswords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangePasswords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    ImageRoute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenId = table.Column<int>(type: "int", nullable: true),
                    ChangePasswordId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_ChangePasswords_ChangePasswordId",
                        column: x => x.ChangePasswordId,
                        principalTable: "ChangePasswords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Tokens_TokenId",
                        column: x => x.TokenId,
                        principalTable: "Tokens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    ImageRoute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Payments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "GenderName", "ModifedAt" },
                values: new object[] { 1, new DateTime(2021, 4, 2, 7, 17, 35, 25, DateTimeKind.Utc).AddTicks(3290), "Male", new DateTime(2021, 4, 2, 7, 17, 35, 25, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "GenderName", "ModifedAt" },
                values: new object[] { 2, new DateTime(2021, 4, 2, 7, 17, 35, 25, DateTimeKind.Utc).AddTicks(4974), "Female", new DateTime(2021, 4, 2, 7, 17, 35, 25, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "GenderId", "ImageRoute", "ModifedAt" },
                values: new object[,]
                {
                    { 5, "Casio", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6780), 1, "../images/HomePage/casio.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6780) },
                    { 6, "Rolex", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6781), 1, "../images/HomePage/rolex.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6781) },
                    { 7, "Omega", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6782), 1, "../images/HomePage/omega.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6782) },
                    { 8, "Certina", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6784), 1, "../images/HomePage/certina.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6784) },
                    { 1, "Ade Kaye", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(4811), 2, "../images/HomePage/adekayee.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(4811) },
                    { 2, "Bedat", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6721), 2, "../images/HomePage/bedat.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6721) },
                    { 3, "Bertha", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6777), 2, "../images/HomePage/bertha.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6777) },
                    { 4, "Eterna", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6779), 2, "../images/HomePage/eterna.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 19, DateTimeKind.Utc).AddTicks(6779) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "GenderId", "ImageRoute", "ModifedAt", "Price", "ProductName", "ShortDescription" },
                values: new object[,]
                {
                    { 13, 5, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3428), 1, "../images/HomePage/casio-m/casio1.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3428), 178.99000000000001, "Casio", "G-Shock Men's Analog-Digital Watch" },
                    { 29, 4, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3450), 2, "../images/HomePage/eterna-f/eterna2.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3450), 209.99000000000001, "Eterna", "Eternity Quartz Diamond White Dial Ladies Watch" },
                    { 28, 4, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3448), 2, "../images/HomePage/eterna-f/eterna1.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3448), 174.99000000000001, "Eterna", "Eternity Quartz Diamond White Dial Ladies" },
                    { 27, 3, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3447), 2, "../images/HomePage/bertha-f/bertha4.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3447), 179.99000000000001, "Bertha", "Dixie Quartz Crystal Silver Dial Ladies Watch" },
                    { 26, 3, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3446), 2, "../images/HomePage/bertha-f/bertha3.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3446), 249.99000000000001, "Bertha", "Cecelia Crystal Green Dial Green Leather Ladies Watch" },
                    { 25, 3, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3445), 2, "../images/HomePage/bertha-f/bertha2.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3445), 119.98999999999999, "Bertha", "Cecelia Crystal Green Dial Green Leather Ladies Watch" },
                    { 24, 3, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3444), 2, "../images/HomePage/bertha-f/bertha1.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3444), 139.99000000000001, "Bertha", "Dolly Quartz Silver Dial Ladies Watch" },
                    { 23, 2, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3442), 2, "../images/HomePage/bedat-f/bedat3.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3442), 1119.99, "Bedat", "No 3 Silver Dial Stainless Steel Ladies Watch" },
                    { 22, 2, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3441), 2, "../images/HomePage/bedat-f/bedat2.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3441), 4619.9899999999998, "Bedat", "No 2 Mother of Pearl Diamond Stainless Steel Ladies Watch" },
                    { 21, 2, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3439), 2, "../images/HomePage/bedat-f/bedat1.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3439), 5674.9899999999998, "Bedat", "No. 3 Diamond Steel Ladies Watch" },
                    { 20, 1, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3438), 2, "../images/HomePage/adee kaye-f/ak-4.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3438), 85.989999999999995, "Adee Kaye", "Brown Dial Ladies Crystal Watch" },
                    { 19, 1, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3437), 2, "../images/HomePage/adee kaye-f/ak-3.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3437), 85.989999999999995, "Adee Kaye", "Beverly Hills Exotic Ladies Leather Watch" },
                    { 18, 1, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3434), 2, "../images/HomePage/adee kaye-f/ak-2.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3434), 111.98999999999999, "Adee Kaye", "Yahtch II Blue Dia Ladies Chronograph Watch" },
                    { 17, 1, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3433), 2, "../images/HomePage/adee kaye-f/ak-1.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3433), 85.989999999999995, "Adee Kaye", "Exotic Snowflake Dial Ladies Watc" },
                    { 30, 4, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3455), 2, "../images/HomePage/eterna-f/eterna3.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3455), 1349.99, "Eterna", "Grace Open Art Automatic Mother of Pearl Diamond Ladies Watch" },
                    { 4, 8, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3417), 1, "../images/HomePage/certina-m/certina4.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3417), 189.99000000000001, "Certina", "DS Blue Ribbon Quartz Black Dial Men's Watch" },
                    { 2, 8, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3282), 1, "../images/HomePage/certina-m/certina2.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3282), 220.99000000000001, "Certina", "DS First Ceramic Black Leather Men's Watch" },
                    { 1, 8, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(1645), 1, "../images/HomePage/certina-m/certina1.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(1645), 299.99000000000001, "Certina", " DS Podium Automatic Grey Dial Men's Watch" },
                    { 8, 7, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3422), 1, "../images/HomePage/omega-m/omega4.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3422), 5594.9899999999998, "Omega", "Seamaster Automatic Chronometer Men's" },
                    { 7, 7, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3421), 1, "../images/HomePage/omega-m/omega3.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3421), 4099.9899999999998, "Omega", "Seamaster Automatic Grey Dial Men's Watch" },
                    { 6, 7, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3419), 1, "../images/HomePage/omega-m/omega2.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3419), 3919.9899999999998, "Omega", "Seamaster Automatic Grey Dial Men's Watch" },
                    { 5, 7, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3418), 1, "../images/HomePage/omega-m/omega1.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3418), 3949.9899999999998, "Omega", "Seamaster Automatic Blue Dial Men's Watch" },
                    { 12, 6, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3427), 1, "../images/HomePage/rolex-m/rolex4.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3427), 7194.9899999999998, "Rolex", "Pre-owned Datejust 36 Automatic Diamond Blue Dial Men's Watch" },
                    { 11, 6, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3425), 1, "../images/HomePage/rolex-m/rolex3.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3425), 20149.990000000002, "Rolex", "Submariner Kermit Automatic Chronometer Black Dial Men's Watch" },
                    { 10, 6, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3424), 1, "../images/HomePage/rolex-m/rolex2.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3424), 14324.99, "Rolex", "Oyster Perpetual Submariner Black Dial Black Cerachrom Bezel Steel Men's Watch" },
                    { 9, 6, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3423), 1, "../images/HomePage/rolex-m/rolex1.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3423), 8849.9899999999998, "Rolex", "Air King Black Dial Stainless Steel Men's" },
                    { 16, 5, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3431), 1, "../images/HomePage/casio-m/casio4.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3431), 59.990000000000002, "Casio", "G-Shock Military Men's Watch" },
                    { 15, 5, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3430), 1, "../images/HomePage/casio-m/casio3.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3430), 74.989999999999995, "Casio", "G Shock Grey Digital Dial Resin Men's Watch" },
                    { 14, 5, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3429), 1, "../images/HomePage/casio-m/casio2.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3429), 124.98999999999999, "Casio", "G Shock Analog-Digital Dial Black and Gold Resin Men's Watch GA110GB-1ACR" },
                    { 3, 8, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3415), 1, "../images/HomePage/certina-m/certina3.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3415), 529.99000000000001, "Certina", "DS-1 Big Date Automatic Men's Watch" },
                    { 31, 4, new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3457), 2, "../images/HomePage/eterna-f/eterna4.jpg", new DateTime(2021, 4, 2, 7, 17, 35, 30, DateTimeKind.Utc).AddTicks(3457), 174.99000000000001, "Eterna", "Eternity Quartz Diamond White Dial Ladies Watch" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_GenderId",
                table: "Categories",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ProductId",
                table: "Payments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenderId",
                table: "Products",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ChangePasswordId",
                table: "Users",
                column: "ChangePasswordId",
                unique: true,
                filter: "[ChangePasswordId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderId",
                table: "Users",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TokenId",
                table: "Users",
                column: "TokenId",
                unique: true,
                filter: "[TokenId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ChangePasswords");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
