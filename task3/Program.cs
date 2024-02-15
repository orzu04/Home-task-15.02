

int n = Convert.ToInt32(Console.ReadLine());
int max = n%10;
int min = n%10;
for (int i = n/10; i >0 ; i/=10)
{
    if(min > i%10)min=i;
    if(max<i%10) max=i;

}
System.Console.WriteLine($"{min} + {max} = {min+max}");