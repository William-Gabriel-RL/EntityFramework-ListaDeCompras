namespace ListaDeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class produtomapfotoagoraopcional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtos", "Foto", c => c.Binary(maxLength: 8000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "Foto", c => c.Binary(nullable: false, maxLength: 8000));
        }
    }
}
