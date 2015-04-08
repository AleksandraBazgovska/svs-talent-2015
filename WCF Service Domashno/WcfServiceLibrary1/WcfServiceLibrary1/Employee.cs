using System;
using System.Collections.Generic;
using System.Linq;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    [DataContract]

    public class Employee
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int Age { get; set; }
    }
}
