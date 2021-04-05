using e_comm.DB.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Configuration
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {

            base.Configure(builder);
            builder.HasData(
                new Product
                {
                    Id=1,
                    ProductName="Certina",
                    GenderId=1,
                    CategoryId=8,
                    ImageRoute="../images/HomePage/certina-m/certina1.jpg",
                    ShortDescription=" DS Podium Automatic Grey Dial Men's Watch",
                    Price =299.99,

                },
                 new Product
                 {
                     Id = 2,
                     ProductName = "Certina",
                     GenderId = 1,
                     CategoryId = 8,
                     ImageRoute = "../images/HomePage/certina-m/certina2.jpg",
                     ShortDescription = "DS First Ceramic Black Leather Men's Watch",
                     Price =220.99,

                 },
                  new Product
                  {
                      Id = 3,
                      ProductName = "Certina",
                      GenderId = 1,
                      CategoryId = 8,
                      ImageRoute = "../images/HomePage/certina-m/certina3.jpg",
                      ShortDescription = "DS-1 Big Date Automatic Men's Watch",
                      Price =529.99,

                  },
                   new Product
                   {
                       Id = 4,
                       ProductName = "Certina",
                       GenderId = 1,
                       CategoryId = 8,
                       ImageRoute = "../images/HomePage/certina-m/certina4.jpg",
                       ShortDescription = "DS Blue Ribbon Quartz Black Dial Men's Watch",
                       Price =189.99,

                   },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Omega",
                        GenderId = 1,
                        CategoryId = 7,
                        ImageRoute = "../images/HomePage/omega-m/omega1.jpg",
                        ShortDescription = "Seamaster Automatic Blue Dial Men's Watch",
                        Price =3949.99,

                    },
                     new Product
                     {
                         Id = 6,
                         ProductName = "Omega",
                         GenderId = 1,
                         CategoryId = 7,
                         ImageRoute = "../images/HomePage/omega-m/omega2.jpg",
                         ShortDescription = "Seamaster Automatic Grey Dial Men's Watch",
                         Price =3919.99,

                     },
                      new Product
                      {
                          Id = 7,
                          ProductName = "Omega",
                          GenderId = 1,
                          CategoryId = 7,
                          ImageRoute = "../images/HomePage/omega-m/omega3.jpg",
                          ShortDescription = "Seamaster Automatic Grey Dial Men's Watch",
                          Price =4099.99,

                      },
                       new Product
                       {
                           Id = 8,
                           ProductName = "Omega",
                           GenderId = 1,
                           CategoryId = 7,
                           ImageRoute = "../images/HomePage/omega-m/omega4.jpg",
                           ShortDescription = "Seamaster Automatic Chronometer Men's",
                           Price =5594.99,

                       },
                        new Product
                        {
                            Id = 9,
                            ProductName = "Rolex",
                            GenderId = 1,
                            CategoryId = 6,
                            ImageRoute = "../images/HomePage/rolex-m/rolex1.jpg",
                            ShortDescription = "Air King Black Dial Stainless Steel Men's",
                            Price =8849.99,

                        },
                         new Product
                         {
                             Id = 10,
                             ProductName = "Rolex",
                             GenderId = 1,
                             CategoryId = 6,
                             ImageRoute = "../images/HomePage/rolex-m/rolex2.jpg",
                             ShortDescription = "Oyster Perpetual Submariner Black Dial Black Cerachrom Bezel Steel Men's Watch",
                             Price =14324.99,

                         },
                          new Product
                          {
                              Id = 11,
                              ProductName = "Rolex",
                              GenderId = 1,
                              CategoryId = 6,
                              ImageRoute = "../images/HomePage/rolex-m/rolex3.jpg",
                              ShortDescription = "Submariner Kermit Automatic Chronometer Black Dial Men's Watch",
                              Price =20149.99,

                          },
                           new Product
                           {
                               Id = 12,
                               ProductName = "Rolex",
                               GenderId = 1,
                               CategoryId = 6,
                               ImageRoute = "../images/HomePage/rolex-m/rolex4.jpg",
                               ShortDescription = "Pre-owned Datejust 36 Automatic Diamond Blue Dial Men's Watch",
                               Price =7194.99,

                           },
                            new Product
                            {
                                Id = 13,
                                ProductName = "Casio",
                                GenderId = 1,
                                CategoryId = 5,
                                ImageRoute = "../images/HomePage/casio-m/casio1.jpg",
                                ShortDescription = "G-Shock Men's Analog-Digital Watch",
                                Price =178.99,

                            },
                             new Product
                             {
                                 Id = 14,
                                 ProductName = "Casio",
                                 GenderId = 1,
                                 CategoryId = 5,
                                 ImageRoute = "../images/HomePage/casio-m/casio2.jpg",
                                 ShortDescription = "G Shock Analog-Digital Dial Black and Gold Resin Men's Watch GA110GB-1ACR",
                                 Price =124.99,

                             },
                              new Product
                              {
                                  Id = 15,
                                  ProductName = "Casio",
                                  GenderId = 1,
                                  CategoryId = 5,
                                  ImageRoute = "../images/HomePage/casio-m/casio3.jpg",
                                  ShortDescription = "G Shock Grey Digital Dial Resin Men's Watch",
                                  Price =74.99,

                              },
                              new Product
                              {
                                  Id = 16,
                                  ProductName = "Casio",
                                  GenderId = 1,
                                  CategoryId = 5,
                                  ImageRoute = "../images/HomePage/casio-m/casio4.jpg",
                                  ShortDescription = "G-Shock Military Men's Watch",
                                  Price =59.99,

                              },
                              new Product
                              {
                                  Id = 17,
                                  ProductName = "Adee Kaye",
                                  GenderId = 2,
                                  CategoryId = 1,
                                  ImageRoute = "../images/HomePage/adee kaye-f/ak-1.jpg",
                                  ShortDescription = "Exotic Snowflake Dial Ladies Watc",
                                  Price = 85.99,

                              },
                              new Product
                              {
                                  Id = 18,
                                  ProductName = "Adee Kaye",
                                  GenderId = 2,
                                  CategoryId = 1,
                                  ImageRoute = "../images/HomePage/adee kaye-f/ak-2.jpg",
                                  ShortDescription = "Yahtch II Blue Dia Ladies Chronograph Watch",
                                  Price = 111.99,

                              },
                              new Product
                              {
                                  Id = 19,
                                  ProductName = "Adee Kaye",
                                  GenderId = 2,
                                  CategoryId = 1,
                                  ImageRoute = "../images/HomePage/adee kaye-f/ak-3.jpg",
                                  ShortDescription = "Beverly Hills Exotic Ladies Leather Watch",
                                  Price = 85.99,

                              },
                              new Product
                              {
                                  Id = 20,
                                  ProductName = "Adee Kaye",
                                  GenderId = 2,
                                  CategoryId = 1,
                                  ImageRoute = "../images/HomePage/adee kaye-f/ak-4.jpg",
                                  ShortDescription = "Brown Dial Ladies Crystal Watch",
                                  Price = 85.99,

                              },
                              new Product
                              {
                                  Id = 21,
                                  ProductName = "Bedat",
                                  GenderId = 2,
                                  CategoryId = 2,
                                  ImageRoute = "../images/HomePage/bedat-f/bedat1.jpg",
                                  ShortDescription = "No. 3 Diamond Steel Ladies Watch",
                                  Price = 5674.99,

                              },
                              new Product
                              {
                                  Id = 22,
                                  ProductName = "Bedat",
                                  GenderId = 2,
                                  CategoryId = 2,
                                  ImageRoute = "../images/HomePage/bedat-f/bedat2.jpg",
                                  ShortDescription = "No 2 Mother of Pearl Diamond Stainless Steel Ladies Watch",
                                  Price = 4619.99,

                              },
                              new Product
                              {
                                  Id = 23,
                                  ProductName = "Bedat",
                                  GenderId = 2,
                                  CategoryId = 2,
                                  ImageRoute = "../images/HomePage/bedat-f/bedat3.jpg",
                                  ShortDescription = "No 3 Silver Dial Stainless Steel Ladies Watch",
                                  Price = 1119.99,

                              },
                              new Product
                              {
                                  Id = 24,
                                  ProductName = "Bertha",
                                  GenderId = 2,
                                  CategoryId = 3,
                                  ImageRoute = "../images/HomePage/bertha-f/bertha1.jpg",
                                  ShortDescription = "Dolly Quartz Silver Dial Ladies Watch",
                                  Price = 139.99,

                              },
                              new Product
                              {
                                  Id = 25,
                                  ProductName = "Bertha",
                                  GenderId = 2,
                                  CategoryId = 3,
                                  ImageRoute = "../images/HomePage/bertha-f/bertha2.jpg",
                                  ShortDescription = "Cecelia Crystal Green Dial Green Leather Ladies Watch",
                                  Price = 119.99,

                              },
                              new Product
                              {
                                  Id = 26,
                                  ProductName = "Bertha",
                                  GenderId = 2,
                                  CategoryId = 3,
                                  ImageRoute = "../images/HomePage/bertha-f/bertha3.jpg",
                                  ShortDescription = "Cecelia Crystal Green Dial Green Leather Ladies Watch",
                                  Price = 249.99,

                              },
                              new Product
                              {
                                  Id = 27,
                                  ProductName = "Bertha",
                                  GenderId = 2,
                                  CategoryId = 3,
                                  ImageRoute = "../images/HomePage/bertha-f/bertha4.jpg",
                                  ShortDescription = "Dixie Quartz Crystal Silver Dial Ladies Watch",
                                  Price = 179.99,

                              },
                              new Product
                              {
                                  Id = 28,
                                  ProductName = "Eterna",
                                  GenderId = 2,
                                  CategoryId = 4,
                                  ImageRoute = "../images/HomePage/eterna-f/eterna1.jpg",
                                  ShortDescription = "Eternity Quartz Diamond White Dial Ladies",
                                  Price = 174.99,

                              },
                              new Product
                              {
                                  Id = 29,
                                  ProductName = "Eterna",
                                  GenderId = 2,
                                  CategoryId = 4,
                                  ImageRoute = "../images/HomePage/eterna-f/eterna2.jpg",
                                  ShortDescription = "Eternity Quartz Diamond White Dial Ladies Watch",
                                  Price = 209.99,

                              },
                              new Product
                              {
                                  Id = 30,
                                  ProductName = "Eterna",
                                  GenderId = 2,
                                  CategoryId = 4,
                                  ImageRoute = "../images/HomePage/eterna-f/eterna3.jpg",
                                  ShortDescription = "Grace Open Art Automatic Mother of Pearl Diamond Ladies Watch",
                                  Price = 1349.99,

                              },
                              new Product
                              {
                                  Id = 31,
                                  ProductName = "Eterna",
                                  GenderId = 2,
                                  CategoryId = 4,
                                  ImageRoute = "../images/HomePage/eterna-f/eterna4.jpg",
                                  ShortDescription = "Eternity Quartz Diamond White Dial Ladies Watch",
                                  Price = 174.99,

                              }



                );

            
        }
    }
}
