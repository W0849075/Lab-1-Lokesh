using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lab_1_Lokesh.Data;
using System;
using System.Linq;

namespace Lab_1_Lokesh.Models;
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Lab_1_LokeshContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Lab_1_LokeshContext>>()))
            {
                // Look for any movies.
                if (context.LokeshMovie.Any())
                {
                    return;   // DB has been seeded
                }
                context.LokeshMovie.AddRange(
                    new LokeshMovie
                    {
                        Title = "SVP",
                        ReleaseDate = DateTime.Parse("2023-1-12"),
                        Genre = "Family Comedy",
                        Rating = "R",
                        price = 17.99M
                    },
                new LokeshMovie
                {
                    Title = "Filmy Moji",
                    ReleaseDate = DateTime.Parse("2024-1-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    price = 8.99M
                },
                new LokeshMovie
                {
                    Title = "DJ Tillu",
                    ReleaseDate = DateTime.Parse("2021-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    price = 19.99M
                },
                new LokeshMovie
                {
                    Title = "Salar",
                    ReleaseDate = DateTime.Parse("2023-4-15"),
                    Genre = "Action",
                    Rating = "R",
                    price = 13.99M
                },
                new LokeshMovie
                {
                    Title = "Athadu",
                    ReleaseDate = DateTime.Parse("2017-03-28"),
                    Genre= "Action",
                    Rating = "R",
                    price = 10.11M
                },
                new LokeshMovie
                {
                    Title = "Pokiri",
                    ReleaseDate = DateTime.Parse("2019-03-28"),
                    Genre = "Action",
                    Rating = "R",
                    price = 16.11M
                }
            );
            context.SaveChanges();
        }
        }
    }
