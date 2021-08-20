namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableEletronico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eletronicoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nome = c.String(),
                        Marca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Eletronicoes");
        }
    }
}
