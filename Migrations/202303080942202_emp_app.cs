namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emp_app : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Productname = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Categoryname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nims");
        }
    }
}
