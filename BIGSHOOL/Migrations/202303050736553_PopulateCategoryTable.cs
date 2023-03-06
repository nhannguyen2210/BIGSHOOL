namespace BIGSHOOL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO    categories(ID,NAME) VALUES (1,'Developmenty')");
            Sql("INSERT INTO categories(ID, NAME) VALUES(2,'Business')");
            Sql("INSERT INTO categories(ID,NAME) VALUES(3,'Maketing')");
        }
        
        public override void Down()
        {
        }
    }
}
