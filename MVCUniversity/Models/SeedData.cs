using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCUniversity.Data;
using System;
using System.Linq;

namespace MVCUniversity.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCUniversityContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCUniversityContext>>()))
            {
                // Look for any movies.
                if (context.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Course.AddRange(
                    new Course
                    {
                        Name = "English 1",
                        SubjectMatter = "English Language Basics",
                        Description = "A 6 week course that will allow to speak English when you are on holiday. European framework level A2.",
                        StartingDate = DateTime.Parse("2021-9-1")
                    },

                    new Course
                    {
                        Name = "Spanish 1",
                        SubjectMatter = "Spanish Language Basics",
                        Description = "A 6 week course that will allow to speak Spanish when you are on holiday. European framework level A2.",
                        StartingDate = DateTime.Parse("2021-9-1")
                    },
                    new Course
                    {
                        Name = "English Literature 1",
                        SubjectMatter = "English Literature",
                        Description = "A 4 week course taught completely in English that will explore Shakespeare's masterpieces.",
                        StartingDate = DateTime.Parse("2021-9-1")
                    },
                    new Course
                    {
                        Name = "Russian Literature 2",
                        SubjectMatter = "Russian Literature - Dostoevsky",
                        Description = "A 4 week course that will discover Dostoevsky's story as well as Crime and Punishment and The Brothers Karamazov.",
                        StartingDate = DateTime.Parse("2021-9-1")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}