using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace la_mia_pizzeria_static.Migrations
{
    public partial class AddTabIngredientiPivot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngredientePizza",
                columns: table => new
                {
                    ingredientsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pizzasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientePizza", x => new { x.ingredientsId, x.pizzasId });
                    table.ForeignKey(
                        name: "FK_IngredientePizza_Ingredienti_ingredientsId",
                        column: x => x.ingredientsId,
                        principalTable: "Ingredienti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientePizza_Pizza_pizzasId",
                        column: x => x.pizzasId,
                        principalTable: "Pizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientePizza_pizzasId",
                table: "IngredientePizza",
                column: "pizzasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientePizza");
        }
    }
}
