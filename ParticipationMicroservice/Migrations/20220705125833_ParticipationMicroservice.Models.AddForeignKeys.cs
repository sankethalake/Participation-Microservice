using Microsoft.EntityFrameworkCore.Migrations;

namespace ParticipationMicroservice.Migrations
{
    public partial class ParticipationMicroserviceModelsAddForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Events_EventId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Sports_SportsSportId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Sports_SportsSportId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Sports_Events_EventId",
                table: "Sports");

            migrationBuilder.DropIndex(
                name: "IX_Sports_EventId",
                table: "Sports");

            migrationBuilder.DropIndex(
                name: "IX_Players_SportsSportId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Participations_EventId",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Participations_SportsSportId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Sports");

            migrationBuilder.DropColumn(
                name: "SportsSportId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "SportsSportId",
                table: "Participations");

            migrationBuilder.AddColumn<int>(
                name: "Sport",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Event",
                table: "Participations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sport",
                table: "Participations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sport",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_Sport",
                table: "Players",
                column: "Sport");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_Event",
                table: "Participations",
                column: "Event");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_Sport",
                table: "Participations",
                column: "Sport");

            migrationBuilder.CreateIndex(
                name: "IX_Events_Sport",
                table: "Events",
                column: "Sport");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Sports_Sport",
                table: "Events",
                column: "Sport",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Events_Event",
                table: "Participations",
                column: "Event",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Sports_Sport",
                table: "Participations",
                column: "Sport",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Sports_Sport",
                table: "Players",
                column: "Sport",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Sports_Sport",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Events_Event",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Sports_Sport",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Sports_Sport",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_Sport",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Participations_Event",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Participations_Sport",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Events_Sport",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Sport",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Event",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "Sport",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "Sport",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Sports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SportsSportId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Participations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SportsSportId",
                table: "Participations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sports_EventId",
                table: "Sports",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_SportsSportId",
                table: "Players",
                column: "SportsSportId");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_EventId",
                table: "Participations",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_SportsSportId",
                table: "Participations",
                column: "SportsSportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Events_EventId",
                table: "Participations",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Sports_SportsSportId",
                table: "Participations",
                column: "SportsSportId",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Sports_SportsSportId",
                table: "Players",
                column: "SportsSportId",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sports_Events_EventId",
                table: "Sports",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
