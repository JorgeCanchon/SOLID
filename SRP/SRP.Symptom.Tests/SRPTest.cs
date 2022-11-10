using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;

namespace SRP.Symptom.Tests
{
    [TestClass]
    public class SRPTest
    {
        [TestMethod]
        public void ReturnsRatingOf10000For200000LandPolicy()
        {
            var policy = new Policy { Type = PolicyType.Land, BondAmount = 200000, Valuation = 200000 };
            string json = JsonConvert.SerializeObject(policy);
            File.WriteAllText("policy.json", json);

            var engine = new RatingEngine();
            engine.Rate();
            var result = engine.Rating;
            Assert.AreEqual(10000, result);
        }
    }
}
