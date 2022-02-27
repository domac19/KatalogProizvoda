namespace KatalogProizvoda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestrictionsForProizvodZaPreuzimanjeTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProizvodZaPreuzimanjes", "Fotografija", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ProizvodZaPreuzimanjes", "Video", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ProizvodZaPreuzimanjes", "OperativniSustav", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.ProizvodZaPreuzimanjes", "WebAplikacija", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProizvodZaPreuzimanjes", "WebAplikacija", c => c.String());
            AlterColumn("dbo.ProizvodZaPreuzimanjes", "OperativniSustav", c => c.String());
            AlterColumn("dbo.ProizvodZaPreuzimanjes", "Video", c => c.String());
            AlterColumn("dbo.ProizvodZaPreuzimanjes", "Fotografija", c => c.String());
        }
    }
}
