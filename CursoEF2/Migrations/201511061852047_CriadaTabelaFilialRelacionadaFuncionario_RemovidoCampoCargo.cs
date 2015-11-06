namespace CursoEF2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriadaTabelaFilialRelacionadaFuncionario_RemovidoCampoCargo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RazaoSocial = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Funcionarios", "filial_Id", c => c.Int());
            CreateIndex("dbo.Funcionarios", "filial_Id");
            AddForeignKey("dbo.Funcionarios", "filial_Id", "dbo.Filials", "Id");
            DropColumn("dbo.Funcionarios", "Cargo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Funcionarios", "Cargo", c => c.String());
            DropForeignKey("dbo.Funcionarios", "filial_Id", "dbo.Filials");
            DropIndex("dbo.Funcionarios", new[] { "filial_Id" });
            DropColumn("dbo.Funcionarios", "filial_Id");
            DropTable("dbo.Filials");
        }
    }
}
