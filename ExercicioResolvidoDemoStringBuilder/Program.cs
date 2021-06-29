using ExercicioResolvidoDemoStringBuilder.Entities;
using System;

namespace ExercicioResolvidoDemoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post()
            {
                Title = "Traveling to New Zealand",
                Content = "I'm going to visit this wonderful country!",
                Likes = 12,
                Moment = DateTime.Parse("21/06/2018 13:05:44"),
            };
            Post post2 = new Post()
            {
                Title = "Good night guys",
                Content = "See you tomorrow",
                Likes = 5,
                Moment = DateTime.Parse("28/07/2018 23:14:19"),
            };

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            post1.AddComment(c1);
            post1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            post2.AddComment(c3);
            post2.AddComment(c4);


            Console.WriteLine(post1);
            Console.WriteLine(post2);






        }
    }
}
