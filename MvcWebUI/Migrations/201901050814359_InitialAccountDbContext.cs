namespace MvcWebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialAccountDbContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DSS.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "DSS.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("DSS.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("DSS.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "DSS.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        UserFull = c.String(),
                        UserTypeId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        FirmId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        DealerId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        BirthDate = c.DateTime(nullable: false),
                        MaritalStatus = c.Decimal(nullable: false, precision: 10, scale: 0),
                        TcIdentity = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Decimal(nullable: false, precision: 1, scale: 0),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Decimal(nullable: false, precision: 1, scale: 0),
                        TwoFactorEnabled = c.Decimal(nullable: false, precision: 1, scale: 0),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Decimal(nullable: false, precision: 1, scale: 0),
                        AccessFailedCount = c.Decimal(nullable: false, precision: 10, scale: 0),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "DSS.AspNetUserClaims",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("DSS.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "DSS.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("DSS.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            DropTable("DSS.CEM_LU_IL");
            DropTable("DSS.CEM_TEST_MIG");
        }
        
        public override void Down()
        {
            CreateTable(
                "DSS.CEM_TEST_MIG",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "DSS.CEM_LU_IL",
                c => new
                    {
                        ID_IL = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        DS_IL = c.String(),
                        DS_PLAKA = c.String(),
                    })
                .PrimaryKey(t => t.ID_IL);
            
            DropForeignKey("DSS.AspNetUserRoles", "UserId", "DSS.AspNetUsers");
            DropForeignKey("DSS.AspNetUserLogins", "UserId", "DSS.AspNetUsers");
            DropForeignKey("DSS.AspNetUserClaims", "UserId", "DSS.AspNetUsers");
            DropForeignKey("DSS.AspNetUserRoles", "RoleId", "DSS.AspNetRoles");
            DropIndex("DSS.AspNetUserLogins", new[] { "UserId" });
            DropIndex("DSS.AspNetUserClaims", new[] { "UserId" });
            DropIndex("DSS.AspNetUsers", "UserNameIndex");
            DropIndex("DSS.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("DSS.AspNetUserRoles", new[] { "UserId" });
            DropIndex("DSS.AspNetRoles", "RoleNameIndex");
            DropTable("DSS.AspNetUserLogins");
            DropTable("DSS.AspNetUserClaims");
            DropTable("DSS.AspNetUsers");
            DropTable("DSS.AspNetUserRoles");
            DropTable("DSS.AspNetRoles");
        }
    }
}
