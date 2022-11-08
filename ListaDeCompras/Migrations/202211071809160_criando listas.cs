namespace ListaDeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criandolistas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Listas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false, storeType: "date"),
                        EstaAtiva = c.Boolean(nullable: false),
                        Total = c.Double(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Listas");
        }
    }
}
