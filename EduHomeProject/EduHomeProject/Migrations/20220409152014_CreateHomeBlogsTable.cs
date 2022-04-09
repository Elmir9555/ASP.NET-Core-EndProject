﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class CreateHomeBlogsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    CommentCount = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeBlogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeBlogs");
        }
    }
}
