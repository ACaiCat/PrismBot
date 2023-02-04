﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrismBot.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permissions",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Permissions",
                table: "Groups");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Permissions",
                table: "Players",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Permissions",
                table: "Groups",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}