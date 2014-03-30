using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace customer
{
    public class Customer
    {
        private string FName, LName, address, phone, CID;
        private double balance;
        private DateTime DOB;

        public Customer(string FName, string LName, string address, string phone, double balance, DateTime DOB, string CID){
            FName = this.FName;
            LName = this.LName;
            address = this.address;
            phone = this.phone;
            balance = this.balance;
            DOB = this.DOB;
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

        public string getCID(){
            return CID;
        }

        public string getAddress(){
            return address;
        }

        public void changeAddress(string address){
            address = this.address;
        }

        public void changeBalance(double change){
            balance = balance + change;
        }
    }
}