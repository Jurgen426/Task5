using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace WebApplicationMenu.Models
{
    public class MenuContext : DbContext
    { 
        public DbSet<Menu> Menus { get; set; }
    }

    public class DbInitializer : DropCreateDatabaseAlways<MenuContext>
    {
        protected override void Seed(MenuContext db)
        {
            db.Menus.Add(new Menu {Id = 1, Name = "Файл", ParentId = 0 });
            db.Menus.Add(new Menu {Id = 2, Name = "Правка", ParentId = 0 });
            db.Menus.Add(new Menu {Id = 3, Name = "Новый", ParentId = 1 });
            db.Menus.Add(new Menu {Id = 4, Name = "Открыть", ParentId = 1 });
            db.Menus.Add(new Menu {Id = 5, Name = "Отмена", ParentId = 2 });
            db.Menus.Add(new Menu {Id = 6, Name = "Повтор", ParentId = 2 });
            db.Menus.Add(new Menu {Id = 7, Name = "Поиск", ParentId = 0 });
            db.Menus.Add(new Menu {Id = 8, Name = "Найти", ParentId = 7 });
            db.Menus.Add(new Menu {Id = 9, Name = "Найти в файлах", ParentId = 7 });
            db.Menus.Add(new Menu { Id = 10, Name = "Преобразование регистра", ParentId = 7 });
            db.Menus.Add(new Menu { Id = 11, Name = "строчные", ParentId = 10 });
            db.Menus.Add(new Menu { Id = 12, Name = "ПРОПИСНЫЕ", ParentId = 10 });
            db.Menus.Add(new Menu { Id = 13, Name = "Таблица символов", ParentId = 2 });
            db.Menus.Add(new Menu { Id = 14, Name = "Справка", ParentId = 0 });
            db.Menus.Add(new Menu { Id = 15, Name = "О программе", ParentId = 14 });

            base.Seed(db);
        }
    }
}