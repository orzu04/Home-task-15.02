


 int MinNumber(int a, int b, int c, int d) 
 {


  if(a<b && a<c && a<d)
  {
    return a;
  }
  else if (b<a && b<c && b<d)
  {
    return b;
  }
  else if (c<a && c<b && c<d)
  {
    return c;
  }
  else {
    return d;
  }
  
  


 }

 MinNumber(5,2,3,4);
 System.Console.WriteLine(MinNumber(5,2,3,4));

