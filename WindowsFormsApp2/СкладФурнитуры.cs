namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class СкладФурнитуры
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Партия { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string АртикулФурнитуры { get; set; }

        public int Количество { get; set; }

        public virtual Фурнитура Фурнитура { get; set; }
    }
}
