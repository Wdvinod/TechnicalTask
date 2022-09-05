using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalTask.Data.Migrations
{
    public partial class InitialDatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "FinanceRateType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceRateType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinanceType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Make",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Make", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Finance",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakeId = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    FinanceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Finance_FinanceType_FinanceTypeId",
                        column: x => x.FinanceTypeId,
                        principalSchema: "dbo",
                        principalTable: "FinanceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Finance_Make_MakeId",
                        column: x => x.MakeId,
                        principalSchema: "dbo",
                        principalTable: "Make",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Finance_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalSchema: "dbo",
                        principalTable: "VehicleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinanceRate",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinanceId = table.Column<int>(type: "int", nullable: false),
                    FinanceRateTypeId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinanceRate_Finance_FinanceId",
                        column: x => x.FinanceId,
                        principalSchema: "dbo",
                        principalTable: "Finance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinanceRate_FinanceRateType_FinanceRateTypeId",
                        column: x => x.FinanceRateTypeId,
                        principalSchema: "dbo",
                        principalTable: "FinanceRateType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Finance_FinanceTypeId",
                schema: "dbo",
                table: "Finance",
                column: "FinanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Finance_MakeId",
                schema: "dbo",
                table: "Finance",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Finance_VehicleTypeId",
                schema: "dbo",
                table: "Finance",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceRate_FinanceId",
                schema: "dbo",
                table: "FinanceRate",
                column: "FinanceId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceRate_FinanceRateTypeId",
                schema: "dbo",
                table: "FinanceRate",
                column: "FinanceRateTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinanceRate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Finance",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FinanceRateType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FinanceType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Make",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "VehicleType",
                schema: "dbo");
        }
    }
}
