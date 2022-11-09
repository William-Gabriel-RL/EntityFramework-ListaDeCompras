namespace ListaDeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criandoprodutoerelacaocomsupermercado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios");
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        CodigoDeBarras = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(nullable: false, maxLength: 70, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 70, unicode: false),
                        Foto = c.Binary(nullable: false, maxLength: 8000),
                    })
                .PrimaryKey(t => t.CodigoDeBarras);
            
            CreateTable(
                "dbo.ProdutoSupermercado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoProduto = c.String(nullable: false, maxLength: 128),
                        IdSupermercado = c.Int(nullable: false),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtos", t => t.CodigoProduto, cascadeDelete: true)
                .ForeignKey("dbo.Supermercados", t => t.IdSupermercado, cascadeDelete: true)
                .Index(t => t.CodigoProduto)
                .Index(t => t.IdSupermercado);
            
            AddForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.ProdutoSupermercado", "IdSupermercado", "dbo.Supermercados");
            DropForeignKey("dbo.ProdutoSupermercado", "CodigoProduto", "dbo.Produtos");
            DropIndex("dbo.ProdutoSupermercado", new[] { "IdSupermercado" });
            DropIndex("dbo.ProdutoSupermercado", new[] { "CodigoProduto" });
            DropTable("dbo.ProdutoSupermercado");
            DropTable("dbo.Produtos");
            AddForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios", "Id");
        }
    }
}
