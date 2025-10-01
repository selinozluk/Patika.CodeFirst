using Patika.CodeFirst.App.Data;
using Patika.CodeFirst.App.Models;

Console.WriteLine("Code First Başladı...");

using var db = new PatikaFirstDbContext();

if (!db.Movies.Any())
{
    db.Movies.Add(new Movie { Title = "Inception", Genre = "Action", ReleaseYear = 2010 });
    db.Games.Add(new Game { Name = "The Last of Us", Platform = "PlayStation", Rating = 9.7m });
    db.SaveChanges();
}

Console.WriteLine($"Movies: {db.Movies.Count()} | Games: {db.Games.Count()}");
