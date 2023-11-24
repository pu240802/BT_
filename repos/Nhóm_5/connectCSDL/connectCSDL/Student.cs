namespace connectCSDL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        [StringLength(10)]
        public string student_id { get; set; }

        [StringLength(30)]
        public string fullname { get; set; }

        public double? averageScore { get; set; }

        public int? faculty_id { get; set; }
    }
}
