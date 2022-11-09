namespace ListaDeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionamentolistaproduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemDaListas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdLista = c.Int(nullable: false),
                        CodigoProduto = c.String(),
                        IdSupermercado = c.Int(nullable: false),
                        Preco = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Comprado = c.Boolean(nullable: false),
                        Lista_Id = c.Int(),
                        Produto_CodigoDeBarras = c.String(maxLength: 128),
                        Supermercado_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Listas", t => t.Lista_Id)
                .ForeignKey("dbo.Produtos", t => t.Produto_CodigoDeBarras)
                .ForeignKey("dbo.Supermercados", t => t.Supermercado_Id)
                .Index(t => t.Lista_Id)
                .Index(t => t.Produto_CodigoDeBarras)
                .Index(t => t.Supermercado_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemDaListas", "Supermercado_Id", "dbo.Supermercados");
            DropForeignKey("dbo.ItemDaListas", "Produto_CodigoDeBarras", "dbo.Produtos");
            DropForeignKey("dbo.ItemDaListas", "Lista_Id", "dbo.Listas");
            DropIndex("dbo.ItemDaListas", new[] { "Supermercado_Id" });
            DropIndex("dbo.ItemDaListas", new[] { "Produto_CodigoDeBarras" });
            DropIndex("dbo.ItemDaListas", new[] { "Lista_Id" });
            DropTable("dbo.ItemDaListas");
        }
    }
}
