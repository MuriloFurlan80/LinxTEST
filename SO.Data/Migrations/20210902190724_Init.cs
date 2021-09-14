using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SO.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SO_STORE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "varchar(255)", nullable: false),
                    NAME = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SO_EXPENSE_TOTAL",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "varchar(255)", nullable: false),
                    VALUE = table.Column<decimal>(type: "decimal(10,5)", nullable: false, defaultValue: 0m),
                    STORE_ID = table.Column<Guid>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SO_EXPENSE_TOTAL_SO_STORE_STORE_ID",
                        column: x => x.STORE_ID,
                        principalTable: "SO_STORE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SO_PRODUCT",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "varchar(255)", nullable: false),
                    NAME = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PRICE = table.Column<decimal>(type: "decimal(10,5)", nullable: false, defaultValue: 0m),
                    DESCRIPTION = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    QUANTITY = table.Column<int>(type: "int", nullable: false),
                    STORE_ID = table.Column<Guid>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SO_PRODUCT_SO_STORE_STORE_ID",
                        column: x => x.STORE_ID,
                        principalTable: "SO_STORE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SO_COST_PURCHASE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "varchar(255)", nullable: false),
                    VALUE = table.Column<decimal>(type: "decimal(10,5)", nullable: false, defaultValue: 0m),
                    PRODUCT_ID = table.Column<Guid>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SO_COST_PURCHASE_SO_PRODUCT_PRODUCT_ID",
                        column: x => x.PRODUCT_ID,
                        principalTable: "SO_PRODUCT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SO_PHOTO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "varchar(255)", nullable: false),
                    PRODUCT_ID = table.Column<Guid>(type: "varchar(255)", nullable: false),
                    IMAGE = table.Column<string>(type: "clob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SO_PHOTO_SO_PRODUCT_PRODUCT_ID",
                        column: x => x.PRODUCT_ID,
                        principalTable: "SO_PRODUCT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SO_SALE_PRICE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "varchar(255)", nullable: false),
                    PRODUCT_ID = table.Column<Guid>(type: "varchar(255)", nullable: false),
                    PROFIT_MARGIN = table.Column<decimal>(type: "decimal(10,5)", nullable: true, defaultValue: 0m),
                    VALUE = table.Column<decimal>(type: "decimal(10,5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SO_SALE_PRICE_SO_PRODUCT_PRODUCT_ID",
                        column: x => x.PRODUCT_ID,
                        principalTable: "SO_PRODUCT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SO_COST_PURCHASE_PRODUCT_ID",
                table: "SO_COST_PURCHASE",
                column: "PRODUCT_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SO_EXPENSE_TOTAL_STORE_ID",
                table: "SO_EXPENSE_TOTAL",
                column: "STORE_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SO_PHOTO_PRODUCT_ID",
                table: "SO_PHOTO",
                column: "PRODUCT_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SO_PRODUCT_STORE_ID",
                table: "SO_PRODUCT",
                column: "STORE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SO_SALE_PRICE_PRODUCT_ID",
                table: "SO_SALE_PRICE",
                column: "PRODUCT_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SO_COST_PURCHASE");

            migrationBuilder.DropTable(
                name: "SO_EXPENSE_TOTAL");

            migrationBuilder.DropTable(
                name: "SO_PHOTO");

            migrationBuilder.DropTable(
                name: "SO_SALE_PRICE");

            migrationBuilder.DropTable(
                name: "SO_PRODUCT");

            migrationBuilder.DropTable(
                name: "SO_STORE");
        }
    }
}
