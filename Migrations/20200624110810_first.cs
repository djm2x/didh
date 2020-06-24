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
                values: new object[] { 10, "Categorie 1", new DateTime(2019, 9, 21, 0, 39, 57, 605, DateTimeKind.Local).AddTicks(3501), "esse", "ut" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 9, "Categorie 1", new DateTime(2019, 11, 16, 7, 50, 7, 969, DateTimeKind.Local).AddTicks(8083), "quos", "sint" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 8, "Categorie 1", new DateTime(2020, 4, 30, 16, 3, 8, 409, DateTimeKind.Local).AddTicks(3330), "doloribus", "esse" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 7, "Categorie 1", new DateTime(2020, 4, 9, 15, 6, 41, 522, DateTimeKind.Local).AddTicks(5690), "iste", "est" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 6, "Categorie 1", new DateTime(2019, 8, 15, 2, 40, 32, 2, DateTimeKind.Local).AddTicks(1104), "dolorem", "amet" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 4, "Categorie 1", new DateTime(2019, 10, 30, 20, 54, 40, 88, DateTimeKind.Local).AddTicks(3816), "ut", "dolor" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 3, "Categorie 1", new DateTime(2020, 6, 11, 0, 3, 32, 15, DateTimeKind.Local).AddTicks(7335), "nulla", "nesciunt" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 2, "Categorie 1", new DateTime(2020, 5, 31, 15, 16, 43, 784, DateTimeKind.Local).AddTicks(9015), "aut", "eveniet" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 1, "Categorie 1", new DateTime(2019, 7, 17, 16, 5, 22, 639, DateTimeKind.Local).AddTicks(9211), "recusandae", "deserunt" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 5, "Categorie 1", new DateTime(2019, 11, 29, 3, 20, 2, 355, DateTimeKind.Local).AddTicks(7774), "hic", "veritatis" });

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
                values: new object[] { 73, new DateTime(2020, 3, 1, 0, 10, 46, 913, DateTimeKind.Local).AddTicks(8151), "1,2,4", 73, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2020, 3, 14, 21, 6, 16, 777, DateTimeKind.Local).AddTicks(5132), "1,3,5", 72, 5, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2020, 4, 12, 13, 25, 35, 245, DateTimeKind.Local).AddTicks(3907), "0,3,4", 71, 3, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2019, 10, 21, 22, 2, 21, 978, DateTimeKind.Local).AddTicks(3666), "0,3,5", 70, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2020, 5, 25, 23, 35, 57, 866, DateTimeKind.Local).AddTicks(5134), "1,2,5", 69, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2019, 12, 2, 23, 51, 10, 884, DateTimeKind.Local).AddTicks(4111), "0,2,6", 68, 4, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2020, 3, 26, 0, 15, 16, 630, DateTimeKind.Local).AddTicks(8216), "1,2,6", 67, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2020, 3, 24, 14, 40, 44, 825, DateTimeKind.Local).AddTicks(5443), "1,3,4", 66, 3, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2019, 7, 12, 0, 50, 18, 448, DateTimeKind.Local).AddTicks(7453), "1,3,5", 65, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2019, 9, 2, 10, 53, 41, 251, DateTimeKind.Local).AddTicks(8703), "1,2,4", 64, 4, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2020, 3, 1, 15, 5, 29, 346, DateTimeKind.Local).AddTicks(8333), "0,2,4", 63, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2019, 10, 29, 18, 18, 50, 101, DateTimeKind.Local).AddTicks(9342), "0,3,6", 61, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2020, 3, 8, 23, 54, 10, 829, DateTimeKind.Local).AddTicks(7793), "0,3,6", 60, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2019, 11, 7, 17, 22, 24, 853, DateTimeKind.Local).AddTicks(3000), "0,2,5", 59, 1, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2020, 6, 8, 5, 56, 27, 917, DateTimeKind.Local).AddTicks(6337), "0,3,4", 58, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2020, 1, 2, 4, 25, 50, 163, DateTimeKind.Local).AddTicks(9806), "1,3,5", 57, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2019, 10, 6, 19, 2, 31, 241, DateTimeKind.Local).AddTicks(7971), "0,2,4", 56, 3, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2019, 9, 6, 10, 24, 32, 20, DateTimeKind.Local).AddTicks(8559), "1,3,5", 55, 5, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2020, 1, 8, 14, 36, 11, 656, DateTimeKind.Local).AddTicks(6010), "0,2,4", 54, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2019, 6, 25, 9, 41, 4, 92, DateTimeKind.Local).AddTicks(7290), "1,3,5", 53, 3, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2019, 12, 17, 2, 43, 21, 37, DateTimeKind.Local).AddTicks(1331), "0,2,6", 74, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2020, 1, 8, 22, 23, 18, 33, DateTimeKind.Local).AddTicks(7705), "0,3,4", 62, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2019, 8, 20, 14, 58, 29, 406, DateTimeKind.Local).AddTicks(1986), "0,3,6", 75, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2020, 4, 6, 1, 51, 23, 728, DateTimeKind.Local).AddTicks(2069), "0,3,5", 93, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2019, 11, 22, 14, 27, 0, 354, DateTimeKind.Local).AddTicks(3700), "1,2,4", 77, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2020, 3, 12, 23, 21, 17, 391, DateTimeKind.Local).AddTicks(765), "0,3,4", 100, 2, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2020, 2, 26, 4, 57, 30, 567, DateTimeKind.Local).AddTicks(5205), "1,3,4", 99, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2019, 12, 17, 15, 6, 33, 672, DateTimeKind.Local).AddTicks(8433), "1,2,6", 98, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2019, 7, 9, 9, 34, 25, 77, DateTimeKind.Local).AddTicks(4445), "0,3,6", 97, 5, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2019, 11, 10, 18, 26, 29, 813, DateTimeKind.Local).AddTicks(4883), "0,3,5", 96, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2020, 3, 3, 0, 56, 50, 985, DateTimeKind.Local).AddTicks(7142), "0,3,5", 95, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2019, 8, 20, 20, 49, 59, 447, DateTimeKind.Local).AddTicks(3343), "1,2,4", 94, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2019, 7, 24, 23, 1, 58, 828, DateTimeKind.Local).AddTicks(1542), "0,3,6", 52, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2020, 1, 8, 2, 50, 30, 317, DateTimeKind.Local).AddTicks(4981), "1,3,4", 92, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2019, 11, 15, 19, 12, 13, 991, DateTimeKind.Local).AddTicks(7495), "1,2,5", 91, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2020, 3, 27, 13, 5, 43, 267, DateTimeKind.Local).AddTicks(4810), "1,2,5", 76, 3, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2020, 5, 4, 9, 36, 32, 472, DateTimeKind.Local).AddTicks(9901), "1,3,6", 90, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2019, 12, 21, 19, 18, 28, 873, DateTimeKind.Local).AddTicks(4733), "0,2,4", 88, 1, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2020, 3, 5, 17, 23, 11, 880, DateTimeKind.Local).AddTicks(8102), "1,3,5", 87, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2019, 9, 13, 7, 24, 44, 590, DateTimeKind.Local).AddTicks(4600), "1,2,6", 86, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2020, 4, 26, 13, 56, 52, 942, DateTimeKind.Local).AddTicks(3501), "1,3,5", 85, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2019, 8, 25, 23, 20, 20, 782, DateTimeKind.Local).AddTicks(3600), "1,2,5", 83, 2, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2019, 9, 17, 23, 49, 45, 875, DateTimeKind.Local).AddTicks(7812), "1,3,4", 82, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2020, 1, 3, 23, 41, 23, 784, DateTimeKind.Local).AddTicks(5967), "1,2,4", 81, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2020, 2, 28, 17, 54, 10, 761, DateTimeKind.Local).AddTicks(2326), "1,2,5", 80, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2020, 1, 26, 19, 44, 13, 196, DateTimeKind.Local).AddTicks(5130), "1,3,6", 79, 5, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2020, 2, 28, 13, 13, 38, 636, DateTimeKind.Local).AddTicks(9466), "1,2,5", 78, 4, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2020, 3, 17, 0, 56, 39, 202, DateTimeKind.Local).AddTicks(2149), "1,2,5", 89, 5, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2019, 11, 21, 5, 16, 45, 517, DateTimeKind.Local).AddTicks(959), "1,3,5", 51, 1, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2019, 10, 7, 10, 30, 13, 966, DateTimeKind.Local).AddTicks(4237), "0,2,5", 84, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2019, 11, 11, 1, 50, 27, 960, DateTimeKind.Local).AddTicks(2416), "1,2,5", 49, 3, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2019, 8, 17, 11, 17, 22, 975, DateTimeKind.Local).AddTicks(2708), "1,3,4", 22, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2020, 5, 31, 16, 10, 22, 989, DateTimeKind.Local).AddTicks(5167), "0,2,4", 21, 1, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2019, 7, 26, 13, 39, 16, 194, DateTimeKind.Local).AddTicks(9144), "1,3,6", 20, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2020, 5, 30, 22, 52, 43, 23, DateTimeKind.Local).AddTicks(7430), "0,2,4", 19, 1, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2019, 11, 13, 18, 22, 51, 407, DateTimeKind.Local).AddTicks(5534), "1,2,4", 18, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2019, 8, 22, 0, 41, 52, 206, DateTimeKind.Local).AddTicks(6037), "1,3,4", 17, 6, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2019, 12, 10, 11, 10, 14, 413, DateTimeKind.Local).AddTicks(3819), "1,3,4", 15, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2019, 11, 27, 6, 13, 48, 258, DateTimeKind.Local).AddTicks(1034), "1,3,6", 14, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2020, 2, 1, 7, 46, 14, 295, DateTimeKind.Local).AddTicks(6129), "0,3,4", 13, 6, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2019, 10, 17, 4, 48, 0, 636, DateTimeKind.Local).AddTicks(9714), "1,2,6", 12, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 1, 21, 4, 19, 12, 616, DateTimeKind.Local).AddTicks(6844), "0,2,6", 23, 3, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2019, 7, 3, 16, 0, 48, 882, DateTimeKind.Local).AddTicks(4009), "1,3,6", 11, 4, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2019, 12, 23, 11, 58, 2, 943, DateTimeKind.Local).AddTicks(870), "1,2,4", 9, 4, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2019, 10, 21, 16, 2, 53, 967, DateTimeKind.Local).AddTicks(6907), "0,2,6", 8, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2019, 7, 30, 2, 38, 11, 763, DateTimeKind.Local).AddTicks(6077), "0,3,5", 7, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2020, 3, 14, 13, 10, 44, 673, DateTimeKind.Local).AddTicks(5150), "0,2,5", 6, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2019, 8, 28, 18, 58, 12, 881, DateTimeKind.Local).AddTicks(593), "0,3,4", 5, 6, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2020, 5, 11, 12, 8, 24, 923, DateTimeKind.Local).AddTicks(4434), "0,2,6", 4, 6, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2020, 4, 25, 8, 19, 38, 466, DateTimeKind.Local).AddTicks(9666), "1,3,4", 3, 5, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2020, 1, 31, 14, 13, 25, 438, DateTimeKind.Local).AddTicks(4052), "0,2,4", 2, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2019, 12, 2, 12, 20, 43, 883, DateTimeKind.Local).AddTicks(5869), "1,2,4", 1, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2020, 1, 17, 19, 22, 12, 686, DateTimeKind.Local).AddTicks(8701), "1,3,6", 50, 2, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2019, 8, 12, 0, 57, 21, 604, DateTimeKind.Local).AddTicks(2360), "1,2,4", 10, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2020, 2, 7, 6, 12, 54, 681, DateTimeKind.Local).AddTicks(3571), "0,2,4", 24, 2, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2019, 12, 9, 23, 59, 56, 289, DateTimeKind.Local).AddTicks(6888), "1,2,4", 16, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2020, 5, 17, 15, 32, 22, 451, DateTimeKind.Local).AddTicks(8300), "0,2,5", 26, 6, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2020, 4, 21, 21, 38, 43, 97, DateTimeKind.Local).AddTicks(2808), "1,3,4", 48, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2019, 12, 27, 7, 55, 29, 598, DateTimeKind.Local).AddTicks(1992), "1,2,6", 47, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2019, 10, 26, 17, 56, 34, 808, DateTimeKind.Local).AddTicks(8296), "0,2,4", 46, 3, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2019, 10, 12, 10, 0, 58, 909, DateTimeKind.Local).AddTicks(536), "1,2,5", 25, 2, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2019, 9, 22, 16, 14, 13, 955, DateTimeKind.Local).AddTicks(3860), "0,3,4", 44, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2019, 7, 15, 15, 33, 48, 862, DateTimeKind.Local).AddTicks(3196), "1,3,4", 43, 4, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2020, 1, 31, 1, 57, 8, 204, DateTimeKind.Local).AddTicks(3986), "1,3,5", 42, 1, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2019, 12, 2, 20, 50, 45, 559, DateTimeKind.Local).AddTicks(8187), "0,2,5", 41, 5, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2019, 7, 29, 12, 26, 15, 763, DateTimeKind.Local).AddTicks(8172), "0,3,4", 40, 2, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2020, 1, 7, 3, 12, 13, 783, DateTimeKind.Local).AddTicks(5709), "1,3,6", 39, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2020, 4, 19, 5, 51, 26, 842, DateTimeKind.Local).AddTicks(3972), "0,3,6", 38, 1, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2020, 2, 10, 8, 53, 8, 170, DateTimeKind.Local).AddTicks(7171), "1,3,5", 37, 2, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2020, 2, 24, 15, 45, 34, 507, DateTimeKind.Local).AddTicks(4223), "0,2,4", 45, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2020, 2, 23, 7, 57, 44, 390, DateTimeKind.Local).AddTicks(9910), "0,2,4", 35, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2019, 9, 24, 5, 55, 6, 234, DateTimeKind.Local).AddTicks(4762), "1,3,5", 34, 1, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2019, 7, 16, 17, 34, 8, 783, DateTimeKind.Local).AddTicks(7393), "1,3,5", 33, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2020, 2, 9, 9, 59, 40, 820, DateTimeKind.Local).AddTicks(4066), "0,2,4", 27, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2020, 6, 15, 19, 43, 36, 17, DateTimeKind.Local).AddTicks(2085), "1,3,4", 32, 3, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2019, 7, 18, 1, 4, 15, 378, DateTimeKind.Local).AddTicks(775), "0,3,6", 31, 3, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2019, 12, 22, 14, 56, 10, 993, DateTimeKind.Local).AddTicks(1303), "1,3,5", 30, 3, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2019, 10, 13, 21, 35, 37, 83, DateTimeKind.Local).AddTicks(4630), "0,3,6", 29, 2, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2019, 8, 14, 15, 6, 50, 876, DateTimeKind.Local).AddTicks(3567), "1,3,4", 28, 5, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2019, 8, 13, 17, 11, 35, 814, DateTimeKind.Local).AddTicks(2205), "0,3,4", 36, 6, "Nouveau traité a été ajoutée", 1, "traite", false });

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
                values: new object[] { 9, "", "sous theme 9", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 15, "", "sous theme 15", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 14, "", "sous theme 14", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 13, "", "sous theme 13", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 11, "", "sous theme 11", "Droits catégoriels" });

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
                values: new object[] { 12, "", "sous theme 12", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 6, "", "sous theme 6", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 5, "", "sous theme 5", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 4, "", "sous theme 4", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 7, "", "sous theme 7", "Droits catégoriels" });

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
                values: new object[] { 66, "", "", new DateTime(2020, 5, 30, 0, 50, 14, 986, DateTimeKind.Local).AddTicks(7285), new DateTime(2020, 2, 17, 12, 31, 18, 220, DateTimeKind.Local).AddTicks(7964), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 67, "", "", new DateTime(2020, 2, 29, 8, 21, 13, 790, DateTimeKind.Local).AddTicks(8909), new DateTime(2019, 8, 2, 8, 32, 38, 17, DateTimeKind.Local).AddTicks(338), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 68, "", "", new DateTime(2020, 2, 3, 3, 42, 19, 577, DateTimeKind.Local).AddTicks(868), new DateTime(2020, 5, 8, 5, 47, 56, 286, DateTimeKind.Local).AddTicks(405), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 69, "", "", new DateTime(2020, 4, 4, 13, 32, 29, 392, DateTimeKind.Local).AddTicks(9675), new DateTime(2019, 12, 9, 10, 42, 34, 3, DateTimeKind.Local).AddTicks(8461), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 72, "", "", new DateTime(2019, 11, 10, 13, 18, 31, 37, DateTimeKind.Local).AddTicks(9173), new DateTime(2020, 2, 27, 15, 55, 46, 265, DateTimeKind.Local).AddTicks(4015), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 71, "", "", new DateTime(2020, 4, 13, 11, 39, 57, 21, DateTimeKind.Local).AddTicks(5083), new DateTime(2019, 6, 29, 20, 52, 1, 443, DateTimeKind.Local).AddTicks(9481), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 65, "", "", new DateTime(2020, 2, 13, 9, 1, 24, 231, DateTimeKind.Local).AddTicks(8050), new DateTime(2020, 4, 6, 16, 7, 7, 758, DateTimeKind.Local).AddTicks(2452), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 73, "", "", new DateTime(2020, 4, 12, 22, 49, 38, 164, DateTimeKind.Local).AddTicks(8837), new DateTime(2020, 4, 6, 22, 35, 14, 994, DateTimeKind.Local).AddTicks(9130), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 74, "", "", new DateTime(2020, 1, 29, 1, 19, 8, 957, DateTimeKind.Local).AddTicks(8743), new DateTime(2019, 11, 22, 14, 29, 51, 721, DateTimeKind.Local).AddTicks(5267), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 70, "", "", new DateTime(2019, 11, 30, 16, 11, 14, 941, DateTimeKind.Local).AddTicks(7905), new DateTime(2020, 4, 12, 9, 31, 13, 552, DateTimeKind.Local).AddTicks(7534), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 64, "", "", new DateTime(2019, 7, 26, 7, 35, 7, 381, DateTimeKind.Local).AddTicks(1024), new DateTime(2020, 3, 24, 9, 30, 11, 522, DateTimeKind.Local).AddTicks(4549), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 62, "", "", new DateTime(2020, 2, 5, 1, 17, 22, 160, DateTimeKind.Local).AddTicks(7926), new DateTime(2019, 7, 7, 17, 34, 9, 910, DateTimeKind.Local).AddTicks(4005), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 53, "", "", new DateTime(2019, 9, 27, 13, 35, 49, 776, DateTimeKind.Local).AddTicks(7817), new DateTime(2020, 5, 31, 5, 18, 45, 928, DateTimeKind.Local).AddTicks(3557), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 61, "", "", new DateTime(2020, 3, 30, 18, 5, 39, 408, DateTimeKind.Local).AddTicks(2962), new DateTime(2020, 5, 12, 1, 58, 17, 125, DateTimeKind.Local).AddTicks(1060), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 60, "", "", new DateTime(2019, 9, 22, 4, 51, 58, 495, DateTimeKind.Local).AddTicks(9395), new DateTime(2020, 4, 17, 14, 26, 57, 347, DateTimeKind.Local).AddTicks(1752), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 59, "", "", new DateTime(2020, 3, 1, 19, 34, 33, 26, DateTimeKind.Local).AddTicks(3905), new DateTime(2019, 6, 24, 14, 39, 28, 842, DateTimeKind.Local).AddTicks(8299), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 58, "", "", new DateTime(2019, 7, 23, 11, 18, 58, 882, DateTimeKind.Local).AddTicks(408), new DateTime(2020, 3, 8, 7, 50, 59, 376, DateTimeKind.Local).AddTicks(2390), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 57, "", "", new DateTime(2019, 11, 24, 10, 26, 36, 16, DateTimeKind.Local).AddTicks(3637), new DateTime(2019, 11, 7, 17, 39, 54, 659, DateTimeKind.Local).AddTicks(8687), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 56, "", "", new DateTime(2019, 8, 29, 4, 2, 52, 823, DateTimeKind.Local).AddTicks(7880), new DateTime(2020, 5, 15, 3, 12, 40, 431, DateTimeKind.Local).AddTicks(1145), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 55, "", "", new DateTime(2019, 11, 18, 11, 44, 26, 992, DateTimeKind.Local).AddTicks(5936), new DateTime(2019, 10, 10, 13, 54, 48, 507, DateTimeKind.Local).AddTicks(5666), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 54, "", "", new DateTime(2019, 12, 3, 21, 53, 15, 510, DateTimeKind.Local).AddTicks(5886), new DateTime(2020, 1, 25, 16, 12, 22, 635, DateTimeKind.Local).AddTicks(9209), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 75, "", "", new DateTime(2020, 2, 5, 3, 44, 56, 279, DateTimeKind.Local).AddTicks(3752), new DateTime(2019, 10, 23, 14, 59, 38, 798, DateTimeKind.Local).AddTicks(3792), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 63, "", "", new DateTime(2020, 3, 31, 1, 41, 11, 265, DateTimeKind.Local).AddTicks(3762), new DateTime(2020, 3, 4, 10, 50, 10, 8, DateTimeKind.Local).AddTicks(5172), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 76, "", "", new DateTime(2019, 8, 6, 20, 53, 16, 307, DateTimeKind.Local).AddTicks(2049), new DateTime(2019, 12, 2, 14, 25, 44, 813, DateTimeKind.Local).AddTicks(3564), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 91, "", "", new DateTime(2020, 3, 5, 6, 11, 54, 834, DateTimeKind.Local).AddTicks(8924), new DateTime(2019, 9, 7, 16, 21, 24, 15, DateTimeKind.Local).AddTicks(4346), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 78, "", "", new DateTime(2019, 9, 10, 2, 47, 30, 382, DateTimeKind.Local).AddTicks(7239), new DateTime(2020, 1, 16, 8, 38, 54, 868, DateTimeKind.Local).AddTicks(1699), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 52, "", "", new DateTime(2019, 12, 19, 16, 57, 36, 416, DateTimeKind.Local).AddTicks(461), new DateTime(2020, 1, 24, 9, 59, 56, 239, DateTimeKind.Local).AddTicks(5910), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 100, "", "", new DateTime(2020, 4, 30, 10, 48, 21, 268, DateTimeKind.Local).AddTicks(9649), new DateTime(2019, 7, 9, 22, 37, 59, 228, DateTimeKind.Local).AddTicks(1028), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 99, "", "", new DateTime(2020, 1, 14, 22, 42, 56, 879, DateTimeKind.Local).AddTicks(2256), new DateTime(2019, 11, 22, 13, 25, 27, 942, DateTimeKind.Local).AddTicks(9168), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 98, "", "", new DateTime(2019, 12, 13, 17, 30, 13, 514, DateTimeKind.Local).AddTicks(5621), new DateTime(2019, 8, 1, 7, 48, 24, 832, DateTimeKind.Local).AddTicks(363), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 97, "", "", new DateTime(2019, 6, 29, 23, 59, 43, 197, DateTimeKind.Local).AddTicks(7896), new DateTime(2019, 8, 1, 18, 4, 44, 723, DateTimeKind.Local).AddTicks(6846), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 96, "", "", new DateTime(2019, 12, 19, 0, 20, 17, 559, DateTimeKind.Local).AddTicks(3077), new DateTime(2020, 5, 17, 5, 4, 55, 717, DateTimeKind.Local).AddTicks(7396), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 95, "", "", new DateTime(2020, 4, 17, 3, 40, 40, 288, DateTimeKind.Local).AddTicks(3049), new DateTime(2019, 10, 13, 22, 34, 40, 860, DateTimeKind.Local).AddTicks(582), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 94, "", "", new DateTime(2020, 5, 15, 7, 39, 43, 222, DateTimeKind.Local).AddTicks(588), new DateTime(2019, 10, 3, 15, 55, 35, 233, DateTimeKind.Local).AddTicks(1773), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 93, "", "", new DateTime(2019, 10, 13, 3, 11, 44, 129, DateTimeKind.Local).AddTicks(9824), new DateTime(2019, 10, 27, 0, 2, 50, 439, DateTimeKind.Local).AddTicks(7727), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 92, "", "", new DateTime(2020, 2, 29, 1, 37, 12, 853, DateTimeKind.Local).AddTicks(7577), new DateTime(2020, 1, 12, 16, 53, 40, 416, DateTimeKind.Local).AddTicks(2408), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 77, "", "", new DateTime(2020, 5, 22, 3, 28, 57, 226, DateTimeKind.Local).AddTicks(8073), new DateTime(2020, 3, 27, 6, 52, 28, 202, DateTimeKind.Local).AddTicks(7856), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 90, "", "", new DateTime(2019, 11, 21, 21, 5, 39, 414, DateTimeKind.Local).AddTicks(1787), new DateTime(2020, 5, 12, 20, 0, 57, 259, DateTimeKind.Local).AddTicks(5357), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 88, "", "", new DateTime(2020, 2, 10, 19, 16, 20, 925, DateTimeKind.Local).AddTicks(603), new DateTime(2020, 1, 3, 0, 50, 27, 878, DateTimeKind.Local).AddTicks(1331), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 87, "", "", new DateTime(2019, 12, 21, 22, 56, 9, 643, DateTimeKind.Local).AddTicks(7505), new DateTime(2020, 2, 21, 4, 47, 23, 248, DateTimeKind.Local).AddTicks(9096), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 86, "", "", new DateTime(2019, 11, 14, 23, 29, 9, 381, DateTimeKind.Local).AddTicks(289), new DateTime(2020, 6, 22, 12, 5, 33, 460, DateTimeKind.Local).AddTicks(8558), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 85, "", "", new DateTime(2019, 10, 18, 9, 50, 44, 828, DateTimeKind.Local).AddTicks(1575), new DateTime(2019, 7, 25, 19, 10, 14, 996, DateTimeKind.Local).AddTicks(1579), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 84, "", "", new DateTime(2020, 1, 31, 17, 2, 26, 529, DateTimeKind.Local).AddTicks(9195), new DateTime(2019, 8, 10, 14, 8, 46, 984, DateTimeKind.Local).AddTicks(9832), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 83, "", "", new DateTime(2020, 4, 27, 17, 5, 51, 237, DateTimeKind.Local).AddTicks(1950), new DateTime(2019, 9, 27, 7, 51, 3, 357, DateTimeKind.Local).AddTicks(234), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 82, "", "", new DateTime(2019, 10, 3, 15, 50, 16, 2, DateTimeKind.Local).AddTicks(7669), new DateTime(2019, 10, 6, 8, 3, 20, 522, DateTimeKind.Local).AddTicks(7266), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 81, "", "", new DateTime(2019, 7, 10, 20, 33, 38, 704, DateTimeKind.Local).AddTicks(7951), new DateTime(2019, 10, 23, 21, 38, 6, 486, DateTimeKind.Local).AddTicks(7154), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 80, "", "", new DateTime(2020, 1, 28, 18, 36, 24, 312, DateTimeKind.Local).AddTicks(6078), new DateTime(2020, 4, 25, 23, 53, 2, 930, DateTimeKind.Local).AddTicks(9519), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 79, "", "", new DateTime(2019, 12, 23, 5, 25, 43, 941, DateTimeKind.Local).AddTicks(5374), new DateTime(2019, 8, 20, 2, 31, 29, 994, DateTimeKind.Local).AddTicks(3333), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 89, "", "", new DateTime(2019, 9, 18, 5, 20, 26, 937, DateTimeKind.Local).AddTicks(8542), new DateTime(2020, 1, 26, 21, 0, 36, 801, DateTimeKind.Local).AddTicks(9373), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 51, "", "", new DateTime(2020, 1, 7, 9, 53, 22, 722, DateTimeKind.Local).AddTicks(7919), new DateTime(2019, 9, 26, 6, 43, 1, 756, DateTimeKind.Local).AddTicks(1696), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 8, "", "", new DateTime(2020, 3, 22, 11, 28, 8, 62, DateTimeKind.Local).AddTicks(8562), new DateTime(2020, 3, 11, 16, 58, 24, 381, DateTimeKind.Local).AddTicks(4124), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 49, "", "", new DateTime(2019, 10, 7, 0, 27, 20, 677, DateTimeKind.Local).AddTicks(7327), new DateTime(2019, 12, 16, 6, 56, 10, 71, DateTimeKind.Local).AddTicks(6229), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 22, "", "", new DateTime(2020, 4, 3, 6, 54, 59, 216, DateTimeKind.Local).AddTicks(6074), new DateTime(2019, 10, 10, 11, 16, 20, 864, DateTimeKind.Local).AddTicks(1666), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 21, "", "", new DateTime(2020, 5, 20, 2, 31, 30, 267, DateTimeKind.Local).AddTicks(7447), new DateTime(2019, 10, 16, 15, 28, 43, 228, DateTimeKind.Local).AddTicks(3864), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 20, "", "", new DateTime(2019, 6, 25, 20, 58, 37, 785, DateTimeKind.Local).AddTicks(3101), new DateTime(2019, 7, 3, 6, 35, 56, 561, DateTimeKind.Local).AddTicks(7977), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 19, "", "", new DateTime(2019, 7, 26, 16, 23, 8, 658, DateTimeKind.Local).AddTicks(160), new DateTime(2020, 4, 10, 12, 27, 19, 480, DateTimeKind.Local).AddTicks(4008), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 18, "", "", new DateTime(2020, 4, 8, 8, 57, 15, 282, DateTimeKind.Local).AddTicks(904), new DateTime(2019, 8, 31, 1, 34, 17, 295, DateTimeKind.Local).AddTicks(8429), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 17, "", "", new DateTime(2019, 8, 13, 7, 21, 37, 387, DateTimeKind.Local).AddTicks(357), new DateTime(2019, 8, 22, 16, 2, 18, 966, DateTimeKind.Local).AddTicks(9011), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 16, "", "", new DateTime(2020, 2, 17, 6, 15, 2, 938, DateTimeKind.Local).AddTicks(8519), new DateTime(2019, 11, 26, 23, 28, 58, 706, DateTimeKind.Local).AddTicks(3996), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 15, "", "", new DateTime(2020, 1, 11, 7, 8, 56, 228, DateTimeKind.Local).AddTicks(5349), new DateTime(2020, 5, 24, 0, 21, 39, 573, DateTimeKind.Local).AddTicks(5423), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 14, "", "", new DateTime(2020, 3, 20, 2, 5, 6, 517, DateTimeKind.Local).AddTicks(222), new DateTime(2019, 7, 6, 7, 29, 22, 869, DateTimeKind.Local).AddTicks(6772), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 13, "", "", new DateTime(2019, 6, 29, 14, 45, 45, 217, DateTimeKind.Local).AddTicks(7538), new DateTime(2019, 11, 21, 0, 33, 51, 949, DateTimeKind.Local).AddTicks(7293), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 12, "", "", new DateTime(2019, 6, 28, 7, 25, 34, 233, DateTimeKind.Local).AddTicks(4534), new DateTime(2020, 2, 28, 20, 46, 27, 478, DateTimeKind.Local).AddTicks(2447), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 11, "", "", new DateTime(2020, 6, 6, 23, 49, 33, 526, DateTimeKind.Local).AddTicks(9251), new DateTime(2019, 8, 4, 20, 18, 6, 39, DateTimeKind.Local).AddTicks(7127), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 10, "", "", new DateTime(2019, 9, 29, 16, 26, 43, 370, DateTimeKind.Local).AddTicks(9272), new DateTime(2020, 3, 2, 3, 42, 25, 269, DateTimeKind.Local).AddTicks(1706), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 9, "", "", new DateTime(2020, 1, 21, 22, 43, 5, 926, DateTimeKind.Local).AddTicks(559), new DateTime(2020, 4, 17, 9, 11, 40, 970, DateTimeKind.Local).AddTicks(4296), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 7, "", "", new DateTime(2019, 7, 10, 20, 46, 49, 793, DateTimeKind.Local).AddTicks(3365), new DateTime(2019, 10, 22, 2, 41, 14, 818, DateTimeKind.Local).AddTicks(971), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 6, "", "", new DateTime(2020, 5, 10, 20, 43, 50, 662, DateTimeKind.Local).AddTicks(1787), new DateTime(2020, 6, 11, 0, 20, 6, 276, DateTimeKind.Local).AddTicks(136), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 5, "", "", new DateTime(2019, 7, 14, 7, 53, 21, 486, DateTimeKind.Local).AddTicks(278), new DateTime(2020, 2, 23, 19, 43, 33, 174, DateTimeKind.Local).AddTicks(9365), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 4, "", "", new DateTime(2019, 9, 22, 22, 57, 44, 228, DateTimeKind.Local).AddTicks(1371), new DateTime(2019, 7, 28, 17, 32, 38, 350, DateTimeKind.Local).AddTicks(6668), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 3, "", "", new DateTime(2020, 1, 21, 19, 47, 16, 436, DateTimeKind.Local).AddTicks(3612), new DateTime(2019, 8, 17, 0, 49, 23, 727, DateTimeKind.Local).AddTicks(3856), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 2, "", "", new DateTime(2020, 1, 30, 17, 10, 52, 324, DateTimeKind.Local).AddTicks(8920), new DateTime(2020, 1, 23, 23, 15, 48, 704, DateTimeKind.Local).AddTicks(4322), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 50, "", "", new DateTime(2019, 10, 8, 4, 6, 22, 139, DateTimeKind.Local).AddTicks(3122), new DateTime(2019, 12, 20, 12, 37, 37, 277, DateTimeKind.Local).AddTicks(9125), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 23, "", "", new DateTime(2019, 11, 17, 17, 28, 17, 509, DateTimeKind.Local).AddTicks(9802), new DateTime(2019, 7, 10, 12, 35, 57, 415, DateTimeKind.Local).AddTicks(5316), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 24, "", "", new DateTime(2019, 8, 3, 17, 21, 9, 765, DateTimeKind.Local).AddTicks(6926), new DateTime(2020, 5, 5, 18, 6, 15, 607, DateTimeKind.Local).AddTicks(3850), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 1, "", "", new DateTime(2020, 1, 7, 11, 47, 17, 379, DateTimeKind.Local).AddTicks(1292), new DateTime(2020, 1, 24, 4, 11, 5, 555, DateTimeKind.Local).AddTicks(2650), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 26, "", "", new DateTime(2019, 7, 9, 18, 2, 16, 426, DateTimeKind.Local).AddTicks(8324), new DateTime(2019, 9, 3, 16, 27, 21, 997, DateTimeKind.Local).AddTicks(2869), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 25, "", "", new DateTime(2019, 7, 20, 18, 54, 26, 630, DateTimeKind.Local).AddTicks(2912), new DateTime(2019, 10, 15, 6, 49, 53, 439, DateTimeKind.Local).AddTicks(2771), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 47, "", "", new DateTime(2019, 9, 16, 1, 52, 13, 105, DateTimeKind.Local).AddTicks(7504), new DateTime(2020, 5, 18, 11, 20, 44, 513, DateTimeKind.Local).AddTicks(5431), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 46, "", "", new DateTime(2019, 6, 27, 10, 57, 51, 136, DateTimeKind.Local).AddTicks(1561), new DateTime(2020, 5, 17, 1, 8, 15, 583, DateTimeKind.Local).AddTicks(6218), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 45, "", "", new DateTime(2019, 8, 29, 15, 39, 36, 261, DateTimeKind.Local).AddTicks(4855), new DateTime(2019, 12, 4, 9, 2, 29, 476, DateTimeKind.Local).AddTicks(77), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 44, "", "", new DateTime(2020, 1, 20, 15, 19, 22, 470, DateTimeKind.Local).AddTicks(1176), new DateTime(2020, 5, 1, 14, 0, 32, 677, DateTimeKind.Local).AddTicks(7865), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 43, "", "", new DateTime(2019, 8, 25, 17, 56, 29, 101, DateTimeKind.Local).AddTicks(3462), new DateTime(2019, 9, 6, 14, 3, 34, 45, DateTimeKind.Local).AddTicks(4581), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 42, "", "", new DateTime(2019, 7, 31, 2, 46, 7, 861, DateTimeKind.Local).AddTicks(8389), new DateTime(2020, 1, 16, 3, 57, 13, 490, DateTimeKind.Local).AddTicks(5655), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 41, "", "", new DateTime(2019, 7, 13, 14, 38, 53, 730, DateTimeKind.Local).AddTicks(727), new DateTime(2020, 2, 20, 16, 40, 35, 251, DateTimeKind.Local).AddTicks(6077), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 40, "", "", new DateTime(2020, 5, 30, 21, 35, 2, 318, DateTimeKind.Local).AddTicks(9314), new DateTime(2019, 8, 6, 21, 49, 53, 454, DateTimeKind.Local).AddTicks(8755), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 39, "", "", new DateTime(2019, 11, 10, 16, 29, 35, 632, DateTimeKind.Local).AddTicks(9698), new DateTime(2020, 6, 15, 5, 42, 51, 382, DateTimeKind.Local).AddTicks(9982), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 38, "", "", new DateTime(2019, 7, 20, 6, 44, 6, 529, DateTimeKind.Local).AddTicks(5478), new DateTime(2020, 5, 26, 23, 41, 48, 828, DateTimeKind.Local).AddTicks(7079), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 48, "", "", new DateTime(2019, 7, 13, 12, 7, 35, 50, DateTimeKind.Local).AddTicks(3036), new DateTime(2020, 5, 8, 7, 58, 1, 769, DateTimeKind.Local).AddTicks(7752), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 36, "", "", new DateTime(2020, 3, 27, 22, 0, 41, 574, DateTimeKind.Local).AddTicks(2207), new DateTime(2020, 3, 13, 2, 10, 58, 814, DateTimeKind.Local).AddTicks(8020), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 27, "", "", new DateTime(2019, 7, 24, 9, 24, 59, 119, DateTimeKind.Local).AddTicks(6106), new DateTime(2020, 5, 29, 4, 36, 13, 150, DateTimeKind.Local).AddTicks(1724), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 37, "", "", new DateTime(2020, 5, 7, 17, 6, 0, 814, DateTimeKind.Local).AddTicks(6350), new DateTime(2019, 7, 11, 10, 29, 2, 394, DateTimeKind.Local).AddTicks(1892), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 29, "", "", new DateTime(2020, 2, 19, 21, 13, 15, 924, DateTimeKind.Local).AddTicks(7377), new DateTime(2019, 8, 23, 3, 0, 28, 407, DateTimeKind.Local).AddTicks(8089), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 30, "", "", new DateTime(2020, 3, 21, 12, 55, 52, 421, DateTimeKind.Local).AddTicks(3812), new DateTime(2020, 5, 27, 3, 10, 35, 738, DateTimeKind.Local).AddTicks(4145), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 31, "", "", new DateTime(2020, 1, 11, 1, 32, 6, 438, DateTimeKind.Local).AddTicks(1387), new DateTime(2019, 6, 28, 5, 55, 17, 595, DateTimeKind.Local).AddTicks(4237), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 28, "", "", new DateTime(2020, 5, 29, 8, 56, 49, 47, DateTimeKind.Local).AddTicks(7497), new DateTime(2019, 8, 10, 21, 13, 16, 146, DateTimeKind.Local).AddTicks(8628), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 33, "", "", new DateTime(2019, 9, 1, 16, 9, 53, 912, DateTimeKind.Local).AddTicks(633), new DateTime(2020, 4, 2, 12, 22, 7, 174, DateTimeKind.Local).AddTicks(9215), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 34, "", "", new DateTime(2020, 2, 12, 12, 30, 39, 806, DateTimeKind.Local).AddTicks(6233), new DateTime(2019, 9, 24, 0, 54, 55, 591, DateTimeKind.Local).AddTicks(8687), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 35, "", "", new DateTime(2019, 7, 6, 19, 56, 43, 627, DateTimeKind.Local).AddTicks(1512), new DateTime(2019, 7, 4, 2, 8, 37, 784, DateTimeKind.Local).AddTicks(3429), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 32, "", "", new DateTime(2020, 5, 7, 16, 59, 2, 747, DateTimeKind.Local).AddTicks(8475), new DateTime(2020, 4, 24, 11, 41, 46, 412, DateTimeKind.Local).AddTicks(2683), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 65, new DateTime(2019, 7, 30, 9, 27, 58, 203, DateTimeKind.Local).AddTicks(5966), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 72, new DateTime(2020, 5, 5, 2, 46, 11, 25, DateTimeKind.Local).AddTicks(8072), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 71, new DateTime(2019, 9, 23, 15, 39, 12, 40, DateTimeKind.Local).AddTicks(354), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 70, new DateTime(2019, 9, 3, 11, 40, 24, 298, DateTimeKind.Local).AddTicks(8719), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 69, new DateTime(2019, 10, 19, 21, 34, 32, 354, DateTimeKind.Local).AddTicks(110), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 68, new DateTime(2019, 8, 17, 2, 48, 51, 97, DateTimeKind.Local).AddTicks(7540), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 67, new DateTime(2019, 10, 6, 2, 44, 50, 649, DateTimeKind.Local).AddTicks(60), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 66, new DateTime(2019, 8, 6, 4, 9, 12, 865, DateTimeKind.Local).AddTicks(6446), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 64, new DateTime(2020, 4, 22, 20, 9, 43, 303, DateTimeKind.Local).AddTicks(2683), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 53, new DateTime(2020, 6, 20, 23, 13, 5, 952, DateTimeKind.Local).AddTicks(3317), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 62, new DateTime(2020, 4, 20, 12, 4, 33, 131, DateTimeKind.Local).AddTicks(9570), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 61, new DateTime(2020, 5, 13, 4, 34, 12, 949, DateTimeKind.Local).AddTicks(296), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 60, new DateTime(2019, 11, 3, 19, 39, 37, 927, DateTimeKind.Local).AddTicks(9856), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 59, new DateTime(2019, 9, 9, 12, 17, 20, 63, DateTimeKind.Local).AddTicks(7469), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 58, new DateTime(2019, 8, 30, 21, 29, 40, 172, DateTimeKind.Local).AddTicks(8823), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 57, new DateTime(2020, 3, 19, 12, 5, 50, 632, DateTimeKind.Local).AddTicks(3586), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 56, new DateTime(2019, 8, 18, 15, 36, 8, 116, DateTimeKind.Local).AddTicks(2885), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 55, new DateTime(2020, 3, 10, 0, 28, 57, 136, DateTimeKind.Local).AddTicks(1408), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 54, new DateTime(2019, 8, 6, 3, 18, 57, 44, DateTimeKind.Local).AddTicks(8905), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 73, new DateTime(2019, 9, 27, 20, 18, 41, 336, DateTimeKind.Local).AddTicks(7377), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 52, new DateTime(2020, 5, 15, 5, 14, 14, 733, DateTimeKind.Local).AddTicks(5802), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 63, new DateTime(2020, 4, 10, 3, 56, 6, 396, DateTimeKind.Local).AddTicks(1971), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 74, new DateTime(2019, 12, 9, 8, 4, 23, 214, DateTimeKind.Local).AddTicks(7592), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 85, new DateTime(2019, 11, 21, 10, 3, 31, 181, DateTimeKind.Local).AddTicks(809), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 76, new DateTime(2019, 12, 20, 0, 1, 8, 496, DateTimeKind.Local).AddTicks(5002), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 98, new DateTime(2019, 7, 9, 0, 37, 59, 430, DateTimeKind.Local).AddTicks(6763), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 51, new DateTime(2020, 2, 13, 20, 40, 4, 493, DateTimeKind.Local).AddTicks(9369), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 97, new DateTime(2020, 3, 2, 2, 29, 12, 300, DateTimeKind.Local).AddTicks(3376), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 96, new DateTime(2020, 6, 7, 12, 32, 35, 108, DateTimeKind.Local).AddTicks(8953), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 95, new DateTime(2019, 8, 22, 11, 11, 13, 603, DateTimeKind.Local).AddTicks(2827), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 94, new DateTime(2020, 4, 10, 1, 58, 5, 899, DateTimeKind.Local).AddTicks(2298), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 93, new DateTime(2020, 1, 25, 20, 2, 44, 632, DateTimeKind.Local).AddTicks(51), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 92, new DateTime(2019, 6, 28, 5, 36, 34, 76, DateTimeKind.Local).AddTicks(2519), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 91, new DateTime(2019, 6, 25, 4, 47, 42, 969, DateTimeKind.Local).AddTicks(9988), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 90, new DateTime(2020, 4, 7, 18, 43, 21, 164, DateTimeKind.Local).AddTicks(2520), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 75, new DateTime(2019, 8, 12, 4, 10, 13, 34, DateTimeKind.Local).AddTicks(734), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 89, new DateTime(2019, 10, 27, 18, 22, 52, 767, DateTimeKind.Local).AddTicks(5732), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 87, new DateTime(2020, 5, 29, 17, 29, 47, 611, DateTimeKind.Local).AddTicks(9215), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 86, new DateTime(2019, 10, 9, 16, 17, 40, 801, DateTimeKind.Local).AddTicks(5503), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 84, new DateTime(2019, 7, 7, 19, 59, 34, 645, DateTimeKind.Local).AddTicks(9743), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 83, new DateTime(2020, 6, 1, 5, 41, 33, 762, DateTimeKind.Local).AddTicks(8418), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 82, new DateTime(2020, 5, 30, 19, 52, 5, 774, DateTimeKind.Local).AddTicks(1343), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 81, new DateTime(2020, 1, 28, 3, 5, 44, 215, DateTimeKind.Local).AddTicks(1959), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 80, new DateTime(2020, 5, 14, 4, 0, 57, 672, DateTimeKind.Local).AddTicks(2182), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 79, new DateTime(2020, 3, 6, 10, 5, 54, 446, DateTimeKind.Local).AddTicks(7585), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 78, new DateTime(2020, 3, 6, 9, 9, 29, 462, DateTimeKind.Local).AddTicks(980), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 77, new DateTime(2020, 5, 9, 4, 53, 28, 101, DateTimeKind.Local).AddTicks(4348), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 88, new DateTime(2019, 9, 22, 4, 42, 43, 477, DateTimeKind.Local).AddTicks(3911), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 50, new DateTime(2019, 12, 18, 14, 18, 59, 293, DateTimeKind.Local).AddTicks(220), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 26, new DateTime(2020, 5, 26, 9, 24, 32, 178, DateTimeKind.Local).AddTicks(4974), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 48, new DateTime(2019, 12, 20, 17, 1, 12, 243, DateTimeKind.Local).AddTicks(8920), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 20, new DateTime(2020, 2, 26, 19, 9, 29, 750, DateTimeKind.Local).AddTicks(1111), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 19, new DateTime(2019, 11, 7, 17, 31, 29, 191, DateTimeKind.Local).AddTicks(9003), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 18, new DateTime(2019, 12, 11, 10, 6, 36, 835, DateTimeKind.Local).AddTicks(3593), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 17, new DateTime(2019, 7, 14, 11, 17, 26, 222, DateTimeKind.Local).AddTicks(8113), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 16, new DateTime(2020, 6, 3, 8, 54, 45, 683, DateTimeKind.Local).AddTicks(787), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 15, new DateTime(2020, 4, 22, 18, 19, 55, 471, DateTimeKind.Local).AddTicks(4031), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 14, new DateTime(2020, 1, 15, 10, 10, 53, 11, DateTimeKind.Local).AddTicks(1903), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 13, new DateTime(2019, 9, 6, 19, 44, 11, 276, DateTimeKind.Local).AddTicks(9690), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 12, new DateTime(2019, 8, 3, 21, 53, 53, 73, DateTimeKind.Local).AddTicks(3946), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 11, new DateTime(2020, 3, 1, 7, 29, 25, 346, DateTimeKind.Local).AddTicks(4541), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 10, new DateTime(2020, 5, 19, 11, 22, 22, 170, DateTimeKind.Local).AddTicks(5471), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 9, new DateTime(2019, 12, 27, 12, 29, 43, 887, DateTimeKind.Local).AddTicks(4298), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 8, new DateTime(2020, 2, 24, 7, 8, 54, 676, DateTimeKind.Local).AddTicks(4786), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 7, new DateTime(2020, 1, 23, 19, 15, 52, 187, DateTimeKind.Local).AddTicks(2479), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 6, new DateTime(2019, 11, 28, 10, 26, 49, 415, DateTimeKind.Local).AddTicks(3703), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 5, new DateTime(2019, 11, 16, 21, 49, 1, 288, DateTimeKind.Local).AddTicks(9653), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 4, new DateTime(2019, 7, 27, 21, 33, 43, 985, DateTimeKind.Local).AddTicks(7105), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 3, new DateTime(2019, 11, 2, 5, 43, 21, 15, DateTimeKind.Local).AddTicks(9580), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 2, new DateTime(2020, 1, 13, 0, 20, 46, 819, DateTimeKind.Local).AddTicks(8817), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 1, new DateTime(2020, 2, 2, 15, 34, 51, 382, DateTimeKind.Local).AddTicks(8490), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 99, new DateTime(2019, 12, 24, 10, 38, 32, 32, DateTimeKind.Local).AddTicks(8383), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 21, new DateTime(2019, 8, 23, 14, 14, 1, 900, DateTimeKind.Local).AddTicks(8581), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 22, new DateTime(2020, 2, 18, 22, 22, 54, 357, DateTimeKind.Local).AddTicks(6248), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 23, new DateTime(2020, 5, 30, 5, 19, 36, 380, DateTimeKind.Local).AddTicks(6661), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 24, new DateTime(2020, 4, 21, 3, 49, 17, 720, DateTimeKind.Local).AddTicks(4970), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 47, new DateTime(2020, 2, 24, 2, 23, 51, 738, DateTimeKind.Local).AddTicks(8051), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 46, new DateTime(2020, 5, 16, 18, 6, 46, 903, DateTimeKind.Local).AddTicks(6186), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 45, new DateTime(2019, 12, 17, 5, 58, 47, 391, DateTimeKind.Local).AddTicks(8541), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 44, new DateTime(2019, 12, 10, 23, 26, 11, 402, DateTimeKind.Local).AddTicks(5312), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 43, new DateTime(2019, 7, 15, 14, 34, 40, 782, DateTimeKind.Local).AddTicks(1697), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 42, new DateTime(2019, 9, 26, 2, 2, 43, 658, DateTimeKind.Local).AddTicks(8097), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 41, new DateTime(2019, 8, 27, 8, 24, 26, 752, DateTimeKind.Local).AddTicks(2132), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 40, new DateTime(2019, 12, 3, 21, 39, 55, 94, DateTimeKind.Local).AddTicks(3584), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 39, new DateTime(2020, 5, 19, 19, 0, 9, 647, DateTimeKind.Local).AddTicks(9735), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 38, new DateTime(2020, 4, 2, 19, 57, 51, 306, DateTimeKind.Local).AddTicks(6463), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 49, new DateTime(2020, 2, 10, 6, 2, 45, 541, DateTimeKind.Local).AddTicks(4046), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 37, new DateTime(2019, 12, 9, 23, 2, 9, 935, DateTimeKind.Local).AddTicks(1804), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 35, new DateTime(2019, 12, 9, 14, 32, 21, 571, DateTimeKind.Local).AddTicks(9263), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 34, new DateTime(2020, 4, 3, 11, 59, 41, 573, DateTimeKind.Local).AddTicks(2440), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 33, new DateTime(2020, 5, 4, 2, 55, 34, 220, DateTimeKind.Local).AddTicks(2738), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 32, new DateTime(2019, 10, 15, 3, 39, 11, 779, DateTimeKind.Local).AddTicks(9236), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 31, new DateTime(2020, 4, 21, 4, 16, 29, 861, DateTimeKind.Local).AddTicks(846), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 30, new DateTime(2019, 10, 27, 23, 56, 47, 488, DateTimeKind.Local).AddTicks(4637), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 29, new DateTime(2019, 7, 26, 3, 23, 44, 854, DateTimeKind.Local).AddTicks(9515), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 28, new DateTime(2020, 4, 12, 7, 38, 14, 653, DateTimeKind.Local).AddTicks(4845), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 27, new DateTime(2020, 2, 5, 19, 24, 44, 43, DateTimeKind.Local).AddTicks(1737), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 25, new DateTime(2019, 11, 6, 17, 35, 26, 986, DateTimeKind.Local).AddTicks(1961), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 36, new DateTime(2020, 2, 18, 20, 37, 49, 649, DateTimeKind.Local).AddTicks(7806), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 100, new DateTime(2019, 12, 21, 2, 50, 57, 382, DateTimeKind.Local).AddTicks(7036), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 6, 24, 19, 15, 48, 873, DateTimeKind.Local).AddTicks(1261), new DateTime(2020, 6, 25, 2, 1, 56, 573, DateTimeKind.Local).AddTicks(3143), new DateTime(2020, 6, 24, 17, 53, 29, 955, DateTimeKind.Local).AddTicks(745), 48, "", "http://alice.fr", "ea" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 6, 25, 8, 32, 34, 353, DateTimeKind.Local).AddTicks(8178), new DateTime(2020, 6, 24, 17, 20, 10, 35, DateTimeKind.Local).AddTicks(8430), new DateTime(2020, 6, 25, 6, 27, 41, 616, DateTimeKind.Local).AddTicks(5855), 67, "", "https://lina.fr", "quo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 6, 25, 10, 18, 29, 29, DateTimeKind.Local).AddTicks(7703), new DateTime(2020, 6, 25, 8, 13, 57, 904, DateTimeKind.Local).AddTicks(4094), new DateTime(2020, 6, 24, 12, 36, 38, 322, DateTimeKind.Local).AddTicks(4124), 67, "", "http://pierre.eu", "cupiditate" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 6, 24, 23, 59, 42, 862, DateTimeKind.Local).AddTicks(5222), new DateTime(2020, 6, 25, 11, 1, 19, 979, DateTimeKind.Local).AddTicks(8718), new DateTime(2020, 6, 24, 17, 28, 12, 355, DateTimeKind.Local).AddTicks(6481), 66, "", "http://adam.com", "fugiat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 6, 25, 7, 27, 7, 170, DateTimeKind.Local).AddTicks(5717), new DateTime(2020, 6, 24, 13, 53, 12, 828, DateTimeKind.Local).AddTicks(6775), new DateTime(2020, 6, 25, 5, 16, 3, 388, DateTimeKind.Local).AddTicks(4398), 65, "", "http://mathilde.info", "corporis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 6, 24, 16, 58, 0, 808, DateTimeKind.Local).AddTicks(951), new DateTime(2020, 6, 25, 11, 56, 44, 484, DateTimeKind.Local).AddTicks(8511), new DateTime(2020, 6, 25, 10, 32, 24, 325, DateTimeKind.Local).AddTicks(7342), 63, "", "http://lilou.name", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 6, 25, 0, 1, 4, 165, DateTimeKind.Local).AddTicks(5878), new DateTime(2020, 6, 25, 3, 4, 38, 195, DateTimeKind.Local).AddTicks(9759), new DateTime(2020, 6, 25, 3, 2, 29, 449, DateTimeKind.Local).AddTicks(2198), 63, "", "http://marie.com", "fugit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 6, 25, 3, 6, 45, 164, DateTimeKind.Local).AddTicks(1102), new DateTime(2020, 6, 24, 15, 59, 45, 522, DateTimeKind.Local).AddTicks(2997), new DateTime(2020, 6, 25, 9, 8, 47, 641, DateTimeKind.Local).AddTicks(8726), 63, "", "http://kylian.com", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 6, 25, 5, 41, 6, 184, DateTimeKind.Local).AddTicks(9679), new DateTime(2020, 6, 24, 14, 48, 40, 393, DateTimeKind.Local).AddTicks(2628), new DateTime(2020, 6, 25, 1, 24, 38, 101, DateTimeKind.Local).AddTicks(2186), 63, "", "http://thomas.name", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 6, 25, 1, 8, 58, 468, DateTimeKind.Local).AddTicks(7482), new DateTime(2020, 6, 24, 22, 53, 6, 32, DateTimeKind.Local).AddTicks(2163), new DateTime(2020, 6, 24, 14, 36, 24, 973, DateTimeKind.Local).AddTicks(853), 62, "", "http://léo.name", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 6, 25, 7, 49, 34, 604, DateTimeKind.Local).AddTicks(5919), new DateTime(2020, 6, 24, 23, 46, 55, 178, DateTimeKind.Local).AddTicks(1524), new DateTime(2020, 6, 24, 20, 22, 36, 882, DateTimeKind.Local).AddTicks(4567), 62, "", "https://juliette.name", "saepe" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 6, 24, 23, 20, 34, 998, DateTimeKind.Local).AddTicks(821), new DateTime(2020, 6, 24, 21, 26, 39, 843, DateTimeKind.Local).AddTicks(7707), new DateTime(2020, 6, 25, 9, 58, 56, 498, DateTimeKind.Local).AddTicks(9919), 62, "", "http://léa.eu", "commodi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 6, 24, 12, 50, 13, 855, DateTimeKind.Local).AddTicks(2530), new DateTime(2020, 6, 25, 4, 4, 47, 877, DateTimeKind.Local).AddTicks(4951), new DateTime(2020, 6, 25, 11, 4, 25, 459, DateTimeKind.Local).AddTicks(4304), 68, "", "https://noa.info", "laudantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 6, 24, 12, 48, 33, 43, DateTimeKind.Local).AddTicks(1141), new DateTime(2020, 6, 24, 23, 54, 38, 173, DateTimeKind.Local).AddTicks(7355), new DateTime(2020, 6, 24, 23, 37, 31, 705, DateTimeKind.Local).AddTicks(2340), 61, "", "http://clara.com", "libero" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 6, 24, 16, 29, 13, 178, DateTimeKind.Local).AddTicks(3174), new DateTime(2020, 6, 25, 6, 49, 6, 603, DateTimeKind.Local).AddTicks(5075), new DateTime(2020, 6, 25, 2, 8, 30, 655, DateTimeKind.Local).AddTicks(1095), 61, "", "http://evan.com", "neque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 6, 25, 2, 37, 14, 492, DateTimeKind.Local).AddTicks(2392), new DateTime(2020, 6, 24, 14, 29, 48, 658, DateTimeKind.Local).AddTicks(7105), new DateTime(2020, 6, 25, 9, 24, 53, 82, DateTimeKind.Local).AddTicks(589), 60, "", "http://elisa.com", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 6, 24, 19, 7, 49, 764, DateTimeKind.Local).AddTicks(4464), new DateTime(2020, 6, 25, 1, 32, 54, 522, DateTimeKind.Local).AddTicks(6210), new DateTime(2020, 6, 25, 3, 58, 51, 578, DateTimeKind.Local).AddTicks(8890), 59, "", "https://pauline.info", "id" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 6, 25, 1, 41, 9, 432, DateTimeKind.Local).AddTicks(8946), new DateTime(2020, 6, 24, 22, 40, 29, 570, DateTimeKind.Local).AddTicks(5037), new DateTime(2020, 6, 24, 16, 0, 31, 330, DateTimeKind.Local).AddTicks(2728), 56, "", "https://manon.info", "saepe" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 6, 24, 21, 35, 33, 807, DateTimeKind.Local).AddTicks(5983), new DateTime(2020, 6, 25, 11, 40, 7, 482, DateTimeKind.Local).AddTicks(4343), new DateTime(2020, 6, 24, 21, 13, 38, 993, DateTimeKind.Local).AddTicks(4477), 54, "", "http://charlotte.name", "atque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 6, 25, 7, 11, 50, 54, DateTimeKind.Local).AddTicks(7640), new DateTime(2020, 6, 25, 10, 9, 49, 529, DateTimeKind.Local).AddTicks(923), new DateTime(2020, 6, 25, 2, 21, 45, 613, DateTimeKind.Local).AddTicks(7362), 52, "", "https://enzo.net", "fuga" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 6, 25, 11, 26, 47, 324, DateTimeKind.Local).AddTicks(6222), new DateTime(2020, 6, 25, 2, 17, 51, 806, DateTimeKind.Local).AddTicks(8930), new DateTime(2020, 6, 24, 23, 25, 1, 188, DateTimeKind.Local).AddTicks(6679), 51, "", "https://jeanne.com", "vel" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 6, 24, 12, 12, 29, 76, DateTimeKind.Local).AddTicks(6516), new DateTime(2020, 6, 24, 15, 53, 13, 114, DateTimeKind.Local).AddTicks(4583), new DateTime(2020, 6, 25, 7, 22, 12, 992, DateTimeKind.Local).AddTicks(8774), 50, "", "http://ethan.org", "rem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 6, 24, 22, 59, 32, 73, DateTimeKind.Local).AddTicks(3320), new DateTime(2020, 6, 25, 4, 14, 1, 699, DateTimeKind.Local).AddTicks(4571), new DateTime(2020, 6, 24, 19, 51, 19, 247, DateTimeKind.Local).AddTicks(3556), 50, "", "https://pauline.fr", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 6, 24, 18, 9, 34, 771, DateTimeKind.Local).AddTicks(4800), new DateTime(2020, 6, 24, 22, 55, 19, 73, DateTimeKind.Local).AddTicks(1062), new DateTime(2020, 6, 25, 10, 32, 49, 908, DateTimeKind.Local).AddTicks(2057), 50, "", "https://pauline.fr", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 6, 25, 11, 17, 12, 99, DateTimeKind.Local).AddTicks(2330), new DateTime(2020, 6, 24, 21, 48, 50, 520, DateTimeKind.Local).AddTicks(1219), new DateTime(2020, 6, 25, 6, 51, 28, 738, DateTimeKind.Local).AddTicks(9137), 49, "", "http://antoine.net", "eligendi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 6, 25, 4, 59, 5, 116, DateTimeKind.Local).AddTicks(6560), new DateTime(2020, 6, 25, 3, 37, 22, 47, DateTimeKind.Local).AddTicks(4135), new DateTime(2020, 6, 24, 21, 31, 35, 667, DateTimeKind.Local).AddTicks(6294), 61, "", "http://paul.net", "unde" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 6, 25, 4, 29, 30, 533, DateTimeKind.Local).AddTicks(1854), new DateTime(2020, 6, 24, 23, 1, 21, 571, DateTimeKind.Local).AddTicks(6952), new DateTime(2020, 6, 25, 10, 40, 47, 93, DateTimeKind.Local).AddTicks(4788), 69, "", "http://lou.name", "officiis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 6, 24, 14, 6, 26, 561, DateTimeKind.Local).AddTicks(177), new DateTime(2020, 6, 25, 3, 50, 34, 337, DateTimeKind.Local).AddTicks(6946), new DateTime(2020, 6, 25, 0, 40, 53, 94, DateTimeKind.Local).AddTicks(4136), 69, "", "https://paul.fr", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 6, 24, 22, 58, 48, 367, DateTimeKind.Local).AddTicks(1389), new DateTime(2020, 6, 24, 21, 37, 44, 962, DateTimeKind.Local).AddTicks(948), new DateTime(2020, 6, 24, 12, 21, 18, 740, DateTimeKind.Local).AddTicks(8754), 69, "", "http://nicolas.info", "cumque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 6, 25, 7, 42, 33, 90, DateTimeKind.Local).AddTicks(6053), new DateTime(2020, 6, 25, 3, 27, 57, 485, DateTimeKind.Local).AddTicks(9071), new DateTime(2020, 6, 24, 13, 23, 8, 457, DateTimeKind.Local).AddTicks(3039), 97, "", "https://louis.name", "ducimus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 6, 25, 4, 3, 23, 796, DateTimeKind.Local).AddTicks(4317), new DateTime(2020, 6, 24, 20, 50, 48, 528, DateTimeKind.Local).AddTicks(7946), new DateTime(2020, 6, 25, 3, 34, 57, 82, DateTimeKind.Local).AddTicks(2944), 97, "", "https://enzo.info", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 6, 24, 21, 48, 11, 826, DateTimeKind.Local).AddTicks(2267), new DateTime(2020, 6, 25, 0, 44, 40, 207, DateTimeKind.Local).AddTicks(5855), new DateTime(2020, 6, 24, 15, 29, 23, 39, DateTimeKind.Local).AddTicks(192), 95, "", "https://quentin.com", "facere" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 6, 25, 1, 20, 20, 260, DateTimeKind.Local).AddTicks(8195), new DateTime(2020, 6, 24, 12, 10, 1, 221, DateTimeKind.Local).AddTicks(2004), new DateTime(2020, 6, 24, 18, 56, 20, 279, DateTimeKind.Local).AddTicks(9268), 93, "", "http://mael.info", "maxime" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 6, 24, 23, 59, 12, 669, DateTimeKind.Local).AddTicks(1996), new DateTime(2020, 6, 25, 8, 5, 36, 521, DateTimeKind.Local).AddTicks(590), new DateTime(2020, 6, 24, 15, 49, 51, 440, DateTimeKind.Local).AddTicks(7568), 89, "", "https://kylian.com", "magnam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 6, 25, 1, 53, 35, 133, DateTimeKind.Local).AddTicks(5533), new DateTime(2020, 6, 24, 20, 37, 14, 534, DateTimeKind.Local).AddTicks(9482), new DateTime(2020, 6, 24, 14, 43, 29, 929, DateTimeKind.Local).AddTicks(8051), 89, "", "https://léo.fr", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 6, 24, 16, 52, 57, 548, DateTimeKind.Local).AddTicks(986), new DateTime(2020, 6, 25, 2, 58, 14, 879, DateTimeKind.Local).AddTicks(715), new DateTime(2020, 6, 24, 17, 0, 10, 124, DateTimeKind.Local).AddTicks(7122), 88, "", "https://rayan.net", "corporis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 6, 25, 10, 54, 40, 805, DateTimeKind.Local).AddTicks(7913), new DateTime(2020, 6, 24, 19, 35, 35, 803, DateTimeKind.Local).AddTicks(855), new DateTime(2020, 6, 24, 20, 36, 34, 183, DateTimeKind.Local).AddTicks(5265), 87, "", "http://lilou.net", "cum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 6, 25, 7, 1, 36, 181, DateTimeKind.Local).AddTicks(2910), new DateTime(2020, 6, 25, 5, 42, 6, 612, DateTimeKind.Local).AddTicks(8331), new DateTime(2020, 6, 25, 2, 21, 10, 933, DateTimeKind.Local).AddTicks(4191), 87, "", "http://alicia.com", "doloremque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 6, 25, 9, 45, 30, 264, DateTimeKind.Local).AddTicks(777), new DateTime(2020, 6, 24, 12, 44, 36, 609, DateTimeKind.Local).AddTicks(5367), new DateTime(2020, 6, 25, 4, 12, 39, 37, DateTimeKind.Local).AddTicks(6135), 85, "", "https://noah.org", "rem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 6, 25, 11, 46, 26, 439, DateTimeKind.Local).AddTicks(5038), new DateTime(2020, 6, 24, 14, 1, 28, 189, DateTimeKind.Local).AddTicks(3281), new DateTime(2020, 6, 25, 1, 13, 12, 365, DateTimeKind.Local).AddTicks(3044), 85, "", "https://lucas.org", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 6, 25, 9, 43, 28, 867, DateTimeKind.Local).AddTicks(8879), new DateTime(2020, 6, 25, 8, 32, 58, 253, DateTimeKind.Local).AddTicks(549), new DateTime(2020, 6, 25, 11, 29, 52, 326, DateTimeKind.Local).AddTicks(6500), 83, "", "http://yanis.eu", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 6, 25, 4, 17, 53, 390, DateTimeKind.Local).AddTicks(331), new DateTime(2020, 6, 24, 14, 58, 14, 761, DateTimeKind.Local).AddTicks(8582), new DateTime(2020, 6, 24, 17, 41, 16, 705, DateTimeKind.Local).AddTicks(3861), 80, "", "https://lucas.name", "placeat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 6, 25, 9, 29, 47, 444, DateTimeKind.Local).AddTicks(5685), new DateTime(2020, 6, 25, 6, 8, 42, 596, DateTimeKind.Local).AddTicks(2243), new DateTime(2020, 6, 24, 22, 25, 59, 750, DateTimeKind.Local).AddTicks(2997), 80, "", "http://rayan.eu", "a" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 6, 25, 8, 45, 5, 480, DateTimeKind.Local).AddTicks(509), new DateTime(2020, 6, 24, 15, 4, 2, 365, DateTimeKind.Local).AddTicks(245), new DateTime(2020, 6, 24, 13, 25, 9, 683, DateTimeKind.Local).AddTicks(1805), 79, "", "http://louise.name", "voluptatum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 6, 25, 7, 20, 16, 996, DateTimeKind.Local).AddTicks(3961), new DateTime(2020, 6, 25, 11, 3, 42, 361, DateTimeKind.Local).AddTicks(4309), new DateTime(2020, 6, 24, 23, 56, 52, 873, DateTimeKind.Local).AddTicks(4981), 79, "", "http://léa.com", "nihil" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 6, 25, 1, 47, 56, 575, DateTimeKind.Local).AddTicks(3009), new DateTime(2020, 6, 24, 21, 18, 47, 825, DateTimeKind.Local).AddTicks(4690), new DateTime(2020, 6, 25, 0, 45, 41, 958, DateTimeKind.Local).AddTicks(9052), 79, "", "http://evan.org", "commodi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 6, 25, 10, 43, 22, 520, DateTimeKind.Local).AddTicks(1138), new DateTime(2020, 6, 25, 6, 15, 16, 812, DateTimeKind.Local).AddTicks(247), new DateTime(2020, 6, 24, 22, 14, 14, 582, DateTimeKind.Local).AddTicks(3222), 78, "", "http://alice.eu", "totam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 6, 24, 18, 58, 55, 723, DateTimeKind.Local).AddTicks(3534), new DateTime(2020, 6, 24, 21, 28, 3, 631, DateTimeKind.Local).AddTicks(105), new DateTime(2020, 6, 25, 9, 20, 22, 970, DateTimeKind.Local).AddTicks(4843), 78, "", "http://thomas.net", "deserunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 6, 24, 20, 29, 40, 826, DateTimeKind.Local).AddTicks(1565), new DateTime(2020, 6, 24, 13, 49, 7, 722, DateTimeKind.Local).AddTicks(8278), new DateTime(2020, 6, 24, 12, 17, 27, 700, DateTimeKind.Local).AddTicks(9988), 76, "", "https://adrien.fr", "voluptas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 6, 25, 11, 28, 17, 121, DateTimeKind.Local).AddTicks(8605), new DateTime(2020, 6, 24, 17, 43, 11, 141, DateTimeKind.Local).AddTicks(2432), new DateTime(2020, 6, 25, 3, 6, 39, 378, DateTimeKind.Local).AddTicks(4415), 75, "", "http://mathilde.eu", "sed" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 6, 24, 19, 36, 22, 779, DateTimeKind.Local).AddTicks(6127), new DateTime(2020, 6, 25, 12, 0, 29, 296, DateTimeKind.Local).AddTicks(5455), new DateTime(2020, 6, 24, 17, 55, 43, 935, DateTimeKind.Local).AddTicks(4407), 73, "", "http://noémie.info", "maxime" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 6, 25, 3, 25, 3, 563, DateTimeKind.Local).AddTicks(2985), new DateTime(2020, 6, 25, 6, 43, 27, 930, DateTimeKind.Local).AddTicks(5600), new DateTime(2020, 6, 25, 9, 41, 11, 652, DateTimeKind.Local).AddTicks(2466), 73, "", "http://lou.org", "modi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 6, 25, 11, 41, 42, 255, DateTimeKind.Local).AddTicks(9618), new DateTime(2020, 6, 25, 11, 21, 29, 193, DateTimeKind.Local).AddTicks(9038), new DateTime(2020, 6, 25, 8, 51, 37, 18, DateTimeKind.Local).AddTicks(7759), 72, "", "http://lena.com", "id" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 6, 25, 2, 30, 32, 893, DateTimeKind.Local).AddTicks(3059), new DateTime(2020, 6, 25, 11, 45, 3, 655, DateTimeKind.Local).AddTicks(1654), new DateTime(2020, 6, 25, 10, 52, 58, 434, DateTimeKind.Local).AddTicks(7797), 72, "", "https://mélissa.net", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 6, 25, 0, 46, 35, 487, DateTimeKind.Local).AddTicks(4246), new DateTime(2020, 6, 24, 12, 31, 48, 199, DateTimeKind.Local).AddTicks(6810), new DateTime(2020, 6, 25, 6, 44, 19, 52, DateTimeKind.Local).AddTicks(9321), 48, "", "http://romane.net", "occaecati" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 6, 25, 11, 12, 17, 563, DateTimeKind.Local).AddTicks(1223), new DateTime(2020, 6, 24, 13, 45, 26, 912, DateTimeKind.Local).AddTicks(5598), new DateTime(2020, 6, 24, 21, 27, 39, 962, DateTimeKind.Local).AddTicks(4297), 48, "", "http://thomas.net", "quis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 6, 25, 0, 57, 45, 437, DateTimeKind.Local).AddTicks(4279), new DateTime(2020, 6, 25, 10, 9, 50, 380, DateTimeKind.Local).AddTicks(1628), new DateTime(2020, 6, 24, 16, 39, 53, 617, DateTimeKind.Local).AddTicks(6276), 99, "", "https://maeva.com", "reiciendis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 6, 25, 0, 31, 21, 67, DateTimeKind.Local).AddTicks(6050), new DateTime(2020, 6, 24, 21, 50, 43, 971, DateTimeKind.Local).AddTicks(9362), new DateTime(2020, 6, 25, 11, 24, 48, 1, DateTimeKind.Local).AddTicks(6561), 46, "", "http://evan.net", "quos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 6, 24, 16, 38, 20, 556, DateTimeKind.Local).AddTicks(7371), new DateTime(2020, 6, 24, 18, 41, 38, 481, DateTimeKind.Local).AddTicks(2498), new DateTime(2020, 6, 24, 15, 49, 17, 20, DateTimeKind.Local).AddTicks(3399), 19, "", "http://alicia.eu", "quas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 6, 25, 8, 26, 19, 694, DateTimeKind.Local).AddTicks(1986), new DateTime(2020, 6, 24, 23, 11, 48, 326, DateTimeKind.Local).AddTicks(5507), new DateTime(2020, 6, 25, 10, 42, 13, 662, DateTimeKind.Local).AddTicks(2478), 17, "", "https://lena.org", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 6, 25, 1, 8, 27, 346, DateTimeKind.Local).AddTicks(1207), new DateTime(2020, 6, 24, 12, 32, 2, 972, DateTimeKind.Local).AddTicks(7545), new DateTime(2020, 6, 24, 20, 12, 11, 741, DateTimeKind.Local).AddTicks(1018), 17, "", "http://camille.com", "soluta" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 6, 24, 16, 9, 12, 988, DateTimeKind.Local).AddTicks(117), new DateTime(2020, 6, 25, 3, 26, 19, 739, DateTimeKind.Local).AddTicks(5872), new DateTime(2020, 6, 25, 1, 41, 27, 351, DateTimeKind.Local).AddTicks(7883), 16, "", "https://maeva.org", "a" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 6, 25, 6, 11, 34, 827, DateTimeKind.Local).AddTicks(2013), new DateTime(2020, 6, 24, 21, 41, 54, 898, DateTimeKind.Local).AddTicks(9093), new DateTime(2020, 6, 24, 12, 40, 4, 489, DateTimeKind.Local).AddTicks(6770), 99, "", "https://mohamed.eu", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 6, 25, 3, 32, 37, 956, DateTimeKind.Local).AddTicks(3417), new DateTime(2020, 6, 25, 4, 52, 31, 505, DateTimeKind.Local).AddTicks(9630), new DateTime(2020, 6, 24, 16, 42, 7, 394, DateTimeKind.Local).AddTicks(2613), 12, "", "https://mélissa.eu", "asperiores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 6, 24, 18, 40, 12, 943, DateTimeKind.Local).AddTicks(9987), new DateTime(2020, 6, 24, 22, 59, 20, 452, DateTimeKind.Local).AddTicks(1529), new DateTime(2020, 6, 24, 14, 38, 44, 64, DateTimeKind.Local).AddTicks(5457), 11, "", "https://quentin.eu", "cupiditate" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 6, 25, 9, 51, 7, 990, DateTimeKind.Local).AddTicks(2015), new DateTime(2020, 6, 24, 18, 46, 9, 945, DateTimeKind.Local).AddTicks(7669), new DateTime(2020, 6, 24, 19, 0, 36, 649, DateTimeKind.Local).AddTicks(1340), 11, "", "http://hugo.name", "deserunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 6, 24, 13, 16, 24, 806, DateTimeKind.Local).AddTicks(7475), new DateTime(2020, 6, 24, 23, 18, 54, 964, DateTimeKind.Local).AddTicks(8592), new DateTime(2020, 6, 24, 17, 14, 19, 341, DateTimeKind.Local).AddTicks(6415), 21, "", "https://ambre.info", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 6, 25, 6, 37, 33, 454, DateTimeKind.Local).AddTicks(7311), new DateTime(2020, 6, 24, 22, 4, 30, 790, DateTimeKind.Local).AddTicks(8255), new DateTime(2020, 6, 24, 23, 43, 37, 381, DateTimeKind.Local).AddTicks(3467), 10, "", "http://valentin.eu", "eligendi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 6, 25, 5, 22, 51, 309, DateTimeKind.Local).AddTicks(8943), new DateTime(2020, 6, 25, 1, 47, 11, 123, DateTimeKind.Local).AddTicks(6358), new DateTime(2020, 6, 25, 3, 7, 12, 778, DateTimeKind.Local).AddTicks(8311), 9, "", "http://louis.com", "nemo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 6, 24, 18, 51, 34, 607, DateTimeKind.Local).AddTicks(3839), new DateTime(2020, 6, 25, 1, 55, 13, 970, DateTimeKind.Local).AddTicks(9088), new DateTime(2020, 6, 25, 10, 25, 43, 574, DateTimeKind.Local).AddTicks(9745), 8, "", "https://chloé.info", "odio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 6, 25, 7, 22, 23, 333, DateTimeKind.Local).AddTicks(1612), new DateTime(2020, 6, 24, 15, 46, 28, 824, DateTimeKind.Local).AddTicks(1221), new DateTime(2020, 6, 25, 9, 24, 34, 194, DateTimeKind.Local).AddTicks(4294), 8, "", "https://jade.info", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 6, 24, 22, 38, 1, 129, DateTimeKind.Local).AddTicks(7154), new DateTime(2020, 6, 25, 9, 12, 50, 918, DateTimeKind.Local).AddTicks(1844), new DateTime(2020, 6, 25, 10, 30, 54, 64, DateTimeKind.Local).AddTicks(7835), 3, "", "http://julie.eu", "minus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 6, 25, 7, 31, 56, 801, DateTimeKind.Local).AddTicks(5565), new DateTime(2020, 6, 24, 19, 23, 23, 240, DateTimeKind.Local).AddTicks(2512), new DateTime(2020, 6, 24, 18, 10, 55, 206, DateTimeKind.Local).AddTicks(2197), 3, "", "https://yanis.com", "laboriosam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 6, 24, 22, 30, 18, 326, DateTimeKind.Local).AddTicks(9843), new DateTime(2020, 6, 25, 5, 52, 58, 170, DateTimeKind.Local).AddTicks(3025), new DateTime(2020, 6, 24, 13, 28, 57, 373, DateTimeKind.Local).AddTicks(2763), 3, "", "https://alicia.info", "exercitationem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 6, 24, 19, 18, 53, 351, DateTimeKind.Local).AddTicks(5229), new DateTime(2020, 6, 24, 13, 14, 12, 903, DateTimeKind.Local).AddTicks(8697), new DateTime(2020, 6, 24, 12, 39, 24, 610, DateTimeKind.Local).AddTicks(6704), 2, "", "http://romain.name", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 6, 24, 17, 6, 9, 869, DateTimeKind.Local).AddTicks(5538), new DateTime(2020, 6, 24, 18, 49, 59, 576, DateTimeKind.Local).AddTicks(3436), new DateTime(2020, 6, 24, 21, 52, 48, 597, DateTimeKind.Local).AddTicks(7624), 1, "", "http://ines.name", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 6, 24, 19, 49, 29, 342, DateTimeKind.Local).AddTicks(7820), new DateTime(2020, 6, 24, 15, 52, 38, 314, DateTimeKind.Local).AddTicks(1647), new DateTime(2020, 6, 25, 6, 13, 37, 141, DateTimeKind.Local).AddTicks(5332), 9, "", "http://maëlys.name", "aliquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 6, 24, 18, 14, 9, 590, DateTimeKind.Local).AddTicks(3175), new DateTime(2020, 6, 25, 7, 8, 55, 389, DateTimeKind.Local).AddTicks(7779), new DateTime(2020, 6, 24, 13, 48, 55, 476, DateTimeKind.Local).AddTicks(8724), 21, "", "https://mattéo.fr", "rerum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 6, 25, 4, 32, 52, 574, DateTimeKind.Local).AddTicks(9419), new DateTime(2020, 6, 25, 4, 36, 0, 129, DateTimeKind.Local).AddTicks(1861), new DateTime(2020, 6, 24, 13, 58, 11, 698, DateTimeKind.Local).AddTicks(4035), 14, "", "https://lucie.org", "doloribus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 6, 25, 5, 12, 25, 581, DateTimeKind.Local).AddTicks(2978), new DateTime(2020, 6, 24, 16, 10, 41, 507, DateTimeKind.Local).AddTicks(7853), new DateTime(2020, 6, 25, 10, 13, 58, 154, DateTimeKind.Local).AddTicks(2654), 22, "", "http://sacha.info", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 6, 24, 23, 27, 10, 496, DateTimeKind.Local).AddTicks(9217), new DateTime(2020, 6, 25, 1, 59, 36, 609, DateTimeKind.Local).AddTicks(4584), new DateTime(2020, 6, 25, 11, 47, 26, 605, DateTimeKind.Local).AddTicks(4557), 45, "", "http://juliette.com", "porro" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 6, 24, 15, 31, 53, 812, DateTimeKind.Local).AddTicks(2946), new DateTime(2020, 6, 25, 10, 34, 49, 641, DateTimeKind.Local).AddTicks(6159), new DateTime(2020, 6, 25, 1, 0, 23, 519, DateTimeKind.Local).AddTicks(1925), 43, "", "https://océane.name", "doloremque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 6, 24, 22, 56, 21, 681, DateTimeKind.Local).AddTicks(6023), new DateTime(2020, 6, 24, 22, 28, 26, 633, DateTimeKind.Local).AddTicks(5568), new DateTime(2020, 6, 25, 9, 28, 38, 471, DateTimeKind.Local).AddTicks(5458), 22, "", "http://hugo.fr", "eveniet" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 6, 24, 21, 18, 56, 768, DateTimeKind.Local).AddTicks(9822), new DateTime(2020, 6, 25, 3, 42, 9, 81, DateTimeKind.Local).AddTicks(557), new DateTime(2020, 6, 24, 17, 25, 1, 342, DateTimeKind.Local).AddTicks(1090), 43, "", "http://noah.fr", "ex" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 6, 25, 0, 44, 53, 642, DateTimeKind.Local).AddTicks(4251), new DateTime(2020, 6, 24, 20, 35, 14, 294, DateTimeKind.Local).AddTicks(4987), new DateTime(2020, 6, 25, 9, 50, 34, 37, DateTimeKind.Local).AddTicks(2968), 42, "", "https://noah.fr", "delectus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 6, 24, 20, 15, 22, 816, DateTimeKind.Local).AddTicks(8683), new DateTime(2020, 6, 25, 7, 9, 48, 56, DateTimeKind.Local).AddTicks(9384), new DateTime(2020, 6, 25, 11, 0, 5, 198, DateTimeKind.Local).AddTicks(5769), 41, "", "http://paul.net", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 6, 25, 5, 1, 5, 830, DateTimeKind.Local).AddTicks(2320), new DateTime(2020, 6, 24, 20, 16, 4, 492, DateTimeKind.Local).AddTicks(1313), new DateTime(2020, 6, 24, 15, 57, 54, 197, DateTimeKind.Local).AddTicks(3883), 40, "", "https://maëlle.info", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 6, 24, 22, 1, 29, 359, DateTimeKind.Local).AddTicks(622), new DateTime(2020, 6, 24, 17, 44, 16, 805, DateTimeKind.Local).AddTicks(1046), new DateTime(2020, 6, 25, 11, 56, 25, 450, DateTimeKind.Local).AddTicks(3489), 39, "", "http://louna.eu", "dignissimos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 6, 25, 10, 38, 43, 933, DateTimeKind.Local).AddTicks(3996), new DateTime(2020, 6, 25, 1, 48, 38, 299, DateTimeKind.Local).AddTicks(1017), new DateTime(2020, 6, 25, 4, 41, 46, 488, DateTimeKind.Local).AddTicks(4263), 38, "", "http://hugo.eu", "vitae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 6, 24, 14, 58, 48, 465, DateTimeKind.Local).AddTicks(1821), new DateTime(2020, 6, 24, 16, 53, 55, 528, DateTimeKind.Local).AddTicks(6674), new DateTime(2020, 6, 25, 9, 10, 35, 216, DateTimeKind.Local).AddTicks(4403), 43, "", "https://sacha.org", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 6, 24, 16, 39, 45, 103, DateTimeKind.Local).AddTicks(4644), new DateTime(2020, 6, 25, 0, 29, 48, 799, DateTimeKind.Local).AddTicks(618), new DateTime(2020, 6, 25, 2, 38, 26, 676, DateTimeKind.Local).AddTicks(4558), 35, "", "https://mathis.fr", "inventore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 6, 24, 16, 14, 31, 17, DateTimeKind.Local).AddTicks(8774), new DateTime(2020, 6, 24, 17, 54, 36, 907, DateTimeKind.Local).AddTicks(8567), new DateTime(2020, 6, 24, 19, 40, 0, 256, DateTimeKind.Local).AddTicks(9460), 30, "", "https://théo.name", "necessitatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 6, 24, 13, 40, 45, 775, DateTimeKind.Local).AddTicks(8269), new DateTime(2020, 6, 24, 22, 20, 48, 533, DateTimeKind.Local).AddTicks(2918), new DateTime(2020, 6, 24, 21, 42, 45, 929, DateTimeKind.Local).AddTicks(1769), 29, "", "https://ethan.fr", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 6, 24, 20, 26, 8, 221, DateTimeKind.Local).AddTicks(9717), new DateTime(2020, 6, 25, 11, 28, 36, 853, DateTimeKind.Local).AddTicks(7807), new DateTime(2020, 6, 25, 9, 8, 57, 734, DateTimeKind.Local).AddTicks(1087), 29, "", "https://lola.name", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 6, 24, 18, 53, 57, 393, DateTimeKind.Local).AddTicks(8561), new DateTime(2020, 6, 25, 6, 40, 3, 739, DateTimeKind.Local).AddTicks(4567), new DateTime(2020, 6, 24, 17, 42, 32, 378, DateTimeKind.Local).AddTicks(8362), 24, "", "https://clara.info", "temporibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 6, 24, 16, 19, 32, 174, DateTimeKind.Local).AddTicks(6304), new DateTime(2020, 6, 24, 19, 2, 45, 787, DateTimeKind.Local).AddTicks(148), new DateTime(2020, 6, 25, 7, 47, 10, 849, DateTimeKind.Local).AddTicks(1457), 24, "", "https://maëlle.com", "velit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 6, 25, 0, 17, 18, 58, DateTimeKind.Local).AddTicks(3594), new DateTime(2020, 6, 24, 20, 18, 27, 741, DateTimeKind.Local).AddTicks(1918), new DateTime(2020, 6, 24, 12, 25, 15, 638, DateTimeKind.Local).AddTicks(3300), 23, "", "https://mathis.eu", "ex" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 6, 24, 13, 42, 54, 725, DateTimeKind.Local).AddTicks(6655), new DateTime(2020, 6, 25, 1, 37, 52, 128, DateTimeKind.Local).AddTicks(2129), new DateTime(2020, 6, 25, 1, 10, 41, 865, DateTimeKind.Local).AddTicks(4001), 23, "", "http://théo.eu", "nihil" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 6, 24, 17, 38, 28, 132, DateTimeKind.Local).AddTicks(8916), new DateTime(2020, 6, 25, 11, 54, 7, 766, DateTimeKind.Local).AddTicks(4105), new DateTime(2020, 6, 25, 7, 41, 33, 313, DateTimeKind.Local).AddTicks(7005), 22, "", "http://louna.fr", "laborum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 6, 25, 11, 51, 56, 949, DateTimeKind.Local).AddTicks(8753), new DateTime(2020, 6, 24, 19, 57, 26, 659, DateTimeKind.Local).AddTicks(9636), new DateTime(2020, 6, 24, 18, 48, 40, 392, DateTimeKind.Local).AddTicks(8647), 36, "", "http://noémie.eu", "hic" });

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
                values: new object[] { 13, "0.8.7.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 4, 4, 2, 1, 1, 8, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 4, "2.9.6.1", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 32, 1, 6, 2, 3, 5, 7, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 91, "8.1.5.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 29, 5, 1, 5, 2, 4, 9, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 65, "9.4.1.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 80, 1, 1, 4, 2, 4, 3, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 62, "7.1.0.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 63, 6, 3, 5, 1, 4, 3, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 54, "0.2.3.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 18, 4, 10, 2, 3, 4, 7, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 26, "4.4.5.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 7, 3, 5, 3, 4, 4, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 12, "9.8.4.6", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 46, 3, 8, 3, 1, 4, 8, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 94, "7.8.7.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 88, 5, 7, 5, 3, 10, 6, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 88, "2.8.1.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 6, 9, 5, 4, 10, 10, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 63, "5.8.9.9", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 3, 2, 2, 1, 10, 7, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 57, "5.4.8.9", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 83, 7, 7, 5, 3, 10, 10, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 47, "9.1.1.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 60, 7, 2, 3, 2, 10, 3, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 31, "0.0.5.7", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 49, 5, 2, 5, 2, 10, 1, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 17, "7.6.7.5", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 64, 2, 5, 4, 1, 10, 4, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 98, "7.5.5.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 26, 5, 1, 1, 1, 9, 4, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 89, "1.7.4.0", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 26, 2, 3, 5, 3, 9, 1, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 56, "1.0.0.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 34, 2, 9, 4, 4, 9, 4, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 41, "5.5.0.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 47, 5, 10, 4, 3, 9, 7, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 40, "0.8.1.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 2, 2, 1, 4, 9, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 19, "7.4.6.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 9, 7, 5, 2, 3, 9, 6, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 9, "4.3.3.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 46, 4, 5, 5, 2, 9, 7, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 11, "4.0.2.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 89, 7, 6, 1, 4, 5, 2, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 25, "8.6.7.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 6, 6, 1, 4, 5, 3, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 30, "6.2.4.9", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 3, 1, 5, 4, 5, 8, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 39, "3.9.5.5", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 1, 6, 5, 3, 5, 10, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 86, "6.0.6.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 6, 7, 5, 2, 6, 1, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 78, "0.6.2.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 31, 3, 2, 2, 4, 6, 5, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 76, "5.3.6.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 6, 7, 2, 1, 6, 7, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 74, "1.7.0.3", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 6, 5, 6, 2, 6, 4, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 67, "8.3.8.7", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 13, 4, 3, 2, 3, 6, 10, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 55, "9.3.1.6", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 34, 2, 6, 6, 3, 6, 10, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 45, "8.6.6.7", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 2, 7, 1, 3, 6, 4, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 44, "3.5.3.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 55, 4, 10, 2, 3, 6, 3, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 38, "9.6.7.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 43, 7, 8, 2, 3, 6, 8, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 22, "0.4.0.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 60, 3, 7, 6, 3, 6, 3, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 6, "6.3.9.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 76, 5, 8, 2, 2, 9, 7, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 21, "0.8.9.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 52, 3, 3, 4, 3, 6, 2, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 7, "8.6.2.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 68, 4, 3, 3, 4, 6, 5, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 99, "6.5.5.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 5, 6, 10, 1, 4, 5, 3, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 97, "5.9.1.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 6, 4, 6, 2, 3, 5, 10, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 96, "3.3.4.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 58, 2, 9, 1, 2, 5, 4, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 93, "1.2.5.0", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 96, 1, 4, 4, 1, 5, 6, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 70, "5.3.5.3", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 89, 5, 4, 4, 3, 5, 1, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 60, "2.1.3.9", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 1, 7, 3, 4, 5, 6, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 52, "1.4.9.7", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 8, 7, 2, 4, 1, 5, 9, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 51, "5.5.2.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 60, 6, 7, 5, 3, 5, 10, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 49, "7.5.0.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 4, 1, 1, 2, 5, 9, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 15, "5.8.9.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 7, 1, 2, 1, 6, 4, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 5, "0.6.9.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 61, 7, 8, 2, 2, 9, 1, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 90, "4.4.5.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 21, 2, 5, 4, 4, 6, 9, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 85, "0.8.5.9", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 5, 1, 4, 2, 8, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 33, "0.2.9.7", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 63, 3, 4, 2, 1, 3, 7, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 23, "3.4.2.7", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 61, 5, 8, 6, 3, 3, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 20, "4.3.9.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 74, 2, 3, 1, 1, 3, 7, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 84, "1.8.5.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 76, 3, 8, 1, 1, 2, 7, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 83, "7.3.9.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 1, 8, 2, 1, 2, 2, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 72, "6.1.8.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 3, 5, 3, 4, 2, 3, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 66, "8.6.9.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 42, 2, 7, 6, 1, 2, 10, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 64, "0.8.9.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 26, 5, 10, 1, 4, 2, 3, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 37, "9.7.4.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 1, 6, 4, 2, 2, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 16, "6.9.6.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 4, 5, 1, 2, 2, 8, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 8, "6.6.2.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 2, 3, 2, 4, 2, 10, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 100, "0.0.8.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 2, 2, 5, 3, 1, 6, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 92, "1.9.4.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 28, 6, 7, 2, 2, 1, 2, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 75, "4.6.0.0", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 77, 3, 10, 4, 4, 1, 7, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 73, "3.5.2.8", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 4, 10, 4, 2, 1, 4, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 61, "1.7.2.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 4, 1, 1, 2, 1, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 32, "2.2.9.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 59, 1, 3, 5, 4, 1, 6, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 29, "9.8.5.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 6, 2, 4, 4, 1, 2, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 28, "5.9.1.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 1, 1, 5, 2, 1, 7, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 27, "2.8.1.6", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 53, 3, 8, 5, 3, 1, 4, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 87, "3.5.9.5", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 51, 2, 7, 4, 1, 8, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 34, "4.7.9.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 2, 6, 3, 2, 3, 6, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 71, "7.8.0.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 42, 7, 6, 2, 2, 3, 3, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 50, "3.8.0.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 10, 2, 1, 1, 3, 2, 8, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 80, "9.6.4.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 1, 7, 4, 3, 3, 8, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 79, "3.2.5.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 3, 9, 1, 4, 3, 3, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 77, "7.3.3.6", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 29, 7, 10, 3, 4, 8, 10, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 59, "7.9.8.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 4, 9, 3, 2, 8, 4, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 58, "3.1.7.7", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 1, 1, 3, 2, 8, 3, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 48, "5.2.9.4", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 23, 5, 1, 5, 3, 8, 6, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 14, "3.7.3.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 76, 2, 10, 1, 3, 8, 5, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 10, "8.4.7.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 82, 4, 4, 2, 4, 8, 6, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 1, "1.6.5.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 82, 1, 7, 2, 1, 8, 8, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 82, "5.9.1.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 32, 2, 2, 6, 2, 7, 7, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 69, "5.8.2.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 50, 5, 10, 2, 2, 7, 2, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 68, "3.8.7.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 7, 7, 4, 2, 7, 4, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 2, "3.8.7.6", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 31, 7, 3, 4, 3, 8, 8, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 81, "1.9.1.2", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 53, 5, 10, 3, 3, 8, 2, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 53, "3.8.9.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 88, 7, 10, 2, 2, 7, 6, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 3, "4.0.7.7", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 7, 4, 2, 1, 3, 7, 10, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 18, "5.3.3.9", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 7, 4, 4, 4, 7, 1, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 24, "7.5.6.5", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 3, 3, 1, 3, 7, 7, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 35, "3.4.6.1", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 2, 3, 5, 1, 7, 5, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 95, "9.7.7.9", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 2, 1, 2, 3, 3, 5, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 42, "8.7.9.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 3, 4, 5, 3, 7, 4, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 43, "9.2.6.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 2, 3, 6, 2, 7, 3, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 46, "7.7.7.9", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 23, 1, 4, 6, 1, 7, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 36, "9.6.9.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 71, 6, 4, 1, 1, 7, 10, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "ea", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 40, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "consequuntur", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 36, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "dolorem", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 36, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 36, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "magnam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 26, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "saepe", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 14, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 4, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "odit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 66, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "illo", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 72, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "recusandae", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 24, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 49, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "cumque", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 54, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "sint", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 38, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "enim", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 38, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "temporibus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 2, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "eaque", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 2, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "assumenda", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 93, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "est", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 93, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "accusamus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 93, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "tempora", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 5, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "adipisci", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 32, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "iste", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 55, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "eos", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 41, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "dignissimos", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 74, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "cupiditate", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 41, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "nihil", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 49, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "est", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 11, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "quidem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 11, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "eum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 45, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "nisi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 45, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "debitis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 45, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "recusandae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 45, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "voluptatem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 9, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "autem", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 70, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 92, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "temporibus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 41, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "quibusdam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 92, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "accusamus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 59, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "velit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 37, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 37, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "quia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 37, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "minus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 37, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "velit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 37, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "temporibus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 60, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "facilis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 60, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "eligendi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 60, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "rerum", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 60, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "nisi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 92, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "molestias", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 27, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "nemo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 95, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "voluptas", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 13, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "magnam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 23, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "recusandae", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 15, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "saepe", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 79, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "aperiam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 79, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "ea", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 12, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "expedita", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 18, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "dolor", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 18, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "architecto", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 18, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 29, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "sed", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 29, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "fugit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 1, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "odio", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 1, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "hic", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 52, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "impedit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 53, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "exercitationem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 53, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "quis", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 6, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "ad", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 6, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "molestiae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 6, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "sed", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 80, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "occaecati", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 7, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "suscipit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 74, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "vel", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 75, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "maxime", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 75, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 75, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "qui", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 73, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "incidunt", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 8, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "quasi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 8, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "odit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 44, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "quasi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 20, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "eaque", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 71, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "laboriosam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 88, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 16, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "ea", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 81, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "aut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 68, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "ipsa", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 68, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "dolor", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 69, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "provident", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 30, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "adipisci", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 22, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "voluptatibus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 22, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "sequi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "aut", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "facilis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "libero", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 96, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "perferendis", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 89, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "saepe", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 83, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "quisquam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 62, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "alias", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 73, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "et", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 22, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 74, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/local", 3, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/back-end", 3, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/puerto-rico", 5, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/tasty", 3, 42 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/vertical/robust/generic-granite-salad", 6, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/louisiana/national/copy", 5, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/seychelles/indigo", 2, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/seychelles-rupee", 5, 13 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/dominican-republic/repurpose/transmitter", 2, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/us-dollar/gorgeous/synthesize", 6, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/bandwidth/frozen", 5, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/cyan", 6, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/virginia", 3, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/junction", 1, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/ergonomic/stable", 4, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/secured/roi/mindshare", 3, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/ergonomic-soft-table/generate/http", 1, 53 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/parsing", 6, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/platforms/place", 6, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/black/configurable/iterate", 6, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/gold/assurance", 2, 28 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/jbod", 3, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/sleek", 7, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/vortals/copying/convertible-marks", 3, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/backing-up/greece/agp", 7, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/invoice/virginia", 2, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/pike/credit-card-account/junctions", 6, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/communities/sleek-metal-ball", 5, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/executive/baby--outdoors", 6, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/roads/direct", 3, 52 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/factors", 1, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/avon", 5, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/prairie/frozen/deposit", 2, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/executive/white", 5, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/yemen/data-warehouse/usability", 4, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/ville", 4, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/granite", 1, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/western-sahara", 4, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/persistent", 4, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/pre-emptive/soft", 7, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/bluetooth", 7, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/salmon/standardization/investment-account", 5, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/district/front-line/field", 3, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/visualize", 5, 79 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/holistic/primary", 6, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/seamless/united-states-of-america/sleek", 6, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/pennsylvania/granite", 7, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/thx/stravenue", 3, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/savings-account", 7, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/local-area-network", 7, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/buckinghamshire/salmon", 2, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/myanmar", 5, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/senior/home-loan-account", 5, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/cape-verde-escudo/b2b/users", 5, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/leverage/plain/forge", 1, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/investment-account/cotton/facilitator", 5, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/invoice/pines/dynamic", 1, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/money-market-account/orchid", 2, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/markets", 5, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/argentina/practical-wooden-towels", 1, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/logistical/borders", 4, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/computers/regional/granite", 7, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/repurpose/rustic-fresh-gloves", 5, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/supervisor/bluetooth/point", 2, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/deposit/aggregate", 6, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/green", 5, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/beauty-movies--sports", 6, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/avon/vision-oriented/soft", 4, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/synthesize/alaska", 7, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/sensor/macao", 2, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/transitional/kwanza", 5, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/sleek/bedfordshire", 5, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/refined-rubber-tuna/architectures/associate", 5, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/garden--toys/invoice/backing-up", 6, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/response/bedfordshire", 3, 34 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/maximized/integration", 1, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/static", 3, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/override", 6, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/ssl/tasty/program", 2, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/bypass/engineer/fantastic-plastic-table", 3, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/redundant/mountains", 6, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/responsive/indigo/hybrid", 2, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/realigned", 6, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/e-commerce/database", 4, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/dong/navigate", 7, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/forks/ergonomic-concrete-bacon", 2, 87 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/legacy/auxiliary/index", 3, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/awesome-steel-hat", 7, 61 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/methodologies/movies-sports--industrial", 3, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/minnesota/24365/seychelles", 7, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/reboot/invoice", 4, 63 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/internet-solution/sensor", 6, 63 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/virtual/1080p", 5, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/global/money-market-account/invoice", 5, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/paradigms/repurpose/dynamic", 1, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/neural-net/forint", 6, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/soft/leading-edge/us-dollar", 4, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/communities/cordoba-oro/solution-oriented", 4, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/scalable/awesome-fresh-chair/leading-edge", 7, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/poland", 5, 39 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 1, new DateTime(2020, 3, 17, 19, 36, 54, 349, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 5, new DateTime(2019, 7, 28, 15, 2, 32, 661, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 5, new DateTime(2019, 6, 29, 22, 34, 2, 38, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 2, new DateTime(2020, 3, 18, 21, 3, 10, 380, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 3, new DateTime(2020, 4, 19, 8, 37, 35, 497, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 3, new DateTime(2020, 4, 23, 19, 14, 50, 478, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 5, new DateTime(2019, 9, 16, 9, 50, 26, 861, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 6, new DateTime(2020, 4, 23, 20, 55, 23, 106, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 1, new DateTime(2020, 3, 18, 20, 54, 33, 168, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 4, new DateTime(2019, 10, 31, 4, 47, 51, 274, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 3, new DateTime(2020, 6, 4, 18, 19, 42, 350, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 2, new DateTime(2019, 7, 21, 23, 27, 8, 960, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 6, new DateTime(2019, 9, 17, 13, 52, 17, 881, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 2, new DateTime(2019, 7, 10, 4, 52, 48, 849, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 2, new DateTime(2019, 10, 24, 17, 30, 24, 922, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 3, new DateTime(2020, 3, 1, 21, 31, 50, 110, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 5, new DateTime(2019, 11, 9, 18, 53, 20, 823, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 6, new DateTime(2019, 9, 9, 3, 5, 50, 386, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 6, new DateTime(2019, 8, 26, 22, 4, 1, 216, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 5, new DateTime(2019, 11, 14, 4, 53, 42, 838, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 5, new DateTime(2019, 12, 23, 4, 35, 40, 590, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 6, new DateTime(2019, 8, 8, 11, 23, 36, 105, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 1, new DateTime(2020, 5, 13, 5, 21, 6, 79, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 5, new DateTime(2020, 2, 19, 5, 24, 49, 997, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 2, new DateTime(2019, 7, 19, 22, 23, 47, 341, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 4, new DateTime(2019, 8, 21, 7, 32, 22, 570, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 5, new DateTime(2020, 5, 1, 15, 28, 32, 838, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 2, new DateTime(2019, 10, 17, 19, 28, 35, 353, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 3, new DateTime(2020, 1, 27, 12, 14, 47, 127, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 5, new DateTime(2020, 4, 28, 3, 52, 40, 571, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 1, new DateTime(2020, 3, 23, 6, 17, 7, 467, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 5, new DateTime(2019, 10, 1, 3, 37, 23, 246, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 4, new DateTime(2020, 5, 24, 13, 8, 1, 305, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 5, new DateTime(2020, 3, 19, 9, 52, 36, 609, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 3, new DateTime(2019, 8, 28, 11, 48, 44, 948, DateTimeKind.Local).AddTicks(746) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 1, new DateTime(2020, 5, 22, 12, 42, 3, 282, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 6, new DateTime(2020, 5, 5, 2, 48, 11, 717, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 4, new DateTime(2019, 12, 24, 12, 52, 24, 893, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 5, new DateTime(2019, 8, 15, 23, 45, 8, 98, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 5, new DateTime(2019, 12, 17, 12, 24, 11, 180, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 5, new DateTime(2020, 3, 30, 15, 52, 35, 170, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 5, new DateTime(2020, 6, 10, 13, 51, 53, 823, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 4, new DateTime(2020, 3, 6, 4, 33, 22, 706, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 2, new DateTime(2020, 1, 5, 11, 41, 1, 165, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 5, new DateTime(2019, 11, 17, 13, 12, 38, 914, DateTimeKind.Local).AddTicks(1217) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 2, new DateTime(2020, 5, 29, 23, 28, 2, 116, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 4, new DateTime(2020, 2, 7, 5, 48, 50, 927, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 2, new DateTime(2020, 6, 3, 4, 41, 23, 8, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 3, new DateTime(2019, 8, 14, 11, 45, 30, 753, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 2, new DateTime(2019, 7, 30, 5, 44, 41, 118, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 2, new DateTime(2019, 7, 9, 19, 42, 57, 430, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 6, new DateTime(2019, 8, 13, 2, 12, 20, 997, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 6, new DateTime(2020, 1, 18, 7, 10, 3, 732, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 4, new DateTime(2019, 8, 13, 9, 14, 28, 973, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 4, new DateTime(2020, 3, 5, 14, 22, 2, 268, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 3, new DateTime(2020, 6, 6, 9, 52, 38, 81, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 5, new DateTime(2019, 10, 20, 22, 44, 53, 24, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 1, new DateTime(2019, 11, 22, 15, 57, 28, 778, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 6, new DateTime(2020, 6, 6, 6, 40, 22, 672, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 2, new DateTime(2019, 12, 31, 8, 50, 35, 607, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 2, new DateTime(2019, 10, 10, 23, 48, 46, 727, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 4, new DateTime(2019, 7, 4, 4, 35, 14, 118, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 6, new DateTime(2020, 4, 25, 8, 10, 58, 919, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 3, new DateTime(2019, 11, 15, 23, 22, 39, 147, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 3, new DateTime(2019, 9, 16, 15, 36, 13, 110, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 1, new DateTime(2020, 5, 12, 19, 14, 12, 744, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 2, new DateTime(2020, 1, 20, 22, 17, 24, 898, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 2, new DateTime(2020, 6, 20, 19, 56, 2, 430, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 3, new DateTime(2020, 6, 1, 13, 31, 28, 777, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 3, new DateTime(2020, 6, 3, 12, 20, 38, 233, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 4, new DateTime(2019, 12, 17, 19, 20, 10, 566, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 6, new DateTime(2020, 3, 17, 8, 35, 43, 139, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 5, new DateTime(2019, 9, 24, 8, 18, 58, 389, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 5, new DateTime(2019, 9, 7, 1, 25, 4, 804, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 5, new DateTime(2020, 4, 28, 11, 19, 31, 608, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 5, new DateTime(2020, 5, 2, 8, 41, 15, 897, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 5, new DateTime(2019, 12, 4, 1, 29, 27, 681, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 4, new DateTime(2020, 1, 17, 2, 33, 32, 804, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 3, new DateTime(2020, 6, 19, 5, 56, 47, 430, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 2, new DateTime(2020, 4, 22, 11, 33, 13, 737, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 1, new DateTime(2019, 12, 13, 19, 51, 59, 950, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 1, new DateTime(2019, 9, 6, 16, 48, 34, 984, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 4, new DateTime(2020, 2, 24, 0, 22, 0, 558, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 1, new DateTime(2019, 12, 29, 6, 25, 39, 849, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 3, new DateTime(2019, 12, 5, 4, 32, 12, 77, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 5, new DateTime(2019, 8, 21, 15, 7, 33, 414, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 2, new DateTime(2019, 8, 12, 12, 58, 26, 242, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 3, new DateTime(2019, 12, 27, 12, 31, 49, 56, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 1, new DateTime(2020, 4, 17, 9, 45, 0, 652, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 3, new DateTime(2019, 8, 9, 22, 40, 37, 104, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 2, new DateTime(2019, 7, 14, 10, 41, 43, 809, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 6, new DateTime(2019, 12, 15, 10, 7, 29, 207, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 4, new DateTime(2019, 11, 12, 12, 25, 25, 279, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 1, new DateTime(2019, 8, 3, 6, 16, 16, 82, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 1, new DateTime(2020, 2, 2, 6, 53, 8, 349, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 5, new DateTime(2019, 11, 6, 5, 17, 44, 893, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 1, new DateTime(2019, 10, 10, 16, 44, 29, 125, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 6, new DateTime(2020, 1, 15, 6, 23, 26, 832, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 2, new DateTime(2020, 6, 17, 2, 13, 28, 580, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 6, new DateTime(2019, 12, 16, 21, 40, 24, 599, DateTimeKind.Local).AddTicks(1506) });

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
