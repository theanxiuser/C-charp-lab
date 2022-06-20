// WAP in C# to find largest number in an 1D array

using System;
public class Largest{
    public static void Main(){
        int [] numArray = new int [10]{34, 54, 14, 65, 45, 88, 22, 81, 61, 71};
        int large = numArray[0];

        // start comparing
        for(int i=1; i<10; i++){
            if (large < numArray[i])
                large = numArray[i];
        }

        Console.WriteLine("Largest number in array = "+ large);
    }
}