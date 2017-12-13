using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ContribeBookStore.Models
{
    public class BookStoreData : DropCreateDatabaseAlways<StoreEntities> 
    {
        protected override void Seed(StoreEntities context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Drama" },
                new Genre { Name = "Technology" },
                new Genre { Name = "Science" },
                new Genre { Name = "Agriculture" },
                new Genre { Name = "History" },
                new Genre { Name = "Romance" },

            };

            var artists = new List<Artist>
            {
                new Artist { Name = "Average Swede" },
                new Artist { Name = "Rich Block" },
                new Artist { Name = "Aaron Goldberg" },
                new Artist { Name = "Jeffrey Archec" },
                new Artist { Name = "Rasenjit Paul" },
                new Artist { Name = "Joseph Murphy" }

            };

            new List<Book>
            {
                new Book { Title = "The Best Of Men At Work", Genre = genres.Single(g => g.Name == "Drama"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Average Swede"), AlbumArtUrl = "/Content/Images/1.jpeg", Stock=10 },
                new Book { Title = "A Copland Celebration, Vol. I", Genre = genres.Single(a => a.Name == "Technology"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rich Block"), AlbumArtUrl = "/Content/Images/2.jpeg",Stock=5 },
                new Book { Title = "Dödsmask och lustgård ", Genre = genres.Single(a => a.Name == "Science"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/2.jpeg" ,Stock=4},
                new Book { Title = "For Those About To Rock We Salute You", Genre = genres.Single(a => a.Name == "Agriculture"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Jeffrey Archec"), AlbumArtUrl = "/Content/Images/3.jpeg",Stock=0 },
                new Book { Title = "Let There Be Rock", Genre = genres.Single(a => a.Name == "History"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rasenjit Paul"), AlbumArtUrl = "/Content/Images/4.jpeg",Stock=8 },
                new Book { Title = "Let There Be Rocking new", Genre = genres.Single(a => a.Name == "Romance"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Joseph Murphy"), AlbumArtUrl = "/Content/Images/5.jpeg",Stock=9 },

                 new Book { Title = "The Best Of Men At Work", Genre = genres.Single(g => g.Name == "Drama"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Average Swede"), AlbumArtUrl = "/Content/Images/1.jpeg", Stock=10 },
                new Book { Title = "A Copland Celebration, Vol. I", Genre = genres.Single(a => a.Name == "Technology"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rich Block"), AlbumArtUrl = "/Content/Images/2.jpeg",Stock=5 },
                new Book { Title = "Dödsmask och lustgård ", Genre = genres.Single(a => a.Name == "Science"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/2.jpeg" ,Stock=4},
                new Book { Title = "For Those About To Rock We Salute You", Genre = genres.Single(a => a.Name == "Agriculture"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Jeffrey Archec"), AlbumArtUrl = "/Content/Images/3.jpeg",Stock=0 },
                new Book { Title = "Let There Be Rock", Genre = genres.Single(a => a.Name == "History"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rasenjit Paul"), AlbumArtUrl = "/Content/Images/4.jpeg",Stock=8 },
                new Book { Title = "Let There Be Rocking new", Genre = genres.Single(a => a.Name == "Romance"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Joseph Murphy"), AlbumArtUrl = "/Content/Images/5.jpeg",Stock=9 },

                 new Book { Title = "The Best Of Men At Work", Genre = genres.Single(g => g.Name == "Drama"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Average Swede"), AlbumArtUrl = "/Content/Images/1.jpeg", Stock=10 },
                new Book { Title = "A Copland Celebration, Vol. I", Genre = genres.Single(a => a.Name == "Technology"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rich Block"), AlbumArtUrl = "/Content/Images/2.jpeg",Stock=5 },
                new Book { Title = "Dödsmask och lustgård ", Genre = genres.Single(a => a.Name == "Science"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/2.jpeg" ,Stock=4},
                new Book { Title = "For Those About To Rock We Salute You", Genre = genres.Single(a => a.Name == "Agriculture"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Jeffrey Archec"), AlbumArtUrl = "/Content/Images/3.jpeg",Stock=0 },
                new Book { Title = "Let There Be Rock", Genre = genres.Single(a => a.Name == "History"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rasenjit Paul"), AlbumArtUrl = "/Content/Images/4.jpeg",Stock=8 },
                new Book { Title = "Let There Be Rocking new", Genre = genres.Single(a => a.Name == "Romance"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Joseph Murphy"), AlbumArtUrl = "/Content/Images/5.jpeg",Stock=9 },

                 new Book { Title = "The Best Of Men At Work", Genre = genres.Single(g => g.Name == "Drama"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Average Swede"), AlbumArtUrl = "/Content/Images/1.jpeg", Stock=10 },
                new Book { Title = "A Copland Celebration, Vol. I", Genre = genres.Single(a => a.Name == "Technology"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rich Block"), AlbumArtUrl = "/Content/Images/2.jpeg",Stock=5 },
                new Book { Title = "Dödsmask och lustgård ", Genre = genres.Single(a => a.Name == "Science"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/2.jpeg" ,Stock=4},
                new Book { Title = "For Those About To Rock We Salute You", Genre = genres.Single(a => a.Name == "Agriculture"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Jeffrey Archec"), AlbumArtUrl = "/Content/Images/3.jpeg",Stock=0 },
                new Book { Title = "Let There Be Rock", Genre = genres.Single(a => a.Name == "History"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rasenjit Paul"), AlbumArtUrl = "/Content/Images/4.jpeg",Stock=8 },
                new Book { Title = "Let There Be Rocking new", Genre = genres.Single(a => a.Name == "Romance"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Joseph Murphy"), AlbumArtUrl = "/Content/Images/5.jpeg",Stock=9 },

                new Book { Title = "The Best Of Men At Work", Genre = genres.Single(g => g.Name == "Drama"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Average Swede"), AlbumArtUrl = "/Content/Images/1.jpeg", Stock=10 },
                new Book { Title = "A Copland Celebration, Vol. I", Genre = genres.Single(a => a.Name == "Technology"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rich Block"), AlbumArtUrl = "/Content/Images/2.jpeg",Stock=5 },
                new Book { Title = "Dödsmask och lustgård ", Genre = genres.Single(a => a.Name == "Science"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/2.jpeg" ,Stock=4},
                new Book { Title = "For Those About To Rock We Salute You", Genre = genres.Single(a => a.Name == "Agriculture"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Jeffrey Archec"), AlbumArtUrl = "/Content/Images/3.jpeg",Stock=0 },
                new Book { Title = "Let There Be Rock", Genre = genres.Single(a => a.Name == "History"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rasenjit Paul"), AlbumArtUrl = "/Content/Images/4.jpeg",Stock=8 },
                new Book { Title = "Let There Be Rocking new", Genre = genres.Single(a => a.Name == "Romance"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Joseph Murphy"), AlbumArtUrl = "/Content/Images/5.jpeg",Stock=9 },


                new Book { Title = "Bränt barn", Genre = genres.Single(g => g.Name == "Drama"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Average Swede"), AlbumArtUrl = "/Content/Images/1.jpeg", Stock=10 },
                new Book { Title = "Dramer om dömda", Genre = genres.Single(a => a.Name == "Technology"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rich Block"), AlbumArtUrl = "/Content/Images/2.jpeg",Stock=5 },
                new Book { Title = "Tysk höst", Genre = genres.Single(a => a.Name == "Science"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/3.jpeg" ,Stock=4},
                new Book { Title = "Kärlek i tjugonde seklet", Genre = genres.Single(a => a.Name == "Agriculture"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Jeffrey Archec"), AlbumArtUrl = "/Content/Images/4.jpeg",Stock=0 },
                new Book { Title = "Ensamstående bildad herre", Genre = genres.Single(a => a.Name == "History"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rasenjit Paul"), AlbumArtUrl = "/Content/Images/5.jpeg",Stock=8 },
                new Book { Title = "Den heliga natten", Genre = genres.Single(a => a.Name == "Romance"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Joseph Murphy"), AlbumArtUrl = "/Content/Images/6.jpeg",Stock=9 },

                new Book { Title = "Gösta Berling’s Saga", Genre = genres.Single(g => g.Name == "Drama"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Average Swede"), AlbumArtUrl = "/Content/Images/6.jpeg", Stock=10 },
                new Book { Title = "Harry Potter and the Order of the Phoenix ", Genre = genres.Single(a => a.Name == "Technology"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rich Block"), AlbumArtUrl = "/Content/Images/5.jpeg",Stock=5 },
                new Book { Title = "To Kill a Mockingbird ", Genre = genres.Single(a => a.Name == "Science"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/4.jpeg" ,Stock=4},
                new Book { Title = "Från Dronten till Gripen", Genre = genres.Single(a => a.Name == "Agriculture"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Jeffrey Archec"), AlbumArtUrl = "/Content/Images/3.jpeg",Stock=0 },
                new Book { Title = "Brottsplats Rosenbad", Genre = genres.Single(a => a.Name == "History"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rasenjit Paul"), AlbumArtUrl = "/Content/Images/2.jpeg",Stock=8 },
                new Book { Title = "Den sjätte natten", Genre = genres.Single(a => a.Name == "Romance"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Joseph Murphy"), AlbumArtUrl = "/Content/Images/1.jpeg",Stock=9 }

            }.ForEach(a => context.Books.Add(a));
        }
    }
}
//new Album { Title = "Mastering åäö", Genre = genres.Single(g => g.Name == "Drama"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Average Swede"), AlbumArtUrl = "/Content/Images/1.jpeg", Stock=10 }
//new Album { Title = "How To Spend Money", Genre = genres.Single(a => a.Name == "Technology"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rich Block"), AlbumArtUrl = "/Content/Images/1.jpeg",Stock=5 },
//new Album { Title = "Meningslösa stycken", Genre = genres.Single(a => a.Name == "Science"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/1.jpeg" ,Stock=4},
//new Album { Title = "Tell Tale", Genre = genres.Single(a => a.Name == "Agriculture"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Jeffrey Arche"), AlbumArtUrl = "/Content/Images/1.jpeg",Stock=0 },
//new Album { Title = "How to Avoid Loss and Earn", Genre = genres.Single(a => a.Name == "History"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Prasenjit Paul"), AlbumArtUrl = "/Content/Images/1.jpeg",Stock=8 },
//new Album { Title = "The Power of your Subconscious Mind", Genre = genres.Single(a => a.Name == "Romance"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Joseph Murphy"), AlbumArtUrl = "/Content/Images/1.jpeg",Stock=9 },

//new Album { Title = "Bury My Heart at Wounded Knee", Genre = genres.Single(g => g.Name == "Drama"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Average Swede"), AlbumArtUrl = "/Content/Images/1.jpeg", Stock=10 },
//new Album { Title = "Butter In a Lordly Dish", Genre = genres.Single(a => a.Name == "Technology"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rich Block"), AlbumArtUrl = "/Content/Images/1.jpeg",Stock=5 },
//new Album { Title = "Death Be Not Proud", Genre = genres.Single(a => a.Name == "Science"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/1.jpeg" ,Stock=4},
//new Album { Title = "The Doors of Perception", Genre = genres.Single(a => a.Name == "Agriculture"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Jeffrey Arche"), AlbumArtUrl = "/Content/Images/1.jpeg",Stock=0 },
//new Album { Title = "Down to a Sunless Sea", Genre = genres.Single(a => a.Name == "History"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Prasenjit Paul"), AlbumArtUrl = "/Content/Images/1.jpeg",Stock=8 },
//new Album { Title = "Dulce et Decorum Est", Genre = genres.Single(a => a.Name == "Romance"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Joseph Murphy"), AlbumArtUrl = "/Content/Images/1.jpeg",Stock=9 },
