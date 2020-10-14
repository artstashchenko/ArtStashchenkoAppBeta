using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Artstashchenko.PaymentsAppBeta.Models
{
    public class Counters
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("Gas")]
        [Required]
        public string Gas { get; set; }

        [BsonElement("Water")]
        [Required]
        public string Water { get; set; }

        [BsonElement("Electricity")]
        [Required]
        public string Electricity { get; set; }

        [BsonElement("OSMD")]
        [Required]
        public string OSMD { get; set; }

        [BsonElement("JEK")]
        [Required]
        public string JEK { get; set; }

        [BsonElement("Trash")]
        [Required]
        public string Trash {get;set;}

        [BsonElement("TV")]
        [Required]
        public string TV {get;set;}

        [BsonElement("Internet")]
        [Required]
        public string Internet {get;set;}
    }
}