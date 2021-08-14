using System;
using System.Collections.Generic;
using DbFirstApproachDemo.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace DbFirstApproachDemo
{
    class Program
    {
     static   EFcoreDB1Context dB1Context;
        static void GetAllDepartments()
        {
            dB1Context = new EFcoreDB1Context();
            // List<Department> departments = dB1Context.Departments.ToList();
            
            List<Department> departments= dB1Context.Departments.FromSqlRaw<Department>("sp_GetAllDepartments1").ToList();
            foreach (var item in departments)
            {
                Console.WriteLine(item.Id +"\t" +item.Name+"\t"+item.Location);
            }
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
             AddNewDEpartment();
            //  UpdateNewDEpartment();
            GetAllDepartments();
        }
        static void AddNewDEpartment()
        {
            dB1Context = new EFcoreDB1Context();
            Console.WriteLine(" Enter the Name and Location of the Department");
            Department department = new Department();
            department.Name = Console.ReadLine();
            department.Location = Console.ReadLine();          
             dB1Context.Database.ExecuteSqlRaw("sp_InsertNewEmployee1 {0},{1}",department.Name,department.Location);
            

        }
        static void UpdateNewDEpartment()
        {
            Console.WriteLine("Enter the Department Id to Update");
            int id = int.Parse(Console.ReadLine());
            dB1Context = new EFcoreDB1Context();
            Department department = dB1Context.Departments.Find(id);
            if(department!=null)
            {
                Console.WriteLine("enter the New name and Location of the department");
                department.Name = Console.ReadLine();
                department.Location = Console.ReadLine();
                dB1Context.Departments.Update(department);
                dB1Context.SaveChanges();
            }
            else
            {
                Console.WriteLine(" Sorry No Record Found");
            }
           
           
            

        }
        
    }
}
