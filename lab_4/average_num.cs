// WAP in C# to find average number in an 1D array

using System;
public class Average{
    public static void Main(){
        int [] numArray = new int [10]{34, 54, 14, 65, 45, 88, 22, 81, 61, 71};
        float sum =0;

        // add all nums and divide by length of array
        for(int i=0; i<10; i++)
            sum += numArray[i];

        Console.WriteLine("Average number of array = "+ sum/10);
    }
}