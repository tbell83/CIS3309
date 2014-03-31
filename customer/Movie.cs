using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer{
    public class Movie{
        private string name, rating, genre, description;
        private int status;

        public Movie(string name, string rating, string genre, int status, string description){
            this.name = name;
            this.rating = rating;
            this.genre = genre;
            this.status = status;
            this.description = description;
        }

        public string getName(){
            return name;
        }

        public int getStatus(){
            return status;
        }

        public string getRating(){
            return rating;
        }

        public string getGenre(){
            return genre;
        }

        public string getDescription(){
            return description;
        }

        public void CheckIn(){
            status = 0;
        }

        public bool CheckOut(int CID){
            if (status != 0){
                return false;
            }else{
                status = CID;
                return true;
            }
        }
    }
}