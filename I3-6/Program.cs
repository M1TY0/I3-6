int numOfLInes = int.Parse(Console.ReadLine());
double[] num1 = new double[numOfLInes*2+2];
double lenght = 0;
for (int i = 0; i < numOfLInes * 2 + 2; i++)
{
    num1[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < numOfLInes; i++)
{
    lenght += Lenght(num1[i], num1[i] + 1, num1[i] + 2, num1[i] + 3);
}
Console.WriteLine(  lenght);

double Lenght(double n = 0, double n1 = 0, double n2 = 0, double n3 = 0)
{
    double num = (Math.Pow((n - n1), 2) + Math.Pow((n2 - n3), 2));
    int num2 = (int)num;
    return Math.Sqrt(num2);

}