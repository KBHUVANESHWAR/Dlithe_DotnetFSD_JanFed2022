// See https://aka.ms/new-console-template for more information
// Encapsulation
using System;

public class Encapsulation
{
    private int emp_id;
    private String emp_name;

    public int ID
    {
        get
        {
            return emp_id;
        }
        set
        {
            emp_id = value;
        }
    }
    public String EmployeeName
    {
        get
        {
            return emp_name;
        }
        set
        {
            emp_name = value;
        }
    }


}

class EncapsulationData
{
    static void Main(String[] args)
    {
        Encapsulation data = new Encapsulation();
        data.ID = 120;
        data.EmployeeName = "Bhuvaneshwari k";
        Console.WriteLine("Employee ID: " + data.ID);
        Console.WriteLine("Employee NAME: " + data.EmployeeName);
    }
}
