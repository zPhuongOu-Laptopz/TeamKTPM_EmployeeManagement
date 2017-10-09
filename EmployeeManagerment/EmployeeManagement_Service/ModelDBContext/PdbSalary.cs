namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbSalary")]
    public partial class PdbSalary
    {
        [Key]
        public Guid IDSalary { get; set; }

        public Guid IDStaff { get; set; }

        public virtual PdbStaff PdbStaff { get; set; }
    }
}
