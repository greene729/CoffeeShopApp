using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeShopApp.Migrations
{
    public partial class updateReservationTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubMenu_Menus_Menuid",
                table: "SubMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Type",
                table: "Type");

            migrationBuilder.RenameTable(
                name: "Type",
                newName: "Reservations");

            migrationBuilder.RenameColumn(
                name: "Menuid",
                table: "SubMenu",
                newName: "MenuId");

            migrationBuilder.RenameIndex(
                name: "IX_SubMenu_Menuid",
                table: "SubMenu",
                newName: "IX_SubMenu_MenuId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Menus",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubMenu_Menus_MenuId",
                table: "SubMenu",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubMenu_Menus_MenuId",
                table: "SubMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "SubMenu",
                newName: "Menuid");

            migrationBuilder.RenameIndex(
                name: "IX_SubMenu_MenuId",
                table: "SubMenu",
                newName: "IX_SubMenu_Menuid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Menus",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Type",
                table: "Type",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubMenu_Menus_Menuid",
                table: "SubMenu",
                column: "Menuid",
                principalTable: "Menus",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
