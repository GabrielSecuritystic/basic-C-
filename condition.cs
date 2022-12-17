using System;

public class Condition
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Masukan Nama: ");
        String nama= "Gabriel";
        nama = Console.ReadLine();
        if(nama !="Gabriel"){
             Console.WriteLine("Nama yang anda masukan salah ");
        }else{
             Console.WriteLine ("Hallo " + nama);
        }
    }
}