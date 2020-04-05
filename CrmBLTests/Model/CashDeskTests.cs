using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmModel.Model.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        [TestMethod()]
        public void ServeCustomerTest()
        {
            //Arrange
            CrmContext crm = new CrmContext();
            var Seller = new Seller()
            {
                Name = Guid.NewGuid().ToString(),
                Surname = Guid.NewGuid().ToString(),
                Lastname = Guid.NewGuid().ToString(),
                Age = 23
            };

            var Customer = new Customer()
            {
                Name = Guid.NewGuid().ToString(),
                Surname = Guid.NewGuid().ToString(),
                Age = 23
            };

            var Cart = new Cart(Customer);
            var cashDesk = new CashDesk(10, Seller, crm);
            cashDesk.IsModel = true;


            //Act
            cashDesk.Enqueue(Cart);
            cashDesk.ServeCustomer();

            //Assert
            Assert.AreEqual(Seller.Name, cashDesk.Seller.Name);
        }

    }
}