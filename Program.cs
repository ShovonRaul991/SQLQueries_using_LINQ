using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace SQL_Queries1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> Employeelist = new List<Employee>()
                {
                    new Employee(1, "John", "Smith", "Programmer", 54, 27000),
                    new Employee(2,"Leroy", "Brooks", "General Manager", 55, 40099),
                    new Employee(3, "John", "Fanning", "Programmer", 28, 35000),
                    new Employee(4, "Lisa", "Moore", "Programmer", 27, 35000),
                    new Employee(5, "Ginger", "Finger", "Fresher", 22, 31500),
                    new Employee(6, "Kelly", "Brooks", "Programmer", 27, 22000),
                    new Employee(7, "Shaw", "Tait", "Fresher", 20, 25000),
                    new Employee(8, "Michael", "Tolstoy", "Fresher", 21, 25000),
                    new Employee(9, "Anthony", "Hopkins", "Programmer", 26, 19500),
                    new Employee(10, "Leroy", "Miles", "General Manager", 54, 30000),
                    new Employee(11,"Mary An", "Moore", "Software Engineer", 32, 32513),
                    new Employee(12, "Donald", "Duck", "Programmer", 35, 19300),
                    new Employee(13, "Linda", "Hamilto", "Fresher", 35, 25000),
                    new Employee(14, "Sarah", "Kara", "Fresher", 15, 25000),
                    new Employee(15, "Kevi", "Peiterse", "Programmer", 40, 32300),
                    new Employee(16, "Conrad", "Whales", "Software Engineer", 20, 32300),
                    new Employee(17, "Isabela", "Kara", "Programmer", 38, 30260),
                    new Employee(18, "Lisa", "Loga", "Programmer", 23, 20000),
                    new Employee(19, "Ginger", "Gra", "Fresher", 10, 22000),
                    new Employee(20, "Kelly", "Shield", "Programmer", 25, 19000),
                    new Employee(21, "Shaw", "Bichel", "Fresher", 26, 22000),
                    new Employee(22, "Michael", "Stone", "Fresher", 24, 21000),
                    new Employee(23, "Anthony", "Groove", "Software Engineer", 47, 23000),
                    new Employee(24, "Mary An", "Vista", "Programmer", 27, 37570),
                    new Employee(25, "Donald", "Bang", "Fresher", 34, 31000),
                    new Employee(26, "Linda", "Hamser", "Fresher", 42, 34000),
                    new Employee(27, "Sarah", "Bones", "Fresher", 51, 32000),
                    new Employee(28, "Kevi", "Luther", "Programmer", 45, 33000),
                    new Employee(29, "Conrad", "Marss", "Fresher", 24, 31500),
                    new Employee(30, "Isabela", "Tauto", "Programmer", 25, 32500),
                    new Employee(31, "John", "Vaugha", "Programmer", 25, 27000),
                    new Employee(32, "Leroy", "Garte", "Programmer", 55, 40099),
                    new Employee(33, "John", "Whitaker", "Programmer", 25, 32000),
                    new Employee(34, "Lisa", "Merci", "Programmer", 27, 35000),
                    new Employee(35, "Ginger", "Brow", "Software Engineer", 20, 25000),
                    new Employee(36, "Kelly", "Alba", "Programmer", 27, 22000),
                    new Employee(37, "Shaw", "Sons", "Fresher", 20, 25000),
                    new Employee(38, "Michael", "Mitchell", "Fresher", 21, 25000),
                    new Employee(39, "Anthony", "Bravo", "Programmer", 26, 19500),
                    new Employee(40, "Leroy", "Kings", "General Manager", 54, 30000),
                    new Employee(41, "Mary An", "Dolce", "Programmer", 32, 32513),
                    new Employee(42, "Donald", "Bus", "Programmer", 35, 19300),
                    new Employee(43, "Linda", "Scott", "Fresher", 35, 25000),
                    new Employee(44, "Sarah", "Jones", "Fresher", 15, 25000),
                    new Employee(45, "Kevi", "Reese", "Software Engineer", 40, 32300),
                    new Employee(46, "Conrad", "Turtle", "Software Engineer", 40, 25000),
                    new Employee(47, "Isabela", "Apple", "Programmer", 38, 30260),
                    new Employee(48, "Lisa", "Hammer", "Programmer", 23, 20000),
                    new Employee(49, "Ginger", "Gold", "Fresher", 10, 22000),
                    new Employee(50, "Kelly", "Rise", "Programmer", 25, 19000),
                    new Employee(51, "Shaw", "Bell", "Fresher", 26, 22000),
                    new Employee(52, "Michael", "Moore", "Fresher", 24, 21000),
                    new Employee(53, "Anthony", "Tamahori", "Programmer", 84, 23000),
                    new Employee(54, "Mary An", "Hor", "Programmer", 27, 37570),
                    new Employee(55, "Donald", "Crank", "Programmer", 34, 31000),
                    new Employee(56, "Linda", "Josh", "Fresher", 42, 34000),
                    new Employee(57, "Sarah", "Michael", "Fresher", 51, 32000),
                    new Employee(58, "Kevi", "Long", "Programmer", 45, 33000),
                    new Employee(59, "Conrad", "Tamahori", "Software Engineer", 24, 31500),
                    new Employee(60, "Isabela", "Moore", "Programmer", 25, 32500),
                };

            var EmployeeData = Employeelist.Select(e=> new {FirstName= e.EmployeeFirstName,
                                                            LastName = e.EmployeeLastName, 
                                                        Title =e.EmployeeTitle, 
                                                        Age = e.EmployeeAge,
                                                        salary = e.EmployeeSalary});
            //Select  firstname, lastname, title, age, salary  for everyone in your employee table. 
            void query1()
            {
                foreach (var employee in EmployeeData)
                {
                    Console.WriteLine("Name is " + employee.FirstName + " " + employee.LastName + " and title is " + employee.Title + " and salary is: " + employee.salary);
                }
            }


            //Select firstname, age and salary for everyone in your employee table
            void query2()
            {
                foreach (var employee in EmployeeData)
                {
                    Console.WriteLine("FirstName" + " " + "Age" + " " + "salary");
                    Console.WriteLine(employee.FirstName + " " + employee.Age + " " + employee.salary);
                }
            }

            //Select firstname and display as 'Name' for everyone in your employee table
            void query3()
            {
                foreach (var employee in EmployeeData)
                {
                    Console.WriteLine("Name");
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }

            //Select all columns for everyone with a salary over  38000. 
            void query4()
            {
                var EmployeeSalaryGreaterThan38000 = Employeelist.Where(e => e.EmployeeSalary > 38000);
                foreach(var employee in EmployeeSalaryGreaterThan38000)
                {
                    Console.WriteLine(employee.EmployeeFirstName+" "+employee.EmployeeLastName+" "+employee.EmployeeSalary+" "+employee.EmployeeTitle+" "+employee.EmployeeAge);
                    //Console.WriteLine("Name is " + employee.FirstName + " " + employee.LastName + " and title is " + employee.Title + " and salary is: " + employee.salary);
                }
            }

            //Select first and last names for everyone that's under  24 years old. 
            void query5()
            {
                var EmployeeAgeLessThan24 = Employeelist.Where(e => e.EmployeeAge<24).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    //Title = e.EmployeeTitle,
                    //Age = e.EmployeeAge,
                    //salary = e.EmployeeSalary
                });
                foreach (var employee in EmployeeAgeLessThan24)
                {
                    Console.WriteLine(employee);
                    
                }
            }

            //Select first name, last name, and salary for anyone with "Programmer" in their title. 
            void query6()
            {
                var EmployeeProgrammer = Employeelist.Where(e => e.EmployeeTitle == "Programmer").Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    //Title = e.EmployeeTitle,
                    //Age = e.EmployeeAge,
                    //salary = e.EmployeeSalary
                });
                foreach (var employee in EmployeeProgrammer)
                {
                    Console.WriteLine(employee);

                }
            }

            //Select all columns for everyone whose last name contains   "O". 
            void query7()
            {
                var EmployeeContains_O_ = Employeelist.Where(e => e.EmployeeLastName.Contains("o")).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in EmployeeContains_O_)
                {
                    Console.WriteLine(employee);

                }
            }

            //Select the lastname for everyone whose first name equals "Kelly"
            void query8()
            {
                var EmployeeKelly = Employeelist.Where(e => e.EmployeeFirstName == "Kelly").Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });

                foreach (var employee in EmployeeKelly)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select all columns for everyone whose last name ends in  "Moore
            void query9()
            {
                var EmployeeMoore = Employeelist.Where(e => e.EmployeeLastName.EndsWith("Moore")).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in EmployeeMoore)
                {
                    Console.WriteLine(employee);
                }
                //Console.WriteLine(EmployeeKelly);
            }

            //Select all columns for everyone who are 35 and above
            void query10()
            {
                var EmployeeMore34 = Employeelist.Where(e => e.EmployeeAge>=35).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in EmployeeMore34)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select firstname ,lastname,age and salary of everyone whose age is above 24 and below 43
            void query11()
            {
                var EmployeeAgeBetweet_24_43 = Employeelist.Where(e => e.EmployeeAge > 24 && e.EmployeeAge<43).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    //Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in EmployeeAgeBetweet_24_43)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select firstname, title and lastname whose age is in the range 28  and 62 and salary greater than 31250
            void query12()
            {
                var filterQuery12 = Employeelist.Where(e => e.EmployeeAge >= 28 && e.EmployeeAge <= 62 && e.EmployeeSalary>31250).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    //Age = e.EmployeeAge,
                    //salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery12)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select all columns for everyone whose age is not more than 48 and salary not less than 21520
            void query13()
            {
                var filterQuery13 = Employeelist.Where(e => e.EmployeeAge <= 48 && e.EmployeeSalary >= 21520).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery13)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select firstname and age of everyone whose firstname starts with  "John"  and salary in the range 25000 and 35000
            void query14()
            {
                var filterQuery14 = Employeelist.Where(e => e.EmployeeFirstName.StartsWith("John") && e.EmployeeSalary>=25000 && e.EmployeeSalary<=35000).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    //LastName = e.EmployeeLastName,
                    //Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    //salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery14)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select all columns for everyone by their ages in descending order.
            void query15()
            {
                var filterQuery15 = Employeelist.OrderByDescending(e=>e.EmployeeAge).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery15)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select all columns for everyone by their ages in ascending order.
            void query16()
            {
                var filterQuery16 = Employeelist.OrderBy(e => e.EmployeeAge).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery16)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select all columns for everyone by their salaries in descending order.
            void query17()
            {
                var filterQuery17 = Employeelist.OrderByDescending(e => e.EmployeeSalary).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery17)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select all columns for everyone by their salaries in ascending order
            void query18()
            {
                var filterQuery18 = Employeelist.OrderBy(e => e.EmployeeSalary).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery18)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select all columns for everyone by their salaries in ascending order whose age not less than 17.
            void query19()
            {
                var filterQuery19 = Employeelist.Where(e=>e.EmployeeAge>=17).OrderBy(e => e.EmployeeSalary).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery19)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select all columns for everyone by their salaries in descending order whose age not more than 34.
            void query20()
            {
                var filterQuery20 = Employeelist.Where(e => e.EmployeeAge <=34 ).OrderByDescending(e => e.EmployeeSalary).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery20)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select all columns for everyone by their length of firstname in ascending order.
            void query21()
            {
                var filterQuery21 = Employeelist.OrderBy(e => e.EmployeeFirstName.Length).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                foreach (var employee in filterQuery21)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select the number of employees whose age is above 45
            void query22()
            {
                var filterQuery22 = Employeelist.Where(e => e.EmployeeAge>45).Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                Console.WriteLine("Select the number of employees whose age is above 45 : "+filterQuery22.Count());
            }

            //Show the results by adding 5 to ages and removing 250 from salaries of all employees
            void query23()
            {
                var filterQuery23 = Employeelist.Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge+5,
                    salary = e.EmployeeSalary-250
                });
                foreach (var employee in filterQuery23)
                {
                    Console.WriteLine(employee);
                }
            }

            //Select the number of employees whose lastname ends with "re" or "ri" or "ks"
            void query24()
            {
                var filterQuery24 = Employeelist.Where(e=>e.EmployeeLastName.Contains("re") || 
                                                          e.EmployeeLastName.Contains("ri") ||
                                                          e.EmployeeLastName.Contains("ks"))
                    .Select(e => new
                {
                    FirstName = e.EmployeeFirstName,
                    LastName = e.EmployeeLastName,
                    Title = e.EmployeeTitle,
                    Age = e.EmployeeAge,
                    salary = e.EmployeeSalary
                });
                
                Console.WriteLine("Select the number of employees whose lastname ends with \"re\" or \"ri\" or \"ks\": " + filterQuery24.Count());
                
            }

            //Select the average salary of all your employees
            void query25()
            {
                var filterQuery25 = Employeelist.Average(e=>e.EmployeeSalary);
                Console.WriteLine("the average salary of all your employees: "+filterQuery25);
                
            }

            //Select the average salary of Freshers
            void query26()
            {
                var filterQuery26 = Employeelist.Where(e => e.EmployeeTitle == "Fresher").Average(e=>e.EmployeeSalary);
                Console.WriteLine("Select the average salary of Freshers: " + filterQuery26);
            }


            //Select the average age of Programmers
            void query27()
            {
                var filterQuery27 = Employeelist.Where(e => e.EmployeeTitle == "Programmer").Average(e => e.EmployeeSalary);
                Console.WriteLine("Select the average salary of Programmers: " + filterQuery27);
            }

            //Select the average salary of employees whose age is not less than 35 and not more than 50
            void query28()
            {
                var filterQuery28 = Employeelist.Where(e => e.EmployeeAge>=35 && e.EmployeeAge<=50).Average(e => e.EmployeeSalary);
                Console.WriteLine("the average salary of employees whose age is not less than 35 and not more than 50:  " + filterQuery28);
            }

            //Select the number of Freshers
            void query29()
            {
                var filterQuery29 = Employeelist.Where(e => e.EmployeeTitle == "Fresher");
                Console.WriteLine(filterQuery29.Count());
            }

            //What percentage of programmers constitute your employees
            void query30()
            {
                var filterQuery30 = Employeelist.Where(e => e.EmployeeTitle == "Programmer");
                var programmerCount = filterQuery30.Count();
                var totalCount = Employeelist.Count(); 
                Console.WriteLine("percentage of programmers constitute your employees: "+programmerCount *100/totalCount);
            }

            //What is the combined salary that you need to pay to the employees whose age is not less than 40
            void query31()
            {
                var filterQuery31 = Employeelist.Where(e=>e.EmployeeAge>=40).Sum(e => e.EmployeeSalary);
                Console.WriteLine("combined salary that you need to pay to the employees whose age is not less than 40"+filterQuery31);
            }

            //What is the combined salary that you need to pay to all the Freshers and Programmers for 1 month
            void query32()
            {
                var filterQuery32 = Employeelist.Where(e=>e.EmployeeTitle=="Fresher" || e.EmployeeTitle=="Programmer").Sum(e => e.EmployeeSalary/12);
                Console.WriteLine("combined salary that you need to pay to all the Freshers and Programmers for 1 month :"+filterQuery32);
            }

            //What is the combined salary that you need to pay to all the Freshers whose age is greater than 27 for 3years 
            void query33()
            {
                var filterQuery33 = Employeelist.Where(e => e.EmployeeTitle == "Fresher" && e.EmployeeAge > 27).Sum(e => e.EmployeeSalary * 3);
                Console.WriteLine("combined salary that you need to pay to all the Freshers whose age is greater than 27 for 3years : "+ filterQuery33);
            }

            //Select the eldest employee's firstname, lastname and age whose salary is less than 35000
            void query34()
            {
                var filterQuery34 = Employeelist.Where(e => e.EmployeeSalary < 35000).Select(e => e);
                var elders = filterQuery34.OrderByDescending(e => e.EmployeeAge).ToList();
                Console.WriteLine(elders[0].EmployeeFirstName+" " + elders[0].EmployeeLastName+" " + elders[0].EmployeeAge);
            }

            //Who is the youngest General Manager
            void query35()
            {
                var filterQuery35 = Employeelist.Where(e=>e.EmployeeTitle=="General Manager").OrderBy(e=>e.EmployeeAge).ToList();
                Console.WriteLine(filterQuery35[0].EmployeeFirstName + " " + filterQuery35[0].EmployeeLastName);
            }

            //Select the eldest fresher whose salary is less than 35000
            void query36()
            {
                var filterQuery36 = Employeelist.Where(e=>e.EmployeeTitle=="Fresher" && e.EmployeeSalary<35000).OrderByDescending(e=>e.EmployeeAge).ToList();
                Console.WriteLine(filterQuery36[0].EmployeeFirstName+" "+filterQuery36[0].EmployeeLastName);
            }

            //Select firstname and age of everyone whose firstname starts with  "John" or "Michael"  and salary in the range 17000 and 26000
            void query37()
            {
                //string[] startWithArray = { "John", "Michael" };
                var filterQuery37 = Employeelist.Where(e=>e.EmployeeFirstName.StartsWith("John") || e.EmployeeFirstName.StartsWith("Michael")
                                                        && e.EmployeeSalary>=17000 && e.EmployeeSalary<=26000).Select(e=>e.EmployeeFirstName+" "+e.EmployeeAge);
                foreach(var employee in filterQuery37)
                {
                    Console.WriteLine(employee);
                }
            }

            //How many employees are having each unique title. Select the title and display the number of employees present in ascending order
            void query38()
            {
                var filterQuery38 = Employeelist.GroupBy(e=>e.EmployeeTitle);
                foreach(var employee in filterQuery38)
                {
                    Console.WriteLine(employee.Key+ " "+ employee.Count());
                }
            }

            //What is the average salary of each unique title of the employees. Select the title and display the average salary of employees in each
            void query39()
            {
                var filterQuery38 = Employeelist.GroupBy(e => e.EmployeeTitle).Select(g => new { Title = g.Key,Avg_salary = g.Average(e => e.EmployeeSalary),Numbers=g.Count()});
                foreach (var employee in filterQuery38)
                {
                    Console.WriteLine(employee);
                }
            }

            //What is the average salary of employees excluding Freshers
            void query40()
            {
                var filterQuery40 = Employeelist.Where(e=>e.EmployeeTitle!="Fresher").Average(e=>e.EmployeeSalary);
                Console.WriteLine("average salary of employees excluding Freshers: " + filterQuery40);
            }

            //What is the average age of employees of each unique title
            void query41()
            {
                var filterQuery41 = Employeelist.GroupBy(e=>e.EmployeeTitle).Select(g => new {Title = g.Key,Average_age = Convert.ToInt32(g.Average(e=>e.EmployeeAge))});
                foreach(var employee in filterQuery41)
                {
                    Console.WriteLine(employee);
                }
            }

            //In the age range of  25 to 40 get the number of employees under each unique title.
            void query42()
            {
                var filterQuery42 = Employeelist.Where(e => e.EmployeeAge >= 25 && e.EmployeeAge <= 40).GroupBy(e => e.EmployeeTitle).Select(g => new { Title = g.Key ,Numbers = g.Count()});
                foreach (var employee in filterQuery42)
                {
                    Console.WriteLine(employee);
                }
            }

            //Show the average salary of each unique title of employees only if the average salary is not less than 25000   /* not complete*/
            void query43()
            {
                var filterQuery43 = Employeelist.GroupBy(e=>e.EmployeeTitle).Select(g => new {Title = g.Key, Average_salary = g.Average(e=>e.EmployeeSalary)});
                foreach (var employee in filterQuery43)
                {
                    if(employee.Average_salary>25000)
                    {
                        Console.WriteLine(employee);
                    }
                    
                }
            }

            //Show the sum of ages of each unique title of employee only if the sum of age is greater than 30
            void query44()
            {
                var filterQuery44 = Employeelist.GroupBy(e => e.EmployeeTitle).Select(g => new { Title = g.Key, Sum_of_age = g.Sum(e=>e.EmployeeAge), Average_age  = Convert.ToInt32(g.Average(e=>e.EmployeeAge))});
                foreach(var employee in filterQuery44)
                {
                    if(employee.Average_age>30)
                    {
                        Console.WriteLine(employee.Title+" "+employee.Sum_of_age);
                    }
                    
                }
            }

            //Lisa Ray just got married to Michael Moore. She has requested that her last name be updated to Moore. 
            void query45()
            {
                var filterQuery45 = Employeelist.Where(e => e.EmployeeFirstName == "Lisa" && e.EmployeeLastName == "Ray");
                foreach(var employee in filterQuery45)
                {
                    employee.EmployeeLastName = "Moore";
                }
            }

            //Ginger Finger's birthday is today, add 1 to his age and a bonus of 5000
            void query46()
            {
                var filterQuery46 = Employeelist.Where(e => e.EmployeeFirstName == "Ginger" && e.EmployeeLastName == "Finger");
                foreach(var employee in filterQuery46)
                {
                    Console.WriteLine("Previous Age: "+employee.EmployeeAge+" "+"Previous Salary: "+employee.EmployeeSalary);
                    employee.EmployeeAge = employee.EmployeeAge + 1;
                    employee.EmployeeSalary += 5000;
                    Console.WriteLine("Recent Age: " + employee.EmployeeAge + " " + "Recent Salary: " + employee.EmployeeSalary);
                }
            }

            //All 'Programmer's are now called "Engineer"s. Update all titles accordingly
            void query47()
            {
                var filterQuery47 = Employeelist.Where(e => e.EmployeeTitle == "Programmer");
                foreach(var employee in filterQuery47)
                {
                    //Console.WriteLine(employee.EmployeeTitle);
                    employee.EmployeeTitle = "Engineer";
                    //Console.WriteLine("Updated");
                    //Console.WriteLine(employee.EmployeeTitle);
                }
            }

            //Everyone whose making under 30000 are to receive a 3500 bonus.
            void query48()
            {
                var filterQuery48 = Employeelist.Where(e => e.EmployeeSalary < 30000);
                foreach(var employee in filterQuery48)
                {
                   
                    employee.EmployeeSalary += 3500;
                }
            }

            //Everyone whose making over 35500 are to be deducted 15% of their salaries
            void query49()
            {
                var filterQuery49 = Employeelist.Where(e => e.EmployeeSalary > 35500);
                foreach(var employee in filterQuery49)
                {
                    employee.EmployeeSalary -= Convert.ToInt32((employee.EmployeeSalary) * 0.15);
                }
            }


            //Calling for all the queries
            //query1();
            //query2();
            //query3();
            //query4();
            //query5();
            //query6();
            //query7();
            //query8();
            //query9();
            //query10();
            //query11();
            //query12();
            //query13();
            //query14();
            //query15();
            //query16();
            //query17();
            //query18();
            //query19();
            //query20();
            //query21();
            //query22();
            //query23();
            //query24();
            //query25();
            //query26();
            //query27();
            //query28();
            //query29();
            //query30();
            //query31();
            //query32();
            //query33();
            //query34();
            //query35();
            //query36();
            //query37();
            //query38();
            //query39();
            //query40();
            //query41();
            //query42();
            //query43();
            //query44();
            //query45();
            //query46();
            //query47();
            //query48();

        }




    }
}
