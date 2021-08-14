using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore_DBFirst_StoredProcedureDemo.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
