using System;

class LeapYear{
    public static void Main(){

        // run four times
        int n = 4;
        while(n>0){
            // get year
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            
            // check if leap or not
            if((year%100 == 0 && year%400 == 0) || (year%100 != 0 && year%4 == 0)){
                Console.WriteLine(year + " is leap year.");
            }
            else{
                Console.WriteLine(year + " is not leap year.");
            }
            n--;
        }
        
    }
}