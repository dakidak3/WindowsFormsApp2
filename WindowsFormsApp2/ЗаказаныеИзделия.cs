namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ЗаказаныеИзделия
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string АртикулИзделия { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string НомерЗаказа { get; set; }

        public int Количество { get; set; }

        public virtual Заказ Заказ { get; set; }

        public virtual Изделие Изделие { get; set; }
    }
}
