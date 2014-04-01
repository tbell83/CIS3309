using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customer;
using System.Collections;
using System.Collections.Generic;

namespace Movie_rentals_tests
{
    [TestClass]
    public class UnitTest_MovieRentalSystem
    {
        string test_movie1 = "Blade Runner;R;Action/SciFi;0;In a world with something, unicron at the end";
        string test_movie2 = "Terminator;R;Action;9999;Quirky robot galavanting through time.";
        string test_movie3 = "Terminator II: Judgement Day;R;Action;9999;Quirky robot galavanting through time, having a ball.";
        string test_customer1 = "Bob;Hope;10 Main Street;9993336666;0.00;1983/10/28;9988";
        string test_customer2 = "Bob;Barker;10 Road Street;888666444;0.00;1980/1/1;9938";
        string test_customer3 = "Tina;Roberts;82 Street Lane;8884442222;57.00;1950/1/31;9977";

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
            MRS.addCustomer(test_customer3);
            string[] test_names = {"Bob","BOB","bob","Hope","Barker","Bob Barker"};
            foreach(string name in test_names){
                List<int> results = MRS.findCustomer(name);
                foreach(int item in results){
                    Assert.AreEqual("Bob", MRS.getCustomer(item).getFName());
                }
            }
        }

        [TestMethod]
        public void TestFindMovie(){
            MovieRentalSystem MRS = new MovieRentalSystem();
            MRS.addMovie(test_movie1);
            MRS.addMovie(test_movie2);
            MRS.addMovie(test_movie3);
            List<int> results = MRS.findMovie("Terminator");
            foreach(int item in results){
                Assert.IsTrue(MRS.getMovie(item).getName().Contains("Terminator"));
            }
        }

        [TestMethod]
        public void TestRemoveCustomer(){
            MovieRentalSystem MRS = new MovieRentalSystem();
            MRS.addCustomer(test_customer1);
            MRS.addCustomer(test_customer2);
            MRS.addCustomer(test_customer3);
            List<int> results = MRS.findCustomer("Bob");
            results.ForEach(delegate(int item) { MRS.removeCustomer(item); });
        }

        [TestMethod]
        public void TestRemoveMovie(){
            MovieRentalSystem MRS = new MovieRentalSystem();
            MRS.addMovie(test_movie1);
            MRS.addMovie(test_movie2);
            MRS.addMovie(test_movie3);
            List<int> results = MRS.findMovie("Blade Runner");
            results.ForEach(delegate(int item) { MRS.removeMovie(item); });
        }
    }
}