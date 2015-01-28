namespace Compwreck.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("County")]
    public partial class County
    {
        public County()
        {
            Shipwrecks = new HashSet<Shipwreck>();
        }

        [Key]
        public int County_id { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public virtual ICollection<Shipwreck> Shipwrecks { get; set; }
    }
}
