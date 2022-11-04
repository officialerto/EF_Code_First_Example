using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityCodeFirst.Entity
{
    public class Context: DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
        //SQL DE DİREKT OLARAK EKLEME YAPILMIYOR HATA VERİYOR
        //VİEW -> OTHERS -> PACKAGE MANAGER CONSOLE TIKLA 
        //1- enable-migrations YAZ
        //2- Açılan Configuration tabında AutomaticMigrationsEnabled = false; kod kısmını true yap.
        //3- update-database YAZ VE BİTİR.
        //"Kod kısmında yaptığımız değişiklikleri veritabanına yansıtmaya Migration demekteyiz."
        public DbSet<Kategori> Kategori { get; set; }

    }
}
