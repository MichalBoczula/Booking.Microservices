using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Service.Persistance.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TermStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvailableTerms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    TermStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableTerms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailableTerms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableTerms_TermStatuses_TermStatusId",
                        column: x => x.TermStatusId,
                        principalTable: "TermStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookedTerms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailableTermId = table.Column<int>(type: "int", nullable: false),
                    PaymentStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedTerms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedTerms_AvailableTerms_AvailableTermId",
                        column: x => x.AvailableTermId,
                        principalTable: "AvailableTerms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookedTerms_PaymentStatuses_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalTable: "PaymentStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "President" },
                    { 2, "Bro" },
                    { 3, "Island" }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Accepted" },
                    { 2, "Declined" }
                });

            migrationBuilder.InsertData(
                table: "TermStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Booked" },
                    { 2, "Free" },
                    { 3, "Reserved" }
                });

            migrationBuilder.InsertData(
                table: "AvailableTerms",
                columns: new[] { "Id", "HotelId", "Month", "TermStatusId", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 2023 },
                    { 2, 1, 2, 1, 2023 },
                    { 3, 2, 1, 1, 2023 },
                    { 4, 2, 2, 1, 2023 },
                    { 5, 3, 1, 1, 2023 },
                    { 6, 3, 2, 1, 2023 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableTerms_HotelId",
                table: "AvailableTerms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableTerms_TermStatusId",
                table: "AvailableTerms",
                column: "TermStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedTerms_AvailableTermId",
                table: "BookedTerms",
                column: "AvailableTermId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookedTerms_PaymentStatusId",
                table: "BookedTerms",
                column: "PaymentStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookedTerms");

            migrationBuilder.DropTable(
                name: "AvailableTerms");

            migrationBuilder.DropTable(
                name: "PaymentStatuses");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "TermStatuses");
        }
    }
}
