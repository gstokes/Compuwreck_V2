namespace Compwreck.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        [Key]
        public int Location_id { get; set; }

        public int Shipwreck_FK { get; set; }

        public double? LTD { get; set; }

        public double? LNG { get; set; }

        public string lat { get; set; }

        [Column("long")]
        public string _long { get; set; }

        public DbGeography GeoLocation { get; set; }

        public virtual Shipwreck Shipwreck { get; set; }
    }
}
