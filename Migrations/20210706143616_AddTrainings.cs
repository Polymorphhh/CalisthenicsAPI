using Microsoft.EntityFrameworkCore.Migrations;

namespace CalisthenicsAPI.Migrations
{
    public partial class AddTrainings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainingId",
                table: "Sets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sets_TrainingId",
                table: "Sets",
                column: "TrainingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_Trainings_TrainingId",
                table: "Sets",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sets_Trainings_TrainingId",
                table: "Sets");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropIndex(
                name: "IX_Sets_TrainingId",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "TrainingId",
                table: "Sets");
        }
    }
}
