using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10298613_ContractMonthlyClaimSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddIdToClaim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClaimId",
                table: "Claims",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Claims",
                newName: "ClaimId");
        }
    }
}
