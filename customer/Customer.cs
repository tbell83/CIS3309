using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MovieRentalSystem
{
    public class Customer
    {
        private string FName, LName, address, phone;
        private double balance;
        private int CID;
        private DateTime DOB;

        public Customer(string FName, string LName, string address, string phone, double balance, DateTime DOB, int CID){
            this.FName = FName;
            this.LName = LName;
            this.address = address;
            this.phone = phone;
            this.balance = balance;
            this.DOB = DOB;
            this.CID = CID;
        }

        public double getBalance(){
            return balance;
        }

        public string fullName(){
            return string.Concat(FName + " " + LName);
        }

        public string getFName(){
            return FName;
        }

        public string getLName(){
            return LName;
        }

        public string getPhone(){
            return phone;
        }

        public int getCID(){
            return CID;
        }

        public string getAddress(){
            return address;
        }

        public void changeAddress(string address){
            this.address = address;
        }

        public void changeBalance(double change){
            balance = balance + change;
        }
    }
}