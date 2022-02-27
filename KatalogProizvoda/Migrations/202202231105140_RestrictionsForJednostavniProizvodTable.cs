namespace KatalogProizvoda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestrictionsForJednostavniProizvodTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JednostavniProizvods", "CD", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.JednostavniProizvods", "SmartTv", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.JednostavniProizvods", "Smartphone", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.JednostavniProizvods", "Knjiga", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.JednostavniProizvods", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JednostavniProizvods", "MyProperty", c => c.String());
            AlterColumn("dbo.JednostavniProizvods", "Knjiga", c => c.String());
            DropColumn("dbo.JednostavniProizvods", "Smartphone");
            DropColumn("dbo.JednostavniProizvods", "SmartTv");
            DropColumn("dbo.JednostavniProizvods", "CD");
        }
    }
}
