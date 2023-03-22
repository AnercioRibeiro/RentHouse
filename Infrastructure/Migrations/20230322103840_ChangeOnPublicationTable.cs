using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeOnPublicationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Counties_CountyId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Provinces_ProvinceId",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "PublicationCountyId",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "PublicationProvinceId",
                table: "Publications");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinceId",
                table: "Publications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountyId",
                table: "Publications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Counties_CountyId",
                table: "Publications",
                column: "CountyId",
                principalTable: "Counties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Provinces_ProvinceId",
                table: "Publications",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Counties_CountyId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Provinces_ProvinceId",
                table: "Publications");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinceId",
                table: "Publications",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CountyId",
                table: "Publications",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "PublicationCountyId",
                table: "Publications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublicationProvinceId",
                table: "Publications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Counties_CountyId",
                table: "Publications",
                column: "CountyId",
                principalTable: "Counties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Provinces_ProvinceId",
                table: "Publications",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id");
        }
    }
}
