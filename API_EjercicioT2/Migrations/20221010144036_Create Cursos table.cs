﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_EjercicioT2.Migrations
{
    public partial class CreateCursostable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(560)", maxLength: 560, nullable: false),
                    PublicObjective = table.Column<string>(type: "nvarchar(560)", maxLength: 560, nullable: false),
                    Objectives = table.Column<string>(type: "nvarchar(560)", maxLength: 560, nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(560)", maxLength: 560, nullable: false),
                    Createby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
