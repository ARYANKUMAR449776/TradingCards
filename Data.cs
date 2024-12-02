using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

public static class Data
{
    private static List<Player> _players = new List<Player>
    {
            new Player { Id = 1, Name = "LeBron James", Team = "Los Angeles Lakers", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\lebron.jpg", PointsPerGame = 27.2, ReboundsPerGame = 7.4, AssistsPerGame = 7.2, StealsPerGame = 1.6 },
            new Player { Id = 2, Name = "Anthony Davis", Team = "Los Angeles Lakers", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\anthony-davis.jpg", PointsPerGame = 22.5, ReboundsPerGame = 9.0, AssistsPerGame = 2.3, StealsPerGame = 1.2 },
            new Player { Id = 3, Name = "Russell Westbrook", Team = "Los Angeles Lakers", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\russell-westbrook.jpg", PointsPerGame = 18.5, ReboundsPerGame = 7.1, AssistsPerGame = 7.9, StealsPerGame = 1.0 },
            new Player { Id = 4, Name = "Carmelo Anthony", Team = "Los Angeles Lakers", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\carmelo-anthony.jpg", PointsPerGame = 13.4, ReboundsPerGame = 5.2, AssistsPerGame = 1.1, StealsPerGame = 0.6 },
            new Player { Id = 5, Name = "Stephen Curry", Team = "Golden State Warriors", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\curry.jpg", PointsPerGame = 30.0, ReboundsPerGame = 5.5, AssistsPerGame = 6.6, StealsPerGame = 1.2 },
            new Player { Id = 6, Name = "Klay Thompson", Team = "Golden State Warriors", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\Klay-thompson.jpg", PointsPerGame = 19.9, ReboundsPerGame = 3.5, AssistsPerGame = 2.5, StealsPerGame = 0.8 },
            new Player { Id = 7, Name = "Draymond Green", Team = "Golden State Warriors", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\Draymond-Green.jpg", PointsPerGame = 8.7, ReboundsPerGame = 6.9, AssistsPerGame = 6.6, StealsPerGame = 1.4 },
            new Player { Id = 8, Name = "Andrew Wiggins", Team = "Golden State Warriors", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\Andrew-Wiggins.jpg", PointsPerGame = 17.2, ReboundsPerGame = 5.2, AssistsPerGame = 2.0, StealsPerGame = 0.9 },
            new Player { Id = 9, Name = "Ja Morant", Team = "Memphis Grizzlies", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\Ja-Morant.jpg", PointsPerGame = 26.2, ReboundsPerGame = 5.8, AssistsPerGame = 7.1, StealsPerGame = 1.5 },
            new Player { Id = 10, Name = "Jaren Jackson Jr.", Team = "Memphis Grizzlies", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\Jaren-Jackson.jpg", PointsPerGame = 16.0, ReboundsPerGame = 6.6, AssistsPerGame = 1.2, StealsPerGame = 0.9 },
            new Player { Id = 11, Name = "Desmond Bane", Team = "Memphis Grizzlies", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\desmond.jpg", PointsPerGame = 18.2, ReboundsPerGame = 4.3, AssistsPerGame = 2.4, StealsPerGame = 1.1 },
            new Player { Id = 12, Name = "Dillon Brooks", Team = "Memphis Grizzlies", PlayerPhoto = "C:\\Bow Valley College\\Soft Dev\\3. Semester 3\\Rapid Application Development\\Assignment\\PlayerCardImages\\Dillon-Brooks.jpg", PointsPerGame = 14.6, ReboundsPerGame = 4.0, AssistsPerGame = 2.2, StealsPerGame = 1.3 }
    };

    public static List<Player> GetPlayers()
    {
        return _players;
    }

    public static void AddPlayer(Player player)
    {
        _players.Add(player);
    }

    public static void RemovePlayer(Player player)
    {
        _players.Remove(player);
    }
}
