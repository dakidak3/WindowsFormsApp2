namespace WindowsFormsApp2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<ЗаказаныеИзделия> ЗаказаныеИзделия { get; set; }
        public virtual DbSet<Изделие> Изделие { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<СкладТкани> СкладТкани { get; set; }
        public virtual DbSet<СкладФурнитуры> СкладФурнитуры { get; set; }
        public virtual DbSet<Ткань> Ткань { get; set; }
        public virtual DbSet<Фурнитура> Фурнитура { get; set; }
        public virtual DbSet<ФурнитураИзделия> ФурнитураИзделия { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .Property(e => e.Номер)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ>()
                .Property(e => e.ЭтапВыполнения)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ>()
                .Property(e => e.Заказчик)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ>()
                .Property(e => e.Менеджер)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ>()
                .HasMany(e => e.ЗаказаныеИзделия)
                .WithRequired(e => e.Заказ)
                .HasForeignKey(e => e.НомерЗаказа)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ЗаказаныеИзделия>()
                .Property(e => e.АртикулИзделия)
                .IsUnicode(false);

            modelBuilder.Entity<ЗаказаныеИзделия>()
                .Property(e => e.НомерЗаказа)
                .IsUnicode(false);

            modelBuilder.Entity<Изделие>()
                .Property(e => e.Артикул)
                .IsUnicode(false);

            modelBuilder.Entity<Изделие>()
                .Property(e => e.Наименование)
                .IsUnicode(false);

            modelBuilder.Entity<Изделие>()
                .Property(e => e.Ширина)
                .IsUnicode(false);

            modelBuilder.Entity<Изделие>()
                .Property(e => e.Длина)
                .IsUnicode(false);

            modelBuilder.Entity<Изделие>()
                .Property(e => e.Изображение)
                .IsUnicode(false);

            modelBuilder.Entity<Изделие>()
                .Property(e => e.Коммаентарий)
                .IsUnicode(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.ЗаказаныеИзделия)
                .WithRequired(e => e.Изделие)
                .HasForeignKey(e => e.АртикулИзделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.ФурнитураИзделия)
                .WithRequired(e => e.Изделие)
                .HasForeignKey(e => e.АртикулИзделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Ткань)
                .WithMany(e => e.Изделие)
                .Map(m => m.ToTable("ТканиИзделия").MapLeftKey("АртикулИзделия").MapRightKey("АртикулТкани"));

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Логин)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Пароль)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Роль)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Наименование)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .HasMany(e => e.Заказ)
                .WithOptional(e => e.Пользователь)
                .HasForeignKey(e => e.Менеджер);

            modelBuilder.Entity<Пользователь>()
                .HasMany(e => e.Заказ1)
                .WithRequired(e => e.Пользователь1)
                .HasForeignKey(e => e.Заказчик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<СкладТкани>()
                .Property(e => e.Рулон)
                .IsUnicode(false);

            modelBuilder.Entity<СкладТкани>()
                .Property(e => e.АртикулТкани)
                .IsUnicode(false);

            modelBuilder.Entity<СкладФурнитуры>()
                .Property(e => e.Партия)
                .IsUnicode(false);

            modelBuilder.Entity<СкладФурнитуры>()
                .Property(e => e.АртикулФурнитуры)
                .IsUnicode(false);

            modelBuilder.Entity<Ткань>()
                .Property(e => e.Артикул)
                .IsUnicode(false);

            modelBuilder.Entity<Ткань>()
                .Property(e => e.Наименование)
                .IsUnicode(false);

            modelBuilder.Entity<Ткань>()
                .Property(e => e.Цвет)
                .IsUnicode(false);

            modelBuilder.Entity<Ткань>()
                .Property(e => e.Рисунок)
                .IsUnicode(false);

            modelBuilder.Entity<Ткань>()
                .Property(e => e.Состав)
                .IsUnicode(false);

            modelBuilder.Entity<Ткань>()
                .Property(e => e.Изображение)
                .IsUnicode(false);

            modelBuilder.Entity<Ткань>()
                .HasMany(e => e.СкладТкани)
                .WithRequired(e => e.Ткань)
                .HasForeignKey(e => e.АртикулТкани)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Артикул)
                .IsUnicode(false);

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Наименование)
                .IsUnicode(false);

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Ширина)
                .IsUnicode(false);

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Длина)
                .IsUnicode(false);

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Тип)
                .IsFixedLength();

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Изображение)
                .IsUnicode(false);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.СкладФурнитуры)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.АртикулФурнитуры)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.ФурнитураИзделия)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.АртикулФурнитуры)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ФурнитураИзделия>()
                .Property(e => e.АртикулИзделия)
                .IsUnicode(false);

            modelBuilder.Entity<ФурнитураИзделия>()
                .Property(e => e.АртикулФурнитуры)
                .IsUnicode(false);

            modelBuilder.Entity<ФурнитураИзделия>()
                .Property(e => e.Размещение)
                .IsUnicode(false);

            modelBuilder.Entity<ФурнитураИзделия>()
                .Property(e => e.Ширина)
                .IsUnicode(false);

            modelBuilder.Entity<ФурнитураИзделия>()
                .Property(e => e.Длина)
                .IsUnicode(false);

            modelBuilder.Entity<ФурнитураИзделия>()
                .Property(e => e.Поворот)
                .IsUnicode(false);

            modelBuilder.Entity<ФурнитураИзделия>()
                .Property(e => e.Количество)
                .IsUnicode(false);
        }
    }
}
