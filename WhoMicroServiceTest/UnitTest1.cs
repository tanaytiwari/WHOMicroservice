using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace WhoMicroServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var paymentServiceMock = new Mock<IPaymentService>();
        }
    }
}
