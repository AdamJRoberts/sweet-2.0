namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Appointment", newName: "Appointments");
            RenameTable(name: "dbo.Ticket", newName: "Tickets");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Tickets", newName: "Ticket");
            RenameTable(name: "dbo.Appointments", newName: "Appointment");
        }
    }
}
