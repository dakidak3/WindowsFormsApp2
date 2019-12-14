namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ткань
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ткань()
        {
            СкладТкани = new HashSet<СкладТкани>();
            Изделие = new HashSet<Изделие>();
        }

        [Key]
        [StringLength(50)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [StringLength(50)]
        public string Цвет { get; set; }

        [StringLength(50)]
        public string Рисунок { get; set; }

        [StringLength(50)]
        public string Состав { get; set; }

        public double Ширина { get; set; }

        public double Длина { get; set; }

        public double Цена { get; set; }

        public string Изображение { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<СкладТкани> СкладТкани { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Изделие> Изделие { get; set; }
    }
}
