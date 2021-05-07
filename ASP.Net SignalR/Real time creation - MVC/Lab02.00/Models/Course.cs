namespace Lab02._00.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Crs_Id { get; set; }

        [StringLength(50)]
        public string Crs_Name { get; set; }

        public int? Crs_Duration { get; set; }

        public int? Top_Id { get; set; }
    }
}
