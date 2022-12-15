// See https://aka.ms/new-console-template for more information



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Windows.Markup;

class student1
{
    public String Name;
    public String Rollno;
    public String Id;
    public String Mark;
    public   student1 (string name)
    {
        
        this.Name = name;
        Console.WriteLine("Enter the Rollno");
        this.Rollno = Console.ReadLine();
        Console.WriteLine("Enter the ID");
        this.Id = Console.ReadLine();
        Console.WriteLine("Enter the Mark");
        this.Mark = Console.ReadLine();
    }
    public void display()
    {
        Console.WriteLine("Name: {0} Rollno: {1} Id: {2} Mark: {3} ",this.Name,this.Rollno,this.Id,this.Mark);
        
    }
    public void edit(string Val)
    {
       if(Val == "Name")
        {
            string name= Console.ReadLine();
            this.Name = name;
        }
       else if(Val == "RollNo")
        {
            string rollNo= Console.ReadLine();
            this.Rollno = rollNo;
        }
       else if(Val == "Id")
        {
            string id = Console.ReadLine();
            this.Id = id;
        }
       else if(Val== "Mark")
        {
            string mark = Console.ReadLine();
            this.Mark = mark;
        }
        Console.WriteLine("Updated records");
        display();
    }
    
        
       

    }





class student 
{
    
   
    public static void Main(string[] args)
    {
        Dictionary<string, student1> values = new Dictionary<string, student1>();
        Console.WriteLine("Enter the No of records to get");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the name");
            string Name = Console.ReadLine();
            values.Add(Name, new student1(Name));

        }


        int temp = 1;

        while(temp!=0)
        {
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
             switch(choice)
            {
                case 1:
                    foreach (KeyValuePair<string, student1> items in values)
                    {
                        values[items.Key].display();
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter student name to edit: ");
                    string stdname = Console.ReadLine();
                    Console.WriteLine("To change: ");
                    string toChange = Console.ReadLine();
                    values[stdname].edit(toChange);
                    break;
                case 3:
                    Console.WriteLine("Enter student Record To be deleted");
                    string stname = Console.ReadLine();
                    values.Remove(stname);
                    foreach (KeyValuePair<string, student1> items in values)
                    {
                        values[items.Key].display();
                    }
                    break;


                case 4:
                    Console.WriteLine("Ivalid case");
                    temp = 0;
                    break;


            }
        }
       
        
      
        
    }
}
