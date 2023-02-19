

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program{

        static void Main(string[] args){
            string acnam = "",bnam = "";
            Payee pay = new Payee();
            Console.WriteLine("Enter the name");
            pay.Name = Console.ReadLine();
            Console.WriteLine("Enter the bank name");
            pay.BankName = Console.ReadLine();
            Console.WriteLine("Enter the ifsc code");
            pay.ifscCode = Console.ReadLine();
            Console.WriteLine("Enter the aadhar id");
            pay.AadharId = Console.ReadLine();
            Console.WriteLine("Enter the amount");
            pay.Amount = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("1) Pay using name,bankname and IFSC code \n 2) Pay using aadharid and IFSC code "+"\n Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            if(ch==1||ch==2){
                string ifsc="",py="";
                if(ch==1){
                     Console.WriteLine("Enter the payee account name"); 
                     acnam = Console.ReadLine(); 
                     Console.WriteLine("Enter their bankname"); 
                      bnam = Console.ReadLine();

                }

                else {
                    Console.WriteLine("Enter the payee aadhar id"); 
                     py = Console.ReadLine();

                }

                Console.WriteLine("Enter their IFSC Code"); 
                 ifsc = Console.ReadLine();

                 Console.WriteLine("Enter the amount to deposite"); 
                 int depos = int.Parse(Console.ReadLine()); 

                 if(ch==1){
                    if(pay.AddPayee(acnam,bnam,ifsc,depos))
                       Console.WriteLine("Amount deposited successfully\nCurrent balance of {1} account is {0}", depos,acnam);
                    
                    else
                         Console.WriteLine("Payee not found from given match"); 
                    
                 }

                 else 
                 {
                    if(pay.AddPayee(py,ifsc,depos))
                       Console.WriteLine("Amount deposited successfully\nCurrent balance of {1} account is {0}", depos,py);
                    
                    else
                         Console.WriteLine("Payee not found from given match");
                 }
            }
            

        }


    }




    class Payee
    {
        string _name ,_bankName,_ifscCode,_aadharId;
        double _amount;

        public string AadharId{
            get { return _aadharId; }
            set { _aadharId = value; }

        }

        public string ifscCode
        {
            get{return _ifscCode;}
            set{_ifscCode = value;}

        }

        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }

        }

        public bool AddPayee(string name ,string bankname,string ifsccode,double amount ){
            if(_name==name && _bankName==bankname && _ifscCode==ifsccode ){
                return true;
            }
            else{
                return false;
            }
        }
        public bool AddPayee(string  adhar,string ifsc,double amount){
            if(_aadharId==adhar && _ifscCode==ifsc){
                return true;
            }
            else{
                return false;
            }
        }

    }
}
