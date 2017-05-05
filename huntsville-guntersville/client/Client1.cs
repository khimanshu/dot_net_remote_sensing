// Client.cs 
using System;
using System.Runtime.Remoting;

public class Client1{

   public static void Main(){
	   Console.WriteLine("Enter 1 for Guntersville Server and 2 for Lake Lanier server");
	   int p = Convert.ToInt32(Console.ReadLine());
	   if(p==1)
	   {
		   Console.WriteLine("Connected to Guntersville Lake");
		   RemotingConfiguration.Configure("guntersville.config");
	   }
	   if(p==2)
	   {
		  Console.WriteLine("Connected to Lake Lanier");
		   RemotingConfiguration.Configure("Lanier.config"); 
	   }
	   
     
      RemotableType remoteObject = new RemotableType();
	  Console.WriteLine("Enter 1 for Water   2 for Air    3 for Temperature");
	  int y = Convert.ToInt32(Console.ReadLine());
	  
	  if(y==1)
	  {
	  Console.WriteLine("Enter 1 for N     2 for S     3 for E   4 for W     water quality");
	  int x = Convert.ToInt32(Console.ReadLine());
	  if(x==1)
			  Console.WriteLine(remoteObject.WaterNorth());
		  else if(x==2)
			  Console.WriteLine(remoteObject.WaterSouth());
		  else if(x==3)
			  Console.WriteLine(remoteObject.WaterEast());
		  else if(x==4)
			  Console.WriteLine(remoteObject.WaterWest());
			else
				Console.WriteLine("wrong input");
	  }
	  else if(y==2)
	  Console.WriteLine(remoteObject.Air());
  else if(y==3)
	  Console.WriteLine(remoteObject.Temperature());
  else
	  Console.WriteLine("invalid Entry");
	  Console.ReadLine();
	  
   }
}