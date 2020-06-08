using Microsoft.EntityFrameworkCore.Migrations;

namespace AjaxCRUDInASPNETCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    Departament = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    Salary = table.Column<double>(nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
