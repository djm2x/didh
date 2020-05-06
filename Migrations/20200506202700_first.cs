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
                    Etat = table.Column<string>(nullable: false)
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
                columns: new[] { "Id", "CompilationHCDH", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 6, "", "Examen-7", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 5, "", "Examen-6", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 4, "", "Examen-5", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 1, "", "Examen-2", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 2, "", "Examen-3", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Libelle", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 3, "", "Examen-4", "", "", "" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2019, 11, 19, 0, 45, 36, 241, DateTimeKind.Local).AddTicks(435), "0,3,6", 65, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 73, new DateTime(2019, 7, 20, 8, 12, 49, 91, DateTimeKind.Local).AddTicks(1462), "1,2,6", 73, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2020, 1, 25, 19, 42, 44, 336, DateTimeKind.Local).AddTicks(1564), "0,3,6", 72, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2019, 12, 19, 5, 9, 19, 109, DateTimeKind.Local).AddTicks(7367), "1,3,6", 71, 2, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2020, 1, 11, 23, 24, 18, 998, DateTimeKind.Local).AddTicks(2253), "1,3,5", 70, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2019, 5, 29, 10, 36, 32, 747, DateTimeKind.Local).AddTicks(1217), "1,3,4", 69, 5, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2019, 5, 11, 17, 29, 27, 931, DateTimeKind.Local).AddTicks(7594), "1,2,6", 68, 1, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2020, 4, 2, 12, 37, 6, 12, DateTimeKind.Local).AddTicks(5339), "1,2,6", 67, 3, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2019, 12, 17, 1, 41, 42, 827, DateTimeKind.Local).AddTicks(3332), "1,2,4", 66, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2019, 10, 9, 7, 31, 41, 371, DateTimeKind.Local).AddTicks(6186), "1,2,6", 64, 5, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2019, 9, 18, 7, 18, 53, 708, DateTimeKind.Local).AddTicks(2862), "1,3,6", 54, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2020, 4, 29, 13, 18, 38, 248, DateTimeKind.Local).AddTicks(98), "0,2,4", 62, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2019, 10, 18, 21, 33, 29, 349, DateTimeKind.Local).AddTicks(938), "1,3,6", 61, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2020, 5, 3, 6, 28, 19, 37, DateTimeKind.Local).AddTicks(2510), "1,3,6", 60, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2019, 8, 22, 14, 38, 5, 871, DateTimeKind.Local).AddTicks(3490), "1,3,4", 59, 4, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2019, 9, 22, 7, 56, 11, 668, DateTimeKind.Local).AddTicks(9598), "0,2,4", 58, 3, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2019, 7, 16, 12, 11, 21, 441, DateTimeKind.Local).AddTicks(4054), "1,3,4", 57, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2020, 2, 29, 14, 24, 56, 700, DateTimeKind.Local).AddTicks(2854), "0,3,5", 56, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2019, 10, 30, 20, 10, 3, 431, DateTimeKind.Local).AddTicks(2694), "0,2,6", 55, 5, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2019, 5, 19, 15, 31, 17, 64, DateTimeKind.Local).AddTicks(1761), "0,3,4", 74, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2019, 9, 27, 14, 34, 51, 251, DateTimeKind.Local).AddTicks(270), "1,3,4", 53, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2019, 8, 22, 6, 2, 42, 978, DateTimeKind.Local).AddTicks(1194), "0,3,5", 63, 4, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2019, 8, 12, 0, 13, 23, 868, DateTimeKind.Local).AddTicks(5656), "1,2,6", 75, 6, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2019, 7, 7, 8, 42, 18, 568, DateTimeKind.Local).AddTicks(4034), "1,3,5", 86, 5, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2019, 9, 15, 17, 38, 4, 89, DateTimeKind.Local).AddTicks(4746), "1,3,5", 78, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2020, 3, 6, 22, 36, 13, 876, DateTimeKind.Local).AddTicks(4248), "0,2,4", 100, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2020, 4, 5, 9, 16, 39, 779, DateTimeKind.Local).AddTicks(1006), "1,3,6", 99, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2019, 5, 16, 19, 59, 11, 10, DateTimeKind.Local).AddTicks(4871), "0,2,5", 98, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2020, 4, 14, 19, 46, 18, 137, DateTimeKind.Local).AddTicks(9918), "0,2,6", 97, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2019, 8, 18, 22, 11, 10, 720, DateTimeKind.Local).AddTicks(1747), "1,2,5", 96, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2019, 9, 16, 1, 42, 53, 443, DateTimeKind.Local).AddTicks(8751), "1,3,5", 95, 5, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2019, 11, 1, 5, 56, 14, 571, DateTimeKind.Local).AddTicks(8889), "1,3,4", 94, 6, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2020, 3, 11, 6, 18, 51, 21, DateTimeKind.Local).AddTicks(577), "1,2,6", 93, 5, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2019, 6, 7, 0, 8, 14, 231, DateTimeKind.Local).AddTicks(1778), "1,3,5", 92, 2, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2019, 8, 22, 20, 48, 45, 990, DateTimeKind.Local).AddTicks(311), "1,3,4", 91, 6, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2019, 8, 3, 21, 6, 9, 714, DateTimeKind.Local).AddTicks(105), "1,3,4", 77, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2019, 12, 12, 11, 41, 32, 194, DateTimeKind.Local).AddTicks(7402), "1,3,5", 90, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2020, 4, 9, 18, 51, 33, 510, DateTimeKind.Local).AddTicks(7244), "1,2,4", 88, 5, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2019, 7, 7, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(6984), "0,3,4", 87, 1, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2019, 10, 7, 9, 28, 25, 920, DateTimeKind.Local).AddTicks(411), "0,3,4", 52, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2019, 8, 21, 9, 10, 1, 902, DateTimeKind.Local).AddTicks(6508), "1,2,6", 85, 5, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2019, 12, 20, 5, 28, 51, 398, DateTimeKind.Local).AddTicks(1185), "1,2,5", 84, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2019, 10, 18, 18, 58, 23, 59, DateTimeKind.Local).AddTicks(9703), "0,2,6", 83, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2020, 3, 5, 12, 35, 32, 351, DateTimeKind.Local).AddTicks(1982), "0,2,6", 82, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2020, 1, 16, 2, 16, 47, 801, DateTimeKind.Local).AddTicks(8299), "0,2,5", 81, 6, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2019, 7, 27, 15, 40, 54, 909, DateTimeKind.Local).AddTicks(951), "0,2,4", 80, 4, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2020, 2, 5, 15, 44, 14, 450, DateTimeKind.Local).AddTicks(7586), "0,2,6", 79, 3, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2019, 11, 16, 16, 33, 43, 906, DateTimeKind.Local).AddTicks(3722), "1,2,4", 89, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2020, 4, 21, 15, 7, 12, 825, DateTimeKind.Local).AddTicks(1633), "0,2,6", 51, 4, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2019, 12, 7, 16, 27, 52, 621, DateTimeKind.Local).AddTicks(4642), "1,3,5", 76, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2020, 3, 22, 1, 42, 58, 100, DateTimeKind.Local).AddTicks(287), "1,2,4", 49, 5, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2019, 11, 28, 9, 23, 48, 991, DateTimeKind.Local).AddTicks(9225), "1,3,6", 22, 2, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2020, 3, 21, 13, 35, 37, 250, DateTimeKind.Local).AddTicks(6618), "1,3,4", 50, 5, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2019, 6, 18, 22, 23, 33, 188, DateTimeKind.Local).AddTicks(1887), "0,2,4", 20, 2, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2019, 11, 15, 20, 6, 37, 681, DateTimeKind.Local).AddTicks(239), "0,3,6", 19, 4, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2019, 6, 14, 11, 48, 29, 247, DateTimeKind.Local).AddTicks(9924), "1,2,4", 18, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2019, 6, 9, 8, 36, 41, 644, DateTimeKind.Local).AddTicks(4601), "1,2,5", 17, 6, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2019, 8, 19, 0, 10, 21, 662, DateTimeKind.Local).AddTicks(9780), "1,3,5", 16, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2019, 6, 23, 8, 8, 56, 795, DateTimeKind.Local).AddTicks(7098), "1,3,5", 15, 4, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2020, 1, 22, 7, 21, 33, 699, DateTimeKind.Local).AddTicks(3592), "1,3,6", 14, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2019, 10, 2, 21, 6, 44, 148, DateTimeKind.Local).AddTicks(9175), "1,2,4", 13, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 3, 15, 5, 13, 48, 519, DateTimeKind.Local).AddTicks(9920), "0,3,6", 23, 2, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2020, 3, 20, 20, 13, 56, 834, DateTimeKind.Local).AddTicks(9328), "0,2,6", 12, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2019, 7, 14, 20, 42, 37, 734, DateTimeKind.Local).AddTicks(1444), "0,2,4", 10, 3, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2019, 8, 16, 13, 1, 34, 1, DateTimeKind.Local).AddTicks(6199), "0,3,4", 9, 1, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2019, 8, 9, 0, 8, 23, 132, DateTimeKind.Local).AddTicks(6833), "0,2,4", 8, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2020, 3, 15, 2, 51, 14, 665, DateTimeKind.Local).AddTicks(5624), "1,2,6", 7, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2020, 2, 2, 14, 34, 50, 554, DateTimeKind.Local).AddTicks(6432), "1,2,4", 6, 4, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2020, 3, 15, 20, 28, 45, 439, DateTimeKind.Local).AddTicks(1096), "0,2,4", 5, 3, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2020, 2, 28, 5, 23, 3, 834, DateTimeKind.Local).AddTicks(6582), "0,3,6", 4, 4, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2019, 8, 4, 15, 25, 48, 296, DateTimeKind.Local).AddTicks(74), "0,3,5", 3, 2, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2020, 4, 17, 5, 9, 49, 119, DateTimeKind.Local).AddTicks(5400), "0,3,4", 2, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2019, 12, 2, 22, 18, 57, 411, DateTimeKind.Local).AddTicks(8518), "0,3,5", 1, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2019, 10, 14, 10, 30, 55, 597, DateTimeKind.Local).AddTicks(8186), "0,3,5", 11, 2, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2019, 12, 16, 18, 38, 16, 939, DateTimeKind.Local).AddTicks(9203), "1,3,6", 24, 1, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2019, 5, 29, 1, 20, 47, 95, DateTimeKind.Local).AddTicks(6358), "0,2,6", 21, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2019, 9, 13, 13, 12, 7, 154, DateTimeKind.Local).AddTicks(8520), "0,2,5", 25, 5, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2019, 10, 25, 8, 31, 47, 301, DateTimeKind.Local).AddTicks(8920), "0,3,4", 48, 3, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2019, 7, 24, 15, 35, 48, 504, DateTimeKind.Local).AddTicks(399), "0,2,6", 47, 6, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2019, 6, 22, 23, 53, 55, 589, DateTimeKind.Local).AddTicks(3373), "0,2,6", 46, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2019, 11, 30, 15, 21, 29, 355, DateTimeKind.Local).AddTicks(6474), "1,2,4", 45, 5, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2019, 8, 12, 15, 42, 34, 17, DateTimeKind.Local).AddTicks(3034), "0,2,4", 44, 3, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2020, 4, 21, 20, 20, 52, 426, DateTimeKind.Local).AddTicks(8767), "1,3,5", 43, 1, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2019, 5, 23, 5, 22, 58, 651, DateTimeKind.Local).AddTicks(8738), "1,2,6", 42, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2019, 11, 3, 0, 4, 8, 655, DateTimeKind.Local).AddTicks(1195), "1,3,5", 40, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2019, 12, 6, 2, 5, 15, 726, DateTimeKind.Local).AddTicks(236), "0,2,4", 39, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2019, 10, 12, 7, 25, 6, 821, DateTimeKind.Local).AddTicks(4941), "0,3,6", 38, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2019, 11, 24, 18, 9, 0, 186, DateTimeKind.Local).AddTicks(904), "1,2,5", 37, 4, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2019, 6, 25, 11, 4, 29, 596, DateTimeKind.Local).AddTicks(9833), "1,2,5", 41, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2019, 5, 27, 8, 20, 50, 926, DateTimeKind.Local).AddTicks(7056), "1,3,6", 35, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2019, 8, 6, 18, 31, 7, 945, DateTimeKind.Local).AddTicks(7519), "0,2,6", 26, 1, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2019, 9, 22, 16, 51, 14, 384, DateTimeKind.Local).AddTicks(8396), "1,3,4", 36, 5, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2020, 1, 25, 14, 37, 39, 472, DateTimeKind.Local).AddTicks(8692), "1,3,4", 28, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2019, 7, 21, 3, 20, 5, 240, DateTimeKind.Local).AddTicks(8185), "1,2,4", 29, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2020, 4, 22, 3, 26, 35, 745, DateTimeKind.Local).AddTicks(6431), "1,2,5", 30, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2020, 3, 28, 11, 14, 6, 823, DateTimeKind.Local).AddTicks(9555), "1,2,4", 27, 2, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2019, 11, 22, 16, 15, 22, 967, DateTimeKind.Local).AddTicks(8525), "0,2,4", 32, 3, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2020, 1, 18, 1, 17, 15, 609, DateTimeKind.Local).AddTicks(3028), "0,2,4", 33, 1, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2019, 7, 8, 7, 53, 9, 797, DateTimeKind.Local).AddTicks(283), "0,2,6", 34, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2020, 1, 25, 12, 49, 25, 632, DateTimeKind.Local).AddTicks(8997), "0,3,6", 31, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 1, "Comité CEDAW" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 2, "Comité contre la torture" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label" },
                values: new object[] { 3, "Comité des disparitions forcées" });

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
                values: new object[] { 6, "Comité des droits des personnes handicapés" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 7, null, "Délégation interministérielle aux droits de l'Homme", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 6, null, "Ministère de la Santé", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 4, null, "Ministère de l'Equipement et du Transport", null });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "Tel" },
                values: new object[] { 5, null, "Ministère de la Communication", null });

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
                table: "Pays",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 1, "Maroc" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 2, "France" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 3, "Allemagne" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 4, "Espagnole" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label" },
                values: new object[] { 3, "Point focal" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label" },
                values: new object[] { 4, "Propriétaire" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label" },
                values: new object[] { 1, "Administrateur" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label" },
                values: new object[] { 2, "Superviseur" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 66, "", new DateTime(2020, 1, 4, 8, 20, 35, 567, DateTimeKind.Local).AddTicks(465), new DateTime(2019, 8, 13, 19, 58, 43, 584, DateTimeKind.Local).AddTicks(4022), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 73, "", new DateTime(2019, 6, 28, 21, 24, 25, 260, DateTimeKind.Local).AddTicks(7331), new DateTime(2019, 9, 28, 23, 37, 10, 549, DateTimeKind.Local).AddTicks(9815), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 74, "", new DateTime(2020, 4, 7, 18, 45, 59, 178, DateTimeKind.Local).AddTicks(2367), new DateTime(2019, 6, 27, 2, 42, 53, 41, DateTimeKind.Local).AddTicks(7961), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 72, "", new DateTime(2019, 10, 27, 12, 46, 1, 29, DateTimeKind.Local).AddTicks(8703), new DateTime(2019, 7, 30, 19, 46, 14, 274, DateTimeKind.Local).AddTicks(6172), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 71, "", new DateTime(2019, 7, 16, 5, 10, 15, 210, DateTimeKind.Local).AddTicks(5686), new DateTime(2020, 2, 5, 19, 3, 36, 189, DateTimeKind.Local).AddTicks(1129), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 70, "", new DateTime(2019, 6, 17, 10, 1, 39, 270, DateTimeKind.Local).AddTicks(6790), new DateTime(2019, 11, 5, 23, 50, 54, 755, DateTimeKind.Local).AddTicks(6846), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 69, "", new DateTime(2019, 9, 21, 3, 43, 27, 582, DateTimeKind.Local).AddTicks(395), new DateTime(2020, 3, 6, 13, 26, 54, 530, DateTimeKind.Local).AddTicks(6600), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 68, "", new DateTime(2020, 4, 30, 1, 43, 58, 347, DateTimeKind.Local).AddTicks(5349), new DateTime(2020, 2, 14, 6, 33, 52, 950, DateTimeKind.Local).AddTicks(5188), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 67, "", new DateTime(2019, 10, 25, 3, 45, 44, 256, DateTimeKind.Local).AddTicks(8123), new DateTime(2019, 6, 17, 3, 45, 11, 104, DateTimeKind.Local).AddTicks(2267), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 65, "", new DateTime(2020, 2, 4, 16, 42, 55, 626, DateTimeKind.Local).AddTicks(3495), new DateTime(2020, 2, 6, 20, 8, 58, 476, DateTimeKind.Local).AddTicks(5391), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 60, "", new DateTime(2020, 4, 7, 2, 54, 40, 245, DateTimeKind.Local).AddTicks(2937), new DateTime(2020, 2, 12, 17, 59, 1, 725, DateTimeKind.Local).AddTicks(5750), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 63, "", new DateTime(2020, 3, 3, 5, 40, 48, 350, DateTimeKind.Local).AddTicks(2791), new DateTime(2020, 2, 8, 16, 49, 30, 859, DateTimeKind.Local).AddTicks(5275), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 62, "", new DateTime(2019, 10, 5, 5, 49, 51, 240, DateTimeKind.Local).AddTicks(2718), new DateTime(2020, 1, 7, 21, 5, 7, 524, DateTimeKind.Local).AddTicks(7666), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 61, "", new DateTime(2020, 3, 1, 21, 4, 53, 321, DateTimeKind.Local).AddTicks(3408), new DateTime(2020, 1, 23, 19, 40, 41, 371, DateTimeKind.Local).AddTicks(304), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 75, "", new DateTime(2019, 9, 21, 22, 35, 45, 162, DateTimeKind.Local).AddTicks(8938), new DateTime(2019, 5, 19, 17, 21, 44, 847, DateTimeKind.Local).AddTicks(1726), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 59, "", new DateTime(2019, 9, 1, 8, 51, 3, 529, DateTimeKind.Local).AddTicks(5591), new DateTime(2020, 1, 31, 13, 54, 11, 118, DateTimeKind.Local).AddTicks(9483), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 58, "", new DateTime(2019, 12, 7, 5, 23, 40, 688, DateTimeKind.Local).AddTicks(6131), new DateTime(2020, 2, 26, 12, 45, 7, 248, DateTimeKind.Local).AddTicks(394), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 57, "", new DateTime(2019, 8, 18, 4, 40, 50, 869, DateTimeKind.Local).AddTicks(9598), new DateTime(2019, 9, 26, 17, 39, 52, 318, DateTimeKind.Local).AddTicks(4457), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 56, "", new DateTime(2020, 4, 23, 11, 56, 41, 182, DateTimeKind.Local).AddTicks(824), new DateTime(2020, 1, 23, 18, 57, 26, 459, DateTimeKind.Local).AddTicks(838), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 55, "", new DateTime(2020, 2, 27, 9, 0, 1, 580, DateTimeKind.Local).AddTicks(2644), new DateTime(2019, 8, 29, 16, 52, 15, 729, DateTimeKind.Local).AddTicks(1471), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 54, "", new DateTime(2019, 5, 25, 20, 24, 7, 385, DateTimeKind.Local).AddTicks(9713), new DateTime(2019, 6, 8, 7, 46, 7, 281, DateTimeKind.Local).AddTicks(780), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 53, "", new DateTime(2020, 1, 7, 1, 31, 16, 224, DateTimeKind.Local).AddTicks(4217), new DateTime(2020, 2, 27, 6, 43, 6, 761, DateTimeKind.Local).AddTicks(8094), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 64, "", new DateTime(2019, 8, 5, 7, 46, 6, 232, DateTimeKind.Local).AddTicks(7821), new DateTime(2020, 4, 6, 22, 1, 7, 840, DateTimeKind.Local).AddTicks(6434), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 76, "", new DateTime(2020, 4, 1, 20, 20, 34, 436, DateTimeKind.Local).AddTicks(5375), new DateTime(2020, 3, 8, 9, 7, 45, 272, DateTimeKind.Local).AddTicks(2614), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 81, "", new DateTime(2019, 8, 9, 11, 48, 46, 406, DateTimeKind.Local).AddTicks(4417), new DateTime(2020, 1, 21, 16, 6, 9, 289, DateTimeKind.Local).AddTicks(6151), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 78, "", new DateTime(2019, 12, 3, 17, 0, 15, 874, DateTimeKind.Local).AddTicks(8117), new DateTime(2019, 10, 18, 19, 35, 56, 198, DateTimeKind.Local).AddTicks(4857), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 52, "", new DateTime(2020, 3, 2, 12, 14, 58, 75, DateTimeKind.Local).AddTicks(2607), new DateTime(2019, 10, 9, 7, 25, 10, 960, DateTimeKind.Local).AddTicks(4288), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 100, "", new DateTime(2019, 10, 6, 10, 32, 9, 730, DateTimeKind.Local).AddTicks(7092), new DateTime(2020, 1, 12, 20, 53, 31, 601, DateTimeKind.Local).AddTicks(5720), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 99, "", new DateTime(2020, 3, 10, 23, 46, 3, 945, DateTimeKind.Local).AddTicks(7446), new DateTime(2020, 1, 30, 5, 51, 11, 802, DateTimeKind.Local).AddTicks(215), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 98, "", new DateTime(2019, 7, 19, 20, 21, 40, 527, DateTimeKind.Local).AddTicks(2011), new DateTime(2020, 1, 11, 1, 24, 10, 667, DateTimeKind.Local).AddTicks(9500), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 97, "", new DateTime(2020, 1, 12, 9, 38, 32, 768, DateTimeKind.Local).AddTicks(9516), new DateTime(2020, 2, 6, 23, 57, 40, 228, DateTimeKind.Local).AddTicks(8690), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 96, "", new DateTime(2019, 12, 9, 18, 0, 54, 710, DateTimeKind.Local).AddTicks(1594), new DateTime(2019, 5, 7, 11, 12, 20, 76, DateTimeKind.Local).AddTicks(6719), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 95, "", new DateTime(2019, 11, 17, 12, 40, 24, 779, DateTimeKind.Local).AddTicks(6106), new DateTime(2020, 1, 5, 0, 52, 29, 126, DateTimeKind.Local).AddTicks(7790), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 94, "", new DateTime(2019, 8, 26, 13, 8, 13, 36, DateTimeKind.Local).AddTicks(3021), new DateTime(2020, 1, 23, 16, 25, 53, 937, DateTimeKind.Local).AddTicks(5745), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 93, "", new DateTime(2020, 1, 17, 5, 36, 19, 705, DateTimeKind.Local).AddTicks(7416), new DateTime(2019, 10, 25, 22, 33, 41, 464, DateTimeKind.Local).AddTicks(4777), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 92, "", new DateTime(2020, 2, 24, 8, 35, 55, 420, DateTimeKind.Local).AddTicks(3001), new DateTime(2020, 1, 4, 3, 24, 12, 981, DateTimeKind.Local).AddTicks(8435), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 77, "", new DateTime(2019, 7, 20, 22, 50, 16, 452, DateTimeKind.Local).AddTicks(9237), new DateTime(2020, 1, 2, 20, 57, 28, 172, DateTimeKind.Local).AddTicks(5137), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 91, "", new DateTime(2019, 10, 11, 19, 25, 37, 699, DateTimeKind.Local).AddTicks(5603), new DateTime(2020, 3, 7, 11, 45, 56, 359, DateTimeKind.Local).AddTicks(3096), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 89, "", new DateTime(2019, 7, 26, 20, 2, 32, 516, DateTimeKind.Local).AddTicks(9548), new DateTime(2019, 12, 18, 8, 36, 59, 545, DateTimeKind.Local).AddTicks(7970), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 88, "", new DateTime(2019, 11, 15, 2, 24, 34, 814, DateTimeKind.Local).AddTicks(4786), new DateTime(2020, 4, 3, 7, 38, 23, 27, DateTimeKind.Local).AddTicks(7922), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 87, "", new DateTime(2019, 12, 23, 1, 8, 18, 653, DateTimeKind.Local).AddTicks(5787), new DateTime(2019, 10, 26, 3, 49, 53, 355, DateTimeKind.Local).AddTicks(5356), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 86, "", new DateTime(2019, 12, 20, 5, 30, 9, 591, DateTimeKind.Local).AddTicks(588), new DateTime(2019, 12, 13, 23, 35, 13, 394, DateTimeKind.Local).AddTicks(6722), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 85, "", new DateTime(2019, 12, 3, 2, 14, 56, 8, DateTimeKind.Local).AddTicks(1975), new DateTime(2019, 11, 23, 5, 26, 45, 288, DateTimeKind.Local).AddTicks(6048), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 84, "", new DateTime(2019, 11, 20, 18, 24, 47, 536, DateTimeKind.Local).AddTicks(2016), new DateTime(2019, 11, 12, 7, 23, 10, 516, DateTimeKind.Local).AddTicks(3385), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 83, "", new DateTime(2019, 7, 15, 0, 21, 40, 709, DateTimeKind.Local).AddTicks(177), new DateTime(2019, 8, 15, 0, 23, 54, 806, DateTimeKind.Local).AddTicks(5011), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 82, "", new DateTime(2020, 4, 2, 20, 29, 3, 908, DateTimeKind.Local).AddTicks(4678), new DateTime(2019, 5, 26, 23, 2, 51, 232, DateTimeKind.Local).AddTicks(2318), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 80, "", new DateTime(2019, 8, 28, 6, 5, 29, 111, DateTimeKind.Local).AddTicks(4708), new DateTime(2019, 5, 20, 22, 33, 23, 868, DateTimeKind.Local).AddTicks(2441), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 79, "", new DateTime(2019, 9, 21, 9, 0, 49, 609, DateTimeKind.Local).AddTicks(8696), new DateTime(2020, 3, 8, 15, 47, 55, 183, DateTimeKind.Local).AddTicks(8135), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 90, "", new DateTime(2019, 9, 23, 18, 57, 14, 624, DateTimeKind.Local).AddTicks(9087), new DateTime(2019, 6, 12, 0, 12, 11, 630, DateTimeKind.Local).AddTicks(439), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 51, "", new DateTime(2019, 10, 6, 22, 23, 35, 9, DateTimeKind.Local).AddTicks(2921), new DateTime(2019, 9, 25, 11, 18, 50, 623, DateTimeKind.Local).AddTicks(9997), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 30, "", new DateTime(2020, 4, 12, 17, 27, 17, 365, DateTimeKind.Local).AddTicks(537), new DateTime(2019, 7, 22, 9, 2, 1, 324, DateTimeKind.Local).AddTicks(5674), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 49, "", new DateTime(2019, 6, 3, 19, 14, 52, 76, DateTimeKind.Local).AddTicks(3319), new DateTime(2019, 8, 22, 6, 8, 31, 439, DateTimeKind.Local).AddTicks(6839), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 22, "", new DateTime(2020, 5, 1, 8, 31, 41, 936, DateTimeKind.Local).AddTicks(6321), new DateTime(2019, 7, 25, 0, 57, 31, 717, DateTimeKind.Local).AddTicks(2167), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 21, "", new DateTime(2020, 3, 19, 1, 25, 4, 79, DateTimeKind.Local).AddTicks(8478), new DateTime(2019, 12, 17, 7, 33, 42, 732, DateTimeKind.Local).AddTicks(7284), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 20, "", new DateTime(2019, 8, 7, 17, 41, 23, 687, DateTimeKind.Local).AddTicks(9038), new DateTime(2019, 5, 25, 20, 2, 26, 108, DateTimeKind.Local).AddTicks(7145), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 19, "", new DateTime(2019, 7, 22, 1, 5, 11, 618, DateTimeKind.Local).AddTicks(2768), new DateTime(2019, 10, 10, 22, 16, 32, 868, DateTimeKind.Local).AddTicks(9327), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 18, "", new DateTime(2020, 3, 5, 23, 50, 1, 572, DateTimeKind.Local).AddTicks(4881), new DateTime(2019, 9, 5, 22, 39, 16, 891, DateTimeKind.Local).AddTicks(4263), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 17, "", new DateTime(2019, 11, 10, 3, 46, 12, 624, DateTimeKind.Local).AddTicks(5358), new DateTime(2019, 11, 22, 0, 49, 16, 283, DateTimeKind.Local).AddTicks(3221), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 16, "", new DateTime(2019, 11, 28, 16, 36, 10, 411, DateTimeKind.Local).AddTicks(3933), new DateTime(2019, 7, 7, 18, 8, 2, 584, DateTimeKind.Local).AddTicks(7569), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 15, "", new DateTime(2019, 9, 7, 20, 21, 40, 263, DateTimeKind.Local).AddTicks(966), new DateTime(2019, 12, 4, 3, 59, 5, 132, DateTimeKind.Local).AddTicks(8352), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 14, "", new DateTime(2019, 11, 22, 20, 41, 3, 62, DateTimeKind.Local).AddTicks(6621), new DateTime(2020, 2, 21, 6, 46, 48, 627, DateTimeKind.Local).AddTicks(5188), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 13, "", new DateTime(2019, 7, 18, 18, 53, 13, 101, DateTimeKind.Local).AddTicks(6533), new DateTime(2019, 12, 20, 16, 47, 40, 860, DateTimeKind.Local).AddTicks(1077), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 23, "", new DateTime(2019, 8, 8, 13, 35, 56, 554, DateTimeKind.Local).AddTicks(2247), new DateTime(2019, 9, 13, 11, 2, 53, 947, DateTimeKind.Local).AddTicks(4196), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 12, "", new DateTime(2019, 10, 6, 13, 40, 12, 732, DateTimeKind.Local).AddTicks(9391), new DateTime(2019, 11, 14, 23, 49, 2, 387, DateTimeKind.Local).AddTicks(6844), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 10, "", new DateTime(2019, 9, 16, 17, 36, 24, 51, DateTimeKind.Local).AddTicks(9318), new DateTime(2019, 7, 10, 2, 2, 8, 643, DateTimeKind.Local).AddTicks(7831), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 9, "", new DateTime(2019, 6, 12, 13, 47, 4, 959, DateTimeKind.Local).AddTicks(3840), new DateTime(2019, 12, 2, 7, 51, 34, 867, DateTimeKind.Local).AddTicks(2648), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 8, "", new DateTime(2020, 2, 4, 19, 26, 35, 269, DateTimeKind.Local).AddTicks(7830), new DateTime(2019, 11, 12, 19, 11, 7, 63, DateTimeKind.Local).AddTicks(3513), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 7, "", new DateTime(2019, 6, 30, 1, 8, 40, 209, DateTimeKind.Local).AddTicks(6793), new DateTime(2019, 5, 30, 8, 34, 36, 636, DateTimeKind.Local).AddTicks(4813), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 6, "", new DateTime(2020, 4, 6, 21, 41, 42, 257, DateTimeKind.Local).AddTicks(2325), new DateTime(2020, 4, 24, 7, 7, 20, 173, DateTimeKind.Local).AddTicks(1476), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 5, "", new DateTime(2020, 2, 13, 4, 16, 6, 470, DateTimeKind.Local).AddTicks(4667), new DateTime(2019, 10, 24, 21, 41, 25, 288, DateTimeKind.Local).AddTicks(4636), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 4, "", new DateTime(2020, 1, 26, 21, 37, 29, 36, DateTimeKind.Local).AddTicks(8354), new DateTime(2020, 2, 14, 23, 50, 1, 103, DateTimeKind.Local).AddTicks(7455), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 3, "", new DateTime(2020, 4, 28, 4, 43, 6, 574, DateTimeKind.Local).AddTicks(7713), new DateTime(2019, 10, 7, 19, 12, 13, 484, DateTimeKind.Local).AddTicks(9482), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 2, "", new DateTime(2019, 7, 1, 13, 22, 30, 858, DateTimeKind.Local).AddTicks(2004), new DateTime(2020, 4, 20, 1, 26, 22, 903, DateTimeKind.Local).AddTicks(4364), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 50, "", new DateTime(2019, 5, 27, 14, 47, 43, 610, DateTimeKind.Local).AddTicks(4995), new DateTime(2019, 11, 2, 17, 59, 55, 239, DateTimeKind.Local).AddTicks(8100), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 11, "", new DateTime(2019, 11, 8, 17, 6, 57, 529, DateTimeKind.Local).AddTicks(5090), new DateTime(2019, 6, 29, 8, 28, 41, 170, DateTimeKind.Local).AddTicks(7041), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 24, "", new DateTime(2020, 3, 8, 2, 15, 51, 813, DateTimeKind.Local).AddTicks(9173), new DateTime(2020, 1, 24, 23, 15, 29, 365, DateTimeKind.Local).AddTicks(4729), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 1, "", new DateTime(2019, 7, 10, 21, 16, 7, 928, DateTimeKind.Local).AddTicks(26), new DateTime(2020, 2, 7, 21, 4, 3, 757, DateTimeKind.Local).AddTicks(6261), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 26, "", new DateTime(2019, 7, 28, 8, 3, 23, 91, DateTimeKind.Local).AddTicks(1362), new DateTime(2019, 10, 3, 19, 31, 55, 216, DateTimeKind.Local).AddTicks(5840), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 25, "", new DateTime(2019, 9, 20, 5, 22, 37, 846, DateTimeKind.Local).AddTicks(1618), new DateTime(2019, 12, 13, 0, 54, 37, 356, DateTimeKind.Local).AddTicks(9128), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 47, "", new DateTime(2020, 2, 25, 20, 6, 5, 652, DateTimeKind.Local).AddTicks(5369), new DateTime(2019, 5, 7, 17, 49, 20, 517, DateTimeKind.Local).AddTicks(3163), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 46, "", new DateTime(2019, 12, 8, 3, 5, 23, 855, DateTimeKind.Local).AddTicks(935), new DateTime(2019, 5, 20, 23, 21, 52, 297, DateTimeKind.Local).AddTicks(543), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 45, "", new DateTime(2019, 12, 5, 8, 37, 28, 724, DateTimeKind.Local).AddTicks(8186), new DateTime(2019, 5, 14, 0, 58, 14, 500, DateTimeKind.Local).AddTicks(3732), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 44, "", new DateTime(2019, 6, 8, 23, 1, 42, 324, DateTimeKind.Local).AddTicks(910), new DateTime(2019, 7, 28, 1, 14, 20, 196, DateTimeKind.Local).AddTicks(4012), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 43, "", new DateTime(2020, 2, 13, 14, 1, 24, 771, DateTimeKind.Local).AddTicks(5641), new DateTime(2020, 4, 1, 3, 58, 27, 62, DateTimeKind.Local).AddTicks(6479), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 42, "", new DateTime(2020, 3, 11, 16, 46, 53, 591, DateTimeKind.Local).AddTicks(9430), new DateTime(2019, 8, 5, 5, 53, 25, 820, DateTimeKind.Local).AddTicks(1606), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 40, "", new DateTime(2019, 12, 17, 12, 24, 12, 690, DateTimeKind.Local).AddTicks(6163), new DateTime(2019, 6, 20, 6, 15, 49, 996, DateTimeKind.Local).AddTicks(4915), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 39, "", new DateTime(2020, 4, 29, 0, 18, 15, 963, DateTimeKind.Local).AddTicks(5811), new DateTime(2019, 7, 8, 15, 54, 12, 58, DateTimeKind.Local).AddTicks(8533), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 38, "", new DateTime(2019, 8, 23, 7, 7, 54, 973, DateTimeKind.Local).AddTicks(9462), new DateTime(2020, 5, 3, 20, 40, 2, 993, DateTimeKind.Local).AddTicks(2307), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 41, "", new DateTime(2020, 3, 1, 1, 58, 55, 863, DateTimeKind.Local).AddTicks(6775), new DateTime(2019, 9, 1, 16, 35, 39, 399, DateTimeKind.Local).AddTicks(985), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 36, "", new DateTime(2020, 3, 17, 1, 20, 31, 842, DateTimeKind.Local).AddTicks(6888), new DateTime(2019, 10, 21, 14, 54, 23, 936, DateTimeKind.Local).AddTicks(2430), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 27, "", new DateTime(2019, 8, 10, 17, 28, 20, 904, DateTimeKind.Local).AddTicks(5948), new DateTime(2019, 11, 19, 17, 37, 54, 757, DateTimeKind.Local).AddTicks(8901), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 37, "", new DateTime(2019, 10, 1, 19, 26, 57, 843, DateTimeKind.Local).AddTicks(2838), new DateTime(2020, 4, 30, 13, 28, 48, 737, DateTimeKind.Local).AddTicks(604), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 29, "", new DateTime(2020, 3, 17, 22, 42, 52, 150, DateTimeKind.Local).AddTicks(661), new DateTime(2020, 1, 9, 13, 43, 56, 166, DateTimeKind.Local).AddTicks(9242), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 48, "", new DateTime(2019, 6, 5, 8, 31, 44, 954, DateTimeKind.Local).AddTicks(6912), new DateTime(2019, 11, 16, 18, 27, 19, 731, DateTimeKind.Local).AddTicks(7120), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 31, "", new DateTime(2019, 12, 8, 16, 49, 26, 203, DateTimeKind.Local).AddTicks(6861), new DateTime(2020, 4, 16, 21, 38, 49, 623, DateTimeKind.Local).AddTicks(6567), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 28, "", new DateTime(2020, 1, 16, 5, 57, 52, 230, DateTimeKind.Local).AddTicks(9181), new DateTime(2020, 3, 13, 10, 17, 11, 637, DateTimeKind.Local).AddTicks(2973), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 33, "", new DateTime(2019, 5, 7, 3, 16, 3, 104, DateTimeKind.Local).AddTicks(6683), new DateTime(2019, 9, 13, 8, 16, 58, 536, DateTimeKind.Local).AddTicks(3755), "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 34, "", new DateTime(2019, 8, 3, 12, 57, 6, 614, DateTimeKind.Local).AddTicks(1567), new DateTime(2019, 8, 26, 23, 27, 14, 67, DateTimeKind.Local).AddTicks(814), "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 35, "", new DateTime(2020, 1, 2, 3, 3, 0, 143, DateTimeKind.Local).AddTicks(8009), new DateTime(2020, 1, 8, 21, 57, 21, 20, DateTimeKind.Local).AddTicks(5334), "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "ConventionPiece", "DateRatification", "DateSignature", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 32, "", new DateTime(2019, 10, 25, 21, 51, 10, 993, DateTimeKind.Local).AddTicks(4452), new DateTime(2020, 1, 10, 15, 42, 59, 192, DateTimeKind.Local).AddTicks(7235), "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 65, new DateTime(2019, 8, 14, 18, 19, 27, 664, DateTimeKind.Local).AddTicks(8277), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 72, new DateTime(2019, 9, 7, 3, 13, 58, 424, DateTimeKind.Local).AddTicks(6737), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 71, new DateTime(2020, 4, 4, 2, 17, 2, 336, DateTimeKind.Local).AddTicks(182), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 70, new DateTime(2019, 10, 9, 10, 47, 7, 400, DateTimeKind.Local).AddTicks(8465), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 69, new DateTime(2020, 2, 26, 19, 13, 9, 609, DateTimeKind.Local).AddTicks(7801), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 68, new DateTime(2019, 5, 26, 6, 0, 5, 932, DateTimeKind.Local).AddTicks(3070), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 67, new DateTime(2020, 1, 11, 18, 51, 43, 238, DateTimeKind.Local).AddTicks(8827), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 66, new DateTime(2019, 8, 19, 7, 51, 51, 861, DateTimeKind.Local).AddTicks(6152), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 64, new DateTime(2020, 2, 8, 15, 14, 48, 340, DateTimeKind.Local).AddTicks(840), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 53, new DateTime(2019, 10, 4, 6, 19, 51, 81, DateTimeKind.Local).AddTicks(7181), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 62, new DateTime(2020, 4, 8, 2, 49, 18, 309, DateTimeKind.Local).AddTicks(6553), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 61, new DateTime(2019, 12, 30, 11, 35, 11, 91, DateTimeKind.Local).AddTicks(2505), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 60, new DateTime(2019, 12, 14, 15, 4, 10, 289, DateTimeKind.Local).AddTicks(7814), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 59, new DateTime(2019, 12, 11, 3, 17, 25, 822, DateTimeKind.Local).AddTicks(7215), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 58, new DateTime(2019, 7, 7, 13, 39, 47, 609, DateTimeKind.Local).AddTicks(6125), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 57, new DateTime(2019, 10, 3, 17, 44, 18, 483, DateTimeKind.Local).AddTicks(6535), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 56, new DateTime(2020, 3, 17, 15, 28, 32, 634, DateTimeKind.Local).AddTicks(1285), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 55, new DateTime(2019, 6, 6, 6, 10, 44, 816, DateTimeKind.Local).AddTicks(4878), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 54, new DateTime(2019, 7, 17, 7, 1, 27, 466, DateTimeKind.Local).AddTicks(7718), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 73, new DateTime(2020, 2, 29, 23, 0, 33, 818, DateTimeKind.Local).AddTicks(8261), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 52, new DateTime(2020, 2, 17, 1, 43, 29, 176, DateTimeKind.Local).AddTicks(8001), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 63, new DateTime(2019, 5, 14, 9, 55, 17, 506, DateTimeKind.Local).AddTicks(7008), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 74, new DateTime(2019, 12, 4, 4, 30, 44, 316, DateTimeKind.Local).AddTicks(4931), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 85, new DateTime(2020, 2, 17, 12, 34, 14, 428, DateTimeKind.Local).AddTicks(2081), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 76, new DateTime(2019, 11, 13, 11, 6, 21, 659, DateTimeKind.Local).AddTicks(6912), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 98, new DateTime(2019, 10, 23, 2, 3, 58, 285, DateTimeKind.Local).AddTicks(8278), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 51, new DateTime(2019, 9, 18, 20, 28, 14, 603, DateTimeKind.Local).AddTicks(208), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 97, new DateTime(2019, 5, 31, 2, 9, 48, 78, DateTimeKind.Local).AddTicks(2968), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 96, new DateTime(2019, 10, 10, 7, 33, 9, 508, DateTimeKind.Local).AddTicks(3749), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 95, new DateTime(2019, 8, 25, 5, 9, 33, 914, DateTimeKind.Local).AddTicks(9482), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 94, new DateTime(2020, 1, 5, 19, 11, 21, 176, DateTimeKind.Local).AddTicks(396), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 93, new DateTime(2020, 1, 20, 15, 38, 21, 743, DateTimeKind.Local).AddTicks(4779), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 92, new DateTime(2020, 2, 14, 9, 43, 11, 463, DateTimeKind.Local).AddTicks(6012), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 91, new DateTime(2019, 12, 6, 19, 19, 26, 401, DateTimeKind.Local).AddTicks(4067), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 90, new DateTime(2019, 6, 11, 5, 53, 54, 713, DateTimeKind.Local).AddTicks(6674), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 75, new DateTime(2020, 1, 10, 17, 48, 44, 906, DateTimeKind.Local).AddTicks(2566), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 89, new DateTime(2019, 12, 22, 15, 22, 37, 807, DateTimeKind.Local).AddTicks(2125), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 87, new DateTime(2019, 11, 20, 4, 59, 50, 714, DateTimeKind.Local).AddTicks(1184), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 86, new DateTime(2019, 11, 10, 13, 21, 43, 457, DateTimeKind.Local).AddTicks(8992), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 84, new DateTime(2019, 6, 27, 4, 54, 59, 890, DateTimeKind.Local).AddTicks(9082), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 83, new DateTime(2020, 3, 7, 3, 10, 31, 374, DateTimeKind.Local).AddTicks(1907), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 82, new DateTime(2019, 5, 18, 0, 19, 58, 134, DateTimeKind.Local).AddTicks(3373), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 81, new DateTime(2019, 11, 7, 22, 15, 5, 614, DateTimeKind.Local).AddTicks(2000), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 80, new DateTime(2019, 7, 8, 1, 52, 35, 140, DateTimeKind.Local).AddTicks(4059), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 79, new DateTime(2019, 7, 23, 22, 7, 24, 173, DateTimeKind.Local).AddTicks(3286), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 78, new DateTime(2019, 8, 20, 1, 35, 4, 130, DateTimeKind.Local).AddTicks(2519), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 77, new DateTime(2019, 5, 28, 6, 24, 19, 994, DateTimeKind.Local).AddTicks(8401), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 88, new DateTime(2019, 8, 1, 23, 49, 33, 960, DateTimeKind.Local).AddTicks(1304), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 50, new DateTime(2019, 10, 14, 18, 35, 54, 539, DateTimeKind.Local).AddTicks(720), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 26, new DateTime(2019, 5, 18, 7, 45, 26, 768, DateTimeKind.Local).AddTicks(2949), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 48, new DateTime(2020, 2, 19, 10, 1, 58, 889, DateTimeKind.Local).AddTicks(2101), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 20, new DateTime(2020, 2, 21, 1, 3, 35, 300, DateTimeKind.Local).AddTicks(3858), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 19, new DateTime(2020, 4, 8, 9, 12, 13, 560, DateTimeKind.Local).AddTicks(7267), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 18, new DateTime(2020, 4, 12, 2, 19, 49, 552, DateTimeKind.Local).AddTicks(8225), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 17, new DateTime(2020, 3, 12, 6, 1, 57, 953, DateTimeKind.Local).AddTicks(4765), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 16, new DateTime(2019, 12, 14, 0, 38, 25, 165, DateTimeKind.Local).AddTicks(5416), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 15, new DateTime(2019, 9, 28, 18, 50, 2, 92, DateTimeKind.Local).AddTicks(5892), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 14, new DateTime(2020, 4, 24, 15, 21, 41, 959, DateTimeKind.Local).AddTicks(961), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 13, new DateTime(2019, 7, 10, 0, 15, 53, 621, DateTimeKind.Local).AddTicks(6710), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 12, new DateTime(2020, 2, 29, 16, 46, 37, 426, DateTimeKind.Local).AddTicks(2476), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 11, new DateTime(2019, 5, 23, 14, 21, 37, 197, DateTimeKind.Local).AddTicks(5123), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 10, new DateTime(2020, 2, 9, 17, 12, 56, 307, DateTimeKind.Local).AddTicks(8042), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 9, new DateTime(2019, 5, 18, 18, 18, 58, 183, DateTimeKind.Local).AddTicks(8329), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 8, new DateTime(2019, 8, 5, 21, 41, 18, 244, DateTimeKind.Local).AddTicks(2009), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 7, new DateTime(2019, 7, 16, 3, 38, 59, 979, DateTimeKind.Local).AddTicks(4596), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 6, new DateTime(2020, 2, 21, 2, 40, 5, 299, DateTimeKind.Local).AddTicks(1319), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 5, new DateTime(2019, 6, 13, 10, 24, 31, 282, DateTimeKind.Local).AddTicks(143), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 4, new DateTime(2020, 2, 24, 15, 53, 56, 138, DateTimeKind.Local).AddTicks(3247), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 3, new DateTime(2019, 10, 25, 11, 30, 35, 101, DateTimeKind.Local).AddTicks(1080), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 2, new DateTime(2019, 10, 13, 14, 18, 30, 772, DateTimeKind.Local).AddTicks(4589), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 1, new DateTime(2019, 6, 28, 21, 13, 31, 494, DateTimeKind.Local).AddTicks(2694), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 99, new DateTime(2019, 5, 27, 3, 44, 37, 983, DateTimeKind.Local).AddTicks(6294), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 21, new DateTime(2019, 6, 27, 6, 49, 28, 181, DateTimeKind.Local).AddTicks(1532), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 22, new DateTime(2019, 11, 6, 23, 39, 37, 438, DateTimeKind.Local).AddTicks(9165), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 23, new DateTime(2020, 4, 27, 20, 47, 27, 240, DateTimeKind.Local).AddTicks(662), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 24, new DateTime(2020, 2, 5, 0, 39, 16, 646, DateTimeKind.Local).AddTicks(7851), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 47, new DateTime(2019, 5, 9, 16, 21, 44, 968, DateTimeKind.Local).AddTicks(8050), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 46, new DateTime(2019, 6, 27, 12, 36, 50, 409, DateTimeKind.Local).AddTicks(7256), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 45, new DateTime(2020, 1, 15, 10, 14, 16, 349, DateTimeKind.Local).AddTicks(169), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 44, new DateTime(2019, 9, 26, 9, 23, 1, 422, DateTimeKind.Local).AddTicks(1804), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 43, new DateTime(2019, 7, 31, 0, 27, 57, 359, DateTimeKind.Local).AddTicks(3642), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 42, new DateTime(2019, 10, 10, 2, 29, 15, 370, DateTimeKind.Local).AddTicks(8656), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 41, new DateTime(2020, 2, 14, 17, 16, 15, 669, DateTimeKind.Local).AddTicks(7472), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 40, new DateTime(2019, 11, 15, 6, 33, 52, 771, DateTimeKind.Local).AddTicks(7660), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 39, new DateTime(2019, 9, 26, 9, 43, 10, 960, DateTimeKind.Local).AddTicks(5750), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 38, new DateTime(2019, 9, 10, 3, 47, 30, 390, DateTimeKind.Local).AddTicks(6594), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 49, new DateTime(2019, 10, 29, 12, 8, 54, 864, DateTimeKind.Local).AddTicks(390), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 37, new DateTime(2019, 8, 25, 21, 39, 28, 390, DateTimeKind.Local).AddTicks(8080), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 35, new DateTime(2019, 12, 10, 6, 2, 34, 490, DateTimeKind.Local).AddTicks(5367), "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 34, new DateTime(2019, 9, 24, 14, 40, 18, 978, DateTimeKind.Local).AddTicks(1399), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 33, new DateTime(2019, 8, 7, 22, 4, 5, 604, DateTimeKind.Local).AddTicks(346), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 32, new DateTime(2020, 2, 23, 19, 32, 56, 102, DateTimeKind.Local).AddTicks(6291), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 31, new DateTime(2020, 4, 4, 16, 10, 31, 359, DateTimeKind.Local).AddTicks(3629), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 30, new DateTime(2019, 8, 9, 7, 41, 40, 400, DateTimeKind.Local).AddTicks(9498), "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 29, new DateTime(2020, 4, 16, 23, 53, 20, 412, DateTimeKind.Local).AddTicks(8565), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 28, new DateTime(2020, 3, 25, 17, 42, 9, 466, DateTimeKind.Local).AddTicks(5746), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 27, new DateTime(2019, 9, 17, 9, 39, 51, 858, DateTimeKind.Local).AddTicks(3209), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 25, new DateTime(2019, 9, 12, 20, 59, 0, 68, DateTimeKind.Local).AddTicks(6587), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 36, new DateTime(2019, 6, 30, 8, 44, 13, 23, DateTimeKind.Local).AddTicks(1312), "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 100, new DateTime(2020, 2, 1, 9, 22, 22, 233, DateTimeKind.Local).AddTicks(9751), "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 5, 7, 14, 12, 15, 976, DateTimeKind.Local).AddTicks(577), new DateTime(2020, 5, 7, 7, 31, 46, 693, DateTimeKind.Local).AddTicks(3478), new DateTime(2020, 5, 7, 6, 4, 20, 950, DateTimeKind.Local).AddTicks(4051), 41, "", "https://sarah.eu", "nihil" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 5, 7, 18, 34, 31, 813, DateTimeKind.Local).AddTicks(8524), new DateTime(2020, 5, 7, 6, 29, 47, 335, DateTimeKind.Local).AddTicks(5530), new DateTime(2020, 5, 7, 12, 53, 46, 865, DateTimeKind.Local).AddTicks(5153), 71, "", "https://louise.org", "illum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 5, 7, 12, 56, 43, 741, DateTimeKind.Local).AddTicks(2108), new DateTime(2020, 5, 7, 15, 38, 4, 666, DateTimeKind.Local).AddTicks(6190), new DateTime(2020, 5, 6, 21, 8, 18, 714, DateTimeKind.Local).AddTicks(9002), 70, "", "https://eva.name", "maiores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 5, 7, 7, 46, 51, 862, DateTimeKind.Local).AddTicks(7787), new DateTime(2020, 5, 7, 3, 9, 21, 275, DateTimeKind.Local).AddTicks(1533), new DateTime(2020, 5, 7, 8, 4, 49, 3, DateTimeKind.Local).AddTicks(1058), 68, "", "https://sacha.info", "vitae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 5, 7, 10, 33, 28, 388, DateTimeKind.Local).AddTicks(6102), new DateTime(2020, 5, 6, 22, 10, 44, 365, DateTimeKind.Local).AddTicks(3310), new DateTime(2020, 5, 7, 1, 46, 40, 706, DateTimeKind.Local).AddTicks(2868), 68, "", "http://axel.name", "sint" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 5, 7, 19, 56, 47, 95, DateTimeKind.Local).AddTicks(2939), new DateTime(2020, 5, 7, 9, 58, 49, 158, DateTimeKind.Local).AddTicks(4796), new DateTime(2020, 5, 6, 23, 17, 44, 884, DateTimeKind.Local).AddTicks(529), 67, "", "https://carla.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 5, 7, 5, 4, 10, 739, DateTimeKind.Local).AddTicks(1892), new DateTime(2020, 5, 7, 4, 20, 9, 146, DateTimeKind.Local).AddTicks(2749), new DateTime(2020, 5, 6, 22, 19, 16, 740, DateTimeKind.Local).AddTicks(6755), 64, "", "http://lena.net", "accusantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 5, 7, 8, 43, 1, 595, DateTimeKind.Local).AddTicks(4494), new DateTime(2020, 5, 7, 10, 35, 23, 64, DateTimeKind.Local).AddTicks(7010), new DateTime(2020, 5, 7, 15, 57, 13, 80, DateTimeKind.Local).AddTicks(2698), 62, "", "https://tom.com", "rem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 5, 7, 0, 19, 4, 5, DateTimeKind.Local).AddTicks(6439), new DateTime(2020, 5, 7, 14, 41, 19, 186, DateTimeKind.Local).AddTicks(482), new DateTime(2020, 5, 6, 21, 24, 5, 430, DateTimeKind.Local).AddTicks(7204), 60, "", "http://théo.info", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 5, 7, 5, 51, 59, 296, DateTimeKind.Local).AddTicks(8186), new DateTime(2020, 5, 7, 11, 30, 9, 686, DateTimeKind.Local).AddTicks(9940), new DateTime(2020, 5, 7, 5, 10, 19, 151, DateTimeKind.Local).AddTicks(9810), 60, "", "https://pierre.eu", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 5, 7, 0, 38, 36, 784, DateTimeKind.Local).AddTicks(2549), new DateTime(2020, 5, 7, 3, 8, 27, 120, DateTimeKind.Local).AddTicks(7704), new DateTime(2020, 5, 6, 21, 16, 49, 166, DateTimeKind.Local).AddTicks(5594), 60, "", "https://evan.eu", "neque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 5, 7, 4, 20, 38, 425, DateTimeKind.Local).AddTicks(9956), new DateTime(2020, 5, 7, 19, 51, 57, 17, DateTimeKind.Local).AddTicks(4422), new DateTime(2020, 5, 7, 19, 5, 26, 214, DateTimeKind.Local).AddTicks(9165), 58, "", "http://romain.info", "porro" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 5, 7, 17, 33, 1, 521, DateTimeKind.Local).AddTicks(1443), new DateTime(2020, 5, 6, 22, 48, 39, 530, DateTimeKind.Local).AddTicks(8854), new DateTime(2020, 5, 7, 17, 51, 12, 710, DateTimeKind.Local).AddTicks(5202), 71, "", "https://louise.name", "officiis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 5, 7, 10, 50, 2, 148, DateTimeKind.Local).AddTicks(2608), new DateTime(2020, 5, 7, 15, 6, 40, 640, DateTimeKind.Local).AddTicks(8076), new DateTime(2020, 5, 7, 19, 34, 54, 263, DateTimeKind.Local).AddTicks(1590), 57, "", "http://clémence.eu", "perferendis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 5, 7, 12, 33, 45, 261, DateTimeKind.Local).AddTicks(2237), new DateTime(2020, 5, 7, 17, 58, 29, 818, DateTimeKind.Local).AddTicks(1112), new DateTime(2020, 5, 7, 17, 10, 43, 17, DateTimeKind.Local).AddTicks(2851), 55, "", "https://lisa.name", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 5, 7, 10, 30, 53, 468, DateTimeKind.Local).AddTicks(5758), new DateTime(2020, 5, 7, 18, 59, 11, 836, DateTimeKind.Local).AddTicks(5804), new DateTime(2020, 5, 7, 14, 58, 43, 601, DateTimeKind.Local).AddTicks(7383), 53, "", "https://jules.net", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 5, 6, 23, 21, 13, 247, DateTimeKind.Local).AddTicks(5217), new DateTime(2020, 5, 6, 21, 55, 34, 212, DateTimeKind.Local).AddTicks(5096), new DateTime(2020, 5, 7, 7, 0, 23, 976, DateTimeKind.Local).AddTicks(4336), 51, "", "http://chloé.fr", "necessitatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 5, 7, 11, 15, 22, 393, DateTimeKind.Local).AddTicks(5129), new DateTime(2020, 5, 7, 2, 38, 22, 265, DateTimeKind.Local).AddTicks(733), new DateTime(2020, 5, 7, 5, 2, 39, 682, DateTimeKind.Local).AddTicks(1712), 51, "", "https://lola.com", "excepturi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 5, 7, 6, 52, 39, 926, DateTimeKind.Local).AddTicks(3220), new DateTime(2020, 5, 7, 19, 31, 29, 226, DateTimeKind.Local).AddTicks(4033), new DateTime(2020, 5, 7, 7, 52, 38, 884, DateTimeKind.Local).AddTicks(4746), 50, "", "https://maëlle.net", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 5, 7, 3, 55, 18, 647, DateTimeKind.Local).AddTicks(846), new DateTime(2020, 5, 7, 14, 37, 35, 940, DateTimeKind.Local).AddTicks(5097), new DateTime(2020, 5, 7, 7, 12, 17, 349, DateTimeKind.Local).AddTicks(7142), 49, "", "https://lucie.info", "velit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 5, 6, 23, 39, 13, 25, DateTimeKind.Local).AddTicks(2561), new DateTime(2020, 5, 7, 1, 5, 27, 685, DateTimeKind.Local).AddTicks(5931), new DateTime(2020, 5, 7, 16, 15, 10, 98, DateTimeKind.Local).AddTicks(742), 49, "", "https://noémie.eu", "natus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 5, 7, 17, 17, 9, 853, DateTimeKind.Local).AddTicks(5427), new DateTime(2020, 5, 7, 3, 58, 10, 650, DateTimeKind.Local).AddTicks(6209), new DateTime(2020, 5, 7, 14, 32, 43, 38, DateTimeKind.Local).AddTicks(2988), 48, "", "https://alicia.name", "tenetur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 5, 7, 17, 35, 31, 196, DateTimeKind.Local).AddTicks(8816), new DateTime(2020, 5, 7, 15, 29, 43, 431, DateTimeKind.Local).AddTicks(4615), new DateTime(2020, 5, 7, 16, 21, 27, 117, DateTimeKind.Local).AddTicks(9482), 47, "", "http://maxime.name", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 5, 6, 21, 28, 10, 117, DateTimeKind.Local).AddTicks(5984), new DateTime(2020, 5, 7, 13, 45, 41, 968, DateTimeKind.Local).AddTicks(8380), new DateTime(2020, 5, 7, 2, 49, 53, 371, DateTimeKind.Local).AddTicks(9898), 46, "", "http://clémence.org", "debitis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 5, 6, 22, 34, 52, 750, DateTimeKind.Local).AddTicks(9849), new DateTime(2020, 5, 7, 1, 3, 2, 521, DateTimeKind.Local).AddTicks(1176), new DateTime(2020, 5, 7, 5, 44, 4, 684, DateTimeKind.Local).AddTicks(3018), 45, "", "http://rayan.org", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 5, 7, 18, 36, 28, 64, DateTimeKind.Local).AddTicks(2029), new DateTime(2020, 5, 7, 14, 56, 59, 181, DateTimeKind.Local).AddTicks(3316), new DateTime(2020, 5, 7, 20, 1, 24, 702, DateTimeKind.Local).AddTicks(3039), 56, "", "https://antoine.org", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 5, 7, 9, 47, 34, 8, DateTimeKind.Local).AddTicks(2918), new DateTime(2020, 5, 7, 15, 16, 22, 736, DateTimeKind.Local).AddTicks(9389), new DateTime(2020, 5, 7, 15, 18, 43, 192, DateTimeKind.Local).AddTicks(7056), 72, "", "https://valentin.info", "aspernatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 5, 7, 11, 7, 8, 58, DateTimeKind.Local).AddTicks(2342), new DateTime(2020, 5, 7, 4, 25, 46, 952, DateTimeKind.Local).AddTicks(3494), new DateTime(2020, 5, 7, 16, 18, 30, 314, DateTimeKind.Local).AddTicks(3439), 73, "", "https://lucie.net", "quidem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 5, 6, 22, 57, 41, 975, DateTimeKind.Local).AddTicks(4163), new DateTime(2020, 5, 7, 18, 18, 59, 916, DateTimeKind.Local).AddTicks(803), new DateTime(2020, 5, 7, 17, 39, 38, 524, DateTimeKind.Local).AddTicks(2211), 74, "", "http://ambre.org", "autem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 5, 7, 19, 55, 37, 255, DateTimeKind.Local).AddTicks(651), new DateTime(2020, 5, 7, 14, 29, 0, 475, DateTimeKind.Local).AddTicks(8548), new DateTime(2020, 5, 6, 22, 10, 38, 877, DateTimeKind.Local).AddTicks(4312), 96, "", "https://baptiste.com", "saepe" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 5, 6, 22, 30, 53, 559, DateTimeKind.Local).AddTicks(6492), new DateTime(2020, 5, 7, 5, 1, 37, 321, DateTimeKind.Local).AddTicks(6980), new DateTime(2020, 5, 7, 12, 3, 30, 157, DateTimeKind.Local).AddTicks(3352), 96, "", "https://clément.fr", "ipsa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 5, 7, 3, 42, 27, 606, DateTimeKind.Local).AddTicks(8853), new DateTime(2020, 5, 7, 5, 9, 1, 908, DateTimeKind.Local).AddTicks(4669), new DateTime(2020, 5, 7, 5, 2, 53, 593, DateTimeKind.Local).AddTicks(3055), 95, "", "http://evan.name", "culpa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 5, 7, 7, 20, 7, 721, DateTimeKind.Local).AddTicks(9062), new DateTime(2020, 5, 6, 20, 46, 34, 608, DateTimeKind.Local).AddTicks(3802), new DateTime(2020, 5, 7, 2, 3, 48, 992, DateTimeKind.Local).AddTicks(502), 93, "", "http://alice.com", "eius" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 5, 6, 21, 31, 29, 546, DateTimeKind.Local).AddTicks(7915), new DateTime(2020, 5, 7, 1, 30, 53, 375, DateTimeKind.Local).AddTicks(3061), new DateTime(2020, 5, 6, 20, 33, 14, 882, DateTimeKind.Local).AddTicks(209), 92, "", "http://célia.com", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 5, 7, 5, 44, 52, 630, DateTimeKind.Local).AddTicks(3936), new DateTime(2020, 5, 7, 10, 54, 46, 227, DateTimeKind.Local).AddTicks(5185), new DateTime(2020, 5, 7, 13, 16, 10, 570, DateTimeKind.Local).AddTicks(8418), 92, "", "https://pierre.com", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 5, 7, 11, 32, 27, 995, DateTimeKind.Local).AddTicks(1580), new DateTime(2020, 5, 7, 16, 50, 19, 422, DateTimeKind.Local).AddTicks(6430), new DateTime(2020, 5, 6, 23, 35, 47, 710, DateTimeKind.Local).AddTicks(7337), 92, "", "https://benjamin.info", "aperiam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 5, 7, 12, 49, 33, 55, DateTimeKind.Local).AddTicks(5945), new DateTime(2020, 5, 7, 8, 26, 21, 632, DateTimeKind.Local).AddTicks(8125), new DateTime(2020, 5, 7, 5, 29, 12, 115, DateTimeKind.Local).AddTicks(457), 90, "", "https://zoe.com", "exercitationem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 5, 7, 1, 10, 21, 817, DateTimeKind.Local).AddTicks(4147), new DateTime(2020, 5, 6, 21, 15, 23, 696, DateTimeKind.Local).AddTicks(7747), new DateTime(2020, 5, 7, 4, 28, 22, 478, DateTimeKind.Local).AddTicks(6693), 90, "", "http://sacha.fr", "laudantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 5, 7, 8, 29, 47, 587, DateTimeKind.Local).AddTicks(6358), new DateTime(2020, 5, 6, 20, 29, 10, 509, DateTimeKind.Local).AddTicks(4833), new DateTime(2020, 5, 7, 16, 45, 20, 28, DateTimeKind.Local).AddTicks(5937), 89, "", "https://yanis.info", "perspiciatis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 5, 7, 9, 25, 28, 48, DateTimeKind.Local).AddTicks(7661), new DateTime(2020, 5, 7, 6, 59, 57, 844, DateTimeKind.Local).AddTicks(8585), new DateTime(2020, 5, 7, 8, 5, 24, 845, DateTimeKind.Local).AddTicks(8500), 89, "", "http://océane.fr", "totam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 5, 7, 4, 4, 22, 938, DateTimeKind.Local).AddTicks(646), new DateTime(2020, 5, 7, 9, 42, 31, 335, DateTimeKind.Local).AddTicks(6135), new DateTime(2020, 5, 7, 4, 47, 17, 838, DateTimeKind.Local).AddTicks(5647), 89, "", "http://noah.eu", "dolore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 5, 7, 9, 57, 32, 257, DateTimeKind.Local).AddTicks(6423), new DateTime(2020, 5, 6, 23, 54, 12, 292, DateTimeKind.Local).AddTicks(6409), new DateTime(2020, 5, 7, 2, 19, 24, 261, DateTimeKind.Local).AddTicks(1630), 89, "", "http://alexis.fr", "voluptatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 5, 6, 23, 35, 57, 160, DateTimeKind.Local).AddTicks(2122), new DateTime(2020, 5, 7, 6, 0, 51, 165, DateTimeKind.Local).AddTicks(5983), new DateTime(2020, 5, 7, 2, 24, 26, 701, DateTimeKind.Local).AddTicks(3603), 89, "", "https://anaïs.name", "atque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 5, 7, 9, 43, 51, 207, DateTimeKind.Local).AddTicks(2923), new DateTime(2020, 5, 7, 3, 50, 50, 785, DateTimeKind.Local).AddTicks(8966), new DateTime(2020, 5, 7, 10, 16, 26, 243, DateTimeKind.Local).AddTicks(5622), 88, "", "http://lilou.info", "magnam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 5, 7, 6, 48, 21, 790, DateTimeKind.Local).AddTicks(7530), new DateTime(2020, 5, 7, 19, 18, 25, 377, DateTimeKind.Local).AddTicks(7733), new DateTime(2020, 5, 7, 10, 0, 11, 243, DateTimeKind.Local).AddTicks(2382), 88, "", "http://alice.info", "itaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 5, 7, 8, 58, 31, 880, DateTimeKind.Local).AddTicks(372), new DateTime(2020, 5, 7, 13, 15, 20, 832, DateTimeKind.Local).AddTicks(3140), new DateTime(2020, 5, 7, 3, 45, 2, 346, DateTimeKind.Local).AddTicks(850), 88, "", "https://romain.fr", "dignissimos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 5, 7, 13, 0, 35, 203, DateTimeKind.Local).AddTicks(408), new DateTime(2020, 5, 7, 19, 37, 7, 186, DateTimeKind.Local).AddTicks(8583), new DateTime(2020, 5, 7, 11, 32, 51, 135, DateTimeKind.Local).AddTicks(7565), 85, "", "https://lilou.org", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 5, 6, 22, 13, 54, 890, DateTimeKind.Local).AddTicks(1174), new DateTime(2020, 5, 7, 7, 29, 4, 953, DateTimeKind.Local).AddTicks(1114), new DateTime(2020, 5, 6, 22, 22, 52, 792, DateTimeKind.Local).AddTicks(7335), 85, "", "https://alexandre.com", "architecto" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 5, 7, 18, 35, 6, 855, DateTimeKind.Local).AddTicks(5874), new DateTime(2020, 5, 7, 5, 30, 35, 611, DateTimeKind.Local).AddTicks(7085), new DateTime(2020, 5, 7, 8, 26, 19, 499, DateTimeKind.Local).AddTicks(5250), 85, "", "http://emilie.info", "nesciunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 5, 7, 6, 24, 46, 594, DateTimeKind.Local).AddTicks(9436), new DateTime(2020, 5, 7, 0, 1, 59, 584, DateTimeKind.Local).AddTicks(8066), new DateTime(2020, 5, 7, 6, 54, 24, 835, DateTimeKind.Local).AddTicks(1495), 80, "", "http://manon.org", "totam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 5, 6, 20, 31, 45, 485, DateTimeKind.Local).AddTicks(3488), new DateTime(2020, 5, 6, 23, 54, 46, 804, DateTimeKind.Local).AddTicks(7998), new DateTime(2020, 5, 7, 16, 35, 44, 248, DateTimeKind.Local).AddTicks(4164), 78, "", "https://manon.fr", "fugit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 5, 7, 12, 38, 55, 571, DateTimeKind.Local).AddTicks(6359), new DateTime(2020, 5, 7, 20, 9, 12, 879, DateTimeKind.Local).AddTicks(5825), new DateTime(2020, 5, 7, 16, 18, 24, 553, DateTimeKind.Local).AddTicks(5244), 78, "", "https://maëlys.org", "odio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 5, 7, 16, 10, 59, 410, DateTimeKind.Local).AddTicks(6791), new DateTime(2020, 5, 7, 8, 3, 24, 732, DateTimeKind.Local).AddTicks(8132), new DateTime(2020, 5, 7, 18, 48, 36, 930, DateTimeKind.Local).AddTicks(9418), 76, "", "https://maëlle.com", "sint" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 5, 7, 1, 36, 48, 675, DateTimeKind.Local).AddTicks(8661), new DateTime(2020, 5, 7, 9, 21, 5, 808, DateTimeKind.Local).AddTicks(1851), new DateTime(2020, 5, 7, 15, 41, 21, 128, DateTimeKind.Local).AddTicks(1784), 76, "", "https://chloé.name", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 5, 7, 1, 37, 32, 977, DateTimeKind.Local).AddTicks(5349), new DateTime(2020, 5, 7, 7, 27, 21, 32, DateTimeKind.Local).AddTicks(13), new DateTime(2020, 5, 7, 9, 55, 19, 995, DateTimeKind.Local).AddTicks(8356), 45, "", "http://anaïs.name", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 5, 7, 1, 34, 51, 935, DateTimeKind.Local).AddTicks(2824), new DateTime(2020, 5, 7, 1, 19, 13, 876, DateTimeKind.Local).AddTicks(5213), new DateTime(2020, 5, 6, 20, 58, 38, 455, DateTimeKind.Local).AddTicks(1467), 44, "", "http://charlotte.org", "earum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 5, 7, 20, 21, 37, 151, DateTimeKind.Local).AddTicks(1734), new DateTime(2020, 5, 7, 5, 16, 2, 459, DateTimeKind.Local).AddTicks(596), new DateTime(2020, 5, 6, 23, 14, 5, 294, DateTimeKind.Local).AddTicks(449), 100, "", "https://noa.eu", "architecto" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 5, 7, 3, 38, 21, 88, DateTimeKind.Local).AddTicks(7515), new DateTime(2020, 5, 7, 18, 15, 20, 456, DateTimeKind.Local).AddTicks(1126), new DateTime(2020, 5, 7, 12, 16, 54, 455, DateTimeKind.Local).AddTicks(9956), 40, "", "https://lina.info", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 5, 7, 0, 57, 16, 690, DateTimeKind.Local).AddTicks(356), new DateTime(2020, 5, 7, 10, 31, 38, 291, DateTimeKind.Local).AddTicks(5437), new DateTime(2020, 5, 7, 2, 41, 29, 65, DateTimeKind.Local).AddTicks(8229), 18, "", "http://quentin.org", "facilis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 5, 7, 6, 7, 28, 909, DateTimeKind.Local).AddTicks(4563), new DateTime(2020, 5, 7, 0, 33, 39, 63, DateTimeKind.Local).AddTicks(5544), new DateTime(2020, 5, 7, 19, 50, 11, 346, DateTimeKind.Local).AddTicks(1016), 17, "", "http://laura.net", "rerum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 5, 7, 18, 7, 38, 939, DateTimeKind.Local).AddTicks(6990), new DateTime(2020, 5, 7, 19, 41, 41, 326, DateTimeKind.Local).AddTicks(8406), new DateTime(2020, 5, 7, 12, 19, 7, 585, DateTimeKind.Local).AddTicks(5228), 14, "", "https://juliette.org", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 5, 7, 4, 22, 3, 114, DateTimeKind.Local).AddTicks(5010), new DateTime(2020, 5, 7, 17, 32, 47, 446, DateTimeKind.Local).AddTicks(9239), new DateTime(2020, 5, 7, 14, 40, 22, 608, DateTimeKind.Local).AddTicks(1604), 14, "", "https://noa.name", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 5, 6, 21, 10, 43, 909, DateTimeKind.Local).AddTicks(9990), new DateTime(2020, 5, 7, 0, 3, 33, 380, DateTimeKind.Local).AddTicks(6560), new DateTime(2020, 5, 7, 19, 48, 40, 90, DateTimeKind.Local).AddTicks(9597), 99, "", "https://jeanne.info", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 5, 7, 4, 42, 57, 210, DateTimeKind.Local).AddTicks(3964), new DateTime(2020, 5, 7, 7, 27, 10, 370, DateTimeKind.Local).AddTicks(5565), new DateTime(2020, 5, 7, 1, 58, 13, 681, DateTimeKind.Local).AddTicks(9459), 12, "", "http://quentin.name", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 5, 7, 12, 47, 7, 610, DateTimeKind.Local).AddTicks(2577), new DateTime(2020, 5, 7, 11, 7, 7, 106, DateTimeKind.Local).AddTicks(2909), new DateTime(2020, 5, 7, 3, 46, 0, 507, DateTimeKind.Local).AddTicks(2485), 12, "", "https://noa.org", "quam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 5, 7, 5, 21, 16, 277, DateTimeKind.Local).AddTicks(6784), new DateTime(2020, 5, 7, 0, 4, 38, 680, DateTimeKind.Local).AddTicks(4528), new DateTime(2020, 5, 7, 16, 6, 24, 54, DateTimeKind.Local).AddTicks(9506), 12, "", "https://sarah.eu", "itaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 5, 7, 17, 50, 15, 998, DateTimeKind.Local).AddTicks(4195), new DateTime(2020, 5, 7, 0, 30, 56, 742, DateTimeKind.Local).AddTicks(8269), new DateTime(2020, 5, 6, 21, 12, 47, 955, DateTimeKind.Local).AddTicks(8489), 19, "", "http://adrien.fr", "provident" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 5, 6, 23, 43, 23, 478, DateTimeKind.Local).AddTicks(8186), new DateTime(2020, 5, 7, 19, 38, 15, 420, DateTimeKind.Local).AddTicks(3480), new DateTime(2020, 5, 7, 7, 51, 7, 748, DateTimeKind.Local).AddTicks(4269), 12, "", "http://alexandre.eu", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 5, 7, 13, 25, 11, 922, DateTimeKind.Local).AddTicks(7203), new DateTime(2020, 5, 7, 11, 12, 28, 114, DateTimeKind.Local).AddTicks(6167), new DateTime(2020, 5, 7, 17, 47, 36, 994, DateTimeKind.Local).AddTicks(5198), 9, "", "https://noah.info", "vero" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 5, 7, 19, 37, 24, 70, DateTimeKind.Local).AddTicks(4542), new DateTime(2020, 5, 7, 16, 5, 0, 609, DateTimeKind.Local).AddTicks(8579), new DateTime(2020, 5, 7, 20, 2, 32, 542, DateTimeKind.Local).AddTicks(3387), 8, "", "https://mélissa.org", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 5, 7, 3, 14, 24, 180, DateTimeKind.Local).AddTicks(1889), new DateTime(2020, 5, 6, 21, 11, 6, 123, DateTimeKind.Local).AddTicks(1574), new DateTime(2020, 5, 7, 1, 15, 7, 312, DateTimeKind.Local).AddTicks(1478), 8, "", "http://ines.eu", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 5, 7, 13, 4, 25, 971, DateTimeKind.Local).AddTicks(908), new DateTime(2020, 5, 7, 9, 16, 32, 109, DateTimeKind.Local).AddTicks(4252), new DateTime(2020, 5, 7, 14, 51, 17, 593, DateTimeKind.Local).AddTicks(2483), 4, "", "https://romain.net", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 5, 7, 3, 3, 10, 657, DateTimeKind.Local).AddTicks(4785), new DateTime(2020, 5, 6, 20, 56, 30, 960, DateTimeKind.Local).AddTicks(8641), new DateTime(2020, 5, 6, 23, 56, 59, 520, DateTimeKind.Local).AddTicks(5217), 4, "", "https://louna.eu", "a" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 5, 7, 3, 37, 40, 547, DateTimeKind.Local).AddTicks(2038), new DateTime(2020, 5, 7, 12, 36, 25, 943, DateTimeKind.Local).AddTicks(1181), new DateTime(2020, 5, 7, 19, 59, 41, 704, DateTimeKind.Local).AddTicks(4064), 3, "", "http://louise.org", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 5, 7, 11, 14, 33, 390, DateTimeKind.Local).AddTicks(9076), new DateTime(2020, 5, 7, 3, 37, 12, 287, DateTimeKind.Local).AddTicks(3941), new DateTime(2020, 5, 7, 0, 20, 9, 598, DateTimeKind.Local).AddTicks(1866), 1, "", "http://maxence.org", "mollitia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 5, 7, 5, 56, 2, 818, DateTimeKind.Local).AddTicks(6208), new DateTime(2020, 5, 7, 14, 33, 36, 602, DateTimeKind.Local).AddTicks(795), new DateTime(2020, 5, 7, 0, 32, 11, 837, DateTimeKind.Local).AddTicks(6268), 1, "", "https://benjamin.net", "voluptate" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 5, 7, 20, 7, 0, 877, DateTimeKind.Local).AddTicks(8186), new DateTime(2020, 5, 7, 10, 42, 27, 277, DateTimeKind.Local).AddTicks(3474), new DateTime(2020, 5, 7, 2, 27, 17, 517, DateTimeKind.Local).AddTicks(5802), 9, "", "http://noah.org", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 5, 7, 18, 12, 31, 106, DateTimeKind.Local).AddTicks(3136), new DateTime(2020, 5, 7, 13, 36, 8, 863, DateTimeKind.Local).AddTicks(5601), new DateTime(2020, 5, 7, 19, 27, 8, 697, DateTimeKind.Local).AddTicks(375), 19, "", "https://théo.com", "incidunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 5, 7, 9, 9, 38, 858, DateTimeKind.Local).AddTicks(7115), new DateTime(2020, 5, 7, 8, 12, 20, 306, DateTimeKind.Local).AddTicks(6111), new DateTime(2020, 5, 7, 12, 1, 5, 446, DateTimeKind.Local).AddTicks(6160), 13, "", "https://célia.net", "quaerat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 5, 7, 11, 2, 0, 737, DateTimeKind.Local).AddTicks(1246), new DateTime(2020, 5, 7, 20, 3, 12, 785, DateTimeKind.Local).AddTicks(3114), new DateTime(2020, 5, 7, 3, 22, 43, 243, DateTimeKind.Local).AddTicks(4563), 20, "", "http://clément.net", "vitae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 5, 6, 23, 20, 26, 702, DateTimeKind.Local).AddTicks(7365), new DateTime(2020, 5, 7, 14, 31, 26, 494, DateTimeKind.Local).AddTicks(2361), new DateTime(2020, 5, 7, 14, 39, 54, 739, DateTimeKind.Local).AddTicks(5596), 40, "", "http://pierre.net", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 5, 7, 16, 36, 52, 738, DateTimeKind.Local).AddTicks(6257), new DateTime(2020, 5, 7, 14, 56, 39, 897, DateTimeKind.Local).AddTicks(4497), new DateTime(2020, 5, 7, 16, 44, 58, 617, DateTimeKind.Local).AddTicks(3437), 38, "", "http://nathan.com", "expedita" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 5, 7, 5, 56, 30, 237, DateTimeKind.Local).AddTicks(4710), new DateTime(2020, 5, 7, 12, 57, 45, 481, DateTimeKind.Local).AddTicks(9625), new DateTime(2020, 5, 6, 20, 55, 50, 559, DateTimeKind.Local).AddTicks(5796), 19, "", "http://marie.name", "vero" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 5, 7, 6, 20, 57, 958, DateTimeKind.Local).AddTicks(467), new DateTime(2020, 5, 7, 2, 29, 39, 707, DateTimeKind.Local).AddTicks(4272), new DateTime(2020, 5, 7, 19, 58, 11, 607, DateTimeKind.Local).AddTicks(2980), 37, "", "https://clémence.eu", "dignissimos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 5, 7, 2, 35, 2, 989, DateTimeKind.Local).AddTicks(2622), new DateTime(2020, 5, 7, 17, 27, 33, 268, DateTimeKind.Local).AddTicks(6534), new DateTime(2020, 5, 7, 2, 59, 45, 221, DateTimeKind.Local).AddTicks(6994), 36, "", "http://kylian.org", "iusto" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 5, 7, 6, 4, 9, 778, DateTimeKind.Local).AddTicks(6397), new DateTime(2020, 5, 7, 7, 39, 29, 170, DateTimeKind.Local).AddTicks(6344), new DateTime(2020, 5, 7, 10, 41, 59, 487, DateTimeKind.Local).AddTicks(8292), 36, "", "http://justine.fr", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 5, 6, 20, 27, 16, 652, DateTimeKind.Local).AddTicks(6752), new DateTime(2020, 5, 6, 23, 19, 56, 206, DateTimeKind.Local).AddTicks(1863), new DateTime(2020, 5, 7, 16, 37, 10, 576, DateTimeKind.Local).AddTicks(9616), 35, "", "https://romane.org", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 5, 6, 22, 25, 28, 368, DateTimeKind.Local).AddTicks(1860), new DateTime(2020, 5, 6, 21, 28, 41, 743, DateTimeKind.Local).AddTicks(4925), new DateTime(2020, 5, 7, 8, 49, 6, 270, DateTimeKind.Local).AddTicks(2170), 34, "", "https://hugo.name", "perspiciatis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 5, 7, 4, 30, 13, 626, DateTimeKind.Local).AddTicks(8040), new DateTime(2020, 5, 6, 23, 18, 6, 189, DateTimeKind.Local).AddTicks(5294), new DateTime(2020, 5, 7, 10, 25, 25, 6, DateTimeKind.Local).AddTicks(4134), 34, "", "http://sacha.org", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 5, 6, 22, 5, 36, 244, DateTimeKind.Local).AddTicks(2096), new DateTime(2020, 5, 7, 0, 44, 52, 27, DateTimeKind.Local).AddTicks(3063), new DateTime(2020, 5, 7, 7, 3, 6, 661, DateTimeKind.Local).AddTicks(5330), 37, "", "https://nathan.info", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 5, 7, 18, 46, 48, 424, DateTimeKind.Local).AddTicks(685), new DateTime(2020, 5, 7, 14, 36, 0, 121, DateTimeKind.Local).AddTicks(4968), new DateTime(2020, 5, 7, 18, 16, 37, 59, DateTimeKind.Local).AddTicks(9652), 33, "", "http://marie.eu", "unde" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 5, 7, 16, 0, 28, 986, DateTimeKind.Local).AddTicks(8742), new DateTime(2020, 5, 7, 12, 28, 24, 518, DateTimeKind.Local).AddTicks(4099), new DateTime(2020, 5, 6, 23, 37, 23, 698, DateTimeKind.Local).AddTicks(6603), 31, "", "http://maëlys.name", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 5, 6, 20, 36, 33, 304, DateTimeKind.Local).AddTicks(9211), new DateTime(2020, 5, 7, 14, 35, 43, 840, DateTimeKind.Local).AddTicks(8073), new DateTime(2020, 5, 7, 3, 37, 36, 422, DateTimeKind.Local).AddTicks(7044), 31, "", "http://nicolas.name", "similique" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 5, 7, 7, 45, 28, 326, DateTimeKind.Local).AddTicks(9219), new DateTime(2020, 5, 7, 2, 15, 33, 350, DateTimeKind.Local).AddTicks(1143), new DateTime(2020, 5, 6, 20, 43, 16, 700, DateTimeKind.Local).AddTicks(4881), 29, "", "http://lola.eu", "expedita" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 5, 6, 23, 11, 54, 883, DateTimeKind.Local).AddTicks(3799), new DateTime(2020, 5, 7, 7, 25, 37, 336, DateTimeKind.Local).AddTicks(9281), new DateTime(2020, 5, 6, 22, 17, 11, 64, DateTimeKind.Local).AddTicks(8685), 25, "", "https://arthur.name", "tempora" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 5, 7, 13, 34, 42, 721, DateTimeKind.Local).AddTicks(6283), new DateTime(2020, 5, 7, 5, 38, 21, 327, DateTimeKind.Local).AddTicks(6989), new DateTime(2020, 5, 7, 14, 57, 9, 294, DateTimeKind.Local).AddTicks(3187), 24, "", "http://jules.fr", "dignissimos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 5, 7, 12, 50, 3, 904, DateTimeKind.Local).AddTicks(8172), new DateTime(2020, 5, 6, 22, 38, 47, 703, DateTimeKind.Local).AddTicks(175), new DateTime(2020, 5, 7, 18, 12, 16, 170, DateTimeKind.Local).AddTicks(3577), 24, "", "http://jules.net", "ducimus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 5, 7, 10, 15, 47, 469, DateTimeKind.Local).AddTicks(6308), new DateTime(2020, 5, 7, 19, 19, 58, 300, DateTimeKind.Local).AddTicks(3119), new DateTime(2020, 5, 7, 3, 27, 48, 159, DateTimeKind.Local).AddTicks(3481), 23, "", "http://jules.net", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 5, 7, 18, 22, 37, 30, DateTimeKind.Local).AddTicks(2816), new DateTime(2020, 5, 7, 8, 39, 18, 598, DateTimeKind.Local).AddTicks(2527), new DateTime(2020, 5, 6, 22, 18, 56, 563, DateTimeKind.Local).AddTicks(1155), 21, "", "http://lilou.name", "assumenda" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 5, 7, 14, 51, 36, 973, DateTimeKind.Local).AddTicks(2753), new DateTime(2020, 5, 7, 12, 52, 56, 981, DateTimeKind.Local).AddTicks(9181), new DateTime(2020, 5, 7, 9, 14, 52, 91, DateTimeKind.Local).AddTicks(5500), 33, "", "https://jade.info", "sint" });

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
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 7, "0.9.6.8", "Examen périodique universal", 3, 4, 4, 2, 1, 6, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 72, "1.9.7.2", "Examen périodique universal", 3, 8, 3, 2, 8, 2, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 70, "5.6.0.4", "Examen périodique universal", 3, 4, 4, 1, 8, 3, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 69, "0.8.1.9", "Examen périodique universal", 2, 6, 6, 3, 8, 7, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 32, "6.7.6.2", "Procédure spéciale", 4, 5, 3, 2, 8, 8, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 18, "2.7.1.9", "Examen périodique universal", 2, 2, 5, 3, 8, 10, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 15, "1.8.7.1", "Procédure spéciale", 4, 4, 4, 1, 8, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 11, "8.7.9.5", "Procédure spéciale", 4, 3, 1, 4, 8, 3, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 10, "5.8.1.9", "Procédure spéciale", 4, 8, 1, 1, 8, 2, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 9, "2.6.8.8", "Examen périodique universal", 1, 2, 2, 4, 8, 6, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 1, "9.3.5.5", "Organes de traités", 1, 5, 2, 3, 8, 1, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 90, "6.5.4.6", "Organes de traités", 1, 2, 5, 2, 7, 8, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 89, "5.4.7.1", "Examen périodique universal", 3, 8, 2, 4, 7, 7, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 82, "9.9.5.1", "Organes de traités", 1, 10, 1, 2, 7, 7, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 80, "2.8.5.9", "Organes de traités", 4, 7, 3, 2, 7, 7, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 75, "9.7.7.1", "Examen périodique universal", 1, 2, 5, 3, 7, 4, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 67, "5.2.0.9", "Organes de traités", 3, 7, 6, 1, 7, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 58, "3.7.5.8", "Procédure spéciale", 1, 4, 6, 2, 7, 9, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 48, "6.3.6.2", "Procédure spéciale", 4, 1, 5, 1, 7, 3, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 47, "9.9.1.4", "Organes de traités", 2, 4, 6, 3, 7, 2, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 45, "2.5.4.2", "Organes de traités", 2, 5, 5, 1, 7, 5, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 28, "4.9.6.7", "Procédure spéciale", 1, 2, 5, 2, 7, 2, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 73, "9.3.9.4", "Examen périodique universal", 3, 5, 6, 3, 8, 4, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 91, "0.8.5.3", "Examen périodique universal", 1, 9, 5, 3, 8, 5, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 96, "6.5.8.5", "Organes de traités", 4, 9, 5, 3, 8, 5, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 4, "0.7.0.1", "Organes de traités", 4, 2, 4, 3, 9, 2, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 88, "7.7.1.0", "Organes de traités", 1, 9, 5, 1, 10, 9, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 81, "8.2.9.1", "Examen périodique universal", 1, 10, 1, 3, 10, 3, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 71, "5.7.9.8", "Procédure spéciale", 2, 8, 4, 2, 10, 7, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 52, "5.4.1.0", "Organes de traités", 3, 4, 5, 4, 10, 7, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 20, "7.2.3.7", "Examen périodique universal", 4, 2, 4, 3, 10, 10, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 16, "6.6.0.7", "Examen périodique universal", 2, 10, 1, 3, 10, 2, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 3, "4.7.2.8", "Procédure spéciale", 2, 2, 4, 2, 10, 4, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 97, "6.5.4.9", "Procédure spéciale", 4, 3, 6, 3, 9, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 94, "8.7.0.8", "Examen périodique universal", 2, 7, 6, 2, 9, 10, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 86, "9.5.2.2", "Procédure spéciale", 1, 6, 4, 4, 9, 9, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 22, "1.2.5.2", "Procédure spéciale", 2, 10, 3, 2, 7, 10, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 85, "7.0.6.8", "Examen périodique universal", 4, 3, 2, 3, 9, 5, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 59, "7.4.3.2", "Examen périodique universal", 2, 7, 3, 4, 9, 6, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 40, "5.9.5.2", "Procédure spéciale", 2, 6, 2, 1, 9, 1, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 38, "8.0.7.4", "Procédure spéciale", 1, 3, 2, 4, 9, 7, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 34, "1.7.5.5", "Procédure spéciale", 1, 6, 5, 2, 9, 10, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 31, "1.4.4.4", "Organes de traités", 4, 1, 1, 3, 9, 9, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 30, "6.5.3.8", "Organes de traités", 4, 4, 2, 4, 9, 6, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 23, "5.4.3.0", "Organes de traités", 1, 10, 6, 1, 9, 4, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 21, "8.7.9.5", "Procédure spéciale", 3, 6, 2, 4, 9, 10, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 17, "2.4.2.9", "Examen périodique universal", 2, 10, 6, 3, 9, 8, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 5, "5.5.2.3", "Organes de traités", 4, 4, 1, 1, 9, 4, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 64, "7.0.1.0", "Examen périodique universal", 4, 1, 1, 4, 9, 3, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 13, "6.9.5.2", "Procédure spéciale", 1, 1, 2, 1, 7, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 99, "0.5.4.4", "Examen périodique universal", 4, 4, 4, 2, 10, 4, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 77, "7.7.1.7", "Procédure spéciale", 4, 5, 4, 1, 6, 7, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 26, "8.7.6.2", "Procédure spéciale", 3, 7, 2, 3, 3, 6, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 76, "4.2.1.1", "Examen périodique universal", 4, 1, 5, 2, 2, 8, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 65, "8.9.0.5", "Procédure spéciale", 2, 5, 1, 3, 2, 8, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 51, "2.8.1.0", "Examen périodique universal", 4, 6, 1, 3, 2, 6, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 44, "0.1.7.6", "Procédure spéciale", 1, 2, 5, 1, 2, 6, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 39, "7.3.9.9", "Examen périodique universal", 2, 8, 3, 4, 2, 6, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 36, "3.2.0.0", "Procédure spéciale", 3, 2, 3, 3, 2, 6, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 29, "7.7.3.6", "Organes de traités", 3, 8, 2, 3, 2, 10, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 6, "6.1.7.4", "Organes de traités", 2, 7, 5, 4, 2, 1, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 2, "0.5.6.7", "Organes de traités", 1, 8, 4, 1, 2, 3, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 100, "9.3.1.6", "Procédure spéciale", 1, 10, 6, 3, 1, 4, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 98, "8.5.3.7", "Examen périodique universal", 4, 8, 1, 4, 1, 8, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 93, "7.1.1.7", "Procédure spéciale", 1, 2, 5, 3, 1, 10, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 87, "0.9.7.9", "Procédure spéciale", 3, 3, 2, 3, 1, 6, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 84, "3.2.7.1", "Organes de traités", 2, 7, 5, 3, 1, 3, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 83, "6.7.3.9", "Examen périodique universal", 3, 1, 5, 4, 1, 8, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 56, "1.8.9.6", "Organes de traités", 1, 7, 3, 3, 1, 1, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 50, "2.6.2.3", "Examen périodique universal", 3, 2, 2, 2, 1, 6, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 43, "2.4.5.5", "Organes de traités", 4, 2, 5, 1, 1, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 42, "7.0.8.4", "Procédure spéciale", 1, 6, 5, 2, 1, 1, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 12, "9.4.5.3", "Organes de traités", 4, 6, 5, 4, 7, 9, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 35, "3.3.8.7", "Organes de traités", 3, 7, 5, 3, 3, 1, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 55, "7.4.7.4", "Procédure spéciale", 2, 2, 6, 3, 3, 7, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 19, "6.9.9.1", "Organes de traités", 3, 8, 1, 4, 2, 9, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 78, "5.3.1.3", "Examen périodique universal", 2, 3, 4, 1, 3, 3, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 61, "6.1.9.8", "Examen périodique universal", 3, 2, 2, 4, 3, 7, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 62, "6.4.3.9", "Examen périodique universal", 3, 7, 1, 4, 6, 7, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 60, "2.6.2.8", "Organes de traités", 4, 7, 2, 2, 6, 3, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 53, "5.3.3.1", "Organes de traités", 2, 10, 6, 2, 6, 1, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 33, "3.9.6.5", "Procédure spéciale", 1, 5, 4, 1, 6, 4, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 25, "9.6.0.4", "Examen périodique universal", 3, 4, 6, 3, 6, 10, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 14, "5.3.8.4", "Organes de traités", 3, 4, 5, 1, 6, 8, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 66, "3.4.9.5", "Examen périodique universal", 3, 8, 6, 3, 5, 3, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 41, "9.9.4.0", "Examen périodique universal", 2, 1, 6, 4, 5, 3, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 37, "2.3.8.6", "Procédure spéciale", 4, 8, 1, 3, 5, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 24, "6.6.6.5", "Organes de traités", 2, 6, 1, 4, 5, 4, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 74, "0.6.9.0", "Examen périodique universal", 1, 1, 2, 2, 5, 4, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 63, "9.6.4.4", "Organes de traités", 4, 9, 1, 3, 6, 7, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 92, "3.9.9.5", "Examen périodique universal", 2, 6, 2, 4, 4, 8, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 95, "1.7.1.7", "Procédure spéciale", 2, 3, 1, 2, 3, 5, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 8, "6.9.3.0", "Examen périodique universal", 2, 3, 4, 4, 4, 8, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 27, "1.0.7.5", "Organes de traités", 2, 10, 1, 3, 4, 2, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 46, "3.0.8.9", "Examen périodique universal", 1, 9, 4, 1, 4, 7, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 79, "4.0.6.2", "Procédure spéciale", 4, 6, 3, 4, 3, 10, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 54, "8.7.5.2", "Examen périodique universal", 4, 2, 4, 1, 4, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 57, "8.3.7.9", "Organes de traités", 4, 10, 2, 1, 4, 7, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 68, "1.7.4.6", "Organes de traités", 2, 10, 4, 2, 4, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom" },
                values: new object[] { 49, "3.7.0.6", "Organes de traités", 1, 2, 4, 1, 4, 7, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 53, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 16, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "ut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 16, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "ut", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 93, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "reprehenderit", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 65, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "ducimus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 31, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "atque", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 98, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "corporis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 36, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "reprehenderit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 53, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "dolor", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 66, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "id", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 23, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "earum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 56, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "esse", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 56, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 61, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "tempore", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 30, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "error", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 30, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "nobis", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 30, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "at", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 76, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "neque", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 32, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "sit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 75, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "voluptates", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 16, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "rerum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 66, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "error", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 16, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "voluptatum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 9, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "minus", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 48, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "voluptas", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 23, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "illo", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 29, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "reiciendis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 40, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "commodi", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 92, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "rerum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 80, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "voluptatem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 80, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "labore", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 14, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "nulla", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 14, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "quia", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 50, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "fuga", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 49, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "consectetur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 48, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "aperiam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 73, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 73, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "sunt", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 73, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "reiciendis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 63, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "ipsam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 63, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "harum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 55, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "sed", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 55, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "quidem", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 46, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "quidem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 62, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "autem", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 42, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "animi", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 42, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "corrupti", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 73, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "dolore", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 6, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "eius", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 34, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "aliquid", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 13, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "quos", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 78, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "maiores", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 15, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "libero", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 28, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "iusto", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 96, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "illo", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 64, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "dolores", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 64, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "nesciunt", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 25, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "id", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 7, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "occaecati", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 24, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "sint", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 24, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "ut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 33, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 47, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "sed", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 20, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "ratione", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 12, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "sapiente", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 90, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "porro", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 90, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "harum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 84, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "placeat", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 84, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "voluptatem", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 97, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "non", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 86, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "facilis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 9, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "mollitia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 78, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "tempore", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 85, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "suscipit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 85, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "repudiandae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 69, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "vel", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 37, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "rerum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 10, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "nam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 10, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "quae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 10, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "magni", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 72, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "harum", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 67, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "molestiae", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 5, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "necessitatibus", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 5, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "alias", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 11, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "nam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 6, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "fugit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 11, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "est", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 99, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "at", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 19, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "natus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 54, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "odio", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 54, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 27, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "commodi", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 39, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "rerum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 52, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "eius", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 34, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "iusto", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 34, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "nostrum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 34, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "error", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 99, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "vero", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 26, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/sleek-plastic-hat", 2, 83 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/florida", 1, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/hdd/synthesizing/connect", 7, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/encoding", 3, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/northern-mariana-islands/strategy", 1, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/directives/self-enabling", 1, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/credit-card-account/tactics", 6, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/dam/payment", 5, 13 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/solutions/handmade-fresh-car", 7, 13 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/bolivia/refined/steel", 2, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/plains/rustic", 6, 38 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/bedfordshire", 3, 38 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/ergonomic/locks/garden-outdoors--music", 5, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/incredible-metal-tuna/invoice/247", 4, 15 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/bandwidth", 4, 15 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/communities/strategic/direct", 4, 34 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/parse", 7, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/money-market-account/intuitive", 3, 40 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/gorgeous-wooden-towels/relationships/networked", 6, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/assimilated/back-end", 7, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/cross-group/payment/mint-green", 6, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/practical/avon/lithuanian-litas", 1, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/application/sports-health--baby", 7, 87 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/forges/granite", 7, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/outdoors--sports/electronics--sports/steel", 5, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/quality/bypass", 6, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/connect", 2, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/fantastic-cotton-fish", 2, 82 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/accounts/bedfordshire/jewelery", 4, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/outdoors/cutting-edge", 5, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/monitoring/tan/hard-drive", 5, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/thx", 3, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/zero-defect/sdd", 6, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/avon", 6, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/engineer/buckinghamshire", 5, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/bypass", 6, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/swaziland", 1, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/strategist", 1, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/violet", 7, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/china", 4, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/glen/bhutan", 3, 52 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/cutting-edge/clothing--toys", 3, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/tan", 2, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/berkshire/rustic-granite-pizza/open-source", 4, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/syrian-pound", 6, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/transform", 3, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/port", 1, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/borders/rustic/causeway", 7, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/ivory", 2, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/withdrawal/strategize", 7, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/hacking/coherent", 1, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/nevada", 2, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/ergonomic-fresh-gloves/indexing", 5, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/monitor/firewall/uic-franc", 4, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/efficient", 5, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/green/methodical", 6, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/malagasy-ariary", 5, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/e-markets", 6, 96 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/regional/payment/integrated", 3, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/plastic/intelligent-concrete-chips", 5, 61 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/new-zealand/blue/agp", 7, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/cambridgeshire", 4, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/xml", 3, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/logistical/optimal/division", 1, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/oregon/tunisia/frozen", 4, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/field/metal/feed", 4, 42 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/matrix", 1, 42 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/plastic/rustic-soft-pizza", 5, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/compelling", 3, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/buckinghamshire/grid-enabled", 5, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/unbranded-cotton-bike", 1, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/bedfordshire", 6, 28 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/intuitive", 7, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/synergy/factors", 6, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/seamless/initiative/executive", 2, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/incubate", 2, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/value-added/borders/coordinator", 5, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/salmon", 6, 100 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/accountability", 4, 100 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/input/canadian-dollar", 4, 100 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/new-mexico/auto-loan-account", 3, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/pci", 1, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/customer-loyalty/generating", 7, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/gb/uic-franc/internet-solution", 4, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/flexibility/front-end/summit", 6, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/morph", 2, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/manager/lights/primary", 1, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/systems/dynamic", 1, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/pine/sexy", 6, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/global/cutting-edge/deposit", 2, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/explicit/awesome-steel-shoes", 6, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/lead", 1, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/violet/small-concrete-cheese", 4, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/copying/gold/drive", 1, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/refined", 6, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/channels/overriding", 3, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/mobile/gold", 7, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/revolutionize/tasty-concrete-mouse/configurable", 2, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/oregon/card/haptic", 1, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/capacitor/mountains/auxiliary", 5, 28 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 4, new DateTime(2020, 1, 31, 7, 45, 24, 726, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 1, new DateTime(2019, 12, 2, 21, 37, 55, 769, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 2, new DateTime(2019, 7, 3, 19, 18, 35, 112, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 3, new DateTime(2019, 9, 11, 19, 9, 38, 505, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 3, new DateTime(2019, 8, 2, 14, 17, 28, 111, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 4, new DateTime(2019, 9, 3, 13, 26, 44, 826, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 3, new DateTime(2020, 1, 13, 21, 26, 52, 501, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 1, new DateTime(2019, 11, 6, 16, 42, 9, 690, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 4, new DateTime(2019, 5, 22, 8, 36, 45, 210, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 2, new DateTime(2019, 7, 2, 21, 45, 58, 844, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 4, new DateTime(2019, 5, 13, 23, 57, 46, 918, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 4, new DateTime(2020, 2, 23, 2, 21, 21, 387, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 4, new DateTime(2020, 1, 9, 14, 33, 47, 517, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 6, new DateTime(2019, 10, 12, 5, 29, 30, 165, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 2, new DateTime(2020, 3, 14, 17, 0, 18, 349, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 1, new DateTime(2020, 2, 27, 0, 37, 29, 16, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 1, new DateTime(2019, 7, 7, 18, 46, 34, 802, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 3, new DateTime(2020, 4, 6, 17, 11, 50, 599, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 6, new DateTime(2019, 12, 10, 4, 45, 46, 11, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 5, new DateTime(2020, 5, 5, 4, 45, 28, 344, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 5, new DateTime(2019, 9, 2, 21, 1, 19, 691, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 1, new DateTime(2019, 11, 16, 17, 8, 18, 959, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 1, new DateTime(2019, 12, 9, 12, 10, 21, 673, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 2, new DateTime(2019, 6, 2, 2, 52, 3, 57, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 5, new DateTime(2020, 1, 31, 7, 56, 12, 199, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 5, new DateTime(2019, 7, 24, 16, 10, 47, 780, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 1, new DateTime(2020, 3, 30, 12, 21, 55, 181, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 1, new DateTime(2020, 1, 5, 0, 40, 29, 473, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 4, new DateTime(2020, 1, 8, 0, 54, 42, 482, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 3, new DateTime(2019, 5, 6, 21, 51, 59, 711, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 1, new DateTime(2019, 7, 2, 1, 35, 42, 350, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 6, new DateTime(2019, 6, 8, 23, 5, 46, 914, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 2, new DateTime(2019, 8, 30, 15, 26, 15, 894, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 2, new DateTime(2020, 3, 1, 9, 28, 52, 648, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 4, new DateTime(2019, 7, 5, 0, 34, 4, 364, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 6, new DateTime(2020, 2, 6, 16, 32, 3, 969, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 2, new DateTime(2019, 9, 9, 22, 47, 27, 665, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 3, new DateTime(2019, 5, 24, 20, 17, 43, 23, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 5, new DateTime(2019, 11, 2, 5, 22, 39, 213, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 2, new DateTime(2019, 7, 15, 4, 41, 3, 439, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 6, new DateTime(2019, 6, 22, 0, 48, 31, 635, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 4, new DateTime(2020, 1, 4, 8, 9, 52, 941, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 5, new DateTime(2020, 4, 16, 0, 26, 1, 412, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 2, new DateTime(2020, 4, 27, 6, 33, 3, 666, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 5, new DateTime(2020, 1, 9, 16, 12, 0, 63, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 1, new DateTime(2020, 1, 14, 9, 51, 51, 527, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 5, new DateTime(2020, 2, 5, 1, 15, 34, 585, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 1, new DateTime(2019, 11, 9, 3, 2, 18, 850, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 1, new DateTime(2020, 4, 17, 2, 3, 4, 313, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 5, new DateTime(2019, 11, 25, 5, 56, 4, 595, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 3, new DateTime(2020, 4, 27, 16, 0, 29, 536, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 5, new DateTime(2019, 6, 28, 16, 4, 34, 303, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 5, new DateTime(2019, 6, 18, 0, 53, 21, 718, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 3, new DateTime(2019, 9, 24, 8, 39, 2, 48, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 5, new DateTime(2019, 12, 4, 3, 10, 8, 772, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 6, new DateTime(2020, 2, 23, 4, 50, 18, 306, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 1, new DateTime(2019, 10, 28, 4, 25, 41, 558, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 1, new DateTime(2020, 1, 29, 3, 6, 8, 398, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 4, new DateTime(2019, 9, 3, 21, 14, 19, 653, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 5, new DateTime(2020, 2, 12, 21, 3, 47, 985, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 4, new DateTime(2020, 3, 13, 21, 51, 50, 295, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 4, new DateTime(2020, 1, 21, 3, 43, 31, 673, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 4, new DateTime(2019, 7, 16, 8, 7, 37, 487, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 4, new DateTime(2020, 2, 13, 2, 27, 47, 700, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 2, new DateTime(2019, 5, 12, 0, 19, 35, 224, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 4, new DateTime(2019, 12, 26, 2, 7, 54, 805, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 5, new DateTime(2019, 10, 23, 12, 37, 44, 106, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 1, new DateTime(2019, 5, 29, 20, 30, 18, 325, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 1, new DateTime(2020, 4, 14, 12, 27, 40, 153, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 5, new DateTime(2019, 7, 25, 11, 8, 49, 492, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 6, new DateTime(2019, 5, 7, 1, 45, 17, 372, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 2, new DateTime(2019, 6, 18, 9, 18, 8, 905, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 5, new DateTime(2020, 1, 18, 1, 46, 49, 632, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 4, new DateTime(2020, 4, 17, 3, 33, 47, 177, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 3, new DateTime(2019, 9, 30, 11, 34, 5, 418, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 2, new DateTime(2019, 7, 7, 10, 11, 45, 218, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 6, new DateTime(2020, 3, 6, 14, 33, 10, 578, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 2, new DateTime(2020, 1, 20, 13, 50, 49, 211, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 2, new DateTime(2019, 7, 23, 3, 41, 53, 909, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 2, new DateTime(2019, 9, 6, 8, 15, 29, 784, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 5, new DateTime(2019, 9, 27, 13, 49, 48, 406, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 3, new DateTime(2020, 1, 8, 5, 55, 38, 428, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 6, new DateTime(2019, 11, 25, 1, 14, 16, 665, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 4, new DateTime(2019, 10, 2, 0, 25, 38, 378, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 4, new DateTime(2019, 5, 21, 19, 37, 26, 420, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 1, new DateTime(2019, 10, 12, 4, 47, 29, 837, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 5, new DateTime(2019, 8, 15, 1, 8, 24, 69, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 5, new DateTime(2019, 7, 4, 3, 15, 23, 243, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 6, new DateTime(2020, 1, 25, 1, 55, 47, 922, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 5, new DateTime(2020, 2, 4, 2, 57, 33, 660, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 1, new DateTime(2019, 8, 19, 19, 52, 32, 185, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 4, new DateTime(2019, 9, 17, 5, 36, 27, 311, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 3, new DateTime(2019, 5, 25, 12, 7, 52, 10, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 5, new DateTime(2019, 9, 15, 12, 0, 27, 962, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 3, new DateTime(2020, 2, 10, 1, 22, 8, 203, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 1, new DateTime(2019, 8, 1, 15, 27, 4, 341, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 6, new DateTime(2020, 2, 18, 23, 34, 38, 334, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 4, new DateTime(2019, 5, 23, 23, 8, 56, 363, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 4, new DateTime(2019, 11, 10, 11, 5, 42, 817, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 4, new DateTime(2019, 10, 26, 19, 2, 14, 424, DateTimeKind.Local).AddTicks(6073) });

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
