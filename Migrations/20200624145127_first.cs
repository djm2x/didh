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
                values: new object[] { 10, "Categorie 1", new DateTime(2019, 8, 22, 0, 47, 47, 21, DateTimeKind.Local).AddTicks(4557), "qui", "officia" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 9, "Categorie 1", new DateTime(2019, 8, 18, 0, 50, 7, 495, DateTimeKind.Local).AddTicks(6865), "ab", "officiis" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 8, "Categorie 1", new DateTime(2019, 7, 2, 21, 57, 10, 326, DateTimeKind.Local).AddTicks(556), "animi", "eos" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 7, "Categorie 1", new DateTime(2020, 2, 29, 8, 1, 49, 252, DateTimeKind.Local).AddTicks(4859), "quae", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 6, "Categorie 1", new DateTime(2019, 12, 25, 22, 16, 54, 332, DateTimeKind.Local).AddTicks(3430), "cumque", "molestiae" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 4, "Categorie 1", new DateTime(2020, 6, 14, 20, 21, 17, 108, DateTimeKind.Local).AddTicks(9690), "corporis", "eius" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 3, "Categorie 1", new DateTime(2020, 4, 9, 23, 40, 11, 905, DateTimeKind.Local).AddTicks(3109), "voluptatem", "natus" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 2, "Categorie 1", new DateTime(2019, 8, 31, 20, 31, 52, 148, DateTimeKind.Local).AddTicks(1225), "minus", "eum" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 1, "Categorie 1", new DateTime(2020, 2, 20, 14, 15, 28, 488, DateTimeKind.Local).AddTicks(7493), "consectetur", "quisquam" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 5, "Categorie 1", new DateTime(2020, 4, 30, 0, 54, 28, 567, DateTimeKind.Local).AddTicks(3652), "eum", "non" });

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
                values: new object[] { 73, new DateTime(2020, 1, 3, 13, 13, 49, 769, DateTimeKind.Local).AddTicks(5451), "1,2,6", 73, 4, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2019, 10, 19, 12, 7, 48, 833, DateTimeKind.Local).AddTicks(7934), "0,3,4", 72, 3, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2019, 12, 7, 10, 10, 52, 991, DateTimeKind.Local).AddTicks(7779), "0,2,5", 71, 1, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2019, 9, 23, 12, 58, 38, 495, DateTimeKind.Local).AddTicks(594), "1,3,5", 70, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2020, 4, 15, 5, 54, 57, 912, DateTimeKind.Local).AddTicks(671), "0,3,6", 69, 5, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2019, 12, 6, 0, 27, 38, 599, DateTimeKind.Local).AddTicks(3488), "1,2,5", 68, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2020, 1, 1, 18, 14, 4, 18, DateTimeKind.Local).AddTicks(3190), "1,3,5", 67, 5, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2019, 8, 23, 22, 7, 44, 993, DateTimeKind.Local).AddTicks(473), "0,2,5", 66, 2, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2020, 6, 22, 1, 35, 20, 550, DateTimeKind.Local).AddTicks(9589), "1,2,4", 65, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2020, 5, 20, 6, 5, 8, 938, DateTimeKind.Local).AddTicks(8365), "0,3,6", 64, 1, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2019, 12, 7, 20, 13, 41, 606, DateTimeKind.Local).AddTicks(2175), "0,3,6", 63, 3, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2019, 10, 3, 17, 36, 49, 129, DateTimeKind.Local).AddTicks(7629), "1,3,5", 61, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2019, 11, 9, 23, 28, 49, 293, DateTimeKind.Local).AddTicks(5078), "1,2,4", 60, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2020, 2, 22, 5, 7, 23, 582, DateTimeKind.Local).AddTicks(5246), "1,2,4", 59, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2019, 8, 26, 8, 48, 0, 731, DateTimeKind.Local).AddTicks(9727), "0,2,6", 58, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2019, 10, 31, 6, 15, 31, 835, DateTimeKind.Local).AddTicks(604), "0,3,5", 57, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2020, 4, 5, 15, 16, 26, 259, DateTimeKind.Local).AddTicks(8436), "0,2,6", 56, 2, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2020, 5, 5, 6, 19, 24, 139, DateTimeKind.Local).AddTicks(8512), "0,2,5", 55, 1, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2019, 10, 10, 7, 53, 58, 588, DateTimeKind.Local).AddTicks(4133), "1,2,5", 54, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2020, 3, 24, 3, 23, 53, 935, DateTimeKind.Local).AddTicks(2805), "1,2,5", 53, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2020, 5, 15, 1, 28, 46, 133, DateTimeKind.Local).AddTicks(4043), "0,3,6", 74, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2019, 9, 5, 2, 24, 45, 77, DateTimeKind.Local).AddTicks(6621), "0,3,6", 62, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2019, 11, 27, 13, 51, 16, 948, DateTimeKind.Local).AddTicks(2288), "1,3,5", 75, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2020, 1, 2, 0, 49, 6, 391, DateTimeKind.Local).AddTicks(4545), "1,3,4", 93, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2020, 1, 12, 3, 59, 55, 133, DateTimeKind.Local).AddTicks(5103), "0,2,6", 77, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2019, 7, 9, 4, 30, 54, 723, DateTimeKind.Local).AddTicks(5160), "0,3,5", 100, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2019, 9, 16, 18, 1, 0, 240, DateTimeKind.Local).AddTicks(1029), "1,2,5", 99, 3, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2019, 12, 1, 22, 43, 18, 533, DateTimeKind.Local).AddTicks(3479), "1,2,6", 98, 1, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2019, 9, 24, 6, 17, 12, 370, DateTimeKind.Local).AddTicks(3112), "1,2,5", 97, 2, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2020, 2, 13, 0, 19, 37, 811, DateTimeKind.Local).AddTicks(712), "0,2,5", 96, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2019, 10, 14, 4, 10, 45, 672, DateTimeKind.Local).AddTicks(9305), "1,2,4", 95, 5, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2020, 1, 2, 23, 57, 1, 372, DateTimeKind.Local).AddTicks(7587), "0,2,5", 94, 2, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2020, 1, 29, 20, 33, 1, 241, DateTimeKind.Local).AddTicks(9475), "0,2,4", 52, 2, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2019, 8, 31, 16, 13, 39, 389, DateTimeKind.Local).AddTicks(7247), "1,2,4", 92, 6, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2019, 10, 20, 3, 49, 13, 805, DateTimeKind.Local).AddTicks(9392), "1,3,5", 91, 2, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2019, 9, 20, 22, 14, 56, 262, DateTimeKind.Local).AddTicks(245), "0,2,5", 76, 6, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2019, 12, 13, 21, 58, 0, 946, DateTimeKind.Local).AddTicks(1377), "1,3,5", 90, 2, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2019, 9, 23, 20, 46, 16, 266, DateTimeKind.Local).AddTicks(6437), "1,2,4", 88, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2019, 6, 27, 18, 53, 40, 668, DateTimeKind.Local).AddTicks(4390), "1,3,5", 87, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2020, 2, 29, 14, 55, 23, 632, DateTimeKind.Local).AddTicks(3590), "0,3,6", 86, 3, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2020, 2, 1, 14, 54, 46, 310, DateTimeKind.Local).AddTicks(889), "1,3,6", 85, 3, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2019, 9, 24, 17, 57, 13, 937, DateTimeKind.Local).AddTicks(2913), "1,2,6", 83, 5, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2019, 10, 27, 17, 8, 42, 773, DateTimeKind.Local).AddTicks(4764), "0,3,4", 82, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2019, 12, 13, 19, 9, 50, 651, DateTimeKind.Local).AddTicks(548), "1,2,4", 81, 4, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2019, 8, 5, 17, 20, 39, 729, DateTimeKind.Local).AddTicks(8329), "1,2,4", 80, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2020, 2, 9, 17, 49, 28, 795, DateTimeKind.Local).AddTicks(5686), "1,3,5", 79, 4, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2020, 5, 25, 10, 17, 3, 216, DateTimeKind.Local).AddTicks(8624), "1,2,4", 78, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2019, 9, 27, 21, 0, 17, 559, DateTimeKind.Local).AddTicks(4478), "0,3,4", 89, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2019, 12, 10, 20, 30, 12, 164, DateTimeKind.Local).AddTicks(6085), "0,3,4", 51, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2019, 7, 5, 8, 27, 43, 819, DateTimeKind.Local).AddTicks(7816), "1,2,6", 84, 1, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2020, 1, 12, 0, 24, 33, 540, DateTimeKind.Local).AddTicks(7649), "1,3,5", 49, 6, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2020, 1, 19, 11, 52, 59, 503, DateTimeKind.Local).AddTicks(7229), "0,3,5", 22, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2019, 12, 23, 18, 54, 44, 975, DateTimeKind.Local).AddTicks(7682), "1,2,6", 21, 2, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2020, 2, 13, 7, 30, 4, 150, DateTimeKind.Local).AddTicks(4926), "0,2,5", 20, 6, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2020, 2, 20, 3, 57, 42, 698, DateTimeKind.Local).AddTicks(4922), "1,3,6", 19, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2019, 9, 4, 22, 26, 35, 619, DateTimeKind.Local).AddTicks(7594), "0,3,6", 18, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2020, 1, 27, 13, 42, 15, 274, DateTimeKind.Local).AddTicks(4728), "0,3,4", 17, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2020, 4, 21, 5, 53, 43, 667, DateTimeKind.Local).AddTicks(5680), "0,2,6", 15, 3, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2019, 11, 6, 5, 43, 5, 972, DateTimeKind.Local).AddTicks(102), "0,2,6", 14, 2, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2019, 7, 5, 8, 4, 34, 617, DateTimeKind.Local).AddTicks(4999), "1,2,5", 13, 5, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2020, 5, 6, 3, 21, 49, 766, DateTimeKind.Local).AddTicks(5991), "1,2,6", 12, 1, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 4, 10, 10, 47, 2, 499, DateTimeKind.Local).AddTicks(749), "1,2,5", 23, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2019, 8, 22, 13, 43, 39, 989, DateTimeKind.Local).AddTicks(8301), "0,3,4", 11, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2019, 12, 12, 23, 13, 30, 142, DateTimeKind.Local).AddTicks(4328), "1,3,6", 9, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2019, 7, 4, 22, 17, 46, 6, DateTimeKind.Local).AddTicks(315), "0,2,4", 8, 6, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2019, 8, 29, 23, 57, 25, 79, DateTimeKind.Local).AddTicks(8576), "1,2,4", 7, 3, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2019, 8, 21, 20, 12, 55, 708, DateTimeKind.Local).AddTicks(9326), "1,3,5", 6, 5, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2019, 11, 6, 8, 1, 7, 923, DateTimeKind.Local).AddTicks(2095), "1,2,4", 5, 4, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2020, 6, 1, 9, 6, 42, 74, DateTimeKind.Local).AddTicks(7927), "0,3,5", 4, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2019, 12, 11, 1, 37, 23, 945, DateTimeKind.Local).AddTicks(2803), "1,3,6", 3, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2019, 8, 16, 1, 2, 36, 512, DateTimeKind.Local).AddTicks(8954), "0,3,5", 2, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2019, 11, 18, 13, 42, 23, 270, DateTimeKind.Local).AddTicks(7406), "0,2,5", 1, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2019, 6, 27, 17, 50, 44, 991, DateTimeKind.Local).AddTicks(3086), "1,3,6", 50, 1, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2019, 6, 30, 16, 28, 57, 687, DateTimeKind.Local).AddTicks(8388), "0,3,6", 10, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2019, 11, 18, 4, 47, 49, 682, DateTimeKind.Local).AddTicks(4763), "0,3,5", 24, 1, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2019, 12, 18, 19, 31, 5, 815, DateTimeKind.Local).AddTicks(7899), "0,3,5", 16, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2019, 10, 2, 18, 19, 21, 495, DateTimeKind.Local).AddTicks(1215), "1,2,4", 26, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2020, 1, 10, 12, 7, 25, 720, DateTimeKind.Local).AddTicks(849), "1,2,6", 48, 2, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2020, 6, 13, 9, 7, 10, 702, DateTimeKind.Local).AddTicks(3761), "1,3,5", 47, 1, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2020, 4, 12, 16, 19, 52, 909, DateTimeKind.Local).AddTicks(9864), "0,3,6", 46, 1, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2019, 7, 11, 3, 7, 39, 946, DateTimeKind.Local).AddTicks(4951), "0,2,6", 25, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2020, 6, 16, 1, 54, 10, 733, DateTimeKind.Local).AddTicks(7990), "1,3,5", 44, 4, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2019, 10, 22, 11, 51, 37, 286, DateTimeKind.Local).AddTicks(4326), "0,3,6", 43, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2019, 11, 18, 8, 56, 14, 555, DateTimeKind.Local).AddTicks(9328), "0,3,5", 42, 2, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2020, 2, 21, 19, 53, 15, 88, DateTimeKind.Local).AddTicks(8207), "0,2,4", 41, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2019, 8, 9, 22, 23, 6, 271, DateTimeKind.Local).AddTicks(5970), "1,3,6", 40, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2019, 7, 27, 7, 51, 47, 435, DateTimeKind.Local).AddTicks(5600), "1,2,5", 39, 4, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2020, 3, 6, 5, 38, 20, 408, DateTimeKind.Local).AddTicks(5763), "0,3,4", 38, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2020, 4, 14, 6, 21, 44, 587, DateTimeKind.Local).AddTicks(4495), "1,3,6", 37, 3, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2019, 9, 12, 1, 29, 25, 199, DateTimeKind.Local).AddTicks(3919), "1,3,6", 45, 4, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2019, 8, 29, 17, 3, 14, 13, DateTimeKind.Local).AddTicks(4962), "1,2,4", 35, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2019, 11, 28, 0, 20, 43, 393, DateTimeKind.Local).AddTicks(1560), "1,2,5", 34, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2020, 4, 8, 5, 46, 2, 714, DateTimeKind.Local).AddTicks(2052), "0,2,4", 33, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2019, 12, 20, 11, 33, 38, 938, DateTimeKind.Local).AddTicks(1515), "1,2,4", 27, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2019, 7, 16, 1, 57, 36, 317, DateTimeKind.Local).AddTicks(6899), "0,2,6", 32, 4, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2019, 7, 16, 1, 21, 14, 554, DateTimeKind.Local).AddTicks(2642), "0,3,5", 31, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2019, 6, 30, 19, 53, 55, 338, DateTimeKind.Local).AddTicks(9906), "0,3,4", 30, 2, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2019, 9, 29, 7, 28, 57, 182, DateTimeKind.Local).AddTicks(8209), "1,3,5", 29, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2019, 11, 23, 5, 5, 35, 585, DateTimeKind.Local).AddTicks(7365), "1,2,6", 28, 3, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2020, 3, 10, 2, 53, 10, 783, DateTimeKind.Local).AddTicks(9430), "0,3,6", 36, 2, "Nouveau traité a été ajoutée", 2, "traite", true });

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
                values: new object[] { 15, "", "sous theme 15", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 14, "", "sous theme 14", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 13, "", "sous theme 13", "Droits thématiques" });

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
                values: new object[] { 66, "", "", new DateTime(2019, 12, 28, 0, 44, 8, 679, DateTimeKind.Local).AddTicks(8474), new DateTime(2020, 4, 21, 22, 9, 31, 452, DateTimeKind.Local).AddTicks(8353), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 67, "", "", new DateTime(2019, 8, 30, 20, 37, 52, 702, DateTimeKind.Local).AddTicks(4949), new DateTime(2020, 6, 22, 14, 44, 32, 404, DateTimeKind.Local).AddTicks(5622), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 68, "", "", new DateTime(2019, 10, 8, 3, 3, 6, 121, DateTimeKind.Local).AddTicks(541), new DateTime(2020, 1, 13, 5, 36, 39, 68, DateTimeKind.Local).AddTicks(2712), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 69, "", "", new DateTime(2019, 10, 10, 3, 41, 6, 97, DateTimeKind.Local).AddTicks(7471), new DateTime(2019, 12, 10, 23, 55, 35, 895, DateTimeKind.Local).AddTicks(1291), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 72, "", "", new DateTime(2019, 9, 26, 9, 5, 23, 648, DateTimeKind.Local).AddTicks(678), new DateTime(2019, 8, 4, 8, 11, 33, 955, DateTimeKind.Local).AddTicks(2248), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 71, "", "", new DateTime(2019, 11, 5, 4, 54, 47, 331, DateTimeKind.Local).AddTicks(3866), new DateTime(2020, 3, 14, 2, 23, 15, 699, DateTimeKind.Local).AddTicks(1837), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 65, "", "", new DateTime(2019, 9, 15, 20, 43, 38, 872, DateTimeKind.Local).AddTicks(3291), new DateTime(2019, 9, 7, 20, 2, 42, 544, DateTimeKind.Local).AddTicks(3925), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 73, "", "", new DateTime(2020, 2, 6, 5, 39, 3, 158, DateTimeKind.Local).AddTicks(5076), new DateTime(2019, 8, 21, 23, 59, 49, 245, DateTimeKind.Local).AddTicks(7250), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 74, "", "", new DateTime(2019, 11, 28, 21, 53, 54, 295, DateTimeKind.Local).AddTicks(8748), new DateTime(2020, 5, 23, 10, 30, 23, 838, DateTimeKind.Local).AddTicks(3957), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 70, "", "", new DateTime(2019, 12, 10, 15, 40, 46, 292, DateTimeKind.Local).AddTicks(2442), new DateTime(2019, 7, 3, 6, 2, 51, 508, DateTimeKind.Local).AddTicks(5904), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 64, "", "", new DateTime(2019, 11, 21, 19, 49, 10, 24, DateTimeKind.Local).AddTicks(5961), new DateTime(2020, 1, 7, 9, 39, 49, 938, DateTimeKind.Local).AddTicks(716), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 62, "", "", new DateTime(2019, 12, 18, 5, 28, 39, 9, DateTimeKind.Local).AddTicks(6261), new DateTime(2019, 7, 7, 14, 7, 48, 967, DateTimeKind.Local).AddTicks(2564), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 53, "", "", new DateTime(2020, 1, 30, 21, 38, 20, 482, DateTimeKind.Local).AddTicks(647), new DateTime(2020, 1, 29, 13, 31, 26, 649, DateTimeKind.Local).AddTicks(4810), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 61, "", "", new DateTime(2020, 1, 17, 14, 59, 6, 461, DateTimeKind.Local).AddTicks(4054), new DateTime(2019, 9, 7, 20, 34, 39, 811, DateTimeKind.Local).AddTicks(4748), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 60, "", "", new DateTime(2020, 5, 12, 11, 6, 31, 439, DateTimeKind.Local).AddTicks(6041), new DateTime(2020, 6, 11, 1, 25, 55, 412, DateTimeKind.Local).AddTicks(50), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 59, "", "", new DateTime(2020, 5, 6, 0, 46, 35, 40, DateTimeKind.Local).AddTicks(7363), new DateTime(2019, 7, 13, 9, 51, 53, 779, DateTimeKind.Local).AddTicks(3169), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 58, "", "", new DateTime(2020, 2, 22, 16, 55, 54, 985, DateTimeKind.Local).AddTicks(3670), new DateTime(2019, 12, 3, 17, 54, 58, 566, DateTimeKind.Local).AddTicks(7521), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 57, "", "", new DateTime(2019, 10, 14, 12, 6, 16, 187, DateTimeKind.Local).AddTicks(1238), new DateTime(2019, 10, 11, 23, 27, 56, 520, DateTimeKind.Local).AddTicks(1560), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 56, "", "", new DateTime(2019, 9, 20, 5, 11, 50, 363, DateTimeKind.Local).AddTicks(216), new DateTime(2019, 12, 17, 7, 55, 2, 456, DateTimeKind.Local).AddTicks(2828), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 55, "", "", new DateTime(2020, 2, 14, 13, 37, 1, 598, DateTimeKind.Local).AddTicks(6238), new DateTime(2020, 2, 22, 5, 6, 48, 802, DateTimeKind.Local).AddTicks(1128), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 54, "", "", new DateTime(2020, 2, 27, 7, 19, 13, 759, DateTimeKind.Local).AddTicks(9049), new DateTime(2020, 5, 31, 20, 24, 26, 268, DateTimeKind.Local).AddTicks(7400), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 75, "", "", new DateTime(2020, 1, 9, 19, 52, 48, 691, DateTimeKind.Local).AddTicks(8306), new DateTime(2020, 5, 17, 8, 8, 32, 819, DateTimeKind.Local).AddTicks(2594), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 63, "", "", new DateTime(2019, 10, 22, 10, 32, 53, 181, DateTimeKind.Local).AddTicks(3555), new DateTime(2020, 6, 20, 13, 29, 2, 854, DateTimeKind.Local).AddTicks(3062), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 76, "", "", new DateTime(2019, 8, 22, 8, 36, 44, 113, DateTimeKind.Local).AddTicks(3670), new DateTime(2019, 12, 1, 12, 3, 42, 769, DateTimeKind.Local).AddTicks(7718), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 91, "", "", new DateTime(2019, 7, 23, 0, 43, 12, 370, DateTimeKind.Local).AddTicks(8127), new DateTime(2019, 7, 21, 18, 40, 20, 350, DateTimeKind.Local).AddTicks(6137), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 78, "", "", new DateTime(2019, 8, 19, 19, 57, 37, 781, DateTimeKind.Local).AddTicks(8402), new DateTime(2020, 3, 6, 6, 20, 5, 393, DateTimeKind.Local).AddTicks(8471), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 52, "", "", new DateTime(2020, 5, 14, 14, 57, 59, 892, DateTimeKind.Local).AddTicks(6057), new DateTime(2019, 7, 26, 23, 52, 14, 220, DateTimeKind.Local).AddTicks(1047), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 100, "", "", new DateTime(2019, 10, 11, 9, 8, 39, 511, DateTimeKind.Local).AddTicks(5202), new DateTime(2020, 1, 20, 14, 16, 13, 888, DateTimeKind.Local).AddTicks(2374), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 99, "", "", new DateTime(2020, 1, 10, 18, 11, 46, 603, DateTimeKind.Local).AddTicks(5379), new DateTime(2019, 8, 18, 21, 11, 39, 215, DateTimeKind.Local).AddTicks(4122), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 98, "", "", new DateTime(2020, 6, 22, 9, 21, 21, 150, DateTimeKind.Local).AddTicks(9578), new DateTime(2020, 2, 22, 3, 35, 0, 808, DateTimeKind.Local).AddTicks(1806), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 97, "", "", new DateTime(2020, 5, 13, 22, 18, 41, 98, DateTimeKind.Local).AddTicks(402), new DateTime(2020, 2, 15, 16, 10, 16, 805, DateTimeKind.Local).AddTicks(506), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 96, "", "", new DateTime(2020, 1, 15, 5, 24, 6, 776, DateTimeKind.Local).AddTicks(1332), new DateTime(2019, 11, 27, 16, 44, 40, 599, DateTimeKind.Local).AddTicks(1259), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 95, "", "", new DateTime(2019, 8, 16, 1, 52, 34, 89, DateTimeKind.Local).AddTicks(9518), new DateTime(2020, 2, 5, 7, 1, 11, 146, DateTimeKind.Local).AddTicks(3532), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 94, "", "", new DateTime(2020, 6, 3, 22, 22, 58, 999, DateTimeKind.Local).AddTicks(9542), new DateTime(2020, 6, 23, 11, 28, 43, 630, DateTimeKind.Local).AddTicks(4014), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 93, "", "", new DateTime(2020, 1, 3, 2, 51, 14, 913, DateTimeKind.Local).AddTicks(165), new DateTime(2019, 8, 21, 19, 10, 3, 346, DateTimeKind.Local).AddTicks(976), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 92, "", "", new DateTime(2019, 7, 14, 16, 38, 13, 419, DateTimeKind.Local).AddTicks(4824), new DateTime(2020, 3, 31, 21, 43, 23, 777, DateTimeKind.Local).AddTicks(2663), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 77, "", "", new DateTime(2019, 7, 5, 0, 9, 48, 207, DateTimeKind.Local).AddTicks(3608), new DateTime(2019, 11, 1, 15, 53, 53, 17, DateTimeKind.Local).AddTicks(6247), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 90, "", "", new DateTime(2020, 2, 23, 17, 15, 34, 886, DateTimeKind.Local).AddTicks(7823), new DateTime(2019, 11, 4, 19, 0, 5, 65, DateTimeKind.Local).AddTicks(873), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 88, "", "", new DateTime(2019, 12, 28, 10, 41, 44, 616, DateTimeKind.Local).AddTicks(7492), new DateTime(2019, 11, 30, 7, 22, 24, 741, DateTimeKind.Local).AddTicks(6434), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 87, "", "", new DateTime(2020, 5, 12, 15, 6, 35, 313, DateTimeKind.Local).AddTicks(2622), new DateTime(2019, 8, 12, 10, 55, 48, 641, DateTimeKind.Local).AddTicks(1380), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 86, "", "", new DateTime(2019, 9, 23, 5, 37, 55, 91, DateTimeKind.Local).AddTicks(4743), new DateTime(2020, 3, 22, 23, 1, 44, 85, DateTimeKind.Local).AddTicks(9794), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 85, "", "", new DateTime(2020, 3, 16, 19, 4, 23, 839, DateTimeKind.Local).AddTicks(4923), new DateTime(2020, 3, 26, 14, 35, 25, 63, DateTimeKind.Local).AddTicks(3737), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 84, "", "", new DateTime(2019, 11, 22, 9, 0, 3, 717, DateTimeKind.Local).AddTicks(7835), new DateTime(2020, 5, 15, 10, 56, 32, 178, DateTimeKind.Local).AddTicks(911), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 83, "", "", new DateTime(2019, 8, 23, 12, 59, 27, 139, DateTimeKind.Local).AddTicks(7392), new DateTime(2020, 6, 14, 3, 29, 41, 881, DateTimeKind.Local).AddTicks(105), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 82, "", "", new DateTime(2019, 11, 12, 16, 34, 12, 2, DateTimeKind.Local).AddTicks(5042), new DateTime(2019, 7, 11, 6, 45, 49, 349, DateTimeKind.Local).AddTicks(9565), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 81, "", "", new DateTime(2020, 2, 21, 16, 1, 57, 175, DateTimeKind.Local).AddTicks(3775), new DateTime(2020, 5, 6, 10, 43, 33, 545, DateTimeKind.Local).AddTicks(8561), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 80, "", "", new DateTime(2020, 1, 10, 2, 50, 9, 464, DateTimeKind.Local).AddTicks(6604), new DateTime(2019, 9, 1, 17, 38, 59, 568, DateTimeKind.Local).AddTicks(6211), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 79, "", "", new DateTime(2020, 5, 16, 5, 56, 45, 239, DateTimeKind.Local).AddTicks(7447), new DateTime(2019, 10, 4, 3, 47, 26, 997, DateTimeKind.Local).AddTicks(914), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 89, "", "", new DateTime(2020, 4, 16, 18, 9, 24, 771, DateTimeKind.Local).AddTicks(529), new DateTime(2019, 9, 10, 0, 48, 36, 206, DateTimeKind.Local).AddTicks(3086), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 51, "", "", new DateTime(2019, 8, 10, 1, 0, 4, 223, DateTimeKind.Local).AddTicks(7774), new DateTime(2019, 9, 2, 10, 37, 32, 549, DateTimeKind.Local).AddTicks(1167), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 8, "", "", new DateTime(2019, 7, 7, 3, 3, 9, 732, DateTimeKind.Local).AddTicks(1284), new DateTime(2019, 12, 6, 18, 54, 31, 697, DateTimeKind.Local).AddTicks(1729), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 49, "", "", new DateTime(2019, 9, 18, 4, 4, 56, 110, DateTimeKind.Local).AddTicks(8692), new DateTime(2019, 9, 12, 16, 7, 30, 492, DateTimeKind.Local).AddTicks(9937), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 22, "", "", new DateTime(2019, 10, 20, 7, 27, 12, 695, DateTimeKind.Local).AddTicks(2375), new DateTime(2019, 12, 1, 8, 42, 25, 880, DateTimeKind.Local).AddTicks(6578), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 21, "", "", new DateTime(2020, 1, 11, 3, 5, 17, 462, DateTimeKind.Local).AddTicks(7052), new DateTime(2020, 2, 9, 23, 49, 20, 705, DateTimeKind.Local).AddTicks(9505), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 20, "", "", new DateTime(2020, 1, 28, 14, 8, 35, 602, DateTimeKind.Local).AddTicks(4769), new DateTime(2019, 10, 1, 11, 51, 36, 680, DateTimeKind.Local).AddTicks(9301), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 19, "", "", new DateTime(2020, 1, 13, 6, 34, 0, 377, DateTimeKind.Local).AddTicks(1998), new DateTime(2019, 7, 6, 20, 41, 5, 725, DateTimeKind.Local).AddTicks(1617), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 18, "", "", new DateTime(2019, 12, 6, 2, 55, 59, 574, DateTimeKind.Local).AddTicks(5959), new DateTime(2020, 3, 14, 19, 9, 13, 49, DateTimeKind.Local).AddTicks(4454), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 17, "", "", new DateTime(2019, 8, 22, 17, 34, 40, 249, DateTimeKind.Local).AddTicks(3506), new DateTime(2019, 7, 12, 16, 51, 16, 399, DateTimeKind.Local).AddTicks(1000), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 16, "", "", new DateTime(2020, 3, 30, 18, 51, 31, 271, DateTimeKind.Local).AddTicks(8155), new DateTime(2020, 5, 8, 9, 49, 7, 139, DateTimeKind.Local).AddTicks(4505), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 15, "", "", new DateTime(2019, 9, 5, 7, 21, 25, 599, DateTimeKind.Local).AddTicks(963), new DateTime(2019, 12, 26, 15, 26, 24, 72, DateTimeKind.Local).AddTicks(1378), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 14, "", "", new DateTime(2019, 8, 21, 1, 46, 6, 971, DateTimeKind.Local).AddTicks(3354), new DateTime(2020, 1, 6, 6, 26, 22, 428, DateTimeKind.Local).AddTicks(4763), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 13, "", "", new DateTime(2019, 10, 22, 13, 33, 4, 60, DateTimeKind.Local).AddTicks(2102), new DateTime(2020, 3, 13, 9, 25, 40, 338, DateTimeKind.Local).AddTicks(7054), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 12, "", "", new DateTime(2019, 6, 29, 20, 50, 41, 96, DateTimeKind.Local).AddTicks(8392), new DateTime(2019, 12, 11, 18, 2, 30, 114, DateTimeKind.Local).AddTicks(8762), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 11, "", "", new DateTime(2020, 3, 8, 12, 9, 33, 843, DateTimeKind.Local).AddTicks(824), new DateTime(2020, 1, 18, 0, 24, 8, 700, DateTimeKind.Local).AddTicks(5992), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 10, "", "", new DateTime(2019, 6, 29, 4, 4, 10, 143, DateTimeKind.Local).AddTicks(2600), new DateTime(2019, 11, 28, 9, 1, 53, 584, DateTimeKind.Local).AddTicks(149), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 9, "", "", new DateTime(2019, 12, 5, 3, 17, 39, 580, DateTimeKind.Local).AddTicks(3600), new DateTime(2019, 12, 30, 14, 8, 21, 40, DateTimeKind.Local).AddTicks(5129), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 7, "", "", new DateTime(2019, 12, 25, 3, 52, 37, 451, DateTimeKind.Local).AddTicks(939), new DateTime(2020, 1, 30, 20, 28, 24, 28, DateTimeKind.Local).AddTicks(6831), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 6, "", "", new DateTime(2020, 5, 11, 18, 1, 19, 608, DateTimeKind.Local).AddTicks(7069), new DateTime(2019, 9, 16, 21, 42, 59, 93, DateTimeKind.Local).AddTicks(2855), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 5, "", "", new DateTime(2019, 11, 10, 10, 4, 24, 785, DateTimeKind.Local).AddTicks(3842), new DateTime(2019, 7, 28, 13, 11, 52, 714, DateTimeKind.Local).AddTicks(1212), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 4, "", "", new DateTime(2019, 8, 15, 5, 0, 33, 67, DateTimeKind.Local).AddTicks(1236), new DateTime(2020, 5, 30, 3, 43, 11, 212, DateTimeKind.Local).AddTicks(4768), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 3, "", "", new DateTime(2020, 2, 14, 12, 2, 4, 192, DateTimeKind.Local).AddTicks(5954), new DateTime(2019, 8, 11, 22, 55, 5, 669, DateTimeKind.Local).AddTicks(9332), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 2, "", "", new DateTime(2020, 3, 12, 23, 17, 49, 604, DateTimeKind.Local).AddTicks(6603), new DateTime(2020, 1, 30, 1, 39, 21, 911, DateTimeKind.Local).AddTicks(8165), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 50, "", "", new DateTime(2020, 5, 4, 1, 51, 28, 598, DateTimeKind.Local).AddTicks(6783), new DateTime(2020, 6, 3, 12, 31, 11, 758, DateTimeKind.Local).AddTicks(7604), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 23, "", "", new DateTime(2019, 11, 6, 1, 44, 35, 148, DateTimeKind.Local).AddTicks(5981), new DateTime(2019, 11, 5, 5, 5, 10, 345, DateTimeKind.Local).AddTicks(1633), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 24, "", "", new DateTime(2019, 11, 27, 3, 29, 6, 182, DateTimeKind.Local).AddTicks(1808), new DateTime(2020, 1, 12, 20, 19, 42, 205, DateTimeKind.Local).AddTicks(1171), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 1, "", "", new DateTime(2019, 7, 19, 7, 52, 48, 799, DateTimeKind.Local).AddTicks(7666), new DateTime(2020, 3, 26, 11, 10, 24, 554, DateTimeKind.Local).AddTicks(9201), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 26, "", "", new DateTime(2019, 8, 5, 19, 59, 17, 843, DateTimeKind.Local).AddTicks(5456), new DateTime(2020, 4, 25, 11, 33, 10, 789, DateTimeKind.Local).AddTicks(6567), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 25, "", "", new DateTime(2019, 12, 28, 16, 24, 41, 877, DateTimeKind.Local).AddTicks(6099), new DateTime(2019, 10, 28, 17, 57, 57, 136, DateTimeKind.Local).AddTicks(3810), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 47, "", "", new DateTime(2020, 5, 12, 11, 30, 29, 647, DateTimeKind.Local).AddTicks(5872), new DateTime(2019, 7, 22, 13, 22, 49, 787, DateTimeKind.Local).AddTicks(529), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 46, "", "", new DateTime(2019, 8, 14, 15, 26, 43, 763, DateTimeKind.Local).AddTicks(4282), new DateTime(2019, 11, 16, 22, 44, 58, 369, DateTimeKind.Local).AddTicks(9627), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 45, "", "", new DateTime(2020, 5, 10, 12, 35, 36, 90, DateTimeKind.Local).AddTicks(2059), new DateTime(2019, 12, 28, 14, 35, 20, 6, DateTimeKind.Local).AddTicks(6653), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 44, "", "", new DateTime(2019, 8, 22, 23, 16, 26, 534, DateTimeKind.Local).AddTicks(3300), new DateTime(2020, 1, 30, 3, 30, 37, 50, DateTimeKind.Local).AddTicks(1294), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 43, "", "", new DateTime(2019, 7, 18, 6, 34, 41, 753, DateTimeKind.Local).AddTicks(4514), new DateTime(2019, 8, 11, 12, 33, 9, 805, DateTimeKind.Local).AddTicks(2985), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 42, "", "", new DateTime(2019, 9, 4, 13, 39, 24, 866, DateTimeKind.Local).AddTicks(1748), new DateTime(2020, 4, 30, 14, 25, 17, 112, DateTimeKind.Local).AddTicks(7249), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 41, "", "", new DateTime(2019, 12, 31, 13, 55, 33, 517, DateTimeKind.Local).AddTicks(3658), new DateTime(2020, 1, 2, 21, 36, 53, 962, DateTimeKind.Local).AddTicks(4514), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 40, "", "", new DateTime(2019, 10, 21, 13, 34, 1, 557, DateTimeKind.Local).AddTicks(6437), new DateTime(2019, 9, 22, 14, 39, 34, 856, DateTimeKind.Local).AddTicks(59), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 39, "", "", new DateTime(2019, 12, 1, 23, 3, 13, 626, DateTimeKind.Local).AddTicks(8908), new DateTime(2019, 11, 2, 0, 43, 47, 547, DateTimeKind.Local).AddTicks(929), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 38, "", "", new DateTime(2019, 11, 2, 4, 39, 11, 889, DateTimeKind.Local).AddTicks(7975), new DateTime(2019, 12, 16, 9, 19, 47, 828, DateTimeKind.Local).AddTicks(3401), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 48, "", "", new DateTime(2019, 12, 12, 19, 55, 6, 394, DateTimeKind.Local).AddTicks(7467), new DateTime(2019, 6, 30, 23, 18, 45, 819, DateTimeKind.Local).AddTicks(7234), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 36, "", "", new DateTime(2020, 6, 24, 11, 7, 41, 365, DateTimeKind.Local).AddTicks(5046), new DateTime(2020, 6, 2, 2, 22, 44, 353, DateTimeKind.Local).AddTicks(6323), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 27, "", "", new DateTime(2019, 8, 6, 20, 40, 14, 430, DateTimeKind.Local).AddTicks(7876), new DateTime(2020, 2, 29, 0, 17, 34, 965, DateTimeKind.Local).AddTicks(1714), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 37, "", "", new DateTime(2020, 4, 21, 12, 31, 48, 679, DateTimeKind.Local).AddTicks(7536), new DateTime(2019, 12, 2, 2, 26, 9, 190, DateTimeKind.Local).AddTicks(3026), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 29, "", "", new DateTime(2019, 7, 22, 8, 39, 4, 495, DateTimeKind.Local).AddTicks(8867), new DateTime(2019, 9, 26, 1, 5, 0, 925, DateTimeKind.Local).AddTicks(1176), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 30, "", "", new DateTime(2020, 4, 27, 19, 59, 7, 842, DateTimeKind.Local).AddTicks(8039), new DateTime(2019, 12, 10, 6, 8, 7, 376, DateTimeKind.Local).AddTicks(2728), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 31, "", "", new DateTime(2020, 1, 21, 4, 55, 15, 726, DateTimeKind.Local).AddTicks(1159), new DateTime(2020, 3, 18, 15, 15, 55, 114, DateTimeKind.Local).AddTicks(3687), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 28, "", "", new DateTime(2019, 9, 2, 18, 12, 56, 572, DateTimeKind.Local).AddTicks(2653), new DateTime(2020, 5, 1, 2, 20, 56, 550, DateTimeKind.Local).AddTicks(5384), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 33, "", "", new DateTime(2019, 12, 30, 8, 20, 7, 450, DateTimeKind.Local).AddTicks(807), new DateTime(2020, 5, 10, 15, 45, 39, 560, DateTimeKind.Local).AddTicks(4987), "", "", "Conseil consultatif de la famille et de l'enfance", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 34, "", "", new DateTime(2020, 2, 1, 21, 56, 21, 80, DateTimeKind.Local).AddTicks(7888), new DateTime(2019, 11, 17, 8, 58, 22, 779, DateTimeKind.Local).AddTicks(8594), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 35, "", "", new DateTime(2020, 4, 10, 11, 19, 24, 858, DateTimeKind.Local).AddTicks(9712), new DateTime(2020, 3, 20, 5, 57, 0, 723, DateTimeKind.Local).AddTicks(8140), "", "", "La lutte contre toutes les formes de discrimination", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece" },
                values: new object[] { 32, "", "", new DateTime(2019, 11, 10, 19, 42, 58, 728, DateTimeKind.Local).AddTicks(9737), new DateTime(2020, 2, 2, 14, 32, 16, 165, DateTimeKind.Local).AddTicks(2678), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 65, new DateTime(2019, 11, 28, 13, 17, 23, 88, DateTimeKind.Local).AddTicks(7330), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 72, new DateTime(2019, 7, 10, 9, 18, 56, 458, DateTimeKind.Local).AddTicks(9134), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 71, new DateTime(2019, 11, 20, 12, 8, 41, 606, DateTimeKind.Local).AddTicks(456), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 70, new DateTime(2019, 11, 17, 4, 8, 2, 964, DateTimeKind.Local).AddTicks(7464), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 69, new DateTime(2020, 1, 5, 4, 26, 35, 606, DateTimeKind.Local).AddTicks(5880), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 68, new DateTime(2020, 2, 7, 0, 50, 31, 918, DateTimeKind.Local).AddTicks(1757), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 67, new DateTime(2019, 10, 29, 5, 1, 37, 467, DateTimeKind.Local).AddTicks(825), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 66, new DateTime(2019, 10, 10, 5, 40, 56, 15, DateTimeKind.Local).AddTicks(5848), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 64, new DateTime(2020, 3, 2, 2, 1, 17, 556, DateTimeKind.Local).AddTicks(9418), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 53, new DateTime(2019, 11, 23, 21, 12, 14, 510, DateTimeKind.Local).AddTicks(7334), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 62, new DateTime(2019, 12, 24, 4, 42, 44, 119, DateTimeKind.Local).AddTicks(3698), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 61, new DateTime(2020, 1, 26, 11, 16, 32, 354, DateTimeKind.Local).AddTicks(4051), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 60, new DateTime(2019, 8, 29, 3, 42, 42, 967, DateTimeKind.Local).AddTicks(5040), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 59, new DateTime(2019, 10, 1, 0, 18, 42, 734, DateTimeKind.Local).AddTicks(4311), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 58, new DateTime(2019, 12, 27, 17, 36, 54, 502, DateTimeKind.Local).AddTicks(6802), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 57, new DateTime(2019, 6, 29, 8, 50, 14, 11, DateTimeKind.Local).AddTicks(4637), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 56, new DateTime(2020, 1, 3, 8, 36, 3, 126, DateTimeKind.Local).AddTicks(1958), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 55, new DateTime(2019, 11, 28, 17, 16, 40, 209, DateTimeKind.Local).AddTicks(4026), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 54, new DateTime(2019, 8, 10, 22, 20, 6, 124, DateTimeKind.Local).AddTicks(7414), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 73, new DateTime(2020, 1, 20, 16, 59, 0, 384, DateTimeKind.Local).AddTicks(9216), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 52, new DateTime(2020, 3, 27, 23, 35, 2, 968, DateTimeKind.Local).AddTicks(1025), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 63, new DateTime(2020, 3, 21, 20, 43, 53, 744, DateTimeKind.Local).AddTicks(8771), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 74, new DateTime(2020, 5, 1, 2, 57, 33, 404, DateTimeKind.Local).AddTicks(4286), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 85, new DateTime(2020, 6, 21, 3, 19, 52, 841, DateTimeKind.Local).AddTicks(1147), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 76, new DateTime(2019, 10, 9, 1, 0, 45, 738, DateTimeKind.Local).AddTicks(6763), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 98, new DateTime(2020, 5, 29, 19, 1, 9, 333, DateTimeKind.Local).AddTicks(5810), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 51, new DateTime(2020, 1, 12, 20, 53, 59, 477, DateTimeKind.Local).AddTicks(6029), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 97, new DateTime(2019, 12, 30, 3, 49, 13, 498, DateTimeKind.Local).AddTicks(886), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 96, new DateTime(2020, 5, 6, 19, 34, 44, 555, DateTimeKind.Local).AddTicks(6800), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 95, new DateTime(2020, 2, 16, 4, 35, 30, 465, DateTimeKind.Local).AddTicks(403), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 94, new DateTime(2019, 10, 31, 5, 16, 58, 531, DateTimeKind.Local).AddTicks(6895), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 93, new DateTime(2019, 10, 19, 5, 58, 48, 477, DateTimeKind.Local).AddTicks(371), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 92, new DateTime(2019, 11, 30, 16, 52, 3, 269, DateTimeKind.Local).AddTicks(1666), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 91, new DateTime(2020, 2, 10, 16, 30, 6, 465, DateTimeKind.Local).AddTicks(4440), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 90, new DateTime(2020, 5, 19, 22, 2, 58, 866, DateTimeKind.Local).AddTicks(1127), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 75, new DateTime(2019, 7, 5, 14, 27, 20, 427, DateTimeKind.Local).AddTicks(5600), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 89, new DateTime(2020, 4, 8, 15, 43, 5, 870, DateTimeKind.Local).AddTicks(3184), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 87, new DateTime(2019, 12, 15, 22, 44, 45, 171, DateTimeKind.Local).AddTicks(6462), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 86, new DateTime(2020, 3, 31, 2, 18, 59, 634, DateTimeKind.Local).AddTicks(5365), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 84, new DateTime(2019, 8, 15, 10, 30, 5, 998, DateTimeKind.Local).AddTicks(3574), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 83, new DateTime(2020, 4, 4, 7, 13, 57, 318, DateTimeKind.Local).AddTicks(9536), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 82, new DateTime(2019, 7, 8, 8, 57, 43, 2, DateTimeKind.Local).AddTicks(5474), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 81, new DateTime(2020, 5, 16, 4, 12, 50, 650, DateTimeKind.Local).AddTicks(7900), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 80, new DateTime(2020, 2, 8, 7, 24, 18, 298, DateTimeKind.Local).AddTicks(8845), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 79, new DateTime(2019, 10, 22, 22, 44, 5, 745, DateTimeKind.Local).AddTicks(4152), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 78, new DateTime(2019, 10, 1, 4, 19, 1, 318, DateTimeKind.Local).AddTicks(6606), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 77, new DateTime(2019, 12, 20, 19, 15, 15, 274, DateTimeKind.Local).AddTicks(3660), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 88, new DateTime(2019, 10, 23, 5, 37, 43, 841, DateTimeKind.Local).AddTicks(8449), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 50, new DateTime(2020, 6, 15, 7, 38, 13, 353, DateTimeKind.Local).AddTicks(2536), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 26, new DateTime(2020, 1, 12, 20, 58, 23, 826, DateTimeKind.Local).AddTicks(6462), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 48, new DateTime(2020, 2, 22, 11, 9, 36, 853, DateTimeKind.Local).AddTicks(786), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 20, new DateTime(2019, 7, 20, 0, 18, 9, 765, DateTimeKind.Local).AddTicks(3725), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 19, new DateTime(2020, 2, 17, 21, 59, 27, 50, DateTimeKind.Local).AddTicks(7031), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 18, new DateTime(2019, 8, 13, 10, 32, 38, 851, DateTimeKind.Local).AddTicks(8282), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 17, new DateTime(2019, 7, 20, 5, 2, 39, 733, DateTimeKind.Local).AddTicks(1377), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 16, new DateTime(2020, 2, 24, 1, 3, 52, 649, DateTimeKind.Local).AddTicks(1024), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 15, new DateTime(2020, 1, 21, 6, 39, 19, 438, DateTimeKind.Local).AddTicks(5937), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 14, new DateTime(2020, 2, 7, 21, 5, 4, 471, DateTimeKind.Local).AddTicks(5691), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 13, new DateTime(2019, 7, 5, 23, 7, 30, 37, DateTimeKind.Local).AddTicks(5623), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 12, new DateTime(2020, 1, 18, 1, 24, 37, 518, DateTimeKind.Local).AddTicks(9089), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 11, new DateTime(2020, 6, 11, 14, 55, 56, 926, DateTimeKind.Local).AddTicks(5460), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 10, new DateTime(2019, 10, 27, 23, 15, 10, 777, DateTimeKind.Local).AddTicks(3626), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 9, new DateTime(2019, 7, 11, 5, 22, 9, 836, DateTimeKind.Local).AddTicks(116), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 8, new DateTime(2020, 6, 2, 22, 27, 24, 857, DateTimeKind.Local).AddTicks(4777), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 7, new DateTime(2020, 1, 8, 21, 45, 47, 944, DateTimeKind.Local).AddTicks(6050), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 6, new DateTime(2019, 6, 25, 15, 50, 32, 351, DateTimeKind.Local).AddTicks(5402), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 5, new DateTime(2020, 1, 5, 12, 54, 23, 428, DateTimeKind.Local).AddTicks(2124), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 4, new DateTime(2019, 7, 24, 19, 57, 14, 867, DateTimeKind.Local).AddTicks(7942), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 3, new DateTime(2019, 9, 14, 2, 45, 47, 522, DateTimeKind.Local).AddTicks(8957), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 2, new DateTime(2020, 6, 1, 16, 55, 28, 184, DateTimeKind.Local).AddTicks(3370), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 1, new DateTime(2020, 4, 9, 17, 53, 37, 35, DateTimeKind.Local).AddTicks(5810), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 99, new DateTime(2019, 11, 26, 18, 51, 47, 721, DateTimeKind.Local).AddTicks(6214), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 21, new DateTime(2019, 10, 24, 17, 51, 15, 214, DateTimeKind.Local).AddTicks(8367), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 22, new DateTime(2019, 9, 23, 9, 0, 9, 568, DateTimeKind.Local).AddTicks(303), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 23, new DateTime(2019, 11, 9, 5, 48, 3, 9, DateTimeKind.Local).AddTicks(4648), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 24, new DateTime(2020, 2, 24, 12, 20, 32, 438, DateTimeKind.Local).AddTicks(5734), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 47, new DateTime(2019, 10, 7, 12, 17, 17, 978, DateTimeKind.Local).AddTicks(6675), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 46, new DateTime(2020, 3, 5, 10, 20, 18, 330, DateTimeKind.Local).AddTicks(751), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 45, new DateTime(2019, 10, 28, 3, 45, 18, 371, DateTimeKind.Local).AddTicks(1049), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 44, new DateTime(2020, 5, 29, 2, 30, 16, 898, DateTimeKind.Local).AddTicks(6759), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 43, new DateTime(2019, 11, 18, 5, 53, 48, 275, DateTimeKind.Local).AddTicks(3338), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 42, new DateTime(2019, 12, 26, 15, 47, 23, 923, DateTimeKind.Local).AddTicks(9703), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 41, new DateTime(2019, 7, 2, 22, 11, 20, 249, DateTimeKind.Local).AddTicks(1198), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 40, new DateTime(2020, 4, 3, 0, 55, 45, 540, DateTimeKind.Local).AddTicks(106), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 39, new DateTime(2019, 12, 27, 23, 55, 52, 131, DateTimeKind.Local).AddTicks(1740), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 38, new DateTime(2019, 8, 25, 8, 44, 42, 772, DateTimeKind.Local).AddTicks(740), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 49, new DateTime(2020, 6, 21, 14, 5, 17, 566, DateTimeKind.Local).AddTicks(2194), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 37, new DateTime(2019, 6, 25, 15, 49, 18, 710, DateTimeKind.Local).AddTicks(2243), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 35, new DateTime(2020, 1, 21, 17, 2, 42, 845, DateTimeKind.Local).AddTicks(4180), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 34, new DateTime(2019, 10, 14, 4, 3, 19, 80, DateTimeKind.Local).AddTicks(8182), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 33, new DateTime(2019, 10, 2, 4, 40, 53, 261, DateTimeKind.Local).AddTicks(9525), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 32, new DateTime(2020, 3, 2, 4, 38, 45, 695, DateTimeKind.Local).AddTicks(1515), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 31, new DateTime(2020, 1, 25, 11, 12, 53, 899, DateTimeKind.Local).AddTicks(987), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 30, new DateTime(2020, 4, 7, 2, 20, 36, 238, DateTimeKind.Local).AddTicks(3570), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 29, new DateTime(2020, 4, 15, 4, 37, 14, 369, DateTimeKind.Local).AddTicks(683), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 28, new DateTime(2019, 11, 2, 9, 6, 46, 999, DateTimeKind.Local).AddTicks(6392), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 27, new DateTime(2020, 1, 14, 23, 7, 46, 116, DateTimeKind.Local).AddTicks(3929), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 25, new DateTime(2020, 4, 13, 11, 38, 4, 202, DateTimeKind.Local).AddTicks(234), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 36, new DateTime(2019, 10, 29, 7, 41, 7, 369, DateTimeKind.Local).AddTicks(267), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat" },
                values: new object[] { 100, new DateTime(2019, 12, 22, 7, 10, 47, 634, DateTimeKind.Local).AddTicks(3903), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 6, 24, 22, 39, 34, 362, DateTimeKind.Local).AddTicks(399), new DateTime(2020, 6, 25, 12, 17, 15, 877, DateTimeKind.Local).AddTicks(6854), new DateTime(2020, 6, 25, 13, 10, 33, 364, DateTimeKind.Local).AddTicks(8302), 46, "", "http://rayan.net", "dolore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 6, 25, 6, 58, 18, 169, DateTimeKind.Local).AddTicks(5503), new DateTime(2020, 6, 24, 22, 50, 11, 262, DateTimeKind.Local).AddTicks(5290), new DateTime(2020, 6, 25, 11, 23, 46, 271, DateTimeKind.Local).AddTicks(2149), 68, "", "http://maëlys.name", "veritatis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 6, 24, 18, 48, 39, 755, DateTimeKind.Local).AddTicks(9759), new DateTime(2020, 6, 24, 21, 44, 23, 67, DateTimeKind.Local).AddTicks(2511), new DateTime(2020, 6, 25, 10, 39, 3, 509, DateTimeKind.Local).AddTicks(5486), 68, "", "https://carla.net", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 6, 24, 20, 58, 34, 840, DateTimeKind.Local).AddTicks(2623), new DateTime(2020, 6, 25, 11, 3, 46, 223, DateTimeKind.Local).AddTicks(810), new DateTime(2020, 6, 24, 23, 19, 53, 400, DateTimeKind.Local).AddTicks(731), 67, "", "https://alicia.eu", "maxime" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 6, 24, 19, 48, 54, 348, DateTimeKind.Local).AddTicks(144), new DateTime(2020, 6, 25, 9, 43, 46, 79, DateTimeKind.Local).AddTicks(7180), new DateTime(2020, 6, 25, 10, 41, 23, 939, DateTimeKind.Local).AddTicks(9830), 67, "", "http://maeva.com", "magni" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 6, 25, 0, 34, 9, 664, DateTimeKind.Local).AddTicks(9800), new DateTime(2020, 6, 25, 10, 54, 47, 330, DateTimeKind.Local).AddTicks(8525), new DateTime(2020, 6, 24, 15, 59, 43, 233, DateTimeKind.Local).AddTicks(3940), 67, "", "https://elisa.name", "temporibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 6, 24, 21, 41, 51, 113, DateTimeKind.Local).AddTicks(4707), new DateTime(2020, 6, 24, 22, 43, 8, 448, DateTimeKind.Local).AddTicks(3451), new DateTime(2020, 6, 25, 10, 8, 33, 715, DateTimeKind.Local).AddTicks(1403), 67, "", "http://tom.eu", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 6, 24, 23, 8, 32, 518, DateTimeKind.Local).AddTicks(8203), new DateTime(2020, 6, 25, 7, 59, 31, 852, DateTimeKind.Local).AddTicks(843), new DateTime(2020, 6, 25, 1, 9, 44, 981, DateTimeKind.Local).AddTicks(8532), 66, "", "http://pierre.com", "tempora" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 6, 24, 17, 56, 25, 414, DateTimeKind.Local).AddTicks(2695), new DateTime(2020, 6, 25, 13, 1, 2, 786, DateTimeKind.Local).AddTicks(292), new DateTime(2020, 6, 25, 11, 20, 56, 804, DateTimeKind.Local).AddTicks(2002), 65, "", "https://camille.com", "distinctio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 6, 24, 17, 53, 0, 126, DateTimeKind.Local).AddTicks(5162), new DateTime(2020, 6, 25, 3, 51, 41, 312, DateTimeKind.Local).AddTicks(1419), new DateTime(2020, 6, 24, 22, 17, 16, 778, DateTimeKind.Local).AddTicks(2767), 63, "", "https://lisa.fr", "quis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 6, 25, 12, 40, 55, 785, DateTimeKind.Local).AddTicks(2466), new DateTime(2020, 6, 25, 8, 28, 15, 868, DateTimeKind.Local).AddTicks(7559), new DateTime(2020, 6, 25, 0, 49, 50, 69, DateTimeKind.Local).AddTicks(2342), 63, "", "http://enzo.eu", "a" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 6, 25, 11, 45, 24, 707, DateTimeKind.Local).AddTicks(205), new DateTime(2020, 6, 25, 7, 31, 17, 579, DateTimeKind.Local).AddTicks(7375), new DateTime(2020, 6, 25, 10, 44, 51, 357, DateTimeKind.Local).AddTicks(5868), 63, "", "http://carla.info", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 6, 25, 5, 6, 33, 164, DateTimeKind.Local).AddTicks(8927), new DateTime(2020, 6, 24, 21, 36, 50, 380, DateTimeKind.Local).AddTicks(6396), new DateTime(2020, 6, 25, 1, 58, 21, 727, DateTimeKind.Local).AddTicks(8040), 68, "", "http://alexis.net", "iusto" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 6, 25, 9, 2, 2, 86, DateTimeKind.Local).AddTicks(6120), new DateTime(2020, 6, 24, 23, 21, 11, 111, DateTimeKind.Local).AddTicks(756), new DateTime(2020, 6, 24, 20, 44, 43, 647, DateTimeKind.Local).AddTicks(2445), 63, "", "https://océane.eu", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 6, 24, 16, 21, 40, 126, DateTimeKind.Local).AddTicks(521), new DateTime(2020, 6, 25, 15, 17, 8, 367, DateTimeKind.Local).AddTicks(5706), new DateTime(2020, 6, 25, 9, 50, 11, 317, DateTimeKind.Local).AddTicks(157), 62, "", "http://adam.info", "voluptatum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 6, 24, 18, 1, 34, 971, DateTimeKind.Local).AddTicks(5678), new DateTime(2020, 6, 24, 21, 22, 29, 606, DateTimeKind.Local).AddTicks(81), new DateTime(2020, 6, 24, 21, 0, 0, 331, DateTimeKind.Local).AddTicks(1299), 61, "", "http://lena.net", "maiores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 6, 24, 17, 38, 19, 414, DateTimeKind.Local).AddTicks(9839), new DateTime(2020, 6, 25, 11, 12, 0, 341, DateTimeKind.Local).AddTicks(9858), new DateTime(2020, 6, 25, 14, 6, 14, 544, DateTimeKind.Local).AddTicks(8729), 60, "", "https://marie.com", "maxime" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 6, 24, 20, 53, 40, 377, DateTimeKind.Local).AddTicks(1393), new DateTime(2020, 6, 24, 23, 26, 21, 342, DateTimeKind.Local).AddTicks(8641), new DateTime(2020, 6, 25, 9, 9, 55, 929, DateTimeKind.Local).AddTicks(214), 60, "", "http://juliette.info", "laudantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 6, 25, 8, 25, 22, 697, DateTimeKind.Local).AddTicks(7760), new DateTime(2020, 6, 25, 8, 29, 14, 51, DateTimeKind.Local).AddTicks(986), new DateTime(2020, 6, 25, 5, 15, 31, 3, DateTimeKind.Local).AddTicks(938), 60, "", "http://benjamin.name", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 6, 25, 14, 29, 46, 205, DateTimeKind.Local).AddTicks(4043), new DateTime(2020, 6, 25, 15, 43, 1, 339, DateTimeKind.Local).AddTicks(9663), new DateTime(2020, 6, 25, 14, 7, 0, 925, DateTimeKind.Local).AddTicks(3834), 58, "", "https://rayan.info", "illo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 6, 24, 21, 46, 36, 358, DateTimeKind.Local).AddTicks(431), new DateTime(2020, 6, 25, 5, 6, 11, 995, DateTimeKind.Local).AddTicks(7216), new DateTime(2020, 6, 25, 1, 5, 18, 963, DateTimeKind.Local).AddTicks(9908), 57, "", "https://julien.fr", "molestias" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 6, 25, 15, 46, 11, 749, DateTimeKind.Local).AddTicks(5111), new DateTime(2020, 6, 25, 15, 17, 38, 843, DateTimeKind.Local).AddTicks(5737), new DateTime(2020, 6, 25, 1, 7, 58, 410, DateTimeKind.Local).AddTicks(5158), 55, "", "http://hugo.com", "minima" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 6, 25, 9, 21, 55, 130, DateTimeKind.Local).AddTicks(9010), new DateTime(2020, 6, 25, 10, 11, 39, 412, DateTimeKind.Local).AddTicks(5638), new DateTime(2020, 6, 25, 11, 31, 26, 578, DateTimeKind.Local).AddTicks(312), 54, "", "https://jules.org", "placeat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 6, 24, 21, 0, 15, 269, DateTimeKind.Local).AddTicks(5354), new DateTime(2020, 6, 24, 21, 58, 34, 294, DateTimeKind.Local).AddTicks(2524), new DateTime(2020, 6, 25, 10, 8, 31, 737, DateTimeKind.Local).AddTicks(3011), 53, "", "https://romain.com", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 6, 25, 10, 58, 17, 143, DateTimeKind.Local).AddTicks(6775), new DateTime(2020, 6, 24, 19, 31, 29, 122, DateTimeKind.Local).AddTicks(7627), new DateTime(2020, 6, 24, 16, 49, 22, 952, DateTimeKind.Local).AddTicks(1787), 50, "", "https://lola.com", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 6, 25, 0, 49, 4, 138, DateTimeKind.Local).AddTicks(7583), new DateTime(2020, 6, 25, 8, 42, 41, 345, DateTimeKind.Local).AddTicks(9715), new DateTime(2020, 6, 25, 2, 13, 24, 967, DateTimeKind.Local).AddTicks(2764), 62, "", "http://clémence.net", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 6, 25, 4, 52, 45, 49, DateTimeKind.Local).AddTicks(1705), new DateTime(2020, 6, 25, 7, 12, 34, 682, DateTimeKind.Local).AddTicks(5669), new DateTime(2020, 6, 24, 23, 57, 23, 941, DateTimeKind.Local).AddTicks(191), 69, "", "https://quentin.org", "veritatis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 6, 24, 22, 15, 20, 643, DateTimeKind.Local).AddTicks(6357), new DateTime(2020, 6, 24, 22, 52, 59, 809, DateTimeKind.Local).AddTicks(8186), new DateTime(2020, 6, 25, 1, 48, 24, 263, DateTimeKind.Local).AddTicks(186), 69, "", "https://louis.name", "sit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 6, 25, 13, 30, 27, 77, DateTimeKind.Local).AddTicks(4808), new DateTime(2020, 6, 25, 2, 21, 11, 721, DateTimeKind.Local).AddTicks(1779), new DateTime(2020, 6, 25, 5, 18, 54, 468, DateTimeKind.Local).AddTicks(5384), 70, "", "http://sacha.name", "maiores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 6, 25, 14, 15, 54, 532, DateTimeKind.Local).AddTicks(5079), new DateTime(2020, 6, 24, 22, 16, 38, 702, DateTimeKind.Local).AddTicks(806), new DateTime(2020, 6, 25, 2, 13, 14, 95, DateTimeKind.Local).AddTicks(7009), 98, "", "http://célia.com", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 6, 24, 20, 26, 27, 293, DateTimeKind.Local).AddTicks(2735), new DateTime(2020, 6, 24, 22, 43, 18, 68, DateTimeKind.Local).AddTicks(8189), new DateTime(2020, 6, 24, 17, 0, 16, 146, DateTimeKind.Local).AddTicks(76), 96, "", "http://baptiste.name", "nemo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 6, 24, 17, 48, 17, 140, DateTimeKind.Local).AddTicks(3321), new DateTime(2020, 6, 24, 16, 11, 16, 425, DateTimeKind.Local).AddTicks(505), new DateTime(2020, 6, 24, 21, 2, 50, 101, DateTimeKind.Local).AddTicks(7680), 96, "", "http://justine.name", "ad" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 6, 25, 1, 58, 9, 754, DateTimeKind.Local).AddTicks(8573), new DateTime(2020, 6, 25, 13, 23, 17, 521, DateTimeKind.Local).AddTicks(8079), new DateTime(2020, 6, 25, 6, 7, 48, 467, DateTimeKind.Local).AddTicks(5049), 90, "", "https://noah.com", "delectus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 6, 24, 17, 7, 55, 880, DateTimeKind.Local).AddTicks(6483), new DateTime(2020, 6, 24, 20, 0, 56, 111, DateTimeKind.Local).AddTicks(941), new DateTime(2020, 6, 24, 23, 28, 7, 758, DateTimeKind.Local).AddTicks(7380), 87, "", "https://maeva.com", "doloribus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 6, 24, 18, 18, 0, 545, DateTimeKind.Local).AddTicks(8504), new DateTime(2020, 6, 24, 23, 20, 36, 605, DateTimeKind.Local).AddTicks(4169), new DateTime(2020, 6, 24, 15, 56, 37, 886, DateTimeKind.Local).AddTicks(4871), 87, "", "http://alexandre.com", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 6, 24, 16, 12, 17, 152, DateTimeKind.Local).AddTicks(8594), new DateTime(2020, 6, 25, 14, 59, 33, 991, DateTimeKind.Local).AddTicks(7063), new DateTime(2020, 6, 24, 22, 32, 18, 30, DateTimeKind.Local).AddTicks(2211), 87, "", "http://paul.com", "voluptas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 6, 24, 15, 59, 54, 661, DateTimeKind.Local).AddTicks(6694), new DateTime(2020, 6, 25, 8, 33, 4, 950, DateTimeKind.Local).AddTicks(241), new DateTime(2020, 6, 25, 1, 44, 10, 238, DateTimeKind.Local).AddTicks(7940), 86, "", "http://justine.name", "nostrum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 6, 24, 20, 48, 41, 840, DateTimeKind.Local).AddTicks(7779), new DateTime(2020, 6, 25, 9, 22, 31, 886, DateTimeKind.Local).AddTicks(5982), new DateTime(2020, 6, 24, 16, 26, 58, 888, DateTimeKind.Local).AddTicks(860), 85, "", "http://lisa.fr", "ullam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 6, 24, 17, 0, 13, 369, DateTimeKind.Local).AddTicks(145), new DateTime(2020, 6, 25, 5, 55, 51, 797, DateTimeKind.Local).AddTicks(8010), new DateTime(2020, 6, 24, 15, 59, 29, 398, DateTimeKind.Local).AddTicks(5158), 84, "", "http://lucie.net", "eius" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 6, 24, 22, 40, 29, 783, DateTimeKind.Local).AddTicks(6511), new DateTime(2020, 6, 24, 18, 31, 49, 646, DateTimeKind.Local).AddTicks(7894), new DateTime(2020, 6, 24, 16, 49, 10, 824, DateTimeKind.Local).AddTicks(3088), 84, "", "https://jade.fr", "minima" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 6, 24, 19, 8, 32, 272, DateTimeKind.Local).AddTicks(3581), new DateTime(2020, 6, 24, 21, 45, 47, 802, DateTimeKind.Local).AddTicks(5973), new DateTime(2020, 6, 24, 16, 50, 38, 689, DateTimeKind.Local).AddTicks(1499), 82, "", "http://théo.com", "aliquid" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 6, 25, 15, 10, 23, 643, DateTimeKind.Local).AddTicks(6342), new DateTime(2020, 6, 25, 2, 8, 10, 752, DateTimeKind.Local).AddTicks(4945), new DateTime(2020, 6, 25, 11, 45, 30, 367, DateTimeKind.Local).AddTicks(784), 81, "", "https://zoe.info", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 6, 25, 3, 46, 34, 374, DateTimeKind.Local).AddTicks(4490), new DateTime(2020, 6, 24, 20, 59, 59, 875, DateTimeKind.Local).AddTicks(1321), new DateTime(2020, 6, 25, 12, 34, 16, 211, DateTimeKind.Local).AddTicks(7822), 79, "", "http://jeanne.com", "nemo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 6, 25, 8, 7, 44, 730, DateTimeKind.Local).AddTicks(4506), new DateTime(2020, 6, 24, 20, 19, 18, 361, DateTimeKind.Local).AddTicks(9539), new DateTime(2020, 6, 25, 6, 46, 35, 125, DateTimeKind.Local).AddTicks(5612), 76, "", "http://alice.info", "nobis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 6, 25, 8, 6, 20, 406, DateTimeKind.Local).AddTicks(442), new DateTime(2020, 6, 24, 17, 50, 0, 534, DateTimeKind.Local).AddTicks(6780), new DateTime(2020, 6, 25, 8, 33, 44, 960, DateTimeKind.Local).AddTicks(5541), 76, "", "https://anaïs.fr", "ratione" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 6, 25, 15, 10, 10, 871, DateTimeKind.Local).AddTicks(7966), new DateTime(2020, 6, 25, 7, 40, 46, 526, DateTimeKind.Local).AddTicks(272), new DateTime(2020, 6, 25, 7, 37, 28, 106, DateTimeKind.Local).AddTicks(1827), 76, "", "https://raphaël.net", "tempore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 6, 24, 16, 39, 3, 678, DateTimeKind.Local).AddTicks(9600), new DateTime(2020, 6, 25, 5, 35, 38, 592, DateTimeKind.Local).AddTicks(4532), new DateTime(2020, 6, 24, 21, 2, 24, 625, DateTimeKind.Local).AddTicks(7721), 76, "", "http://théo.org", "id" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 6, 25, 2, 21, 19, 597, DateTimeKind.Local).AddTicks(3508), new DateTime(2020, 6, 24, 16, 1, 17, 671, DateTimeKind.Local).AddTicks(8211), new DateTime(2020, 6, 24, 19, 22, 3, 68, DateTimeKind.Local).AddTicks(898), 75, "", "http://manon.fr", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 6, 25, 9, 41, 0, 411, DateTimeKind.Local).AddTicks(4192), new DateTime(2020, 6, 25, 3, 58, 51, 205, DateTimeKind.Local).AddTicks(9644), new DateTime(2020, 6, 24, 21, 41, 1, 353, DateTimeKind.Local).AddTicks(8616), 75, "", "https://quentin.name", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 6, 25, 2, 24, 43, 203, DateTimeKind.Local).AddTicks(8616), new DateTime(2020, 6, 25, 0, 9, 57, 636, DateTimeKind.Local).AddTicks(5704), new DateTime(2020, 6, 25, 14, 11, 20, 913, DateTimeKind.Local).AddTicks(2032), 74, "", "https://alice.com", "officiis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 6, 25, 3, 10, 30, 193, DateTimeKind.Local).AddTicks(1913), new DateTime(2020, 6, 24, 19, 38, 38, 244, DateTimeKind.Local).AddTicks(3599), new DateTime(2020, 6, 25, 9, 23, 22, 69, DateTimeKind.Local).AddTicks(2015), 73, "", "http://hugo.name", "commodi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 6, 24, 22, 8, 41, 689, DateTimeKind.Local).AddTicks(9047), new DateTime(2020, 6, 25, 2, 0, 17, 628, DateTimeKind.Local).AddTicks(3798), new DateTime(2020, 6, 25, 10, 20, 31, 761, DateTimeKind.Local).AddTicks(3517), 72, "", "http://pierre.org", "ducimus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 6, 25, 1, 48, 40, 463, DateTimeKind.Local).AddTicks(9428), new DateTime(2020, 6, 25, 15, 28, 35, 270, DateTimeKind.Local).AddTicks(3159), new DateTime(2020, 6, 25, 12, 19, 45, 330, DateTimeKind.Local).AddTicks(1964), 72, "", "https://mathéo.com", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 6, 24, 20, 1, 27, 617, DateTimeKind.Local).AddTicks(1564), new DateTime(2020, 6, 24, 15, 52, 52, 496, DateTimeKind.Local).AddTicks(9644), new DateTime(2020, 6, 24, 18, 49, 28, 235, DateTimeKind.Local).AddTicks(1127), 71, "", "https://mattéo.info", "ab" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 6, 24, 16, 48, 35, 996, DateTimeKind.Local).AddTicks(2778), new DateTime(2020, 6, 25, 12, 58, 25, 147, DateTimeKind.Local).AddTicks(9884), new DateTime(2020, 6, 24, 20, 32, 49, 564, DateTimeKind.Local).AddTicks(2702), 48, "", "http://lilou.eu", "nihil" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 6, 25, 13, 37, 36, 800, DateTimeKind.Local).AddTicks(6256), new DateTime(2020, 6, 25, 1, 16, 30, 884, DateTimeKind.Local).AddTicks(1166), new DateTime(2020, 6, 25, 7, 24, 4, 422, DateTimeKind.Local).AddTicks(6049), 47, "", "http://alexis.eu", "numquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 6, 24, 18, 34, 47, 123, DateTimeKind.Local).AddTicks(6681), new DateTime(2020, 6, 25, 0, 36, 7, 295, DateTimeKind.Local).AddTicks(3221), new DateTime(2020, 6, 24, 22, 2, 52, 862, DateTimeKind.Local).AddTicks(7916), 99, "", "https://lisa.org", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 6, 25, 10, 59, 28, 716, DateTimeKind.Local).AddTicks(3454), new DateTime(2020, 6, 25, 6, 8, 19, 33, DateTimeKind.Local).AddTicks(3032), new DateTime(2020, 6, 25, 5, 0, 15, 617, DateTimeKind.Local).AddTicks(2692), 44, "", "http://maeva.com", "atque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 6, 25, 5, 44, 13, 613, DateTimeKind.Local).AddTicks(3804), new DateTime(2020, 6, 25, 4, 1, 45, 668, DateTimeKind.Local).AddTicks(487), new DateTime(2020, 6, 24, 15, 51, 36, 852, DateTimeKind.Local).AddTicks(4618), 30, "", "http://baptiste.eu", "harum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 6, 25, 12, 48, 15, 258, DateTimeKind.Local).AddTicks(2815), new DateTime(2020, 6, 24, 19, 47, 16, 734, DateTimeKind.Local).AddTicks(2412), new DateTime(2020, 6, 24, 18, 36, 46, 467, DateTimeKind.Local).AddTicks(6659), 24, "", "https://anaïs.name", "deserunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 6, 25, 4, 39, 3, 381, DateTimeKind.Local).AddTicks(6408), new DateTime(2020, 6, 25, 9, 38, 12, 58, DateTimeKind.Local).AddTicks(4656), new DateTime(2020, 6, 25, 11, 19, 36, 443, DateTimeKind.Local).AddTicks(2099), 24, "", "https://noémie.com", "id" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 6, 25, 7, 32, 46, 279, DateTimeKind.Local).AddTicks(9649), new DateTime(2020, 6, 24, 23, 36, 51, 128, DateTimeKind.Local).AddTicks(5404), new DateTime(2020, 6, 25, 5, 9, 10, 704, DateTimeKind.Local).AddTicks(7262), 23, "", "http://quentin.net", "sequi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 6, 24, 20, 46, 43, 918, DateTimeKind.Local).AddTicks(1324), new DateTime(2020, 6, 25, 6, 35, 31, 305, DateTimeKind.Local).AddTicks(877), new DateTime(2020, 6, 25, 9, 34, 13, 887, DateTimeKind.Local).AddTicks(4082), 98, "", "http://laura.net", "porro" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 6, 25, 7, 2, 47, 127, DateTimeKind.Local).AddTicks(6718), new DateTime(2020, 6, 24, 20, 14, 59, 578, DateTimeKind.Local).AddTicks(3059), new DateTime(2020, 6, 25, 10, 58, 47, 381, DateTimeKind.Local).AddTicks(4321), 22, "", "https://alexis.org", "odio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 6, 25, 3, 1, 22, 18, DateTimeKind.Local).AddTicks(6661), new DateTime(2020, 6, 25, 2, 33, 19, 701, DateTimeKind.Local).AddTicks(2169), new DateTime(2020, 6, 25, 6, 30, 17, 565, DateTimeKind.Local).AddTicks(2444), 21, "", "https://lou.com", "sint" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 6, 25, 13, 34, 14, 171, DateTimeKind.Local).AddTicks(1537), new DateTime(2020, 6, 24, 22, 34, 17, 565, DateTimeKind.Local).AddTicks(3174), new DateTime(2020, 6, 25, 5, 25, 58, 462, DateTimeKind.Local).AddTicks(1291), 19, "", "http://romane.info", "sunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 6, 24, 20, 44, 41, 187, DateTimeKind.Local).AddTicks(2400), new DateTime(2020, 6, 25, 3, 56, 4, 716, DateTimeKind.Local).AddTicks(7319), new DateTime(2020, 6, 25, 1, 16, 36, 562, DateTimeKind.Local).AddTicks(3427), 31, "", "https://eva.fr", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 6, 25, 6, 12, 34, 343, DateTimeKind.Local).AddTicks(2764), new DateTime(2020, 6, 24, 18, 49, 29, 964, DateTimeKind.Local).AddTicks(4329), new DateTime(2020, 6, 25, 2, 56, 40, 101, DateTimeKind.Local).AddTicks(8580), 18, "", "http://mathéo.net", "labore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 6, 24, 15, 53, 57, 715, DateTimeKind.Local).AddTicks(872), new DateTime(2020, 6, 25, 2, 22, 15, 121, DateTimeKind.Local).AddTicks(5763), new DateTime(2020, 6, 25, 12, 6, 22, 562, DateTimeKind.Local).AddTicks(6347), 13, "", "https://léo.fr", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 6, 25, 12, 38, 0, 150, DateTimeKind.Local).AddTicks(7795), new DateTime(2020, 6, 24, 19, 8, 4, 960, DateTimeKind.Local).AddTicks(5150), new DateTime(2020, 6, 24, 21, 35, 20, 444, DateTimeKind.Local).AddTicks(9231), 13, "", "https://eva.org", "autem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 6, 25, 5, 46, 42, 141, DateTimeKind.Local).AddTicks(6067), new DateTime(2020, 6, 25, 6, 37, 9, 568, DateTimeKind.Local).AddTicks(3986), new DateTime(2020, 6, 24, 21, 53, 16, 577, DateTimeKind.Local).AddTicks(9051), 10, "", "https://océane.com", "expedita" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 6, 25, 5, 26, 22, 899, DateTimeKind.Local).AddTicks(6791), new DateTime(2020, 6, 25, 6, 23, 1, 988, DateTimeKind.Local).AddTicks(2654), new DateTime(2020, 6, 25, 5, 19, 5, 248, DateTimeKind.Local).AddTicks(9864), 8, "", "http://zoe.info", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 6, 24, 18, 23, 19, 818, DateTimeKind.Local).AddTicks(4336), new DateTime(2020, 6, 25, 12, 42, 2, 188, DateTimeKind.Local).AddTicks(7201), new DateTime(2020, 6, 25, 8, 6, 5, 217, DateTimeKind.Local).AddTicks(7664), 7, "", "http://lucie.name", "distinctio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 6, 25, 15, 39, 1, 408, DateTimeKind.Local).AddTicks(6780), new DateTime(2020, 6, 25, 3, 59, 6, 17, DateTimeKind.Local).AddTicks(9371), new DateTime(2020, 6, 25, 4, 33, 57, 373, DateTimeKind.Local).AddTicks(8452), 7, "", "https://zoe.net", "eius" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 6, 25, 1, 42, 31, 36, DateTimeKind.Local).AddTicks(5360), new DateTime(2020, 6, 25, 1, 40, 32, 177, DateTimeKind.Local).AddTicks(5154), new DateTime(2020, 6, 25, 5, 34, 43, 660, DateTimeKind.Local).AddTicks(9525), 7, "", "https://thomas.name", "sint" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 6, 25, 14, 52, 57, 172, DateTimeKind.Local).AddTicks(2783), new DateTime(2020, 6, 25, 0, 58, 49, 234, DateTimeKind.Local).AddTicks(3038), new DateTime(2020, 6, 25, 9, 52, 30, 181, DateTimeKind.Local).AddTicks(142), 4, "", "https://alexandre.name", "quae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 6, 24, 22, 43, 27, 38, DateTimeKind.Local).AddTicks(612), new DateTime(2020, 6, 25, 13, 28, 32, 145, DateTimeKind.Local).AddTicks(931), new DateTime(2020, 6, 24, 17, 43, 4, 62, DateTimeKind.Local).AddTicks(9491), 15, "", "http://camille.fr", "quasi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 6, 25, 3, 48, 3, 249, DateTimeKind.Local).AddTicks(7916), new DateTime(2020, 6, 25, 8, 24, 57, 184, DateTimeKind.Local).AddTicks(8311), new DateTime(2020, 6, 24, 20, 23, 43, 467, DateTimeKind.Local).AddTicks(6497), 31, "", "http://maëlle.eu", "earum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 6, 25, 14, 18, 52, 58, DateTimeKind.Local).AddTicks(8725), new DateTime(2020, 6, 24, 16, 23, 39, 827, DateTimeKind.Local).AddTicks(3555), new DateTime(2020, 6, 24, 17, 6, 54, 274, DateTimeKind.Local).AddTicks(5200), 22, "", "https://raphaël.com", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 6, 25, 3, 30, 47, 21, DateTimeKind.Local).AddTicks(5744), new DateTime(2020, 6, 25, 4, 42, 29, 62, DateTimeKind.Local).AddTicks(6966), new DateTime(2020, 6, 25, 1, 35, 15, 882, DateTimeKind.Local).AddTicks(1407), 32, "", "http://gabriel.info", "voluptate" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 6, 25, 7, 16, 7, 471, DateTimeKind.Local).AddTicks(9064), new DateTime(2020, 6, 24, 22, 12, 28, 383, DateTimeKind.Local).AddTicks(1587), new DateTime(2020, 6, 24, 20, 2, 44, 97, DateTimeKind.Local).AddTicks(3557), 44, "", "https://maxime.fr", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 6, 25, 1, 3, 11, 661, DateTimeKind.Local).AddTicks(5213), new DateTime(2020, 6, 24, 17, 44, 32, 680, DateTimeKind.Local).AddTicks(9098), new DateTime(2020, 6, 24, 22, 26, 13, 974, DateTimeKind.Local).AddTicks(4389), 43, "", "http://elisa.org", "dolor" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 6, 25, 3, 22, 56, 802, DateTimeKind.Local).AddTicks(681), new DateTime(2020, 6, 24, 16, 26, 5, 494, DateTimeKind.Local).AddTicks(8378), new DateTime(2020, 6, 25, 1, 18, 28, 119, DateTimeKind.Local).AddTicks(8649), 31, "", "https://enzo.name", "error" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 6, 25, 11, 4, 23, 117, DateTimeKind.Local).AddTicks(1969), new DateTime(2020, 6, 24, 17, 13, 14, 47, DateTimeKind.Local).AddTicks(2592), new DateTime(2020, 6, 24, 16, 12, 41, 342, DateTimeKind.Local).AddTicks(9630), 41, "", "http://mathilde.eu", "laborum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 6, 24, 17, 37, 38, 100, DateTimeKind.Local).AddTicks(1195), new DateTime(2020, 6, 24, 17, 35, 10, 446, DateTimeKind.Local).AddTicks(3647), new DateTime(2020, 6, 25, 11, 50, 57, 701, DateTimeKind.Local).AddTicks(8896), 41, "", "https://arthur.com", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 6, 25, 1, 13, 53, 925, DateTimeKind.Local).AddTicks(2682), new DateTime(2020, 6, 25, 13, 59, 34, 26, DateTimeKind.Local).AddTicks(9034), new DateTime(2020, 6, 24, 22, 30, 46, 557, DateTimeKind.Local).AddTicks(9540), 41, "", "http://pierre.info", "suscipit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 6, 25, 2, 6, 8, 165, DateTimeKind.Local).AddTicks(7719), new DateTime(2020, 6, 24, 22, 50, 47, 159, DateTimeKind.Local).AddTicks(4573), new DateTime(2020, 6, 24, 23, 52, 9, 319, DateTimeKind.Local).AddTicks(1293), 40, "", "http://mohamed.name", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 6, 25, 13, 4, 14, 144, DateTimeKind.Local).AddTicks(4188), new DateTime(2020, 6, 24, 21, 4, 55, 763, DateTimeKind.Local).AddTicks(1705), new DateTime(2020, 6, 24, 23, 14, 14, 273, DateTimeKind.Local).AddTicks(134), 40, "", "http://jade.eu", "accusamus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 6, 24, 19, 22, 35, 764, DateTimeKind.Local).AddTicks(3088), new DateTime(2020, 6, 25, 4, 32, 9, 807, DateTimeKind.Local).AddTicks(3590), new DateTime(2020, 6, 25, 12, 7, 19, 886, DateTimeKind.Local).AddTicks(7606), 40, "", "http://sarah.eu", "itaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 6, 24, 17, 36, 8, 212, DateTimeKind.Local).AddTicks(9805), new DateTime(2020, 6, 25, 4, 56, 29, 366, DateTimeKind.Local).AddTicks(361), new DateTime(2020, 6, 25, 13, 18, 35, 107, DateTimeKind.Local).AddTicks(5356), 42, "", "https://maëlys.org", "molestias" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 6, 25, 9, 2, 56, 993, DateTimeKind.Local).AddTicks(8411), new DateTime(2020, 6, 25, 8, 40, 15, 196, DateTimeKind.Local).AddTicks(6813), new DateTime(2020, 6, 25, 13, 55, 47, 61, DateTimeKind.Local).AddTicks(5753), 40, "", "http://théo.org", "porro" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 6, 25, 8, 38, 42, 992, DateTimeKind.Local).AddTicks(3812), new DateTime(2020, 6, 25, 13, 50, 53, 573, DateTimeKind.Local).AddTicks(8770), new DateTime(2020, 6, 25, 5, 58, 48, 414, DateTimeKind.Local).AddTicks(5264), 39, "", "http://sacha.eu", "minima" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 6, 24, 21, 54, 58, 941, DateTimeKind.Local).AddTicks(1296), new DateTime(2020, 6, 25, 13, 10, 19, 710, DateTimeKind.Local).AddTicks(6135), new DateTime(2020, 6, 25, 15, 10, 45, 665, DateTimeKind.Local).AddTicks(6702), 37, "", "https://mael.com", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 6, 25, 0, 9, 6, 216, DateTimeKind.Local).AddTicks(8598), new DateTime(2020, 6, 25, 3, 56, 0, 408, DateTimeKind.Local).AddTicks(4825), new DateTime(2020, 6, 25, 2, 30, 48, 562, DateTimeKind.Local).AddTicks(4600), 37, "", "https://mélissa.org", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 6, 25, 10, 13, 32, 210, DateTimeKind.Local).AddTicks(466), new DateTime(2020, 6, 24, 19, 48, 47, 774, DateTimeKind.Local).AddTicks(4484), new DateTime(2020, 6, 25, 12, 45, 19, 150, DateTimeKind.Local).AddTicks(4364), 37, "", "https://baptiste.info", "labore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 6, 25, 2, 12, 1, 376, DateTimeKind.Local).AddTicks(9931), new DateTime(2020, 6, 25, 15, 22, 18, 334, DateTimeKind.Local).AddTicks(9115), new DateTime(2020, 6, 25, 15, 27, 48, 230, DateTimeKind.Local).AddTicks(48), 35, "", "https://maëlys.info", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 6, 25, 1, 26, 44, 400, DateTimeKind.Local).AddTicks(1424), new DateTime(2020, 6, 24, 16, 7, 45, 425, DateTimeKind.Local).AddTicks(4163), new DateTime(2020, 6, 25, 12, 25, 33, 862, DateTimeKind.Local).AddTicks(2361), 34, "", "http://mathis.info", "quibusdam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 6, 25, 0, 48, 1, 187, DateTimeKind.Local).AddTicks(9837), new DateTime(2020, 6, 25, 10, 34, 32, 461, DateTimeKind.Local).AddTicks(5352), new DateTime(2020, 6, 25, 12, 19, 11, 954, DateTimeKind.Local).AddTicks(8572), 34, "", "http://mattéo.name", "corporis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 6, 25, 1, 35, 27, 336, DateTimeKind.Local).AddTicks(9301), new DateTime(2020, 6, 25, 0, 33, 49, 854, DateTimeKind.Local).AddTicks(2688), new DateTime(2020, 6, 24, 20, 48, 31, 637, DateTimeKind.Local).AddTicks(1823), 32, "", "http://lilou.net", "corporis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 6, 25, 3, 54, 46, 472, DateTimeKind.Local).AddTicks(9067), new DateTime(2020, 6, 25, 15, 47, 37, 205, DateTimeKind.Local).AddTicks(2899), new DateTime(2020, 6, 25, 0, 44, 35, 9, DateTimeKind.Local).AddTicks(4722), 40, "", "https://anaïs.name", "dolor" });

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
                values: new object[] { 4, "1.4.5.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 1, null, 6, 3, 1, 5, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 39, "8.2.2.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 92, 1, 9, null, 3, 4, 3, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 34, "5.9.4.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 36, 3, null, 3, 2, 4, 10, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 10, "8.0.7.6", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 1, null, 2, 4, 4, 7, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 2, "7.0.0.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 100, 1, 2, 3, 3, 4, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 89, "7.4.9.0", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 7, 10, 5, 4, 10, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 86, "9.1.4.5", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 1, 5, 3, 3, 10, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 82, "7.9.1.4", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 3, null, 6, 4, 10, 10, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 75, "7.3.1.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 3, 2, null, 3, 10, 1, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 49, "8.6.4.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 2, null, 5, 4, 10, 10, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 42, "9.6.3.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 4, 5, null, 1, 10, 8, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 29, "1.8.5.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 50, 3, 2, 1, 4, 10, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 1, "0.1.9.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 32, 7, null, 6, 2, 10, 7, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 99, "4.6.6.9", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 21, 2, 9, null, 1, 9, 7, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 98, "2.9.5.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 63, 5, 10, 3, 3, 9, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 97, "4.9.2.9", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 5, null, 1, 3, 9, 9, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 84, "7.5.8.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 50, 5, 4, null, 1, 9, 7, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 76, "7.9.3.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 91, 2, null, 5, 3, 9, 3, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 71, "0.5.7.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 36, 6, 9, 5, 1, 9, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 68, "6.2.4.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 96, 5, 10, 3, 4, 9, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 62, "0.9.8.6", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 3, 1, 5, 1, 9, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 57, "0.9.2.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 31, 3, 9, null, 2, 9, 8, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 51, "3.9.0.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 38, 6, 5, null, 2, 4, 6, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 70, "8.8.7.4", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 73, 1, null, 3, 3, 4, 1, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 81, "6.7.7.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 55, 4, 9, null, 4, 4, 10, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 85, "7.3.4.9", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 2, null, 4, 1, 4, 8, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 91, "2.0.7.9", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 77, 3, null, 1, 1, 6, 10, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 88, "2.6.5.1", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 55, 2, null, 1, 2, 6, 7, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 78, "4.3.5.5", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 80, 7, 9, null, 3, 6, 1, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 60, "3.0.0.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 1, 5, null, 2, 6, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 46, "1.7.8.1", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 1, null, 1, 2, 6, 8, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 45, "3.1.7.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 57, 1, 5, null, 4, 6, 8, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 33, "9.2.0.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 1, 2, null, 2, 6, 8, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 24, "7.1.9.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 1, 1, null, 3, 6, 8, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 19, "3.5.3.2", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 5, null, 4, 3, 6, 10, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 18, "9.2.9.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 7, 2, null, 4, 6, 5, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 43, "2.4.5.6", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 5, null, 1, 3, 9, 7, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 6, "0.0.0.2", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 3, 3, null, 2, 6, 4, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 87, "1.5.3.3", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 81, 1, 1, null, 3, 5, 10, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 79, "6.0.6.3", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 58, 5, null, 3, 3, 5, 1, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 65, "7.1.1.6", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 3, 7, 1, 4, 5, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 44, "5.1.2.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 63, 4, 3, 2, 2, 5, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 38, "1.5.8.7", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 79, 5, 1, 3, 2, 5, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 36, "9.8.9.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 57, 6, 4, null, 4, 5, 5, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 31, "3.2.8.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 6, null, 2, 2, 5, 3, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 25, "1.4.6.6", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 3, null, 2, 2, 5, 5, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 7, "2.0.5.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 9, 1, null, 1, 1, 5, 2, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 96, "5.1.4.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 6, 1, null, 3, 4, 8, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 92, "8.6.1.0", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 16, 6, 4, 6, 1, 5, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 30, "8.0.6.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 81, 3, 1, null, 4, 9, 9, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 93, "0.1.9.2", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 7, 3, null, 1, 6, 5, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 8, "5.2.6.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 6, 4, 4, 4, 9, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 95, "9.9.4.9", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 9, 2, 1, 1, 2, 2, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 80, "7.6.9.1", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 83, 3, 7, 3, 3, 2, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 73, "6.8.1.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 73, 3, null, 4, 4, 2, 9, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 61, "1.9.4.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 5, null, 2, 3, 2, 10, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 59, "6.1.6.2", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 4, 4, 5, 3, 2, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 58, "8.6.4.0", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 31, 3, null, 1, 4, 2, 2, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 56, "7.6.3.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 7, 1, 2, 4, 2, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 53, "8.7.1.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 21, 3, 5, 6, 2, 2, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 26, "4.0.9.3", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 6, 4, 4, 2, 2, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 17, "5.2.7.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 2, 6, 4, 2, 2, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 16, "7.2.8.2", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 42, 3, null, 2, 3, 2, 6, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 14, "3.7.5.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 13, 7, 10, 2, 3, 2, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 12, "5.5.3.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 75, 2, 10, null, 1, 2, 7, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 11, "0.7.3.0", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 38, 7, 8, 5, 4, 2, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 9, "3.4.2.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 92, 1, 8, null, 3, 2, 3, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 100, "6.8.6.6", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 89, 5, null, 4, 1, 1, 3, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 94, "1.7.2.7", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 7, null, 5, 3, 1, 1, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 90, "5.3.1.7", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 16, 6, 10, null, 2, 1, 2, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 83, "4.3.1.1", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 1, 6, 5, 4, 1, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 22, "7.3.8.6", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 2, null, 2, 3, 1, 6, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 15, "6.0.8.4", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 90, 2, 7, null, 4, 9, 2, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 5, "5.8.8.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 3, 4, 4, 4, 3, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 21, "2.8.6.7", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 83, 7, 9, null, 4, 3, 3, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 37, "9.7.2.0", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 19, 6, null, 6, 1, 2, 1, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 35, "7.6.9.7", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 96, 7, 8, 2, 3, 3, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 28, "7.6.8.8", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 2, null, 5, 1, 3, 5, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 77, "1.2.7.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 5, 9, 4, 1, 8, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 74, "7.0.6.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 12, 7, 4, 5, 3, 8, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 63, "6.5.7.7", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 8, 1, 7, null, 1, 8, 6, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 50, "8.9.4.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 75, 5, 4, 2, 4, 8, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 47, "1.0.2.2", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 6, 7, 5, 3, 4, 8, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 41, "3.5.6.7", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 5, 3, 10, 6, 3, 8, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 20, "9.6.1.2", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 5, 8, 3, 2, 8, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 72, "0.7.3.4", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 3, 5, null, 4, 7, 7, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 66, "9.7.9.9", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 1, 7, null, 3, 7, 5, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 64, "3.4.6.8", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 21, 6, null, 3, 1, 7, 4, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 32, "6.4.9.5", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 2, 6, 1, 3, 8, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 3, "0.8.0.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 7, 9, null, 1, 9, 7, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 52, "3.0.9.5", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 64, 3, null, 5, 4, 7, 8, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 48, "3.1.2.8", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 47, 2, 6, null, 3, 3, 2, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 54, "4.5.4.7", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 75, 2, 2, null, 3, 3, 9, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 55, "1.6.0.8", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 7, null, 4, 3, 3, 4, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 67, "3.9.1.6", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 1, null, 6, 4, 3, 9, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 40, "6.1.4.9", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 0, 6, null, 2, 4, 3, 5, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 13, "6.2.1.8", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 15, 2, null, 6, 4, 7, 8, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 23, "2.6.4.9", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 86, 6, 8, 5, 4, 7, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 27, "9.4.4.0", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 73, 7, 4, null, 1, 7, 6, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 69, "5.1.9.4", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 52, 6, 3, null, 1, 3, 9, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "quia", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 76, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "minima", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 65, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 65, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "rerum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 65, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 65, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "omnis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 93, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "magnam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 93, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "dolorem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 97, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "quia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 79, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "omnis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 75, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "quidem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 91, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "est", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 37, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "aut", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 18, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "enim", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 18, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "sit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 18, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "aut", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 87, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "vero", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 25, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "dolore", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 25, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "molestias", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 94, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "quisquam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 29, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "dolor", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 82, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "dolorum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 64, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "qui", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 82, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "rerum", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 45, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "pariatur", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 95, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "fuga", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 17, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "fugit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 80, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "rerum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 43, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "consectetur", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 43, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "dicta", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 7, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "quibusdam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 55, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "ullam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 39, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "enim", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 39, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "ut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 11, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "voluptas", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 11, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "et", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 95, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "quo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 2, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "rerum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 66, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "molestiae", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 66, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "aut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 66, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "similique", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 31, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "molestiae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 8, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "fugiat", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 88, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "nemo", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 30, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "nisi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 30, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 99, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "quia", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 95, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "et", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 32, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "veniam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 20, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "nulla", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 14, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "sint", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 58, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "harum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 89, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "ratione", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 9, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "mollitia", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 40, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 40, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "minima", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 40, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "cupiditate", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 69, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "itaque", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "modi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 10, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "maiores", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 10, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "aliquid", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 10, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "aut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 23, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "eius", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 33, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 33, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "est", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 52, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "sit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 56, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "ducimus", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 67, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "alias", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 67, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "totam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 67, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "iure", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 73, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "ex", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 24, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "dolore", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 45, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "itaque", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 89, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "nulla", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 78, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "ad", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 81, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "est", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 72, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "excepturi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 53, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "laborum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 53, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "adipisci", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 84, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 84, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "culpa", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 22, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "blanditiis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 22, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "quia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 59, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "consequatur", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 15, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "placeat", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 15, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "impedit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 15, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "labore", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 28, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "sequi", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 16, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "quia", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 74, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "cum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 63, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "laborum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 85, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "blanditiis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 36, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "nemo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 92, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "facere", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 51, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "molestiae", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 14, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "architecto", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 14, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "vel", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 14, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "veniam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 47, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "officia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 16, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "atque", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 45, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/el-salvador/cambridgeshire", 5, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/borders/money-market-account", 7, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/transmitter/switchable/executive", 1, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/intelligent-concrete-soap/south-carolina/rue", 4, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/principal", 5, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/value-added/end-to-end/cordoba-oro", 6, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/global/groupware/refined", 4, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/investment-account/overriding", 5, 79 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/ftp", 4, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/generic-fresh-salad/associate", 7, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/frictionless/auto-loan-account/manager", 7, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/cambridgeshire/architect", 6, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/fall", 4, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/synergize", 4, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/soft/program/panel", 1, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/wireless", 5, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/extend", 1, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/grow/democratic-peoples-republic-of-korea/mobility", 7, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/future/reduced", 2, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/sas/engineer/checking-account", 2, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/chief/central/credit-card-account", 7, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/paradigms", 6, 42 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/awesome-concrete-ball", 4, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/branding/payment/invoice", 5, 42 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/compressing", 7, 71 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/reciprocal/moderator/licensed-wooden-bike", 7, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/rss/gorgeous", 7, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/programming/mint-green/locks", 6, 52 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/street/rhode-island", 1, 52 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/integrate", 4, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/virtual", 6, 63 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/24365", 4, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/money-market-account", 4, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/automotive-jewelery--automotive/redefine", 1, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/primary/clicks-and-mortar/south-carolina", 1, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/configuration/west-virginia/lilangeni", 5, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/web-services/kids-toys--computers", 5, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/reciprocal", 4, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/fantastic-wooden-chicken", 2, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/transmit/alarm", 1, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/toys/outdoors/walk", 1, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/small", 7, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/bypassing/solutions", 7, 68 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/payment", 4, 68 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/matrix", 1, 87 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/reboot/deposit", 3, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/plastic/firewall", 3, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/handmade/4th-generation/gorgeous", 3, 46 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/users", 6, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/stream", 3, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/borders/investor", 1, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/tasty-frozen-table", 7, 15 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/actuating/responsive", 1, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/electronics--electronics/directional", 6, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/needs-based", 4, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/planner", 1, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/personal-loan-account/feed/reintermediate", 3, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/withdrawal", 1, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/reintermediate/bedfordshire", 4, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/group/multi-tasking/refined-plastic-pants", 2, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/soft/jewelery", 4, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/licensed/face-to-face", 2, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/discrete", 3, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/system-worthy", 3, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/transparent", 5, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/technologies", 3, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/pine/ohio/games-baby--kids", 6, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/technologies/invoice", 4, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/implementation/shoes/international", 7, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/experiences", 3, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/channels/creek", 2, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/calculate/reboot", 6, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/microchip/cyan", 3, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/liberia/park", 1, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/netherlands-antillian-guilder/shoal", 6, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/bedfordshire/future/buckinghamshire", 7, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/pennsylvania/outdoors-garden--automotive/array", 6, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/quantify", 6, 51 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/fiji/investment-account", 7, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/cloned", 4, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/designer", 3, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/bandwidth", 6, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/iran/iowa/berkshire", 3, 40 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/intelligent-metal-soap", 7, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/matrix/bedfordshire/australian-dollar", 6, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/way/group", 7, 83 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/persevering/camp", 1, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/generate", 2, 83 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/home-loan-account/mint-green/handcrafted", 4, 96 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/rubber/clothing-outdoors--outdoors/composite", 6, 96 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/liberian-dollar", 2, 96 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/content/brand", 1, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/copy/deposit/plastic", 3, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/calculate/harness", 1, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/puerto-rico/niger", 5, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/developer/granite/input", 1, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/auto-loan-account/backing-up/quality-focused", 4, 33 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/maroon/mozambique/system", 4, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/capability/input", 7, 83 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/functionalities", 2, 88 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 2, new DateTime(2020, 4, 4, 19, 40, 14, 87, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 6, new DateTime(2019, 11, 1, 11, 33, 53, 495, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 1, new DateTime(2020, 2, 11, 10, 54, 17, 576, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 5, new DateTime(2019, 11, 24, 3, 45, 11, 784, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 1, new DateTime(2020, 1, 8, 13, 24, 12, 91, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 5, new DateTime(2019, 6, 29, 3, 56, 40, 38, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 4, new DateTime(2019, 12, 11, 15, 0, 13, 544, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 3, new DateTime(2020, 1, 18, 22, 41, 32, 94, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 3, new DateTime(2019, 9, 26, 8, 33, 43, 127, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 5, new DateTime(2020, 6, 3, 9, 52, 56, 149, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 6, new DateTime(2019, 11, 8, 9, 44, 35, 458, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 6, new DateTime(2019, 12, 20, 9, 41, 44, 370, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 1, new DateTime(2020, 4, 22, 21, 23, 2, 941, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 2, new DateTime(2020, 2, 17, 16, 53, 37, 724, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 4, new DateTime(2019, 10, 30, 15, 29, 40, 19, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 3, new DateTime(2020, 5, 14, 5, 40, 17, 708, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 4, new DateTime(2019, 11, 12, 6, 21, 48, 544, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 3, new DateTime(2020, 1, 16, 14, 35, 41, 133, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 5, new DateTime(2020, 1, 22, 18, 14, 13, 508, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 4, new DateTime(2019, 11, 30, 9, 54, 37, 408, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 6, new DateTime(2020, 5, 8, 18, 8, 25, 984, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 6, new DateTime(2019, 8, 16, 23, 22, 34, 862, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 6, new DateTime(2020, 6, 16, 1, 54, 11, 872, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 4, new DateTime(2020, 1, 30, 7, 22, 35, 625, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 5, new DateTime(2020, 2, 19, 19, 31, 55, 997, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 1, new DateTime(2020, 4, 3, 6, 48, 7, 848, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 6, new DateTime(2019, 11, 25, 15, 59, 40, 335, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 6, new DateTime(2019, 9, 11, 7, 17, 6, 894, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 5, new DateTime(2020, 4, 9, 7, 54, 31, 374, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 2, new DateTime(2019, 9, 12, 3, 56, 45, 819, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 3, new DateTime(2019, 12, 28, 3, 15, 5, 201, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 6, new DateTime(2019, 10, 12, 7, 18, 15, 228, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 1, new DateTime(2020, 5, 28, 11, 10, 35, 905, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 5, new DateTime(2019, 11, 18, 1, 2, 28, 390, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 6, new DateTime(2019, 8, 13, 3, 24, 55, 543, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 6, new DateTime(2019, 8, 17, 1, 53, 16, 389, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 3, new DateTime(2020, 1, 9, 11, 12, 22, 48, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 1, new DateTime(2019, 9, 23, 5, 30, 14, 545, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 1, new DateTime(2019, 10, 18, 23, 47, 0, 717, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 4, new DateTime(2019, 12, 27, 12, 35, 17, 67, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 6, new DateTime(2020, 5, 7, 16, 0, 14, 896, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 4, new DateTime(2020, 3, 6, 8, 31, 10, 62, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 5, new DateTime(2019, 7, 26, 19, 31, 26, 899, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 4, new DateTime(2019, 7, 6, 4, 28, 16, 945, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 5, new DateTime(2020, 2, 9, 16, 6, 51, 713, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 6, new DateTime(2020, 4, 27, 21, 14, 29, 906, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 4, new DateTime(2019, 10, 7, 21, 39, 39, 777, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 4, new DateTime(2020, 4, 29, 18, 21, 58, 659, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 1, new DateTime(2019, 11, 29, 17, 19, 1, 672, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 1, new DateTime(2020, 3, 17, 5, 17, 55, 660, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 2, new DateTime(2020, 6, 5, 19, 29, 5, 176, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 2, new DateTime(2020, 6, 2, 0, 53, 26, 17, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 6, new DateTime(2019, 9, 14, 10, 31, 8, 915, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 5, new DateTime(2019, 10, 15, 15, 31, 3, 230, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 4, new DateTime(2020, 3, 5, 9, 34, 47, 274, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 6, new DateTime(2019, 7, 28, 0, 53, 16, 241, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 3, new DateTime(2019, 12, 22, 13, 34, 0, 238, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 1, new DateTime(2019, 7, 21, 19, 59, 58, 620, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 6, new DateTime(2020, 5, 9, 5, 41, 34, 520, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 4, new DateTime(2020, 2, 1, 13, 13, 39, 155, DateTimeKind.Local).AddTicks(8413) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 5, new DateTime(2020, 3, 1, 23, 33, 11, 771, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 2, new DateTime(2019, 9, 5, 14, 35, 34, 869, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 1, new DateTime(2020, 4, 6, 4, 36, 10, 157, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 3, new DateTime(2019, 8, 8, 17, 26, 4, 546, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 4, new DateTime(2019, 9, 11, 4, 44, 25, 414, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 5, new DateTime(2019, 8, 22, 4, 14, 9, 3, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 6, new DateTime(2020, 5, 14, 17, 44, 58, 979, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 3, new DateTime(2019, 12, 3, 18, 23, 26, 900, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 2, new DateTime(2020, 4, 13, 16, 9, 47, 252, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 4, new DateTime(2020, 1, 5, 16, 26, 35, 630, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 3, new DateTime(2019, 7, 16, 14, 31, 4, 565, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 3, new DateTime(2019, 12, 9, 6, 2, 30, 165, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 6, new DateTime(2019, 7, 23, 11, 59, 53, 636, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 1, new DateTime(2019, 7, 24, 10, 21, 1, 396, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 4, new DateTime(2020, 2, 27, 21, 6, 0, 123, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 5, new DateTime(2020, 5, 6, 16, 39, 51, 780, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 5, new DateTime(2020, 5, 26, 13, 31, 39, 41, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 2, new DateTime(2019, 10, 20, 16, 52, 14, 761, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 6, new DateTime(2019, 7, 14, 15, 31, 13, 305, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 2, new DateTime(2020, 5, 2, 17, 27, 48, 234, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 1, new DateTime(2019, 7, 29, 8, 18, 11, 645, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 4, new DateTime(2020, 6, 7, 19, 23, 0, 867, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 1, new DateTime(2019, 7, 6, 2, 33, 41, 778, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 5, new DateTime(2020, 1, 28, 3, 32, 5, 705, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 6, new DateTime(2020, 5, 15, 15, 29, 40, 602, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 1, new DateTime(2019, 10, 23, 22, 21, 29, 98, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 2, new DateTime(2020, 3, 26, 0, 20, 7, 50, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 5, new DateTime(2020, 3, 26, 19, 17, 14, 970, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 3, new DateTime(2020, 6, 8, 19, 52, 50, 132, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 6, new DateTime(2019, 10, 26, 5, 23, 6, 72, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 6, new DateTime(2020, 2, 29, 12, 40, 41, 96, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 5, new DateTime(2019, 8, 17, 23, 36, 2, 845, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 5, new DateTime(2020, 1, 24, 6, 27, 20, 202, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 3, new DateTime(2020, 5, 7, 6, 3, 31, 749, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 5, new DateTime(2019, 11, 17, 17, 47, 43, 783, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 6, new DateTime(2019, 9, 28, 23, 38, 24, 537, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 4, new DateTime(2019, 6, 29, 21, 3, 15, 508, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 5, new DateTime(2019, 8, 4, 5, 9, 23, 790, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 2, new DateTime(2020, 1, 2, 21, 20, 13, 881, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 3, new DateTime(2020, 4, 11, 16, 33, 25, 261, DateTimeKind.Local).AddTicks(7565) });

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
