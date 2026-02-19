using OPPConcepts.Backend;

try
{
    var date1 = new Date();
    var date2 = new Date(2026, 2, 12);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

