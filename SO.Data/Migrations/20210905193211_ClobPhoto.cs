using Microsoft.EntityFrameworkCore.Migrations;

namespace SO.Data.Migrations
{
    public partial class ClobPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SO_PRODUCT",
                keyColumn: "ID",
                keyValue: "64982f06-d152-4231-abdd-6ac9945d91a0");

            migrationBuilder.DeleteData(
                table: "SO_PRODUCT",
                keyColumn: "ID",
                keyValue: "9f4dd069-799b-4603-82a0-074d22513021");

            migrationBuilder.DeleteData(
                table: "SO_PRODUCT",
                keyColumn: "ID",
                keyValue: "b2a11779-39f8-441e-961e-90f0cfd2b8d1");

            migrationBuilder.DeleteData(
                table: "SO_STORE",
                keyColumn: "ID",
                keyValue: "17c7fab7-cb23-4612-9410-db0bc0032242");

            migrationBuilder.AlterColumn<string>(
                name: "IMAGE",
                table: "SO_PHOTO",
                type: "blob",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "clob");

            migrationBuilder.InsertData(
                table: "SO_STORE",
                columns: new[] { "ID", "NAME" },
                values: new object[] { "a9ef8d81-f7f0-4e00-ac25-076dd83d117f", "Store Like Test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SO_STORE",
                keyColumn: "ID",
                keyValue: "a9ef8d81-f7f0-4e00-ac25-076dd83d117f");

            migrationBuilder.AlterColumn<string>(
                name: "IMAGE",
                table: "SO_PHOTO",
                type: "clob",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "blob");

            migrationBuilder.InsertData(
                table: "SO_PRODUCT",
                columns: new[] { "ID", "DESCRIPTION", "NAME", "PhotoId", "PRICE", "QUANTITY", "STORE_ID" },
                values: new object[] { "9f4dd069-799b-4603-82a0-074d22513021", "Keyboard gamer Ranger RGB", "Keyboard Gamer", null, 190.9m, 12, "a77ff437-ff34-4717-8d4e-83e74d925452" });

            migrationBuilder.InsertData(
                table: "SO_PRODUCT",
                columns: new[] { "ID", "DESCRIPTION", "NAME", "PhotoId", "PRICE", "QUANTITY", "STORE_ID" },
                values: new object[] { "b2a11779-39f8-441e-961e-90f0cfd2b8d1", "Graphics Video GTX 1660 OC", "Graphics Video GTX 1660 OC", null, 300.0m, 3, "a77ff437-ff34-4717-8d4e-83e74d925452" });

            migrationBuilder.InsertData(
                table: "SO_PRODUCT",
                columns: new[] { "ID", "DESCRIPTION", "NAME", "PhotoId", "PRICE", "QUANTITY", "STORE_ID" },
                values: new object[] { "64982f06-d152-4231-abdd-6ac9945d91a0", "Headset Evolut", "Headset Evolut", null, 63.78m, 79, "a77ff437-ff34-4717-8d4e-83e74d925452" });

            migrationBuilder.InsertData(
                table: "SO_STORE",
                columns: new[] { "ID", "NAME" },
                values: new object[] { "17c7fab7-cb23-4612-9410-db0bc0032242", "Store Like Test" });
        }
    }
}
