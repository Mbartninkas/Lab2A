using Lab1A.Data;
using Lab1A.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DealershipTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ATestSuccessGet()
        {
            Dealership dealership = new Dealership();
            dealership.Email = "Michael@Michael.com";
            dealership.Name = "Michael";
            dealership.Phone = "9012421";
            DealershipMgr.Dealerships.Add(dealership);
            var result = DealershipMgr.Get(0);
            Assert.AreEqual(result, dealership);
        }
        [TestMethod]
        public void BTestforFailGet()
        {
            Assert.IsNull(DealershipMgr.Get(1));
        }
        [TestMethod]
        public void DTestFailPost()
        {
            Dealership dealership1 = new Dealership();
            dealership1.Email = "Michael@Mic123123123123hael.com";

            DealershipMgr.Post(dealership1);
            Assert.IsNull(DealershipMgr.Get(2));
        }
        [TestMethod]
        public void CTestSuccessPost()
        {
            Dealership dealership = new Dealership();
            dealership.Email = "Michael@Michael.com";
            dealership.Name = "Michael";
            dealership.Phone = "9012421";

            DealershipMgr.Post(dealership);
            var result1 = DealershipMgr.Get(1);
            Assert.AreEqual(result1, dealership);
        }

    }
}
