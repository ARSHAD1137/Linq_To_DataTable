using System;

namespace Linq_To_DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Table demo");
            LinqToDataTable linqToDataTable = new LinqToDataTable();
            linqToDataTable.AddToDataTableDemo();
            Console.ReadKey();
        }
    }
}
