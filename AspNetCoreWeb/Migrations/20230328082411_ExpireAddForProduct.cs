﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreWeb.Migrations
{
    public partial class ExpireAddForProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Expire",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expire",
                table: "Products");
        }
    }
}
