namespace _2_CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        EducatorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Educators", t => t.EducatorId, cascadeDelete: true)
                .Index(t => t.EducatorId);
            
            CreateTable(
                "dbo.Educators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Course_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Courses", "EducatorId", "dbo.Educators");
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropIndex("dbo.Courses", new[] { "EducatorId" });
            DropTable("dbo.Students");
            DropTable("dbo.Educators");
            DropTable("dbo.Courses");
        }
    }
}
