Console.WriteLine("--------------Question1---------");
 Console.Write("input a number: ");
 int number1 = int.Parse(Console.ReadLine());
 Console.WriteLine($"is {number1} an even number?? {number1 %2 == 0}");
 Console.WriteLine($"is {number1} an odd number?? {number1 %2 != 0}");
 Console.WriteLine("-------------------Question2------------");
 Console.Write("input a number: ");
 int number2 = int.Parse(Console.ReadLine());
 Console.WriteLine($"is {number2} divisible by 5 & 7?? {number2 %5*7 == 0}");

 Console.WriteLine("-------------Question4------------");
Console.Write("enter any given integer: ");
 int integer1 = int.Parse(Console.ReadLine());
 bool  thirdbit = (integer1&4) != 0;
 Console.WriteLine($"the third bit is {(thirdbit?1:0)}");
Console.WriteLine(thirdbit);
   Console.Write("----------------Question5-----------\n Area of trapezoid\n");
Console.Write("input integer a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("input integer b: ");
double b  = double.Parse(Console.ReadLine());

Console.Write("input height: ");
double  height = double.Parse(Console.ReadLine());

double AreaOfTrapezoid = (a+b)*height /2;

Console.WriteLine("The Area of trapezoid with sides {0},{1} and {2} is equalt to {3}",a,b,height,AreaOfTrapezoid);

Console.Write("--------------Question6--------------------\n Area of a rectangle\n------------------\n");
Console.Write("enter the length: ");
double  length = double.Parse(Console.ReadLine());

Console.Write("enter breath: ");
double breath = double.Parse(Console.ReadLine());
double perimeter = 2*length+breath;
double Area = length * breath;
Console.WriteLine("the area of rectangle with length {0} and breath {1} is = {2}", length,breath,Area);
Console.WriteLine("the perimeter of rectangle with length {0} and breath {1} is = {2}",length,breath ,perimeter);
 Console.WriteLine("-------Question 7-------");
Console.Write("Enter the weight: ");
double weight = Convert.ToDouble(Console.ReadLine());
double percentGiven = 17d / 100;
Console.WriteLine($"The weight of the man on the moon with {weight} on earth is: {weight * (percentGiven)}");

 Console.WriteLine("-----------------Question8----------------");
 Console.Write("checking whether a given point is inside a circle \n");
 Console.Write("enter point x: ");
 int pointx = int.Parse(Console.ReadLine());   
Console.Write("enter point y: ");
int pointy = int.Parse(Console.ReadLine());

double radius = Math.Pow(5,2);

int pointinsidecircle = (pointx *pointx + pointy * pointy);

if(pointinsidecircle<= radius)
{
Console.WriteLine("the point {0} and {1} is inside the circle",pointx,pointy);
}
else 
{
   Console.WriteLine("it is not inside th circle");
}
  Console.WriteLine("-------Question 10-------");
Console.Write("Enter a four digit number: ");
string num = Console.ReadLine();
int first = Convert.ToInt32(num[0].ToString());
int second = Convert.ToInt32(num[1].ToString());
int third = Convert.ToInt32(num[2].ToString());
int fourth = Convert.ToInt32(num[3].ToString());
Console.WriteLine($"Calculates the sum of the digits: {first + second + third + fourth}");
Console.WriteLine($"Prints on the console the number in reversed order: {fourth}{third}{second}{first}");
Console.WriteLine($"Puts the last digit in the first position: {fourth}{first}{second}{third}");
Console.WriteLine($"Exchanges the second and the third digit: {first}{third}{second}{fourth}");

            int number;
            int position;
            int i = 1;
            int mask;
            int bit;

            Console.Write("Enter a integer: ");
             number =int.Parse(Console.ReadLine());

            Console.Write("Enter a position: ");
          position=  int.Parse(Console.ReadLine());
            mask = i << position;
            Console.WriteLine(mask);
           
             bit = ((number & mask) == 0 ? 0 : 1);

            
             Console.WriteLine("The bit on the given position is " + bit);
 Console.WriteLine("Result: " + (bit == 1 ? "true" : "false"));
 