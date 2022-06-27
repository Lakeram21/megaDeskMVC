using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaDesk.Migrations
{
    public partial class changeproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskQuote_Delivery_DeliveryTypeId",
                table: "DeskQuote");

            migrationBuilder.RenameColumn(
                name: "DeliveryTypeId",
                table: "DeskQuote",
                newName: "DeliveryId");

            migrationBuilder.RenameIndex(
                name: "IX_DeskQuote_DeliveryTypeId",
                table: "DeskQuote",
                newName: "IX_DeskQuote_DeliveryId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeskQuote_Delivery_DeliveryId",
                table: "DeskQuote",
                column: "DeliveryId",
                principalTable: "Delivery",
                principalColumn: "DeliveryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskQuote_Delivery_DeliveryId",
                table: "DeskQuote");

            migrationBuilder.RenameColumn(
                name: "DeliveryId",
                table: "DeskQuote",
                newName: "DeliveryTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_DeskQuote_DeliveryId",
                table: "DeskQuote",
                newName: "IX_DeskQuote_DeliveryTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeskQuote_Delivery_DeliveryTypeId",
                table: "DeskQuote",
                column: "DeliveryTypeId",
                principalTable: "Delivery",
                principalColumn: "DeliveryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
