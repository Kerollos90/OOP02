using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.demo
{
    internal struct Phonebook
    {
        #region attributes
        //string[] name;
        //int[] numbers;
        
        #endregion

        #region properties

        //public int size 
        //{ 
            
        //    get;
            
           
        //}

        #endregion

        #region constructor
        //public Phonebook (int size) 
        //{
        //    //this.size = size;
        //    //name = new string[size];
        //    //numbers = new int[size];
                
        
        //}

        #endregion

        #region methods
        //add person to notebook
       // public void addperson(int position ,string personname, int phonenumber)
       // {
            //if (name != null&&numbers != null) 
            //{
            //    if (position < size)
            //    { 
              
            //        name[position] = personname;
             
            //        numbers[position] = phonenumber;
            
                
            //    }
            //}

       // }




        #endregion

        #region getter

       // public int getnumber(string personname)
        //{

            //if (name is not null && numbers is not null)
            //{
            //    for (int i = 0; i < name.Length; i++) 
            //    { 
            //        if (name[i] == personname)
            //            return numbers[i];

                
            //    }

            //}
            //    return -1;

                 
        
       // }

       // public void setname(string personname,int newnumber) 
       // {
            //if (name is not null && numbers is not null)
            //{ for (int i = 0;i <= name.Length;i++)
            //        if (name[i]==personname)
            //        {
            //            numbers[i] = newnumber;
            //            break;

            //        }
            
            
            //}
                
                
                
                
                
                
       // }




        #endregion

        #region indexer
        //special prop
        //can take parameter
      //  public int this[string Name]
        //{
        //
        //    get
        //    {
        //        if (name is not null && numbers is not null)
        //            for (int i = 0; i < name.Length; i++)
        //            {
        //                if (name[i] == Name)
        //                    return numbers[i];
        //            }              
        //        return -1;
        //    }

        //    set
        //    {


        //        if (name is not null && numbers is not null)
        //        {
        //            for (int i = 0; i <= name.Length; i++)
        //                if (name[i] == Name)
        //                {
        //                    numbers[i] = value;
        //                    break;

        //                }


        //        }


        //    }




        //}

        //public string this[int Name]
        //{
        //    get 
        //    {
        //        return $"{Name}::{name[Name]}::{numbers[Name]}";
            

            
        //    }
         
        //}


        #endregion

    }
}
