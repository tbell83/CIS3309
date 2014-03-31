using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer{
    class Movie{
        private string name, rating, genre, description;
        private int status;

        public Movie(string name, string rating, string genre, int status, string description){
            this.name = name;
            this.rating = rating;
            this.genre = genre;
            this.status = status;
        }

        public string Name(){
            return name;
        }

        public int Status(){
            return status;
        }

        public string Rating(){
            return rating;
        }

        public string Genre(){
            return genre;
        }

        public void CheckIn(){
            status = 1;
        }

        public void CheckOut(string CID){
            status = 0;
        }
    }
}