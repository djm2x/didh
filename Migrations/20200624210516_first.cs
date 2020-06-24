using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin5.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Axes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Axes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cycles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evenements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Categorie = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evenements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Examens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Libelle = table.Column<string>(nullable: true),
                    Discours = table.Column<string>(nullable: true),
                    RapportNational = table.Column<string>(nullable: true),
                    CompilationHCDH = table.Column<string>(nullable: true),
                    ObservationFinale = table.Column<string>(nullable: true),
                    RapportMiParcours = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdConcerner = table.Column<int>(nullable: false),
                    IdOrganisme = table.Column<int>(nullable: false),
                    TableConcerner = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    Destinataire = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Vu = table.Column<bool>(nullable: false),
                    Priorite = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organismes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organismes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParticipationSessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Session = table.Column<string>(nullable: true),
                    Discours = table.Column<string>(nullable: true),
                    Documents = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipationSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profils",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Theme = table.Column<string>(nullable: true),
                    SousTheme = table.Column<string>(nullable: true),
                    PieceJointe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SituationReserves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituationReserves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Traites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    ConventionPiece = table.Column<string>(nullable: true),
                    MiseOeuvrePiece = table.Column<string>(nullable: true),
                    ObservationPiece = table.Column<string>(nullable: true),
                    AnalytiquePiece = table.Column<string>(nullable: true),
                    Discours = table.Column<string>(nullable: true),
                    DateRatification = table.Column<DateTime>(nullable: false),
                    DateSignature = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mandat = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    LienRapport = table.Column<string>(nullable: true),
                    Discours = table.Column<string>(nullable: true),
                    LienUpload = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SousAxes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true),
                    IdAxe = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SousAxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SousAxes_Axes_IdAxe",
                        column: x => x.IdAxe,
                        principalTable: "Axes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Adresse = table.Column<string>(nullable: false),
                    Tel = table.Column<string>(nullable: false),
                    Fix = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Actif = table.Column<bool>(nullable: true),
                    IdOrganisme = table.Column<int>(nullable: false),
                    IdProfil = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Organismes_IdOrganisme",
                        column: x => x.IdOrganisme,
                        principalTable: "Organismes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Profils_IdProfil",
                        column: x => x.IdProfil,
                        principalTable: "Profils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rapports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titre = table.Column<string>(nullable: true),
                    DateDernierRapport = table.Column<DateTime>(nullable: false),
                    DateObservation = table.Column<DateTime>(nullable: false),
                    DateProchaineRapport = table.Column<DateTime>(nullable: false),
                    Reference = table.Column<string>(nullable: false),
                    PieceJointe = table.Column<string>(nullable: true),
                    IdTraite = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rapports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rapports_Traites_IdTraite",
                        column: x => x.IdTraite,
                        principalTable: "Traites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: false),
                    CodeRecommendation = table.Column<string>(nullable: false),
                    Mecanisme = table.Column<string>(nullable: false),
                    IdCycle = table.Column<int>(nullable: true),
                    IdAxe = table.Column<int>(nullable: false),
                    IdSousAxe = table.Column<int>(nullable: false),
                    IdOrgane = table.Column<int>(nullable: true),
                    IdVisite = table.Column<int>(nullable: true),
                    IdPays = table.Column<int>(nullable: true),
                    Etat = table.Column<string>(nullable: false),
                    EtatAvancement = table.Column<string>(nullable: true),
                    EtatAvancementChiffre = table.Column<int>(nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    PieceJointe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recommendations_Axes_IdAxe",
                        column: x => x.IdAxe,
                        principalTable: "Axes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recommendations_Cycles_IdCycle",
                        column: x => x.IdCycle,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recommendations_Organes_IdOrgane",
                        column: x => x.IdOrgane,
                        principalTable: "Organes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recommendations_Pays_IdPays",
                        column: x => x.IdPays,
                        principalTable: "Pays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recommendations_SousAxes_IdSousAxe",
                        column: x => x.IdSousAxe,
                        principalTable: "SousAxes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recommendations_Visites_IdVisite",
                        column: x => x.IdVisite,
                        principalTable: "Visites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syntheses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(nullable: false),
                    Detail = table.Column<string>(nullable: false),
                    IdRapport = table.Column<int>(nullable: true),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syntheses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Syntheses_Rapports_IdRapport",
                        column: x => x.IdRapport,
                        principalTable: "Rapports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Syntheses_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecomOrgs",
                columns: table => new
                {
                    IdRecommendation = table.Column<int>(nullable: false),
                    IdOrganisme = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecomOrgs", x => new { x.IdRecommendation, x.IdOrganisme });
                    table.ForeignKey(
                        name: "FK_RecomOrgs_Organismes_IdOrganisme",
                        column: x => x.IdOrganisme,
                        principalTable: "Organismes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecomOrgs_Recommendations_IdRecommendation",
                        column: x => x.IdRecommendation,
                        principalTable: "Recommendations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FicheSyntheses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FicheUrl = table.Column<string>(nullable: false),
                    IdOrganisme = table.Column<int>(nullable: false),
                    IdSynthese = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FicheSyntheses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FicheSyntheses_Organismes_IdOrganisme",
                        column: x => x.IdOrganisme,
                        principalTable: "Organismes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FicheSyntheses_Syntheses_IdSynthese",
                        column: x => x.IdSynthese,
                        principalTable: "Syntheses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SyntheseRecommandations",
                columns: table => new
                {
                    IdRecommandation = table.Column<int>(nullable: false),
                    IdSynthese = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SyntheseRecommandations", x => new { x.IdRecommandation, x.IdSynthese });
                    table.ForeignKey(
                        name: "FK_SyntheseRecommandations_Recommendations_IdRecommandation",
                        column: x => x.IdRecommandation,
                        principalTable: "Recommendations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SyntheseRecommandations_Syntheses_IdSynthese",
                        column: x => x.IdSynthese,
                        principalTable: "Syntheses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 1, "Consolider la gouvernance du développement durable" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 2, "Réussir la transition vers une économie verts" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 3, "Améliorer la gestion et la valorisation des ressources naturelles et renforcer la conservation de la biodiversité" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 4, "Accélérer la mise en œuvre de la politique nationale de lutte contre le changement climatique" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 5, "Accorder une vigilance particulière aux territoires sensibles" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 6, "Promouvoir le développement humain et réduire les inégalités sociales et territoriales" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 7, "Promouvoir une culture de développement durable" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 10, "2050-2055" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 9, "2045-2050" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 7, "2035-2040" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 6, "2030-2035" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 8, "2040-2045" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 4, "2020-2025" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 3, "2015-2020" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 2, "2010-2015" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 1, "2005-2010" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label" },
                values: new object[] { 5, "2025-2030" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 10, "Categorie 1", new DateTime(2019, 11, 1, 9, 33, 44, 268, DateTimeKind.Local).AddTicks(205), "Aut eos sit possimus earum possimus porro. Nemo odit harum repellat eius veritatis commodi ducimus laudantium. Facilis dolor occaecati laboriosam officiis ut illum et consequatur. Natus dolor earum veniam ut. Modi aut cumque provident nesciunt odit voluptatem. Ipsam aperiam animi alias aut soluta in autem optio et. Aliquam et ut. Et earum odio hic commodi consectetur magni neque ut explicabo. Voluptas magnam placeat recusandae nobis ut nesciunt unde. Voluptas nam vel. Consequuntur omnis amet atque cumque tempora.", "cumque" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 9, "Categorie 1", new DateTime(2020, 5, 24, 12, 47, 16, 204, DateTimeKind.Local).AddTicks(9653), "Ut voluptatem ut totam similique. Aliquam inventore velit eligendi repellat hic nulla eos. Assumenda dolor maxime at enim ad pariatur suscipit et. Ad ullam repudiandae doloremque numquam aliquid fugiat nulla officiis eum. Tempore enim consequatur magni est dolores et. Iure dolorem suscipit voluptatum facere. Excepturi sint et delectus aut et vel qui iste nostrum. Laboriosam doloremque maiores laboriosam dolorem aut. Doloremque quis aspernatur et id quisquam fuga eos ut repellat. Maxime itaque qui neque.", "explicabo" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 8, "Categorie 1", new DateTime(2019, 10, 27, 4, 16, 34, 451, DateTimeKind.Local).AddTicks(7454), "Explicabo voluptatem ipsum rerum perferendis quisquam et. Doloribus est quos voluptates adipisci incidunt quis. Animi magni nobis doloribus repudiandae. Ipsam ratione amet vel adipisci et facilis reiciendis. Velit placeat perferendis excepturi aliquid dolores accusantium voluptatem dolor. Aspernatur nihil non doloremque alias eaque culpa temporibus a. Nam quia laudantium nam commodi. Accusantium blanditiis quidem. Quod ut perferendis non vitae nesciunt dolor. Sit dolor in vel ut consectetur illum accusantium. Fugit sit laboriosam laborum quo est.", "vero" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 7, "Categorie 1", new DateTime(2019, 9, 8, 10, 42, 26, 307, DateTimeKind.Local).AddTicks(5955), "Molestias voluptate sapiente tempora rerum inventore qui eos quis accusantium. Est sed ipsum. Aliquam ipsa corrupti dolores. Magnam voluptas quod et qui et esse. Et voluptas fugit temporibus quo ipsa earum ut praesentium sit. Iste molestiae recusandae. Aspernatur laborum consequatur distinctio officiis saepe iste enim. Mollitia id tempore libero. Sit et ipsa rerum optio et cupiditate repudiandae. Vel nesciunt incidunt sint.", "qui" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 6, "Categorie 1", new DateTime(2019, 10, 14, 5, 47, 22, 845, DateTimeKind.Local).AddTicks(8263), "Ut nulla reiciendis alias et itaque placeat earum est voluptatem. Dolores natus nihil voluptatem sapiente dolor ut eaque. Recusandae corrupti voluptas neque deleniti expedita ut corporis. Modi laborum porro occaecati unde. Consequatur quo perspiciatis est ipsum dolorum at cum qui totam. Provident ipsa autem et voluptatem eum assumenda laudantium delectus. Beatae vel occaecati. Ut ducimus tempore nihil velit reiciendis et aut autem tenetur. Quidem expedita et. Beatae consequatur ipsam.", "consequatur" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 4, "Categorie 1", new DateTime(2019, 12, 31, 9, 20, 15, 574, DateTimeKind.Local).AddTicks(7942), "Iusto illum corporis aperiam. Sed numquam est harum ut ut. Est quis voluptatem quia aut. Est officia quibusdam. Aspernatur voluptatem sit officiis rem molestias. Tempora et minus velit aut beatae accusantium voluptate numquam. Ut placeat sequi nobis nihil. Vitae delectus dolorem ut rerum vitae voluptates. Sunt qui asperiores quisquam eaque pariatur fuga. Nihil quo ea.", "nisi" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 3, "Categorie 1", new DateTime(2019, 7, 11, 8, 35, 49, 184, DateTimeKind.Local).AddTicks(8403), "Est quibusdam nobis at dignissimos. Voluptatem ea asperiores nam accusantium ut vero aut fuga. Quis dolor vel assumenda qui cumque natus animi consequatur qui. Perspiciatis sint veniam illum eum vel sequi provident soluta placeat. Voluptas veritatis animi delectus et ut quo. Esse dolorem quisquam aut minus eius et tempora facere. Ut vitae ipsa asperiores rerum omnis rerum impedit nulla velit. Nihil in earum sed assumenda esse placeat ipsum dolorum harum. Rerum asperiores aperiam illo qui perspiciatis omnis animi. Voluptatem in perspiciatis dignissimos libero iste assumenda sed qui. Ea illo sint. Quo dolore omnis assumenda sapiente et voluptatem illo dolores. Sunt adipisci ab sapiente necessitatibus.", "aut" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 2, "Categorie 1", new DateTime(2020, 1, 30, 11, 36, 30, 402, DateTimeKind.Local).AddTicks(7929), "Voluptatem repellendus dolores aut et nulla odit voluptas incidunt illum. Velit in illum eos. Sunt sit voluptas ipsam consequatur. Inventore dolor tempore in blanditiis. Vel provident consequuntur eius odio. Voluptatum rerum fuga enim dignissimos voluptatem. Temporibus culpa nobis quis qui et voluptatem dolorem ipsum facilis. Pariatur vel rerum id. Aliquid suscipit aspernatur iure dolorem iure cumque est. Omnis consequuntur laboriosam aut est illum rerum ducimus iure eius. Autem quos modi voluptatum et qui quia necessitatibus. Consequatur inventore error quod neque ad itaque nisi non aut.", "laborum" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 1, "Categorie 1", new DateTime(2019, 12, 10, 17, 39, 1, 752, DateTimeKind.Local).AddTicks(3), "Voluptatibus et ut qui. Ea omnis eligendi corporis quia qui consectetur non consequatur. Quis ipsum quibusdam dolorum sit magni. Nisi nemo odit eius nemo doloribus blanditiis. Quam sequi eius harum aut vel ut eaque blanditiis quia. Quis sit in qui architecto. Dolores atque repellat sit et ipsam provident aut. Ad molestiae nisi error aspernatur. Labore quia ut exercitationem ut eveniet voluptatem. Eum magni nisi et tempore omnis minima earum. Doloremque iste consequatur quas. Est et voluptas est occaecati minus.", "itaque" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 5, "Categorie 1", new DateTime(2019, 10, 30, 20, 49, 25, 602, DateTimeKind.Local).AddTicks(4236), "Exercitationem quia repudiandae deserunt voluptas ut voluptas rerum possimus. Tempore aut voluptates est est ipsum. Tenetur neque et aliquid. Nemo consequatur commodi. Dolorem ipsa ipsam veniam modi repellendus aut nesciunt. Omnis est quos ratione aperiam qui vel. Sit consequatur placeat porro. Aspernatur libero voluptatem non est ducimus. Non vel perspiciatis tempora aut quis. Quia rem dolorem rerum explicabo placeat fugit eum dignissimos.", "consequatur" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 5, "", "", "Examen-6", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 6, "", "", "Examen-7", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 4, "", "", "Examen-5", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 1, "", "", "Examen-2", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 2, "", "", "Examen-3", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 3, "", "", "Examen-4", "", "", "" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 73, new DateTime(2020, 3, 24, 11, 25, 44, 345, DateTimeKind.Local).AddTicks(9378), "1,2,6", 73, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2020, 2, 7, 12, 54, 13, 935, DateTimeKind.Local).AddTicks(1630), "1,2,6", 72, 5, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2019, 8, 18, 21, 14, 43, 441, DateTimeKind.Local).AddTicks(5346), "1,3,6", 71, 5, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2019, 8, 6, 5, 59, 47, 227, DateTimeKind.Local).AddTicks(7391), "1,2,5", 70, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2019, 10, 25, 2, 8, 45, 707, DateTimeKind.Local).AddTicks(4221), "1,3,4", 69, 5, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2019, 7, 26, 14, 35, 24, 864, DateTimeKind.Local).AddTicks(6086), "1,2,5", 68, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2020, 2, 24, 6, 37, 26, 887, DateTimeKind.Local).AddTicks(9773), "0,3,4", 67, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2019, 8, 8, 10, 46, 53, 73, DateTimeKind.Local).AddTicks(1493), "0,2,4", 66, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2020, 2, 20, 21, 59, 9, 381, DateTimeKind.Local).AddTicks(4365), "1,3,4", 65, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2020, 3, 17, 1, 1, 23, 416, DateTimeKind.Local).AddTicks(2384), "1,2,4", 64, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2020, 4, 15, 21, 25, 32, 155, DateTimeKind.Local).AddTicks(6396), "0,3,4", 63, 6, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2020, 2, 22, 6, 50, 15, 554, DateTimeKind.Local).AddTicks(7260), "1,3,6", 61, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2019, 9, 15, 11, 2, 5, 439, DateTimeKind.Local).AddTicks(3804), "0,3,4", 60, 5, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2020, 4, 4, 9, 13, 16, 317, DateTimeKind.Local).AddTicks(3563), "0,2,4", 59, 5, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2020, 2, 22, 5, 59, 23, 171, DateTimeKind.Local).AddTicks(328), "0,3,4", 58, 3, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2019, 11, 17, 16, 25, 54, 161, DateTimeKind.Local).AddTicks(8820), "0,2,4", 57, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2020, 5, 29, 18, 17, 55, 11, DateTimeKind.Local).AddTicks(2866), "1,3,6", 56, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2020, 3, 23, 18, 10, 22, 76, DateTimeKind.Local).AddTicks(6659), "0,3,6", 55, 4, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2019, 7, 29, 8, 49, 27, 203, DateTimeKind.Local).AddTicks(9533), "1,3,5", 54, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2020, 3, 7, 13, 36, 37, 307, DateTimeKind.Local).AddTicks(18), "1,2,6", 53, 2, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2020, 1, 12, 11, 52, 40, 721, DateTimeKind.Local).AddTicks(7239), "1,2,4", 74, 5, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2019, 8, 14, 21, 44, 6, 116, DateTimeKind.Local).AddTicks(7250), "1,3,6", 62, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2019, 7, 8, 3, 42, 1, 446, DateTimeKind.Local).AddTicks(3493), "0,3,5", 75, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2020, 1, 22, 1, 32, 46, 494, DateTimeKind.Local).AddTicks(3642), "1,3,5", 93, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2019, 7, 2, 4, 19, 19, 886, DateTimeKind.Local).AddTicks(8388), "1,2,5", 77, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2019, 10, 25, 7, 55, 18, 326, DateTimeKind.Local).AddTicks(4072), "0,3,4", 100, 6, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2019, 12, 30, 7, 30, 55, 4, DateTimeKind.Local).AddTicks(9509), "0,2,4", 99, 4, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2020, 1, 1, 20, 1, 59, 523, DateTimeKind.Local).AddTicks(7634), "0,2,4", 98, 2, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2020, 4, 11, 17, 50, 33, 249, DateTimeKind.Local).AddTicks(3735), "1,3,4", 97, 2, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2019, 10, 25, 8, 44, 12, 127, DateTimeKind.Local).AddTicks(217), "0,2,6", 96, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2020, 4, 29, 16, 0, 6, 559, DateTimeKind.Local).AddTicks(6606), "1,2,6", 95, 6, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2020, 2, 8, 0, 53, 46, 180, DateTimeKind.Local).AddTicks(4852), "0,2,4", 94, 4, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2020, 2, 9, 2, 56, 53, 28, DateTimeKind.Local).AddTicks(1552), "1,3,5", 52, 1, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2020, 2, 3, 14, 16, 21, 922, DateTimeKind.Local).AddTicks(6432), "0,3,5", 92, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2020, 5, 16, 5, 30, 28, 935, DateTimeKind.Local).AddTicks(2519), "0,2,5", 91, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2020, 4, 16, 0, 13, 12, 823, DateTimeKind.Local).AddTicks(3743), "1,3,5", 76, 2, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2019, 7, 6, 8, 8, 22, 333, DateTimeKind.Local).AddTicks(5983), "1,3,6", 90, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2020, 3, 18, 11, 50, 31, 161, DateTimeKind.Local).AddTicks(5652), "1,3,5", 88, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2019, 12, 10, 6, 21, 2, 853, DateTimeKind.Local).AddTicks(9320), "1,2,4", 87, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2020, 1, 22, 7, 39, 41, 418, DateTimeKind.Local).AddTicks(5212), "1,2,5", 86, 1, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2019, 7, 27, 14, 3, 15, 748, DateTimeKind.Local).AddTicks(6977), "1,2,4", 85, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2019, 12, 13, 4, 24, 28, 264, DateTimeKind.Local).AddTicks(8218), "0,2,4", 83, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2020, 2, 12, 4, 36, 36, 577, DateTimeKind.Local).AddTicks(634), "1,2,4", 82, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2020, 4, 14, 17, 51, 13, 184, DateTimeKind.Local).AddTicks(7875), "0,2,6", 81, 2, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2020, 1, 27, 20, 17, 57, 625, DateTimeKind.Local).AddTicks(3860), "1,3,5", 80, 3, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2020, 2, 22, 7, 41, 16, 523, DateTimeKind.Local).AddTicks(3204), "0,2,5", 79, 2, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2019, 7, 23, 23, 32, 50, 136, DateTimeKind.Local).AddTicks(960), "0,2,5", 78, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2019, 8, 20, 18, 46, 24, 847, DateTimeKind.Local).AddTicks(8745), "1,2,5", 89, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2020, 4, 5, 8, 37, 56, 552, DateTimeKind.Local).AddTicks(5726), "1,2,6", 51, 1, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2020, 4, 25, 10, 46, 21, 297, DateTimeKind.Local).AddTicks(9864), "1,3,5", 84, 1, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2020, 5, 24, 2, 11, 30, 872, DateTimeKind.Local).AddTicks(6045), "0,3,5", 49, 3, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2019, 6, 26, 11, 54, 6, 742, DateTimeKind.Local).AddTicks(4598), "1,3,6", 22, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2019, 10, 15, 13, 33, 58, 152, DateTimeKind.Local).AddTicks(9319), "0,3,5", 21, 5, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2019, 8, 10, 20, 6, 26, 343, DateTimeKind.Local).AddTicks(8621), "0,2,5", 20, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2020, 1, 27, 0, 31, 9, 77, DateTimeKind.Local).AddTicks(9559), "1,2,6", 19, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2019, 10, 25, 2, 9, 46, 773, DateTimeKind.Local).AddTicks(2372), "1,2,4", 18, 2, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2020, 6, 12, 4, 27, 3, 457, DateTimeKind.Local).AddTicks(2289), "0,3,4", 17, 1, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2020, 4, 28, 5, 18, 10, 236, DateTimeKind.Local).AddTicks(8487), "0,2,5", 15, 5, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2020, 6, 9, 12, 23, 3, 244, DateTimeKind.Local).AddTicks(2678), "1,2,5", 14, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2019, 11, 21, 16, 57, 52, 509, DateTimeKind.Local).AddTicks(2101), "0,3,6", 13, 2, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2019, 11, 21, 5, 21, 30, 187, DateTimeKind.Local).AddTicks(5981), "0,2,5", 12, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 6, 5, 15, 30, 56, 949, DateTimeKind.Local).AddTicks(6309), "1,2,5", 23, 3, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2019, 11, 15, 1, 12, 59, 600, DateTimeKind.Local).AddTicks(278), "1,3,4", 11, 1, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2019, 12, 1, 18, 54, 4, 987, DateTimeKind.Local).AddTicks(3376), "1,3,5", 9, 6, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2019, 10, 16, 15, 25, 32, 483, DateTimeKind.Local).AddTicks(2407), "0,3,6", 8, 4, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2019, 8, 21, 10, 18, 37, 546, DateTimeKind.Local).AddTicks(3804), "1,3,6", 7, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2019, 7, 25, 8, 34, 57, 167, DateTimeKind.Local).AddTicks(1998), "1,2,5", 6, 5, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2019, 11, 30, 6, 25, 17, 419, DateTimeKind.Local).AddTicks(878), "0,3,4", 5, 4, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2020, 4, 2, 4, 36, 49, 403, DateTimeKind.Local).AddTicks(7686), "0,3,5", 4, 5, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2019, 10, 11, 7, 53, 23, 722, DateTimeKind.Local).AddTicks(1756), "0,3,6", 3, 5, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2019, 10, 29, 22, 26, 46, 791, DateTimeKind.Local).AddTicks(4802), "0,2,4", 2, 4, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2020, 5, 3, 8, 17, 49, 657, DateTimeKind.Local).AddTicks(3140), "0,3,6", 1, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2019, 12, 8, 3, 42, 45, 228, DateTimeKind.Local).AddTicks(4321), "1,3,6", 50, 2, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2019, 10, 24, 22, 42, 24, 92, DateTimeKind.Local).AddTicks(3618), "0,3,4", 10, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2019, 12, 12, 16, 39, 13, 725, DateTimeKind.Local).AddTicks(5632), "1,2,4", 24, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2019, 9, 19, 12, 59, 22, 266, DateTimeKind.Local).AddTicks(3720), "1,3,6", 16, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2019, 9, 19, 17, 13, 39, 634, DateTimeKind.Local).AddTicks(7010), "0,3,4", 26, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2020, 2, 20, 8, 54, 59, 235, DateTimeKind.Local).AddTicks(8546), "0,3,6", 48, 3, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2019, 7, 25, 19, 12, 36, 365, DateTimeKind.Local).AddTicks(9500), "0,3,5", 47, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2020, 5, 21, 14, 2, 37, 464, DateTimeKind.Local).AddTicks(4846), "1,2,5", 46, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2019, 8, 17, 13, 59, 47, 549, DateTimeKind.Local).AddTicks(6874), "0,3,4", 25, 5, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2020, 5, 8, 0, 2, 12, 797, DateTimeKind.Local).AddTicks(5081), "0,3,4", 44, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2020, 1, 1, 7, 36, 11, 108, DateTimeKind.Local).AddTicks(7586), "1,3,4", 43, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2020, 4, 5, 7, 44, 20, 820, DateTimeKind.Local).AddTicks(8050), "0,3,6", 42, 3, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2020, 4, 8, 10, 13, 38, 885, DateTimeKind.Local).AddTicks(7966), "1,3,6", 41, 6, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2020, 2, 13, 20, 53, 23, 149, DateTimeKind.Local).AddTicks(8329), "1,2,5", 40, 4, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2019, 12, 4, 10, 19, 45, 914, DateTimeKind.Local).AddTicks(973), "0,3,6", 39, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2019, 8, 1, 0, 39, 46, 936, DateTimeKind.Local).AddTicks(3446), "0,2,6", 38, 1, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2020, 6, 1, 6, 33, 24, 295, DateTimeKind.Local).AddTicks(561), "1,3,4", 37, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2020, 1, 26, 22, 34, 6, 422, DateTimeKind.Local).AddTicks(776), "1,3,6", 45, 3, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2020, 1, 6, 1, 43, 6, 84, DateTimeKind.Local).AddTicks(9945), "0,2,5", 35, 5, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2019, 7, 4, 10, 39, 14, 792, DateTimeKind.Local).AddTicks(1158), "0,3,5", 34, 5, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2020, 1, 21, 6, 2, 26, 988, DateTimeKind.Local).AddTicks(2827), "0,2,6", 33, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2019, 10, 27, 15, 34, 47, 771, DateTimeKind.Local).AddTicks(8039), "1,2,4", 27, 4, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2020, 6, 13, 11, 56, 37, 111, DateTimeKind.Local).AddTicks(492), "0,3,5", 32, 1, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2020, 5, 26, 0, 17, 0, 0, DateTimeKind.Local).AddTicks(6325), "1,3,5", 31, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2020, 2, 9, 10, 8, 12, 864, DateTimeKind.Local).AddTicks(8082), "1,3,5", 30, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2019, 8, 5, 23, 39, 18, 37, DateTimeKind.Local).AddTicks(359), "0,3,4", 29, 6, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2020, 2, 26, 10, 24, 41, 211, DateTimeKind.Local).AddTicks(2036), "0,2,4", 28, 2, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2020, 1, 9, 1, 42, 44, 321, DateTimeKind.Local).AddTicks(3249), "0,2,5", 36, 1, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 6, "Comité des droits des personnes handicapés" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 4, "Comité des droits de l’Homme" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 5, "Comité des droits de l’enfant" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 2, "Comité contre la torture" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 1, "Comité CEDAW" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 3, "Comité des disparitions forcées" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 7, null, "Délégation interministérielle aux droits de l'Homme", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 5, null, "Ministère de la Communication", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 4, null, "Ministère de l'Equipement et du Transport", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 6, null, "Ministère de la Santé", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 2, null, "Ministère de la Justice et des Libertés", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 1, null, "Ministère des Affaires Étrangères et de la Coopération", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 3, null, "Ministère de la Fonction Publique et de la Modernisation de l'Administration", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 15, "", "", "Session 15" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 14, "", "", "Session 14" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 9, "", "", "Session 9" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 12, "", "", "Session 12" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 11, "", "", "Session 11" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 10, "", "", "Session 10" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 8, "", "", "Session 8" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 13, "", "", "Session 13" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 6, "", "", "Session 6" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 5, "", "", "Session 5" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 4, "", "", "Session 4" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 3, "", "", "Session 3" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 2, "", "", "Session 2" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 1, "", "", "Session 1" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 7, "", "", "Session 7" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 3, "Allemagne" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 4, "Espagnole" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 1, "Maroc" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 2, "France" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label" },
                values: new object[] { 1, "Administrateur" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label" },
                values: new object[] { 2, "Superviseur" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label" },
                values: new object[] { 3, "Point focal" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label" },
                values: new object[] { 4, "Propriétaire" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 9, "", "sous theme 9", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 15, "", "sous theme 15", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 14, "", "sous theme 14", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 13, "", "sous theme 13", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 11, "", "sous theme 11", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 10, "", "sous theme 10", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 8, "", "sous theme 8", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 12, "", "sous theme 12", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 6, "", "sous theme 6", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 5, "", "sous theme 5", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 4, "", "sous theme 4", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 7, "", "sous theme 7", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 3, "", "sous theme 3", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 2, "", "sous theme 2", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 1, "", "sous theme 1", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 66, "", "", new DateTime(2019, 8, 11, 13, 5, 46, 533, DateTimeKind.Local).AddTicks(5345), new DateTime(2019, 11, 13, 11, 26, 57, 264, DateTimeKind.Local).AddTicks(1440), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 67, "", "", new DateTime(2019, 12, 23, 0, 37, 10, 55, DateTimeKind.Local).AddTicks(368), new DateTime(2020, 6, 1, 6, 35, 0, 568, DateTimeKind.Local).AddTicks(9263), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 68, "", "", new DateTime(2019, 11, 16, 2, 50, 54, 450, DateTimeKind.Local).AddTicks(9065), new DateTime(2019, 12, 21, 9, 33, 40, 995, DateTimeKind.Local).AddTicks(742), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 69, "", "", new DateTime(2019, 10, 15, 16, 34, 28, 174, DateTimeKind.Local).AddTicks(5406), new DateTime(2019, 7, 22, 8, 31, 31, 41, DateTimeKind.Local).AddTicks(4578), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 72, "", "", new DateTime(2019, 7, 22, 18, 34, 13, 250, DateTimeKind.Local).AddTicks(4042), new DateTime(2020, 1, 22, 15, 20, 30, 605, DateTimeKind.Local).AddTicks(9780), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 71, "", "", new DateTime(2019, 12, 13, 16, 15, 13, 284, DateTimeKind.Local).AddTicks(474), new DateTime(2020, 5, 15, 0, 32, 19, 394, DateTimeKind.Local).AddTicks(4622), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 65, "", "", new DateTime(2020, 1, 2, 20, 0, 30, 381, DateTimeKind.Local).AddTicks(1917), new DateTime(2019, 8, 24, 18, 16, 19, 910, DateTimeKind.Local).AddTicks(5259), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 73, "", "", new DateTime(2019, 8, 11, 15, 47, 10, 821, DateTimeKind.Local).AddTicks(8833), new DateTime(2020, 3, 5, 13, 6, 23, 224, DateTimeKind.Local).AddTicks(6008), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 74, "", "", new DateTime(2019, 12, 12, 6, 31, 50, 100, DateTimeKind.Local).AddTicks(6118), new DateTime(2020, 5, 21, 21, 47, 53, 47, DateTimeKind.Local).AddTicks(9395), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 70, "", "", new DateTime(2019, 9, 9, 16, 42, 0, 812, DateTimeKind.Local).AddTicks(396), new DateTime(2020, 4, 14, 4, 39, 10, 61, DateTimeKind.Local).AddTicks(3067), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 64, "", "", new DateTime(2020, 3, 24, 12, 18, 58, 416, DateTimeKind.Local).AddTicks(3119), new DateTime(2020, 2, 17, 7, 35, 13, 253, DateTimeKind.Local).AddTicks(3693), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 62, "", "", new DateTime(2019, 10, 8, 22, 16, 44, 287, DateTimeKind.Local).AddTicks(2052), new DateTime(2019, 10, 29, 2, 24, 2, 54, DateTimeKind.Local).AddTicks(8108), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 53, "", "", new DateTime(2019, 10, 21, 21, 4, 50, 435, DateTimeKind.Local).AddTicks(3455), new DateTime(2020, 4, 3, 22, 25, 31, 377, DateTimeKind.Local).AddTicks(2261), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 61, "", "", new DateTime(2020, 4, 9, 11, 15, 16, 390, DateTimeKind.Local).AddTicks(7658), new DateTime(2019, 11, 14, 5, 1, 35, 824, DateTimeKind.Local).AddTicks(9794), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 60, "", "", new DateTime(2019, 12, 1, 18, 37, 46, 459, DateTimeKind.Local).AddTicks(6016), new DateTime(2019, 10, 22, 19, 16, 34, 862, DateTimeKind.Local).AddTicks(8258), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 59, "", "", new DateTime(2020, 1, 29, 9, 57, 27, 398, DateTimeKind.Local).AddTicks(597), new DateTime(2020, 4, 28, 5, 36, 13, 637, DateTimeKind.Local).AddTicks(8057), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 58, "", "", new DateTime(2019, 8, 30, 3, 38, 12, 159, DateTimeKind.Local).AddTicks(3320), new DateTime(2019, 11, 19, 20, 55, 37, 542, DateTimeKind.Local).AddTicks(774), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 57, "", "", new DateTime(2019, 8, 18, 14, 41, 16, 502, DateTimeKind.Local).AddTicks(8801), new DateTime(2020, 4, 11, 18, 3, 43, 468, DateTimeKind.Local).AddTicks(8654), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 56, "", "", new DateTime(2020, 4, 13, 12, 55, 53, 736, DateTimeKind.Local).AddTicks(2446), new DateTime(2020, 2, 15, 6, 20, 23, 917, DateTimeKind.Local).AddTicks(9735), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 55, "", "", new DateTime(2020, 6, 19, 13, 17, 52, 93, DateTimeKind.Local).AddTicks(832), new DateTime(2020, 1, 22, 22, 24, 16, 711, DateTimeKind.Local).AddTicks(1297), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 54, "", "", new DateTime(2019, 11, 7, 4, 30, 31, 578, DateTimeKind.Local).AddTicks(236), new DateTime(2020, 2, 10, 16, 8, 35, 98, DateTimeKind.Local).AddTicks(6424), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 75, "", "", new DateTime(2019, 8, 14, 15, 12, 17, 248, DateTimeKind.Local).AddTicks(8127), new DateTime(2019, 11, 19, 0, 27, 33, 505, DateTimeKind.Local).AddTicks(2953), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 63, "", "", new DateTime(2020, 5, 17, 13, 13, 16, 107, DateTimeKind.Local).AddTicks(300), new DateTime(2020, 4, 16, 11, 58, 57, 136, DateTimeKind.Local).AddTicks(6859), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 76, "", "", new DateTime(2019, 8, 3, 16, 18, 8, 705, DateTimeKind.Local).AddTicks(6778), new DateTime(2020, 2, 20, 5, 42, 57, 196, DateTimeKind.Local).AddTicks(8696), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 91, "", "", new DateTime(2019, 10, 28, 13, 44, 19, 862, DateTimeKind.Local).AddTicks(5039), new DateTime(2019, 8, 20, 10, 29, 19, 94, DateTimeKind.Local).AddTicks(2206), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 78, "", "", new DateTime(2019, 11, 15, 11, 53, 8, 540, DateTimeKind.Local).AddTicks(2989), new DateTime(2020, 6, 3, 16, 5, 51, 823, DateTimeKind.Local).AddTicks(2985), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 52, "", "", new DateTime(2019, 11, 18, 16, 31, 22, 40, DateTimeKind.Local).AddTicks(6502), new DateTime(2020, 1, 17, 2, 11, 20, 495, DateTimeKind.Local).AddTicks(486), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 100, "", "", new DateTime(2020, 2, 24, 19, 42, 48, 716, DateTimeKind.Local).AddTicks(959), new DateTime(2020, 4, 6, 2, 32, 20, 590, DateTimeKind.Local).AddTicks(3525), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 99, "", "", new DateTime(2020, 5, 1, 13, 9, 12, 587, DateTimeKind.Local).AddTicks(5292), new DateTime(2019, 12, 23, 13, 58, 14, 981, DateTimeKind.Local).AddTicks(8713), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 98, "", "", new DateTime(2020, 4, 16, 8, 27, 2, 758, DateTimeKind.Local).AddTicks(8887), new DateTime(2019, 11, 12, 5, 9, 0, 343, DateTimeKind.Local).AddTicks(1898), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 97, "", "", new DateTime(2019, 11, 5, 1, 59, 42, 191, DateTimeKind.Local).AddTicks(6728), new DateTime(2019, 9, 4, 15, 33, 13, 86, DateTimeKind.Local).AddTicks(2273), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 96, "", "", new DateTime(2020, 3, 30, 17, 53, 57, 752, DateTimeKind.Local).AddTicks(8762), new DateTime(2019, 10, 4, 19, 54, 59, 919, DateTimeKind.Local).AddTicks(3237), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 95, "", "", new DateTime(2020, 2, 17, 21, 48, 43, 745, DateTimeKind.Local).AddTicks(7594), new DateTime(2020, 1, 31, 14, 48, 36, 874, DateTimeKind.Local).AddTicks(1031), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 94, "", "", new DateTime(2019, 11, 14, 1, 30, 51, 775, DateTimeKind.Local).AddTicks(3423), new DateTime(2019, 8, 30, 22, 13, 5, 552, DateTimeKind.Local).AddTicks(5549), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 93, "", "", new DateTime(2020, 4, 22, 9, 6, 55, 124, DateTimeKind.Local).AddTicks(6594), new DateTime(2019, 7, 28, 8, 19, 21, 593, DateTimeKind.Local).AddTicks(6870), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 92, "", "", new DateTime(2020, 6, 12, 0, 12, 59, 61, DateTimeKind.Local).AddTicks(7147), new DateTime(2019, 6, 25, 17, 49, 32, 265, DateTimeKind.Local).AddTicks(7142), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 77, "", "", new DateTime(2019, 11, 19, 1, 58, 55, 597, DateTimeKind.Local).AddTicks(4736), new DateTime(2019, 12, 12, 18, 56, 56, 283, DateTimeKind.Local).AddTicks(2567), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 90, "", "", new DateTime(2019, 7, 15, 12, 32, 37, 639, DateTimeKind.Local).AddTicks(2450), new DateTime(2020, 3, 28, 23, 10, 15, 435, DateTimeKind.Local).AddTicks(6538), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 88, "", "", new DateTime(2020, 6, 12, 18, 54, 33, 690, DateTimeKind.Local).AddTicks(5720), new DateTime(2020, 4, 15, 12, 48, 20, 633, DateTimeKind.Local).AddTicks(3221), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 87, "", "", new DateTime(2020, 1, 27, 20, 19, 22, 222, DateTimeKind.Local).AddTicks(142), new DateTime(2019, 9, 5, 22, 21, 34, 887, DateTimeKind.Local).AddTicks(6166), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 86, "", "", new DateTime(2019, 8, 8, 0, 1, 15, 566, DateTimeKind.Local).AddTicks(603), new DateTime(2019, 9, 26, 9, 43, 52, 620, DateTimeKind.Local).AddTicks(8456), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 85, "", "", new DateTime(2019, 8, 5, 14, 3, 24, 39, DateTimeKind.Local).AddTicks(7493), new DateTime(2019, 7, 5, 16, 10, 35, 373, DateTimeKind.Local).AddTicks(1747), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 84, "", "", new DateTime(2020, 4, 12, 9, 15, 34, 142, DateTimeKind.Local).AddTicks(1426), new DateTime(2020, 6, 24, 19, 23, 51, 130, DateTimeKind.Local).AddTicks(3986), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 83, "", "", new DateTime(2020, 5, 28, 16, 10, 18, 571, DateTimeKind.Local).AddTicks(8929), new DateTime(2019, 12, 5, 23, 31, 32, 549, DateTimeKind.Local).AddTicks(5327), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 82, "", "", new DateTime(2019, 7, 12, 4, 58, 11, 73, DateTimeKind.Local).AddTicks(8934), new DateTime(2019, 10, 4, 18, 9, 0, 551, DateTimeKind.Local).AddTicks(75), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 81, "", "", new DateTime(2019, 12, 11, 10, 47, 33, 253, DateTimeKind.Local).AddTicks(6631), new DateTime(2020, 3, 1, 18, 36, 30, 713, DateTimeKind.Local).AddTicks(7313), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 80, "", "", new DateTime(2020, 6, 16, 3, 23, 7, 146, DateTimeKind.Local).AddTicks(4261), new DateTime(2020, 6, 18, 3, 47, 31, 531, DateTimeKind.Local).AddTicks(4034), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 79, "", "", new DateTime(2019, 10, 18, 17, 29, 13, 233, DateTimeKind.Local).AddTicks(5110), new DateTime(2019, 11, 17, 6, 29, 37, 358, DateTimeKind.Local).AddTicks(5954), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 89, "", "", new DateTime(2019, 9, 30, 0, 31, 5, 902, DateTimeKind.Local).AddTicks(3233), new DateTime(2019, 7, 23, 2, 27, 20, 162, DateTimeKind.Local).AddTicks(5069), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 51, "", "", new DateTime(2019, 9, 26, 14, 4, 27, 782, DateTimeKind.Local).AddTicks(759), new DateTime(2020, 2, 2, 20, 24, 13, 445, DateTimeKind.Local).AddTicks(4609), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 8, "", "", new DateTime(2020, 1, 3, 8, 35, 58, 797, DateTimeKind.Local).AddTicks(1416), new DateTime(2020, 4, 20, 4, 9, 31, 963, DateTimeKind.Local).AddTicks(8723), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 49, "", "", new DateTime(2020, 3, 20, 21, 25, 38, 886, DateTimeKind.Local).AddTicks(4614), new DateTime(2020, 1, 29, 2, 37, 50, 846, DateTimeKind.Local).AddTicks(5855), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 22, "", "", new DateTime(2019, 12, 4, 14, 1, 35, 695, DateTimeKind.Local).AddTicks(4368), new DateTime(2020, 2, 20, 9, 47, 15, 892, DateTimeKind.Local).AddTicks(1411), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 21, "", "", new DateTime(2020, 2, 8, 5, 32, 38, 495, DateTimeKind.Local).AddTicks(9381), new DateTime(2019, 8, 12, 8, 13, 49, 980, DateTimeKind.Local).AddTicks(9619), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 20, "", "", new DateTime(2019, 10, 30, 1, 59, 56, 754, DateTimeKind.Local).AddTicks(1263), new DateTime(2020, 6, 3, 21, 1, 6, 259, DateTimeKind.Local).AddTicks(6224), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 19, "", "", new DateTime(2019, 9, 19, 15, 28, 8, 170, DateTimeKind.Local).AddTicks(5072), new DateTime(2020, 2, 23, 4, 6, 41, 673, DateTimeKind.Local).AddTicks(3294), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 18, "", "", new DateTime(2020, 2, 25, 4, 19, 53, 169, DateTimeKind.Local).AddTicks(7379), new DateTime(2020, 1, 19, 8, 30, 15, 541, DateTimeKind.Local).AddTicks(8945), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 17, "", "", new DateTime(2020, 1, 3, 23, 51, 10, 603, DateTimeKind.Local).AddTicks(6273), new DateTime(2019, 7, 28, 15, 1, 55, 577, DateTimeKind.Local).AddTicks(6645), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 16, "", "", new DateTime(2020, 2, 19, 7, 3, 16, 482, DateTimeKind.Local).AddTicks(1649), new DateTime(2019, 12, 22, 18, 45, 21, 872, DateTimeKind.Local).AddTicks(2424), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 15, "", "", new DateTime(2019, 9, 10, 5, 20, 55, 117, DateTimeKind.Local).AddTicks(5228), new DateTime(2020, 2, 11, 14, 48, 29, 758, DateTimeKind.Local).AddTicks(112), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 14, "", "", new DateTime(2019, 7, 12, 4, 29, 52, 786, DateTimeKind.Local).AddTicks(9961), new DateTime(2019, 12, 2, 15, 51, 36, 622, DateTimeKind.Local).AddTicks(6447), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 13, "", "", new DateTime(2020, 5, 14, 7, 29, 52, 60, DateTimeKind.Local).AddTicks(1873), new DateTime(2020, 3, 3, 3, 51, 31, 266, DateTimeKind.Local).AddTicks(3046), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 12, "", "", new DateTime(2019, 10, 3, 21, 44, 51, 412, DateTimeKind.Local).AddTicks(4555), new DateTime(2020, 3, 26, 6, 13, 27, 716, DateTimeKind.Local).AddTicks(2302), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 11, "", "", new DateTime(2020, 3, 26, 5, 26, 46, 399, DateTimeKind.Local).AddTicks(3747), new DateTime(2019, 6, 27, 14, 24, 45, 315, DateTimeKind.Local).AddTicks(742), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 10, "", "", new DateTime(2020, 2, 2, 18, 21, 10, 887, DateTimeKind.Local).AddTicks(7022), new DateTime(2019, 7, 27, 14, 34, 16, 735, DateTimeKind.Local).AddTicks(266), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 9, "", "", new DateTime(2019, 12, 21, 3, 13, 8, 977, DateTimeKind.Local).AddTicks(719), new DateTime(2020, 5, 3, 21, 56, 23, 837, DateTimeKind.Local).AddTicks(7828), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 7, "", "", new DateTime(2020, 1, 12, 13, 34, 41, 656, DateTimeKind.Local).AddTicks(9638), new DateTime(2019, 10, 29, 19, 47, 22, 263, DateTimeKind.Local).AddTicks(8731), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 6, "", "", new DateTime(2019, 12, 31, 3, 30, 31, 713, DateTimeKind.Local).AddTicks(714), new DateTime(2019, 12, 11, 21, 42, 43, 339, DateTimeKind.Local).AddTicks(8724), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 5, "", "", new DateTime(2019, 11, 10, 23, 43, 28, 751, DateTimeKind.Local).AddTicks(9112), new DateTime(2020, 5, 21, 4, 51, 56, 671, DateTimeKind.Local).AddTicks(860), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 4, "", "", new DateTime(2019, 11, 21, 17, 8, 46, 872, DateTimeKind.Local).AddTicks(9064), new DateTime(2020, 2, 21, 8, 24, 31, 827, DateTimeKind.Local).AddTicks(2519), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 3, "", "", new DateTime(2020, 3, 22, 4, 29, 45, 450, DateTimeKind.Local).AddTicks(560), new DateTime(2019, 7, 4, 15, 33, 20, 666, DateTimeKind.Local).AddTicks(9861), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 2, "", "", new DateTime(2019, 11, 30, 2, 8, 59, 818, DateTimeKind.Local).AddTicks(753), new DateTime(2020, 6, 22, 5, 35, 26, 704, DateTimeKind.Local).AddTicks(8719), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 50, "", "", new DateTime(2020, 2, 14, 2, 9, 42, 79, DateTimeKind.Local).AddTicks(2426), new DateTime(2020, 1, 8, 2, 46, 20, 487, DateTimeKind.Local).AddTicks(6379), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 23, "", "", new DateTime(2020, 4, 3, 21, 3, 21, 249, DateTimeKind.Local).AddTicks(1598), new DateTime(2019, 8, 2, 0, 3, 52, 758, DateTimeKind.Local).AddTicks(671), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 24, "", "", new DateTime(2019, 10, 18, 15, 26, 47, 857, DateTimeKind.Local).AddTicks(1738), new DateTime(2020, 2, 10, 18, 5, 55, 71, DateTimeKind.Local).AddTicks(4977), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 1, "", "", new DateTime(2019, 9, 2, 14, 37, 25, 51, DateTimeKind.Local).AddTicks(106), new DateTime(2020, 5, 5, 10, 5, 31, 8, DateTimeKind.Local).AddTicks(6063), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 26, "", "", new DateTime(2020, 4, 22, 8, 20, 47, 985, DateTimeKind.Local).AddTicks(1426), new DateTime(2019, 10, 18, 1, 20, 19, 98, DateTimeKind.Local).AddTicks(2366), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 25, "", "", new DateTime(2020, 1, 18, 1, 55, 55, 204, DateTimeKind.Local).AddTicks(6126), new DateTime(2019, 12, 26, 7, 10, 4, 288, DateTimeKind.Local).AddTicks(5835), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 47, "", "", new DateTime(2020, 1, 7, 0, 41, 36, 69, DateTimeKind.Local).AddTicks(8444), new DateTime(2020, 2, 25, 14, 25, 53, 95, DateTimeKind.Local).AddTicks(7164), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 46, "", "", new DateTime(2020, 6, 15, 6, 34, 48, 270, DateTimeKind.Local).AddTicks(121), new DateTime(2019, 8, 18, 19, 39, 31, 44, DateTimeKind.Local).AddTicks(7900), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 45, "", "", new DateTime(2019, 9, 10, 6, 25, 3, 758, DateTimeKind.Local).AddTicks(6356), new DateTime(2019, 10, 24, 5, 39, 23, 7, DateTimeKind.Local).AddTicks(4580), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 44, "", "", new DateTime(2020, 1, 30, 18, 23, 14, 418, DateTimeKind.Local).AddTicks(1884), new DateTime(2019, 10, 4, 8, 35, 7, 183, DateTimeKind.Local).AddTicks(7828), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 43, "", "", new DateTime(2019, 7, 5, 9, 6, 2, 485, DateTimeKind.Local).AddTicks(5261), new DateTime(2019, 9, 26, 16, 46, 49, 234, DateTimeKind.Local).AddTicks(1137), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 42, "", "", new DateTime(2019, 7, 18, 18, 36, 58, 330, DateTimeKind.Local).AddTicks(5935), new DateTime(2020, 5, 6, 18, 19, 15, 589, DateTimeKind.Local).AddTicks(9889), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 41, "", "", new DateTime(2019, 9, 11, 10, 10, 32, 157, DateTimeKind.Local).AddTicks(6342), new DateTime(2020, 2, 24, 12, 8, 56, 387, DateTimeKind.Local).AddTicks(3804), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 40, "", "", new DateTime(2020, 6, 2, 23, 31, 58, 193, DateTimeKind.Local).AddTicks(2312), new DateTime(2019, 8, 5, 16, 36, 51, 271, DateTimeKind.Local).AddTicks(5474), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 39, "", "", new DateTime(2020, 4, 2, 2, 33, 16, 320, DateTimeKind.Local).AddTicks(1892), new DateTime(2020, 2, 11, 11, 6, 23, 999, DateTimeKind.Local).AddTicks(3176), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 38, "", "", new DateTime(2020, 5, 2, 14, 40, 12, 257, DateTimeKind.Local).AddTicks(9231), new DateTime(2019, 9, 20, 2, 14, 27, 349, DateTimeKind.Local).AddTicks(9679), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 48, "", "", new DateTime(2019, 11, 8, 2, 39, 33, 938, DateTimeKind.Local).AddTicks(5202), new DateTime(2020, 5, 29, 10, 22, 39, 988, DateTimeKind.Local).AddTicks(4645), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 36, "", "", new DateTime(2020, 2, 21, 3, 9, 22, 165, DateTimeKind.Local).AddTicks(4868), new DateTime(2019, 8, 2, 0, 29, 13, 383, DateTimeKind.Local).AddTicks(7652), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 27, "", "", new DateTime(2019, 8, 3, 21, 50, 44, 822, DateTimeKind.Local).AddTicks(8028), new DateTime(2020, 4, 25, 18, 15, 7, 913, DateTimeKind.Local).AddTicks(5271), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 37, "", "", new DateTime(2019, 8, 29, 18, 42, 15, 710, DateTimeKind.Local).AddTicks(6342), new DateTime(2019, 11, 22, 5, 12, 35, 604, DateTimeKind.Local).AddTicks(67), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 29, "", "", new DateTime(2019, 10, 23, 19, 29, 59, 842, DateTimeKind.Local).AddTicks(5380), new DateTime(2019, 7, 24, 23, 12, 8, 648, DateTimeKind.Local).AddTicks(2611), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 30, "", "", new DateTime(2019, 8, 3, 6, 59, 40, 280, DateTimeKind.Local).AddTicks(4313), new DateTime(2019, 7, 9, 4, 21, 58, 660, DateTimeKind.Local).AddTicks(5750), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 31, "", "", new DateTime(2019, 12, 6, 19, 12, 47, 685, DateTimeKind.Local).AddTicks(8390), new DateTime(2020, 1, 8, 3, 35, 10, 724, DateTimeKind.Local).AddTicks(6898), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 28, "", "", new DateTime(2020, 6, 21, 16, 31, 29, 915, DateTimeKind.Local).AddTicks(2669), new DateTime(2019, 7, 24, 16, 35, 15, 702, DateTimeKind.Local).AddTicks(6972), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 33, "", "", new DateTime(2020, 1, 11, 21, 50, 56, 220, DateTimeKind.Local).AddTicks(181), new DateTime(2020, 3, 31, 13, 24, 34, 840, DateTimeKind.Local).AddTicks(7192), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 34, "", "", new DateTime(2020, 4, 4, 14, 16, 37, 234, DateTimeKind.Local).AddTicks(55), new DateTime(2020, 5, 11, 8, 5, 10, 651, DateTimeKind.Local).AddTicks(6406), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 35, "", "", new DateTime(2020, 4, 27, 18, 57, 14, 289, DateTimeKind.Local).AddTicks(1399), new DateTime(2019, 9, 10, 6, 29, 38, 165, DateTimeKind.Local).AddTicks(911), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 32, "", "", new DateTime(2019, 10, 16, 7, 14, 21, 389, DateTimeKind.Local).AddTicks(1552), new DateTime(2019, 11, 26, 21, 2, 29, 709, DateTimeKind.Local).AddTicks(6890), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 65, new DateTime(2019, 8, 23, 4, 3, 14, 999, DateTimeKind.Local).AddTicks(2288), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 72, new DateTime(2019, 10, 22, 19, 17, 50, 750, DateTimeKind.Local).AddTicks(6197), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 71, new DateTime(2019, 12, 19, 6, 5, 30, 293, DateTimeKind.Local).AddTicks(286), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 70, new DateTime(2019, 12, 24, 7, 45, 4, 972, DateTimeKind.Local).AddTicks(5522), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 69, new DateTime(2019, 7, 24, 2, 4, 34, 548, DateTimeKind.Local).AddTicks(7763), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 68, new DateTime(2020, 5, 10, 23, 8, 52, 785, DateTimeKind.Local).AddTicks(8725), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 67, new DateTime(2019, 10, 10, 0, 46, 32, 110, DateTimeKind.Local).AddTicks(1980), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 66, new DateTime(2020, 5, 6, 23, 7, 31, 54, DateTimeKind.Local).AddTicks(9108), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 64, new DateTime(2019, 10, 8, 17, 39, 32, 626, DateTimeKind.Local).AddTicks(9747), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 53, new DateTime(2019, 9, 21, 6, 29, 10, 868, DateTimeKind.Local).AddTicks(9598), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 62, new DateTime(2020, 1, 27, 1, 55, 9, 815, DateTimeKind.Local).AddTicks(7600), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 61, new DateTime(2020, 1, 16, 8, 10, 47, 860, DateTimeKind.Local).AddTicks(7716), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 60, new DateTime(2020, 1, 29, 15, 59, 21, 609, DateTimeKind.Local).AddTicks(7612), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 59, new DateTime(2020, 2, 11, 0, 3, 19, 44, DateTimeKind.Local).AddTicks(652), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 58, new DateTime(2019, 10, 27, 6, 7, 4, 518, DateTimeKind.Local).AddTicks(8920), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 57, new DateTime(2020, 3, 24, 9, 1, 32, 325, DateTimeKind.Local).AddTicks(5252), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 56, new DateTime(2019, 7, 18, 5, 50, 15, 664, DateTimeKind.Local).AddTicks(6945), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 55, new DateTime(2019, 11, 2, 10, 50, 3, 956, DateTimeKind.Local).AddTicks(643), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 54, new DateTime(2019, 9, 25, 19, 57, 39, 445, DateTimeKind.Local).AddTicks(7822), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 73, new DateTime(2019, 11, 9, 7, 41, 32, 716, DateTimeKind.Local).AddTicks(2544), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 52, new DateTime(2019, 11, 20, 17, 25, 18, 141, DateTimeKind.Local).AddTicks(229), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 63, new DateTime(2019, 7, 23, 21, 20, 33, 545, DateTimeKind.Local).AddTicks(7173), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 74, new DateTime(2020, 3, 16, 3, 56, 33, 312, DateTimeKind.Local).AddTicks(2632), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 85, new DateTime(2020, 2, 10, 4, 32, 17, 850, DateTimeKind.Local).AddTicks(7587), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 76, new DateTime(2019, 12, 22, 11, 43, 12, 182, DateTimeKind.Local).AddTicks(574), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 98, new DateTime(2020, 2, 2, 20, 27, 11, 836, DateTimeKind.Local).AddTicks(3167), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 51, new DateTime(2019, 9, 21, 18, 4, 59, 675, DateTimeKind.Local).AddTicks(7212), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 97, new DateTime(2020, 5, 19, 0, 22, 24, 460, DateTimeKind.Local).AddTicks(6393), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 96, new DateTime(2020, 2, 8, 15, 28, 33, 71, DateTimeKind.Local).AddTicks(9408), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 95, new DateTime(2019, 7, 10, 9, 52, 1, 176, DateTimeKind.Local).AddTicks(5031), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 94, new DateTime(2019, 12, 29, 16, 18, 5, 364, DateTimeKind.Local).AddTicks(5280), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 93, new DateTime(2020, 2, 20, 1, 53, 58, 150, DateTimeKind.Local).AddTicks(5323), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 92, new DateTime(2019, 8, 8, 7, 55, 15, 629, DateTimeKind.Local).AddTicks(9839), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 91, new DateTime(2019, 11, 1, 13, 9, 2, 285, DateTimeKind.Local).AddTicks(5892), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 90, new DateTime(2020, 4, 22, 2, 8, 1, 428, DateTimeKind.Local).AddTicks(4328), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 75, new DateTime(2020, 1, 11, 0, 40, 11, 29, DateTimeKind.Local).AddTicks(9589), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 89, new DateTime(2019, 8, 10, 16, 19, 11, 640, DateTimeKind.Local).AddTicks(9266), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 87, new DateTime(2020, 6, 4, 16, 32, 9, 787, DateTimeKind.Local).AddTicks(8601), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 86, new DateTime(2020, 3, 18, 20, 14, 43, 588, DateTimeKind.Local).AddTicks(9396), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 84, new DateTime(2020, 6, 5, 4, 8, 1, 981, DateTimeKind.Local).AddTicks(4454), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 83, new DateTime(2020, 1, 3, 19, 58, 13, 463, DateTimeKind.Local).AddTicks(5871), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 82, new DateTime(2019, 12, 5, 19, 2, 24, 130, DateTimeKind.Local).AddTicks(3530), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 81, new DateTime(2019, 10, 9, 2, 46, 27, 386, DateTimeKind.Local).AddTicks(1406), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 80, new DateTime(2020, 4, 30, 5, 32, 18, 566, DateTimeKind.Local).AddTicks(2056), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 79, new DateTime(2020, 1, 30, 14, 12, 35, 581, DateTimeKind.Local).AddTicks(9693), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 78, new DateTime(2020, 4, 28, 3, 23, 44, 192, DateTimeKind.Local).AddTicks(6731), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 77, new DateTime(2020, 3, 16, 6, 24, 18, 401, DateTimeKind.Local).AddTicks(1816), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 88, new DateTime(2020, 2, 22, 16, 58, 5, 368, DateTimeKind.Local).AddTicks(8433), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 50, new DateTime(2019, 7, 2, 8, 7, 33, 786, DateTimeKind.Local).AddTicks(4879), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 26, new DateTime(2020, 5, 15, 21, 44, 3, 281, DateTimeKind.Local).AddTicks(2856), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 48, new DateTime(2020, 1, 7, 5, 53, 42, 247, DateTimeKind.Local).AddTicks(5463), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 20, new DateTime(2020, 2, 14, 22, 11, 41, 823, DateTimeKind.Local).AddTicks(1971), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 19, new DateTime(2019, 12, 27, 10, 18, 23, 89, DateTimeKind.Local).AddTicks(7581), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 18, new DateTime(2019, 7, 18, 3, 56, 35, 526, DateTimeKind.Local).AddTicks(1281), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 17, new DateTime(2019, 10, 18, 5, 50, 7, 925, DateTimeKind.Local).AddTicks(3086), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 16, new DateTime(2020, 1, 11, 0, 51, 59, 97, DateTimeKind.Local).AddTicks(2432), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 15, new DateTime(2020, 1, 5, 14, 15, 35, 649, DateTimeKind.Local).AddTicks(9778), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 14, new DateTime(2020, 1, 5, 23, 45, 1, 60, DateTimeKind.Local).AddTicks(3320), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 13, new DateTime(2019, 12, 25, 16, 32, 16, 939, DateTimeKind.Local).AddTicks(4312), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 12, new DateTime(2019, 9, 13, 5, 36, 52, 787, DateTimeKind.Local).AddTicks(7509), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 11, new DateTime(2019, 10, 15, 7, 14, 16, 989, DateTimeKind.Local).AddTicks(4064), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 10, new DateTime(2020, 1, 5, 21, 8, 18, 25, DateTimeKind.Local).AddTicks(7480), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 9, new DateTime(2020, 6, 10, 5, 51, 37, 7, DateTimeKind.Local).AddTicks(6542), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 8, new DateTime(2019, 11, 11, 9, 26, 11, 119, DateTimeKind.Local).AddTicks(9249), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 7, new DateTime(2020, 3, 2, 20, 56, 56, 897, DateTimeKind.Local).AddTicks(8689), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 6, new DateTime(2019, 10, 29, 6, 23, 49, 679, DateTimeKind.Local).AddTicks(7210), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 5, new DateTime(2019, 12, 4, 22, 15, 24, 917, DateTimeKind.Local).AddTicks(9160), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 4, new DateTime(2019, 11, 3, 22, 13, 5, 327, DateTimeKind.Local).AddTicks(8848), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 3, new DateTime(2019, 10, 15, 11, 53, 3, 238, DateTimeKind.Local).AddTicks(5627), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 2, new DateTime(2019, 7, 4, 6, 15, 21, 361, DateTimeKind.Local).AddTicks(9968), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 1, new DateTime(2020, 1, 24, 14, 46, 13, 328, DateTimeKind.Local).AddTicks(9418), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 99, new DateTime(2020, 2, 29, 0, 58, 41, 757, DateTimeKind.Local).AddTicks(5439), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 21, new DateTime(2019, 11, 29, 8, 5, 53, 112, DateTimeKind.Local).AddTicks(7617), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 22, new DateTime(2019, 11, 17, 21, 31, 8, 560, DateTimeKind.Local).AddTicks(743), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 23, new DateTime(2020, 3, 8, 2, 20, 32, 635, DateTimeKind.Local).AddTicks(4838), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 24, new DateTime(2019, 8, 13, 16, 55, 29, 60, DateTimeKind.Local).AddTicks(6435), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 47, new DateTime(2019, 7, 3, 1, 54, 16, 789, DateTimeKind.Local).AddTicks(2672), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 46, new DateTime(2019, 11, 9, 5, 24, 14, 940, DateTimeKind.Local).AddTicks(9748), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 45, new DateTime(2019, 11, 1, 17, 8, 19, 995, DateTimeKind.Local).AddTicks(2171), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 44, new DateTime(2020, 3, 21, 0, 50, 58, 869, DateTimeKind.Local).AddTicks(3260), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 43, new DateTime(2019, 12, 17, 1, 23, 53, 87, DateTimeKind.Local).AddTicks(4244), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 42, new DateTime(2020, 2, 26, 14, 31, 48, 990, DateTimeKind.Local).AddTicks(6236), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 41, new DateTime(2019, 11, 24, 3, 33, 7, 903, DateTimeKind.Local).AddTicks(4997), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 40, new DateTime(2019, 10, 8, 6, 34, 31, 274, DateTimeKind.Local).AddTicks(4855), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 39, new DateTime(2020, 1, 16, 2, 50, 17, 628, DateTimeKind.Local).AddTicks(5213), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 38, new DateTime(2019, 10, 3, 7, 7, 55, 410, DateTimeKind.Local).AddTicks(5854), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 49, new DateTime(2019, 8, 11, 3, 3, 23, 814, DateTimeKind.Local).AddTicks(3341), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 37, new DateTime(2020, 1, 13, 21, 6, 56, 60, DateTimeKind.Local).AddTicks(6712), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 35, new DateTime(2020, 2, 14, 5, 5, 36, 377, DateTimeKind.Local).AddTicks(5224), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 34, new DateTime(2019, 8, 14, 23, 29, 10, 950, DateTimeKind.Local).AddTicks(1246), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 33, new DateTime(2020, 5, 14, 6, 50, 59, 252, DateTimeKind.Local).AddTicks(5811), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 32, new DateTime(2019, 8, 30, 20, 15, 44, 453, DateTimeKind.Local).AddTicks(8269), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 31, new DateTime(2019, 10, 11, 23, 33, 24, 679, DateTimeKind.Local).AddTicks(4221), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 30, new DateTime(2020, 2, 9, 2, 39, 16, 950, DateTimeKind.Local).AddTicks(1362), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 29, new DateTime(2020, 1, 12, 19, 32, 53, 840, DateTimeKind.Local).AddTicks(2449), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 28, new DateTime(2019, 11, 14, 3, 0, 53, 239, DateTimeKind.Local).AddTicks(6629), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 27, new DateTime(2019, 10, 15, 14, 46, 50, 228, DateTimeKind.Local).AddTicks(2811), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 25, new DateTime(2019, 11, 11, 11, 21, 54, 450, DateTimeKind.Local).AddTicks(5479), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 36, new DateTime(2020, 1, 12, 11, 47, 55, 87, DateTimeKind.Local).AddTicks(5228), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 100, new DateTime(2019, 11, 30, 20, 20, 8, 161, DateTimeKind.Local).AddTicks(2889), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 6, 25, 19, 33, 16, 239, DateTimeKind.Local).AddTicks(8977), new DateTime(2020, 6, 25, 20, 58, 39, 146, DateTimeKind.Local).AddTicks(508), new DateTime(2020, 6, 25, 7, 19, 38, 757, DateTimeKind.Local).AddTicks(4892), 40, "", "http://tom.eu", "commodi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 6, 25, 20, 47, 35, 54, DateTimeKind.Local).AddTicks(1583), new DateTime(2020, 6, 25, 8, 23, 1, 305, DateTimeKind.Local).AddTicks(207), new DateTime(2020, 6, 25, 8, 20, 34, 379, DateTimeKind.Local).AddTicks(5659), 69, "", "http://clémence.eu", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 6, 25, 2, 10, 45, 375, DateTimeKind.Local).AddTicks(9985), new DateTime(2020, 6, 25, 6, 38, 50, 22, DateTimeKind.Local).AddTicks(2571), new DateTime(2020, 6, 25, 5, 1, 34, 103, DateTimeKind.Local).AddTicks(3158), 69, "", "https://romane.fr", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 6, 25, 10, 7, 49, 937, DateTimeKind.Local).AddTicks(719), new DateTime(2020, 6, 25, 2, 19, 31, 321, DateTimeKind.Local).AddTicks(8961), new DateTime(2020, 6, 25, 14, 32, 30, 546, DateTimeKind.Local).AddTicks(150), 68, "", "https://carla.org", "fugit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 6, 25, 15, 50, 22, 473, DateTimeKind.Local).AddTicks(86), new DateTime(2020, 6, 25, 16, 2, 2, 54, DateTimeKind.Local).AddTicks(4495), new DateTime(2020, 6, 25, 9, 47, 2, 327, DateTimeKind.Local).AddTicks(2337), 67, "", "http://quentin.net", "iusto" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 6, 25, 21, 8, 11, 632, DateTimeKind.Local).AddTicks(7449), new DateTime(2020, 6, 25, 9, 17, 10, 625, DateTimeKind.Local).AddTicks(6584), new DateTime(2020, 6, 25, 3, 34, 52, 424, DateTimeKind.Local).AddTicks(4367), 66, "", "http://lou.info", "iusto" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 6, 25, 7, 9, 41, 11, DateTimeKind.Local).AddTicks(3241), new DateTime(2020, 6, 25, 14, 59, 19, 930, DateTimeKind.Local).AddTicks(8738), new DateTime(2020, 6, 25, 20, 15, 10, 560, DateTimeKind.Local).AddTicks(6630), 65, "", "https://lena.com", "officiis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 6, 25, 5, 34, 9, 349, DateTimeKind.Local).AddTicks(2097), new DateTime(2020, 6, 25, 7, 52, 37, 218, DateTimeKind.Local).AddTicks(1332), new DateTime(2020, 6, 25, 18, 5, 29, 285, DateTimeKind.Local).AddTicks(1628), 65, "", "https://eva.eu", "itaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 6, 25, 14, 54, 17, 125, DateTimeKind.Local).AddTicks(6783), new DateTime(2020, 6, 24, 23, 57, 28, 743, DateTimeKind.Local).AddTicks(4841), new DateTime(2020, 6, 25, 0, 53, 48, 516, DateTimeKind.Local).AddTicks(615), 64, "", "http://kylian.org", "a" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 6, 25, 13, 30, 25, 696, DateTimeKind.Local).AddTicks(2570), new DateTime(2020, 6, 25, 13, 39, 28, 833, DateTimeKind.Local).AddTicks(3240), new DateTime(2020, 6, 25, 21, 29, 18, 989, DateTimeKind.Local).AddTicks(7872), 61, "", "http://yanis.info", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 6, 25, 9, 3, 0, 153, DateTimeKind.Local).AddTicks(2645), new DateTime(2020, 6, 25, 1, 40, 9, 577, DateTimeKind.Local).AddTicks(2765), new DateTime(2020, 6, 25, 8, 12, 59, 467, DateTimeKind.Local).AddTicks(5890), 60, "", "http://ines.fr", "porro" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 6, 25, 3, 42, 45, 24, DateTimeKind.Local).AddTicks(237), new DateTime(2020, 6, 25, 6, 41, 34, 639, DateTimeKind.Local).AddTicks(7001), new DateTime(2020, 6, 25, 17, 46, 26, 383, DateTimeKind.Local).AddTicks(8360), 60, "", "http://paul.net", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 6, 25, 0, 55, 27, 636, DateTimeKind.Local).AddTicks(7125), new DateTime(2020, 6, 25, 6, 29, 49, 1, DateTimeKind.Local).AddTicks(6967), new DateTime(2020, 6, 25, 15, 49, 6, 710, DateTimeKind.Local).AddTicks(2594), 69, "", "https://eva.info", "ad" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 6, 25, 16, 48, 59, 391, DateTimeKind.Local).AddTicks(1529), new DateTime(2020, 6, 25, 12, 24, 43, 775, DateTimeKind.Local).AddTicks(8404), new DateTime(2020, 6, 25, 19, 49, 27, 362, DateTimeKind.Local).AddTicks(9650), 59, "", "https://lisa.eu", "doloribus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 6, 25, 5, 54, 24, 639, DateTimeKind.Local).AddTicks(3224), new DateTime(2020, 6, 25, 10, 35, 28, 792, DateTimeKind.Local).AddTicks(7593), new DateTime(2020, 6, 25, 8, 9, 7, 178, DateTimeKind.Local).AddTicks(7101), 57, "", "http://enzo.name", "magni" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 6, 25, 15, 4, 49, 35, DateTimeKind.Local).AddTicks(9354), new DateTime(2020, 6, 25, 1, 47, 44, 360, DateTimeKind.Local).AddTicks(127), new DateTime(2020, 6, 25, 12, 27, 33, 378, DateTimeKind.Local).AddTicks(4418), 56, "", "https://mélissa.com", "ad" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 6, 25, 21, 3, 9, 333, DateTimeKind.Local).AddTicks(2072), new DateTime(2020, 6, 25, 19, 36, 15, 42, DateTimeKind.Local).AddTicks(5182), new DateTime(2020, 6, 25, 9, 35, 35, 557, DateTimeKind.Local).AddTicks(1935), 54, "", "https://emilie.fr", "fugit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 6, 25, 19, 48, 53, 61, DateTimeKind.Local).AddTicks(3812), new DateTime(2020, 6, 25, 13, 19, 4, 236, DateTimeKind.Local).AddTicks(9559), new DateTime(2020, 6, 25, 17, 7, 51, 627, DateTimeKind.Local).AddTicks(8840), 52, "", "http://adam.org", "nobis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 6, 25, 18, 1, 42, 504, DateTimeKind.Local).AddTicks(8363), new DateTime(2020, 6, 25, 14, 49, 16, 678, DateTimeKind.Local).AddTicks(9032), new DateTime(2020, 6, 24, 22, 24, 41, 189, DateTimeKind.Local).AddTicks(1661), 51, "", "https://mathilde.eu", "rem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 6, 25, 4, 18, 36, 904, DateTimeKind.Local).AddTicks(9120), new DateTime(2020, 6, 25, 16, 46, 3, 656, DateTimeKind.Local).AddTicks(9350), new DateTime(2020, 6, 25, 12, 21, 49, 238, DateTimeKind.Local).AddTicks(9605), 48, "", "http://ines.eu", "id" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 6, 25, 5, 4, 10, 730, DateTimeKind.Local).AddTicks(6465), new DateTime(2020, 6, 25, 10, 29, 3, 562, DateTimeKind.Local).AddTicks(8060), new DateTime(2020, 6, 25, 0, 30, 52, 501, DateTimeKind.Local).AddTicks(8624), 48, "", "http://tom.name", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 6, 25, 19, 50, 37, 937, DateTimeKind.Local).AddTicks(4276), new DateTime(2020, 6, 25, 13, 20, 49, 121, DateTimeKind.Local).AddTicks(8539), new DateTime(2020, 6, 25, 19, 49, 10, 484, DateTimeKind.Local).AddTicks(8761), 46, "", "http://lou.fr", "quaerat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 6, 25, 9, 36, 49, 272, DateTimeKind.Local).AddTicks(3804), new DateTime(2020, 6, 25, 3, 1, 51, 506, DateTimeKind.Local).AddTicks(378), new DateTime(2020, 6, 25, 18, 47, 58, 476, DateTimeKind.Local).AddTicks(4923), 46, "", "https://clément.net", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 6, 25, 7, 16, 30, 600, DateTimeKind.Local).AddTicks(9014), new DateTime(2020, 6, 24, 22, 42, 47, 938, DateTimeKind.Local).AddTicks(575), new DateTime(2020, 6, 25, 17, 20, 20, 605, DateTimeKind.Local).AddTicks(8144), 45, "", "https://alicia.info", "unde" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 6, 25, 2, 49, 22, 357, DateTimeKind.Local).AddTicks(9555), new DateTime(2020, 6, 25, 13, 54, 7, 695, DateTimeKind.Local).AddTicks(3262), new DateTime(2020, 6, 25, 11, 1, 54, 804, DateTimeKind.Local).AddTicks(5164), 45, "", "https://baptiste.fr", "asperiores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 6, 25, 20, 26, 29, 852, DateTimeKind.Local).AddTicks(1255), new DateTime(2020, 6, 25, 9, 22, 1, 657, DateTimeKind.Local).AddTicks(493), new DateTime(2020, 6, 25, 13, 29, 43, 12, DateTimeKind.Local).AddTicks(949), 58, "", "http://louis.com", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 6, 25, 8, 29, 36, 981, DateTimeKind.Local).AddTicks(6862), new DateTime(2020, 6, 25, 21, 43, 38, 346, DateTimeKind.Local).AddTicks(9168), new DateTime(2020, 6, 24, 23, 45, 51, 473, DateTimeKind.Local).AddTicks(8324), 71, "", "http://carla.org", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 6, 25, 8, 38, 37, 597, DateTimeKind.Local).AddTicks(4840), new DateTime(2020, 6, 25, 11, 57, 59, 978, DateTimeKind.Local).AddTicks(6328), new DateTime(2020, 6, 25, 17, 58, 9, 982, DateTimeKind.Local).AddTicks(895), 71, "", "http://quentin.org", "maiores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 6, 25, 8, 56, 45, 968, DateTimeKind.Local).AddTicks(185), new DateTime(2020, 6, 25, 7, 43, 4, 395, DateTimeKind.Local).AddTicks(981), new DateTime(2020, 6, 25, 21, 11, 1, 768, DateTimeKind.Local).AddTicks(6289), 72, "", "http://carla.net", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 6, 25, 19, 30, 7, 767, DateTimeKind.Local).AddTicks(4052), new DateTime(2020, 6, 25, 13, 27, 20, 23, DateTimeKind.Local).AddTicks(4254), new DateTime(2020, 6, 25, 13, 4, 38, 435, DateTimeKind.Local).AddTicks(7998), 100, "", "http://sarah.net", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 6, 25, 0, 13, 12, 259, DateTimeKind.Local).AddTicks(9520), new DateTime(2020, 6, 25, 3, 17, 50, 937, DateTimeKind.Local).AddTicks(1026), new DateTime(2020, 6, 25, 1, 40, 25, 7, DateTimeKind.Local).AddTicks(2320), 100, "", "http://maeva.fr", "nisi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 6, 25, 0, 46, 29, 635, DateTimeKind.Local).AddTicks(8886), new DateTime(2020, 6, 25, 0, 40, 16, 867, DateTimeKind.Local).AddTicks(6838), new DateTime(2020, 6, 24, 23, 58, 53, 101, DateTimeKind.Local).AddTicks(3524), 99, "", "https://baptiste.name", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 6, 25, 17, 6, 7, 132, DateTimeKind.Local).AddTicks(2585), new DateTime(2020, 6, 25, 10, 38, 51, 539, DateTimeKind.Local).AddTicks(681), new DateTime(2020, 6, 25, 8, 51, 23, 963, DateTimeKind.Local).AddTicks(3758), 99, "", "http://justine.fr", "quaerat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 6, 25, 4, 15, 0, 324, DateTimeKind.Local).AddTicks(9015), new DateTime(2020, 6, 25, 19, 28, 33, 576, DateTimeKind.Local).AddTicks(1192), new DateTime(2020, 6, 25, 18, 2, 17, 259, DateTimeKind.Local).AddTicks(4746), 99, "", "https://romain.info", "ad" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 6, 25, 21, 26, 10, 991, DateTimeKind.Local).AddTicks(7222), new DateTime(2020, 6, 25, 2, 43, 41, 40, DateTimeKind.Local).AddTicks(6920), new DateTime(2020, 6, 25, 15, 1, 49, 796, DateTimeKind.Local).AddTicks(8293), 99, "", "https://nathan.net", "pariatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 6, 25, 17, 50, 39, 236, DateTimeKind.Local).AddTicks(6630), new DateTime(2020, 6, 25, 19, 5, 27, 845, DateTimeKind.Local).AddTicks(1901), new DateTime(2020, 6, 25, 13, 17, 3, 657, DateTimeKind.Local).AddTicks(2587), 97, "", "http://elisa.org", "eius" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 6, 25, 11, 29, 7, 717, DateTimeKind.Local).AddTicks(2237), new DateTime(2020, 6, 25, 17, 17, 9, 895, DateTimeKind.Local).AddTicks(8612), new DateTime(2020, 6, 25, 13, 27, 6, 711, DateTimeKind.Local).AddTicks(585), 96, "", "https://théo.eu", "aliquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 6, 25, 12, 54, 58, 433, DateTimeKind.Local).AddTicks(1728), new DateTime(2020, 6, 25, 14, 55, 28, 240, DateTimeKind.Local).AddTicks(1499), new DateTime(2020, 6, 25, 0, 7, 43, 187, DateTimeKind.Local).AddTicks(6180), 95, "", "https://léo.fr", "veniam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 6, 25, 10, 33, 54, 960, DateTimeKind.Local).AddTicks(8255), new DateTime(2020, 6, 25, 15, 18, 54, 212, DateTimeKind.Local).AddTicks(5248), new DateTime(2020, 6, 25, 2, 10, 26, 307, DateTimeKind.Local).AddTicks(5269), 93, "", "https://nathan.org", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 6, 25, 18, 29, 16, 473, DateTimeKind.Local).AddTicks(8737), new DateTime(2020, 6, 25, 2, 30, 58, 276, DateTimeKind.Local).AddTicks(851), new DateTime(2020, 6, 25, 9, 49, 14, 256, DateTimeKind.Local).AddTicks(8226), 92, "", "http://lilou.fr", "repellendus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 6, 25, 8, 21, 26, 565, DateTimeKind.Local).AddTicks(6240), new DateTime(2020, 6, 25, 21, 35, 43, 736, DateTimeKind.Local).AddTicks(1601), new DateTime(2020, 6, 25, 14, 7, 57, 177, DateTimeKind.Local).AddTicks(661), 92, "", "http://océane.info", "quam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 6, 25, 15, 24, 35, 717, DateTimeKind.Local).AddTicks(8711), new DateTime(2020, 6, 25, 9, 2, 38, 716, DateTimeKind.Local).AddTicks(7567), new DateTime(2020, 6, 25, 15, 9, 11, 952, DateTimeKind.Local).AddTicks(3334), 91, "", "http://zoe.info", "voluptate" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 6, 25, 1, 12, 39, 484, DateTimeKind.Local).AddTicks(2458), new DateTime(2020, 6, 25, 10, 36, 31, 131, DateTimeKind.Local).AddTicks(1742), new DateTime(2020, 6, 25, 3, 21, 38, 317, DateTimeKind.Local).AddTicks(3504), 90, "", "https://enzo.net", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 6, 25, 15, 49, 46, 894, DateTimeKind.Local).AddTicks(3669), new DateTime(2020, 6, 25, 14, 10, 54, 16, DateTimeKind.Local).AddTicks(9898), new DateTime(2020, 6, 25, 12, 51, 48, 712, DateTimeKind.Local).AddTicks(4513), 88, "", "https://mélissa.com", "debitis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 6, 25, 2, 27, 39, 152, DateTimeKind.Local).AddTicks(3485), new DateTime(2020, 6, 25, 7, 55, 40, 875, DateTimeKind.Local).AddTicks(2959), new DateTime(2020, 6, 25, 7, 31, 39, 388, DateTimeKind.Local).AddTicks(7272), 87, "", "http://jeanne.net", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 6, 25, 14, 39, 43, 128, DateTimeKind.Local).AddTicks(6697), new DateTime(2020, 6, 24, 23, 56, 57, 577, DateTimeKind.Local).AddTicks(9535), new DateTime(2020, 6, 25, 8, 18, 14, 251, DateTimeKind.Local).AddTicks(4431), 86, "", "https://kylian.net", "voluptas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 6, 25, 13, 14, 4, 956, DateTimeKind.Local).AddTicks(3571), new DateTime(2020, 6, 25, 13, 33, 29, 447, DateTimeKind.Local).AddTicks(1655), new DateTime(2020, 6, 25, 17, 20, 15, 945, DateTimeKind.Local).AddTicks(458), 84, "", "http://léo.net", "maxime" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 6, 25, 3, 24, 0, 912, DateTimeKind.Local).AddTicks(950), new DateTime(2020, 6, 25, 2, 15, 8, 798, DateTimeKind.Local).AddTicks(350), new DateTime(2020, 6, 25, 9, 32, 40, 810, DateTimeKind.Local).AddTicks(3127), 81, "", "http://rayan.name", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 6, 25, 10, 58, 25, 454, DateTimeKind.Local).AddTicks(8635), new DateTime(2020, 6, 25, 14, 46, 21, 675, DateTimeKind.Local).AddTicks(8823), new DateTime(2020, 6, 25, 16, 28, 7, 413, DateTimeKind.Local).AddTicks(2367), 81, "", "https://clément.info", "a" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 6, 25, 6, 20, 46, 595, DateTimeKind.Local).AddTicks(2147), new DateTime(2020, 6, 25, 10, 37, 32, 657, DateTimeKind.Local).AddTicks(627), new DateTime(2020, 6, 24, 23, 51, 36, 0, DateTimeKind.Local).AddTicks(7979), 79, "", "https://elisa.fr", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 6, 25, 10, 17, 22, 118, DateTimeKind.Local).AddTicks(9577), new DateTime(2020, 6, 25, 1, 20, 7, 769, DateTimeKind.Local).AddTicks(3827), new DateTime(2020, 6, 25, 8, 54, 22, 712, DateTimeKind.Local).AddTicks(2900), 78, "", "https://alicia.info", "soluta" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 6, 25, 7, 16, 39, 54, DateTimeKind.Local).AddTicks(2197), new DateTime(2020, 6, 25, 12, 47, 32, 867, DateTimeKind.Local).AddTicks(405), new DateTime(2020, 6, 25, 18, 8, 26, 399, DateTimeKind.Local).AddTicks(2705), 76, "", "https://noémie.org", "minima" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 6, 24, 23, 10, 0, 271, DateTimeKind.Local).AddTicks(1840), new DateTime(2020, 6, 24, 22, 54, 19, 374, DateTimeKind.Local).AddTicks(8998), new DateTime(2020, 6, 25, 1, 33, 52, 755, DateTimeKind.Local).AddTicks(6479), 73, "", "https://camille.fr", "porro" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 6, 25, 19, 42, 48, 418, DateTimeKind.Local).AddTicks(6384), new DateTime(2020, 6, 25, 18, 1, 42, 342, DateTimeKind.Local).AddTicks(1043), new DateTime(2020, 6, 24, 22, 13, 15, 836, DateTimeKind.Local).AddTicks(236), 73, "", "http://lena.fr", "voluptatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 6, 25, 11, 56, 26, 544, DateTimeKind.Local).AddTicks(4950), new DateTime(2020, 6, 25, 4, 26, 12, 276, DateTimeKind.Local).AddTicks(8479), new DateTime(2020, 6, 25, 16, 43, 13, 258, DateTimeKind.Local).AddTicks(7381), 44, "", "http://lena.net", "quibusdam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 6, 25, 13, 52, 27, 416, DateTimeKind.Local).AddTicks(6347), new DateTime(2020, 6, 25, 5, 29, 21, 461, DateTimeKind.Local).AddTicks(7035), new DateTime(2020, 6, 25, 4, 27, 52, 535, DateTimeKind.Local).AddTicks(8251), 41, "", "https://mohamed.name", "magnam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 6, 25, 8, 37, 4, 523, DateTimeKind.Local).AddTicks(1212), new DateTime(2020, 6, 25, 13, 51, 36, 887, DateTimeKind.Local).AddTicks(3523), new DateTime(2020, 6, 25, 4, 51, 57, 689, DateTimeKind.Local).AddTicks(5987), 100, "", "https://lucas.info", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 6, 25, 19, 57, 59, 549, DateTimeKind.Local).AddTicks(8304), new DateTime(2020, 6, 25, 3, 19, 52, 613, DateTimeKind.Local).AddTicks(2371), new DateTime(2020, 6, 25, 18, 47, 9, 371, DateTimeKind.Local).AddTicks(3139), 39, "", "http://emilie.net", "delectus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 6, 25, 5, 24, 5, 306, DateTimeKind.Local).AddTicks(8092), new DateTime(2020, 6, 25, 10, 40, 0, 455, DateTimeKind.Local).AddTicks(612), new DateTime(2020, 6, 25, 17, 27, 20, 798, DateTimeKind.Local).AddTicks(3072), 24, "", "http://ines.net", "magnam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 6, 25, 4, 8, 5, 841, DateTimeKind.Local).AddTicks(8067), new DateTime(2020, 6, 25, 9, 54, 57, 701, DateTimeKind.Local).AddTicks(106), new DateTime(2020, 6, 25, 17, 15, 18, 712, DateTimeKind.Local).AddTicks(498), 24, "", "https://lola.eu", "ipsa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 6, 25, 4, 12, 47, 469, DateTimeKind.Local).AddTicks(1531), new DateTime(2020, 6, 25, 11, 15, 24, 882, DateTimeKind.Local).AddTicks(4203), new DateTime(2020, 6, 25, 11, 10, 6, 927, DateTimeKind.Local).AddTicks(9193), 17, "", "http://chloé.info", "impedit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 6, 25, 0, 23, 19, 82, DateTimeKind.Local).AddTicks(5804), new DateTime(2020, 6, 25, 2, 9, 32, 669, DateTimeKind.Local).AddTicks(2567), new DateTime(2020, 6, 25, 7, 52, 37, 383, DateTimeKind.Local).AddTicks(6453), 17, "", "http://ines.name", "culpa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 6, 25, 16, 20, 47, 920, DateTimeKind.Local).AddTicks(5225), new DateTime(2020, 6, 25, 3, 20, 44, 178, DateTimeKind.Local).AddTicks(4712), new DateTime(2020, 6, 25, 10, 50, 36, 34, DateTimeKind.Local).AddTicks(1713), 100, "", "http://enzo.fr", "nihil" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 6, 25, 3, 11, 1, 819, DateTimeKind.Local).AddTicks(9749), new DateTime(2020, 6, 25, 18, 59, 1, 766, DateTimeKind.Local).AddTicks(6021), new DateTime(2020, 6, 25, 0, 50, 14, 734, DateTimeKind.Local).AddTicks(3093), 16, "", "http://louis.com", "vel" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 6, 25, 18, 11, 52, 865, DateTimeKind.Local).AddTicks(693), new DateTime(2020, 6, 25, 19, 47, 47, 87, DateTimeKind.Local).AddTicks(5328), new DateTime(2020, 6, 24, 23, 43, 23, 122, DateTimeKind.Local).AddTicks(9555), 14, "", "http://enzo.org", "numquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 6, 25, 22, 5, 8, 567, DateTimeKind.Local).AddTicks(2739), new DateTime(2020, 6, 25, 11, 51, 41, 280, DateTimeKind.Local).AddTicks(4005), new DateTime(2020, 6, 25, 11, 37, 18, 100, DateTimeKind.Local).AddTicks(2909), 13, "", "http://valentin.name", "eveniet" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 6, 25, 9, 44, 33, 858, DateTimeKind.Local).AddTicks(6447), new DateTime(2020, 6, 25, 2, 26, 37, 678, DateTimeKind.Local).AddTicks(9680), new DateTime(2020, 6, 24, 22, 26, 20, 947, DateTimeKind.Local).AddTicks(3822), 24, "", "http://thomas.net", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 6, 25, 17, 8, 37, 435, DateTimeKind.Local).AddTicks(7859), new DateTime(2020, 6, 25, 4, 54, 24, 179, DateTimeKind.Local).AddTicks(8432), new DateTime(2020, 6, 25, 19, 29, 32, 580, DateTimeKind.Local).AddTicks(4754), 9, "", "http://sacha.net", "culpa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 6, 25, 0, 34, 48, 14, DateTimeKind.Local).AddTicks(7917), new DateTime(2020, 6, 25, 20, 25, 49, 526, DateTimeKind.Local).AddTicks(681), new DateTime(2020, 6, 25, 0, 36, 24, 745, DateTimeKind.Local).AddTicks(4694), 8, "", "https://adam.eu", "placeat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 6, 25, 5, 16, 39, 646, DateTimeKind.Local).AddTicks(330), new DateTime(2020, 6, 24, 22, 48, 10, 520, DateTimeKind.Local).AddTicks(9139), new DateTime(2020, 6, 25, 8, 16, 11, 110, DateTimeKind.Local).AddTicks(4469), 7, "", "http://carla.com", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 6, 25, 0, 4, 41, 163, DateTimeKind.Local).AddTicks(611), new DateTime(2020, 6, 25, 15, 29, 5, 932, DateTimeKind.Local).AddTicks(889), new DateTime(2020, 6, 25, 16, 22, 25, 327, DateTimeKind.Local).AddTicks(9742), 6, "", "https://marie.org", "quos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 6, 25, 20, 18, 42, 438, DateTimeKind.Local).AddTicks(3344), new DateTime(2020, 6, 25, 0, 24, 31, 1, DateTimeKind.Local).AddTicks(5154), new DateTime(2020, 6, 25, 3, 27, 27, 488, DateTimeKind.Local).AddTicks(6749), 4, "", "http://axel.net", "sequi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 6, 25, 10, 44, 15, 370, DateTimeKind.Local).AddTicks(68), new DateTime(2020, 6, 25, 16, 52, 27, 801, DateTimeKind.Local).AddTicks(8672), new DateTime(2020, 6, 25, 5, 17, 6, 797, DateTimeKind.Local).AddTicks(4874), 3, "", "https://axel.com", "ab" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 6, 25, 2, 33, 1, 582, DateTimeKind.Local).AddTicks(1771), new DateTime(2020, 6, 25, 1, 13, 30, 886, DateTimeKind.Local).AddTicks(7435), new DateTime(2020, 6, 25, 5, 33, 43, 410, DateTimeKind.Local).AddTicks(9863), 3, "", "https://chloé.fr", "quibusdam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 6, 25, 18, 13, 20, 626, DateTimeKind.Local).AddTicks(4780), new DateTime(2020, 6, 25, 10, 13, 59, 252, DateTimeKind.Local).AddTicks(7160), new DateTime(2020, 6, 25, 6, 3, 15, 566, DateTimeKind.Local).AddTicks(2125), 2, "", "https://lucie.name", "magnam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 6, 25, 4, 10, 35, 2, DateTimeKind.Local).AddTicks(4453), new DateTime(2020, 6, 25, 0, 33, 24, 57, DateTimeKind.Local).AddTicks(9122), new DateTime(2020, 6, 24, 23, 55, 51, 695, DateTimeKind.Local).AddTicks(6770), 1, "", "http://noah.net", "vel" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 6, 25, 16, 47, 20, 683, DateTimeKind.Local).AddTicks(4769), new DateTime(2020, 6, 25, 12, 38, 57, 43, DateTimeKind.Local).AddTicks(8501), new DateTime(2020, 6, 25, 14, 45, 3, 490, DateTimeKind.Local).AddTicks(1601), 8, "", "http://clara.name", "hic" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 6, 25, 18, 29, 18, 18, DateTimeKind.Local).AddTicks(6284), new DateTime(2020, 6, 25, 7, 55, 17, 18, DateTimeKind.Local).AddTicks(4703), new DateTime(2020, 6, 25, 9, 17, 42, 763, DateTimeKind.Local).AddTicks(5643), 26, "", "http://nathan.net", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 6, 25, 13, 17, 45, 724, DateTimeKind.Local).AddTicks(6312), new DateTime(2020, 6, 25, 4, 24, 57, 75, DateTimeKind.Local).AddTicks(3653), new DateTime(2020, 6, 25, 5, 54, 49, 229, DateTimeKind.Local).AddTicks(9875), 16, "", "https://océane.eu", "doloremque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 6, 25, 17, 39, 43, 339, DateTimeKind.Local).AddTicks(744), new DateTime(2020, 6, 24, 23, 26, 52, 634, DateTimeKind.Local).AddTicks(7559), new DateTime(2020, 6, 25, 8, 39, 58, 761, DateTimeKind.Local).AddTicks(3067), 27, "", "http://sacha.eu", "voluptas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 6, 25, 6, 10, 22, 775, DateTimeKind.Local).AddTicks(8630), new DateTime(2020, 6, 25, 14, 11, 20, 595, DateTimeKind.Local).AddTicks(9753), new DateTime(2020, 6, 25, 10, 9, 11, 340, DateTimeKind.Local).AddTicks(2765), 38, "", "http://ethan.net", "autem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 6, 25, 7, 32, 33, 104, DateTimeKind.Local).AddTicks(7316), new DateTime(2020, 6, 25, 1, 20, 10, 741, DateTimeKind.Local).AddTicks(4181), new DateTime(2020, 6, 25, 14, 41, 36, 910, DateTimeKind.Local).AddTicks(9552), 38, "", "https://nathan.com", "libero" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 6, 25, 13, 18, 39, 411, DateTimeKind.Local).AddTicks(1987), new DateTime(2020, 6, 25, 13, 43, 15, 537, DateTimeKind.Local).AddTicks(4925), new DateTime(2020, 6, 25, 11, 33, 10, 839, DateTimeKind.Local).AddTicks(6093), 27, "", "http://carla.com", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 6, 25, 15, 51, 45, 166, DateTimeKind.Local).AddTicks(4796), new DateTime(2020, 6, 25, 5, 0, 9, 35, DateTimeKind.Local).AddTicks(5322), new DateTime(2020, 6, 24, 23, 56, 37, 465, DateTimeKind.Local).AddTicks(8277), 37, "", "https://justine.net", "sint" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 6, 24, 23, 15, 28, 578, DateTimeKind.Local).AddTicks(7198), new DateTime(2020, 6, 25, 19, 31, 16, 104, DateTimeKind.Local).AddTicks(3065), new DateTime(2020, 6, 25, 7, 18, 51, 684, DateTimeKind.Local).AddTicks(1039), 37, "", "http://rayan.fr", "itaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 6, 25, 2, 50, 58, 394, DateTimeKind.Local).AddTicks(8358), new DateTime(2020, 6, 25, 18, 51, 25, 917, DateTimeKind.Local).AddTicks(8550), new DateTime(2020, 6, 25, 20, 25, 9, 777, DateTimeKind.Local).AddTicks(746), 36, "", "https://mathis.info", "ab" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 6, 24, 22, 34, 4, 809, DateTimeKind.Local).AddTicks(6792), new DateTime(2020, 6, 25, 18, 0, 8, 589, DateTimeKind.Local).AddTicks(264), new DateTime(2020, 6, 25, 18, 37, 38, 665, DateTimeKind.Local).AddTicks(8599), 36, "", "https://ines.org", "voluptatum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 6, 25, 15, 24, 1, 277, DateTimeKind.Local).AddTicks(2074), new DateTime(2020, 6, 25, 3, 53, 58, 526, DateTimeKind.Local).AddTicks(9054), new DateTime(2020, 6, 25, 21, 19, 49, 307, DateTimeKind.Local).AddTicks(304), 35, "", "http://alexandre.net", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 6, 25, 20, 42, 57, 623, DateTimeKind.Local).AddTicks(7523), new DateTime(2020, 6, 25, 15, 15, 55, 144, DateTimeKind.Local).AddTicks(8223), new DateTime(2020, 6, 25, 12, 40, 32, 136, DateTimeKind.Local).AddTicks(4055), 35, "", "http://noah.com", "sequi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 6, 25, 5, 27, 37, 31, DateTimeKind.Local).AddTicks(5374), new DateTime(2020, 6, 25, 21, 10, 50, 850, DateTimeKind.Local).AddTicks(2455), new DateTime(2020, 6, 25, 2, 56, 12, 937, DateTimeKind.Local).AddTicks(7776), 37, "", "https://léo.info", "consequuntur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 6, 25, 20, 42, 30, 244, DateTimeKind.Local).AddTicks(6019), new DateTime(2020, 6, 25, 16, 7, 57, 624, DateTimeKind.Local).AddTicks(5890), new DateTime(2020, 6, 25, 4, 58, 23, 928, DateTimeKind.Local).AddTicks(8160), 34, "", "http://pauline.org", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 6, 25, 15, 17, 15, 517, DateTimeKind.Local).AddTicks(900), new DateTime(2020, 6, 25, 21, 27, 2, 301, DateTimeKind.Local).AddTicks(3253), new DateTime(2020, 6, 25, 13, 37, 31, 747, DateTimeKind.Local).AddTicks(505), 33, "", "http://mattéo.eu", "culpa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 6, 25, 4, 30, 5, 172, DateTimeKind.Local).AddTicks(1893), new DateTime(2020, 6, 25, 2, 47, 48, 488, DateTimeKind.Local).AddTicks(7962), new DateTime(2020, 6, 24, 22, 12, 51, 959, DateTimeKind.Local).AddTicks(1966), 32, "", "https://benjamin.info", "eligendi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 6, 25, 20, 5, 5, 726, DateTimeKind.Local).AddTicks(6431), new DateTime(2020, 6, 25, 7, 50, 13, 325, DateTimeKind.Local).AddTicks(3483), new DateTime(2020, 6, 24, 23, 4, 17, 255, DateTimeKind.Local).AddTicks(9005), 31, "", "https://louise.org", "dicta" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 6, 24, 23, 41, 34, 652, DateTimeKind.Local).AddTicks(7550), new DateTime(2020, 6, 25, 9, 21, 27, 215, DateTimeKind.Local).AddTicks(3728), new DateTime(2020, 6, 25, 20, 22, 7, 231, DateTimeKind.Local).AddTicks(9254), 31, "", "https://alexandre.net", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 6, 25, 10, 58, 59, 598, DateTimeKind.Local).AddTicks(8328), new DateTime(2020, 6, 25, 18, 48, 17, 355, DateTimeKind.Local).AddTicks(3913), new DateTime(2020, 6, 25, 1, 34, 29, 934, DateTimeKind.Local).AddTicks(6515), 31, "", "https://noa.eu", "deleniti" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 6, 25, 14, 29, 20, 371, DateTimeKind.Local).AddTicks(9855), new DateTime(2020, 6, 25, 17, 10, 30, 224, DateTimeKind.Local).AddTicks(9531), new DateTime(2020, 6, 25, 1, 12, 26, 714, DateTimeKind.Local).AddTicks(3912), 31, "", "http://paul.org", "temporibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 6, 25, 5, 9, 41, 70, DateTimeKind.Local).AddTicks(6285), new DateTime(2020, 6, 25, 20, 28, 42, 213, DateTimeKind.Local).AddTicks(7713), new DateTime(2020, 6, 25, 3, 35, 19, 837, DateTimeKind.Local).AddTicks(9666), 28, "", "https://romane.name", "impedit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 6, 25, 9, 25, 26, 7, DateTimeKind.Local).AddTicks(4341), new DateTime(2020, 6, 25, 7, 24, 41, 74, DateTimeKind.Local).AddTicks(2480), new DateTime(2020, 6, 25, 9, 27, 27, 212, DateTimeKind.Local).AddTicks(6924), 28, "", "https://manon.eu", "vel" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 6, 24, 23, 30, 12, 274, DateTimeKind.Local).AddTicks(4641), new DateTime(2020, 6, 25, 16, 54, 29, 446, DateTimeKind.Local).AddTicks(7686), new DateTime(2020, 6, 25, 10, 16, 17, 582, DateTimeKind.Local).AddTicks(2229), 35, "", "https://célia.net", "quo" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 2, 1, "Gouvernance" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 3, 2, "Droits économiques" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 7, 3, "Promotion des droits catégoriels" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 8, 3, "Protection des droits catégoriels" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 9, 4, "Cadre institutionnel" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 10, 4, "Cadre juridique" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 1, 1, "Démocratie" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 5, 6, "Droits culturels" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 6, 7, "Droits environnementaux" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 4, 5, "Droits sociaux" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Actif", "Adresse", "Email", "Fix", "IdOrganisme", "IdProfil", "Nom", "Password", "Prenom", "Tel", "Username" },
                values: new object[] { 1, true, "Temara", "mourabit@angular.io", "05 ## ## ## ##", 1, 1, "mourabit", "123", "mohamed", "06 ## ## ## ##", "mourabit" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Actif", "Adresse", "Email", "Fix", "IdOrganisme", "IdProfil", "Nom", "Password", "Prenom", "Tel", "Username" },
                values: new object[] { 4, true, "Temara", "soufiane@angular.io", "05 ## ## ## ##", 4, 3, "soufiane", "123", "soufiane", "06 ## ## ## ##", "soufiane" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Actif", "Adresse", "Email", "Fix", "IdOrganisme", "IdProfil", "Nom", "Password", "Prenom", "Tel", "Username" },
                values: new object[] { 3, true, "Temara", "ahmed@angular.io", "05 ## ## ## ##", 4, 4, "ahmed", "123", "ahmed", "06 ## ## ## ##", "ahmed" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Actif", "Adresse", "Email", "Fix", "IdOrganisme", "IdProfil", "Nom", "Password", "Prenom", "Tel", "Username" },
                values: new object[] { 2, true, "Temara", "mehdi@angular.io", "05 ## ## ## ##", 2, 2, "mehdi", "123", "mehdi", "06 ## ## ## ##", "mehdi" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 4, "1.1.2.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 96, 3, 5, null, 3, 1, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 60, "1.7.3.9", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 1, null, 5, 3, 4, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 48, "6.7.9.3", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 25, 5, null, 2, 1, 4, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 35, "6.6.9.6", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 4, null, null, 3, 4, 1, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 28, "2.5.2.1", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 7, 10, null, 2, 4, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 22, "5.2.1.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 6, 5, null, 2, 4, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 10, "9.6.1.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 4, 9, null, 4, 4, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 7, "0.2.6.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 23, 5, 10, null, 2, 4, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 58, "0.5.5.3", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 5, 1, 1, null, 3, 10, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 47, "1.4.3.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 79, 7, null, null, 2, 10, 2, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 31, "3.0.9.5", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 5, 8, null, 2, 10, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 30, "5.3.5.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 2, null, 2, 4, 10, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 83, "4.0.6.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 85, 7, null, null, 3, 9, 8, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 70, "9.9.5.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 3, 7, null, 3, 9, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 64, "3.0.8.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 53, 7, 3, null, 2, 9, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 55, "9.3.3.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 4, 10, null, 3, 9, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 51, "1.6.7.8", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 4, null, 2, 4, 9, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 34, "9.9.0.6", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 53, 2, 2, null, 4, 9, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 25, "3.4.2.0", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 3, 1, null, 2, 9, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 24, "4.4.9.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 12, 5, null, 2, 2, 9, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 86, "5.1.6.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 34, 1, null, null, 3, 8, 8, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 74, "6.1.3.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 6, null, null, 4, 8, 6, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 66, "4.7.1.7", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 26, 4, null, 5, 1, 4, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 71, "8.4.4.6", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 86, 4, null, null, 2, 4, 6, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 72, "6.1.4.1", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 4, null, 6, 3, 4, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 84, "8.6.8.1", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 25, 1, null, 5, 3, 4, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 80, "1.7.6.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 9, 6, null, null, 4, 6, 10, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 69, "6.7.8.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 6, null, 2, 2, 6, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 54, "4.5.0.4", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 5, null, 4, 3, 6, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 52, "4.9.6.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 83, 3, 5, null, 3, 6, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 42, "6.2.9.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 100, 2, null, 1, 4, 6, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 41, "8.3.0.1", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 3, null, null, 1, 6, 6, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 32, "1.7.4.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 58, 3, null, null, 2, 6, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 8, "4.8.3.0", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 5, null, null, 1, 6, 10, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 6, "0.3.3.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 57, 2, null, 2, 4, 6, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 99, "4.2.6.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 77, 4, null, 2, 3, 5, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 59, "9.1.9.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 8, 1, null, null, 3, 8, 10, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 96, "1.3.8.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 7, null, 1, 4, 5, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 75, "8.9.3.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 1, null, 5, 3, 5, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 63, "6.8.4.3", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 71, 7, null, 6, 1, 5, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 56, "6.7.0.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 82, 1, null, null, 2, 5, 4, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 50, "6.4.0.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 74, 2, null, null, 3, 5, 1, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 27, "3.6.9.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 1, null, 4, 1, 5, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 26, "2.7.4.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 79, 2, null, null, 4, 5, 8, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 12, "9.8.0.0", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 1, null, 3, 2, 5, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 90, "4.8.2.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 1, null, 2, 3, 4, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 89, "0.0.2.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 4, null, null, 1, 4, 6, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 87, "3.5.5.1", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 34, 6, null, 1, 3, 4, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 81, "8.5.0.3", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 1, null, 1, 4, 5, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 53, "4.7.0.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 23, 7, null, null, 2, 8, 8, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 94, "3.4.6.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 7, 9, null, 3, 6, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 29, "6.0.6.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 4, null, null, 2, 8, 3, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 82, "4.2.0.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 52, 3, 2, null, 1, 2, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 79, "7.4.8.1", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 83, 6, 3, null, 3, 2, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 77, "6.0.4.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 6, null, null, 3, 2, 10, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 68, "2.9.8.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 48, 1, null, null, 4, 2, 7, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 67, "4.6.5.5", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 92, 2, 3, null, 4, 2, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 61, "8.7.8.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 34, 3, 9, null, 2, 2, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 57, "1.4.8.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 52, 3, null, 6, 3, 2, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 39, "3.0.5.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 1, null, 6, 4, 2, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 36, "2.1.3.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 40, 7, null, 3, 1, 2, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 20, "6.7.0.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 4, null, null, 3, 2, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 5, "0.3.6.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 17, 4, null, null, 3, 2, 8, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 1, "1.5.6.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 85, 3, 6, null, 4, 2, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 95, "2.2.1.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 3, null, null, 3, 1, 3, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 76, "8.6.4.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 96, 7, 9, null, 1, 1, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 45, "5.7.6.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 5, null, 5, 2, 1, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 23, "2.7.3.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 3, null, null, 1, 1, 10, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 19, "4.7.3.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 3, 9, null, 2, 1, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 18, "4.8.6.1", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 4, null, 1, 4, 1, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 17, "5.0.4.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 57, 5, null, null, 3, 1, 3, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 9, "4.4.4.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 31, 4, null, 3, 4, 1, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 49, "8.0.0.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 90, 1, 9, null, 2, 8, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 21, "0.8.2.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 72, 4, null, 6, 2, 3, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 33, "0.3.9.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 2, null, 3, 3, 3, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 37, "4.7.5.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 5, 7, null, 2, 2, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 65, "0.8.1.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 6, null, null, 4, 3, 8, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 38, "2.5.3.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 58, 2, null, null, 4, 3, 10, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 100, "5.3.7.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 59, 6, 2, null, 3, 7, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 93, "4.2.1.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 32, 7, null, 2, 4, 7, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 91, "0.7.5.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 6, 10, null, 3, 7, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 88, "2.2.4.7", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 6, 2, null, 2, 7, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 85, "3.6.1.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 7, 5, 8, null, 2, 7, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 78, "4.1.9.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 82, 7, null, 2, 2, 7, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 62, "8.5.6.5", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 70, 7, null, null, 3, 7, 8, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 46, "1.9.4.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 71, 5, 2, null, 4, 7, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 44, "6.0.3.0", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 5, null, null, 1, 7, 1, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 43, "4.3.0.9", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 7, 8, null, 1, 7, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 73, "1.5.7.1", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 6, 4, null, 2, 7, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 11, "2.0.1.3", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 4, null, null, 1, 8, 3, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 40, "8.7.4.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 91, 1, 2, null, 3, 7, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 97, "5.2.6.6", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 4, 3, null, 4, 3, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 98, "9.1.2.7", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 36, 4, null, null, 1, 3, 4, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 2, "2.0.3.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 8, 2, null, null, 2, 7, 9, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 3, "8.6.6.6", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 1, null, 4, 1, 7, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 92, "2.0.3.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 59, 3, null, null, 3, 3, 1, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 14, "4.5.6.2", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 51, 3, null, null, 2, 7, 2, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 15, "5.9.9.0", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 83, 6, null, 2, 1, 7, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 16, "4.3.3.1", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 7, 2, 4, null, 3, 7, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 13, "5.0.4.0", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 13, 5, 3, null, 2, 7, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "doloribus", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 59, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "id", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 27, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "quam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 27, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "animi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "at", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 98, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 84, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "sint", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 54, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 4, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "ut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 59, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "ea", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 59, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "fugit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 76, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "distinctio", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 11, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "est", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 75, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "corporis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 71, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "vitae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 94, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "architecto", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 7, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "quisquam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 7, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "illo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 76, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "iste", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 76, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "quo", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 76, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "sunt", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 31, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "esse", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 11, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "reiciendis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 31, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "fuga", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 79, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "eos", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 57, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "iste", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 66, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "ipsa", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 64, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "aut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 53, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "libero", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 29, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 2, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "voluptatem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 2, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "rerum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 8, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "possimus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 8, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "impedit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 8, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "quasi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 96, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "recusandae", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 31, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "ut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 96, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "cupiditate", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 46, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "ut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 36, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "ipsam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 5, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 5, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "sed", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 5, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "exercitationem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 67, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "maxime", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 67, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "officiis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 63, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "aliquid", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 91, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "itaque", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 91, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "nobis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 46, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "perferendis", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 26, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "alias", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 97, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "voluptas", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 20, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "natus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 77, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "optio", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 77, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "eum", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 23, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "deserunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 19, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "aut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 34, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 34, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "praesentium", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 34, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "consequatur", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 93, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "delectus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 93, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "dolorem", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 38, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "debitis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 38, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "a", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 17, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "repudiandae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 90, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "totam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 90, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "eius", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 90, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "accusantium", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 40, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "iure", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 1, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "vel", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 1, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "ex", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 1, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "nihil", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 47, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 79, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "in", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 95, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "libero", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 74, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "quasi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 92, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "debitis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 97, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "eligendi", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 13, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "voluptas", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 85, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "eveniet", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 43, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "suscipit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 58, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "laudantium", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 58, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "omnis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 51, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "eveniet", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 80, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "fugiat", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 89, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "voluptates", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 70, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "quos", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 86, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 26, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "consequatur", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 86, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "voluptas", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "consequatur", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "nostrum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 3, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 69, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "earum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 52, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "consectetur", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 22, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "sint", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 22, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "aliquam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 22, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "debitis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 39, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "blanditiis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 97, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "nemo", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 62, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "sint", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 79, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/metrics", 1, 42 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/rustic/deposit/streamline", 2, 51 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/holistic/real-time", 3, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/missouri", 4, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/loop/designer/dale", 1, 53 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/hacking", 4, 53 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/movies", 5, 53 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/systematic/cotton/attitude", 1, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/bedfordshire", 2, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/adp/deliverables/practical-granite-soap", 1, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/assistant", 1, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/invoice", 4, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/street/texas/e-tailers", 1, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/concrete/impactful", 2, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/personal-loan-account/gorgeous-plastic-gloves", 1, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/burg/rial-omani", 2, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/intermediate/neck/backing-up", 4, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/navigate", 2, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/electronics--movies/handmade", 5, 15 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/generic-cotton-shoes", 5, 52 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/senior/global", 1, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/optimizing/engage/xml", 3, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/holistic/wooden", 5, 51 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/orchestration/french-southern-territories/deposit", 6, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/planner/withdrawal", 6, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/union/handcrafted-steel-keyboard", 7, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/invoice/credit-card-account/home-loan-account", 4, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/web/back-end/wooden", 6, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/universal/methodical/devolved", 3, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/assistant/credit-card-account", 7, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/scalable/attitude/adp", 4, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/back-up/tasty-granite-bike/integrated", 5, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/group", 4, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/ram", 5, 79 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/credit-card-account/national", 4, 79 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/fantastic", 2, 79 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/tcp/bluetooth", 5, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/dynamic", 6, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/sleek-wooden-table/light/garden-clothing--computers", 4, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/sky-blue/models", 6, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/seamless/synthesizing", 2, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/senior", 6, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/synergize/tan", 5, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/bedfordshire", 7, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/connect/investment-account", 1, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/barbados", 5, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/fantastic-concrete-car/cutting-edge/portals", 6, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/netherlands-antilles/mobile/pixel", 7, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/realigned", 3, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/multi-byte", 3, 83 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/branch", 4, 83 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/azure/upward-trending/pci", 7, 6 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/factors/invoice", 1, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/soft", 7, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/avon/licensed/sdd", 4, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/productize/flats/sdd", 4, 63 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/salmon/macao/connect", 4, 96 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/unbranded-cotton-shirt", 2, 96 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/ftp", 7, 40 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/transmitting/dominica/metal", 5, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/orchestrator/invoice/bus", 7, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/us-dollar", 1, 34 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/incremental", 1, 34 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/matrix/creek", 2, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/croatian-kuna/needs-based", 2, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/png", 5, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/wooden/platforms/clear-thinking", 1, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/overriding/systems", 4, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/pennsylvania/sleek/adp", 1, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/digital/principal", 5, 61 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/cross-media/withdrawal/withdrawal", 5, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/reboot", 3, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/back-end/tasty-rubber-shirt/plains", 1, 6 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/connecticut/intuitive", 1, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/driver/sao-tome-and-principe", 5, 68 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/curve/small-rubber-cheese", 4, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/systems/out-of-the-box", 1, 84 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/developer", 6, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/secured-line/ftp/expressway", 4, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/operative", 7, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/corner", 3, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/mesh/avon/maximized", 4, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/outdoors/berkshire", 4, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/purple/persistent", 3, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/virtual", 7, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/auto-loan-account/borders/trail", 2, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/face-to-face/emulation/technician", 4, 27 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/global/productize", 7, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/handmade-steel-shoes/ford", 5, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/interactive/bypassing/ergonomic-steel-soap", 1, 13 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/plastic/deliver", 7, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/new-israeli-sheqel/solid-state", 1, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/turnpike/parsing", 7, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/definition/michigan/bus", 4, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/capacitor/incredible-cotton-chair", 6, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/empower/italy/intermediate", 6, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/capacitor/program/tools", 3, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/auxiliary/mountains/program", 1, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/tcp/knowledge-user/circuit", 6, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/games--beauty/compress/paradigm", 4, 35 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 1, new DateTime(2020, 6, 17, 20, 57, 31, 403, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 2, new DateTime(2019, 10, 31, 20, 25, 33, 863, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 2, new DateTime(2020, 1, 11, 16, 10, 50, 499, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 1, new DateTime(2019, 7, 18, 14, 42, 8, 803, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 5, new DateTime(2019, 12, 14, 16, 33, 28, 210, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 5, new DateTime(2019, 9, 10, 15, 42, 41, 150, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 6, new DateTime(2019, 9, 27, 3, 34, 27, 331, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 1, new DateTime(2020, 2, 1, 3, 42, 58, 158, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 4, new DateTime(2020, 5, 31, 11, 44, 56, 301, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 4, new DateTime(2019, 10, 3, 9, 28, 0, 918, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 4, new DateTime(2020, 6, 1, 23, 49, 27, 990, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 3, new DateTime(2020, 2, 5, 5, 44, 25, 315, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 4, new DateTime(2019, 11, 21, 7, 52, 49, 357, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 5, new DateTime(2020, 1, 5, 4, 2, 17, 966, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 6, new DateTime(2019, 9, 18, 0, 20, 0, 850, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 5, new DateTime(2020, 5, 20, 18, 26, 13, 422, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 3, new DateTime(2020, 6, 15, 3, 20, 1, 901, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 1, new DateTime(2019, 10, 27, 10, 57, 14, 623, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 3, new DateTime(2019, 12, 2, 3, 10, 3, 391, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 3, new DateTime(2019, 7, 20, 18, 16, 31, 475, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 4, new DateTime(2019, 11, 28, 2, 38, 42, 446, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 2, new DateTime(2019, 12, 31, 10, 39, 50, 703, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 2, new DateTime(2020, 1, 10, 12, 22, 26, 912, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 3, new DateTime(2020, 5, 20, 14, 49, 1, 434, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 2, new DateTime(2019, 11, 19, 10, 10, 35, 380, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 5, new DateTime(2020, 1, 24, 4, 12, 50, 470, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 4, new DateTime(2019, 8, 9, 0, 5, 12, 123, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 3, new DateTime(2019, 9, 14, 5, 28, 8, 523, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 3, new DateTime(2019, 11, 18, 11, 54, 41, 947, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 6, new DateTime(2019, 9, 18, 18, 6, 26, 300, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 2, new DateTime(2019, 8, 2, 2, 0, 21, 800, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 6, new DateTime(2019, 11, 1, 20, 25, 35, 827, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 1, new DateTime(2019, 8, 20, 9, 0, 11, 375, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 6, new DateTime(2020, 6, 10, 17, 42, 45, 496, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 4, new DateTime(2020, 3, 4, 14, 14, 47, 629, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 4, new DateTime(2020, 1, 8, 17, 22, 40, 837, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 3, new DateTime(2019, 7, 10, 21, 13, 23, 467, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 1, new DateTime(2019, 9, 2, 7, 37, 54, 67, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 6, new DateTime(2020, 1, 3, 7, 14, 18, 625, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 5, new DateTime(2020, 5, 8, 12, 16, 7, 303, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 4, new DateTime(2020, 5, 15, 17, 47, 59, 971, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 2, new DateTime(2020, 2, 9, 2, 4, 1, 49, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 3, new DateTime(2019, 9, 21, 11, 50, 54, 797, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 1, new DateTime(2019, 9, 26, 20, 56, 58, 941, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 6, new DateTime(2020, 6, 9, 11, 8, 35, 201, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 2, new DateTime(2020, 5, 13, 13, 8, 3, 664, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 1, new DateTime(2020, 5, 8, 23, 32, 30, 909, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 5, new DateTime(2020, 4, 28, 21, 16, 16, 285, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 3, new DateTime(2020, 3, 28, 22, 48, 25, 209, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 4, new DateTime(2019, 12, 8, 4, 24, 56, 972, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 6, new DateTime(2019, 12, 14, 5, 20, 47, 986, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 4, new DateTime(2019, 11, 16, 14, 38, 55, 729, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 5, new DateTime(2020, 1, 14, 10, 5, 38, 122, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 3, new DateTime(2020, 6, 23, 15, 58, 30, 536, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 4, new DateTime(2019, 8, 27, 22, 58, 43, 201, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 4, new DateTime(2020, 5, 13, 19, 2, 37, 374, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 4, new DateTime(2020, 4, 19, 16, 43, 34, 472, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 1, new DateTime(2019, 7, 26, 10, 53, 23, 512, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 2, new DateTime(2019, 7, 13, 11, 0, 10, 558, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 6, new DateTime(2019, 11, 18, 19, 36, 58, 339, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 3, new DateTime(2019, 8, 31, 19, 37, 5, 392, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 1, new DateTime(2020, 5, 20, 18, 35, 26, 329, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 6, new DateTime(2019, 6, 25, 20, 29, 9, 888, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 2, new DateTime(2019, 7, 25, 20, 29, 20, 582, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 6, new DateTime(2020, 5, 21, 11, 23, 34, 882, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 5, new DateTime(2020, 6, 2, 12, 56, 30, 319, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 2, new DateTime(2019, 11, 1, 12, 39, 54, 930, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 5, new DateTime(2020, 4, 27, 6, 20, 29, 659, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 6, new DateTime(2019, 10, 15, 18, 44, 54, 293, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 6, new DateTime(2020, 1, 13, 10, 39, 3, 765, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 3, new DateTime(2020, 5, 10, 23, 51, 42, 720, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 2, new DateTime(2019, 10, 6, 3, 15, 34, 291, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 1, new DateTime(2020, 4, 18, 4, 16, 51, 332, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 2, new DateTime(2019, 8, 19, 18, 2, 45, 181, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 6, new DateTime(2020, 3, 15, 8, 19, 27, 30, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 3, new DateTime(2019, 12, 1, 21, 15, 24, 380, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 1, new DateTime(2019, 8, 15, 12, 50, 7, 597, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 5, new DateTime(2019, 8, 16, 0, 23, 15, 132, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 4, new DateTime(2019, 9, 19, 10, 23, 40, 743, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 3, new DateTime(2020, 6, 12, 22, 49, 53, 929, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 4, new DateTime(2020, 4, 25, 3, 9, 22, 771, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 5, new DateTime(2019, 12, 22, 23, 40, 4, 123, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 2, new DateTime(2019, 10, 17, 8, 45, 53, 533, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 3, new DateTime(2019, 8, 25, 1, 2, 7, 890, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 2, new DateTime(2020, 4, 24, 15, 57, 26, 327, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 3, new DateTime(2020, 3, 31, 16, 36, 26, 340, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 3, new DateTime(2020, 6, 9, 15, 11, 37, 192, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 4, new DateTime(2020, 6, 17, 10, 55, 28, 717, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 5, new DateTime(2020, 1, 1, 8, 13, 35, 326, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 1, new DateTime(2020, 6, 8, 0, 40, 49, 590, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 1, new DateTime(2019, 12, 12, 23, 26, 56, 607, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 4, new DateTime(2019, 10, 18, 21, 22, 43, 385, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 2, new DateTime(2019, 9, 11, 5, 15, 5, 974, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 6, new DateTime(2020, 2, 20, 1, 57, 20, 193, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 6, new DateTime(2020, 1, 21, 4, 25, 21, 859, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 4, new DateTime(2019, 6, 25, 11, 4, 16, 160, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 6, new DateTime(2019, 7, 1, 3, 4, 0, 211, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 5, new DateTime(2019, 11, 18, 2, 21, 37, 763, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 4, new DateTime(2020, 2, 17, 17, 2, 33, 385, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 1, new DateTime(2019, 11, 15, 5, 30, 58, 338, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.CreateIndex(
                name: "IX_FicheSyntheses_IdOrganisme",
                table: "FicheSyntheses",
                column: "IdOrganisme");

            migrationBuilder.CreateIndex(
                name: "IX_FicheSyntheses_IdSynthese",
                table: "FicheSyntheses",
                column: "IdSynthese");

            migrationBuilder.CreateIndex(
                name: "IX_Rapports_IdTraite",
                table: "Rapports",
                column: "IdTraite");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_IdAxe",
                table: "Recommendations",
                column: "IdAxe");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_IdCycle",
                table: "Recommendations",
                column: "IdCycle");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_IdOrgane",
                table: "Recommendations",
                column: "IdOrgane");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_IdPays",
                table: "Recommendations",
                column: "IdPays");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_IdSousAxe",
                table: "Recommendations",
                column: "IdSousAxe");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_IdVisite",
                table: "Recommendations",
                column: "IdVisite");

            migrationBuilder.CreateIndex(
                name: "IX_RecomOrgs_IdOrganisme",
                table: "RecomOrgs",
                column: "IdOrganisme");

            migrationBuilder.CreateIndex(
                name: "IX_SousAxes_IdAxe",
                table: "SousAxes",
                column: "IdAxe");

            migrationBuilder.CreateIndex(
                name: "IX_SyntheseRecommandations_IdSynthese",
                table: "SyntheseRecommandations",
                column: "IdSynthese");

            migrationBuilder.CreateIndex(
                name: "IX_Syntheses_IdRapport",
                table: "Syntheses",
                column: "IdRapport");

            migrationBuilder.CreateIndex(
                name: "IX_Syntheses_IdUser",
                table: "Syntheses",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdOrganisme",
                table: "Users",
                column: "IdOrganisme");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdProfil",
                table: "Users",
                column: "IdProfil");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evenements");

            migrationBuilder.DropTable(
                name: "Examens");

            migrationBuilder.DropTable(
                name: "FicheSyntheses");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ParticipationSessions");

            migrationBuilder.DropTable(
                name: "Questionnaires");

            migrationBuilder.DropTable(
                name: "RecomOrgs");

            migrationBuilder.DropTable(
                name: "SituationReserves");

            migrationBuilder.DropTable(
                name: "SyntheseRecommandations");

            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "Syntheses");

            migrationBuilder.DropTable(
                name: "Cycles");

            migrationBuilder.DropTable(
                name: "Organes");

            migrationBuilder.DropTable(
                name: "Pays");

            migrationBuilder.DropTable(
                name: "SousAxes");

            migrationBuilder.DropTable(
                name: "Visites");

            migrationBuilder.DropTable(
                name: "Rapports");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Axes");

            migrationBuilder.DropTable(
                name: "Traites");

            migrationBuilder.DropTable(
                name: "Organismes");

            migrationBuilder.DropTable(
                name: "Profils");
        }
    }
}
