using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp_travel_agency.Data.Migrations
{
    public partial class FixMessageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelBox_Message_MessageId",
                table: "TravelBox");

            migrationBuilder.DropIndex(
                name: "IX_TravelBox_MessageId",
                table: "TravelBox");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "TravelBox");

            migrationBuilder.AddColumn<int>(
                name: "TravelBoxId",
                table: "Message",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_TravelBoxId",
                table: "Message",
                column: "TravelBoxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_TravelBox_TravelBoxId",
                table: "Message",
                column: "TravelBoxId",
                principalTable: "TravelBox",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_TravelBox_TravelBoxId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_TravelBoxId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "TravelBoxId",
                table: "Message");

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "TravelBox",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelBox_MessageId",
                table: "TravelBox",
                column: "MessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelBox_Message_MessageId",
                table: "TravelBox",
                column: "MessageId",
                principalTable: "Message",
                principalColumn: "Id");
        }
    }
}
