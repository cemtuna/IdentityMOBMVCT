namespace MvcWebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialApplicationDbContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DSS.CEM_LU_IL",
                c => new
                    {
                        ID_IL = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        DS_IL = c.String(),
                        DS_PLAKA = c.String(),
                    })
                .PrimaryKey(t => t.ID_IL);
            
            CreateTable(
                "DSS.CEM_TEST_MIG",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("DSS.CEM_TEST_MIG");
            DropTable("DSS.CEM_LU_IL");
        }
    }
}
