using ejercicioBilletera.Modelo;
var billetera1 = new Billetera();
var billetera2 = new Billetera();
var billetera3 = new Billetera();
billetera1.IngresarBilletes();
billetera1.PresumirBilletes();
Console.WriteLine($"Total: {billetera1.Total()}");
Console.WriteLine();

Console.WriteLine("Billetera 2");
billetera2.IngresarBilletes();
billetera2.PresumirBilletes();
Console.WriteLine($"Total: {billetera2.Total()}");
Console.WriteLine();

billetera3 = billetera1.Combinar(billetera2);
Console.WriteLine("Dinero de billeteras 1 y 2 transferido a billetera 3");
Console.WriteLine();
Console.WriteLine("Billetera 1");
billetera1.PresumirBilletes();
Console.WriteLine($"Total: {billetera1.Total()}");
Console.WriteLine();

Console.WriteLine("Billetera 2");
billetera2.PresumirBilletes();
Console.WriteLine($"Total: {billetera2.Total()}");
Console.WriteLine();

Console.WriteLine("Billetera 3");
billetera3.PresumirBilletes();
Console.WriteLine(billetera3.Total());