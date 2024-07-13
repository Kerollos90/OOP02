using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.demo

{
    internal struct Employee
    {
        #region attributes
        //public int id;
        //private string? name;
        //private decimal salary;
        #endregion

        #region 1. apply encapsulation definition attributes
        //// 1.private attributes 
        ///// 2.getter setter
        ////getter
        //  public string? GetName()
        //{ return name; }

        ////setter 

        //public void Setname(string? value)
        //{

        //    name = value?.Length > 5 ? value.Substring(0, 5) : value;


        //}










        #endregion

        #region 2. apply encapsulation property 
        //1 full property
        //2 automatic property
        //3 indexer

        ////full prop
        //public decimal Salary
        //{
        //    get { return salary; }

        //    set { salary = value; }

        //}

        //public int age;//attribute
       //  public int age{get ; set;} //prop
       // in automatic prop compiler create attribute
        //full prop => propfull
        //automatic => prop


        //private decimal duduction;

        //public decimal Duduction        
        //{
        //    get { return salary * 0.2m; }

        //}

        #endregion


        #region constructors

        //public Employee()
        //{

        //}
        //public Employee(int id, string name, decimal salary)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;



        //}
        #endregion
        #region methods
        //public override string ToString()
        //{
        //    return $"id = {id} \n name {name}\n salary {salary}";
        //}
        #endregion




    }


}
