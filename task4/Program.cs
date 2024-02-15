



int x = Convert.ToInt32(Console.ReadLine());


int y = Convert.ToInt32(Console.ReadLine());


int sum = 1;

int Pow(int x, int y)
{

    for (int i = 1; i <=y; i++)
    {
        
      sum*=x;

    }
  return sum;
}
System.Console.Write($"Sum = ");
System.Console.WriteLine(Pow(x,y));