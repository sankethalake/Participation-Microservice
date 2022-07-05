using Microsoft.EntityFrameworkCore.Migrations;

namespace ParticipationMicroservice.Migrations
{
    public partial class ParticipationMicroserviceModelsAddeDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "sportType",
                table: "Sports",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SportName",
                table: "Sports",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlayerName",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SportId",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Participations",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EventName",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SportId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_SportId",
                table: "Players",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_EventId",
                table: "Participations",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SportId",
                table: "Events",
                column: "SportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Sports_SportId",
                table: "Events",
                column: "SportId",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Events_EventId",
                table: "Participations",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Sports_SportId",
                table: "Players",
                column: "SportId",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Sports_SportId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Events_EventId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Sports_SportId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_SportId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Participations_EventId",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Events_SportId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SportId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "SportId",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "sportType",
                table: "Sports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SportName",
                table: "Sports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PlayerName",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Sport",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Event",
                table: "Participations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sport",
                table: "Participations",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EventName",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Sport",
                table: "Events",
                type: "int",
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
    }
}
