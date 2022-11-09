namespace ListaDeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class consertandocascade : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.ProdutoSupermercado", "CodigoProduto", "dbo.Produtos");
            DropForeignKey("dbo.ProdutoSupermercado", "IdSupermercado", "dbo.Supermercados");
            AddForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.ProdutoSupermercado", "CodigoProduto", "dbo.Produtos", "CodigoDeBarras");
            AddForeignKey("dbo.ProdutoSupermercado", "IdSupermercado", "dbo.Supermercados", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProdutoSupermercado", "IdSupermercado", "dbo.Supermercados");
            DropForeignKey("dbo.ProdutoSupermercado", "CodigoProduto", "dbo.Produtos");
            DropForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios");
            AddForeignKey("dbo.ProdutoSupermercado", "IdSupermercado", "dbo.Supermercados", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProdutoSupermercado", "CodigoProduto", "dbo.Produtos", "CodigoDeBarras", cascadeDelete: true);
            AddForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios", "Id", cascadeDelete: true);
        }
    }
}
