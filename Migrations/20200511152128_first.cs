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
                values: new object[] { 1, "Démocratie et gouvernance" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 2, "Droits économiques, sociaux, culturels et environnementaux" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 3, "Promotion et protection des droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 4, "Cadre institutionnel et juridique" });

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
                values: new object[] { 8, "2040-2045" });

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
                values: new object[] { 5, "2025-2030" });

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
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 6, "", "", "Examen-7", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 5, "", "", "Examen-6", "", "", "" });

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
                values: new object[] { 65, new DateTime(2019, 10, 14, 4, 31, 34, 23, DateTimeKind.Local).AddTicks(7459), "0,2,5", 65, 4, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 73, new DateTime(2020, 2, 6, 21, 28, 15, 994, DateTimeKind.Local).AddTicks(1413), "1,3,4", 73, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2019, 12, 6, 8, 34, 50, 785, DateTimeKind.Local).AddTicks(9138), "1,2,4", 72, 2, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2019, 6, 30, 18, 47, 58, 36, DateTimeKind.Local).AddTicks(3626), "0,2,4", 71, 4, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2019, 10, 26, 9, 12, 6, 974, DateTimeKind.Local).AddTicks(1032), "1,3,5", 70, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2019, 10, 4, 22, 5, 27, 371, DateTimeKind.Local).AddTicks(7303), "1,2,6", 69, 1, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2020, 1, 11, 6, 42, 12, 792, DateTimeKind.Local).AddTicks(6242), "1,2,5", 68, 4, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2019, 10, 6, 6, 16, 4, 543, DateTimeKind.Local).AddTicks(3524), "0,2,4", 67, 3, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2020, 2, 6, 15, 6, 2, 430, DateTimeKind.Local).AddTicks(3968), "0,2,5", 66, 6, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2019, 8, 13, 6, 0, 48, 459, DateTimeKind.Local).AddTicks(4792), "0,3,5", 64, 6, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2020, 4, 21, 11, 30, 1, 868, DateTimeKind.Local).AddTicks(7991), "0,3,5", 54, 1, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2019, 10, 14, 22, 14, 41, 624, DateTimeKind.Local).AddTicks(4325), "0,2,5", 62, 1, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2019, 12, 17, 2, 30, 27, 219, DateTimeKind.Local).AddTicks(7779), "0,3,6", 61, 1, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2019, 7, 19, 5, 54, 36, 916, DateTimeKind.Local).AddTicks(8067), "0,2,4", 60, 4, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2019, 6, 15, 1, 40, 27, 196, DateTimeKind.Local).AddTicks(6562), "0,3,6", 59, 1, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2019, 5, 26, 16, 2, 1, 94, DateTimeKind.Local).AddTicks(5214), "1,2,6", 58, 3, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2019, 5, 11, 21, 25, 47, 539, DateTimeKind.Local).AddTicks(9127), "0,3,5", 57, 4, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2019, 8, 9, 8, 29, 26, 907, DateTimeKind.Local).AddTicks(5717), "0,3,5", 56, 2, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2019, 11, 6, 21, 5, 30, 257, DateTimeKind.Local).AddTicks(9567), "0,2,4", 55, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2019, 7, 30, 1, 59, 34, 702, DateTimeKind.Local).AddTicks(7163), "0,3,5", 74, 4, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2019, 7, 15, 21, 2, 13, 985, DateTimeKind.Local).AddTicks(278), "0,3,4", 53, 4, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2020, 2, 28, 23, 55, 24, 144, DateTimeKind.Local).AddTicks(7503), "0,2,4", 63, 5, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2020, 2, 2, 1, 10, 24, 113, DateTimeKind.Local).AddTicks(2495), "0,3,4", 75, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2019, 7, 30, 23, 46, 5, 204, DateTimeKind.Local).AddTicks(5587), "1,3,4", 85, 3, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2019, 12, 7, 13, 29, 21, 390, DateTimeKind.Local).AddTicks(1072), "0,2,4", 77, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2019, 7, 11, 19, 4, 23, 510, DateTimeKind.Local).AddTicks(6630), "0,2,6", 100, 2, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2019, 8, 3, 9, 37, 13, 777, DateTimeKind.Local).AddTicks(3398), "0,2,5", 99, 4, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2019, 7, 9, 19, 53, 25, 32, DateTimeKind.Local).AddTicks(209), "1,3,4", 98, 1, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2020, 5, 1, 6, 32, 10, 289, DateTimeKind.Local).AddTicks(8594), "1,2,4", 97, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2020, 3, 13, 5, 8, 43, 432, DateTimeKind.Local).AddTicks(799), "1,3,5", 96, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2019, 9, 8, 10, 22, 50, 999, DateTimeKind.Local).AddTicks(1783), "1,2,4", 95, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2020, 3, 28, 5, 46, 10, 47, DateTimeKind.Local).AddTicks(6519), "1,3,5", 94, 1, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2019, 6, 15, 16, 14, 5, 48, DateTimeKind.Local).AddTicks(1038), "1,2,4", 93, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2019, 8, 24, 6, 18, 1, 319, DateTimeKind.Local).AddTicks(8807), "0,2,4", 92, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2019, 5, 14, 11, 4, 12, 629, DateTimeKind.Local).AddTicks(7638), "1,3,6", 90, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2019, 8, 10, 18, 16, 5, 584, DateTimeKind.Local).AddTicks(5054), "0,2,4", 76, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2019, 9, 13, 1, 17, 33, 732, DateTimeKind.Local).AddTicks(1122), "0,3,5", 89, 3, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2019, 11, 21, 15, 30, 34, 119, DateTimeKind.Local).AddTicks(4633), "0,2,6", 87, 6, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2019, 9, 23, 21, 31, 53, 996, DateTimeKind.Local).AddTicks(446), "0,2,6", 86, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2019, 7, 30, 11, 46, 36, 669, DateTimeKind.Local).AddTicks(9976), "1,2,5", 52, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2019, 7, 24, 17, 36, 2, 134, DateTimeKind.Local).AddTicks(1500), "1,3,5", 84, 2, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2019, 12, 7, 22, 48, 51, 440, DateTimeKind.Local).AddTicks(7597), "0,3,4", 83, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2019, 11, 20, 19, 0, 56, 31, DateTimeKind.Local).AddTicks(9661), "0,3,5", 82, 3, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2020, 4, 28, 11, 49, 3, 249, DateTimeKind.Local).AddTicks(4705), "1,2,6", 81, 1, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2019, 11, 24, 22, 5, 59, 140, DateTimeKind.Local).AddTicks(4416), "1,2,5", 80, 3, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2020, 2, 9, 8, 43, 33, 611, DateTimeKind.Local).AddTicks(6193), "0,2,5", 79, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2019, 8, 31, 10, 17, 44, 83, DateTimeKind.Local).AddTicks(836), "1,2,6", 78, 6, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2020, 1, 28, 0, 12, 44, 990, DateTimeKind.Local).AddTicks(8996), "1,3,4", 88, 2, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2019, 9, 14, 8, 37, 59, 29, DateTimeKind.Local).AddTicks(3459), "1,2,5", 51, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2019, 5, 25, 1, 13, 51, 174, DateTimeKind.Local).AddTicks(8444), "1,2,6", 91, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2019, 5, 27, 17, 49, 40, 924, DateTimeKind.Local).AddTicks(9), "0,2,6", 49, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2020, 1, 27, 18, 23, 4, 874, DateTimeKind.Local).AddTicks(2459), "1,2,6", 22, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2019, 7, 3, 18, 9, 23, 553, DateTimeKind.Local).AddTicks(8139), "0,3,6", 21, 4, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2019, 5, 28, 13, 47, 5, 708, DateTimeKind.Local).AddTicks(4492), "1,2,5", 20, 4, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2019, 7, 16, 7, 35, 27, 347, DateTimeKind.Local).AddTicks(2678), "0,2,4", 19, 1, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2020, 2, 26, 4, 1, 44, 235, DateTimeKind.Local).AddTicks(2799), "0,2,4", 18, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2020, 3, 27, 19, 52, 0, 471, DateTimeKind.Local).AddTicks(3680), "1,2,6", 17, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2019, 8, 15, 2, 44, 0, 509, DateTimeKind.Local).AddTicks(901), "0,2,5", 16, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2019, 9, 3, 17, 54, 16, 888, DateTimeKind.Local).AddTicks(5078), "1,3,6", 14, 1, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2019, 11, 20, 5, 57, 50, 780, DateTimeKind.Local).AddTicks(7876), "0,2,6", 13, 5, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2019, 7, 10, 14, 49, 41, 133, DateTimeKind.Local).AddTicks(5266), "0,3,6", 12, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 2, 14, 12, 30, 36, 861, DateTimeKind.Local).AddTicks(7283), "1,3,6", 23, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2020, 3, 9, 22, 17, 35, 283, DateTimeKind.Local).AddTicks(1231), "0,3,6", 11, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2019, 9, 8, 11, 14, 28, 44, DateTimeKind.Local).AddTicks(5933), "0,3,6", 9, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2019, 6, 29, 9, 8, 40, 780, DateTimeKind.Local).AddTicks(4751), "0,2,6", 8, 1, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2020, 3, 8, 6, 13, 8, 834, DateTimeKind.Local).AddTicks(6569), "0,2,4", 7, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2019, 11, 5, 10, 44, 28, 371, DateTimeKind.Local).AddTicks(1449), "0,2,4", 6, 2, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2020, 4, 28, 10, 42, 12, 688, DateTimeKind.Local).AddTicks(5553), "1,2,5", 5, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2020, 3, 30, 23, 51, 13, 719, DateTimeKind.Local).AddTicks(6242), "0,2,4", 4, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2019, 10, 20, 6, 34, 55, 283, DateTimeKind.Local).AddTicks(1637), "1,2,6", 3, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2019, 10, 2, 22, 17, 3, 265, DateTimeKind.Local).AddTicks(7632), "1,2,6", 2, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2019, 7, 15, 11, 9, 21, 730, DateTimeKind.Local).AddTicks(6422), "0,2,5", 1, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2019, 8, 12, 1, 29, 28, 250, DateTimeKind.Local).AddTicks(1402), "1,2,5", 50, 1, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2020, 2, 2, 7, 40, 51, 564, DateTimeKind.Local).AddTicks(3180), "1,2,5", 10, 4, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2020, 5, 10, 14, 20, 53, 958, DateTimeKind.Local).AddTicks(1696), "0,3,4", 24, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2020, 2, 4, 3, 14, 2, 802, DateTimeKind.Local).AddTicks(691), "0,3,5", 15, 4, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2020, 1, 31, 2, 33, 6, 788, DateTimeKind.Local).AddTicks(7819), "0,3,5", 26, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2019, 8, 10, 23, 21, 30, 547, DateTimeKind.Local).AddTicks(7010), "0,2,4", 48, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2019, 8, 4, 21, 53, 30, 191, DateTimeKind.Local).AddTicks(7869), "0,3,6", 47, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2019, 11, 21, 6, 56, 32, 406, DateTimeKind.Local).AddTicks(8648), "1,2,5", 46, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2019, 7, 16, 17, 48, 45, 395, DateTimeKind.Local).AddTicks(8647), "0,2,6", 25, 5, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2020, 5, 2, 15, 11, 14, 347, DateTimeKind.Local).AddTicks(7078), "1,3,4", 44, 2, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2019, 9, 12, 6, 44, 7, 969, DateTimeKind.Local).AddTicks(2938), "1,2,5", 43, 2, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2019, 8, 25, 17, 27, 39, 881, DateTimeKind.Local).AddTicks(5423), "0,3,4", 42, 5, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2019, 8, 14, 8, 37, 46, 459, DateTimeKind.Local).AddTicks(9694), "0,3,4", 41, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2019, 11, 22, 16, 55, 38, 70, DateTimeKind.Local).AddTicks(1547), "0,2,5", 40, 1, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2019, 7, 7, 17, 59, 14, 770, DateTimeKind.Local).AddTicks(316), "0,2,6", 39, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2020, 3, 18, 9, 31, 48, 419, DateTimeKind.Local).AddTicks(1652), "0,2,5", 38, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2019, 10, 23, 2, 23, 0, 220, DateTimeKind.Local).AddTicks(8805), "0,3,4", 45, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2019, 9, 24, 0, 48, 50, 820, DateTimeKind.Local).AddTicks(9231), "1,3,4", 36, 6, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2019, 7, 18, 21, 12, 51, 827, DateTimeKind.Local).AddTicks(6189), "1,2,4", 27, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2019, 12, 13, 9, 20, 53, 528, DateTimeKind.Local).AddTicks(816), "1,3,4", 35, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2019, 11, 4, 13, 24, 44, 682, DateTimeKind.Local).AddTicks(4014), "0,2,4", 34, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2019, 6, 15, 14, 41, 33, 702, DateTimeKind.Local).AddTicks(5839), "0,3,6", 33, 2, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2020, 3, 20, 2, 1, 30, 44, DateTimeKind.Local).AddTicks(9079), "0,2,6", 32, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2020, 4, 10, 3, 3, 24, 702, DateTimeKind.Local).AddTicks(7312), "1,2,6", 31, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2019, 5, 12, 0, 20, 47, 287, DateTimeKind.Local).AddTicks(3732), "1,3,4", 30, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2020, 4, 11, 15, 37, 49, 908, DateTimeKind.Local).AddTicks(16), "0,3,6", 29, 3, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2019, 9, 9, 9, 33, 41, 579, DateTimeKind.Local).AddTicks(8652), "1,3,4", 28, 3, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2019, 11, 30, 14, 36, 10, 222, DateTimeKind.Local).AddTicks(1504), "0,2,5", 37, 3, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

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
                values: new object[] { 9, "", "", "Session 9" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 14, "", "", "Session 14" });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Discours", "Documents", "Session" },
                values: new object[] { 15, "", "", "Session 15" });

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
                values: new object[] { 9, "", "sous theme 9", "Droit thématique" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 15, "", "sous theme 15", "Droit catégoriel" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 14, "", "sous theme 14", "Droit catégoriel" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 13, "", "sous theme 13", "Droit catégoriel" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 11, "", "sous theme 11", "Droit thématique" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 10, "", "sous theme 10", "Droit catégoriel" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 8, "", "sous theme 8", "Droit thématique" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 12, "", "sous theme 12", "Droit thématique" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 6, "", "sous theme 6", "Droit thématique" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 5, "", "sous theme 5", "Droit catégoriel" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 4, "", "sous theme 4", "Droit thématique" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 7, "", "sous theme 7", "Droit catégoriel" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 3, "", "sous theme 3", "Droit catégoriel" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 2, "", "sous theme 2", "Droit catégoriel" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 1, "", "sous theme 1", "Droit catégoriel" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 66, "", "", new DateTime(2019, 5, 29, 23, 53, 48, 289, DateTimeKind.Local).AddTicks(1812), new DateTime(2020, 1, 24, 5, 4, 4, 278, DateTimeKind.Local).AddTicks(2994), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 67, "", "", new DateTime(2020, 3, 25, 4, 33, 45, 594, DateTimeKind.Local).AddTicks(8249), new DateTime(2020, 1, 10, 13, 52, 37, 468, DateTimeKind.Local).AddTicks(3645), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 68, "", "", new DateTime(2019, 8, 29, 18, 6, 22, 783, DateTimeKind.Local).AddTicks(1050), new DateTime(2019, 12, 21, 6, 1, 32, 204, DateTimeKind.Local).AddTicks(7385), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 69, "", "", new DateTime(2019, 12, 11, 6, 44, 41, 146, DateTimeKind.Local).AddTicks(8054), new DateTime(2019, 12, 11, 13, 58, 18, 871, DateTimeKind.Local).AddTicks(4785), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 72, "", "", new DateTime(2019, 12, 19, 7, 31, 13, 506, DateTimeKind.Local).AddTicks(7279), new DateTime(2020, 1, 14, 16, 53, 8, 879, DateTimeKind.Local).AddTicks(8555), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 71, "", "", new DateTime(2020, 5, 10, 10, 57, 24, 723, DateTimeKind.Local).AddTicks(1923), new DateTime(2020, 1, 2, 14, 4, 30, 134, DateTimeKind.Local).AddTicks(71), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 65, "", "", new DateTime(2019, 5, 21, 4, 15, 47, 560, DateTimeKind.Local).AddTicks(4701), new DateTime(2020, 3, 23, 16, 37, 13, 199, DateTimeKind.Local).AddTicks(6663), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 73, "", "", new DateTime(2019, 8, 1, 20, 24, 10, 44, DateTimeKind.Local).AddTicks(9050), new DateTime(2019, 11, 7, 19, 20, 21, 69, DateTimeKind.Local).AddTicks(927), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 74, "", "", new DateTime(2019, 8, 11, 0, 20, 15, 15, DateTimeKind.Local).AddTicks(8814), new DateTime(2020, 3, 20, 9, 53, 33, 569, DateTimeKind.Local).AddTicks(6931), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 70, "", "", new DateTime(2019, 8, 6, 14, 25, 30, 181, DateTimeKind.Local).AddTicks(9258), new DateTime(2019, 10, 27, 13, 42, 42, 438, DateTimeKind.Local).AddTicks(2995), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 64, "", "", new DateTime(2019, 7, 18, 10, 50, 53, 185, DateTimeKind.Local).AddTicks(247), new DateTime(2020, 5, 1, 20, 3, 35, 967, DateTimeKind.Local).AddTicks(8683), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 62, "", "", new DateTime(2019, 10, 3, 10, 19, 36, 770, DateTimeKind.Local).AddTicks(3586), new DateTime(2019, 11, 27, 10, 29, 20, 641, DateTimeKind.Local).AddTicks(1528), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 53, "", "", new DateTime(2019, 7, 28, 16, 39, 37, 586, DateTimeKind.Local).AddTicks(9465), new DateTime(2019, 11, 30, 5, 13, 21, 281, DateTimeKind.Local).AddTicks(6448), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 61, "", "", new DateTime(2019, 10, 8, 22, 14, 40, 67, DateTimeKind.Local).AddTicks(9325), new DateTime(2019, 11, 10, 17, 58, 16, 419, DateTimeKind.Local).AddTicks(2017), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 60, "", "", new DateTime(2019, 12, 5, 17, 56, 34, 999, DateTimeKind.Local).AddTicks(666), new DateTime(2019, 11, 10, 22, 30, 56, 272, DateTimeKind.Local).AddTicks(7738), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 59, "", "", new DateTime(2020, 2, 19, 3, 37, 32, 597, DateTimeKind.Local).AddTicks(2153), new DateTime(2019, 11, 30, 18, 56, 7, 780, DateTimeKind.Local).AddTicks(1291), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 58, "", "", new DateTime(2019, 6, 17, 10, 53, 38, 806, DateTimeKind.Local).AddTicks(8154), new DateTime(2019, 6, 20, 22, 12, 46, 762, DateTimeKind.Local).AddTicks(8835), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 57, "", "", new DateTime(2019, 7, 24, 13, 12, 45, 146, DateTimeKind.Local).AddTicks(5370), new DateTime(2020, 2, 20, 23, 56, 52, 34, DateTimeKind.Local).AddTicks(5396), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 56, "", "", new DateTime(2019, 10, 7, 2, 54, 2, 472, DateTimeKind.Local).AddTicks(4336), new DateTime(2020, 2, 13, 17, 43, 36, 896, DateTimeKind.Local).AddTicks(6534), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 55, "", "", new DateTime(2020, 3, 31, 14, 18, 30, 293, DateTimeKind.Local).AddTicks(3079), new DateTime(2019, 5, 20, 8, 52, 16, 829, DateTimeKind.Local).AddTicks(5618), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 54, "", "", new DateTime(2019, 6, 12, 23, 46, 21, 401, DateTimeKind.Local).AddTicks(6565), new DateTime(2019, 8, 14, 12, 23, 39, 774, DateTimeKind.Local).AddTicks(3295), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 75, "", "", new DateTime(2020, 3, 31, 16, 49, 9, 141, DateTimeKind.Local).AddTicks(1949), new DateTime(2019, 5, 17, 17, 43, 19, 507, DateTimeKind.Local).AddTicks(6751), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 63, "", "", new DateTime(2019, 11, 28, 8, 21, 56, 448, DateTimeKind.Local).AddTicks(8992), new DateTime(2020, 2, 20, 0, 46, 20, 905, DateTimeKind.Local).AddTicks(9077), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 76, "", "", new DateTime(2019, 11, 10, 13, 33, 53, 913, DateTimeKind.Local).AddTicks(6493), new DateTime(2019, 6, 7, 21, 59, 18, 792, DateTimeKind.Local).AddTicks(5121), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 91, "", "", new DateTime(2020, 3, 24, 21, 50, 6, 686, DateTimeKind.Local).AddTicks(8163), new DateTime(2020, 3, 11, 2, 21, 7, 353, DateTimeKind.Local).AddTicks(8063), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 78, "", "", new DateTime(2019, 7, 15, 0, 49, 34, 895, DateTimeKind.Local).AddTicks(4293), new DateTime(2020, 1, 22, 4, 44, 16, 950, DateTimeKind.Local).AddTicks(4171), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 52, "", "", new DateTime(2019, 8, 6, 1, 58, 47, 489, DateTimeKind.Local).AddTicks(3914), new DateTime(2019, 11, 15, 11, 25, 44, 151, DateTimeKind.Local).AddTicks(7720), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 100, "", "", new DateTime(2019, 12, 9, 7, 47, 35, 429, DateTimeKind.Local).AddTicks(7395), new DateTime(2019, 12, 31, 8, 54, 53, 77, DateTimeKind.Local).AddTicks(9286), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 99, "", "", new DateTime(2019, 10, 23, 19, 53, 29, 236, DateTimeKind.Local).AddTicks(9296), new DateTime(2020, 2, 10, 17, 51, 44, 658, DateTimeKind.Local).AddTicks(2415), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 98, "", "", new DateTime(2019, 8, 27, 14, 59, 59, 63, DateTimeKind.Local).AddTicks(6371), new DateTime(2019, 8, 3, 19, 4, 26, 355, DateTimeKind.Local).AddTicks(7243), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 97, "", "", new DateTime(2019, 5, 20, 20, 0, 42, 451, DateTimeKind.Local).AddTicks(9531), new DateTime(2019, 10, 2, 6, 4, 55, 41, DateTimeKind.Local).AddTicks(4948), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 96, "", "", new DateTime(2019, 12, 31, 19, 29, 47, 838, DateTimeKind.Local).AddTicks(8333), new DateTime(2020, 3, 8, 9, 29, 35, 301, DateTimeKind.Local).AddTicks(4216), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 95, "", "", new DateTime(2019, 5, 31, 21, 12, 56, 789, DateTimeKind.Local).AddTicks(6122), new DateTime(2019, 9, 23, 19, 10, 22, 729, DateTimeKind.Local).AddTicks(5188), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 94, "", "", new DateTime(2019, 11, 2, 13, 15, 37, 779, DateTimeKind.Local).AddTicks(120), new DateTime(2019, 8, 13, 16, 28, 49, 267, DateTimeKind.Local).AddTicks(2621), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 93, "", "", new DateTime(2020, 1, 10, 21, 15, 5, 69, DateTimeKind.Local).AddTicks(3350), new DateTime(2019, 7, 2, 20, 38, 10, 739, DateTimeKind.Local).AddTicks(7645), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 92, "", "", new DateTime(2019, 11, 16, 17, 13, 21, 964, DateTimeKind.Local).AddTicks(9282), new DateTime(2019, 7, 23, 16, 4, 11, 224, DateTimeKind.Local).AddTicks(6973), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 77, "", "", new DateTime(2020, 1, 20, 15, 28, 14, 79, DateTimeKind.Local).AddTicks(2629), new DateTime(2020, 1, 31, 19, 5, 11, 854, DateTimeKind.Local).AddTicks(2051), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 90, "", "", new DateTime(2019, 7, 30, 13, 25, 33, 750, DateTimeKind.Local).AddTicks(6178), new DateTime(2019, 10, 14, 16, 39, 13, 682, DateTimeKind.Local).AddTicks(6083), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 88, "", "", new DateTime(2019, 8, 28, 21, 7, 14, 225, DateTimeKind.Local).AddTicks(3988), new DateTime(2019, 11, 26, 14, 18, 43, 648, DateTimeKind.Local).AddTicks(8601), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 87, "", "", new DateTime(2019, 7, 10, 5, 41, 31, 427, DateTimeKind.Local).AddTicks(8228), new DateTime(2019, 6, 11, 8, 32, 14, 779, DateTimeKind.Local).AddTicks(3493), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 86, "", "", new DateTime(2020, 2, 23, 15, 29, 59, 875, DateTimeKind.Local).AddTicks(653), new DateTime(2019, 10, 9, 16, 38, 41, 188, DateTimeKind.Local).AddTicks(992), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 85, "", "", new DateTime(2019, 9, 17, 6, 41, 27, 140, DateTimeKind.Local).AddTicks(2385), new DateTime(2019, 12, 24, 19, 34, 58, 125, DateTimeKind.Local).AddTicks(1380), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 84, "", "", new DateTime(2019, 9, 7, 11, 39, 18, 895, DateTimeKind.Local).AddTicks(9710), new DateTime(2020, 3, 8, 18, 51, 5, 790, DateTimeKind.Local).AddTicks(4668), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 83, "", "", new DateTime(2019, 8, 8, 12, 26, 32, 192, DateTimeKind.Local).AddTicks(6099), new DateTime(2019, 10, 12, 12, 6, 1, 599, DateTimeKind.Local).AddTicks(9289), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 82, "", "", new DateTime(2020, 2, 8, 11, 32, 25, 947, DateTimeKind.Local).AddTicks(6492), new DateTime(2019, 7, 19, 15, 14, 56, 8, DateTimeKind.Local).AddTicks(151), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 81, "", "", new DateTime(2019, 5, 29, 23, 37, 31, 337, DateTimeKind.Local).AddTicks(3988), new DateTime(2019, 9, 2, 9, 17, 53, 813, DateTimeKind.Local).AddTicks(1520), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 80, "", "", new DateTime(2019, 10, 2, 9, 24, 30, 237, DateTimeKind.Local).AddTicks(3081), new DateTime(2020, 3, 3, 18, 56, 23, 169, DateTimeKind.Local).AddTicks(7375), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 79, "", "", new DateTime(2019, 7, 16, 6, 13, 27, 370, DateTimeKind.Local).AddTicks(3252), new DateTime(2019, 6, 20, 19, 29, 44, 831, DateTimeKind.Local).AddTicks(158), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 89, "", "", new DateTime(2019, 6, 19, 17, 59, 0, 415, DateTimeKind.Local).AddTicks(9659), new DateTime(2020, 3, 7, 1, 29, 17, 373, DateTimeKind.Local).AddTicks(9644), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 51, "", "", new DateTime(2020, 1, 17, 9, 30, 30, 132, DateTimeKind.Local).AddTicks(1747), new DateTime(2020, 1, 5, 9, 34, 7, 5, DateTimeKind.Local).AddTicks(3509), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 15, "", "", new DateTime(2019, 7, 13, 10, 22, 18, 56, DateTimeKind.Local).AddTicks(5930), new DateTime(2019, 10, 2, 16, 29, 27, 450, DateTimeKind.Local).AddTicks(8152), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 49, "", "", new DateTime(2019, 6, 7, 1, 25, 12, 394, DateTimeKind.Local).AddTicks(6963), new DateTime(2019, 11, 21, 10, 49, 25, 216, DateTimeKind.Local).AddTicks(3238), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 22, "", "", new DateTime(2019, 5, 24, 17, 52, 46, 11, DateTimeKind.Local).AddTicks(2601), new DateTime(2020, 2, 8, 15, 44, 36, 574, DateTimeKind.Local).AddTicks(7922), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 21, "", "", new DateTime(2019, 12, 24, 11, 45, 17, 661, DateTimeKind.Local).AddTicks(8771), new DateTime(2019, 8, 27, 16, 30, 46, 963, DateTimeKind.Local).AddTicks(2629), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 20, "", "", new DateTime(2020, 1, 17, 11, 18, 2, 991, DateTimeKind.Local).AddTicks(4390), new DateTime(2019, 10, 18, 18, 57, 25, 549, DateTimeKind.Local).AddTicks(534), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 19, "", "", new DateTime(2019, 5, 29, 10, 22, 24, 221, DateTimeKind.Local).AddTicks(900), new DateTime(2020, 1, 11, 9, 12, 40, 71, DateTimeKind.Local).AddTicks(2233), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 18, "", "", new DateTime(2019, 11, 19, 8, 15, 14, 225, DateTimeKind.Local).AddTicks(2922), new DateTime(2019, 10, 27, 4, 3, 37, 26, DateTimeKind.Local).AddTicks(5065), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 17, "", "", new DateTime(2020, 3, 4, 16, 12, 53, 603, DateTimeKind.Local).AddTicks(642), new DateTime(2019, 10, 3, 15, 5, 29, 8, DateTimeKind.Local).AddTicks(3449), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 16, "", "", new DateTime(2020, 3, 9, 12, 59, 34, 281, DateTimeKind.Local).AddTicks(5806), new DateTime(2019, 12, 7, 21, 41, 36, 146, DateTimeKind.Local).AddTicks(3457), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 14, "", "", new DateTime(2020, 1, 2, 0, 47, 46, 699, DateTimeKind.Local).AddTicks(3511), new DateTime(2020, 1, 8, 19, 13, 54, 929, DateTimeKind.Local).AddTicks(1388), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 13, "", "", new DateTime(2019, 9, 30, 3, 4, 22, 343, DateTimeKind.Local).AddTicks(8935), new DateTime(2019, 12, 31, 19, 36, 31, 356, DateTimeKind.Local).AddTicks(6203), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 12, "", "", new DateTime(2020, 3, 16, 22, 37, 8, 769, DateTimeKind.Local).AddTicks(9763), new DateTime(2020, 1, 26, 13, 43, 32, 623, DateTimeKind.Local).AddTicks(1206), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 11, "", "", new DateTime(2020, 3, 20, 18, 30, 52, 321, DateTimeKind.Local).AddTicks(5278), new DateTime(2020, 1, 28, 4, 1, 38, 101, DateTimeKind.Local).AddTicks(2335), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 10, "", "", new DateTime(2019, 10, 15, 8, 48, 7, 640, DateTimeKind.Local).AddTicks(7094), new DateTime(2020, 2, 7, 8, 57, 26, 500, DateTimeKind.Local).AddTicks(4031), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 9, "", "", new DateTime(2020, 3, 27, 4, 27, 48, 736, DateTimeKind.Local).AddTicks(3193), new DateTime(2019, 8, 13, 1, 23, 41, 655, DateTimeKind.Local).AddTicks(3380), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 8, "", "", new DateTime(2020, 3, 25, 9, 46, 22, 878, DateTimeKind.Local).AddTicks(7154), new DateTime(2019, 5, 31, 13, 16, 31, 630, DateTimeKind.Local).AddTicks(864), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 7, "", "", new DateTime(2019, 10, 20, 2, 11, 34, 584, DateTimeKind.Local).AddTicks(7481), new DateTime(2019, 8, 14, 11, 13, 58, 576, DateTimeKind.Local).AddTicks(2989), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 6, "", "", new DateTime(2019, 10, 1, 18, 37, 5, 823, DateTimeKind.Local).AddTicks(5254), new DateTime(2019, 7, 7, 11, 23, 48, 296, DateTimeKind.Local).AddTicks(5321), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 5, "", "", new DateTime(2020, 4, 15, 7, 15, 30, 324, DateTimeKind.Local).AddTicks(1789), new DateTime(2019, 9, 7, 11, 27, 38, 750, DateTimeKind.Local).AddTicks(4782), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 4, "", "", new DateTime(2019, 12, 18, 18, 54, 1, 350, DateTimeKind.Local).AddTicks(4169), new DateTime(2019, 6, 22, 20, 13, 58, 889, DateTimeKind.Local).AddTicks(5964), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 3, "", "", new DateTime(2020, 1, 31, 9, 57, 27, 58, DateTimeKind.Local).AddTicks(720), new DateTime(2019, 7, 6, 19, 21, 22, 718, DateTimeKind.Local).AddTicks(5782), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 2, "", "", new DateTime(2019, 9, 3, 8, 3, 46, 739, DateTimeKind.Local).AddTicks(4583), new DateTime(2020, 4, 5, 19, 41, 30, 115, DateTimeKind.Local).AddTicks(5934), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 50, "", "", new DateTime(2020, 3, 4, 3, 52, 49, 805, DateTimeKind.Local).AddTicks(1604), new DateTime(2020, 2, 9, 18, 10, 11, 982, DateTimeKind.Local).AddTicks(8895), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 23, "", "", new DateTime(2020, 4, 29, 11, 47, 45, 774, DateTimeKind.Local).AddTicks(7414), new DateTime(2019, 6, 9, 23, 59, 49, 100, DateTimeKind.Local).AddTicks(1094), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 24, "", "", new DateTime(2020, 2, 21, 12, 39, 33, 684, DateTimeKind.Local).AddTicks(3429), new DateTime(2019, 5, 13, 6, 54, 11, 25, DateTimeKind.Local).AddTicks(5422), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 1, "", "", new DateTime(2019, 11, 25, 3, 37, 35, 402, DateTimeKind.Local).AddTicks(7101), new DateTime(2019, 11, 6, 8, 27, 58, 462, DateTimeKind.Local).AddTicks(5947), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 26, "", "", new DateTime(2020, 4, 27, 15, 56, 9, 224, DateTimeKind.Local).AddTicks(4808), new DateTime(2020, 1, 22, 14, 45, 32, 368, DateTimeKind.Local).AddTicks(403), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 25, "", "", new DateTime(2020, 3, 8, 23, 51, 2, 10, DateTimeKind.Local).AddTicks(5189), new DateTime(2020, 2, 27, 16, 45, 15, 431, DateTimeKind.Local).AddTicks(3112), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 47, "", "", new DateTime(2020, 4, 25, 1, 2, 7, 55, DateTimeKind.Local).AddTicks(2294), new DateTime(2019, 9, 14, 3, 6, 54, 479, DateTimeKind.Local).AddTicks(2768), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 46, "", "", new DateTime(2019, 7, 18, 21, 21, 46, 8, DateTimeKind.Local).AddTicks(7255), new DateTime(2020, 3, 17, 9, 0, 50, 936, DateTimeKind.Local).AddTicks(9779), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 45, "", "", new DateTime(2019, 5, 16, 11, 23, 40, 849, DateTimeKind.Local).AddTicks(2138), new DateTime(2019, 7, 30, 0, 6, 18, 924, DateTimeKind.Local).AddTicks(9205), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 44, "", "", new DateTime(2019, 8, 4, 4, 38, 23, 227, DateTimeKind.Local).AddTicks(2465), new DateTime(2019, 8, 9, 5, 11, 31, 39, DateTimeKind.Local).AddTicks(776), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 43, "", "", new DateTime(2019, 9, 3, 6, 29, 38, 678, DateTimeKind.Local).AddTicks(3039), new DateTime(2019, 6, 21, 6, 26, 34, 622, DateTimeKind.Local).AddTicks(4132), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 42, "", "", new DateTime(2019, 12, 7, 8, 34, 41, 121, DateTimeKind.Local).AddTicks(4158), new DateTime(2019, 11, 2, 18, 47, 13, 360, DateTimeKind.Local).AddTicks(1890), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 40, "", "", new DateTime(2019, 6, 4, 7, 53, 26, 272, DateTimeKind.Local).AddTicks(654), new DateTime(2019, 6, 24, 17, 56, 55, 717, DateTimeKind.Local).AddTicks(3632), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 39, "", "", new DateTime(2020, 4, 29, 5, 57, 10, 497, DateTimeKind.Local).AddTicks(2218), new DateTime(2020, 1, 2, 11, 0, 46, 959, DateTimeKind.Local).AddTicks(8406), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 38, "", "", new DateTime(2020, 2, 18, 13, 45, 50, 199, DateTimeKind.Local).AddTicks(8280), new DateTime(2020, 3, 2, 14, 14, 35, 293, DateTimeKind.Local).AddTicks(1483), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 37, "", "", new DateTime(2019, 8, 12, 22, 9, 12, 510, DateTimeKind.Local).AddTicks(7728), new DateTime(2019, 6, 12, 9, 47, 42, 542, DateTimeKind.Local).AddTicks(5739), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 41, "", "", new DateTime(2019, 7, 4, 7, 35, 47, 259, DateTimeKind.Local).AddTicks(5871), new DateTime(2020, 3, 20, 21, 46, 15, 743, DateTimeKind.Local).AddTicks(8850), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 35, "", "", new DateTime(2019, 6, 26, 22, 26, 34, 857, DateTimeKind.Local).AddTicks(326), new DateTime(2019, 5, 23, 18, 54, 47, 464, DateTimeKind.Local).AddTicks(6779), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 27, "", "", new DateTime(2020, 3, 27, 12, 24, 55, 244, DateTimeKind.Local).AddTicks(2595), new DateTime(2019, 5, 29, 6, 49, 42, 0, DateTimeKind.Local).AddTicks(6609), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 36, "", "", new DateTime(2019, 12, 7, 3, 31, 50, 906, DateTimeKind.Local).AddTicks(6016), new DateTime(2020, 1, 21, 23, 45, 39, 760, DateTimeKind.Local).AddTicks(7341), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 29, "", "", new DateTime(2020, 4, 10, 15, 17, 17, 839, DateTimeKind.Local).AddTicks(8736), new DateTime(2019, 9, 11, 1, 37, 5, 642, DateTimeKind.Local).AddTicks(1664), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 30, "", "", new DateTime(2019, 6, 20, 5, 22, 57, 576, DateTimeKind.Local).AddTicks(8368), new DateTime(2020, 2, 28, 3, 36, 12, 94, DateTimeKind.Local).AddTicks(8214), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 31, "", "", new DateTime(2019, 8, 30, 9, 13, 47, 870, DateTimeKind.Local).AddTicks(1395), new DateTime(2020, 1, 23, 7, 7, 46, 898, DateTimeKind.Local).AddTicks(3943), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 28, "", "", new DateTime(2020, 5, 2, 16, 5, 58, 248, DateTimeKind.Local).AddTicks(95), new DateTime(2019, 12, 22, 7, 56, 41, 583, DateTimeKind.Local).AddTicks(5718), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 33, "", "", new DateTime(2020, 1, 29, 2, 6, 5, 731, DateTimeKind.Local).AddTicks(3967), new DateTime(2019, 6, 30, 7, 50, 59, 591, DateTimeKind.Local).AddTicks(2811), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 34, "", "", new DateTime(2020, 1, 8, 3, 40, 3, 865, DateTimeKind.Local).AddTicks(3361), new DateTime(2020, 3, 21, 16, 33, 16, 52, DateTimeKind.Local).AddTicks(7917), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 48, "", "", new DateTime(2019, 12, 14, 4, 1, 7, 25, DateTimeKind.Local).AddTicks(5096), new DateTime(2020, 3, 18, 22, 35, 12, 612, DateTimeKind.Local).AddTicks(726), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 32, "", "", new DateTime(2020, 1, 28, 8, 45, 54, 934, DateTimeKind.Local).AddTicks(954), new DateTime(2019, 5, 20, 4, 23, 56, 583, DateTimeKind.Local).AddTicks(4179), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 65, new DateTime(2020, 4, 13, 20, 0, 14, 1, DateTimeKind.Local).AddTicks(1977), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 72, new DateTime(2019, 9, 6, 13, 7, 44, 493, DateTimeKind.Local).AddTicks(3543), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 71, new DateTime(2019, 9, 17, 8, 21, 12, 331, DateTimeKind.Local).AddTicks(2350), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 70, new DateTime(2019, 6, 7, 19, 6, 58, 248, DateTimeKind.Local).AddTicks(5510), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 69, new DateTime(2019, 10, 11, 5, 29, 35, 663, DateTimeKind.Local).AddTicks(6010), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 68, new DateTime(2020, 4, 7, 17, 49, 54, 395, DateTimeKind.Local).AddTicks(907), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 67, new DateTime(2019, 11, 9, 3, 5, 27, 801, DateTimeKind.Local).AddTicks(3074), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 66, new DateTime(2020, 3, 24, 13, 5, 53, 380, DateTimeKind.Local).AddTicks(5309), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 64, new DateTime(2020, 2, 8, 9, 4, 16, 84, DateTimeKind.Local).AddTicks(198), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 53, new DateTime(2019, 11, 13, 9, 46, 5, 681, DateTimeKind.Local).AddTicks(6187), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 62, new DateTime(2020, 3, 9, 11, 52, 23, 378, DateTimeKind.Local).AddTicks(7344), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 61, new DateTime(2020, 2, 4, 8, 56, 15, 16, DateTimeKind.Local).AddTicks(9004), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 60, new DateTime(2020, 1, 29, 3, 26, 19, 287, DateTimeKind.Local).AddTicks(2079), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 59, new DateTime(2019, 10, 13, 5, 30, 25, 91, DateTimeKind.Local).AddTicks(8447), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 58, new DateTime(2019, 9, 29, 11, 0, 31, 87, DateTimeKind.Local).AddTicks(5822), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 57, new DateTime(2019, 8, 1, 18, 25, 14, 600, DateTimeKind.Local).AddTicks(9976), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 56, new DateTime(2019, 9, 11, 15, 57, 16, 627, DateTimeKind.Local).AddTicks(4609), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 55, new DateTime(2019, 11, 17, 9, 26, 4, 424, DateTimeKind.Local).AddTicks(2460), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 54, new DateTime(2019, 5, 13, 18, 0, 58, 276, DateTimeKind.Local).AddTicks(816), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 73, new DateTime(2019, 11, 14, 6, 57, 25, 940, DateTimeKind.Local).AddTicks(9571), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 52, new DateTime(2019, 10, 8, 22, 51, 16, 682, DateTimeKind.Local).AddTicks(5943), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 63, new DateTime(2020, 3, 25, 10, 6, 23, 222, DateTimeKind.Local).AddTicks(1222), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 74, new DateTime(2019, 11, 25, 11, 3, 36, 236, DateTimeKind.Local).AddTicks(266), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 85, new DateTime(2019, 6, 22, 2, 19, 20, 782, DateTimeKind.Local).AddTicks(5037), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 76, new DateTime(2019, 6, 23, 23, 48, 10, 565, DateTimeKind.Local).AddTicks(976), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 98, new DateTime(2020, 2, 23, 18, 21, 7, 264, DateTimeKind.Local).AddTicks(9587), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 51, new DateTime(2020, 1, 11, 18, 25, 9, 987, DateTimeKind.Local).AddTicks(936), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 97, new DateTime(2019, 6, 4, 16, 16, 52, 167, DateTimeKind.Local).AddTicks(9134), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 96, new DateTime(2020, 2, 11, 22, 15, 11, 132, DateTimeKind.Local).AddTicks(3003), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 95, new DateTime(2020, 5, 10, 20, 2, 1, 234, DateTimeKind.Local).AddTicks(3333), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 94, new DateTime(2019, 8, 22, 16, 29, 57, 101, DateTimeKind.Local).AddTicks(2099), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 93, new DateTime(2020, 5, 4, 2, 45, 20, 934, DateTimeKind.Local).AddTicks(8657), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 92, new DateTime(2020, 4, 24, 12, 18, 50, 529, DateTimeKind.Local).AddTicks(2106), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 91, new DateTime(2019, 8, 1, 21, 31, 45, 599, DateTimeKind.Local).AddTicks(6133), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 90, new DateTime(2020, 5, 6, 15, 21, 21, 506, DateTimeKind.Local).AddTicks(3864), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 75, new DateTime(2020, 4, 21, 4, 3, 51, 516, DateTimeKind.Local).AddTicks(4536), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 89, new DateTime(2019, 12, 23, 3, 33, 54, 599, DateTimeKind.Local).AddTicks(7256), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 87, new DateTime(2020, 2, 13, 20, 1, 26, 972, DateTimeKind.Local).AddTicks(7097), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 86, new DateTime(2020, 2, 12, 23, 37, 53, 13, DateTimeKind.Local).AddTicks(1203), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 84, new DateTime(2019, 6, 10, 11, 12, 2, 428, DateTimeKind.Local).AddTicks(3469), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 83, new DateTime(2020, 1, 2, 9, 42, 25, 450, DateTimeKind.Local).AddTicks(7890), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 82, new DateTime(2019, 10, 24, 3, 35, 36, 256, DateTimeKind.Local).AddTicks(1352), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 81, new DateTime(2019, 10, 5, 3, 51, 0, 852, DateTimeKind.Local).AddTicks(2457), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 80, new DateTime(2019, 12, 7, 22, 5, 51, 664, DateTimeKind.Local).AddTicks(9445), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 79, new DateTime(2020, 5, 11, 8, 6, 42, 682, DateTimeKind.Local).AddTicks(97), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 78, new DateTime(2019, 7, 14, 11, 9, 3, 97, DateTimeKind.Local).AddTicks(5866), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 77, new DateTime(2020, 1, 16, 15, 57, 1, 392, DateTimeKind.Local).AddTicks(2877), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 88, new DateTime(2019, 8, 9, 19, 14, 59, 170, DateTimeKind.Local).AddTicks(6514), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 50, new DateTime(2020, 3, 29, 22, 33, 4, 683, DateTimeKind.Local).AddTicks(22), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 26, new DateTime(2020, 1, 3, 13, 11, 51, 608, DateTimeKind.Local).AddTicks(4659), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 48, new DateTime(2020, 3, 12, 2, 22, 29, 210, DateTimeKind.Local).AddTicks(1569), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 20, new DateTime(2019, 8, 27, 8, 17, 8, 418, DateTimeKind.Local).AddTicks(3046), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 19, new DateTime(2019, 6, 6, 7, 1, 42, 736, DateTimeKind.Local).AddTicks(694), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 18, new DateTime(2019, 11, 27, 22, 33, 33, 220, DateTimeKind.Local).AddTicks(5213), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 17, new DateTime(2020, 5, 10, 19, 43, 15, 350, DateTimeKind.Local).AddTicks(4093), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 16, new DateTime(2019, 12, 13, 7, 41, 28, 384, DateTimeKind.Local).AddTicks(7640), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 15, new DateTime(2019, 12, 24, 8, 34, 37, 136, DateTimeKind.Local).AddTicks(1264), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 14, new DateTime(2019, 12, 10, 4, 16, 53, 896, DateTimeKind.Local).AddTicks(2334), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 13, new DateTime(2019, 5, 21, 1, 46, 57, 231, DateTimeKind.Local).AddTicks(6486), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 12, new DateTime(2019, 7, 30, 10, 1, 14, 128, DateTimeKind.Local).AddTicks(2134), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 11, new DateTime(2020, 4, 12, 11, 4, 30, 697, DateTimeKind.Local).AddTicks(1604), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 10, new DateTime(2019, 12, 15, 14, 4, 48, 296, DateTimeKind.Local).AddTicks(1432), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 9, new DateTime(2020, 3, 19, 23, 53, 12, 820, DateTimeKind.Local).AddTicks(2149), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 8, new DateTime(2019, 8, 1, 19, 59, 11, 721, DateTimeKind.Local).AddTicks(3515), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 7, new DateTime(2019, 6, 3, 19, 37, 4, 849, DateTimeKind.Local).AddTicks(3270), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 6, new DateTime(2020, 4, 23, 5, 54, 20, 250, DateTimeKind.Local).AddTicks(3920), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 5, new DateTime(2019, 5, 22, 20, 39, 53, 280, DateTimeKind.Local).AddTicks(625), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 4, new DateTime(2019, 6, 20, 11, 44, 15, 810, DateTimeKind.Local).AddTicks(9496), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 3, new DateTime(2019, 10, 30, 3, 44, 38, 855, DateTimeKind.Local).AddTicks(6154), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 2, new DateTime(2019, 12, 5, 23, 16, 10, 785, DateTimeKind.Local).AddTicks(501), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 1, new DateTime(2019, 11, 16, 19, 13, 7, 119, DateTimeKind.Local).AddTicks(1533), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 99, new DateTime(2020, 1, 27, 4, 27, 4, 517, DateTimeKind.Local).AddTicks(3007), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 21, new DateTime(2019, 5, 29, 13, 15, 14, 320, DateTimeKind.Local).AddTicks(3347), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 22, new DateTime(2019, 10, 23, 13, 48, 19, 871, DateTimeKind.Local).AddTicks(7882), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 23, new DateTime(2019, 7, 17, 16, 31, 19, 13, DateTimeKind.Local).AddTicks(7626), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 24, new DateTime(2020, 4, 13, 6, 15, 15, 740, DateTimeKind.Local).AddTicks(4496), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 47, new DateTime(2020, 2, 12, 13, 16, 41, 162, DateTimeKind.Local).AddTicks(3466), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 46, new DateTime(2019, 7, 23, 7, 2, 45, 466, DateTimeKind.Local).AddTicks(7670), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 45, new DateTime(2019, 8, 17, 20, 28, 8, 875, DateTimeKind.Local).AddTicks(1280), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 44, new DateTime(2019, 11, 25, 9, 34, 8, 456, DateTimeKind.Local).AddTicks(5282), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 43, new DateTime(2019, 9, 10, 13, 3, 2, 479, DateTimeKind.Local).AddTicks(2334), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 42, new DateTime(2019, 6, 12, 0, 30, 36, 145, DateTimeKind.Local).AddTicks(6924), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 41, new DateTime(2019, 12, 10, 4, 16, 37, 300, DateTimeKind.Local).AddTicks(8274), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 40, new DateTime(2019, 6, 10, 5, 11, 59, 872, DateTimeKind.Local).AddTicks(1841), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 39, new DateTime(2019, 9, 22, 5, 45, 56, 598, DateTimeKind.Local).AddTicks(7746), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 38, new DateTime(2019, 12, 31, 9, 47, 44, 582, DateTimeKind.Local).AddTicks(6911), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 49, new DateTime(2019, 9, 4, 23, 2, 56, 656, DateTimeKind.Local).AddTicks(7460), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 37, new DateTime(2019, 8, 2, 9, 22, 42, 75, DateTimeKind.Local).AddTicks(4897), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 35, new DateTime(2019, 9, 13, 23, 9, 7, 441, DateTimeKind.Local).AddTicks(5595), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 34, new DateTime(2020, 2, 20, 17, 11, 5, 436, DateTimeKind.Local).AddTicks(4824), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 33, new DateTime(2020, 4, 25, 7, 53, 59, 535, DateTimeKind.Local).AddTicks(93), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 32, new DateTime(2019, 10, 10, 21, 57, 6, 577, DateTimeKind.Local).AddTicks(2410), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 31, new DateTime(2019, 5, 12, 11, 23, 58, 448, DateTimeKind.Local).AddTicks(7311), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 30, new DateTime(2019, 12, 16, 10, 19, 56, 985, DateTimeKind.Local).AddTicks(5965), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 29, new DateTime(2020, 4, 25, 17, 51, 40, 139, DateTimeKind.Local).AddTicks(7857), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 28, new DateTime(2020, 1, 22, 12, 52, 46, 294, DateTimeKind.Local).AddTicks(4229), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 27, new DateTime(2019, 6, 29, 23, 54, 10, 894, DateTimeKind.Local).AddTicks(5175), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 25, new DateTime(2019, 11, 16, 3, 17, 1, 1, DateTimeKind.Local).AddTicks(7942), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 36, new DateTime(2019, 11, 21, 15, 59, 50, 98, DateTimeKind.Local).AddTicks(4577), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 100, new DateTime(2019, 6, 21, 10, 1, 47, 167, DateTimeKind.Local).AddTicks(2635), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 5, 12, 9, 21, 48, 50, DateTimeKind.Local).AddTicks(8604), new DateTime(2020, 5, 12, 1, 36, 41, 951, DateTimeKind.Local).AddTicks(3580), new DateTime(2020, 5, 12, 11, 16, 58, 222, DateTimeKind.Local).AddTicks(4376), 31, "", "http://lou.eu", "aliquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 5, 12, 6, 35, 23, 656, DateTimeKind.Local).AddTicks(5082), new DateTime(2020, 5, 12, 3, 7, 57, 596, DateTimeKind.Local).AddTicks(9959), new DateTime(2020, 5, 12, 4, 23, 14, 263, DateTimeKind.Local).AddTicks(3075), 71, "", "https://mattéo.info", "accusantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 5, 11, 20, 2, 26, 146, DateTimeKind.Local).AddTicks(1557), new DateTime(2020, 5, 12, 14, 4, 43, 782, DateTimeKind.Local).AddTicks(4956), new DateTime(2020, 5, 12, 9, 59, 3, 93, DateTimeKind.Local).AddTicks(2226), 71, "", "https://mael.info", "natus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 5, 12, 7, 4, 16, 790, DateTimeKind.Local).AddTicks(5255), new DateTime(2020, 5, 12, 10, 12, 32, 600, DateTimeKind.Local).AddTicks(1944), new DateTime(2020, 5, 12, 4, 47, 20, 429, DateTimeKind.Local).AddTicks(6987), 71, "", "https://clément.fr", "dolorum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 5, 12, 5, 45, 55, 249, DateTimeKind.Local).AddTicks(5760), new DateTime(2020, 5, 11, 22, 33, 13, 703, DateTimeKind.Local).AddTicks(757), new DateTime(2020, 5, 12, 7, 22, 19, 659, DateTimeKind.Local).AddTicks(1236), 70, "", "http://yanis.name", "eligendi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 5, 12, 3, 6, 32, 517, DateTimeKind.Local).AddTicks(6599), new DateTime(2020, 5, 12, 3, 23, 51, 763, DateTimeKind.Local).AddTicks(4430), new DateTime(2020, 5, 12, 13, 35, 15, 189, DateTimeKind.Local).AddTicks(5940), 69, "", "https://noah.name", "molestias" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 5, 11, 20, 32, 34, 434, DateTimeKind.Local).AddTicks(8187), new DateTime(2020, 5, 11, 16, 41, 25, 720, DateTimeKind.Local).AddTicks(8208), new DateTime(2020, 5, 12, 5, 47, 2, 434, DateTimeKind.Local).AddTicks(3934), 66, "", "https://louise.fr", "itaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 5, 12, 14, 15, 43, 63, DateTimeKind.Local).AddTicks(4555), new DateTime(2020, 5, 12, 13, 59, 29, 592, DateTimeKind.Local).AddTicks(519), new DateTime(2020, 5, 12, 14, 7, 25, 81, DateTimeKind.Local).AddTicks(6889), 66, "", "https://hugo.net", "iste" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 5, 11, 21, 36, 59, 643, DateTimeKind.Local).AddTicks(854), new DateTime(2020, 5, 11, 21, 53, 24, 94, DateTimeKind.Local).AddTicks(6375), new DateTime(2020, 5, 12, 12, 51, 57, 404, DateTimeKind.Local).AddTicks(457), 64, "", "https://mattéo.info", "natus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 5, 11, 17, 44, 1, 539, DateTimeKind.Local).AddTicks(9773), new DateTime(2020, 5, 12, 1, 4, 0, 622, DateTimeKind.Local).AddTicks(1484), new DateTime(2020, 5, 12, 3, 9, 13, 789, DateTimeKind.Local).AddTicks(1664), 63, "", "http://ethan.net", "blanditiis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 5, 11, 17, 15, 34, 953, DateTimeKind.Local).AddTicks(9073), new DateTime(2020, 5, 12, 1, 52, 16, 738, DateTimeKind.Local).AddTicks(1720), new DateTime(2020, 5, 12, 8, 49, 29, 152, DateTimeKind.Local).AddTicks(3976), 62, "", "http://noa.eu", "dolore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 5, 12, 12, 54, 28, 992, DateTimeKind.Local).AddTicks(9713), new DateTime(2020, 5, 11, 17, 35, 45, 299, DateTimeKind.Local).AddTicks(3503), new DateTime(2020, 5, 11, 23, 34, 24, 701, DateTimeKind.Local).AddTicks(9309), 62, "", "https://emilie.com", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 5, 12, 13, 10, 59, 963, DateTimeKind.Local).AddTicks(4409), new DateTime(2020, 5, 11, 17, 19, 41, 506, DateTimeKind.Local).AddTicks(1310), new DateTime(2020, 5, 12, 1, 58, 11, 986, DateTimeKind.Local).AddTicks(8487), 75, "", "https://mattéo.com", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 5, 11, 17, 3, 53, 229, DateTimeKind.Local).AddTicks(1266), new DateTime(2020, 5, 12, 9, 7, 41, 252, DateTimeKind.Local).AddTicks(5675), new DateTime(2020, 5, 12, 5, 24, 40, 359, DateTimeKind.Local).AddTicks(981), 62, "", "http://romain.com", "unde" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 5, 12, 11, 0, 48, 133, DateTimeKind.Local).AddTicks(6585), new DateTime(2020, 5, 12, 10, 11, 44, 509, DateTimeKind.Local).AddTicks(5932), new DateTime(2020, 5, 12, 0, 4, 7, 710, DateTimeKind.Local).AddTicks(4994), 55, "", "https://antoine.net", "dolorum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 5, 11, 22, 31, 54, 504, DateTimeKind.Local).AddTicks(9653), new DateTime(2020, 5, 11, 16, 57, 13, 825, DateTimeKind.Local).AddTicks(8254), new DateTime(2020, 5, 11, 17, 16, 9, 738, DateTimeKind.Local).AddTicks(5957), 50, "", "https://hugo.net", "quis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 5, 12, 12, 55, 54, 261, DateTimeKind.Local).AddTicks(7849), new DateTime(2020, 5, 11, 21, 28, 47, 651, DateTimeKind.Local).AddTicks(8347), new DateTime(2020, 5, 12, 13, 40, 27, 480, DateTimeKind.Local).AddTicks(4012), 49, "", "https://maxime.info", "dolor" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 5, 12, 13, 13, 6, 443, DateTimeKind.Local).AddTicks(2433), new DateTime(2020, 5, 12, 1, 22, 38, 489, DateTimeKind.Local).AddTicks(7298), new DateTime(2020, 5, 12, 5, 43, 40, 301, DateTimeKind.Local).AddTicks(6294), 49, "", "http://mattéo.org", "libero" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 5, 12, 12, 44, 55, 987, DateTimeKind.Local).AddTicks(7626), new DateTime(2020, 5, 11, 15, 36, 25, 912, DateTimeKind.Local).AddTicks(3621), new DateTime(2020, 5, 11, 23, 36, 16, 323, DateTimeKind.Local).AddTicks(9891), 48, "", "http://mathilde.name", "explicabo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 5, 12, 1, 4, 10, 759, DateTimeKind.Local).AddTicks(147), new DateTime(2020, 5, 11, 20, 56, 18, 373, DateTimeKind.Local).AddTicks(1320), new DateTime(2020, 5, 12, 13, 36, 5, 678, DateTimeKind.Local).AddTicks(20), 47, "", "http://maxime.info", "sunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 5, 12, 6, 11, 11, 346, DateTimeKind.Local).AddTicks(2900), new DateTime(2020, 5, 12, 14, 46, 12, 642, DateTimeKind.Local).AddTicks(4156), new DateTime(2020, 5, 11, 15, 30, 4, 474, DateTimeKind.Local).AddTicks(6784), 47, "", "http://chloé.com", "harum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 5, 12, 4, 56, 58, 283, DateTimeKind.Local).AddTicks(2637), new DateTime(2020, 5, 12, 11, 4, 31, 475, DateTimeKind.Local).AddTicks(6674), new DateTime(2020, 5, 11, 16, 11, 15, 908, DateTimeKind.Local).AddTicks(4999), 46, "", "http://mathéo.com", "unde" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 5, 12, 9, 11, 56, 951, DateTimeKind.Local).AddTicks(1085), new DateTime(2020, 5, 11, 19, 28, 45, 933, DateTimeKind.Local).AddTicks(7322), new DateTime(2020, 5, 11, 23, 17, 41, 313, DateTimeKind.Local).AddTicks(1109), 39, "", "https://lucie.info", "nostrum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 5, 11, 17, 12, 35, 423, DateTimeKind.Local).AddTicks(5236), new DateTime(2020, 5, 12, 10, 48, 46, 240, DateTimeKind.Local).AddTicks(7212), new DateTime(2020, 5, 12, 10, 45, 51, 864, DateTimeKind.Local).AddTicks(3196), 38, "", "https://maëlys.info", "nulla" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 5, 12, 7, 26, 15, 548, DateTimeKind.Local).AddTicks(3984), new DateTime(2020, 5, 12, 4, 1, 22, 491, DateTimeKind.Local).AddTicks(6363), new DateTime(2020, 5, 12, 5, 16, 33, 834, DateTimeKind.Local).AddTicks(2993), 38, "", "http://enzo.net", "magnam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 5, 12, 2, 48, 50, 493, DateTimeKind.Local).AddTicks(7662), new DateTime(2020, 5, 12, 15, 3, 29, 220, DateTimeKind.Local).AddTicks(2227), new DateTime(2020, 5, 12, 9, 44, 50, 742, DateTimeKind.Local).AddTicks(3816), 56, "", "http://célia.fr", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 5, 12, 1, 30, 23, 373, DateTimeKind.Local).AddTicks(5221), new DateTime(2020, 5, 12, 12, 48, 34, 739, DateTimeKind.Local).AddTicks(9555), new DateTime(2020, 5, 12, 6, 2, 53, 625, DateTimeKind.Local).AddTicks(1411), 76, "", "http://pierre.fr", "explicabo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 5, 11, 15, 26, 36, 39, DateTimeKind.Local).AddTicks(4333), new DateTime(2020, 5, 12, 11, 41, 28, 330, DateTimeKind.Local).AddTicks(6390), new DateTime(2020, 5, 11, 21, 31, 27, 428, DateTimeKind.Local).AddTicks(7727), 76, "", "http://mael.net", "doloremque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 5, 12, 8, 4, 11, 696, DateTimeKind.Local).AddTicks(512), new DateTime(2020, 5, 11, 20, 27, 54, 290, DateTimeKind.Local).AddTicks(1318), new DateTime(2020, 5, 12, 12, 49, 31, 685, DateTimeKind.Local).AddTicks(5238), 77, "", "https://jeanne.com", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 5, 12, 8, 35, 44, 653, DateTimeKind.Local).AddTicks(3542), new DateTime(2020, 5, 12, 15, 20, 18, 188, DateTimeKind.Local).AddTicks(6141), new DateTime(2020, 5, 12, 3, 19, 41, 447, DateTimeKind.Local).AddTicks(7764), 100, "", "https://maëlys.net", "ad" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 5, 12, 7, 12, 11, 118, DateTimeKind.Local).AddTicks(8981), new DateTime(2020, 5, 12, 1, 34, 20, 730, DateTimeKind.Local).AddTicks(9499), new DateTime(2020, 5, 12, 12, 29, 22, 141, DateTimeKind.Local).AddTicks(6146), 98, "", "https://noah.org", "modi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 5, 11, 17, 25, 0, 240, DateTimeKind.Local).AddTicks(26), new DateTime(2020, 5, 12, 3, 32, 59, 403, DateTimeKind.Local).AddTicks(7734), new DateTime(2020, 5, 11, 21, 57, 36, 156, DateTimeKind.Local).AddTicks(3668), 98, "", "https://enzo.fr", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 5, 12, 2, 41, 24, 518, DateTimeKind.Local).AddTicks(3873), new DateTime(2020, 5, 11, 19, 54, 4, 717, DateTimeKind.Local).AddTicks(9286), new DateTime(2020, 5, 11, 17, 48, 38, 315, DateTimeKind.Local).AddTicks(2977), 97, "", "https://baptiste.name", "neque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 5, 12, 10, 35, 6, 129, DateTimeKind.Local).AddTicks(71), new DateTime(2020, 5, 12, 8, 1, 26, 486, DateTimeKind.Local).AddTicks(328), new DateTime(2020, 5, 11, 19, 19, 10, 238, DateTimeKind.Local).AddTicks(4136), 97, "", "https://kylian.name", "animi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 5, 11, 15, 24, 13, 228, DateTimeKind.Local).AddTicks(2594), new DateTime(2020, 5, 11, 20, 39, 56, 652, DateTimeKind.Local).AddTicks(2145), new DateTime(2020, 5, 12, 2, 42, 31, 63, DateTimeKind.Local).AddTicks(5389), 96, "", "https://lisa.eu", "dignissimos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 5, 11, 21, 48, 29, 493, DateTimeKind.Local).AddTicks(1538), new DateTime(2020, 5, 12, 11, 34, 47, 418, DateTimeKind.Local).AddTicks(9542), new DateTime(2020, 5, 12, 9, 5, 19, 131, DateTimeKind.Local).AddTicks(9288), 96, "", "https://adam.com", "nam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 5, 12, 0, 5, 9, 180, DateTimeKind.Local).AddTicks(8673), new DateTime(2020, 5, 11, 16, 12, 21, 516, DateTimeKind.Local).AddTicks(8999), new DateTime(2020, 5, 12, 2, 8, 46, 672, DateTimeKind.Local).AddTicks(2439), 95, "", "https://lucie.org", "natus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 5, 12, 15, 7, 22, 724, DateTimeKind.Local).AddTicks(7535), new DateTime(2020, 5, 12, 8, 21, 54, 236, DateTimeKind.Local).AddTicks(7067), new DateTime(2020, 5, 12, 2, 1, 37, 187, DateTimeKind.Local).AddTicks(1329), 95, "", "http://clément.name", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 5, 11, 17, 46, 36, 184, DateTimeKind.Local).AddTicks(3309), new DateTime(2020, 5, 12, 9, 42, 53, 778, DateTimeKind.Local).AddTicks(6318), new DateTime(2020, 5, 12, 2, 54, 23, 258, DateTimeKind.Local).AddTicks(8622), 94, "", "http://chloé.info", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 5, 12, 6, 22, 58, 683, DateTimeKind.Local).AddTicks(637), new DateTime(2020, 5, 11, 15, 35, 42, 966, DateTimeKind.Local).AddTicks(8448), new DateTime(2020, 5, 12, 3, 3, 17, 366, DateTimeKind.Local).AddTicks(1126), 94, "", "http://justine.name", "aspernatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 5, 12, 2, 45, 29, 3, DateTimeKind.Local).AddTicks(779), new DateTime(2020, 5, 11, 22, 50, 10, 51, DateTimeKind.Local).AddTicks(7732), new DateTime(2020, 5, 12, 10, 53, 26, 131, DateTimeKind.Local).AddTicks(5599), 92, "", "http://romane.info", "veniam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 5, 11, 22, 56, 21, 81, DateTimeKind.Local).AddTicks(5827), new DateTime(2020, 5, 12, 12, 24, 45, 912, DateTimeKind.Local).AddTicks(9013), new DateTime(2020, 5, 12, 14, 15, 4, 573, DateTimeKind.Local).AddTicks(827), 90, "", "http://camille.org", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 5, 11, 23, 46, 36, 33, DateTimeKind.Local).AddTicks(9231), new DateTime(2020, 5, 11, 15, 47, 7, 280, DateTimeKind.Local).AddTicks(1977), new DateTime(2020, 5, 12, 1, 54, 31, 415, DateTimeKind.Local).AddTicks(1096), 89, "", "https://mélissa.com", "beatae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 5, 11, 21, 58, 19, 435, DateTimeKind.Local).AddTicks(1640), new DateTime(2020, 5, 12, 3, 7, 30, 618, DateTimeKind.Local).AddTicks(357), new DateTime(2020, 5, 12, 2, 28, 7, 808, DateTimeKind.Local).AddTicks(2809), 88, "", "https://mael.net", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 5, 11, 22, 59, 35, 649, DateTimeKind.Local).AddTicks(3303), new DateTime(2020, 5, 12, 4, 57, 15, 405, DateTimeKind.Local).AddTicks(6445), new DateTime(2020, 5, 12, 10, 9, 37, 679, DateTimeKind.Local).AddTicks(103), 88, "", "https://maëlys.info", "nihil" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 5, 12, 0, 26, 56, 700, DateTimeKind.Local).AddTicks(6373), new DateTime(2020, 5, 12, 7, 11, 37, 611, DateTimeKind.Local).AddTicks(2744), new DateTime(2020, 5, 12, 14, 7, 44, 516, DateTimeKind.Local).AddTicks(8631), 86, "", "https://ambre.name", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 5, 12, 0, 11, 54, 30, DateTimeKind.Local).AddTicks(4411), new DateTime(2020, 5, 12, 11, 22, 12, 703, DateTimeKind.Local).AddTicks(3611), new DateTime(2020, 5, 11, 23, 28, 2, 247, DateTimeKind.Local).AddTicks(9761), 86, "", "http://pauline.info", "pariatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 5, 12, 5, 55, 29, 204, DateTimeKind.Local).AddTicks(3528), new DateTime(2020, 5, 12, 5, 11, 39, 841, DateTimeKind.Local).AddTicks(1857), new DateTime(2020, 5, 12, 9, 0, 10, 84, DateTimeKind.Local).AddTicks(1083), 84, "", "http://maëlys.fr", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 5, 12, 3, 0, 18, 609, DateTimeKind.Local).AddTicks(794), new DateTime(2020, 5, 12, 4, 56, 58, 585, DateTimeKind.Local).AddTicks(1173), new DateTime(2020, 5, 11, 16, 6, 59, 284, DateTimeKind.Local).AddTicks(3265), 84, "", "https://valentin.fr", "tempora" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 5, 12, 13, 48, 17, 993, DateTimeKind.Local).AddTicks(1345), new DateTime(2020, 5, 12, 1, 7, 54, 665, DateTimeKind.Local).AddTicks(8043), new DateTime(2020, 5, 11, 21, 47, 31, 513, DateTimeKind.Local).AddTicks(4725), 84, "", "http://alicia.name", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 5, 12, 3, 45, 25, 770, DateTimeKind.Local).AddTicks(4127), new DateTime(2020, 5, 12, 14, 37, 23, 719, DateTimeKind.Local).AddTicks(5506), new DateTime(2020, 5, 11, 20, 58, 27, 687, DateTimeKind.Local).AddTicks(8019), 81, "", "https://mael.eu", "accusantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 5, 12, 9, 31, 18, 658, DateTimeKind.Local).AddTicks(6238), new DateTime(2020, 5, 12, 11, 10, 27, 173, DateTimeKind.Local).AddTicks(6989), new DateTime(2020, 5, 11, 19, 14, 30, 606, DateTimeKind.Local).AddTicks(4845), 81, "", "https://enzo.com", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 5, 12, 8, 53, 45, 756, DateTimeKind.Local).AddTicks(9983), new DateTime(2020, 5, 12, 4, 6, 12, 805, DateTimeKind.Local).AddTicks(7121), new DateTime(2020, 5, 12, 15, 10, 12, 526, DateTimeKind.Local).AddTicks(5130), 78, "", "https://maeva.fr", "excepturi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 5, 11, 18, 13, 21, 225, DateTimeKind.Local).AddTicks(2134), new DateTime(2020, 5, 12, 4, 58, 18, 903, DateTimeKind.Local).AddTicks(2846), new DateTime(2020, 5, 12, 11, 38, 2, 36, DateTimeKind.Local).AddTicks(9005), 78, "", "http://louis.fr", "deleniti" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 5, 12, 5, 2, 41, 97, DateTimeKind.Local).AddTicks(2418), new DateTime(2020, 5, 12, 3, 29, 44, 44, DateTimeKind.Local).AddTicks(9320), new DateTime(2020, 5, 12, 2, 16, 23, 977, DateTimeKind.Local).AddTicks(4273), 36, "", "https://lucie.org", "nemo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 5, 11, 21, 12, 31, 661, DateTimeKind.Local).AddTicks(2202), new DateTime(2020, 5, 12, 10, 6, 0, 360, DateTimeKind.Local).AddTicks(6765), new DateTime(2020, 5, 12, 13, 29, 33, 940, DateTimeKind.Local).AddTicks(4230), 33, "", "http://lou.org", "voluptate" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 5, 12, 10, 19, 38, 997, DateTimeKind.Local).AddTicks(7437), new DateTime(2020, 5, 12, 8, 28, 38, 168, DateTimeKind.Local).AddTicks(1294), new DateTime(2020, 5, 12, 5, 11, 22, 146, DateTimeKind.Local).AddTicks(9490), 100, "", "http://antoine.net", "voluptas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 5, 11, 21, 18, 27, 867, DateTimeKind.Local).AddTicks(530), new DateTime(2020, 5, 11, 19, 38, 46, 51, DateTimeKind.Local).AddTicks(3781), new DateTime(2020, 5, 11, 18, 47, 15, 453, DateTimeKind.Local).AddTicks(4965), 31, "", "https://thomas.net", "corrupti" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 5, 11, 19, 32, 32, 454, DateTimeKind.Local).AddTicks(303), new DateTime(2020, 5, 11, 18, 33, 40, 242, DateTimeKind.Local).AddTicks(6919), new DateTime(2020, 5, 11, 18, 13, 59, 382, DateTimeKind.Local).AddTicks(1895), 19, "", "https://nathan.info", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 5, 12, 5, 14, 58, 905, DateTimeKind.Local).AddTicks(9311), new DateTime(2020, 5, 12, 9, 3, 11, 918, DateTimeKind.Local).AddTicks(9410), new DateTime(2020, 5, 12, 12, 29, 17, 245, DateTimeKind.Local).AddTicks(4), 18, "", "https://gabriel.eu", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 5, 12, 14, 11, 43, 15, DateTimeKind.Local).AddTicks(8838), new DateTime(2020, 5, 11, 21, 40, 32, 873, DateTimeKind.Local).AddTicks(4900), new DateTime(2020, 5, 11, 20, 5, 8, 716, DateTimeKind.Local).AddTicks(5665), 16, "", "http://maëlys.info", "quasi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 5, 11, 16, 4, 23, 326, DateTimeKind.Local).AddTicks(1726), new DateTime(2020, 5, 11, 23, 41, 21, 493, DateTimeKind.Local).AddTicks(9447), new DateTime(2020, 5, 12, 6, 14, 51, 578, DateTimeKind.Local).AddTicks(7692), 15, "", "http://benjamin.info", "fugit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 5, 12, 11, 39, 17, 654, DateTimeKind.Local).AddTicks(7639), new DateTime(2020, 5, 12, 4, 47, 57, 454, DateTimeKind.Local).AddTicks(4824), new DateTime(2020, 5, 11, 19, 59, 32, 340, DateTimeKind.Local).AddTicks(1384), 100, "", "https://maëlle.com", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 5, 11, 17, 48, 34, 734, DateTimeKind.Local).AddTicks(2908), new DateTime(2020, 5, 12, 4, 39, 2, 49, DateTimeKind.Local).AddTicks(2385), new DateTime(2020, 5, 12, 0, 21, 33, 946, DateTimeKind.Local).AddTicks(4617), 12, "", "http://lola.net", "sunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 5, 11, 20, 44, 0, 168, DateTimeKind.Local).AddTicks(5183), new DateTime(2020, 5, 12, 5, 4, 50, 763, DateTimeKind.Local).AddTicks(9367), new DateTime(2020, 5, 12, 9, 54, 51, 576, DateTimeKind.Local).AddTicks(5436), 11, "", "https://jeanne.fr", "sed" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 5, 12, 7, 46, 32, 668, DateTimeKind.Local).AddTicks(6312), new DateTime(2020, 5, 12, 13, 20, 3, 317, DateTimeKind.Local).AddTicks(4557), new DateTime(2020, 5, 12, 5, 4, 38, 65, DateTimeKind.Local).AddTicks(4375), 11, "", "https://léa.net", "sit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 5, 12, 11, 24, 36, 278, DateTimeKind.Local).AddTicks(4520), new DateTime(2020, 5, 12, 13, 6, 15, 586, DateTimeKind.Local).AddTicks(1898), new DateTime(2020, 5, 11, 22, 20, 52, 563, DateTimeKind.Local).AddTicks(7470), 19, "", "http://yanis.name", "vitae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 5, 12, 2, 25, 18, 715, DateTimeKind.Local).AddTicks(1065), new DateTime(2020, 5, 12, 5, 16, 42, 778, DateTimeKind.Local).AddTicks(7841), new DateTime(2020, 5, 12, 7, 50, 13, 368, DateTimeKind.Local).AddTicks(8228), 10, "", "http://laura.com", "ratione" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 5, 11, 18, 20, 11, 714, DateTimeKind.Local).AddTicks(160), new DateTime(2020, 5, 11, 17, 27, 48, 291, DateTimeKind.Local).AddTicks(6373), new DateTime(2020, 5, 12, 12, 8, 42, 152, DateTimeKind.Local).AddTicks(9524), 8, "", "http://baptiste.net", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 5, 12, 11, 8, 7, 296, DateTimeKind.Local).AddTicks(9018), new DateTime(2020, 5, 12, 14, 44, 32, 224, DateTimeKind.Local).AddTicks(8288), new DateTime(2020, 5, 12, 0, 13, 28, 473, DateTimeKind.Local).AddTicks(827), 8, "", "http://clémence.name", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 5, 12, 9, 10, 42, 279, DateTimeKind.Local).AddTicks(1456), new DateTime(2020, 5, 12, 13, 5, 8, 72, DateTimeKind.Local).AddTicks(1421), new DateTime(2020, 5, 12, 13, 43, 50, 395, DateTimeKind.Local).AddTicks(5368), 7, "", "https://antoine.info", "sapiente" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 5, 12, 4, 57, 47, 530, DateTimeKind.Local).AddTicks(3528), new DateTime(2020, 5, 11, 16, 57, 9, 561, DateTimeKind.Local).AddTicks(771), new DateTime(2020, 5, 12, 11, 17, 30, 848, DateTimeKind.Local).AddTicks(9527), 6, "", "https://clara.fr", "nesciunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 5, 12, 10, 4, 39, 61, DateTimeKind.Local).AddTicks(2080), new DateTime(2020, 5, 11, 22, 57, 47, 855, DateTimeKind.Local).AddTicks(394), new DateTime(2020, 5, 12, 8, 39, 34, 618, DateTimeKind.Local).AddTicks(3659), 5, "", "https://valentin.net", "rem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 5, 12, 13, 25, 33, 532, DateTimeKind.Local).AddTicks(5579), new DateTime(2020, 5, 12, 8, 22, 15, 412, DateTimeKind.Local).AddTicks(2681), new DateTime(2020, 5, 11, 23, 29, 35, 816, DateTimeKind.Local).AddTicks(1419), 3, "", "https://théo.com", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 5, 12, 10, 38, 12, 568, DateTimeKind.Local).AddTicks(2556), new DateTime(2020, 5, 12, 13, 23, 33, 678, DateTimeKind.Local).AddTicks(378), new DateTime(2020, 5, 12, 11, 44, 23, 483, DateTimeKind.Local).AddTicks(1930), 2, "", "https://jeanne.eu", "aperiam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 5, 11, 19, 38, 54, 103, DateTimeKind.Local).AddTicks(1057), new DateTime(2020, 5, 12, 1, 32, 15, 299, DateTimeKind.Local).AddTicks(6473), new DateTime(2020, 5, 12, 6, 21, 22, 956, DateTimeKind.Local).AddTicks(8393), 1, "", "https://pierre.info", "recusandae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 5, 12, 3, 15, 36, 199, DateTimeKind.Local).AddTicks(127), new DateTime(2020, 5, 12, 4, 18, 23, 501, DateTimeKind.Local).AddTicks(7361), new DateTime(2020, 5, 12, 13, 3, 32, 920, DateTimeKind.Local).AddTicks(5435), 9, "", "https://valentin.info", "voluptates" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 5, 12, 14, 44, 46, 604, DateTimeKind.Local).AddTicks(2863), new DateTime(2020, 5, 12, 0, 8, 14, 800, DateTimeKind.Local).AddTicks(6885), new DateTime(2020, 5, 12, 0, 25, 14, 214, DateTimeKind.Local).AddTicks(9555), 19, "", "http://marie.name", "aliquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 5, 12, 1, 56, 33, 122, DateTimeKind.Local).AddTicks(1213), new DateTime(2020, 5, 12, 14, 16, 36, 348, DateTimeKind.Local).AddTicks(47), new DateTime(2020, 5, 12, 7, 22, 22, 970, DateTimeKind.Local).AddTicks(4688), 13, "", "http://lena.com", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 5, 11, 21, 26, 27, 885, DateTimeKind.Local).AddTicks(6328), new DateTime(2020, 5, 12, 1, 51, 9, 830, DateTimeKind.Local).AddTicks(9999), new DateTime(2020, 5, 12, 5, 49, 46, 536, DateTimeKind.Local).AddTicks(7368), 19, "", "http://alice.eu", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 5, 11, 19, 22, 39, 939, DateTimeKind.Local).AddTicks(407), new DateTime(2020, 5, 12, 11, 3, 39, 563, DateTimeKind.Local).AddTicks(4665), new DateTime(2020, 5, 12, 4, 19, 37, 875, DateTimeKind.Local).AddTicks(2302), 30, "", "http://noa.name", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 5, 12, 6, 9, 45, 390, DateTimeKind.Local).AddTicks(5599), new DateTime(2020, 5, 12, 14, 47, 11, 522, DateTimeKind.Local).AddTicks(7229), new DateTime(2020, 5, 11, 19, 46, 55, 238, DateTimeKind.Local).AddTicks(6257), 29, "", "http://léa.eu", "veritatis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 5, 12, 5, 34, 32, 742, DateTimeKind.Local).AddTicks(3776), new DateTime(2020, 5, 12, 1, 5, 36, 535, DateTimeKind.Local).AddTicks(7088), new DateTime(2020, 5, 12, 6, 5, 12, 494, DateTimeKind.Local).AddTicks(1402), 19, "", "https://léa.com", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 5, 12, 4, 11, 23, 819, DateTimeKind.Local).AddTicks(1325), new DateTime(2020, 5, 11, 22, 3, 37, 123, DateTimeKind.Local).AddTicks(4453), new DateTime(2020, 5, 12, 2, 8, 53, 479, DateTimeKind.Local).AddTicks(8814), 28, "", "http://maëlle.org", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 5, 12, 2, 19, 13, 653, DateTimeKind.Local).AddTicks(9079), new DateTime(2020, 5, 12, 11, 36, 55, 245, DateTimeKind.Local).AddTicks(8734), new DateTime(2020, 5, 11, 19, 23, 27, 984, DateTimeKind.Local).AddTicks(4579), 28, "", "http://noah.com", "nesciunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 5, 11, 18, 55, 38, 550, DateTimeKind.Local).AddTicks(1779), new DateTime(2020, 5, 12, 2, 3, 47, 594, DateTimeKind.Local).AddTicks(6788), new DateTime(2020, 5, 12, 2, 30, 30, 799, DateTimeKind.Local).AddTicks(4630), 28, "", "http://camille.net", "voluptas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 5, 12, 12, 57, 29, 972, DateTimeKind.Local).AddTicks(5100), new DateTime(2020, 5, 11, 18, 0, 10, 20, DateTimeKind.Local).AddTicks(1865), new DateTime(2020, 5, 11, 15, 36, 36, 464, DateTimeKind.Local).AddTicks(7315), 28, "", "http://elisa.eu", "voluptas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 5, 12, 13, 28, 45, 396, DateTimeKind.Local).AddTicks(9965), new DateTime(2020, 5, 12, 11, 49, 35, 477, DateTimeKind.Local).AddTicks(9905), new DateTime(2020, 5, 12, 11, 32, 8, 956, DateTimeKind.Local).AddTicks(4095), 28, "", "http://raphaël.org", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 5, 12, 9, 10, 2, 861, DateTimeKind.Local).AddTicks(647), new DateTime(2020, 5, 11, 23, 8, 8, 609, DateTimeKind.Local).AddTicks(4998), new DateTime(2020, 5, 11, 22, 46, 2, 398, DateTimeKind.Local).AddTicks(5887), 27, "", "https://carla.com", "necessitatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 5, 12, 14, 20, 20, 533, DateTimeKind.Local).AddTicks(1074), new DateTime(2020, 5, 11, 22, 46, 38, 472, DateTimeKind.Local).AddTicks(8776), new DateTime(2020, 5, 11, 23, 37, 26, 376, DateTimeKind.Local).AddTicks(8873), 29, "", "http://léo.name", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 5, 12, 14, 55, 13, 841, DateTimeKind.Local).AddTicks(9937), new DateTime(2020, 5, 11, 15, 40, 49, 834, DateTimeKind.Local).AddTicks(3983), new DateTime(2020, 5, 12, 1, 52, 20, 471, DateTimeKind.Local).AddTicks(3732), 24, "", "http://elisa.name", "culpa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 5, 12, 9, 6, 50, 733, DateTimeKind.Local).AddTicks(8230), new DateTime(2020, 5, 11, 16, 58, 4, 397, DateTimeKind.Local).AddTicks(9009), new DateTime(2020, 5, 12, 6, 45, 26, 800, DateTimeKind.Local).AddTicks(3581), 24, "", "https://lena.info", "consectetur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 5, 11, 19, 24, 28, 522, DateTimeKind.Local).AddTicks(8697), new DateTime(2020, 5, 11, 16, 19, 1, 249, DateTimeKind.Local).AddTicks(2841), new DateTime(2020, 5, 11, 21, 22, 8, 815, DateTimeKind.Local).AddTicks(9823), 24, "", "http://anaïs.eu", "corrupti" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 5, 12, 5, 26, 29, 930, DateTimeKind.Local).AddTicks(9239), new DateTime(2020, 5, 11, 19, 25, 19, 463, DateTimeKind.Local).AddTicks(5914), new DateTime(2020, 5, 12, 2, 53, 4, 997, DateTimeKind.Local).AddTicks(2251), 23, "", "http://anaïs.name", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 5, 12, 5, 29, 39, 825, DateTimeKind.Local).AddTicks(2240), new DateTime(2020, 5, 11, 19, 24, 42, 312, DateTimeKind.Local).AddTicks(3718), new DateTime(2020, 5, 11, 19, 42, 26, 963, DateTimeKind.Local).AddTicks(9714), 23, "", "http://lola.name", "quos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 5, 11, 18, 27, 16, 355, DateTimeKind.Local).AddTicks(4398), new DateTime(2020, 5, 12, 1, 34, 6, 554, DateTimeKind.Local).AddTicks(3012), new DateTime(2020, 5, 12, 0, 54, 41, 545, DateTimeKind.Local).AddTicks(813), 23, "", "http://alice.info", "delectus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 5, 12, 5, 17, 30, 108, DateTimeKind.Local).AddTicks(8727), new DateTime(2020, 5, 11, 19, 28, 38, 382, DateTimeKind.Local).AddTicks(8972), new DateTime(2020, 5, 11, 20, 28, 32, 505, DateTimeKind.Local).AddTicks(9925), 22, "", "http://pauline.info", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 5, 11, 20, 15, 57, 797, DateTimeKind.Local).AddTicks(4725), new DateTime(2020, 5, 12, 6, 17, 53, 418, DateTimeKind.Local).AddTicks(5360), new DateTime(2020, 5, 11, 17, 55, 57, 472, DateTimeKind.Local).AddTicks(2847), 21, "", "https://maeva.fr", "repudiandae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 5, 11, 17, 19, 2, 37, DateTimeKind.Local).AddTicks(2953), new DateTime(2020, 5, 12, 2, 23, 56, 178, DateTimeKind.Local).AddTicks(2632), new DateTime(2020, 5, 12, 14, 17, 44, 446, DateTimeKind.Local).AddTicks(1225), 21, "", "http://noémie.org", "quidem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 5, 12, 12, 40, 10, 686, DateTimeKind.Local).AddTicks(2491), new DateTime(2020, 5, 11, 20, 42, 17, 227, DateTimeKind.Local).AddTicks(3733), new DateTime(2020, 5, 12, 8, 51, 48, 349, DateTimeKind.Local).AddTicks(204), 24, "", "http://noa.name", "tenetur" });

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
                values: new object[] { 4, 2, "Droits sociaux" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 5, 2, "Droits culturels" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 6, 2, "Droits environnementaux" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 7, 3, "Promotion des droits catégoriels" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label" },
                values: new object[] { 1, 1, "Démocratie" });

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
                values: new object[] { 8, 3, "Protection des droits catégoriels" });

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
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 9, "9.7.7.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 10, 4, 3, 1, 3, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 1, "0.4.5.7", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 2, 1, 1, 8, 3, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 99, "2.3.9.7", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 10, 3, 4, 7, 9, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 91, "5.3.5.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 3, 1, 1, 7, 8, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 82, "7.3.9.1", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 6, 1, 1, 7, 9, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 80, "2.1.1.3", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 10, 5, 2, 7, 4, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 73, "1.9.8.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 10, 4, 4, 7, 8, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 58, "1.2.2.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 3, 3, 1, 7, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 46, "4.3.1.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 6, 5, 2, 7, 5, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 38, "6.6.4.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 10, 1, 1, 7, 8, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 31, "1.2.8.9", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 5, 3, 3, 7, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 22, "5.9.9.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 8, 3, 2, 7, 7, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 8, "6.0.7.3", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 9, 1, 4, 7, 9, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 3, "9.8.9.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 6, 1, 3, 7, 8, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 2, "7.3.0.0", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 1, 4, 2, 7, 6, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 98, "0.9.2.3", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 9, 1, 1, 6, 4, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 92, "8.2.1.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 10, 5, 3, 6, 10, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 83, "0.7.3.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 4, 2, 4, 6, 10, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 75, "2.8.7.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 1, 2, 1, 6, 1, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 74, "0.5.9.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 9, 5, 4, 6, 10, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 69, "9.4.8.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 8, 5, 3, 6, 3, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 64, "5.2.3.1", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 6, 5, 3, 6, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 26, "4.1.4.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 7, 6, 3, 8, 6, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 47, "7.4.0.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 10, 4, 4, 8, 5, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 60, "1.3.3.6", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 8, 1, 3, 8, 4, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 61, "7.9.9.5", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 5, 6, 3, 8, 10, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 77, "6.0.8.4", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 3, 5, 4, 10, 2, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 71, "2.5.5.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 5, 1, 4, 10, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 68, "9.8.2.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 1, 2, 3, 10, 4, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 59, "4.9.1.2", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 4, 1, 2, 10, 10, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 32, "9.2.0.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 6, 1, 3, 10, 7, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 21, "4.9.3.0", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 5, 2, 3, 10, 1, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 20, "6.0.5.6", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 4, 2, 4, 10, 10, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 14, "7.3.8.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 4, 5, 2, 10, 3, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 10, "6.1.2.3", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 3, 5, 1, 10, 4, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 100, "1.8.9.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 2, 6, 1, 9, 5, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 55, "2.3.3.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 10, 5, 4, 6, 1, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 97, "5.4.9.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 2, 5, 4, 9, 8, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 85, "1.8.6.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 9, 5, 2, 9, 5, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 70, "2.1.8.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 8, 5, 2, 9, 7, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 67, "3.1.4.1", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 1, 1, 2, 9, 9, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 62, "9.2.7.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 4, 1, 2, 9, 7, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 49, "6.5.9.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 6, 1, 2, 9, 4, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 40, "7.4.7.8", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 5, 6, 1, 9, 2, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 30, "5.3.3.2", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 5, 6, 3, 9, 3, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 15, "2.7.3.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 4, 6, 3, 9, 3, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 11, "5.9.9.3", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 3, 5, 2, 9, 10, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 96, "8.1.0.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 1, 1, 4, 8, 2, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 90, "9.8.6.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 4, 5, 2, 9, 5, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 54, "1.2.7.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 4, 2, 1, 6, 8, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 78, "5.5.7.7", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 5, 5, 1, 10, 8, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 33, "7.9.9.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 1, 6, 4, 6, 8, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 25, "1.7.8.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 7, 2, 3, 3, 8, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 23, "1.8.7.6", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 5, 3, 1, 3, 10, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 13, "3.7.1.1", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 8, 3, 3, 3, 9, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 5, "6.4.4.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 10, 1, 1, 3, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 88, "7.2.0.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 8, 2, 3, 2, 3, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 81, "0.5.4.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 9, 1, 2, 2, 3, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 44, "6.4.2.5", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 3, 3, 4, 2, 6, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 39, "6.5.8.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 4, 5, 1, 2, 2, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 34, "7.1.5.1", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 8, 3, 1, 2, 4, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 29, "3.7.9.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 2, 4, 1, 2, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 28, "6.5.7.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 7, 1, 4, 2, 3, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 93, "7.3.4.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 8, 5, 2, 1, 7, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 89, "9.1.6.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 4, 1, 4, 1, 7, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 63, "9.3.6.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 5, 4, 3, 1, 10, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 56, "9.2.0.1", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 2, 6, 2, 1, 1, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 53, "9.9.9.6", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 6, 1, 3, 1, 8, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 45, "5.0.2.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 8, 2, 4, 1, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 42, "9.8.9.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 4, 2, 3, 1, 10, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 27, "0.0.5.3", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 8, 2, 1, 1, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 24, "8.6.9.3", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 7, 5, 2, 1, 7, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 35, "3.6.4.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 10, 5, 4, 6, 3, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 37, "2.6.1.3", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 9, 5, 3, 3, 4, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 66, "3.2.5.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 7, 5, 3, 3, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 36, "5.0.6.9", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 6, 5, 2, 2, 4, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 87, "6.1.3.7", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 10, 2, 4, 3, 3, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 79, "2.9.0.6", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 3, 3, 3, 3, 10, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 84, "3.4.5.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 10, 2, 2, 5, 8, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 76, "0.4.9.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 4, 4, 3, 5, 5, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 72, "0.3.0.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 7, 5, 4, 5, 5, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 51, "5.5.2.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 7, 2, 1, 5, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 50, "1.6.8.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 5, 6, 3, 5, 8, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 41, "2.6.8.0", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 5, 2, 4, 5, 2, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 17, "2.2.9.5", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 2, 3, 3, 5, 5, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 16, "1.1.7.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 1, 1, 1, 5, 1, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 6, "1.1.6.7", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 5, 4, 4, 5, 8, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 86, "8.3.6.5", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 5, 2, 2, 4, 10, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 18, "8.4.0.8", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 1, 2, 2, 5, 3, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 12, "4.0.3.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 8, 2, 3, 6, 4, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 65, "3.1.0.6", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 1, 3, 3, 4, 10, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 95, "9.1.7.8", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 10, 3, 4, 3, 7, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 4, "4.4.1.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 3, 4, 1, 4, 3, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 7, "4.4.8.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 7, 6, 3, 4, 6, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 19, "8.6.4.2", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 10, 1, 1, 4, 6, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 94, "8.9.1.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 1, 3, 1, 3, 7, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 48, "6.7.0.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 2, 6, 1, 4, 2, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 52, "2.7.2.5", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 2, 1, 4, 4, 8, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 57, "9.8.1.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 5, 2, 2, 4, 9, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 43, "2.4.0.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 1, 1, 4, 4, 10, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "veniam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 30, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "veniam", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 9, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "dignissimos", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "voluptas", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 3, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "quas", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 59, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "aliquam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 59, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 38, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "maiores", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 79, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "cum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 30, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "ipsum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 30, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "molestiae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 22, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "repellat", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 30, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 30, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "quo", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 95, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 56, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "nihil", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 56, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "at", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 68, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "sed", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 68, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "a", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 68, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "ducimus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 41, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "rerum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 60, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "quaerat", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 30, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "quis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 16, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "quaerat", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 36, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "saepe", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 16, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "non", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 81, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "aliquid", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 36, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "vitae", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 36, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "sapiente", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 19, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "velit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 23, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "optio", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 15, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "deserunt", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 85, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "dolorem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 85, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "totam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 99, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "corporis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 99, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "ut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 16, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "nemo", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 84, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "ut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 84, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "corrupti", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 74, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "est", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 74, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "harum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 57, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "eos", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 20, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "unde", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 20, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "nesciunt", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 78, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "est", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 78, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "at", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 78, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "iusto", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 16, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "dolor", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 84, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "unde", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 81, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "suscipit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 49, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "consequatur", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 18, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "explicabo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 4, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "corrupti", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 17, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "voluptatem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 17, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "perspiciatis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 87, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "expedita", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 70, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "hic", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 69, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "sunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 52, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "laudantium", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 40, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "est", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 94, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "quibusdam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 64, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "dignissimos", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 51, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "non", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 5, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "fugit", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 63, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "reprehenderit", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 34, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "ad", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 13, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "voluptatibus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 29, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "distinctio", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 29, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "ab", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 29, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "id", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 65, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "officia", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 36, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "sunt", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 4, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "itaque", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 98, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "amet", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 98, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "expedita", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 75, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "ut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 18, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "quisquam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 12, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "odit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 12, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "quia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 6, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "vel", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 37, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "recusandae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 37, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 1, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "amet", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 66, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "error", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 66, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "iure", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 66, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "culpa", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 76, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "aliquam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 48, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "repellendus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 26, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "placeat", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 73, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "corrupti", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 73, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "ut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 53, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "est", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 86, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "quo", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 86, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "non", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 44, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "in", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 44, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "sed", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 35, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "dolores", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 49, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "vel", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 26, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "laborum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 43, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/unbranded/gorgeous", 3, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/producer/circuit/asymmetric", 3, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/value-added/path/collaboration", 4, 99 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/fresh", 5, 99 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/fantastic", 2, 38 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/unbranded-wooden-pants", 2, 38 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/sql/investment-account", 1, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/saint-lucia/primary/home-loan-account", 5, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/parsing", 2, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/interface/internal", 5, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/actuating", 3, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/international/collaboration/workforce", 1, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/purple/incredible-plastic-towels", 6, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/primary/shoes", 2, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/isle/invoice", 6, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/streamline/practical-soft-chips", 4, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/syndicate/stable", 5, 100 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/matrix/digital/portals", 5, 68 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/business-focused/automotive--baby", 7, 68 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/rustic-concrete-soap/eco-centric/delaware", 2, 79 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/turquoise/moderator/fantastic", 3, 27 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/deposit", 1, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/nevada/up-sized", 7, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/payment", 4, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/functionality/steel", 1, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/distributed/mews/incredible", 6, 15 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/systems/stream", 5, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/generate", 6, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/bleeding-edge", 4, 82 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/navigating/intelligent-steel-table/generic-steel-computer", 3, 84 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/encoding", 2, 84 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/directional/implementation", 3, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/connect/compatible", 2, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/json", 6, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/health-movies--automotive", 6, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/ergonomic-fresh-shoes/visualize/tugrik", 4, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/quetzal/orchard/automotive", 6, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/quantify/gorgeous", 4, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/withdrawal", 1, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/clothing-music--jewelery/kina", 6, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/mississippi/pennsylvania", 6, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/stream/cordoba-oro", 3, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/invoice", 4, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/checking-account/handmade-metal-chips", 5, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/architect/gorgeous-metal-salad/orchestrate", 2, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/home-loan-account", 7, 61 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/exploit/street", 7, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/lead", 6, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/planner/forward/rubber", 6, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/payment/ergonomic-frozen-pizza/clothing-shoes--sports", 7, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/new-york", 4, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/hard-drive/soft", 6, 13 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/extranet/monitor/pound-sterling", 2, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/pixel", 2, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/out-of-the-box/system/bypass", 4, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/zimbabwe/cyan/robust", 2, 83 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/moderator/licensed-frozen-cheese", 1, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/asymmetric/azure/jordan", 6, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/minnesota", 5, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/withdrawal/savings-account", 6, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/practical-soft-mouse/holy-see-vatican-city-state/overriding", 2, 96 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/pennsylvania", 5, 40 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/wireless/madagascar", 7, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/transmit", 4, 34 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/navigate/vertical/customizable", 4, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/islands/access/ivory", 3, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/forks/handcrafted-granite-mouse", 1, 28 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/projection/generic", 7, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/programming", 3, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/firewall", 7, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/matrix/morocco", 5, 33 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/strategy/compressing/point", 5, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/georgia/auto-loan-account/xml", 3, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/sudan/strategize", 2, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/fantastic-rubber-hat/fundamental/common", 4, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/bypassing/robust/hungary", 7, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/multi-byte/knolls/utilize", 2, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/payment", 1, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/green/networks", 5, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/bypassing/comoros/executive", 1, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/personal-loan-account/sleek-cotton-bike/solutions", 1, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/generating", 1, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/digital/refined", 3, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/frozen", 4, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/bedfordshire/small-metal-shirt/bluetooth", 7, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/unbranded-fresh-hat/handmade/walks", 7, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/sdr/deposit/product", 3, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/fundamental", 5, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/programmable/human/maryland", 2, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/antarctica-the-territory-south-of-60-deg-s", 5, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/cross-platform", 3, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/redundant", 3, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/withdrawal", 4, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/practical-soft-table", 2, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/avon/roi/payment", 5, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/mobile/array/national", 7, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/withdrawal/face-to-face", 6, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/1080p", 1, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/knolls/bond-markets-units-european-composite-unit-eurco/officer", 5, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/payment/e-enable", 2, 74 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 1, new DateTime(2019, 10, 8, 16, 56, 0, 761, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 2, new DateTime(2020, 2, 6, 12, 9, 6, 593, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 6, new DateTime(2019, 10, 8, 14, 47, 34, 246, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 3, new DateTime(2019, 8, 17, 8, 41, 49, 168, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 2, new DateTime(2020, 2, 24, 6, 55, 13, 328, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 3, new DateTime(2019, 6, 10, 10, 19, 33, 850, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 1, new DateTime(2020, 1, 25, 8, 15, 18, 921, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 5, new DateTime(2020, 4, 17, 21, 59, 11, 924, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 5, new DateTime(2019, 10, 18, 4, 9, 51, 446, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 3, new DateTime(2019, 10, 22, 10, 55, 42, 446, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 1, new DateTime(2020, 2, 26, 19, 16, 9, 721, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 4, new DateTime(2019, 8, 22, 17, 26, 15, 819, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 1, new DateTime(2020, 4, 28, 18, 24, 23, 283, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 5, new DateTime(2019, 11, 14, 19, 1, 30, 22, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 4, new DateTime(2020, 3, 30, 8, 51, 40, 452, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 3, new DateTime(2020, 2, 26, 11, 51, 45, 215, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 1, new DateTime(2019, 8, 19, 15, 57, 11, 629, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 3, new DateTime(2020, 2, 2, 18, 37, 10, 997, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 6, new DateTime(2020, 3, 15, 0, 11, 5, 571, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 2, new DateTime(2019, 7, 25, 23, 13, 46, 359, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 5, new DateTime(2019, 10, 3, 3, 9, 57, 21, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 1, new DateTime(2019, 10, 26, 16, 39, 50, 541, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 2, new DateTime(2019, 9, 24, 6, 4, 45, 444, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 3, new DateTime(2019, 10, 4, 16, 43, 47, 228, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 4, new DateTime(2019, 12, 22, 13, 22, 2, 700, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 6, new DateTime(2020, 4, 26, 14, 53, 31, 905, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 4, new DateTime(2019, 12, 7, 8, 18, 6, 749, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 1, new DateTime(2020, 2, 6, 21, 36, 59, 131, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 4, new DateTime(2019, 6, 16, 14, 33, 43, 76, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 1, new DateTime(2019, 10, 2, 14, 0, 44, 535, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 2, new DateTime(2020, 1, 22, 15, 18, 12, 486, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 5, new DateTime(2019, 5, 29, 5, 8, 53, 881, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 1, new DateTime(2020, 1, 4, 8, 36, 55, 469, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 5, new DateTime(2019, 8, 19, 20, 47, 2, 624, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 6, new DateTime(2020, 1, 8, 6, 43, 18, 178, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 5, new DateTime(2019, 6, 19, 8, 1, 41, 590, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 6, new DateTime(2019, 7, 2, 7, 2, 42, 894, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 3, new DateTime(2019, 8, 27, 22, 53, 22, 571, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 1, new DateTime(2020, 2, 6, 18, 21, 36, 47, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 1, new DateTime(2019, 11, 17, 12, 43, 51, 866, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 6, new DateTime(2020, 3, 28, 12, 47, 19, 598, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 3, new DateTime(2019, 11, 28, 1, 2, 15, 877, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 6, new DateTime(2020, 1, 24, 18, 34, 42, 786, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 2, new DateTime(2019, 6, 25, 8, 15, 1, 809, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 3, new DateTime(2020, 5, 4, 3, 47, 1, 210, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 1, new DateTime(2019, 11, 6, 20, 9, 16, 985, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 5, new DateTime(2019, 12, 14, 20, 49, 9, 791, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 4, new DateTime(2019, 7, 26, 20, 14, 29, 159, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 3, new DateTime(2020, 3, 11, 8, 49, 52, 51, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 2, new DateTime(2019, 10, 21, 19, 44, 18, 720, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 3, new DateTime(2019, 9, 30, 15, 43, 17, 165, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 6, new DateTime(2020, 2, 23, 5, 14, 24, 939, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 1, new DateTime(2019, 9, 5, 0, 27, 37, 961, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 5, new DateTime(2019, 8, 18, 16, 9, 41, 202, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 5, new DateTime(2019, 9, 1, 15, 23, 14, 342, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 3, new DateTime(2020, 2, 27, 12, 52, 15, 352, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 5, new DateTime(2019, 5, 22, 12, 39, 11, 921, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 4, new DateTime(2019, 10, 6, 20, 57, 5, 882, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 5, new DateTime(2019, 9, 10, 2, 29, 44, 868, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 6, new DateTime(2019, 11, 25, 18, 44, 48, 755, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 1, new DateTime(2019, 11, 25, 19, 20, 57, 163, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 6, new DateTime(2019, 7, 17, 11, 54, 58, 493, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 6, new DateTime(2019, 7, 5, 8, 40, 46, 354, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 2, new DateTime(2019, 6, 25, 5, 26, 32, 812, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 5, new DateTime(2019, 7, 19, 6, 23, 50, 841, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 2, new DateTime(2019, 12, 9, 10, 37, 29, 818, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 3, new DateTime(2019, 11, 26, 18, 0, 1, 182, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 4, new DateTime(2019, 9, 14, 23, 18, 16, 501, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 1, new DateTime(2019, 6, 7, 3, 3, 18, 314, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 2, new DateTime(2019, 10, 19, 18, 3, 28, 43, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 5, new DateTime(2020, 3, 3, 23, 38, 15, 326, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 4, new DateTime(2020, 2, 26, 4, 43, 37, 868, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 2, new DateTime(2019, 9, 12, 1, 24, 30, 989, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 3, new DateTime(2019, 12, 9, 4, 35, 30, 681, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 5, new DateTime(2020, 4, 27, 7, 59, 53, 239, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 3, new DateTime(2020, 4, 19, 1, 39, 23, 640, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 4, new DateTime(2020, 4, 21, 16, 57, 21, 131, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 4, new DateTime(2019, 8, 26, 3, 22, 46, 597, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 6, new DateTime(2019, 10, 21, 1, 33, 52, 897, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 5, new DateTime(2019, 11, 6, 15, 31, 21, 140, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 2, new DateTime(2020, 1, 26, 18, 50, 16, 367, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 4, new DateTime(2019, 5, 22, 11, 24, 36, 732, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 2, new DateTime(2019, 7, 3, 8, 57, 36, 693, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 1, new DateTime(2019, 9, 19, 10, 0, 19, 377, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 6, new DateTime(2019, 6, 10, 5, 20, 16, 225, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 1, new DateTime(2019, 7, 23, 11, 55, 8, 507, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 3, new DateTime(2019, 9, 19, 10, 19, 55, 33, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 5, new DateTime(2020, 4, 26, 14, 11, 21, 946, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 6, new DateTime(2019, 11, 24, 4, 50, 9, 236, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 1, new DateTime(2019, 10, 1, 14, 18, 25, 240, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 2, new DateTime(2020, 3, 6, 0, 0, 37, 770, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 2, new DateTime(2020, 1, 20, 20, 17, 39, 761, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 4, new DateTime(2019, 7, 7, 21, 32, 56, 677, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 2, new DateTime(2019, 6, 15, 8, 0, 23, 864, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 5, new DateTime(2020, 4, 29, 4, 27, 6, 920, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 4, new DateTime(2019, 6, 16, 21, 35, 42, 762, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 4, new DateTime(2019, 8, 30, 1, 51, 32, 182, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 4, new DateTime(2019, 6, 5, 10, 28, 57, 305, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 3, new DateTime(2019, 11, 22, 1, 17, 29, 450, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 5, new DateTime(2019, 9, 16, 19, 27, 29, 329, DateTimeKind.Local).AddTicks(3777) });

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
