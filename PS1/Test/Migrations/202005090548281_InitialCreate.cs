namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ciudades",
                c => new
                    {
                        cityId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Pais = c.String(),
                    })
                .PrimaryKey(t => t.cityId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ciudades");
        }
    }
}
