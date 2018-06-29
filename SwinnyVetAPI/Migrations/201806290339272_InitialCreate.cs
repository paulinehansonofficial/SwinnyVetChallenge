namespace SwinnyVetAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerID = c.Int(nullable: false, identity: true),
                        GivenName = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.OwnerID);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        PetID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        OwnerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PetID)
                .ForeignKey("dbo.Owners", t => t.OwnerID, cascadeDelete: true)
                .Index(t => t.OwnerID);
            
            CreateTable(
                "dbo.Procedures",
                c => new
                    {
                        ProcedureID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProcedureID);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        TreatmentID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Notes = c.String(),
                        PricePaid = c.Double(nullable: false),
                        PetID = c.Int(nullable: false),
                        ProcedureID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TreatmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "OwnerID", "dbo.Owners");
            DropIndex("dbo.Pets", new[] { "OwnerID" });
            DropTable("dbo.Treatments");
            DropTable("dbo.Procedures");
            DropTable("dbo.Pets");
            DropTable("dbo.Owners");
        }
    }
}
