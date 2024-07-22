using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class music2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicFiles_Albums_AlbumId",
                table: "MusicFiles");

            migrationBuilder.DropIndex(
                name: "IX_MusicFiles_AlbumId",
                table: "MusicFiles");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "MusicFiles");

            migrationBuilder.AlterColumn<string>(
                name: "Lenght",
                table: "MusicFiles",
                type: "text",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "interval");

            migrationBuilder.AddColumn<List<int>>(
                name: "MusicFiles",
                table: "Albums",
                type: "integer[]",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MusicFiles",
                table: "Albums");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Lenght",
                table: "MusicFiles",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "MusicFiles",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MusicFiles_AlbumId",
                table: "MusicFiles",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicFiles_Albums_AlbumId",
                table: "MusicFiles",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id");
        }
    }
}
