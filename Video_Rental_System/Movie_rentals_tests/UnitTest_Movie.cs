using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movie_Rental_System;

namespace Movie_rentals_tests
{
    [TestClass]
    public class UnitTest_Movie
    {
        string test_name = "Terminator";
        string test_rating = "R";
        string test_genre = "Romantic Comedy";
        int test_CID = 9999;
        int test_status = 0;
        string test_description = "A quirky robot travels back in time to find the woman of his dreams";

        [TestMethod]
        public void TestMovie(){
            Movie test_movie = new Movie(test_name, test_rating, test_genre, test_status, test_description);
            Assert.AreEqual(test_name, test_movie.getName());
            Assert.AreEqual(test_status, test_movie.getStatus());
            Assert.AreEqual(test_rating, test_movie.getRating());
            Assert.AreEqual(test_genre, test_movie.getGenre());
            Assert.AreEqual(test_description, test_movie.getDescription());
        }

        [TestMethod]
        public void TestCheckIn(){
            Movie test_movie = new Movie(test_name, test_rating, test_genre, test_status, test_description);
            test_movie.CheckIn();
            Assert.AreEqual(0, test_movie.getStatus());
        }
        
        [TestMethod]
        public void TestCheckOut_whenCheckedOut(){
            Movie test_movie = new Movie(test_name, test_rating, test_genre, test_status, test_description);
            Assert.AreEqual(true, test_movie.CheckOut(test_CID));
            Assert.AreEqual(test_CID, test_movie.getStatus());
        }
        
        [TestMethod]
        public void TestCheckOut_whenCheckedIn(){
            Movie test_movie = new Movie(test_name, test_rating, test_genre, test_CID, test_description);
            Assert.AreEqual(false, test_movie.CheckOut(test_CID));
        }
    }
}