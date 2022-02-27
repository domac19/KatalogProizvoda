namespace KatalogProizvoda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestrictionsToITProizvodModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ITProizvods", "Miš", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.ITProizvods", "Tipkovnica", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.ITProizvods", "Slušalice", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.ITProizvods", "Zvučnik", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.ITProizvods", "Kamera", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.ITProizvods", "Laptop", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.ITProizvods", "PC", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ITProizvods", "PC", c => c.String());
            AlterColumn("dbo.ITProizvods", "Laptop", c => c.String());
            AlterColumn("dbo.ITProizvods", "Kamera", c => c.String());
            AlterColumn("dbo.ITProizvods", "Zvučnik", c => c.String());
            AlterColumn("dbo.ITProizvods", "Slušalice", c => c.String());
            AlterColumn("dbo.ITProizvods", "Tipkovnica", c => c.String());
            AlterColumn("dbo.ITProizvods", "Miš", c => c.String());
        }
    }
}
