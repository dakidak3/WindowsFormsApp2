namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ФурнитураИзделия
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string АртикулИзделия { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string АртикулФурнитуры { get; set; }

        [Required]
        [StringLength(50)]
        public string Размещение { get; set; }

        [Required]
        [StringLength(50)]
        public string Ширина { get; set; }

        [Required]
        [StringLength(50)]
        public string Длина { get; set; }

        [Required]
        [StringLength(50)]
        public string Поворот { get; set; }

        [Required]
        [StringLength(50)]
        public string Количество { get; set; }

        public virtual Изделие Изделие { get; set; }

        public virtual Фурнитура Фурнитура { get; set; }
    }
}
