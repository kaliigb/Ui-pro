using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema.Model
{
    /// <summary>
    /// Represents a movie in the Cinema system.
    /// </summary>
    [Serializable]
    public class Movie
    {
        private IMongoCollection<Movie> movies;
        public Theater th;

        // The unique identifier of the movie.
        // It will be mapped to the "id" column in the MongoDB collection.
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the movie.
        /// It will be mapped to the "movieName" column in the MongoDB collection.
        /// </summary>
        [BsonElement("movieName")]
        [BsonRepresentation(BsonType.String)]
        public string MovieName { get; set; }

        /// <summary>
        /// The category of the movie.
        /// It will be mapped to the "movieCategories" column in the MongoDB collection.
        /// </summary>
        [BsonElement("movieCategories")]
        public List<string> MovieCategories { get; set; }

        /// <summary>
        /// The projection type of the movie (e.g., 2D, 3D, 4DX).
        /// It will be mapped to the "projectionType" column in the MongoDB collection.
        /// </summary>
        [BsonElement("projectionType")]
        [BsonRepresentation(BsonType.String)]
        public string ProjectionType { get; set; }

        /// <summary>
        /// The price of the movie.
        /// It will be mapped to the "price" column in the MongoDB collection.
        /// In the code, Price is defined as Double, but in the database, it will be stored as a string.
        /// </summary>
        [BsonElement("price")]
        [BsonRepresentation(BsonType.Double)]
        public double Price { get; set; }

        /// <summary>
        /// The director of the movie.
        /// It will be mapped to the "director" column in the MongoDB collection.
        /// </summary>
        [BsonElement("director")]
        [BsonRepresentation(BsonType.String)]
        public string Director { get; set; }

        /// <summary>
        /// The duration of the movie.
        /// It will be mapped to the "duration" column in the MongoDB collection.
        /// </summary>
        [BsonElement("duration")]
        [BsonRepresentation(BsonType.String)]
        public string Duration { get; set; }

        /// <summary>
        /// The poster of the movie.
        /// It will be mapped to the "poster" column in the MongoDB collection.
        /// </summary>
        [BsonElement("poster")]
        [BsonRepresentation(BsonType.String)]
        public string Poster { get; set; }

        /// <summary>
        /// The schedule of the movie, represented as a dictionary with date and corresponding showtimes.
        /// It will be mapped to the "schedule" column in the MongoDB collection.
        /// </summary>
        [BsonElement("schedule")]
        [BsonRepresentation(BsonType.Array)]
        public Dictionary<string, List<string>> Schedule { get; set; }


        /// <summary>
        /// The age rating of the movie.
        /// It will be mapped to the "age" column in the MongoDB collection.
        /// </summary>
        [BsonElement("age")]
        [BsonRepresentation(BsonType.Int32)]
        public int Age { get; set; }

        /// <summary>
        /// The trailer URL of the movie.
        /// It will be mapped to the "trailer" column in the MongoDB collection.
        /// </summary>
        [BsonElement("trailer")]
        [BsonRepresentation(BsonType.String)]
        public string Trailer { get; set; }

        /// <summary>
        /// The name of the theater where the movie is being shown.
        /// It will be mapped to the "theater" column in the MongoDB collection.
        /// </summary>
        [BsonElement("theater")]
        [BsonRepresentation(BsonType.String)]
        public string TheaterName { get; set; }

        /// <summary>
        /// Constructor for creating a new instance of the Movie class.
        /// </summary>
        /// <param name="movieName">The name of the movie.</param>
        /// <param name="categories">The categories of the movie.</param>
        /// <param name="price">The price of the movie.</param>
        /// <param name="duration">The duration of the movie.</param>
        /// <param name="schedule">The schedule of the movie.</param>
        /// <param name="director">The director of the movie.</param>
        /// <param name="projectionType">The projection type of the movie.</param>
        /// <param name="poster">The URL of the movie poster.</param>
        /// <param name="age">The age rating of the movie.</param>
        /// <param name="trailer">The URL of the movie trailer.</param>
        /// <param name="movies">The MongoDB collection of movies.</param>
        public Movie(
            string movieName,
            List<string> categories,
            double price,
            string duration,
            Dictionary<string, List<string>> schedule,
            string director,
            string projectionType,
            string poster,
            int age,
            string trailer,
            IMongoCollection<Movie> movies)
        {
            Id = ObjectId.GenerateNewId().ToString(); // Generate a new ObjectId and assign it to the Id property
            MovieName = movieName;
            MovieCategories = categories;
            Price = price;
            Duration = duration;
            Schedule = schedule;
            Director = director;
            ProjectionType = projectionType;
            Poster = poster;
            Age = age;
            Trailer = trailer;
            th = new Theater(movies, schedule.First().Value);
            TheaterName = th.Name;
        }

    }
}
