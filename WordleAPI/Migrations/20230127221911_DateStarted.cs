﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordleAPI.Migrations
{
    /// <inheritdoc />
    public partial class DateStarted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateStarted",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateStarted",
                table: "Games");
        }
    }
}
