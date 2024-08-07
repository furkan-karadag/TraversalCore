﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
	public partial class project_initialization : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "About2s",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Title1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Title2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_About2s", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "Abouts",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Title2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Decription2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Abouts", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "Contacts",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
					MapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Contacts", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "Destinations",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					City = table.Column<string>(type: "nvarchar(max)", nullable: false),
					DayNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Price = table.Column<double>(type: "float", nullable: false),
					Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Capacity = table.Column<int>(type: "int", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Destinations", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "Feature2s",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Tİtle = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Feature2s", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "Features",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Features", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "Guides",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
					TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
					InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Guides", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "Newsletters",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Newsletters", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "SubAbouts",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_SubAbouts", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "Testimonials",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Client = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ClientImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Testimonials", x => x.ID);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "About2s");

			migrationBuilder.DropTable(
				name: "Abouts");

			migrationBuilder.DropTable(
				name: "Contacts");

			migrationBuilder.DropTable(
				name: "Destinations");

			migrationBuilder.DropTable(
				name: "Feature2s");

			migrationBuilder.DropTable(
				name: "Features");

			migrationBuilder.DropTable(
				name: "Guides");

			migrationBuilder.DropTable(
				name: "Newsletters");

			migrationBuilder.DropTable(
				name: "SubAbouts");

			migrationBuilder.DropTable(
				name: "Testimonials");
		}
	}
}
