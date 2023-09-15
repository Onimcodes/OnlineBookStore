using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookStore.Api.Migrations
{
    public partial class editedOrderitemagainagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Books_BookId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ISBN", "Price", "StockQuantity", "Title" },
                values: new object[] { 1, "Micheal", "bbbqo", 70m, 3, "No Evidence" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ISBN", "Price", "StockQuantity", "Title" },
                values: new object[] { 2, "Abraham", "bbbqp", 45m, 3, "Pain and Gain" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ISBN", "Price", "StockQuantity", "Title" },
                values: new object[] { 3, "Brad", "bbbqq", 30m, 3, "Talodabi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Books_BookId",
                table: "OrderItem",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
