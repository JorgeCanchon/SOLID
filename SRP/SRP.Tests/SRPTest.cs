using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SRP.Tests
{
    [TestClass]
    public class SRPTest
    {
        [TestMethod]
        public void ReturnsDefaultPolicyFromEmptyJsonString()
        {
            var inputJson = "{}";
            var serializer = new JsonPolicySerializer();

            var result = serializer.GetPolicyFromJsonString(inputJson);

            var policy = new Policy();
            Assert.ReferenceEquals(result, policy);
        }
    }
}
