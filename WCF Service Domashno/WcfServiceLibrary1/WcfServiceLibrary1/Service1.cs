using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        /// <summary>
        /// Lista od site Employee
        /// </summary>
     public static  List<Employee> lstEmployees = new List<Employee>(){

                              new Employee{EmployeeID=1,FirstName="Adam", LastName="Daniel",Age=25,},

                              new Employee{EmployeeID=2,FirstName="Calvin",LastName="Klain",Age=35},

                              new Employee{EmployeeID=3,FirstName="Kurt",LastName="Delgado",Age=28}

      };


        /// <summary>
        /// Brishenje na Employee spored Id 
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>

        public bool DeleteEmployee(int Cid)
        {
            var item = lstEmployees.First(x => x.EmployeeID == Cid);

            lstEmployees.Remove(item);
            return true;
        }

       
        /// <summary>
        /// Vrakja lista od site employees
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployeesData()
        {
                        

            return lstEmployees;

        }
        /// <summary>
        /// Vnesuvanje na employee vo lista
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool InsertEmployee(Employee obj)
        {
            lstEmployees.Add(obj);
            return true;
        }

       


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}
