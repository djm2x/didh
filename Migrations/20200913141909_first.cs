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
                    Label = table.Column<string>(nullable: true),
                    LabelAr = table.Column<string>(nullable: true)
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
                    NomAr = table.Column<string>(nullable: true),
                    CodeRecommendation = table.Column<string>(nullable: false),
                    CodeRecommendationAr = table.Column<string>(nullable: true),
                    Mecanisme = table.Column<string>(nullable: false),
                    IdCycle = table.Column<int>(nullable: true),
                    IdAxe = table.Column<int>(nullable: false),
                    IdSousAxe = table.Column<int>(nullable: true),
                    IdOrgane = table.Column<int>(nullable: true),
                    IdVisite = table.Column<int>(nullable: true),
                    IdPays = table.Column<int>(nullable: true),
                    Etat = table.Column<string>(nullable: false),
                    EtatAvancement = table.Column<string>(nullable: true),
                    EtatAvancementChiffre = table.Column<int>(nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    Complement = table.Column<string>(nullable: true),
                    PieceJointe = table.Column<string>(nullable: true),
                    Annee = table.Column<int>(nullable: true)
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
                values: new object[] { 1, "la promotion, le développement démocratique et la primauté du droit", "تعزيز البناء الديمقراطي وسيادة القانون" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 2, "l’interaction avec le système onusien des droits de l'homme", "مواصلة الانخراط والتعاون مع المنظومة الأممية لحقوق الإنسان" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 3, "la promotion et la protection des droits de l'homme, à travers la législation et l’harmonisation avec les normes internationales, constitué d’un sous-thème se rapportant à la législation", "النهوض بحقوق الإنسان وحمايتها عبر التشريع والملاءمة مع المعايير الدولية" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 4, "la promotion des droits économiques, sociaux, culturels et environnementaux", "النهوض بالحقوق الاقتصادية والاجتماعية والثقافية والبيئية" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 5, "la protection et la promotion des droits civils et politiques", "حماية الحقوق المدنية والسياسية والنهوض بها" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 6, "la promotion et la protection des droits catégoriels", "النهوض بالحقوق الفئوية وحمايتها" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 7, "la promotion de la culture des droits de l'homme par l'éducation et la formation", "النهوض بثقافة حقوق الإنسان من خلال التربية والتكوين" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 8, "la promotion du cadre institutionnel pour la protection et la promotion des droits de l'homme", "الإطار المؤسساتي لحماية حقوق الإنسان والنهوض بها" });

            migrationBuilder.InsertData(
                table: "Axes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 9, "des recommandations d'ordre général", "التوصيات العامة" });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 1, "3ème cycle (2017-2022)", "الجولة الثالثة من آلية الاستعراض الدوري الشامل  )شتنبر 2017)" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 9, "Le Sous-Comité pour la prévention de la torture (SPT)", "اللجنة الفرعية لمنع التعذيب (SPT)" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 8, "Comité des droits des personnes handicapées (CRPD)", "اللجنة المعنية بحقوق الأشخاص ذوي الإعاقة (CRPD)" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 7, "Le Comité des droits de l'enfant (CRC)", "لجنة حقوق الطفل (CRC)" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 6, "Le Comité pour l'élimination de la discrimination à l'égard des femmes (CEDAW)", "لجنة القضاء على التمييز ضد المرأة (CEDAW)" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 5, "Le Comité des travailleurs migrants (CMW)", "اللجنة المعنية بالعمال المهاجرين (CMW)" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 4, "Le Comité des droits économiques, sociaux et culturels  (CESCR)", "لجنة الحقوق الاقتصادية والاجتماعية والثقافية (CESCR)" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 3, "Le Comité des droits de l'homme (CCPR)", "اللجنة المعنية بحقوق الإنسان (CCPR)" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 2, "Le Comité contre la torture (CAT)", "لجنة مناهضة التعذيب (CAT)" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 1, "Le Comité pour l’élimination de la discrimination raciale (CERD)", "لجنة القضاء على التمييز العنصري (CERD)" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 29, "", "Marocains Résidant à l’Etranger", "المغاربة المقيمون بالخارج", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 30, "", "Médiateur", "الوسيط", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 31, "", "Observatoire National des Droits de l’Enfant", "المرصد الوطني لحقوق الطفل", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 32, "", "Parlement", "البرلمان", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 33, "", "Santé", "الصحة", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 34, "", "Tourisme", "السياحة", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 35, "", "Transport", "النقل", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 36, "", "IRCAM", "المعهد الملكي للثقافة الأمازيغية", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 38, "", "Relations avec parlement", "العلاقات مع البرلمان", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 39, "", "Agriculture", "الفلاحة", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 40, "", "Education nationale", "التربية الوطنية", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 51, "", "Affaires générales du gouvernement", "undefined", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 43, "", "ANELCA", "الوكالة الوطنية لمحاربة الأمية", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 44, "", "Conseil Supérieur de l’Education, de la Formation et de la Recherche Scientifique", "المجلس الأعلى للتربية والتكوين والبحث العلمي", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 45, "", "Conseil Economique Social et Environnemental", "المجلس الاقتصادي والاجتماعي والبيئي", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 46, "", "Environnement", "البيئة", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 47, "", "Pêche maritime", "الصيد البحري", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 48, "", "Conseil de la communauté marocaine à l’étranger", "مجلس الجالية المغربية بالخارج", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 49, "", "ONGs", "undefined", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 50, "", "Partis Politiques", "undefined", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 28, "", "Justice", "العدل", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 52, "", "Rabita Mohammedia des Oulémas", "undefined", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 53, "", "Eaux et Forets", "undefined", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 41, "", "Formation professionnelle", "التكوين المهني", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 27, "", "Jeunesse et Sports", "الشباب والرياضة", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 42, "", "Enseignement supérieur", "التعليم العالي", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 25, "", "HACA", "الهيأة العليا للاتصال السمعي البصري", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 26, "", "Intérieur", "الداخلية", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 1, "", "HCP", "المندوبية السامية للتخطيط", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 3, "", "Affaires Etrangères", "الشؤون الخارجية", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 4, "", "CNDH", "المجلس الوطني لحقوق الإنسان", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 5, "", "Communication", "الاتصال", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 6, "", "Présidence du Ministère Public", "رئاسة النيابة العامة", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 7, "", "Chef du Gouvernement", "رئاسة الحكومة", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 8, "", "Commerce et Industrie", "التجارة والصناعة", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 9, "", "Conseil Supérieur de l’Autorité Judiciaire", "المجلس الأعلى للسلطة القضائية", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 10, "", "Culture", "الثقافة", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 11, "", "Défense Nationale", "الدفاع الوطني", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 12, "", "Développement Social et Solidarité", "التنمية الاجتماعية والتضامن", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 2, "", "INPPLC", "الهيئة الوطنية للنزاهة و الوقاية من الرشوة و محاربتها", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 24, "", "Habous et des Affaires Islamiques", "الأوقاف والشؤون الإسلامية", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 14, "", "DGSN", "الأمن الوطني", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 15, "", "Droits de l’Homme", "حقوق الإنسان", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 16, "", "Eau", "الماء", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 17, "", "Economie et Finances", "الاقتصاد والمالية", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 18, "", "Emploi", "الشغل", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 19, "", "Energie et Mines", "الطاقة والمعادن", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 20, "", "Equipement", "التجهيز", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 21, "", "Fonction Publique", "الوظيفة العمومية", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 22, "", "Gendarmerie Royale", "الدرك الملكي", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 23, "", "Habitat", "السكنى", "" });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel" },
                values: new object[] { 13, "", "DGAPR", "إدارة السجون", "" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 68, "Pakistan", "باكستان" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 69, "Paraguay", "باراغواي" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 70, "Pays-Bas", "هولندا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 75, "République centrafricaine", "جمهورية أفريقيا الوسطى" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 72, "Philippines", "الفلبين" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 73, "Portugal", "البرتغال" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 74, "Qatar", "دولة قطر" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 67, "Ouganda", "أوغندا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 71, "Pérou", "بيرو" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 55, "Libye", "ليبيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 61, "Monténégro", "الجبل الأسود" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 65, "Norvège", "النرويج" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 64, "Niger", "النيجر" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 63, "Namibie", "ناميبيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 62, "Myanmar", "ميانمار" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 60, "Mexique", "المكسيك" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 59, "Mauritanie", "موريتانيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 58, "Maurice", "موريشيوس" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 57, "Maldives", "جزر المالديف" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 56, "Madagascar", "مدغشقر" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 76, "République de Corée", "جمهورية كوريا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 66, "Oman", "سلطنة عمان" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 77, "République démocratique populaire lao", "جمهورية لاو الديمقراطية الشعبية" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 90, "Suisse", "سويسري" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 79, "Roumanie", "رومانيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 54, "Liban", "لبنان" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 101, "Irlande", "" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 100, "Arménie", "" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 99, "Sri Lanka", "" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 98, "Zambie", "زامبيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 97, "Yémen", "اليمن" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 96, "Viet Nam", "فييت نام" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 95, "Ukraine", "أوكرانيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 94, "Turquie", "تركيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 93, "Tunisie", "تونس" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 78, "République islamique d’Iran", "جمهورية ايران الاسلامية" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 92, "Togo", "توجو" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 89, "Suède", "السويد" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 88, "Soudan du Sud", "جنوب السودان" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 87, "Soudan", "السودان" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 86, "Slovénie", "سلوفينيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 85, "Singapour", "سنغافورة" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 84, "Sierra Leone", "سيراليون" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 83, "Serbie", "صربيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 82, "Sénégal", "السنغال" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 81, "Rwanda", "رواندا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 80, "Royaume-Uni de Grande-Bretagne et d’Irlande du Nord", "المملكة المتحدة لبريطانيا العظمى وأيرلندا الشمالية" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 91, "Thaïlande", "تايلاند" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 53, "Lettonie", "لاتفيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 19, "Chine", "الصين" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 51, "Kenya", "كينيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 22, "Côte d’Ivoire", "ساحل العاج" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 52, "Koweït", "الكويت" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 20, "Chypre", "قبرص" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 18, "Chili", "تشيلي" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 17, "Canada", "كندا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 16, "Burundi", "بوروندي" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 15, "Brunéi Darussalam", "بروناي دار السلام" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 14, "Brésil", "البرازيل" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 13, "Botswana", "بوتسوانا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 12, "Belgique", "بلجيكا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 11, "Bangladesh", "بنغلاديش" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 10, "Bahreïn", "البحرين" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 9, "Azerbaïdjan", "أذربيجان" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 8, "Autriche", "النمسا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 7, "Australie", "أستراليا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 6, "Argentine", "الأرجنتين" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 5, "Arabie saoudite", "العربية السعودية" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 4, "Angola", "أنغولا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 3, "Allemagne", "ألمانيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 2, "Albanie", "ألبانيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 1, "Afrique du Sud", "إفريقيا الجنوبية" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 23, "Croatie", "كرواتيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 25, "Cuba", "كوبا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 21, "Congo", "الكونغو" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 27, "Djibouti", "جيبوتي" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 50, "Jordanie", "الأردن" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 49, "Italie", "إيطاليا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 48, "Islande", "أيسلندا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 47, "Iraq", "العراق" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 46, "Indonésie", "إندونيسيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 45, "Hongrie", "هنغاريا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 44, "Honduras", "هندوراس" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 26, "Danemark", "الدنمارك" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 42, "Guatemala", "غواتيمالا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 41, "Grèce", "اليونان" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 40, "Ghana", "غانا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 43, "Haïti", "هايتي" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 37, "Gabon", "الغابون" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 28, "Égypte", "مصر" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 38, "Géorgie", "جورجيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 30, "Équateur", "إكوادور" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 31, "Espagne", "إسبانيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 29, "Émirats arabes unis", "الإمارات العربية المتحدة" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 33, "État de Palestine", "دولة فلسطين" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 34, "États-Unis d’Amérique", "الولايات المتحدة الأمريكية" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 35, "Éthiopie", "أثيوبيا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 36, "France", "فرنسا" });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[] { 32, "Estonie", "إستونيا" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 8, new DateTime(2020, 9, 13, 15, 19, 7, 924, DateTimeKind.Local).AddTicks(8015), "", "", "", "l’experte indépendante dans le domaine des droits culturels", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 1, new DateTime(2020, 9, 13, 15, 19, 7, 922, DateTimeKind.Local).AddTicks(3015), "", "", "", "la Rapporteuse spéciale sur le droit à l’alimentation", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 2, new DateTime(2020, 9, 13, 15, 19, 7, 924, DateTimeKind.Local).AddTicks(8015), "", "", "", "Rapporteuse spéciale sur les formes contemporaines de racisme, de discrimination raciale, de xénophobie et de l’intolérance qui y est associée", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 3, new DateTime(2020, 9, 13, 15, 19, 7, 924, DateTimeKind.Local).AddTicks(8015), "", "", "", "Rapporteur spécial sur la torture et autres peines ou traitements cruels, inhumains ou dégradants", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 4, new DateTime(2020, 9, 13, 15, 19, 7, 924, DateTimeKind.Local).AddTicks(8015), "", "", "", "la Rapporteuse spéciale sur la traite des êtres humains, en particulier les femmes et les enfants", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 5, new DateTime(2020, 9, 13, 15, 19, 7, 924, DateTimeKind.Local).AddTicks(8015), "", "", "", "Rapporteuse spéciale sur les formes contemporaines de racisme, de discrimination raciale, de xénophobie et de l’intolérance qui y est associée", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 6, new DateTime(2020, 9, 13, 15, 19, 7, 924, DateTimeKind.Local).AddTicks(8015), "", "", "", "GT Disc femme 2012", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 7, new DateTime(2020, 9, 13, 15, 19, 7, 924, DateTimeKind.Local).AddTicks(8015), "", "", "", "Recommandations du Groupe de travail sur la détention arbitraire", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 9, new DateTime(2020, 9, 13, 15, 19, 7, 924, DateTimeKind.Local).AddTicks(8015), "", "", "", "EI solidarité inle", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 462, null, "R144.52", "52.144", "", "Non réalisé", "", 0, 8, 1, null, 90, null, null, "Examen périodique universal", "Veiller à ce qu’un mécanisme national de prévention soit mis sur pied rapidement et que le mécanisme s’appuie sur une base juridique et reçoive les ressources humaines et les moyens financiers nécessaires pour s’acquitter de son mandat en toute indépendance et de manière efficace", "ضمان الإسراع في إنشاء آلية وطنية لمنع التعذيب، وأن ترتكز تلك الآلية على أساس قانوني وأن تحصل على الموارد البشرية والمالية اللازمة لأداء وظيفتها على نحوٍ مستقل وكفء", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 148, null, "R95P2", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 4, "Procédure spéciale", "-    …De nouvelles mesures devraient être prises pour que les victimes de la traite qui ont besoin d’une protection internationale soient dûment identifiées et aiguillées vers le système d’asile, selon que de besoin.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 129, null, "R98", "ت.98", "", "Non réalisé", "", 0, 9, 1, null, null, null, 3, "Procédure spéciale", "-    Le Rapporteur spécial invite la communauté internationale à appuyer le Maroc dans ses efforts pour appliquer les recommandations ci-dessus, et notamment pour reformer son système judiciaire, mettre en place un cadre de prévention de la torture et des mauvais traitements et un mécanisme national de prévention efficace et dispenser à la police et au personnel pénitentiaire la formation voulue.", "-          يطلب المقرر الخاص إلى المجتمع الدولي أن يدعم جهود المغرب الرامية إلى تطبيق التوصيات المذكورة، خاصة إصلاح نظامه القانوني، ووضع إطار للوقاية من التعذيب وسوء المعاملة، وإنشاء آلية وقائية وطنية، وتوفير التدريب المناسب لأفراد الشرطة وموظفي السجون.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 128, null, "R97P2", "ت.97.ف.2", "", "Non réalisé", "", 0, 9, 1, null, null, null, 3, "Procédure spéciale", "En ce qui concerne les provinces marocaines du Sud : - Reconsidérer la compétence du tribunal militaire pour connaître d’affaires concernant des civils dans le cas des 23 Sahraouis en détention à la prison 1 de Salé et de veiller à ce qu’en principe, les civils ne soient pas condamnés par des tribunaux militaires- Ouvrir des enquêtes sérieuses et impartiales pour établir les faits exacts dans cette affaire et déterminer quelle est la responsabilité des membres de la police ou des forces de sécurité ; et d’enquêter sur toutes les allégations de torture et de mauvais traitements", "فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي:-  (ب) إعادة النظر في الولاية القضائية للمحكمة العسكرية في القضايا المدنية في حالة 23 رجلاً صحراوياً محتجزاً في 'سجن سَلا 1'، ومنع محاكمة محاكم عسكرية مدنيين مبدئياً؛ وإجراء تحقيقات نزيهة وفعالة للتأكد مما حدث حقيقة، وتحديد مسؤولية أفراد الشرطة أو قوات الأمن؛ والتحقيق في جميع ادعاءات التعذيب وسوء المعاملة؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 127, null, "R97P4", "ت.97.ف.4", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "En ce qui concerne les provinces marocaines du Sud -L’établissement d’un mécanisme régional intergouvernementales de surveillance des droits de l’homme, robuste, comme une mesure importante visant à instaurer la confiance et qui peut contribuer à améliorer la situation en ce qui concerne le respect des droits de l’homme et, en particulier, l’interdiction de la torture et autres peines ou traitements cruels, inhumains ou dégradants.", "فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي: (د)  من شأن المنطقة بكاملها أن تستفيد من إنشاء آلية حكومية دولية إقليمية متينة لحقوق الإنسان بوصفها إجراء مهماً لبناء الثقة قد يساعد على تحسين وضع التقيد بحقوق الإنسان، خاصة ما يتعلق بحظر التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 126, null, "R95P1", "ت.95.ف.1", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    Faire en sorte que les plus hautes autorités, en particulier celles qui sont responsables de l’application de la loi, déclarent sans équivoque qu’elles ne toléreront pas le recours à la torture ou aux mauvais traitements par leurs subordonnés et que les auteurs de tels actes auront à en rendre compte ;", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي: (أ) السعي إلى أن تعلن أعلى السلطات، خاصة المعنية بأنشطة إنفاذ القوانين، بكامل الوضوح أنها لن تتساهل مع ممارسة المرؤوسين التعذيب أو إساءتهم المعاملة، ومساءلة الجناة؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 125, null, "R94P2", "ت.94.ف. 2", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    Pour ce qui est des établissements psychiatriques, faire en sorte que le Bureau du Procureur général et le 4 effectuent des visites dans les établissements psychiatriques comme prévu par la loi.", "بخصوص المصحات النفسية، يوصي المقرر الخاص الحكومة بما يلي: (ب) زيارة النيابة العامة والمجلس الوطني لحقوق الإنسان المصحات النفسية، عملاً بالقانون.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 124, null, "R93P5", "ت.93.ف.5", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    faciliter la surveillance exercée par les commissions régionales, au moyen d’inspections régulières et effectives des prisons et de la présentation de rapports sur la situation des prisons et des prisonniers, de façon à améliorer la situation dans les prisons et à donner effet aux droits des prisonniers ;", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي:   (ﻫ) تسهيل الرصد الذي تتولاه اللجان الإقليمية لتحسين الأوضاع في السجون، وإعمال حقوق السجناء، عن طريق الزيارات المنتظمة والفعالة إلى السجون، وتقديم التقارير عن أوضاع السجون والسجناء؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 123, null, "R93P4", "ت.93.ف.4", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "Exercer un contrôle judiciaire sur les établissements pénitentiaires ;- Renforcer les pouvoirs des juges d’application de façon à leur permettre de contrôler de manière effective ces établissements, de surveiller l’application des peines et de vérifier leur validité ;- Renforcer le droit d’appel des personnes soumises à des mesures disciplinaires", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي:-  (د) فرض المراقبة القضائية على الإصلاحيات؛ وتدعيم سلطات القضاة المكلفين بتنفيذ الأحكام بحيث يستطيعون مراقبة تلك المؤسسات بفعالية، ورصد إنفاذ العقوبات، والتحقيق في صلاحيته؛ وتعزيز حق المتضررين من الإجراءات التأديبية في الاستئناف؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 122, null, "R88P17", "ت.88.ف.17", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    Faciliter l’accès des organisations de la société civile aux établissements pénitentiaires et de renforcer le partenariat avec ces institutions pour qu’elles puissent jouer leur rôle de sensibilisation et de propagation de la culture des droits de l’homme et contribuer à l’amélioration de la formation des superviseurs et du personnel des établissements pénitentiaires.", "-          (ف) تسهيل زيارة منظمات المجتمع المدني الإصلاحيات، وتوطيد الشراكة معها لمساعدتها على أداء دورها في التوعية، ونشر ثقافة حقوق الإنسان، والمساهمة في الارتقاء بمستوى تدريب المشرفين عليها وموظفيها.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 121, null, "R88P16", "ت.88.ف.16", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    Renforcer la confiance et la coopération entre l’État et la société civile de façon que toutes les organisations non gouvernementales soient en mesure de collaborer de manière plus efficace avec les mécanismes nationaux et internationaux et d’effectuer un travail de sensibilisation sur la base de dossiers bien documentés", "-          (ع) ترسيخ الثقة وتوثيق التعاون بين الدول والمجتمع المدني بحيث تستطيع المنظمات غير الحكومية العمل بمزيد من الفاعلية مع الآليات الوطنية والدولية، والدعوة على أساس حالات موثقة توثيقاً جيداً؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 120, null, "R88P15", "ت.88.ف.15", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    Ouvrir les crédits nécessaires pour doter le mécanisme national de prévention des ressources humaines et autres dont il a besoin pour inspecter régulièrement tous les lieux de détention, recevoir des plaintes, engager des poursuites et les suivre jusqu’à leur terme", "-          (س) رصد ميزانية لإمداد آلية الوقاية الوطنية بما يكفي من موارد بشرية وغيرها حتى يتسنى لها تفتيش جميع أماكن الاحتجاز بانتظام، وتلقي الشكاوى، ورفع دعاوى ومتابعتها حتى نهايتها؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 119, null, "R88P14-2", "ت.88.ف.14ج2", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    Créer un mécanisme national de prévention de la torture efficace conformément à l’article 17 du Protocole facultatif, et entamer un processus de consultation de toutes les parties prenantes sans exception, notamment les organisations de la société civile", "-          (ن)  ....إنشاء آلية وقاية وطنية فعالة وفقاً للمادة 17 من البروتوكول الاختياري؛ وبدء عملية تشاور يشارك فيها جميع الفاعلين المعنيين بالموضوع، مثل منظمات المجتمع المدني؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 118, null, "R88P13", "ت.88.ف.13", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    Mettre en place des mécanismes de plainte indépendants, efficaces et accessibles dans tous les lieux de détention en installant des lignes d’assistance téléphonique ou des boîtes confidentielles de dépôt de plaintes, et de faire en sorte que chaque détenu ait un accès sans entrave et sans surveillance au procureur sur sa demande et que les plaignants ne soient pas soumis à des représailles", "-          (م) إنشاء آليات شكوى مستقلة وفعالة وميسرة في جميع أماكن الاحتجاز بواسطة تركيب خطوط هاتف مباشرة أو صناديق لوضع الشكاوى سراً، وضمان اتصال كل محتجز بالمدعي العام دون عوائق أو مراقبة بناء على الطلب، وعدم الانتقام من الشاكين؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 117, null, "R88P12", "ت.88.ف.12", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    Fournir au Ministère de l’26 tout le soutien logistique et financier nécessaire pour lui permettre d’appliquer le projet envisagé par le Ministère de la justice et des libertés visant à effectuer un enregistrement vidéo de toutes les déclarations faites à la police pendant l’enquête et l’interrogatoire. De telles mesures ne doivent pas se substituer à la représentation légale pendant toutes les phases de l’interrogatoire mais la compléter", "-          (ل) إمداد وزارة الداخلية بكل الدعم اللوجستي والمالي اللازم لتنفيذ مشروع وزير العدل والحريات الداعي إلى تسجيل جميع بيانات الشرطة بالصورة والصوت أثناء التحقيق والاستجواب. وينبغي النظر إلى هذا الأسلوب على أنه يكمل التمثيل القضائي في جميع مراحل الاستجواب؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 116, null, "R88P7", "ت.88.ف.7", "", "Non réalisé", "", 0, 8, 1, null, null, null, 3, "Procédure spéciale", "-    mettre en place un mécanisme d’enquête pénale et de poursuites indépendant qui n’ait aucun lien avec l’organe chargé de l’enquête ou des poursuites dans la procédure engagée contre la victime présumée; de donner effet au droit de plainte et de faire en sorte que les défendeurs qui comparaissent devant le mécanisme aient une bonne chance de formuler leurs allégations au sujet des tortures et des mauvais traitements qu’ils ont pu subir", "-          (ز) إنشاء آلية للتحقيق الجنائي والملاحقة تكون فعالة ومستقلة ولا ترتبط بالهيئة المكلفة بالتحقيق في الدعاوى المقامة على من يدعون أنهم ضحايا وبملاحقتهم؛ وإعمال الحق في الشكوى؛ والتأكد من إتاحة الفرصة أمام المدّعى عليهم الذين يمثلون أولاً أمام الآلية كي يتحدثوا عما يدعونه من تعرضهم للتعذيب أو سوء المعاملة؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 74, null, "R96", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 2, "Procédure spéciale", "-       Les organismes des Nations Unies chargés des questions relatives aux réfugiés et aux migrants doivent veiller à ce qu’une approche fondée sur les droits de l’homme soit au cœur de tout le travail effectué, à l’échelle nationale et locale, auprès des migrants, des demandeurs d’asile et des réfugiés en situation régulière et irrégulière, en mettant particulièrement l’accent sur la promotion de leurs droits à la non-discrimination et à l’égalité", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 73, null, "R95", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 2, "Procédure spéciale", "-       Les organismes des Nations Unies chargés des questions relatives aux réfugiés et aux migrants doivent fournir d’urgence une aide humanitaire aux migrants noirs d’origine subsaharienne qui vivent dans la forêt de Tanger ainsi qu’aux autres migrants victimes de graves violations des droits de l’homme dans tout le pays, en particulier les femmes et les enfants qui sont au quotidien la cible de violences, notamment sexuelles, commises par les réseaux de passeurs et de trafiquants, entre autres.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 72, null, "R94", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 2, "Procédure spéciale", "-       l’Union européenne et de ses États membres doivent appliquer une approche régionale de gouvernance des migrations qui soit fondée sur les droits de l’homme et qui comprenne des voies légales de migration.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 71, null, "R93", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 2, "Procédure spéciale", "-       l’Union européenne et de ses États membres doivent cesser de faire pression sur les gouvernements africains pour qu’ils limitent la liberté de circulation des Africains et qu’ils fassent de la sécurisation des frontières contre les migrations une priorité en appliquant des pratiques inhumaines, notamment en ayant recours à la discrimination raciale.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 70, null, "R70P3", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 2, "Procédure spéciale", "-       Adopter un plan d’action national de lutte contre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 69, null, "R92", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 2, "Procédure spéciale", "-       Le Conseil national des droits de l’homme doit poursuivre son important travail de sensibilisation au racisme, à la discrimination raciale, à la xénophobie et à l’intolérance qui y est associée, de signalement des cas et d’assistance aux victimes dans tous les contextes.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 68, null, "R89", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 2, "Procédure spéciale", "-       Le Conseil national des droits de l’homme doit jouer un rôle moteur dans l’adoption et la mise en œuvre à l’échelle nationale d’un plan d’action pour combattre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, conformément à la Déclaration et au Programme d’action de Durban.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 67, null, "R88", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 2, "Procédure spéciale", "-       Le Conseil national des droits de l’homme doit jouer un rôle de premier plan pour favoriser une meilleure compréhension des droits de l’homme en ce qui concerne le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, qui se manifestent tous même dans des sociétés comme celle du Maroc, pays dont l’identité nationale est traditionnellement marquée par la diversité et la multiculturalité.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 38, null, "R96P2", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 1, "Procédure spéciale", "Pour les provinces marocaines du sud :- Suivre la mise en œuvre des programmes relatifs aux jeunes", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 37, null, "R86", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 1, "Procédure spéciale", "-   Promouvoir la mise en place d’une budgétisation tenant compte des questions de genre comme outil permettant d’évaluer les politiques publiques du point de vue du genre", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 36, null, "R72", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 1, "Procédure spéciale", "-   Revoir régulièrement les politiques qui ont trait aux importations et aux secours d’urgence afin de garantir la sécurité alimentaire.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 472, null, "R144.37", "37.144", "", "Non réalisé", "", 0, 9, 1, null, 97, null, null, "Examen périodique universal", "Poursuivre ses mesures visant à consolider les principes des droits de l’homme et des libertés publiques", "مواصلة سيره على طريق توطيد مبدأي حقوق الإنسان والحريات العامة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 149, null, "R81", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 4, "Procédure spéciale", "-    Mettre au point, d’entente avec toutes les parties prenantes, notamment les organisations de la société civile, un plan national d’action qui définisse clairement les objectifs à atteindre et les responsabilités de chacun et fixe des indicateurs clairs permettant de mesurer les progrès accomplis et l’efficacité des mesures prises pour lutter contre la traite des êtres humains", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 470, null, "R144.62", "62.144", "", "Non réalisé", "", 0, 8, 1, null, 92, null, null, "Examen périodique universal", "Poursuivre les efforts du Gouvernement visant à doter l’institution nationale des droits de l’homme des ressources budgétaires suffisantes", "مواصلة الحكومة جهودها لتزويد المؤسسة الوطنية لحقوق الإنسان بالموارد الكافية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 150, null, "R82", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 4, "Procédure spéciale", "créer un organisme national qui serait chargé de coordonner les différentes activités menées par les organismes gouvernementaux dans le domaine de lutte contre la traite- envisager de nommer un rapporteur spécial, chargé de surveiller la mise en œuvre de la législation relative à la traite et des mesures prises dans ce domaine et de mesurer leurs effets sur la situation des droits de l’homme.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 152, null, "R84", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 4, "Procédure spéciale", "Étant donné que l’on ne dispose pas de données fiables au sujet de la traite, il est urgent de mettre au point un mécanisme de collecte de données sur les affaires de traite, ainsi que sur les formes de traite, les différentes manifestations de ce phénomène et les tendances observées dans ce domaine. - Ces données sont essentielles à l’élaboration de mesures réfléchies de lutte contre la traite.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 252, null, "R74P1", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 8, "Procédure spéciale", "Consulter toutes les parties prenantes concernées par les programmes d’aide au développement et intégrer pleinement les approches fondées sur les droits de l’homme à tous les stades du processus, de la planification à la mise en œuvre, au suivi et à l’évaluation", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 251, null, "R73P3", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 8, "Procédure spéciale", "Mettre en place un cadre tripartite, composé de représentants du Gouvernement, des partenaires de développement et de la société civile, qui soit chargé de suivre la mise en œuvre et les résultats des programmes d’aide au développement", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 250, null, "R73P6-1", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 8, "Procédure spéciale", "Collaborer avec les acteurs de la société civile, y compris les organisations de défense des droits de l’homme et les partenaires de développement, afin de mettre en place un cadre de suivi des fonds étrangers reçus par les acteurs de la société civile. Ce cadre devrait se fonder sur l’impartialité et l’objectivité, le principe de responsabilité, la transparence et l’équité, et être entièrement compatible avec la liberté d’association", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 249, null, "R73P4", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 8, "Procédure spéciale", "Mettre en œuvre des consultations plus systématiques et approfondies aux fins de la planification, de la mise en œuvre, du suivi et de l’évaluation des programmes de développement, y compris les programmes d’aide au développement, avec la participation effective de la société civile et des collectivités concernées", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 248, null, "R73P3", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 8, "Procédure spéciale", "Renforcer la politique globale de développement national, de la planification et de la conception à la mise en œuvre et l’exécution, au suivi, à l’examen et à l’évaluation et à la cohérence et l’harmonisation des politiques entre les divers ministères, y compris ceux qui œuvrent en faveur de la coopération internationale pour le développement. Il est fortement recommandé qu’un seul service soit investi d’une fonction de contrôle à cet égard, de façon à optimiser les ressources et à éviter les doubles emplois", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 214, null, "R83P15", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 7, "Procédure spéciale", "-       Allouer des crédits pour équiper le mécanisme national de prévention des ressources humaines et autres suffisantes pour lui permettre d’inspecter régulièrement tous les lieux de détention, de recevoir des plaintes, d’engager des poursuites et de les suivre jusqu’à leur conclusion;", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 213, null, "R83P14P2", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 7, "Procédure spéciale", "-       … établir un mécanisme national de prévention efficace, conformément à l’article 17 du Protocole facultatif ; et lancer un processus de consultation inclusif de tous les acteurs concernés, y compris les organisations de la société civile", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 212, null, "R83P13", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 7, "Procédure spéciale", "-       Continuer de s’engager à renforcer le 4 et lui fournir tous les moyens nécessaires pour assurer son bon fonctionnement ;", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 211, null, "R83P12", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 7, "Procédure spéciale", "Afin de lutter contre le surpeuplement dans les prisons, utiliser des alternatives à la détention préventive en conformité avec les Règles minima des Nations Unies pour l’élaboration de mesures non privatives de liberté (Règles de Tokyo) et étudier la dépénalisation possible de certaines infractions et la réduction possible des peines de prison. - Un système pourrait être conçu pour organiser la caution et l’usage plus fréquent des sanctions non privatives de liberté dans le cas d’infractions moins graves", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 187, null, "R94", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "Le Groupe de travail recommande au Conseil national des droits de l’homme et à d’autres organismes nationaux indépendants de mettre en place, là où il n’en existe pas, des mécanismes efficaces de surveillance et de protection sensibles à la condition des femmes et capables d’atteindre les communautés pauvres et rurales et, notamment, de faire face à la discrimination extrême dont sont victimes les travailleuses dans les champs de fraises du nord du Maroc.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 186, null, "R93P6", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "Elargir la protection juridique aux organisations caritatives qui fournissent une assistance et une protection aux groupes de femmes vulnérables et assurer un appui continu et d’une plus vaste portée de la part de l’État", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 185, null, "R93P4P5", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "Accélérer l’entrée en service du Fonds pour la famille et les déboursements pour aider les bénéficiaires qui sont dans le besoin- Renouveler le programme Tamkine et assurer sa viabilité, et faire bénéficier de ses prestations les groupes de femmes rurales et d’autres femmes marginalisées", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 184, null, "R93P2", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "Prendre des mesures pour faire en sorte que les conseils locaux soient plus soucieux des questions de parité entre les sexes et de promouvoir, en tant que moyen d’autonomiser davantage la femme, la capacité individuelle et collective des femmes locales de participer véritablement à la vie publique au niveau local", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 183, null, "null", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "null", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 182, null, "R93P1", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "Revoir le fonds social pour le développement créé en vertu de la Constitution afin qu’il consacre une part équitable de ses ressources aux femmes, en particulier aux femmes rurales et aux femmes victimes de violence, de façon à les aider à jouir de leurs droits fondamentaux", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 181, null, "R92", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "Les partis politiques instituent divers moyens de garantir l’intégration des femmes dans les listes électorales", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 180, null, "R91P6", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "Veiller à ce qu’une suite soit donnée aux recommandations de la commission consultative sur la régionalisation concernant l’égalité entre les sexes dans le cadre de la mise en place du système de gouvernance des régions et d’autres collectivités territoriales envisagé dans la Constitution; les fonds de développement social et de solidarité interrégionale prévus par la Constitution doivent intégrer dans leur travail les principes de la budgétisation axée sur la parité.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 179, null, "R91P3P4", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "c) Revoir la représentation des femmes au Conseil des ministres pour faire en sorte que les objectifs d’égalité formelle et effective entre les hommes et les femmes soient atteints ;  d) Revoir les règles de procédure régissant la prise de décisions aux échelons supérieurs des organes exécutif, législatif et judiciaire pour faire en sorte que l’objectif de la parité soit pris en compte", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 178, null, "R90", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "a) le Conseil national des droits de l’homme et d’autres institutions nationales indépendantes doivent intensifier leurs efforts volontaristes pour faire face à la discrimination à l’égard des femmes en droit et en pratique en tant que partie intégrante des processus de protection et de promotion des droits de l’homme et de bonne gouvernance, notamment par le biais de systèmes indépendants de surveillance des droits de l’homme accessibles à toutes les femmes; b) Renforcer l’exécution de leurs mandats aux niveaux régional et local par des mesures spéciales pour assurer au niveau local l’accès des femmes qui sont victimes de multiples formes de discrimination.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 177, null, "R89P8", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "- Le Gouvernement devrait assurer un processus de consultation vaste et ouvert avec toutes les parties prenantes en faisant fond sur le travail accompli par le Conseil national des droits de l’homme, et faire en sorte que cette autorité coopère avec lui", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 176, null, "R89P8", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "- Le futur organisme devrait avoir pour tâches d’établir le bilan des progrès accomplis, de repérer les problèmes persistants et de proposer et d’exécuter des mesures en vue d’accomplir d’autres progrès.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 175, null, "R89P8", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 6, "Procédure spéciale", "- Accélérer la création d’une autorité pour la parité et la lutte contre la discrimination à l’égard des femmes en tant qu’organisation faîtière pour consolider les acquis en matière d’égalité et d’élimination de la discrimination à l’égard des femmes.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 157, null, "R96P1", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 4, "Procédure spéciale", "-    Renforcer les relations de partenariat avec les pays d’origine dans toutes les régions, y compris l’Afrique subsaharienne et l’Asie du Sud‑Est, ainsi que de coopérer aux fins de l’échange d’informations et de la fourniture d’un appui juridique mutuel", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 156, null, "R98", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 4, "Procédure spéciale", "-    La participation et la collaboration des organisations de la société civile sont essentielles dans le cadre de 35. À cet égard, des mesures devraient être prises immédiatement, d’une part, pour fournir l’appui nécessaire aux organisations de la société civile qui aident les victimes, notamment en leur proposant un accompagnement psychologique, et d’autre part, pour établir le cadre juridique requis. Les organisations de la société civile et les organismes d’aide aux victimes devraient être en mesure d’exercer leurs activités dans toutes les régions du pays.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 155, null, "R88P2", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 4, "Procédure spéciale", "-    Les agents de l’Inspection du travail devraient être habilités à surveiller les conditions de travail de ces employés, qui sont souvent plus exposés que quiconque au risque d’être victimes de la traite.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 154, null, "R86", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 4, "Procédure spéciale", "-    Davantage de ressources, financières et autres, devraient être allouées à l’aide aux victimes de la traite, et des programmes et des institutions parrainés ou soutenus par l’État devraient être créés et développés de sorte que les victimes puissent bénéficier de soins à court et à long terme.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 153, null, "R85", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 4, "Procédure spéciale", "-    le Gouvernement devrait faire beaucoup plus d’efforts pour protéger et aider toutes les victimes de la traite, y compris les hommes et les garçons, en veillant au plein respect de leurs droits de l’homme, et devrait faire en sorte que les enquêtes menées sur les affaires de traite soient axées sur une approche fondée sur les droits de l’homme.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 151, null, "R83P1", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 4, "Procédure spéciale", "-    Mettre en place un système de détection adapté, doté de ressources suffisantes, devrait être mis en place. Ce système devrait comporter des outils et des protocoles spécifiques permettant de repérer les victimes de la traite", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 253, null, "R74P2", "null", "", "Non réalisé", "", 0, 8, 1, null, null, null, 8, "Procédure spéciale", "Assurer l’égalité des chances en ce qui concerne l’accès des acteurs de la société civile aux fonds d’aide au développement, s’agissant en particulier des organisations locales des zones rurales et reculées, qui sont souvent exclues par manque d’accès à l’information. - Envisager de modifier la procédure actuelle d’appel à propositions, en tenant compte de la situation dans les zones reculées où il n’y a pas d’accès à Internet", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 254, null, "R73P1-1", "null", "", "Non réalisé", "", 0, 9, 1, null, null, null, 8, "Procédure spéciale", "Fournir des informations simplifiées et largement accessibles sur les accords internationaux signés par le Maroc, notamment les accords économiques et commerciaux, et l’incidence de ces accords sur la population marocaine. Ces informations ne devraient pas être seulement accessibles sur des sites Web, afin de ne pas exclure ceux qui n’ont pas accès à Internet.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 466, null, "R144.56", "56.144", "", "Non réalisé", "", 0, 8, 1, null, 75, null, null, "Examen périodique universal", "Soutenir l’action pour la promotion et la protection des droits de l’homme menée par le Conseil national des droits de l’homme par l’intermédiaire de ses commissions régionales sur tout le territoire", "دعم العمل على تعزيز وحماية حقوق الإنسان الذي يقوم به المجلس الوطني لحقوق الإنسان بواسطة لجانه الجهوية في جميع أنحاء البلد", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 476, null, "R144.4", "43.144", "", "Non réalisé", "", 0, 9, 1, null, 82, null, null, "Examen périodique universal", "Renforcer les réalisations dans le domaine de la consolidation des droits de l’homme", "توطيد الإنجازات التي تحققت في مجال ترسيخ حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 510, null, "R18P3", "ت.18.ف.3", "", "Non réalisé", "", 0, 8, 1, 1, null, null, null, "Organes de traités", "Envisager d’adopter la méthode du «testing» pour récolter des preuves de discrimination raciale.", "التفكير في اعتماد أسلوب 'الاختبار' للحصول على أدلة على التمييز العنصري.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 511, null, "R19", "ت.19", "", "Non réalisé", "", 0, 8, 1, 1, null, null, null, "Organes de traités", "veiller à la pleine application des articles 21, 73, 74 et 120 du Code de procédure pénale, afin de garantir un service d’interprétation, notamment en procédant à la formation de plus d’ interprètes assermentés, et de s’assurer que des justiciables appartenant à des catégories vulnérables et ne parlant pas l’arabe, notamment les amazighs, les saharawis, les noirs, les migrants, les réfugiés, les demandeurs d’asile, puissent bénéficier d’une bonne administration de la justice.", "ضمان التطبيق الكامل للمواد 21 و73 و74 و120 من قانون المسطرة الجنائية وبأن تكفل خدمات الترجمة الفورية، خاصة عن طريق تدريب عدد أكبر من المترجمين الفوريين المحلفين، وضمان استفادة المتقاضين من الفئات الضعيفة غير المتحدثة باللغة العربية من نظام جيد لإقامة العدل، لا سيما منهم الأمازيغ والصحراويون والزنوج والمهاجرون واللاجئون وطالبو اللجوء.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 464, null, "R144.54", "54.144", "", "Non réalisé", "", 0, 8, 1, null, 10, null, null, "Examen périodique universal", "Créer un mécanisme national pour la protection des droits des personnes handicapées", "إنشاء آلية وطنية لحماية حقوق الأشخاص ذوي الإعاقة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 477, null, "R144.141", "141.144", "", "Non réalisé", "", 0, 9, 1, null, 27, null, null, "Examen périodique universal", "Poursuivre et accélérer les efforts visant à promouvoir les droits économiques, sociaux et culturels pour l’ensemble de la population", "مواصلة الجهود وتسريعها بغرض تعزيز الحقوق الاقتصادية والاجتماعية والثقافية لجميع السكان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 461, null, "R144.51", "51.144", "", "Non réalisé", "", 0, 8, 1, null, 31, null, null, "Examen périodique universal", "Intensifier les efforts pour combattre la torture et les autres mauvais traitements commis par des agents de l’État par la mise en place d’un mécanisme national indépendant et efficace pour la prévention de la torture", "تكثيف الجهود لمكافحة حالات التعذيب وغيره من ضروب المعاملة السيئة على يد أعوان الدولة، وذلك بإنشاء آلية وطنية لمنع التعذيب تكون مستقلة وفعالة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 473, null, "R144.39", "39.144", "", "Non réalisé", "", 0, 9, 1, null, 35, null, null, "Examen périodique universal", "Continuer d’allouer les fonds nécessaires à la mise en œuvre de projets visant à accroître l’intégration des droits de l’homme dans les politiques publiques", "مواصلة تخصيص التمويل المطلوب لتنفيذ مشاريع بهدف زيادة إدماج حقوق الإنسان في السياسات العامة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 455, null, "R144.45", "45.144", "", "Non réalisé", "", 0, 8, 1, null, 37, null, null, "Examen périodique universal", "Accélérer le processus de création de l’Autorité pour la parité et la lutte contre toutes les formes de discrimination", "تسريع عملية إنشاء هيئة المناصفة ومكافحة كل أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 467, null, "R144.57", "57.144.", "", "Non réalisé", "", 0, 8, 1, null, 37, null, null, "Examen périodique universal", "Poursuivre ses efforts en vue de mettre en place et consolider les institutions et mécanismes nationaux de promotion et de protection des droits de l’homme", "مواصلة الجهود لإنشاء وتوطيد مؤسسات وآليات وطنية بغرض تعزيز وحماية حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 474, null, "R144.40", "40.144", "", "Non réalisé", "", 0, 9, 1, null, 37, null, null, "Examen périodique universal", "Consolider l’expérience de la régionalisation et poursuivre la participation des jeunes et des femmes dans toutes les régions du Royaume, y compris dans les provinces méridionales", "تكريس تجربة الجهوية ومواصلة مشاركة الشباب والنساء في جميع مناطق المملكة، بما فيها الأقاليم الجنوبية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 458, null, "R144.48", "48.144", "", "Non réalisé", "", 0, 8, 1, null, 40, null, null, "Examen périodique universal", "Établir un mécanisme national de prévention indépendant, efficace et doté de ressources suffisantes conformément au Protocole facultatif se rapportant à la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "إنشاء آلية وقائية وطنية مستقلة وفعالة ومزوَّدة بقدر جيد من الموارد بما يتفق مع متطلبات البروتوكول الاختياري لاتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 465, null, "R144.55", "55.144", "", "Non réalisé", "", 0, 8, 1, null, 10, null, null, "Examen périodique universal", "Continuer à promouvoir le rôle des institutions nationales de protection des droits de l’homme en appuyant les activités des comités régionaux du Conseil national des droits de l’homme dans diverses régions, en particulier dans les villes de Laayoune et Dakhla, dans les provinces du sud", "مواصلة تعزيز دور المؤسسات الوطنية لحماية حقوق الإنسان عن طريق دعم أنشطة اللجان الجهوية للمجلس الوطني لحقوق الإنسان في مختلف المناطق، ولا سيما في مدينتي العيون والداخلة في الأقاليم الجنوبية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 460, null, "R144.50", "50.144", "", "Non réalisé", "", 0, 8, 1, null, 42, null, null, "Examen périodique universal", "Rationaliser le processus de création du mécanisme national de prévention de la torture, et assurer une participation large et sans exclusive audit mécanisme", "ترشيد عملية إنشاء الآلية الوطنية لمنع التعذيب عن طريق ضمان المشاركة الواسعة والشاملة في تلك الآلية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 459, null, "R144.49", "49.144", "", "Non réalisé", "", 0, 8, 1, null, 41, null, null, "Examen périodique universal", "Accélérer le processus de création du mécanisme national de prévention de la torture", "تسريع عملية إنشاء الآلية الوطنية لمنع التعذيب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 454, null, "R144.42", "42.144", "", "Non réalisé", "", 0, 8, 1, null, 72, null, null, "Examen périodique universal", "Continuer à mettre en place des politiques et des programmes publics relatifs aux droits de l’homme, y compris sur le rôle effectif des parlementaires dans la promotion et la protection des droits de l’homme", "مواصلة وضع سياسيات وبرامج حول حقوق الإنسان، تشمل الدور الفعال الذي يلعبه البرلمانيون في تعزيز وحماية حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 471, null, "R144.67", "67.144", "", "Non réalisé", "", 0, 8, 1, null, 72, null, null, "Examen périodique universal", "Veiller à ce que des ressources humaines et financières suffisantes soient allouées à la mise en œuvre de programmes et d’activités sur les droits de l’homme", "ضمان تخصيص ما يكفي من الموارد البشرية والمالية لتنفيذ البرامج والأنشطة المتعلقة بحقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 453, null, "R144.33", "33.144", "", "Non réalisé", "", 0, 8, 1, null, 66, null, null, "Examen périodique universal", "Continuer de renforcer son cadre institutionnel pour la promotion et la protection des droits de l’homme", "مواصلة توطيد الإطار المؤسساتي بغية تعزيز وحماية حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 469, null, "R144.60", "60.144", "", "Non réalisé", "", 0, 8, 1, null, 59, null, null, "Examen périodique universal", "Continuer d’améliorer le rôle et les capacités de l’institution nationale des droits de l’homme, qui a conservé son statut A en mars 2016, en pleine conformité avec les Principes concernant le statut des institutions nationales pour la promotion et la protection des droits de l’homme (Principes de Paris)", "مواصلة ترسيخ دور المؤسسة الوطنية لحقوق الإنسان وقدرتها، وهي التي حصلت مجدداً على المركز ألف في آذار/مارس 2016 في امتثالٍ تام للمبادئ المتعلقة بمركز المؤسسات الوطنية لتعزيز وحماية حقوق الإنسان (مبادئ باريس)", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 478, null, "R144.88", "88.144", "", "Non réalisé", "", 0, 9, 1, null, 71, null, null, "Examen périodique universal", "Poursuivre les efforts visant à retirer les mines terrestres et autres restes explosifs de guerre", "مواصلة الجهود لإزالة الألغام الأرضية وغيرها من المتفجرات من مخلفات الحرب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 463, null, "R144.53", "53.144", "", "Non réalisé", "", 0, 8, 1, null, 56, null, null, "Examen périodique universal", "Mettre en place un mécanisme de protection des droits des personnes handicapées", "إنشاء آلية لحماية حقوق الأشخاص ذوي الإعاقة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 457, null, "R144.47", "47.144", "", "Non réalisé", "", 0, 8, 1, null, 52, null, null, "Examen périodique universal", "Mettre en place l’Autorité pour la parité et la lutte contre toutes les formes de discrimination", "إنشاء هيئة المناصفة ومكافحة كل أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 456, null, "R144.46", "46.144", "", "Non réalisé", "", 0, 8, 1, null, 50, null, null, "Examen périodique universal", "Poursuivre les efforts visant à soutenir les comités régionaux du Conseil national des droits de l’homme, en particulier dans les provinces du sud", "مواصلة الجهود لدعم دور اللجان الإقليمية للمجلس الوطني لحقوق الإنسان، ولا سيما في الأقاليم الجنوبية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 475, null, "R144.41", "41.144", "", "Non réalisé", "", 0, 9, 1, null, 46, null, null, "Examen périodique universal", "Accélérer la mise en œuvre de la régionalisation avancée, en tant que moyen de promouvoir la participation des citoyens, en particulier des femmes et des jeunes, des 12 régions du Royaume, à la gouvernance politique et économique du pays () ;", "تسريع تنفيذ الجهوية المتقدمة باعتبارها وسيلة من وسائل زيادة تعزيز مشارکة المواطنین، ولا سیما النساء والشباب، في الحوكمة السیاسیة والاقتصادية في البلد في مناطق المملكة البالغ عددها 12 منطقة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 468, null, "R144.59", "59.144", "", "Non réalisé", "", 0, 8, 1, null, 56, null, null, "Examen périodique universal", "Renforcer les mesures prises par le Conseil national pour la promotion et la protection des droits de l’homme, en particulier par l’intermédiaire de ses commissions sur l’ensemble du territoire", "تقوية العمل الذي يقوم به المجلس الوطني لحقوق الإنسان من أجل تعزيز وحماية حقوق الإنسان، ولا سيما عن طريق لجانه الموجودة في جميع أنحاء البلد", "", "" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 16, 4, "Le droit au développement", "الحق في التنمية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 15, 4, "Le droit au travail", "الحق في الشغل" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 14, 4, "Le droit à l’éducation", "الحق في والتعليم" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 13, 4, "Le droit à la santé", "الحق في الصحة" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 12, 4, "Les droits culturels", "الحقوق الثقافية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 11, 4, "La lutte contre la pauvreté et la vulnérabilité", "محاربة الفقر والهشاشة" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 10, 3, "Harmonisation", "الملاءمة" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 5, 2, "La ratification et l'adhésion aux mécanismes internationaux relatifs aux droits de l'homme", "المصادقة أو الانضمام للصكوك الدولية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 8, 2, "Le suivi des résultats des conférences et des déclarations internationales", "متابعة نتائج وتوصيات المؤتمرات الدولية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 7, 2, "La coopération avec les mécanismes onusiens des droits de l'homme", "التعاون مع الآليات الأممية لحقوق الإنسان" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 6, 2, "L’interaction avec les PS du Conseil des droits de l’Homme", "التفاعل مع آلية الإجراءات الخاصة" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 4, 1, "La mise en œuvre du plan d'action national dans le domaine de la démocratie et des droits de l'homme", "إعمال خطة العمل الوطنية في مجال الديمقراطية وحقوق الإنسان" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 3, 1, "La mise en œuvre des dispositions de la constitution relatives aux droits de l’Homme", "تطبيق المقتضيات الدستورية المتعلقة بحقوق الإنسان" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 2, 1, "La réforme du système de la justice", "إصلاح منظومة العدالة" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 17, 4, "Le droit et l’accès à l’eau", "الحق في الولوج إلى الماء" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 9, 3, "Législation", "التشريع" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 18, 4, "Le droit à un logement convenable", "الحق في السكن اللائق" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 30, 6, "La promotion et la protection des droits des femmes", "النهوض بحقوق المرأة وحمايتها" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 20, 5, "La protection du droit à la vie, l’éradication de toutes les formes de torture et de mauvais traitements et la lutte contre l’impunité", "الحق في الحياة ومناهضة كافة أشكال التعذيب والإفلات من العقاب" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 37, 7, "Diffusion de la culture des droits de l’Homme", "نشر ثقافة حقوق الإنسان" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 36, 7, "Education et formation aux droits de l’Homme", "التدريب والتكوين في مجال حقوق الإنسان" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 35, 6, "La lutte contre la traite des êtres humains", "مكافحة الاتجار بالبشر" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 34, 6, "La promotion et la protection des droits de l’homme des migrants", "النهوض بحقوق المهاجرين وحمايتها" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 33, 6, "La promotion et la protection des droits des personnes handicapées", "النهوض بحقوق الأشخاص المعاقين" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 32, 6, "La promotion et la protection des droits des enfants", "النهوض بحقوق الطفل وحمايتها" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 29, 5, "Droit à l’identité et d’enregistrement des naissances", "الحق في الهوية وتسجيل المواليد" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 28, 5, "Les garanties relatives aux droits de l’homme dans la lutte contre le terrorisme", "ضمانات حقوق الإنسان في إطار مكافحة الإرهاب" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 27, 5, "La garantie de la liberté de conscience et de croyance", "ضمان حرية الضمير والمعتقد" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 26, 5, "La promotion du droit à l’information et le droit à la vie privée", "النهوض بالحق في المعلومة والحق في الخصوصية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 25, 5, "La garantie de la liberté de réunion et d’association", "ضمان حرية التجمع وتكوين الجمعيات" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 24, 5, "La protection de la liberté d’opinion et d’expression", "حماية حرية الرأي والتعبير" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 23, 5, "La promotion de la participation à la vie publique et la vie politique", "النهوض بالمشاركة في الحياة العامة والحياة السياسية" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 22, 5, "La réparation des victimes de violations flagrantes des droits de l’homme", "جبر ضرر ضحايا انتهاكات حقوق الإنسان" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 21, 5, "La promotion du statut des prisonniers", "النهوض بوضعية السجناء" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 19, 4, "Le Droit à l’environnement et au développement durable", "الحق في البيئة والتنمية المستدامة" });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[] { 1, 1, "Le renforcement de l'Etat de droit et la séparation des pouvoirs", "تعزيز حكم القانون وفصل السلط" });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 254, 47, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 472, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 472, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 470, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 470, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 462, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 476, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 27, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 476, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 124, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 123, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 123, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 122, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 121, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 121, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 120, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 120, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 119, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 118, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 118, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 118, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 117, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 117, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 116, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 116, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 118, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 466, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 466, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 471, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 473, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 473, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 473, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 473, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 473, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 473, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 461, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 477, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 455, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 477, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 477, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 477, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 465, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 464, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 511, 9, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 511, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 511, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 510, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 477, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 455, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 467, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 467, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 471, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 471, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 454, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 478, 11, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 453, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 453, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 453, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 453, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 453, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 469, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 468, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 463, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 457, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 457, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 456, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 460, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 459, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 458, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 474, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 124, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 125, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 475, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 125, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 213, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 212, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 211, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 211, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 211, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 187, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 187, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 186, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 214, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 185, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 183, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 182, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 181, 50, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 181, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 180, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 180, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 179, 9, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 179, 21, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 184, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 248, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 248, 51, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 248, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 125, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 254, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 254, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 253, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 253, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 253, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 252, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 252, 51, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 251, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 251, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 251, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 250, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 250, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 250, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 249, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 249, 51, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 249, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 248, 45, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 248, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 179, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 178, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 254, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 176, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 149, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 149, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 149, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 149, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 148, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 148, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 129, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 129, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 129, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 129, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 128, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 128, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 127, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 127, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 126, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 126, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 126, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 126, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 177, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 149, 49, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 150, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 128, 11, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 151, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 157, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 175, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 151, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 157, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 156, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 156, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 154, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 154, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 154, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 153, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 155, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 153, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 152, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 152, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 152, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 152, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 151, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 151, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 153, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 152, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 418, null, "R144.224P1", "224.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 79, 32, null, "Examen périodique universal", "Continuer à renforcer les politiques publiques pertinentes pour la promotion et la protection des droits de l’homme, en particulier les droits des enfants", "مواصلة تقوية السياسات العامة ذات الصلة لتعزيز وحماية حقوق الإنسان، وبخاصة حقوق الطفل....", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 426, null, "R144.91", "91.144", "", "Non réalisé", "", 0, 6, 1, null, 69, 32, null, "Examen périodique universal", "Mettre en place une 9 interdisant les châtiments corporels et les mauvais traitements infligés aux garçons et aux filles", "وضع تشريعات تحظر العقوبة البدنية وإساءة معاملة البنين والبنات", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 425, null, "R144.90", "90.144", "", "Non réalisé", "", 0, 6, 1, null, 43, 32, null, "Examen périodique universal", "Mettre en œuvre les recommandations issues du deuxième cycle figurant dans le document A/HRC/21/3 (par. 129.62 et 129.65) et interdire sans équivoque les châtiments corporels en tous lieux, y compris à la maison, dans les institutions de protection de remplacement, dans les crèches et dans les écoles", "تنفيذ التوصيات المنبثقة عن الجولة الثانية، الواردة في الوثيقة A/HRC/21/3، الفقرتان 129‑62 و129‑65، وحظر العقوبة البدنية حظراً لا يدع مجالاً للشك، في جميع الأماكن وحتى داخل المنزل وفي مؤسسات الرعاية البديلة وفي دور الحضانة النهارية وفي المدارس", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 424, null, "P2R144.191", "191.144", "", "Non réalisé", "", 0, 6, 1, null, 62, 32, null, "Examen périodique universal", "Prendre des mesures appropriées pour prévenir le mariage des mineurs", "اتخاذ تدابير مناسبة، مع مراعاة التزاماته الدولية، لمنع زواج القاصرين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 421, null, "R144.227P2", "227.144. ج.2", "", "Non réalisé", "", 0, 6, 1, null, 20, 32, null, "Examen périodique universal", "Poursuivre ses efforts pour assurer la protection et la promotion des droits des groupes vulnérables, notamment et les enfants", "مواصلة جهوده من أجل حماية وتعزيز حقوق الإنسان للفئات الضعيفة بما فيها..... الأطفال", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 422, null, "R144.138P1", "138.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 94, 32, null, "Examen périodique universal", "Retirer toute référence dans les documents d’identité qui permettrait de repérer les enfants nés hors mariage", "سحب أي إشارة في وثائق الهوية من شأنها أن تمكّن من تحديد الأطفال المولودين خارج إطار الزواج.......", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 420, null, "R144.226", "226.144", "", "Non réalisé", "", 0, 6, 1, null, 95, 32, null, "Examen périodique universal", "Interdire et incriminer expressément l’enrôlement et l’utilisation dans des hostilités d’enfants de moins de 18 ans", "حظر وتجريم تجنيد الأطفال دون سن 18 واستخدامهم في الأعمال العدائية حظراً وتجريماً صريحين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 419, null, "R144.225", "225.144", "", "Non réalisé", "", 0, 6, 1, null, 57, 32, null, "Examen périodique universal", "Poursuivre ses efforts pour lutter contre le travail des enfants par la mise en œuvre effective de la loi sur les conditions de travail et d’18 des travailleurs domestiques", "مواصلة جهوده في سبيل مكافحة عمالة الأطفال عن طريق التنفيذ الفعال لقانون العمال المنزليين وظروف الاستخدام", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 417, null, "R144.223", "223.144", "", "Non réalisé", "", 0, 6, 1, null, 77, 32, null, "Examen périodique universal", "Poursuivre les efforts pour faire en sorte que les enfants et adolescents vulnérables vivant en milieu rural aient accès à une éducation et à des services de santé de qualité", "مواصلة الجهود من أجل كفالة حصول الأطفال والمراهقين الضعيفة حالهم في المجتمعات الريفية على التعليم الجيد وخدمات الرعاية الصحية الجيدة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 427, null, "R144.130P1P3", "130.144 ج.1 و ج.3", "", "Non réalisé", "", 0, 6, 1, null, 18, 32, null, "Examen périodique universal", "Analyser la 9 existante et abroger toutes les règles qui sont contraires au principe de l’égalité entre les enfants ou qui constituent une discrimination à l’égard des droits de l’enfant", "تحليل التشريعات القائمة وإلغاء جميع القواعد التي تتنافى مع مبدأ المساواة بين الأطفال أو التي تشكل تمييزاً في حق الطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 423, null, "R144.228P2", "228.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 38, 32, null, "Examen périodique universal", "Accélérer encore les efforts visant à promouvoir les droits des enfants, en particulier ceux qui sont handicapés", "زيادة تسريع الجهود المبذولة لأجل تعزيز حقوق... والطفل، وخاصة ذوي الإعاقة منهم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 428, null, "R144.134P2", "134.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 3, 32, null, "Examen périodique universal", "permettre la pleine reconnaissance juridique des enfants nés hors mariage", "...... السماح بالاعتراف القانوني التام بالأطفال المولودين خارج إطار الزواج.....", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 435, null, "R144.224P3", "224.144 ج.3", "", "Non réalisé", "", 0, 6, 1, null, 79, 33, null, "Examen périodique universal", "Continuer à renforcer les politiques publiques pertinentes pour la promotion et la protection des droits de l’homme, en particulier les droits des personnes handicapées", "مواصلة تقوية السياسات العامة ذات الصلة لتعزيز وحماية حقوق الإنسان،..... وبخاصة حقوق الأشخاص ذوي الإعاقة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 430, null, "R144.218P2", "218.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 84, 32, null, "Examen périodique universal", "Renforcer les mesures visant à éliminer les mariages d’enfants et accélérer l’adoption de la loi abolissant le mariage forcé des enfants", "......... الإسراع بسَنّ التشريع الذي يلغي تزويج الأطفال كرهاً", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 431, null, "R144.219", "219.144", "", "Non réalisé", "", 0, 6, 1, null, 89, 32, null, "Examen périodique universal", "Prendre des mesures pour contrecarrer la tendance des autorisations judiciaires de mariage entre mineurs, notamment en apportant les modifications nécessaires au Code de la", "اتخاذ تدابير من أجل مقاومة الميل إلى استصدار أذون قضائية لحالات زواج تهمُّ قاصرين بوسائل منها إجراء التعديلات الضرورية لمدونة الأسرة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 432, null, "R144.201", "201.144", "", "Non réalisé", "", 0, 6, 1, null, 51, 32, null, "Examen périodique universal", "Poursuivre la mise en conformité de la 9, des politiques et des programmes qui établissent les droits de l’enfant afin d’empêcher que les enfants travaillent dans des conditions nocives, mettre un terme aux mariages précoces et criminaliser toutes les formes d’exploitation des enfants", "مواصلة مواءمة تشريعاته وسياساته وبرامجه التي تكرس حقوق الطفل من أجل منع عمل الأطفال في ظروف مؤذية ووقف حالات الزواج المبكر وتجريم جميع أشكال استغلال الأطفال", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 27, null, "R93", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 33, 1, "Procédure spéciale", "-   Intégrer pleinement la problématique du handicap dans les politiques et les programmes relatifs à la nutrition, les politiques relatives à la santé maternelle et infantile et les initiatives plus générales en matière de santé.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 232, null, "R88P3", "ت.88.ف.3", "", "Non réalisé", "", 0, 6, 1, null, null, 33, 8, "Procédure spéciale", "Davantage d’investissements devraient être réalisés dans le renforcement des capacités et dans l’aménagement des centres de culture pour les rendre plus accessibles aux personnes handicapées.", "-    زيادة الاستثمار في بناء القدرات وجعل الاستفادة من هذه المراكز أمراً أسهل بالنسبة للأشخاص ذوي الإعاقة.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 433, null, "R144.167", "167.144", "", "Non réalisé", "", 0, 6, 1, null, 30, 33, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir l’éducation inclusive en renforçant l’accès à l’éducation pour les personnes handicapées", "مواصلة الجهود لتعزيز التعليم الجامع عن طريق تيسير حصول الأشخاص ذوي الإعاقة على التعليم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 434, null, "R144.222P2", "222.144. ج.2", "", "Non réalisé", "", 0, 6, 1, null, 19, 33, null, "Examen périodique universal", "Prendre des mesures plus efficaces pour mieux protéger les droits des personnes handicapées", "اتخاذ تدابير أكثر نجوعاً من أجل توفير حماية أفضل لحقوق.... الأشخاص ذوي الإعاقة.... وغير ذلك من الفئات الضعيفة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 436, null, "R144.227P1", "227.144. ج.1", "", "Non réalisé", "", 0, 6, 1, null, 20, 33, null, "Examen périodique universal", "Poursuivre ses efforts pour assurer la protection et la promotion des droits des groupes vulnérables, notamment les personnes handicapées", "مواصلة جهوده من أجل حماية وتعزيز حقوق الإنسان للفئات الضعيفة بما فيها الأشخاص ذوي الإعاقة.....", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 437, null, "R144.229", "229.144", "", "Non réalisé", "", 0, 6, 1, null, 45, 33, null, "Examen périodique universal", "Continuer de prendre des mesures globales pour mieux intégrer les personnes handicapées dans la société", "مواصلة اتخاذ تدابير شاملة لتحسين اندماج الأشخاص ذوي الإعاقة في المجتمع", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 438, null, "R144.230", "230.144", "", "Non réalisé", "", 0, 6, 1, null, 55, 33, null, "Examen périodique universal", "Continuer à renforcer la mise en œuvre des politiques publiques concernant les personnes handicapées", "مواصلة تقوية تنفيذ السياسات العامة المتعلقة بالأشخاص ذوي الإعاقة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 439, null, "R144.231", "231.144", "", "Non réalisé", "", 0, 6, 1, null, 56, 33, null, "Examen périodique universal", "Intégrer la langue des signes dans les médias publics et assurer la formation des interprètes dans ce domaine", "إدماج لغة الإشارة في وسائط الإعلام العامة وتوفير التدريب للمترجمين في هذا المجال", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 416, null, "R144.222 P1", "222.144. ج.1", "", "Non réalisé", "", 0, 6, 1, null, 19, 32, null, "Examen périodique universal", "Prendre des mesures plus efficaces pour mieux protéger les droits des enfants", "اتخاذ تدابير أكثر نجوعاً من أجل توفير حماية أفضل لحقوق الطفل....... وغير ذلك من الفئات الضعيفة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 57, null, "R80", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 2, "Procédure spéciale", "-       Garantir des voies de migration supplémentaires systématisées, notamment en attendant la finalisation des projets de loi nationaux sur les migrations et l’asile en cours d’examen par le 32", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 429, null, "R144.159", "159.144", "", "Non réalisé", "", 0, 6, 1, null, 94, 32, null, "Examen périodique universal", "Adopter un projet de loi réglementant les conditions de travail des travailleurs domestiques", "اعتماد مشروع قانون يحدد شروط عمل العمال المنزليين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 415, null, "R144.218P1", "218.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 84, 32, null, "Examen périodique universal", "Renforcer les mesures visant à éliminer les mariages d’enfants", "تقوية التدابير الرامية إلى القضاء التام على زواج الأطفال ......", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 402, null, "R144.204", "204.144", "", "Non réalisé", "", 0, 6, 1, null, 69, 30, null, "Examen périodique universal", "Adopter une loi générale sur la violence à l’égard des femmes, conformément aux normes internationales, en fournissant les moyens de sa mise en œuvre effective", "اعتماد قانون عام متعلق بالعنف على المرأة بما يتفق مع المعايير الدولية مع توفير وسائل تنفيذه تنفيذاً فعالاً", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 413, null, "P2R144.184", "184.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 59, 32, null, "Examen périodique universal", "Poursuivre les efforts louables visant à promouvoir et protéger les droits des enfants", ".......مواصلة الجهود الحميدة الرامية إلى تعزيز حماية حقوق", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 393, null, "R144.189", "189.144", "", "Non réalisé", "", 0, 6, 1, null, 18, 30, null, "Examen périodique universal", "Renforcer le cadre juridique existant pour protéger les femmes contre toutes les formes de violence et éliminer toutes les normes juridiques à caractère sexiste", "تقوية الإطار القانوني القائم من أجل حماية النساء من جميع أشكال العنف وإزالة جميع القواعد القانونية التمييزية القائمة على نوع الجنس", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 394, null, "R144.194", "194.144", "", "Non réalisé", "", 0, 6, 1, null, 7, 30, null, "Examen périodique universal", "Modifier la 9 interne pour supprimer toutes les formes de discrimination sexiste et protéger les droits des femmes et des enfants", "تعديل التشريعات الداخلية لإزالة جميع أشكال التمييز القائم على نوع الجنس ولحماية حقوق المرأة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 395, null, "R144.195", "195.144", "", "Non réalisé", "", 0, 6, 1, null, 12, 30, null, "Examen périodique universal", "Accélérer l’adoption du projet de loi no 103.13 sur la violence à l’égard des femmes, tout en tenant compte de l’importance de l’élargissement de la protection destinée aux femmes victimes de violence, et ériger en infraction le viol conjugal", "تسريع اعتماد مشروع القانون 103-13 المتعلق بالعنف على المرأة، مع مراعاة أهمية توسيع نطاق الحماية ليشمل النساء ضحايا العنف ولتجريم الاغتصاب في إطار الزواج", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 396, null, "R144.197", "197.144", "", "Non réalisé", "", 0, 6, 1, null, 17, 30, null, "Examen périodique universal", "Ériger en infraction le viol conjugal et les menaces de violence dans le cadre de son projet de loi 103.13 sur la lutte contre la violence à l’égard des femmes et mettre en œuvre des programmes, financés par l’État, pour soutenir les victimes", "تجريم الاغتصاب في إطار الزواج والتهديدات بالعنف كجزء من مشروع القانون 103-13 المتعلق بمكافحة العنف على المرأة وتنفيذ برامج برعاية الدولة لمساندة الضحايا", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 397, null, "R144.198", "198.144", "", "Non réalisé", "", 0, 6, 1, null, 3, 30, null, "Examen périodique universal", "Mettre en œuvre des mesures adéquates pour assurer la protection complète et efficace des femmes contre la violence familiale et accélérer le processus de rédaction d’un projet de loi conforme aux normes internationales dans ce domaine", "تنفيذ تدابير كافية لضمان توفير الحماية الشاملة والفعالة للنساء من العنف المنزلي وتسريع عملية صياغة مشروع قانون يتماشى مع المعايير الدولية لتوفير الحماية الشاملة والفعالة للنساء من العنف المنزلي", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 398, null, "R144.199", "199.144", "", "Non réalisé", "", 0, 6, 1, null, 49, 30, null, "Examen périodique universal", "Renforcer le cadre juridique visant à prévenir la discrimination et la violence à l’égard des femmes, notamment la violence familiale", "تقوية الإطار القانوني منعاً للتمييز والعنف على المرأة، ولا سيما العنف المنزلي", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 399, null, "R144.200", "200.144", "", "Non réalisé", "", 0, 6, 1, null, 50, 30, null, "Examen périodique universal", "Accélérer le processus d’adoption du projet de loi sur l’élimination de la violence à l’égard des femmes", "تسريع عملية اعتماد مشروع القانون المتعلق بالقضاء على العنف على المرأة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 400, null, "R144.202", "202.144", "", "Non réalisé", "", 0, 6, 1, null, 60, 30, null, "Examen périodique universal", "Adopter une 9 spécifique sur la violence à l’égard des femmes, y compris les dispositions pénales et civiles nécessaires pour remédier à la violence familiale et au harcèlement sexuel des femmes et des filles", "اعتماد تشريعات محددة بشأن العنف على المرأة تتضمن أحكاماً جنائية ومدنية ضرورية للتصدي للعنف المنزلي والتحرش الجنسي بالنساء والفتيات", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 401, null, "R144.203", "203.144", "", "Non réalisé", "", 0, 6, 1, null, 65, 30, null, "Examen périodique universal", "Mettre en œuvre la loi sur la violence à l’égard des femmes rapidement", "تنفيذ القانون المتعلق بالعنف على المرأة بصورة عاجلة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 58, null, "R81", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 2, "Procédure spéciale", "-       Adopter et promouvoir une approche multipartite dans l’élaboration d’un cadre permanent relatif à la régularisation des migrants", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 403, null, "R144.205", "205.144", "", "Non réalisé", "", 0, 6, 1, null, 76, 30, null, "Examen périodique universal", "Renforcer la 9 pour assurer l’égalité entre les sexes, en particulier pour prévenir la violence à l’égard des femmes, et mettre un terme aux mariages précoces et forcés", "تقوية التشريعات وتشديدها لكفالة المساواة بين الجنسين وخاصة لمنع العنف على المرأة ووقف حالات الزواج المبكر والقسري", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 404, null, "R144.206", "206.144", "", "Non réalisé", "", 0, 6, 1, null, 86, 30, null, "Examen périodique universal", "Accélérer la promulgation de la loi sur la violence à l’égard des femmes et l’adoption de la définition internationale de la violence fondée sur le genre", "الإسراع في سنّ القانون المتعلق بالعنف على المرأة واعتماد التعريف العالمي للعنف القائم على أساس نوع الجنس", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 405, null, "R144.208", "208.144", "", "Non réalisé", "", 0, 6, 1, null, 90, 30, null, "Examen périodique universal", "Adopter et appliquer une loi globale et non discriminatoire sur la violence à l’égard des femmes et des filles", "اعتماد وتنفيذ قانون شامل ولا تمييزي بشأ�� العنف على النساء والبنات", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 414, null, "R144.217", "217.144", "", "Non réalisé", "", 0, 6, 1, null, 23, 32, null, "Examen périodique universal", "Éliminer la pratique néfaste du mariage précoce et sensibiliser le public et les parents pour la protection efficace des mineures", "القضاء على الممارسة الضارة المتمثلة في الزواج المبكر وتوعية الجمهور والآباء والأمهات من أجل حماية الفتيات القاصرات حمايةً فعالة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 406, null, "R144.209", "209.144", "", "Non réalisé", "", 0, 6, 1, null, 67, 30, null, "Examen périodique universal", "Mettre en place une 9 spécifique pour prévenir les violences faites aux femmes, mener des enquêtes sur ces actes et les réprimer", "وضع تشريع محدد لمنع العنف على المرأة والتحقيق فيه والمعاقبة عليه", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 408, null, "R144.210", "210.144", "", "Non réalisé", "", 0, 6, 1, null, 86, 30, null, "Examen périodique universal", "Régler le nouveau protocole de la loi sur l’avortement pour donner aux femmes le droit d’avorter en cas d’inceste ou de viol, sur base du rapport de police seulement", "تعديل قانون الإجهاض الجديد لمنح النساء الحق في الإجهاض في حالات التعرض لزنا المحارم والاغتصاب بناءً على محضر الشرطة فقط", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 409, null, "R144.185P1", "185.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 89, 30, null, "Examen périodique universal", "….revoir toutes les lois et pratiques qui établissent une discrimination fondée sur le sexe et les mettre en conformité avec le droit international et les normes internationales, et prendre des mesures pour améliorer encore la protection des femmes victimes de la violence", "........ استعراض جميع القوانين والممارسات التي تشكل تمييزاً على أساس نوع الجنس وجعلها متوائمة مع القانون الدولي والمعايير الدولية واتخاذ خطوات من أجل زيادة تحسين حماية النساء اللواتي يتعرضن للعنف", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 504, null, "R17", "ت.17", "", "Non réalisé", "", 0, 6, 1, 1, null, 30, null, "Organes de traités", "Prendre toutes les mesures nécessaires afin de s’assurer de la pleine application du Code de la famille de manière uniforme sur tout le territoire national et d’éviter que certaines catégories parmi les plus vulnérables de sa population, en particulier les femmes et les enfants résidant dans les régions éloignées, ne soient victimes de doubles ou multiples discriminations.", "اتخاذ جميع التدابير الضرورية لضمان تطبيق كامل وموحد لمدونة الأسرة في جميع أنحاء الإقليم الوطني ولتفادي وقوع فئات معينة من أضعف السكان، وخاصةً النساء والأطفال في المناطق النائية، ضحية التمييز المزدوج أو المتعدد. وتذكّر اللجنة الدولة الطرف خصوصاً بتوصيتها العامة رقم 25(2000) بشأن أبعاد التمييز العنصري المتعلقة بنوع الجنس.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 25, null, "R88", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 32, 1, "Procédure spéciale", "-   Veiller à ce que le budget de l’État reflète la volonté de réaliser les droits des enfants en allouant des ressources équitables et suffisantes aux services essentiels pour les enfants, notamment en garantissant le droit de l’enfant à une alimentation saine et équilibrée.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 26, null, "R89", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 32, 1, "Procédure spéciale", "-   Redoubler d’efforts pour allouer des ressources suffisantes à l’amélioration et à la protection de l’alimentation des enfants, et pour concevoir, adopter et mettre en œuvre des politiques et des programmes coordonnés dans ce domaine, en particulier en milieu rural", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 110, null, "R91P1", "ت.91.ف.1", "", "Non réalisé", "", 0, 6, 1, null, null, 32, 3, "Procédure spéciale", "-    Organiser des visites régulières dans les postes de police en accordant une attention particulière aux délinquants mineurs, de ne pas placer des mineurs dans des prisons ordinaires mais de renforcer les centres de protection des enfants et d’enquêter sur toutes les plaintes de torture et de mauvais traitements émanant de mineurs, en particulier sur les allégations relatives aux châtiments corporels;", "فيما يتعلق بالأحداث، يوصي المقرر الخاص الحكومة بما يلي:- (أ) زيارة مراكز الشرطة بانتظام، مع التركيز خصوصاً على الأحداث الجانحين؛ وعدم حبسهم في سجون عادية وإنما تدعيم هيكلية مراكز حماية الأطفال؛ والتحقيق في جميع شكاوى تعذيبهم أو إساءة معاملتهم، لا سيما الادعاءات المتعلقة بالعقوبة البدنية؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 111, null, "R91P3", "ت.91.ف.3", "", "Non réalisé", "", 0, 6, 1, null, null, 32, 3, "Procédure spéciale", "-    Pour ce qui est des mineurs, le Rapporteur spécial recommande au Gouvernement de déployer des procureurs et des fonctionnaires de police judiciaire spécialisés dans les affaires concernant des délinquants mineurs.", "فيما يتعلق بالأحداث، يوصي المقرر الخاص الحكومة بما يلي: (ج) توفير خدمات مدعين عامين متخصصين وموظفين في الشرطة القضائية متخصصين في قضايا الجانحين الأحداث.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 139, null, "R99P1-2", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 32, 4, "Procédure spéciale", "En ce qui les provinces marocaines du sud :- a) …………. prendre des mesures concrètes pour améliorer la situation des employés de maison et lutter contre le travail des enfants et l’exploitation sexuelle des femmes et des enfants", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 206, null, "R83P20", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 32, 7, "Procédure spéciale", "Mettre en place un système de visites régulières dans les postes de police avec un accent particulier sur les délinquants juvéniles, ne pas placer les mineurs dans les prisons ordinaires mais plutôt dans des centres de protection de l’enfance- Enquêter sur toutes les plaintes de torture et de mauvais traitements des mineurs, notamment des allégations de châtiments corporels", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 207, null, "R83P22", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 32, 7, "Procédure spéciale", "-       Fournir des procureurs spécialisés et des officiers de police judiciaire specialises pour les cas de jeunes délinquants", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 410, null, "R144.135", "135.144", "", "Non réalisé", "", 0, 6, 1, null, 71, 32, null, "Examen périodique universal", "Envisager d’éliminer des documents d’identité toutes les données qui pourraient conduire à une discrimination contre les enfants nés hors mariage", "النظر في إلغاء جميع البيانات من وثائق الهوية التي من شأنها أن تؤدي إلى تمييز في حق الأطفال المولودين خارج إطار الزواج", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 411, null, "R144.136", "136.144", "", "Non réalisé", "", 0, 6, 1, null, 83, 32, null, "Examen périodique universal", "Améliorer les procédures actuelles d’enregistrement des enfants pour garantir l’égalité entre les enfants et l’égalité de traitement juridique sans aucune discrimination", "تحسين الإجراءات المتّبعة في تسجيل الأطفال من أجل ضمان المساواة بين الأطفال والمعاملة القانونية المتساوية لهم دونما تمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 412, null, "R144.139", "139.144", "", "Non réalisé", "", 0, 6, 1, null, 94, 32, null, "Examen périodique universal", "Éliminer les frais pour les actes de naissance et faciliter la délivrance d’un certificat de naissance à tous les enfants réfugiés qui n’en ont pas encore", "إلغاء الرسوم المفروضة على إصدار شهادات الميلاد وتيسير إصدار شهادات الميلاد لجميع الأطفال اللاجئين الذين لا يملكون شهادة ميلاد بعد", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 407, null, "R144.196P1", "196.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 14, 30, null, "Examen périodique universal", "Poursuivre ses efforts tendant à améliorer la 9 concernant la violence à l’égard des femmes", "مواصلة الجهود من أجل تحسين التشريعات المتعلقة بالعنف على المرأة بما يتفق مع المعايير الدولية بأن تتناول أبعاد الوقاية والحماية والمساعدة، ............", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 59, null, "R82", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 2, "Procédure spéciale", "-       Renforcer les mesures visant à éliminer les obstacles administratifs et les autres obstacles structurels à l’intégration des réfugiés et des migrants", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 446, null, "R144.109", "109.144", "", "Non réalisé", "", 0, 6, 1, null, 74, 35, null, "Examen périodique universal", "Poursuivre les efforts visant à lutter contre la traite des êtres humains et veiller à ce qu’une attention particulière soit accordée aux groupes vulnérables en appliquant la loi adoptée à cet égard", "مواصلة الجهود لمكافحة الاتجار بالبشر وضمان إيلاء عناية خاصة للفئات الضعيفة عند تطبيق القانون المعتمَد في هذا الشأن", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 61, null, "R84", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 2, "Procédure spéciale", "-       Éliminer toutes les pratiques de profilage racial et toutes les autres pratiques discriminatoires d’application de la loi sur l’immigration, y compris les réinstallations forcées, les arrestations et détentions arbitraires, le confinement régional des Africains noirs d’origine subsaharienne et le recours excessif à la force à leur égard.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 144, null, "R83P2", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 4, "Procédure spéciale", "……..Former le personnel des organismes d’application des lois, en particulier les policiers, les agents des services d’immigration et les inspecteurs du travail. - Le personnel ainsi formé devrait être mieux à même de repérer rapidement et sans se tromper les victimes de la traite et de les orienter vers les services voulus. - Distinguer clairement les migrants en situation irrégulière des victimes de la traite, ces deux catégories de personnes devant être soumises à des lois et à des procédures distinctes.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 145, null, "R90", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 4, "Procédure spéciale", "-    Organiser des programmes de formation à l’application des instruments juridiques internationaux au profit des avocats et autres professionnels pour pouvoir appliquer les lois et les normes internationales relatives aux droits de l’homme.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 146, null, "R99P2-1", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 4, "Procédure spéciale", "En ce qui les provinces marocaines du sud :- b) Renforcer encore les capacités actuelles pour permettre de détecter les cas de traite des êtres humains…….", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 172, null, "R89P11", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 6, "Procédure spéciale", "Prendre d’autres mesures pour sensibiliser et former l’ensemble du personnel et des services du secteur de la justice en ce qui concerne les obligations de l’État dans le domaine des droits de l’homme, ainsi que leur place et leur incorporation dans l’ordre juridique interne. - Le Ministère de l’26, le Ministère de la justice et le Ministère de la solidarité, de la femme, de la famille et du développement social sont encouragés à assurer une sensibilisation accrue de la société à tous les aspects de la violence à l’égard des femmes et à intégrer l’information sur la prévention effective de la violence fondée sur le sexe et de la lutte contre cette violence dans les programmes de formation de la police, et de la justice et des secteurs juridique et social", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 173, null, "R91P5", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 6, "Procédure spéciale", "Faciliter l’accès des 32aires des deux sexes, en particulier ceux qui sont élus pour la première fois, aux services de renforcement des capacités, de façon à accroître leurs connaissances des obligations internationales de l’État en matière de droits de l’homme et de tous les aspects des droits fondamentaux des femmes ainsi que des techniques de rédaction juridique et d’autres tâches législatives; dans les environnements où les hommes prédominent, les femmes devraient bénéficier d’une formation pour développer leur sens de la direction et leur confiance en elle-même;", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 233, null, "R86P1-6", "ت.86.ف1ج6", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 8, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en encourageant les fonctionnaires et administrateurs fournissant des services publics aux locuteurs amazighs, les juges et les avocats à améliorer leurs connaissances linguistiques et en veillant à ce que des interprètes de langue amazighe soient formés et disponibles auprès des tribunaux ;", "(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:- - تعزيز المهارات اللغوية في صفوف الموظفين الحكوميين والإداريين الذين يقدمون خدمات عامة للناطقين بالأمازيغية، وفي صفوف القضاة والمحاميين، وضمان تدريب وتوفر مترجمين شفويين لدى المحاكم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 234, null, "R83P2", "ت.83.ف.2", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 8, "Procédure spéciale", "Les nouvelles lois et mesures relatives à la mise en œuvre de nouvelles dispositions constitutionnelles, en particulier celles qui concernent les droits et la diversité culturels exigent l’adoption de politiques et stratégies pertinentes, et ceux qui sont chargés de mettre celles-ci en œuvre doivent recevoir une formation et des orientations à cet effet.", "-       تتطلب القوانين والتدابير الجديدة  المتعلقة بإنفاذ الأحكام الدستورية الجديدة، لا سيما تلك الخاصة بالحقوق الثقافية والتنوع الثقافي اعتماد سياسات واستراتيجيات مناسبة وينبغي أن تقترن بتدريب مناسب وتوجيه صحيح للمسؤولين المكلفين بتطبيقها.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 235, null, "R88P1", "ت.88.ف.1", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 8, "Procédure spéciale", "Adoption d’une procédure plus efficace, plus simple et plus conviviale de présentation des projets culturels à l’INDH et aux autres institutions de développement est cruciale pour autonomiser le secteur culturel de la société civile et susciter une participation plus active aux niveaux régional et national.", "-       اعتماد عملية أكثر فعالية وبساطة وسهولة في الاستعمال لتقديم الطلبات فيما يخص المشاريع الثقافية التي تدخل في إطار المبادرة الوطنية للتنمية البشرية وغيرها من الوكالات الإنمائية، لتمكين القطاع المدني الثقافي والسماح بمشاركة أكثر فعالية على الصعيدين الإقليمي والوطني.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 236, null, "R86P1-4", "ت.86.ف1ج4", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 8, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en fournissant des fonds et une assistance adéquats dans le cadre de mesures de renforcement des capacités pour promouvoir l’utilisation de la langue amazighe dans l’éducation et la vie publique; en particulier, une assistance financière supplémentaire devrait être apportée à l’IRCAM afin que ces ouvrages et publications soient largement distribués dans les zones rurales", "(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:- 4-تقديم التمويل والمساعدة الكافيين لتدابير بناء القدرات من أجل تعزيز استخدام اللغة الأمازيغية في التعليم والحياة العامة؛ وبصورة خاصة، ينبغي تقديم مزيد من المساعدة المالية للمعهد الملكي للثقافة الأمازيغية لضمان توزيع الكتب والمنشورات ذات الصلة على نطاق واسع في المناطق الريفية؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 238, null, "R90P1P2", "ت.90.ق.1.ف.2", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 8, "Procédure spéciale", "- Mettre en place des mécanismes permettant une participation effective et digne de ce nom, notamment en matière de prise de décisions, de la population au recensement, à l’interprétation, à la promotion et à la protection du patrimoine culturel.", "إنشاء آليات تسمح للأشخاص باتخاذ قرارات فعالة ومجدية والمشاركة في تحديد التراث الثقافي وتفسيره وتعزيزه وحمايته. - توفير الدعم القانوني والمالي والمؤسسي لمقترح 'الكنوز البشرية الحية'. وينبغي للمغرب أيضاً", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 239, null, "R90P1P2", "ت.90.ق.1.ف.2", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 8, "Procédure spéciale", "- Apporter un appui juridique, financier et institutionnel à la proposition relative aux «trésors humains vivants»", "إنشاء آليات تسمح للأشخاص باتخاذ قرارات فعالة ومجدية والمشاركة في تحديد التراث الثقافي وتفسيره وتعزيزه وحمايته. - توفير الدعم القانوني والمالي والمؤسسي لمقترح 'الكنوز البشرية الحية'. وينبغي للمغرب أيضاً", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 240, null, "R87", "ت.87", "", "Non réalisé", "", 0, 9, 1, null, null, 36, 8, "Procédure spéciale", "lors du recensement de 2014, des informations doivent être recueillies sur la composition de la population, l’usage des langues arabe, amazighe et autres, et sur tout autre indicateur de la diversité ethnique et culturelle de la population.", "-       توصي الخبيرة المستقلة أيضاً بأن تُجمع، خلال التعداد السكاني لعام 2014، معلومات عن تركيبة السكان، واستخدام اللغتين العربية والأمازيغية وغيرهما من اللغات، وأي مؤشر آخر على التنوع الإثني والثقافي للسكان. وفي هذا الصدد، قد ترغب الحكومة في التماس مساعدة اليونسكو فيما يخص عملها المتعلق بالمؤشرات الثقافية.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 246, null, "R73P5", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 8, "Procédure spéciale", "Allouer des ressources supplémentaires au renforcement des capacités à tous les niveaux de la mise en œuvre des activités de développement, compte tenu en particulier de la décentralisation imminente- Il est suggéré que la Délégation interministérielle aux droits de l’homme intensifie, en coordination avec le Conseil national des droits de l’homme et autres partenaires, les programmes de formation aux droits de l’homme, en particulier ceux qui sont destinés aux fonctionnaires œuvrant à la prestation de services publics. Cela améliorerait la transparence et constituerait une mesure positive en vue de prévenir le favoritisme et la corruption dans la 21", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 247, null, "R74P3", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 8, "Procédure spéciale", "Dans le cadre de leur partenariat, prévoir à l’intention de la société civile et des collectivités des activités d’éducation, de formation et de renforcement des capacités dans le domaine des droits de l’homme, afin de leur permettre d’être de véritables acteurs de leur propre développement.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 448, null, "R144.38", "38.144", "", "Non réalisé", "", 0, 7, 1, null, 28, 36, null, "Examen périodique universal", "Continuer à intégrer les droits de l’homme dans différents secteurs et organismes nationaux", "مواصلة تعميم منظور حقوق الإنسان في مختلف الهيئات والقطاعات الوطنية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 449, null, "R144.64", "64.144", "", "Non réalisé", "", 0, 7, 1, null, 9, 36, null, "Examen périodique universal", "Poursuivre l’expérience positive consistant à organiser des programmes de renforcement des capacités en matière de droits de l’homme à l’intention des organismes chargés de faire respecter la loi", "مواصلة التجربة الإيجابية المتمثلة في تنظيم برامج لبناء القدرات في ميدان حقوق الإنسان لفائدة وكالات إنفاذ القانون", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 450, null, "R144.65", "65.144", "", "Non réalisé", "", 0, 7, 1, null, 54, 36, null, "Examen périodique universal", "Continuer de former les fonctionnaires aux droits de l’homme", "مواصلة تدريب المسؤولين العموميين على حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 451, null, "R144.66", "66.144", "", "Non réalisé", "", 0, 7, 1, null, 76, 36, null, "Examen périodique universal", "Promouvoir l’éducation et la formation des agents de la 21 aux droits de l’homme, en veillant à la fourniture des ressources nécessaires, à tous les niveaux. Les employés de l’administration à l’échelon local, qui ont l’influence la plus directe sur la population, manquent le plus souvent de formation aux droits de l’homme ou des ressources nécessaires pour satisfaire aux normes internationales sur les droits de l’homme", "تعزيز التثقيف في ميدان حقوق الإنسان وتدريب الموظفين العموميين، إلى جانب التزويد بالموارد الضرورية على جميع المستويات. فموظفو الحكومات المحلية، الذين لهم الأثر الأكثر مباشرَة على الناس، كثيراً ما يفتقرون إلى تدريب في ميدان حقوق الإنسان أو إلى الموارد لتلبية المعايير الدولية في ميدان حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 507, null, "R20P1", "ت.20.ف1", "", "Non réalisé", "", 0, 7, 1, 1, null, 36, null, "Organes de traités", "Accentue ses efforts de formation aux droits de l’homme, en particulier à la lutte contre la discrimination raciale, de même que ses efforts de sensibilisation à la tolérance, à l’entente interraciale ou interethnique et aux relations interculturelles auprès des agents chargés de l’application des lois, notamment des personnels de police et de gendarmerie, de la justice, de l’administration pénitentiaire, des avocats, ainsi que des enseignants.", "- بذل مزيد من الجهود للتدريب على حقوق الإنسان، وخاصة على مكافحة التمييز العنصري، ومزيد من جهود التحسيس كذلك في صفوف الموظفين المكلفين بإنفاذ القوانين، ولا سيما العاملين في الشرطة والدرك والقضاء وإدارة السجون، وفي صفوف المحامين والمدرِّسين، بقيم التسامح والوئام بين الأعراق أو الإثنيات والعلاقات بين الثقافات.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 66, null, "R77", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 37, 2, "Procédure spéciale", "-       Redoubler d’efforts pour éliminer les préjugés, les stéréotypes négatifs et la stigmatisation et prendre des mesures efficaces visant à promouvoir la tolérance et la compréhension, conformément à l’article 7 de la Convention internationale sur l’élimination de toutes les formes de discrimination raciale", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 147, null, "R89", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 37, 4, "Procédure spéciale", "Des efforts de sensibilisation et de renforcement des capacités devraient être entrepris d’urgence afin que les affaires de traite fassent l’objet de mesures centrées sur la victime. - Le Gouvernement devrait également redoubler d’efforts pour sensibiliser le grand public à toutes les formes de traite des êtres humains, afin de mieux faire comprendre ce qui constitue une forme de traite", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 174, null, "R89P12", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 37, 6, "Procédure spéciale", "Mettre l’enseignement, les médias et d’autres moyens au service d’une sensibilisation accrue aux questions juridiques et d’une meilleure connaissance de ces questions, s’agissant notamment des moyens d’obtenir une réparation d’ordre judiciaire et sous toute autre forme en cas de violation des droits de l’homme et de combattre les obstacles culturels et sociaux à l’égalité et au respect des droits fondamentaux des femmes au Maroc", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 245, null, "R73P1-2", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 37, 8, "Procédure spéciale", "Les nouveaux objectifs de développement durable, le document final de la troisième Conférence internationale sur le financement du développement et l’accord sur le climat issu de la vingt et unième session de la Conférence des Parties à la Convention-cadre des Nations Unies sur les changements climatiques devraient être diffusés sous une présentation simplifiée auprès du plus grand nombre, afin que le public puisse prendre connaissance de leurs conséquences directes pour le Maroc", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 452, null, "R144.63", "63.144", "", "Non réalisé", "", 0, 7, 1, null, 54, 37, null, "Examen périodique universal", "Redoubler d’efforts pour promouvoir la culture des droits de l’homme et l’éducation aux droits de l’homme", "بذل المزيد من الجهود لتعزيز ثقافة حقوق الإنسان والتثقيف في ميدان حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 508, null, "R18P2", "ت.18.ف.2", "", "Non réalisé", "", 0, 7, 1, 1, null, 37, null, "Organes de traités", "Informer la population, en particulier les catégories vulnérables et notamment les Amazighs, les Sahraouis, les noirs, les non-ressortissants, les réfugiés et les demandeurs d’asile, de toutes les voies de recours juridiques disponibles, de simplifier ces recours et d’en faciliter l’accès", "إعلام السكان، وخاصة الفئات الضعيفة ولا سيما الأمازيغ والصحراويون والزنوج وغير المواطنين واللاجئون وطالبو اللجوء، بجميع سبل الانتصاف القانونية المتاحة، وتبسيط تلك السبل وتسهيل اللجوء إليها", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 509, null, "R20P2", "ت.20.ف2", "", "Non réalisé", "", 0, 7, 1, 1, null, 37, null, "Organes de traités", "- Poursuivre les initiatives de sensibilisation et d’éducation du public, à la diversité multiculturelle, à l’entente et à la tolérance, notamment à l’égard de certaines catégories vulnérables, en particulier de certains amazighs, des saharawis, des noirs, des non-ressortissants, des réfugiés et des demandeurs d’asile.", "- مواصلة تنفيذ مبادرات تحسيس عامة الناس وتثقيفهم بشأن التنوع الثقافي والوئام والتسامح، خصوصاً تجاه بعض الفئات الضعيفة، وخاصة بعض الأمازيغ والصحراويين والزنوج وغير المواطنين واللاجئين وطالبي اللجوء.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 392, null, "R144.188", "188.144", "", "Non réalisé", "", 0, 6, 1, null, 44, 30, null, "Examen périodique universal", "Adopter une 9 complète et globale visant à éliminer la discrimination et toutes les formes de violence à l’égard des femmes et à les promouvoir dans tous les domaines, notamment le domaine économique", "اعتماد تشريعات شاملة ومتكاملة للقضاء على التمييز وعلى جميع أشكال العنف على المرأة ولتشجيع ارتقائها في جميع المجالات بما فيها المجال الاقتصادي", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 115, null, "R95P2", "ت.95.ف.2", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 3, "Procédure spéciale", "-    sensibiliser davantage l’ensemble du personnel chargé d’appliquer la loi à son rôle de prévention de la torture et des mauvais traitements au moyen de cours obligatoires de formation aux normes internationales relatives à l’interdiction de la torture, aux dispositions régissant les enquêtes en cas de torture et de mauvais traitements, et aux techniques d’interrogatoire et de renforcer les programmes de formation sur la façon de déceler, de signaler et de prévenir la torture, destinés aux professionnels de la santé et de l’administration de la justice;", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي:- (ب) إذكاء وعي جميع موظفي إنفاذ القانون بدورهم في منع التعذيب وسوء المعاملة بواسطة التدريب الإلزامي على المعايير الدولية المتعلقة بمنع التعذيب والأحكام المنظمة للتحقيقات في التعذيب وسوء المعاملة وأساليب الاستجواب، واستحداث المزيد من البرامج التدريبية التي ينبغي تقديمها أثناء دورات التأهيل المهني للعاملين في مجالي الصحة والقانون بشأن كشف التعذيب والإبلاغ عنه وتوقيه؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 65, null, "R91", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 2, "Procédure spéciale", "-       Accroître les ressources des bureaux régionaux du Conseil national des droits de l’homme et leur procurer des possibilités de formation sur les obligations internationales en matière de droits de l’homme pour combattre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, en prêtant particulièrement attention aux variations locales dans les manifestations de ces problèmes", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 64, null, "R90", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 2, "Procédure spéciale", "-       Renforcer les capacités et les compétences des bureaux régionaux du Conseil national des droits de l’homme en matière de lutte contre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, en accordant une attention particulière aux dynamiques régionales qui influent sur l’égalité raciale.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 63, null, "R76", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 2, "Procédure spéciale", "-       Renforcer les mesures préventives d’éducation, de formation et de sensibilisation de sorte que tous les agents publics, y compris ceux qui sont responsables de l’administration des services publics, s’abstiennent de toute forme de racisme, de discrimination raciale, de xénophobie et d’intolérance qui y est associée.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 62, null, "R85", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 2, "Procédure spéciale", "-       Fournir une aide humanitaire d’urgence à toutes les personnes victimes de graves violations des droits de l’homme dans le contexte migratoire, sans distinction de race, d’appartenance ethnique, d’origine nationale, d’ascendance ou de statut migratoire, en particulier à celles qui risquent de subir une discrimination croisée en raison de leur sexe, de leur identité de genre, de leur orientation sexuelle, d’un handicap ou de toute autre situation", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 112, null, "R88P11", "ت.88.ف.11", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 3, "Procédure spéciale", "-    veiller à ce que le principe de non-refoulement énoncé à l’article 3 de la Convention contre la torture soit pleinement appliqué, notamment dans le cas des migrants, des réfugiés et des demandeurs d’asile, pour que nul ne soit expulsé vers un pays où il risque d’être soumis à la torture;", "-          (ك) ضمان تطبيق مبدأ عدم الإعادة القسرية المنصوص عليه في المادة 3 من اتفاقية مناهضة التعذيب تطبيقاً تاماً، مثلاً على المهاجرين واللاجئين وملتمسي اللجوء، بحيث لا يسلّم الناس إلى أي بلد يحتمل أن يعذبوا فيه؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 113, null, "R90P2", "ت.90.ف.2", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 3, "Procédure spéciale", "-    Prendre toutes les mesures nécessaires pour prévenir d’autres violences et enquêter sur les informations faisant état d’actes de violence subis par des migrants, des réfugiés et des demandeurs d’asile subsahariens", "-          (أ) اتخاذ جميع التدابير اللازمة لمنع حدوث المزيد من أعمال العنف، والتحقيق في التقارير التي تتحدث عن تلك الأعمال في حق المهاجرين واللاجئين وملتمسي اللجوء من الصحراء الغربية؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 114, null, "R90P3", "ت.90.ف.3", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 3, "Procédure spéciale", "-    Respecter les droits de l’homme fondamentaux des migrants, des réfugiés et des demandeurs d’asile et de leur assurer l’accès aux établissements de santé et aux soins médicaux sans crainte d’être arrêtés.", "-          (ب) احترام الحقوق الإنسانية الأساسية للمهاجرين واللاجئين وملتمسي اللجوء، وتيسير دخولهم المرافق الصحية وتلقيهم الرعاية الطبية دون خوف من اعتقالهم.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 140, null, "R99P1-1", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 4, "Procédure spéciale", "En ce qui les provinces marocaines du sud :- a) prendre des mesures concrètes pour améliorer la situation des migrants en situation irrégulière…………", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 208, null, "R83P17", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 7, "Procédure spéciale", "-       Prendre toutes les mesures nécessaires pour empêcher les arrestations massives et autres actes de violence et enquêter sur les rapports concernant les violences commises contre les migrants sub-sahariens, les réfugiés et les demandeurs d’asile", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 209, null, "R83P18", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 7, "Procédure spéciale", "S’assurer que les garanties juridiques régissant la pratique de reconduite à la frontière des migrants sans papiers et l’expulsion de ressortissants étrangers soient effectivement appliquées et que de telles pratiques et expulsions soient effectuées conformément au droit international et national. - Le Gouvernement devrait demander des enquêtes impartiales et efficaces sur les allégations de mauvais traitements ou d’usage excessif de la force lors des expulsions de migrants. Il convient également de s’assurer que les responsables soient traduits en justice et condamnés à des peines proportionnelles à la gravité de leurs actes", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 210, null, "R83P19", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 7, "Procédure spéciale", "-       Envisager différentes mesures non privatives de liberté, telles que l’obligation de faire rapport, avant de recourir à la détention des migrants, réfugiés et demandeurs d’asile ;", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 440, null, "R144.222P3", "222.144. ج.3", "", "Non réalisé", "", 0, 6, 1, null, 19, 34, null, "Examen périodique universal", "Prendre des mesures plus efficaces pour mieux protéger les droits des migrants", "اتخاذ تدابير أكثر نجوعاً من أجل توفير حماية أفضل.... المهاجرين وغير ذلك من الفئات الضعيفة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 441, null, "R144.224P2", "224.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 79, 34, null, "Examen périodique universal", "Continuer à renforcer les politiques publiques pertinentes pour la promotion et la protection des droits de l’homme, en particulier les droits des demandeurs d’asile () ;", "مواصلة تقوية السياسات العامة ذات الصلة لتعزيز وحماية حقوق الإنسان، وبخاصة حقوق... المهاجرين وملتمسي اللجوء ...", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 442, null, "R144.237", "237.144", "", "Non réalisé", "", 0, 6, 1, null, 75, 34, null, "Examen périodique universal", "Poursuivre la mise en œuvre de la politique de promotion et de protection effectives des droits des migrants () ;", "مواصلة تنفيذ سياسة التعزيز والحماية الفعّالين لحقوق المهاجرين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 443, null, "R144.238", "238.144", "", "Non réalisé", "", 0, 6, 1, null, 27, 34, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir et protéger les droits des migrants", "مواصلة الجهود الرامية إلى تعزيز وحماية حقوق المهاجرين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 444, null, "R144.241", "241.144", "", "Non réalisé", "", 0, 6, 1, null, 82, 34, null, "Examen périodique universal", "Envisager de partager avec d’autres pays l’expérience marocaine en matière de protection et de promotion des droits des migrants", "النظر في تبادل الخبرة المغربية مع بلدان أخرى فيما يتعلق بحماية وتعزيز حقوق المهاجرين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 60, null, "R83", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 34, 2, "Procédure spéciale", "-       Veiller à ce que la politique migratoire nationale fondée sur les droits de l’homme soit appliquée uniformément à tous les échelons de l’administration.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 505, null, "R13P2", "ت.13.ف.2", "", "Non réalisé", "", 0, 6, 1, 1, null, 34, null, "Organes de traités", "Garantir la protection des droits des réfugiés et des demandeurs d’asile, notamment en ce qui concerne l’accès à l’emploi et l’accès au logement, ainsi que leur protection contre la discrimination raciale", "ضمان حماية حقوق اللاجئين وطالبي اللجوء فيما يخص الحصول على العمل والسكن وحماية تلك الفئات من الناس من أي تمييز عنصري.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 141, null, "R91", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 35, 4, "Procédure spéciale", "Redoubler les efforts pour poursuivre les trafiquants tout en garantissant leur droit à un procès équitable dans le cadre d’une approche de la justice pénale fondée sur les droits de l’homme, et pour établir le cadre juridique et les procédures nécessaires en vue d’assurer la protection des victimes et des témoins. - En ce qui concerne les Marocains vivant à l’étranger, le Gouvernement devrait définir et mettre en œuvre des mesures judiciaires efficaces pour protéger les Marocaines prises au piège des réseaux de prostitution à l’étranger.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 142, null, "R93", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 35, 4, "Procédure spéciale", "-    Les peines et les sanctions infligées aux personnes qui se rendent coupables de travail forcé devraient être plus lourdes, de façon à dissuader les trafiquants qui recrutent à cette fin.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 143, null, "R99P2-2", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 35, 4, "Procédure spéciale", "En ce qui les provinces marocaines du sud :- b) …..prendre de nouvelles mesures pour réduire la vulnérabilité des victimes potentielles de la traite assurer une protection adéquate aux migrants et aux membres de leur famille", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 445, null, "R144.108", "108.144", "", "Non réalisé", "", 0, 6, 1, null, 44, 35, null, "Examen périodique universal", "Renforcer ses mécanismes nationaux et la coopération internationale pour lutter contre la traite des êtres humains et, en particulier, le tourisme sexuel impliquant des enfants", "تقوية آلياته الوطنية والتعاون الدولي على مكافحة الاتجار بالأشخاص ولا سيما سياحة الجنس التي يُستخدم فيها أطفال", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 447, null, "R144.110P1", "110.144.ج.1", "", "Non réalisé", "", 0, 6, 1, null, 80, 35, null, "Examen périodique universal", "Élaborer une stratégie nationale pour lutter contre l’esclavage moderne", "وضع استراتيجية وطنية للتصدي للعبودية المعاصرة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 28, null, "R78", "null", "", "Non réalisé", "", 0, 7, 1, null, null, 36, 1, "Procédure spéciale", "-   Sensibiliser les populations locales, en particulier les femmes et les jeunes, et faciliter leur participation, avec l’appui des organisations non gouvernementales, aux mesures de développement visant à combattre les effets des changements climatiques", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 29, null, "R66P2", "null", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 1, "Procédure spéciale", "Désigner les autorités et les organismes responsables de la mise en œuvre et mettre en place des mécanismes adéquats de suivi et de responsabilisation se rapportant à la loi-cadre relative au droit à l’alimentation à mettre en place. - Garantir la pleine participation de tous les acteurs concernés, notamment des plus vulnérables face à la faim et à la malnutrition", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 30, null, "R67P1", "null", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 1, "Procédure spéciale", "-   Garantir la bonne application des lois en vigueur en renforçant les mécanismes de suivi et de responsabilisation", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 31, null, "R69", "null", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 1, "Procédure spéciale", "Promouvoir une société civile indépendante, qui permettra au Maroc de renforcer l’engagement qu’il a pris de garantir le respect des droits de l’homme et des libertés fondamentales à l’avenir. - Encourager la société civile à incorporer les droits économiques, sociaux et culturels, en particulier le droit à l’alimentation, dans son programme.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 32, null, "R70", "null", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 1, "Procédure spéciale", "-   Renforcer les mécanismes de suivi et d’évaluation afin que les projets d’intensification agricole lancés dans le cadre du pilier I du Plan Maroc Vert soient écologiquement viables et qu’ils ne conduisent pas à l’épuisement des ressources.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 33, null, "R74", "null", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 1, "Procédure spéciale", "-   Élargir les mécanismes de suivi existants pour que les permis de pêche annuels soient délivrés de manière transparente, conformément aux règles internationales relatives à la pêche", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 34, null, "R87", "null", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 1, "Procédure spéciale", "Veiller à ce que les dispositifs de protection sociale bénéficient aux groupes les plus pauvres et les plus désavantagés, notamment à ceux vivant en milieu rural, en s’employant à mieux identifier les personnes admissibles ; - -Veiller à ce que les cibles des programmes soient choisies de manière transparente et éliminer la corruption à tous les niveaux du système", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 35, null, "R90P2", "null", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 1, "Procédure spéciale", "-   Renforcer le rôle des travailleurs sociaux et veiller à ce que ceux-ci soient rémunérés en conséquence, afin de garantir le contrôle effectif du respect du droit de l’enfant à une alimentation suffisante et équilibrée et de promouvoir une alimentation équilibrée auprès des familles.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 506, null, "R14", "ت.14", "", "Non réalisé", "", 0, 6, 1, 1, null, 34, null, "Organes de traités", "Prendre des mesures visant à protéger les non-ressortissants dépourvus de titre de séjour contre la discrimination raciale et la xénophobie, à veiller à l’application de toutes garanties juridiques relatives à leur détention, ainsi qu’à faciliter leur accès aux tribunaux. Le Comité recommande également à l’Etat partie de garantir l’application correcte du principe de non-refoulement.", "-اتخاذ تدابير لحماية غير المواطنين الذين لا يملكون رخصة إقامة من التمييز العنصري ومن كراهية الأجانب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 237, null, "R86P1-5", "ت.86.ف1ج5", "", "Non réalisé", "", 0, 8, 1, null, null, 36, 8, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en veillant à ce que les chaînes de télévision et stations de radio qui diffusent leurs programmes en langue arabe diffusent également au moins 30 % de ceux-ci en langue amazighe, comme le prévoit la loi; des mesures supplémentaires devraient aussi être prises pour élaborer des programmes aux niveaux national et régional afin d’appuyer les activités menées pour promouvoir la connaissance du patrimoine culturel et la diversité culturelle dans le cadre des émissions pédagogiques et destinées à la jeunesse et pour associer les médias nationaux à cette action", "(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:- 5-ضمان قيام قنوات وسائط الإعلام التي تبث برامجها باللغة العربية ببث ما لا يقل عن 30 في المائة من برامجها باللغة الأمازيغية، مثلما ينص على ذلك القانون؛ وينبغي اتخاذ مزيد من التدابير لإعداد برامج على الصعيدين الوطني والإقليمي من أجل دعم الجهود الرامية إلى تعزيز معرفة التراث الثقافي والتنوع في البرامج التعليمية والشبابية، وتعبئة وسائط الإعلام الوطنية للدعوة إلى هذا النهج؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 391, null, "R144.133", "133.144", "", "Non réalisé", "", 0, 6, 1, null, 26, 30, null, "Examen périodique universal", "Abroger les dispositions qui privent les femmes de la tutelle légale des enfants mineurs sur un pied d’égalité avec les hommes", "إلغاء الأحكام القانونية التي تحرم النساء من ممارسة الوصاية القانونية على الأطفال القصّر على قدم المساواة مع الرجال", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 389, null, "R144.228P1", "228.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 38, 30, null, "Examen périodique universal", "Accélérer encore les efforts visant à promouvoir les droits des femmes en particulier ceux qui sont handicapés", "زيادة تسريع الجهود المبذولة لأجل تعزيز حقوق المرأة...... ولا سيما ذوي الإعاقات منهم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 287, null, "R144.72", "72.144", "", "Non réalisé", "", 0, 3, 1, null, 17, 9, null, "Examen périodique universal", "Interdire la discrimination et ériger en infraction la violence envers des personnes en raison de leur orientation sexuelle ou de leur identité de genre", "حظر التمييز وتجريم العنف على الأشخاص على أساس ميلهم الجنسي أو هويتهم الجنسانية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 288, null, "R144.73", "73.144", "", "Non réalisé", "", 0, 3, 1, null, 36, 9, null, "Examen périodique universal", "Mettre fin aux formes de discrimination (notamment juridiques) auxquelles se heurtent les lesbiennes, gays, bisexuels, transgenres et intersexués", "إنهاء أشكال التمييز (بما فيها الأشكال القانونية) التي يتعرض لها المثليات والمثليون ومزدوجو الميل الجنسي ومغايرو الهوية الجنسانية وحاملو صفات الجنسين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 289, null, "R144.75 P1P3", "75.144. ج.1 ج.3", "", "Non réalisé", "", 0, 3, 1, null, 31, 9, null, "Examen périodique universal", "Garantir les mêmes droits à tous les citoyens, y compris ceux de la communauté des lesbiennes, gays, bisexuels, transgenres et intersexué en éliminant toutes les lois discriminatoires sur la base de l’orientation sexuelle", "ضمان تمتع جميع المواطنين بالحقوق نفسها، بمن فيهم المثليات والمثليون ومزدوجو الميل الجنسي ومغايرو الهوية الجنسانية وحاملو صفات الجنسين، ..... وإلغاء جميع التشريعات التمييزية على أساس الميل الجنسي", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 290, null, "R144.76", "76.144", "", "Non réalisé", "", 0, 3, 1, null, 45, 9, null, "Examen périodique universal", "Adopter et appliquer une 9 complète contre la discrimination qui contienne une interdiction générale de toutes formes de discrimination directe et indirecte", "تطبيق واعتماد قانون شامل لمكافحة التمييز يتضمن حظراً عاماً لجميع أشكال التمييز المباشرة منها وغير المباشرة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 291, null, "R144.78", "78.144", "", "Non réalisé", "", 0, 3, 1, null, 1, 9, null, "Examen périodique universal", "Adopter une 9 complète contre la discrimination", "اعتماد قانون شامل لمكافحة التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 292, null, "R144.79", "79.144", "", "Non réalisé", "", 0, 3, 1, null, 6, 9, null, "Examen périodique universal", "Prendre des mesures d’urgence pour révoquer les normes qui criminalisent et stigmatisent les lesbiennes, les gays, les bisexuels, les transgenres et les intersexués, et poursuivre et punir les auteurs d’actes de discrimination et de violence à leur égard", "اتخاذ تدابير عاجلة لإلغاء الأحكام التي تجرّم وتصم المثليات والمثليين ومزدوجي الميل الجنسي ومغايري الهوية الجنسانية وحاملي صفات الجنسين، والتحقيقُ مع مرتكبي أفعال التمييز والعنف في حقهم ومعاقبتُهم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 286, null, "R144.34", "34.144", "", "Non réalisé", "", 0, 3, 1, null, 95, 9, null, "Examen périodique universal", "Adopter et appliquer une 9 complète contre la discrimination", "اعتماد وتطبيق قانون شامل مناهض للتمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 293, null, "R144.120", "120.144", "", "Non réalisé", "", 0, 3, 1, null, 101, 9, null, "Examen périodique universal", "Créer et maintenir, en droit et dans la pratique, un environnement sûr et favorable pour la société civile et les défenseurs des droits de l’homme, y compris au Sahara occidental et en ce qui le concerne, grâce à une révision du Code pénal, et supprimer les restrictions à la liberté d’expression, revoir le système d’enregistrement des associations et de notification des réunions et veiller à une application cohérente des règles à tous les rassemblements pacifiques indépendamment de leur objet", "إنشاء بيئة آمنة وممكّنة، في القانون والممارسة، والمحافظة عليها لفائدة المجتمع المدني والمدافعين عن حقوق الإنسان حتى في الصحراء الغربية وفيما يتعلق بها عن طريق مراجعة القانون الجنائي وإزالة القيود المفروضة على حرية التعبير واستعراض نظام تسجيل الجمعيات والإشعار بالتجمعات والتطبيق المتّسق للقواعد على جميع التجمعات السلمية بصرف النظر عن موضوعها", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 295, null, "R144.239", "239.144", "", "Non réalisé", "", 0, 3, 1, null, 44, 9, null, "Examen périodique universal", "Réexaminer complètement la 9 nationale sur les migrations et l’asile", "استعراض التشريعات الوطنية بشأن الهجرة واللجوء استعراضاً مفصلاً", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 490, null, "R9", "ت.9", "", "Non réalisé", "", 0, 3, 1, 1, null, 9, null, "Organes de traités", "Le Comité recommande à l’État partie d’amender sa 9 ou d’adopter une 9 spécifique relative à l’interdiction de la discrimination raciale qui soit en pleine conformité avec l’article premier de la Convention.", "تعديل التشريعات الوطنية أو اعتماد تشريع يتناول تحديداً حظر التمييز العنصري على نحو يتماشى تماماً مع المادة 1 من الاتفاقية.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 491, null, "R11P4", "ت.11.ف.4", "", "Non réalisé", "", 0, 3, 1, 1, null, 9, null, "Organes de traités", "Envisager l’inscription dans la constitution de la langue amazigh comme langue officielle", "التفكير في إدراج اللغة الأمازيغية كلغة رسمية في الدستور", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 492, null, "R12", "ت.12", "", "Non réalisé", "", 0, 3, 1, 1, null, 9, null, "Organes de traités", "clarifier la signification et la portée dans sa 9 de la notion de «prénom à caractère marocain» et garantir pleinement l’application par les officiers d’état civil de la circulaire du Ministère de l’26 de mars 2010 relative aux choix des prénoms, afin d’assurer pour tous l’inscription de prénoms, en particulier des prénoms amazighs", "توضيح معنى ونطاق مفهوم 'مغربية الاسم' في التشريعات. وضمان تطبيق ضباط الحالة المدنية لما نص عليه تعميم وزارة الداخلية المؤرخ في آذار/مارس 2010 المتعلق باختيار الأسماء والذي يضمن لجميع المواطنين تسجيل الأسماء، وخاصة الأمازيغية منها.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 493, null, "R13P1", "ت.13.ف.1", "", "Non réalisé", "", 0, 3, 1, 1, null, 9, null, "Organes de traités", "Etablir un cadre juridique et institutionnel visant à clarifier les procédures d’asile", "إنشاء إطار قانوني ومؤسسي تكون الغاية منه توضيح إجراءات اللجوء", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 494, null, "R18P1P4", "ت.18.ف1.ف.4", "", "Non réalisé", "", 0, 3, 1, 1, null, 9, null, "Organes de traités", "Promouvoir la 9 relative à la discrimination raciale,Le Comité recommande en outre que dans la 9 de l’État partie la charge de la preuve soit renversée lorsque les faits de discrimination raciale relèvent de la matière civile", "تعزيز التشريع المتعلق بالتمييز العنصري .وضع عبء ا الإثبات في التشريعاتُ الوطنية على الطرف المدعى عليه بالنسبة لأفعال التمييز العنصري الواقعة في سياق قضايا مدنية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 294, null, "R144.85", "85.144", "", "Non réalisé", "", 0, 3, 1, null, 45, 9, null, "Examen périodique universal", "Réviser les dispositions du Code pénal sur le terrorisme et définir les infractions liées au terrorisme plus clairement et précisément", "مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب ووضعُ تعريف أوضح وأدق للجرائم المرتبطة بالإرهاب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 285, null, "R144.128", "128.44", "", "Non réalisé", "", 0, 3, 1, null, 80, 9, null, "Examen périodique universal", "Réviser le Code pénal et le Code de procédure pénale dans le cadre de la réforme en cours du secteur de la 28", "مراجعة القانون الجنائي وقانون المسطرة الجنائية كجزء من عملية الإصلاح الجارية لقطاع القضاء", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 284, null, "R144.107", "107.144", "", "Non réalisé", "", 0, 3, 1, null, 40, 9, null, "Examen périodique universal", "Adopter les amendements proposés au Code de procédure pénale pour assurer le respect des garanties en détention", "اعتماد التعديلات المقترَحة لقانون المسطرة الجنائية من أجل ضمان احترام الضمانات والتدابير الوقائية أثناء الاحتجاز", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 218, null, "R86P2-3", "ت.86.ف.2ج3", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 8, "Procédure spéciale", "-          envisager d’adopter une nouvelle loi reconnaissant le droit de chacun de choisir librement le prénom de ses enfants dans sa propre langue;", "- التفكير أيضاً في اعتماد قانون جديد يقر حق كل شخص في اختيار اسم طفله بحرية بلغته الخاصة؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 85, null, "R87P5", "ت.87.ف.5", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    modifier la loi (no 03-03) contre le terrorisme de façon à réduire le délai de garde à vue de quatre-vingt-seize heures (renouvelables deux fois)", "-          (ﻫ) تعديل قانون مكافحة الإرهاب (03-03) لتقليص مدة الحبس الاحتياطي البالغة 96 يوماً (والقابلة للتجديد مرتين)؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 86, null, "R87P6", "ت.87.ف.6", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    modifier l’article 290 du Code de procédure pénale de façon à appliquer aux infractions pénales la règle de la preuve qui régit les délits et contraventions afin que tous les rapports établis par la police pour des procès pénaux soient considérés comme des éléments de preuve parmi d’autres sans présomption quant à leur véracité", "-          (و) مراجعة المادة 290 من قانون الإجراءات الجنائية كي تشمل معايير الاستدلال، التي تحكم الجرائم والتي يُعمل بها أصلاً، الجنحَ والمخالفات، بحيث يُتعامل مع جميع بيانات المحاكمات الجنائية التي تعدها الشرطة على أنها دليل واحد في جملة أدلة، دون افتراض صدقها؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 87, null, "R87P7", "ت.87.ف.7", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    modifier le Code de procédure pénale pour qu’il dispose qu’en cas d’allégation de torture ou de mauvais traitements, la charge de la preuve incombe à l’accusation, qui doit montrer au-delà de tout doute raisonnable que les aveux soumis au tribunal n’ont pas été obtenus par des moyens illicites", "-          (ز) تعديل قانون الإجراءات الجنائية بحيث ينص على أنه متى كان ادعاء بالتعذيب أو سوء المعاملة، كان على الادعاء أن يثبت، دون أي شك معقول، أن كل اعتراف من الاعترافات لم يُنتزع بأساليب غير مشروعة؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 88, null, "R87P8", "ت.87.ف.8", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    modifier l’article 84 de la loi (no 23/98) sur les prisons de façon à habiliter les directeurs régionaux à autoriser les organisations de la société civile à visiter les établissements pénitentiaires, et de modifier l’article 10 du décret d’application de la loi no 23/98 afin d’élargir le champ des activités des organisations non gouvernementales dans ce domaine", "-          (ح) تعديل المادة 84 من قانون السجون (رقم 23/98) بحيث يخول المديرين الإقليميين سلطة الترخيص لمنظمات المجتمع المدني بزيارة المؤسسة؛ وتعديل المادة 10 من المرسوم التنفيذي للقانون رقم 23/98 بحيث توسع نطاق أنشطة المنظمات غير الحكومية في هذا المجال؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 89, null, "R87P9", "ت.87.ف.9", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    modifier l’article 134 du Code pénal pour faire en sorte que les auteurs d’infraction souffrant d’une maladie mentale soient placés dans un établissement psychiatrique, quelle que soit la gravité de l’infraction commise", "-          (ط) تعديل المادة 134 من القانون الجنائي بحيث تنص على إيداع جميع المجرمين المصابين بخلل عقلي في مصحة نفسية، بصرف النظر عن درجة خطورة الجرم.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 90, null, "R91P2", "ت.91.ف.2", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    Modifier l’article 473 du Code de procédure pénale de façon à porter de 12 à 18 ans l’âge auquel un délinquant mineur peut être emprisonné et à souligner que l’emprisonnement des délinquants mineurs est une mesure exceptionnelle ;", "فيما يتعلق بالأحداث، يوصي المقرر الخاص الحكومة بما يلي:  (ب) تعديل المادة 473 من قانون الإجراءات الجنائية لزيادة العمر الذي يُسمح فيه بسجن الحدث الجانح من 12 إلى 18 عاماً، والتشديد على أن سجن الأحداث الجانحين إجراء استثنائي؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 91, null, "R88P2", "ت.88.ف.2", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    Assurer, par des modifications apportées à la législation, que l’accès à un avocat choisi par le suspect lui-même soit garanti dès l’arrestation, sans surveillance policière et sans avoir à obtenir l’autorisation préalable du Procureur, y compris en cas de menace contre la sécurité et de terrorisme. Cet accès doit être accordé en application de la loi et tout fonctionnaire qui refuserait de l’accorder devrait être sanctionné", "ب) التأكد، بواسطة تعديل التشريعات، من أن توكيل المحامين من اختيار المشتبه فيهم مكفول منذ اللحظة الأولى من إلقاء القبض، دون حضور محقق ودون اشتراط إذن من المدعي العام، بما في ذلك قضايا تهديد الأمن القومي والإرهاب. وينبغي منح ذلك الحق قانوناً، وتأديب كل موظف يحول دون ذلك؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 133, null, "R80P2", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 4, "Procédure spéciale", "-    Accélérer l’adoption des modifications à apporter au Code pénal, puis à promulguer et à appliquer des textes législatifs spécifiques contre la traite, dans un délai déterminé", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 134, null, "R87", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 4, "Procédure spéciale", "-    Tout projet de modification ou de loi relative à la traite des êtres humains devrait être axé sur une approche fondée sur les droits de l’homme et comporter des dispositions relatives à l’indemnisation des victimes et aux recours effectifs dont celles-ci disposent.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 135, null, "R80P3/R88P1", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 4, "Procédure spéciale", "-    Le champ d’application de la législation du travail devrait être élargi de sorte que les employés de maison bénéficient d’une protection suffisante.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 136, null, "R92", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 4, "Procédure spéciale", "Une réforme pénale devrait être entreprise et des systèmes de protection des victimes et des témoins devraient être institués. - Parallèlement à la réforme pénale, des modifications devraient être apportées au Code pénal et un cadre juridique plus vaste devrait être établi, qui exempte les victimes de la traite des peines encourues pour prostitution, pour immigration illégale et pour d’autres infractions connexes résultant directement de la traite", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 162, null, "R89P4P5", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 6, "Procédure spéciale", "Combler les lacunes dans la protection juridique des droits des femmes et des groupes qui ont besoin d’une protection particulière, notamment les travailleurs domestiques et les travailleurs migrants, et faire en sorte que les groupes de femmes vulnérables bénéficient de l’égale protection de la loi. - Les projets de loi sur la violence à l’égard des femmes et la violence au foyer devraient être réexaminés à la lumière des observations finales du Comité contre la torture. Le Code pénal, qui est en cours de modification, devrait être revu dans le sens du respect des principes et des normes internationaux et adopté. Ses articles 475 et 490 devraient être abrogés- Entamer un examen complet de l’application de toutes les lois et dispositions préjudiciables aux femmes et aux filles, y compris, entre autres, le Code de la famille, le Code de la nationalité, le Code pénal et le Code du travail. Cet examen devrait se faire avec la participation active des organisations de la société civile, notamment celles qui ont suivi les décisions des tribunaux dans des affaires relatives au mariage précoce et à la polygamie ;", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 163, null, "R91P1", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 6, "Procédure spéciale", "Accélérer l’élaboration des lois organiques appelées à définir les conditions et les modalités d’exercice, par tous les citoyens, femmes et hommes du droit de présenter des motions en matière législative et des pétitions aux pouvoirs publics; de telles lois devraient prévoir des mesures spéciales pour renforcer l’accès effectif des femmes pauvres et marginalisées à ce droit, y compris la mobilisation de ressources pour le renforcement des capacités des groupes locaux de femmes", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 164, null, "R91P2", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 6, "Procédure spéciale", "Institutionnaliser, en modifiant les lois sur les élections, les mesures spéciales visant à augmenter le nombre de femmes aux postes électifs, aux niveaux national et local, de façon à satisfaire aux normes internationales ; - les listes nationales dans lesquelles un nombre déterminé de sièges est réservé aux femmes devraient être conservées et les quotas augmentés. - Les femmes devraient avoir la possibilité de présenter leur candidature pour une réélection sur les listes nationales. - Une augmentation des quotas, qui réponde aux normes internationales, devrait être effectuée dans les élections locales", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 193, null, "R83P26", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 7, "Procédure spéciale", "-       Adopter rapidement le projet de loi sur les tribunaux militaires afin de s’assurer que les civils ne soient pas condamnés par un tribunal militaire et d’examiner les jugements rendus par le tribunal militaire dans le cas des 25 personnes sahraouies du camp de Gdeim Izik.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 4, null, "R67P2", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 1, "Procédure spéciale", "-   Veiller à ce que les lois en cours de révision soient conformes aux normes internationales relatives aux droits de l’homme.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 45, null, "R70P1P2", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 2, "Procédure spéciale", "Adopter un cadre juridique et politique global de lutte contre la discrimination qui met en application l’intégralité des dispositions relatives à l’égalité raciale de la Convention internationale sur l’élimination de toutes les formes de discrimination raciale, conformément aux recommandations du Comité pour l’élimination de la discrimination raciale. - Afin de garantir la pleine conformité avec l’article premier de la Convention, réviser la législation existante ou adopter une nouvelle loi de façon à interdire expressément la discrimination raciale telle que définie dans la Convention.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 137, null, "R80P1", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 4, "Procédure spéciale", "-    Veiller à la pleine application, en droit interne, du Protocole additionnel à la Convention des Nations Unies contre la criminalité transnationale organisée visant à prévenir, réprimer et punir la traite des personnes, en particulier des femmes et des enfants, qui impose à l’État de prévenir et de combattre la traite des êtres humains.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 165, null, "R89P1", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 6, "Procédure spéciale", "Mettre toutes les lois nationales en conformité avec les instruments internationaux relatifs aux droits de l’homme auxquels le Maroc est partie et de modifier ou d’abroger les dispositions discriminatoires qui subsistent dans les lois nationales", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 309, null, "R144.240", "240.144", "", "Non réalisé", "", 0, 3, 1, null, 67, 10, null, "Examen périodique universal", "Accélérer l’examen du cadre juridique en matière de migration et d’asile afin de l’aligner sur le Pacte international relatif aux droits civils et politiques", "تسريع استعراض الإطار القانوني المتعلق بالهجرة واللجوء بهدف مواءمته مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 495, null, "R8", "ت.8", "", "Non réalisé", "", 0, 3, 1, 1, null, 10, null, "Organes de traités", "Consacrer dans la constitution le principe de la primauté des traités internationaux sur la 9 interne, afin de lui donner une portée générale et de permettre aux justiciables d’invoquer devant les tribunaux les dispositions pertinentes de la Convention.", "تكريس مبدأ أسبقية المعاهدات الدولية على التشريعات الداخلية في الدستور حتى تعطي لهذا المبدأ قوةً حجية عامة ويتمكن بذلك المتقاضون الاعتداد أمام المحاكم بأحكام الاتفاقية ذات الصلة بقضاياهم.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 496, null, "R10", "ت.10", "", "Non réalisé", "", 0, 3, 1, 1, null, 10, null, "Organes de traités", "Inclure dans le Code pénal des dispositions donnant pleinement effet à l’article 4 de la Convention, en particulier une incrimination spécifique sur la diffusion d’idées racistes. prévoir dans sa 9 pénale le motif raciste comme circonstance aggravante de la discrimination raciale.", "إدراج أحكام في القانون الجنائي تفعل المادة 4 من الاتفاقية تفعيلاً كاملاً، وبخاصة تجريم نشر الأفكار العنصرية على وجه التحديد، وذلك في إطار الإصلاح العام المقبل لنظام العدالة وفق التوصية العامة  رقم 1(1972) و7(1985) و15(1993) التي أضفت على أحكام المادة 4 طابعاً آمراً ووقائياً.إ دراج الدافع العنصري بوصفه ظرفاً مشدداً للتمييز العنصري في التشريعات الجنائية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 497, null, "R10", "ت.10", "", "Non réalisé", "", 0, 3, 1, 1, null, 10, null, "Organes de traités", "null", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 498, null, "R16", "ت.16", "", "Non réalisé", "", 0, 3, 1, 1, null, 10, null, "Organes de traités", "réviser le Code de la nationalité afin de permettre à la femme marocaine de transmettre sa nationalité à son époux d’origine étrangère à égalité avec les hommes de nationalité marocaine.", "مراجعة قانون الجنسية لكي يتيح للمرأة المغربية نقل جنسيتها إلى زوجها الأجنبي من أجل المساواة في الحقوق بينها وبين الرجل الذي يحمل الجنسية المغربية.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 5, null, "R68", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 11, 1, "Procédure spéciale", "-   Affecter des ressources suffisantes à la mise en œuvre des mesures de réduction de la pauvreté énoncées dans l’Initiative nationale pour le développement humain, en accordant une attention particulière aux disparités structurelles en matière de mise en œuvre et en ciblant les besoins des personnes et des groupes désavantagés et marginalisés, en particulier de ceux vivant dans des zones reculées.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 6, null, "R71", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 11, 1, "Procédure spéciale", "-   Élaborer des programmes visant à renforcer les organisations communautaires en leur dispensant les formations voulues et en leur offrant l’appui nécessaire pour les aider à assurer elles-mêmes leur développement et à diversifier les activités agricoles, afin de créer de nouvelles possibilités d’emploi.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 7, null, "R75", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 11, 1, "Procédure spéciale", "-   Faire des populations urbaines pauvres, des petits agriculteurs et des communautés côtières qui sont particulièrement vulnérables face aux effets des changements climatiques les premiers bénéficiaires des évaluations des vulnérabilités, ainsi que des ressources financières et de l’appui destinés à l’adaptation et à l’atténuation", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 8, null, "R85", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 11, 1, "Procédure spéciale", "-   Revoir, examiner et modifier les politiques et les programmes concernant la réduction de la pauvreté afin que les préoccupations relatives au genre soient réellement prises en compte", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 9, null, "R94", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 11, 1, "Procédure spéciale", "Pour les provinces marocaines du sud : - Adopter une stratégie de réduction de la pauvreté fondée sur les droits de l’homme qui cible spécifiquement les besoins des individus et des groupes défavorisés et marginalisés, en allouant des ressources financières suffisantes ou autres ressources pour sa mise en œuvre et en veillant à ce que ces ressources soient équitablement réparties entre tous ceux touchés par la pauvreté, conformément aux recommandations du Comité des droits économiques, sociaux et culturels.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 10, null, "R96P3", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 11, 1, "Procédure spéciale", "Pour les provinces marocaines du sud : - Offrir à la population locale les mêmes possibilités d’éducation et d’emploi, en vue de réduire la pauvreté et d’assurer la sécurité alimentaire et nutritionnelle de tous, conformément au droit international.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 46, null, "R73", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 11, 2, "Procédure spéciale", "-       Envisager l’adoption de mesures spéciales pour garantir aux groupes défavorisés, dans des conditions d’égalité, la pleine jouissance des droits de l’homme et des libertés fondamentales.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 138, null, "R94", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 11, 4, "Procédure spéciale", "-    En sus des mesures juridiques et des politiques adoptées pour lutter contre la traite des êtres humains, des efforts devraient être faits pour remédier aux causes profondes de ce problème, notamment l’exclusion sociale, la pauvreté, les inégalités et la discrimination.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 310, null, "R144.140", "140.144", "", "Non réalisé", "", 0, 4, 1, null, 96, 11, null, "Examen périodique universal", "Allouer davantage de ressources à la mise en œuvre de politiques nationales en faveur des groupes sociaux vulnérables", "تخصيص مزيد من الموارد لتنفيذ السياسات الوطنية لصالح الفئات الاجتماعية الضعيفة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 311, null, "R144.143", "143.144", "", "Non réalisé", "", 0, 4, 1, null, 78, 11, null, "Examen périodique universal", "Améliorer l’identification des bénéficiaires des régimes de protection sociale", "تحسين وسائل تحديد ذوي الأهلية للاستفادة من خطط الحماية الاجتماعية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 308, null, "R144.106", "106.144", "", "Non réalisé", "", 0, 3, 1, null, 68, 10, null, "Examen périodique universal", "Accélérer le processus de révision du cadre législatif régissant les prisons en vue de l’harmoniser avec la Constitution de 2011 et les normes internationales", "تسريع عملية مراجعة الإطار التشريعي الذي ينظم السجون بغية مواءمته مع دستور عام 2011 ومع المعايير الدولية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 84, null, "R87P4", "ت.87.ف.4", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    inclure dans le Code pénal une disposition expresse établissant que l’ordre d’un supérieur ou d’une autorité publique ne peut être invoqué pour justifier la torture, et mettre en place un mécanisme pour la protection des subordonnés qui refusent d’obéir à un ordre visant à torturer une personne en détention", "-          (د) إدراج حكم محدد في القانون الجنائي ينص على أنه لا يجوز الاحتجاج بصدور أمر من موظف سام أو سلطة عامة لتبرير التعذيب، وتوفير آلية لحماية المرؤوسين الذين يرفضون إطاعة أوامر تعذيب أشخاص محتجزين لديهم؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 307, null, "R144.103", "103.144", "", "Non réalisé", "", 0, 3, 1, null, 20, 10, null, "Examen périodique universal", "Accélérer le processus de révision du cadre juridique régissant les prisons afin de l’harmoniser avec les normes internationales", "تسريع عملية مراجعة الإطار القانوني الذي ينظم السجون بهدف مواءمته مع المعايير الدولية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 305, null, "R144.36P2", "36.144. ج.2", "", "Non réalisé", "", 0, 3, 1, null, 42, 10, null, "Examen périodique universal", "mettre la législation nationale en conformité avec le Statut de Rome de la Cour pénale internationale", "......مواءمة التشريعات مع أحكامه نظام روما الأساسي للمحكمة الجنائية الدولية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 194, null, "R83P1", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 7, "Procédure spéciale", "Garantir, par des modifications de la législation, que l’accès à un avocat choisi par le suspect lui-même soit accordé dès l’arrestation, sans la présence d’un enquêteur et sans nécessiter l’autorisation du Procureur, y compris dans les affaires touchant à la sécurité nationale et de terrorisme. - Cet accès devrait être garanti par la loi et tout fonctionnaire qui refuserait d’accorder l’accès à un avocat devrait être sanctionné", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 195, null, "R83P3", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 7, "Procédure spéciale", "-       Modifier la loi antiterroriste (no 03-03) en vue de remédier à la définition vague du crime de terrorisme et de réduire la durée de la garde à vue qui est de quatre-vingt-seize heures renouvelables deux fois", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 196, null, "R83P4", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 7, "Procédure spéciale", "Modifier le Code de procédure pénale pour indiquer qu’en cas d’allégation de torture ou de mauvais traitements, la charge de la preuve incombe à l’accusation qui devra prouver, hors de tout doute raisonnable, que les aveux n’ont pas été obtenus par des moyens illégaux. - Les allégations de torture et de mauvais traitements devraient être admises à n’importe quel stade du procès et les tribunaux devraient être tenus de lancer des enquêtes d’office chaque fois qu’il y a des motifs raisonnables de suspecter des actes de torture ou de mauvais traitements", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 197, null, "R83P21", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 7, "Procédure spéciale", "-       Étudier l’amendement de l’article 473 du Code de procédure pénale visant à reculer l’âge auquel un jeune délinquant peut être incarcéré de12à 18 ans, et souligner que l’emprisonnement des jeunes délinquants est une mesure exceptionnelle ;", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 198, null, "R83P24", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 7, "Procédure spéciale", "-       Envisager de modifier l’article 134 du Code pénal afin de s’assurer que tous les délinquants souffrant d’une incapacité mentale soient placés dans un établissement psychiatrique, quelle que soit la gravité de l’infraction", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 243, null, "R73P6-2", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 10, 9, "Procédure spéciale", "Envisager de faire figurer des dispositions sur la question relative à la mise  en place un cadre de suivi des fonds étrangers reçus par les acteurs de la société civile dans le projet de loi sur la société civile, conformément aux normes internationales relatives aux droits de l’homme mentionnées dans le rapport du Rapporteur spécial sur le droit de réunion pacifique et la liberté d’association (A/HRC/23/39)", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 296, null, "R144.31", "31.144", "", "Non réalisé", "", 0, 3, 1, null, 32, 10, null, "Examen périodique universal", "Faire en sorte que le Code pénal soit pleinement en conformité avec le Pacte international relatif aux droits civils et politiques", "ضمان أن يكون القانون الجنائي متوافقاً تماماً مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 297, null, "R144.35", "35.144", "", "Non réalisé", "", 0, 3, 1, null, 40, 10, null, "Examen périodique universal", "Prendre des mesures pour mettre la définition de la torture en conformité avec celle énoncée dans la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "اتخاذ خطوات لجعل تعريف التعذيب متوافقاً مع متطلبات اتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 298, null, "R144.86", "86.144", "", "Non réalisé", "", 0, 3, 1, null, 2, 10, null, "Examen périodique universal", "Réviser les dispositions du Code pénal sur le terrorisme en vue de définir précisément les infractions liées au terrorisme et veiller à ce que la 9 soit en conformité avec le Pacte international relatif aux droits civils et politiques", "مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب بغية وضع تعريف دقيق للجرائم المرتبطة بالإرهاب، وضمان أن تكون التشريعات متسقة مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 299, null, "R144.86", "86.144", "", "Non réalisé", "", 0, 3, 1, null, 2, 10, null, "Examen périodique universal", "Réviser les dispositions du Code pénal sur le terrorisme en vue de définir précisément les infractions liées au terrorisme et veiller à ce que la législation soit en conformité avec le Pacte international relatif aux droits civils et politiques", "مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب بغية وضع تعريف دقيق للجرائم المرتبطة بالإرهاب، وضمان أن تكون التشريعات متسقة مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 300, null, "R144.116", "116.14", "", "Non réalisé", "", 0, 3, 1, null, 70, 10, null, "Examen périodique universal", "Examiner les dispositions du Code pénal relatives à la liberté d’expression à la lumière de l’article 19 du Pacte international relatif aux droits civils et politiques", "استعراض أحكام القانون الجنائي المتعلقة بحرية التعبير بما يتوافق مع المادة 19 من العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 301, null, "R144.12 P2", "12.144ج.2", "", "Non réalisé", "", 0, 3, 1, null, 8, 10, null, "Examen périodique universal", "mettre la législation nationale en conformité avec les dispositions du Statut de Rome de la Cour pénale internationale", "...... جعل التشريعات الوطنية متسقة مع أحكام نظام روما الأساسي للمحكمة الجنائية الدولية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 302, null, "R144.14 P2", "14.144ج.2", "", "Non réalisé", "", 0, 3, 1, null, 53, 10, null, "Examen périodique universal", "rendre la législation nationale pleinement conforme au Statut de Rome de la Cour pénale internationale, comme cela a été recommandé précédemment", "......جعل التشريعات الوطنية متسقة مع أحكام نظام روما الأساسي للمحكمة الجنائية الدولية وفق ما تمّت التوصية به سابقاً", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 303, null, "R144.14 P2", "14.144ج.2", "", "Non réalisé", "", 0, 3, 1, null, 53, 10, null, "Examen périodique universal", "rendre lalégislation nationale pleinement conforme au Statut de Rome de la Cour pénale internationale, comme cela a été recommandé précédemment", "......جعل التشريعات الوطنية متسقة مع أحكام نظام روما الأساسي للمحكمة الجنائية الدولية وفق ما تمّت التوصية به سابقاً", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 304, null, "R144.15 P2", "15.144. ج.2", "", "Non réalisé", "", 0, 3, 1, null, 65, 10, null, "Examen périodique universal", "adapter pleinement sa législation à toutes les obligations énoncées dans le Statut de Rome de la Cour pénale internationale", "...... التشريعات الوطنية متسقة اتساقاً كاملاً مع جميع الالتزامات الناشئة عن نظام روما الأساسي للمحكمة الجنائية الدولية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 306, null, "R144.112", "112.144", "", "Non réalisé", "", 0, 3, 1, null, 98, 10, null, "Examen périodique universal", "Veiller à ce que les dispositions pertinentes du Code pénal soient mises en conformité avec les obligations du Maroc en vertu du Pacte international relatif aux droits civils et politiques, en particulier en ce qui concerne la liberté d’expression et d’opinion", "ضمان جعل الأحكام ذات الصلة من قانون المسطرة الجنائية أو من القانون الجنائي متماشية مع التزامات المغرب الناشئة عن العهد الدولي الخاص بالحقوق المدنية والسياسية ولا سيما فيما يتعلق بحرية الكلام والرأي", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 312, null, "R144.144", "144.144", "", "Non réalisé", "", 0, 4, 1, null, 4, 11, null, "Examen périodique universal", "Continuer de promouvoir la consolidation de sa politique sociale et lutter contre la pauvreté et les inégalités, qui sont toujours présentes", "مواصلة تشجيع تكامل سياساته الاجتماعية ومكافحة الفقر وعدم المساواة اللذين لا يزالان موجودين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 83, null, "R87P3", "ت.87.ف.3", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    veiller à ce qu’aucune personne reconnue coupable d’actes de torture ou faisant l’objet de poursuites pour de tels actes ne puisse bénéficier d’une mesure d’amnistie", "-          (ج)  التأكد من عدم استفادة أي شخص مدان أو محكوم عليه بسبب ارتكابه جريمة التعذيب من أي عفو؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 81, null, "R87P1", "ت.87.ف.1", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "Modifier l’article 231-1 du Code pénal pour faire en sorte que la complicité ou le consentement exprès ou tacite des fonctionnaires chargés d’appliquer la loi et des forces de sécurité ou de toute autre personne agissant à titre officiel soient expressément visés", "-          (أ) تعديل المادة 231-1 من القانون الجنائي بحيث تشمل تحديداً تواطؤ موظفي إنفاذ القانون أو غيرهم من الأشخاص الذين يتصرفون بصفة رسمية أو موافقتهم الصريحة أو الضمنية؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 265, null, "R144.58P1", "58.144. ج.1", "", "Non réalisé", "", 0, 1, 1, null, 48, 3, null, "Examen périodique universal", "Veiller à établir des procédures régissant l’enregistrement des organisations de la société civile", "ضمان وضع إجراءات تحكم تسجيل منظمات المجتمع المدني ......", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 266, null, "R144.61P1", "61.144. ج.1", "", "Non réalisé", "", 0, 1, 1, null, 65, 3, null, "Examen périodique universal", "Veiller à ce que les procédures régissant l’enregistrement des organisations de la société civile, soient conformes aux normes internationales", "ضمان أن تكون الآليات التي تنظم تسجيل منظمات المجتمع المدني..... متوافقة مع المعايير الدولية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 1, null, "R65", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 5, 1, "Procédure spéciale", "Ratifier le Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 78, null, "R88P14-1", "ت.88.ف.14ج1", "", "Non réalisé", "", 0, 2, 1, null, null, 5, 3, "Procédure spéciale", "-    prendre des mesures concrètes pour accélérer la ratification du Protocole facultatif à la Convention contre la torture", "-          (ن) اتخاذ تدابير ملموسة لتسريع عملية التصديق على البروتوكول الاختياري الملحق باتفاقية مناهضة التعذيب.....", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 130, null, "R96P2", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 5, 4, "Procédure spéciale", "-    Envisager de ratifier la Convention no 189 de l’OIT sur les travailleuses et travailleurs domestiques.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 159, null, "R89P2", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 5, 6, "Procédure spéciale", "Retirer toutes les déclarations restantes au sujet de la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes, en particulier celles concernant l’article 2 et le paragraphe 4 de l’article 15, ainsi que la réserve à cet instrument", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 264, null, "R144.122", "122.144", "", "Non réalisé", "", 0, 1, 1, null, 34, 3, null, "Examen périodique universal", "Approuver les demandes de licence pour toutes les associations non gouvernementales demandant l’enregistrement conformément à la loi, y compris les organisations qui défendent les membres des populations minoritaires", "الموافقة على طلبات الترخيص لجميع الجمعيات غير الحكومية التي تلتمس التسجيل وفقاً للقانون، بما فيها الجمعيات التي تدافع عن أفراد الأقليات من السكان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 160, null, "R89P3", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 5, 6, "Procédure spéciale", "Signer et ratifier le Protocole facultatif à la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes ou y adhérer, et ratifier la Convention pour la protection de toutes les personnes contre les disparitions forcées", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 216, null, "R91", "ت.91", "", "Non réalisé", "", 0, 2, 1, null, null, 5, 8, "Procédure spéciale", "Ratifier le Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels.", "-       التصديق على البروتوكول الاختياري للعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 241, null, "R73P8-1", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 5, 9, "Procédure spéciale", "Envisager de ratifier les Protocoles facultatifs se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels et au Pacte international relatif aux droits civils et politiques", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 267, null, "R144.1", "1.144", "", "Non réalisé", "", 0, 2, 1, null, 7, 5, null, "Examen périodique universal", "-Ratifier le premier Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques", "التصديق على البروتوكول الاختياري الأول الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية والانضمام إلى البروتوكول الاختياري الأول الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 268, null, "R144.1", "null", "", "Non réalisé", "", 0, 2, 1, null, 73, 5, null, "Examen périodique universal", "-adhérer au premier Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 269, null, "R144.4", "4.144", "", "Non réalisé", "", 0, 2, 1, null, 65, 5, null, "Examen périodique universal", "Envisager de ratifier le deuxième Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques", "النظر في التصديق على البروتوكول الاختياري الثاني الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 270, null, "R144.6", "6.144", "", "Non réalisé", "", 0, 2, 1, null, 73, 5, null, "Examen périodique universal", "Ratifier le Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels", "التصديق على البروتوكول الاختياري الثاني الملحق بالعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية ()", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 191, null, "R83P14P1", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 5, 7, "Procédure spéciale", "-       Prendre des mesures concrètes et durables pour parachever le processus de ratification du Protocole facultatif à la Convention contre la torture", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 263, null, "R144.121", "121.144", "", "Non réalisé", "", 0, 1, 1, null, 89, 3, null, "Examen périodique universal", "Lever les obstacles à l’enregistrement des associations non gouvernementales auprès des autorités", "إزالة العوائق التي تمنع الجمعيات غير الحكومية من التماس تسجيلها من قِبل السلطات", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 262, null, "R144.114P2", "114.144.ج.2", "", "Non réalisé", "", 0, 1, 1, null, 36, 3, null, "Examen périodique universal", "Garantir pleinement les libertés d’expression et prendre toutes les mesures nécessaires pour veiller à ce que les défenseurs des droits de l’homme puissent s’acquitter de leur mission", "ضمان حرية تكوين الجمعيات ضماناً تاماً بغية كفالة تمكين المدافعين عن حقوق الإنسان من أداء مهماتهم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 261, null, "R144.117", "117.144", "", "Non réalisé", "", 0, 1, 1, null, 89, 3, null, "Examen périodique universal", "Veiller à ce que les dispositions de la Constitution sur la liberté de la presse, la liberté d’opinion et d’expression et la liberté de réunion et d’association soient respectées, y compris pour les personnes qui veulent exprimer leurs vues sur la situation du et au Sahara occidental", "ضمان احترام أحكام الدستور المتعلقة بحرية الصحافة وحرية الرأي والتعبير وحرية التجمع وتكوين الجمعيات، حتى للأشخاص الذين يريدون التعبير عن آرائهم بشأن الحالة في الصحراء الغربية ووضعها السياسي", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 40, null, "R79P2", "null", "", "Non réalisé", "", 0, 1, 1, null, null, 1, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’accès à la justice", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 75, null, "R88P4", "ت.88.ف.4", "", "Non réalisé", "", 0, 1, 1, null, null, 1, 3, "Procédure spéciale", "-    Faire en sorte que les déclarations ou les aveux d’une personne privée de liberté, qui ne sont pas faits en présence d’un juge et avec l’assistance d’un avocat, n’aient aucune valeur probante dans les procédures contre cette personne ;", "-          (د) ضمان ألا يكون لبيانات شخص مسلوب الحرية أو اعترافاته، غير تلك المدلى بها بحضور قاض أو بمساعدة محام، أي قوة مقنعة في الإجراءات المتعلقة بذلك الشخص؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 76, null, "R88P5", "ت.88.ف.5", "", "Non réalisé", "", 0, 1, 1, null, null, 1, 3, "Procédure spéciale", "-    Faire en sorte que les rapports établis par la police judiciaire pendant l’enquête restent irrecevables dans le cadre d’un procès tant que l’accusation, à qui incombe la charge de la preuve, n’a pas prouvé leur véracité et leur validité juridique, conformément au Code de procédure pénale ;", "-          (ﻫ) التأكد من عدم قبول تقارير الشرطة القضائية المعدة إبّان مرحلة التحقيق في المحاكم حتى يثبت الادعاء صحتها وصلاحيتها القانونية وفقاً لقانون الإجراءات الجنائية؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 77, null, "R88P9", "ت.88.ف.9", "", "Non réalisé", "", 0, 1, 1, null, null, 1, 3, "Procédure spéciale", "faire en sorte que le personnel médical des lieux de détention soit véritablement indépendant des organes chargés d’appliquer la loi et reçoive une formation au sujet du Protocole d’Istanbul ;-  autoriser l’accès à des examens médicaux indépendants effectués sans surveillance ni ingérence de la part d’agents chargés d’appliquer la loi ou de procureurs et d’assurer l’accès en temps voulu à des examens médicaux indépendants, au moment de l’arrestation, lors d’un transfert vers un autre lieu de détention ou sur demande;", "ط) التأكد من أن العاملين الطبيين في أماكن الاحتجاز مستقلون تماماً عن موظفي إنفاذ القانون، ومدربون على بروتوكول اسطنبول؛        الترخيص في الفحوص الطبية المستقلة دون تدخل العاملين في مجال إنفاذ القانون أو المدعين العامين أو حضورهم؛ وضمان تلك الفحوص في الوقت المناسب عند إلقاء القبض أو النقل إلى مكان احتجاز آخر أو عند الطلب؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 188, null, "R83P2", "null", "", "Non réalisé", "", 0, 1, 1, null, null, 1, 7, "Procédure spéciale", "-       S’assurer que tous les suspects aient le droit de bénéficier, dans la pratique, des autres garanties fondamentales prévues par la loi, notamment le droit d’être examiné par un médecin indépendant, de communiquer avec un proche ou un ami, d’être informés de leurs droits et des charges retenues contre eux, et d’être traduits devant un juge sans délai", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 189, null, "R83P9", "null", "", "Non réalisé", "", 0, 1, 1, null, null, 1, 7, "Procédure spéciale", "-       Renforcer les efforts pour lutter contre la détention au secret, conformément à l’article 23 de la Constitution", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 255, null, "R144.44P1", "44.144.ج.1", "", "Non réalisé", "", 0, 1, 1, null, 96, 1, null, "Examen périodique universal", "Poursuivre les réformes visant à consolider l’état de droit et les mécanismes nationaux de protection des droits de l’homme", "مواصلة الإصلاحات بقصد توطيد سيادة القانون لحماية حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 256, null, "R144.123", "123.144", "", "Non réalisé", "", 0, 1, 1, null, 34, 1, null, "Examen périodique universal", "Mener des enquêtes complètes, impartiales et indépendantes sur toutes les allégations de corruption ou d’abus par les forces de sécurité et en poursuivre les responsables, le cas échéant", "إجراء تحقيقات كاملة ونزيهة ومستقلة في جميع ادعاءات الفساد أو الاعتداء على يد قوات الأمن وملاحقة المسؤولين عنها، عند الاقتضاء", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 257, null, "R144.124", "124.144", "", "Non réalisé", "", 0, 1, 1, null, 7, 1, null, "Examen périodique universal", "Prendre des mesures supplémentaires pour garantir l’indépendance du pouvoir judiciaire, ce qui est important pour garantir un procès équitable conformément aux normes internationales des droits de l’homme", "القيام بخطوات أخرى من أجل ضمان استقلال القضاء، وهو أمر مهم لضمان إجراء محاكمات عادلة بما يتفق مع المعايير الدولية لحقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 190, null, "R83P11", "null", "", "Non réalisé", "", 0, 1, 1, null, null, 2, 7, "Procédure spéciale", "-       Réformer le système judiciaire afin de garantir que toutes les personnes en détention préventive bénéficient d’un procès équitable et rapide", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 258, null, "R144.125", "125.144", "", "Non réalisé", "", 0, 1, 1, null, 52, 2, null, "Examen périodique universal", "Mener à bien la réforme de la 28", "إكمال إصلاحات القضاء", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 259, null, "R144.126", "126.144", "", "Non réalisé", "", 0, 1, 1, null, 99, 2, null, "Examen périodique universal", "Accélérer la mise en œuvre de la charte sur la réforme du système judiciaire", "تسريع تنفيذ ميثاق إصلاح منظومة العدالة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 260, null, "R144.127", "127.144", "", "Non réalisé", "", 0, 1, 1, null, 87, 2, null, "Examen périodique universal", "Parachever le processus de réforme du système judiciaire et garantir l’indépendance du pouvoir judiciaire en conformité avec les exigences constitutionnelles", "مواصلة إتمام عملية إصلاح منظومة العدالة وضمان استقلال القضاء بما يتفق مع مقتضيات الدستور ذات الصلة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 158, null, "R89P7", "null", "", "Non réalisé", "", 0, 1, 1, null, null, 3, 6, "Procédure spéciale", "Adopter une approche globale et intégrée de la rédaction de toutes les lois d’application et organiques relatives aux institutions qui tirent leur mandat de la Constitution, afin d’assurer, dans toutes ces institutions, la cohérence et l’homogénéité requises, notamment l’application du principe de l’égalité des sexes et la réalisation des objectifs en matière d’égalité entre les hommes et les femmes, conformément aux normes internationales.  Les efforts de coordination entre le Gouvernement, le Conseil national des droits de l’homme, la société civile et d’autres partenaires devraient viser à assurer l’application effective des dispositions constitutionnelles", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 215, null, "R83P1", "ت.83.ف.1", "", "Non réalisé", "", 0, 1, 1, null, null, 3, 8, "Procédure spéciale", "De nouvelles dispositions constitutionnelles, en particulier celles qui concernent les droits et la diversité culturels, devraient être effectivement appliquées au moyen de textes législatifs, y compris tous les décrets pertinents, comme le stipule la Constitution", "ينبغي إنفاذ الأحكام الدستورية الجديدة، لا سيما تلك المتعلقة بالحقوق الثقافية والتنوع الثقافي، إنفاذاً فعالاً من خلال اعتماد قوانين، بما فيها جميع القوانين الفرعية المناسبة، مثلما ينص على ذلك الدستور. - تتطلب القوانين والتدابير الجديدة  المتعلقة بإنفاذ الأحكام الدستورية الجديدة، لا سيما تلك الخاصة بالحقوق الثقافية والتنوع الثقافي اعتماد سياسات واستراتيجيات مناسبة وينبغي أن تقترن بتدريب مناسب وتوجيه صحيح للمسؤولين المكلفين بتطبيقها.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 271, null, "R144.7", "7.144", "", "Non réalisé", "", 0, 2, 1, null, 49, 5, null, "Examen périodique universal", "Signer et ratifier le Protocole facultatif à la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes", "التوقيع والتصديق على البروتوكول الاختياري الثاني الملحق باتفاقية القضاء على جميع أشكال التمييز ضد المرأة ()؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 272, null, "R144.9", "9.144", "", "Non réalisé", "", 0, 2, 1, null, 61, 5, null, "Examen périodique universal", "Ratifier le Protocole facultatif à la Convention relative aux droits de l’enfant établissant une procédure de présentation de communications", "التصديق على البروتوكول الاختياري لاتفاقية حقوق الطفل المتعلق بإجراء البلاغات", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 273, null, "R144.10", "10.144", "", "Non réalisé", "", 0, 2, 1, null, 38, 5, null, "Examen périodique universal", "Accélérer la procédure de ratification du Protocole facultatif à la Convention relative aux droits de l’enfant établissant une procédure de présentation de communications", "تسريع عملية التصديق على البروتوكول الاختياري لاتفاقية حقوق الطفل المتعلق بإجراء تقديم البلاغات", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 274, null, "R144.16", "16.144.", "", "Non réalisé", "", 0, 2, 1, null, 72, 5, null, "Examen périodique universal", "Ratifier la convention (no 189) de l’OIT sur les travailleuses et travailleurs domestiques, 2011", "التصديق على اتفاقية العمال المنزليين، 2011 (رقم 189)، لمنظمة العمل الدولية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 282, null, "R144.17", "17.144", "", "Non réalisé", "", 0, 2, 1, null, 80, 7, null, "Examen périodique universal", "Adopter un processus de sélection ouvert, fondé sur le mérite, pour sélectionner les candidats nationaux aux élections aux organes conventionnels de l’ONU", "اعتماد إجراء اختيار علني وقائم على الجدارة والاستحقاق عند اختيار المرشحين الوطنيين لانتخاب أعضاءٍ في هيئات معاهدات الأمم المتحدة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 283, null, "R144.29", "29.144.", "", "Non réalisé", "", 0, 2, 1, null, 84, 7, null, "Examen périodique universal", "Continuer de travailler avec le HCDH et le Haut-Commissariat des Nations Unies pour les réfugiés pour rétablir le programme d’aide humanitaire à la population du Sahara occidental", "مواصلة العمل مع مفوضية الأمم المتحدة السامية لحقوق الإنسان ومع مكتب مفوضية الأمم المتحدة السامية لشؤون اللاجئين من أجل إعادة العمل ببرنامج المعونة الإنسانية لسكان الصحراء الغربية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 481, null, "R7", "ت.7", "", "Non réalisé", "", 0, 2, 1, 1, null, 7, null, "Organes de traités", "A la lumière de sa Recommandation générale no.8 (1990) concernant l’interprétation et l’application des paragraphes 1 et 4 de l’article premier de la Convention et conformément aux paragraphes 10 à 12 des directives révisées concernant l’établissement de rapports (CERD/C/2007/1), le Comité recommande à l’État partie de fournir des renseignements sur la composition de sa population, l’utilisation de langues maternelles, les langues communément parlées et d’autres indicateurs de la diversité ethnique, ainsi que toute autre information émanant d’études socio-économiques ciblées menées à titre volontaire, dans le plein respect de la vie privée et de l’anonymat des personnes concernées, afin qu’il puisse évaluer la situation de sa population sur le plan économique, social et culturel.", "في ضوء توصيتها العامة رقم 8 (1990) المتعلقة بتفسير وتطبيق أحكام     الفقرتين 1 و4 من المادة 1 من الاتفاقية وفي ضوء الفقرات 10 إلى 12 من مبادئها التوجيهية المنقحة المتعلقة بصياغة التقارير الدورية (CERD/C/2007/1)، توصي اللجنة الدولة الطرف بتقديم معلومات عن تكوين سكانها، وعن استخدام اللغات الأم، وعن اللغات الشائعة، وعن أي مؤشر آخر يتعلق بالتنوع العرقي. وتوصي اللجنة كذلك بأن تبلَّغ بأي معلومات أخرى مستقاة من دراسات اجتماعية واقتصادية محددة الهدف تُجرى على نحو طوعي مع الاحترام الكامل لحرمة الحياة الخاصة وإغفال هويات الأشخاص المعنيين، حتى يتسنى لها تقييم وضع سكانها على الصعيد الاقتصادي والاجتماعي والثقافي.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 482, null, "R18P5", "ت.18.ف.5", "", "Non réalisé", "", 0, 2, 1, 1, null, 7, null, "Organes de traités", "fournir dans le prochain rapport des données complètes sur les plaintes déposées, les poursuites engagées, les condamnations et les peines prononcées pour des faits de discrimination raciale.", "تضمين التقرير المقبل بيانات كاملة عن الشكاوى المقدمة والملاحقات التي شُرع فيها والإدانات والعقوبات المنطوق بها في قضايا تتعلق بأفعال التمييز العنصري.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 483, null, "R23", "ت.23", "", "Non réalisé", "", 0, 2, 1, 1, null, 7, null, "Organes de traités", "Poursuivre les consultations et d’approfondir son dialogue avec les organisations de la société civile œuvrant dans le domaine de la protection des droits de l’homme, en particulier avec celles qui luttent contre la discrimination raciale, en vue de l’élaboration du prochain rapport périodique.", "مواصلة التشاور مع منظمات المجتمع المدني العاملة في مجال حماية حقوق الإنسان، ولا سيما في مكافحة التمييز العنصري، وتعميق الحوار معها عند صياغة التقرير الدوري المقبل.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 484, null, "R28", "ت.28", "", "Non réalisé", "", 0, 2, 1, 1, null, 7, null, "Organes de traités", "faire figurer dans le prochain rapport périodique des informations détaillées sur les mesures concrètes prises pour appliquer les recommandations7, 9, 10, 18, 20 et 26", "تقديم معلومات مفصلة في التقرير الدوري المقبل عن التدابير الملموسة والمناسبة المتخذة لتنفيذ التوصيات الواردة في الفقرات 7 و9 و10 و18 و20 الواردة في الفقرات 7 و9 و10 و18 و20 تنفيذاً فعالاً.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 485, null, "R25", "ت.25", "", "Non réalisé", "", 0, 2, 1, 1, null, 7, null, "Organes de traités", "mettre les rapports à la disposition du public dès leur soumission et de diffuser également ses observations finales sur ces rapports dans la langue officielle et les autres langues communément utilisées, selon le cas.", "إتاحة التقارير الدورية لعامة الجمهور حال تقديمها، ونشر الملاحظات الختامية التي تعتمدها باللغة الرسمية وباللغات الأخرى الشائع استخدامها، حسب الاقتضاء، عند الفراغ من النظر في تلك التقارير.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 486, null, "R26", "ت.26", "", "Non réalisé", "", 0, 2, 1, 1, null, 7, null, "Organes de traités", "Présenter une version mise à jour  du document de base en 2002 document de base présenté en 2002, qui devrait comporter de 60 à 80 pages, conformément aux directives harmonisées concernant l’établissement des rapports établis au titre des instruments internationaux relatifs aux droits de l’homme, à savoir celles qui se rapportent au document de base commun, telles qu’adoptées par la cinquième réunion inter comités des organes crées en vertu des traités relatifs aux droits de l’homme tenue en juin 2006 (HRI/GEN/2/Rev.4).", "تقديم نسخة محيَّنة للوثيقة الأساسية التي سبق ت إحالتها في عام 2002، من 60 إلى 80 صفحة، وفقاً للمبادئ التوجيهية المنسقة لتقديم التقارير بموجب المعاهدات الدولية لحقوق الإنسان، ولا سيما ما يتصل منها بالوثيقة الأساسية المشتركة، بالصيغة المعتمدة في الاجتماع الخامس المشترك بين لجان هيئات معاهدات حقوق الإنسان المعقود في حزيران/يونيه 2006 (HRI/GEN/2/Rev.4).", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 487, null, "R27", "ت.27", "", "Non réalisé", "", 0, 2, 1, 1, null, 7, null, "Organes de traités", "Fournir, dans un délai d’un an à compter de l’adoption des présentes observations finales, des informations sur la suite qu’il aura donnée aux recommandations contenues dans les paragraphes 11,13 et 14 ci-dessus, et ce conformément au au paragraphe 1 de l’article 9 de la Convention et à l’article 65 de son règlement 26 modifié", "تقديم معلومات بشأن متابعتها للتوصيات الواردة في الفقرات 11 و13 و14 أعلاه، في غضون سنة واحدة من اعتماد هذه الاستنتاجات، عملا بأحكام الفقرة 1 من المادة 9 من الاتفاقية والمادة 65 من نظام اللجنة الداخلي المعدل", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 488, null, "R29", "ت.29", "", "Non réalisé", "", 0, 2, 1, 1, null, 7, null, "Organes de traités", "soumettre le dix-neuvième, vingtième et vingt-unième rapports périodiques en un seul document, attendu le 17 janvier 2013, qui tiendra compte des directives concernant l’élaboration des documents propres au Comité pour l’élimination de la discrimination raciale, adoptées par le Comité à sa soixante et onzième session (CERD/C/2007/1) et qui ne devrait pas dépasser 40 pages et traitera tous les points soulevés dans les présentes observations finales.", "تقديم الدولة الطرف التقارير الدورية المقبلة التاسع عشر والعشرين والحادي والعشرين في وثيقة واحدة، لا تتعدى 40 صفحة، في موعد أقصاه 17 كانون الثاني/يناير 2014، مع مراعاة المبادئ التوجيهية المتعلقة بإعداد الوثائق الخاصة بلجنة القضاء على التمييز العنصري، التي اعتمدتها اللجنة في دورتها الحادية والسبعين (CERD/C/2007/1)، على أن يتم تناول جميع النقاط المثارة في هذه الملاحظات الختامية في تلك الوثيقة.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 489, null, "R22", "ت.22", "", "Non réalisé", "", 0, 2, 1, 1, null, 8, null, "Organes de traités", "A la lumière de sa Recommandation générale no. 33 (2009) sur le suivi de la Conférence d’examen de Durban, le Comité recommande à l’État partie de tenir compte de la Déclaration et du Programme d’action de Durban adoptés en septembre 2001 par la Conférence mondiale contre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, ainsi que du document final de la Conférence d’examen de Durban, qui s’est tenue à Genève en avril 2009, lorsqu’il applique la Convention dans son ordre juridique interne.", "القيان بإنفاذ إعلان وبرنامج عمل ديربان اللذين اعتمدا في أيلول/سبتمبر 2001 أثناء المؤتمر العالمي لمناهضة العنصرية والتمييز العنصري وكراهية الأجانب وما يتصل بذلك من تعصب، على ضوء توصية اللجنة العامة رقم 33(2009) بشأن متابعة مؤتمر استعراض نتائج ديربان، مع مراعاة الوثيقة الختامية لهذا المؤتمر  الذي عُقد في جنيف في نيسان/أبريل 2009، عندما تكون بصدد إدراج أحكام الاتفاقية في نظامها القانوني الداخلي. وتطلب اللجنة إلى الدولة الطرف أن تورد في تقريرها الدوري المقبل معلومات محددة عن خطط العمل وغيرها من التدابير المتخذة لتنفيذ إعلان وبرنامج عمل ديربان على الصعيد الوطني.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 2, null, "R66P1", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 1, "Procédure spéciale", "-   Élaborer et adopter une loi-cadre relative au droit à l’alimentation prévoyant des plans de mise en œuvre pour chaque région ainsi qu’un calendrier des opérations. Cette loi devrait également prévoir les mesures budgétaires et fiscales nécessaires afin d’être viable dans la durée", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 3, null, "R92", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 1, "Procédure spéciale", "-   Adopter au plus vite le projet de loi n o 97.13 relatif à la protection et à la promotion des droits des personnes en situation de handicap, actuellement examiné par le 32, afin de garantir la protection juridique des personnes handicapées", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 43, null, "R71", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 2, "Procédure spéciale", "-       Adopter des dispositions législatives et des mesures concrètes pour faire en sorte que l’élimination du racisme, de la discrimination raciale, de la xénophobie et de l’intolérance qui y est associée soit intégrée aux travaux et au mandat des organes chargés de promouvoir les droits de l’homme, l’égalité et la non-discrimination.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 44, null, "R78P1", "null", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 2, "Procédure spéciale", "-       Adopter sans délai la loi organique nécessaire pour donner à l’amazigh le statut constitutionnel de langue officielle", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 242, null, "R73P8-2", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 7, 9, "Procédure spéciale", "L’Experte indépendante encourage le Gouvernement à redoubler d’efforts en vue de soumettre ses rapports en temps voulu aux organes conventionnels des droits de l’homme pertinents", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 82, null, "R87P2", "ت.87.ف.2", "", "Non réalisé", "", 0, 3, 1, null, null, 9, 3, "Procédure spéciale", "-    Modifier l’article 224 du Code pénal pour mettre la définition du fonctionnaire public en conformité avec la définition de l’agent de la 21 ou toute autre personne agissant à titre officiel qui figure dans la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "-          (ب) تعديل المادة 224 من القانون الجنائي بحيث يتوافق تعريف الموظف العمومي مع تعريف موظف الخدمة المدنية أو غيره من الأشخاص الذين يعملون بصفة رسمية، الوارد في اتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 217, null, "R90P3", "ت.90.ق.3", "", "Non réalisé", "", 0, 2, 1, null, null, 7, 8, "Procédure spéciale", "Intensifier les efforts pour appliquer la Convention pour la sauvegarde du patrimoine culturel immatériel.", "إنشاء آليات تسمح للأشخاص باتخاذ قرارات فعالة ومجدية والمشاركة في تحديد التراث الثقافي وتفسيره وتعزيزه وحمايته. - توفير الدعم القانوني والمالي والمؤسسي لمقترح 'الكنوز البشرية الحية'. وينبغي للمغرب أيضاً - الدفع قدما بالجهود فيما يتعلق بتنفيذ اتفاقية صون التراث الثقافي غير المادي.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 161, null, "R89P13", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 7, 6, "Procédure spéciale", "Solliciter l’assistance technique de l’Organisation des Nations Unies en vue d’accroître la sensibilisation aux obligations internationales de l’État et d’en promouvoir le respect, notamment en ce qui concerne l’égalité et les droits fondamentaux des femmes, en s’appuyant sur l’attachement du Maroc à la coopération avec tous les organes et organismes des Nations Unies.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 275, null, "R144.110 P2", "110.144.ج.2", "", "Non réalisé", "", 0, 2, 1, null, 80, 5, null, "Examen périodique universal", "Ratifier le Protocole de 2014 à la Convention sur le travail forcé de l’Organisation internationale du Travail", "التصديق على بروتوكول عام 2014 لاتفاقية منظمة العمل الدولية لإلغاء السخرة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 276, null, "R144.242", "242.144.", "", "Non réalisé", "", 0, 2, 1, null, 51, 5, null, "Examen périodique universal", "Adhérer aux conventions relatives au statut des apatrides et à la réduction des cas d’apatridie pour accorder la nationalité aux enfants qui, autrement, demeureraient apatrides et les incorporer dans le droit interne", "الانضمام إلى الاتفاقيات المتعلقة بمركز الأشخاص عديمي الجنسية وإدراج أحكامها في قانونه الداخلي والحد من حالات انعدام الجنسية عن طريق منح الجنسية للأطفال الذين سيظلون بلا جنسية ما لم يُمنَحوا الجنسية المغربية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 277, null, "R144.19", "19.144", "", "Non réalisé", "", 0, 2, 1, null, 8, 5, null, "Examen périodique universal", "Envisager d’adresser une invitation permanente aux titulaires de mandat au titre des procédures spéciales", "النظر في توجيه دعوة دائمة إلى المكلفين بولايات في إطار الإجراءات الخاصة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 479, null, "R21", "ت.21", "", "Non réalisé", "", 0, 2, 1, 1, null, 5, null, "Organes de traités", "Envisager de ratifier les traités internationaux relatifs aux droits de l’homme auxquels il n’est pas encore partie mais qui pourraient avoir un rapport avec la  question de la discrimination raciale qui est en voie de trouver une solution et faire écho à l’histoire récente du Maroc, tels que la Convention internationale pour la protection de toutes les personnes contre les disparitions forcées adoptée en 2006.", "التفكير في التصديق على المعاهدات الدولية المتعلقة بحقوق الإنسان التي لم تنضم إليها المملكة المغربية بعد والتي قد تكون ذات صلة بمسألة التمييز العنصري التي هي مسألة في طريق الحل وإيجاد صدى لها في تاريخ المغرب الحديث، كالاتفاقية الدولية لحماية جميع الأشخاص من الاختفاء القسري، التي اعتُمدت في عام 2006.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 480, null, "R24", "ت.24", "", "Non réalisé", "", 0, 2, 1, 1, null, 5, null, "Organes de traités", "Ratifier les modifications apportées au paragraphe 6 de l’article 8 de la Convention, adoptées le 15 janvier 1992 à la quatorzième réunion des Etats parties à la Convention et approuvées par l’Assemblée générale dans sa résolution 47/111 en date du 16 décembre 1992. A cet égard, il renvoie à la résolution 61/148 de l’Assemblée générale, par laquelle l’Assemblée a demandé instamment aux Etats parties à la Convention d’accélérer leurs procédures internes de ratification des modifications et d’informer par écrit le Secrétaire général, dans les meilleurs délais, de leur acceptation de ces modifications.", "التصديق على التعديل الذي أُجري على الفقرة 6 من المادة 8 من الاتفاقية والذي اعتُمد في 15 كانون الثاني/يناير 1992 أثناء الدورة الرابعة عشرة للدول الأطراف في الاتفاقية (انظر مرفق الوثيقة CERD/SP/45) وأقرته الجمعية العامة في قرارها 47/111. وفي هذا الصدد، تشير اللجنة إلى الفقرة 14 من قرار الجمعية العامة 61/148 التي حثت فيها الجمعيةُ العامة بقوة الدول الأطراف في الاتفاقية على التعجيل باتخاذ إجراءاتها الداخلية للتصديق على التعديل وعلى إخطار الأمين العام بموافقتها عليه كتابةً وفي أسرع وقت ممكن.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 41, null, "R86", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 6, 2, "Procédure spéciale", "-       Inviter le Rapporteur spécial sur les droits de l’homme des migrants à effectuer une visite de pays", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 278, null, "R144.20", "20.144", "", "Non réalisé", "", 0, 2, 1, null, 22, 6, null, "Examen périodique universal", "Continuer d’interagir de manière constructive avec les mécanismes des procédures spéciales du Conseil des droits de l’homme", "مواصلة التحاور بشكلٍ بنّاء مع آليات الإجراءات الخاصة التابعة لمجلس حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 279, null, "R144.21", "21.144", "", "Non réalisé", "", 0, 2, 1, null, 42, 6, null, "Examen périodique universal", "Adresser une invitation permanente aux titulaires de mandat au titre des procédures spéciales du Conseil des droits de l’homme", "توجيه دعوة دائمة إلى المكلفين بولايات في إطار الإجراءات الخاصة التابعة لمجلس حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 280, null, "R144.22", "22.144", "", "Non réalisé", "", 0, 2, 1, null, 53, 6, null, "Examen périodique universal", "Adresser une invitation permanente aux titulaires de mandat au titre des procédures spéciales, comme cela a été précédemment recommandé", "توجيه دعوة دائمة للإجراءات الخاصة، مثلما سبقت التوصية بذلك", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 281, null, "R144.23", "23.144", "", "Non réalisé", "", 0, 2, 1, null, 73, 6, null, "Examen périodique universal", "Prendre des mesures concrètes pour renforcer sa coopération avec les procédures spéciales de l’ONU, notamment celles du Conseil des droits de l’homme", "اتخاذ خطوات حقيقية من أجل تعزيز التعاون مع الإجراءات الخاصة التابعة للأمم المتحدة، ولا سيما مع إجراءات مجلس حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 42, null, "R69", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 7, 2, "Procédure spéciale", "-       Soumettre sans plus tarder le rapport unique valant dix-neuvième, vingtième et vingt et unième rapports périodiques au Comité pour l’élimination de la discrimination raciale.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 79, null, "R90P1", "ت.90.ف.1", "", "Non réalisé", "", 0, 2, 1, null, null, 7, 3, "Procédure spéciale", "-    Collaborer plus étroitement avec le Haut-Commissariat des Nations Unies aux droits de l’homme, le Rapporteur spécial sur les droits de l’homme des migrants et d’autres organismes des Nations Unies, tels que le Haut-Commissariat des Nations Unies pour les réfugiés", "-          فيما يتعلق بالمهاجرين واللاجئين وملتمسي اللجوء، يوصي المقرر الخاص الحكومة بأن توثق تعاونها مع مفوضية الأمم المتحدة السامية لحقوق الإنسان، والمقرر الخاص المعني بحقوق الإنسان للمهاجرين، ووكالات أخرى تابعة للأمم المتحدة، مثل مفوضية الأمم المتحدة السامية لشؤون اللاجئين؛ كما يوصيها بما يلي:", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 80, null, "R97P3", "ت.97.ف.3", "", "Non réalisé", "", 0, 2, 1, null, null, 7, 3, "Procédure spéciale", "En ce qui concerne les provinces marocaines du Sud - Trouver des moyens pour renforcer encore plus la protection des droits de l’homme internationalement reconnus, notamment en adressant des invitations aux titulaires de mandat au titre des procédures spéciales de l’Organisation des Nations Unies, en renforçant la coopération avec la société civile et l’institution nationale des droits de l’homme et en facilitant la présence d’organisations non gouvernementales régionales", "فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي:- (ج) استحداث جميع الوسائل الممكنة لتعزيز حماية حقوق الإنسان المعترف بها دولياً بسبل منها دعوة آليات الإجراءات الخاصة التابعة للأمم المتحدة؛ وتدعيم التعاون مع المجتمع المدني والمؤسسة الوطنية لحقوق الإنسان؛ وتسهيل حضور المنظمات غير الحكومية الدولية؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 131, null, "R95P1", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 7, 4, "Procédure spéciale", "-    Poursuivre la collaboration étroite avec les organisations internationales et les organismes des Nations Unies compétents, notamment avec le HCR et l’OIM, afin de permettre aux victimes de la traite de retourner saines et sauves dans leur pays, en tenant dûment compte, s’il y a lieu, de la nécessité de leur garantir une protection internationale.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 132, null, "R97", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 7, 4, "Procédure spéciale", "collaborer avec les organisations internationales et bilatérales aux fins de l’hébergement et de l’indemnisation des victimes de la traite.  Envisager la possibilité d’utiliser les revenus issus du blanchiment d’argent ou les avoirs confisqués aux trafiquants comme ressources complémentaires pour financer l’aide aux victimes", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 192, null, "R83P16", "null", "", "Non réalisé", "", 0, 2, 1, null, null, 7, 7, "Procédure spéciale", "-       En ce qui concerne les migrants en situation irrégulière, réfugiés et demandeurs d’asile, travailler en coopération plus étroite avec le Haut-Commissariat des Nations Unies pour les réfugiés ; le Haut-Commissariat des Nations Unies aux droits de l’homme ; le Rapporteur spécial sur les droits de l’homme des migrants et d’autres organismes des Nations Unies", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 313, null, "R144.145", "145.144", "", "Non réalisé", "", 0, 4, 1, null, 22, 11, null, "Examen périodique universal", "Poursuivre les efforts visant à protéger les droits économiques et sociaux par la mise en œuvre de programmes de lutte contre la pauvreté, dans le cadre de l’Initiative nationale de développement humain", "مواصلة الجهود من أجل حماية الحقوق الاقتصادية والاجتماعية عن طريق تنفيذ برامج مكافحة الفقر في إطار المبادرة الوطنية للتنمية البشرية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 314, null, "R144.146", "146.144", "", "Non réalisé", "", 0, 4, 1, null, 28, 11, null, "Examen périodique universal", "Poursuivre la mise en œuvre de politiques de lutte contre la pauvreté et de promotion du développement économique", "مواصلة تنفيذ السياسات الرامية إلى مكافحة الفقر وتشجيع التنمية الاقتصادية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 315, null, "R144.147", "147.144", "", "Non réalisé", "", 0, 4, 1, null, 78, 11, null, "Examen périodique universal", "Poursuivre les efforts pour réduire la pauvreté et combler l’écart de revenu entre les différentes régions et entre les zones rurales et les zones urbaines", "مواصلة الجهود الرامية إلى الحد من الفقر وسد الفارق في الدخل بين منطقة وأخرى وبين الأرياف والحواضر", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 361, null, "R144.95P1P3", "95.144. ج.1 و ج.3", "", "Non réalisé", "", 0, 5, 1, null, 2, 20, null, "Examen périodique universal", "Poursuivre le débat national en cours relatif à l’abolition de la peine de mort", "مواصلة النقاش الوطني الحالي بشأن إلغاء عقوبة الإعدام....... والنظر في إضفاء الصفة الرسمية على الوقف الاختياري لتنفيذها بحكم الواقع الذي يُطبَّق حالياً", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 362, null, "R144.96P1", "96.144. ج.1", "", "Non réalisé", "", 0, 5, 1, null, 81, 20, null, "Examen périodique universal", "Maintenir son moratoire de fait sur l’application de la peine de mort", "الإبقاء على الوقف الاختياري بحكم الواقع على استخدام عقوبة الإعدام....", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 363, null, "R144.97", "97.144", "", "Non réalisé", "", 0, 5, 1, null, 1, 20, null, "Examen périodique universal", "Poursuivre le débat national sur l’abolition de la peine de mort", "مواصلة النقاش الوطني بشأن إلغاء عقوبة الإعدام", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 364, null, "R144.98", "98.144", "", "Non réalisé", "", 0, 5, 1, null, 95, 20, null, "Examen périodique universal", "Envisager d’officialiser le moratoire de fait sur la peine de mort", "النظر في إضفاء الصفة الرسمية على الوقف الاختياري لتنفيذ عقوبة الإعدام بحكم الواقع", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 365, null, "R144.99", "99.144", "", "Non réalisé", "", 0, 5, 1, null, 63, 20, null, "Examen périodique universal", "Envisager d’abolir la peine capitale", "النظر في إلغاء عقوبة الإعدام", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 366, null, "R144.101P1", "101.144. ج.1", "", "Non réalisé", "", 0, 5, 1, null, 8, 20, null, "Examen périodique universal", "Maintenir le moratoire sur la peine de mort", ".........الإبقاء على الوقف الاختياري لعقوبة الإعدام.......", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 360, null, "R144.94 P1", "94.144.ج.1", "", "Non réalisé", "", 0, 5, 1, null, 61, 20, null, "Examen périodique universal", "Maintenir le moratoire sur la peine de mort et intensifier le dialogue sur la peine capitale et son impact", "الإبقاء على الوقف الاختياري لعقوبة الإعدام وتكثيف الحوار بشأن عقوبة الإعدام وآثارها..........", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 100, null, "R88P1", "ت.88.ف.1", "", "Non réalisé", "", 0, 5, 1, null, null, 21, 3, "Procédure spéciale", "-    Veiller strictement à l’enregistrement des détenus dès leur arrestation, en particulier dans les affaires concernant la sécurité nationale et le terrorisme, et de faire en sorte que les chefs de poste de police, les agents de la police judiciaire et les fonctionnaires de police, y compris les membres de la DST, soient tenus pénalement responsables de toute détention non reconnue;", "-          (أ) التأكد من التقيد الصارم بالتسجيل منذ الوهلة الأولى من إلقاء القبض، خاصة في حالات الأمن القومي والمشتبه في ارتكابهم أعمالاً إرهابية؛ والتأكد من المساءلة الجنائية لمديري مراكز الشرطة والمحققين والموظفين التنفيذيين، بمن فيهم العاملون في إدارة مراقبة التراب الوطني (المخابرات)، عن أي احتجاز غير معترف به؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 102, null, "R93P1", "ت.93.ف.1", "", "Non réalisé", "", 0, 5, 1, null, null, 21, 3, "Procédure spéciale", "-    Réduire fortement le taux de surpeuplement", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي: (أ) تقليص نسبة الاكتظاظ تقليصاً شديداً؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 103, null, "R93P2", "ت.93.ف.2", "", "Non réalisé", "", 0, 5, 1, null, null, 21, 3, "Procédure spéciale", "Allouer des ressources budgétaires suffisantes pour assurer des soins de santé convenables ;- Améliorer la qualité de la nourriture et faire en sorte que les mineurs soient séparés des adultes et les détenus avant jugement des condamnés ;- Renforcer et améliorer le système d’application des peines de façon qu’il vise à assurer la réadaptation et la réinsertion des délinquants ; - Créer des possibilités d’instruction et de travail et des activités récréatives pour les détenus", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي:- (ب) تخصيص ميزانية كافية لتوفير الرعاية الصحية، وتحسين نوعية الغذاء، وفصل القُصّر عن البالغين والسجناء الذين لم تصدر بعد في حقهم أحكام عن المدانين؛ وتعزيز وتحسين نظام تطبيق الأحكام الذي يهدف إلى إعادة تأهيل الجناة وإعادة إدماجهم؛ وتوفير فرص تعليمية ومهنية وأنشطة ترفيهية للسجناء؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 104, null, "R93P3", "ت.93.ف.3", "", "Non réalisé", "", 0, 5, 1, null, null, 21, 3, "Procédure spéciale", "-    Transférer les prisonniers condamnés à la peine de mort et ceux qui exécutent une peine de réclusion à perpétuité dans des établissements ouverts ou semi-ouverts ;", "-          (ج) نقل السجناء المحكوم عليهم بالإعدام وبالسجن المؤبّد إلى مرافق مفتوحة أو شبه مفتوحة؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 105, null, "R93P6", "ت.93.ف.6", "", "Non réalisé", "", 0, 5, 1, null, null, 21, 3, "Procédure spéciale", "-    Fournir les soins dentaires et psychiatriques requis et assurer les interventions psychologiques voulues, de manière générale", "-          (و) توفير خدمات طب الأسنان والطب النفسي المناسبة، إضافة إلى التدخلات النفسية، والأخذ بذلك على أنه قاعدة عامة.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 367, null, "R144.102", "102.144", "", "Non réalisé", "", 0, 5, 1, null, 75, 21, null, "Examen périodique universal", "Poursuivre les programmes socioéconomiques pour les détenus aux fins de leur réinsertion socioprofessionnelle à leur sortie de prison, en particulier en faveur des femmes et des jeunes", "مواصلة تنفيذ البرامج الاجتماعية والاقتصادية لصالح المساجين في إطار إعادة إدماجهم اجتماعياً ومهنياً بعد احتجازهم، ولا سيما لفائدة النساء والشباب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 368, null, "R144.104", "104.144", "", "Non réalisé", "", 0, 5, 1, null, 41, 21, null, "Examen périodique universal", "Prendre les mesures nécessaires pour résoudre le problème de la surpopulation carcérale", "اتخاذ التدابير الضرورية لحل مشكلة اكتظاظ السجون", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 101, null, "R88P3", "ت.88.ف.3", "", "Non réalisé", "", 0, 5, 1, null, null, 21, 3, "Procédure spéciale", "-    Mettre un terme à la pratique de l’isolement cellulaire et de la détention secrète, conformément à l’article 23 de la Constitution ;", "-          (ج) إنهاء ممارسة الحبس الانفرادي والاحتجاز السري، عملاً بالمادة 23 من الدستور؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 359, null, "R144.93", "93.144", "", "Non réalisé", "", 0, 5, 1, null, 49, 20, null, "Examen périodique universal", "Intensifier le débat national en vue d’abolir la peine de mort", "تكثيف المناقشات الوطنية بقصد إلغاء عقوبة الإعدام", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 205, null, "R83P25", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 7, "Procédure spéciale", "-       En ce qui concerne Laâyoune, au Sahara occidental, enquêter rapidement sur toutes les allégations de torture et de mauvais traitements dans le cadre d’arrestations, pendant et après les manifestations ainsi qu’à la prison de Laâyoune; éviter les cas de privation de liberté arbitraire; tenir les auteurs responsables et indemniser les victimes;", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 204, null, "R83P23", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 7, "Procédure spéciale", "Prendre des mesures efficaces en vue de prévenir les représailles, y compris l’intimidation, les mesures disciplinaires et les mauvais traitements contre les détenus, victimes de détention arbitraire et leurs familles, et d’autres personnes qui ont parlé au Groupe de travail lors de sa visite ; - Enquêter rapidement et punir les auteurs d’actes de représailles ;", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 52, null, "R79P5", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 18, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne les droits fonciers", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 19, null, "R73", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 19, 1, "Procédure spéciale", "-   Créer des conditions permettant aux agriculteurs d’adopter des pratiques agro écologiques et dispenser une formation sur les différentes méthodes de lutte contre les organismes nuisibles afin d’éviter l’utilisation excessive des pesticides synthétiques.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 20, null, "R76", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 19, 1, "Procédure spéciale", "-   Promouvoir le maintien et la gestion de la biodiversité agricole afin de garantir une diversité génétique permettant de préserver les ressources naturelles nécessaires à la résilience des agriculteurs, à l’innovation agricole et à l’adaptation de l’agriculture aux changements climatiques.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 21, null, "R77", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 19, 1, "Procédure spéciale", "-   Mieux appliquer les lois environnementales afin de protéger les bassins versants, les forêts et les rivières, qui sont les premières sources de nourriture. Mettre en place des mécanismes permettant de prévenir l’érosion des sols et les inondations et de renforcer la biodiversité.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 53, null, "R75", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 2, "Procédure spéciale", "-       Prendre des mesures concrètes pour renforcer le principe de responsabilité pour tous les actes de discrimination raciale et de xénophobie, en veillant à ce que les allégations de tels actes fassent l’objet d’enquêtes approfondies et, s’il y a lieu, de poursuites et de sanctions, même dans les cas où les violations des droits ne résultent pas directement d’une politique ou de mesures délibérées du Gouvernement.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 95, null, "R88P6", "ت.88.ف.6", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 3, "Procédure spéciale", "-    diligenter des enquêtes impartiales et approfondies sur toutes les allégations de torture et de traitements cruels, inhumains ou dégradants, sans qu’il soit nécessaire qu’une plainte soit déposée par écrit, conformément à l’article 13 de la Convention contre la torture; de mettre en place des procédures pour enquêter d’office sur tout cas de torture et de mauvais traitements quelle que soit la manière dont il est invoqué, même lorsque les victimes n’utilisent pas les procédures prescrites par la loi pour soumettre leur plainte", "-          (و) التعجيل بإجراء تحقيقات فورية ونزيهة وشاملة في جميع ادعاءات التعذيب وغيره من أشكال المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة، دون الحاجة إلى شكوى خطية، عملاً بالمادة 13 من اتفاقية مناهضة التعذيب؛ ووضع إجراءات للتحقيق، بحكم الوظيفة، في أي قضية تعذيب أو سوء معاملة تثار بأي وسيلة من الوسائل، حتى عندما لا يقدم الضحايا شكاوى بالطرق القانونية؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 96, null, "R88P10", "ت.88.ف.10", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 3, "Procédure spéciale", "Engager des procédures judiciaires au sujet de tous les cas de violations commises par le passé pendant les «années de plomb» (1956-1999) révélées par l’Instance équité et réconciliation", "-          (ي) رفع دعاوى قضائية بشأن جميع الحالات التي كشفت عنها هيئة الإنصاف والمصالحة والمتعلقة بانتهاكات سنوات الرّصاص (1956-1999)؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 97, null, "R89", "ت.89", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 3, "Procédure spéciale", "En ce qui concerne les manifestations, le Rapporteur spécial recommande au Gouvernement de se conformer aux normes internationales, telles que les «Principes de base relatifs au recours à la force et l’utilisation des armes à feu par les responsables de l’application des lois», qui, s’agissant du respect de la vie et de l’intégrité physique, sont fondées sur les principes de nécessité et de proportionnalité; et de promouvoir encore plus la prévention des actes de torture ou des mauvais traitements dont sont victimes les manifestants, les enquêtes sur ces actes et les poursuites engagées contre leurs auteurs.", "-          يوصي المقرر الخاص الحكومة بأن تتصرف وفق المعايير الدولية، مثل 'المبادئ الأساسية بشأن استخدام القوة والأسلحة النارية من جانب الموظفين المكلفين بإنفاذ القوانين‏'، التي تقوم على مبدأي الضرورة والتناسب المتعلقين بالحق في الحياة والسلامة الجسدية، إضافة إلى منع تعذيب المحتجين أو إساءة معاملتهم، والتحقيق في هاتين الممارستين.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 98, null, "R96", "ت.96", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 3, "Procédure spéciale", "-    Agir pour prévenir les représailles, y compris sous la forme d’actes d’intimidation, de mesures disciplinaires et de mauvais traitements, à l’encontre de détenus, de victimes de la torture et de membres de leur famille, d’activistes et d’autres personnes qui se sont entretenus avec le Rapporteur spécial pendant sa visite, et d’enquêter rapidement sur les actes de représailles et de punir leurs auteurs.", "-          يحث المقرر الخاص الحكومة على أن تمنع بالفعل الأعمال الانتقامية، مثل التخويف، والتدابير التأديبية، وسوء المعاملة، في حق السجناء، وضحايا التعذيب وأفراد أسرهم، والمناضلين وغيرهم ممن تحدثوا إلى المقرر الخاص أثناء زيارته، والتعجيل بالتحقيق في تلك الأعمال ومعاقبة مقترفيها.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 99, null, "R97P1", "ت.97.ف.1", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 3, "Procédure spéciale", "En ce qui concerne les provinces marocaines du Sud - Enquêter rapidement sur toutes les allégations faisant état d’actes de torture et de mauvais traitements pendant et après les manifestations et à la prison de Laâyoune; - Tenir les auteurs responsables de ces actes et d’accorder une indemnisation aux victimes ;", "فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي:- (أ) التحقيق بسرعة في جميع ادعاءات التعذيب وسوء المعاملة أثناء المظاهرات وبعدها وفي سجن العيون؛  مساءلة الجناة؛ وتعويض الضحايا؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 199, null, "R83P5", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 7, "Procédure spéciale", "-       Prendre toutes les mesures nécessaires pour s’assurer que les condamnations pénales sont fondées sur des preuves autres que les aveux des accusés, en particulier lorsque ces personnes se rétractent lors du procès, et s’assurer que, sauf dans les cas impliquant des accusations de torture, les déclarations faites sous la torture ne sont pas invoquées comme preuve dans une procédure, conformément à l’article 15 de la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 200, null, "R83P6", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 7, "Procédure spéciale", "-       S’assurer que les rapports établis par la police judiciaire au cours de l’enquête restent inadmissibles au cours du procès jusqu’à ce que les preuves de leur véracité et de leur validité juridique soient confirmées conformément au Code de procédure pénale", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 201, null, "R83P7", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 7, "Procédure spéciale", "-       Réviser les condamnations pénales fondées uniquement sur des aveux afin d’identifier les cas où la condamnation est fondée sur des aveux obtenus par la torture ou des mauvais traitements et prendre les mesures correctives appropriées", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 202, null, "R83P8", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 7, "Procédure spéciale", "-       Veiller strictement à l’enregistrement dès l’arrestation, en particulier dans les affaires concernant la sécurité nationale et le terrorisme, et faire en sorte que les chefs de poste de police, les agents de la police judiciaire et les fonctionnaires de police, y compris les membres de la DST, soient tenus pénalement responsables de toute détention non reconnue", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 203, null, "R83P10", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 20, 7, "Procédure spéciale", "-       Mener des enquêtes efficaces et impartiales sur tous les cas de «transfèrements secrets» dans lesquels l’État pourrait avoir joué un rôle : mettre en lumière les faits entourant ces cas, poursuivre et punir les responsables de ces transfèrements", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 369, null, "R144.105", "105.144", "", "Non réalisé", "", 0, 5, 1, null, 51, 21, null, "Examen périodique universal", "Continuer à améliorer les conditions de détention dans les établissements pénitentiaires, réduire la surpopulation et adopter des mesures de substitution à la détention provisoire, et fournir des soins médicaux appropriés aux détenus", "مواصلة تحسين الظروف في السجون والحد من الاكتظاظ واعتماد بدائل عن الاحتجاز قبل المحاكمة وتوفير الرعاية الطبية الكافية للسجناء", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 106, null, "R95P4", "ت.95.ف.4", "", "Non réalisé", "", 0, 5, 1, null, null, 22, 3, "Procédure spéciale", "Faire en sorte que les victimes obtiennent une réparation et une indemnisation équitable et suffisante, y compris les moyens d’une réadaptation aussi complète que possible ;                        Etablir des mécanismes et des programmes, notamment les structures requises au sein du Ministère de la santé, pour fournir à toutes les victimes des services de réadaptation, et de financer les services privés médicaux, juridiques et autres, y compris ceux administrés par des organisations non gouvernementales, prestataires de services médicaux, psychologiques et de réadaptation sociale", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي:  (ج) اتباع الإدارات المعنية بالصحة في السجون لوزارة الصحة، الأمر الذي يُفترض أن يسهم في تقديم خدمات طبية فائقة الجودة؛ ...استحداث آليات وبرامج، مثل البنى التحتية المناسبة داخل وزارة الصحة، وإعادة تأهيل الضحايا، وتمويل المرافق الطبية والقانونية وغيرها، مثل تلك التي تديرها المنظمات غير الحكومية، التي تقدم خدمات إعادة التأهيل الطبي والنفسي والاجتماعي؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 107, null, "R95P5", "ت.95.ف.5", "", "Non réalisé", "", 0, 5, 1, null, null, 22, 3, "Procédure spéciale", "-    Envisager un financement bilatéral direct des organisations de la société civile qui apportent un soutien aux victimes et aux membres de leur famille, et de mettre en place des services spécialisés au sein du système de santé national. Le Fonds de contributions volontaires des Nations Unies pour les victimes de la torture est invité à examiner les demandes d’aide émanant d’ONG œuvrant pour assurer aux personnes qui ont été torturées l’accès à des soins médicaux et à des recours judiciaires.", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي: ... (ﻫ) النظر في التمويل الثنائي المباشر لمنظمات المجتمع المدني التي تساعد الضحايا وأسرهم، واستحداث إدارات متخصصة داخل النظام الصحي الوطني. ويُدعى صندوق الأمم المتحدة للتبرعات لضحايا التعذيب إلى النظر في طلبات المساعدة المقدمة من المنظمات غير الحكومية العاملة في مجال مساعدة ضحايا التعذيب على الحصول على الخدمات الطبية والانتصاف القانوني.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 22, null, "R80", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 23, 1, "Procédure spéciale", "-   Renforcer la participation des femmes à l’examen des questions relatives au droit à l’alimentation, en particulier au niveau de la prise de décisions. Il faudrait prévoir la pleine participation des femmes vivant dans des zones reculées à la vie politique.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 374, null, "R144.69", "69.144", "", "Non réalisé", "", 0, 6, 1, null, 93, 30, null, "Examen périodique universal", "Poursuivre les efforts visant à élaborer un cadre national pour le développement humain qui tienne compte de l’égalité des sexes et de la non‑discrimination", "مواصلة الجهود الرامية إلى صوغ إطار وطني للتنمية البشرية يضع في الاعتبار المساواة بين الجنسين وعدم التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 375, null, "R144.182", "182.144", "", "Non réalisé", "", 0, 6, 1, null, 28, 30, null, "Examen périodique universal", "Continuer à promouvoir l’égalité entre hommes et femmes dans les politiques publiques", "مواصلة تعزيز المساواة بين الرجال والنساء في السياسات العامة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 376, null, "R144.183", "183.144", "", "Non réalisé", "", 0, 6, 1, null, 77, 30, null, "Examen périodique universal", "Continuer de promouvoir l’égalité des sexes et la participation des femmes à la vie politique et aux services publics", "مواصلة تشجيع المساواة بين الجنسين وإشراك المرأة في الحياة السياسية والوظيفة العمومية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 377, null, "R144.184P1", "184.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 59, 30, null, "Examen périodique universal", "Poursuivre les efforts louables visant à promouvoir et protéger les droits des femmes", "مواصلة الجهود الحميدة الرامية إلى تعزيز حماية حقوق النساء", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 378, null, "R144.187", "187.144", "", "Non réalisé", "", 0, 6, 1, null, 43, 30, null, "Examen périodique universal", "Comme suite aux recommandations issues du deuxième cycle figurant dans le document A/HRC/21/3 (par. 129.19, 129.22, 129.27, 129.39, 129.40, 129.43, 129.78, 129.88, 129.93 et 131.7), intensifier les efforts visant à améliorer les droits économiques, sociaux et culturels de la population féminine, avec leur pleine participation", "متابعة للتوصيات المنبثقة عن الجولة الثانية والواردة في الوثيقة A/HRC/21/3، الفقرات 129-19 و129-22 و129-27 و129-39 و129-40 و129-43 و129-78 و129-88 و129-93 و131-7، وتكثيف الجهود من أجل تحسين التمتع بالحقوق الاقتصادية والاجتماعية والثقافية مع مشاركة النساء مشاركة تامة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 379, null, "R144.190", "190.144", "", "Non réalisé", "", 0, 6, 1, null, 36, 30, null, "Examen périodique universal", "Prendre toutes les mesures nécessaires afin de renforcer la lutte contre la violence domestique et les violences sexuelles envers les femmes", "اتخاذ جميع التدابير الضرورية لتشديد مكافحة العنف المنزلي والعنف الجنسي الذي يمارَس على النساء", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 380, null, "R144.192", "192.144", "", "Non réalisé", "", 0, 6, 1, null, 85, 30, null, "Examen périodique universal", "Continuer à mettre en place des mesures concrètes aux niveaux local et national pour garantir l’égalité des sexes et lutter contre la discrimination à l’égard des femmes", "مواصلة استحداث تدابير عملية على الصعيدين المحلي والوطني لضمان المساواة بين الجنسين ومكافحة التمييز في حق المرأة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 381, null, "R144.193", "193.144", "", "Non réalisé", "", 0, 6, 1, null, 93, 30, null, "Examen périodique universal", "Continuer de s’employer à lutter contre les violences faites aux femmes", "مواصلة الجهود لمكافحة العنف على المرأة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 382, null, "R144.198P1", "198.144", "", "Non réalisé", "", 0, 6, 1, null, 3, 30, null, "Examen périodique universal", "Mettre en œuvre des mesures adéquates pour assurer la protection complète et efficace des femmes contre la violence familiale", "تنفيذ تدابير كافية لضمان توفير الحماية الشاملة والفعالة للنساء من العنف المنزلي وتسريع عملية صياغة مشروع قانون يتماشى مع المعايير الدولية لتوفير الحماية الشاملة والفعالة للنساء من العنف المنزلي", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 383, null, "R144.207", "207.144", "", "Non réalisé", "", 0, 6, 1, null, 31, 30, null, "Examen périodique universal", "Accomplir de nouveaux progrès dans la lutte contre toutes les formes de discrimination et de violence à l’égard des femmes en mettant en service l’Autorité pour l’égalité des sexes et la lutte contre toutes les formes de discrimination", "إحراز مزيد من التقدم في محاربة جميع أشكال التمييز والعنف على المرأة وبدئ هيئة المناصفة ومكافحة كل أشكال التمييز عملها", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 384, null, "R144.211", "211.144", "", "Non réalisé", "", 0, 6, 1, null, 91, 30, null, "Examen périodique universal", "Intensifier les efforts pour combattre la violence à l’égard des femmes en appliquant strictement les lois pertinentes et améliorer les mécanismes d’assistance aux victimes", "تكثيف الجهود لمكافحة العنف على المرأة بتطبيق القوانين ذات الصلة تطبيقاً صارماً وبتحسين آليات مساندة الضحايا", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 385, null, "R144.212", "212.144", "", "Non réalisé", "", 0, 6, 1, null, 41, 30, null, "Examen périodique universal", "Prendre des mesures supplémentaires sur la violence familiale", "اتخاذ مزيد من التدابير بشأن العنف المنزلي", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 386, null, "R144.214", "214.144", "", "Non réalisé", "", 0, 6, 1, null, 83, 30, null, "Examen périodique universal", "Adopter des mesures appropriées en vue d’intégrer davantage les femmes dans les activités économiques et de leur garantir le droit à l’égalité de traitement et l’égalité de rémunération pour un travail de valeur égale", "اعتماد التدابير المناسبة بغية إدماج النساء أكثر في الأنشطة الاقتصادية وضمان حقهن في المعاملة المتساوية والأجر المتساوي لقاء العمل ذي القيمة المتساوية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 387, null, "R144.220", "220.144", "", "Non réalisé", "", 0, 6, 1, null, 30, 30, null, "Examen périodique universal", "Renforcer la promotion de la participation politique des femmes et des jeunes", "زيادة تعزيز مشاركة المرأة والشباب في الحياة السياسية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 388, null, "R144.221", "221.144.", "", "Non réalisé", "", 0, 6, 1, null, 50, 30, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir la participation politique des femmes", "مواصلة الجهود الرامية إلى تعزيز مشاركة المرأة في الحياة السياسية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 231, null, "R89", "ت.89", "", "Non réalisé", "", 0, 6, 1, null, null, 30, 8, "Procédure spéciale", "Pour garantir une égalité effective des sexes au bénéfice des femmes assurant une direction spirituelle, les femmes devraient pouvoir devenir membres à part entière des conseils religieux à tous les niveaux, y compris les institutions chargées d’émettre des fatwa, et être autorisées à exercer des fonctions de supervision dans les mosquées, que ce soit par l’enseignement ou la prédication.", "-    لضمان مساواة فعالة بين الجنسين للنساء اللواتي يقدمن إرشادات دينية، ينبغي أن تكون النساء قادرات على الانضمام- كأعضاء كاملي العضوية- إلى المجالس الدينية على جميع المستويات، بما في ذلك مؤسسات الفتوى، وأن يُسمح لهن بممارسة الإشراف الديني داخل المساجد، سواء من خلال الدروس أو الوعظ.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 502, null, "R11P6", "·          ت.11.ف.6", "", "Non réalisé", "", 0, 4, 1, 1, null, 16, null, "Organes de traités", "Mettre un accent particulier sur le développement des régions habitées par les amazighs, et ce dans le cadre de la Commission consultative de Régionalisation", "تنمية المناطق التي يسكنها الأمازيغ وذلك في إطار اللجنة الاستشارية للهيكلة الإقليمية.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 230, null, "R86P6-2", "ت.86.ف.6ج2", "", "Non réalisé", "", 0, 6, 1, null, null, 30, 8, "Procédure spéciale", "Tenir compte des droits de l’homme, de l’égalité des sexes et de la justice sociale dans l’élaboration du plan national de développement culturel.", "-    (و) وضع خطة عمل وطنية للتنمية الثقافية تضمن بشكل فعال إبراز التنوع الثقافي؛ ..... وينبغي أن تساهم مفاهيم حقوق الإنسان والمساواة بين الجنسين والعدالة الاجتماعية في إعداد خطة وطنية للتنمية الثقافية.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 170, null, "R89P9", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 30, 6, "Procédure spéciale", "Transposer à l’échelon régional, provincial et communal les progrès notables accomplis au niveau national dans le domaine de l’intégration et de la budgétisation axée sur la parité au sein des organismes publics", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 54, null, "R79P6", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 24, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne les libertés d’opinion et d’expression", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 370, null, "R144.115", "115.144", "", "Non réalisé", "", 0, 5, 1, null, 74, 24, null, "Examen périodique universal", "Poursuivre les travaux visant à renforcer la liberté d’expression par l’application de la loi portant création du Conseil national de la presse", "مواصلة العمل على تعزيز حرية التعبير عن طريق تنفيذ القانون المنشئ للمجلس الوطني للصحافة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 371, null, "R144.244", "244.144", "", "Non réalisé", "", 0, 5, 1, null, 48, 24, null, "Examen périodique universal", "Élaborer et appliquer des mesures indépendantes et crédibles qui garantissent le plein respect des droits de l’homme au Sahara occidental, notamment la liberté d’expression et de réunion", "وضع وتنفيذ تدابير مستقلة وموثوقة لضمان الاحترام الكامل لحقوق الإنسان في الصحراء الغربية بما فيها حرية التعبير والتجمع", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 55, null, "R79P7", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 25, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne les libertés de réunion pacifique et d’association", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 228, null, "R86P5", "ت.86.ف.5", "", "Non réalisé", "", 0, 5, 1, null, null, 25, 8, "Procédure spéciale", "Revoir ses pratiques en matière d’enregistrement des associations afin d’assurer le respect intégral du droit à la liberté d’association, sans aucune discrimination", "(ﻫ) استعراض الممارسات المتصلة بتسجيل الجمعيات من أجل ضمان الاحترام التام للحق في حرية تكوين الجمعيات، دون أي تمييز؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 372, null, "R144.114P2", "114.144.ج.2", "", "Non réalisé", "", 0, 5, 1, null, 36, 25, null, "Examen périodique universal", "Garantir pleinement les libertés d’association et prendre toutes les mesures nécessaires pour veiller à ce que les défenseurs des droits de l’homme puissent s’acquitter de leur mission", "ضمان حرية تكوين الجمعيات ضماناً تاماً بغية كفالة تمكين المدافعين عن حقوق الإنسان من أداء مهماتهم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 56, null, "R87", "null", "", "Non réalisé", "", 0, 5, 1, null, null, 27, 2, "Procédure spéciale", "-       Veiller à ce que tous les Marocains, y compris les membres de minorités religieuses, jouissent pleinement de leur droit à la liberté de pensée, de conscience et de religion dans des conditions d’égalité", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 373, null, "P1R 144.111", "111.144. ج.1", "", "Non réalisé", "", 0, 5, 1, null, 51, 27, null, "Examen périodique universal", "Supprimer les pratiques restrictives à l’encontre des chrétiens et d’autres minorités conformément au droit international", "إزالة الممارسات التقييدية في حق المسيحيين وأقليات أخرى.. .......", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 503, null, "R15", "ت.15", "", "Non réalisé", "", 0, 5, 1, 1, null, 28, null, "Organes de traités", "Assurer l’application des garanties juridiques fondamentales aux personnes soupçonnées de terrorisme, en particulier des étrangers, en tenant compte de la Déclaration adoptée par le Comité, le 8 mars 2002 sur la discrimination raciale et les mesures de lutte contre le terrorisme (A/57/18, paragraphe 514).", "الحرص على ضمان تطبيق الضمانات القانونية الأساسية على الأشخاص الذين يُشتبه في تورطهم في الإرهاب، خاصةً إذا كانوا يحملون جنسية أجنبية، مع اعتبار الإعلان الذي اعتمدته اللجنة في 8 آذار/مارس 2002 بشأن التمييز العنصري وتدابير مكافحة الإرهاب (A/57/18، الفقرة 514).", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 229, null, "R86P2-1-2", "ت.86.ف.2ج1ج2", "", "Non réalisé", "", 0, 5, 1, null, null, 29, 8, "Procédure spéciale", "veiller à ce que les officiers de l’état civil observent pleinement les dispositions de la circulaire du 9 avril 2010 sur le choix des prénoms du Ministère des affaires 26es. - ouvrir en temps voulu des recours effectifs aux individus dont on a refusé d’inscrire les enfants sous le prénom choisi. Dans un tel cas, les officiers d’état civil devraient répondre par écrit aux demandeurs, en temps voulu, en indiquant clairement les raisons de leur refus et les possibilités de recours.", "(ب) ضمان تقيد سجلات الحالة المدنية تقيدا تاما بأحكام مذكروزارة الداخلية المؤرخة 9 نيسان/أبريل 2010 والمتعلقة باختيار الأسماء.-   إتاحة الوصول إلى سبل الانتصاف في الوقت المناسب وبشكل فعال للأشخاص الذين حرموا من تسجيل أسماء أطفالهم. وفي هذه الحالة، ينبغي أن يقدم موظفو الحالة المدنية ردوداً خطية إلى أصحاب الطلبات، في الوقت المناسب، مع الإشارة بوضوح لأسباب هذا الرفض وإمكانيات الطعن فيه.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 23, null, "R79", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 30, 1, "Procédure spéciale", "-   Prendre toutes les mesures nécessaires pour éliminer les préjugés et pratiques néfastes qui empêchent les femmes d’exercer leurs droits, conformément aux obligations qui incombent au Maroc en vertu de la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 24, null, "R81", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 30, 1, "Procédure spéciale", "-   Appliquer les dispositions du Code des habous et prendre des mesures pour éliminer les obstacles socioculturels empêchant les femmes d’exercer leur droit à la terre.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 108, null, "R92P1", "ت.92.ف.1", "", "Non réalisé", "", 0, 6, 1, null, null, 30, 3, "Procédure spéciale", "-    Donner effet à la protection des prisonnières contre toutes les violences fondées sur le sexe", "عن النساء، يوصي المقرر الخاص الحكومة بما يلي:  (أ) تعزيز حماية السجينات من جميع أشكال العنف الجنساني؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 109, null, "R92P2", "ت.92.ف.2", "", "Non réalisé", "", 0, 6, 1, null, null, 30, 3, "Procédure spéciale", "-    En ce qui concerne les femmes, réduire le taux de surpeuplement des prisons en prenant des mesures de remplacement des peines privatives de liberté, en particulier dans le cas des femmes ayant des enfants.", "عن النساء، يوصي المقرر الخاص الحكومة بما يلي:  (ب) تقليص نسبة الاكتظاظ بتنفيذ تدابير بديلة، لا سيما لفائدة النساء والأطفال.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 169, null, "R89P6", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 30, 6, "Procédure spéciale", "Rassembler des informations étayées par des faits sur l’application de l’obligation qu’a l’État partie d’agir avec la diligence voulue pour prévenir, interdire et punir les violations des normes internationales relatives à l’égalité et à la non-discrimination,  et pour assurer aux femmes en temps voulu des moyens de recours abordables et accessibles, y compris judiciaires;", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 171, null, "R89P10", "null", "", "Non réalisé", "", 0, 6, 1, null, null, 30, 6, "Procédure spéciale", "Approuver et appliquer l’Agenda du Gouvernement pour l’égalité 2011-2015. Toutes les politiques et programmes dotés d’objectifs en matière d’égalité et de non-discrimination devraient faire l’objet d’une évaluation régulière pour s’assurer qu’ils permettront d’atteindre ces objectifs", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 358, null, "R144.157", "157.144", "", "Non réalisé", "", 0, 4, 1, null, 29, 16, null, "Examen périodique universal", "Continuer de renforcer la promotion des droits environnementaux par leur incorporation dans les plans de développement social et économique pour l’ensemble du Royaume", "الاستمرار في تعزيز الحقوق البيئية وذلك بإدراجها في خطط التنمية الاجتماعية والاقتصادية في جميع أنحاء المملكة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 357, null, "R144.84", "84.144", "", "Non réalisé", "", 0, 4, 1, null, 46, 16, null, "Examen périodique universal", "Renforcer l’intégration des droits environnementaux dans l’élaboration et la mise en œuvre des stratégies de développement", "زيادة تعميم مراعاة الحقوق البيئية في وضع الاستراتيجيات الإنمائية وتنفيذها", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 356, null, "R144.83", "83.144", "", "Non réalisé", "", 0, 4, 1, null, 25, 16, null, "Examen périodique universal", "Accélérer la mise en œuvre de la politique nationale sur les changements climatiques", "تسريع تنفيذ السياسة الوطنية المتعلقة بتغير المناخ", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 11, null, "R82", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 13, 1, "Procédure spéciale", "-   Prendre des mesures pour promouvoir une alimentation saine auprès des femmes et souligner les risques sanitaires associés au surpoids et à l’obésité", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 12, null, "R83", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 13, 1, "Procédure spéciale", "-   Sensibiliser la population aux meilleures pratiques d’allaitement et aider les femmes et leur famille à adopter les meilleures pratiques en ce qui concerne l’alimentation des nourrissons et des jeunes enfants", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 13, null, "R84", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 13, 1, "Procédure spéciale", "-   Mieux faire appliquer le Code international de commercialisation des substituts du lait maternel et créer un système de suivi indépendant.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 14, null, "R90P1", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 13, 1, "Procédure spéciale", "-   Faciliter, dans des conditions d’égalité, l’accès aux services de santé primaires, réduire la mortalité maternelle, juvénile et infantile et promouvoir de bonnes pratiques d’allaitement, conformément aux recommandations formulées par le Comité des droits de l’enfant", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 49, null, "R79P4", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 13, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’accès aux services de santé", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 92, null, "R88P8", "ت.88.ف.8", "", "Non réalisé", "", 0, 4, 1, null, null, 13, 3, "Procédure spéciale", "-    Investir dans les domaines de la psychiatrie et de la médecine légale ainsi que dans la formation spécialisée d’experts médico-légaux capables de se prononcer sur les cas de torture et de mauvais traitements, conformément aux normes internationales, notamment le Protocole d’Istanbul; de renforcer les moyens médicolégaux du parquet et des tribunaux;", "-          (ح) الاستثمار في الطب النفسي والطب الشرعي، وكذلك في تدريب خبراء الطب الشرعي على تقييم سوء المعاملة والتعذيب، تماشياً مع المعايير الدولية، مثل بروتوكول اسطنبول؛ وتدعيم قدرات الادعاء والقضاء في مجال الطب الشرعي؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 93, null, "R94P1", "ت.94.ف.1", "", "Non réalisé", "", 0, 4, 1, null, null, 13, 3, "Procédure spéciale", "-    Pour ce qui est des établissements psychiatriques, appliquer les dispositions des articles 3 et 4 du décret d’application de la loi (no 23/98) sur les prisons, notamment en ce qui concerne le non-recours à la violence contre les prisonniers, et d’interdire l’isolement cellulaire ;", "بخصوص المصحات النفسية، يوصي المقرر الخاص الحكومة بما يلي: ...(أ) تطبيق أحكام المادتين 3 و4 من المرسوم التنفيذي لقانون السجون (رقم 23/98)، لا سيما ما تعلق بالامتناع عن استخدام العنف في حق السجناء، وحظر الحبس الانفرادي؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 94, null, "R95P3", "ت.95.ف.3", "", "Non réalisé", "", 0, 4, 1, null, null, 13, 3, "Procédure spéciale", "-    Rattacher les services de santé destinés aux prisonniers au Ministère de la santé, ce qui devrait contribuer à des soins médicaux de meilleure qualité", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي:  (ج) اتباع الإدارات المعنية بالصحة في السجون لوزارة الصحة، الأمر الذي يُفترض أن يسهم في تقديم خدمات طبية فائقة الجودة؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 166, null, "R93P7", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 13, 6, "Procédure spéciale", "Assurer l’accès au droit à la santé, y compris aux services de santé sexuelle et reproductive et d’information", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 327, null, "R144.160", "160.144", "", "Non réalisé", "", 0, 4, 1, null, 15, 13, null, "Examen périodique universal", "Continuer de fournir une couverture médicale de base à sa population, notamment aux personnes âgées", "مواصلة توفير التغطية الطبية الأساسية لجميع سكانه بمن فيهم المسنون", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 328, null, "R144.163", "163.144", "", "Non réalisé", "", 0, 4, 1, null, 76, 13, null, "Examen périodique universal", "Améliorer l’accès aux services de santé dans les zones rurales, en particulier pour réduire la mortalité et la morbidité maternelles", "زيادة الفرص في الحصول على خدمات الرعاية الصحية في الأرياف لأهداف منها الحد من معدلات وفيات الأمهات واعتلالهن", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 329, null, "R144.164", "164.144", "", "Non réalisé", "", 0, 4, 1, null, 91, 13, null, "Examen périodique universal", "Continuer de promouvoir les soins et consultations prénatals pour réduire la nécessité du transport d’urgence au moment de l’accouchement et réduire ainsi le risque de décès chez les mères et les enfants", "زيادة تحسين خدمات الرعاية الصحية قبل الولادة واستشارات الطبيب للحد من ضرورة النقل العاجل عند المخاض ومن ثم الحد من خطر وفيات الأمهات والأطفال", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 499, null, "R11P3", "·          ت.11.ف.3", "", "Non réalisé", "", 0, 4, 1, 1, null, 13, null, "Organes de traités", "Prendre les mesures nécessaires pour s’assurer que des amazighs ne soient victimes d’aucune forme de discrimination raciale, notamment dans l’accès aux services de santé.", "اتخاذ التدابير اللازمة لضمان عدم تعرض الأمازيغ لأي شكل من أشكال التمييز العنصري، لا سيما وفي الحصول على الخدمات الصحية.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 15, null, "R95P1P3", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 14, 1, "Procédure spéciale", "Pour les provinces marocaines du sud :-  Veiller à ce que les ressources éducatives profitent à la population locale- Elaborer des programmes de formation technique à l’intention des Sahraouis", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 16, null, "R96P1", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 14, 1, "Procédure spéciale", "Pour les provinces marocaines du sud :- Suivre la mise en œuvre des programmes relatifs à l’éducation", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 326, null, "R144.236", "236.144", "", "Non réalisé", "", 0, 4, 1, null, 84, 12, null, "Examen périodique universal", "Garantir un accès plein et égal aux ressources socioéconomiques (y compris l’accès à l’enseignement supérieur et aux cours de langue traditionnelle) pour les populations amazighes et saharienne/sahraouie", "ضمان الوصول التام والمتساوي إلى الموارد الاجتماعية والاقتصادية (بما في ذلك الحصول على التعليم الجامعي وعلى دروس في اللغات التقليدية) للسكان الأمازيغ والصحراويين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 50, null, "R79P1", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 14, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’éducation", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 325, null, "R144.235", "235.144", "", "Non réalisé", "", 0, 4, 1, null, 60, 12, null, "Examen périodique universal", "Continuer d’adopter les mesures législatives et les politiques de protection nécessaires pour assurer l’éducation aux populations amazighes et sahraouies à tous les niveaux, ainsi que la pleine jouissance de leurs droits de manifester et de participer à la vie culturelle du pays, en préservant leurs traditions et leur identité", "مواصلة اعتماد تدابير تشريعية وسياسات الحماية الضرورية لكفالة التعليم للسكان الأمازيغ والصحراويين في جميع المستويات، إلى جانب التمتع الكامل بحقوقهم في التظاهر والمشاركة في الحياة الثقافية في البلد بما يحفظ تقاليدهم وهويتهم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 323, null, "R144.233", "233.144", "", "Non réalisé", "", 0, 4, 1, null, 16, 12, null, "Examen périodique universal", "Poursuivre les efforts visant à introduire l’enseignement de la langue et de la culture amazighe", "مواصلة جهوده لتوفير تعليم اللغة والثقافة الأمازيغيتين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 316, null, "R144.148", "148.144", "", "Non réalisé", "", 0, 4, 1, null, 68, 11, null, "Examen périodique universal", "Continuer de renforcer les programmes visant à réduire la pauvreté dans le cadre de l’Initiative nationale pour le développement humain", "مواصلة تقوية البرامج للحد من الفقر من خلال المبادرة الوطنية للتنمية البشرية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 317, null, "R144.149", "149.144", "", "Non réalisé", "", 0, 4, 1, null, 88, 11, null, "Examen périodique universal", "Partager avec d’autres pays son expérience dans le domaine du développement humain et de la réduction de la pauvreté", "تبادل تجربته مع غيره في مجال التنمية البشرية والحد من الفقر", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 318, null, "R144.150", "150.144", "", "Non réalisé", "", 0, 4, 1, null, 15, 11, null, "Examen périodique universal", "Continuer d’adopter des mesures visant à améliorer la vie des personnes vulnérables dans le pays", "مواصلة اعتماد تدابير لتحسين عيشة ضعاف الحال في البلد", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 319, null, "R144.151", "151.144", "", "Non réalisé", "", 0, 4, 1, null, 33, 11, null, "Examen périodique universal", "Assurer une répartition équitable des ressources entre les zones rurales et les zones urbaines", "ضمان التوزيع المنصف للموارد بين الأرياف والحواضر", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 320, null, "144.161", "161.144", "", "Non réalisé", "", 0, 4, 1, null, 25, 11, null, "Examen périodique universal", "Améliorer le système de protection sociale en vue d’étendre la couverture sociale et médicale à toute personne", "تحسين نظام الحماية الاجتماعية بهدف توسيع نطاق التغطية الاجتماعية والطبية لتشمل كل فرد", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 47, null, "R72", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 12, 2, "Procédure spéciale", "-       Recueillir au moyen d’indicateurs des données fiables et ventilées qui rendent fidèlement compte de la diversité raciale, culturelle et ethnique de la population marocaine, y compris de la diversité linguistique − dont témoignent bien les indicateurs qui mesurent l’utilisation de la langue orale et le degré d’alphabétisation", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 48, null, "R78P2", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 12, 2, "Procédure spéciale", "-       Prendre des mesures provisoires pour prévenir et atténuer toutes les formes de discrimination linguistique et culturelle dans tous les domaines.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 219, null, "R85", "ت.85", "", "Non réalisé", "", 0, 4, 1, null, null, 12, 8, "Procédure spéciale", "Envisager la diversité culturelle comme une ressource inestimable pour associer chacun à la vie du pays, et à prendre des mesures pour qu’il soit tenu compte de la diversité culturelle et du patrimoine culturel des diverses populations du pays, notamment en assurant la promotion de ces cultures par l’éducation, dans les médias et au moyen d’activités culturelles, en améliorant les compétences interculturelles de toutes les institutions officielles et en encourageant le bilinguisme dans la fonction publique.", "-    النظر إلى التنوع الثقافي كمورد لا يقدر بثمن لإدماج الجميع، واتخاذ تدابير لتعميم التنوع الثقافي والتراث الثقافي لسكان البلد المتنوعين عن طريق جملة أمور منها الترويج لهذه الثقافات من خلال التثقيف ووسائط الإعلام والأنشطة الثقافية، وتعزيز الكفاءات متعددة الثقافات لدى جميع المؤسسات الرسمية وتشجيع المهارات ثنائية اللغة في صفوف الموظفين الحكوميين.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 220, null, "R85", "ت.85", "", "Non réalisé", "", 0, 4, 1, null, null, 12, 8, "Procédure spéciale", "Envisager la diversité culturelle comme une ressource inestimable pour associer chacun à la vie du pays, et à prendre des mesures pour qu’il soit tenu compte de la diversité culturelle et du patrimoine culturel des diverses populations du pays, notamment en assurant la promotion de ces cultures par l’éducation, dans les médias et au moyen d’activités culturelles, en améliorant les compétences interculturelles de toutes les institutions officielles et en encourageant le bilinguisme dans la 21.", "-    النظر إلى التنوع الثقافي كمورد لا يقدر بثمن لإدماج الجميع، واتخاذ تدابير لتعميم التنوع الثقافي والتراث الثقافي لسكان البلد المتنوعين عن طريق جملة أمور منها الترويج لهذه الثقافات من خلال التثقيف ووسائط الإعلام والأنشطة الثقافية، وتعزيز الكفاءات متعددة الثقافات لدى جميع المؤسسات الرسمية وتشجيع المهارات ثنائية اللغة في صفوف الموظفين الحكوميين.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 221, null, "R86P1-2", "ت.86.ف.1ج2", "", "Non réalisé", "", 0, 4, 1, null, null, 12, 8, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en allouant des subventions aux artistes, théâtres et associations culturelles amazighs, y compris aux groupes d’artistes amazighs qui voyagent à l’étranger et représentent la culture marocaine", "(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:- تخصيص إعانات للفنانين الأمازيغ والمسارح والجمعيات الثقافية الأمازيغية، بما في ذلك الفنانون الأمازيغ ضمن الفرق التي تسافر إلى الخارج لتمثيل ثقافة المغرب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 222, null, "R86P3-2", "ت.86.ف.4ج2", "", "Non réalisé", "", 0, 4, 1, null, null, 12, 8, "Procédure spéciale", "Respecter le droit d’avoir accès au patrimoine culturel de sa propre communauté et à celui des autres et d’en jouir, y compris l’histoire des communautés, leurs figures emblématiques et leur patrimoine linguistique", "-    (ج) ..... ينبغي للمغرب أن يحترم حق الفرد في الوصول إلى التراث الثقافي لجماعته وللآخرين والتمتع به، بما فيه تاريخ المجتمعات المحلية وشخصياتها البارزة وتراثها اللغوي؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 223, null, "R86P6-1", "ت.86.ف.6ج1", "", "Non réalisé", "", 0, 4, 1, null, null, 12, 8, "Procédure spéciale", "Elaborer un plan national d’action pour le développement culturel qui garantisse effectivement l’expression de la diversité culturelle. En particulier, de promouvoir les valeurs positives de la diversité culturelle par l’éducation, dans les médias et au moyen de programmes spéciaux destinés aux personnes handicapées. À cette fin, des ressources adéquates devraient être consacrées à la mise en œuvre des stratégies, politiques et programmes aux niveaux central, régional et local.", "-    (و) وضع خطة عمل وطنية للتنمية الثقافية تضمن بشكل فعال إبراز التنوع الثقافي؛ وعلى الخصوص، ترويج القيم الإيجابية للتنوع الثقافي من خلال التعليم ووسائط الإعلام وبرامج خاصة للأشخاص ذوي الإعاقة. ولتحقيق هذا الهدف، ينبغي تخصيص موارد كافية لتنفيذ الاستراتيجيات والسياسات والبرامج المناسبة على الصعيد المركزي والإقليمي والمحلي.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 224, null, "R88P2P4", "ت.88.ف.2.ف.4", "", "Non réalisé", "", 0, 4, 1, null, null, 12, 8, "Procédure spéciale", "Procéder à des investissements pour entretenir les infrastructures et développer les maisons de la culture et des jeunes existantes - Créer les possibilités et les conditions voulues pour que les jeunes, les femmes et les personnes handicapées puissent contribuer à la vie culturelle de la société. Des mesures concertées sont nécessaires pour garantir le financement de projets pour les jeunes, comme le groupe des «filles cavalières» de Khemisset", "الاستثمار في صيانة الهياكل الأساسية ومواصلة تطوير المراكز الثقافية والشبابية القائمة؛- خلق فرص وظروف ملائمة للشباب والمرأة والأشخاص ذوي الإعاقة لكي يساهموا في الحياة الثقافية للمجتمع. ولا بد من تدابير تتضافر فيها الجهود من أجل ضمان الحصول على تمويل للمشاريع الخاصة بالشباب، مثل مشروع الفتيات الفارسات في مدينة الخميسات.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 321, null, "144.181", "181.144", "", "Non réalisé", "", 0, 4, 1, null, 29, 12, null, "Examen périodique universal", "Poursuivre les efforts de promotion des droits culturels par des programmes visant à protéger et revitaliser la diversité du patrimoine culturel constitutif de l’identité marocaine, y compris le patrimoine hassani dans les provinces du sud", "مواصلة الجهود لتعزيز الحقوق الثقافية عن طريق برامج لحماية وإنعاش تنوع التراث الثقافي الذي يشكل الهوية المغربية بما فيه التراث الحساني في الأقاليم الجنوبية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 322, null, "R144.232", "232.144", "", "Non réalisé", "", 0, 4, 1, null, 11, 12, null, "Examen périodique universal", "Poursuivre ses efforts appréciables en faveur du développement des langues nationales et promouvoir et protéger la langue et les patrimoines culturels amazighs", "مواصلة جهوده المحمودة باتجاه تطوير اللغات الوطنية وتعزيز وحماية اللغة والتراث الثقافي الأمازيغيين", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 324, null, "R144.234", "234.144", "", "Non réalisé", "", 0, 4, 1, null, 16, 12, null, "Examen périodique universal", "Poursuivre les efforts en vue de la promotion et de la préservation du patrimoine culturel saharo-hassani, tel que consacré dans la Constitution de 2011", "مواصلة الجهود باتجاه تعزيز التراث الثقافي الصحراوي الحسّاني والمحافظة عليه، مثلما هو مكرّس في دستور عام 2011", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 390, null, "R144.132", "132.144", "", "Non réalisé", "", 0, 6, 1, null, 21, 30, null, "Examen périodique universal", "Abolir la disposition empêchant les Marocaines de transmettre leur nationalité à leur mari étranger", "إلغاء النص القانوني الذي يمنع النساء المغربيات من نقل جنسيتهن إلى أزواجهن الأجانب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 167, null, "R93P8", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 14, 6, "Procédure spéciale", "Assurer l’accès à l’éducation pour les filles rurales, y compris par des mesures supplémentaires et efficaces pour faciliter leur participation dans l’enseignement primaire et secondaire.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 226, null, "R86P3-1", "ت.86.ف.4ج1", "", "Non réalisé", "", 0, 4, 1, null, null, 14, 8, "Procédure spéciale", "Abroger la circulaire no 122 du 7 janvier 2002 du Ministère de l’éducation nationale stipulant que le nom non arabe d’un certain nombre d’écoles doit être remplacé par un nom arabe, et d’abroger tout autre texte législatif ou réglementaire comparable", "-    (ج) إلغاء مذكرة وزارة التربية رقم 122 المؤرخة 7 كانون الثاني/ يناير 2002 التي تنص على تغيير الأسماء غير العربية لعدد من المدارس بأسماء عربية، وإلغاء أي تشريعات أخرى من هذا القبيل. ....", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 18, null, "R95P2P4", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 15, 1, "Procédure spéciale", "Pour les provinces marocaines du sud :- Etablir des mécanismes visant à réduire sensiblement le taux de chômage- Adopter des mesures qui incitent les employeurs à recruter des jeunes sans aucune discrimination.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 51, null, "R79P3", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 15, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’accès à l’emploi", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 346, null, "R144.142", "142.144", "", "Non réalisé", "", 0, 4, 1, null, 5, 15, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir et protéger les droits économiques et sociaux au moyen de stratégies de développement encourageant l’investissement et l’emploi", "مواصلة الجهود من أجل تعزيز وحماية الحقوق الاقتصادية والاجتماعية عن طريق تنفيذ استراتيجية إنمائية لتشجيع الاستثمار والعمالة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 347, null, "R144.152", "152.144", "", "Non réalisé", "", 0, 4, 1, null, 11, 15, null, "Examen périodique universal", "Poursuivre ses efforts louables pour réduire le taux de chômage élevé qui prévaut dans le pays", "مواصلة عمله الجيد على الحد من معدل البطالة المرتفع في البلد", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 348, null, "R144.154", "154.144", "", "Non réalisé", "", 0, 4, 1, null, 47, 15, null, "Examen périodique universal", "Renforcer les lois favorisant la réduction des taux de chômage et accroître les possibilités d’emploi  afin de contribuer à la réalisation d’un développement durable", "تجديد القوانين الرامية إلى الحد من معدلات البطالة وزيادة فرص العمل للمساهمة في تحقيق التنمية المستدامة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 349, null, "R144.154", "154.144", "", "Non réalisé", "", 0, 4, 1, null, 47, 15, null, "Examen périodique universal", "Renforcer les lois favorisant la réduction des taux de chômage et accroître les possibilités d’18 afin de contribuer à la réalisation d’un développement durable", "تجديد القوانين الرامية إلى الحد من معدلات البطالة وزيادة فرص العمل للمساهمة في تحقيق التنمية المستدامة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 350, null, "R144.155", "155.144", "", "Non réalisé", "", 0, 4, 1, null, 55, 15, null, "Examen périodique universal", "Poursuivre ses efforts pour réduire le taux de chômage chez les jeunes, notamment par le renforcement des programmes de formation professionnelle", "مواصلة الجهود لأجل الحد من معدلات البطالة في صفوف الشباب بوسائل منها تقوية برامج التدريب المهني", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 351, null, "R144.156", "156.144", "", "Non réalisé", "", 0, 4, 1, null, 69, 15, null, "Examen périodique universal", "Établir des dialogues visant à engager une coopération qui permettra l’application de pratiques optimales et de plans visant à réduire le chômage, le sous-emploi et le travail informel, et renforcer les politiques de création d’emplois et d’emploi  des jeunes", "إقامة حوارات للانخراط في التعاون الذي سيتيح تطبيق الممارسات والخطط الفضلى للحد من البطالة وقلة فرص العمل والعمل في القطاع غير النظامي، وتقوية السياسات الرامية إلى إنشاء فرص العمل وإلى عمالة الشباب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 352, null, "R144.158", "158.144", "", "Non réalisé", "", 0, 4, 1, null, 85, 15, null, "Examen périodique universal", "Continuer à mettre en œuvre des politiques et à développer des infrastructures permettant d’accroître l’accès à l’emploi , en particulier pour les jeunes", "مواصلة تنفيذ السياسات وتطوير الهياكل الأساسية التي تزيد من الفرص في الحصول على العمل خاصةً في صفوف الشباب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 501, null, "R11P2", "·          ت.11.ف.2", "", "Non réalisé", "", 0, 4, 1, 1, null, 15, null, "Organes de traités", "Prendre les mesures nécessaires pour s’assurer que des amazighs ne soient victimes d’aucune forme de discrimination raciale, notamment dans l’accès à l’emploi", "اتخاذ التدابير اللازمة لضمان عدم تعرض الأمازيغ لأي شكل من أشكال التمييز العنصري، لا سيما في التوظيف", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 168, null, "R93P3", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 16, 6, "Procédure spéciale", "Revoir l’Initiative nationale pour le développement humain afin de faire en sorte qu’elle tienne compte des questions de parité entre les sexes et mette à profit le rôle plus actif des femmes à tous les niveaux (national, régional et local) et à toutes les étapes (conception, exécution et évaluation)", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 244, null, "R73P2", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 16, 9, "Procédure spéciale", "Élaborer une politique générale nationale sur le développement humain qui tienne compte des droits de l’homme et se fonde sur les normes internationales en la matière, notamment l’égalité et la non-discrimination. - Intégrer dans tous les programmes et politiques de développement de tous les secteurs une démarche tenant compte de la problématique hommes-femmes.- Dans le cadre d’une approche du développement fondée sur les droits de l’homme, la planification et la mise en œuvre de mesures de développement doivent être mûrement réfléchies, ciblées et progressives afin d’instaurer des conditions favorables à l’exercice et à la réalisation des droits de l’homme", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 353, null, "R144.82", "82.144", "", "Non réalisé", "", 0, 4, 1, null, 5, 16, null, "Examen périodique universal", "Continuer à élaborer et à mettre en œuvre des programmes de développement et à améliorer les capacités économiques dans l’ensemble du pays, y compris dans les provinces du sud du Maroc", "مواصلة وضع وتنفيذ برامج إنمائية، وتحسين القدرات الاقتصادية للبلد ككل بما فيه الأقاليم الجنوبية للمغرب", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 354, null, "R 144.153", "153.144", "", "Non réalisé", "", 0, 4, 1, null, 19, 16, null, "Examen périodique universal", "Continuer à promouvoir le développement économique et social afin de relever le niveau de vie de la population régulièrement, dans le but de fournir une base solide à la jouissance de tous les droits de l’homme", "مواصلة تشجيع التنمية الاقتصادية والاجتماعية من أجل الرفع المطّرد من مستويات معيشة السكان وذلك لتزويدهم بأساس متين للتمتع بجميع حقوق الإنسان", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 355, null, "R144.81", "81.144", "", "Non réalisé", "", 0, 4, 1, null, 66, 16, null, "Examen périodique universal", "Poursuivre les efforts visant à réaliser les objectifs stratégiques nationaux pour le développement durable (2015-2020)", "مواصلة الجهود من أجل تحقيق الأهداف الوطنية الاستراتيجية للتنمية المستدامة (2015‑2020)", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 17, null, "R91", "null", "", "Non réalisé", "", 0, 4, 1, null, null, 15, 1, "Procédure spéciale", "Redoubler d’efforts pour réduire sensiblement le taux de chômage en ciblant les femmes et les jeunes, - Accroître le nombre de programmes de requalification et de 41 et technique, - Adopter des mesures visant à inciter les employeurs à créer des emplois et à recruter des femmes et des jeunes selon qu’il convient.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 225, null, "R86P1-3", "ت.86.ف.1ج3", "", "Non réalisé", "", 0, 4, 1, null, null, 14, 8, "Procédure spéciale", "- Renforcer l’appui à la promotion et à la préservation de la culture amazighe en réformant le secteur de l’éducation pour garantir l’utilisation de la langue amazighe dans tous les domaines, et faire figurer des manuels en langue amazighe dans la liste officielle des ouvrages distribués gratuitement dans toutes les écoles établie par le Ministère de l’éducation nationale", "(أ)  زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي: 3-إصلاح قطاع التعليم من أجل ضمان استخدام اللغة الأمازيغية في جميع المجالات التعليمية، وإدراج الكتب المدرسية المكتوبة باللغة الأمازيغية في القائمة الرسمية للكتب التي تعدها وزارة التربية لتوزيعها بالمجان في جميع المدارس؛", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 500, null, "R11P1P5", "·          ت.11.ف.1.ف.5", "", "Non réalisé", "", 0, 4, 1, 1, null, 14, null, "Organes de traités", "Intensifier ses efforts en vue de promouvoir la langue et la culture amazighes, notamment par leur enseignement et à assurer également l'alphabétisationdes amazighs dans cette langue", "·          -بذل المزيد من الجهود بغية تعزيز اللغة والثقافة الأمازيغيتين، لا سيما عن طريق تعليمهما", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 344, null, "R144.179", "179.144", "", "Non réalisé", "", 0, 4, 1, null, 13, 14, null, "Examen périodique universal", "Examiner et, le cas échéant, adapter les programmes scolaires et préscolaires et l’enseignement et les pratiques scolaires pour favoriser l’élimination de la discrimination fondée sur le sexe et des stéréotypes sexistes, ainsi que pour promouvoir l’autonomisation des filles à un âge précoce", "استعراض المناهج التعليمية وتكييفها عند الضرورة، وكذلك استعراض ممارسات التدريس والمدارس من أجل القضاء على التمييز القائم على نوع الجنس والقوالب النمطية القائمة على نوع الجنس إلى جانب تعزيز تمكين الفتيات منذ سن مبكرة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 227, null, "R86P4", "ت.86.ف.4", "", "Non réalisé", "", 0, 4, 1, null, null, 14, 8, "Procédure spéciale", "Réviser les manuels scolaires d’histoire et d’autres disciplines afin de refléter la diversité du pays, en veillant à une représentation adéquate de la diversité culturelle entre les auteurs, ainsi qu’au sein du comité indépendant chargé d’approuver les manuels. De plus, les programmes de formation des enseignants devraient comprendre des méthodologies reflétant la richesse de la diversité culturelle marocaine de la manière la plus interactive et novatrice possible", "-    (د) تنقيح مادة التاريخ وغيرها من المواد في الكتب المدرسية لتعبر عن التنوع الذي يزخر به البلد، مع ضمان تمثيل كافٍ للتنوع الثقافي بين المؤلفين، وكذلك في لجنة الاستعراض المستقلة التي توافق على الكتب المدرسية. وبالإضافة إلى ذلك، ينبغي أن تشمل برامج تدريب المدرسين منهجيات تعبر عن ثراء التنوع الثقافي المغربي بأكثر الأساليب تفاعلاً وابتكاراً.", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 330, null, "R144.162", "162.144", "", "Non réalisé", "", 0, 4, 1, null, 43, 14, null, "Examen périodique universal", "Comme suite aux recommandations issues du deuxième cycle figurant aux paragraphes 129.98, 129.102, 129.111, 129.116, 129.117 et 130.9 du document A/HRC/21/3, accroître les investissements dans l’enseignement public en vue d’augmenter les salaires des enseignants et de mettre en place des programmes de formation professionnelle et technique", "متابعة التوصيات المنبثقة عن الجولة الثانية والواردة في الوثيقة A/HRC/21/3 الفقرات 129-98 و129-102 و129-111 و129-116 و129-117 و130-9، وزيادة الاستثمارات في التعليم العام وذلك بزيادة مرتبات المدرسين واستحداث برامج تدريب مهني وفني", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 331, null, "R144.165", "165.144", "", "Non réalisé", "", 0, 4, 1, null, 100, 14, null, "Examen périodique universal", "Prendre de nouvelles mesures ciblées pour promouvoir l’éducation inclusive pour tous", "اتخاذ مزيد من التدابير المحددة الهدف بغية تعزيز التعليم الجامع", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 332, null, "R144.166", "166.144", "", "Non réalisé", "", 0, 4, 1, null, 16, 14, null, "Examen périodique universal", "Mettre en œuvre la vision stratégique pour la réforme de l’éducation sur la période 2015-2030 (16) ;", "تنفيذ الرؤية الاستراتيجية لإصلاح التعليم للفترة ما بين عامي 2015 و2030", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 333, null, "R144.168", "168.144", "", "Non réalisé", "", 0, 4, 1, null, 58, 14, null, "Examen périodique universal", "Continuer de renforcer le droit à l’éducation", "مواصلة تكريس الحق في التعليم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 334, null, "R144.169", "169.144", "", "Non réalisé", "", 0, 4, 1, null, 64, 14, null, "Examen périodique universal", "Mettre en place une stratégie ou un plan d’action pour lutter contre l’analphabétisme", "وضع استراتيجية أو خطة عمل لمكافحة الأمية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 335, null, "R144.170", "170.144", "", "Non réalisé", "", 0, 4, 1, null, 71, 14, null, "Examen périodique universal", "Envisager d’éliminer les différences en matière de scolarisation entre les villes et les zones rurales, entre filles et garçons et parmi les minorités", "النظر في القضاء على التفاوتات في التعليم ما بين الحواضر والأرياف وما بين الفتيات والفتيان وما بين الأقليات", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 336, null, "R144.171", "171.144", "", "Non réalisé", "", 0, 4, 1, null, 73, 14, null, "Examen périodique universal", "Mettre en œuvre des mesures visant à garantir l’éducation inclusive pour tous dans l’enseignement primaire, secondaire et universitaire", "تنفيذ تدابير لضمان حصول الجميع على التعليم في المراحل الابتدائية والثانوية والجامعية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 337, null, "R144.172", "172.144", "", "Non réalisé", "", 0, 4, 1, null, 79, 14, null, "Examen périodique universal", "Prendre des mesures supplémentaires dans le domaine de la promotion des droits économiques, sociaux et culturels, notamment dans le secteur de l’éducation, en mettant un accent particulier sur la scolarisation des filles et des garçons dans les zones rurales", "القيام بخطوات أخرى في مجال تعزيز الحقوق الاقتصادية والاجتماعية والثقافية وخاصة في قطاع التعليم مع التركيز بوجه خاص على تسجيل فتيات وفتيان الأرياف في المدارس", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 338, null, "R144.173", "173.144", "", "Non réalisé", "", 0, 4, 1, null, 5, 14, null, "Examen périodique universal", "Soutenir le droit à l’éducation en mettant en œuvre la vision stratégique pour réformer le système éducatif sur la période 2015-2030", "دعم الحق في التعليم عن طريق تنفيذ الرؤية الاستراتيجية لنظام التعليم للفترة ما بين عامي 2015 و2030", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 339, null, "R144.174", "174.144", "", "Non réalisé", "", 0, 4, 1, null, 88, 14, null, "Examen périodique universal", "Renforcer et appuyer la promotion de l’éducation des enfants économiquement vulnérables", "دعم تشجيع التعليم لفائدة الأطفال ضعيفي الحالة الاقتصادية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 340, null, "R144.175", "175.144", "", "Non réalisé", "", 0, 4, 1, null, 33, 14, null, "Examen périodique universal", "Poursuivre les efforts pour veiller à ce que tous les enfants soient inscrits à l’école élémentaire et étudier les mesures nécessaires pour toucher les enfants privés d’éducation", "مواصل�� الجهود لضمان تسجيل جميع الأطفال في المدرسة الابتدائية والنظر في اتخاذ التدابير الضرورية لمساعدة الأطفال المحرومين من التعليم", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 341, null, "R144.176", "176.144", "", "Non réalisé", "", 0, 4, 1, null, 87, 14, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir le droit à l’éducation en luttant contre le phénomène de l’abandon scolaire", "مواصلة الجهود من أجل تعزيز الحق في التعليم عن طريق مكافحة ظاهرة تسرب الأطفال من المدارس", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 342, null, "R144.177", "177.144", "", "Non réalisé", "", 0, 4, 1, null, 93, 14, null, "Examen périodique universal", "Poursuivre les efforts visant à réformer le système éducatif public et à améliorer la qualité de l’enseignement public pour instaurer l’égalité des chances entre les classes sociales", "مواصلة الجهود لإصلاح نظام التعليم العام وتحسين نوعية التعليم العام توخياً لتحقيق المساواة في الفرص بين الطبقات الاجتماعية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 343, null, "R144.178", "178.144", "", "Non réalisé", "", 0, 4, 1, null, 94, 14, null, "Examen périodique universal", "Intensifier les efforts pour s’assurer que tous les enfants dont scolarisés aux niveaux primaire et secondaire", "زيادة الجهود المبذولة لضمان تسجيل جميع الأطفال في المدارس في المرحلتين الابتدائية والثانوية", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 345, null, "R144.180", "180.144", "", "Non réalisé", "", 0, 4, 1, null, 29, 14, null, "Examen périodique universal", "Promouvoir des programmes qui encouragent l’éducation des enfants, notamment des filles dans les villages, et bénéficient aux groupes vulnérables", "النهوض بالبرامج التي تشجع تعليم الأطفال وخاصة الفتيات في القرى ولصالح الفئات الهشة", "", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 39, null, "R74", "null", "", "Non réalisé", "", 0, 1, 1, null, null, 1, 2, "Procédure spéciale", "Donner à toutes les personnes les moyens de faire valoir leurs droits, en garantissant à toutes les victimes de discrimination ou d’intolérance raciale et xénophobe un accès effectif à la justice et à des voies de recours adéquates. - Mieux faire connaître les voies de recours disponibles et en faciliter l’accès, notamment en supprimant les obstacles linguistiques et en fournissant des informations adéquates et accessibles sur les droits et les recours dont disposent les groupes et les personnes en situation de vulnérabilité.", "null", "", "" });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 397, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 398, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 398, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 399, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 399, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 400, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 400, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 401, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 401, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 401, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 402, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 397, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 402, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 403, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 404, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 404, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 405, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 405, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 406, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 406, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 407, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 407, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 408, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 408, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 403, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 397, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 396, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 396, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 384, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 385, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 385, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 386, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 386, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 387, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 387, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 388, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 388, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 389, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 390, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 390, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 390, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 390, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 391, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 392, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 392, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 392, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 393, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 393, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 394, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 394, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 395, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 395, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 396, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 408, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 409, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 409, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 409, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 412, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 413, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 413, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 414, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 414, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 415, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 415, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 416, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 416, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 417, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 417, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 417, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 418, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 419, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 420, 11, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 421, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 422, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 423, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 424, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 425, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 425, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 425, 27, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 425, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 426, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 426, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 412, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 384, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 411, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 411, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 504, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 504, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 504, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 110, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 110, 27, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 110, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 111, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 111, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 111, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 139, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 139, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 206, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 206, 27, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 206, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 206, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 206, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 207, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 207, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 410, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 410, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 411, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 383, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 383, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 382, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 363, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 364, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 365, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 365, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 365, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 365, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 366, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 101, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 102, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 103, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 103, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 103, 41, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 103, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 104, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 104, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 105, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 105, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 367, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 367, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 368, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 368, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 369, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 363, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 369, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 363, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 362, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 200, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 201, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 202, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 202, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 202, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 202, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 203, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 203, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 203, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 203, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 204, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 204, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 204, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 204, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 204, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 205, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 359, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 359, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 359, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 359, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 360, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 361, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 361, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 361, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 361, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 363, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 427, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 106, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 107, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 109, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 169, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 169, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 169, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 170, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 171, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 230, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 230, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 231, 24, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 374, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 374, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 375, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 376, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 376, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 376, 21, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 377, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 377, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 377, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 378, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 379, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 379, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 380, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 381, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 381, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 382, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 108, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 106, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 107, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 107, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 25, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 370, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 371, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 228, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 372, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 372, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 24, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 373, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 503, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 503, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 503, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 229, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 229, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 229, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 229, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 24, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 427, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 428, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 428, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 172, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 172, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 173, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 233, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 233, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 233, 36, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 234, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 235, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 235, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 236, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 236, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 236, 21, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 236, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 236, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 236, 36, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 237, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 237, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 238, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 240, 1, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 246, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 246, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 246, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 246, 21, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 246, 2, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 247, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 172, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 247, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 172, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 146, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 25, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 115, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 115, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 115, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 115, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 115, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 115, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 115, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 144, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 144, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 144, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 144, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 144, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 144, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 145, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 145, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 145, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 145, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 145, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 146, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 172, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 11, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 247, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 448, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 24, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 52, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 25, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 147, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 147, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 147, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 147, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 174, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 174, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 174, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 174, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 174, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 245, 1, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 245, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 245, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 452, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 452, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 508, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 508, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 508, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 508, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 509, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 509, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 247, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 448, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 448, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 449, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 449, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 449, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 449, 9, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 449, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 450, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 450, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 451, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 451, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 451, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 451, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 451, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 451, 9, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 451, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 507, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 200, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 112, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 112, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 113, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 113, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 114, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 140, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 140, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 208, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 208, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 208, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 208, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 209, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 209, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 209, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 209, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 210, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 210, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 210, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 210, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 440, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 11, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 440, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 429, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 430, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 430, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 431, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 431, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 432, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 432, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 432, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 232, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 433, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 434, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 435, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 436, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 437, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 438, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 439, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 441, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 441, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 445, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 445, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 446, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 446, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 446, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 447, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 447, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 447, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 47, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 445, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 441, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 143, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 143, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 441, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 441, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 442, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 442, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 442, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 442, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 442, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 443, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 443, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 443, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 443, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 443, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 444, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 444, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 505, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 505, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 505, 23, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 506, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 506, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 506, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 141, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 141, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 141, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 141, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 142, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 143, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 509, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 200, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 200, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 133, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 134, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 134, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 134, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 135, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 136, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 136, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 136, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 136, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 136, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 162, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 133, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 162, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 162, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 162, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 162, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 163, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 164, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 164, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 193, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 193, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 218, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 218, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 218, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 162, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 284, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 285, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 286, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 286, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 137, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 137, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 137, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 165, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 165, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 165, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 194, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 194, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 195, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 195, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 196, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 196, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 196, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 197, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 197, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 198, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 198, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 243, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 243, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 243, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 296, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 296, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 297, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 297, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 287, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 287, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 288, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 288, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 289, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 289, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 290, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 290, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 291, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 291, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 292, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 292, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 293, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 293, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 294, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 295, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 295, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 490, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 490, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 491, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 492, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 493, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 493, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 493, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 494, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 262, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 262, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 262, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 263, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 264, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 265, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 266, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 130, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 130, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 159, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 159, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 160, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 160, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 160, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 191, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 216, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 241, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 267, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 269, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 270, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 271, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 272, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 273, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 262, 38, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 274, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 262, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 261, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 188, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 189, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 189, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 255, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 255, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 256, 21, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 256, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 256, 2, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 256, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 257, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 190, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 258, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 259, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 259, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 259, 9, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 260, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 158, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 158, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 215, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 215, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 261, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 298, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 274, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 275, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 242, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 282, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 283, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 481, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 481, 1, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 481, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 482, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 482, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 483, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 484, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 485, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 486, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 487, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 488, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 489, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 489, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 242, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 275, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 217, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 192, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 276, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 277, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 479, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 479, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 480, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 278, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 279, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 280, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 281, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 15, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 131, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 131, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 131, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 132, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 132, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 132, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 132, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 161, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 192, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 299, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 300, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 300, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 341, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 342, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 343, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 344, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 345, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 500, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 500, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 41, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 1, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 21, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 346, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 346, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 346, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 347, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 347, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 347, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 348, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 349, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 349, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 340, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 349, 1, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 339, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 338, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 328, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 329, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 499, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 41, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 167, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 225, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 226, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 227, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 330, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 330, 41, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 330, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 331, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 332, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 332, 41, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 332, 42, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 333, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 334, 43, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 334, 24, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 335, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 336, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 336, 42, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 337, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 338, 44, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 327, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 350, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 351, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 23, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 53, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 199, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 199, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 199, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 199, 14, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 199, 22, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 502, 19, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 350, 41, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 502, 34, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 502, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 351, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 351, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 352, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 352, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 352, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 501, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 168, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 244, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 244, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 244, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 244, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 244, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 353, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 353, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 353, 45, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 354, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 354, 8, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 354, 45, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 355, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 356, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 357, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 358, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 502, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 502, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 502, 47, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 502, 20, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 200, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 166, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 47, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 46, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 138, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 138, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 138, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 310, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 310, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 498, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 300, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 301, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 301, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 301, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 302, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 302, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 303, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 304, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 304, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 304, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 305, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 305, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 305, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 306, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 306, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 306, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 307, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 308, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 309, 3, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 309, 29, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 495, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 496, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 496, 6, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 497, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 498, 28, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 498, 32, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 13, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 310, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 312, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 221, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 222, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 223, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 223, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 223, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 223, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 224, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 224, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 321, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 321, 36, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 322, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 322, 36, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 323, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 323, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 323, 36, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 324, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 325, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 326, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 221, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 311, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 220, 21, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 219, 40, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 312, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 312, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 312, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 313, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 313, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 313, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 314, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 314, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 314, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 315, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 315, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 315, 39, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 315, 12, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 316, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 317, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 317, 26, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 318, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 319, 17, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 320, 18, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 320, 33, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 1, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 7, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 219, 10, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 219, 5, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 509, 4, new DateTime(2020, 9, 13, 15, 19, 8, 124, DateTimeKind.Local).AddTicks(8046) });

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
