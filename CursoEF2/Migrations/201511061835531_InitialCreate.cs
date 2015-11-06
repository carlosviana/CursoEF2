namespace CursoEF2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cargo = c.String(),
                        Idade = c.Int(nullable: false),
                        departamento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentos", t => t.departamento_Id)
                .Index(t => t.departamento_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "departamento_Id", "dbo.Departamentos");
            DropIndex("dbo.Funcionarios", new[] { "departamento_Id" });
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Departamentos");
        }
    }
}
