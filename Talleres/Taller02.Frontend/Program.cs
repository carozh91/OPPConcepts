
using Taller02.Backend;

try
{
    var circle = new Circle("Circle", 5);
    Console.WriteLine(circle);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
