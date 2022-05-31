using System;

class Conversion{
    public static void Main(){
        int n1 = 7;
        float f1 = 3.25F;
        bool flag = false;

        // Int to string
        string n1_str = Convert.ToString(n1);

        // float to int
        int f1_int = Convert.ToInt32(f1);

        // bool to string
        string flag_str = Convert.ToString(flag);

        // display data
        Console.WriteLine("Before conversion\t After conversion");
        Console.WriteLine("Int: "+ n1 + "\t\t\t String: "+ n1_str);
        Console.WriteLine("Float: "+ f1 + "\t\t Int: "+ f1_int);
        Console.WriteLine("Bool: "+ flag + "\t\t String: "+ flag_str);
    }
}