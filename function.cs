using System;

public class Function
{
    //parent class
    class Program{
        //mendefinisikan sebuah function
        public string Show(string pesan){
            Console.WriteLine("ini pesan yang akan muncul didalam function ");
            return pesan;
        }
          public static void Main(string[] args)
    {
        Program program = new Program();
        string pesan = program.Show("Gabriel");
        Console.WriteLine ("Hello "+pesan);
    }
  }
 }