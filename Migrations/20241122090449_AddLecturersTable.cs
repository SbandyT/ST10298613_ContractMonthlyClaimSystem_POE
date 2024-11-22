using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10298613_ContractMonthlyClaimSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddLecturersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claims_Lecturers_LecturerId",
                table: "Claims");

            migrationBuilder.DropIndex(
                name: "IX_Claims_LecturerId",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Lecturers");

            migrationBuilder.DropColumn(
                name: "LecturerId",
                table: "Claims");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Lecturers",
                newName: "LecturerName");

            migrationBuilder.RenameColumn(
                name: "LecturerId",
                table: "Lecturers",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LecturerName",
                table: "Lecturers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lecturers",
                newName: "LecturerId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Lecturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LecturerId",
                table: "Claims",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Claims_LecturerId",
                table: "Claims",
                column: "LecturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Claims_Lecturers_LecturerId",
                table: "Claims",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "LecturerId");
        }
    }
}
