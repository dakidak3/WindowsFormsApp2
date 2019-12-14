namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Фурнитура
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Фурнитура()
        {
            СкладФурнитуры = new HashSet<СкладФурнитуры>();
            ФурнитураИзделия = new HashSet<ФурнитураИзделия>();
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

        [StringLength(50)]
        public string Длина { get; set; }

        [StringLength(10)]
        public string Тип { get; set; }

        public double Цена { get; set; }

        public string Изображение { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<СкладФурнитуры> СкладФурнитуры { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ФурнитураИзделия> ФурнитураИзделия { get; set; }
    }
}
