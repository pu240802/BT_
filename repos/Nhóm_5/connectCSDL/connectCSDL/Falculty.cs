namespace connectCSDL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Falculty")]
    public partial class Falculty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int faculty_id { get; set; }

        [StringLength(30)]
        public string facultyName { get; set; }
    }
}
