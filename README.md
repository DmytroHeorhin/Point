# Point

 Find the issue, explain and fix: 
 
 public struct Point 
 {       
     public int X;     
      public void IncX() 
      {  
           X++;             
      }         
 }        
 
 static void Main() 
 {   
      var points = new List<Point>(Enumerable.Range(1, 10).Select(p => new Point()));  
      foreach (var p in points)
      {              
           p.IncX();            
      }         
      foreach (var p in points) 
      {                 
           Console.WriteLine(p.X);   
      }           
      Console.ReadKey();  
 }  
 
 The issue here is that we are trying to change a field of list member, but we just changing a field of a local variable p, because value types are passed to variables vie copying it's value, not by reference. Eventually we are just calling an IncX method on a local variable and not on a list member.  
