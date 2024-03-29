﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using File_Reader;

namespace Movie_Rental_System{
    public class MovieRentalSystem{
        List<Movie> movies = new List<Movie>();
        List<Customer> customers = new List<Customer>();

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
            int CID = Convert.ToInt16(user[6]);
            Customer customer = new Customer(FName, LName, address, phone, balance, DOB, CID);
            customers.Add(customer);
        }

        public void writeOut(string movie_db, string customer_db){
            FileReader file = new FileReader();
            List<string> movies_to_write = new List<string>();
            List<string> customers_to_write = new List<string>();
            foreach(Movie item in movies){
                 movies_to_write.Add(item.getName() + ";"+ item.getRating() + ";" + item.getGenre() + ";" + item.getStatus() + ";" + item.getDescription());
            }
            foreach(Customer item in customers){
                customers_to_write.Add(item.getFName() + ";" + item.getLName() + ";" + item.getAddress() + ";" + item.getPhone() + ";" + item.getBalance() + ";" + item.getDOB() + ";" + item.getCID());
            }
            file.writeFile(movies_to_write, movie_db);
            file.writeFile(customers_to_write, customer_db);
        }

        public Customer getCustomer(int index){
            return customers[index];
        }

        public Movie getMovie(int index){
            return movies[index];
        }

        public string listMovie(int index){
            return movies[index].ToString();
        }
        public string listCustomer(int index){
            return customers[index].ToString();
        }

        public List<int> findCustomer(string search){
            List<int> results = new List<int>();
            foreach(Customer item in customers){
                if (String.Compare(item.fullName(), search, true) == 0){
                    results.Add(customers.IndexOf(item));
                } else if (String.Compare(item.getFName(), search, true) == 0){
                    results.Add(customers.IndexOf(item));
                } else if (String.Compare(item.getLName(), search, true) == 0){
                    results.Add(customers.IndexOf(item));
                } else if (String.Compare(item.getPhone(), search) == 0){
                    results.Add(customers.IndexOf(item));
                } else if (item.getAddress().ToUpper().Contains(search.ToUpper())){
                    results.Add(customers.IndexOf(item));
                }
            }
            return results;
        }

        public List<int> findMovie(string search){
            search = search.ToUpper();
            List<int> results = new List<int>();
            foreach(Movie item in movies){
                if (item.getName().ToUpper().Contains(search)){
                    results.Add(movies.IndexOf(item));
                } else if (String.Compare(item.getRating(), search, true) == 0){
                    results.Add(movies.IndexOf(item));
                } else if (item.getGenre().ToUpper().Contains(search)){
                    results.Add(movies.IndexOf(item));
                }else if(item.getName().Contains(search)){
                    results.Add(movies.IndexOf(item));
                }else if(item.getDescription().Contains(search)){
                    results.Add(movies.IndexOf(item));
                }
            }
            return results;
        }

        public void removeCustomer(int index){
            customers.RemoveAt(index);
        }

        public void removeMovie(int index){
            movies.RemoveAt(index);
        }
    }
}