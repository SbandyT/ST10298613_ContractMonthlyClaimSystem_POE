using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10298613_ContractMonthlyClaimSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClaimModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LecturerName",
                table: "Claims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LecturerName",
                table: "Claims");
        }
    }
}
