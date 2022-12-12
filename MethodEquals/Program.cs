using MethodEquals;

Employee employee = new();
Employee employee2 = new("Jora", "Normalnov", "Dom");
void WorkEquals()
{
    if (employee.Equals(employee2))
    {
        Console.WriteLine("Данные объектов совпадают");
    }
    else
    {
        Console.WriteLine("Данные объектов не совпадают");
    }
}
WorkEquals();



