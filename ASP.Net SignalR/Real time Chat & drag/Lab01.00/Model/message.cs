namespace Lab01._00.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("message")]
    public partial class message
    {
        [StringLength(10)]
        public string name { get; set; }

        [Column("message")]
        [StringLength(50)]
        public string message1 { get; set; }

        public DateTime? date { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
    }
}
