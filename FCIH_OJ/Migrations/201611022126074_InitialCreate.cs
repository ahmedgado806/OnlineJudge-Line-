namespace FCIH_OJ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        User_ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
