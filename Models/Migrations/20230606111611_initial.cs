using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Office = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    SkypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Count", "Name" },
                values: new object[,]
                {
                    { "0b91a979-1155-46dc-b71f-6d6d95999ef5", 0, "MD" },
                    { "705f54e0-5062-41c2-a30d-88c396705f07", 0, "Sales" },
                    { "801d3461-ccf1-4cc7-aee3-0f261cfa6de1", 0, "Human Resources" },
                    { "d66a4cf6-6f30-451e-adab-0a6adcb55398", 0, "IT" }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "Count", "Title" },
                values: new object[,]
                {
                    { "0eded364-1bec-4d95-8e93-77c3ebf1f38a", 0, "BI Developer" },
                    { "76216765-8f2c-4e9d-8d38-1f7bd38064fd", 0, "SharePoint Practice Head" },
                    { "80329967-0488-4049-aa84-aa0a344f219f", 0, "Business Analyst" },
                    { "cbbefda7-4b5a-4284-988b-e37365fbe71f", 0, ".Net Development Lead" },
                    { "ffa3bb5b-7507-46e5-bc44-e3adc73fb008", 0, "Recruiting Expert" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Count", "CountryName" },
                values: new object[,]
                {
                    { "2000fb72-fe0f-439f-8c87-2210063dde43", 0, "India" },
                    { "3c73d466-84d3-4d36-933f-8ab2e2498b9f", 0, "Seattle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
