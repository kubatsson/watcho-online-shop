using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e_comm.Migrations
{
    public partial class Initialandseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "BillingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    table.ForeignKey(
                        name: "FK_ChangePasswords_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Tokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                values: new object[] { 1, new DateTime(2021, 4, 6, 21, 39, 2, 471, DateTimeKind.Utc).AddTicks(196), "Male", new DateTime(2021, 4, 6, 21, 39, 2, 471, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "GenderName", "ModifedAt" },
                values: new object[] { 2, new DateTime(2021, 4, 6, 21, 39, 2, 471, DateTimeKind.Utc).AddTicks(498), "Female", new DateTime(2021, 4, 6, 21, 39, 2, 471, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "GenderId", "ImageRoute", "ModifedAt" },
                values: new object[,]
                {
                    { 5, "Casio", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5754), 1, "../images/HomePage/casio.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5754) },
                    { 6, "Rolex", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5756), 1, "../images/HomePage/rolex.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5756) },
                    { 7, "Omega", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5757), 1, "../images/HomePage/omega.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5757) },
                    { 8, "Certina", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5758), 1, "../images/HomePage/certina.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5758) },
                    { 1, "Ade Kaye", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(4042), 2, "../images/HomePage/adekayee.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(4042) },
                    { 2, "Bedat", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5699), 2, "../images/HomePage/bedat.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5699) },
                    { 3, "Bertha", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5752), 2, "../images/HomePage/bertha.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5752) },
                    { 4, "Eterna", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5753), 2, "../images/HomePage/eterna.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 468, DateTimeKind.Utc).AddTicks(5753) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "GenderId", "ModifedAt", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new DateTime(2021, 4, 6, 21, 39, 2, 478, DateTimeKind.Utc).AddTicks(3395), "adiskubat@outlook.com", 1, new DateTime(2021, 4, 6, 21, 39, 2, 478, DateTimeKind.Utc).AddTicks(3395), "C29v6PDxBQq/0r05p0yzXWxUdm7dH5xQ+Y2sagbcKbY=", "NBRH/6nbEfnhdyx9a7w6lA==", "testuser" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "GenderId", "ImageRoute", "ModifedAt", "Price", "ProductName", "ShortDescription" },
                values: new object[,]
                {
                    { 13, 5, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5712), 1, "../images/HomePage/casio-m/casio1.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5712), 178.99000000000001, "Casio", "G-Shock Men's Analog-Digital Watch" },
                    { 29, 4, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5731), 2, "../images/HomePage/eterna-f/eterna2.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5731), 209.99000000000001, "Eterna", "Eternity Quartz Diamond White Dial Ladies Watch" },
                    { 28, 4, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5729), 2, "../images/HomePage/eterna-f/eterna1.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5729), 174.99000000000001, "Eterna", "Eternity Quartz Diamond White Dial Ladies" },
                    { 27, 3, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5728), 2, "../images/HomePage/bertha-f/bertha4.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5728), 179.99000000000001, "Bertha", "Dixie Quartz Crystal Silver " },
                    { 26, 3, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5727), 2, "../images/HomePage/bertha-f/bertha3.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5727), 249.99000000000001, "Bertha", "Cecelia Crystal Green Dial Green " },
                    { 25, 3, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5726), 2, "../images/HomePage/bertha-f/bertha2.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5726), 119.98999999999999, "Bertha", "Cecelia Crystal Green Dial Green " },
                    { 24, 3, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5725), 2, "../images/HomePage/bertha-f/bertha1.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5725), 139.99000000000001, "Bertha", "Dolly Quartz Silver Dial Ladies Watch" },
                    { 23, 2, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5723), 2, "../images/HomePage/bedat-f/bedat3.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5723), 1119.99, "Bedat", "No 3 Silver Dial Stainless Steel " },
                    { 22, 2, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5722), 2, "../images/HomePage/bedat-f/bedat2.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5722), 4619.9899999999998, "Bedat", "No 2 Mother of Pearl Diamond Stainless " },
                    { 21, 2, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5721), 2, "../images/HomePage/bedat-f/bedat1.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5721), 5674.9899999999998, "Bedat", "No. 3 Diamond Steel Ladies Watch" },
                    { 20, 1, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5720), 2, "../images/HomePage/adee kaye-f/ak-4.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5720), 85.989999999999995, "Adee Kaye", "Brown Dial Ladies Crystal Watch" },
                    { 19, 1, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5719), 2, "../images/HomePage/adee kaye-f/ak-3.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5719), 85.989999999999995, "Adee Kaye", "Beverly Hills Exotic Ladies Leather Watch" },
                    { 18, 1, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5717), 2, "../images/HomePage/adee kaye-f/ak-2.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5717), 111.98999999999999, "Adee Kaye", "Yahtch II Blue Dia Ladies Chronograph Watch" },
                    { 17, 1, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5716), 2, "../images/HomePage/adee kaye-f/ak-1.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5716), 85.989999999999995, "Adee Kaye", "Exotic Snowflake Dial Ladies Watc" },
                    { 30, 4, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5732), 2, "../images/HomePage/eterna-f/eterna3.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5732), 1349.99, "Eterna", "Grace Open Art Automatic Mother " },
                    { 4, 8, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5699), 1, "../images/HomePage/certina-m/certina4.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5699), 189.99000000000001, "Certina", "DS Blue Ribbon Quartz Black" },
                    { 2, 8, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5603), 1, "../images/HomePage/certina-m/certina2.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5603), 220.99000000000001, "Certina", "DS First Ceramic Black Leather Men's Watch" },
                    { 1, 8, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(4250), 1, "../images/HomePage/certina-m/certina1.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(4250), 299.99000000000001, "Certina", " DS Podium Automatic Grey Dial Men's Watch" },
                    { 8, 7, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5705), 1, "../images/HomePage/omega-m/omega4.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5705), 5594.9899999999998, "Omega", "Seamaster Automatic Chronometer Men's" },
                    { 7, 7, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5704), 1, "../images/HomePage/omega-m/omega3.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5704), 4099.9899999999998, "Omega", "Seamaster Automatic Grey Dial Men's Watch" },
                    { 6, 7, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5703), 1, "../images/HomePage/omega-m/omega2.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5703), 3919.9899999999998, "Omega", "Seamaster Automatic Grey Dial Men's Watch" },
                    { 5, 7, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5700), 1, "../images/HomePage/omega-m/omega1.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5700), 3949.9899999999998, "Omega", "Seamaster Automatic Blue Dial Men's Watch" },
                    { 12, 6, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5710), 1, "../images/HomePage/rolex-m/rolex4.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5710), 7194.9899999999998, "Rolex", "Pre-owned Datejust 36 Automatic Diamond" },
                    { 11, 6, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5709), 1, "../images/HomePage/rolex-m/rolex3.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5709), 20149.990000000002, "Rolex", "Submariner Kermit Automatic Chronometer " },
                    { 10, 6, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5708), 1, "../images/HomePage/rolex-m/rolex2.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5708), 14324.99, "Rolex", "Oyster Perpetual Submariner Black Dial " },
                    { 9, 6, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5707), 1, "../images/HomePage/rolex-m/rolex1.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5707), 8849.9899999999998, "Rolex", "Air King Black Dial Stainless Steel Men's" },
                    { 16, 5, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5715), 1, "../images/HomePage/casio-m/casio4.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5715), 59.990000000000002, "Casio", "G-Shock Military Men's Watch" },
                    { 15, 5, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5714), 1, "../images/HomePage/casio-m/casio3.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5714), 74.989999999999995, "Casio", "G Shock Grey Digital Dial Resin " },
                    { 14, 5, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5713), 1, "../images/HomePage/casio-m/casio2.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5713), 124.98999999999999, "Casio", "G Shock Analog-Digital Dial Black " },
                    { 3, 8, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5697), 1, "../images/HomePage/certina-m/certina3.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5697), 529.99000000000001, "Certina", "DS-1 Big Date Automatic Men's Watch" },
                    { 31, 4, new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5733), 2, "../images/HomePage/eterna-f/eterna4.jpg", new DateTime(2021, 4, 6, 21, 39, 2, 474, DateTimeKind.Utc).AddTicks(5733), 174.99000000000001, "Eterna", "Eternity Quartz Diamond White Dial " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillingDetails_UserId",
                table: "BillingDetails",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_GenderId",
                table: "Categories",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangePasswords_UserId",
                table: "ChangePasswords",
                column: "UserId",
                unique: true);

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
                name: "IX_Tokens_UserId",
                table: "Tokens",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderId",
                table: "Users",
                column: "GenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingDetails");

            migrationBuilder.DropTable(
                name: "ChangePasswords");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
