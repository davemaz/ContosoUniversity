namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnFirstNameFix1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "FirstName", newName: "FirstNameFix");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Student", name: "FirstNameFix", newName: "FirstName");
        }
    }
}
