using AssignmentOOP02;
using static AssignmentOOP02.Employee;

namespace Assignmentoop2
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region part2

            #region Q1
            //Person[] employee =
            //{
            //    new Person("hjh",54)
            //    , new Person("ji",21),
            //    new Person("ui",32)
            //};
            //foreach (Person person in employee) 
            //{
            // Console.WriteLine(person);    
            //}


            #endregion


            #region Q2

            //Person[] employee2 = new Person[3];
            //int count = 0;
            //do { 

            // Console.WriteLine($"emp{ +count}");

            // string name = Console.ReadLine();
            // int age = int.Parse(Console.ReadLine());
            //    employee2[count] = new Person(name, age);
            //    ++count;


            //} while (count < 3);

            //Person oldest = employee2[0];
            //for (int i = 1; i < 3; i++) 
            //{
            //    if (employee2[i].Age > oldest.Age)
            //       oldest = employee2[i];
            //}
            //Console.WriteLine(oldest);



            #endregion

            #region Part3

            #region Q1
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "hjh", 'F', SecurityLevel.DBA,546511, new HireDate(1, 1, 2020));
            EmpArr[1] = new Employee(2, "jkhl", 'M', SecurityLevel.Guest, 5454, new HireDate(15, 3, 2019));
            EmpArr[2] = new Employee(3, "knkn", 'M', SecurityLevel.Developer, 464, new HireDate(10, 10, 2018));

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }



            #endregion








            #endregion











            #endregion
        }
    }
}
