// See https://aka.ms/new-console-template for more information

double priceSmall = 25;
double priceLarge = 35;
double taxRate = 0.06;


Console.WriteLine("Number of small carpets?");
int small = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number of large carpets?");
int large = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Price per small room: $25");
Console.WriteLine("Price per large room: $35");

double cost = (small * priceSmall) + (large * priceLarge);

Console.WriteLine("cost : $"+ cost );

double tax = cost * taxRate;
Console.WriteLine("tax Rate :" + tax);

double total = cost + tax;
Console.WriteLine("toat");

Console.WriteLine("Total estimate: $" + total);

Console.WriteLine("This estimate is valid for 30 days");


