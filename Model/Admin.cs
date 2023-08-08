using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cinema.Model
{
    /// <summary>
    /// Represents an Admin in the Cinema system.
    /// </summary>
    [Serializable]
    public class Admin
    {
        // The unique identifier of the Admin.
        // It will be mapped to the "_id" column in the MongoDB collection.
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        // The unique identifier of the Admin.
        // It will be mapped to the "AdminID" column in the MongoDB collection.
        [BsonElement("_AdminID"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string AdminID { get; set; }

        // The name of the Admin.
        // It will be mapped to the "AdminName" column in the MongoDB collection.
        [BsonElement("_AdminName"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string AdminName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin"/> class.
        /// </summary>
        /// <param name="adminID">The unique identifier of the Admin.</param>
        /// <param name="adminName">The name of the Admin.</param>
        public Admin(string adminID, string adminName)
        {
            this.AdminID = adminID;
            this.AdminName = adminName;
        }
    }
}
