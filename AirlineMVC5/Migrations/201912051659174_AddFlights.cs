namespace AirlineMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFlights : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        FlightID = c.Int(nullable: false, identity: true),
                        FlightNo = c.String(),
                        Airline = c.Int(nullable: false),
                        GateNo = c.String(),
                        TerminalNo = c.String(),
                        DepartureDateTime = c.DateTime(nullable: false),
                        ArrivalDateTime = c.DateTime(nullable: false),
                        ArrivalAirport_AirportID = c.String(maxLength: 128),
                        DepartureAirport_AirportID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.FlightID)
                .ForeignKey("dbo.Airports", t => t.ArrivalAirport_AirportID)
                .ForeignKey("dbo.Airports", t => t.DepartureAirport_AirportID)
                .Index(t => t.ArrivalAirport_AirportID)
                .Index(t => t.DepartureAirport_AirportID);
            
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        AirportID = c.String(nullable: false, maxLength: 128),
                        AirportName = c.String(),
                        NearestCity = c.String(),
                        Country = c.Int(nullable: false),
                        CountryCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AirportID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Flights", "DepartureAirport_AirportID", "dbo.Airports");
            DropForeignKey("dbo.Flights", "ArrivalAirport_AirportID", "dbo.Airports");
            DropIndex("dbo.Flights", new[] { "DepartureAirport_AirportID" });
            DropIndex("dbo.Flights", new[] { "ArrivalAirport_AirportID" });
            DropTable("dbo.Airports");
            DropTable("dbo.Flights");
        }
    }
}
