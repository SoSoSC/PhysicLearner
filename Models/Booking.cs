namespace PhysicLeaner.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime booking_time { get; set; }
        [Required]
        public int courseID { get; set; }


        [StringLength(128)]
        public string userID { get; set; }

        public virtual AspNetRole AspNetRole { get; set; }

        public virtual Course Course { get; set; }
    }
}
