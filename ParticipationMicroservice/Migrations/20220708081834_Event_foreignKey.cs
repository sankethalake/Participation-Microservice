using Microsoft.EntityFrameworkCore.Migrations;

namespace ParticipationMicroservice.Migrations
{
    public partial class Event_foreignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Events_EventId",
                table: "Participations");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "Participations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Events_EventId",
                table: "Participations",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Events_EventId",
                table: "Participations");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "Participations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Events_EventId",
                table: "Participations",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
