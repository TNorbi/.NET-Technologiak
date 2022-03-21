﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgoRythmicsAPI.Migrations
{
    public partial class AlgorithmCreationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "Algorithms",
                newName: "CreationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Algorithms",
                newName: "CreationTime");
        }
    }
}
