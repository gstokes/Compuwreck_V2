namespace Compwreck.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Photo")]
    public partial class Photo
    {
        public Photo()
        {
            Shipwreck_Photo_LK = new HashSet<Shipwreck_Photo_LK>();
        }

        [Key]
        public int Photo_id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Details { get; set; }

        [StringLength(50)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string URL { get; set; }

        public string Source { get; set; }

        public int Shipwreck_id { get; set; }

        public virtual ICollection<Shipwreck_Photo_LK> Shipwreck_Photo_LK { get; set; }
    }
}
