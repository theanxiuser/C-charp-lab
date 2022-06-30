using System;

class SortArray{
    public static void Main(){
        
        int[] arrya = new int[10]{10, 2, 4, 23, 32, 4, 8, 54, 2, 1};
       
        Console.WriteLine("Unsorted array:");
        for(int i=0; i<arrya.Length; i++)
            Console.Write(arrya[i] + " ");
 
        for(int i=0; i<arrya.Length-1; i++){
            for(int j=i+1; j<arrya.Length; j++){
                if(arrya[i] > arrya[j]){
                    int tmp = arrya[i];
                    arrya[i] = arrya[j];
                    arrya[j] = tmp;
                }
            }
        }
        Console.WriteLine("\nSorted array:");
        for(int i=0; i<arrya.Length; i++)
            Console.Write(arrya[i] + " ");
        Console.WriteLine("");
    }
}
