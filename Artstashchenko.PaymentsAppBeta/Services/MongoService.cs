using Artstashchenko.PaymentsAppBeta.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Artstashchenko.PaymentsAppBeta.Services
{
    public class MongoService
    {
        private readonly IMongoCollection<Counters> counters;

        public MongoService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("CountersPaymentDb"));
            IMongoDatabase database = client.GetDatabase("CountersPaymentDb");
            counters = database.GetCollection<Counters>("Payments");
        }

        public List<Counters> Get()
        {
            return counters.Find(count => true).ToList();
        }

        public Counters Get(string id)
        {
            return counters.Find(count => count.Id == id).FirstOrDefault();
        }

        public Counters Create(Counters count)
        {
            counters.InsertOne(count);
            return count;
        }

        public void Update(string id, Counters countIn)
        {
            counters.ReplaceOne(car => car.Id == id, countIn);
        }

        public void Remove(Counters countIn)
        {
            counters.DeleteOne(count => count.Id == countIn.Id);
        }

        public void Remove(string id)
        {
            counters.DeleteOne(count => count.Id == id);
        }
    }
}