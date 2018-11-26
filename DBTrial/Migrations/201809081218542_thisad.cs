namespace DBTrial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thisad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BareMembers", "nrEvents", c => c.Int(nullable: false));
            AddColumn("dbo.BareMembers", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BareMembers", "Amount");
            DropColumn("dbo.BareMembers", "nrEvents");
        }
    }
}
