using System;
using System.Linq;
using System.Collections.Generic;

public class Player{
  public string name { get; set; }
  public string country { get; set; }
  
  public Player(string n,string c){
    this.name = n;
    this.country = c;
  }
}

public class Order{
  public string name { get; set; }
  public DateTime orderDate { get; set; }
  public int quantity{get; set;}
  
  public Order(string n,DateTime d,int q){
    this.name = n;
    this.orderDate = d;
    this.quantity = q;
  }
}


public class Linq
{
	public static void Main()
	{
	  
	  List<Order> O = new List<Order>();
	
	  O.Add(new Order("A",new DateTime(2018, 7, 24),10));
	  O.Add(new Order("B",new DateTime(2018, 7, 25),20));
	  O.Add(new Order("C",new DateTime(2018, 8, 24),10));
	  O.Add(new Order("D",new DateTime(2018, 9, 25),20));
	  
	  var ans1 = from w in O orderby w.orderDate select w;
	  foreach (var order in ans)  
        Console.WriteLine("{0} {1} {2}", order.name,order.orderDate,order.quantity);  
    
    var ans2 = from w in O orderby w.quantity select w;
	  foreach (var order in ans2)  
        Console.WriteLine("{0} {1} {2}", order.name,order.orderDate,order.quantity);  
		
		/*1
	  int[] array={11,2,7,3,4,5,6,10,11};
	  var n= array.Count(p => p%2==0);
	  Console.WriteLine(n);
	  */
	  
	  /*9
	  var n= from value in array where value*value*value < 1000 && value*value*value>100 select value;
	  foreach(var s in n)
	    Console.WriteLine(s);
	  */
	  
	  /*2
	  List<Player> P1 = new List<Player>();
	
	  P1.Add(new Player("A","A"));
	  P1.Add(new Player("B","B"));
	  P1.Add(new Player("C","A"));
	  P1.Add(new Player("D","C"));
	  P1.Add(new Player("E","A"));
	  P1.Add(new Player("F","C"));
	  P1.Add(new Player("G","F"));
	  P1.Add(new Player("H","G"));
	  var pairs =from a in P1 from b in P1 where (a.country != b.country) select new { a,b};  
    Console.WriteLine("The Matches are:");  
    foreach (var pair in pairs)  
      {  
        Console.WriteLine("{0} vs {1}", pair.a.name, pair.b.name);  
      }  
    */
    
    
    
	  
	}
	
	
}