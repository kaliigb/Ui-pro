using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


namespace Cinema.Model
{
    /// <summary>
    /// Represents a seat in the Cinema system.
    /// </summary>
    [Serializable]
    public class Seat
    {
        private static int num = 1;
        private static char letter = 'A';

        /// <summary>
        /// The seat number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// The seat row identifier.
        /// </summary>
        public string Row { get; set; }

        /// <summary>
        /// Indicates if the seat is occupied or not.
        /// </summary>
        public bool Occupied { get; set; }

        /// <summary>
        /// Constructor for creating a new instance of the Seat class.
        /// </summary>
        public Seat()
        {
            Number = num;
            Row = letter.ToString();
            Occupied = false;
            IncrementSeat();
        }

        /// <summary>
        /// Returns a formatted string representing the seat name (e.g., "A1").
        /// </summary>
        /// <returns>The formatted seat name.</returns>
        public string SeatNameFormat()
        {
            return Row + Convert.ToString(Number);
        }

        private void IncrementSeat()
        {
            num++;
            if (num > 5)
            {
                num = 1;
                IncrementLetter();
            }
        }

        private void IncrementLetter()
        {
            letter++;
            if (letter > 'D')
            {
                letter = 'A';
            }
        }

        /// <summary>
        /// Returns the name of the seat in the format "RowNumber" (e.g., "A1").
        /// </summary>
        /// <returns>The name of the seat in the format "RowNumber".</returns>
        public string GetName()
        {
            return $"{Row}{Number}";
        }


        /// <summary>
        /// Overrides the ToString() method to provide a string representation of the Seat object.
        /// </summary>
        /// <returns>A string representation of the Seat object.</returns>
        public override string ToString()
        {
            return $"Number: {Number}\nRow: {Row}";
        }
    }
}
