namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            int numOfLInes = int.Parse(Console.ReadLine());
double[] num = new double[numOfLInes * 2 + 2];
double lenght = 0;
for (int i = 0; i < numOfLInes * 2 + 2; i++)
{
    num[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < numOfLInes*2; i+=2)
{
    lenght += Lenght(num[i], num[i+1] , num[i+2] , num[i+3]);
}
Console.WriteLine(lenght);
double lastl = Lenght(num[0], num[1], num[numOfLInes * 2 ], num[numOfLInes * 2 + 1]);
Console.WriteLine(lenght+lastl);
double Lenght(double n = 0, double n1 = 0, double n2 = 0, double n3 = 0)
{
    double num = (Math.Pow((n2 - n), 2) + Math.Pow((n3 - n1), 2));
    int num2 = (int)num;
    return Math.Sqrt(num2);

}
        }
    }
}
