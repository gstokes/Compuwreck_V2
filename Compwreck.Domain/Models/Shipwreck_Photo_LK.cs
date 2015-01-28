namespace Compwreck.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shipwreck_Photo_LK
    {
        public int id { get; set; }

        public int Shipwreck_id { get; set; }

        public int Photo_id { get; set; }

        public virtual Photo Photo { get; set; }

        public virtual Shipwreck Shipwreck { get; set; }
    }
}
