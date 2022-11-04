namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KategoriAditoKategoriAdInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAd", c => c.String());
            Sql("Update Kategoris Set KategoriAd=KategoriAdi");
            //Üstteki Kod: Rename yaparken aynı zamanda verileri de tutuyor.
            DropColumn("dbo.Kategoris", "KategoriAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriAdi", c => c.String());
            Sql("Update Kategoris Set KategoriAdi=KategoriAd");
            DropColumn("dbo.Kategoris", "KategoriAd");
        }
    }
}
