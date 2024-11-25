using System;
using System.Transactions;


namespace MyApp
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            //1 Done
        //     string name = "Abdulmajeed";
        //     int age = 23;
        //     double favoriteNumber = 7.7d;
        // Console.WriteLine($"Hello, my name is {name}, I am {age} years old, and my favorite number is {favoriteNumber}.");

            //2 ):
        // int[] Array = [0, 0, 0, 0, 0];
        //     Console.WriteLine("Enter five numbers: ");
        // for(int i =1; i <= 5; i++){
                
        //         int userInput = int.Parse(Console.ReadLine());
        //         int j = 0;
        //         j ++;
        //         int push = userInput + Array[j] ;
        // }
        // foreach(int num in Array){
        //     Console.WriteLine(num);
        // }


            //3 done
        // void IsEven(int number){
        //     int Isnumber = number %2;
        //     if(Isnumber == 0){
        //         Console.WriteLine($"number {number} Is Even");
        //     }
        //     else{
        //         Console.WriteLine($"number {number} is Odd");
        //     }
        // }
        // IsEven(3);

            //4 Done
        // Console.Write("Enter you age: ");
        // int age = int.Parse(Console.ReadLine());

        // if(age < 12)
        // {
        //     Console.WriteLine("You are a child");
        // }
        // else if(age >=13 && age <=17)
        // {
        //     Console.WriteLine("You are a teenager");
        // }
        // else{
        //     Console.WriteLine("You are an adult");
        // }

                //5 done
        // Console.Write("Enter enter a number between 1 and 12: ");
        // int date = int.Parse(Console.ReadLine());

        // switch(date){
        //     case 1:
        //         Console.WriteLine("Month: 1");
        //     break;
        //     case 2:
        //         Console.WriteLine("Month: 2");
        //     break;
        //     case 3:
        //         Console.WriteLine("Month: 3");
        //     break;
        //     case 4:
        //         Console.WriteLine("Month: 4");
        //     break;
        //     case 5:
        //         Console.WriteLine("Month: 5");
        //     break;
        //     case 6:
        //         Console.WriteLine("Month: 6");
        //     break;
        //     case 7:
        //         Console.WriteLine("Month: 7");
        //     break;
        //     case 8:
        //         Console.WriteLine("Month: 8");
        //     break;
        //     case 9:
        //         Console.WriteLine("Month: 9");
        //     break;
        //     case 10:
        //         Console.WriteLine("Month: 10");
        //     break;
        //     case 11:
        //         Console.WriteLine("Month: 11");
        //     break;
        //     case 12:
        //         Console.WriteLine("Month: 12");
        //     break;
        //     default:
        //         Console.WriteLine("Error!: You must enter form 1 to 12 only.");
        //     break;
        // }


        // string[] array2 = ["HiToYou", "Abdulmajeed", "2.99"];
        // Book.PrintDetails;
        }
    }
}

public  class Book{

    // String Title;
    // String Author;
    // double Price;

    string PrintDetails(String Title, String Author, double Price){

          Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
        return Title;
        
    }
    

}