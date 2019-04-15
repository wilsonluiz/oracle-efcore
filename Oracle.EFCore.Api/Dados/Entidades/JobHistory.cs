using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oracle.EFCore.Api.Dados.Entidades
{
    [Description("")]
    [Table("JOB_HISTORY", Schema = "HR")]
    public class JobHistory
    {
        [Key]
        //[Column("EMPLOYEE_ID", Order = 0)]
        [Column("EMPLOYEE_ID")]
        [Description("")]
        public decimal EmployeeId { get; set; }

        [Column("START_DATE")]
        [Description("")]
        public DateTime StartDate { get; set; }

        [Column("END_DATE")]
        [Description("")]
        public DateTime EndDate { get; set; }

        //[Key]
        //[Column("JOB_ID", Order = 1)]
        [Column("JOB_ID")]
        [Description("")]
        public string JobId { get; set; }

        [Column("DEPARTMENT_ID")]
        [Description("")]
        public decimal? DepartmentId { get; set; }
    }
}