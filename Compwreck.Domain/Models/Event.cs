namespace Compwreck.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        public Event()
        {
            Shipwrecks = new HashSet<Shipwreck>();
        }

        [Key]
        public int Event_id { get; set; }

        [Column("Event")]
        [StringLength(255)]
        public string Event1 { get; set; }

        [StringLength(300)]
        public string Event_Description { get; set; }

        public virtual ICollection<Shipwreck> Shipwrecks { get; set; }
    }
}
