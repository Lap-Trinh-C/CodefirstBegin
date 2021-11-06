namespace projectAccessData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200),
                        Content = c.String(maxLength: 300),
                        WriteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Writers", t => t.WriteId, cascadeDelete: true)
                .Index(t => t.WriteId);
            
            CreateTable(
                "dbo.Writers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "WriteId", "dbo.Writers");
            DropIndex("dbo.Recipes", new[] { "WriteId" });
            DropTable("dbo.Writers");
            DropTable("dbo.Recipes");
        }
    }
}
