using System;

public class Looping
{
     public static void Main(string[] args)
    {
       String[] nama_murid = {"andi","junaedi","Gibran"};
	
       for(int i=0;i<3;i++){
	 Console.WriteLine(String.Format("Index: "+i));
	}
	foreach(String nama in nama_murid){
	 Console.WriteLine(String.Format("Nama: "+nama));
	}
  }
}