using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoRentalSystem
{
    class Movie{
        private string name, rating, genre, description;
        private int status;

        public Movie(string name, string rating, string genre, int status, string description){
            name = this.name;
            rating = this.rating;
            genre = this.genre;
            status = this.status;
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