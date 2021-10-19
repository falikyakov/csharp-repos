using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoCsharpCorner.Models
{
    public class CarModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("CarName")]
        public string CarName { get; set; }

        [BsonElement("Color")]
        public string Color { get; set; }

        [BsonElement("Price")]
        public int Price  { get; set; }

        [BsonElement("EngineNo")]
        public string EngineNo { get; set; }
        [BsonElement("RegistrationDate")]
        public string RegistrationDate { get; set; }
        [BsonElement("ChassisNo")]
        public string ChassisNo { get; set; } 
    }
}