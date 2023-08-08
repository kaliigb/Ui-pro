using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Cinema.Model
{
    /// <summary>
    /// Represents a customer in the Cinema system.
    /// </summary>
    [Serializable]
    public class Customer
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// The unique identifier of the customer.
        /// It will be mapped to the "customerID" column in the MongoDB collection.
        /// </summary>
        [BsonElement("customerID")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string CustomerID { get; set; }

        /// <summary>
        /// The full name of the customer.
        /// It will be mapped to the "customerFullName" column in the MongoDB collection.
        /// </summary>
        [BsonElement("customerFullName")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string CustomerName { get; set; }

        /// <summary>
        /// The phone number of the customer.
        /// It will be mapped to the "phoneNumber" column in the MongoDB collection.
        /// </summary>
        [BsonElement("PhoneNumber")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="customerID">The unique identifier of the customer.</param>
        /// <param name="fullName">The full name of the customer.</param>
        /// <param name="phoneNumber">The phone number of the customer.</param>
        public Customer(string customerID, string fullName, string phoneNumber)
        {
            Id = ObjectId.GenerateNewId().ToString(); // Generate a new ObjectId and assign it to the Id property
            CustomerID = customerID;
            CustomerName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}


