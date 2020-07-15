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
                    RapportMiParcours = table.Column<string>(nullable: true),
                    MiseOeuvrePiece = table.Column<string>(nullable: true)
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
                    Annee = table.Column<int>(nullable: false),
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
                    Annee = table.Column<int>(nullable: false),
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
                    RapportParallelePiece = table.Column<string>(nullable: true),
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
                    MiseOeuvrePiece = table.Column<string>(nullable: true),
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
                    Complement = table.Column<string>(nullable: true),
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
                values: new object[] { 10, "Categorie 1", new DateTime(2019, 11, 16, 4, 58, 24, 855, DateTimeKind.Local).AddTicks(6701), "Itaque laboriosam velit labore aut architecto. Praesentium voluptas commodi atque molestiae. Sit cumque repudiandae quisquam doloribus repellendus perferendis eos id. Reprehenderit ut deleniti nobis voluptatem. Qui perspiciatis molestiae qui qui repellat quia laboriosam qui. In enim et consequatur magnam ratione. Eum assumenda deserunt eos. Tempore commodi ducimus ullam suscipit accusantium voluptatem saepe in reprehenderit. Est optio illum iste nulla ut voluptatem quos in asperiores. Iure cumque ut animi veritatis dolore sequi. Repudiandae est tempore ut officiis error eos veniam.", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 9, "Categorie 1", new DateTime(2019, 11, 15, 19, 55, 57, 935, DateTimeKind.Local).AddTicks(4700), "Ad et consectetur voluptates odit quia et dolorum. Qui in sunt dolor. Aut delectus quia consequatur sit quia. Sit totam est praesentium sit. Aspernatur quos quod provident. Voluptatem ut voluptate inventore rerum iure voluptatem et. Aut perspiciatis aut quia. Similique natus voluptatum nulla tenetur et nam. Nemo quaerat animi quas qui molestiae sit ut. Rem est eos est. Beatae quae voluptatem recusandae. Facere ut ipsam rem officia consequatur nulla. Et dolorum est temporibus nostrum ab et.", "nulla" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 8, "Categorie 1", new DateTime(2020, 6, 25, 22, 6, 40, 352, DateTimeKind.Local).AddTicks(7211), "Aut iste voluptatibus. Aperiam maiores cupiditate non consequatur repudiandae eveniet ut nam. Officia quae natus omnis architecto. Iusto quod et. Qui eos minima omnis. Incidunt aut dolorum sit. Ducimus a est quos qui neque non incidunt cum. Sit officia natus amet animi. Consequuntur eos ullam quis quidem enim harum possimus. Eveniet nihil maxime. In vel ad.", "quis" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 7, "Categorie 1", new DateTime(2019, 8, 15, 19, 55, 31, 953, DateTimeKind.Local).AddTicks(7237), "Nihil ea sit officia quos. Eligendi quia aut unde sit repudiandae rerum perspiciatis quia. Consequatur et repellendus ut. Non corrupti ipsam mollitia ut. Ut optio consequuntur corporis in voluptas quos odit est recusandae. Eum iste assumenda aspernatur et et in modi quos debitis. Qui qui omnis commodi. Delectus saepe sint sit asperiores deserunt necessitatibus blanditiis excepturi. Et dolorum ratione qui odio atque eius repudiandae dolorem. Et amet qui nobis.", "ratione" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 6, "Categorie 1", new DateTime(2020, 5, 1, 12, 41, 24, 24, DateTimeKind.Local).AddTicks(3897), "Iusto impedit voluptatem est officiis officia officia dolorem quis. Et ratione id illum molestias. Voluptate voluptatibus eos quia dolores assumenda porro et. Voluptas omnis nulla quidem. Veritatis voluptatem dolorem quia. Velit sapiente inventore error est. Architecto laboriosam quam nostrum ut dolor qui deserunt. Quo minus qui suscipit. Nam asperiores beatae molestias unde. Maxime non magni ut deleniti voluptatem qui praesentium nemo. Ut quam dolores iusto quam et exercitationem hic.", "officia" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 4, "Categorie 1", new DateTime(2019, 12, 28, 6, 54, 52, 867, DateTimeKind.Local).AddTicks(7468), "Ut aspernatur nulla nam eaque voluptas. Sapiente ad omnis ut necessitatibus maiores quaerat. Sit temporibus iure recusandae quasi totam architecto amet. Omnis velit aut quo exercitationem cumque architecto quibusdam. Ea qui nulla aut voluptates numquam aut quaerat maiores quasi. Molestiae aut doloremque voluptatem voluptatum laboriosam sed. Aut autem sapiente laudantium voluptates. Rerum quo tempora voluptates. In nihil omnis delectus et aut quo ullam. Ipsum consequuntur consequatur deleniti consequatur harum enim aut dolorem beatae. A dolores est dolorem.", "et" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 3, "Categorie 1", new DateTime(2019, 11, 7, 12, 41, 40, 294, DateTimeKind.Local).AddTicks(1410), "Amet sapiente architecto voluptatem. Quia voluptatem id iure corporis nihil perferendis repudiandae distinctio dolore. Dicta soluta omnis. Tenetur natus ab quo molestias nulla quis minus. Et eum hic quibusdam provident. Et ex voluptas reiciendis qui pariatur sapiente et voluptatem. Aliquam impedit quos dolor. Sed illo quaerat omnis magnam et voluptates commodi rerum quasi. Quam nihil occaecati rem rem eius vel accusamus illum eligendi. Nihil consequatur temporibus asperiores earum qui in aliquam dolores. Hic ut sit omnis eligendi sit minima nesciunt occaecati doloribus.", "sit" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 2, "Categorie 1", new DateTime(2019, 10, 20, 11, 12, 3, 559, DateTimeKind.Local).AddTicks(4608), "Ad id nemo molestiae. Cum officiis totam ad deserunt quisquam doloremque omnis voluptate. Natus voluptates omnis debitis quos. Dolores enim repellendus libero corrupti amet enim et inventore at. Quidem ut non vel nulla voluptates veritatis officiis. Reprehenderit tempora est harum rerum voluptatum error in deleniti. Est natus tempore enim omnis totam cupiditate omnis. Corrupti error ut numquam id. Reprehenderit et deleniti saepe porro repellat optio alias fuga natus. Dolorum voluptatem doloremque perferendis dolorum.", "iusto" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 1, "Categorie 1", new DateTime(2020, 2, 16, 12, 29, 10, 60, DateTimeKind.Local).AddTicks(4734), "Id ut in et ullam minima ipsum hic aperiam. Dicta placeat voluptatem ut architecto consequatur aut nobis vel animi. Quo ut quod in exercitationem in. Quae sed laborum voluptatum ea. Aut iusto eum omnis accusamus vel explicabo. Et id culpa labore possimus. Ab eos in ipsa ad et qui voluptas iste. Aperiam consequatur aut vero et fugiat aliquid est reprehenderit. Et quidem nihil ut vel repellat molestias qui. Quod nesciunt nesciunt sed id. Sit et sunt sed sed. Suscipit debitis unde maxime. Et labore ex libero aliquam aut pariatur eaque unde.", "et" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 5, "Categorie 1", new DateTime(2019, 10, 28, 4, 8, 19, 585, DateTimeKind.Local).AddTicks(6412), "Minus voluptatem autem culpa aliquid quia quos at debitis quo. Eius quidem ipsa quia consequuntur nulla. Atque blanditiis ad debitis repudiandae libero ratione. Impedit beatae non est quam incidunt vel ut. Vero quibusdam unde praesentium nesciunt excepturi dolor. Dolores voluptas eos animi repudiandae quia. Voluptatibus voluptatibus repudiandae sed distinctio at odit nihil. Cum laborum velit et voluptatem quam. Ea id deleniti laudantium. Exercitationem odit quia rerum dolores. Omnis et quis architecto autem et. Maxime iusto ipsam minima labore. Placeat sunt sed dolor unde aspernatur vero et.", "qui" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 5, "", "", "Examen-6", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 6, "", "", "Examen-7", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 4, "", "", "Examen-5", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 1, "", "", "Examen-2", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 2, "", "", "Examen-3", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 3, "", "", "Examen-4", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 73, new DateTime(2019, 10, 26, 22, 17, 39, 787, DateTimeKind.Local).AddTicks(3937), "0,2,6", 73, 2, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2019, 10, 2, 19, 44, 2, 701, DateTimeKind.Local).AddTicks(3517), "1,3,4", 72, 2, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2020, 6, 13, 2, 6, 15, 525, DateTimeKind.Local).AddTicks(1100), "1,2,5", 71, 2, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2020, 1, 9, 15, 0, 38, 140, DateTimeKind.Local).AddTicks(7053), "1,3,6", 70, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2019, 7, 21, 3, 6, 46, 216, DateTimeKind.Local).AddTicks(2561), "1,2,5", 69, 6, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2019, 7, 20, 1, 12, 47, 62, DateTimeKind.Local).AddTicks(3181), "0,2,4", 68, 5, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2020, 3, 2, 6, 47, 9, 587, DateTimeKind.Local).AddTicks(5017), "0,2,4", 67, 2, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2019, 12, 25, 10, 54, 26, 264, DateTimeKind.Local).AddTicks(6251), "1,2,4", 66, 1, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2019, 11, 20, 9, 14, 50, 418, DateTimeKind.Local).AddTicks(1754), "1,3,6", 65, 1, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2019, 10, 7, 6, 49, 4, 456, DateTimeKind.Local).AddTicks(7559), "0,3,5", 64, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2020, 3, 24, 11, 56, 57, 611, DateTimeKind.Local).AddTicks(5614), "1,2,4", 63, 3, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2020, 6, 24, 13, 57, 8, 993, DateTimeKind.Local).AddTicks(4864), "1,2,6", 61, 1, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2019, 12, 17, 9, 51, 32, 505, DateTimeKind.Local).AddTicks(7961), "1,3,5", 60, 1, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2020, 6, 23, 9, 51, 30, 305, DateTimeKind.Local).AddTicks(810), "1,2,5", 59, 2, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2020, 3, 22, 11, 36, 51, 170, DateTimeKind.Local).AddTicks(1327), "1,3,6", 58, 4, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2020, 1, 2, 10, 15, 13, 919, DateTimeKind.Local).AddTicks(403), "1,3,4", 57, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2019, 12, 5, 7, 16, 38, 775, DateTimeKind.Local).AddTicks(8644), "1,2,4", 56, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2019, 8, 9, 15, 27, 15, 231, DateTimeKind.Local).AddTicks(2168), "1,3,5", 55, 6, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2019, 8, 14, 5, 3, 0, 399, DateTimeKind.Local).AddTicks(2701), "1,2,6", 54, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2020, 2, 20, 7, 4, 40, 876, DateTimeKind.Local).AddTicks(3493), "0,3,5", 53, 1, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2020, 4, 6, 19, 47, 55, 595, DateTimeKind.Local).AddTicks(1654), "0,3,4", 74, 6, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2020, 5, 13, 7, 59, 44, 493, DateTimeKind.Local).AddTicks(9835), "0,2,6", 62, 3, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2020, 4, 24, 3, 1, 43, 50, DateTimeKind.Local).AddTicks(4252), "1,2,4", 75, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2019, 8, 12, 21, 40, 18, 730, DateTimeKind.Local).AddTicks(8182), "1,2,4", 93, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2019, 12, 3, 16, 4, 20, 605, DateTimeKind.Local).AddTicks(4887), "1,2,4", 77, 4, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2019, 12, 30, 11, 17, 58, 596, DateTimeKind.Local).AddTicks(380), "0,2,6", 100, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2020, 5, 1, 2, 12, 28, 890, DateTimeKind.Local).AddTicks(5060), "0,2,4", 99, 1, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2020, 5, 29, 21, 50, 29, 27, DateTimeKind.Local).AddTicks(7026), "0,3,4", 98, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2019, 9, 12, 13, 0, 30, 952, DateTimeKind.Local).AddTicks(3221), "1,3,6", 97, 1, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2020, 5, 17, 17, 36, 32, 788, DateTimeKind.Local).AddTicks(7873), "1,2,5", 96, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2019, 11, 15, 10, 22, 9, 771, DateTimeKind.Local).AddTicks(3386), "0,3,6", 95, 2, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2020, 6, 24, 0, 50, 55, 714, DateTimeKind.Local).AddTicks(8585), "0,2,4", 94, 6, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2020, 7, 6, 0, 9, 49, 150, DateTimeKind.Local).AddTicks(1943), "0,3,4", 52, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2019, 10, 10, 23, 25, 0, 219, DateTimeKind.Local).AddTicks(567), "0,3,6", 92, 1, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2020, 5, 14, 8, 38, 38, 934, DateTimeKind.Local).AddTicks(7252), "1,3,5", 91, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2019, 12, 15, 5, 11, 59, 920, DateTimeKind.Local).AddTicks(7261), "0,3,4", 76, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2019, 9, 9, 4, 2, 46, 124, DateTimeKind.Local).AddTicks(8804), "1,3,5", 90, 5, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2019, 10, 19, 13, 41, 19, 150, DateTimeKind.Local).AddTicks(4362), "1,2,6", 88, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2019, 12, 29, 5, 47, 35, 811, DateTimeKind.Local).AddTicks(5664), "1,3,4", 87, 5, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2020, 7, 1, 12, 56, 33, 448, DateTimeKind.Local).AddTicks(4771), "0,2,6", 86, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2019, 10, 13, 12, 37, 32, 876, DateTimeKind.Local).AddTicks(4266), "1,2,5", 85, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2020, 2, 29, 16, 32, 37, 184, DateTimeKind.Local).AddTicks(9174), "1,3,6", 83, 4, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2020, 1, 3, 3, 22, 50, 337, DateTimeKind.Local).AddTicks(8778), "1,2,4", 82, 4, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2019, 11, 9, 12, 26, 9, 889, DateTimeKind.Local).AddTicks(5338), "1,2,4", 81, 3, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2019, 12, 24, 22, 42, 19, 552, DateTimeKind.Local).AddTicks(5112), "0,2,4", 80, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2020, 3, 27, 7, 13, 23, 821, DateTimeKind.Local).AddTicks(3218), "1,3,6", 79, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2019, 8, 17, 1, 44, 5, 624, DateTimeKind.Local).AddTicks(8383), "0,2,6", 78, 1, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2019, 10, 24, 23, 59, 43, 496, DateTimeKind.Local).AddTicks(2608), "0,3,6", 89, 3, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2019, 12, 15, 0, 44, 22, 68, DateTimeKind.Local).AddTicks(8221), "1,2,6", 51, 6, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2019, 10, 8, 12, 49, 15, 323, DateTimeKind.Local).AddTicks(264), "1,3,5", 84, 1, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2020, 7, 1, 18, 22, 44, 85, DateTimeKind.Local).AddTicks(9851), "0,3,4", 49, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2019, 12, 28, 13, 39, 19, 166, DateTimeKind.Local).AddTicks(8970), "1,2,5", 22, 2, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2019, 10, 29, 10, 8, 43, 709, DateTimeKind.Local).AddTicks(5336), "1,2,6", 21, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2019, 12, 20, 14, 28, 56, 632, DateTimeKind.Local).AddTicks(546), "0,2,5", 20, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2020, 2, 29, 15, 11, 41, 831, DateTimeKind.Local).AddTicks(9394), "0,3,6", 19, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2020, 3, 11, 13, 3, 32, 483, DateTimeKind.Local).AddTicks(2160), "0,3,4", 18, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2020, 1, 4, 8, 17, 19, 542, DateTimeKind.Local).AddTicks(9585), "0,3,6", 17, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2020, 1, 13, 12, 6, 31, 85, DateTimeKind.Local).AddTicks(6304), "0,2,5", 15, 1, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2020, 4, 24, 21, 14, 38, 290, DateTimeKind.Local).AddTicks(9666), "1,3,6", 14, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2020, 2, 6, 18, 28, 24, 552, DateTimeKind.Local).AddTicks(1787), "1,2,6", 13, 6, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2019, 9, 7, 4, 9, 4, 452, DateTimeKind.Local).AddTicks(4160), "0,3,4", 12, 6, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 6, 10, 11, 23, 43, 914, DateTimeKind.Local).AddTicks(5825), "0,2,6", 23, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2020, 3, 29, 3, 52, 44, 535, DateTimeKind.Local).AddTicks(9415), "1,2,4", 11, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2020, 4, 6, 1, 11, 38, 797, DateTimeKind.Local).AddTicks(5724), "1,2,4", 9, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2019, 10, 4, 18, 26, 45, 396, DateTimeKind.Local).AddTicks(3558), "0,2,6", 8, 6, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2019, 12, 2, 0, 50, 48, 160, DateTimeKind.Local).AddTicks(2943), "1,3,5", 7, 4, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2020, 5, 27, 19, 24, 20, 953, DateTimeKind.Local).AddTicks(6295), "1,2,5", 6, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2020, 3, 27, 1, 32, 11, 669, DateTimeKind.Local).AddTicks(4905), "1,2,5", 5, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2020, 4, 28, 21, 50, 39, 753, DateTimeKind.Local).AddTicks(5267), "1,2,5", 4, 5, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2020, 7, 1, 0, 18, 34, 863, DateTimeKind.Local).AddTicks(2640), "1,3,6", 3, 2, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2019, 8, 30, 9, 55, 14, 398, DateTimeKind.Local).AddTicks(2285), "0,3,5", 2, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2020, 3, 26, 0, 55, 29, 372, DateTimeKind.Local).AddTicks(9538), "0,3,5", 1, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2020, 3, 13, 23, 27, 42, 977, DateTimeKind.Local).AddTicks(461), "1,2,4", 50, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2019, 8, 17, 5, 9, 18, 855, DateTimeKind.Local).AddTicks(1370), "0,3,4", 10, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2019, 8, 16, 7, 28, 39, 169, DateTimeKind.Local).AddTicks(5588), "0,2,4", 24, 4, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2019, 9, 6, 18, 6, 40, 31, DateTimeKind.Local).AddTicks(6821), "0,2,6", 16, 2, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2019, 8, 18, 3, 51, 14, 306, DateTimeKind.Local).AddTicks(4980), "0,2,6", 26, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2019, 10, 1, 23, 13, 14, 653, DateTimeKind.Local).AddTicks(7677), "1,2,5", 48, 4, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2020, 6, 10, 8, 20, 22, 180, DateTimeKind.Local).AddTicks(7311), "1,3,5", 47, 6, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2020, 5, 11, 12, 9, 14, 399, DateTimeKind.Local).AddTicks(688), "0,3,6", 46, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2020, 1, 25, 9, 51, 55, 688, DateTimeKind.Local).AddTicks(552), "1,2,4", 25, 6, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2020, 6, 1, 8, 18, 5, 882, DateTimeKind.Local).AddTicks(52), "1,2,4", 44, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2019, 12, 31, 11, 9, 26, 85, DateTimeKind.Local).AddTicks(8726), "1,3,5", 43, 1, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2020, 1, 6, 22, 54, 45, 43, DateTimeKind.Local).AddTicks(3138), "0,3,6", 42, 6, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2020, 2, 17, 9, 8, 57, 796, DateTimeKind.Local).AddTicks(5249), "1,3,5", 41, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2020, 5, 17, 4, 47, 17, 206, DateTimeKind.Local).AddTicks(7209), "0,2,4", 40, 2, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2020, 3, 15, 16, 35, 3, 998, DateTimeKind.Local).AddTicks(1218), "0,3,4", 39, 6, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2019, 12, 31, 15, 30, 11, 127, DateTimeKind.Local).AddTicks(8625), "1,3,6", 38, 3, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2020, 2, 21, 14, 54, 27, 852, DateTimeKind.Local).AddTicks(9017), "0,2,4", 37, 1, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2020, 6, 21, 22, 8, 31, 160, DateTimeKind.Local).AddTicks(2775), "1,2,4", 45, 2, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2019, 10, 5, 15, 1, 34, 718, DateTimeKind.Local).AddTicks(4547), "1,3,4", 35, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2019, 8, 2, 16, 20, 12, 376, DateTimeKind.Local).AddTicks(7922), "0,2,6", 34, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2020, 6, 7, 19, 23, 11, 579, DateTimeKind.Local).AddTicks(1206), "1,2,4", 33, 6, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2020, 6, 11, 5, 23, 51, 185, DateTimeKind.Local).AddTicks(3144), "0,3,5", 27, 5, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2020, 7, 11, 12, 7, 9, 304, DateTimeKind.Local).AddTicks(9112), "1,2,4", 32, 3, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2019, 10, 25, 10, 13, 40, 80, DateTimeKind.Local).AddTicks(8393), "1,3,5", 31, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2020, 1, 22, 11, 39, 11, 509, DateTimeKind.Local).AddTicks(8948), "0,2,5", 30, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2019, 12, 30, 1, 49, 58, 916, DateTimeKind.Local).AddTicks(3151), "0,2,6", 29, 6, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2019, 8, 1, 7, 6, 36, 627, DateTimeKind.Local).AddTicks(1972), "0,2,6", 28, 5, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2019, 7, 29, 11, 30, 34, 84, DateTimeKind.Local).AddTicks(7297), "0,3,4", 36, 3, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

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
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 15, 2020, "", "", "Session 15" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 14, 2020, "", "", "Session 14" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 9, 2020, "", "", "Session 9" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 12, 2020, "", "", "Session 12" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 11, 2020, "", "", "Session 11" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 10, 2020, "", "", "Session 10" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 8, 2020, "", "", "Session 8" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 13, 2020, "", "", "Session 13" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 6, 2020, "", "", "Session 6" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 5, 2020, "", "", "Session 5" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 4, 2020, "", "", "Session 4" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 3, 2020, "", "", "Session 3" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 2, 2020, "", "", "Session 2" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 1, 2020, "", "", "Session 1" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session" },
                values: new object[] { 7, 2020, "", "", "Session 7" });

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
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 9, 2020, "", "sous theme 9", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 15, 2020, "", "sous theme 15", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 14, 2020, "", "sous theme 14", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 13, 2020, "", "sous theme 13", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 11, 2020, "", "sous theme 11", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 10, 2020, "", "sous theme 10", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 8, 2020, "", "sous theme 8", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 12, 2020, "", "sous theme 12", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 6, 2020, "", "sous theme 6", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 5, 2020, "", "sous theme 5", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 4, 2020, "", "sous theme 4", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 7, 2020, "", "sous theme 7", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 3, 2020, "", "sous theme 3", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 2, 2020, "", "sous theme 2", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 1, 2020, "", "sous theme 1", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 66, "", "", new DateTime(2019, 7, 18, 5, 33, 35, 80, DateTimeKind.Local).AddTicks(5665), new DateTime(2019, 8, 17, 18, 23, 59, 978, DateTimeKind.Local).AddTicks(2027), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 67, "", "", new DateTime(2019, 9, 20, 11, 41, 31, 436, DateTimeKind.Local).AddTicks(7163), new DateTime(2020, 2, 4, 21, 41, 22, 755, DateTimeKind.Local).AddTicks(1338), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 68, "", "", new DateTime(2020, 7, 13, 0, 23, 53, 989, DateTimeKind.Local).AddTicks(2740), new DateTime(2019, 8, 6, 19, 28, 31, 638, DateTimeKind.Local).AddTicks(5215), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 69, "", "", new DateTime(2019, 7, 21, 21, 10, 38, 899, DateTimeKind.Local).AddTicks(3574), new DateTime(2019, 10, 17, 12, 20, 5, 127, DateTimeKind.Local).AddTicks(6138), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 72, "", "", new DateTime(2020, 4, 4, 23, 29, 53, 330, DateTimeKind.Local).AddTicks(3371), new DateTime(2020, 5, 21, 15, 15, 18, 70, DateTimeKind.Local).AddTicks(6845), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 71, "", "", new DateTime(2020, 1, 19, 21, 55, 56, 519, DateTimeKind.Local).AddTicks(7875), new DateTime(2020, 2, 8, 17, 24, 17, 744, DateTimeKind.Local).AddTicks(3759), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 65, "", "", new DateTime(2019, 12, 26, 19, 18, 31, 102, DateTimeKind.Local).AddTicks(8037), new DateTime(2020, 4, 3, 9, 33, 32, 575, DateTimeKind.Local).AddTicks(1196), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 73, "", "", new DateTime(2020, 3, 27, 21, 4, 54, 950, DateTimeKind.Local).AddTicks(8012), new DateTime(2019, 12, 31, 8, 42, 35, 36, DateTimeKind.Local).AddTicks(614), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 74, "", "", new DateTime(2020, 4, 22, 11, 48, 32, 72, DateTimeKind.Local).AddTicks(319), new DateTime(2020, 2, 20, 2, 30, 50, 220, DateTimeKind.Local).AddTicks(5244), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 70, "", "", new DateTime(2019, 11, 5, 14, 23, 24, 714, DateTimeKind.Local).AddTicks(9629), new DateTime(2020, 1, 14, 9, 55, 23, 198, DateTimeKind.Local).AddTicks(1597), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 64, "", "", new DateTime(2019, 12, 20, 7, 33, 49, 532, DateTimeKind.Local).AddTicks(9636), new DateTime(2019, 10, 3, 7, 1, 38, 414, DateTimeKind.Local).AddTicks(6509), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 62, "", "", new DateTime(2019, 12, 30, 16, 27, 35, 550, DateTimeKind.Local).AddTicks(7730), new DateTime(2020, 4, 8, 20, 8, 31, 13, DateTimeKind.Local).AddTicks(597), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 53, "", "", new DateTime(2019, 8, 25, 6, 0, 10, 216, DateTimeKind.Local).AddTicks(357), new DateTime(2019, 7, 16, 19, 32, 59, 62, DateTimeKind.Local).AddTicks(6186), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 61, "", "", new DateTime(2020, 4, 5, 15, 33, 16, 837, DateTimeKind.Local).AddTicks(6857), new DateTime(2020, 6, 17, 15, 43, 3, 405, DateTimeKind.Local).AddTicks(3762), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 60, "", "", new DateTime(2020, 1, 30, 3, 55, 27, 952, DateTimeKind.Local).AddTicks(6322), new DateTime(2020, 6, 22, 12, 8, 47, 483, DateTimeKind.Local).AddTicks(3465), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 59, "", "", new DateTime(2020, 2, 20, 3, 2, 14, 694, DateTimeKind.Local).AddTicks(2695), new DateTime(2020, 5, 24, 16, 27, 51, 216, DateTimeKind.Local).AddTicks(5023), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 58, "", "", new DateTime(2020, 4, 17, 8, 44, 33, 499, DateTimeKind.Local).AddTicks(5898), new DateTime(2019, 12, 22, 22, 23, 45, 229, DateTimeKind.Local).AddTicks(7529), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 57, "", "", new DateTime(2020, 3, 16, 6, 41, 31, 576, DateTimeKind.Local).AddTicks(1554), new DateTime(2019, 11, 9, 19, 24, 16, 543, DateTimeKind.Local).AddTicks(4760), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 56, "", "", new DateTime(2020, 1, 19, 8, 59, 54, 960, DateTimeKind.Local).AddTicks(5694), new DateTime(2020, 5, 28, 1, 40, 20, 579, DateTimeKind.Local).AddTicks(6146), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 55, "", "", new DateTime(2020, 6, 16, 9, 50, 35, 105, DateTimeKind.Local).AddTicks(8565), new DateTime(2019, 12, 28, 22, 58, 33, 561, DateTimeKind.Local).AddTicks(6894), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 54, "", "", new DateTime(2020, 2, 10, 15, 28, 59, 427, DateTimeKind.Local).AddTicks(3952), new DateTime(2020, 2, 12, 22, 42, 41, 226, DateTimeKind.Local).AddTicks(3166), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 75, "", "", new DateTime(2020, 6, 20, 17, 48, 27, 473, DateTimeKind.Local).AddTicks(8398), new DateTime(2019, 10, 10, 14, 27, 17, 524, DateTimeKind.Local).AddTicks(1752), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 63, "", "", new DateTime(2020, 6, 13, 21, 48, 40, 221, DateTimeKind.Local).AddTicks(256), new DateTime(2019, 12, 7, 2, 30, 7, 581, DateTimeKind.Local).AddTicks(6189), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 76, "", "", new DateTime(2019, 8, 30, 2, 14, 42, 406, DateTimeKind.Local).AddTicks(8284), new DateTime(2019, 11, 5, 4, 45, 37, 877, DateTimeKind.Local).AddTicks(7722), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 91, "", "", new DateTime(2020, 5, 1, 2, 4, 41, 535, DateTimeKind.Local).AddTicks(938), new DateTime(2019, 10, 3, 1, 46, 6, 61, DateTimeKind.Local).AddTicks(1605), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 78, "", "", new DateTime(2020, 3, 5, 18, 14, 13, 536, DateTimeKind.Local).AddTicks(8778), new DateTime(2019, 11, 24, 7, 33, 31, 996, DateTimeKind.Local).AddTicks(9085), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 52, "", "", new DateTime(2019, 8, 20, 21, 38, 2, 411, DateTimeKind.Local).AddTicks(4594), new DateTime(2019, 11, 3, 6, 47, 36, 841, DateTimeKind.Local).AddTicks(3511), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 100, "", "", new DateTime(2020, 7, 11, 10, 47, 11, 761, DateTimeKind.Local).AddTicks(242), new DateTime(2019, 10, 17, 20, 12, 4, 317, DateTimeKind.Local).AddTicks(9822), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 99, "", "", new DateTime(2020, 1, 24, 15, 33, 34, 116, DateTimeKind.Local).AddTicks(6346), new DateTime(2019, 10, 21, 8, 23, 48, 795, DateTimeKind.Local).AddTicks(2490), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 98, "", "", new DateTime(2019, 7, 30, 6, 32, 53, 133, DateTimeKind.Local).AddTicks(5359), new DateTime(2020, 1, 20, 7, 31, 34, 377, DateTimeKind.Local).AddTicks(9271), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 97, "", "", new DateTime(2019, 12, 16, 10, 36, 27, 674, DateTimeKind.Local).AddTicks(6281), new DateTime(2020, 3, 9, 12, 23, 31, 579, DateTimeKind.Local).AddTicks(4380), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 96, "", "", new DateTime(2019, 9, 4, 3, 42, 1, 777, DateTimeKind.Local).AddTicks(1803), new DateTime(2019, 11, 27, 14, 24, 40, 690, DateTimeKind.Local).AddTicks(5639), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 95, "", "", new DateTime(2020, 5, 22, 9, 51, 33, 631, DateTimeKind.Local).AddTicks(2174), new DateTime(2020, 7, 3, 18, 10, 24, 808, DateTimeKind.Local).AddTicks(1717), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 94, "", "", new DateTime(2019, 12, 28, 14, 4, 52, 939, DateTimeKind.Local).AddTicks(5665), new DateTime(2020, 4, 15, 6, 9, 9, 103, DateTimeKind.Local).AddTicks(274), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 93, "", "", new DateTime(2020, 2, 11, 21, 55, 4, 95, DateTimeKind.Local).AddTicks(5503), new DateTime(2020, 7, 14, 20, 40, 4, 250, DateTimeKind.Local).AddTicks(3928), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 92, "", "", new DateTime(2019, 10, 13, 10, 21, 12, 144, DateTimeKind.Local).AddTicks(1946), new DateTime(2019, 10, 31, 4, 15, 29, 567, DateTimeKind.Local).AddTicks(7289), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 77, "", "", new DateTime(2019, 12, 27, 23, 15, 51, 397, DateTimeKind.Local).AddTicks(8017), new DateTime(2020, 2, 17, 12, 48, 15, 94, DateTimeKind.Local).AddTicks(6919), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 90, "", "", new DateTime(2020, 3, 23, 8, 16, 22, 332, DateTimeKind.Local).AddTicks(648), new DateTime(2020, 4, 27, 16, 31, 23, 199, DateTimeKind.Local).AddTicks(1436), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 88, "", "", new DateTime(2019, 9, 30, 5, 48, 24, 671, DateTimeKind.Local).AddTicks(1354), new DateTime(2020, 5, 24, 6, 27, 8, 798, DateTimeKind.Local).AddTicks(1810), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 87, "", "", new DateTime(2020, 7, 3, 18, 26, 25, 473, DateTimeKind.Local).AddTicks(7898), new DateTime(2020, 6, 6, 10, 15, 31, 973, DateTimeKind.Local).AddTicks(5461), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 86, "", "", new DateTime(2019, 10, 29, 1, 14, 9, 513, DateTimeKind.Local).AddTicks(8260), new DateTime(2019, 8, 6, 21, 55, 1, 996, DateTimeKind.Local).AddTicks(4485), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 85, "", "", new DateTime(2019, 10, 22, 19, 9, 8, 327, DateTimeKind.Local).AddTicks(3558), new DateTime(2019, 12, 13, 15, 12, 34, 845, DateTimeKind.Local).AddTicks(6959), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 84, "", "", new DateTime(2020, 1, 8, 20, 25, 2, 70, DateTimeKind.Local).AddTicks(6700), new DateTime(2019, 11, 4, 23, 48, 15, 610, DateTimeKind.Local).AddTicks(7741), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 83, "", "", new DateTime(2019, 11, 29, 11, 25, 8, 784, DateTimeKind.Local).AddTicks(8383), new DateTime(2020, 4, 6, 11, 8, 13, 253, DateTimeKind.Local).AddTicks(4728), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 82, "", "", new DateTime(2020, 6, 21, 12, 27, 58, 704, DateTimeKind.Local).AddTicks(4815), new DateTime(2020, 6, 15, 0, 57, 28, 494, DateTimeKind.Local).AddTicks(1796), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 81, "", "", new DateTime(2020, 1, 5, 22, 52, 37, 985, DateTimeKind.Local).AddTicks(3347), new DateTime(2020, 2, 21, 22, 44, 50, 987, DateTimeKind.Local).AddTicks(634), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 80, "", "", new DateTime(2020, 1, 8, 10, 38, 24, 370, DateTimeKind.Local).AddTicks(6696), new DateTime(2019, 12, 24, 10, 36, 32, 132, DateTimeKind.Local).AddTicks(4136), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 79, "", "", new DateTime(2020, 6, 22, 22, 18, 5, 612, DateTimeKind.Local).AddTicks(2196), new DateTime(2020, 4, 8, 6, 28, 58, 329, DateTimeKind.Local).AddTicks(4071), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 89, "", "", new DateTime(2020, 3, 19, 7, 35, 29, 867, DateTimeKind.Local).AddTicks(5519), new DateTime(2020, 5, 30, 19, 1, 18, 463, DateTimeKind.Local).AddTicks(9330), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 51, "", "", new DateTime(2019, 7, 20, 5, 45, 3, 146, DateTimeKind.Local).AddTicks(2365), new DateTime(2019, 11, 27, 1, 42, 47, 74, DateTimeKind.Local).AddTicks(5215), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 8, "", "", new DateTime(2020, 1, 18, 4, 18, 16, 434, DateTimeKind.Local).AddTicks(6092), new DateTime(2020, 4, 7, 10, 39, 53, 13, DateTimeKind.Local).AddTicks(636), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 49, "", "", new DateTime(2019, 8, 10, 15, 21, 42, 234, DateTimeKind.Local).AddTicks(7370), new DateTime(2020, 3, 1, 10, 45, 7, 610, DateTimeKind.Local).AddTicks(4392), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 22, "", "", new DateTime(2019, 10, 21, 5, 34, 42, 43, DateTimeKind.Local).AddTicks(499), new DateTime(2019, 11, 8, 15, 33, 29, 532, DateTimeKind.Local).AddTicks(4433), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 21, "", "", new DateTime(2019, 12, 31, 22, 15, 26, 557, DateTimeKind.Local).AddTicks(5033), new DateTime(2019, 10, 12, 4, 51, 59, 69, DateTimeKind.Local).AddTicks(2597), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 20, "", "", new DateTime(2020, 5, 19, 1, 20, 37, 957, DateTimeKind.Local).AddTicks(9088), new DateTime(2019, 8, 2, 15, 34, 30, 76, DateTimeKind.Local).AddTicks(645), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 19, "", "", new DateTime(2020, 5, 10, 5, 1, 50, 689, DateTimeKind.Local).AddTicks(6620), new DateTime(2019, 11, 22, 22, 43, 3, 608, DateTimeKind.Local).AddTicks(6199), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 18, "", "", new DateTime(2019, 9, 19, 2, 39, 32, 268, DateTimeKind.Local).AddTicks(6174), new DateTime(2020, 2, 16, 23, 2, 21, 201, DateTimeKind.Local).AddTicks(5342), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 17, "", "", new DateTime(2019, 8, 7, 13, 46, 5, 335, DateTimeKind.Local).AddTicks(322), new DateTime(2020, 6, 17, 5, 53, 31, 239, DateTimeKind.Local).AddTicks(5681), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 16, "", "", new DateTime(2020, 6, 28, 0, 27, 38, 577, DateTimeKind.Local).AddTicks(9981), new DateTime(2019, 10, 3, 22, 57, 2, 730, DateTimeKind.Local).AddTicks(2728), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 15, "", "", new DateTime(2020, 1, 7, 16, 9, 22, 88, DateTimeKind.Local).AddTicks(394), new DateTime(2019, 10, 24, 16, 22, 11, 757, DateTimeKind.Local).AddTicks(1306), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 14, "", "", new DateTime(2019, 8, 3, 16, 39, 22, 58, DateTimeKind.Local).AddTicks(7611), new DateTime(2020, 6, 1, 16, 54, 55, 386, DateTimeKind.Local).AddTicks(5906), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 13, "", "", new DateTime(2019, 9, 3, 17, 15, 8, 357, DateTimeKind.Local).AddTicks(5181), new DateTime(2019, 7, 24, 10, 52, 6, 965, DateTimeKind.Local).AddTicks(8860), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 12, "", "", new DateTime(2019, 8, 30, 13, 21, 4, 468, DateTimeKind.Local).AddTicks(6062), new DateTime(2020, 4, 16, 17, 59, 44, 143, DateTimeKind.Local).AddTicks(6876), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 11, "", "", new DateTime(2020, 3, 4, 8, 23, 11, 26, DateTimeKind.Local).AddTicks(928), new DateTime(2020, 2, 6, 12, 32, 40, 245, DateTimeKind.Local).AddTicks(9326), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 10, "", "", new DateTime(2020, 3, 20, 5, 41, 0, 271, DateTimeKind.Local).AddTicks(4627), new DateTime(2020, 5, 8, 23, 41, 16, 933, DateTimeKind.Local).AddTicks(407), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 9, "", "", new DateTime(2020, 4, 17, 0, 55, 48, 536, DateTimeKind.Local).AddTicks(2244), new DateTime(2020, 2, 5, 12, 19, 4, 501, DateTimeKind.Local).AddTicks(9305), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 7, "", "", new DateTime(2020, 3, 21, 8, 27, 12, 857, DateTimeKind.Local).AddTicks(2788), new DateTime(2019, 10, 20, 0, 12, 14, 901, DateTimeKind.Local).AddTicks(3905), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 6, "", "", new DateTime(2019, 12, 30, 8, 24, 39, 463, DateTimeKind.Local).AddTicks(4590), new DateTime(2020, 3, 10, 2, 4, 4, 32, DateTimeKind.Local).AddTicks(9745), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 5, "", "", new DateTime(2019, 11, 14, 13, 59, 7, 615, DateTimeKind.Local).AddTicks(2466), new DateTime(2019, 9, 12, 10, 7, 43, 435, DateTimeKind.Local).AddTicks(274), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 4, "", "", new DateTime(2020, 6, 28, 8, 37, 5, 77, DateTimeKind.Local).AddTicks(7157), new DateTime(2019, 12, 10, 0, 46, 39, 148, DateTimeKind.Local).AddTicks(1226), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 3, "", "", new DateTime(2020, 6, 16, 19, 13, 23, 859, DateTimeKind.Local).AddTicks(9043), new DateTime(2019, 12, 22, 18, 56, 33, 416, DateTimeKind.Local).AddTicks(190), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 2, "", "", new DateTime(2020, 5, 5, 1, 10, 43, 131, DateTimeKind.Local).AddTicks(4531), new DateTime(2020, 2, 1, 12, 8, 25, 4, DateTimeKind.Local).AddTicks(9858), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 50, "", "", new DateTime(2020, 4, 7, 10, 50, 27, 733, DateTimeKind.Local).AddTicks(7119), new DateTime(2019, 12, 5, 10, 53, 44, 665, DateTimeKind.Local).AddTicks(931), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 23, "", "", new DateTime(2020, 4, 6, 8, 24, 17, 161, DateTimeKind.Local).AddTicks(5544), new DateTime(2019, 9, 29, 15, 57, 38, 627, DateTimeKind.Local).AddTicks(4634), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 24, "", "", new DateTime(2019, 11, 8, 2, 3, 41, 31, DateTimeKind.Local).AddTicks(9406), new DateTime(2019, 11, 10, 6, 29, 6, 586, DateTimeKind.Local).AddTicks(7666), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 1, "", "", new DateTime(2020, 5, 27, 11, 41, 44, 561, DateTimeKind.Local).AddTicks(3881), new DateTime(2020, 1, 30, 8, 47, 18, 398, DateTimeKind.Local).AddTicks(3893), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 26, "", "", new DateTime(2020, 5, 29, 0, 25, 33, 806, DateTimeKind.Local).AddTicks(7043), new DateTime(2019, 7, 26, 3, 28, 29, 827, DateTimeKind.Local).AddTicks(4010), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 25, "", "", new DateTime(2020, 7, 9, 3, 43, 29, 591, DateTimeKind.Local).AddTicks(9403), new DateTime(2020, 3, 2, 7, 7, 26, 279, DateTimeKind.Local).AddTicks(3460), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 47, "", "", new DateTime(2019, 10, 30, 9, 42, 56, 521, DateTimeKind.Local).AddTicks(5406), new DateTime(2020, 4, 4, 10, 47, 45, 636, DateTimeKind.Local).AddTicks(9200), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 46, "", "", new DateTime(2019, 11, 12, 21, 42, 13, 149, DateTimeKind.Local).AddTicks(7152), new DateTime(2019, 12, 24, 23, 2, 43, 945, DateTimeKind.Local).AddTicks(7245), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 45, "", "", new DateTime(2020, 1, 12, 8, 48, 34, 512, DateTimeKind.Local).AddTicks(1097), new DateTime(2020, 3, 20, 18, 15, 45, 689, DateTimeKind.Local).AddTicks(6798), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 44, "", "", new DateTime(2020, 4, 13, 10, 33, 58, 678, DateTimeKind.Local).AddTicks(3304), new DateTime(2020, 4, 23, 12, 34, 51, 423, DateTimeKind.Local).AddTicks(6261), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 43, "", "", new DateTime(2020, 3, 10, 11, 13, 55, 658, DateTimeKind.Local).AddTicks(1257), new DateTime(2020, 6, 24, 21, 42, 1, 676, DateTimeKind.Local).AddTicks(3843), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 42, "", "", new DateTime(2019, 7, 18, 12, 10, 54, 237, DateTimeKind.Local).AddTicks(1277), new DateTime(2019, 11, 12, 2, 48, 24, 772, DateTimeKind.Local).AddTicks(4950), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 41, "", "", new DateTime(2020, 5, 28, 14, 3, 15, 338, DateTimeKind.Local).AddTicks(6449), new DateTime(2019, 8, 13, 15, 12, 22, 407, DateTimeKind.Local).AddTicks(5637), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 40, "", "", new DateTime(2020, 4, 7, 16, 47, 6, 270, DateTimeKind.Local).AddTicks(3564), new DateTime(2019, 11, 7, 6, 49, 5, 964, DateTimeKind.Local).AddTicks(3737), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 39, "", "", new DateTime(2020, 3, 9, 1, 46, 54, 212, DateTimeKind.Local).AddTicks(2559), new DateTime(2019, 7, 18, 13, 27, 35, 754, DateTimeKind.Local).AddTicks(7093), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 38, "", "", new DateTime(2019, 11, 24, 19, 9, 19, 610, DateTimeKind.Local).AddTicks(7918), new DateTime(2020, 7, 12, 8, 12, 46, 530, DateTimeKind.Local).AddTicks(9017), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 48, "", "", new DateTime(2019, 7, 19, 12, 54, 59, 603, DateTimeKind.Local).AddTicks(864), new DateTime(2019, 12, 26, 5, 38, 8, 956, DateTimeKind.Local).AddTicks(6714), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 36, "", "", new DateTime(2019, 10, 8, 18, 37, 1, 403, DateTimeKind.Local).AddTicks(5153), new DateTime(2019, 9, 25, 14, 15, 38, 157, DateTimeKind.Local).AddTicks(5354), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 27, "", "", new DateTime(2020, 5, 22, 8, 27, 26, 907, DateTimeKind.Local).AddTicks(8707), new DateTime(2020, 5, 4, 15, 47, 45, 439, DateTimeKind.Local).AddTicks(600), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 37, "", "", new DateTime(2019, 9, 26, 18, 12, 56, 759, DateTimeKind.Local).AddTicks(900), new DateTime(2020, 6, 26, 19, 55, 52, 363, DateTimeKind.Local).AddTicks(8185), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 29, "", "", new DateTime(2020, 6, 28, 14, 5, 11, 559, DateTimeKind.Local).AddTicks(5462), new DateTime(2019, 12, 29, 21, 3, 14, 238, DateTimeKind.Local).AddTicks(3146), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 30, "", "", new DateTime(2020, 3, 8, 8, 31, 30, 234, DateTimeKind.Local).AddTicks(8633), new DateTime(2019, 11, 4, 23, 38, 49, 259, DateTimeKind.Local).AddTicks(7861), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 31, "", "", new DateTime(2020, 7, 11, 14, 34, 51, 740, DateTimeKind.Local).AddTicks(3211), new DateTime(2019, 10, 31, 7, 14, 5, 880, DateTimeKind.Local).AddTicks(4540), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 28, "", "", new DateTime(2019, 12, 29, 0, 7, 26, 283, DateTimeKind.Local).AddTicks(6602), new DateTime(2020, 2, 26, 7, 14, 30, 417, DateTimeKind.Local).AddTicks(2672), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 33, "", "", new DateTime(2019, 8, 20, 3, 10, 17, 863, DateTimeKind.Local).AddTicks(9592), new DateTime(2019, 10, 2, 1, 54, 15, 525, DateTimeKind.Local).AddTicks(8395), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 34, "", "", new DateTime(2019, 9, 16, 5, 31, 16, 699, DateTimeKind.Local).AddTicks(744), new DateTime(2019, 10, 6, 7, 22, 56, 897, DateTimeKind.Local).AddTicks(2965), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 35, "", "", new DateTime(2019, 7, 19, 16, 24, 17, 818, DateTimeKind.Local).AddTicks(8220), new DateTime(2020, 4, 14, 3, 1, 59, 783, DateTimeKind.Local).AddTicks(9469), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 32, "", "", new DateTime(2019, 7, 29, 21, 21, 3, 396, DateTimeKind.Local).AddTicks(4341), new DateTime(2020, 2, 16, 9, 43, 30, 982, DateTimeKind.Local).AddTicks(1053), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 65, new DateTime(2019, 10, 10, 18, 4, 31, 332, DateTimeKind.Local).AddTicks(5906), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 72, new DateTime(2019, 11, 17, 19, 33, 46, 20, DateTimeKind.Local).AddTicks(9336), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 71, new DateTime(2020, 7, 12, 12, 41, 34, 690, DateTimeKind.Local).AddTicks(3222), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 70, new DateTime(2020, 3, 7, 20, 50, 4, 271, DateTimeKind.Local).AddTicks(1635), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 69, new DateTime(2019, 12, 16, 0, 11, 48, 367, DateTimeKind.Local).AddTicks(4528), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 68, new DateTime(2020, 3, 10, 10, 42, 50, 777, DateTimeKind.Local).AddTicks(8726), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 67, new DateTime(2020, 7, 3, 5, 38, 23, 939, DateTimeKind.Local).AddTicks(5459), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 66, new DateTime(2020, 2, 13, 21, 37, 13, 965, DateTimeKind.Local).AddTicks(8475), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 64, new DateTime(2020, 5, 12, 11, 50, 31, 721, DateTimeKind.Local).AddTicks(5624), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 53, new DateTime(2019, 11, 6, 12, 15, 18, 107, DateTimeKind.Local).AddTicks(7699), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 62, new DateTime(2020, 7, 10, 23, 10, 39, 140, DateTimeKind.Local).AddTicks(3492), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 61, new DateTime(2020, 2, 20, 16, 26, 50, 113, DateTimeKind.Local).AddTicks(6387), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 60, new DateTime(2020, 5, 31, 15, 34, 27, 279, DateTimeKind.Local).AddTicks(5460), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 59, new DateTime(2020, 5, 6, 11, 12, 12, 758, DateTimeKind.Local).AddTicks(5250), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 58, new DateTime(2020, 2, 21, 6, 59, 42, 154, DateTimeKind.Local).AddTicks(5142), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 57, new DateTime(2020, 7, 2, 15, 15, 49, 199, DateTimeKind.Local).AddTicks(1034), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 56, new DateTime(2020, 1, 28, 0, 35, 5, 384, DateTimeKind.Local).AddTicks(753), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 55, new DateTime(2019, 10, 11, 3, 57, 18, 535, DateTimeKind.Local).AddTicks(2067), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 54, new DateTime(2020, 4, 24, 13, 54, 3, 315, DateTimeKind.Local).AddTicks(3862), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 73, new DateTime(2019, 9, 10, 0, 8, 41, 854, DateTimeKind.Local).AddTicks(5848), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 52, new DateTime(2020, 2, 3, 6, 39, 36, 766, DateTimeKind.Local).AddTicks(4734), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 63, new DateTime(2020, 2, 4, 8, 2, 35, 478, DateTimeKind.Local).AddTicks(3744), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 74, new DateTime(2020, 1, 14, 22, 27, 41, 784, DateTimeKind.Local).AddTicks(943), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 85, new DateTime(2019, 10, 24, 22, 45, 50, 795, DateTimeKind.Local).AddTicks(6280), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 76, new DateTime(2020, 4, 27, 14, 17, 20, 984, DateTimeKind.Local).AddTicks(9835), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 98, new DateTime(2019, 12, 1, 22, 58, 35, 201, DateTimeKind.Local).AddTicks(8032), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 51, new DateTime(2019, 12, 15, 1, 7, 45, 413, DateTimeKind.Local).AddTicks(1069), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 97, new DateTime(2020, 2, 12, 3, 20, 25, 43, DateTimeKind.Local).AddTicks(9365), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 96, new DateTime(2020, 6, 11, 20, 54, 55, 785, DateTimeKind.Local).AddTicks(3912), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 95, new DateTime(2019, 10, 7, 9, 39, 41, 333, DateTimeKind.Local).AddTicks(6286), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 94, new DateTime(2019, 9, 11, 2, 2, 32, 261, DateTimeKind.Local).AddTicks(7109), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 93, new DateTime(2019, 12, 4, 1, 35, 45, 547, DateTimeKind.Local).AddTicks(1887), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 92, new DateTime(2020, 5, 13, 20, 43, 14, 596, DateTimeKind.Local).AddTicks(1481), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 91, new DateTime(2019, 11, 19, 6, 10, 0, 23, DateTimeKind.Local).AddTicks(9057), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 90, new DateTime(2020, 1, 26, 19, 15, 16, 849, DateTimeKind.Local).AddTicks(298), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 75, new DateTime(2020, 1, 2, 16, 22, 16, 491, DateTimeKind.Local).AddTicks(5433), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 89, new DateTime(2020, 5, 16, 13, 23, 3, 322, DateTimeKind.Local).AddTicks(7304), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 87, new DateTime(2020, 5, 25, 12, 14, 17, 301, DateTimeKind.Local).AddTicks(7736), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 86, new DateTime(2019, 8, 25, 18, 36, 3, 865, DateTimeKind.Local).AddTicks(4461), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 84, new DateTime(2019, 8, 10, 12, 38, 8, 652, DateTimeKind.Local).AddTicks(1629), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 83, new DateTime(2019, 8, 8, 5, 41, 23, 165, DateTimeKind.Local).AddTicks(8937), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 82, new DateTime(2020, 2, 15, 12, 13, 55, 933, DateTimeKind.Local).AddTicks(621), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 81, new DateTime(2019, 11, 2, 15, 54, 46, 344, DateTimeKind.Local).AddTicks(3581), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 80, new DateTime(2020, 4, 26, 9, 10, 1, 159, DateTimeKind.Local).AddTicks(1511), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 79, new DateTime(2019, 7, 27, 10, 12, 48, 448, DateTimeKind.Local).AddTicks(9567), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 78, new DateTime(2020, 4, 25, 7, 15, 19, 920, DateTimeKind.Local).AddTicks(2267), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 77, new DateTime(2020, 3, 3, 10, 57, 14, 589, DateTimeKind.Local).AddTicks(3112), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 88, new DateTime(2019, 11, 11, 13, 48, 26, 70, DateTimeKind.Local).AddTicks(8167), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 50, new DateTime(2020, 4, 4, 17, 9, 21, 542, DateTimeKind.Local).AddTicks(683), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 26, new DateTime(2020, 5, 26, 0, 46, 58, 879, DateTimeKind.Local).AddTicks(7739), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 48, new DateTime(2019, 9, 24, 3, 33, 34, 701, DateTimeKind.Local).AddTicks(9601), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 20, new DateTime(2020, 3, 3, 2, 55, 19, 862, DateTimeKind.Local).AddTicks(4993), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 19, new DateTime(2020, 5, 9, 1, 38, 58, 708, DateTimeKind.Local).AddTicks(3057), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 18, new DateTime(2020, 1, 24, 20, 52, 48, 580, DateTimeKind.Local).AddTicks(9087), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 17, new DateTime(2020, 2, 14, 0, 53, 30, 605, DateTimeKind.Local).AddTicks(3355), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 16, new DateTime(2020, 6, 12, 8, 59, 38, 293, DateTimeKind.Local).AddTicks(1674), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 15, new DateTime(2020, 2, 12, 19, 44, 20, 516, DateTimeKind.Local).AddTicks(2399), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 14, new DateTime(2020, 6, 10, 13, 41, 15, 81, DateTimeKind.Local).AddTicks(240), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 13, new DateTime(2019, 10, 13, 1, 28, 42, 742, DateTimeKind.Local).AddTicks(2541), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 12, new DateTime(2020, 1, 12, 1, 5, 13, 28, DateTimeKind.Local).AddTicks(9164), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 11, new DateTime(2020, 2, 27, 8, 55, 57, 822, DateTimeKind.Local).AddTicks(5784), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 10, new DateTime(2019, 8, 31, 6, 53, 25, 341, DateTimeKind.Local).AddTicks(7536), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 9, new DateTime(2020, 3, 8, 3, 32, 7, 670, DateTimeKind.Local).AddTicks(7041), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 8, new DateTime(2019, 10, 6, 22, 24, 39, 599, DateTimeKind.Local).AddTicks(9667), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 7, new DateTime(2020, 2, 27, 17, 30, 32, 991, DateTimeKind.Local).AddTicks(259), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 6, new DateTime(2019, 8, 6, 11, 21, 33, 843, DateTimeKind.Local).AddTicks(7874), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 5, new DateTime(2019, 11, 21, 11, 42, 26, 240, DateTimeKind.Local).AddTicks(8959), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 4, new DateTime(2019, 8, 9, 4, 36, 4, 437, DateTimeKind.Local).AddTicks(1728), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 3, new DateTime(2019, 8, 16, 6, 5, 16, 598, DateTimeKind.Local).AddTicks(8079), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 2, new DateTime(2019, 11, 8, 18, 11, 57, 994, DateTimeKind.Local).AddTicks(4214), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 1, new DateTime(2019, 11, 14, 6, 28, 59, 675, DateTimeKind.Local).AddTicks(2639), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 99, new DateTime(2019, 9, 22, 20, 54, 14, 777, DateTimeKind.Local).AddTicks(9742), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 21, new DateTime(2019, 8, 19, 22, 27, 16, 580, DateTimeKind.Local).AddTicks(9110), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 22, new DateTime(2019, 9, 24, 16, 47, 15, 998, DateTimeKind.Local).AddTicks(7385), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 23, new DateTime(2020, 2, 13, 11, 38, 5, 362, DateTimeKind.Local).AddTicks(4370), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 24, new DateTime(2020, 2, 7, 7, 59, 29, 939, DateTimeKind.Local).AddTicks(5459), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 47, new DateTime(2020, 6, 13, 7, 9, 55, 473, DateTimeKind.Local).AddTicks(1172), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 46, new DateTime(2020, 7, 5, 20, 37, 39, 404, DateTimeKind.Local).AddTicks(9162), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 45, new DateTime(2020, 2, 4, 21, 24, 9, 590, DateTimeKind.Local).AddTicks(7071), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 44, new DateTime(2020, 2, 20, 17, 27, 51, 595, DateTimeKind.Local).AddTicks(7443), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 43, new DateTime(2020, 5, 5, 20, 39, 53, 231, DateTimeKind.Local).AddTicks(1419), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 42, new DateTime(2020, 3, 26, 7, 44, 16, 459, DateTimeKind.Local).AddTicks(6781), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 41, new DateTime(2020, 6, 30, 18, 32, 25, 442, DateTimeKind.Local).AddTicks(7236), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 40, new DateTime(2019, 12, 3, 18, 38, 24, 906, DateTimeKind.Local).AddTicks(7954), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 39, new DateTime(2019, 11, 2, 17, 32, 42, 338, DateTimeKind.Local).AddTicks(9592), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 38, new DateTime(2020, 4, 19, 19, 23, 53, 894, DateTimeKind.Local).AddTicks(7674), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 49, new DateTime(2019, 10, 28, 18, 33, 16, 333, DateTimeKind.Local).AddTicks(2272), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 37, new DateTime(2019, 11, 26, 14, 28, 43, 352, DateTimeKind.Local).AddTicks(8401), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 35, new DateTime(2019, 11, 30, 22, 8, 59, 561, DateTimeKind.Local).AddTicks(3763), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 34, new DateTime(2020, 4, 18, 10, 29, 7, 518, DateTimeKind.Local).AddTicks(9149), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 33, new DateTime(2019, 8, 15, 7, 6, 52, 385, DateTimeKind.Local).AddTicks(9764), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 32, new DateTime(2019, 12, 31, 20, 10, 57, 571, DateTimeKind.Local).AddTicks(143), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 31, new DateTime(2020, 1, 16, 3, 40, 30, 985, DateTimeKind.Local).AddTicks(9753), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 30, new DateTime(2020, 7, 14, 23, 20, 31, 383, DateTimeKind.Local).AddTicks(6344), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 29, new DateTime(2020, 4, 5, 19, 5, 31, 692, DateTimeKind.Local).AddTicks(4820), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 28, new DateTime(2020, 1, 20, 21, 30, 21, 49, DateTimeKind.Local).AddTicks(9798), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 27, new DateTime(2019, 10, 17, 5, 57, 46, 919, DateTimeKind.Local).AddTicks(3726), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 25, new DateTime(2020, 5, 27, 23, 54, 5, 139, DateTimeKind.Local).AddTicks(9948), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 36, new DateTime(2019, 11, 6, 20, 22, 26, 410, DateTimeKind.Local).AddTicks(2943), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 100, new DateTime(2020, 5, 20, 10, 22, 55, 674, DateTimeKind.Local).AddTicks(219), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 7, 16, 2, 37, 8, 682, DateTimeKind.Local).AddTicks(1410), new DateTime(2020, 7, 15, 21, 10, 50, 380, DateTimeKind.Local).AddTicks(3602), new DateTime(2020, 7, 15, 20, 21, 35, 321, DateTimeKind.Local).AddTicks(2724), 41, "", "http://mael.eu", "tenetur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 7, 15, 22, 42, 45, 392, DateTimeKind.Local).AddTicks(5424), new DateTime(2020, 7, 16, 14, 28, 56, 480, DateTimeKind.Local).AddTicks(7377), new DateTime(2020, 7, 16, 10, 44, 50, 845, DateTimeKind.Local).AddTicks(721), 69, "", "http://jade.org", "vel" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 7, 15, 20, 46, 55, 33, DateTimeKind.Local).AddTicks(4578), new DateTime(2020, 7, 16, 1, 46, 20, 436, DateTimeKind.Local).AddTicks(4441), new DateTime(2020, 7, 15, 23, 51, 22, 663, DateTimeKind.Local).AddTicks(327), 69, "", "http://thomas.name", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 7, 16, 10, 31, 43, 935, DateTimeKind.Local).AddTicks(1680), new DateTime(2020, 7, 15, 21, 41, 36, 572, DateTimeKind.Local).AddTicks(192), new DateTime(2020, 7, 16, 12, 16, 26, 926, DateTimeKind.Local).AddTicks(6823), 69, "", "https://lina.net", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 7, 16, 8, 33, 58, 215, DateTimeKind.Local).AddTicks(344), new DateTime(2020, 7, 15, 23, 37, 57, 543, DateTimeKind.Local).AddTicks(7160), new DateTime(2020, 7, 15, 15, 44, 18, 767, DateTimeKind.Local).AddTicks(4521), 68, "", "https://nicolas.org", "sit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 7, 16, 3, 38, 39, 347, DateTimeKind.Local).AddTicks(5648), new DateTime(2020, 7, 16, 15, 11, 40, 433, DateTimeKind.Local).AddTicks(5337), new DateTime(2020, 7, 16, 13, 40, 48, 884, DateTimeKind.Local).AddTicks(3446), 68, "", "http://emilie.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 7, 16, 14, 30, 4, 880, DateTimeKind.Local).AddTicks(3268), new DateTime(2020, 7, 16, 13, 44, 6, 389, DateTimeKind.Local).AddTicks(2736), new DateTime(2020, 7, 16, 15, 18, 49, 83, DateTimeKind.Local).AddTicks(4186), 67, "", "http://lina.info", "tempora" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 7, 16, 8, 57, 31, 281, DateTimeKind.Local).AddTicks(8680), new DateTime(2020, 7, 15, 16, 36, 32, 268, DateTimeKind.Local).AddTicks(442), new DateTime(2020, 7, 16, 6, 31, 27, 785, DateTimeKind.Local).AddTicks(4040), 66, "", "http://théo.eu", "vel" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 7, 15, 23, 25, 38, 602, DateTimeKind.Local).AddTicks(4760), new DateTime(2020, 7, 16, 0, 32, 31, 994, DateTimeKind.Local).AddTicks(9123), new DateTime(2020, 7, 15, 22, 23, 37, 0, DateTimeKind.Local).AddTicks(509), 64, "", "https://nicolas.org", "labore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 7, 15, 22, 16, 28, 833, DateTimeKind.Local).AddTicks(4724), new DateTime(2020, 7, 15, 23, 27, 12, 922, DateTimeKind.Local).AddTicks(8671), new DateTime(2020, 7, 16, 6, 19, 16, 471, DateTimeKind.Local).AddTicks(6180), 64, "", "https://charlotte.org", "odit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 7, 15, 19, 26, 56, 375, DateTimeKind.Local).AddTicks(6572), new DateTime(2020, 7, 16, 7, 11, 12, 457, DateTimeKind.Local).AddTicks(4018), new DateTime(2020, 7, 16, 14, 46, 17, 830, DateTimeKind.Local).AddTicks(8142), 63, "", "http://quentin.com", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 7, 16, 0, 39, 30, 606, DateTimeKind.Local).AddTicks(7992), new DateTime(2020, 7, 15, 23, 44, 6, 197, DateTimeKind.Local).AddTicks(2704), new DateTime(2020, 7, 15, 18, 59, 3, 410, DateTimeKind.Local).AddTicks(2066), 61, "", "https://noémie.net", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 7, 16, 5, 16, 43, 544, DateTimeKind.Local).AddTicks(8137), new DateTime(2020, 7, 15, 19, 56, 33, 690, DateTimeKind.Local).AddTicks(6093), new DateTime(2020, 7, 16, 8, 5, 16, 551, DateTimeKind.Local).AddTicks(4838), 70, "", "http://anaïs.org", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 7, 16, 0, 13, 51, 399, DateTimeKind.Local).AddTicks(3346), new DateTime(2020, 7, 16, 9, 29, 8, 567, DateTimeKind.Local).AddTicks(2187), new DateTime(2020, 7, 15, 21, 21, 40, 428, DateTimeKind.Local).AddTicks(2498), 60, "", "http://julien.net", "repellendus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 7, 15, 22, 35, 45, 478, DateTimeKind.Local).AddTicks(3505), new DateTime(2020, 7, 16, 10, 37, 11, 343, DateTimeKind.Local).AddTicks(6068), new DateTime(2020, 7, 15, 23, 26, 12, 598, DateTimeKind.Local).AddTicks(2850), 57, "", "https://alexis.fr", "incidunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 7, 16, 7, 1, 53, 183, DateTimeKind.Local).AddTicks(4930), new DateTime(2020, 7, 16, 11, 31, 23, 638, DateTimeKind.Local).AddTicks(6211), new DateTime(2020, 7, 16, 11, 8, 10, 568, DateTimeKind.Local).AddTicks(9701), 56, "", "http://axel.com", "laboriosam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 7, 15, 17, 42, 28, 636, DateTimeKind.Local).AddTicks(855), new DateTime(2020, 7, 16, 8, 6, 35, 493, DateTimeKind.Local).AddTicks(4140), new DateTime(2020, 7, 16, 3, 50, 47, 21, DateTimeKind.Local).AddTicks(5186), 55, "", "http://ines.com", "tempore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 7, 16, 13, 58, 3, 994, DateTimeKind.Local).AddTicks(7974), new DateTime(2020, 7, 15, 20, 27, 5, 80, DateTimeKind.Local).AddTicks(6781), new DateTime(2020, 7, 16, 14, 48, 35, 546, DateTimeKind.Local).AddTicks(4922), 52, "", "http://louis.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 7, 16, 14, 29, 35, 187, DateTimeKind.Local).AddTicks(8238), new DateTime(2020, 7, 15, 21, 33, 23, 347, DateTimeKind.Local).AddTicks(7200), new DateTime(2020, 7, 15, 22, 4, 49, 447, DateTimeKind.Local).AddTicks(6503), 50, "", "https://nathan.info", "vel" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 7, 16, 14, 28, 23, 875, DateTimeKind.Local).AddTicks(2458), new DateTime(2020, 7, 15, 21, 38, 53, 119, DateTimeKind.Local).AddTicks(7903), new DateTime(2020, 7, 15, 21, 33, 22, 367, DateTimeKind.Local).AddTicks(6923), 50, "", "http://julie.name", "laborum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 7, 15, 21, 16, 57, 789, DateTimeKind.Local).AddTicks(7972), new DateTime(2020, 7, 16, 1, 27, 27, 341, DateTimeKind.Local).AddTicks(4790), new DateTime(2020, 7, 16, 2, 45, 42, 650, DateTimeKind.Local).AddTicks(3535), 47, "", "http://jules.com", "quae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 7, 16, 10, 32, 33, 470, DateTimeKind.Local).AddTicks(5850), new DateTime(2020, 7, 15, 15, 57, 55, 422, DateTimeKind.Local).AddTicks(8843), new DateTime(2020, 7, 16, 7, 33, 19, 745, DateTimeKind.Local).AddTicks(5669), 47, "", "https://clémence.org", "laudantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 7, 16, 5, 33, 58, 666, DateTimeKind.Local).AddTicks(3943), new DateTime(2020, 7, 16, 11, 29, 42, 549, DateTimeKind.Local).AddTicks(6691), new DateTime(2020, 7, 15, 17, 29, 53, 953, DateTimeKind.Local).AddTicks(3196), 47, "", "http://océane.fr", "repellat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 7, 16, 2, 40, 7, 117, DateTimeKind.Local).AddTicks(2910), new DateTime(2020, 7, 16, 7, 5, 26, 776, DateTimeKind.Local).AddTicks(3938), new DateTime(2020, 7, 15, 19, 26, 34, 528, DateTimeKind.Local).AddTicks(1790), 47, "", "https://hugo.eu", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 7, 16, 11, 51, 58, 535, DateTimeKind.Local).AddTicks(1537), new DateTime(2020, 7, 15, 20, 28, 46, 355, DateTimeKind.Local).AddTicks(5145), new DateTime(2020, 7, 16, 11, 10, 29, 507, DateTimeKind.Local).AddTicks(3754), 46, "", "http://romane.fr", "possimus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 7, 16, 7, 30, 14, 345, DateTimeKind.Local).AddTicks(1123), new DateTime(2020, 7, 15, 18, 54, 52, 707, DateTimeKind.Local).AddTicks(5988), new DateTime(2020, 7, 15, 21, 31, 0, 32, DateTimeKind.Local).AddTicks(7782), 58, "", "https://paul.eu", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 7, 16, 13, 11, 57, 930, DateTimeKind.Local).AddTicks(6688), new DateTime(2020, 7, 16, 14, 25, 24, 562, DateTimeKind.Local).AddTicks(5333), new DateTime(2020, 7, 16, 10, 4, 6, 695, DateTimeKind.Local).AddTicks(6029), 70, "", "https://adam.org", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 7, 15, 15, 59, 3, 787, DateTimeKind.Local).AddTicks(3780), new DateTime(2020, 7, 15, 22, 42, 29, 508, DateTimeKind.Local).AddTicks(784), new DateTime(2020, 7, 15, 16, 46, 35, 13, DateTimeKind.Local).AddTicks(3962), 70, "", "https://noa.eu", "aliquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 7, 16, 5, 11, 59, 266, DateTimeKind.Local).AddTicks(1119), new DateTime(2020, 7, 15, 20, 9, 31, 820, DateTimeKind.Local).AddTicks(6691), new DateTime(2020, 7, 16, 11, 53, 33, 369, DateTimeKind.Local).AddTicks(720), 70, "", "https://rayan.info", "recusandae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 7, 16, 7, 44, 15, 359, DateTimeKind.Local).AddTicks(2879), new DateTime(2020, 7, 15, 19, 8, 33, 951, DateTimeKind.Local).AddTicks(879), new DateTime(2020, 7, 15, 16, 54, 2, 681, DateTimeKind.Local).AddTicks(34), 94, "", "http://manon.eu", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 7, 16, 7, 13, 52, 97, DateTimeKind.Local).AddTicks(3375), new DateTime(2020, 7, 16, 7, 29, 59, 832, DateTimeKind.Local).AddTicks(617), new DateTime(2020, 7, 16, 4, 21, 36, 307, DateTimeKind.Local).AddTicks(2888), 90, "", "http://noah.eu", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 7, 16, 14, 11, 57, 739, DateTimeKind.Local).AddTicks(7953), new DateTime(2020, 7, 16, 10, 0, 58, 398, DateTimeKind.Local).AddTicks(4985), new DateTime(2020, 7, 16, 12, 55, 44, 96, DateTimeKind.Local).AddTicks(2861), 89, "", "http://juliette.name", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 7, 15, 15, 29, 25, 940, DateTimeKind.Local).AddTicks(3547), new DateTime(2020, 7, 16, 14, 6, 15, 94, DateTimeKind.Local).AddTicks(1992), new DateTime(2020, 7, 16, 7, 21, 16, 362, DateTimeKind.Local).AddTicks(4979), 89, "", "http://mélissa.com", "praesentium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 7, 16, 11, 5, 2, 127, DateTimeKind.Local).AddTicks(7883), new DateTime(2020, 7, 15, 22, 55, 3, 334, DateTimeKind.Local).AddTicks(6780), new DateTime(2020, 7, 16, 5, 1, 50, 942, DateTimeKind.Local).AddTicks(6571), 89, "", "https://pierre.name", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 7, 16, 2, 32, 12, 73, DateTimeKind.Local).AddTicks(1520), new DateTime(2020, 7, 16, 11, 37, 52, 790, DateTimeKind.Local).AddTicks(6120), new DateTime(2020, 7, 15, 21, 49, 18, 182, DateTimeKind.Local).AddTicks(1512), 88, "", "http://lisa.fr", "saepe" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 7, 15, 21, 32, 13, 768, DateTimeKind.Local).AddTicks(9110), new DateTime(2020, 7, 16, 14, 13, 28, 146, DateTimeKind.Local).AddTicks(6941), new DateTime(2020, 7, 15, 20, 18, 32, 239, DateTimeKind.Local).AddTicks(2821), 88, "", "http://eva.name", "eaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 7, 15, 19, 11, 3, 23, DateTimeKind.Local).AddTicks(5895), new DateTime(2020, 7, 16, 1, 5, 46, 861, DateTimeKind.Local).AddTicks(2435), new DateTime(2020, 7, 16, 8, 59, 38, 864, DateTimeKind.Local).AddTicks(3935), 88, "", "https://nathan.net", "harum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 7, 16, 12, 28, 36, 950, DateTimeKind.Local).AddTicks(4869), new DateTime(2020, 7, 15, 16, 12, 8, 841, DateTimeKind.Local).AddTicks(1407), new DateTime(2020, 7, 15, 22, 16, 5, 802, DateTimeKind.Local).AddTicks(5765), 86, "", "https://benjamin.info", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 7, 15, 17, 11, 45, 513, DateTimeKind.Local).AddTicks(5957), new DateTime(2020, 7, 16, 4, 7, 52, 690, DateTimeKind.Local).AddTicks(3891), new DateTime(2020, 7, 16, 9, 45, 6, 595, DateTimeKind.Local).AddTicks(6565), 85, "", "https://jeanne.com", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 7, 15, 20, 41, 45, 560, DateTimeKind.Local).AddTicks(2365), new DateTime(2020, 7, 16, 5, 58, 27, 665, DateTimeKind.Local).AddTicks(7408), new DateTime(2020, 7, 16, 11, 8, 13, 866, DateTimeKind.Local).AddTicks(9292), 84, "", "https://léa.info", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 7, 15, 17, 36, 17, 996, DateTimeKind.Local).AddTicks(5901), new DateTime(2020, 7, 15, 19, 35, 30, 771, DateTimeKind.Local).AddTicks(2755), new DateTime(2020, 7, 16, 3, 36, 24, 168, DateTimeKind.Local).AddTicks(4384), 82, "", "https://adam.info", "voluptas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 7, 16, 12, 46, 11, 849, DateTimeKind.Local).AddTicks(4184), new DateTime(2020, 7, 15, 18, 19, 14, 882, DateTimeKind.Local).AddTicks(9830), new DateTime(2020, 7, 16, 9, 36, 40, 116, DateTimeKind.Local).AddTicks(3260), 81, "", "https://mathéo.eu", "debitis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 7, 16, 0, 37, 39, 710, DateTimeKind.Local).AddTicks(3983), new DateTime(2020, 7, 16, 5, 6, 56, 586, DateTimeKind.Local).AddTicks(1184), new DateTime(2020, 7, 16, 15, 3, 20, 670, DateTimeKind.Local).AddTicks(4156), 81, "", "https://ines.fr", "maxime" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 7, 16, 0, 49, 35, 135, DateTimeKind.Local).AddTicks(9901), new DateTime(2020, 7, 16, 14, 7, 39, 209, DateTimeKind.Local).AddTicks(7819), new DateTime(2020, 7, 16, 4, 3, 33, 561, DateTimeKind.Local).AddTicks(3429), 80, "", "https://nathan.fr", "labore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 7, 16, 10, 9, 27, 304, DateTimeKind.Local).AddTicks(2979), new DateTime(2020, 7, 15, 22, 31, 19, 737, DateTimeKind.Local).AddTicks(3938), new DateTime(2020, 7, 16, 13, 48, 51, 157, DateTimeKind.Local).AddTicks(7885), 78, "", "http://lou.name", "nesciunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 7, 16, 8, 34, 45, 760, DateTimeKind.Local).AddTicks(2433), new DateTime(2020, 7, 15, 21, 55, 18, 672, DateTimeKind.Local).AddTicks(529), new DateTime(2020, 7, 16, 11, 34, 34, 669, DateTimeKind.Local).AddTicks(5837), 77, "", "http://ethan.com", "recusandae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 7, 15, 15, 42, 48, 168, DateTimeKind.Local).AddTicks(9878), new DateTime(2020, 7, 16, 4, 0, 5, 220, DateTimeKind.Local).AddTicks(329), new DateTime(2020, 7, 16, 4, 35, 18, 827, DateTimeKind.Local).AddTicks(4397), 76, "", "http://carla.com", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 7, 16, 4, 34, 18, 704, DateTimeKind.Local).AddTicks(2957), new DateTime(2020, 7, 15, 21, 14, 25, 357, DateTimeKind.Local).AddTicks(3205), new DateTime(2020, 7, 15, 22, 29, 23, 271, DateTimeKind.Local).AddTicks(8522), 76, "", "https://quentin.org", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 7, 16, 13, 9, 31, 334, DateTimeKind.Local).AddTicks(226), new DateTime(2020, 7, 15, 23, 5, 18, 321, DateTimeKind.Local).AddTicks(1967), new DateTime(2020, 7, 15, 16, 32, 28, 728, DateTimeKind.Local).AddTicks(474), 74, "", "https://manon.eu", "cupiditate" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 7, 16, 6, 44, 50, 759, DateTimeKind.Local).AddTicks(9366), new DateTime(2020, 7, 15, 17, 58, 53, 402, DateTimeKind.Local).AddTicks(1523), new DateTime(2020, 7, 16, 0, 25, 8, 744, DateTimeKind.Local).AddTicks(6954), 74, "", "http://sacha.net", "harum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 7, 15, 21, 33, 17, 129, DateTimeKind.Local).AddTicks(1003), new DateTime(2020, 7, 16, 8, 37, 2, 432, DateTimeKind.Local).AddTicks(1959), new DateTime(2020, 7, 16, 15, 0, 44, 553, DateTimeKind.Local).AddTicks(6830), 73, "", "https://noa.org", "velit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 7, 16, 15, 3, 43, 942, DateTimeKind.Local).AddTicks(7584), new DateTime(2020, 7, 16, 11, 22, 9, 793, DateTimeKind.Local).AddTicks(145), new DateTime(2020, 7, 16, 8, 18, 9, 181, DateTimeKind.Local).AddTicks(6819), 72, "", "https://maeva.info", "sunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 7, 16, 3, 38, 51, 764, DateTimeKind.Local).AddTicks(8112), new DateTime(2020, 7, 16, 6, 18, 47, 990, DateTimeKind.Local).AddTicks(2957), new DateTime(2020, 7, 16, 4, 37, 13, 939, DateTimeKind.Local).AddTicks(4615), 71, "", "https://alexandre.org", "a" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 7, 16, 0, 41, 37, 625, DateTimeKind.Local).AddTicks(2060), new DateTime(2020, 7, 15, 17, 41, 25, 908, DateTimeKind.Local).AddTicks(723), new DateTime(2020, 7, 15, 15, 29, 49, 478, DateTimeKind.Local).AddTicks(1983), 71, "", "https://kylian.fr", "corrupti" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 7, 16, 5, 35, 44, 713, DateTimeKind.Local).AddTicks(2661), new DateTime(2020, 7, 15, 16, 45, 58, 669, DateTimeKind.Local).AddTicks(8965), new DateTime(2020, 7, 16, 9, 1, 5, 967, DateTimeKind.Local).AddTicks(1020), 45, "", "http://romane.info", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 7, 16, 0, 29, 25, 799, DateTimeKind.Local).AddTicks(4635), new DateTime(2020, 7, 16, 0, 19, 53, 580, DateTimeKind.Local).AddTicks(2010), new DateTime(2020, 7, 16, 12, 16, 18, 337, DateTimeKind.Local).AddTicks(128), 45, "", "http://elisa.name", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 7, 16, 10, 14, 25, 313, DateTimeKind.Local).AddTicks(5721), new DateTime(2020, 7, 16, 12, 53, 59, 35, DateTimeKind.Local).AddTicks(548), new DateTime(2020, 7, 16, 14, 28, 35, 957, DateTimeKind.Local).AddTicks(9174), 100, "", "http://manon.eu", "vel" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 7, 16, 4, 45, 31, 785, DateTimeKind.Local).AddTicks(3673), new DateTime(2020, 7, 15, 22, 51, 32, 82, DateTimeKind.Local).AddTicks(531), new DateTime(2020, 7, 15, 16, 43, 5, 842, DateTimeKind.Local).AddTicks(8703), 39, "", "http://evan.org", "a" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 7, 16, 7, 40, 6, 729, DateTimeKind.Local).AddTicks(4389), new DateTime(2020, 7, 15, 19, 32, 3, 98, DateTimeKind.Local).AddTicks(3270), new DateTime(2020, 7, 15, 20, 55, 57, 428, DateTimeKind.Local).AddTicks(8188), 23, "", "https://lou.com", "sint" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 7, 15, 21, 28, 24, 323, DateTimeKind.Local).AddTicks(6769), new DateTime(2020, 7, 15, 19, 18, 9, 926, DateTimeKind.Local).AddTicks(2287), new DateTime(2020, 7, 15, 23, 50, 3, 43, DateTimeKind.Local).AddTicks(2658), 20, "", "http://paul.name", "reiciendis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 7, 15, 17, 37, 23, 144, DateTimeKind.Local).AddTicks(9966), new DateTime(2020, 7, 16, 11, 6, 58, 489, DateTimeKind.Local).AddTicks(3032), new DateTime(2020, 7, 15, 17, 23, 53, 739, DateTimeKind.Local).AddTicks(3297), 16, "", "https://lucie.org", "sunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 7, 16, 2, 41, 48, 738, DateTimeKind.Local).AddTicks(6597), new DateTime(2020, 7, 15, 22, 51, 38, 412, DateTimeKind.Local).AddTicks(9988), new DateTime(2020, 7, 15, 21, 18, 43, 859, DateTimeKind.Local).AddTicks(5282), 16, "", "https://elisa.info", "ea" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 7, 16, 7, 7, 58, 774, DateTimeKind.Local).AddTicks(828), new DateTime(2020, 7, 16, 0, 46, 40, 38, DateTimeKind.Local).AddTicks(7439), new DateTime(2020, 7, 16, 3, 22, 49, 280, DateTimeKind.Local).AddTicks(7885), 96, "", "https://marie.com", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 7, 15, 19, 5, 36, 444, DateTimeKind.Local).AddTicks(6154), new DateTime(2020, 7, 16, 1, 9, 52, 778, DateTimeKind.Local).AddTicks(6213), new DateTime(2020, 7, 16, 7, 38, 22, 143, DateTimeKind.Local).AddTicks(2498), 15, "", "http://mathéo.com", "libero" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 7, 16, 9, 50, 42, 583, DateTimeKind.Local).AddTicks(5750), new DateTime(2020, 7, 16, 8, 14, 56, 428, DateTimeKind.Local).AddTicks(3395), new DateTime(2020, 7, 15, 15, 22, 37, 58, DateTimeKind.Local).AddTicks(6306), 15, "", "http://juliette.info", "placeat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 7, 15, 15, 45, 47, 133, DateTimeKind.Local).AddTicks(1831), new DateTime(2020, 7, 16, 2, 23, 50, 897, DateTimeKind.Local).AddTicks(3451), new DateTime(2020, 7, 15, 17, 50, 34, 165, DateTimeKind.Local).AddTicks(8833), 14, "", "http://mattéo.com", "dolore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 7, 16, 4, 59, 6, 750, DateTimeKind.Local).AddTicks(9968), new DateTime(2020, 7, 15, 22, 3, 35, 742, DateTimeKind.Local).AddTicks(7007), new DateTime(2020, 7, 16, 8, 19, 49, 514, DateTimeKind.Local).AddTicks(3697), 24, "", "http://océane.net", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 7, 15, 15, 29, 32, 960, DateTimeKind.Local).AddTicks(4827), new DateTime(2020, 7, 15, 17, 2, 38, 419, DateTimeKind.Local).AddTicks(9510), new DateTime(2020, 7, 15, 15, 58, 30, 180, DateTimeKind.Local).AddTicks(8350), 13, "", "http://evan.net", "nostrum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 7, 16, 11, 19, 12, 204, DateTimeKind.Local).AddTicks(7503), new DateTime(2020, 7, 16, 4, 40, 21, 706, DateTimeKind.Local).AddTicks(3770), new DateTime(2020, 7, 16, 6, 17, 55, 252, DateTimeKind.Local).AddTicks(1803), 11, "", "https://julie.name", "aliquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 7, 15, 21, 2, 13, 300, DateTimeKind.Local).AddTicks(1970), new DateTime(2020, 7, 16, 5, 24, 55, 639, DateTimeKind.Local).AddTicks(3658), new DateTime(2020, 7, 15, 17, 20, 3, 388, DateTimeKind.Local).AddTicks(1050), 11, "", "http://alexandre.fr", "quo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 7, 16, 4, 56, 15, 68, DateTimeKind.Local).AddTicks(3305), new DateTime(2020, 7, 16, 8, 13, 30, 775, DateTimeKind.Local).AddTicks(5736), new DateTime(2020, 7, 16, 5, 14, 42, 326, DateTimeKind.Local).AddTicks(1368), 10, "", "http://elisa.com", "fugit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 7, 16, 8, 19, 47, 350, DateTimeKind.Local).AddTicks(4679), new DateTime(2020, 7, 16, 12, 26, 24, 135, DateTimeKind.Local).AddTicks(7975), new DateTime(2020, 7, 16, 8, 15, 35, 828, DateTimeKind.Local).AddTicks(356), 9, "", "https://julie.net", "saepe" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 7, 15, 21, 39, 2, 989, DateTimeKind.Local).AddTicks(280), new DateTime(2020, 7, 16, 11, 0, 46, 484, DateTimeKind.Local).AddTicks(3214), new DateTime(2020, 7, 15, 18, 54, 57, 989, DateTimeKind.Local).AddTicks(4778), 8, "", "https://manon.fr", "distinctio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 7, 16, 13, 22, 6, 381, DateTimeKind.Local).AddTicks(7245), new DateTime(2020, 7, 15, 22, 20, 34, 541, DateTimeKind.Local).AddTicks(8845), new DateTime(2020, 7, 16, 4, 45, 1, 909, DateTimeKind.Local).AddTicks(5554), 5, "", "http://nicolas.eu", "sed" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 7, 16, 0, 37, 36, 480, DateTimeKind.Local).AddTicks(1091), new DateTime(2020, 7, 16, 4, 15, 54, 816, DateTimeKind.Local).AddTicks(706), new DateTime(2020, 7, 15, 22, 0, 24, 898, DateTimeKind.Local).AddTicks(6747), 3, "", "http://elisa.fr", "reprehenderit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 7, 16, 1, 59, 10, 21, DateTimeKind.Local).AddTicks(3280), new DateTime(2020, 7, 15, 19, 11, 27, 604, DateTimeKind.Local).AddTicks(9785), new DateTime(2020, 7, 15, 20, 15, 11, 291, DateTimeKind.Local).AddTicks(6641), 1, "", "https://juliette.com", "doloribus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 7, 16, 0, 35, 15, 252, DateTimeKind.Local).AddTicks(8594), new DateTime(2020, 7, 16, 8, 43, 14, 115, DateTimeKind.Local).AddTicks(2266), new DateTime(2020, 7, 16, 3, 46, 35, 478, DateTimeKind.Local).AddTicks(643), 12, "", "http://antoine.name", "quod" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 7, 16, 3, 23, 36, 200, DateTimeKind.Local).AddTicks(972), new DateTime(2020, 7, 15, 21, 31, 27, 739, DateTimeKind.Local).AddTicks(5543), new DateTime(2020, 7, 16, 5, 58, 24, 328, DateTimeKind.Local).AddTicks(381), 24, "", "http://lisa.fr", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 7, 16, 7, 34, 40, 924, DateTimeKind.Local).AddTicks(4318), new DateTime(2020, 7, 16, 4, 48, 39, 638, DateTimeKind.Local).AddTicks(8085), new DateTime(2020, 7, 15, 16, 0, 17, 809, DateTimeKind.Local).AddTicks(235), 15, "", "https://camille.org", "reprehenderit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 7, 15, 16, 22, 31, 434, DateTimeKind.Local).AddTicks(8756), new DateTime(2020, 7, 16, 5, 21, 7, 993, DateTimeKind.Local).AddTicks(2936), new DateTime(2020, 7, 16, 9, 51, 34, 418, DateTimeKind.Local).AddTicks(7469), 25, "", "https://chloé.eu", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 7, 15, 22, 10, 2, 54, DateTimeKind.Local).AddTicks(4927), new DateTime(2020, 7, 16, 3, 51, 47, 471, DateTimeKind.Local).AddTicks(3435), new DateTime(2020, 7, 15, 19, 43, 24, 156, DateTimeKind.Local).AddTicks(7267), 37, "", "https://lena.eu", "voluptatum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 7, 16, 6, 7, 1, 667, DateTimeKind.Local).AddTicks(3993), new DateTime(2020, 7, 16, 5, 29, 20, 663, DateTimeKind.Local).AddTicks(6098), new DateTime(2020, 7, 15, 19, 19, 58, 208, DateTimeKind.Local).AddTicks(4400), 37, "", "http://mélissa.info", "voluptates" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 7, 15, 19, 48, 46, 850, DateTimeKind.Local).AddTicks(5122), new DateTime(2020, 7, 15, 17, 1, 2, 521, DateTimeKind.Local).AddTicks(4346), new DateTime(2020, 7, 16, 9, 33, 34, 373, DateTimeKind.Local).AddTicks(4659), 24, "", "https://axel.info", "ea" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 7, 16, 1, 16, 46, 146, DateTimeKind.Local).AddTicks(589), new DateTime(2020, 7, 16, 8, 53, 35, 727, DateTimeKind.Local).AddTicks(3149), new DateTime(2020, 7, 15, 16, 36, 29, 264, DateTimeKind.Local).AddTicks(7945), 36, "", "http://pauline.name", "reprehenderit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 7, 16, 0, 23, 15, 675, DateTimeKind.Local).AddTicks(4173), new DateTime(2020, 7, 15, 20, 18, 56, 185, DateTimeKind.Local).AddTicks(8244), new DateTime(2020, 7, 15, 22, 31, 58, 545, DateTimeKind.Local).AddTicks(9921), 36, "", "https://sarah.name", "debitis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 7, 16, 4, 6, 42, 785, DateTimeKind.Local).AddTicks(4372), new DateTime(2020, 7, 16, 4, 33, 49, 899, DateTimeKind.Local).AddTicks(6468), new DateTime(2020, 7, 16, 5, 7, 33, 206, DateTimeKind.Local).AddTicks(5980), 36, "", "http://alexis.fr", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 7, 15, 17, 21, 36, 894, DateTimeKind.Local).AddTicks(2149), new DateTime(2020, 7, 15, 21, 9, 24, 153, DateTimeKind.Local).AddTicks(5039), new DateTime(2020, 7, 16, 13, 38, 15, 299, DateTimeKind.Local).AddTicks(8321), 35, "", "https://hugo.org", "quidem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 7, 15, 23, 37, 45, 712, DateTimeKind.Local).AddTicks(8122), new DateTime(2020, 7, 16, 0, 31, 35, 782, DateTimeKind.Local).AddTicks(4398), new DateTime(2020, 7, 15, 19, 55, 12, 438, DateTimeKind.Local).AddTicks(5052), 35, "", "http://maxime.eu", "inventore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 7, 15, 15, 39, 18, 833, DateTimeKind.Local).AddTicks(152), new DateTime(2020, 7, 16, 12, 45, 5, 63, DateTimeKind.Local).AddTicks(1992), new DateTime(2020, 7, 16, 1, 27, 6, 344, DateTimeKind.Local).AddTicks(4159), 35, "", "https://mattéo.org", "vel" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 7, 15, 16, 25, 32, 988, DateTimeKind.Local).AddTicks(5964), new DateTime(2020, 7, 16, 3, 37, 21, 147, DateTimeKind.Local).AddTicks(9768), new DateTime(2020, 7, 16, 12, 51, 51, 971, DateTimeKind.Local).AddTicks(1514), 37, "", "https://mattéo.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 7, 16, 3, 19, 28, 778, DateTimeKind.Local).AddTicks(1511), new DateTime(2020, 7, 15, 15, 41, 41, 870, DateTimeKind.Local).AddTicks(9218), new DateTime(2020, 7, 16, 4, 53, 49, 634, DateTimeKind.Local).AddTicks(5155), 34, "", "http://noa.com", "sapiente" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 7, 15, 23, 24, 5, 589, DateTimeKind.Local).AddTicks(4775), new DateTime(2020, 7, 16, 4, 36, 58, 35, DateTimeKind.Local).AddTicks(5220), new DateTime(2020, 7, 16, 13, 20, 44, 131, DateTimeKind.Local).AddTicks(6667), 33, "", "https://kylian.net", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 7, 15, 22, 8, 7, 576, DateTimeKind.Local).AddTicks(3535), new DateTime(2020, 7, 16, 12, 23, 49, 388, DateTimeKind.Local).AddTicks(3022), new DateTime(2020, 7, 16, 7, 35, 12, 52, DateTimeKind.Local).AddTicks(9753), 28, "", "https://benjamin.org", "voluptates" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 7, 15, 22, 2, 55, 301, DateTimeKind.Local).AddTicks(8322), new DateTime(2020, 7, 15, 15, 45, 35, 894, DateTimeKind.Local).AddTicks(9880), new DateTime(2020, 7, 16, 9, 58, 3, 412, DateTimeKind.Local).AddTicks(7511), 27, "", "http://mael.name", "quis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 7, 15, 21, 5, 30, 571, DateTimeKind.Local).AddTicks(3643), new DateTime(2020, 7, 15, 18, 10, 58, 870, DateTimeKind.Local).AddTicks(4446), new DateTime(2020, 7, 15, 18, 33, 0, 106, DateTimeKind.Local).AddTicks(4096), 27, "", "http://maxence.net", "dicta" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 7, 15, 22, 59, 39, 77, DateTimeKind.Local).AddTicks(8208), new DateTime(2020, 7, 16, 10, 9, 3, 165, DateTimeKind.Local).AddTicks(3192), new DateTime(2020, 7, 16, 2, 25, 6, 909, DateTimeKind.Local).AddTicks(100), 27, "", "https://pierre.name", "praesentium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 7, 16, 12, 39, 39, 763, DateTimeKind.Local).AddTicks(9927), new DateTime(2020, 7, 16, 0, 22, 25, 110, DateTimeKind.Local).AddTicks(395), new DateTime(2020, 7, 16, 2, 56, 38, 135, DateTimeKind.Local).AddTicks(920), 26, "", "http://mattéo.com", "error" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 7, 15, 19, 44, 31, 184, DateTimeKind.Local).AddTicks(1208), new DateTime(2020, 7, 15, 18, 5, 46, 368, DateTimeKind.Local).AddTicks(2590), new DateTime(2020, 7, 15, 17, 50, 51, 685, DateTimeKind.Local).AddTicks(816), 26, "", "http://manon.org", "repellat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 7, 16, 4, 58, 42, 954, DateTimeKind.Local).AddTicks(2578), new DateTime(2020, 7, 15, 23, 37, 35, 722, DateTimeKind.Local).AddTicks(9284), new DateTime(2020, 7, 16, 9, 25, 27, 175, DateTimeKind.Local).AddTicks(4454), 26, "", "http://axel.name", "tempore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 7, 15, 21, 4, 22, 799, DateTimeKind.Local).AddTicks(2061), new DateTime(2020, 7, 16, 12, 23, 58, 229, DateTimeKind.Local).AddTicks(6304), new DateTime(2020, 7, 16, 3, 13, 55, 742, DateTimeKind.Local).AddTicks(8817), 34, "", "https://juliette.org", "nam" });

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
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 3, "3.4.8.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 72, 4, null, 4, 2, 1, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 62, "0.5.0.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 60, 1, null, null, 4, 10, 9, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 56, "3.1.6.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 65, 7, null, null, 4, 10, 4, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 54, "3.6.5.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 6, null, 4, 1, 10, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 52, "7.0.3.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 85, 3, 8, null, 1, 10, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 51, "9.8.3.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 1, null, 6, 1, 10, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 41, "6.9.8.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 6, null, null, 1, 10, 4, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 28, "3.6.2.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 96, 1, 6, null, 1, 10, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 6, "8.8.9.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 6, null, 2, 4, 10, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 4, "1.7.7.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 0, 4, 2, null, 4, 10, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 1, "5.9.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 80, 7, 1, null, 1, 10, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 100, "6.6.9.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 3, 8, null, 4, 9, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 93, "1.2.2.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 3, null, 4, 4, 9, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 80, "7.5.3.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 60, 6, null, null, 3, 9, 9, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 61, "3.6.1.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 23, 5, 9, null, 3, 9, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 57, "0.5.1.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 2, null, 4, 1, 9, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 55, "6.0.0.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 74, 6, 5, null, 3, 9, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 48, "9.0.1.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 80, 7, null, 5, 1, 9, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 40, "0.9.5.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 63, 7, 3, null, 2, 9, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 34, "0.4.8.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 9, 7, 4, null, 4, 9, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 29, "5.1.4.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 50, 7, null, null, 2, 9, 6, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 11, "8.3.9.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 5, null, null, 3, 9, 9, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 75, "0.8.2.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 81, 1, null, 1, 2, 10, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 77, "8.3.2.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 61, 5, null, null, 2, 10, 6, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 94, "1.4.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 45, 7, 2, null, 4, 10, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 13, "1.6.9.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 46, 1, 7, null, 3, 4, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 89, "1.0.1.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 79, 5, null, null, 3, 6, 3, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 85, "9.6.3.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 2, 8, null, 2, 6, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 79, "6.1.1.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 5, 4, null, 4, 6, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 70, "4.7.3.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 5, 5, null, 2, 6, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 47, "7.2.7.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 64, 7, null, null, 1, 6, 1, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 37, "5.4.7.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 31, 1, 7, null, 4, 6, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 36, "1.9.1.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 5, 4, null, 1, 4, 6, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 12, "7.4.9.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 16, 7, null, 5, 4, 6, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 97, "2.3.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 6, 4, null, 4, 5, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 86, "0.1.5.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 23, 3, null, null, 3, 5, 5, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 9, "7.0.7.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 4, null, 5, 2, 9, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 81, "2.4.9.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 70, 6, null, 2, 2, 5, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 25, "2.5.7.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 7, 2, null, 2, 5, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 15, "5.0.1.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 85, 4, null, 6, 3, 5, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 83, "5.4.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 31, 7, null, null, 4, 4, 9, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 78, "9.6.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 76, 6, null, 4, 1, 4, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 76, "5.1.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 17, 2, 9, null, 1, 4, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 65, "7.0.9.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 15, 2, null, null, 4, 4, 6, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 60, "1.4.5.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 82, 5, null, 1, 3, 4, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 35, "8.8.0.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 42, 5, null, null, 3, 4, 10, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 22, "6.5.0.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 72, 4, 2, null, 1, 4, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 20, "8.1.0.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 3, null, null, 2, 4, 5, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 71, "6.0.8.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 16, 1, null, null, 3, 5, 5, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 8, "5.0.8.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 51, 1, null, null, 2, 9, 9, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 95, "5.4.4.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 71, 2, null, null, 4, 6, 3, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 87, "7.5.4.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 74, 6, null, 1, 2, 8, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 44, "8.7.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 5, null, null, 2, 3, 4, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 31, "5.4.6.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 5, 1, 5, null, 4, 3, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 5, "9.7.7.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 5, null, null, 1, 3, 9, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 99, "0.4.8.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 29, 7, null, 4, 2, 2, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 98, "5.6.1.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 4, null, null, 3, 2, 2, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 74, "0.3.7.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 34, 3, null, null, 3, 2, 9, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 66, "9.7.6.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 4, null, 1, 4, 2, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 59, "1.1.6.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 32, 5, null, null, 3, 2, 1, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 27, "7.5.4.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 48, 3, null, 5, 3, 2, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 21, "4.2.0.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 91, 3, null, 6, 2, 2, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 18, "8.6.8.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 47, 1, null, 3, 4, 2, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 16, "8.8.9.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 2, 6, null, 4, 2, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 91, "0.1.7.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 76, 2, 5, null, 3, 1, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 73, "0.6.6.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 5, 5, null, 2, 1, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 64, "9.8.1.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 28, 4, 6, null, 3, 1, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 58, "0.7.1.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 4, 5, null, 1, 1, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 46, "4.6.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 90, 6, 2, null, 3, 1, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 39, "9.6.9.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 5, null, 2, 4, 1, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 14, "1.5.0.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 6, null, null, 1, 1, 2, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 10, "1.6.2.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 79, 2, 9, null, 4, 1, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 2, "7.1.3.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 9, 6, null, null, 4, 9, 2, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 45, "7.2.9.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 73, 1, null, 1, 4, 3, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 49, "7.1.6.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 52, 1, 1, null, 2, 3, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 42, "4.2.6.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 5, null, 5, 1, 2, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 63, "4.9.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 29, 3, null, 6, 3, 3, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 50, "5.5.7.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 35, 4, null, null, 3, 3, 5, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 72, "2.8.8.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 1, null, 6, 1, 8, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 53, "5.1.3.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 13, 2, null, null, 3, 8, 7, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 38, "7.2.9.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 58, 6, null, null, 4, 8, 10, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 33, "6.5.3.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 1, null, 1, 1, 8, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 32, "2.3.9.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 6, null, null, 3, 8, 9, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 30, "8.0.5.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 7, null, 3, 2, 8, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 24, "8.7.5.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 57, 3, null, 6, 2, 8, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 17, "4.2.4.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 84, 6, null, null, 4, 8, 6, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 7, "4.3.3.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 5, 3, 8, null, 4, 8, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 92, "8.8.9.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 49, 3, null, null, 3, 7, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 26, "2.5.3.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 5, null, null, 4, 8, 9, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 84, "0.5.6.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 7, null, 4, 3, 8, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 69, "0.4.1.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 100, 2, null, 3, 3, 7, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 68, "0.8.1.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 4, null, null, 3, 3, 3, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 82, "7.8.0.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 40, 2, 9, null, 2, 3, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 88, "2.5.4.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 3, 6, null, 2, 3, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 90, "6.7.6.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 7, null, 1, 4, 3, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 67, "4.4.5.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 7, 1, null, 2, 3, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 19, "2.9.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 10, 3, 8, null, 4, 7, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 23, "6.0.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 4, null, null, 2, 7, 1, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 43, "1.0.9.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 42, 1, 2, null, 4, 7, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 96, "9.5.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 7, null, 1, 2, 3, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "recusandae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 92, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "velit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 90, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "molestiae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 80, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "repudiandae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 83, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "ad", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 83, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "quidem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 19, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "quisquam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 19, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "mollitia", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 8, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "recusandae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 92, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "vitae", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 92, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "in", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "nesciunt", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 77, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "ut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 77, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "reiciendis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 49, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "odio", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 49, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "quod", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 99, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "omnis", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 59, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "exercitationem", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 52, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "libero", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 52, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 100, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "dolorem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 5, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "possimus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 18, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "optio", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 3, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "illo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 24, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "ut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "ipsam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 34, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "ut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 89, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "rerum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 89, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "voluptas", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 61, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "repellat", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 25, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "nulla", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 68, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "voluptates", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 68, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "tempore", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 39, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "minima", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 22, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "delectus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 22, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "numquam", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 3, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "odio", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 22, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "laudantium", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 55, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "velit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 55, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "dolor", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 84, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "eos", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 4, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "consequuntur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 4, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "sapiente", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 4, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "accusantium", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 71, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "deleniti", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 71, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "laboriosam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "fuga", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "laudantium", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 10, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "sequi", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 86, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "voluptatum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 38, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "ab", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 93, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "nostrum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 35, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "officia", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 94, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "placeat", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 43, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "dignissimos", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 12, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "porro", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 42, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "aspernatur", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 88, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "sunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 53, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "nemo", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 87, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "quo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 87, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "occaecati", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 87, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "rerum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 37, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "porro", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 82, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "modi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 32, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "excepturi", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 32, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "possimus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 74, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "non", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 74, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "maxime", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 74, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "est", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 15, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "autem", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 15, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "magni", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 54, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "aliquam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 24, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "aut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 65, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "id", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 65, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "sunt", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 81, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "facilis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 81, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "qui", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 93, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 16, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "dignissimos", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 16, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "praesentium", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 46, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "voluptates", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 21, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "nesciunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 21, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "totam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 7, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "corrupti", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 70, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "quos", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 70, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "cumque", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 96, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "dolores", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 86, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "doloremque", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 96, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "est", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 60, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "ullam", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 41, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "itaque", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 73, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "sunt", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 29, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "hic", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 26, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "nemo", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 26, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "voluptatem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 9, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "ut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 48, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 48, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "consequatur", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 81, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "dolores", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 60, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "reprehenderit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 33, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/rubber/handmade-metal-car/calculating", 3, 46 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/thx/refined/usability", 5, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/hill/investor/forward", 4, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/somoni/cape-verde-escudo", 3, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/embrace/deposit/markets", 7, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/sdd/ivory/viaduct", 7, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/knolls/asynchronous/delaware", 3, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/red", 3, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/gateway/unbranded-rubber-towels", 6, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/rest/parse", 6, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/denar", 6, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/central/silver", 7, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/refined-metal-fish", 4, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/upgradable/cambridgeshire", 6, 99 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/course", 2, 99 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/paradigm/navigating/triple-buffered", 6, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/backing-up", 2, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/css/dynamic", 2, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/ssl/alabama", 7, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/human/transmit/gorgeous", 6, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/outdoors/orchestrator", 2, 82 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/sri-lanka-rupee/assistant/assistant", 5, 82 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/overriding/247/practical", 3, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/gold", 1, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/iowa", 7, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/incredible-concrete-mouse", 5, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/national/dynamic/parsing", 2, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/solutions/reintermediate", 6, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/payment/programming", 4, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/gorgeous-fresh-shoes/groves/operative", 2, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/payment/conglomeration", 7, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/music-toys--computers", 4, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/seamless", 4, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/slovakia-slovak-republic/solomon-islands-dollar/magenta", 2, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/deposit", 1, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/incredible-granite-fish", 2, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/borders/buckinghamshire", 5, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/intelligent-soft-cheese/small/ohio", 7, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/polarised", 7, 33 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/pixel", 7, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/transition/circles", 3, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/green", 5, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/wireless", 1, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/payment", 1, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/compress", 2, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/com/solutions", 5, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/syrian-pound", 5, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/mission", 5, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/aggregate/tasty-rubber-hat/vortals", 7, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/practical/re-contextualized/berkshire", 2, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/emulation/optical", 6, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/swiss-franc/program/indexing", 7, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/connecting", 3, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/berkshire", 3, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/small-cotton-pizza/operations", 2, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/buckinghamshire/road", 1, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/deposit", 5, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/springs", 7, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/michigan", 5, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/clicks-and-mortar/compress/new-jersey", 7, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/automotive-tools--music/connecticut/research", 4, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/savings-account/buckinghamshire/monitor", 2, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/transmitting", 4, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/e-enable/grid-enabled", 1, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/css", 5, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/future-proofed/games-sports--beauty", 2, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/calculating/prairie/hacking", 4, 51 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/concrete/road", 3, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/extend/input/policy", 4, 87 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/beauty--sports/cyan", 3, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/uniform", 6, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/hdd", 3, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/divide/implement", 7, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/realigned", 7, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/generate/re-engineered", 1, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/outdoors--health/personal-loan-account", 2, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/granite/supervisor/azure", 4, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/ridges", 1, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/ergonomic-steel-chicken/deliverables", 5, 100 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/virtual/online", 2, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/avon/solution-oriented/olive", 6, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/rubber", 3, 6 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/landing/georgia/olive", 7, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/scsi", 7, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/users", 2, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/quantifying/green", 2, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/montana/michigan", 7, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/deposit/small-soft-salad", 7, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/copy/one-to-one", 6, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/fantastic", 6, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/macedonia/infrastructure", 3, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/invoice/transmitting", 3, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/ergonomic-wooden-shirt/intelligent/action-items", 7, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/seize/michigan", 5, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/capacitor/deposit", 2, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/checking-account/rustic-frozen-keyboard/multi-tiered", 6, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/rustic/forecast/auto-loan-account", 6, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/overriding", 2, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/multi-byte/research/unbranded-concrete-bike", 4, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/licensed-fresh-towels/black", 2, 46 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 6, new DateTime(2020, 7, 1, 19, 34, 32, 854, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 2, new DateTime(2020, 1, 31, 10, 10, 14, 115, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 5, new DateTime(2020, 2, 15, 1, 52, 33, 714, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 1, new DateTime(2019, 8, 15, 15, 41, 11, 46, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 5, new DateTime(2020, 3, 14, 12, 20, 37, 986, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 1, new DateTime(2019, 7, 28, 14, 25, 32, 772, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 2, new DateTime(2020, 3, 1, 17, 52, 46, 369, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 3, new DateTime(2020, 2, 16, 7, 4, 17, 551, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 1, new DateTime(2019, 10, 3, 0, 27, 22, 316, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 2, new DateTime(2020, 6, 29, 16, 44, 38, 514, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 2, new DateTime(2019, 10, 7, 15, 4, 1, 618, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 2, new DateTime(2020, 4, 10, 2, 11, 30, 683, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 4, new DateTime(2019, 9, 17, 21, 29, 37, 614, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 5, new DateTime(2019, 8, 4, 6, 38, 2, 59, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 3, new DateTime(2019, 11, 22, 15, 15, 12, 102, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 3, new DateTime(2020, 2, 8, 12, 22, 35, 921, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 6, new DateTime(2019, 7, 28, 23, 48, 44, 630, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 4, new DateTime(2019, 12, 7, 13, 13, 2, 661, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 5, new DateTime(2019, 10, 13, 3, 49, 43, 384, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 1, new DateTime(2020, 6, 7, 18, 25, 16, 215, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 1, new DateTime(2020, 6, 1, 1, 58, 57, 818, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 5, new DateTime(2020, 3, 7, 10, 22, 42, 166, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 1, new DateTime(2020, 6, 7, 22, 4, 47, 505, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 3, new DateTime(2019, 8, 19, 8, 24, 23, 105, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 5, new DateTime(2020, 5, 7, 8, 45, 43, 612, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 3, new DateTime(2020, 5, 7, 22, 54, 29, 788, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 2, new DateTime(2020, 2, 23, 2, 28, 42, 89, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 4, new DateTime(2019, 11, 16, 13, 9, 37, 417, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 4, new DateTime(2020, 3, 5, 19, 25, 29, 441, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 4, new DateTime(2020, 5, 31, 23, 54, 36, 97, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 4, new DateTime(2019, 8, 18, 17, 48, 4, 851, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 3, new DateTime(2020, 3, 13, 20, 50, 5, 22, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 2, new DateTime(2020, 4, 3, 12, 23, 11, 554, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 6, new DateTime(2019, 7, 27, 21, 36, 37, 922, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 4, new DateTime(2020, 2, 11, 14, 28, 7, 927, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 5, new DateTime(2019, 10, 15, 11, 21, 24, 579, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 3, new DateTime(2020, 4, 2, 21, 34, 56, 838, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 4, new DateTime(2020, 7, 4, 21, 20, 36, 699, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 2, new DateTime(2020, 5, 8, 5, 13, 55, 11, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 3, new DateTime(2019, 9, 11, 22, 24, 15, 412, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 1, new DateTime(2019, 8, 29, 6, 12, 29, 853, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 5, new DateTime(2019, 9, 29, 1, 25, 58, 572, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 2, new DateTime(2019, 9, 6, 0, 53, 25, 524, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 6, new DateTime(2019, 7, 30, 11, 45, 46, 402, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 6, new DateTime(2019, 11, 1, 8, 32, 52, 164, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 6, new DateTime(2019, 9, 23, 0, 13, 7, 372, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 3, new DateTime(2020, 2, 8, 21, 13, 45, 977, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 3, new DateTime(2020, 5, 3, 16, 31, 51, 303, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 2, new DateTime(2019, 10, 29, 3, 50, 22, 266, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 5, new DateTime(2019, 11, 5, 19, 21, 57, 347, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 6, new DateTime(2020, 1, 16, 18, 38, 29, 338, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 2, new DateTime(2019, 8, 12, 11, 28, 20, 527, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 2, new DateTime(2019, 11, 16, 17, 8, 42, 978, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 5, new DateTime(2019, 7, 19, 13, 9, 17, 994, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 3, new DateTime(2020, 2, 9, 20, 23, 17, 998, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 4, new DateTime(2019, 8, 20, 14, 8, 30, 346, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 3, new DateTime(2020, 3, 25, 16, 15, 6, 59, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 6, new DateTime(2019, 9, 18, 5, 16, 29, 722, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 1, new DateTime(2020, 2, 8, 8, 30, 8, 136, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 4, new DateTime(2020, 5, 31, 17, 24, 39, 407, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 3, new DateTime(2019, 10, 16, 22, 53, 18, 978, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 3, new DateTime(2020, 5, 6, 2, 48, 34, 942, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 6, new DateTime(2019, 12, 2, 15, 9, 13, 591, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 2, new DateTime(2019, 11, 9, 16, 9, 2, 8, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 1, new DateTime(2020, 4, 9, 18, 26, 55, 108, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 1, new DateTime(2019, 9, 24, 14, 17, 23, 682, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 4, new DateTime(2020, 5, 27, 6, 56, 20, 693, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 4, new DateTime(2019, 8, 23, 20, 8, 2, 951, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 5, new DateTime(2020, 1, 4, 5, 38, 17, 948, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 3, new DateTime(2020, 1, 10, 5, 50, 17, 163, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 2, new DateTime(2020, 5, 27, 2, 34, 12, 968, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 1, new DateTime(2019, 8, 1, 22, 23, 39, 217, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 4, new DateTime(2019, 9, 24, 23, 47, 35, 182, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 4, new DateTime(2019, 10, 24, 16, 2, 34, 961, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 1, new DateTime(2019, 10, 25, 3, 45, 2, 73, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 2, new DateTime(2020, 6, 28, 18, 47, 50, 815, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 5, new DateTime(2020, 6, 2, 16, 2, 32, 602, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 2, new DateTime(2020, 5, 19, 8, 45, 53, 597, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 1, new DateTime(2019, 7, 25, 14, 57, 39, 934, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 5, new DateTime(2020, 5, 1, 13, 26, 34, 275, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 1, new DateTime(2020, 6, 6, 12, 7, 52, 470, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 4, new DateTime(2020, 5, 23, 22, 48, 32, 293, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 4, new DateTime(2020, 5, 2, 4, 19, 4, 136, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 1, new DateTime(2020, 4, 29, 18, 35, 6, 667, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 4, new DateTime(2020, 2, 23, 11, 22, 5, 526, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 4, new DateTime(2019, 9, 4, 14, 23, 27, 179, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 5, new DateTime(2019, 8, 21, 2, 31, 9, 84, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 5, new DateTime(2020, 2, 28, 0, 44, 58, 248, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 5, new DateTime(2020, 6, 6, 1, 14, 52, 114, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 1, new DateTime(2020, 4, 7, 21, 14, 58, 325, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 5, new DateTime(2020, 5, 11, 20, 11, 27, 714, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 6, new DateTime(2020, 2, 3, 6, 42, 18, 243, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 2, new DateTime(2020, 6, 29, 7, 36, 51, 834, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 2, new DateTime(2020, 5, 26, 0, 43, 13, 964, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 6, new DateTime(2020, 3, 20, 17, 39, 13, 8, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 6, new DateTime(2020, 6, 10, 0, 32, 7, 483, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 4, new DateTime(2019, 10, 4, 17, 40, 25, 981, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 4, new DateTime(2019, 12, 9, 23, 1, 14, 687, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 5, new DateTime(2020, 5, 12, 16, 44, 40, 541, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 2, new DateTime(2020, 6, 28, 12, 40, 22, 317, DateTimeKind.Local).AddTicks(7351) });

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
