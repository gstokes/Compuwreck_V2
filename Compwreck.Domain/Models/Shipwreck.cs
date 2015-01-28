namespace Compwreck.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipwreck")]
    public partial class Shipwreck
    {
        public Shipwreck()
        {
            Locations = new HashSet<Location>();
            Shipwreck_Photo_LK = new HashSet<Shipwreck_Photo_LK>();
        }

        [Key]
        public int Shipwreck_id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        [StringLength(255)]
        public string Dimensions { get; set; }

        [StringLength(255)]
        public string Tonnage { get; set; }

        [StringLength(255)]
        public string Armament { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateLost { get; set; }

        [StringLength(255)]
        public string DateExtn { get; set; }

        [StringLength(255)]
        public string Locality { get; set; }

        [StringLength(255)]
        public string PosExtn { get; set; }

        [StringLength(255)]
        public string Cargo { get; set; }

        [StringLength(255)]
        public string WindDir { get; set; }

        [StringLength(255)]
        public string WindForce { get; set; }

        [StringLength(255)]
        public string References { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        [Column("U-Boat")]
        [StringLength(255)]
        public string U_Boat { get; set; }

        public int? Event_FK { get; set; }

        public int? County_FK { get; set; }

        public virtual County County { get; set; }

        public virtual Event Event { get; set; }

        public virtual ICollection<Location> Locations { get; set; }

        public virtual ICollection<Shipwreck_Photo_LK> Shipwreck_Photo_LK { get; set; }
    }
}
