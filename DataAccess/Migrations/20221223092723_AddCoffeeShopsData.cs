using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCoffeeShopsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into CoffeeShop (Name, OpeningHours, Address) VALUES ('PJ','Coffee of New Orleans','9079 West Locust St. Buffalo, NY 14221')");
            migrationBuilder.Sql("insert into CoffeeShop (Name, OpeningHours, Address) VALUES ('NO','Coffee of Dej','Dej, Cluj Napoca, 402200')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
