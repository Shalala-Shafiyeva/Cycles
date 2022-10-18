// 1. User gives 2 number a,b. Output a to the power of b (not using math.pow)
/*Console.WriteLine("Please input nums a, b:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int a1 = a;
while (b!=1)
{
    a = a1 * a;
    b--;
}
Console.WriteLine(a);
*/

// 2. User gives 1 number a. Output amount of number from 1 to 1000 that have no reminder when divided by a.
/*Console.WriteLine("Please input nums a:");
int a = Convert.ToInt32(Console.ReadLine());
int k = 0;
for (int i=a; i<=1000; i+=a)
{
    if (i % a == 0) k++;
}
Console.WriteLine(k);
*/

// 3. User gives 1 number a. Output all positive numbers whose square will be less than a.
/*Console.WriteLine("Please input nums a:");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= Math.Sqrt(a); i++)
{
    if (i*i < a) Console.WriteLine(i);
}
*/

// 4. User gives 1 number a. Output largest divisor to that number.
/*Console.WriteLine("Please input nums a:");
int a = Convert.ToInt32(Console.ReadLine());
int d = 0;
for (int i = 2; i <= a; i++)
{
    if (a % i == 0) d = i; }
    

Console.WriteLine(d);
  */

// 5. User gives 2 nums a,b/ Output sum of all nums from range a to b that have no reminder whan divided by 7.

/* Console.WriteLine("Please input nums a, b:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c;
int k = 0;
if (a > b) { c = a; a = b; b = c; }
if (a == b && a % 7 == 0) Console.WriteLine(a);
else if (a == b && a % 7 != 0) Console.WriteLine("This num can't be divided on 7 without reminder");
else
{
    for (int i = a; i <= b && a != b; i++)
    {
        if (i % 7 == 0) { Console.WriteLine(i); k++; }
    }
    if (k == 0)
    {
        Console.WriteLine("This num can't be divided on 7 without reminder");
    }
}
*/

// 6. User gives 1 number a. Output a-th number of Fibonacci's series.

/*Console.WriteLine("Please input nums a:");
int a = Convert.ToInt32(Console.ReadLine());
int f1 = 1;
int f2 = 1;
int f3=0;
for (int i=3; i<=a; i++)
{
    f3 = f1 + f2;
    f1 = f2;
    f2 = f3;
}
Console.WriteLine(f3);
*/

// 7. User gives 2 nums. Find out their greatest common divisor using Euclid's algorithm.
/*Console.WriteLine("Please input nums a, b:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
while (a != b)
{
    if (a > b) a = a - b;
    else b = b - a;
}
Console.WriteLine(a);

*/

// 8. User gives a positive number that is power of another number to 3. Find out that numbers using half divition method.

/*Console.WriteLine("Please input nums k:");
int k = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = k;
int m = k / 2;
while (k != m * m * m)
{
    if (k > m * m * m) a = m;
    else b = m;
    m = (a + b) / 2; Console.WriteLine("a=" + a + "b=" + b );
}
Console.WriteLine(m);*/

//9. дали число н. найти кол во нечетных цифр
/*Console.WriteLine("Please input nums a:");
int a = Convert.ToInt32(Console.ReadLine());
int k = 0;
while (a != 0)
{
    if ((a % 10)%2 == 1) k++;
    a /= 10;
}
Console.WriteLine(k);
*/

// 10. user gives 1 number. Find out mirrored number to that one
/*Console.WriteLine("Please input nums a:");
int a = Convert.ToInt32(Console.ReadLine());
int m = 0;
while (a != 0)
{
    m = 10 * m + (a % 10);
    a /= 10;
}
Console.WriteLine(m);
*/

// 11. user gives 1 number a. find out every number in range 1 to a whose sum of even digits bigger than odd.



/*Console.WriteLine("Please input nums a:");
int a = Convert.ToInt32(Console.ReadLine());
int sum1 = 0;
int sum2 = 0;
for (int i=0; i<=a; i++)
{
    int j = i;
    while (j != 0)
    {
        int n = j % 10;
        if (n % 2 == 0) sum1 += n;
        else sum2 += n;
        j /= 10;
       
    }
    if (sum1 > sum2) Console.WriteLine(i);
}
*/
//12. user gives 2 nums. find out if there are similar digits in those nums
/*Console.WriteLine("Please input nums a, b:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
while (a != 0)
{
    int qa = a % 10;
    a = a / 10;
    int c = b;
    while (c != 0)
    {
        int qc = c % 10;
        if (qc == qa) { Console.WriteLine(qa); break; }

        c = c / 10;
    }
}
*/

