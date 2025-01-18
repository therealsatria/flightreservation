using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirAccess.Migrations
{
    /// <inheritdoc />
    public partial class migratedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Flights_FlightId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "FlightId",
                table: "Tickets",
                newName: "SeatId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_FlightId",
                table: "Tickets",
                newName: "IX_Tickets_SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Seats_SeatId",
                table: "Tickets",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Seats_SeatId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "SeatId",
                table: "Tickets",
                newName: "FlightId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_SeatId",
                table: "Tickets",
                newName: "IX_Tickets_FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Flights_FlightId",
                table: "Tickets",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
