using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema.Model
{
    /// <summary>
    /// Represents a theater in the Cinema system.
    /// </summary>
    [Serializable]
    public class Theater
    {
        private IMongoCollection<Movie> movies;
        private static int num = 1;
        private static char letter = 'A';
        private const int capacity = 20;

        /// <summary>
        /// The name of the theater.
        /// </summary>
        [BsonElement("Name")]
        [BsonRepresentation(BsonType.String)]
        public string Name { get; set; }

        /// <summary>
        /// The capacity of the theater (number of seats).
        /// </summary>
        [BsonElement("Capacity")]
        [BsonRepresentation(BsonType.Int32)]
        public int Capacity { get; set; }

        /// <summary>
        /// Dictionary that maps date and time to a list of seats for the theater.
        /// </summary>
        [BsonElement("seatsAndHourDic")]
        [BsonRepresentation(BsonType.Array)]
        public Dictionary<string, List<Seat>> seatsAndHourDic { get; set; }

        /// <summary>
        /// Constructor for creating a new instance of the Theater class.
        /// </summary>
        /// <param name="movies">The MongoDB collection for movies.</param>
        /// <param name="hours">The list of hours for which the theater has seats.</param>
        public Theater(IMongoCollection<Movie> movies, List<string> hours)
        {
            this.movies = movies;
            Name = GenerateName();
            Capacity = capacity;

            // Initialize the seatsAndHourDic dictionary with an empty list of seats for each hour
            seatsAndHourDic = new Dictionary<string, List<Seat>>();
            foreach (string hour in hours)
            {
                // Create seats for each hour and add them to the list
                List<Seat> seatsForHour = new List<Seat>();
                for (int i = 0; i < Capacity; i++)
                {
                    Seat seat = new Seat();
                    seatsForHour.Add(seat);
                }

                // Add the list of seats to the seatsAndHourDic for the specific hour
                seatsAndHourDic[hour] = seatsForHour;
            }
        }



        private string GenerateName()
        {
            string name;

            // Retrieve the last theater name from the database
            var lastTheater = movies.Find(_ => true)
                                    .SortByDescending(movie => movie.th.Name)
                                    .Limit(1)
                                    .FirstOrDefault();

            if (lastTheater != null)
            {
                string lastTheaterName = lastTheater.th.Name;

                // Increment the letter and number based on the last theater name
                char lastLetter = lastTheaterName[0];
                int lastNum = Convert.ToInt32(lastTheaterName.Substring(1));

                IncrementName(lastLetter, lastNum);
            }
            else
            {
                // Generate the initial theater name if no theaters exist in the database
                IncrementName('A', 0);
            }

            name = letter + Convert.ToString(num);

            return name;
        }

        private void IncrementName(char lastLetter, int lastNum)
        {
            num = lastNum + 1;
            letter = lastLetter;

            if (num > 26)
            {
                num = 1;
                IncrementLetter();
            }
        }

        private void IncrementLetter()
        {
            letter++;
            if (letter > 'Z')
            {
                letter = 'A';
            }
        }
    }
}
