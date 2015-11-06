namespace CursoEF2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncluidoCampoSalarioEmFuncionario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcionarios", "Salario", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Funcionarios", "Salario");
        }
    }
}
