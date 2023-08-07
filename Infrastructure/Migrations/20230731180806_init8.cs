using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInRole_Role_RoleId",
                table: "UserInRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInRole_User_UserId",
                table: "UserInRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInRole",
                table: "UserInRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.RenameTable(
                name: "UserInRole",
                newName: "UserInRoles");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameIndex(
                name: "IX_UserInRole_UserId",
                table: "UserInRoles",
                newName: "IX_UserInRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInRole_RoleId",
                table: "UserInRoles",
                newName: "IX_UserInRoles_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInRoles",
                table: "UserInRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AccessMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControlName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsShow = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleAceessMenuMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    AccessMenuId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAceessMenuMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleAceessMenuMaps_AccessMenus_AccessMenuId",
                        column: x => x.AccessMenuId,
                        principalTable: "AccessMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleAceessMenuMaps_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 31, 21, 38, 6, 456, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 31, 21, 38, 6, 457, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.CreateIndex(
                name: "IX_RoleAceessMenuMaps_AccessMenuId",
                table: "RoleAceessMenuMaps",
                column: "AccessMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAceessMenuMaps_RoleId",
                table: "RoleAceessMenuMaps",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInRoles_Roles_RoleId",
                table: "UserInRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInRoles_User_UserId",
                table: "UserInRoles",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInRoles_Roles_RoleId",
                table: "UserInRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInRoles_User_UserId",
                table: "UserInRoles");

            migrationBuilder.DropTable(
                name: "RoleAceessMenuMaps");

            migrationBuilder.DropTable(
                name: "AccessMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInRoles",
                table: "UserInRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.RenameTable(
                name: "UserInRoles",
                newName: "UserInRole");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameIndex(
                name: "IX_UserInRoles_UserId",
                table: "UserInRole",
                newName: "IX_UserInRole_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInRoles_RoleId",
                table: "UserInRole",
                newName: "IX_UserInRole_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInRole",
                table: "UserInRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 30, 21, 56, 23, 373, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 30, 21, 56, 23, 373, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.AddForeignKey(
                name: "FK_UserInRole_Role_RoleId",
                table: "UserInRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInRole_User_UserId",
                table: "UserInRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
