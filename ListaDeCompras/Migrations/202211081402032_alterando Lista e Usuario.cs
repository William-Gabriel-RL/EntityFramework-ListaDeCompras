namespace ListaDeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterandoListaeUsuario : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Listas", "IdUsuario");
            AddForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Listas", "IdUsuario", "dbo.Usuarios");
            DropIndex("dbo.Listas", new[] { "IdUsuario" });
        }
    }
}
