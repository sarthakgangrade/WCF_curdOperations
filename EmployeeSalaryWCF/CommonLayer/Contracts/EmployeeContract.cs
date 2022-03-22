using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Contracts
{
    public class EmployeeContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int salary { get; set; }
        [DataMember]
        public string email { get; set; }
        
    }
}
