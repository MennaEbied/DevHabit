using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevHabit.Api.Migrations.Application;

/// <inheritdoc />
public partial class M : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "fk_habit_tags_tag_tag_id",
            schema: "dev_habit",
            table: "habit_tags");

        migrationBuilder.DropPrimaryKey(
            name: "pk_tag",
            schema: "dev_habit",
            table: "tag");

        migrationBuilder.RenameTable(
            name: "tag",
            schema: "dev_habit",
            newName: "tags",
            newSchema: "dev_habit");

        migrationBuilder.RenameIndex(
            name: "ix_tag_name",
            schema: "dev_habit",
            table: "tags",
            newName: "ix_tags_name");

        migrationBuilder.AddPrimaryKey(
            name: "pk_tags",
            schema: "dev_habit",
            table: "tags",
            column: "id");

        migrationBuilder.AddForeignKey(
            name: "fk_habit_tags_tags_tag_id",
            schema: "dev_habit",
            table: "habit_tags",
            column: "tag_id",
            principalSchema: "dev_habit",
            principalTable: "tags",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "fk_habit_tags_tags_tag_id",
            schema: "dev_habit",
            table: "habit_tags");

        migrationBuilder.DropPrimaryKey(
            name: "pk_tags",
            schema: "dev_habit",
            table: "tags");

        migrationBuilder.RenameTable(
            name: "tags",
            schema: "dev_habit",
            newName: "tag",
            newSchema: "dev_habit");

        migrationBuilder.RenameIndex(
            name: "ix_tags_name",
            schema: "dev_habit",
            table: "tag",
            newName: "ix_tag_name");

        migrationBuilder.AddPrimaryKey(
            name: "pk_tag",
            schema: "dev_habit",
            table: "tag",
            column: "id");

        migrationBuilder.AddForeignKey(
            name: "fk_habit_tags_tag_tag_id",
            schema: "dev_habit",
            table: "habit_tags",
            column: "tag_id",
            principalSchema: "dev_habit",
            principalTable: "tag",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);
    }
}
