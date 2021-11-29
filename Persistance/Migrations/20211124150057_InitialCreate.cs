using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Steppers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: true),
                    IsVisited = table.Column<bool>(type: "INTEGER", nullable: true),
                    NodeStepNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    NodeTextHTMLElement = table.Column<string>(type: "TEXT", nullable: true),
                    NodeStepNumberHTMLElement = table.Column<string>(type: "TEXT", nullable: true),
                    IsHidden = table.Column<bool>(type: "INTEGER", nullable: true),
                    IsSubNode = table.Column<bool>(type: "INTEGER", nullable: true),
                    IsChildNode = table.Column<bool>(type: "INTEGER", nullable: true),
                    NodeType = table.Column<string>(type: "TEXT", nullable: true),
                    IsComplete = table.Column<bool>(type: "INTEGER", nullable: true),
                    ChildList = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayNodeNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    DisplayPercentForParentNode = table.Column<decimal>(type: "TEXT", nullable: true),
                    ParentCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steppers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Steppers");
        }
    }
}
