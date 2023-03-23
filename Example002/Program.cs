Console.WriteLine("Введите значения: ");
double xb = Convert.ToInt32(Console.ReadLine());
double xa = Convert.ToInt32(Console.ReadLine());
double yb = Convert.ToInt32(Console.ReadLine());
double ya = Convert.ToInt32(Console.ReadLine());
double zb = Convert.ToInt32(Console.ReadLine());
double za = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2) );

Console.WriteLine(result);
