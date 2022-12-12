using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodEquals;

public class Employee
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string PlaceOfWork { get; set; }
    public Employee()
    {
        Name = "Jora";
        SurName = "Normalnov";
        PlaceOfWork = "Dom";
    }
    public Employee(string name, string surName, string placeOfWork)
    {
        Name = name;
        SurName = surName;
        PlaceOfWork = placeOfWork;
    }
    public override bool Equals(object? obj)
    {
        var other = obj as Employee;
        if (other == null || obj == null)
        {
            return false;
        }
        else if (other.Name == Name && other.SurName == SurName && other.PlaceOfWork == PlaceOfWork)
        {
            return true;
        }
        return false;
    }
}
