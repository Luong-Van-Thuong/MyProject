using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sinhvien",
                columns: table => new
                {
                    oid = table.Column<string>(type: "TEXT", nullable: false),
                    nam_hoc = table.Column<string>(type: "TEXT", nullable: true),
                    chuyen_nganh = table.Column<string>(type: "TEXT", nullable: true),
                    ten = table.Column<string>(type: "TEXT", nullable: true),
                    que_quan = table.Column<string>(type: "TEXT", nullable: true),
                    ngay_sinh = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinhvien", x => x.oid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sinhvien");
        }
    }
}
