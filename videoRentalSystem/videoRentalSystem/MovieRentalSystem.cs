using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace videoRentalSystem
{
    class MovieRentalSystem
    {
        ArrayList movies = new ArrayList();
        ArrayList customers = new ArrayList();

        public MovieRentalSystem(){}

        public void addMovie(string input){
            string[] film = input.Split(';');
            string name = film[0];
            string rating = film[1];
            string genre = film[2];
            int status = Convert.ToInt16(film[3]);
            string description = film[4];
            Movie movie = new Movie(name, rating, genre, status, description);
            movies.Add(movie);
        }

        public void addCustomer(string input){
            string[] user = input.Split(';');
            string FName = user[0];
            string LName = user[1];
            string address = user[2];
            string phone = user[3];
            double balance = Convert.ToDouble(user[4]);
            DateTime DOB = Convert.ToDateTime(user[5]);
            string CID = user[6];
            Customer customer = new Customer(FName, LName, address, phone, balance, DOB, CID);
            customers.Add(customer);
        }

        public ArrayList findCustomer(string search){
            ArrayList results = new ArrayList();
            search = search.ToUpper();
            foreach(Customer item in customers){
                if (String.Compare(item.fullName().ToUpper(), search.ToUpper()) == 0){
                    results.Add(item);
                } else if(String.Compare(item.getFName().ToUpper(), search.ToUpper()) == 0){
                    results.Add(item);
                } else if(String.Compare(item.getLName().ToUpper(), search.ToUpper()) == 0){
                    results.Add(item);
                } else if (String.Compare(item.getPhone(), search) == 0){
                    results.Add(item);
                } else if (String.Compare(item.getAddress().ToUpper(), search.ToUpper()) == 0){
                    results.Add(item);
                }
            }
            return results;
        }

        public ArrayList findMovie(string search){
            ArrayList results = new ArrayList();
            search = search.ToUpper();
            foreach(Movie item in movies){
                if (String.Compare(item.Name().ToUpper(), search) == 0){
                    results.Add(item);
                }else if(String.Compare(item.Rating().ToUpper(), search) == 0 ){
                    results.Add(item);
                }else if(String.Compare(item.Genre().ToUpper(), search) == 0){
                    results.Add(item);
                }
            }
            return results;
        }
    }
}