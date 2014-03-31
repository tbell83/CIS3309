using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customer;
using System.Collections;

namespace Movie_rentals_tests
{
    [TestClass]
    public class UnitTest_MovieRentalSystem
    {
        string test_movie1 = "Blade Runner;R;Action/SciFi;0;In a world with something, unicron at the end";
        string test_movie2 = "Terminator;R;Action;9999;Quirky robot galavanting through time.";
        string test_customer1 = "Bob;Hope;10 Main Street;9993336666;0.00;1983/10/28;9988";
        string test_customer2 = "Tina;Roberts;82 Street Lane;8884442222;57.00;1950/1/31;9977";

        [TestMethod]
        public void TestAddMovie(){
            MovieRentalSystem MRS = new MovieRentalSystem();
            MRS.addMovie(test_movie1);
            Assert.AreEqual("Blade Runner", MRS.getMovie(0).getName());
        }

        [TestMethod]
        public void TestAddCustomer(){
            MovieRentalSystem MRS = new MovieRentalSystem();
            MRS.addCustomer(test_customer1);
            Assert.AreEqual(9988, MRS.getCustomer(0).getCID());
        }

        [TestMethod]
        public void TestFindCustomer(){
            MovieRentalSystem MRS = new MovieRentalSystem();
            MRS.addCustomer(test_customer1);
            MRS.addCustomer(test_customer2);
            ArrayList results = new ArrayList();
            results = MRS.findCustomer("Bob");
            Assert.AreEqual("Bob", MRS.getCustomer(Convert.ToInt16(results[0])).getFName());
        }

        [TestMethod]
        public void TestFindMovie(){
            Assert.Fail();
        }
    }
}