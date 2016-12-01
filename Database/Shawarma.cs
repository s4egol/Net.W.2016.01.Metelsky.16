namespace Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shawarma")]
    public partial class Shawarma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shawarma()
        {
            PriceController = new HashSet<PriceController>();
            OrderDetails = new HashSet<OrderDetails>();
            ShawarmaRecipe = new HashSet<ShawarmaRecipe>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShawarmaId { get; set; }

        [StringLength(80)]
        public string ShawarmaName { get; set; }

        public int CookingTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceController> PriceController { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShawarmaRecipe> ShawarmaRecipe { get; set; }
    }
}
