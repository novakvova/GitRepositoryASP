namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatetblWorkersandtblDepartments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblDepartments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(maxLength: 2000),
                        Image = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblWorkers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Fathername = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        PasswordSalt = c.String(nullable: false, maxLength: 255),
                        DepatrmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblDepartments", t => t.DepatrmentId, cascadeDelete: true)
                .Index(t => t.DepatrmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblWorkers", "DepatrmentId", "dbo.tblDepartments");
            DropIndex("dbo.tblWorkers", new[] { "DepatrmentId" });
            DropTable("dbo.tblWorkers");
            DropTable("dbo.tblDepartments");
        }
    }
}
