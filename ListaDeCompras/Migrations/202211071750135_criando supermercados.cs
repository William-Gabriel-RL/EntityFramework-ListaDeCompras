namespace ListaDeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criandosupermercados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Supermercados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 70, unicode: false),
                        Logradouro = c.String(nullable: false, maxLength: 70, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 70, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 70, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 20, unicode: false),
                        CEP = c.String(nullable: false, maxLength: 9, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Supermercados");
        }
    }
}
