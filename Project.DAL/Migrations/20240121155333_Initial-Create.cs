using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirstAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MethodName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reports_Personels_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personels",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpenseStatus = table.Column<int>(type: "int", nullable: false),
                    ApprovmentDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PersonelDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PersonelID = table.Column<int>(type: "int", nullable: false),
                    ReportID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Expense_Personels_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personels",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expense_Reports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "Reports",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ExpenseFiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ExpenseID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseFiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExpenseFiles_Expense_ExpenseID",
                        column: x => x.ExpenseID,
                        principalTable: "Expense",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentLocation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ExpenseID = table.Column<int>(type: "int", nullable: false),
                    PaymentCategoryID = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payments_Expense_ExpenseID",
                        column: x => x.ExpenseID,
                        principalTable: "Expense",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentCategories_PaymentCategoryID",
                        column: x => x.PaymentCategoryID,
                        principalTable: "PaymentCategories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "ID", "CreationDate", "DeletedDate", "Email", "FirstName", "IsFirstAdmin", "LastName", "ModifiedDate", "Password", "Status", "UserName" },
                values: new object[] { 1, new DateTime(2024, 1, 21, 18, 53, 33, 702, DateTimeKind.Local).AddTicks(9075), null, "admin@admin.com", null, true, null, null, "admin", 0, "admin" });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "ID", "CreationDate", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedDate", "Password", "Status", "Title", "UserName" },
                values: new object[] { 1, new DateTime(2024, 1, 21, 18, 53, 33, 704, DateTimeKind.Local).AddTicks(3694), null, "personel@personel.com", "John", "Doe", null, "personel", 0, "Concstructor", "personel" });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_Email",
                table: "Admins",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserName",
                table: "Admins",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expense_PersonelID",
                table: "Expense",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ReportID",
                table: "Expense",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseFiles_ExpenseID",
                table: "ExpenseFiles",
                column: "ExpenseID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentCategories_CategoryName",
                table: "PaymentCategories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_MethodName",
                table: "PaymentMethods",
                column: "MethodName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ExpenseID",
                table: "Payments",
                column: "ExpenseID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentCategoryID",
                table: "Payments",
                column: "PaymentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodID",
                table: "Payments",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_Email",
                table: "Personels",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_UserName",
                table: "Personels",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_PersonelID",
                table: "Reports",
                column: "PersonelID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "ExpenseFiles");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "PaymentCategories");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Personels");
        }
    }
}
