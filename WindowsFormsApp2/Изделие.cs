namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Изделие
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Изделие()
        {
            ЗаказаныеИзделия = new HashSet<ЗаказаныеИзделия>();
            ФурнитураИзделия = new HashSet<ФурнитураИзделия>();
            Ткань = new HashSet<Ткань>();
        }

        [Key]
        [StringLength(50)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(50)]
        public string Ширина { get; set; }

        [Required]
        [StringLength(50)]
        public string Длина { get; set; }

        public string Изображение { get; set; }

        [StringLength(50)]
        public string Коммаентарий { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЗаказаныеИзделия> ЗаказаныеИзделия { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ФурнитураИзделия> ФурнитураИзделия { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ткань> Ткань { get; set; }
    }
}
