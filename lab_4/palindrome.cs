// WAP in C# to check whether a number is palindrome or not.

using System;
public class Palindrome{
    public static void Main(){
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int n = num, plndrm = 0;
        while(n > 0){
            int rem = n % 10;
            n = n / 10;
            plndrm = plndrm*10 + rem;
        }

        if (num == plndrm)
            Console.WriteLine(num + " is palindrome.");
        
        else
            Console.WriteLine(num + " is not palindrome.");
    }
}