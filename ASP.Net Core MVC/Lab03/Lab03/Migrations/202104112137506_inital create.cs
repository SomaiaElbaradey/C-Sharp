namespace Lab03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initalcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepatID = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.DepatID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                        DeptID = c.Int(nullable: false),
                        Department_DepatID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_DepatID)
                .Index(t => t.Department_DepatID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Department_DepatID", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "Department_DepatID" });
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
        }
    }
}