//13. 
/*Console.WriteLine("Please input nums n:");
int n = Convert.ToInt32(Console.ReadLine());
float sum = 0;
for (int i=1;  i<=n; i++)
{
    sum += 1 + (1 /( (float)i * (float)i));
}
Console.WriteLine(sum);
*/
//14.
//1.
/*Console.WriteLine("Please input nums x, n:");
int x = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int temp = x;
double hasil = x;
double sum = 0;
for(int i=1; i <= n; i++)
{
    sum += (1 / hasil);
    hasil = hasil * (temp + i);
}
Console.WriteLine(sum);
*/
//2.

/*Console.WriteLine("Please input nums x, n:");
int x = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int previous = x;
double next = x;
double sum = 0;

for(int i=2; i<=n; i++)
{
    sum += next;
    previous = x / i;
    next = next * previous;
}
Console.WriteLine(sum);
*/

//15.

/*Console.WriteLine("Please input nums n:");
int n = Convert.ToInt32(Console.ReadLine());
float p = 1;
float temp = 1;
for(int i=1; i<=n; i++)
{
    Console.WriteLine(temp);
    temp /= i;
    p *= (2 + temp);
}
Console.WriteLine(p);
*/

//16. WRONG
//найти приближенное значение бесконечной суммы
//нужное приближение считается полученным если вычислена сумма нескольких первых слагаемых и очередное слагаемое оказалось по модулю меньше
//положитеьно числа
/*
double x=0.5; 
double ylast=0.0;
double y=1.0;
double eps=0.0001;
int fac=1;
int sign=-1;
int i;
double sum=0;
for(i=0;i==1 || Math.Abs(y - ylast > eps); i++)
{
ylast=y;
    fac*=i;
    x*=x;
    y+=sign*x/fac;
 sign=-sign;
    sum+=y;
}
Console.WriteLine(y,sum);*/
//17.

//1.

/*bool flag = true;
for (int i=1;i<=99; i++)
{
    int a = i / 10;
    int b = i % 10;
    int s = a + b;
    int p;
    for (int j=2; i<=9; j++)
    {
        p = i * j;
        if (s == p / 100 + p / 10 % 10 + p % 10) flag = true;
    }
    if (flag==true) Console.WriteLine(i);
}

*/

//2.
/*for (int j=2; j <= 9; j++)
{
    for(int i = 10; i <= 99; i++)
    {
        int a = i / 10;
        int b = i % 10;
        int s = a + b;
        int p;
        p = i * j;
        if (s==p/100+p/10%10+p%10) Console.WriteLine(i+ " ");
    }
}
*/

//18. Find out every 3 digits number that can be represented as sum of all its digits factorial

/*
int factorial(int n)
{
    int product = 1;
    for(int i = 1; i <= n; i++)
    {
        product *= i;
    }
    return product;
}
void result()
{
    int abc;
    int faca, facb, facc;
    for( int a = 1; a <= 9; a++)
    {
        for ( int b = 1; b <= 9; b++)
        {
            for ( int c = 1; c <= 9; c++)
            {
                abc = 100 * a + 10 * b + c;
                faca = factorial(a);
                facb = factorial(b);
                facc = factorial(c);
                if (abc == faca + facb + facc)    Console.WriteLine(abc);
            }
        }
    }
}
for(int h=100; h <= 999; h++)
{
    result();
}
*/

//19.
/*int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < num; i++)
{
for (int j = 1; j < num; j++)
{
if (i*i+j*j==num) Console.WriteLine("Yes, we can represent " + num + "as sum of square  "+ i + "and" + j);

}}
*/
//20. Find out is given number perfect? Number is equal to sum of all its positive divisors
/*int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int n = num;
for (int i = 1; i < num; i++)
{
   if (num % i == 0)
      {
          sum += i;
      }
}
if (sum == n)
  {
     Console.WriteLine("This is a perfect number");
  }
else
  {
    Console.WriteLine("This is not a perfect number");
 }
       */

//21. User gives one positive number k. Find out k-th number of series 1234567891011121314... which have every positive number one by one

int n = Convert.ToInt32(Console.ReadLine());
int length = 0;
int i = 1;
while (n > length)
{
    Console.Write(i);
    length += calculateLengthOfNumber(i);
    i++;
}
Console.WriteLine("\n" + ((i - 1) / (Math.Pow(10, length - n))) % 10);
int calculateLengthOfNumber(int i)
{
    int length = 0;
    while (i != 0)
    {
        i /= 10;
        length++;
    }
    return length;
}










