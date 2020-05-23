using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestoNov_Back.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsDatabaseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recettes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recettes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientRecettes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RecetteId = table.Column<Guid>(nullable: false),
                    IngredientId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecettes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientRecettes_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecettes_Recettes_RecetteId",
                        column: x => x.RecetteId,
                        principalTable: "Recettes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("bc03fc19-b49d-491d-92dc-da40c25c2b2a"), null, "laitue" },
                    { new Guid("2621c4e7-9078-42d8-b99b-f4cf9423ee44"), null, "tomate" },
                    { new Guid("10e0c8f5-d0ae-4056-8023-a16e47a9ef4f"), null, "fromage" },
                    { new Guid("1ab96e05-985a-4de6-a948-7411ef469055"), null, "pain complet" },
                    { new Guid("7a146e38-9733-433f-aec3-573a8a3c9e56"), null, "pomme de terre" },
                    { new Guid("e211a41e-1626-477f-96db-cb9257136a21"), null, "carotte" },
                    { new Guid("f13df35e-d470-4a77-aee0-83139b07e5a2"), null, "crevette" },
                    { new Guid("3a75fca9-840e-4bf2-8b7d-833851d98528"), null, "crème fraîche" },
                    { new Guid("4fd570ef-2865-4dfa-9fe0-820a559f9a81"), null, "thon" }
                });

            migrationBuilder.InsertData(
                table: "Recettes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("7d6387ea-f6ce-4fc9-a0fe-12d2c4ba79b9"), null, "Salade" },
                    { new Guid("b8d4a8e5-5841-4a05-ab12-82ffc9fac312"), null, "Soupe" },
                    { new Guid("5591e362-aae1-4107-a083-438ed31d91f2"), null, "Pizza" }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecettes",
                columns: new[] { "Id", "IngredientId", "RecetteId" },
                values: new object[,]
                {
                    { new Guid("eba39bf8-cb09-4996-aa6b-76fee8d9dee8"), new Guid("bc03fc19-b49d-491d-92dc-da40c25c2b2a"), new Guid("7d6387ea-f6ce-4fc9-a0fe-12d2c4ba79b9") },
                    { new Guid("7a31bde8-035c-4d86-b84e-6614c7b07a72"), new Guid("2621c4e7-9078-42d8-b99b-f4cf9423ee44"), new Guid("7d6387ea-f6ce-4fc9-a0fe-12d2c4ba79b9") },
                    { new Guid("550c0611-35a8-4bdb-a576-93e4c21cf8a2"), new Guid("10e0c8f5-d0ae-4056-8023-a16e47a9ef4f"), new Guid("7d6387ea-f6ce-4fc9-a0fe-12d2c4ba79b9") },
                    { new Guid("563cfd8e-3185-4a87-a4f1-53dc94e9164e"), new Guid("1ab96e05-985a-4de6-a948-7411ef469055"), new Guid("7d6387ea-f6ce-4fc9-a0fe-12d2c4ba79b9") },
                    { new Guid("4880f85d-b145-4989-89cf-644c8cc36734"), new Guid("10e0c8f5-d0ae-4056-8023-a16e47a9ef4f"), new Guid("b8d4a8e5-5841-4a05-ab12-82ffc9fac312") },
                    { new Guid("ceb17796-5453-4142-b350-27bce2fdcb1f"), new Guid("f13df35e-d470-4a77-aee0-83139b07e5a2"), new Guid("b8d4a8e5-5841-4a05-ab12-82ffc9fac312") },
                    { new Guid("604a0335-4b0d-4661-a118-c43d5b12dc28"), new Guid("3a75fca9-840e-4bf2-8b7d-833851d98528"), new Guid("b8d4a8e5-5841-4a05-ab12-82ffc9fac312") },
                    { new Guid("bd4d11cc-e9a9-46f8-a252-ed5b3509738a"), new Guid("4fd570ef-2865-4dfa-9fe0-820a559f9a81"), new Guid("b8d4a8e5-5841-4a05-ab12-82ffc9fac312") },
                    { new Guid("fb49b00a-7c43-4ffd-b96b-06b250e6928f"), new Guid("10e0c8f5-d0ae-4056-8023-a16e47a9ef4f"), new Guid("5591e362-aae1-4107-a083-438ed31d91f2") },
                    { new Guid("02c1251b-2eae-48f6-aacc-a7375f8c3d8a"), new Guid("f13df35e-d470-4a77-aee0-83139b07e5a2"), new Guid("5591e362-aae1-4107-a083-438ed31d91f2") },
                    { new Guid("9259fb5e-7e5e-42c0-81cf-713f0fa217b8"), new Guid("3a75fca9-840e-4bf2-8b7d-833851d98528"), new Guid("5591e362-aae1-4107-a083-438ed31d91f2") },
                    { new Guid("69298f08-df75-4d88-94dc-def3e8b0b552"), new Guid("4fd570ef-2865-4dfa-9fe0-820a559f9a81"), new Guid("5591e362-aae1-4107-a083-438ed31d91f2") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecettes_IngredientId",
                table: "IngredientRecettes",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecettes_RecetteId",
                table: "IngredientRecettes",
                column: "RecetteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecettes");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recettes");
        }
    }
}
