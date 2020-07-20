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
                    Label = table.Column<string>(nullable: true),
                    LabelAr = table.Column<string>(nullable: true)
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
                    Label = table.Column<string>(nullable: true),
                    LabelAr = table.Column<string>(nullable: true)
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
                    LabelAr = table.Column<string>(nullable: true),
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
                    SessionAr = table.Column<string>(nullable: true),
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
                    Nom = table.Column<string>(nullable: true),
                    NomAr = table.Column<string>(nullable: true)
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
                    Label = table.Column<string>(nullable: true),
                    LabelAr = table.Column<string>(nullable: true)
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
                    MandatAr = table.Column<string>(nullable: true),
                    Discours = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    LienRapport = table.Column<string>(nullable: true),
                    MiseOeuvrePiece = table.Column<string>(nullable: true),
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
                    LabelAr = table.Column<string>(nullable: true),
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
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 1, "Consolider la gouvernance du développement durable", "توطيد حوكمة التنمية المستدامة" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 2, "Réussir la transition vers une économie verts", "الانتقال الناجح إلى الاقتصاد الأخضر" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 3, "Améliorer la gestion et la valorisation des ressources naturelles et renforcer la conservation de la biodiversité", "تحسين إدارة وتنمية الموارد الطبيعية وتعزيز حفظ التنوع البيولوجي" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 4, "Accélérer la mise en œuvre de la politique nationale de lutte contre le changement climatique", "تسريع تنفيذ السياسة الوطنية لمكافحة تغير المناخ" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 5, "Accorder une vigilance particulière aux territoires sensibles", "انتبه بشكل خاص للمناطق الحساسة" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 6, "Promouvoir le développement humain et réduire les inégalités sociales et territoriales", "تعزيز التنمية البشرية والحد من التفاوتات الاجتماعية والإقليمية" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 7, "Promouvoir une culture de développement durable", "تعزيز ثقافة التنمية المستدامة" });

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
                values: new object[] { 10, "Categorie 1", new DateTime(2019, 7, 25, 11, 31, 23, 541, DateTimeKind.Local).AddTicks(8410), "Iusto qui a. Quia et sed et veniam fugiat totam earum voluptatem. Ipsum qui accusamus molestiae deserunt deleniti id. Et veniam fugit vel nostrum. Consequuntur ut dolor incidunt ut aspernatur. Aperiam accusantium aut ex unde. Et possimus id voluptatem qui. Nemo animi qui perspiciatis officiis voluptatem. Commodi sunt tenetur cum. Autem et autem dolor maxime et ut tempore. Voluptatem eos nihil eos. Quae magni quia officia saepe dolores provident.", "vero" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 9, "Categorie 1", new DateTime(2019, 10, 1, 15, 31, 4, 947, DateTimeKind.Local).AddTicks(8430), "Qui error similique. Nulla nesciunt maxime sunt itaque blanditiis. Vel ipsum autem quia modi. Laboriosam ab aliquam et cum commodi illum. Vero reprehenderit numquam aut iure itaque labore vel omnis. Laudantium suscipit repellendus iusto harum blanditiis veritatis aperiam quaerat. Adipisci ut rerum eaque sit sit. Tenetur voluptatibus dicta. Velit facere et maiores voluptas non totam omnis occaecati eaque. Et cupiditate expedita necessitatibus assumenda ut esse.", "consequatur" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 8, "Categorie 1", new DateTime(2020, 3, 8, 4, 42, 52, 711, DateTimeKind.Local).AddTicks(7806), "Est ad soluta iste. Ea minus ut nobis eaque deserunt quis explicabo. Consequuntur libero libero tenetur non illo ex ipsam. Aperiam voluptatum amet consequatur aut dolorem enim non. Maiores pariatur eligendi error ut rerum. Placeat est error. Beatae veritatis omnis. Et minus consequatur ratione consequuntur minus et. Blanditiis iste est beatae deleniti ex non voluptate autem. Quia corporis dolore ab error iusto accusantium. Dolor minima autem velit quidem ut porro distinctio in quasi. Neque ea id.", "distinctio" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 7, "Categorie 1", new DateTime(2020, 6, 21, 15, 5, 40, 422, DateTimeKind.Local).AddTicks(2819), "Natus natus dolores consequatur consequatur ea fugiat. In ea rerum minima minima amet et et suscipit et. Autem doloribus possimus vel eum veritatis soluta placeat cumque. Aliquid saepe odit commodi. Rem ut in. Vel facilis est earum eos quia ut. Et libero eaque natus sequi quia fugiat. Cupiditate aut dolor nam nemo consequuntur est dolores. Quae laudantium voluptas repudiandae velit porro aut molestias. Aut fugit et ab et quia eos deleniti illum.", "deserunt" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 6, "Categorie 1", new DateTime(2019, 10, 24, 18, 3, 48, 89, DateTimeKind.Local).AddTicks(8390), "Atque vero nobis fugiat tenetur. Id veritatis nihil itaque necessitatibus est dolores. Quaerat ut dolor ea. Omnis error error doloremque beatae dignissimos voluptatem id aut. Repellat suscipit vero molestias labore. Quidem delectus modi in et. Est nihil aut eius facere quibusdam et ut voluptas recusandae. Exercitationem rerum maxime et eum est reprehenderit eligendi nulla. Cumque molestiae animi doloremque aut saepe et dolorum. Iste dolorem ut. Sint vero ratione vero est laudantium quos.", "beatae" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 4, "Categorie 1", new DateTime(2019, 9, 29, 5, 38, 16, 527, DateTimeKind.Local).AddTicks(4437), "Sit quisquam voluptatem. Qui atque blanditiis adipisci quis nihil sed quod. Delectus vel tempore alias aperiam quidem et aliquam. Voluptatem animi laborum impedit. Doloremque labore recusandae sint itaque ut. Excepturi aut at beatae beatae et quia. Itaque qui laudantium expedita ut eum dolore et. Sed corrupti vitae dolor rerum. Quisquam consequuntur officiis voluptatibus nihil tenetur. Repellendus animi qui modi qui. Illum molestiae a dolores provident. Adipisci vel dolores tenetur dolorem fugit repellendus.", "quia" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 3, "Categorie 1", new DateTime(2020, 4, 23, 18, 52, 0, 588, DateTimeKind.Local).AddTicks(1124), "Ut et est corrupti. Odio explicabo et illo et. Delectus aspernatur similique eius enim est quis repellendus sit animi. Cupiditate voluptas fugiat tenetur. Itaque quod ut sed. Dolores et placeat iste sit aut. Natus eos mollitia dolorem quaerat dolores non. Qui optio et incidunt dicta ex esse animi aut. Nulla et nisi ad nesciunt inventore vitae sed provident fugiat. Illum distinctio voluptatibus in. Modi sequi alias in ut ut fuga odit nisi.", "qui" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 2, "Categorie 1", new DateTime(2020, 2, 4, 23, 27, 25, 483, DateTimeKind.Local).AddTicks(3869), "Dolor aut eos et. Et est et dolores eaque molestiae sunt. Dignissimos aut quia voluptas. Tenetur explicabo doloremque repellat et et illum eos dolorem quo. Earum amet quaerat sed. Molestiae voluptate velit laboriosam recusandae recusandae et adipisci. Rerum totam itaque tempora nihil sed modi omnis enim sit. Quia repellendus aut repellat aut. Et aut eveniet omnis at libero. Sunt sint similique quia maiores illo sit mollitia quo alias. In debitis repudiandae in dolor rerum iure repudiandae molestiae sint.", "veniam" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 1, "Categorie 1", new DateTime(2020, 4, 15, 12, 38, 31, 912, DateTimeKind.Local).AddTicks(3606), "Laborum velit impedit corrupti suscipit exercitationem consequatur. Unde sed impedit. Facilis veniam numquam omnis veniam et reiciendis veritatis sit accusantium. Possimus dolorem ipsa aut voluptatum eos cumque animi. Est non laudantium. Ut optio provident enim est quia voluptas sit possimus. Dolor ipsam corrupti totam tempore dolores sequi voluptatem eum qui. Tenetur voluptatem nostrum corrupti saepe quaerat nulla. Est modi quo qui qui ut qui. Impedit quis veritatis quaerat excepturi alias modi voluptatem quos maiores. Doloremque laudantium et excepturi perspiciatis debitis.", "dolores" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 5, "Categorie 1", new DateTime(2020, 4, 29, 17, 59, 44, 300, DateTimeKind.Local).AddTicks(3282), "Voluptatem quisquam et et dolores hic. Sint optio soluta qui. Eos voluptatem voluptatem recusandae reiciendis et esse dolore. Omnis neque est facilis qui. Impedit et rerum ratione. Quasi sequi dolores et dolorem et nobis aut facere. Quo itaque est ratione ad est pariatur. Aut adipisci dolor totam. Quo natus itaque. Omnis omnis dolores. Illo provident dolorem deserunt impedit consequuntur qui odit. Non dignissimos quos minus quo.", "deserunt" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 5, "", "", "مراجعة-6", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 6, "", "", "مراجعة-7", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 4, "", "", "مراجعة-5", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 1, "", "", "مراجعة-2", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 2, "", "", "مراجعة-3", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 3, "", "", "مراجعة-4", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 73, new DateTime(2020, 2, 14, 16, 16, 46, 515, DateTimeKind.Local).AddTicks(4177), "0,3,6", 73, 4, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2019, 12, 22, 8, 55, 3, 422, DateTimeKind.Local).AddTicks(7052), "0,3,4", 72, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2020, 6, 22, 16, 54, 57, 777, DateTimeKind.Local).AddTicks(2156), "1,2,6", 71, 3, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2020, 3, 10, 1, 26, 24, 419, DateTimeKind.Local).AddTicks(3508), "0,3,6", 70, 1, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2020, 5, 22, 5, 9, 34, 806, DateTimeKind.Local).AddTicks(5510), "0,3,4", 69, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2019, 9, 2, 18, 42, 10, 339, DateTimeKind.Local).AddTicks(605), "0,2,6", 68, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2020, 5, 12, 14, 39, 18, 411, DateTimeKind.Local).AddTicks(2903), "0,3,4", 67, 4, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2019, 8, 12, 13, 37, 23, 217, DateTimeKind.Local).AddTicks(3554), "0,2,4", 66, 2, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2019, 12, 19, 21, 32, 35, 163, DateTimeKind.Local).AddTicks(172), "1,3,5", 65, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2020, 1, 7, 5, 56, 59, 379, DateTimeKind.Local).AddTicks(8030), "1,3,5", 64, 1, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2019, 9, 23, 14, 53, 23, 582, DateTimeKind.Local).AddTicks(7150), "1,3,6", 63, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2020, 4, 13, 19, 0, 25, 851, DateTimeKind.Local).AddTicks(9071), "0,3,6", 61, 3, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2019, 12, 29, 20, 2, 38, 528, DateTimeKind.Local).AddTicks(186), "0,2,6", 60, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2020, 6, 24, 10, 50, 20, 854, DateTimeKind.Local).AddTicks(1097), "1,2,6", 59, 1, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2020, 5, 8, 17, 27, 0, 30, DateTimeKind.Local).AddTicks(7229), "0,2,4", 58, 2, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2019, 12, 11, 5, 12, 6, 865, DateTimeKind.Local).AddTicks(1154), "0,3,5", 57, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2019, 10, 9, 1, 38, 40, 755, DateTimeKind.Local).AddTicks(5695), "1,2,6", 56, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2020, 4, 3, 3, 43, 28, 326, DateTimeKind.Local).AddTicks(1823), "1,2,4", 55, 1, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2019, 9, 9, 14, 35, 56, 821, DateTimeKind.Local).AddTicks(2772), "1,2,4", 54, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2020, 3, 5, 20, 39, 9, 861, DateTimeKind.Local).AddTicks(1547), "1,2,4", 53, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2020, 6, 6, 1, 49, 35, 65, DateTimeKind.Local).AddTicks(3706), "0,3,5", 74, 6, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2019, 12, 14, 19, 28, 59, 566, DateTimeKind.Local).AddTicks(111), "1,2,5", 62, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2019, 12, 14, 7, 47, 30, 147, DateTimeKind.Local).AddTicks(7348), "1,3,4", 75, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2019, 8, 24, 20, 17, 28, 595, DateTimeKind.Local).AddTicks(238), "0,3,6", 93, 3, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2019, 12, 28, 2, 23, 25, 408, DateTimeKind.Local).AddTicks(4612), "0,2,6", 77, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2019, 12, 17, 0, 25, 28, 301, DateTimeKind.Local).AddTicks(9105), "1,2,6", 100, 6, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2020, 2, 8, 5, 38, 32, 107, DateTimeKind.Local).AddTicks(8574), "0,2,6", 99, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2019, 11, 22, 18, 51, 15, 377, DateTimeKind.Local).AddTicks(4710), "0,3,4", 98, 3, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2019, 12, 6, 8, 57, 37, 383, DateTimeKind.Local).AddTicks(9626), "0,2,4", 97, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2020, 3, 26, 10, 13, 36, 20, DateTimeKind.Local).AddTicks(683), "1,3,5", 96, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2020, 4, 21, 0, 23, 59, 714, DateTimeKind.Local).AddTicks(8086), "1,3,4", 95, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2019, 11, 29, 14, 41, 3, 824, DateTimeKind.Local).AddTicks(7982), "1,3,6", 94, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2019, 11, 29, 7, 35, 48, 248, DateTimeKind.Local).AddTicks(3967), "0,3,5", 52, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2020, 5, 18, 3, 55, 44, 126, DateTimeKind.Local).AddTicks(8861), "0,2,5", 92, 5, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2020, 7, 9, 1, 8, 41, 417, DateTimeKind.Local).AddTicks(5322), "1,2,4", 91, 3, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2019, 10, 9, 5, 25, 8, 757, DateTimeKind.Local).AddTicks(7319), "1,3,6", 76, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2020, 2, 29, 5, 52, 35, 783, DateTimeKind.Local).AddTicks(2791), "1,3,4", 90, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2020, 7, 5, 16, 20, 25, 444, DateTimeKind.Local).AddTicks(2271), "1,3,6", 88, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2019, 9, 7, 8, 39, 41, 952, DateTimeKind.Local).AddTicks(9521), "0,3,4", 87, 1, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2020, 5, 11, 20, 22, 53, 526, DateTimeKind.Local).AddTicks(1314), "0,3,6", 86, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2020, 6, 20, 0, 47, 37, 712, DateTimeKind.Local).AddTicks(1578), "1,2,5", 85, 6, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2020, 3, 6, 4, 20, 44, 903, DateTimeKind.Local).AddTicks(7935), "1,2,4", 83, 2, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2019, 7, 28, 3, 24, 3, 61, DateTimeKind.Local).AddTicks(2872), "1,3,5", 82, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2019, 7, 27, 20, 38, 48, 188, DateTimeKind.Local).AddTicks(2094), "0,3,4", 81, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2019, 11, 21, 18, 9, 24, 777, DateTimeKind.Local).AddTicks(6774), "0,2,4", 80, 3, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2019, 8, 27, 19, 54, 20, 306, DateTimeKind.Local).AddTicks(1936), "1,2,5", 79, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2019, 12, 12, 23, 58, 19, 498, DateTimeKind.Local).AddTicks(5299), "1,3,4", 78, 4, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2019, 7, 23, 18, 58, 19, 221, DateTimeKind.Local).AddTicks(4541), "0,2,6", 89, 4, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2019, 10, 18, 14, 39, 50, 192, DateTimeKind.Local).AddTicks(9661), "0,2,4", 51, 4, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2020, 6, 3, 18, 14, 36, 713, DateTimeKind.Local).AddTicks(1123), "0,2,6", 84, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2020, 1, 10, 11, 51, 43, 59, DateTimeKind.Local).AddTicks(2560), "1,3,6", 49, 6, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2019, 8, 28, 23, 39, 28, 266, DateTimeKind.Local).AddTicks(2807), "1,2,4", 22, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2020, 5, 10, 0, 12, 55, 315, DateTimeKind.Local).AddTicks(182), "0,2,6", 21, 6, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2020, 5, 4, 17, 45, 3, 971, DateTimeKind.Local).AddTicks(3039), "1,2,6", 20, 1, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2019, 10, 12, 4, 38, 21, 771, DateTimeKind.Local).AddTicks(8245), "1,3,4", 19, 1, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2019, 8, 19, 18, 26, 33, 605, DateTimeKind.Local).AddTicks(1501), "1,2,4", 18, 1, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2019, 12, 7, 6, 19, 5, 651, DateTimeKind.Local).AddTicks(8132), "0,3,4", 17, 1, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2019, 8, 13, 19, 44, 38, 423, DateTimeKind.Local).AddTicks(1849), "0,2,4", 15, 1, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2020, 2, 5, 13, 10, 51, 813, DateTimeKind.Local).AddTicks(5238), "0,3,6", 14, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2020, 4, 8, 1, 33, 45, 529, DateTimeKind.Local).AddTicks(6874), "0,2,6", 13, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2019, 9, 1, 2, 52, 21, 137, DateTimeKind.Local).AddTicks(1004), "1,3,6", 12, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 4, 17, 0, 22, 15, 262, DateTimeKind.Local).AddTicks(4598), "0,3,4", 23, 3, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2020, 6, 14, 11, 12, 29, 867, DateTimeKind.Local).AddTicks(5633), "1,3,5", 11, 5, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2019, 8, 1, 20, 16, 32, 228, DateTimeKind.Local).AddTicks(3581), "0,3,5", 9, 4, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2020, 3, 17, 19, 14, 0, 865, DateTimeKind.Local).AddTicks(9195), "1,2,5", 8, 3, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2020, 1, 8, 9, 20, 40, 287, DateTimeKind.Local).AddTicks(3639), "0,3,5", 7, 1, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2020, 6, 3, 4, 38, 49, 665, DateTimeKind.Local).AddTicks(3777), "1,2,4", 6, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2020, 6, 28, 16, 11, 47, 548, DateTimeKind.Local).AddTicks(4632), "0,2,4", 5, 1, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2020, 6, 21, 12, 37, 27, 811, DateTimeKind.Local).AddTicks(1249), "0,2,4", 4, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2019, 9, 24, 18, 20, 20, 896, DateTimeKind.Local).AddTicks(6841), "1,2,6", 3, 5, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2020, 3, 6, 5, 3, 46, 150, DateTimeKind.Local).AddTicks(3744), "0,2,6", 2, 1, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2020, 7, 10, 8, 45, 7, 879, DateTimeKind.Local).AddTicks(7482), "0,3,5", 1, 4, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2020, 1, 8, 18, 14, 12, 89, DateTimeKind.Local).AddTicks(2486), "0,2,6", 50, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2019, 11, 1, 12, 59, 28, 252, DateTimeKind.Local).AddTicks(2226), "1,3,4", 10, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2020, 2, 24, 0, 8, 12, 972, DateTimeKind.Local).AddTicks(2411), "0,3,5", 24, 3, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2020, 2, 10, 20, 22, 40, 301, DateTimeKind.Local).AddTicks(4173), "0,3,5", 16, 6, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2019, 12, 14, 15, 31, 28, 173, DateTimeKind.Local).AddTicks(736), "1,2,4", 26, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2019, 8, 30, 14, 23, 1, 129, DateTimeKind.Local).AddTicks(679), "1,3,4", 48, 6, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2019, 10, 12, 4, 5, 29, 329, DateTimeKind.Local).AddTicks(128), "1,2,5", 47, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2019, 9, 10, 13, 30, 48, 135, DateTimeKind.Local).AddTicks(3521), "0,2,6", 46, 4, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2020, 7, 5, 9, 16, 0, 7, DateTimeKind.Local).AddTicks(5052), "1,3,5", 25, 2, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2020, 6, 28, 4, 44, 30, 446, DateTimeKind.Local).AddTicks(9446), "1,3,6", 44, 5, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2020, 4, 9, 2, 35, 25, 818, DateTimeKind.Local).AddTicks(1749), "0,3,6", 43, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2020, 4, 7, 3, 38, 26, 373, DateTimeKind.Local).AddTicks(9705), "1,2,5", 42, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2019, 10, 10, 23, 10, 5, 875, DateTimeKind.Local).AddTicks(6131), "1,2,5", 41, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2020, 6, 5, 17, 54, 54, 73, DateTimeKind.Local).AddTicks(905), "1,3,4", 40, 5, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2020, 4, 8, 10, 19, 14, 561, DateTimeKind.Local).AddTicks(6596), "1,2,5", 39, 5, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2020, 6, 12, 21, 33, 21, 505, DateTimeKind.Local).AddTicks(1538), "1,2,4", 38, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2020, 3, 3, 10, 39, 54, 135, DateTimeKind.Local).AddTicks(3774), "1,2,4", 37, 6, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2019, 11, 5, 13, 12, 45, 825, DateTimeKind.Local).AddTicks(6287), "0,2,5", 45, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2019, 11, 30, 12, 11, 45, 117, DateTimeKind.Local).AddTicks(1090), "1,2,5", 35, 3, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2020, 6, 6, 1, 43, 21, 586, DateTimeKind.Local).AddTicks(7726), "1,3,5", 34, 3, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2020, 3, 23, 1, 55, 5, 698, DateTimeKind.Local).AddTicks(7022), "1,2,5", 33, 5, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2020, 2, 7, 2, 5, 46, 922, DateTimeKind.Local).AddTicks(3646), "1,3,4", 27, 4, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2019, 7, 22, 17, 21, 35, 493, DateTimeKind.Local).AddTicks(4817), "1,2,6", 32, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2019, 8, 12, 0, 20, 27, 251, DateTimeKind.Local).AddTicks(6022), "1,3,5", 31, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2020, 6, 2, 0, 26, 13, 705, DateTimeKind.Local).AddTicks(4435), "0,2,5", 30, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2019, 11, 28, 0, 33, 41, 504, DateTimeKind.Local).AddTicks(6213), "1,2,6", 29, 3, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2020, 6, 25, 14, 22, 49, 576, DateTimeKind.Local).AddTicks(3865), "1,2,4", 28, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2019, 12, 1, 23, 41, 21, 996, DateTimeKind.Local).AddTicks(5832), "0,3,4", 36, 4, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 6, "Comité des droits des personnes handicapés", "اللجنة المعنية بحقوق الأشخاص ذوي الإعاقة" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 4, "Comité des droits de l’Homme", "لجنة حقوق الإنسان" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 5, "Comité des droits de l’enfant", "لجنة حقوق الطفل" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 2, "Comité contre la torture", "لجنة مناهضة التعذيب" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 1, "Comité CEDAW", "لجنة سيداو" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 3, "Comité des disparitions forcées", "لجنة الاختفاء القسري" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 7, null, "Délégation interministérielle aux droits de l'Homme", "الوفد الوزاري لحقوق الإنسان", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 5, null, "Ministère de la Communication", "وزارة الاتصالات", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 4, null, "Ministère de l'Equipement et du Transport", "وزارة التجهيز والنقل", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 6, null, "Ministère de la Santé", "وزارة الصحة", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 2, null, "Ministère de la Justice et des Libertés", "وزارة العدل والحريات", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 1, null, "Ministère des Affaires Étrangères et de la Coopération", "وزارة الخارجية والتعاون", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 3, null, "Ministère de la Fonction Publique et de la Modernisation de l'Administration", "وزارة الخدمة المدنية وتحديث الإدارة", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 15, 2020, "", "", "Session 15", "جلسة 15" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 14, 2020, "", "", "Session 14", "جلسة 14" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 9, 2020, "", "", "Session 9", "جلسة 9" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 12, 2020, "", "", "Session 12", "جلسة 12" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 11, 2020, "", "", "Session 11", "جلسة 11" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 10, 2020, "", "", "Session 10", "جلسة 10" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 8, 2020, "", "", "Session 8", "جلسة 8" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 13, 2020, "", "", "Session 13", "جلسة 13" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 6, 2020, "", "", "Session 6", "جلسة 6" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 5, 2020, "", "", "Session 5", "جلسة 5" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 4, 2020, "", "", "Session 4", "جلسة 4" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 3, 2020, "", "", "Session 3", "جلسة 3" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 2, 2020, "", "", "Session 2", "جلسة 2" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 1, 2020, "", "", "Session 1", "جلسة 1" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 7, 2020, "", "", "Session 7", "جلسة 7" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 3, "Allemagne", "ألمانيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 4, "Espagnole", "الأسبانية" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 1, "Maroc", "المملكة المغربية" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 2, "France", "فرنسا" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 1, "Administrateur", "مدير" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 2, "Superviseur", "مشرف" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 3, "Point focal", "	المخاطب الرئيسي" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 4, "Propriétaire", "مالك" });

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
                values: new object[] { 14, 2020, "", "sous theme 14", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 13, 2020, "", "sous theme 13", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 11, 2020, "", "sous theme 11", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 10, 2020, "", "sous theme 10", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 8, 2020, "", "sous theme 8", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 12, 2020, "", "sous theme 12", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 6, 2020, "", "sous theme 6", "Droits catégoriels" });

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
                values: new object[] { 7, 2020, "", "sous theme 7", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 3, 2020, "", "sous theme 3", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 2, 2020, "", "sous theme 2", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 1, 2020, "", "sous theme 1", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 66, "", "", new DateTime(2020, 4, 18, 22, 10, 30, 696, DateTimeKind.Local).AddTicks(262), new DateTime(2020, 6, 30, 4, 51, 1, 540, DateTimeKind.Local).AddTicks(9502), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 67, "", "", new DateTime(2019, 9, 11, 17, 23, 21, 928, DateTimeKind.Local).AddTicks(3165), new DateTime(2019, 11, 18, 8, 7, 12, 12, DateTimeKind.Local).AddTicks(9028), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 68, "", "", new DateTime(2020, 5, 21, 3, 2, 49, 207, DateTimeKind.Local).AddTicks(9517), new DateTime(2020, 3, 18, 12, 50, 7, 95, DateTimeKind.Local).AddTicks(4529), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 69, "", "", new DateTime(2020, 6, 1, 9, 44, 15, 952, DateTimeKind.Local).AddTicks(6755), new DateTime(2020, 7, 11, 17, 56, 51, 947, DateTimeKind.Local).AddTicks(6775), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 72, "", "", new DateTime(2019, 11, 5, 20, 2, 27, 500, DateTimeKind.Local).AddTicks(9022), new DateTime(2020, 1, 4, 14, 22, 37, 155, DateTimeKind.Local).AddTicks(7284), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 71, "", "", new DateTime(2020, 1, 9, 15, 54, 55, 376, DateTimeKind.Local).AddTicks(5423), new DateTime(2019, 7, 27, 5, 33, 44, 222, DateTimeKind.Local).AddTicks(4201), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 65, "", "", new DateTime(2019, 8, 16, 7, 8, 28, 755, DateTimeKind.Local).AddTicks(8827), new DateTime(2020, 6, 28, 16, 6, 56, 10, DateTimeKind.Local).AddTicks(5156), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 73, "", "", new DateTime(2020, 4, 29, 11, 2, 44, 460, DateTimeKind.Local).AddTicks(5253), new DateTime(2019, 7, 25, 8, 52, 56, 569, DateTimeKind.Local).AddTicks(2702), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 74, "", "", new DateTime(2019, 10, 24, 5, 35, 36, 81, DateTimeKind.Local).AddTicks(8510), new DateTime(2019, 9, 20, 16, 53, 30, 828, DateTimeKind.Local).AddTicks(9414), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 70, "", "", new DateTime(2019, 12, 23, 23, 57, 1, 76, DateTimeKind.Local).AddTicks(4677), new DateTime(2019, 7, 25, 7, 12, 55, 424, DateTimeKind.Local).AddTicks(166), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 64, "", "", new DateTime(2020, 2, 22, 12, 46, 56, 203, DateTimeKind.Local).AddTicks(931), new DateTime(2020, 5, 6, 22, 16, 42, 895, DateTimeKind.Local).AddTicks(5712), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 62, "", "", new DateTime(2020, 6, 14, 12, 10, 1, 390, DateTimeKind.Local).AddTicks(335), new DateTime(2019, 12, 11, 5, 36, 51, 201, DateTimeKind.Local).AddTicks(5022), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 53, "", "", new DateTime(2020, 1, 7, 14, 33, 58, 850, DateTimeKind.Local).AddTicks(3405), new DateTime(2019, 12, 27, 1, 48, 41, 910, DateTimeKind.Local).AddTicks(6815), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 61, "", "", new DateTime(2020, 5, 7, 13, 35, 48, 702, DateTimeKind.Local).AddTicks(2060), new DateTime(2019, 8, 9, 20, 6, 12, 282, DateTimeKind.Local).AddTicks(1877), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 60, "", "", new DateTime(2020, 1, 1, 2, 44, 53, 638, DateTimeKind.Local).AddTicks(2620), new DateTime(2020, 5, 23, 23, 48, 27, 205, DateTimeKind.Local).AddTicks(3956), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 59, "", "", new DateTime(2020, 3, 15, 1, 21, 25, 131, DateTimeKind.Local).AddTicks(3653), new DateTime(2020, 1, 3, 13, 17, 22, 540, DateTimeKind.Local).AddTicks(1452), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 58, "", "", new DateTime(2020, 4, 8, 2, 0, 54, 306, DateTimeKind.Local).AddTicks(9255), new DateTime(2019, 12, 14, 6, 5, 9, 326, DateTimeKind.Local).AddTicks(6188), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 57, "", "", new DateTime(2019, 9, 29, 3, 28, 26, 881, DateTimeKind.Local).AddTicks(6935), new DateTime(2019, 8, 20, 10, 4, 39, 381, DateTimeKind.Local).AddTicks(7702), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 56, "", "", new DateTime(2019, 9, 23, 18, 27, 32, 308, DateTimeKind.Local).AddTicks(3643), new DateTime(2020, 4, 15, 1, 9, 57, 629, DateTimeKind.Local).AddTicks(1912), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 55, "", "", new DateTime(2020, 6, 19, 3, 18, 18, 948, DateTimeKind.Local).AddTicks(9552), new DateTime(2019, 11, 29, 1, 11, 12, 755, DateTimeKind.Local).AddTicks(8777), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 54, "", "", new DateTime(2019, 10, 22, 10, 13, 46, 847, DateTimeKind.Local).AddTicks(5897), new DateTime(2020, 4, 2, 0, 11, 15, 339, DateTimeKind.Local).AddTicks(949), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 75, "", "", new DateTime(2020, 2, 13, 13, 42, 17, 146, DateTimeKind.Local).AddTicks(2518), new DateTime(2020, 2, 25, 8, 26, 9, 688, DateTimeKind.Local).AddTicks(9552), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 63, "", "", new DateTime(2019, 7, 23, 19, 18, 40, 489, DateTimeKind.Local).AddTicks(7745), new DateTime(2019, 7, 22, 17, 9, 1, 801, DateTimeKind.Local).AddTicks(444), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 76, "", "", new DateTime(2019, 10, 21, 23, 54, 41, 1, DateTimeKind.Local).AddTicks(5681), new DateTime(2020, 3, 12, 12, 37, 4, 561, DateTimeKind.Local).AddTicks(4008), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 91, "", "", new DateTime(2019, 10, 20, 14, 33, 36, 880, DateTimeKind.Local).AddTicks(5551), new DateTime(2020, 5, 12, 21, 55, 29, 405, DateTimeKind.Local).AddTicks(8838), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 78, "", "", new DateTime(2020, 4, 29, 11, 28, 14, 466, DateTimeKind.Local).AddTicks(2443), new DateTime(2019, 11, 9, 3, 6, 10, 720, DateTimeKind.Local).AddTicks(3098), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 52, "", "", new DateTime(2020, 3, 19, 14, 49, 41, 545, DateTimeKind.Local).AddTicks(435), new DateTime(2019, 8, 25, 10, 2, 2, 22, DateTimeKind.Local).AddTicks(5997), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 100, "", "", new DateTime(2020, 6, 8, 17, 23, 23, 409, DateTimeKind.Local).AddTicks(1221), new DateTime(2020, 3, 8, 5, 4, 28, 990, DateTimeKind.Local).AddTicks(6326), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 99, "", "", new DateTime(2019, 8, 21, 0, 4, 50, 877, DateTimeKind.Local).AddTicks(9554), new DateTime(2020, 6, 17, 10, 47, 22, 945, DateTimeKind.Local).AddTicks(7115), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 98, "", "", new DateTime(2019, 11, 19, 20, 36, 46, 790, DateTimeKind.Local).AddTicks(6416), new DateTime(2020, 3, 27, 12, 34, 34, 129, DateTimeKind.Local).AddTicks(3356), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 97, "", "", new DateTime(2019, 11, 26, 18, 12, 13, 18, DateTimeKind.Local).AddTicks(9327), new DateTime(2019, 9, 17, 9, 5, 5, 641, DateTimeKind.Local).AddTicks(5542), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 96, "", "", new DateTime(2020, 2, 18, 6, 12, 55, 37, DateTimeKind.Local).AddTicks(9131), new DateTime(2020, 2, 21, 10, 8, 15, 846, DateTimeKind.Local).AddTicks(9048), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 95, "", "", new DateTime(2020, 7, 13, 5, 58, 33, 471, DateTimeKind.Local).AddTicks(7116), new DateTime(2019, 8, 21, 2, 4, 7, 342, DateTimeKind.Local).AddTicks(9319), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 94, "", "", new DateTime(2020, 1, 23, 12, 49, 36, 823, DateTimeKind.Local).AddTicks(4406), new DateTime(2020, 2, 10, 6, 35, 37, 134, DateTimeKind.Local).AddTicks(6441), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 93, "", "", new DateTime(2020, 4, 15, 15, 49, 28, 461, DateTimeKind.Local).AddTicks(5083), new DateTime(2020, 5, 10, 14, 4, 8, 682, DateTimeKind.Local).AddTicks(8298), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 92, "", "", new DateTime(2020, 2, 7, 1, 39, 1, 310, DateTimeKind.Local).AddTicks(9368), new DateTime(2019, 10, 4, 21, 20, 4, 107, DateTimeKind.Local).AddTicks(537), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 77, "", "", new DateTime(2019, 12, 9, 20, 36, 29, 647, DateTimeKind.Local).AddTicks(7992), new DateTime(2020, 6, 15, 20, 55, 33, 445, DateTimeKind.Local).AddTicks(7003), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 90, "", "", new DateTime(2019, 8, 19, 4, 3, 38, 523, DateTimeKind.Local).AddTicks(1727), new DateTime(2020, 4, 13, 13, 39, 56, 335, DateTimeKind.Local).AddTicks(2354), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 88, "", "", new DateTime(2019, 9, 11, 8, 57, 27, 49, DateTimeKind.Local).AddTicks(9262), new DateTime(2019, 8, 3, 21, 5, 10, 439, DateTimeKind.Local).AddTicks(655), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 87, "", "", new DateTime(2019, 10, 30, 12, 1, 58, 946, DateTimeKind.Local).AddTicks(1400), new DateTime(2020, 2, 29, 3, 34, 13, 961, DateTimeKind.Local).AddTicks(5011), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 86, "", "", new DateTime(2019, 12, 15, 8, 46, 43, 544, DateTimeKind.Local).AddTicks(9408), new DateTime(2019, 10, 26, 7, 5, 11, 72, DateTimeKind.Local).AddTicks(906), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 85, "", "", new DateTime(2019, 9, 26, 19, 4, 37, 629, DateTimeKind.Local).AddTicks(7613), new DateTime(2020, 6, 8, 5, 32, 24, 856, DateTimeKind.Local).AddTicks(8528), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 84, "", "", new DateTime(2019, 11, 8, 12, 17, 1, 315, DateTimeKind.Local).AddTicks(2858), new DateTime(2020, 7, 10, 4, 52, 25, 245, DateTimeKind.Local).AddTicks(8849), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 83, "", "", new DateTime(2020, 3, 31, 11, 3, 42, 877, DateTimeKind.Local).AddTicks(3395), new DateTime(2020, 4, 30, 4, 50, 40, 265, DateTimeKind.Local).AddTicks(3607), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 82, "", "", new DateTime(2020, 4, 24, 17, 22, 47, 473, DateTimeKind.Local).AddTicks(8342), new DateTime(2019, 9, 2, 14, 36, 39, 836, DateTimeKind.Local).AddTicks(9277), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 81, "", "", new DateTime(2019, 8, 9, 2, 0, 10, 985, DateTimeKind.Local).AddTicks(2064), new DateTime(2020, 2, 18, 13, 6, 18, 423, DateTimeKind.Local).AddTicks(6807), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 80, "", "", new DateTime(2020, 7, 7, 6, 51, 54, 65, DateTimeKind.Local).AddTicks(474), new DateTime(2019, 8, 2, 20, 10, 24, 447, DateTimeKind.Local).AddTicks(7288), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 79, "", "", new DateTime(2020, 2, 12, 0, 7, 10, 176, DateTimeKind.Local).AddTicks(700), new DateTime(2020, 7, 7, 4, 17, 38, 504, DateTimeKind.Local).AddTicks(6218), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 89, "", "", new DateTime(2019, 9, 6, 6, 2, 57, 493, DateTimeKind.Local).AddTicks(6361), new DateTime(2020, 3, 31, 22, 11, 19, 920, DateTimeKind.Local).AddTicks(6981), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 51, "", "", new DateTime(2020, 3, 30, 2, 13, 7, 244, DateTimeKind.Local).AddTicks(2678), new DateTime(2019, 7, 22, 11, 16, 10, 682, DateTimeKind.Local).AddTicks(2749), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 8, "", "", new DateTime(2020, 1, 22, 8, 44, 55, 3, DateTimeKind.Local).AddTicks(9772), new DateTime(2020, 3, 10, 9, 8, 47, 416, DateTimeKind.Local).AddTicks(40), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 49, "", "", new DateTime(2020, 1, 22, 8, 50, 5, 310, DateTimeKind.Local).AddTicks(9381), new DateTime(2020, 6, 3, 0, 12, 57, 991, DateTimeKind.Local).AddTicks(9119), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 22, "", "", new DateTime(2019, 10, 16, 18, 59, 23, 948, DateTimeKind.Local).AddTicks(1369), new DateTime(2019, 10, 15, 17, 22, 47, 553, DateTimeKind.Local).AddTicks(5440), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 21, "", "", new DateTime(2020, 4, 30, 7, 13, 59, 915, DateTimeKind.Local).AddTicks(3200), new DateTime(2019, 12, 16, 15, 52, 24, 365, DateTimeKind.Local).AddTicks(2511), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 20, "", "", new DateTime(2019, 12, 8, 19, 55, 36, 20, DateTimeKind.Local).AddTicks(1655), new DateTime(2019, 7, 27, 2, 56, 26, 804, DateTimeKind.Local).AddTicks(372), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 19, "", "", new DateTime(2020, 5, 24, 5, 41, 46, 243, DateTimeKind.Local).AddTicks(2134), new DateTime(2020, 1, 8, 3, 13, 47, 153, DateTimeKind.Local).AddTicks(6118), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 18, "", "", new DateTime(2020, 3, 18, 9, 37, 33, 367, DateTimeKind.Local).AddTicks(7292), new DateTime(2019, 10, 6, 1, 28, 38, 262, DateTimeKind.Local).AddTicks(2167), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 17, "", "", new DateTime(2019, 12, 14, 11, 38, 42, 975, DateTimeKind.Local).AddTicks(5728), new DateTime(2020, 4, 17, 11, 52, 32, 110, DateTimeKind.Local).AddTicks(427), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 16, "", "", new DateTime(2019, 10, 14, 4, 38, 38, 194, DateTimeKind.Local).AddTicks(5068), new DateTime(2019, 9, 7, 19, 38, 43, 470, DateTimeKind.Local).AddTicks(9877), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 15, "", "", new DateTime(2020, 7, 16, 9, 14, 19, 703, DateTimeKind.Local).AddTicks(5823), new DateTime(2020, 2, 26, 15, 1, 4, 822, DateTimeKind.Local).AddTicks(60), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 14, "", "", new DateTime(2020, 1, 3, 5, 35, 39, 457, DateTimeKind.Local).AddTicks(4173), new DateTime(2020, 6, 7, 5, 44, 17, 660, DateTimeKind.Local).AddTicks(5219), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 13, "", "", new DateTime(2020, 3, 20, 2, 34, 49, 339, DateTimeKind.Local).AddTicks(8373), new DateTime(2019, 8, 10, 1, 19, 59, 820, DateTimeKind.Local).AddTicks(7153), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 12, "", "", new DateTime(2020, 1, 14, 14, 53, 34, 967, DateTimeKind.Local).AddTicks(8671), new DateTime(2020, 6, 23, 4, 17, 46, 297, DateTimeKind.Local).AddTicks(3213), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 11, "", "", new DateTime(2019, 9, 30, 8, 42, 27, 177, DateTimeKind.Local).AddTicks(3899), new DateTime(2019, 11, 4, 19, 36, 40, 555, DateTimeKind.Local).AddTicks(8464), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 10, "", "", new DateTime(2019, 7, 30, 4, 23, 3, 269, DateTimeKind.Local).AddTicks(3627), new DateTime(2020, 5, 7, 16, 42, 50, 756, DateTimeKind.Local).AddTicks(3248), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 9, "", "", new DateTime(2019, 8, 13, 20, 16, 8, 928, DateTimeKind.Local).AddTicks(2283), new DateTime(2019, 12, 5, 3, 45, 54, 984, DateTimeKind.Local).AddTicks(4430), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 7, "", "", new DateTime(2019, 12, 29, 15, 51, 38, 885, DateTimeKind.Local).AddTicks(1452), new DateTime(2019, 12, 28, 15, 56, 51, 381, DateTimeKind.Local).AddTicks(170), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 6, "", "", new DateTime(2020, 2, 6, 6, 43, 48, 630, DateTimeKind.Local).AddTicks(9483), new DateTime(2019, 7, 21, 6, 54, 22, 65, DateTimeKind.Local).AddTicks(8561), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 5, "", "", new DateTime(2020, 3, 11, 10, 1, 51, 640, DateTimeKind.Local).AddTicks(5658), new DateTime(2020, 4, 13, 2, 30, 59, 936, DateTimeKind.Local).AddTicks(8314), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 4, "", "", new DateTime(2019, 12, 26, 8, 20, 35, 720, DateTimeKind.Local).AddTicks(7495), new DateTime(2020, 3, 28, 5, 57, 28, 848, DateTimeKind.Local).AddTicks(6740), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 3, "", "", new DateTime(2019, 12, 26, 2, 30, 48, 624, DateTimeKind.Local).AddTicks(4316), new DateTime(2020, 1, 1, 0, 45, 4, 556, DateTimeKind.Local).AddTicks(4869), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 2, "", "", new DateTime(2019, 8, 20, 5, 27, 56, 722, DateTimeKind.Local).AddTicks(670), new DateTime(2020, 7, 7, 5, 34, 30, 594, DateTimeKind.Local).AddTicks(7304), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 50, "", "", new DateTime(2020, 5, 27, 22, 33, 54, 966, DateTimeKind.Local).AddTicks(8142), new DateTime(2020, 3, 14, 16, 9, 55, 803, DateTimeKind.Local).AddTicks(7393), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 23, "", "", new DateTime(2019, 12, 11, 20, 51, 36, 649, DateTimeKind.Local).AddTicks(5045), new DateTime(2019, 9, 15, 12, 52, 55, 682, DateTimeKind.Local).AddTicks(8862), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 24, "", "", new DateTime(2020, 5, 23, 16, 1, 32, 446, DateTimeKind.Local).AddTicks(4156), new DateTime(2020, 6, 7, 21, 53, 38, 301, DateTimeKind.Local).AddTicks(3014), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 1, "", "", new DateTime(2020, 7, 11, 18, 14, 3, 146, DateTimeKind.Local).AddTicks(3177), new DateTime(2019, 8, 18, 7, 11, 13, 953, DateTimeKind.Local).AddTicks(9276), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 26, "", "", new DateTime(2019, 10, 24, 21, 26, 10, 838, DateTimeKind.Local).AddTicks(6269), new DateTime(2020, 1, 26, 17, 15, 14, 310, DateTimeKind.Local).AddTicks(5918), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 25, "", "", new DateTime(2019, 9, 23, 3, 29, 8, 170, DateTimeKind.Local).AddTicks(6833), new DateTime(2020, 7, 16, 4, 0, 38, 437, DateTimeKind.Local).AddTicks(9216), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 47, "", "", new DateTime(2019, 9, 30, 8, 36, 3, 847, DateTimeKind.Local).AddTicks(7828), new DateTime(2020, 3, 13, 22, 48, 40, 700, DateTimeKind.Local).AddTicks(9274), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 46, "", "", new DateTime(2019, 10, 24, 19, 6, 2, 735, DateTimeKind.Local).AddTicks(5924), new DateTime(2020, 4, 10, 21, 8, 0, 482, DateTimeKind.Local).AddTicks(9496), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 45, "", "", new DateTime(2020, 3, 21, 14, 14, 4, 335, DateTimeKind.Local).AddTicks(7717), new DateTime(2020, 1, 20, 6, 24, 49, 968, DateTimeKind.Local).AddTicks(5346), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 44, "", "", new DateTime(2019, 8, 20, 14, 5, 19, 435, DateTimeKind.Local).AddTicks(4571), new DateTime(2020, 3, 19, 0, 42, 44, 12, DateTimeKind.Local).AddTicks(7867), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 43, "", "", new DateTime(2020, 6, 17, 0, 55, 28, 238, DateTimeKind.Local).AddTicks(6922), new DateTime(2019, 9, 24, 11, 22, 27, 280, DateTimeKind.Local).AddTicks(4083), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 42, "", "", new DateTime(2019, 11, 25, 14, 53, 53, 506, DateTimeKind.Local).AddTicks(271), new DateTime(2020, 2, 13, 5, 38, 29, 520, DateTimeKind.Local).AddTicks(3583), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 41, "", "", new DateTime(2019, 11, 12, 9, 57, 25, 9, DateTimeKind.Local).AddTicks(4215), new DateTime(2019, 12, 28, 12, 43, 28, 559, DateTimeKind.Local).AddTicks(3270), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 40, "", "", new DateTime(2020, 2, 23, 20, 56, 34, 164, DateTimeKind.Local).AddTicks(1013), new DateTime(2020, 7, 15, 0, 17, 56, 700, DateTimeKind.Local).AddTicks(2210), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 39, "", "", new DateTime(2019, 11, 24, 11, 26, 3, 107, DateTimeKind.Local).AddTicks(656), new DateTime(2019, 10, 26, 22, 37, 21, 46, DateTimeKind.Local).AddTicks(4510), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 38, "", "", new DateTime(2019, 12, 15, 21, 39, 22, 954, DateTimeKind.Local).AddTicks(6690), new DateTime(2020, 1, 9, 22, 45, 16, 50, DateTimeKind.Local).AddTicks(3895), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 48, "", "", new DateTime(2020, 5, 29, 14, 24, 41, 479, DateTimeKind.Local).AddTicks(5798), new DateTime(2020, 1, 23, 22, 5, 32, 929, DateTimeKind.Local).AddTicks(6508), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 36, "", "", new DateTime(2020, 2, 28, 7, 22, 4, 567, DateTimeKind.Local).AddTicks(4995), new DateTime(2020, 1, 13, 23, 53, 4, 207, DateTimeKind.Local).AddTicks(2770), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 27, "", "", new DateTime(2020, 6, 18, 14, 54, 58, 980, DateTimeKind.Local).AddTicks(134), new DateTime(2020, 5, 20, 9, 22, 9, 743, DateTimeKind.Local).AddTicks(9217), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 37, "", "", new DateTime(2019, 12, 29, 21, 31, 53, 181, DateTimeKind.Local).AddTicks(441), new DateTime(2020, 2, 18, 2, 0, 14, 414, DateTimeKind.Local).AddTicks(8209), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 29, "", "", new DateTime(2019, 10, 22, 12, 26, 6, 258, DateTimeKind.Local).AddTicks(1596), new DateTime(2020, 2, 1, 16, 49, 32, 819, DateTimeKind.Local).AddTicks(8674), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 30, "", "", new DateTime(2020, 7, 4, 1, 52, 47, 100, DateTimeKind.Local).AddTicks(4244), new DateTime(2020, 3, 12, 2, 56, 27, 734, DateTimeKind.Local).AddTicks(8637), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 31, "", "", new DateTime(2019, 10, 29, 4, 7, 41, 936, DateTimeKind.Local).AddTicks(3074), new DateTime(2019, 10, 31, 0, 23, 52, 329, DateTimeKind.Local).AddTicks(8852), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 28, "", "", new DateTime(2020, 1, 23, 2, 21, 17, 879, DateTimeKind.Local).AddTicks(1095), new DateTime(2020, 3, 5, 10, 28, 59, 303, DateTimeKind.Local).AddTicks(9933), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 33, "", "", new DateTime(2020, 2, 25, 14, 28, 5, 836, DateTimeKind.Local).AddTicks(965), new DateTime(2020, 4, 19, 7, 59, 34, 765, DateTimeKind.Local).AddTicks(6653), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 34, "", "", new DateTime(2019, 12, 18, 2, 14, 48, 21, DateTimeKind.Local).AddTicks(7385), new DateTime(2020, 5, 23, 1, 31, 40, 555, DateTimeKind.Local).AddTicks(2255), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 35, "", "", new DateTime(2020, 5, 2, 22, 57, 56, 406, DateTimeKind.Local).AddTicks(4239), new DateTime(2020, 2, 10, 13, 21, 49, 539, DateTimeKind.Local).AddTicks(3850), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 32, "", "", new DateTime(2020, 7, 19, 9, 51, 19, 900, DateTimeKind.Local).AddTicks(5284), new DateTime(2020, 3, 24, 16, 6, 18, 552, DateTimeKind.Local).AddTicks(3139), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 65, new DateTime(2020, 6, 28, 11, 58, 56, 970, DateTimeKind.Local).AddTicks(9188), "Magni harum molestiae. Et perferendis atque iste tenetur similique iste est repellat. Voluptatem nemo aspernatur eos amet in occaecati dolor reprehenderit consequatur. Deserunt beatae dolorum. Incidunt qui enim dolores a vero. Sit consequuntur harum est occaecati culpa.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 72, new DateTime(2020, 2, 5, 15, 45, 35, 793, DateTimeKind.Local).AddTicks(6503), "Illum delectus cupiditate. Quia unde deserunt ut nihil tempora maxime natus est quisquam. Enim iste autem quas tempore nihil sed voluptate et. Natus amet porro velit suscipit similique rerum. Sunt ab sunt temporibus. Et nisi quia.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 71, new DateTime(2020, 4, 9, 6, 9, 19, 264, DateTimeKind.Local).AddTicks(7544), "Adipisci officia dicta dicta blanditiis dolorum magnam pariatur minus. Numquam accusamus sed ipsam ut dolorem necessitatibus porro et debitis. Consequuntur maiores non ut quod nihil.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 70, new DateTime(2020, 2, 29, 20, 55, 52, 409, DateTimeKind.Local).AddTicks(5926), "Libero assumenda veniam. Dignissimos dicta non. Omnis iste qui est molestiae reprehenderit quos voluptatem ab. Ut sit qui qui ut placeat. Rem quaerat quidem quae vero cum architecto deleniti. Et officia velit et non dolorum.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 69, new DateTime(2019, 11, 9, 5, 5, 27, 146, DateTimeKind.Local).AddTicks(7667), "Non quis dolorem qui laudantium provident ex eligendi. Aut nihil et ratione sunt quidem ut et. Voluptatum culpa id.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 68, new DateTime(2020, 1, 23, 5, 16, 15, 997, DateTimeKind.Local).AddTicks(9095), "Natus autem error excepturi aut voluptates qui molestiae. Iure aut ex voluptatem enim quia. Ut natus recusandae qui quod. Quis molestiae ad consequatur saepe et. Voluptas porro esse est odit nostrum ut sed voluptatibus.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 67, new DateTime(2020, 4, 28, 16, 7, 37, 764, DateTimeKind.Local).AddTicks(9162), "Velit blanditiis nihil libero. Excepturi aut earum quia dolores voluptas pariatur sint. Dolores sit in. Rerum aspernatur repudiandae atque. Quam omnis id nam.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 66, new DateTime(2019, 8, 8, 3, 26, 35, 611, DateTimeKind.Local).AddTicks(5803), "Sint dolores beatae laudantium natus reiciendis sit in ut. Et tempore quia itaque. Quasi est sed et voluptatum eaque et in aut. Incidunt in illo itaque magnam voluptas iusto quos temporibus neque. Voluptate voluptas necessitatibus.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 64, new DateTime(2020, 2, 17, 0, 29, 11, 260, DateTimeKind.Local).AddTicks(425), "Nihil maxime dignissimos doloremque et quae repudiandae. Error repellat exercitationem. Culpa et voluptatem sit consequuntur quia qui sint dolores. Autem officiis voluptatum saepe ab maiores architecto quaerat eveniet. Fuga alias dolores atque et quia. Et voluptas sint eum.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 53, new DateTime(2019, 12, 27, 15, 50, 28, 773, DateTimeKind.Local).AddTicks(2589), "Sapiente perferendis consectetur minima at. Similique laborum quis deserunt omnis. Laboriosam inventore hic est voluptate sapiente est aut.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 62, new DateTime(2020, 1, 21, 18, 46, 2, 912, DateTimeKind.Local).AddTicks(5792), "Temporibus voluptas voluptas enim. Est magni veritatis dolorem doloribus et. Odit harum qui optio quae. Dolorem unde quidem laboriosam sed delectus. Maxime suscipit eos iusto est consequatur et aspernatur aperiam deleniti. Pariatur exercitationem dolorem debitis doloribus sint consequatur velit.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 61, new DateTime(2020, 5, 12, 15, 42, 17, 400, DateTimeKind.Local).AddTicks(9001), "Et debitis qui voluptatibus impedit rerum magnam harum. Sit iste necessitatibus repellat quaerat ut. Laborum error exercitationem cupiditate sed voluptatibus. Consectetur sit qui sed repudiandae dolores itaque.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 60, new DateTime(2019, 12, 9, 7, 22, 16, 181, DateTimeKind.Local).AddTicks(5389), "Molestiae repellat similique nulla nam. Maxime voluptatibus quam eveniet omnis odio. Unde eligendi quia consequatur ut hic.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 59, new DateTime(2019, 9, 26, 0, 49, 29, 866, DateTimeKind.Local).AddTicks(4449), "Fuga nam deleniti. Error aut recusandae asperiores ea unde porro nihil aut quam. Quod impedit ratione.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 58, new DateTime(2019, 9, 11, 16, 10, 35, 167, DateTimeKind.Local).AddTicks(2985), "Et iure quisquam atque consectetur est. Aperiam ipsa et reprehenderit sint. Autem est sed aut sunt ut. Quo recusandae delectus voluptas veritatis nesciunt. In necessitatibus rem. Earum libero nesciunt qui est unde eaque voluptates rem.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 57, new DateTime(2020, 1, 17, 6, 0, 24, 980, DateTimeKind.Local).AddTicks(2313), "Vel eaque voluptatum recusandae iure. Tempore non voluptate est dolores soluta. Est voluptatem necessitatibus ut sunt. Laboriosam et praesentium perspiciatis aut neque. Occaecati aut et aut necessitatibus. Porro totam perspiciatis nesciunt vero expedita soluta.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 56, new DateTime(2019, 12, 11, 19, 8, 33, 548, DateTimeKind.Local).AddTicks(8721), "Voluptas et adipisci suscipit deserunt quasi eum sit. Sed aut ratione quasi. Sunt excepturi distinctio.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 55, new DateTime(2020, 1, 21, 19, 17, 31, 921, DateTimeKind.Local).AddTicks(5975), "Inventore possimus voluptas reprehenderit totam nostrum aut sit optio praesentium. Dolorum voluptatem aut. Magnam laboriosam sint autem ipsa. Est neque eligendi consequatur veniam sed ut modi. Reprehenderit architecto non excepturi modi eum facilis. Cupiditate beatae distinctio et dolore incidunt corporis est laborum.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 54, new DateTime(2020, 4, 29, 23, 3, 17, 394, DateTimeKind.Local).AddTicks(1420), "Fuga eum adipisci pariatur corporis est architecto voluptatem aut. Neque non distinctio similique quas maxime. Cum tempore at odit ut sint et maxime ut. Laborum non quos in minima qui velit tempora doloribus quis. Maiores rerum est velit tempora harum temporibus voluptas maxime.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 73, new DateTime(2020, 1, 2, 0, 39, 55, 409, DateTimeKind.Local).AddTicks(2558), "Debitis dolor et aut ea corrupti. Vitae cumque et iste praesentium. Et ea officiis eaque sunt. Et molestiae natus tempore ullam occaecati totam qui.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 52, new DateTime(2019, 8, 22, 17, 2, 35, 702, DateTimeKind.Local).AddTicks(1354), "Quia qui impedit odio. Saepe ut eum animi. Consectetur non repellat modi. Velit commodi ab consequatur cum iste esse velit. Eum quia quia earum quam. Enim quam delectus ut et fugiat sunt reiciendis vero occaecati.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 63, new DateTime(2020, 6, 16, 15, 40, 37, 886, DateTimeKind.Local).AddTicks(5262), "Et tempore placeat. Aliquid deserunt ducimus tempora et eum qui enim asperiores. Natus dolorum natus incidunt architecto sequi quisquam pariatur. Laborum hic natus porro aut suscipit placeat qui et.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 74, new DateTime(2019, 12, 16, 19, 45, 13, 494, DateTimeKind.Local).AddTicks(2293), "Est quia soluta consequatur pariatur. Aut vitae expedita. Iure et sit. Aut eaque maiores magnam et. Corrupti culpa repellat voluptatem molestias.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 85, new DateTime(2020, 2, 9, 10, 41, 59, 862, DateTimeKind.Local).AddTicks(3865), "Veniam unde dolorem in reprehenderit ad consequatur et sapiente vero. Aperiam sit eos. Pariatur aliquid a ad.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 76, new DateTime(2020, 2, 23, 1, 49, 57, 557, DateTimeKind.Local).AddTicks(7558), "Dolores veniam quos dicta id. Sint dignissimos similique quisquam natus cumque aut. Modi tempore magnam voluptates et et voluptatem enim.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 98, new DateTime(2019, 12, 15, 20, 27, 14, 38, DateTimeKind.Local).AddTicks(7979), "Earum ut esse. Cumque sunt provident et occaecati et sit quo asperiores. Asperiores nostrum corporis dolorem quia aut voluptatum atque aliquid. Voluptatum sit ullam assumenda occaecati. Asperiores distinctio aspernatur rerum odit id doloribus.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 51, new DateTime(2019, 12, 7, 5, 51, 43, 453, DateTimeKind.Local).AddTicks(1009), "Ipsam ipsam molestiae ad at numquam consequuntur. Praesentium esse perferendis soluta deleniti dolor aperiam. In pariatur ex nihil qui officiis amet provident molestiae. Laborum non in non esse temporibus. Veniam quam voluptatibus esse quisquam nostrum earum nostrum ducimus quos. Velit maiores illo.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 97, new DateTime(2019, 10, 4, 14, 53, 15, 230, DateTimeKind.Local).AddTicks(1318), "Similique repellendus reprehenderit expedita alias quae accusamus ea nulla. Dicta beatae veritatis omnis non. Molestiae fuga sint corporis incidunt.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 96, new DateTime(2019, 8, 7, 1, 9, 12, 913, DateTimeKind.Local).AddTicks(7568), "Illo porro et iure. Illum sunt et quisquam dolores repellat pariatur. Optio voluptatem praesentium velit ab ut dolore aut quidem.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 95, new DateTime(2019, 12, 10, 23, 37, 21, 621, DateTimeKind.Local).AddTicks(7209), "Omnis deserunt vitae rerum sequi. Voluptate rerum qui quam explicabo veritatis impedit dolorem. Sit labore soluta soluta eaque provident voluptatem. Incidunt sit praesentium error rerum voluptatum cum. Pariatur sit quasi et dolorum consequatur dolorem non aut aliquam.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 94, new DateTime(2020, 1, 20, 17, 4, 10, 527, DateTimeKind.Local).AddTicks(9543), "Cumque natus id laborum excepturi incidunt modi. Ipsum quae sint. Dolorum accusamus voluptas nobis numquam qui. Vitae eum nam. Laboriosam perferendis minima. Voluptas perspiciatis tempora sunt.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 93, new DateTime(2019, 12, 1, 18, 45, 11, 236, DateTimeKind.Local).AddTicks(2), "Illo perferendis sed magni voluptatem minima reprehenderit illum commodi. Mollitia sed vel dolorem. Recusandae dolore et porro recusandae eaque molestias.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 92, new DateTime(2019, 9, 26, 14, 55, 42, 634, DateTimeKind.Local).AddTicks(4936), "Corrupti ea maiores. Sit saepe odio et adipisci dolor iste non cum. Tempora nesciunt rerum occaecati amet molestiae. Quis voluptatem neque amet magnam est rerum. Voluptatem qui quae quam quae ipsum laudantium et et sapiente.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 91, new DateTime(2020, 3, 18, 18, 27, 42, 128, DateTimeKind.Local).AddTicks(3043), "Distinctio ratione voluptatem dolorem consequuntur explicabo quibusdam a nam. Soluta sed impedit consequatur assumenda velit dolores dolore. Laboriosam animi atque deserunt. Ratione distinctio et. Aut qui voluptatum aliquam laborum suscipit voluptatibus est. Aut mollitia corrupti odio.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 90, new DateTime(2020, 5, 30, 6, 25, 5, 344, DateTimeKind.Local).AddTicks(1925), "Est cupiditate ut voluptas ut quo in eveniet atque. Consequatur consequatur at ad reprehenderit adipisci blanditiis et qui. Magni facilis facere quos impedit quisquam qui. Exercitationem alias non enim. Adipisci voluptate possimus sit.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 75, new DateTime(2019, 10, 11, 23, 7, 52, 27, DateTimeKind.Local).AddTicks(2247), "Provident rerum et exercitationem. Odit recusandae ex accusantium tenetur fugit culpa ratione vel. Labore veniam amet nam. Quia ullam consequuntur.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 89, new DateTime(2020, 4, 9, 4, 44, 7, 132, DateTimeKind.Local).AddTicks(1260), "Dolor minima rerum sit tempore. Laborum qui aut aut dolorem. Nihil quia ut cumque tenetur nihil ducimus quia quos. Voluptates aperiam illo minima dicta sequi aut minima provident. Ratione hic et adipisci reiciendis quis consectetur voluptatem.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 87, new DateTime(2020, 5, 1, 7, 7, 1, 992, DateTimeKind.Local).AddTicks(3343), "Dolorem aliquam eius aperiam ea. Qui cupiditate ipsa illum labore sint. Molestiae cupiditate maiores dolor tenetur fugit labore voluptatem.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 86, new DateTime(2020, 6, 27, 19, 36, 52, 689, DateTimeKind.Local).AddTicks(8893), "Et error quaerat eum repudiandae ut omnis quae ut. Rerum facere neque quis rerum quaerat et dolorum repudiandae natus. Distinctio aut aut corporis accusamus qui occaecati non ipsam. Fugit assumenda voluptatibus suscipit eum sit. Sit eligendi explicabo perferendis. Magni modi deleniti.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 84, new DateTime(2020, 1, 28, 16, 5, 42, 656, DateTimeKind.Local).AddTicks(2415), "Sunt voluptates sunt. Repellendus provident fugiat eaque nostrum consequatur minima corporis quae. Nihil voluptas eligendi et. Et et ut pariatur illo. Et ullam maiores est suscipit provident molestias eos debitis. Et optio magni nam provident porro.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 83, new DateTime(2020, 5, 8, 16, 46, 24, 240, DateTimeKind.Local).AddTicks(5958), "Pariatur esse minus debitis qui et molestias. Temporibus rerum qui et omnis quo voluptas et commodi. Voluptas placeat provident neque.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 82, new DateTime(2020, 7, 18, 14, 58, 57, 171, DateTimeKind.Local).AddTicks(9057), "Facilis ut est rem nesciunt occaecati. Minima qui aut quo. Sunt autem ab recusandae explicabo quis molestias qui. Culpa aliquid rerum. Perspiciatis sequi aperiam hic nihil deleniti omnis quidem. Molestiae dolor et alias laudantium.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 81, new DateTime(2020, 5, 27, 20, 42, 37, 95, DateTimeKind.Local).AddTicks(6894), "Similique vitae debitis. Nulla pariatur eum vel temporibus nemo. Pariatur ea eos quasi vitae et voluptatum fuga. Dolore provident et non error dolores nemo tempore dolor voluptas.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 80, new DateTime(2019, 12, 25, 23, 31, 19, 380, DateTimeKind.Local).AddTicks(946), "Maxime quo illo est. Quia voluptatem aut ut inventore et omnis quidem error. Et et magni.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 79, new DateTime(2019, 8, 22, 4, 16, 3, 940, DateTimeKind.Local).AddTicks(1674), "Culpa aut officia. Est consectetur voluptatum est deserunt. Repudiandae autem vero aut. Harum quis corporis animi voluptatem dolorem consequuntur quaerat id.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 78, new DateTime(2020, 3, 5, 11, 6, 16, 941, DateTimeKind.Local).AddTicks(3209), "Tempora consequatur dicta eos. In veniam fuga dicta velit eveniet. Non est atque non modi quasi illum facere quam. Porro dolor quaerat ut velit nesciunt commodi. Distinctio maiores consequatur ea et.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 77, new DateTime(2019, 9, 8, 18, 33, 30, 844, DateTimeKind.Local).AddTicks(7225), "Incidunt illum deleniti cupiditate nam non sunt vero quod praesentium. Voluptas et eos. Tempore error fuga delectus alias perspiciatis architecto qui.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 88, new DateTime(2020, 7, 19, 20, 55, 54, 194, DateTimeKind.Local).AddTicks(569), "Voluptatibus qui dolorem sit iure molestias molestias. Quidem eos unde. Non autem similique et quis debitis vero et esse cumque. Quos molestias aut eveniet dolor rerum sed aperiam. Et consequatur rem et cumque eos et minus consequatur. Temporibus nam odio incidunt voluptatem quod tempore.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 50, new DateTime(2019, 7, 20, 22, 32, 56, 710, DateTimeKind.Local).AddTicks(4375), "Qui asperiores excepturi quia eos dolorem et. Mollitia consequatur consequuntur qui neque exercitationem esse quia qui vel. Ullam voluptas repellat ratione sequi esse eaque hic. Nihil libero provident sint et omnis.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 26, new DateTime(2019, 11, 9, 16, 24, 14, 338, DateTimeKind.Local).AddTicks(6151), "Occaecati nulla ut animi aliquid tempore minima. Et dolores distinctio iste et sequi nulla. Nihil ipsa aut molestias. Fuga id ipsum. Necessitatibus dolor et illo numquam et omnis harum qui.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 48, new DateTime(2020, 1, 8, 20, 17, 24, 644, DateTimeKind.Local).AddTicks(4863), "Illo numquam ipsa tempore aut aut quidem eligendi dolores veniam. Illum et nihil exercitationem dolores. Error at quaerat alias aut magnam.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 20, new DateTime(2020, 6, 20, 12, 26, 34, 279, DateTimeKind.Local).AddTicks(8070), "Consequuntur sint autem distinctio pariatur maiores ea non. Aliquid ullam consectetur reiciendis necessitatibus quia quasi aut omnis magni. Est cum voluptas error sed quo neque. Aut laboriosam cupiditate odit nulla quasi nihil.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 19, new DateTime(2020, 7, 1, 7, 59, 59, 448, DateTimeKind.Local).AddTicks(7701), "Et est voluptatem in. Fugit assumenda unde inventore debitis ut quis sequi qui. Harum nihil minus dolores sint ipsa quis et.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 18, new DateTime(2020, 4, 3, 8, 2, 10, 630, DateTimeKind.Local).AddTicks(8581), "Dolor sunt repellat beatae amet enim. Aut non dolorem nemo placeat odio dolor rerum quasi. Veniam dolorem consequatur nemo.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 17, new DateTime(2020, 7, 5, 16, 26, 51, 584, DateTimeKind.Local).AddTicks(6550), "Corrupti distinctio sint omnis nam qui voluptatibus atque in quis. Sunt accusamus id dolor qui est architecto at officia. Sit repudiandae aperiam in fuga sit. Ab dolorum velit omnis quos nobis suscipit ea aperiam omnis. Unde voluptas voluptatibus voluptas delectus delectus ducimus laboriosam at ut. Aliquid ut odio voluptatem deleniti totam placeat aut.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 16, new DateTime(2019, 7, 29, 14, 42, 22, 190, DateTimeKind.Local).AddTicks(9698), "Ut officia qui. Hic cupiditate sunt. Qui totam labore magnam quod sit non blanditiis quisquam rerum.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 15, new DateTime(2019, 8, 13, 22, 8, 35, 724, DateTimeKind.Local).AddTicks(3225), "Recusandae libero aut sint reiciendis aliquam dolorum. Voluptatem quibusdam placeat dolorem. Ex dolores molestiae est esse veritatis praesentium voluptas. Praesentium nihil velit explicabo non facilis pariatur voluptate necessitatibus quaerat. Omnis mollitia fugiat rem.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 14, new DateTime(2019, 9, 1, 5, 54, 49, 254, DateTimeKind.Local).AddTicks(4098), "Est quo est error debitis commodi non quas. Unde repudiandae sint autem non. Eum sunt nulla facilis debitis quasi et.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 13, new DateTime(2020, 7, 3, 20, 46, 8, 779, DateTimeKind.Local).AddTicks(9076), "Mollitia dignissimos at repellendus aut molestiae doloribus nulla voluptas alias. Perferendis incidunt excepturi harum voluptatem dolores consequuntur impedit tenetur aut. Nihil omnis quasi sed officia numquam veniam. Quidem blanditiis excepturi debitis delectus quisquam nisi laboriosam repudiandae aspernatur. Enim cumque inventore rerum alias minima nesciunt. Voluptatibus aliquam illo cupiditate voluptas.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 12, new DateTime(2020, 5, 15, 20, 20, 53, 429, DateTimeKind.Local).AddTicks(7701), "Aliquam dolor cupiditate ex illum est nemo possimus. Dolorem velit quia necessitatibus cupiditate iste nesciunt. Inventore accusamus perferendis molestias libero sapiente et.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 11, new DateTime(2019, 10, 16, 8, 15, 16, 844, DateTimeKind.Local).AddTicks(4730), "Adipisci illum tempore quia maiores. Quibusdam praesentium quaerat. Incidunt molestias ipsa.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 10, new DateTime(2019, 11, 13, 16, 27, 12, 475, DateTimeKind.Local).AddTicks(8869), "Tempore dolore quis nobis asperiores sunt quia. Provident quod debitis perspiciatis laboriosam quos quod omnis. Facilis adipisci laudantium nemo sint est quia atque.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 9, new DateTime(2019, 7, 20, 21, 40, 39, 728, DateTimeKind.Local).AddTicks(6838), "Ad sequi inventore non nulla. Repellendus et ut quos occaecati voluptas distinctio exercitationem rerum soluta. Animi adipisci fugiat. Itaque distinctio voluptatem dolorem qui aliquam officia odio incidunt. Fugiat quidem quia nihil sed repellat itaque.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 8, new DateTime(2020, 6, 3, 8, 29, 38, 510, DateTimeKind.Local).AddTicks(1022), "Libero explicabo et debitis sunt dolorem dicta vel corrupti perspiciatis. Voluptas inventore cumque. Nisi perspiciatis cumque ex inventore accusamus quasi eveniet quibusdam. Voluptatem dolorem assumenda. Ut nostrum praesentium rerum.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 7, new DateTime(2019, 7, 21, 22, 18, 18, 525, DateTimeKind.Local).AddTicks(2657), "Omnis quis cumque fuga quibusdam et. Laboriosam et consequatur. Ratione enim sit dignissimos eum incidunt mollitia consectetur quis amet.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 6, new DateTime(2019, 10, 20, 18, 1, 57, 156, DateTimeKind.Local).AddTicks(1256), "Laudantium mollitia voluptate sed nesciunt nostrum dicta quis minima. Sit qui eligendi vitae accusamus asperiores veritatis. Earum ratione architecto iusto quaerat neque quo. Qui omnis eaque fugiat. Hic at et quibusdam soluta temporibus et suscipit. Dolor ea nisi et.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 5, new DateTime(2020, 4, 9, 0, 20, 19, 81, DateTimeKind.Local).AddTicks(5973), "Laudantium harum eaque. Veniam quae qui amet. Sint et quis. Minima velit enim dolores dolores. Est dolorum quia totam velit. Qui ut perspiciatis.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 4, new DateTime(2020, 2, 11, 21, 47, 49, 742, DateTimeKind.Local).AddTicks(7797), "Quisquam occaecati inventore ipsa et. In magni tenetur laudantium est optio. Veritatis nisi ratione consectetur sit.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 3, new DateTime(2019, 11, 13, 9, 4, 16, 101, DateTimeKind.Local).AddTicks(5552), "Qui ut officia ad sit asperiores numquam velit. Consequuntur deleniti et nulla. Molestias consequatur in eos minima et quos laboriosam assumenda blanditiis. Accusamus eum sint nesciunt explicabo. Suscipit et excepturi rerum quasi qui qui vitae vel. Qui aut atque velit.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 2, new DateTime(2019, 11, 22, 5, 38, 8, 358, DateTimeKind.Local).AddTicks(9177), "Laborum esse maiores consequatur. Aut eum eos ut laborum saepe. Non ipsam molestias dolorem.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 1, new DateTime(2020, 2, 10, 9, 17, 50, 103, DateTimeKind.Local).AddTicks(8555), "Dicta suscipit est. Voluptas qui eligendi labore id unde similique sequi occaecati dicta. Molestiae autem qui iste dicta amet aliquid. Vel aliquid corrupti in optio accusantium voluptas.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 99, new DateTime(2020, 2, 2, 6, 50, 18, 985, DateTimeKind.Local).AddTicks(8572), "Labore nam voluptatem officia et quo nemo itaque expedita fuga. Qui in blanditiis sint magni laboriosam. Enim omnis perspiciatis repudiandae officiis. Quod ab optio reprehenderit corporis enim sunt aut. Deleniti dolore nobis ut rerum cumque.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 21, new DateTime(2019, 7, 24, 22, 8, 37, 552, DateTimeKind.Local).AddTicks(9047), "Dolor molestias tempore architecto. Earum sed voluptatem dolorem minus quo. Et nobis ab ducimus tempore. Praesentium dolores dolorem eum. Dolorum dolorem adipisci ut voluptates totam.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 22, new DateTime(2019, 12, 3, 23, 22, 52, 525, DateTimeKind.Local).AddTicks(2649), "Ea eos consequatur assumenda magni quaerat quia aut voluptate architecto. Incidunt deleniti nesciunt sit reiciendis officiis at pariatur. Nisi ut aut illo dolore labore.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 23, new DateTime(2019, 8, 1, 11, 31, 33, 72, DateTimeKind.Local).AddTicks(6773), "Sint illo libero veniam voluptates odio et aut. Sapiente vel quam suscipit. Deserunt quo consectetur saepe corrupti nihil eos rerum at et. Eaque tenetur occaecati. Libero unde voluptas illum sit impedit dolor vel debitis odit.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 24, new DateTime(2020, 3, 1, 16, 3, 56, 886, DateTimeKind.Local).AddTicks(6696), "Provident molestiae assumenda veritatis expedita non. Minus adipisci rerum est aut velit. Tempora officiis corrupti. Non provident esse corrupti id alias. Esse eveniet enim temporibus tenetur.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 47, new DateTime(2020, 1, 1, 14, 3, 30, 513, DateTimeKind.Local).AddTicks(9209), "Animi sit omnis cumque alias distinctio placeat ab vel sit. Voluptatem sunt quia temporibus. Velit nihil consequatur. Unde eaque sit et. Doloribus velit aspernatur occaecati quas laudantium totam voluptatem.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 46, new DateTime(2020, 6, 4, 4, 48, 21, 748, DateTimeKind.Local).AddTicks(5402), "Inventore illum consectetur quam nesciunt deserunt assumenda. Aliquid voluptatem nihil. Cumque illo debitis autem quisquam amet veniam accusamus voluptas. Ea explicabo eveniet.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 45, new DateTime(2020, 4, 29, 19, 58, 30, 886, DateTimeKind.Local).AddTicks(2510), "Iste ut modi sint earum sed ex id consectetur. Inventore officiis illo asperiores tempore nemo voluptas voluptas. Sit omnis sed qui et magni et. Voluptatum earum totam. Est alias non molestiae enim numquam accusamus. Deleniti aut eaque.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 44, new DateTime(2019, 8, 17, 23, 5, 14, 659, DateTimeKind.Local).AddTicks(9889), "Doloremque eum odit voluptatum. Maxime omnis illum sed quam iste distinctio est voluptatum vel. Fugit delectus dignissimos expedita laudantium ut tenetur ab deleniti. Iusto repellendus illo mollitia. Omnis praesentium hic tempore. Mollitia illo quos et.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 43, new DateTime(2020, 3, 25, 13, 26, 17, 928, DateTimeKind.Local).AddTicks(6607), "Dignissimos optio maiores dolores beatae. Dolorem iste a corporis eos nihil architecto nihil non. Dolore id quod in quis qui. Maxime optio exercitationem repellendus.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 42, new DateTime(2020, 2, 28, 10, 19, 31, 72, DateTimeKind.Local).AddTicks(6658), "Aut incidunt aliquam optio nemo quia consequatur. Nihil ut et sit distinctio officiis. Voluptas accusamus eligendi accusamus labore reprehenderit in sequi. Ipsum ut debitis harum et accusantium aut. Delectus repudiandae dolor qui perspiciatis rerum quis.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 41, new DateTime(2020, 4, 20, 16, 9, 12, 304, DateTimeKind.Local).AddTicks(7256), "Rerum praesentium illum est modi suscipit molestias. Minima nobis quibusdam laboriosam soluta vel. Mollitia autem tempore ut debitis facilis consequatur eum dolorem.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 40, new DateTime(2019, 9, 21, 18, 8, 22, 387, DateTimeKind.Local).AddTicks(6632), "Vero consequatur dolorem numquam ratione sunt labore est. Sequi et consequuntur. Quis soluta repellat maiores.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 39, new DateTime(2020, 4, 3, 17, 28, 50, 779, DateTimeKind.Local).AddTicks(3817), "Quisquam aut et. Voluptas ipsa delectus in maxime hic sunt sed illum. Consequatur earum et officia similique placeat neque. Nostrum et dolorum quas sed.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 38, new DateTime(2020, 1, 24, 5, 38, 33, 444, DateTimeKind.Local).AddTicks(6828), "Quia provident consequatur sed ipsam. Magni rerum consequatur sequi illo unde. Omnis esse beatae minus quasi. Dolor beatae ullam voluptates et qui quibusdam dolores.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 49, new DateTime(2020, 4, 4, 15, 3, 15, 337, DateTimeKind.Local).AddTicks(5735), "Eum sequi sunt omnis inventore velit consequatur temporibus sed. Incidunt tempora et consequatur dolores consequuntur autem nihil quaerat omnis. Dolorem doloremque maiores iure. Asperiores quae delectus reprehenderit qui non iure accusamus eos. Quo facere possimus fugiat suscipit.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 37, new DateTime(2019, 9, 24, 12, 50, 59, 5, DateTimeKind.Local).AddTicks(4150), "Recusandae suscipit qui deserunt consectetur ipsum et quos eaque. Magni vel quo dolore quis eos quibusdam veniam enim asperiores. Et laborum autem molestiae saepe aliquid id ab. Facere animi autem porro non vero qui sequi. Sed itaque neque deleniti fugiat autem nulla neque veniam consequatur. Deserunt blanditiis est officiis dolores magni quisquam distinctio libero.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 35, new DateTime(2020, 3, 10, 13, 21, 54, 313, DateTimeKind.Local).AddTicks(8187), "Sed recusandae itaque dolores adipisci laboriosam tempora non dolorum. Velit nulla in quidem. Omnis itaque magni cupiditate et quia aliquam maxime facere. Sunt ab distinctio ad aut blanditiis eligendi dolorum. Aut deleniti ipsa unde reprehenderit error.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 34, new DateTime(2019, 12, 5, 4, 28, 46, 576, DateTimeKind.Local).AddTicks(3517), "Omnis exercitationem dolorem. Esse voluptatibus ipsa officia. Temporibus quis itaque expedita dolores repellat exercitationem sint aut error.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 33, new DateTime(2020, 2, 1, 7, 48, 47, 818, DateTimeKind.Local).AddTicks(5056), "Culpa et eligendi assumenda. Voluptas reiciendis qui error eos consectetur possimus voluptatibus. Molestiae modi dolores consectetur in magnam maxime eum.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 32, new DateTime(2020, 3, 29, 12, 30, 26, 169, DateTimeKind.Local).AddTicks(4472), "Exercitationem adipisci molestiae sed facere dolorem. Dolorem consequatur atque inventore expedita. Voluptatum eos eos autem repellat quia reiciendis nisi sint eveniet.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 31, new DateTime(2020, 2, 2, 10, 44, 21, 674, DateTimeKind.Local).AddTicks(8755), "Eligendi voluptatum vitae ea. Distinctio rerum maiores blanditiis id maxime voluptatum pariatur est itaque. Et tempora possimus id vel. Est repudiandae quia dolorem. Sequi non quibusdam placeat enim suscipit doloribus in earum. Voluptatem rerum labore nihil omnis pariatur iure est rerum et.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 30, new DateTime(2019, 11, 25, 19, 5, 29, 592, DateTimeKind.Local).AddTicks(5121), "Quia magni tempora sunt esse aut. Debitis eveniet ut ut corporis quia rem ea. Porro ea velit.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 29, new DateTime(2019, 12, 29, 18, 2, 56, 748, DateTimeKind.Local).AddTicks(7199), "Est beatae et. Quaerat voluptates odit et hic. Praesentium pariatur eum atque sint.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 28, new DateTime(2020, 3, 21, 21, 52, 29, 28, DateTimeKind.Local).AddTicks(6693), "Voluptatum omnis repellendus consequuntur ut accusamus debitis quaerat. Ut ipsum qui possimus tempore incidunt possimus. Maxime officia sequi quia totam rerum voluptates tempora.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 27, new DateTime(2019, 9, 3, 23, 40, 50, 359, DateTimeKind.Local).AddTicks(3095), "Est atque ut consequatur quos et reprehenderit laboriosam. Autem excepturi nisi et nostrum explicabo atque saepe aut aspernatur. Praesentium saepe omnis quos eius suscipit odit molestiae. Dicta voluptatem ipsam perferendis ut sequi.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 25, new DateTime(2019, 8, 2, 21, 57, 44, 73, DateTimeKind.Local).AddTicks(5205), "Consequuntur enim saepe. Commodi voluptatem vel dolores non est id voluptatibus voluptas. Incidunt ab qui ut quia aut quae quia. Dolor labore et sunt rerum et voluptatem modi soluta.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 36, new DateTime(2019, 10, 24, 5, 3, 54, 457, DateTimeKind.Local).AddTicks(7881), "Voluptatem eveniet debitis doloremque repellendus. Dolores natus et. Eos consectetur sit placeat odit nostrum similique. Sint quibusdam molestias tempora alias non exercitationem minus.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 100, new DateTime(2019, 12, 29, 5, 56, 39, 234, DateTimeKind.Local).AddTicks(8118), "Magnam sint consequatur et nobis. Eligendi tempora dolore repellendus blanditiis quia temporibus aliquid pariatur. Sit repudiandae harum eum illo id sequi. Quia incidunt eos. Libero nobis ullam sapiente sapiente molestias. Modi soluta ipsa impedit dignissimos culpa.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 7, 20, 21, 33, 48, 169, DateTimeKind.Local).AddTicks(6448), new DateTime(2020, 7, 21, 7, 52, 50, 271, DateTimeKind.Local).AddTicks(4815), new DateTime(2020, 7, 21, 15, 20, 45, 924, DateTimeKind.Local).AddTicks(8752), 38, "", "http://gabriel.info", "tenetur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 7, 21, 6, 40, 59, 563, DateTimeKind.Local).AddTicks(5317), new DateTime(2020, 7, 20, 22, 50, 0, 540, DateTimeKind.Local).AddTicks(4955), new DateTime(2020, 7, 21, 16, 42, 41, 210, DateTimeKind.Local).AddTicks(8635), 76, "", "https://maxence.eu", "ipsam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 7, 21, 11, 40, 20, 397, DateTimeKind.Local).AddTicks(1727), new DateTime(2020, 7, 21, 9, 13, 53, 213, DateTimeKind.Local).AddTicks(8924), new DateTime(2020, 7, 20, 22, 30, 31, 334, DateTimeKind.Local).AddTicks(7406), 73, "", "http://océane.net", "reprehenderit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 7, 21, 1, 17, 46, 82, DateTimeKind.Local).AddTicks(7551), new DateTime(2020, 7, 20, 22, 27, 29, 553, DateTimeKind.Local).AddTicks(7770), new DateTime(2020, 7, 20, 21, 47, 21, 437, DateTimeKind.Local).AddTicks(4884), 72, "", "https://lisa.info", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 7, 21, 0, 39, 51, 56, DateTimeKind.Local).AddTicks(9393), new DateTime(2020, 7, 20, 18, 0, 31, 972, DateTimeKind.Local).AddTicks(9638), new DateTime(2020, 7, 21, 3, 14, 42, 1, DateTimeKind.Local).AddTicks(391), 72, "", "http://emilie.info", "nostrum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 7, 21, 10, 13, 43, 47, DateTimeKind.Local).AddTicks(3220), new DateTime(2020, 7, 21, 6, 38, 4, 624, DateTimeKind.Local).AddTicks(4763), new DateTime(2020, 7, 20, 21, 30, 49, 268, DateTimeKind.Local).AddTicks(2234), 72, "", "https://carla.net", "repellat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 7, 21, 12, 42, 53, 256, DateTimeKind.Local).AddTicks(9720), new DateTime(2020, 7, 21, 10, 30, 49, 11, DateTimeKind.Local).AddTicks(5584), new DateTime(2020, 7, 21, 12, 21, 1, 386, DateTimeKind.Local).AddTicks(6401), 71, "", "http://ines.info", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 7, 21, 3, 35, 18, 350, DateTimeKind.Local).AddTicks(3985), new DateTime(2020, 7, 21, 0, 40, 48, 771, DateTimeKind.Local).AddTicks(8977), new DateTime(2020, 7, 21, 15, 44, 43, 971, DateTimeKind.Local).AddTicks(6137), 69, "", "https://adam.fr", "vitae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 7, 21, 11, 40, 37, 168, DateTimeKind.Local).AddTicks(9476), new DateTime(2020, 7, 20, 23, 41, 51, 219, DateTimeKind.Local).AddTicks(4625), new DateTime(2020, 7, 21, 11, 7, 15, 930, DateTimeKind.Local).AddTicks(3970), 67, "", "http://maeva.info", "ullam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 7, 20, 23, 42, 41, 28, DateTimeKind.Local).AddTicks(708), new DateTime(2020, 7, 21, 0, 45, 24, 599, DateTimeKind.Local).AddTicks(2109), new DateTime(2020, 7, 21, 17, 37, 6, 611, DateTimeKind.Local).AddTicks(4095), 66, "", "http://tom.info", "molestias" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 7, 21, 2, 12, 22, 149, DateTimeKind.Local).AddTicks(7239), new DateTime(2020, 7, 21, 16, 28, 50, 582, DateTimeKind.Local).AddTicks(596), new DateTime(2020, 7, 21, 10, 39, 54, 113, DateTimeKind.Local).AddTicks(5955), 64, "", "http://maëlys.fr", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 7, 21, 6, 6, 20, 103, DateTimeKind.Local).AddTicks(8866), new DateTime(2020, 7, 21, 13, 51, 39, 588, DateTimeKind.Local).AddTicks(705), new DateTime(2020, 7, 21, 12, 25, 46, 928, DateTimeKind.Local).AddTicks(9122), 61, "", "http://ines.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 7, 21, 2, 53, 14, 140, DateTimeKind.Local).AddTicks(8655), new DateTime(2020, 7, 21, 6, 7, 6, 305, DateTimeKind.Local).AddTicks(8213), new DateTime(2020, 7, 21, 14, 14, 52, 211, DateTimeKind.Local).AddTicks(2280), 76, "", "http://mélissa.eu", "quo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 7, 20, 17, 58, 50, 197, DateTimeKind.Local).AddTicks(3897), new DateTime(2020, 7, 20, 19, 47, 47, 526, DateTimeKind.Local).AddTicks(2883), new DateTime(2020, 7, 21, 4, 6, 44, 46, DateTimeKind.Local).AddTicks(9677), 58, "", "https://noah.net", "neque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 7, 21, 8, 4, 2, 223, DateTimeKind.Local).AddTicks(5627), new DateTime(2020, 7, 21, 1, 15, 48, 734, DateTimeKind.Local).AddTicks(4390), new DateTime(2020, 7, 21, 16, 57, 7, 751, DateTimeKind.Local).AddTicks(1146), 53, "", "https://noah.com", "dolor" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 7, 21, 5, 24, 28, 627, DateTimeKind.Local).AddTicks(9608), new DateTime(2020, 7, 21, 8, 25, 58, 167, DateTimeKind.Local).AddTicks(9762), new DateTime(2020, 7, 20, 20, 56, 57, 948, DateTimeKind.Local).AddTicks(5764), 52, "", "http://tom.eu", "quaerat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 7, 21, 8, 41, 5, 699, DateTimeKind.Local).AddTicks(3351), new DateTime(2020, 7, 21, 17, 18, 39, 397, DateTimeKind.Local).AddTicks(6207), new DateTime(2020, 7, 21, 14, 45, 19, 487, DateTimeKind.Local).AddTicks(2285), 51, "", "http://mohamed.eu", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 7, 21, 10, 44, 59, 261, DateTimeKind.Local).AddTicks(6437), new DateTime(2020, 7, 20, 22, 36, 7, 552, DateTimeKind.Local).AddTicks(1368), new DateTime(2020, 7, 21, 16, 42, 13, 77, DateTimeKind.Local).AddTicks(4033), 50, "", "http://mohamed.info", "odio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 7, 21, 10, 57, 16, 334, DateTimeKind.Local).AddTicks(5487), new DateTime(2020, 7, 20, 20, 20, 31, 566, DateTimeKind.Local).AddTicks(8288), new DateTime(2020, 7, 21, 15, 45, 18, 457, DateTimeKind.Local).AddTicks(7177), 50, "", "http://lucie.net", "eveniet" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 7, 21, 3, 46, 2, 54, DateTimeKind.Local).AddTicks(2101), new DateTime(2020, 7, 21, 15, 24, 24, 131, DateTimeKind.Local).AddTicks(3169), new DateTime(2020, 7, 21, 7, 21, 9, 942, DateTimeKind.Local).AddTicks(3624), 49, "", "http://mathéo.net", "vero" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 7, 21, 10, 43, 51, 225, DateTimeKind.Local).AddTicks(7243), new DateTime(2020, 7, 21, 2, 5, 7, 414, DateTimeKind.Local).AddTicks(2022), new DateTime(2020, 7, 21, 11, 21, 52, 425, DateTimeKind.Local).AddTicks(5448), 48, "", "https://lilou.fr", "optio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 7, 20, 20, 43, 26, 664, DateTimeKind.Local).AddTicks(3638), new DateTime(2020, 7, 21, 15, 31, 11, 580, DateTimeKind.Local).AddTicks(8224), new DateTime(2020, 7, 21, 13, 46, 26, 676, DateTimeKind.Local).AddTicks(4671), 44, "", "http://maxence.net", "esse" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 7, 20, 18, 20, 20, 887, DateTimeKind.Local).AddTicks(225), new DateTime(2020, 7, 20, 19, 55, 34, 918, DateTimeKind.Local).AddTicks(3546), new DateTime(2020, 7, 21, 13, 4, 35, 711, DateTimeKind.Local).AddTicks(387), 43, "", "https://julie.com", "quis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 7, 21, 1, 24, 20, 654, DateTimeKind.Local).AddTicks(7645), new DateTime(2020, 7, 20, 19, 0, 1, 963, DateTimeKind.Local).AddTicks(9749), new DateTime(2020, 7, 21, 12, 12, 59, 449, DateTimeKind.Local).AddTicks(6019), 41, "", "http://océane.net", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 7, 21, 6, 11, 17, 674, DateTimeKind.Local).AddTicks(8420), new DateTime(2020, 7, 21, 11, 11, 2, 411, DateTimeKind.Local).AddTicks(9021), new DateTime(2020, 7, 20, 23, 21, 29, 588, DateTimeKind.Local).AddTicks(4050), 39, "", "http://nicolas.org", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 7, 21, 11, 0, 53, 685, DateTimeKind.Local).AddTicks(6479), new DateTime(2020, 7, 21, 5, 8, 12, 83, DateTimeKind.Local).AddTicks(2612), new DateTime(2020, 7, 21, 9, 19, 36, 432, DateTimeKind.Local).AddTicks(6721), 54, "", "http://maëlys.name", "nisi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 7, 21, 10, 16, 44, 185, DateTimeKind.Local).AddTicks(6881), new DateTime(2020, 7, 21, 13, 53, 41, 237, DateTimeKind.Local).AddTicks(4824), new DateTime(2020, 7, 21, 13, 53, 56, 854, DateTimeKind.Local).AddTicks(8599), 78, "", "http://pierre.eu", "minus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 7, 20, 23, 45, 2, 211, DateTimeKind.Local).AddTicks(3756), new DateTime(2020, 7, 21, 6, 56, 17, 546, DateTimeKind.Local).AddTicks(7186), new DateTime(2020, 7, 20, 18, 59, 1, 344, DateTimeKind.Local).AddTicks(3627), 79, "", "http://charlotte.org", "perspiciatis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 7, 21, 0, 51, 22, 448, DateTimeKind.Local).AddTicks(1319), new DateTime(2020, 7, 21, 8, 36, 23, 946, DateTimeKind.Local).AddTicks(7364), new DateTime(2020, 7, 20, 18, 57, 10, 189, DateTimeKind.Local).AddTicks(261), 79, "", "https://clément.fr", "repellendus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 7, 21, 6, 10, 19, 503, DateTimeKind.Local).AddTicks(381), new DateTime(2020, 7, 21, 4, 47, 11, 738, DateTimeKind.Local).AddTicks(6202), new DateTime(2020, 7, 20, 21, 48, 53, 141, DateTimeKind.Local).AddTicks(2916), 98, "", "http://zoe.com", "reprehenderit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 7, 20, 18, 33, 24, 992, DateTimeKind.Local).AddTicks(2945), new DateTime(2020, 7, 20, 18, 12, 34, 469, DateTimeKind.Local).AddTicks(1646), new DateTime(2020, 7, 21, 5, 9, 38, 639, DateTimeKind.Local).AddTicks(6138), 98, "", "http://lena.name", "odit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 7, 20, 18, 37, 11, 908, DateTimeKind.Local).AddTicks(5100), new DateTime(2020, 7, 21, 12, 42, 44, 822, DateTimeKind.Local).AddTicks(8492), new DateTime(2020, 7, 20, 19, 1, 45, 681, DateTimeKind.Local).AddTicks(1265), 97, "", "http://mattéo.fr", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 7, 21, 8, 18, 26, 653, DateTimeKind.Local).AddTicks(6288), new DateTime(2020, 7, 20, 17, 49, 26, 374, DateTimeKind.Local).AddTicks(5986), new DateTime(2020, 7, 21, 13, 1, 24, 438, DateTimeKind.Local).AddTicks(4765), 97, "", "https://baptiste.org", "velit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 7, 20, 19, 6, 18, 872, DateTimeKind.Local).AddTicks(5655), new DateTime(2020, 7, 20, 22, 1, 36, 122, DateTimeKind.Local).AddTicks(3048), new DateTime(2020, 7, 20, 17, 53, 4, 827, DateTimeKind.Local).AddTicks(5196), 97, "", "https://alice.info", "ratione" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 7, 21, 4, 30, 32, 75, DateTimeKind.Local).AddTicks(1106), new DateTime(2020, 7, 21, 6, 35, 32, 433, DateTimeKind.Local).AddTicks(5881), new DateTime(2020, 7, 21, 10, 34, 4, 152, DateTimeKind.Local).AddTicks(9105), 96, "", "http://tom.org", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 7, 21, 16, 1, 37, 709, DateTimeKind.Local).AddTicks(293), new DateTime(2020, 7, 21, 10, 51, 53, 736, DateTimeKind.Local).AddTicks(9596), new DateTime(2020, 7, 20, 19, 56, 12, 88, DateTimeKind.Local).AddTicks(8233), 95, "", "http://mathis.name", "sit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 7, 21, 10, 43, 46, 131, DateTimeKind.Local).AddTicks(4919), new DateTime(2020, 7, 21, 13, 24, 35, 723, DateTimeKind.Local).AddTicks(7765), new DateTime(2020, 7, 21, 11, 51, 18, 293, DateTimeKind.Local).AddTicks(8257), 95, "", "http://jade.net", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 7, 21, 6, 40, 52, 619, DateTimeKind.Local).AddTicks(4668), new DateTime(2020, 7, 21, 3, 48, 49, 108, DateTimeKind.Local).AddTicks(936), new DateTime(2020, 7, 20, 23, 19, 12, 401, DateTimeKind.Local).AddTicks(6262), 95, "", "http://rayan.eu", "commodi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 7, 21, 17, 40, 19, 696, DateTimeKind.Local).AddTicks(721), new DateTime(2020, 7, 21, 9, 41, 21, 899, DateTimeKind.Local).AddTicks(1290), new DateTime(2020, 7, 20, 17, 50, 36, 81, DateTimeKind.Local).AddTicks(5062), 94, "", "http://noémie.com", "necessitatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 7, 20, 17, 49, 25, 555, DateTimeKind.Local).AddTicks(1141), new DateTime(2020, 7, 20, 23, 51, 50, 151, DateTimeKind.Local).AddTicks(9673), new DateTime(2020, 7, 20, 22, 25, 31, 953, DateTimeKind.Local).AddTicks(2975), 93, "", "http://nicolas.net", "at" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 7, 21, 14, 2, 10, 649, DateTimeKind.Local).AddTicks(1422), new DateTime(2020, 7, 21, 4, 35, 13, 56, DateTimeKind.Local).AddTicks(3323), new DateTime(2020, 7, 20, 18, 59, 55, 357, DateTimeKind.Local).AddTicks(5643), 93, "", "http://lola.com", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 7, 21, 0, 20, 40, 0, DateTimeKind.Local).AddTicks(3318), new DateTime(2020, 7, 21, 2, 40, 43, 490, DateTimeKind.Local).AddTicks(1814), new DateTime(2020, 7, 20, 23, 5, 18, 9, DateTimeKind.Local).AddTicks(6109), 92, "", "https://maxime.com", "voluptas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 7, 20, 19, 15, 27, 949, DateTimeKind.Local).AddTicks(1691), new DateTime(2020, 7, 21, 9, 29, 20, 597, DateTimeKind.Local).AddTicks(3566), new DateTime(2020, 7, 21, 13, 30, 43, 851, DateTimeKind.Local).AddTicks(3754), 92, "", "https://maëlys.net", "nesciunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 7, 21, 9, 27, 46, 372, DateTimeKind.Local).AddTicks(5695), new DateTime(2020, 7, 21, 3, 44, 14, 902, DateTimeKind.Local).AddTicks(6247), new DateTime(2020, 7, 21, 8, 8, 3, 930, DateTimeKind.Local).AddTicks(8371), 91, "", "http://charlotte.info", "cum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 7, 21, 16, 52, 10, 929, DateTimeKind.Local).AddTicks(2603), new DateTime(2020, 7, 20, 19, 45, 34, 634, DateTimeKind.Local).AddTicks(2522), new DateTime(2020, 7, 21, 8, 22, 29, 64, DateTimeKind.Local).AddTicks(7496), 89, "", "https://ambre.name", "quaerat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 7, 21, 11, 36, 21, 382, DateTimeKind.Local).AddTicks(2654), new DateTime(2020, 7, 21, 11, 25, 7, 968, DateTimeKind.Local).AddTicks(6990), new DateTime(2020, 7, 21, 12, 25, 42, 333, DateTimeKind.Local).AddTicks(3379), 89, "", "https://benjamin.com", "eveniet" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 7, 21, 10, 36, 12, 838, DateTimeKind.Local).AddTicks(6673), new DateTime(2020, 7, 21, 11, 41, 53, 429, DateTimeKind.Local).AddTicks(9697), new DateTime(2020, 7, 21, 5, 1, 30, 756, DateTimeKind.Local).AddTicks(1560), 88, "", "https://noah.org", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 7, 20, 21, 30, 5, 681, DateTimeKind.Local).AddTicks(6642), new DateTime(2020, 7, 21, 4, 26, 32, 323, DateTimeKind.Local).AddTicks(3359), new DateTime(2020, 7, 21, 6, 49, 6, 889, DateTimeKind.Local).AddTicks(6541), 86, "", "https://lena.net", "iusto" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 7, 20, 20, 36, 56, 765, DateTimeKind.Local).AddTicks(1789), new DateTime(2020, 7, 21, 11, 16, 1, 391, DateTimeKind.Local).AddTicks(2051), new DateTime(2020, 7, 21, 10, 59, 18, 165, DateTimeKind.Local).AddTicks(5870), 85, "", "https://alicia.info", "ab" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 7, 21, 15, 10, 15, 124, DateTimeKind.Local).AddTicks(2014), new DateTime(2020, 7, 20, 18, 39, 7, 835, DateTimeKind.Local).AddTicks(4297), new DateTime(2020, 7, 21, 12, 5, 46, 354, DateTimeKind.Local).AddTicks(8657), 84, "", "http://elisa.info", "fugiat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 7, 21, 16, 4, 33, 321, DateTimeKind.Local).AddTicks(9913), new DateTime(2020, 7, 20, 17, 57, 10, 270, DateTimeKind.Local).AddTicks(2581), new DateTime(2020, 7, 21, 17, 23, 21, 413, DateTimeKind.Local).AddTicks(9523), 83, "", "http://mohamed.fr", "laborum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 7, 21, 14, 31, 14, 663, DateTimeKind.Local).AddTicks(3663), new DateTime(2020, 7, 21, 16, 57, 49, 837, DateTimeKind.Local).AddTicks(6335), new DateTime(2020, 7, 21, 8, 4, 27, 677, DateTimeKind.Local).AddTicks(3848), 83, "", "http://clara.net", "tempora" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 7, 21, 4, 49, 3, 411, DateTimeKind.Local).AddTicks(1128), new DateTime(2020, 7, 21, 5, 37, 17, 493, DateTimeKind.Local).AddTicks(7479), new DateTime(2020, 7, 21, 8, 21, 39, 85, DateTimeKind.Local).AddTicks(3653), 82, "", "https://océane.com", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 7, 20, 21, 0, 33, 743, DateTimeKind.Local).AddTicks(8980), new DateTime(2020, 7, 21, 4, 39, 29, 970, DateTimeKind.Local).AddTicks(5749), new DateTime(2020, 7, 21, 12, 29, 57, 952, DateTimeKind.Local).AddTicks(4217), 81, "", "http://maxence.org", "ab" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 7, 20, 20, 51, 38, 241, DateTimeKind.Local).AddTicks(4252), new DateTime(2020, 7, 21, 7, 57, 0, 173, DateTimeKind.Local).AddTicks(3674), new DateTime(2020, 7, 21, 0, 11, 54, 222, DateTimeKind.Local).AddTicks(3650), 39, "", "http://tom.fr", "sapiente" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 7, 21, 13, 25, 0, 229, DateTimeKind.Local).AddTicks(9806), new DateTime(2020, 7, 21, 1, 4, 4, 649, DateTimeKind.Local).AddTicks(6461), new DateTime(2020, 7, 21, 8, 13, 46, 621, DateTimeKind.Local).AddTicks(7052), 39, "", "http://axel.name", "voluptatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 7, 21, 17, 31, 45, 762, DateTimeKind.Local).AddTicks(1474), new DateTime(2020, 7, 20, 23, 9, 6, 951, DateTimeKind.Local).AddTicks(208), new DateTime(2020, 7, 20, 19, 24, 26, 764, DateTimeKind.Local).AddTicks(6276), 100, "", "http://adam.org", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 7, 21, 13, 48, 45, 183, DateTimeKind.Local).AddTicks(3774), new DateTime(2020, 7, 21, 16, 2, 22, 156, DateTimeKind.Local).AddTicks(5946), new DateTime(2020, 7, 21, 0, 42, 21, 647, DateTimeKind.Local).AddTicks(3302), 38, "", "https://carla.name", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 7, 21, 7, 4, 26, 167, DateTimeKind.Local).AddTicks(5275), new DateTime(2020, 7, 21, 6, 26, 19, 999, DateTimeKind.Local).AddTicks(8032), new DateTime(2020, 7, 20, 17, 58, 36, 119, DateTimeKind.Local).AddTicks(3293), 15, "", "https://mathéo.fr", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 7, 21, 10, 25, 34, 761, DateTimeKind.Local).AddTicks(5567), new DateTime(2020, 7, 21, 16, 50, 1, 21, DateTimeKind.Local).AddTicks(1673), new DateTime(2020, 7, 20, 22, 11, 56, 983, DateTimeKind.Local).AddTicks(9582), 15, "", "https://nicolas.info", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 7, 20, 21, 5, 6, 667, DateTimeKind.Local).AddTicks(7073), new DateTime(2020, 7, 21, 12, 0, 45, 341, DateTimeKind.Local).AddTicks(76), new DateTime(2020, 7, 21, 16, 42, 15, 225, DateTimeKind.Local).AddTicks(7879), 11, "", "http://manon.eu", "quis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 7, 21, 11, 48, 32, 128, DateTimeKind.Local).AddTicks(8201), new DateTime(2020, 7, 20, 23, 14, 54, 832, DateTimeKind.Local).AddTicks(7616), new DateTime(2020, 7, 21, 5, 55, 8, 995, DateTimeKind.Local).AddTicks(2977), 10, "", "https://louise.net", "accusantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 7, 21, 17, 32, 14, 670, DateTimeKind.Local).AddTicks(4760), new DateTime(2020, 7, 21, 14, 47, 13, 322, DateTimeKind.Local).AddTicks(2065), new DateTime(2020, 7, 20, 20, 9, 25, 32, DateTimeKind.Local).AddTicks(52), 98, "", "https://mathis.info", "sint" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 7, 21, 2, 8, 15, 292, DateTimeKind.Local).AddTicks(4389), new DateTime(2020, 7, 20, 18, 48, 1, 212, DateTimeKind.Local).AddTicks(822), new DateTime(2020, 7, 21, 11, 52, 21, 784, DateTimeKind.Local).AddTicks(1175), 10, "", "http://emilie.eu", "tenetur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 7, 21, 16, 29, 24, 412, DateTimeKind.Local).AddTicks(6426), new DateTime(2020, 7, 20, 19, 13, 56, 373, DateTimeKind.Local).AddTicks(9886), new DateTime(2020, 7, 20, 19, 22, 0, 251, DateTimeKind.Local).AddTicks(4699), 10, "", "http://lina.info", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 7, 21, 12, 25, 34, 877, DateTimeKind.Local).AddTicks(1765), new DateTime(2020, 7, 21, 8, 30, 2, 279, DateTimeKind.Local).AddTicks(7976), new DateTime(2020, 7, 21, 12, 12, 21, 722, DateTimeKind.Local).AddTicks(3977), 9, "", "http://théo.eu", "voluptatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 7, 21, 17, 30, 17, 847, DateTimeKind.Local).AddTicks(3), new DateTime(2020, 7, 21, 10, 8, 39, 874, DateTimeKind.Local).AddTicks(1996), new DateTime(2020, 7, 21, 9, 28, 42, 58, DateTimeKind.Local).AddTicks(3983), 15, "", "https://axel.org", "unde" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 7, 20, 18, 14, 1, 424, DateTimeKind.Local).AddTicks(6104), new DateTime(2020, 7, 20, 22, 55, 6, 741, DateTimeKind.Local).AddTicks(3486), new DateTime(2020, 7, 20, 21, 49, 7, 38, DateTimeKind.Local).AddTicks(1020), 8, "", "http://tom.com", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 7, 21, 12, 16, 34, 672, DateTimeKind.Local).AddTicks(4980), new DateTime(2020, 7, 21, 1, 38, 40, 213, DateTimeKind.Local).AddTicks(551), new DateTime(2020, 7, 21, 16, 31, 26, 410, DateTimeKind.Local).AddTicks(6060), 6, "", "http://noah.net", "maiores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 7, 20, 18, 47, 2, 977, DateTimeKind.Local).AddTicks(1422), new DateTime(2020, 7, 20, 21, 11, 25, 36, DateTimeKind.Local).AddTicks(3397), new DateTime(2020, 7, 20, 20, 55, 39, 954, DateTimeKind.Local).AddTicks(1199), 6, "", "http://théo.org", "occaecati" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 7, 20, 18, 5, 41, 421, DateTimeKind.Local).AddTicks(7663), new DateTime(2020, 7, 21, 16, 30, 16, 164, DateTimeKind.Local).AddTicks(6909), new DateTime(2020, 7, 21, 13, 55, 18, 865, DateTimeKind.Local).AddTicks(9617), 5, "", "https://nicolas.org", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 7, 21, 7, 39, 39, 521, DateTimeKind.Local).AddTicks(1203), new DateTime(2020, 7, 20, 18, 13, 22, 937, DateTimeKind.Local).AddTicks(3484), new DateTime(2020, 7, 21, 6, 55, 6, 184, DateTimeKind.Local).AddTicks(3038), 3, "", "http://lilou.eu", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 7, 21, 16, 51, 56, 364, DateTimeKind.Local).AddTicks(1805), new DateTime(2020, 7, 21, 9, 45, 15, 604, DateTimeKind.Local).AddTicks(154), new DateTime(2020, 7, 21, 16, 29, 41, 431, DateTimeKind.Local).AddTicks(6521), 1, "", "https://lucie.org", "sequi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 7, 21, 11, 24, 4, 915, DateTimeKind.Local).AddTicks(3816), new DateTime(2020, 7, 21, 0, 43, 28, 416, DateTimeKind.Local).AddTicks(8256), new DateTime(2020, 7, 20, 19, 33, 19, 802, DateTimeKind.Local).AddTicks(2018), 1, "", "http://ethan.info", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 7, 20, 20, 18, 34, 25, DateTimeKind.Local).AddTicks(5383), new DateTime(2020, 7, 21, 0, 44, 17, 123, DateTimeKind.Local).AddTicks(5005), new DateTime(2020, 7, 21, 1, 18, 18, 410, DateTimeKind.Local).AddTicks(7606), 1, "", "http://thomas.net", "deserunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 7, 21, 13, 17, 9, 504, DateTimeKind.Local).AddTicks(6859), new DateTime(2020, 7, 20, 19, 26, 10, 481, DateTimeKind.Local).AddTicks(1635), new DateTime(2020, 7, 20, 19, 42, 5, 321, DateTimeKind.Local).AddTicks(4898), 1, "", "https://lou.com", "esse" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 7, 20, 21, 37, 38, 535, DateTimeKind.Local).AddTicks(1954), new DateTime(2020, 7, 21, 9, 42, 1, 672, DateTimeKind.Local).AddTicks(5947), new DateTime(2020, 7, 21, 16, 10, 57, 1, DateTimeKind.Local).AddTicks(5966), 6, "", "http://noémie.eu", "id" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 7, 20, 19, 48, 53, 20, DateTimeKind.Local).AddTicks(261), new DateTime(2020, 7, 21, 8, 28, 38, 824, DateTimeKind.Local).AddTicks(6092), new DateTime(2020, 7, 20, 21, 55, 26, 830, DateTimeKind.Local).AddTicks(1400), 16, "", "http://victor.fr", "at" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 7, 21, 13, 32, 48, 486, DateTimeKind.Local).AddTicks(2768), new DateTime(2020, 7, 21, 1, 19, 3, 704, DateTimeKind.Local).AddTicks(1691), new DateTime(2020, 7, 21, 4, 24, 25, 94, DateTimeKind.Local).AddTicks(5462), 10, "", "https://enzo.org", "nulla" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 7, 21, 1, 38, 48, 454, DateTimeKind.Local).AddTicks(8755), new DateTime(2020, 7, 21, 17, 12, 59, 151, DateTimeKind.Local).AddTicks(6051), new DateTime(2020, 7, 21, 17, 5, 55, 930, DateTimeKind.Local).AddTicks(6063), 17, "", "http://paul.org", "labore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 7, 20, 21, 51, 31, 407, DateTimeKind.Local).AddTicks(8567), new DateTime(2020, 7, 20, 21, 53, 4, 208, DateTimeKind.Local).AddTicks(384), new DateTime(2020, 7, 20, 21, 42, 20, 89, DateTimeKind.Local).AddTicks(223), 37, "", "https://gabriel.name", "atque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 7, 21, 13, 29, 11, 253, DateTimeKind.Local).AddTicks(5760), new DateTime(2020, 7, 21, 15, 48, 30, 205, DateTimeKind.Local).AddTicks(632), new DateTime(2020, 7, 21, 7, 56, 41, 100, DateTimeKind.Local).AddTicks(5444), 37, "", "https://maxence.com", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 7, 21, 0, 0, 0, 230, DateTimeKind.Local).AddTicks(505), new DateTime(2020, 7, 20, 22, 30, 15, 936, DateTimeKind.Local).AddTicks(2203), new DateTime(2020, 7, 21, 8, 31, 20, 545, DateTimeKind.Local).AddTicks(2084), 16, "", "https://clémence.net", "aperiam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 7, 21, 5, 11, 40, 282, DateTimeKind.Local).AddTicks(8439), new DateTime(2020, 7, 21, 10, 1, 18, 556, DateTimeKind.Local).AddTicks(4460), new DateTime(2020, 7, 21, 15, 8, 43, 655, DateTimeKind.Local).AddTicks(9658), 36, "", "http://yanis.name", "fuga" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 7, 21, 10, 59, 4, 802, DateTimeKind.Local).AddTicks(5152), new DateTime(2020, 7, 21, 15, 55, 22, 445, DateTimeKind.Local).AddTicks(2650), new DateTime(2020, 7, 21, 14, 1, 46, 524, DateTimeKind.Local).AddTicks(6386), 34, "", "http://mohamed.eu", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 7, 20, 22, 54, 26, 405, DateTimeKind.Local).AddTicks(4250), new DateTime(2020, 7, 21, 7, 51, 47, 78, DateTimeKind.Local).AddTicks(6448), new DateTime(2020, 7, 21, 1, 39, 15, 906, DateTimeKind.Local).AddTicks(5280), 33, "", "http://tom.name", "provident" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 7, 21, 10, 42, 25, 494, DateTimeKind.Local).AddTicks(6201), new DateTime(2020, 7, 20, 21, 20, 32, 750, DateTimeKind.Local).AddTicks(529), new DateTime(2020, 7, 21, 16, 26, 0, 671, DateTimeKind.Local).AddTicks(6493), 29, "", "https://kylian.org", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 7, 21, 4, 33, 51, 471, DateTimeKind.Local).AddTicks(7678), new DateTime(2020, 7, 21, 15, 9, 13, 926, DateTimeKind.Local).AddTicks(3647), new DateTime(2020, 7, 21, 10, 42, 51, 840, DateTimeKind.Local).AddTicks(1231), 28, "", "https://thomas.net", "sed" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 7, 21, 9, 23, 59, 710, DateTimeKind.Local).AddTicks(4505), new DateTime(2020, 7, 20, 22, 21, 4, 633, DateTimeKind.Local).AddTicks(5589), new DateTime(2020, 7, 20, 20, 9, 6, 315, DateTimeKind.Local).AddTicks(8538), 26, "", "http://mattéo.org", "voluptates" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 7, 20, 18, 25, 12, 809, DateTimeKind.Local).AddTicks(4795), new DateTime(2020, 7, 21, 5, 57, 54, 635, DateTimeKind.Local).AddTicks(421), new DateTime(2020, 7, 21, 12, 10, 1, 550, DateTimeKind.Local).AddTicks(2416), 36, "", "https://benjamin.info", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 7, 21, 6, 19, 49, 60, DateTimeKind.Local).AddTicks(1193), new DateTime(2020, 7, 21, 15, 5, 53, 671, DateTimeKind.Local).AddTicks(3048), new DateTime(2020, 7, 21, 8, 22, 3, 586, DateTimeKind.Local).AddTicks(4252), 25, "", "http://jules.com", "quidem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 7, 20, 23, 1, 12, 283, DateTimeKind.Local).AddTicks(8850), new DateTime(2020, 7, 21, 5, 52, 47, 20, DateTimeKind.Local).AddTicks(7225), new DateTime(2020, 7, 21, 12, 5, 36, 164, DateTimeKind.Local).AddTicks(1781), 25, "", "http://thomas.fr", "tempora" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 7, 21, 12, 18, 59, 488, DateTimeKind.Local).AddTicks(8637), new DateTime(2020, 7, 21, 0, 17, 25, 937, DateTimeKind.Local).AddTicks(1895), new DateTime(2020, 7, 21, 9, 31, 37, 534, DateTimeKind.Local).AddTicks(2767), 21, "", "https://clémence.fr", "eaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 7, 21, 6, 16, 31, 239, DateTimeKind.Local).AddTicks(2282), new DateTime(2020, 7, 20, 18, 30, 32, 401, DateTimeKind.Local).AddTicks(925), new DateTime(2020, 7, 20, 20, 38, 31, 481, DateTimeKind.Local).AddTicks(1915), 21, "", "https://paul.org", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 7, 21, 5, 15, 52, 652, DateTimeKind.Local).AddTicks(4736), new DateTime(2020, 7, 20, 23, 11, 45, 589, DateTimeKind.Local).AddTicks(2300), new DateTime(2020, 7, 21, 0, 56, 40, 619, DateTimeKind.Local).AddTicks(5432), 21, "", "http://valentin.com", "cum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 7, 21, 14, 33, 18, 479, DateTimeKind.Local).AddTicks(2230), new DateTime(2020, 7, 21, 13, 29, 13, 375, DateTimeKind.Local).AddTicks(7976), new DateTime(2020, 7, 21, 6, 29, 50, 705, DateTimeKind.Local).AddTicks(4710), 21, "", "http://charlotte.fr", "suscipit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 7, 21, 12, 23, 5, 394, DateTimeKind.Local).AddTicks(8289), new DateTime(2020, 7, 21, 15, 28, 57, 928, DateTimeKind.Local).AddTicks(1072), new DateTime(2020, 7, 21, 7, 5, 46, 907, DateTimeKind.Local).AddTicks(1404), 20, "", "http://sarah.org", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 7, 20, 18, 21, 56, 368, DateTimeKind.Local).AddTicks(1357), new DateTime(2020, 7, 21, 5, 46, 51, 900, DateTimeKind.Local).AddTicks(7939), new DateTime(2020, 7, 21, 2, 39, 55, 46, DateTimeKind.Local).AddTicks(8044), 19, "", "http://alexandre.name", "repellendus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 7, 20, 21, 59, 5, 800, DateTimeKind.Local).AddTicks(2301), new DateTime(2020, 7, 21, 12, 20, 16, 661, DateTimeKind.Local).AddTicks(78), new DateTime(2020, 7, 21, 9, 52, 40, 319, DateTimeKind.Local).AddTicks(5025), 18, "", "https://adam.com", "inventore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 7, 21, 15, 19, 48, 696, DateTimeKind.Local).AddTicks(695), new DateTime(2020, 7, 21, 10, 14, 8, 870, DateTimeKind.Local).AddTicks(5333), new DateTime(2020, 7, 21, 12, 0, 13, 860, DateTimeKind.Local).AddTicks(7164), 25, "", "https://pierre.info", "est" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 2, 1, "Gouvernance", "الحكم" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 3, 2, "Droits économiques", "الحقوق الاقتصادية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 7, 3, "Promotion des droits catégoriels", "تعزيز حقوق الفئة" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 8, 3, "Protection des droits catégoriels", "حماية حقوق الفئة" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 9, 4, "Cadre institutionnel", "الإطار المؤسسي" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 10, 4, "Cadre juridique", "الإطار القانوني" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 1, 1, "Démocratie", "ديمقراطية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 5, 6, "Droits culturels", "الحقوق الثقافية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 6, 7, "Droits environnementaux", "الحقوق البيئية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 4, 5, "Droits sociaux", "الحقوق الاجتماعية" });

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
                values: new object[] { 10, "1.3.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 51, 4, 7, null, 4, 1, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 47, "2.8.7.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 8, 3, null, null, 1, 4, 9, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 46, "8.9.7.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 76, 1, 9, null, 4, 4, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 26, "1.7.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 1, null, null, 4, 4, 9, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 16, "5.7.0.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 7, 9, null, 4, 4, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 15, "4.3.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 49, 3, null, 5, 3, 4, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 8, "7.0.7.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 1, null, null, 2, 4, 4, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 99, "6.5.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 2, null, 2, 1, 10, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 92, "2.6.4.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 86, 6, null, null, 1, 10, 4, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 77, "0.9.5.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 1, null, null, 1, 10, 7, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 76, "1.5.9.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 47, 1, 3, null, 2, 10, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 68, "5.3.8.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 19, 7, null, null, 1, 10, 3, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 61, "2.1.9.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 85, 7, 3, null, 4, 10, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 55, "0.7.5.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 7, 3, null, 4, 10, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 51, "8.8.3.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 28, 4, null, 6, 2, 10, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 41, "5.5.4.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 1, null, null, 3, 10, 5, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 39, "1.0.3.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 92, 7, null, 5, 3, 10, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 33, "1.5.1.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 7, null, 6, 1, 10, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 25, "4.5.3.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 60, 5, 4, null, 4, 10, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 12, "9.0.0.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 3, null, 6, 4, 10, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 6, "4.2.2.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 5, null, 4, 1, 10, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 2, "9.6.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 85, 7, null, null, 3, 10, 10, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 48, "3.8.0.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 1, null, 6, 4, 4, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 59, "1.5.0.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 57, 4, null, null, 1, 4, 2, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 62, "5.1.9.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 5, null, null, 4, 4, 7, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 64, "2.1.3.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 52, 3, 2, null, 1, 4, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 87, "7.3.6.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 3, null, 6, 4, 6, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 75, "7.2.2.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 26, 4, null, 6, 4, 6, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 73, "2.1.0.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 71, 5, 8, null, 4, 6, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 70, "8.6.5.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 19, 5, 8, null, 3, 6, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 65, "6.1.4.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 6, null, null, 4, 6, 3, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 45, "0.2.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 29, 6, null, 6, 1, 6, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 40, "8.0.7.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 1, 4, null, 3, 6, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 31, "0.2.6.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 43, 5, 3, null, 1, 6, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 27, "6.2.8.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 48, 6, null, 4, 1, 6, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 98, "5.0.9.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 59, 1, null, null, 2, 5, 1, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 86, "8.4.0.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 7, null, null, 1, 9, 5, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 95, "3.0.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 92, 4, null, null, 4, 5, 2, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 80, "8.6.4.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 4, null, null, 4, 5, 7, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 74, "3.6.4.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 53, 3, null, null, 1, 5, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 50, "9.6.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 2, null, null, 3, 5, 5, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 35, "3.1.4.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 1, null, null, 3, 5, 8, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 29, "6.3.8.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 4, null, null, 3, 5, 4, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 5, "8.0.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 45, 1, null, null, 1, 5, 10, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 91, "7.2.2.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 57, 3, 10, null, 1, 4, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 85, "2.3.8.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 51, 2, 10, null, 4, 4, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 84, "7.9.3.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 53, 2, null, 4, 3, 4, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 83, "9.4.0.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 81, 6, null, null, 4, 4, 7, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 89, "2.8.0.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 25, 1, null, null, 2, 5, 2, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 82, "3.3.2.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 2, 9, null, 2, 9, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 90, "4.2.5.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 70, 7, null, 6, 2, 6, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 52, "5.6.1.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 2, 8, null, 3, 9, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 71, "7.3.9.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 81, 6, null, null, 4, 3, 4, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 67, "1.0.5.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 15, 5, 6, null, 1, 3, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 58, "0.9.1.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 85, 1, 6, null, 2, 3, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 49, "9.2.1.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 3, 9, null, 2, 3, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 36, "3.3.2.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 3, null, 1, 2, 3, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 13, "1.9.8.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 55, 4, 9, null, 2, 3, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 7, "7.8.8.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 35, 7, 1, null, 4, 3, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 3, "3.4.5.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 38, 4, null, 1, 3, 3, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 53, "4.5.7.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 10, 7, null, null, 3, 2, 6, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 42, "0.9.9.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 91, 6, null, 4, 1, 2, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 14, "2.9.7.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 5, null, null, 4, 2, 3, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 1, "7.2.7.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 6, 9, null, 4, 2, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 100, "2.5.7.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 4, 9, null, 3, 1, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 56, "5.5.0.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 4, null, null, 1, 1, 1, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 54, "6.7.9.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 83, 7, null, 4, 2, 1, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 30, "1.3.7.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 52, 5, null, 2, 2, 1, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 28, "5.2.7.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 58, 4, 9, null, 3, 1, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 24, "0.1.2.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 61, 1, null, 3, 4, 1, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 23, "4.1.0.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 58, 2, null, null, 1, 1, 4, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 19, "1.2.4.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 89, 7, 1, null, 2, 1, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 66, "0.7.7.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 5, null, 3, 1, 9, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 81, "7.6.7.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 13, 5, null, 6, 3, 3, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 96, "6.9.7.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 23, 1, null, 3, 2, 3, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 63, "6.0.2.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 4, null, 1, 2, 2, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 4, "3.0.1.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 73, 7, 4, null, 3, 7, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 97, "5.0.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 96, 7, 7, null, 1, 3, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 22, "2.7.7.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 4, 4, null, 1, 9, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 21, "9.3.7.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 100, 7, null, 5, 3, 9, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 9, "3.5.8.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 5, null, 1, 3, 9, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 72, "0.0.4.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 5, null, 4, 3, 8, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 60, "4.5.9.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 73, 3, null, 6, 4, 8, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 57, "0.5.5.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 4, null, 1, 2, 8, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 37, "7.7.8.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 81, 1, 5, null, 1, 8, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 32, "1.2.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 35, 7, null, null, 2, 8, 9, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 20, "6.7.7.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 4, null, null, 2, 8, 3, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 94, "5.4.8.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 90, 2, 4, null, 2, 7, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 44, "2.2.8.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 61, 3, null, null, 4, 8, 10, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 34, "0.6.4.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 40, 2, 5, null, 2, 9, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 93, "8.5.2.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 61, 6, null, 1, 2, 7, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 17, "0.8.0.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 2, null, null, 1, 7, 1, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 18, "2.9.0.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 61, 3, null, 6, 3, 7, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 38, "8.8.4.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 2, null, null, 2, 7, 5, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 43, "1.7.5.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 9, 4, 5, null, 1, 7, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 11, "4.4.2.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 16, 4, null, null, 3, 7, 6, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 78, "7.6.6.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 84, 4, null, 2, 4, 7, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 79, "0.7.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 84, 6, 2, null, 2, 7, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 88, "4.4.0.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 4, 8, null, 2, 7, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 69, "6.4.7.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 72, 6, null, 3, 4, 7, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "numquam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 53, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "ipsa", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 70, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "dignissimos", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 21, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "aspernatur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 46, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "ipsum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 73, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "atque", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 71, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "quos", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 71, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "fugit", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 53, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "nemo", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 53, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "soluta", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 7, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "nihil", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 56, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "soluta", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 60, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "ut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 16, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "aut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 51, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "ut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 75, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 75, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "quia", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 95, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "fugiat", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 24, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "nostrum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 43, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "omnis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 43, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "ea", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 70, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "voluptatem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 60, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "eligendi", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 20, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "dolores", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 87, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 52, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "vero", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 56, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "possimus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 39, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "maxime", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 39, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "perspiciatis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 34, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "veniam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 34, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "incidunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 34, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "neque", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 5, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 84, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "ea", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 63, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "sed", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 2, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "aut", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 20, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "accusamus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 68, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "est", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 10, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "quia", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 10, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "distinctio", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 36, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "autem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 36, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "ut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 59, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 79, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "mollitia", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 79, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 40, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "ipsam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 89, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "consequuntur", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 8, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 10, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "quo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 54, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "dolore", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 25, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "voluptas", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 55, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "dolores", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 58, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "in", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 58, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "quo", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 58, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "id", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 64, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "quo", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 50, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "amet", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 49, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "deleniti", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 49, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "ea", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 49, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "ipsum", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 18, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "dolores", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 18, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "voluptas", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 18, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "quasi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 18, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "facilis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 44, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "nemo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 44, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "ut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 42, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "quis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 42, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "rerum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 37, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "alias", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 32, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "laboriosam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 32, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "minima", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 32, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "minima", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 87, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "enim", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 69, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "nisi", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 66, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 66, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "eum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 66, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "quis", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 55, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "porro", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 93, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "fuga", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 74, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "sed", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 33, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 92, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "quis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 92, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "magnam", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 90, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "totam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 9, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "nisi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 9, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "dicta", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 9, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "impedit", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 97, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "quo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 29, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "numquam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 48, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "commodi", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 48, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "vitae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 48, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "ut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 3, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "eveniet", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "magnam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 96, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "porro", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 76, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "repudiandae", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 57, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "saepe", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 25, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "pariatur", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 78, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "eum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 48, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "qui", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 87, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/e-commerce/zero-administration", 6, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/web-readiness/hawaii/court", 4, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/online/users/communications", 7, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/lodge/handcrafted-fresh-shirt", 2, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/grey/leverage/invoice", 4, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/parkway/port/platforms", 2, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/principal/refined-concrete-table", 3, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/human-resource", 5, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/applications/content", 2, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/supply-chains", 3, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/online/zambian-kwacha", 5, 46 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/credit-card-account", 4, 46 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/avon", 7, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/online/concrete/payment", 7, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/club/bedfordshire/new-hampshire", 3, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/red/dynamic", 4, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/functionality/backing-up/online", 4, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/internal", 5, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/berkshire/planner", 1, 96 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/yellow", 5, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/firewall/programming/human-resource", 4, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/object-oriented/reintermediate/bus", 3, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/http/jbod/ergonomic-wooden-shirt", 1, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/wooden/reboot", 5, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/michigan/purple/north-carolina", 3, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/investment-account", 3, 53 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/officer/soft/china", 4, 6 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/systems/berkshire", 3, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/marketing", 5, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/frozen/intelligent/kentucky", 3, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/heuristic/home", 4, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/colorado", 4, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/buckinghamshire/islands/partnerships", 3, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/unbranded-steel-table/hdd/functionalities", 5, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/dynamic/invoice", 5, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/mews/ram", 3, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/administrator/smtp/zambia", 7, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/berkshire/ergonomic/moldova", 4, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/monetize", 7, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/4th-generation/mobility/central", 2, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/maine", 3, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/granite", 6, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/asynchronous/pixel/prairie", 1, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/global/incredible-soft-keyboard/zero-administration", 7, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/handcrafted", 1, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/solutions/247/auxiliary", 2, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/principal/villages", 1, 53 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/copying/deliver", 4, 34 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/cross-platform/streamline", 7, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/lilangeni/hack/austria", 3, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/artificial-intelligence/program", 1, 28 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/villages", 4, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/turquoise/maroon", 1, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/open-source", 3, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/models", 6, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/channels/handcrafted", 2, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/back-end/buckinghamshire/bypassing", 5, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/fantastic-wooden-fish", 4, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/teal", 1, 13 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/encoding", 3, 68 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/granular", 6, 68 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/awesome-plastic-bacon/plum/small-granite-sausages", 5, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/robust/officer", 7, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/program/function-based/avon", 3, 51 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/brand/monetize/gorgeous-frozen-salad", 6, 51 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/gorgeous/handcrafted-granite-bacon/dynamic", 6, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/monetize", 3, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/light/ssl", 5, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/corporate/json", 4, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/implement/indexing", 7, 87 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/station/mauritius-rupee/diverse", 3, 87 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/ergonomic/seamless", 6, 84 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/unbranded", 5, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/synthesizing/assimilated/maroon", 2, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/incubate", 6, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/saint-lucia/vertical", 5, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/com/solutions", 3, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/teal", 7, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/infrastructure/fields/savings-account", 3, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/armenia/redundant/handmade-concrete-table", 4, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/river", 1, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/dong", 3, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/investment-account/outdoors/synthesize", 2, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/robust/content-based", 6, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/developer/systems", 5, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/violet/revolutionary", 2, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/metal/cross-platform/lodge", 5, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/optical/philippine-peso", 7, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/cross-platform", 5, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/transmit", 2, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/transmitting/delaware/fantastic-steel-car", 1, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/generating", 3, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/monitoring/feed", 6, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/payment/vortals", 4, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/bedfordshire/blockchains", 3, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/cross-media", 5, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/neural/multi-byte", 7, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/sleek", 4, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/avon/trace", 3, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/future/agp", 2, 43 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 6, new DateTime(2019, 8, 21, 5, 53, 27, 451, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 5, new DateTime(2019, 11, 14, 11, 13, 31, 575, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 1, new DateTime(2020, 6, 16, 14, 46, 47, 921, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 6, new DateTime(2020, 3, 18, 15, 17, 48, 735, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 5, new DateTime(2020, 6, 17, 17, 54, 45, 435, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 5, new DateTime(2020, 5, 13, 10, 17, 55, 78, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 1, new DateTime(2020, 2, 15, 18, 37, 29, 851, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 3, new DateTime(2019, 12, 9, 18, 36, 3, 867, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 2, new DateTime(2020, 1, 8, 8, 53, 35, 559, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 2, new DateTime(2020, 2, 27, 13, 34, 58, 840, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 1, new DateTime(2020, 1, 11, 4, 32, 22, 377, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 5, new DateTime(2019, 10, 22, 23, 27, 35, 665, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 3, new DateTime(2020, 3, 23, 19, 17, 27, 600, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 3, new DateTime(2020, 3, 27, 5, 39, 23, 642, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 6, new DateTime(2020, 7, 18, 2, 20, 38, 551, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 1, new DateTime(2019, 9, 25, 17, 19, 57, 681, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 6, new DateTime(2019, 10, 2, 23, 26, 9, 407, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 5, new DateTime(2020, 4, 26, 14, 12, 14, 956, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 6, new DateTime(2019, 9, 8, 18, 29, 25, 452, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 2, new DateTime(2020, 7, 6, 14, 14, 36, 426, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 2, new DateTime(2019, 12, 26, 21, 48, 43, 702, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 6, new DateTime(2019, 8, 30, 7, 56, 35, 502, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 6, new DateTime(2019, 11, 15, 11, 3, 24, 602, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 6, new DateTime(2019, 12, 29, 15, 26, 35, 661, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 2, new DateTime(2020, 4, 26, 20, 50, 30, 909, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 4, new DateTime(2019, 12, 4, 0, 27, 4, 368, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 3, new DateTime(2020, 5, 23, 15, 26, 6, 856, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 4, new DateTime(2020, 3, 1, 17, 48, 40, 72, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 4, new DateTime(2020, 5, 12, 12, 58, 45, 346, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 4, new DateTime(2020, 2, 27, 4, 12, 29, 567, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 2, new DateTime(2020, 3, 31, 11, 5, 4, 599, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 6, new DateTime(2019, 9, 20, 22, 20, 22, 90, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 5, new DateTime(2019, 9, 3, 15, 29, 17, 37, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 1, new DateTime(2020, 3, 24, 7, 59, 23, 558, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 2, new DateTime(2019, 11, 26, 7, 13, 33, 844, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 3, new DateTime(2020, 1, 26, 17, 38, 46, 804, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 4, new DateTime(2019, 11, 9, 15, 51, 59, 378, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 5, new DateTime(2020, 2, 1, 8, 48, 27, 375, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 3, new DateTime(2019, 10, 27, 5, 13, 42, 800, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 1, new DateTime(2019, 8, 9, 8, 47, 31, 476, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 2, new DateTime(2020, 2, 29, 16, 13, 20, 338, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 4, new DateTime(2020, 1, 31, 5, 18, 59, 244, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 5, new DateTime(2020, 1, 20, 6, 0, 1, 308, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 5, new DateTime(2019, 10, 6, 20, 34, 9, 313, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 6, new DateTime(2019, 9, 9, 14, 51, 1, 153, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 6, new DateTime(2019, 10, 17, 2, 1, 36, 838, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 6, new DateTime(2020, 5, 17, 7, 7, 9, 543, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 5, new DateTime(2020, 6, 14, 7, 45, 30, 413, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 3, new DateTime(2020, 7, 2, 8, 15, 33, 694, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 3, new DateTime(2019, 12, 18, 4, 56, 49, 267, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 5, new DateTime(2020, 5, 1, 15, 40, 31, 829, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 4, new DateTime(2020, 1, 27, 13, 7, 57, 558, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 2, new DateTime(2020, 1, 2, 11, 16, 52, 690, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 5, new DateTime(2019, 11, 2, 1, 31, 52, 165, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 3, new DateTime(2019, 12, 17, 19, 31, 30, 727, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 4, new DateTime(2020, 4, 18, 1, 39, 29, 333, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 6, new DateTime(2019, 8, 17, 5, 18, 9, 899, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 4, new DateTime(2019, 12, 27, 19, 59, 6, 124, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 4, new DateTime(2019, 9, 15, 3, 35, 33, 120, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 5, new DateTime(2019, 11, 27, 19, 8, 49, 4, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 3, new DateTime(2019, 8, 24, 23, 3, 40, 459, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 1, new DateTime(2020, 3, 27, 15, 8, 50, 805, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 1, new DateTime(2020, 2, 8, 14, 23, 54, 341, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 1, new DateTime(2020, 6, 14, 23, 35, 38, 17, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 6, new DateTime(2020, 6, 9, 9, 59, 33, 774, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 6, new DateTime(2019, 12, 28, 5, 42, 20, 600, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 5, new DateTime(2020, 5, 29, 7, 36, 14, 84, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 6, new DateTime(2020, 4, 13, 4, 30, 8, 255, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 1, new DateTime(2019, 12, 12, 3, 29, 16, 506, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 1, new DateTime(2020, 2, 9, 17, 1, 25, 238, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 3, new DateTime(2019, 7, 24, 11, 39, 38, 606, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 1, new DateTime(2020, 3, 16, 22, 42, 1, 818, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 3, new DateTime(2020, 5, 7, 5, 14, 57, 574, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 1, new DateTime(2020, 4, 9, 13, 25, 1, 320, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 2, new DateTime(2020, 3, 9, 11, 58, 4, 217, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 3, new DateTime(2020, 1, 31, 13, 33, 17, 997, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 4, new DateTime(2019, 12, 16, 8, 42, 43, 37, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 2, new DateTime(2019, 9, 22, 4, 51, 25, 844, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 3, new DateTime(2019, 12, 2, 4, 55, 36, 163, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 2, new DateTime(2020, 5, 20, 6, 11, 4, 512, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 6, new DateTime(2019, 12, 20, 6, 19, 16, 398, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 6, new DateTime(2020, 5, 23, 13, 30, 20, 65, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 2, new DateTime(2019, 12, 14, 6, 18, 43, 88, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 2, new DateTime(2020, 4, 24, 1, 54, 57, 898, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 6, new DateTime(2020, 6, 7, 19, 36, 35, 542, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 6, new DateTime(2020, 3, 25, 16, 57, 21, 731, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 3, new DateTime(2020, 6, 29, 21, 59, 37, 191, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 4, new DateTime(2020, 2, 14, 4, 56, 28, 766, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 4, new DateTime(2019, 12, 4, 4, 28, 44, 89, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 2, new DateTime(2020, 1, 24, 1, 15, 29, 284, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 6, new DateTime(2020, 1, 10, 8, 41, 0, 999, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 6, new DateTime(2019, 11, 8, 22, 5, 14, 844, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 4, new DateTime(2019, 9, 13, 14, 44, 32, 836, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 5, new DateTime(2020, 2, 13, 4, 39, 47, 292, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 4, new DateTime(2019, 12, 17, 0, 29, 39, 579, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 2, new DateTime(2019, 11, 18, 2, 50, 5, 16, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 4, new DateTime(2019, 9, 14, 17, 28, 38, 122, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 4, new DateTime(2019, 9, 24, 10, 45, 19, 923, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 3, new DateTime(2019, 11, 13, 0, 22, 56, 465, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 1, new DateTime(2019, 12, 3, 11, 41, 42, 639, DateTimeKind.Local).AddTicks(5080) });

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
