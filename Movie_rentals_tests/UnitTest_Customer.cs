using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movie_Rental_System;

namespace Movie_rentals_tests
{
    [TestClass]
    public class UnitTest_Customer
    {
        string test_FName = "Bob";
        string test_LName = "Thomas";
        string test_address = "10 Main Street";
        string test_phone = "8883336666";
        double test_balance = 0.00;
        DateTime test_DOB = new DateTime(1983,10,28);
        int test_CID = 0001;

        [TestMethod]
        public void TestCustomer(){
            Customer test_customer = new Customer(test_FName,test_LName,test_address,test_phone,test_balance,test_DOB,test_CID);
            Assert.AreEqual(test_FName, test_customer.getFName());
            Assert.AreEqual(test_LName, test_customer.getLName());
            Assert.AreEqual(test_address, test_customer.getAddress());
            Assert.AreEqual(test_phone, test_customer.getPhone());
            Assert.AreEqual(test_balance, test_customer.getBalance());
            Assert.AreEqual(test_CID, test_customer.getCID());
        }

        [TestMethod]
        public void TestFullName(){
            string test_fullName = test_FName + " " + test_LName;
            Customer test_customer = new Customer(test_FName,test_LName,test_address,test_phone,test_balance,test_DOB,test_CID);
            Assert.AreEqual(test_fullName, test_customer.fullName());
        }

        [TestMethod]
        public void TestChangeAddress(){
            Customer test_customer = new Customer(test_FName,test_LName,test_address,test_phone,test_balance,test_DOB,test_CID);
            string newAddress = "20 Test Road";
            test_customer.changeAddress(newAddress);
            Assert.AreEqual(newAddress, test_customer.getAddress());
        }

        [TestMethod]
        public void TestChangeBalance(){
            double[] test_balances = {-100,0,100};
            foreach(double balanceChange in test_balances){
                Customer test_customer = new Customer(test_FName,test_LName,test_address,test_phone,test_balance,test_DOB,test_CID);
                double currentBalance = test_customer.getBalance();
                test_customer.changeBalance(balanceChange);
                Assert.AreEqual((balanceChange + currentBalance), test_customer.getBalance());
            }
        }
    }
}
