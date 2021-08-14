using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using EFCore_DBFirst_StoredProcedureDemo.Models;
using System.Collections.Generic;

namespace EFCore_DBFirst_StoredProcedureDemo
{
    class Program
    {
      static  EFcoreDB1Context context;
        static void GetAllDepartments()
        {
            context = new EFcoreDB1Context();
         List<Department> Departmentlist= context.Departments.FromSqlRaw<Department>("sp_GetAllDepartments").ToList();
            foreach (var item in Departmentlist)
            {
                Console.WriteLine(item.Id +"\t "+item.Name+"\t "+item.Location);
            }
        }
        static void AddNewDepartment()
        {
            string name, location;
            Console.WriteLine(" Enter the Name and Location of the Department");
            name = Console.ReadLine();
            location = Console.ReadLine();
            context = new EFcoreDB1Context();
            context.Database.ExecuteSqlRaw("sp_InsertNewEmployee {0},{1}", name, location);
        }
        static void Main(string[] args)
        {
            AddNewDepartment();
            GetAllDepartments();
            // Console.WriteLine("Hello World!");
        }
       
       
    }
}
