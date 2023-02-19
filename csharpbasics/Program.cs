// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("amisha jha ");
// Console.WriteLine("BE IT final year");


// Console.ReadLine();


using System;
using System.Collections;

namespace HelloWorld
{

   //delegate int myDel (int x,int y);

    class Program
    {   
           /*string? color;
           int maxSpeed;*/
       /*static  void myfunc(int a,int b){
            Console.WriteLine(a+b);
        }

       static void MyMethod(string child1, string child2, string child3) 
      {
              Console.WriteLine("The youngest child is: " + child3);
       
       }*/


       /*public static int add(int x,int y){
           return x+y;
       }*/


       /*public static int multiply(int x,int y){
           return x*y;
       }*/
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            /*string name = "amisha Jha";
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
          Console.WriteLine("Hello " + name);
          Console.WriteLine("Hello " + myNum);
          Console.WriteLine("Hello " + myDoubleNum);
          Console.WriteLine("Hello " + myLetter);
          Console.WriteLine("Hello " + myBool);*/

            //if you dont want others to overwrite your variable then use const
            //const int car = 11;
            //Console.WriteLine(car);
            //Implicit casting is done automatically when passing a smaller size type to a larger size type:
            /*int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);*/
            //int ans = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(ans);

            //Console.WriteLine(Math.Max(2,33));
            //Console.WriteLine(Math.Round(9.99));
            //string interpolation
            /* string firstName = "John";
             string lastName = "Doe";
             string name = $"My full name is: {firstName} {lastName}";
             Console.WriteLine(name);*/
            /*int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }*/

            /*int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());*/  // returns the sum of elements

           /* int a = 5;
            int b = 6;

            myfunc(a,b);*/

            //MyMethod(child3: "John", child1: "Liam", child2: "Liam");
               /*Program myObj = new Program();
               myObj.color = "red";
              myObj.maxSpeed = 200;
              Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);*/

            //arraylist
            //value stored in generic collection are of object type

            /*ArrayList al = new ArrayList();
            al.Add(33);
            al.Add(44);
            al.Add(12);
            Console.WriteLine("Capacity: {0} ", al.Capacity);
             al.Sort();
              foreach (int i in al) {
            Console.Write(i + " ");
         }*/

            
         //hashtable
         /*Hashtable ht = new Hashtable();
         ht.Add("001","amisha jha");
         ht.Add("002","Rashi Singh");
         ht.Add("003","kalyani Muske");
         if(ht.ContainsValue("amisha jha")){
            Console.WriteLine("amisha jha is present in the hashtable");
         }

         else {
            ht.Add("008","amisha jha");

         }

         //get a collection of the keys
            ICollection key = ht.Keys;

         foreach (string k in key){
            Console.WriteLine(k+":" +ht[k]);
         }*/
         
         //sortedlist
         /*SortedList sl = new SortedList();
         sl.Add("001", "amisha");
         sl.Add("002","mina");
         sl.Add("003","harsh");
         
         ICollection key = sl.Keys;

        foreach (string k in key) {
            Console.WriteLine(k + ": " + sl[k]);
         }*/

        //Stack
        Stack st = new Stack();
        st.Push("learning c#");
        st.Push("let us c");
        foreach (string c in st) {
            Console.WriteLine(c + " ");
         }

         Console.WriteLine("Book removed"+st.Pop()) ;

       //queue
      /* Queue q = new Queue();
         
         q.Enqueue('A');
         q.Enqueue('M');
         q.Enqueue('G');
         q.Enqueue('W');

         Console.WriteLine("Current queue: ");
         foreach (char c in q) Console.Write(c + " ");

         char ch = (char)q.Dequeue();
         Console.WriteLine("The removed value: {0}", ch);*/


         //delegate is the reference type variable that holds the reference to a method
         //used for implementing callback functions
 
       /*myDel del = new myDel(add);
       int result = del(10,30);
       Console.WriteLine(result);
       del = multiply;
       result = del(10,30);
       Console.WriteLine(result);*/

 


       //sum of even numbers in the array
      /* int n  = Convert.ToInt32(Console.ReadLine());
       int [] arr = new int[n];
       int total = 0;
       for(int i = 0;i<n;i++){
         arr[i] = Convert.ToInt32(Console.ReadLine());

       }

       for(int i = 0;i<n;i++){
         if(arr[i]%2==0){
            total = total + arr[i];
         }
       


        }

         Console.WriteLine(total);*/
    }
    }
}
//csharp is used to make desktop applications, web applications, mobile applications, games and much more.