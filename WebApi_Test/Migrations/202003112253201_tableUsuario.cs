namespace WebApi_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableUsuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        NombreEmpleado = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 50),
                        NombreUsuario = c.String(nullable: false, maxLength: 50),
                        ContraseniaUsuario = c.String(nullable: false, maxLength: 225),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
