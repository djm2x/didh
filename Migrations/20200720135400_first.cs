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
                    TitleAr = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DescriptionAr = table.Column<string>(nullable: true),
                    Categorie = table.Column<string>(nullable: true),
                    CategorieAr = table.Column<string>(nullable: true),
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
                    LibelleAr = table.Column<string>(nullable: true),
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
                    ThemeAr = table.Column<string>(nullable: true),
                    SousTheme = table.Column<string>(nullable: true),
                    SousThemeAr = table.Column<string>(nullable: true),
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
                    NomAr = table.Column<string>(nullable: true),
                    Discours = table.Column<string>(nullable: true),
                    ConventionPiece = table.Column<string>(nullable: true),
                    MiseOeuvrePiece = table.Column<string>(nullable: true),
                    ObservationPiece = table.Column<string>(nullable: true),
                    AnalytiquePiece = table.Column<string>(nullable: true),
                    RapportParallelePiece = table.Column<string>(nullable: true),
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
                    DiscoursAr = table.Column<string>(nullable: true),
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
                    TitreAr = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: false),
                    ReferenceAr = table.Column<string>(nullable: true),
                    DateDernierRapport = table.Column<DateTime>(nullable: false),
                    DateObservation = table.Column<DateTime>(nullable: false),
                    DateProchaineRapport = table.Column<DateTime>(nullable: false),
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
                    MecanismeAr = table.Column<string>(nullable: true),
                    IdCycle = table.Column<int>(nullable: true),
                    IdAxe = table.Column<int>(nullable: false),
                    IdSousAxe = table.Column<int>(nullable: false),
                    IdOrgane = table.Column<int>(nullable: true),
                    IdVisite = table.Column<int>(nullable: true),
                    IdPays = table.Column<int>(nullable: true),
                    Etat = table.Column<string>(nullable: false),
                    EtatAr = table.Column<string>(nullable: true),
                    EtatAvancement = table.Column<string>(nullable: true),
                    EtatAvancementAr = table.Column<string>(nullable: true),
                    EtatAvancementChiffre = table.Column<int>(nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    ObservationAr = table.Column<string>(nullable: true),
                    Complement = table.Column<string>(nullable: true),
                    ComplementAr = table.Column<string>(nullable: true),
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
                    CodeAr = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: false),
                    DetailAr = table.Column<string>(nullable: true),
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
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 10, "Categorie 1", "الفئة 1", new DateTime(2020, 1, 28, 14, 10, 4, 95, DateTimeKind.Local).AddTicks(1901), "Eveniet tempore labore praesentium magnam. Vel rerum in eos id. Aperiam minus magni et placeat. Rem ut quo et aperiam laboriosam sunt omnis molestiae. Ut fuga officiis commodi quae assumenda sunt. Similique a aliquid. Molestiae sint cupiditate impedit aut. Quia cum at quod maxime dicta voluptates reprehenderit atque reiciendis. Ut quis quos in numquam ut omnis doloribus. Enim ut nesciunt magni. Autem laudantium ratione. Sint qui voluptas commodi consectetur odio magnam maxime id debitis.", "مجموعة رقائق دليل أخرى إصدار عن يقرأها منذ. أيضاً مايكر والتي إصدار بمعنى الأصلي. مرة استخدام مقاطع هناك انه ستينيّات مع بشكل. المعيار بمعنى ودور انه ولذلك الفقرات الشكلي. مرة تعطي كبير هناك الزمن منذ ليتراسيت القرن بايج. مرة ليتراسيت مقاطع ليتراسيت مرجع والتي هو. يقرأها النشر برامج المعيار مايكر هو بمعنى في قرون وهي. حوت هذا القارئ الأصلي يتم ولذلك الغاية طريقة طريقة. أيضاً هو الإلكتروني نسخ. يقرأها ألدوس الصفحة. مؤخراَ لم هذا تعطي لأنها شكلي وليس.", "vel", "مثبتة" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 9, "Categorie 1", "الفئة 1", new DateTime(2019, 8, 24, 22, 36, 36, 867, DateTimeKind.Local).AddTicks(4054), "Necessitatibus optio sit nam numquam inventore ipsam. Porro illo eum eum. Eius animi soluta quasi magni omnis autem earum ut nam. Reprehenderit nesciunt laboriosam quis et optio voluptatem maxime vel. Magnam maiores repudiandae eos quo illum. Cum et dolore aperiam. Voluptas rerum recusandae ea harum id itaque provident distinctio et. Perspiciatis ad illo. Earum iste voluptatem doloremque dicta consequatur perspiciatis ut. Assumenda non exercitationem minus animi voluptatem ipsum. Facere nihil reprehenderit qui odio tempora.", "القارئ حوت ليتراسيت استخدام أو إصدار مثبتة وليس قامت. شكلي القرن استخدام. الخامس تعطي عشوائي وعاد لم على الشكلي يقرأها خمسة حتى. زمن القارئ أخرى عشوائي مستخدماً أخذتها طريقة. برص النشر وهي أو أخرى خمسة تحوي الأصلي. بمثابة المطابع في الشكلي وهي النص كان لم. إصدار وعاد سيلهي. التي كتيّب ويُستخدم لتكوّن إصدار حوت ويُستخدم. أيضاً زمن الشكل انه مؤخراَ وهي لم ليتراسيت مرة. طويل يقرأها ستينيّات مع. بمثابة قرون توزيعاَ لهذه صار.", "corrupti", "أن" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 8, "Categorie 1", "الفئة 1", new DateTime(2019, 9, 6, 19, 40, 27, 254, DateTimeKind.Local).AddTicks(5881), "Sit quia dolor nihil. Et est rerum aut corporis ipsum. Molestiae alias vel tempore. Quia suscipit autem ea architecto eos voluptas. Possimus non quasi enim quis voluptatem eligendi. Enim odit vero quis. Laboriosam tenetur quos adipisci quis fuga inventore cupiditate. Non nisi sit. Ea porro nostrum eum. Aperiam perferendis debitis est reiciendis et sit est ipsa deleniti. Nesciunt saepe cupiditate ullam molestiae voluptatibus vel rerum quia temporibus. Nihil sit distinctio ea est consequuntur qui.", "على كان لصفحة بمثابة مثبتة مرة تعطي ما التركيز كبير. مع مع ولذلك وعاد لصفحة شكل القرن. لتكوّن قرون مقاطع ودور الطباعة بشكل. ببساطة مع يقرأها الشكلي مع المعيار مستخدماً هو مايكر. ألدوس يتم ودور أخذتها خمسة شكلي كتيّب الخامس. في تقضي مايكر هناك الفقرات عندما يقرأها على وعاد الأصلي. إيبسوم الأحرف شكلي التي مقاطع قرون الصفحة أخرى تعطي. هي كبير القرن الفقرات في يتم. الشكل ولذلك بمثابة. يقرأها رقائق المعيار لم الأحرف. هو طريقة مرة حوت عن مستخدماً الفقرات بايج قرون. عشر ألدوس طبيعياَ المطابع ظهور عندما الطباعة شكلي الخارجي وبشكله. مثبتة من التركيز بمثابة ألدوس كان والتنضيد الشكل ألدوس.", "ab", "عن" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 7, "Categorie 1", "الفئة 1", new DateTime(2019, 10, 28, 0, 22, 16, 59, DateTimeKind.Local).AddTicks(6921), "Et nostrum cum corporis ducimus temporibus aut dolores sit repudiandae. Laudantium sunt ea tempora ea assumenda officia dolor officia. Quia sit dolores sit autem architecto unde. Velit beatae iusto sint officiis amet non. Velit omnis rerum ut ut quas officia. Error quia dolores amet dignissimos expedita ipsum voluptas. In maxime ad. Veniam expedita quo suscipit. Illum quo quia hic cumque quia ullam. Ex eaque saepe aliquid quis illum et dolor. Libero culpa ea dicta perspiciatis voluptates. Dignissimos voluptatum dignissimos et molestiae consequuntur eveniet.", "برامج أيضاً لهذه تحوي لم عشوائي شكل مثل. صناعات يتم مايكر المحتوى يقرأها. قرون ما توزيعاَ صناعات تعطي الأصلي برص يقرأها والتي. الخامس والتي لينتشر عشوائي الخامس المطابع مايكر. مرة صناعات ظهور لهذه سيلهي عندما. انه لهذه عندما حقيقة لينتشر. دليل الأصلي وهي هو من الصفحة نص يقرأها. قرون لصفحة أخرى. للنص رقائق عندما. الغاية طبيعياَ الخامس برص النص. كان إيبسوم طبيعياَ حوت الخارجي مستخدماً في ببساطة ودور. مثبتة عن القرن. من يقرأها الخامس برامج الأصلي الطباعة مايكر عن والتي.", "dolorum", "ولايزال" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 6, "Categorie 1", "الفئة 1", new DateTime(2019, 10, 17, 3, 46, 13, 414, DateTimeKind.Local).AddTicks(567), "Illum quibusdam et exercitationem. Aut ea sint perspiciatis. Voluptatem ullam quo perspiciatis ipsam quos. Provident ipsum corporis qui. Eos odio voluptatum consequuntur. Quia nisi vel nostrum sed dignissimos mollitia aut temporibus. Beatae sit maiores ipsa maxime voluptatem aut explicabo odio. Sapiente eum enim dolorem commodi a non perspiciatis. Distinctio quia qui repellat illo vitae sunt. Aspernatur laborum at fugit. Non rerum explicabo aliquid amet quaerat. Illo aliquam ut aperiam praesentium accusamus itaque aperiam omnis. Culpa sint illo dolores consequuntur cum aliquam sit recusandae sapiente.", "حتى إصدار انتشر الطباعة عن مؤخراَ والتي إيبسوم حقيقة. ألدوس كبير قرون ما زمن. المعيار المطابع والتنضيد البلاستيكية كان ببساطة ولذلك. ولذلك خمسة طريقة. كان قامت من أخرى الغاية انه التركيز هذا الصفحة. هي دليل المقروء الصفحة وهي. كتيّب ولذلك مايكر سيلهي بل لينتشر أيضاً لصفحة. أو البلاستيكية هذا لينتشر حتى إصدار النص ألدوس. القارئ الأصلي لأنها شكلي صار ولذلك طريقة لتكوّن مقاطع ما. ولايزال طويل قامت. مجموعة بايج طبيعياَ ظهور. أو الطباعة مستخدماً. ببساطة مثل عن الزمن وهي لم.", "consequuntur", "ولايزال" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 4, "Categorie 1", "الفئة 1", new DateTime(2019, 9, 1, 14, 31, 40, 484, DateTimeKind.Local).AddTicks(6000), "Earum nam enim sapiente totam magnam velit quis aut. Omnis est fugit distinctio excepturi similique explicabo. Autem sunt at. Fugit officia aut autem dolores fuga sit vel soluta earum. Deleniti officia aut modi. Voluptate quia nemo ad amet. Fugiat corrupti quis minus quidem. Consequatur velit fuga quos repellat voluptatem. Quisquam at explicabo facere repellendus eaque molestiae. Quo sunt quidem architecto in ut consequatur tempore et voluptatem.", "نسخ تحوي الشكل هناك توزيعاَ استخدام ستينيّات حتى بشكل. حتى ستينيّات كبير مستخدماً تقضي بشكل لم الأصلي. هناك مرجع طبيعياَ التي. مرة عشر نص لوريم الطباعة إيبسوم الخامس الزمن. والتي طريقة عشر لوريم توزيعاَ. الشكل عن على الطباعة عن ودور وبشكله سيلهي سيلهي. بمثابة للنص أيضاً كتيّب لأنها تقضي. ألدوس على المحتوى أيضاً الصفحة ستينيّات استخدام الأحرف حتى. مجهولة لصفحة الإلكتروني. بشكل تقضي مايكر المطابع. يتم انه أن مستخدماً ودور خمسة للنص تحوي ولايزال المقروء. الغاية عشوائي الأحرف الشكلي والتنضيد كبير.", "quam", "مع" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 3, "Categorie 1", "الفئة 1", new DateTime(2020, 4, 8, 21, 13, 58, 361, DateTimeKind.Local).AddTicks(1514), "Id at expedita quia ex repellat sapiente unde at. Placeat excepturi quam in officiis. Eius modi velit deleniti mollitia rerum nisi ea. Vel sit doloremque facere corrupti quod labore odio dignissimos dicta. Doloribus excepturi velit est saepe a unde illum tempore. Qui accusantium numquam non accusamus aliquam. Ducimus quaerat autem excepturi ullam quis perspiciatis vel. Quibusdam consequatur fuga excepturi quasi aut corrupti beatae soluta nihil. Quidem qui quidem qui cupiditate est cupiditate esse nesciunt. Tempora dolorum atque deserunt doloribus amet exercitationem veniam eligendi. Accusamus sapiente sapiente nesciunt. Consectetur neque quia nihil. Eos nulla neque ducimus aut et dolorum.", "هناك في مرة ويُستخدم مع أيضاً المطابع. هي مثبتة للنص زمن توزيعاَ حتى ولذلك ظهور تحوي انه. لتكوّن الطباعة الشكلي طبيعياَ. مؤخراَ مرجع النص نص مع في ستينيّات. من هي بل حوت الأحرف سيلهي إصدار على بمعنى عندما. وعاد بمثابة كتيّب القارئ. وبشكله لتكوّن عندما المطابع المعيار مرة الشكل كبير. نص على للنص مجموعة. لتكوّن طريقة القرن. مستخدماً الصفحة هو الشكلي أو. توضع حقيقة مجموعة برص طريقة بمثابة مجهولة أخذتها الطباعة. والتنضيد عندما الخارجي لم بايج لينتشر طبيعياَ الفقرات البلاستيكية. خمسة خمسة ودور استخدام الفقرات.", "inventore", "خمسة" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 2, "Categorie 1", "الفئة 1", new DateTime(2020, 1, 28, 0, 23, 4, 703, DateTimeKind.Local).AddTicks(1064), "Deleniti impedit et molestiae cumque temporibus. Sit consectetur adipisci dolorem ut dolor. Et sed omnis voluptas quo iste eos nemo alias. Ut consequatur nam. Ea voluptas nesciunt odit cum minima atque voluptatem. Quasi quidem vero voluptatem. Ipsa voluptas voluptatem. Nam explicabo eveniet reprehenderit corporis saepe sint dolorem enim quia. Repellendus iure saepe quia placeat aut eos aperiam. Nostrum quas nemo. Molestiae nihil quia reiciendis. Inventore ut tempore optio rerum qui similique.", "مجهولة إصدار وبشكله. بشكل كبير قرون ظهور حوت حوت مجهولة المحتوى المعيار من. البلاستيكية النشر زمن والتي بل. برامج الإلكتروني مقاطع قامت الصفحة ببساطة الشكل. أيضاً انتشر ولذلك لوريم ما هناك انه مثبتة. لوريم البلاستيكية الأصلي هو بل عندما مطبعة. هي مرجع على ببساطة تعطي مثبتة هي مستخدماً تقضي إصدار. الخارجي بايج خمسة. عشوائي ولذلك توزيعاَ المعيار لتكوّن وليس كتيّب. مثبتة لصفحة مقاطع مثبتة ويُستخدم استخدام مع. من دليل من لصفحة. لينتشر بايج هناك حقيقة عن وبشكله قرون المعيار. الصفحة المقروء ليتراسيت الشكل الشكلي الشكل.", "aliquid", "وهي" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 1, "Categorie 1", "الفئة 1", new DateTime(2019, 10, 26, 3, 23, 42, 203, DateTimeKind.Local).AddTicks(6287), "Eum nemo voluptatem delectus mollitia molestiae perferendis omnis. Omnis consequuntur aliquid velit beatae vitae. Dignissimos aspernatur odit dolor laborum nihil et. Numquam ducimus quae. Rerum esse iure qui aspernatur excepturi eius amet. Repudiandae accusamus commodi in quia ipsam qui. Eius exercitationem soluta molestias doloremque assumenda sit. Suscipit accusantium sapiente eum enim facere. Vel quis repudiandae voluptatibus. Ut aliquam nobis vero. Sint non incidunt quod id ea odit rem voluptatum asperiores. Commodi eos laborum est.", "صار مطبعة وهي من النشر مايكر توزيعاَ الشكلي من. من توزيعاَ طريقة البلاستيكية لصفحة. المحتوى عشر استخدام لينتشر والتي تحوي القارئ. ما نسخ طبيعياَ هو عشر الأحرف لتكوّن استخدام كتيّب صار. رقائق الشكل مقاطع أو. نسخ خمسة المحتوى حقيقة ولايزال حتى ببساطة. والتنضيد الطباعة مستخدماً قرون قامت انتشر نص. قرون توضع النص قرون والتي طريقة لأنها طبيعياَ طبيعياَ. لينتشر انه قرون الخامس الطباعة. التركيز هذا شكل أخذتها وبشكله هي.", "corrupti", "منذ" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "CategorieAr", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[] { 5, "Categorie 1", "الفئة 1", new DateTime(2019, 8, 27, 10, 12, 37, 655, DateTimeKind.Local).AddTicks(4966), "Corrupti eius quis dicta labore. Nemo sit ipsa. Voluptatem velit quasi quos quis rerum earum a ex. Rerum omnis atque consequatur doloribus rerum non laboriosam. Placeat omnis tempore ut id qui aliquam est. Voluptates iure rerum odio magni inventore. Officiis aliquam aut repudiandae necessitatibus dolorum. Optio qui aliquid impedit minus consequatur explicabo nostrum deleniti delectus. Exercitationem quia aliquid incidunt laudantium ipsa doloremque. Provident quae ut quo quas est nihil unde sed eligendi.", "في مقاطع تعطي الأصلي قامت حوت الطباعة عشوائي بشكل. الفقرات التي يقرأها ما القارئ المحتوى لينتشر. هناك شكل ولذلك الشكل الخارجي والتي تحوي القارئ بمعنى. المقروء تعطي رقائق نسخ الإلكتروني. كان مع مرجع بايج منذ من وبشكله مقاطع. تقضي أن التي مع. ستينيّات على انه الفقرات طريقة الإلكتروني سيلهي نص أيضاً. الفقرات قرون ظهور منذ. لتكوّن هو ودور مرجع للنص أخرى مجهولة. يقرأها إصدار بل أو بشكل التركيز هذا أخرى. مجهولة عندما حوت مرجع وبشكله مثل طويل طبيعياَ.", "ab", "مايكر" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "LibelleAr", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 5, "", "", "مراجعة-6", null, "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "LibelleAr", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 6, "", "", "مراجعة-7", null, "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "LibelleAr", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 4, "", "", "مراجعة-5", null, "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "LibelleAr", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 1, "", "", "مراجعة-2", null, "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "LibelleAr", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 2, "", "", "مراجعة-3", null, "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "LibelleAr", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 3, "", "", "مراجعة-4", null, "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 73, new DateTime(2020, 5, 24, 9, 35, 0, 798, DateTimeKind.Local).AddTicks(950), "0,3,6", 73, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2020, 7, 15, 15, 34, 52, 542, DateTimeKind.Local).AddTicks(2629), "1,3,6", 72, 3, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2020, 5, 16, 18, 7, 26, 888, DateTimeKind.Local).AddTicks(2655), "0,3,5", 71, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2019, 10, 12, 11, 46, 12, 121, DateTimeKind.Local).AddTicks(1171), "0,2,4", 70, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2020, 4, 12, 2, 1, 48, 46, DateTimeKind.Local).AddTicks(1094), "0,3,4", 69, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2019, 11, 25, 11, 53, 4, 312, DateTimeKind.Local).AddTicks(8814), "1,3,4", 68, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2020, 2, 16, 6, 20, 21, 736, DateTimeKind.Local).AddTicks(3354), "1,3,5", 67, 3, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2020, 6, 20, 3, 11, 44, 846, DateTimeKind.Local).AddTicks(3932), "1,2,4", 66, 3, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2020, 2, 25, 1, 0, 59, 168, DateTimeKind.Local).AddTicks(812), "0,3,5", 65, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2019, 12, 5, 14, 10, 26, 968, DateTimeKind.Local).AddTicks(3064), "1,2,5", 64, 2, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2020, 6, 16, 11, 24, 35, 919, DateTimeKind.Local).AddTicks(7192), "0,3,4", 63, 4, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2020, 6, 25, 6, 45, 14, 389, DateTimeKind.Local).AddTicks(7402), "1,3,5", 61, 1, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2019, 11, 4, 4, 46, 2, 328, DateTimeKind.Local).AddTicks(8290), "0,3,5", 60, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2020, 1, 26, 23, 34, 11, 807, DateTimeKind.Local).AddTicks(7327), "1,2,4", 59, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2020, 6, 17, 9, 54, 53, 655, DateTimeKind.Local).AddTicks(5545), "1,2,6", 58, 4, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2020, 5, 10, 5, 4, 0, 152, DateTimeKind.Local).AddTicks(2240), "0,3,4", 57, 3, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2020, 4, 20, 5, 23, 47, 884, DateTimeKind.Local).AddTicks(9065), "0,2,4", 56, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2019, 10, 27, 19, 42, 50, 402, DateTimeKind.Local).AddTicks(3007), "0,2,5", 55, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2020, 6, 6, 12, 34, 22, 162, DateTimeKind.Local).AddTicks(2076), "0,3,6", 54, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2020, 6, 29, 6, 19, 47, 628, DateTimeKind.Local).AddTicks(9778), "1,2,6", 53, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2019, 9, 22, 2, 17, 31, 316, DateTimeKind.Local).AddTicks(2838), "0,3,4", 74, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2019, 9, 26, 7, 10, 47, 690, DateTimeKind.Local).AddTicks(4191), "0,2,6", 62, 4, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2020, 1, 18, 19, 23, 37, 694, DateTimeKind.Local).AddTicks(1041), "1,3,5", 75, 6, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2019, 12, 29, 3, 23, 55, 569, DateTimeKind.Local).AddTicks(8440), "0,3,4", 93, 3, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2019, 8, 22, 13, 13, 29, 560, DateTimeKind.Local).AddTicks(5640), "0,3,5", 77, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2020, 4, 30, 19, 18, 15, 889, DateTimeKind.Local).AddTicks(4818), "0,3,4", 100, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2020, 7, 14, 6, 34, 46, 406, DateTimeKind.Local).AddTicks(56), "0,3,5", 99, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2020, 1, 22, 16, 20, 6, 453, DateTimeKind.Local).AddTicks(640), "0,3,6", 98, 6, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2020, 4, 10, 23, 46, 50, 745, DateTimeKind.Local).AddTicks(5455), "0,3,5", 97, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2020, 1, 26, 7, 39, 53, 829, DateTimeKind.Local).AddTicks(6653), "0,2,5", 96, 6, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2020, 3, 23, 21, 0, 44, 96, DateTimeKind.Local).AddTicks(8792), "0,2,4", 95, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2019, 12, 1, 23, 30, 47, 683, DateTimeKind.Local).AddTicks(4904), "1,2,5", 94, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2020, 2, 5, 15, 27, 31, 356, DateTimeKind.Local).AddTicks(8714), "1,3,4", 52, 2, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2020, 7, 18, 22, 16, 17, 420, DateTimeKind.Local).AddTicks(8660), "0,3,6", 92, 4, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2020, 1, 12, 21, 29, 39, 531, DateTimeKind.Local).AddTicks(9543), "1,2,5", 91, 6, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2019, 8, 10, 14, 48, 53, 279, DateTimeKind.Local).AddTicks(1863), "1,2,4", 76, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2020, 2, 18, 0, 8, 11, 361, DateTimeKind.Local).AddTicks(5944), "1,3,4", 90, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2020, 3, 14, 22, 44, 57, 780, DateTimeKind.Local).AddTicks(3841), "0,2,6", 88, 1, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2019, 9, 17, 2, 35, 5, 992, DateTimeKind.Local).AddTicks(7558), "0,2,5", 87, 1, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2019, 9, 10, 10, 19, 48, 468, DateTimeKind.Local).AddTicks(2449), "1,3,5", 86, 1, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2020, 6, 1, 5, 15, 9, 661, DateTimeKind.Local).AddTicks(6054), "0,2,4", 85, 6, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2019, 7, 27, 19, 39, 21, 576, DateTimeKind.Local).AddTicks(3130), "1,2,6", 83, 2, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2019, 11, 20, 3, 24, 28, 594, DateTimeKind.Local).AddTicks(146), "1,3,6", 82, 4, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2020, 1, 24, 16, 34, 13, 890, DateTimeKind.Local).AddTicks(9465), "0,2,4", 81, 3, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2020, 7, 17, 7, 11, 57, 87, DateTimeKind.Local).AddTicks(2757), "0,3,4", 80, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2019, 8, 22, 9, 50, 14, 250, DateTimeKind.Local).AddTicks(4898), "0,2,5", 79, 6, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2019, 8, 27, 10, 46, 1, 77, DateTimeKind.Local).AddTicks(5172), "1,3,6", 78, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2019, 8, 3, 20, 47, 6, 803, DateTimeKind.Local).AddTicks(2470), "0,3,4", 89, 6, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2019, 9, 7, 7, 41, 23, 990, DateTimeKind.Local).AddTicks(4269), "0,3,5", 51, 5, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2020, 6, 11, 11, 55, 20, 168, DateTimeKind.Local).AddTicks(2735), "1,2,4", 84, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2020, 5, 22, 13, 2, 36, 471, DateTimeKind.Local).AddTicks(2907), "1,2,6", 49, 4, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2020, 2, 4, 12, 31, 18, 875, DateTimeKind.Local).AddTicks(8463), "0,2,4", 22, 3, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2020, 6, 21, 18, 56, 50, 438, DateTimeKind.Local).AddTicks(2572), "0,2,4", 21, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2019, 8, 6, 4, 52, 2, 396, DateTimeKind.Local).AddTicks(2875), "1,2,4", 20, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2020, 1, 9, 16, 15, 7, 713, DateTimeKind.Local).AddTicks(6473), "1,3,4", 19, 6, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2020, 1, 13, 15, 6, 11, 448, DateTimeKind.Local).AddTicks(1679), "1,2,4", 18, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2020, 1, 11, 19, 42, 30, 581, DateTimeKind.Local).AddTicks(2602), "1,2,6", 17, 1, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2020, 5, 1, 9, 56, 4, 704, DateTimeKind.Local).AddTicks(3756), "1,2,5", 15, 6, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2020, 4, 7, 1, 14, 13, 928, DateTimeKind.Local).AddTicks(3839), "0,2,6", 14, 6, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2019, 10, 1, 21, 11, 46, 391, DateTimeKind.Local).AddTicks(4289), "0,3,4", 13, 1, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2019, 8, 16, 18, 46, 29, 752, DateTimeKind.Local).AddTicks(8034), "0,3,6", 12, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 4, 14, 3, 29, 36, 940, DateTimeKind.Local).AddTicks(1970), "0,2,6", 23, 5, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2020, 4, 22, 4, 19, 33, 157, DateTimeKind.Local).AddTicks(5081), "0,2,6", 11, 1, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2020, 3, 8, 8, 14, 21, 638, DateTimeKind.Local).AddTicks(6061), "1,2,5", 9, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2019, 12, 6, 2, 39, 2, 795, DateTimeKind.Local).AddTicks(2754), "0,3,5", 8, 6, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2019, 10, 28, 10, 0, 52, 620, DateTimeKind.Local).AddTicks(9572), "0,2,5", 7, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2020, 3, 4, 9, 4, 29, 369, DateTimeKind.Local).AddTicks(6999), "1,2,6", 6, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2020, 6, 18, 0, 12, 12, 301, DateTimeKind.Local).AddTicks(9529), "1,3,4", 5, 1, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2020, 3, 24, 16, 48, 10, 149, DateTimeKind.Local).AddTicks(3212), "1,2,4", 4, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2020, 1, 23, 0, 47, 11, 482, DateTimeKind.Local).AddTicks(7141), "0,3,4", 3, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2020, 3, 9, 5, 7, 3, 833, DateTimeKind.Local).AddTicks(2143), "0,2,4", 2, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2019, 11, 1, 0, 56, 8, 788, DateTimeKind.Local).AddTicks(8192), "1,2,6", 1, 3, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2020, 3, 12, 4, 18, 55, 622, DateTimeKind.Local).AddTicks(7170), "0,2,6", 50, 2, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2020, 6, 26, 12, 15, 15, 660, DateTimeKind.Local).AddTicks(3167), "1,3,4", 10, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2019, 10, 27, 5, 44, 46, 957, DateTimeKind.Local).AddTicks(6105), "0,3,5", 24, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2020, 7, 9, 20, 27, 37, 780, DateTimeKind.Local).AddTicks(8173), "0,2,5", 16, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2020, 2, 25, 23, 32, 51, 469, DateTimeKind.Local).AddTicks(8751), "0,3,5", 26, 4, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2019, 10, 28, 5, 0, 29, 188, DateTimeKind.Local).AddTicks(3466), "0,2,4", 48, 1, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2020, 7, 12, 12, 54, 58, 976, DateTimeKind.Local).AddTicks(2409), "0,2,6", 47, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2020, 7, 9, 14, 6, 41, 937, DateTimeKind.Local).AddTicks(4511), "1,2,5", 46, 5, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2020, 6, 13, 0, 59, 50, 35, DateTimeKind.Local).AddTicks(8962), "1,2,4", 25, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2020, 6, 21, 5, 21, 42, 457, DateTimeKind.Local).AddTicks(1089), "1,2,6", 44, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2019, 10, 22, 22, 6, 18, 140, DateTimeKind.Local).AddTicks(9381), "0,3,4", 43, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2019, 7, 26, 3, 40, 56, 855, DateTimeKind.Local).AddTicks(4122), "0,3,5", 42, 5, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2019, 11, 4, 6, 15, 0, 863, DateTimeKind.Local).AddTicks(7328), "1,2,4", 41, 4, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2020, 3, 29, 6, 42, 49, 300, DateTimeKind.Local).AddTicks(2253), "0,2,4", 40, 6, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2019, 7, 24, 1, 35, 31, 613, DateTimeKind.Local).AddTicks(9807), "1,2,4", 39, 1, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2020, 4, 24, 10, 18, 49, 604, DateTimeKind.Local).AddTicks(181), "1,3,6", 38, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2020, 4, 16, 2, 43, 58, 216, DateTimeKind.Local).AddTicks(841), "0,3,6", 37, 4, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2020, 3, 16, 2, 22, 39, 460, DateTimeKind.Local).AddTicks(162), "1,2,5", 45, 6, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2019, 10, 22, 17, 18, 23, 314, DateTimeKind.Local).AddTicks(3902), "1,3,4", 35, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2019, 10, 22, 0, 34, 32, 233, DateTimeKind.Local).AddTicks(6931), "0,2,6", 34, 6, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2020, 5, 11, 23, 4, 56, 610, DateTimeKind.Local).AddTicks(5019), "0,2,5", 33, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2020, 6, 8, 14, 9, 6, 413, DateTimeKind.Local).AddTicks(6610), "1,3,4", 27, 2, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2019, 12, 27, 7, 16, 8, 649, DateTimeKind.Local).AddTicks(7698), "0,3,6", 32, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2020, 5, 13, 19, 48, 53, 793, DateTimeKind.Local).AddTicks(3427), "0,2,6", 31, 5, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2019, 8, 31, 20, 38, 17, 715, DateTimeKind.Local).AddTicks(6275), "1,3,6", 30, 1, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2020, 3, 30, 7, 16, 29, 281, DateTimeKind.Local).AddTicks(4735), "1,2,6", 29, 6, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2020, 4, 13, 19, 12, 19, 82, DateTimeKind.Local).AddTicks(7271), "0,3,4", 28, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2020, 6, 30, 0, 5, 27, 504, DateTimeKind.Local).AddTicks(2356), "1,2,6", 36, 1, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 6, "Comité des droits des personnes handicapés", "Comité des droits des personnes handicapés" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 4, "Comité des droits de l’Homme", "Comité des droits de l’Homme" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 5, "Comité des droits de l’enfant", "Comité des droits de l’enfant" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 2, "Comité contre la torture", "Comité contre la torture" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 1, "Comité CEDAW", "Comité CEDAW" });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 3, "Comité des disparitions forcées", "Comité des disparitions forcées" });

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
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 9, 2020, "", "sous theme 9", "تحت الموضوع 9", "Droits catégoriels", "الحقوق المواضيعية" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 15, 2020, "", "sous theme 15", "تحت الموضوع 15", "Droits catégoriels", "حقوق الفئات" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 14, 2020, "", "sous theme 14", "تحت الموضوع 14", "Droits thématiques", "الحقوق المواضيعية" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 13, 2020, "", "sous theme 13", "تحت الموضوع 13", "Droits catégoriels", "الحقوق المواضيعية" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 11, 2020, "", "sous theme 11", "تحت الموضوع 11", "Droits thématiques", "حقوق الفئات" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 10, 2020, "", "sous theme 10", "تحت الموضوع 10", "Droits thématiques", "الحقوق المواضيعية" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 8, 2020, "", "sous theme 8", "تحت الموضوع 8", "Droits thématiques", "الحقوق المواضيعية" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 12, 2020, "", "sous theme 12", "تحت الموضوع 12", "Droits thématiques", "الحقوق المواضيعية" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 6, 2020, "", "sous theme 6", "تحت الموضوع 6", "Droits thématiques", "حقوق الفئات" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 5, 2020, "", "sous theme 5", "تحت الموضوع 5", "Droits thématiques", "حقوق الفئات" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 4, 2020, "", "sous theme 4", "تحت الموضوع 4", "Droits catégoriels", "الحقوق المواضيعية" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 7, 2020, "", "sous theme 7", "تحت الموضوع 7", "Droits thématiques", "حقوق الفئات" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 3, 2020, "", "sous theme 3", "تحت الموضوع 3", "Droits thématiques", "حقوق الفئات" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 2, 2020, "", "sous theme 2", "تحت الموضوع 2", "Droits thématiques", "الحقوق المواضيعية" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "SousThemeAr", "Theme", "ThemeAr" },
                values: new object[] { 1, 2020, "", "sous theme 1", "تحت الموضوع 1", "Droits thématiques", "الحقوق المواضيعية" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 66, "", "", new DateTime(2019, 7, 21, 15, 29, 11, 671, DateTimeKind.Local).AddTicks(1208), new DateTime(2020, 3, 25, 18, 21, 7, 244, DateTimeKind.Local).AddTicks(5445), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 67, "", "", new DateTime(2020, 4, 6, 2, 11, 45, 397, DateTimeKind.Local).AddTicks(7719), new DateTime(2019, 11, 5, 17, 58, 39, 256, DateTimeKind.Local).AddTicks(3246), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 68, "", "", new DateTime(2019, 11, 10, 7, 10, 34, 815, DateTimeKind.Local).AddTicks(9629), new DateTime(2019, 12, 30, 6, 7, 56, 515, DateTimeKind.Local).AddTicks(9286), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 69, "", "", new DateTime(2020, 4, 30, 2, 21, 17, 523, DateTimeKind.Local).AddTicks(8243), new DateTime(2020, 4, 11, 11, 19, 22, 31, DateTimeKind.Local).AddTicks(4471), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 72, "", "", new DateTime(2020, 5, 31, 8, 5, 43, 631, DateTimeKind.Local).AddTicks(3834), new DateTime(2020, 7, 7, 20, 1, 13, 669, DateTimeKind.Local).AddTicks(1186), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 71, "", "", new DateTime(2020, 5, 15, 5, 4, 0, 741, DateTimeKind.Local).AddTicks(7300), new DateTime(2019, 10, 2, 16, 9, 10, 352, DateTimeKind.Local).AddTicks(3545), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 65, "", "", new DateTime(2020, 6, 9, 7, 52, 20, 601, DateTimeKind.Local).AddTicks(4376), new DateTime(2020, 4, 3, 22, 44, 11, 751, DateTimeKind.Local).AddTicks(2080), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 73, "", "", new DateTime(2020, 2, 24, 20, 22, 3, 573, DateTimeKind.Local).AddTicks(1045), new DateTime(2020, 2, 23, 2, 39, 11, 738, DateTimeKind.Local).AddTicks(2089), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 74, "", "", new DateTime(2019, 11, 20, 3, 19, 31, 44, DateTimeKind.Local).AddTicks(600), new DateTime(2020, 5, 17, 3, 16, 21, 516, DateTimeKind.Local).AddTicks(3419), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 70, "", "", new DateTime(2020, 4, 10, 17, 32, 16, 101, DateTimeKind.Local).AddTicks(3309), new DateTime(2019, 9, 25, 23, 21, 12, 945, DateTimeKind.Local).AddTicks(6545), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 64, "", "", new DateTime(2020, 6, 15, 16, 13, 6, 292, DateTimeKind.Local).AddTicks(9147), new DateTime(2019, 11, 13, 3, 40, 0, 838, DateTimeKind.Local).AddTicks(7269), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 62, "", "", new DateTime(2020, 2, 4, 17, 17, 15, 271, DateTimeKind.Local).AddTicks(4296), new DateTime(2020, 4, 3, 6, 15, 30, 577, DateTimeKind.Local).AddTicks(9410), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 53, "", "", new DateTime(2020, 5, 4, 21, 35, 53, 774, DateTimeKind.Local).AddTicks(8028), new DateTime(2019, 11, 27, 4, 20, 35, 447, DateTimeKind.Local).AddTicks(4953), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 61, "", "", new DateTime(2019, 12, 24, 6, 10, 24, 681, DateTimeKind.Local).AddTicks(4267), new DateTime(2019, 8, 4, 19, 31, 41, 675, DateTimeKind.Local).AddTicks(6365), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 60, "", "", new DateTime(2020, 3, 27, 14, 12, 26, 595, DateTimeKind.Local).AddTicks(6151), new DateTime(2019, 10, 24, 8, 40, 8, 326, DateTimeKind.Local).AddTicks(4042), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 59, "", "", new DateTime(2020, 2, 13, 20, 49, 48, 54, DateTimeKind.Local).AddTicks(345), new DateTime(2019, 9, 27, 13, 20, 29, 977, DateTimeKind.Local).AddTicks(7140), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 58, "", "", new DateTime(2020, 1, 15, 1, 29, 51, 401, DateTimeKind.Local).AddTicks(4002), new DateTime(2020, 3, 13, 21, 4, 21, 308, DateTimeKind.Local).AddTicks(7205), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 57, "", "", new DateTime(2020, 7, 2, 18, 53, 39, 746, DateTimeKind.Local).AddTicks(5387), new DateTime(2020, 6, 12, 4, 0, 26, 949, DateTimeKind.Local).AddTicks(533), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 56, "", "", new DateTime(2019, 8, 30, 5, 35, 25, 709, DateTimeKind.Local).AddTicks(4111), new DateTime(2020, 6, 19, 7, 44, 30, 899, DateTimeKind.Local).AddTicks(286), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 55, "", "", new DateTime(2019, 11, 3, 6, 46, 33, 730, DateTimeKind.Local).AddTicks(7177), new DateTime(2020, 3, 21, 16, 46, 38, 311, DateTimeKind.Local).AddTicks(9885), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 54, "", "", new DateTime(2019, 8, 10, 19, 16, 52, 251, DateTimeKind.Local).AddTicks(8313), new DateTime(2020, 2, 20, 1, 38, 20, 769, DateTimeKind.Local).AddTicks(5369), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 75, "", "", new DateTime(2019, 9, 13, 21, 59, 47, 316, DateTimeKind.Local).AddTicks(1625), new DateTime(2019, 8, 7, 4, 34, 41, 399, DateTimeKind.Local).AddTicks(2034), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 63, "", "", new DateTime(2020, 4, 15, 15, 0, 14, 816, DateTimeKind.Local).AddTicks(8419), new DateTime(2019, 11, 30, 6, 25, 58, 13, DateTimeKind.Local).AddTicks(9699), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 76, "", "", new DateTime(2019, 11, 21, 8, 31, 43, 624, DateTimeKind.Local).AddTicks(1423), new DateTime(2019, 10, 4, 7, 54, 3, 0, DateTimeKind.Local).AddTicks(7972), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 91, "", "", new DateTime(2019, 8, 13, 20, 5, 17, 912, DateTimeKind.Local).AddTicks(8352), new DateTime(2020, 7, 1, 1, 23, 20, 52, DateTimeKind.Local).AddTicks(300), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 78, "", "", new DateTime(2019, 11, 19, 3, 32, 17, 345, DateTimeKind.Local).AddTicks(873), new DateTime(2020, 1, 26, 21, 48, 41, 438, DateTimeKind.Local).AddTicks(4330), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 52, "", "", new DateTime(2020, 7, 7, 6, 3, 25, 288, DateTimeKind.Local).AddTicks(4603), new DateTime(2019, 12, 13, 14, 59, 26, 70, DateTimeKind.Local).AddTicks(8237), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 100, "", "", new DateTime(2019, 12, 5, 6, 10, 29, 607, DateTimeKind.Local).AddTicks(3344), new DateTime(2020, 5, 17, 19, 5, 35, 784, DateTimeKind.Local).AddTicks(7167), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 99, "", "", new DateTime(2020, 3, 3, 6, 20, 18, 891, DateTimeKind.Local).AddTicks(3209), new DateTime(2019, 7, 31, 6, 53, 38, 888, DateTimeKind.Local).AddTicks(6821), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 98, "", "", new DateTime(2019, 11, 11, 0, 23, 10, 983, DateTimeKind.Local).AddTicks(5950), new DateTime(2020, 3, 26, 20, 50, 38, 861, DateTimeKind.Local).AddTicks(6093), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 97, "", "", new DateTime(2020, 5, 1, 6, 47, 47, 99, DateTimeKind.Local).AddTicks(4343), new DateTime(2020, 1, 31, 13, 14, 7, 576, DateTimeKind.Local).AddTicks(2886), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 96, "", "", new DateTime(2020, 1, 27, 4, 50, 58, 278, DateTimeKind.Local).AddTicks(7436), new DateTime(2019, 8, 3, 4, 51, 48, 632, DateTimeKind.Local).AddTicks(7259), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 95, "", "", new DateTime(2019, 9, 28, 14, 56, 29, 868, DateTimeKind.Local).AddTicks(3354), new DateTime(2019, 9, 28, 16, 48, 54, 701, DateTimeKind.Local).AddTicks(5196), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 94, "", "", new DateTime(2019, 9, 7, 7, 20, 45, 875, DateTimeKind.Local).AddTicks(535), new DateTime(2019, 9, 22, 19, 54, 14, 679, DateTimeKind.Local).AddTicks(1061), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 93, "", "", new DateTime(2020, 4, 27, 12, 36, 2, 569, DateTimeKind.Local).AddTicks(3561), new DateTime(2020, 3, 10, 5, 36, 57, 991, DateTimeKind.Local).AddTicks(9105), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 92, "", "", new DateTime(2020, 2, 25, 18, 50, 45, 653, DateTimeKind.Local).AddTicks(2881), new DateTime(2019, 11, 1, 6, 0, 40, 614, DateTimeKind.Local).AddTicks(6483), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 77, "", "", new DateTime(2020, 1, 16, 23, 56, 38, 290, DateTimeKind.Local).AddTicks(3751), new DateTime(2020, 4, 23, 5, 46, 11, 340, DateTimeKind.Local).AddTicks(6179), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 90, "", "", new DateTime(2020, 6, 27, 7, 25, 45, 232, DateTimeKind.Local).AddTicks(2585), new DateTime(2019, 9, 21, 16, 21, 3, 356, DateTimeKind.Local).AddTicks(3539), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 88, "", "", new DateTime(2020, 2, 15, 15, 23, 24, 851, DateTimeKind.Local).AddTicks(1453), new DateTime(2020, 4, 29, 23, 19, 41, 400, DateTimeKind.Local).AddTicks(10), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 87, "", "", new DateTime(2020, 3, 8, 22, 34, 55, 489, DateTimeKind.Local).AddTicks(765), new DateTime(2020, 6, 23, 0, 28, 21, 199, DateTimeKind.Local).AddTicks(7418), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 86, "", "", new DateTime(2019, 8, 13, 10, 26, 56, 677, DateTimeKind.Local).AddTicks(2466), new DateTime(2019, 12, 15, 22, 24, 34, 556, DateTimeKind.Local).AddTicks(507), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 85, "", "", new DateTime(2019, 11, 13, 10, 10, 42, 985, DateTimeKind.Local).AddTicks(8838), new DateTime(2019, 8, 24, 18, 4, 9, 531, DateTimeKind.Local).AddTicks(7589), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 84, "", "", new DateTime(2019, 8, 9, 5, 7, 8, 495, DateTimeKind.Local).AddTicks(1693), new DateTime(2020, 5, 25, 9, 1, 26, 559, DateTimeKind.Local).AddTicks(8222), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 83, "", "", new DateTime(2019, 9, 13, 3, 33, 38, 380, DateTimeKind.Local).AddTicks(3104), new DateTime(2019, 10, 15, 3, 12, 25, 124, DateTimeKind.Local).AddTicks(3724), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 82, "", "", new DateTime(2020, 5, 14, 12, 2, 26, 728, DateTimeKind.Local).AddTicks(312), new DateTime(2020, 6, 10, 5, 55, 3, 946, DateTimeKind.Local).AddTicks(7984), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 81, "", "", new DateTime(2020, 4, 6, 5, 34, 19, 506, DateTimeKind.Local).AddTicks(4305), new DateTime(2019, 8, 30, 19, 27, 58, 806, DateTimeKind.Local).AddTicks(988), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 80, "", "", new DateTime(2019, 11, 4, 6, 18, 38, 479, DateTimeKind.Local).AddTicks(4936), new DateTime(2020, 4, 25, 17, 22, 0, 39, DateTimeKind.Local).AddTicks(6481), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 79, "", "", new DateTime(2020, 2, 29, 5, 18, 8, 243, DateTimeKind.Local).AddTicks(8987), new DateTime(2020, 3, 25, 7, 36, 27, 181, DateTimeKind.Local).AddTicks(3478), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 89, "", "", new DateTime(2020, 4, 26, 21, 14, 53, 496, DateTimeKind.Local).AddTicks(9816), new DateTime(2019, 12, 8, 2, 57, 31, 789, DateTimeKind.Local).AddTicks(4659), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 51, "", "", new DateTime(2020, 2, 24, 14, 27, 4, 181, DateTimeKind.Local).AddTicks(9754), new DateTime(2020, 6, 18, 21, 51, 25, 260, DateTimeKind.Local).AddTicks(2702), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 8, "", "", new DateTime(2019, 12, 31, 22, 24, 47, 138, DateTimeKind.Local).AddTicks(683), new DateTime(2020, 5, 3, 0, 55, 15, 486, DateTimeKind.Local).AddTicks(8098), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 49, "", "", new DateTime(2020, 4, 30, 23, 53, 23, 884, DateTimeKind.Local).AddTicks(4605), new DateTime(2020, 3, 31, 17, 18, 3, 587, DateTimeKind.Local).AddTicks(391), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 22, "", "", new DateTime(2019, 12, 25, 3, 23, 35, 12, DateTimeKind.Local).AddTicks(4351), new DateTime(2020, 2, 2, 21, 10, 48, 486, DateTimeKind.Local).AddTicks(6295), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 21, "", "", new DateTime(2020, 4, 28, 1, 58, 56, 286, DateTimeKind.Local).AddTicks(6074), new DateTime(2019, 9, 12, 8, 25, 5, 688, DateTimeKind.Local).AddTicks(843), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 20, "", "", new DateTime(2020, 6, 12, 1, 47, 30, 724, DateTimeKind.Local).AddTicks(9633), new DateTime(2019, 10, 13, 10, 6, 55, 956, DateTimeKind.Local).AddTicks(6515), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 19, "", "", new DateTime(2020, 2, 1, 18, 30, 9, 856, DateTimeKind.Local).AddTicks(4972), new DateTime(2020, 7, 2, 17, 53, 36, 871, DateTimeKind.Local).AddTicks(875), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 18, "", "", new DateTime(2019, 8, 20, 3, 29, 51, 474, DateTimeKind.Local).AddTicks(6333), new DateTime(2019, 10, 20, 15, 52, 43, 168, DateTimeKind.Local).AddTicks(4016), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 17, "", "", new DateTime(2020, 4, 25, 8, 2, 37, 292, DateTimeKind.Local).AddTicks(5676), new DateTime(2019, 8, 29, 1, 17, 52, 459, DateTimeKind.Local).AddTicks(6444), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 16, "", "", new DateTime(2019, 10, 22, 14, 39, 29, 494, DateTimeKind.Local).AddTicks(1350), new DateTime(2020, 1, 16, 14, 56, 43, 747, DateTimeKind.Local).AddTicks(7097), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 15, "", "", new DateTime(2020, 3, 3, 14, 29, 16, 87, DateTimeKind.Local).AddTicks(4003), new DateTime(2020, 1, 21, 16, 42, 14, 264, DateTimeKind.Local).AddTicks(7705), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 14, "", "", new DateTime(2019, 11, 16, 14, 31, 3, 628, DateTimeKind.Local).AddTicks(1535), new DateTime(2019, 12, 8, 20, 59, 3, 524, DateTimeKind.Local).AddTicks(4245), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 13, "", "", new DateTime(2019, 8, 20, 3, 56, 33, 457, DateTimeKind.Local).AddTicks(7210), new DateTime(2019, 12, 18, 17, 26, 14, 521, DateTimeKind.Local).AddTicks(6975), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 12, "", "", new DateTime(2019, 11, 11, 23, 12, 19, 270, DateTimeKind.Local).AddTicks(9126), new DateTime(2019, 10, 5, 11, 17, 25, 207, DateTimeKind.Local).AddTicks(1540), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 11, "", "", new DateTime(2020, 1, 13, 21, 46, 6, 771, DateTimeKind.Local).AddTicks(6244), new DateTime(2020, 1, 14, 4, 33, 13, 85, DateTimeKind.Local).AddTicks(9786), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 10, "", "", new DateTime(2019, 12, 15, 3, 2, 52, 380, DateTimeKind.Local).AddTicks(695), new DateTime(2019, 11, 25, 18, 44, 55, 478, DateTimeKind.Local).AddTicks(5415), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 9, "", "", new DateTime(2020, 4, 9, 22, 31, 24, 400, DateTimeKind.Local).AddTicks(2100), new DateTime(2020, 5, 13, 0, 21, 13, 840, DateTimeKind.Local).AddTicks(9962), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 7, "", "", new DateTime(2020, 3, 31, 22, 49, 52, 82, DateTimeKind.Local).AddTicks(4275), new DateTime(2019, 10, 14, 6, 33, 54, 141, DateTimeKind.Local).AddTicks(7645), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 6, "", "", new DateTime(2020, 6, 11, 12, 58, 54, 680, DateTimeKind.Local).AddTicks(5241), new DateTime(2020, 6, 23, 10, 22, 55, 705, DateTimeKind.Local).AddTicks(5750), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 5, "", "", new DateTime(2020, 4, 30, 9, 52, 33, 380, DateTimeKind.Local).AddTicks(8737), new DateTime(2020, 3, 31, 5, 31, 15, 939, DateTimeKind.Local).AddTicks(5295), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 4, "", "", new DateTime(2019, 12, 4, 2, 37, 57, 733, DateTimeKind.Local).AddTicks(4371), new DateTime(2020, 3, 23, 18, 1, 53, 63, DateTimeKind.Local).AddTicks(1156), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 3, "", "", new DateTime(2019, 9, 4, 3, 26, 3, 336, DateTimeKind.Local).AddTicks(8932), new DateTime(2020, 6, 5, 0, 22, 12, 695, DateTimeKind.Local).AddTicks(9758), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 2, "", "", new DateTime(2020, 1, 7, 1, 26, 22, 747, DateTimeKind.Local).AddTicks(2449), new DateTime(2020, 2, 8, 0, 28, 58, 609, DateTimeKind.Local).AddTicks(9056), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 50, "", "", new DateTime(2019, 11, 24, 13, 48, 13, 760, DateTimeKind.Local).AddTicks(1717), new DateTime(2019, 10, 5, 20, 59, 25, 511, DateTimeKind.Local).AddTicks(5466), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 23, "", "", new DateTime(2020, 6, 10, 4, 38, 4, 802, DateTimeKind.Local).AddTicks(8007), new DateTime(2020, 7, 7, 10, 16, 38, 527, DateTimeKind.Local).AddTicks(8727), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 24, "", "", new DateTime(2019, 8, 21, 8, 23, 21, 572, DateTimeKind.Local).AddTicks(4639), new DateTime(2020, 6, 24, 7, 2, 36, 544, DateTimeKind.Local).AddTicks(9501), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 1, "", "", new DateTime(2020, 2, 8, 5, 32, 17, 832, DateTimeKind.Local).AddTicks(4722), new DateTime(2019, 11, 27, 7, 26, 9, 296, DateTimeKind.Local).AddTicks(3623), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 26, "", "", new DateTime(2020, 3, 24, 18, 38, 1, 991, DateTimeKind.Local).AddTicks(1547), new DateTime(2020, 6, 14, 17, 12, 13, 30, DateTimeKind.Local).AddTicks(1455), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 25, "", "", new DateTime(2020, 2, 3, 10, 18, 40, 631, DateTimeKind.Local).AddTicks(2194), new DateTime(2020, 3, 29, 20, 58, 36, 197, DateTimeKind.Local).AddTicks(9534), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 47, "", "", new DateTime(2020, 7, 12, 23, 20, 22, 325, DateTimeKind.Local).AddTicks(5775), new DateTime(2019, 10, 14, 21, 46, 17, 372, DateTimeKind.Local).AddTicks(8104), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 46, "", "", new DateTime(2019, 12, 24, 8, 55, 16, 582, DateTimeKind.Local).AddTicks(1046), new DateTime(2019, 7, 31, 17, 51, 58, 990, DateTimeKind.Local).AddTicks(5145), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 45, "", "", new DateTime(2020, 4, 1, 10, 42, 52, 486, DateTimeKind.Local).AddTicks(8579), new DateTime(2019, 11, 6, 0, 59, 58, 932, DateTimeKind.Local).AddTicks(7870), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 44, "", "", new DateTime(2020, 5, 17, 5, 26, 48, 101, DateTimeKind.Local).AddTicks(4377), new DateTime(2019, 12, 15, 22, 49, 37, 599, DateTimeKind.Local).AddTicks(5446), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 43, "", "", new DateTime(2020, 7, 8, 5, 54, 42, 146, DateTimeKind.Local).AddTicks(7507), new DateTime(2020, 2, 21, 13, 54, 47, 197, DateTimeKind.Local).AddTicks(2839), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 42, "", "", new DateTime(2020, 3, 13, 13, 10, 26, 480, DateTimeKind.Local).AddTicks(3888), new DateTime(2020, 1, 30, 18, 20, 55, 10, DateTimeKind.Local).AddTicks(8991), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 41, "", "", new DateTime(2020, 2, 19, 23, 39, 46, 242, DateTimeKind.Local).AddTicks(2380), new DateTime(2019, 12, 24, 9, 53, 0, 950, DateTimeKind.Local).AddTicks(9877), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 40, "", "", new DateTime(2019, 10, 13, 4, 39, 34, 873, DateTimeKind.Local).AddTicks(1370), new DateTime(2020, 7, 1, 1, 23, 16, 208, DateTimeKind.Local).AddTicks(5553), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 39, "", "", new DateTime(2020, 5, 2, 6, 57, 24, 292, DateTimeKind.Local).AddTicks(9389), new DateTime(2020, 1, 24, 8, 37, 28, 356, DateTimeKind.Local).AddTicks(5741), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 38, "", "", new DateTime(2020, 1, 7, 23, 15, 5, 158, DateTimeKind.Local).AddTicks(6901), new DateTime(2020, 7, 17, 22, 29, 12, 561, DateTimeKind.Local).AddTicks(6705), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 48, "", "", new DateTime(2019, 9, 30, 9, 52, 26, 228, DateTimeKind.Local).AddTicks(2455), new DateTime(2019, 11, 17, 10, 5, 22, 435, DateTimeKind.Local).AddTicks(5029), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 36, "", "", new DateTime(2020, 1, 20, 14, 44, 13, 291, DateTimeKind.Local).AddTicks(5734), new DateTime(2020, 6, 3, 21, 15, 40, 13, DateTimeKind.Local).AddTicks(7995), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 27, "", "", new DateTime(2020, 7, 2, 21, 9, 20, 879, DateTimeKind.Local).AddTicks(3549), new DateTime(2020, 6, 23, 21, 18, 1, 639, DateTimeKind.Local).AddTicks(4763), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 37, "", "", new DateTime(2019, 10, 13, 2, 0, 48, 57, DateTimeKind.Local).AddTicks(4463), new DateTime(2020, 1, 17, 4, 11, 45, 518, DateTimeKind.Local).AddTicks(5128), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 29, "", "", new DateTime(2020, 4, 24, 9, 19, 39, 170, DateTimeKind.Local).AddTicks(2947), new DateTime(2020, 4, 29, 13, 43, 6, 98, DateTimeKind.Local).AddTicks(2446), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 30, "", "", new DateTime(2019, 12, 20, 13, 8, 15, 871, DateTimeKind.Local).AddTicks(2813), new DateTime(2020, 6, 17, 4, 9, 58, 905, DateTimeKind.Local).AddTicks(8319), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 31, "", "", new DateTime(2020, 5, 30, 22, 18, 44, 756, DateTimeKind.Local).AddTicks(2412), new DateTime(2019, 9, 30, 6, 1, 1, 407, DateTimeKind.Local).AddTicks(6606), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 28, "", "", new DateTime(2020, 5, 22, 21, 8, 11, 22, DateTimeKind.Local).AddTicks(3641), new DateTime(2020, 1, 25, 2, 11, 26, 511, DateTimeKind.Local).AddTicks(870), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 33, "", "", new DateTime(2020, 5, 26, 4, 3, 59, 570, DateTimeKind.Local).AddTicks(8353), new DateTime(2020, 2, 8, 7, 55, 28, 545, DateTimeKind.Local).AddTicks(5986), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 34, "", "", new DateTime(2020, 1, 17, 5, 31, 37, 861, DateTimeKind.Local).AddTicks(6116), new DateTime(2020, 2, 3, 0, 22, 7, 350, DateTimeKind.Local).AddTicks(6634), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 35, "", "", new DateTime(2019, 8, 19, 4, 42, 35, 600, DateTimeKind.Local).AddTicks(2439), new DateTime(2019, 10, 17, 4, 38, 36, 654, DateTimeKind.Local).AddTicks(5681), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 32, "", "", new DateTime(2019, 12, 2, 22, 12, 36, 586, DateTimeKind.Local).AddTicks(6058), new DateTime(2020, 2, 12, 0, 50, 14, 594, DateTimeKind.Local).AddTicks(4935), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 65, new DateTime(2019, 7, 28, 17, 51, 50, 466, DateTimeKind.Local).AddTicks(9716), "Tenetur esse dolorem odio enim eaque iusto praesentium. Consequatur perferendis maxime et consectetur. Repellat est enim. Commodi voluptate quos quia est nostrum. Est officia tempore laboriosam enim.", "كان الخامس خمسة برص انه ظهور الخارجي. طويل قرون مقاطع ستينيّات أخذتها طويل برامج مرة. لوريم ظهور النشر عشوائي بل الشكل القرن ودور الصفحة كتيّب. زمن إيبسوم بمعنى نسخ ببساطة منذ هو توضع رقائق. طويل أيضاً حتى بايج برامج التي.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 72, new DateTime(2020, 1, 3, 7, 3, 12, 64, DateTimeKind.Local).AddTicks(3826), "Officia id expedita. Mollitia eligendi nisi voluptas eius est commodi officia quia. Culpa magni ipsum libero.", "برامج والتي الخارجي كان مطبعة. لهذه الزمن المحتوى قرون هذا رقائق. تقضي ستينيّات توزيعاَ توزيعاَ تعطي الشكلي عشوائي. الأصلي عشر توزيعاَ بايج منذ أخذتها بايج لينتشر الشكلي. ويُستخدم الخامس مثل الفقرات إيبسوم. مقاطع لتكوّن القرن طريقة الصفحة المحتوى عندما الصفحة طبيعياَ.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 71, new DateTime(2019, 7, 29, 19, 20, 19, 468, DateTimeKind.Local).AddTicks(2414), "Iusto repudiandae modi excepturi odit voluptas sit omnis. Numquam saepe sint mollitia perferendis. Aut aliquam consectetur quod accusantium. Optio doloremque officiis numquam assumenda ut necessitatibus. Tenetur labore fugiat deleniti occaecati molestiae laborum modi laudantium.", "للنص حتى مرجع وبشكله مقاطع مرة هو بشكل. مثبتة ستينيّات توضع أخرى ودور حوت شكل بمثابة. لتكوّن مع من حقيقة أو.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 70, new DateTime(2019, 10, 15, 23, 2, 6, 93, DateTimeKind.Local).AddTicks(4340), "Et hic nulla illum doloremque mollitia mollitia fugit consequatur. Fugiat voluptatem voluptates perspiciatis vero voluptatem et quaerat culpa. Recusandae sed et accusamus sed qui minus at enim numquam.", "الخارجي شكل أخذتها الخامس توضع مقاطع توضع قامت مستخدماً. برص بمثابة إيبسوم الأحرف انتشر الأحرف توزيعاَ. بل ولايزال المعيار. الطباعة هذا تعطي مثل شكل عن حوت وهي رقائق. المطابع عندما نص أخرى الطباعة نص.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 69, new DateTime(2019, 10, 30, 3, 30, 25, 393, DateTimeKind.Local).AddTicks(8018), "Dicta ratione quam ipsam voluptatem officiis quisquam. Minus sit maiores voluptas reiciendis. Ipsa voluptates praesentium exercitationem aut accusamus laudantium non. Officia ullam officia aut rerum qui eos ut aperiam.", "مرجع لم البلاستيكية ظهور مؤخراَ ما مجهولة توضع إصدار صار. لتكوّن دليل التي أن. انتشر لأنها والتنضيد بمعنى النشر بمثابة ما إيبسوم كبير. هي على الخارجي مؤخراَ استخدام برص الغاية ألدوس أخرى. القارئ تحوي تقضي نص للنص نص. وليس النشر قامت مرة.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 68, new DateTime(2019, 9, 14, 8, 19, 6, 668, DateTimeKind.Local).AddTicks(2225), "Laborum quo qui provident eligendi dolorem dolorem qui earum. Quasi suscipit odio debitis voluptatum aut deserunt ducimus. Similique natus quo repellendus sed minus est ut quisquam. Sint facilis ut corrupti sint ab non quia inventore. Non sunt expedita in maxime in possimus iure quia.", "كبير لهذه الغاية الشكلي الفقرات بمعنى ليتراسيت طويل هي للنص. توضع لم أن. سيلهي يقرأها لصفحة انتشر كبير والتنضيد مقاطع. حتى الفقرات بشكل نص طريقة تعطي الخامس.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 67, new DateTime(2020, 7, 19, 4, 7, 0, 760, DateTimeKind.Local).AddTicks(7092), "Est officiis dicta qui consequuntur animi impedit et. Qui aperiam facilis quis. Sint numquam et debitis est dolores et reiciendis suscipit voluptas. Earum facilis sint qui aliquam reprehenderit quibusdam praesentium unde. Ut quis expedita est sapiente reprehenderit sed. Tempore architecto voluptas ex magni eos tempore accusamus.", "النص بايج الإلكتروني عندما كتيّب المعيار طريقة للنص حتى. بمعنى عشر المعيار لصفحة على لأنها القارئ المطابع المحتوى لينتشر. في مجهولة أخرى هناك بل إصدار وبشكله مرجع. لهذه كتيّب هذا لينتشر الشكل لصفحة لوريم في بشكل إصدار.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 66, new DateTime(2019, 8, 15, 22, 56, 15, 942, DateTimeKind.Local).AddTicks(1188), "Eveniet voluptatem nisi enim qui natus minima cumque dolores amet. Similique sit doloremque voluptates. Aliquid debitis ut consequuntur est autem illo dolorum sed.", "حقيقة ولايزال عشر لم الخارجي النص يتم. مؤخراَ أيضاً ولايزال انه يقرأها عشوائي نسخ قرون قامت. الزمن النص طويل توضع. وليس المعيار الفقرات في المحتوى لأنها مايكر. مرة شكل مؤخراَ.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 64, new DateTime(2020, 4, 12, 6, 12, 9, 831, DateTimeKind.Local).AddTicks(3212), "Est quo neque corporis voluptas excepturi. Voluptatem itaque deleniti qui perferendis ullam. Exercitationem in accusamus aut quis. Velit nostrum mollitia occaecati. Ab voluptas quo.", "استخدام أو تعطي ويُستخدم بشكل. القرن دليل هو المطابع ظهور ستينيّات لينتشر المحتوى قامت. صار مؤخراَ قرون عشوائي تعطي إصدار دليل. عشوائي ويُستخدم لينتشر الخامس. أيضاً مايكر بشكل النشر ودور مثبتة لينتشر عشوائي. توزيعاَ المقروء لينتشر لينتشر.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 53, new DateTime(2019, 8, 16, 12, 11, 53, 966, DateTimeKind.Local).AddTicks(403), "Sint omnis quasi. Quis et commodi. Autem nam tempora rerum illum doloribus quia. Rerum quia nemo tempore consequuntur iusto.", "الإلكتروني ظهور هناك. انتشر أيضاً التي عن. الخارجي والتنضيد ودور عشوائي مقاطع نسخ برص عشر ما.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 62, new DateTime(2020, 4, 25, 19, 54, 24, 117, DateTimeKind.Local).AddTicks(1470), "Eligendi culpa error laboriosam voluptatem quod provident eligendi. Ratione consequatur omnis et et sit. Distinctio quia eum illo molestiae qui.", "برص البلاستيكية الغاية قامت مطبعة من مطبعة الغاية مجهولة النص. بمعنى خمسة إصدار المحتوى حقيقة. كبير طبيعياَ أو وبشكله لصفحة الشكلي لينتشر حوت البلاستيكية مع.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 61, new DateTime(2019, 10, 8, 17, 46, 45, 366, DateTimeKind.Local).AddTicks(6964), "Soluta adipisci quibusdam et rem et voluptatibus cum. Veniam illo ut id omnis a. Enim magni sapiente dicta voluptas. Nam quisquam maxime vel quibusdam. Voluptas et unde voluptatem quam et quia sapiente tempora. Vero quasi perferendis sit.", "ظهور دليل أن المطابع مطبعة عشر منذ كان ظهور الفقرات. الطباعة هي عشوائي وليس لوريم ودور. مقاطع حوت حوت القارئ الأحرف وعاد طبيعياَ المطابع ولايزال. توضع الغاية لصفحة المعيار مجهولة.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 60, new DateTime(2020, 3, 19, 8, 43, 30, 348, DateTimeKind.Local).AddTicks(6992), "Numquam sit veritatis quibusdam sapiente nulla. Et provident sint possimus hic. Repudiandae ratione dolor dolorem et qui.", "لهذه وبشكله النص. هي والتنضيد أيضاً لتكوّن بايج برامج انه تحوي ولذلك. بمثابة شكل هذا المعيار ولايزال وهي. هو الشكلي أخذتها التركيز. مثل مستخدماً ظهور طبيعياَ يتم وليس لصفحة وليس مقاطع انتشر.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 59, new DateTime(2020, 1, 21, 8, 52, 36, 116, DateTimeKind.Local).AddTicks(2892), "Id ut rem totam eligendi ea aut vel. Sit rerum provident sed. Quo expedita praesentium. Est nulla odio odio veritatis harum consectetur pariatur. Atque quis aut aut molestiae rem quod consequuntur doloribus autem. Amet non dicta.", "حتى الزمن ظهور قرون. النص عشر برامج. طريقة برص من الصفحة سيلهي برص سيلهي.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 58, new DateTime(2020, 2, 22, 5, 44, 0, 952, DateTimeKind.Local).AddTicks(6731), "Dignissimos libero et est. Id dolorum doloremque. Adipisci provident id possimus aut ut. Optio incidunt dolores consequatur repellat hic quibusdam quas tenetur. Laboriosam illum nemo et tempora veritatis dolores. Ea ex deleniti.", "برص بل عن طريقة. صار الخارجي البلاستيكية لأنها التركيز منذ كان تقضي يتم. صار التركيز ويُستخدم مثل.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 57, new DateTime(2020, 2, 26, 11, 30, 40, 733, DateTimeKind.Local).AddTicks(4468), "Corrupti minus quia totam quia aliquid doloribus atque facilis. At ducimus nesciunt perspiciatis natus sed aut. Mollitia tempore quasi totam eligendi possimus voluptas. Praesentium impedit rerum dolorum quas nihil. Commodi facilis quasi tenetur. Neque dolores eaque et quaerat sapiente nulla ducimus non.", "استخدام شكل بمعنى الخامس. هو نص كبير تحوي مقاطع توضع برص سيلهي هو. ودور القرن طويل. صار قامت النشر مرجع وليس وعاد لم منذ والتي الصفحة.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 56, new DateTime(2020, 2, 13, 22, 36, 12, 104, DateTimeKind.Local).AddTicks(3125), "Adipisci qui minus ut asperiores temporibus illo corrupti. Voluptates dolor nam explicabo aspernatur voluptates voluptatum dignissimos non quam. Amet quaerat explicabo animi eaque vero maiores omnis sed impedit. Facere non consectetur. Non culpa ex cum commodi voluptatum quaerat. Dignissimos cumque quia consequatur aliquam blanditiis id officia impedit.", "ولذلك بمثابة صناعات للنص صناعات طويل برص. مجموعة القارئ ببساطة صناعات الفقرات. مثل توضع الشكل قامت بمعنى خمسة يقرأها.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 55, new DateTime(2019, 11, 29, 21, 50, 35, 947, DateTimeKind.Local).AddTicks(6288), "Natus sapiente consectetur maiores deleniti dolor itaque repellat. Labore placeat voluptas. Ad ut vel ratione enim consequuntur velit et. Est quo fugit sit eum sunt repellendus doloremque. Similique voluptate non vitae ducimus vitae repudiandae.", "الزمن حوت مثل ولذلك. يقرأها والتي أخرى بشكل إصدار مؤخراَ. الطباعة أيضاً لصفحة بمثابة. الخارجي بل بمثابة دليل منذ ببساطة.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 54, new DateTime(2019, 7, 26, 8, 27, 4, 562, DateTimeKind.Local).AddTicks(2318), "Explicabo et aut delectus aut molestias qui officiis vitae. Quasi voluptates eum. Mollitia laudantium et et enim dicta ipsa aut facilis.", "الإلكتروني خمسة شكل ليتراسيت ما صناعات الصفحة. إصدار القارئ صناعات مع لينتشر قرون مجهولة الفقرات طويل. هي الزمن وهي ولذلك ظهور حقيقة إصدار. كبير في والتي.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 73, new DateTime(2019, 8, 6, 10, 29, 23, 765, DateTimeKind.Local).AddTicks(8271), "Sit eligendi maxime quos. Ipsum quos rerum qui quae ratione tempore. Voluptates aspernatur sit consequatur debitis provident natus quia ea.", "الصفحة الزمن طبيعياَ الغاية بايج. وبشكله ألدوس وبشكله إيبسوم البلاستيكية مرجع والتي ودور. الأصلي توضع ولايزال مجموعة الغاية مجموعة ودور الشكلي. إصدار مقاطع مؤخراَ مجموعة. يقرأها لصفحة بمعنى هناك صناعات لينتشر. مستخدماً وهي والتي مرجع مقاطع لأنها قامت توضع حتى.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 52, new DateTime(2020, 4, 11, 3, 50, 7, 895, DateTimeKind.Local).AddTicks(8985), "Aut sunt magni quia enim molestias voluptatem. Adipisci hic nobis sapiente. Deserunt eum atque. Repellat quia error enim ut inventore aliquid aut.", "عن إصدار النشر هو والتي ويُستخدم حقيقة خمسة بشكل. بمثابة لوريم مطبعة وعاد. تحوي رقائق وليس النشر رقائق الشكل وليس على البلاستيكية.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 63, new DateTime(2019, 7, 23, 14, 8, 36, 858, DateTimeKind.Local).AddTicks(1241), "Blanditiis molestias ea officiis magni blanditiis odio. Pariatur omnis est quibusdam. Molestiae eum voluptatem dolorum est veniam. Culpa magni est molestiae blanditiis ea.", "مايكر هو ويُستخدم لأنها الصفحة طويل انتشر طبيعياَ. تعطي عشوائي وبشكله لهذه المطابع المقروء لصفحة هو. مايكر بمثابة كتيّب استخدام وبشكله ظهور المقروء لأنها عشوائي. تعطي الزمن والتي هو يقرأها الطباعة صناعات الطباعة مع. مستخدماً في ما مجهولة الصفحة أيضاً لأنها تعطي للنص.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 74, new DateTime(2019, 12, 16, 23, 41, 42, 233, DateTimeKind.Local).AddTicks(9389), "Eaque enim sit aliquid et vitae omnis non nulla. Sunt alias tempora magnam culpa adipisci. Laborum animi et aut voluptatem dicta dignissimos. Dignissimos enim saepe nemo nam et doloribus itaque atque velit. Rerum cumque eos ab rerum perspiciatis expedita.", "قرون مايكر ظهور مثل التي كتيّب. الخامس لصفحة هو. حوت على النص حقيقة. الصفحة ولايزال التركيز وليس أن حوت سيلهي طريقة انتشر. أيضاً انتشر تحوي تقضي دليل هناك طويل الطباعة نص.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 85, new DateTime(2020, 3, 21, 21, 51, 15, 568, DateTimeKind.Local).AddTicks(8550), "Nemo inventore facere aperiam neque maiores maiores voluptatem quam neque. Explicabo praesentium ut consectetur accusamus voluptatem laboriosam sed. Sequi eligendi placeat assumenda velit ab rerum et occaecati. Et consectetur nesciunt ea recusandae et omnis. Ipsa doloremque fugit facere iste inventore quia saepe.", "الشكلي عن هناك عن ألدوس. البلاستيكية بشكل توزيعاَ تحوي ويُستخدم نص في مقاطع عن. حتى ولذلك بمعنى الأحرف. وليس تحوي الأحرف ولايزال مثل قرون صناعات. كبير الأصلي بشكل القرن الإلكتروني عشوائي ألدوس النشر.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 76, new DateTime(2019, 11, 28, 3, 49, 13, 868, DateTimeKind.Local).AddTicks(1710), "Debitis iure a. Et qui quos qui et non consequatur. Omnis voluptatem soluta optio ab laudantium voluptatem. Maxime rerum nobis voluptatem dolorem impedit facilis optio ut.", "النص القارئ تقضي التركيز. طويل برص دليل لأنها عشر. قامت الشكل لينتشر تعطي مثبتة برص.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 98, new DateTime(2020, 1, 11, 14, 5, 1, 306, DateTimeKind.Local).AddTicks(5481), "Nobis et similique rerum sed nostrum quae dolores. Nulla dolor sint. Dicta maxime et natus placeat optio eveniet ut. Ut omnis sit.", "انه على انتشر مثبتة طبيعياَ. أخذتها الشكلي انتشر الغاية الغاية انتشر. للنص هي للنص الصفحة برامج تقضي. شكل مجموعة والتي. المعيار هذا لتكوّن مقاطع مجهولة وهي هناك تقضي. والتي مرة ليتراسيت من طبيعياَ.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 51, new DateTime(2019, 12, 10, 17, 45, 18, 273, DateTimeKind.Local).AddTicks(5724), "Maxime voluptatibus sed possimus laboriosam consequatur. Et libero aut porro sequi quasi maxime laboriosam aliquid. Illo libero nobis dicta quia aut harum et neque et.", "برامج هناك بل المحتوى برامج أيضاً. على خمسة مؤخراَ وبشكله الطباعة التركيز نص مع برص أن. المعيار انه إصدار وليس.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 97, new DateTime(2020, 2, 13, 9, 37, 13, 887, DateTimeKind.Local).AddTicks(1832), "Eius adipisci enim accusamus temporibus molestiae quisquam ex eos. Voluptatem sit minus. Doloribus sit voluptas fugiat qui.", "كبير انتشر مع. الإلكتروني مرجع مؤخراَ ولايزال لهذه. لهذه الشكلي أن يتم الشكلي والتي. مؤخراَ لتكوّن ويُستخدم هو المقروء ويُستخدم هو البلاستيكية سيلهي حتى. في نص مثل الشكلي وليس. وعاد مايكر مجموعة.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 96, new DateTime(2019, 9, 5, 9, 54, 54, 699, DateTimeKind.Local).AddTicks(9376), "Sunt assumenda consequuntur ratione quo est blanditiis dolore deleniti. Aut fugit velit culpa delectus et quos dolorem. Soluta et ut fuga omnis aut rerum.", "البلاستيكية انتشر الصفحة عندما توزيعاَ. مثل ولذلك ألدوس حوت القارئ أخذتها. مطبعة ليتراسيت هذا. برص المطابع بل. حقيقة وليس بمعنى بل الخارجي لصفحة المطابع. كتيّب الشكلي انه مرة شكل.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 95, new DateTime(2020, 4, 15, 14, 49, 26, 715, DateTimeKind.Local).AddTicks(540), "Quia dolores a laudantium est consequatur ex molestias. Quas maiores ab nihil eos laboriosam quod. Laudantium tempora aut.", "في عن عشر هناك الخارجي المقروء الإلكتروني لهذه مثبتة انه. أن القارئ مع النص مثبتة الأحرف. من لم المعيار حتى مايكر تقضي خمسة مجهولة.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 94, new DateTime(2019, 12, 9, 4, 3, 17, 921, DateTimeKind.Local).AddTicks(1419), "Dicta sit magnam nisi recusandae magni quidem consectetur enim. Iusto excepturi recusandae veniam mollitia omnis. Velit quam qui aut unde aspernatur omnis. Quo quia nihil. Et dolorum in dolore quia minima rerum. Ut aut qui magni tempore officia harum sunt accusantium atque.", "المقروء ستينيّات ودور. توزيعاَ والتنضيد التي انه بشكل وليس. ولذلك برامج بل حقيقة عن مطبعة البلاستيكية لوريم مرة.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 93, new DateTime(2019, 10, 13, 4, 22, 33, 86, DateTimeKind.Local).AddTicks(7080), "Consequatur at inventore laudantium dolores qui omnis voluptates amet. Consequuntur magnam blanditiis dolor culpa animi quae. Natus id qui ut veniam eius tempore velit. Corporis similique magnam.", "المعيار لهذه ودور. ويُستخدم دليل طريقة. شكل نص عن هناك. عن ببساطة الطباعة والتنضيد الزمن وليس زمن انتشر لهذه.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 92, new DateTime(2019, 10, 22, 19, 16, 29, 783, DateTimeKind.Local).AddTicks(9389), "Odit eos omnis. Dolorem vitae dolor cumque voluptate. Dolores at porro. Maiores est debitis dicta dolore aut assumenda vitae laudantium. Dolorem magnam modi architecto sapiente laborum ut. Sapiente animi deleniti dolor qui maxime fuga quas.", "النص مثل المحتوى زمن. ولذلك قرون ألدوس بايج كان ما بمثابة هو. لوريم المطابع مع عن المحتوى حوت. الخامس الزمن توضع ويُستخدم بشكل وهي المحتوى صناعات بل.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 91, new DateTime(2019, 10, 1, 7, 16, 36, 994, DateTimeKind.Local).AddTicks(2537), "Et itaque odio culpa dolorem quia omnis id dolorem. Nam odio eum voluptatem dolorem. Sed fugiat vero hic id quae eum magni possimus maxime.", "ألدوس صناعات وهي مايكر. نص صناعات بمعنى هذا إصدار سيلهي المعيار. إصدار ما طريقة وبشكله الطباعة التي وليس إصدار.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 90, new DateTime(2020, 4, 20, 20, 37, 16, 563, DateTimeKind.Local).AddTicks(8074), "Alias in natus qui. Similique officiis quis nulla. Et hic debitis explicabo placeat voluptatem corporis dolores optio. Necessitatibus consequuntur nobis similique ad. Consequatur quia quisquam voluptates qui earum voluptates dolores. Sapiente fugiat commodi nihil sed veniam voluptatum.", "التركيز لينتشر المعيار الخامس المقروء. الفقرات تقضي ستينيّات قامت الخارجي توضع توزيعاَ النص حتى نسخ. مرة ولذلك تعطي بايج نص مرجع الأصلي زمن. يتم الغاية صار ببساطة الزمن هو. قامت قرون وليس مقاطع يتم الفقرات يتم التي الأصلي لتكوّن.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 75, new DateTime(2020, 6, 13, 7, 0, 37, 203, DateTimeKind.Local).AddTicks(801), "Quis hic impedit expedita reprehenderit reprehenderit eveniet aliquam. Minima perferendis quidem voluptatum blanditiis ut. Distinctio debitis quo ratione inventore. Atque laborum in et praesentium itaque repudiandae. Dolor et corporis iusto in voluptatem.", "ستينيّات مرة البلاستيكية كتيّب مجهولة ليتراسيت. توضع بشكل مطبعة القرن أو بايج مستخدماً النص برامج. بل وليس مطبعة حوت يقرأها طريقة لتكوّن تعطي.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 89, new DateTime(2020, 2, 26, 15, 27, 2, 270, DateTimeKind.Local).AddTicks(7437), "Accusantium sit porro quod. Soluta quis expedita qui voluptatem totam totam. Beatae incidunt provident sunt ut dicta sequi quibusdam.", "زمن وعاد إصدار. لهذه الشكل مرة حقيقة النشر القارئ استخدام. طريقة المقروء الطباعة برص تعطي هي مجهولة.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 87, new DateTime(2020, 3, 15, 22, 28, 21, 816, DateTimeKind.Local).AddTicks(8465), "Ut minus similique voluptatum magnam dignissimos voluptatum aut facilis. Quas ullam aspernatur. Maxime culpa unde. Eaque omnis aut eligendi.", "المعيار المطابع مع. مؤخراَ عندما هو من بل الفقرات المطابع مجهولة هي أو. عشوائي قرون المقروء ليتراسيت المطابع. ودور طويل يتم زمن. استخدام في وعاد بايج القارئ.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 86, new DateTime(2020, 6, 4, 18, 50, 2, 867, DateTimeKind.Local).AddTicks(3321), "Nemo autem voluptatem non doloribus. Quia eligendi illum quisquam a nobis molestiae maxime aut labore. Est consequatur autem deleniti et quam. Et dolorem in. Sequi vitae sequi atque et.", "رقائق أو المعيار ألدوس برص. الخارجي سيلهي كبير مقاطع مثبتة طويل. بل مثل لينتشر هذا. سيلهي برامج أو التي.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 84, new DateTime(2020, 6, 12, 7, 23, 18, 466, DateTimeKind.Local).AddTicks(6150), "Iusto velit eveniet commodi placeat aspernatur. Recusandae est et voluptatum. In earum perspiciatis eius sint veritatis libero ut et.", "مرجع رقائق ظهور ببساطة مطبعة ظهور لتكوّن عندما مؤخراَ الطباعة. الشكلي إيبسوم وليس الفقرات تعطي القرن شكل توزيعاَ. لأنها وبشكله الغاية ويُستخدم.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 83, new DateTime(2019, 7, 21, 15, 21, 33, 466, DateTimeKind.Local).AddTicks(6555), "Expedita distinctio assumenda qui. Corrupti optio debitis eos atque delectus. Ab non odit consequatur quisquam minima dolorem qui totam repudiandae. Ullam et qui dolores earum. Quia consequatur quam qui impedit porro voluptate debitis id. Aliquam sed illum quo et deleniti necessitatibus qui.", "أن النشر صناعات مرجع بايج. مرجع انه كان قامت بمثابة نسخ الغاية حوت. الإلكتروني ويُستخدم لتكوّن منذ مثل ولذلك ويُستخدم البلاستيكية. بل مرة الغاية الزمن المقروء هناك لوريم على مرجع انه. لينتشر مجموعة على.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 82, new DateTime(2020, 2, 11, 8, 51, 25, 570, DateTimeKind.Local).AddTicks(8238), "Accusamus voluptatem laudantium nam praesentium unde voluptas voluptatem. Ratione ut facilis ea neque est repellendus voluptatibus consequuntur sint. Vitae consequuntur perspiciatis magni sint nulla.", "منذ دليل كتيّب مجهولة من الأصلي من والتي عشر. لصفحة حقيقة والتي ظهور مايكر. الأحرف ولايزال النص ودور لتكوّن الصفحة خمسة كان تحوي مقاطع. انه أخذتها أيضاً البلاستيكية يتم الصفحة عندما بايج. توضع أو أن لينتشر لم بمعنى حوت المقروء مثل. بمثابة هذا لصفحة للنص تحوي مؤخراَ المطابع مثبتة.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 81, new DateTime(2020, 1, 10, 11, 14, 59, 976, DateTimeKind.Local).AddTicks(7568), "Possimus a molestiae est dolores aliquam libero fuga ut odio. Ut dolorem sint explicabo est nihil similique ipsum omnis animi. Assumenda cupiditate quo voluptas rerum sint. Aperiam voluptatem alias. Unde quae aut rerum eveniet.", "والتي الزمن الأحرف عن مرجع القرن طويل توضع وليس. هو دليل لوريم لهذه عشوائي للنص الفقرات حقيقة أو البلاستيكية. ليتراسيت التركيز ولايزال يتم والتنضيد تحوي التركيز في توضع.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 80, new DateTime(2019, 12, 17, 8, 24, 30, 156, DateTimeKind.Local).AddTicks(2745), "Sunt odio voluptatem. Et dolor ipsa laborum earum et rem possimus minus nostrum. In sint dolore nostrum atque eum nihil. Doloremque dicta recusandae officia molestias illo tenetur maxime.", "ودور دليل الصفحة. كتيّب القارئ والتنضيد يقرأها والتنضيد طويل ولذلك بشكل وبشكله هو. وبشكله بمثابة بشكل أيضاً وهي. لهذه مايكر طبيعياَ التركيز بشكل.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 79, new DateTime(2019, 12, 29, 13, 17, 0, 274, DateTimeKind.Local).AddTicks(2071), "Reprehenderit ex ut atque. Praesentium qui fugit esse vitae. Placeat assumenda aut sit consequatur delectus provident. Molestias commodi fugiat quia veritatis quis. Voluptatem et sequi ipsum.", "لصفحة الأحرف انتشر البلاستيكية. عندما طويل يقرأها القارئ. ببساطة مع الإلكتروني حتى الأحرف قرون أن. بشكل استخدام هي التركيز.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 78, new DateTime(2019, 9, 15, 5, 30, 30, 889, DateTimeKind.Local).AddTicks(982), "Molestiae molestias id consectetur ea enim rerum. Sed fuga molestiae optio blanditiis et eius pariatur nobis. Quibusdam earum esse voluptas beatae est nisi assumenda. Saepe ipsa voluptatum error incidunt autem quos ratione nihil officia.", "لصفحة لتكوّن انه ما مستخدماً التي أخذتها برامج شكلي. شكل أخذتها ما على المطابع أخرى تقضي صناعات. رقائق مرجع أيضاً ما مايكر أن مثل الفقرات طريقة. الأصلي مطبعة مرجع طريقة لوريم ويُستخدم هي من. المحتوى لم على منذ.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 77, new DateTime(2019, 7, 22, 17, 29, 48, 279, DateTimeKind.Local).AddTicks(6419), "Quos exercitationem doloribus nihil. Placeat est dolores autem sit officiis ipsa voluptas. Repudiandae porro consequatur iusto. Sit temporibus officiis molestias odio. Ipsum dolor qui eos esse fuga.", "طريقة انتشر على. ستينيّات شكلي كبير التركيز. بمعنى مع منذ عشوائي. أن أن انه منذ ظهور النص. تحوي مثبتة انتشر مجهولة الطباعة ستينيّات.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 88, new DateTime(2020, 1, 20, 22, 10, 48, 208, DateTimeKind.Local).AddTicks(1606), "Ullam ut officiis. Voluptas atque consequatur harum dolores animi nemo laudantium et optio. Optio officiis dolor quis rerum aperiam. Harum eos corporis ullam saepe.", "طويل القرن لينتشر. نص لم والتنضيد القارئ هناك. المطابع الأصلي أخرى كتيّب حتى الصفحة ودور لم. إيبسوم تعطي ستينيّات ظهور. نص استخدام مجهولة والتي مؤخراَ الإلكتروني رقائق. الخارجي هي وهي الشكل المقروء.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 50, new DateTime(2020, 5, 24, 17, 49, 0, 312, DateTimeKind.Local).AddTicks(2443), "Amet omnis eos. Nisi et rerum nihil dolorem similique blanditiis. Consequuntur consequatur quidem enim soluta iste dolorum qui omnis omnis. Quia et occaecati quia temporibus ratione accusantium odit. Non molestiae illo exercitationem laudantium pariatur illo hic.", "ستينيّات تقضي والتي كان للنص حوت حتى. هو والتنضيد التي من تقضي. طريقة الطباعة لصفحة وبشكله.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 26, new DateTime(2020, 1, 18, 12, 21, 29, 2, DateTimeKind.Local).AddTicks(6934), "Nostrum cupiditate voluptate. Non ut cum velit impedit eius aut est. Nobis sit nulla incidunt iste. In et praesentium nobis animi necessitatibus quia iste eligendi. Quo et ut accusamus dolore ipsum in minus. Ea veritatis maxime rerum velit minus ut quos expedita optio.", "وعاد وهي دليل برص ما. وهي المقروء وهي ظهور توزيعاَ انتشر التركيز ودور نسخ. وليس الأصلي نسخ ويُستخدم بشكل ودور وهي مرة. مطبعة استخدام وعاد خمسة. عن ليتراسيت شكلي إصدار تقضي الإلكتروني.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 48, new DateTime(2020, 2, 23, 9, 46, 37, 223, DateTimeKind.Local).AddTicks(3124), "Qui corporis incidunt id laudantium eos iure itaque ex nulla. Laudantium perspiciatis labore quis aut nisi. Vero excepturi provident quam sit sint dolor ut.", "عندما الطباعة للنص منذ. أيضاً مطبعة طريقة وعاد. حوت كبير أخذتها الفقرات زمن توزيعاَ لهذه منذ صناعات.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 20, new DateTime(2020, 3, 15, 1, 56, 51, 136, DateTimeKind.Local).AddTicks(5402), "Quia tempora ut. In harum excepturi sequi vero autem voluptates. Voluptas consequatur velit consequatur harum. Quo a quia optio quasi blanditiis recusandae. Distinctio ut a quo. Sapiente et quas.", "ليتراسيت هي وهي إصدار القرن مثبتة مايكر انتشر القرن. بمثابة من لصفحة برص رقائق مثبتة التي. حتى النشر وهي مقاطع بمثابة لأنها عندما الشكلي المطابع. يتم لهذه لتكوّن عشوائي سيلهي ستينيّات نص مستخدماً. أو طبيعياَ الصفحة.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 19, new DateTime(2020, 5, 15, 11, 39, 0, 82, DateTimeKind.Local).AddTicks(739), "Id et eos quo aspernatur. Soluta quia in rerum atque minus modi. Fuga quo quam eveniet itaque culpa excepturi aut sit aut.", "بشكل حتى أن حتى لوريم كتيّب. منذ تقضي طويل عندما برص بمعنى مع لتكوّن مع. قرون ليتراسيت هو تعطي النشر مقاطع مجهولة مع أيضاً وبشكله. طويل أن كان مرة على وليس أو لينتشر وبشكله. انه مرجع دليل ألدوس للنص الصفحة.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 18, new DateTime(2020, 1, 28, 20, 14, 55, 593, DateTimeKind.Local).AddTicks(5594), "Rerum nihil vel laborum aperiam ea quos voluptas quasi et. Et beatae maiores consectetur facere ut molestiae ut. Quis consequatur ut alias ut est rerum. Et dolor dolorem laudantium minus.", "برص مع سيلهي لأنها طريقة شكلي. الأصلي الفقرات مرجع الشكل لصفحة نسخ طريقة مثل تقضي. المقروء مؤخراَ ولذلك الغاية. لينتشر مطبعة النص النشر عن توضع. عندما توضع مثبتة لتكوّن مثل.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 17, new DateTime(2020, 3, 10, 6, 7, 51, 513, DateTimeKind.Local).AddTicks(5804), "Neque nemo ea inventore saepe temporibus. Mollitia reiciendis nesciunt assumenda eum non doloremque facere quod laboriosam. Aut velit praesentium et est voluptatem aspernatur.", "تعطي يتم نسخ برص تحوي المطابع الطباعة. ويُستخدم مطبعة رقائق. مرة للنص الخارجي مرجع النص وهي يتم إيبسوم البلاستيكية إيبسوم. وهي يتم بايج طريقة.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 16, new DateTime(2020, 2, 27, 22, 31, 42, 316, DateTimeKind.Local).AddTicks(6191), "Laborum numquam et ut quas et neque. Corrupti et et quia veniam voluptas sit voluptatem. Voluptas rem perferendis dolorem totam debitis sit tempore vel similique. Aliquid asperiores adipisci delectus sit et corporis aut. Est quisquam odit. Distinctio architecto qui inventore magnam.", "من وليس قرون تعطي. هذا ودور لتكوّن حوت كبير برامج بمثابة الأصلي. صار ألدوس لينتشر زمن القارئ. الخامس للنص ودور شكلي دليل نسخ وبشكله.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 15, new DateTime(2020, 5, 18, 11, 17, 22, 368, DateTimeKind.Local).AddTicks(5961), "Ut eos ut reiciendis sapiente neque rerum. Sed facilis illum dolor. Aliquam deserunt iure harum molestias. Accusantium quia sit omnis expedita. Itaque doloribus et iusto et.", "شكلي أيضاً مؤخراَ الخامس طريقة هو أو الزمن الشكل. التي أخذتها شكلي. الخامس ببساطة لم. كبير مايكر مؤخراَ أو ولذلك. مع البلاستيكية ببساطة.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 14, new DateTime(2020, 6, 25, 13, 27, 55, 476, DateTimeKind.Local).AddTicks(7448), "Neque non facere placeat distinctio ut natus. Dicta et assumenda sit eaque ipsum adipisci quidem et. Qui quod quam suscipit repudiandae enim. Pariatur sunt quos aut.", "عشوائي طويل للنص عشر انه في قامت. وليس ليتراسيت كبير مقاطع إيبسوم والتنضيد. ولذلك توزيعاَ والتنضيد دليل برص كان. المطابع لصفحة من حتى تحوي وهي طريقة.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 13, new DateTime(2019, 11, 2, 19, 17, 24, 643, DateTimeKind.Local).AddTicks(4422), "Consequatur provident error vero autem. Quia atque consequatur dolor. Mollitia voluptas placeat quas quaerat. Praesentium repudiandae tempora. Sit unde tenetur aut non eveniet rerum vel doloremque commodi. Laboriosam cumque iure.", "رقائق لوريم الخامس الخامس مثبتة الفقرات مطبعة هو وهي. الطباعة وعاد عن ولذلك كتيّب إصدار. لصفحة تعطي البلاستيكية بمعنى سيلهي كتيّب. مؤخراَ تعطي المقروء للنص قامت مقاطع دليل بمثابة. الخامس التركيز الصفحة لوريم مرة قرون. مثل مثبتة مايكر مستخدماً المحتوى ولايزال كان تقضي.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 12, new DateTime(2020, 2, 25, 18, 36, 49, 873, DateTimeKind.Local).AddTicks(4489), "Et cum et iste quibusdam. Ut necessitatibus et. Officia quod quod et commodi quo esse. Consequatur unde perspiciatis et impedit voluptatem dicta quis ducimus exercitationem. Provident culpa dolorem nihil.", "النشر ببساطة مجموعة نص من طبيعياَ للنص يقرأها يتم ستينيّات. بشكل المطابع المعيار وعاد برامج تقضي كان حقيقة رقائق. مقاطع انه لم أخرى بمعنى مؤخراَ ألدوس التي هناك عشوائي. توزيعاَ لهذه ظهور مرجع. لأنها قامت الإلكتروني بايج مثبتة هي الأصلي تحوي. ودور ببساطة توضع توضع.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 11, new DateTime(2019, 12, 1, 6, 13, 58, 127, DateTimeKind.Local).AddTicks(5209), "Qui repellat ab ipsam eveniet est officiis at ipsa et. Blanditiis voluptatem ut id. Temporibus alias ut qui vel consectetur dolores nihil excepturi libero. Expedita deserunt et.", "منذ استخدام أخرى حوت ودور ويُستخدم ما بايج القارئ. لينتشر عندما لوريم مرة لوريم هو النشر للنص تقضي لتكوّن. انتشر خمسة عن مقاطع. الخامس إصدار القرن مطبعة المطابع الفقرات مرجع لينتشر المقروء. هي ودور لينتشر شكل على لم والتنضيد. صار ولايزال وبشكله إيبسوم بمعنى.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 10, new DateTime(2020, 2, 12, 12, 25, 51, 533, DateTimeKind.Local).AddTicks(126), "Dolores dolores perferendis fugiat et nesciunt id ut blanditiis. Perferendis perferendis optio et recusandae. Ut aliquam exercitationem dolores recusandae.", "كان هي خمسة برامج قامت هو أيضاً. هي المحتوى تقضي شكل تعطي لتكوّن ليتراسيت لم. توضع المعيار هذا الشكل المطابع والتنضيد مرة زمن. إيبسوم حتى رقائق مثل التي من. بل مؤخراَ الإلكتروني هناك بمعنى توزيعاَ.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 9, new DateTime(2019, 10, 26, 6, 39, 5, 657, DateTimeKind.Local).AddTicks(9185), "Similique explicabo quae molestiae. Autem aliquid officiis ipsum quidem nam voluptas quia. Non consequatur ea facilis. Qui saepe dicta nobis eaque expedita eius possimus. Voluptates id laborum. Sequi earum rerum ratione et est quo harum.", "طريقة مجموعة قرون حتى التركيز الخارجي بمعنى انه انه مرة. بشكل حتى قرون لوريم مجهولة. تحوي برص طريقة ستينيّات هو طبيعياَ. عشر مع مرجع في. وهي المحتوى النشر عشر الشكل مايكر نسخ قامت.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 8, new DateTime(2020, 6, 6, 14, 56, 24, 936, DateTimeKind.Local).AddTicks(3827), "Maiores occaecati quia beatae nulla corporis ratione accusamus quidem qui. Eaque ipsam culpa eius fugiat. Laborum consequatur minus magnam. Et voluptas et aut sit. Aspernatur molestiae magnam ad doloribus reprehenderit aut nulla.", "والتي أن يقرأها ودور منذ عشر. مرة والتنضيد لوريم لينتشر والتنضيد. رقائق استخدام والتي أخرى. قرون لم ما.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 7, new DateTime(2019, 10, 9, 15, 1, 28, 141, DateTimeKind.Local).AddTicks(106), "Ut deserunt aut quidem officiis autem omnis non. Animi ullam ea sapiente aliquid sed laudantium aut. Suscipit labore officia rerum numquam aperiam expedita similique. Ut ea cum commodi et accusantium explicabo voluptatibus unde.", "في هذا وهي القارئ البلاستيكية بايج برامج. إصدار صار تحوي توضع قرون يتم. المحتوى بل أو. تعطي الأحرف تعطي مع كان ببساطة عشر مؤخراَ أو التركيز. مرة قرون مجموعة نص منذ. مثبتة ببساطة البلاستيكية عشوائي لأنها في الخامس حتى حوت.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 6, new DateTime(2020, 7, 5, 7, 23, 33, 201, DateTimeKind.Local).AddTicks(103), "Dolorem dolorum aperiam est in nesciunt non occaecati et. Perferendis illo iure at unde numquam delectus iure consequatur. Quo possimus soluta laboriosam.", "قامت عشر التي. لم شكلي أيضاً تعطي نسخ أخرى. ظهور قرون الفقرات بشكل زمن أخذتها. أن النص انه التي. أخذتها كبير منذ إيبسوم الشكل الزمن ولذلك مثل هي لوريم.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 5, new DateTime(2019, 8, 9, 11, 44, 14, 929, DateTimeKind.Local).AddTicks(858), "Id corporis aliquid voluptate fugit nemo quasi numquam omnis explicabo. Sint reiciendis et odit voluptates atque et. Exercitationem dolore dolorem libero. Et nemo vel molestiae quibusdam sit eum consequuntur corporis.", "بمثابة لتكوّن لم الطباعة قامت طبيعياَ ليتراسيت عشر لأنها. المعيار مرة بشكل يتم لوريم التي الصفحة إيبسوم لينتشر. وعاد الإلكتروني كان وهي صار لينتشر الزمن. بايج هذا منذ لهذه لينتشر مطبعة. ودور أو مثل شكلي قامت كبير تقضي. الزمن في النشر ويُستخدم القارئ أخذتها بل منذ من.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 4, new DateTime(2019, 10, 30, 19, 53, 30, 988, DateTimeKind.Local).AddTicks(5952), "Cumque repellat qui quia voluptates. Deserunt adipisci voluptas consequuntur blanditiis tenetur aliquam laborum tempora. Et laborum blanditiis unde repellat. Officia rem ut voluptas expedita.", "البلاستيكية انه الطباعة ودور ألدوس. الإلكتروني ما عشوائي منذ مرجع أخذتها الإلكتروني كتيّب. الشكل الزمن عن حتى.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 3, new DateTime(2019, 8, 19, 13, 40, 33, 738, DateTimeKind.Local).AddTicks(9578), "Adipisci reiciendis facere saepe dolorum sed. Autem quis nihil et minima voluptas aut quibusdam. Est beatae sunt necessitatibus. Magni saepe consequatur vel quos cum provident voluptatem.", "لصفحة على أن مؤخراَ ودور لم طبيعياَ ويُستخدم دليل. مرة برص هناك ألدوس هو. بل ويُستخدم سيلهي والتنضيد الأصلي الطباعة حوت أن الشكل يتم. صناعات الطباعة كان انه الطباعة لصفحة وهي. قرون حوت في شكلي الخامس هي. الطباعة لهذه انه تحوي شكلي مؤخراَ انه بايج أن منذ.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 2, new DateTime(2019, 12, 9, 14, 22, 24, 121, DateTimeKind.Local).AddTicks(8888), "Minima qui dolores laboriosam iste illo animi. Recusandae veniam molestias quae impedit et dignissimos animi eos. Quas pariatur sunt qui reiciendis unde non. Dolor velit et qui fugiat quo. Blanditiis nemo accusantium ea aliquam ut. Rerum quaerat ut et quos quam ut velit doloremque.", "هذا المحتوى طريقة. الزمن يتم وهي الغاية الخارجي للنص دليل كتيّب. طويل مقاطع قامت صار الزمن عشر. مطبعة مرة الصفحة بشكل تحوي عشوائي بمعنى المحتوى يتم تعطي. توزيعاَ عن حقيقة مجهولة بشكل صار.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 1, new DateTime(2019, 12, 17, 13, 13, 38, 61, DateTimeKind.Local).AddTicks(3606), "Dolor rerum hic eum laboriosam similique deserunt earum. Ex ut voluptas enim quae. Quis incidunt corrupti atque autem. Quia quam cumque eum et blanditiis qui aliquid.", "حتى التي انتشر طبيعياَ والتي ولايزال شكل تحوي. لم أخرى أو طبيعياَ إصدار لم. رقائق لصفحة الصفحة الإلكتروني في الفقرات ولذلك لوريم بل. طبيعياَ انه ويُستخدم عن.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 99, new DateTime(2019, 10, 5, 17, 24, 17, 426, DateTimeKind.Local).AddTicks(2587), "Rerum atque tempore voluptatem praesentium sequi aut. Nulla dolores tempore sint. Consectetur impedit accusamus mollitia unde explicabo. Non quod ipsam facilis quia nihil sed atque. Sint neque adipisci minima laboriosam in et aut eaque doloribus. Expedita fugit sapiente ut.", "بل توضع لم خمسة لأنها. شكلي تحوي ودور كان. يتم نسخ تحوي. قامت يقرأها أخذتها انه لينتشر الشكل.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 21, new DateTime(2020, 7, 4, 3, 37, 11, 467, DateTimeKind.Local).AddTicks(6015), "Nemo ut magni iusto dolores sit rerum impedit. Esse doloribus delectus est. Laboriosam sit facilis voluptatem id dolorem sed aperiam blanditiis. Et explicabo facere unde aut. Consequatur ut sint soluta nam ad et.", "هذا مقاطع ويُستخدم لم إصدار أن مثبتة المعيار نص. مجهولة أخذتها الأحرف شكل انه مجهولة الأصلي الخارجي للنص خمسة. خمسة الفقرات وعاد ليتراسيت الشكل شكلي.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 22, new DateTime(2020, 2, 13, 1, 29, 26, 485, DateTimeKind.Local).AddTicks(5957), "Itaque illum quo vel sunt sint accusantium cum quia voluptatem. Excepturi eum corporis deleniti mollitia doloremque quia. Omnis adipisci molestias aut suscipit illo.", "صار إيبسوم والتي إيبسوم لأنها هو أخذتها وبشكله بل. الفقرات بمثابة صار الشكلي هو هي التركيز. الغاية أخذتها في صار هو سيلهي مثبتة الأحرف نسخ تقضي. مستخدماً أخذتها القارئ.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 23, new DateTime(2020, 1, 30, 13, 42, 49, 684, DateTimeKind.Local).AddTicks(3575), "Qui iste ut consequatur. Ut consequuntur occaecati nemo aperiam enim repellat quos est rem. Et sequi optio alias.", "مؤخراَ مطبعة توضع مستخدماً. المعيار بمعنى التي برص إيبسوم عن مستخدماً الأحرف كتيّب مطبعة. النشر دليل مستخدماً والتنضيد أيضاً. هناك ولذلك مجموعة. النشر للنص برص. ولايزال النشر برامج أخذتها التركيز الإلكتروني هي.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 24, new DateTime(2020, 2, 16, 20, 35, 31, 600, DateTimeKind.Local).AddTicks(8334), "Fugit doloribus voluptatibus harum tempora. Qui reprehenderit aut ut. Et ea voluptatum quidem et a numquam earum. Eos facilis assumenda.", "تعطي انه بايج مجهولة برامج الشكلي النشر برص وعاد. مثبتة الأحرف بمعنى. لتكوّن طويل انه لأنها والتنضيد أخرى أخذتها عن عشر. في قامت القرن. لهذه بل القرن المطابع ولذلك.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 47, new DateTime(2020, 4, 3, 16, 15, 3, 538, DateTimeKind.Local).AddTicks(9591), "Deleniti ducimus neque totam cupiditate vero libero. Autem voluptatem rerum tenetur debitis est nihil nesciunt porro occaecati. Ipsa repudiandae omnis autem officia non voluptas qui quod. Sit praesentium ad ullam. In voluptate rerum porro ut eos modi qui quas est.", "حقيقة حتى كتيّب لهذه. هو أخرى إصدار مايكر. ستينيّات ولذلك الشكلي بايج يقرأها والتي النص طويل. مرة الفقرات ببساطة هو منذ لوريم قامت مؤخراَ. المعيار قامت المحتوى أخذتها ستينيّات للنص أو مطبعة الخارجي. مجهولة قامت وعاد لهذه عن نسخ أو حقيقة أن لم.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 46, new DateTime(2019, 11, 3, 7, 0, 43, 546, DateTimeKind.Local).AddTicks(434), "Accusamus commodi ipsa amet assumenda. Accusantium et facilis. Sed consectetur a. Eos eum voluptatem nobis tempora iusto ab a aliquid distinctio.", "بشكل طويل ولذلك رقائق بمعنى أيضاً زمن على لتكوّن الطباعة. والتي تقضي ولايزال وليس لوريم انه بمعنى القارئ. المعيار زمن طبيعياَ. ظهور من استخدام الشكلي الصفحة إيبسوم مرجع الصفحة وبشكله وليس.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 45, new DateTime(2020, 3, 8, 12, 39, 44, 657, DateTimeKind.Local).AddTicks(4072), "Nemo modi voluptas. Unde consectetur sit aperiam voluptatum. Exercitationem quas explicabo doloribus repellat. Autem inventore sed voluptatem alias numquam error hic voluptatem.", "مثبتة ليتراسيت التي قامت عشوائي أخذتها توزيعاَ لأنها. ودور طريقة إصدار صناعات. بشكل ألدوس ستينيّات. مستخدماً على الشكلي والتي لينتشر ستينيّات إصدار نص أن. مرة مرجع منذ.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 44, new DateTime(2019, 12, 3, 21, 48, 0, 305, DateTimeKind.Local).AddTicks(8704), "Excepturi perspiciatis animi ut facilis quis quo. Alias odio corporis. Fugit non vitae quo reprehenderit et maxime adipisci id. Voluptatem nemo omnis dolores vero voluptas veniam at ea. Quo aliquam amet corrupti quis adipisci quia.", "بل هي طبيعياَ انتشر وهي صار حقيقة الشكل ما عشوائي. انتشر طريقة ظهور. من للنص وبشكله الأصلي وبشكله حقيقة. هي مثبتة توزيعاَ عن. رقائق تقضي الشكلي الإلكتروني على.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 43, new DateTime(2020, 5, 12, 23, 16, 31, 893, DateTimeKind.Local).AddTicks(2284), "Error cupiditate non earum molestias aliquam aspernatur nostrum tempore. Et aut unde molestias repudiandae repellendus at dolore reiciendis velit. Sit numquam ut quia consequatur eius non consequuntur nihil. Accusantium sequi beatae maiores laborum. Non tempora fugit id natus fugiat.", "من ظهور البلاستيكية ودور بمعنى الخارجي المعيار. هي الإلكتروني بشكل. المقروء مثل ببساطة شكل كان لأنها ظهور. استخدام بل الطباعة الأحرف مرجع التي. عن وهي الخامس.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 42, new DateTime(2020, 6, 4, 7, 25, 44, 691, DateTimeKind.Local).AddTicks(2133), "Quidem tempora facilis est ut doloremque. Sed repellendus nam est et suscipit dolore. Veritatis harum aut molestias laborum quos dicta. Nemo id neque.", "مجموعة بشكل تحوي هناك صار. شكلي في مايكر. كتيّب ويُستخدم مقاطع الطباعة ستينيّات مرجع زمن مرة قرون والتي. البلاستيكية مرجع للنص. ولذلك انتشر صناعات لتكوّن الخارجي حوت أو ألدوس. مستخدماً بمثابة ببساطة مؤخراَ القارئ المعيار الأصلي ولذلك الصفحة.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 41, new DateTime(2020, 1, 23, 21, 6, 47, 178, DateTimeKind.Local).AddTicks(4034), "Minima eveniet natus nobis est eum maxime ut. Quisquam corporis cupiditate dolorum eligendi asperiores est dolore mollitia qui. Non atque culpa cupiditate omnis doloremque iste reiciendis similique illo. Distinctio est ipsam praesentium delectus.", "سيلهي ما لأنها طبيعياَ شكل مطبعة أخذتها خمسة أخذتها أخذتها. النشر بشكل صناعات حتى الطباعة طويل عشوائي ببساطة التي مثل. هناك أخذتها شكل أو لينتشر. الأحرف عشر ببساطة الخامس توزيعاَ مرة من صناعات عندما.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 40, new DateTime(2019, 8, 22, 22, 15, 40, 598, DateTimeKind.Local).AddTicks(4640), "Commodi qui ipsum vitae. Qui cumque dicta facilis ullam assumenda ea quae sed qui. Incidunt et cum iusto vero quo amet quaerat vel provident. Quam amet dicta.", "الأحرف القرن النص قامت يقرأها صناعات بمعنى. التركيز هو ولذلك أخرى مؤخراَ مع التركيز ولذلك. كبير القارئ إيبسوم هو أخذتها لينتشر خمسة.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 39, new DateTime(2020, 1, 17, 9, 6, 51, 47, DateTimeKind.Local).AddTicks(8398), "Itaque excepturi ratione nobis assumenda ut aperiam ut. Sit maiores quod aut. Aut magni necessitatibus qui nulla occaecati quam quas iusto.", "خمسة عندما نسخ انتشر الخارجي وهي. لم مثل توضع النشر أن أيضاً. الخارجي في والتي ببساطة حتى مع نص لم إيبسوم. الخارجي على استخدام. عشر تقضي هي تحوي توزيعاَ أخذتها مع زمن.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 38, new DateTime(2019, 8, 29, 3, 33, 52, 251, DateTimeKind.Local).AddTicks(2669), "Qui omnis eum dolor et perspiciatis. Inventore et ratione dolor ea tempore. Et quis dolorum totam esse enim. Cumque aliquam et voluptatem. Error explicabo officia enim explicabo.", "وعاد لأنها مع تقضي وهي حتى. طبيعياَ هو صار ظهور الخامس طبيعياَ عشوائي هناك ليتراسيت. هي مقاطع قرون الأحرف أيضاً الأصلي والتي. لهذه تعطي دليل بل عشوائي شكلي مجموعة توزيعاَ عشر هناك.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 49, new DateTime(2019, 12, 22, 19, 30, 0, 850, DateTimeKind.Local).AddTicks(6476), "Eos non ex dolorem veniam porro natus. Ullam neque facere aut. Numquam magnam quia quos odit.", "ويُستخدم استخدام الشكلي الأصلي الخامس والتنضيد مثبتة بمعنى ألدوس. في كان الفقرات شكلي ظهور التركيز مع تعطي عندما. ليتراسيت على خمسة. زمن بل حقيقة المطابع شكل وعاد من. أو أيضاً هو.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 37, new DateTime(2019, 12, 30, 20, 34, 26, 804, DateTimeKind.Local).AddTicks(2049), "Et sint dolores aperiam quis provident saepe esse praesentium rerum. Et iusto libero. Molestiae temporibus ipsa modi modi et corporis quam atque. Minima est aut nam et doloremque. Quo sit et magni autem quia qui.", "أخذتها عشر يقرأها على ستينيّات الشكلي بمثابة. ويُستخدم القارئ ولذلك من مايكر كبير مستخدماً لينتشر الإلكتروني الشكل. الشكل أيضاً طريقة البلاستيكية بل ببساطة قامت بمعنى لينتشر وعاد. إصدار مؤخراَ مايكر مقاطع لأنها للنص.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 35, new DateTime(2019, 9, 5, 14, 13, 29, 935, DateTimeKind.Local).AddTicks(5148), "Labore ratione doloremque fugit neque quia minus exercitationem. Cum suscipit dolorem est. Quo quam aut omnis. Ratione molestiae adipisci fugiat dolor fugit. Laboriosam ratione quia ea nisi repellat.", "طريقة برامج حقيقة الخامس مع البلاستيكية. الإلكتروني مرجع وليس. لأنها يتم ألدوس يتم ما النشر الطباعة رقائق بايج شكلي. قامت لوريم ألدوس توزيعاَ إصدار. الخارجي لتكوّن لتكوّن. سيلهي مثل أيضاً والتي عشر عشوائي.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 34, new DateTime(2019, 11, 5, 2, 26, 12, 908, DateTimeKind.Local).AddTicks(6169), "Voluptatibus sunt dicta impedit voluptatem dolores rem amet est. Rerum nostrum ducimus vel vitae earum cumque nostrum est voluptatum. Sequi tenetur amet omnis cum facilis quia numquam temporibus id. Sunt asperiores dolore quas quod et voluptatem tempora. Non ipsa labore ullam consequatur est corporis officiis iusto qui. Et nisi aut dolorem eos.", "صار مطبعة لأنها توضع منذ. الشكلي هذا ستينيّات مع. شكلي لأنها بل مع. ويُستخدم بايج شكل خمسة الفقرات كتيّب لتكوّن مثبتة. تقضي الغاية أيضاً. لم أو سيلهي.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 33, new DateTime(2019, 12, 16, 12, 18, 36, 624, DateTimeKind.Local).AddTicks(3335), "In non explicabo dolorem quis quos. Voluptatem alias amet rerum blanditiis. Eos totam nesciunt. Voluptatem quos tempora autem libero magni accusamus incidunt. Magni sint eveniet et repellendus voluptates.", "قامت نص ظهور هناك. وعاد بمعنى القارئ. شكل المطابع أو لم توضع. النشر رقائق القرن أخذتها إيبسوم الصفحة طويل الخامس رقائق. دليل كتيّب دليل أو خمسة والتي المعيار المعيار أخرى. ويُستخدم استخدام مرجع تقضي.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 32, new DateTime(2019, 10, 21, 23, 1, 2, 479, DateTimeKind.Local).AddTicks(386), "Quibusdam aut voluptas molestiae. Eius et hic. Soluta dicta explicabo similique dolores et quia voluptates perspiciatis. Nihil quo ut.", "لينتشر من صناعات الشكلي شكلي في مثل الأصلي. خمسة لصفحة التي الزمن مجموعة لصفحة لم الطباعة. لصفحة من مثبتة ولايزال المطابع مستخدماً بمعنى انتشر. عشوائي القارئ وبشكله والتنضيد رقائق النص مجموعة دليل التي زمن.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 31, new DateTime(2020, 2, 9, 6, 49, 0, 947, DateTimeKind.Local).AddTicks(9920), "Et eum ea repellendus optio. Omnis necessitatibus distinctio possimus. Facere ipsum voluptas sint tempora quo veniam. Aperiam esse blanditiis cum mollitia odio ea. Non velit enim dolore. Aut molestiae eligendi ea.", "في هناك للنص مرة زمن نسخ الأصلي لهذه يقرأها. بل وبشكله ستينيّات وليس زمن. الشكلي ألدوس هناك كتيّب من نص لتكوّن انه لهذه. مرجع الخارجي أيضاً وعاد النشر مطبعة بل.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 30, new DateTime(2019, 9, 13, 3, 16, 17, 109, DateTimeKind.Local).AddTicks(3464), "Officiis rem assumenda ea mollitia. Sed et debitis beatae rem voluptate est. Iusto non veritatis dolore ut libero totam ipsum. Nihil laborum enim quos nam deserunt error asperiores sequi. Quis blanditiis officiis tempore quaerat omnis placeat illum voluptas. Dolores assumenda tempora repudiandae impedit.", "المحتوى صار وليس. ألدوس مثل كتيّب أيضاً أخذتها نص والتنضيد بشكل بشكل. عشوائي انتشر عشوائي. ستينيّات مطبعة طويل برامج الخامس.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 29, new DateTime(2020, 3, 14, 13, 34, 31, 262, DateTimeKind.Local).AddTicks(1289), "Facere maxime impedit praesentium quos enim illum et. Voluptatum ducimus enim quo excepturi nihil sunt. Nisi inventore omnis.", "عندما برامج منذ خمسة كتيّب أخرى. الخارجي التي الغاية يقرأها. كتيّب تحوي مقاطع مرة أخذتها كتيّب على تحوي. مجهولة هو أيضاً الخامس. عندما وعاد ليتراسيت تقضي قرون لتكوّن الغاية.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 28, new DateTime(2019, 8, 9, 1, 49, 38, 377, DateTimeKind.Local).AddTicks(2480), "Autem deserunt eaque eos repellat cupiditate molestiae. Quia nemo id. Culpa vel illo quidem excepturi facere omnis et voluptatem quia. Et assumenda tempore odio veniam ea neque et sint ullam.", "الفقرات الأصلي لم ويُستخدم حتى أخرى. عندما الفقرات هو طريقة تعطي زمن صناعات كتيّب طبيعياَ الصفحة. الزمن قامت وعاد لهذه الشكل أخذتها هي المطابع ليتراسيت. الخارجي القرن مقاطع مايكر. مع حوت طبيعياَ لتكوّن أخرى.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 27, new DateTime(2019, 10, 18, 20, 7, 48, 576, DateTimeKind.Local).AddTicks(5893), "Molestiae odit mollitia eum omnis explicabo voluptas culpa. Possimus iste sit laboriosam. Earum atque repellat impedit sed sunt. Quia esse laboriosam qui eum quas quis quisquam numquam ut.", "المعيار منذ كبير. الفقرات أن ولذلك أو لم وعاد. مؤخراَ مطبعة انتشر وعاد استخدام الإلكتروني زمن القارئ هناك القارئ.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 25, new DateTime(2020, 5, 12, 15, 38, 28, 673, DateTimeKind.Local).AddTicks(6779), "Provident at iusto laboriosam beatae quo deserunt quisquam. Nesciunt beatae eligendi inventore ipsum quibusdam ullam aperiam. Sed dolore tempore voluptatem molestiae maiores. Necessitatibus dolorem dolorem rerum commodi quidem tempore doloribus consequuntur.", "أخذتها قامت هو. أخذتها بل وليس المطابع تحوي لتكوّن من لم. الفقرات استخدام الغاية وليس لوريم مرجع لم هذا حتى.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 36, new DateTime(2019, 8, 28, 6, 4, 22, 509, DateTimeKind.Local).AddTicks(553), "Qui nobis quia corrupti qui odio voluptatem cupiditate. Voluptatum dolores eius molestiae. Odio est cupiditate deserunt voluptatem tenetur libero ab. Laudantium dolores et a numquam mollitia fugiat et ab. Qui eos error autem eius officia voluptatem dolorem aliquid. Et nemo et enim.", "طويل برص الأصلي ولذلك تعطي قرون. أيضاً بمثابة ودور حتى شكلي يقرأها بمثابة لصفحة هي خمسة. زمن الخارجي تعطي. لوريم التركيز صناعات بشكل الفقرات.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "DiscoursAr", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 100, new DateTime(2020, 3, 9, 7, 5, 49, 133, DateTimeKind.Local).AddTicks(9203), "Natus repudiandae quae illum omnis quae rerum. In et mollitia voluptatum occaecati consectetur inventore incidunt quisquam. Architecto voluptatibus explicabo ut natus. Vero doloremque recusandae minima. Eius cum nihil error voluptas esse modi alias et. Quia qui neque ex omnis.", "المطابع الزمن الزمن دليل والتنضيد لهذه. بل أخذتها بمثابة الخارجي طريقة أيضاً ويُستخدم البلاستيكية طبيعياَ ولايزال. كان الصفحة ظهور حقيقة ما الخامس. شكل استخدام سيلهي يقرأها الخارجي لوريم برص هي تحوي زمن. أو القارئ المطابع نص برامج أو الشكل التركيز في. تحوي لوريم والتنضيد كان ولايزال كان مايكر التركيز والتي.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 95, new DateTime(2020, 7, 21, 4, 21, 43, 935, DateTimeKind.Local).AddTicks(6958), new DateTime(2020, 7, 20, 16, 9, 42, 830, DateTimeKind.Local).AddTicks(4349), new DateTime(2020, 7, 21, 10, 51, 30, 507, DateTimeKind.Local).AddTicks(8732), 47, "", "http://lisa.com", "https://فريدة.name", "ullam", "لينتشر" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 49, new DateTime(2020, 7, 20, 19, 16, 36, 579, DateTimeKind.Local).AddTicks(1678), new DateTime(2020, 7, 21, 0, 27, 36, 121, DateTimeKind.Local).AddTicks(174), new DateTime(2020, 7, 21, 0, 27, 13, 498, DateTimeKind.Local).AddTicks(6907), 69, "", "https://sacha.fr", "https://إيهاب.name", "veniam", "تعطي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 32, new DateTime(2020, 7, 20, 21, 59, 17, 679, DateTimeKind.Local).AddTicks(9547), new DateTime(2020, 7, 21, 6, 55, 44, 820, DateTimeKind.Local).AddTicks(7353), new DateTime(2020, 7, 21, 13, 20, 43, 267, DateTimeKind.Local).AddTicks(3769), 69, "", "http://lou.eu", "http://أسامة.info", "est", "ولذلك" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 29, new DateTime(2020, 7, 21, 12, 45, 3, 753, DateTimeKind.Local).AddTicks(9565), new DateTime(2020, 7, 21, 7, 58, 58, 56, DateTimeKind.Local).AddTicks(4722), new DateTime(2020, 7, 21, 0, 26, 31, 639, DateTimeKind.Local).AddTicks(4715), 68, "", "https://thomas.com", "https://طارق.net", "laboriosam", "من" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 10, new DateTime(2020, 7, 20, 22, 58, 23, 308, DateTimeKind.Local).AddTicks(8154), new DateTime(2020, 7, 21, 11, 28, 26, 220, DateTimeKind.Local).AddTicks(9657), new DateTime(2020, 7, 20, 15, 5, 55, 167, DateTimeKind.Local).AddTicks(2937), 68, "", "http://adam.com", "http://فاطمة.com", "vero", "بايج" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 61, new DateTime(2020, 7, 21, 13, 12, 20, 852, DateTimeKind.Local).AddTicks(5482), new DateTime(2020, 7, 20, 19, 55, 41, 79, DateTimeKind.Local).AddTicks(6562), new DateTime(2020, 7, 20, 14, 55, 18, 683, DateTimeKind.Local).AddTicks(5789), 67, "", "https://kylian.eu", "https://جمانة.info", "omnis", "في" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 30, new DateTime(2020, 7, 21, 9, 39, 37, 855, DateTimeKind.Local).AddTicks(3154), new DateTime(2020, 7, 21, 1, 9, 41, 283, DateTimeKind.Local).AddTicks(8229), new DateTime(2020, 7, 21, 8, 27, 27, 51, DateTimeKind.Local).AddTicks(5280), 67, "", "https://baptiste.fr", "https://فريدة.biz", "voluptas", "لم" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 81, new DateTime(2020, 7, 21, 9, 31, 1, 87, DateTimeKind.Local).AddTicks(4918), new DateTime(2020, 7, 21, 4, 0, 52, 243, DateTimeKind.Local).AddTicks(6916), new DateTime(2020, 7, 20, 15, 36, 34, 757, DateTimeKind.Local).AddTicks(9141), 66, "", "http://ethan.fr", "http://إيهاب.com", "modi", "مجهولة" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 66, new DateTime(2020, 7, 20, 16, 22, 17, 399, DateTimeKind.Local).AddTicks(5226), new DateTime(2020, 7, 21, 1, 9, 46, 405, DateTimeKind.Local).AddTicks(9054), new DateTime(2020, 7, 21, 4, 1, 5, 220, DateTimeKind.Local).AddTicks(7678), 64, "", "http://ambre.name", "http://آدم.biz", "et", "ولايزال" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 91, new DateTime(2020, 7, 21, 0, 6, 45, 81, DateTimeKind.Local).AddTicks(2384), new DateTime(2020, 7, 21, 11, 4, 11, 545, DateTimeKind.Local).AddTicks(4719), new DateTime(2020, 7, 21, 5, 36, 49, 103, DateTimeKind.Local).AddTicks(7052), 61, "", "http://manon.fr", "https://حسن.info", "voluptates", "تقضي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 37, new DateTime(2020, 7, 21, 11, 32, 52, 293, DateTimeKind.Local).AddTicks(5125), new DateTime(2020, 7, 20, 17, 23, 54, 349, DateTimeKind.Local).AddTicks(6302), new DateTime(2020, 7, 21, 7, 34, 11, 461, DateTimeKind.Local).AddTicks(2274), 61, "", "http://tom.eu", "https://رقية.info", "dolores", "مع" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 24, new DateTime(2020, 7, 20, 23, 45, 33, 906, DateTimeKind.Local).AddTicks(44), new DateTime(2020, 7, 21, 0, 42, 6, 832, DateTimeKind.Local).AddTicks(3235), new DateTime(2020, 7, 20, 15, 59, 26, 22, DateTimeKind.Local).AddTicks(8912), 61, "", "https://alice.fr", "https://فاطمة.info", "quam", "تعطي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 53, new DateTime(2020, 7, 21, 2, 24, 58, 542, DateTimeKind.Local).AddTicks(6429), new DateTime(2020, 7, 20, 18, 45, 12, 291, DateTimeKind.Local).AddTicks(1744), new DateTime(2020, 7, 21, 11, 49, 37, 404, DateTimeKind.Local).AddTicks(9272), 71, "", "https://emilie.fr", "http://آدم.name", "est", "الإلكتروني" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 51, new DateTime(2020, 7, 21, 12, 3, 49, 693, DateTimeKind.Local).AddTicks(6058), new DateTime(2020, 7, 21, 7, 28, 54, 917, DateTimeKind.Local).AddTicks(7694), new DateTime(2020, 7, 20, 15, 25, 55, 861, DateTimeKind.Local).AddTicks(9990), 59, "", "http://théo.info", "https://أسامة.biz", "ad", "إصدار" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 78, new DateTime(2020, 7, 20, 18, 15, 17, 941, DateTimeKind.Local).AddTicks(7315), new DateTime(2020, 7, 21, 10, 28, 4, 4, DateTimeKind.Local).AddTicks(3386), new DateTime(2020, 7, 21, 3, 10, 43, 337, DateTimeKind.Local).AddTicks(3642), 56, "", "https://axel.net", "http://زينب.org", "non", "ليتراسيت" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 64, new DateTime(2020, 7, 20, 18, 10, 32, 522, DateTimeKind.Local).AddTicks(3755), new DateTime(2020, 7, 21, 5, 24, 46, 18, DateTimeKind.Local).AddTicks(1217), new DateTime(2020, 7, 21, 13, 26, 15, 519, DateTimeKind.Local).AddTicks(4544), 56, "", "https://jade.org", "https://إيهاب.info", "qui", "على" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 23, new DateTime(2020, 7, 21, 8, 39, 10, 109, DateTimeKind.Local).AddTicks(9321), new DateTime(2020, 7, 21, 12, 7, 20, 109, DateTimeKind.Local).AddTicks(8654), new DateTime(2020, 7, 21, 8, 57, 36, 928, DateTimeKind.Local).AddTicks(6349), 56, "", "https://lena.fr", "https://فاطمة.info", "qui", "أو" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 85, new DateTime(2020, 7, 21, 12, 24, 20, 382, DateTimeKind.Local).AddTicks(9266), new DateTime(2020, 7, 20, 21, 12, 52, 851, DateTimeKind.Local).AddTicks(3673), new DateTime(2020, 7, 21, 12, 25, 23, 813, DateTimeKind.Local).AddTicks(4439), 54, "", "http://alexandre.eu", "http://فريدة.org", "voluptatibus", "لينتشر" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 54, new DateTime(2020, 7, 20, 20, 14, 34, 637, DateTimeKind.Local).AddTicks(3650), new DateTime(2020, 7, 21, 1, 19, 34, 906, DateTimeKind.Local).AddTicks(5302), new DateTime(2020, 7, 20, 20, 2, 39, 597, DateTimeKind.Local).AddTicks(6325), 54, "", "https://elisa.info", "http://رنا.net", "ut", "بمثابة" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 67, new DateTime(2020, 7, 20, 20, 48, 49, 545, DateTimeKind.Local).AddTicks(7585), new DateTime(2020, 7, 21, 7, 42, 34, 315, DateTimeKind.Local).AddTicks(9219), new DateTime(2020, 7, 20, 23, 8, 41, 158, DateTimeKind.Local).AddTicks(4257), 53, "", "http://raphaël.fr", "http://طارق.com", "quae", "وهي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 41, new DateTime(2020, 7, 21, 6, 32, 17, 613, DateTimeKind.Local).AddTicks(6098), new DateTime(2020, 7, 20, 21, 52, 31, 29, DateTimeKind.Local).AddTicks(3044), new DateTime(2020, 7, 21, 3, 47, 56, 481, DateTimeKind.Local).AddTicks(8202), 53, "", "https://arthur.info", "https://زيد.org", "et", "الفقرات" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 73, new DateTime(2020, 7, 20, 19, 34, 23, 73, DateTimeKind.Local).AddTicks(7771), new DateTime(2020, 7, 20, 19, 39, 53, 575, DateTimeKind.Local).AddTicks(4661), new DateTime(2020, 7, 20, 15, 39, 7, 380, DateTimeKind.Local).AddTicks(9948), 52, "", "http://célia.info", "http://فريدة.name", "est", "استخدام" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 58, new DateTime(2020, 7, 21, 10, 25, 45, 459, DateTimeKind.Local).AddTicks(2265), new DateTime(2020, 7, 20, 15, 57, 10, 428, DateTimeKind.Local).AddTicks(9098), new DateTime(2020, 7, 21, 7, 33, 7, 796, DateTimeKind.Local).AddTicks(5552), 52, "", "http://louna.fr", "http://هاجر.com", "culpa", "الأصلي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 45, new DateTime(2020, 7, 20, 15, 30, 24, 516, DateTimeKind.Local).AddTicks(2689), new DateTime(2020, 7, 20, 21, 38, 7, 748, DateTimeKind.Local).AddTicks(8115), new DateTime(2020, 7, 21, 2, 20, 22, 925, DateTimeKind.Local).AddTicks(7218), 51, "", "https://evan.net", "http://أروى.info", "sit", "الغاية" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 89, new DateTime(2020, 7, 20, 16, 51, 58, 958, DateTimeKind.Local).AddTicks(1073), new DateTime(2020, 7, 20, 20, 15, 23, 817, DateTimeKind.Local).AddTicks(2414), new DateTime(2020, 7, 21, 9, 22, 32, 127, DateTimeKind.Local).AddTicks(2996), 50, "", "http://alicia.org", "https://صلاح.info", "maxime", "نسخ" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 9, new DateTime(2020, 7, 21, 13, 17, 41, 287, DateTimeKind.Local).AddTicks(3835), new DateTime(2020, 7, 20, 20, 9, 53, 162, DateTimeKind.Local).AddTicks(9054), new DateTime(2020, 7, 21, 11, 44, 2, 672, DateTimeKind.Local).AddTicks(9986), 58, "", "https://mathéo.fr", "http://إيهاب.biz", "neque", "القرن" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 22, new DateTime(2020, 7, 20, 17, 46, 7, 271, DateTimeKind.Local).AddTicks(4956), new DateTime(2020, 7, 21, 5, 3, 5, 75, DateTimeKind.Local).AddTicks(2222), new DateTime(2020, 7, 20, 17, 11, 59, 275, DateTimeKind.Local).AddTicks(5243), 74, "", "http://julie.org", "http://أروى.com", "voluptatem", "مؤخراَ" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 100, new DateTime(2020, 7, 21, 4, 2, 7, 217, DateTimeKind.Local).AddTicks(5716), new DateTime(2020, 7, 21, 9, 38, 27, 300, DateTimeKind.Local).AddTicks(7619), new DateTime(2020, 7, 21, 12, 59, 23, 44, DateTimeKind.Local).AddTicks(7919), 74, "", "https://clara.info", "https://آدم.info", "iste", "حتى" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 72, new DateTime(2020, 7, 21, 0, 19, 5, 556, DateTimeKind.Local).AddTicks(6483), new DateTime(2020, 7, 21, 12, 14, 27, 986, DateTimeKind.Local).AddTicks(4592), new DateTime(2020, 7, 20, 22, 5, 43, 179, DateTimeKind.Local).AddTicks(502), 76, "", "https://manon.name", "https://منى.org", "quasi", "منذ" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 42, new DateTime(2020, 7, 21, 5, 7, 43, 220, DateTimeKind.Local).AddTicks(9538), new DateTime(2020, 7, 20, 18, 43, 7, 42, DateTimeKind.Local).AddTicks(1948), new DateTime(2020, 7, 21, 3, 47, 10, 944, DateTimeKind.Local).AddTicks(5291), 97, "", "http://célia.info", "http://أروى.info", "mollitia", "مطبعة" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 27, new DateTime(2020, 7, 21, 12, 47, 1, 62, DateTimeKind.Local).AddTicks(2254), new DateTime(2020, 7, 20, 19, 27, 19, 278, DateTimeKind.Local).AddTicks(9746), new DateTime(2020, 7, 20, 20, 1, 40, 404, DateTimeKind.Local).AddTicks(1074), 96, "", "http://maxime.eu", "https://زيد.biz", "provident", "لأنها" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 26, new DateTime(2020, 7, 20, 23, 21, 35, 476, DateTimeKind.Local).AddTicks(647), new DateTime(2020, 7, 20, 18, 52, 29, 170, DateTimeKind.Local).AddTicks(9997), new DateTime(2020, 7, 21, 3, 0, 26, 254, DateTimeKind.Local).AddTicks(7404), 96, "", "https://nicolas.org", "http://إيهاب.info", "velit", "بمثابة" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 86, new DateTime(2020, 7, 21, 4, 34, 8, 796, DateTimeKind.Local).AddTicks(214), new DateTime(2020, 7, 21, 5, 50, 58, 207, DateTimeKind.Local).AddTicks(7161), new DateTime(2020, 7, 20, 17, 51, 50, 972, DateTimeKind.Local).AddTicks(2065), 95, "", "https://rayan.org", "https://فؤاد.name", "repellat", "زمن" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 65, new DateTime(2020, 7, 20, 22, 11, 18, 413, DateTimeKind.Local).AddTicks(5890), new DateTime(2020, 7, 20, 17, 19, 13, 551, DateTimeKind.Local).AddTicks(9694), new DateTime(2020, 7, 21, 7, 26, 28, 960, DateTimeKind.Local).AddTicks(6697), 95, "", "http://thomas.net", "https://فريد.name", "vel", "الصفحة" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 46, new DateTime(2020, 7, 20, 16, 33, 3, 239, DateTimeKind.Local).AddTicks(9787), new DateTime(2020, 7, 21, 6, 52, 18, 708, DateTimeKind.Local).AddTicks(210), new DateTime(2020, 7, 21, 2, 48, 39, 651, DateTimeKind.Local).AddTicks(2807), 92, "", "http://enzo.org", "http://حسن.name", "harum", "قرون" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 17, new DateTime(2020, 7, 21, 12, 0, 32, 832, DateTimeKind.Local).AddTicks(8588), new DateTime(2020, 7, 20, 16, 17, 13, 154, DateTimeKind.Local).AddTicks(9679), new DateTime(2020, 7, 20, 19, 27, 14, 998, DateTimeKind.Local).AddTicks(7023), 92, "", "https://enzo.name", "https://جمانة.biz", "laudantium", "للنص" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 14, new DateTime(2020, 7, 20, 20, 45, 40, 331, DateTimeKind.Local).AddTicks(6418), new DateTime(2020, 7, 20, 15, 49, 38, 389, DateTimeKind.Local).AddTicks(3124), new DateTime(2020, 7, 20, 21, 44, 54, 217, DateTimeKind.Local).AddTicks(7002), 91, "", "https://elisa.name", "http://حسن.biz", "fugiat", "تحوي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 96, new DateTime(2020, 7, 21, 2, 27, 0, 915, DateTimeKind.Local).AddTicks(6732), new DateTime(2020, 7, 21, 13, 14, 6, 336, DateTimeKind.Local).AddTicks(4032), new DateTime(2020, 7, 21, 9, 36, 27, 720, DateTimeKind.Local).AddTicks(27), 89, "", "http://camille.eu", "https://عبير.biz", "autem", "قامت" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 55, new DateTime(2020, 7, 21, 7, 47, 2, 662, DateTimeKind.Local).AddTicks(2961), new DateTime(2020, 7, 21, 10, 54, 45, 43, DateTimeKind.Local).AddTicks(7015), new DateTime(2020, 7, 21, 10, 52, 38, 717, DateTimeKind.Local).AddTicks(1696), 89, "", "https://rayan.net", "http://فاطمة.org", "nulla", "لينتشر" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 8, new DateTime(2020, 7, 20, 20, 29, 51, 588, DateTimeKind.Local).AddTicks(4911), new DateTime(2020, 7, 21, 6, 24, 51, 338, DateTimeKind.Local).AddTicks(3843), new DateTime(2020, 7, 21, 3, 35, 6, 717, DateTimeKind.Local).AddTicks(3399), 88, "", "https://alicia.net", "https://طارق.net", "voluptas", "المطابع" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 77, new DateTime(2020, 7, 20, 16, 49, 18, 317, DateTimeKind.Local).AddTicks(1112), new DateTime(2020, 7, 21, 1, 5, 56, 268, DateTimeKind.Local).AddTicks(3956), new DateTime(2020, 7, 21, 0, 36, 57, 772, DateTimeKind.Local).AddTicks(1726), 87, "", "http://raphaël.org", "https://جمانة.com", "necessitatibus", "لأنها" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 12, new DateTime(2020, 7, 20, 14, 58, 41, 170, DateTimeKind.Local).AddTicks(8100), new DateTime(2020, 7, 21, 0, 54, 54, 943, DateTimeKind.Local).AddTicks(3555), new DateTime(2020, 7, 21, 13, 12, 6, 112, DateTimeKind.Local).AddTicks(6782), 87, "", "https://mael.info", "http://آية.name", "quibusdam", "التركيز" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 84, new DateTime(2020, 7, 21, 4, 39, 7, 522, DateTimeKind.Local).AddTicks(7078), new DateTime(2020, 7, 20, 19, 25, 34, 742, DateTimeKind.Local).AddTicks(9944), new DateTime(2020, 7, 21, 3, 48, 2, 113, DateTimeKind.Local).AddTicks(9886), 86, "", "https://juliette.net", "http://سعيد.net", "nulla", "الزمن" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 21, new DateTime(2020, 7, 21, 9, 11, 21, 883, DateTimeKind.Local).AddTicks(3235), new DateTime(2020, 7, 21, 14, 23, 1, 511, DateTimeKind.Local).AddTicks(2964), new DateTime(2020, 7, 21, 7, 26, 1, 388, DateTimeKind.Local).AddTicks(140), 86, "", "http://manon.name", "http://جابر‌.net", "possimus", "مثبتة" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 99, new DateTime(2020, 7, 20, 22, 45, 34, 784, DateTimeKind.Local).AddTicks(7727), new DateTime(2020, 7, 21, 10, 11, 37, 955, DateTimeKind.Local).AddTicks(8492), new DateTime(2020, 7, 21, 12, 10, 41, 702, DateTimeKind.Local).AddTicks(9432), 84, "", "https://noa.com", "http://رقية.info", "omnis", "المقروء" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 6, new DateTime(2020, 7, 21, 14, 9, 30, 469, DateTimeKind.Local).AddTicks(7780), new DateTime(2020, 7, 21, 6, 6, 42, 941, DateTimeKind.Local).AddTicks(3513), new DateTime(2020, 7, 20, 15, 40, 33, 822, DateTimeKind.Local).AddTicks(1249), 84, "", "http://mattéo.net", "https://شيماء.biz", "accusantium", "الإلكتروني" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 25, new DateTime(2020, 7, 21, 12, 43, 28, 819, DateTimeKind.Local).AddTicks(418), new DateTime(2020, 7, 21, 9, 56, 46, 636, DateTimeKind.Local).AddTicks(8394), new DateTime(2020, 7, 20, 16, 56, 40, 404, DateTimeKind.Local).AddTicks(1225), 83, "", "http://eva.org", "http://سعيد.biz", "delectus", "هو" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 69, new DateTime(2020, 7, 21, 4, 44, 30, 153, DateTimeKind.Local).AddTicks(8680), new DateTime(2020, 7, 21, 0, 50, 25, 456, DateTimeKind.Local).AddTicks(1133), new DateTime(2020, 7, 21, 10, 2, 3, 894, DateTimeKind.Local).AddTicks(2644), 81, "", "http://yanis.net", "https://فريد.info", "ut", "ليتراسيت" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 38, new DateTime(2020, 7, 20, 17, 14, 8, 596, DateTimeKind.Local).AddTicks(5987), new DateTime(2020, 7, 20, 19, 18, 38, 158, DateTimeKind.Local).AddTicks(7437), new DateTime(2020, 7, 20, 23, 32, 46, 190, DateTimeKind.Local).AddTicks(9923), 80, "", "https://manon.net", "https://أروى.name", "ut", "هو" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 97, new DateTime(2020, 7, 21, 1, 33, 49, 747, DateTimeKind.Local).AddTicks(6845), new DateTime(2020, 7, 21, 0, 53, 8, 488, DateTimeKind.Local).AddTicks(7476), new DateTime(2020, 7, 21, 7, 31, 27, 965, DateTimeKind.Local).AddTicks(3236), 78, "", "https://mael.fr", "http://إيناس.org", "sit", "المطابع" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 57, new DateTime(2020, 7, 21, 2, 35, 5, 12, DateTimeKind.Local).AddTicks(103), new DateTime(2020, 7, 21, 0, 50, 25, 149, DateTimeKind.Local).AddTicks(283), new DateTime(2020, 7, 20, 23, 28, 57, 26, DateTimeKind.Local).AddTicks(5160), 78, "", "https://mathilde.info", "https://آدم.biz", "occaecati", "ليتراسيت" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 1, new DateTime(2020, 7, 21, 8, 50, 1, 205, DateTimeKind.Local).AddTicks(7993), new DateTime(2020, 7, 21, 0, 39, 59, 626, DateTimeKind.Local).AddTicks(53), new DateTime(2020, 7, 20, 22, 2, 36, 129, DateTimeKind.Local).AddTicks(5147), 78, "", "https://mathilde.eu", "http://سارة.net", "cupiditate", "ويُستخدم" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 88, new DateTime(2020, 7, 21, 7, 59, 30, 492, DateTimeKind.Local).AddTicks(3366), new DateTime(2020, 7, 20, 19, 56, 58, 884, DateTimeKind.Local).AddTicks(5704), new DateTime(2020, 7, 21, 9, 27, 8, 878, DateTimeKind.Local).AddTicks(5450), 77, "", "http://louise.fr", "http://حازم.name", "fuga", "هو" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 98, new DateTime(2020, 7, 20, 22, 1, 17, 44, DateTimeKind.Local).AddTicks(1489), new DateTime(2020, 7, 21, 2, 1, 45, 863, DateTimeKind.Local).AddTicks(8628), new DateTime(2020, 7, 21, 8, 51, 42, 475, DateTimeKind.Local).AddTicks(6640), 76, "", "https://raphaël.org", "http://لمى.info", "iure", "تحوي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 93, new DateTime(2020, 7, 21, 13, 44, 30, 750, DateTimeKind.Local).AddTicks(3090), new DateTime(2020, 7, 21, 3, 21, 31, 700, DateTimeKind.Local).AddTicks(2125), new DateTime(2020, 7, 20, 15, 22, 49, 501, DateTimeKind.Local).AddTicks(9439), 49, "", "https://juliette.org", "http://إيناس.net", "sit", "شكل" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 92, new DateTime(2020, 7, 21, 4, 27, 10, 761, DateTimeKind.Local).AddTicks(5479), new DateTime(2020, 7, 20, 20, 48, 53, 664, DateTimeKind.Local).AddTicks(8968), new DateTime(2020, 7, 21, 7, 51, 21, 46, DateTimeKind.Local).AddTicks(252), 49, "", "https://pierre.fr", "http://زيد.info", "optio", "إيبسوم" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 70, new DateTime(2020, 7, 20, 17, 6, 14, 682, DateTimeKind.Local).AddTicks(9812), new DateTime(2020, 7, 20, 22, 17, 54, 517, DateTimeKind.Local).AddTicks(9535), new DateTime(2020, 7, 20, 22, 8, 49, 500, DateTimeKind.Local).AddTicks(8340), 99, "", "http://lina.com", "https://شيماء.org", "fuga", "عن" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 90, new DateTime(2020, 7, 20, 19, 12, 38, 122, DateTimeKind.Local).AddTicks(6147), new DateTime(2020, 7, 21, 14, 48, 24, 355, DateTimeKind.Local).AddTicks(1705), new DateTime(2020, 7, 20, 23, 36, 28, 110, DateTimeKind.Local).AddTicks(9923), 47, "", "https://théo.fr", "https://سالم.net", "blanditiis", "ما" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 52, new DateTime(2020, 7, 21, 7, 17, 22, 113, DateTimeKind.Local).AddTicks(3766), new DateTime(2020, 7, 21, 0, 39, 36, 224, DateTimeKind.Local).AddTicks(9130), new DateTime(2020, 7, 21, 4, 44, 13, 416, DateTimeKind.Local).AddTicks(3227), 25, "", "http://ambre.org", "http://أمجد.com", "neque", "بمعنى" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 76, new DateTime(2020, 7, 21, 2, 19, 42, 95, DateTimeKind.Local).AddTicks(4683), new DateTime(2020, 7, 20, 15, 10, 29, 512, DateTimeKind.Local).AddTicks(6372), new DateTime(2020, 7, 20, 18, 43, 35, 839, DateTimeKind.Local).AddTicks(4280), 24, "", "http://victor.name", "https://إيهاب.org", "ratione", "للنص" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 15, new DateTime(2020, 7, 21, 14, 30, 27, 713, DateTimeKind.Local).AddTicks(8282), new DateTime(2020, 7, 20, 22, 44, 8, 465, DateTimeKind.Local).AddTicks(3898), new DateTime(2020, 7, 21, 13, 56, 53, 797, DateTimeKind.Local).AddTicks(2537), 22, "", "http://paul.org", "http://عبير.info", "illum", "أخذتها" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 5, new DateTime(2020, 7, 20, 15, 28, 4, 286, DateTimeKind.Local).AddTicks(2749), new DateTime(2020, 7, 21, 7, 49, 12, 513, DateTimeKind.Local).AddTicks(6500), new DateTime(2020, 7, 21, 11, 18, 34, 503, DateTimeKind.Local).AddTicks(1744), 21, "", "https://thomas.org", "http://فريد.name", "hic", "هذا" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 28, new DateTime(2020, 7, 21, 6, 3, 34, 347, DateTimeKind.Local).AddTicks(6739), new DateTime(2020, 7, 20, 17, 43, 36, 211, DateTimeKind.Local).AddTicks(4861), new DateTime(2020, 7, 21, 9, 20, 39, 755, DateTimeKind.Local).AddTicks(8798), 98, "", "https://valentin.fr", "https://فاطمة.name", "sit", "إصدار" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 40, new DateTime(2020, 7, 21, 12, 36, 35, 686, DateTimeKind.Local).AddTicks(9145), new DateTime(2020, 7, 21, 5, 27, 19, 872, DateTimeKind.Local).AddTicks(5916), new DateTime(2020, 7, 21, 9, 21, 24, 58, DateTimeKind.Local).AddTicks(2613), 15, "", "http://louise.com", "https://حسن.name", "dolor", "بشكل" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 43, new DateTime(2020, 7, 20, 21, 47, 57, 756, DateTimeKind.Local).AddTicks(699), new DateTime(2020, 7, 20, 15, 47, 51, 630, DateTimeKind.Local).AddTicks(2044), new DateTime(2020, 7, 20, 16, 52, 9, 315, DateTimeKind.Local).AddTicks(9012), 11, "", "http://axel.fr", "https://فريدة.biz", "voluptatem", "استخدام" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 34, new DateTime(2020, 7, 21, 11, 6, 20, 886, DateTimeKind.Local).AddTicks(7172), new DateTime(2020, 7, 21, 13, 35, 27, 714, DateTimeKind.Local).AddTicks(1553), new DateTime(2020, 7, 21, 4, 31, 10, 444, DateTimeKind.Local).AddTicks(9671), 11, "", "http://noah.com", "https://إيهاب.com", "voluptas", "لهذه" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 31, new DateTime(2020, 7, 21, 4, 53, 33, 797, DateTimeKind.Local).AddTicks(8321), new DateTime(2020, 7, 20, 19, 0, 30, 806, DateTimeKind.Local).AddTicks(9546), new DateTime(2020, 7, 20, 16, 15, 57, 793, DateTimeKind.Local).AddTicks(4738), 26, "", "https://pauline.net", "https://سعيد.info", "reiciendis", "الطباعة" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 35, new DateTime(2020, 7, 21, 12, 51, 5, 755, DateTimeKind.Local).AddTicks(3259), new DateTime(2020, 7, 20, 18, 39, 19, 728, DateTimeKind.Local).AddTicks(662), new DateTime(2020, 7, 21, 0, 11, 28, 140, DateTimeKind.Local).AddTicks(6837), 10, "", "https://quentin.eu", "http://زيد.biz", "doloremque", "مرجع" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 79, new DateTime(2020, 7, 21, 13, 18, 18, 322, DateTimeKind.Local).AddTicks(417), new DateTime(2020, 7, 21, 3, 7, 0, 933, DateTimeKind.Local).AddTicks(5189), new DateTime(2020, 7, 20, 20, 49, 16, 745, DateTimeKind.Local).AddTicks(9199), 8, "", "http://mattéo.name", "http://دانا.com", "sapiente", "تقضي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 4, new DateTime(2020, 7, 20, 15, 41, 4, 711, DateTimeKind.Local).AddTicks(1112), new DateTime(2020, 7, 21, 12, 58, 34, 374, DateTimeKind.Local).AddTicks(5356), new DateTime(2020, 7, 20, 23, 18, 45, 72, DateTimeKind.Local).AddTicks(6607), 7, "", "http://pauline.info", "http://سارة.net", "eum", "التي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 16, new DateTime(2020, 7, 21, 3, 16, 5, 419, DateTimeKind.Local).AddTicks(5179), new DateTime(2020, 7, 20, 17, 19, 4, 917, DateTimeKind.Local).AddTicks(3555), new DateTime(2020, 7, 21, 7, 58, 10, 759, DateTimeKind.Local).AddTicks(1061), 5, "", "https://adrien.org", "https://فريد.biz", "qui", "إيبسوم" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 18, new DateTime(2020, 7, 21, 11, 40, 18, 11, DateTimeKind.Local).AddTicks(9071), new DateTime(2020, 7, 21, 7, 57, 35, 894, DateTimeKind.Local).AddTicks(1559), new DateTime(2020, 7, 20, 19, 19, 39, 69, DateTimeKind.Local).AddTicks(5510), 3, "", "https://maëlle.info", "https://سعيد.name", "ad", "طويل" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 2, new DateTime(2020, 7, 21, 7, 20, 8, 574, DateTimeKind.Local).AddTicks(2036), new DateTime(2020, 7, 21, 13, 14, 42, 252, DateTimeKind.Local).AddTicks(1119), new DateTime(2020, 7, 21, 5, 53, 34, 483, DateTimeKind.Local).AddTicks(8165), 3, "", "http://justine.eu", "https://فؤاد.info", "delectus", "التي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 59, new DateTime(2020, 7, 21, 9, 48, 26, 506, DateTimeKind.Local).AddTicks(1900), new DateTime(2020, 7, 20, 15, 39, 16, 642, DateTimeKind.Local).AddTicks(5974), new DateTime(2020, 7, 20, 21, 30, 57, 865, DateTimeKind.Local).AddTicks(7923), 2, "", "https://lucas.net", "http://إيهاب.net", "quas", "أخذتها" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 82, new DateTime(2020, 7, 21, 3, 38, 3, 943, DateTimeKind.Local).AddTicks(231), new DateTime(2020, 7, 20, 20, 14, 48, 282, DateTimeKind.Local).AddTicks(783), new DateTime(2020, 7, 21, 1, 40, 13, 906, DateTimeKind.Local).AddTicks(535), 1, "", "https://julie.org", "http://لمى.com", "praesentium", "انتشر" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 68, new DateTime(2020, 7, 21, 14, 38, 6, 25, DateTimeKind.Local).AddTicks(5400), new DateTime(2020, 7, 21, 6, 31, 10, 327, DateTimeKind.Local).AddTicks(5076), new DateTime(2020, 7, 20, 20, 19, 47, 10, DateTimeKind.Local).AddTicks(9135), 1, "", "http://lisa.org", "https://إيهاب.name", "nostrum", "الشكل" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 83, new DateTime(2020, 7, 20, 20, 22, 2, 453, DateTimeKind.Local).AddTicks(7501), new DateTime(2020, 7, 21, 12, 36, 17, 985, DateTimeKind.Local).AddTicks(4354), new DateTime(2020, 7, 21, 0, 40, 38, 372, DateTimeKind.Local).AddTicks(1754), 9, "", "https://alexandre.info", "https://زينب.info", "consequatur", "وعاد" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 75, new DateTime(2020, 7, 21, 9, 38, 27, 54, DateTimeKind.Local).AddTicks(7057), new DateTime(2020, 7, 21, 1, 33, 15, 496, DateTimeKind.Local).AddTicks(1206), new DateTime(2020, 7, 21, 10, 52, 46, 387, DateTimeKind.Local).AddTicks(4728), 26, "", "http://juliette.com", "http://جمانة.net", "accusantium", "دليل" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 44, new DateTime(2020, 7, 21, 3, 17, 19, 60, DateTimeKind.Local).AddTicks(1770), new DateTime(2020, 7, 20, 20, 2, 38, 99, DateTimeKind.Local).AddTicks(1564), new DateTime(2020, 7, 21, 3, 48, 28, 862, DateTimeKind.Local).AddTicks(3495), 16, "", "http://lisa.com", "http://سارة.org", "inventore", "انه" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 3, new DateTime(2020, 7, 20, 16, 33, 40, 513, DateTimeKind.Local).AddTicks(5272), new DateTime(2020, 7, 21, 6, 7, 27, 126, DateTimeKind.Local).AddTicks(4448), new DateTime(2020, 7, 20, 21, 45, 54, 104, DateTimeKind.Local).AddTicks(5845), 28, "", "https://nathan.name", "https://دانا.info", "perspiciatis", "لم" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 36, new DateTime(2020, 7, 20, 21, 0, 51, 934, DateTimeKind.Local).AddTicks(5299), new DateTime(2020, 7, 21, 1, 18, 25, 476, DateTimeKind.Local).AddTicks(5475), new DateTime(2020, 7, 21, 3, 48, 16, 79, DateTimeKind.Local).AddTicks(7283), 46, "", "https://baptiste.com", "http://صلاح.biz", "tempore", "لأنها" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 7, new DateTime(2020, 7, 21, 4, 24, 40, 66, DateTimeKind.Local).AddTicks(8325), new DateTime(2020, 7, 21, 14, 7, 25, 71, DateTimeKind.Local).AddTicks(2839), new DateTime(2020, 7, 21, 7, 57, 25, 537, DateTimeKind.Local).AddTicks(2100), 46, "", "https://pierre.fr", "https://هاجر.name", "quia", "منذ" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 48, new DateTime(2020, 7, 21, 11, 47, 16, 204, DateTimeKind.Local).AddTicks(2679), new DateTime(2020, 7, 20, 19, 24, 44, 690, DateTimeKind.Local).AddTicks(8456), new DateTime(2020, 7, 21, 3, 6, 9, 478, DateTimeKind.Local).AddTicks(4950), 27, "", "http://louis.org", "https://أمجد.net", "deleniti", "حتى" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 87, new DateTime(2020, 7, 20, 19, 46, 29, 375, DateTimeKind.Local).AddTicks(4321), new DateTime(2020, 7, 20, 22, 8, 14, 902, DateTimeKind.Local).AddTicks(3066), new DateTime(2020, 7, 21, 2, 7, 34, 521, DateTimeKind.Local).AddTicks(3490), 44, "", "http://lola.eu", "https://فؤاد.biz", "est", "التي" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 60, new DateTime(2020, 7, 21, 2, 29, 12, 644, DateTimeKind.Local).AddTicks(5156), new DateTime(2020, 7, 21, 12, 30, 0, 498, DateTimeKind.Local).AddTicks(2942), new DateTime(2020, 7, 20, 21, 41, 33, 805, DateTimeKind.Local).AddTicks(6745), 44, "", "http://ethan.net", "https://ربيع.info", "similique", "المقروء" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 80, new DateTime(2020, 7, 21, 10, 16, 14, 100, DateTimeKind.Local).AddTicks(3993), new DateTime(2020, 7, 21, 4, 44, 45, 28, DateTimeKind.Local).AddTicks(1863), new DateTime(2020, 7, 20, 16, 52, 16, 592, DateTimeKind.Local).AddTicks(7266), 42, "", "https://pauline.org", "https://جابر‌.net", "voluptatem", "ما" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 63, new DateTime(2020, 7, 21, 6, 40, 53, 801, DateTimeKind.Local).AddTicks(7760), new DateTime(2020, 7, 21, 4, 47, 25, 95, DateTimeKind.Local).AddTicks(3535), new DateTime(2020, 7, 20, 19, 43, 45, 587, DateTimeKind.Local).AddTicks(1354), 42, "", "http://jules.fr", "http://أسامة.name", "id", "لينتشر" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 20, new DateTime(2020, 7, 21, 0, 33, 51, 890, DateTimeKind.Local).AddTicks(1688), new DateTime(2020, 7, 21, 4, 13, 45, 125, DateTimeKind.Local).AddTicks(6364), new DateTime(2020, 7, 21, 5, 22, 37, 657, DateTimeKind.Local).AddTicks(7202), 42, "", "http://ethan.eu", "https://سالم.info", "vel", "بايج" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 56, new DateTime(2020, 7, 21, 1, 10, 54, 19, DateTimeKind.Local).AddTicks(1890), new DateTime(2020, 7, 20, 17, 53, 22, 688, DateTimeKind.Local).AddTicks(1811), new DateTime(2020, 7, 21, 14, 21, 23, 23, DateTimeKind.Local).AddTicks(3923), 41, "", "https://romane.org", "http://إيهاب.com", "est", "مؤخراَ" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 33, new DateTime(2020, 7, 21, 14, 22, 1, 797, DateTimeKind.Local).AddTicks(704), new DateTime(2020, 7, 21, 0, 7, 51, 943, DateTimeKind.Local).AddTicks(2252), new DateTime(2020, 7, 20, 16, 32, 4, 291, DateTimeKind.Local).AddTicks(9106), 45, "", "http://baptiste.net", "https://حازم.org", "vel", "منذ" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 19, new DateTime(2020, 7, 21, 0, 6, 7, 596, DateTimeKind.Local).AddTicks(9033), new DateTime(2020, 7, 20, 18, 31, 15, 185, DateTimeKind.Local).AddTicks(5397), new DateTime(2020, 7, 21, 2, 20, 16, 726, DateTimeKind.Local).AddTicks(4148), 39, "", "http://axel.info", "https://ربيع.net", "et", "كبير" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 39, new DateTime(2020, 7, 20, 16, 35, 5, 981, DateTimeKind.Local).AddTicks(7226), new DateTime(2020, 7, 21, 10, 50, 36, 6, DateTimeKind.Local).AddTicks(2013), new DateTime(2020, 7, 20, 20, 33, 16, 194, DateTimeKind.Local).AddTicks(7861), 38, "", "http://yanis.name", "http://رقية.name", "omnis", "أخرى" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 74, new DateTime(2020, 7, 20, 18, 31, 47, 307, DateTimeKind.Local).AddTicks(3629), new DateTime(2020, 7, 21, 3, 59, 46, 3, DateTimeKind.Local).AddTicks(8070), new DateTime(2020, 7, 21, 14, 27, 5, 145, DateTimeKind.Local).AddTicks(9975), 35, "", "https://théo.name", "http://لمى.name", "dignissimos", "حقيقة" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 11, new DateTime(2020, 7, 20, 23, 15, 57, 537, DateTimeKind.Local).AddTicks(9187), new DateTime(2020, 7, 21, 4, 3, 45, 3, DateTimeKind.Local).AddTicks(7939), new DateTime(2020, 7, 20, 15, 52, 17, 311, DateTimeKind.Local).AddTicks(9904), 35, "", "https://yanis.fr", "http://جمانة.info", "officiis", "لهذه" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 94, new DateTime(2020, 7, 21, 12, 55, 43, 792, DateTimeKind.Local).AddTicks(3537), new DateTime(2020, 7, 21, 2, 9, 9, 461, DateTimeKind.Local).AddTicks(2990), new DateTime(2020, 7, 21, 3, 30, 30, 578, DateTimeKind.Local).AddTicks(3391), 34, "", "http://elisa.info", "http://إيهاب.name", "dignissimos", "توزيعاَ" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 50, new DateTime(2020, 7, 20, 20, 45, 15, 159, DateTimeKind.Local).AddTicks(6346), new DateTime(2020, 7, 21, 8, 25, 17, 145, DateTimeKind.Local).AddTicks(4336), new DateTime(2020, 7, 20, 23, 59, 37, 399, DateTimeKind.Local).AddTicks(8258), 33, "", "http://lucas.eu", "https://فاطمة.info", "autem", "ما" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 71, new DateTime(2020, 7, 21, 12, 4, 50, 641, DateTimeKind.Local).AddTicks(4714), new DateTime(2020, 7, 20, 17, 27, 36, 525, DateTimeKind.Local).AddTicks(7785), new DateTime(2020, 7, 20, 19, 17, 6, 16, DateTimeKind.Local).AddTicks(6428), 31, "", "http://paul.info", "https://فاطمة.info", "nihil", "بشكل" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 13, new DateTime(2020, 7, 21, 11, 33, 27, 374, DateTimeKind.Local).AddTicks(4884), new DateTime(2020, 7, 21, 2, 7, 22, 995, DateTimeKind.Local).AddTicks(3109), new DateTime(2020, 7, 20, 22, 5, 53, 210, DateTimeKind.Local).AddTicks(1688), 31, "", "http://carla.com", "http://أروى.biz", "ipsam", "لوريم" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 47, new DateTime(2020, 7, 21, 11, 30, 49, 561, DateTimeKind.Local).AddTicks(386), new DateTime(2020, 7, 20, 18, 17, 23, 849, DateTimeKind.Local).AddTicks(7374), new DateTime(2020, 7, 21, 14, 3, 13, 150, DateTimeKind.Local).AddTicks(4361), 28, "", "http://carla.eu", "https://فاروق.net", "voluptate", "على" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "ReferenceAr", "Titre", "TitreAr" },
                values: new object[] { 62, new DateTime(2020, 7, 21, 13, 45, 46, 399, DateTimeKind.Local).AddTicks(6455), new DateTime(2020, 7, 21, 12, 22, 3, 971, DateTimeKind.Local).AddTicks(6462), new DateTime(2020, 7, 21, 5, 38, 3, 266, DateTimeKind.Local).AddTicks(8684), 39, "", "http://pauline.fr", "https://هاجر.name", "officiis", "بشكل" });

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
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 6, "0.7.4.7", "5.5.7.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "تحوي بمثابة حوت الأصلي.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أو لينتشر في القارئ.", 97, 7, null, 6, 2, 1, null, "Procédure spéciale", "هيئات المعاهدات", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عندما بشكل مجموعة الشكل أو. كتيّب طبيعياَ وهي عشوائي بل يقرأها ولايزال بشكل نص.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 58, "9.7.3.5", "0.2.3.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أن المحتوى المطابع صناعات هي. عن قامت يقرأها دليل لتكوّن أن التي. لهذه إصدار قرون عشر لأنها.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لهذه مستخدماً أن هناك. المحتوى ودور يتم. طبيعياَ حقيقة والتنضيد لصفحة صار هي هناك. مثبتة البلاستيكية عشر عن أخذتها خمسة يقرأها مقاطع.", 63, 6, 5, null, 4, 4, null, "Procédure spéciale", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "من برامج إصدار وعاد على بل الصفحة. مثل المعيار عندما الإلكتروني. طويل مثبتة سيلهي ستينيّات ودور قامت بمثابة الإلكتروني. مقاطع نسخ صار مثبتة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 51, "3.0.0.1", "3.4.2.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مرة أخذتها الطباعة الإلكتروني أيضاً المطابع هذا. الشكلي لينتشر وليس ليتراسيت طويل نسخ شكل المحتوى مستخدماً. نص هي ستينيّات بشكل.", "Réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ولذلك للنص لوريم من وبشكله من ألدوس مجهولة عن كان. دليل على مجموعة القارئ بشكل ما حقيقة حقيقة الخارجي عن. إصدار كتيّب طريقة توزيعاَ أيضاً.", 9, 2, null, 4, 2, 4, null, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "قرون مرجع زمن مايكر. ظهور شكلي كبير يتم أخرى. لينتشر المقروء عشر إيبسوم نص. مرة هي رقائق تعطي نص مجموعة حوت أيضاً صناعات.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 47, "2.5.0.8", "4.2.1.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "القرن من طريقة عندما مع تحوي زمن توضع صناعات بايج. لم البلاستيكية برامج البلاستيكية لأنها شكلي كتيّب انتشر النشر. القارئ أخرى توزيعاَ أخرى. مجهولة هناك مجموعة عشوائي ولايزال شكل لتكوّن لم مرة.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "تعطي لهذه كبير صناعات حوت. دليل أو دليل تعطي بشكل دليل الخارجي القارئ. هي المعيار بمعنى ويُستخدم انتشر.", 66, 4, null, null, 3, 4, 4, "Procédure spéciale", "هيئات المعاهدات", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "قرون توضع من انه الفقرات. شكلي المعيار وليس.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 45, "4.4.3.2", "9.7.7.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الطباعة كتيّب الشكل والتي. حتى استخدام حقيقة كتيّب الفقرات ولذلك صناعات من بمثابة انتشر.", "Réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لصفحة لينتشر الطباعة القارئ المطابع توزيعاَ على إيبسوم. حقيقة لوريم استخدام توزيعاَ. بشكل طويل طويل.", 90, 3, null, 4, 4, 4, null, "Organes de traités", "الاستعراض الدوري الشامل", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "وعاد ليتراسيت والتنضيد مجموعة تعطي طريقة مايكر على. مايكر طويل الخارجي وعاد القارئ دليل الأحرف. المقروء الغاية انتشر مجهولة طبيعياَ.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 35, "9.6.6.8", "2.6.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "توضع برص مثبتة بشكل وبشكله طويل القارئ. انه خمسة الشكل بايج هي الشكلي لينتشر.", "En continue", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ستينيّات المعيار حقيقة مؤخراَ. صار للنص والتنضيد الزمن للنص الغاية أو طريقة للنص ظهور.", 58, 7, null, null, 1, 4, 2, "Organes de traités", "الاستعراض الدوري الشامل", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أخرى تقضي ودور ظهور التركيز تقضي الطباعة وليس تحوي التي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 30, "2.1.7.1", "3.4.5.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مؤخراَ توضع مستخدماً الأحرف حقيقة وبشكله استخدام مع تحوي الفقرات. مؤخراَ للنص لينتشر بايج حقيقة طبيعياَ طويل للنص النشر. نسخ المحتوى التي التي. مثل لم الخارجي ولايزال يقرأها سيلهي مايكر ببساطة انه.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "منذ عشر إيبسوم تحوي مؤخراَ هناك مع. المطابع انه مجهولة الشكل يقرأها المعيار من خمسة الإلكتروني عشوائي.", 82, 5, null, 5, 1, 4, null, "Examen périodique universal", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عن الأصلي المقروء المطابع هذا أيضاً يقرأها.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 14, "1.3.2.0", "8.1.5.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ما الخامس تقضي والتنضيد ولايزال والتي الطباعة ليتراسيت. برامج في من قرون قامت حوت مثبتة حوت منذ. المحتوى طريقة لهذه وليس الزمن مستخدماً مستخدماً وليس الطباعة ويُستخدم.", "En continue", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "برامج برص أخذتها. حقيقة شكل الأصلي لأنها الزمن المقروء زمن بل. وعاد ليتراسيت زمن ما طويل كان هي التي طريقة.", 85, 6, null, null, 3, 4, 7, "Organes de traités", "الاستعراض الدوري الشامل", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "طويل هي هناك الخامس ستينيّات النشر الغاية لوريم. الإلكتروني لينتشر مستخدماً ما على مثل أيضاً إصدار. عن الخامس البلاستيكية وليس الزمن مطبعة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 86, "1.1.9.3", "0.2.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مجموعة المطابع أخذتها قامت توضع مطبعة.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الأحرف النشر بمثابة إيبسوم منذ ودور وهي دليل وليس القارئ. ببساطة صناعات ولذلك برامج إيبسوم الغاية. القارئ الفقرات لم أيضاً التي بل الطباعة ويُستخدم. الخامس بايج الغاية انه منذ.", 47, 5, null, null, 3, 10, 6, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ظهور طويل نسخ الخارجي بمعنى وليس لتكوّن حوت وهي. مقاطع تعطي لأنها صناعات رقائق هذا. برامج شكلي تعطي بل. عشر شكل حتى الشكل الخارجي إصدار لينتشر.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 68, "9.5.9.1", "4.6.7.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ولذلك النص مقاطع البلاستيكية حقيقة.", "En cours", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الفقرات لصفحة لهذه في تقضي نص تقضي. عشوائي هذا التركيز مرة بمثابة نسخ. لم انتشر لصفحة.", 70, 4, null, null, 3, 10, 10, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مرة على للنص حقيقة كتيّب. الشكل انتشر بايج التركيز الأصلي كان ستينيّات قامت. بل القارئ لأنها النص ببساطة الإلكتروني في تحوي. مجهولة سيلهي خمسة بايج البلاستيكية برص دليل صار.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 54, "0.0.9.3", "6.4.7.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "توضع لينتشر مقاطع الشكل صناعات استخدام شكلي الأحرف وبشكله.", "En cours", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "صناعات منذ عشوائي برامج هذا قامت.", 17, 4, null, 1, 1, 10, null, "Procédure spéciale", "الإجراءات الخاصة", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "شكل الأحرف لينتشر حقيقة تحوي على عشر مثل هي. مطبعة مايكر لتكوّن مرجع. للنص المعيار والتنضيد على مؤخراَ هناك بشكل.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 44, "6.2.9.9", "8.2.0.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لم لتكوّن بل دليل لأنها للنص.", "En continue", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "وهي أيضاً الخامس عن عن إصدار قرون مثبتة. الأصلي حوت الشكلي مرجع الشكل القرن.", 69, 3, null, null, 4, 10, 2, "Examen périodique universal", "الاستعراض الدوري الشامل", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بايج على التي الغاية. التي إصدار أخذتها.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 40, "7.2.9.2", "2.1.8.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الأحرف طريقة نسخ.", "En continue", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "زمن وبشكله لتكوّن لوريم مثل ستينيّات دليل أخرى سيلهي. على في توزيعاَ ببساطة نص كبير برص حتى والتي.", 46, 5, 9, null, 3, 10, null, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ودور التركيز كتيّب الإلكتروني وعاد ستينيّات هي لصفحة طويل النص. عشوائي القرن مستخدماً ستينيّات المقروء ودور مجموعة لينتشر. الإلكتروني هي على الخارجي لهذه عن.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 25, "1.5.6.8", "9.6.9.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المعيار أن نسخ خمسة ببساطة مرجع أخرى لصفحة بايج.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "وعاد لم تحوي والتنضيد حتى في والتي تقضي. تحوي هو ولايزال طويل استخدام برص بشكل يقرأها وعاد.", 81, 5, 5, null, 3, 10, null, "Examen périodique universal", "هيئات المعاهدات", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مؤخراَ ولذلك ألدوس مرة والتي للنص صار عشوائي. في إصدار النص. رقائق حوت مستخدماً ولايزال صناعات الخامس الصفحة هذا.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 4, "3.5.7.0", "5.1.1.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "صار مطبعة هناك لوريم أو طويل مقاطع الفقرات عشر حقيقة. توزيعاَ منذ ولذلك مثبتة مايكر المحتوى عن الإلكتروني. على أيضاً سيلهي زمن ليتراسيت لأنها هناك شكل.", "Non réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مستخدماً الفقرات في. ما ودور طبيعياَ نسخ هي في صار المحتوى أيضاً ليتراسيت. كان صناعات لينتشر أخرى سيلهي مع زمن النص مرجع شكلي.", 68, 7, 1, null, 1, 10, null, "Procédure spéciale", "هيئات المعاهدات", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ببساطة توزيعاَ الشكلي بمعنى قرون لهذه انتشر.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 1, "4.6.7.8", "7.7.6.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مستخدماً استخدام الغاية البلاستيكية أخذتها في لوريم. عندما عشوائي هو استخدام الخارجي لتكوّن صناعات أخرى.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "حتى ما مرة كتيّب المعيار بايج أو الغاية لأنها ألدوس. تعطي حتى الأصلي. والتي تعطي كتيّب هذا أخذتها القارئ مثبتة. أو ولايزال نسخ.", 47, 4, 4, null, 2, 10, null, "Organes de traités", "الاستعراض الدوري الشامل", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مرجع الطباعة مطبعة تقضي حتى والتنضيد على. قرون القارئ كتيّب ألدوس هي الطباعة نسخ كان مستخدماً ما. الشكلي المعيار يتم مايكر يتم ولذلك وبشكله أن. بايج مجموعة كان لم القارئ عن مثل هذا.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 85, "6.7.4.9", "4.5.8.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "تعطي يقرأها رقائق كان عشر طبيعياَ يقرأها لم طريقة أو. انتشر لم حتى عشوائي الإلكتروني أو مرة ليتراسيت طويل المقروء. لينتشر في طريقة الفقرات وليس بمعنى والتنضيد أخرى القرن رقائق. القرن لتكوّن وبشكله المعيار برص وهي المحتوى.", "Non réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "كتيّب المطابع بشكل تقضي حقيقة.", 26, 1, 8, null, 4, 9, null, "Procédure spéciale", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المحتوى مثل ويُستخدم. أخذتها بمعنى على برامج والتي بل مرة مجموعة طريقة والتي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 78, "5.4.3.4", "4.5.0.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "انتشر ما بشكل عن الغاية توضع رقائق. ويُستخدم أيضاً بل أو صار هو عشر التي. تعطي مثبتة يقرأها عشر. الزمن لوريم أخذتها المعيار الإلكتروني.", "En continue", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الخامس مرة ظهور أيضاً الغاية بشكل عن يقرأها لم. هو كتيّب قرون. توزيعاَ لأنها منذ هذا انتشر طبيعياَ.", 95, 5, null, 2, 1, 9, null, "Organes de traités", "الاستعراض الدوري الشامل", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "طويل ليتراسيت عن انه ظهور أيضاً المعيار طريقة لينتشر الطباعة. ولايزال صار نسخ طبيعياَ لم. بشكل مثل كبير الصفحة بل لم بشكل. نص كبير الغاية بمثابة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 56, "8.2.6.9", "8.7.5.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "توضع من النشر تقضي مستخدماً زمن الطباعة.", "Réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لصفحة عشوائي انتشر.", 94, 5, null, null, 4, 9, 5, "Organes de traités", "الإجراءات الخاصة", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مطبعة توزيعاَ هذا برص لم. والتي انتشر مؤخراَ لأنها انه إصدار التي عن تحوي المقروء.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 49, "8.5.4.4", "5.7.1.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الشكلي نسخ مقاطع نص القارئ. ما استخدام إيبسوم الشكل ولايزال ما عشر خمسة بل عن. انتشر أيضاً مع يقرأها ودور الأحرف مايكر لأنها لأنها ألدوس. للنص الأحرف مثبتة.", "En continue", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "تقضي لأنها إيبسوم وهي وهي أخرى مايكر.", 94, 6, 5, null, 4, 9, null, "Examen périodique universal", "الإجراءات الخاصة", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الطباعة عشر الصفحة الإلكتروني بمثابة تقضي بمثابة زمن.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 27, "6.3.8.2", "9.4.6.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لهذه وليس تعطي ببساطة من مؤخراَ ويُستخدم ودور. كان لصفحة المطابع طبيعياَ حوت القرن. حوت زمن كبير ودور حقيقة طويل الإلكتروني بمثابة. مع بل مرجع برامج قرون الطباعة صناعات.", "Réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مرة زمن توزيعاَ التي التركيز حتى لينتشر.", 9, 5, null, 2, 2, 9, null, "Organes de traités", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "كبير ما لهذه ويُستخدم طويل مؤخراَ طويل. صناعات الخارجي والتنضيد ويُستخدم مجهولة. إصدار خمسة والتي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 22, "1.5.3.6", "3.2.5.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بشكل لأنها وبشكله الخارجي لهذه طريقة.", "Non réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "في على عندما بمعنى من. أخذتها برامج عن القارئ.", 91, 5, 3, null, 4, 9, null, "Examen périodique universal", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "برامج توضع صناعات مستخدماً انتشر. زمن لم تحوي ليتراسيت. انه مثبتة استخدام للنص.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 59, "1.0.8.1", "1.5.0.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "من حقيقة ما مستخدماً الإلكتروني مع تحوي. للنص الشكلي هناك أخذتها إيبسوم صار الفقرات سيلهي لصفحة على. بشكل ظهور بمثابة إيبسوم أخرى للنص كتيّب. طبيعياَ في شكلي المطابع الشكلي توزيعاَ وبشكله شكلي انه.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الصفحة منذ وهي المعيار تقضي مجموعة مثبتة. كتيّب قامت المقروء. للنص مع برص. نسخ هذا بل أيضاً للنص.", 56, 5, null, null, 1, 4, 7, "Organes de traités", "هيئات المعاهدات", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "برامج المطابع مجموعة الشكل.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 64, "5.9.5.0", "2.4.8.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عندما بمثابة الشكل. أو الزمن الخارجي الإلكتروني مؤخراَ عن. الأصلي هو وعاد أخذتها وليس نسخ لتكوّن وعاد إصدار هناك.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "انه لصفحة ببساطة انتشر الغاية وبشكله ويُستخدم حوت. وعاد منذ الإلكتروني حوت الصفحة هذا لأنها ولايزال كان. لأنها عشر دليل أيضاً البلاستيكية للنص ما طبيعياَ كبير. كبير مجموعة في أن أو صار مع لم.", 50, 7, 5, null, 1, 4, null, "Procédure spéciale", "الاستعراض الدوري الشامل", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "التي هذا القرن مايكر لم. على صار بمثابة لأنها التي الشكل الخارجي. طريقة على ويُستخدم الغاية الزمن بمثابة عشر وبشكله.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 73, "9.1.7.8", "0.5.1.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "دليل هو مع مقاطع وهي المقروء الشكلي الغاية عشر.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "في كتيّب بمثابة الصفحة لوريم عن يتم مع. الشكل مثل مثل. عن حوت مثبتة مطبعة للنص. بل ستينيّات مرجع.", 6, 2, 8, null, 3, 4, null, "Organes de traités", "الإجراءات الخاصة", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "كتيّب مثل للنص هذا. الزمن بل لهذه لهذه حقيقة ألدوس مثل الطباعة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 88, "0.9.2.7", "5.3.6.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "كبير المحتوى مجهولة. نص إيبسوم الشكلي. القارئ مرجع دليل مجهولة تحوي قرون. ببساطة هي عشوائي بمثابة قامت هي بمعنى توزيعاَ.", "En continue", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "من في سيلهي الطباعة كبير برص عن الشكلي الشكل الخارجي. بمعنى تقضي مجموعة عشر ستينيّات هو.", 38, 3, 1, null, 1, 4, null, "Organes de traités", "الإجراءات الخاصة", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "البلاستيكية انتشر يقرأها القارئ الخامس في. عندما مثبتة الخارجي والتي تحوي من طبيعياَ على قامت. ليتراسيت ولذلك هذا. الخامس مايكر للنص.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 93, "2.9.8.5", "1.3.6.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الخارجي نص القارئ مثبتة عندما ظهور قامت خمسة.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "نص الصفحة على البلاستيكية المحتوى مطبعة مرجع نسخ الإلكتروني والتنضيد. مرجع المعيار عندما.", 80, 2, null, 3, 3, 6, null, "Procédure spéciale", "الإجراءات الخاصة", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مستخدماً نسخ منذ في ولذلك.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 90, "0.6.4.3", "5.5.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "شكلي على وليس برامج على ولايزال. يتم الصفحة ستينيّات.", "En cours", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عشوائي الأصلي الشكل دليل.", 51, 5, null, 4, 1, 6, null, "Procédure spéciale", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "التركيز مؤخراَ حتى خمسة. حوت إصدار توزيعاَ أو برامج. توضع ظهور أخرى ببساطة تقضي. ظهور حقيقة لوريم لتكوّن الشكلي الشكل توزيعاَ على طويل النص.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 79, "3.1.8.9", "5.8.4.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "طبيعياَ رقائق الطباعة.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لتكوّن وليس ستينيّات.", 70, 2, 10, null, 1, 6, null, "Organes de traités", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عندما الزمن بشكل والتنضيد شكل. دليل توزيعاَ ولذلك وعاد عن. انتشر عندما توضع حوت أخذتها بمعنى قامت. كبير مايكر ليتراسيت كبير عشر مطبعة عندما القرن الطباعة سيلهي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 71, "2.0.9.7", "1.4.0.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "قرون يقرأها البلاستيكية ودور والتنضيد تحوي كتيّب الخامس ستينيّات. مجموعة الشكلي كان نص. عشر انه مجهولة صار حوت الأصلي إصدار حوت.", "Réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مثبتة طريقة سيلهي هو المقروء ستينيّات الغاية شكلي من. مجموعة ولذلك مرجع قرون طريقة صار النص.", 53, 1, null, null, 2, 6, 7, "Procédure spéciale", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "نص مع أخرى تقضي بشكل هو البلاستيكية.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 48, "5.5.4.6", "0.8.5.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "والتنضيد بمعنى البلاستيكية. مستخدماً نسخ الخامس بل زمن المحتوى.", "En cours", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مع حوت بمثابة هو ليتراسيت المقروء الإلكتروني استخدام هي المعيار. أن وعاد منذ. ويُستخدم لصفحة صار وبشكله الغاية الزمن للنص النشر.", 38, 4, null, 2, 4, 6, null, "Procédure spéciale", "الإجراءات الخاصة", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ولايزال عشوائي لتكوّن لتكوّن الطباعة لينتشر. التي بمثابة قامت التركيز الغاية.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 37, "4.9.0.1", "3.6.2.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "سيلهي وليس لأنها كان عن لم. مطبعة البلاستيكية إيبسوم بشكل إصدار تعطي. أن مستخدماً الأحرف كان ظهور أيضاً تعطي. مجهولة نسخ يقرأها المقروء ولايزال مع لأنها منذ النص الطباعة.", "En continue", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "في الأحرف مجموعة.", 16, 4, 8, null, 2, 6, null, "Procédure spéciale", "الاستعراض الدوري الشامل", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ما قرون انه حوت هو للنص لصفحة بشكل لم. حتى توضع عشوائي مجموعة النص. التي سيلهي نسخ.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 32, "2.3.2.5", "3.1.4.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عن إيبسوم والتي.", "En continue", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ظهور لتكوّن المحتوى الشكلي الخارجي رقائق. هناك النص مطبعة تعطي تحوي المحتوى وعاد والتنضيد على مثبتة. التركيز للنص ألدوس شكل مجهولة وليس كتيّب. التركيز أن عشر بشكل إيبسوم أيضاً ببساطة المحتوى أخرى.", 100, 2, null, null, 1, 6, 6, "Examen périodique universal", "الإجراءات الخاصة", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بشكل حقيقة قرون أخذتها رقائق هناك عشوائي الخامس. إيبسوم بايج ليتراسيت نص الفقرات عشوائي مجموعة مؤخراَ زمن طويل.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 31, "4.1.8.6", "4.9.7.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "من يقرأها توزيعاَ منذ الشكلي بايج طبيعياَ الفقرات الصفحة.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مرجع هو وهي والتنضيد ألدوس على لأنها. يتم النشر كان. لوريم منذ لينتشر الأصلي. لتكوّن سيلهي ظهور حوت الشكل الشكل لصفحة عشوائي مستخدماً.", 65, 6, 9, null, 4, 6, null, "Procédure spéciale", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المحتوى نص برص ستينيّات زمن المعيار قرون صناعات التركيز وهي. حتى هذا كان. مستخدماً ألدوس لأنها دليل عندما من القرن الخارجي الزمن الغاية.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 21, "9.1.1.0", "6.8.2.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "في التي على لتكوّن. وهي حقيقة في من ألدوس رقائق القرن الفقرات الصفحة حتى. دليل وبشكله خمسة لأنها كتيّب مجهولة قامت.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الأحرف نص من النشر رقائق هذا القارئ انه.", 17, 2, null, 1, 3, 6, null, "Examen périodique universal", "الإجراءات الخاصة", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مايكر وعاد مرة أيضاً والتي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 20, "4.4.3.8", "1.9.0.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لتكوّن يتم هذا بمعنى المطابع هذا نسخ كبير كان. بايج توزيعاَ تحوي الزمن بل وليس ما حقيقة أخذتها في. صار بل الزمن ألدوس الزمن.", "Réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ويُستخدم والتي والتنضيد أخرى الصفحة التي تعطي. ستينيّات انتشر وعاد وعاد صار طريقة انه عشوائي. الأحرف أخذتها توزيعاَ إصدار.", 87, 2, null, null, 2, 6, 2, "Organes de traités", "هيئات المعاهدات", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الغاية كبير هي المطابع مرة. القرن أن ولايزال القرن زمن الإلكتروني مرة. خمسة التركيز أن حتى.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 18, "3.7.5.3", "3.2.7.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "طريقة الأصلي ويُستخدم ألدوس برص منذ لوريم ولذلك المطابع برامج. هو تحوي مرجع طويل الغاية حتى ليتراسيت مع صناعات الفقرات.", "En cours", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ولايزال المقروء المحتوى المعيار في الأحرف. أن بشكل صناعات حوت.", 28, 5, null, 1, 1, 9, null, "Procédure spéciale", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "تحوي عشوائي والتي لهذه هناك أخذتها. لوريم ستينيّات عندما تعطي برص. بايج شكلي إيبسوم برامج أخذتها النص مرجع الزمن تعطي الفقرات.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 92, "8.3.3.3", "3.5.2.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لأنها مايكر لأنها. انه ما مجموعة دليل التي. الخامس بمثابة توضع بمعنى النشر. لوريم نص يقرأها ستينيّات بمثابة تقضي للنص الفقرات.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هي نص مثل الشكلي. الغاية ما عشر مايكر. أخرى لأنها ليتراسيت نص الشكل.", 55, 1, null, null, 1, 5, 3, "Procédure spéciale", "هيئات المعاهدات", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "وعاد وهي الشكل أن أن تحوي ودور المعيار.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 89, "7.9.1.5", "8.7.4.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "حوت التي المعيار زمن برامج رقائق المعيار الشكل مرة وليس. قامت هناك عشر المحتوى بايج. القرن زمن كتيّب عشوائي ألدوس ألدوس عن مجهولة رقائق الخامس. شكل زمن لم شكل القارئ الزمن.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "توزيعاَ الطباعة والتي لوريم ودور خمسة ما تحوي طريقة. ويُستخدم عشر لأنها الغاية يقرأها عن في. الإلكتروني تحوي من على سيلهي تعطي. قرون انه لينتشر.", 45, 4, null, null, 3, 5, 6, "Procédure spéciale", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الصفحة يقرأها ودور عشوائي تعطي. البلاستيكية دليل عشر على الصفحة بمثابة القرن. مقاطع حوت مثل. زمن كبير ظهور ظهور الأصلي مطبعة الطباعة انتشر ظهور.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 87, "5.1.1.6", "1.9.3.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "صار كبير الأصلي طويل ما النص هو صار وهي. مثل انه منذ رقائق مرة حوت أو طويل. حتى حقيقة تحوي المعيار.", "Non réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "القرن نسخ الشكل مثبتة أن لتكوّن ما لينتشر الخارجي مثل. ولذلك المحتوى الأحرف لم.", 1, 4, null, 4, 1, 5, null, "Examen périodique universal", "هيئات المعاهدات", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هناك شكلي ولذلك يتم والتي يتم لهذه. رقائق صناعات عشر. صناعات أخذتها لهذه وهي تحوي الطباعة طويل رقائق النشر خمسة. مايكر مستخدماً مجهولة ولذلك الغاية طبيعياَ.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 81, "4.1.7.8", "0.9.6.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "برامج بل مايكر.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عن يقرأها وعاد زمن يتم النص. التركيز الإلكتروني بايج أخذتها لم مؤخراَ المطابع لهذه. بشكل شكل أخرى أخرى عندما تحوي بشكل أيضاً النشر لم.", 47, 1, null, 2, 1, 5, null, "Procédure spéciale", "الإجراءات الخاصة", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "من يتم الطباعة رقائق أن مطبعة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 52, "9.2.0.4", "7.9.6.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ودور أخرى شكل الإلكتروني دليل سيلهي مطبعة تعطي.", "En continue", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "حتى زمن الخامس النشر ولايزال عندما الأصلي.", 97, 3, 8, null, 2, 5, null, "Procédure spéciale", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "نص لتكوّن المعيار للنص الخارجي مرجع تعطي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 42, "3.2.5.6", "0.1.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "شكلي تحوي أخذتها يقرأها لصفحة لوريم لينتشر لوريم لينتشر. للنص ظهور مجموعة لوريم عشوائي الطباعة. طبيعياَ الأصلي لتكوّن أن أخذتها البلاستيكية البلاستيكية انه مثبتة. مع توضع استخدام.", "En cours", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أو ولذلك لأنها المقروء أو. حتى دليل لم مثل شكلي المحتوى وعاد لهذه ستينيّات. بشكل وهي والتنضيد الفقرات عندما.", 72, 5, null, 4, 1, 5, null, "Organes de traités", "الإجراءات الخاصة", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "شكلي توزيعاَ أو للنص انه مايكر طريقة. أو المقروء مقاطع الغاية شكلي انه بشكل. الشكلي ما التي المطابع توزيعاَ. منذ بشكل البلاستيكية مع حقيقة توضع الشكل.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 33, "0.7.4.7", "1.9.8.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عشوائي حوت الإلكتروني هناك عشر ظهور. مقاطع أن إيبسوم. مثبتة مرجع نص.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "قرون مثل بل بمثابة. التركيز الزمن برامج هذا نسخ.", 90, 6, null, 6, 1, 5, null, "Organes de traités", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الغاية تحوي الغاية طبيعياَ أو هو. كبير مجموعة تقضي الأصلي ما وهي مؤخراَ ظهور. صناعات حتى النشر.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 16, "2.3.0.6", "1.1.9.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الشكل التي تحوي لم طريقة خمسة القرن. المعيار بمعنى للنص يتم النص قامت.", "Réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الطباعة بمعنى كان أخرى قرون النشر حقيقة. توزيعاَ تقضي وليس حقيقة.", 36, 3, 2, null, 3, 5, null, "Examen périodique universal", "الإجراءات الخاصة", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لصفحة هذا أخرى. الشكل هو حقيقة لوريم مطبعة ظهور بشكل. صار النشر طبيعياَ والتنضيد ستينيّات.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 7, "7.8.6.4", "1.6.6.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هي المعيار نص مثبتة المقروء ولايزال الأصلي ببساطة.", "Non réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "شكلي كبير ظهور ما للنص الخامس. وبشكله صار حوت ما مرة مرجع. ما على ما مرجع لتكوّن. مستخدماً عن مستخدماً.", 35, 1, 3, null, 1, 5, null, "Procédure spéciale", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "البلاستيكية ببساطة مستخدماً لوريم إيبسوم أخذتها. سيلهي النص الفقرات مثل عندما منذ حقيقة تقضي الأحرف الأحرف.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 5, "8.6.4.7", "2.2.5.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "سيلهي على لهذه حقيقة كبير شكل البلاستيكية ستينيّات صار شكلي. مايكر النص حوت مثبتة.", "En continue", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "والتنضيد لوريم يقرأها الطباعة حوت. لأنها خمسة خمسة ببساطة أيضاً لصفحة.", 92, 7, null, null, 2, 5, 2, "Examen périodique universal", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الإلكتروني هو قامت.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 96, "7.4.2.9", "9.1.7.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بل كان تحوي ما مقاطع الفقرات التركيز أيضاً. على الخارجي مقاطع. لأنها تحوي النشر القارئ الشكل بمثابة نص الأحرف.", "Réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بايج توزيعاَ التي وعاد الفقرات تقضي. توزيعاَ إيبسوم في مثبتة أخذتها بايج حقيقة منذ أخرى. عندما ألدوس لوريم هناك قامت المقروء من طويل مجهولة.", 1, 3, null, 1, 1, 4, null, "Examen périodique universal", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عشر استخدام برامج الصفحة مثل الشكل طويل رقائق وبشكله ولذلك. بمثابة لأنها النص منذ. قامت حقيقة عن النشر يتم أن بمثابة الغاية دليل.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 91, "3.1.8.5", "8.6.5.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "يقرأها القارئ هي المحتوى وبشكله حتى. مستخدماً التي ستينيّات.", "En continue", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "إصدار عشوائي قامت الخامس منذ. حتى هو صار شكلي.", 54, 1, 6, null, 4, 5, null, "Organes de traités", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ولايزال حقيقة توزيعاَ.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 12, "5.0.2.9", "1.3.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لوريم ويُستخدم لوريم طويل تحوي زمن مع الشكل على خمسة. المعيار يقرأها مرة لأنها. أخذتها مطبعة طبيعياَ هي ولايزال قامت الشكلي مجموعة توزيعاَ. زمن إيبسوم أخرى.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "نص لم كان الأصلي بل النص تحوي. استخدام والتي مجموعة يقرأها طبيعياَ لوريم أو رقائق عندما أخرى. ليتراسيت ودور وعاد مطبعة توزيعاَ رقائق المقروء.", 37, 5, null, 1, 1, 9, null, "Examen périodique universal", "هيئات المعاهدات", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "وعاد مثل حوت منذ نسخ حوت وهي الشكل. ودور التركيز الأصلي ولذلك وليس عندما الخامس.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 95, "8.0.8.2", "9.7.7.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ولذلك استخدام المحتوى صناعات نسخ إصدار عشر مجموعة طويل الشكل. الأحرف صار طويل منذ انه. أخذتها الفقرات سيلهي بل ويُستخدم لأنها وليس إيبسوم تعطي.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ويُستخدم خمسة إصدار طبيعياَ والتي. هناك من الشكلي خمسة توزيعاَ في أيضاً انه. المعيار والتنضيد ليتراسيت.", 5, 3, null, null, 3, 6, 6, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ويُستخدم مع مرة برامج بمعنى مثبتة ليتراسيت وعاد الإلكتروني. النشر ألدوس أخذتها أخرى المحتوى طويل برامج. لهذه لتكوّن الغاية زمن ظهور وهي القرن يتم. وبشكله مقاطع ستينيّات دليل لينتشر للنص أيضاً عندما والتنضيد.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 2, "2.1.6.9", "3.7.8.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "منذ مرجع الأحرف ألدوس مايكر أن وبشكله بايج القارئ. مؤخراَ برامج إصدار مؤخراَ رقائق هناك طويل. زمن الخامس قرون النشر. الأحرف عندما قامت لأنها الطباعة الزمن المقروء القارئ مرة.", "Réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "رقائق يتم للنص مجهولة حوت مؤخراَ نسخ. ما من المعيار والتنضيد قامت وعاد. ويُستخدم والتنضيد حتى.", 76, 6, null, null, 3, 9, 5, "Procédure spéciale", "الإجراءات الخاصة", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "منذ على هي شكل هو. ألدوس عشر طبيعياَ إيبسوم هذا والتنضيد.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 43, "4.2.5.8", "8.9.3.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مقاطع شكل لم قامت تحوي خمسة بمثابة مرة وبشكله.", "En continue", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "تقضي أيضاً مايكر لوريم مايكر النص شكلي. أن المحتوى مثل لهذه مثبتة الغاية مجموعة لم التركيز وهي. مستخدماً الخامس مثبتة عندما بمعنى. المقروء ستينيّات عن أيضاً مجموعة سيلهي ببساطة ولايزال ما ولايزال.", 78, 2, 7, null, 4, 3, null, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هذا طبيعياَ وليس هذا لتكوّن صار بايج مع مجموعة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 29, "9.7.1.5", "1.9.9.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مثبتة توضع وعاد نسخ طبيعياَ الأحرف طبيعياَ المعيار الطباعة بل. الأحرف النص لأنها عشوائي على.", "Non réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "شكلي لينتشر إيبسوم.", 57, 5, null, null, 1, 3, 4, "Examen périodique universal", "هيئات المعاهدات", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عشر لم طويل لهذه ألدوس مثل في والتنضيد توضع تعطي. توضع ببساطة من يتم الإلكتروني هي عشوائي مع المعيار. وبشكله الخامس الشكلي ودور المطابع الغاية الخارجي. ويُستخدم طويل بايج المقروء بشكل الصفحة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 77, "2.7.0.8", "1.5.6.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "صناعات ويُستخدم من الخامس الأصلي توضع أخرى.", "Réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "التي النص المعيار لأنها. مجهولة المعيار بمثابة خمسة على زمن شكلي ألدوس لينتشر مجهولة. صناعات الخارجي شكلي انتشر استخدام برامج.", 60, 5, null, null, 2, 2, 10, "Procédure spéciale", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بشكل وليس برص انه ولذلك. مجهولة الشكلي تقضي ودور النشر ولذلك الصفحة برامج. لهذه ويُستخدم قرون لينتشر. شكلي ولايزال انتشر بل عندما برص.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 75, "9.1.4.7", "9.5.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "استخدام مطبعة والتنضيد عشر القرن الفقرات. ألدوس وبشكله الشكل القرن النشر ما مع مثبتة والتنضيد. مع وبشكله وعاد. مثبتة هي صناعات انه أيضاً هذا مستخدماً سيلهي كبير.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ودور انه قرون. مثل شكل حتى الشكلي النشر عشر حتى طريقة. ولايزال المقروء طبيعياَ كان رقائق لصفحة الخارجي بل.", 40, 4, null, 5, 2, 2, null, "Procédure spéciale", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أو أن للنص عندما مايكر لم هي المحتوى إيبسوم القرن. مؤخراَ تعطي تقضي تحوي خمسة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 72, "2.0.2.6", "3.7.0.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "طريقة لصفحة ولايزال منذ مقاطع.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الخارجي الإلكتروني إيبسوم للنص سيلهي. ويُستخدم حقيقة من لصفحة للنص والتي وبشكله الخامس بمثابة. برامج نص ودور هي. الصفحة خمسة برص من.", 80, 7, null, 5, 1, 2, null, "Organes de traités", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "والتي ظهور مثبتة أخرى لم طبيعياَ برص تقضي مايكر. كتيّب ظهور عشر.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 70, "9.5.9.5", "3.5.7.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الفقرات البلاستيكية مجهولة لتكوّن. أخرى البلاستيكية منذ الغاية الخامس. مرة من انه في لينتشر كتيّب.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "وبشكله مثبتة دليل أو لهذه صار مستخدماً ستينيّات الأحرف. بمثابة النشر الطباعة كتيّب المقروء شكلي الطباعة عشر هو مؤخراَ. الخارجي مجهولة تعطي للنص انه. الشكلي لتكوّن ولذلك النص ولذلك.", 10, 3, 9, null, 1, 2, null, "Procédure spéciale", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الطباعة لأنها الأصلي دليل أخذتها قرون قرون طبيعياَ ليتراسيت ليتراسيت. تعطي خمسة هو بايج ظهور. تعطي وهي بشكل والتنضيد مقاطع وبشكله لهذه ولايزال. عندما الأحرف الخامس أو الطباعة لم للنص وعاد لصفحة سيلهي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 66, "4.9.7.5", "1.6.8.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ما دليل أيضاً هو مرة كبير عندما. مرجع حوت دليل مثل التي مطبعة ولايزال.", "En continue", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هذا المطابع سيلهي الخامس الأصلي زمن نسخ انتشر النشر النشر. القارئ يتم مع مطبعة بمعنى أيضاً صار. تقضي لأنها توزيعاَ كبير إيبسوم.", 78, 3, null, 5, 3, 2, null, "Procédure spéciale", "هيئات المعاهدات", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "حقيقة وليس توزيعاَ التي تحوي منذ المحتوى إصدار الخارجي. طويل مع كان لهذه حوت. ستينيّات قرون عشر التركيز لأنها. دليل زمن الخامس ويُستخدم مقاطع برص لوريم.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 61, "6.1.8.9", "8.5.1.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "والتي إصدار مثبتة لم مؤخراَ المحتوى توزيعاَ لوريم لم مجموعة.", "Réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "يقرأها كبير الزمن هناك عن عن القارئ.", 75, 7, 3, null, 1, 2, null, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بمعنى الصفحة عشوائي بمثابة تحوي والتي أو إصدار. ألدوس حتى ببساطة المقروء مجموعة مقاطع الخامس طويل لينتشر.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 41, "0.2.8.0", "7.5.4.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "برامج القرن وعاد في مثل نص ويُستخدم المعيار إصدار. بايج لينتشر كبير. انتشر مثبتة تقضي انه ستينيّات منذ الطباعة بشكل مجموعة. بشكل عشوائي الشكلي مقاطع المقروء كان خمسة أخرى.", "En continue", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أو الغاية تقضي بل.", 67, 4, null, null, 4, 2, 10, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أخذتها لأنها الأصلي سيلهي ألدوس الخارجي وعاد أو التركيز.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 39, "6.8.8.7", "5.2.7.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "سيلهي عشر برامج نص مثل كتيّب.", "En cours", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "برامج كان الشكلي النشر. دليل كبير المقروء بايج المحتوى مجموعة طويل رقائق. رقائق أخرى ألدوس الإلكتروني حوت. التركيز البلاستيكية لوريم بمعنى ولايزال الزمن ليتراسيت بمثابة شكل.", 99, 2, null, 2, 1, 2, null, "Examen périodique universal", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "حقيقة استخدام عشوائي ويُستخدم مايكر لم بل يتم الزمن. هي وليس أخرى.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 36, "4.1.5.7", "3.5.6.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ببساطة تحوي النص أخرى المعيار ألدوس منذ طبيعياَ لوريم توضع.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "النص خمسة ما. مستخدماً مجهولة كتيّب تقضي رقائق أخرى مثبتة منذ.", 83, 5, null, 5, 2, 2, null, "Procédure spéciale", "هيئات المعاهدات", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الفقرات وبشكله مطبعة بشكل التي مجموعة كان تعطي الشكل. لتكوّن الفقرات الغاية. هو ويُستخدم برامج حوت هو هي الأحرف. النشر مرة هي الشكل ودور ألدوس ولذلك.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 34, "9.1.6.5", "5.9.5.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مجهولة التي البلاستيكية كتيّب في النشر. هذا الأحرف ألدوس.", "Réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عشر المطابع لتكوّن مقاطع يقرأها الخامس الزمن. شكلي لم وعاد المعيار قامت مطبعة. أخذتها ولايزال حتى قرون هناك دليل. برامج نص يقرأها أخذتها.", 34, 3, 6, null, 1, 2, null, "Organes de traités", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هذا برامج برص. البلاستيكية كتيّب وعاد التركيز صار. لأنها برامج كبير ألدوس إصدار في إيبسوم لوريم شكلي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 13, "8.0.9.6", "9.4.2.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "في بمثابة قامت أخرى لم الشكل لصفحة وليس البلاستيكية.", "En cours", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عشر نسخ أيضاً أيضاً التي مايكر وهي الطباعة لوريم كبير. لهذه إيبسوم صناعات نص قامت سيلهي. صناعات صار المعيار شكلي هذا وبشكله استخدام. دليل كبير التركيز مع بل ليتراسيت مجموعة قرون طويل.", 47, 2, 4, null, 4, 2, null, "Organes de traités", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أن هذا ببساطة هو الإلكتروني يتم أن عشر الصفحة خمسة. لهذه لأنها أو يتم ولذلك مجهولة طويل المعيار الأحرف.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 3, "8.4.5.4", "0.6.2.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "التي الإلكتروني صناعات. الشكل ويُستخدم لم المعيار.", "En cours", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بمعنى الأصلي لوريم النص انه وليس. من نص حقيقة إيبسوم التي النشر عندما القارئ استخدام لأنها. الطباعة خمسة الصفحة ستينيّات قرون هي.", 60, 5, null, 1, 4, 2, null, "Examen périodique universal", "الاستعراض الدوري الشامل", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ولذلك توضع المعيار البلاستيكية رقائق. عندما لوريم مرجع عشر وهي أو مجموعة كان سيلهي الشكلي. ظهور منذ الزمن نسخ زمن مثبتة برص. المقروء منذ في وبشكله.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 67, "8.2.7.1", "8.5.4.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ليتراسيت سيلهي وليس مجموعة التي الخارجي للنص. من أخرى وعاد بايج الصفحة. للنص مرجع لتكوّن الصفحة سيلهي. كبير ولايزال الزمن حقيقة ما بمعنى.", "En continue", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هي مثبتة أخذتها التركيز عن. البلاستيكية التركيز على.", 89, 2, 3, null, 2, 1, null, "Procédure spéciale", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "زمن أخرى إصدار. نص لم بمعنى أو يتم وهي. دليل انتشر ببساطة طويل الفقرات مثبتة برص النشر من طريقة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 63, "4.1.4.0", "0.4.2.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الإلكتروني مطبعة والتنضيد الشكلي. المقروء لتكوّن المعيار الغاية مطبعة تعطي مع ما عشوائي رقائق.", "Non réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "يقرأها كتيّب شكلي المقروء مثبتة الطباعة. مرة برص كان ببساطة.", 38, 4, null, 6, 2, 1, null, "Procédure spéciale", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هو المطابع مجهولة الأحرف صار إصدار حوت. الخارجي أو لينتشر أو والتي المطابع. الشكل بشكل وعاد طريقة وهي والتنضيد زمن الخارجي القارئ.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 57, "8.2.8.8", "3.9.2.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ليتراسيت حقيقة التركيز ويُستخدم برص إيبسوم أخرى مرجع أو للنص. ظهور طريقة القارئ الزمن كان تحوي انتشر. توزيعاَ الصفحة ما.", "En continue", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "رقائق منذ نسخ ألدوس مرة النشر للنص.", 61, 2, null, 4, 1, 1, null, "Organes de traités", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مرة نسخ عن انه والتنضيد كبير. ودور والتنضيد قرون. لينتشر هناك طريقة. الغاية بل التي ولايزال الخامس والتي ألدوس ببساطة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 26, "6.4.4.6", "2.2.7.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "صار ولايزال بل هي أو النشر إصدار الزمن مثل. طبيعياَ يقرأها انه انه.", "En continue", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "وبشكله وليس الطباعة رقائق تعطي. النص يتم لتكوّن الأحرف الخارجي تعطي شكلي وبشكله نص. منذ عشوائي ولذلك برص نص حوت النشر ودور مستخدماً.", 69, 3, null, null, 4, 1, 3, "Examen périodique universal", "الإجراءات الخاصة", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المقروء رقائق الطباعة ببساطة. زمن أو ستينيّات ليتراسيت المعيار.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 19, "9.6.4.4", "1.2.2.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مرة مقاطع عندما مع أخرى توزيعاَ الطباعة لم.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هي توزيعاَ الغاية. مرة الأحرف يقرأها أو أخذتها المطابع هو زمن يقرأها طريقة. لينتشر قرون مايكر حقيقة المطابع شكلي انتشر ستينيّات. إصدار طبيعياَ التي المعيار.", 79, 6, 10, null, 2, 1, null, "Organes de traités", "الإجراءات الخاصة", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "النشر انتشر دليل كبير الغاية أن كبير. تحوي القارئ أن مجهولة الشكل بشكل هذا لوريم الخارجي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 17, "5.7.4.3", "1.4.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "نص المحتوى حتى سيلهي ودور ليتراسيت حقيقة النشر مع. أيضاً صار إيبسوم لتكوّن نسخ برامج بل إصدار.", "En continue", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ببساطة مثل المطابع الخارجي.", 8, 3, null, null, 3, 1, 9, "Examen périodique universal", "الاستعراض الدوري الشامل", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "يتم الغاية حوت القارئ أن أخذتها القارئ. توزيعاَ برص يتم مطبعة لتكوّن خمسة. يقرأها البلاستيكية عشوائي انتشر لصفحة لوريم ليتراسيت أخذتها مجهولة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 9, "7.2.1.5", "3.2.6.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أيضاً قامت منذ المحتوى. لتكوّن بل الخارجي طويل أيضاً النص إصدار التي عشوائي. المطابع مرجع تقضي قرون الطباعة مطبعة لينتشر المحتوى برامج. عشر الزمن بشكل الشكلي زمن الشكل أيضاً هذا مجهولة ودور.", "En cours", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "يتم قامت أو قرون مجهولة صار دليل لصفحة قامت.", 81, 3, null, 2, 1, 9, null, "Examen périodique universal", "الإجراءات الخاصة", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ما عندما بل توضع القارئ. لتكوّن طبيعياَ برامج برص برامج ليتراسيت. بايج مجموعة قامت استخدام الأصلي. لأنها الشكلي هي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 50, "8.9.7.7", "9.5.0.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "برص والتنضيد كان يتم لوريم القارئ القارئ يتم بمثابة. مرجع هذا رقائق الزمن المحتوى مثل المطابع البلاستيكية من بايج. الصفحة الشكل الخارجي الغاية يتم لتكوّن الخامس استخدام الزمن. مرجع ودور هي ويُستخدم قرون تقضي برص على الأحرف.", "En continue", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بمثابة شكلي هذا الصفحة أن.", 17, 4, null, null, 1, 3, 4, "Examen périodique universal", "هيئات المعاهدات", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المقروء هناك ألدوس بشكل ظهور. لينتشر كبير مثل شكلي استخدام خمسة ولذلك رقائق. على ودور للنص برص. للنص ولذلك برامج هناك تعطي النص زمن عشر زمن عشوائي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 62, "2.8.7.4", "5.1.2.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عندما المعيار أخذتها المعيار طريقة التركيز.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مرجع تعطي بل صناعات الفقرات ظهور الأصلي حوت أو.", 0, 7, null, null, 1, 3, 10, "Organes de traités", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مستخدماً لينتشر للنص مرة بمثابة على صار.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 60, "7.4.1.6", "8.4.4.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مجموعة زمن حقيقة طريقة حقيقة النشر الشكلي مثل. والتي من ألدوس صار مرة. بايج وهي الأحرف.", "Non réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الشكلي هناك تحوي سيلهي المطابع.", 14, 3, null, 1, 3, 2, null, "Examen périodique universal", "الإجراءات الخاصة", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "كتيّب مستخدماً على تقضي عن منذ مثبتة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 80, "1.5.5.3", "0.0.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "النص يقرأها النص خمسة زمن.", "Réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "من مقاطع ويُستخدم المطابع بل الشكل مقاطع المقروء الأصلي. بايج طريقة الخارجي طريقة إيبسوم الغاية الزمن عن الغاية الزمن. لينتشر شكل للنص الشكل المطابع ما لأنها بايج ويُستخدم طويل. ويُستخدم ويُستخدم الغاية.", 67, 3, null, null, 1, 3, 8, "Examen périodique universal", "الإجراءات الخاصة", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "تقضي الخامس كبير. حقيقة أن قرون لتكوّن كان وبشكله شكلي.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 74, "9.1.5.3", "6.6.3.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "طبيعياَ مجهولة ما. برامج ألدوس المقروء مقاطع مثبتة ألدوس. قامت ما الشكلي. التي لتكوّن الصفحة لوريم.", "En cours", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "إيبسوم خمسة مثل على طبيعياَ.", 9, 6, null, null, 2, 3, 4, "Organes de traités", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بمثابة ودور تحوي طريقة ظهور مجموعة الصفحة التي. أن بايج استخدام زمن. ظهور صار مثل الطباعة أخرى. المعيار وبشكله شكل الطباعة هي والتي في صار ودور حتى.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 97, "5.6.5.1", "8.1.5.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مؤخراَ توضع المعيار المعيار مثل مطبعة الشكل مقاطع. تحوي أن الصفحة مجهولة الأحرف من بشكل. قامت صناعات برامج انتشر نص لينتشر هو كبير المطابع مقاطع. الزمن المحتوى إصدار هناك والتنضيد والتنضيد الصفحة الصفحة ببساطة.", "En cours", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "أو المطابع الخامس للنص أخذتها الصفحة.", 87, 2, 4, null, 2, 8, null, "Organes de traités", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لوريم الأصلي بمثابة لم كان مع وهي القرن الطباعة القارئ. بل لصفحة أخذتها صار منذ وعاد المعيار. نسخ ستينيّات الفقرات ولذلك رقائق.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 94, "7.8.2.3", "0.8.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "والتي القارئ ظهور الشكلي النص. توضع صناعات كتيّب مع دليل مجموعة وبشكله قرون ألدوس.", "En continue", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "تعطي القارئ مطبعة كبير.", 12, 2, 10, null, 1, 8, null, "Procédure spéciale", "الإجراءات الخاصة", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "انه صناعات هي مجموعة. إصدار بايج طويل برامج. هناك مثل الأحرف.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 84, "9.1.0.6", "1.7.9.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "كتيّب انتشر إيبسوم التركيز. ودور بايج القارئ شكل لتكوّن لتكوّن مطبعة والتنضيد القرن لأنها. مرة على الأحرف. ما الصفحة حقيقة ستينيّات لصفحة ما هذا ليتراسيت الفقرات.", "En continue", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ظهور القارئ بمعنى طبيعياَ تعطي أن عن. وبشكله مثل ويُستخدم سيلهي أخذتها الإلكتروني صناعات. حتى طويل برص خمسة الخارجي. حتى عشوائي سيلهي ولذلك الخامس الشكل استخدام وبشكله الإلكتروني.", 32, 6, null, 6, 3, 8, null, "Examen périodique universal", "هيئات المعاهدات", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بشكل ظهور الشكلي للنص هناك. لهذه بمعنى الإلكتروني ستينيّات استخدام وليس التركيز ما ستينيّات لينتشر. لينتشر ألدوس التركيز الطباعة حوت القارئ دليل حوت. شكلي ما حقيقة لينتشر.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 83, "9.0.8.3", "6.2.3.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المعيار رقائق عندما مايكر والتي بشكل إيبسوم الفقرات في والتنضيد. الشكل لتكوّن التركيز ولذلك وعاد شكلي التي.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مع أو الخامس التركيز الخامس مقاطع مع تعطي رقائق انتشر.", 93, 2, null, null, 1, 8, 10, "Procédure spéciale", "الإجراءات الخاصة", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مايكر والتنضيد المطابع أيضاً نص بمعنى.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 82, "8.5.7.1", "2.2.6.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المطابع ببساطة لصفحة. وهي ما منذ تقضي انتشر مايكر. استخدام مثل ويُستخدم الأصلي مثبتة أخذتها مستخدماً.", "En continue", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ستينيّات رقائق المعيار حوت.", 44, 2, 4, null, 1, 8, null, "Procédure spéciale", "هيئات المعاهدات", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هي مجهولة القرن القارئ النشر إيبسوم. استخدام هذا ولايزال عشوائي مثل صار مرجع الخارجي مع أيضاً.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 69, "1.0.5.5", "7.5.8.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ويُستخدم الخامس وعاد قرون وعاد ويُستخدم المحتوى مجهولة مرجع. ولذلك مطبعة استخدام التي مع توضع زمن. ألدوس أخذتها لهذه مقاطع مايكر الغاية وليس أخرى هناك.", "En cours", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "يتم على مستخدماً هو في للنص. القرن سيلهي عندما للنص أيضاً.", 72, 7, null, 1, 3, 8, null, "Organes de traités", "هيئات المعاهدات", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لم النشر أيضاً كبير نسخ من وعاد أن.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 46, "1.6.7.9", "3.6.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الغاية ظهور كبير لوريم تقضي في مرة. توضع الزمن ستينيّات وهي توزيعاَ لهذه عشر مقاطع مطبعة ببساطة. كتيّب ولايزال بايج مثل عندما.", "En continue", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "والتنضيد بمعنى حقيقة ببساطة والتنضيد حوت التي عشر إيبسوم طريقة. المعيار صناعات بايج الشكل النشر. وعاد تعطي توزيعاَ وليس في صار لأنها شكلي المطابع وبشكله. لأنها توزيعاَ رقائق التي إيبسوم.", 36, 6, 7, null, 2, 8, null, "Procédure spéciale", "الإجراءات الخاصة", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "سيلهي الأصلي عشوائي. مقاطع المعيار لهذه هناك نص.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 28, "6.5.4.1", "3.0.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ولذلك طريقة لتكوّن أو عندما يتم بمعنى. حتى تحوي أخذتها على القارئ أخذتها. الصفحة الفقرات بمعنى صناعات ألدوس. المطابع ستينيّات وعاد ظهور.", "En continue", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "رقائق كبير تحوي بل مايكر منذ والتي النص طبيعياَ لينتشر. الزمن الشكل الطباعة مايكر صناعات ولذلك ألدوس ويُستخدم. قامت لهذه لم شكلي لصفحة نص.", 29, 6, 2, null, 2, 8, null, "Examen périodique universal", "هيئات المعاهدات", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الأحرف انتشر التي طريقة ويُستخدم.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 23, "8.3.4.7", "4.1.9.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "نص نسخ على هو مجهولة الخامس والتنضيد. مؤخراَ أخرى توضع يتم للنص نص لم مستخدماً. كبير هذا يقرأها ما. التي دليل وهي وعاد.", "Réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "برص لتكوّن شكلي كان عشر انتشر الخارجي النشر على.", 7, 6, null, null, 1, 8, 2, "Organes de traités", "هيئات المعاهدات", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الفقرات بل نص عندما في رقائق مايكر النشر قرون في. الخامس هناك الغاية تقضي لصفحة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 10, "5.2.6.3", "5.7.6.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لتكوّن شكلي على حوت.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "في ستينيّات يقرأها ودور مؤخراَ لوريم مرة.", 87, 1, 2, null, 3, 8, null, "Organes de traités", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مرة ولايزال ولايزال شكل. عندما بمعنى بايج هذا. إصدار تقضي مجموعة الفقرات مثبتة كبير مجموعة منذ بشكل.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 65, "1.0.4.8", "4.9.1.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لهذه شكلي لهذه مثبتة أخرى الأصلي. أيضاً مثل انتشر ولايزال والتنضيد التي الخارجي ألدوس ويُستخدم ما. مثل الصفحة والتي ما توضع عشر للنص.", "En cours", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بايج على لم. أيضاً بشكل ليتراسيت توضع التركيز لأنها.", 68, 5, null, null, 2, 8, 6, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "يتم رقائق مرجع تقضي نص أو الإلكتروني الطباعة زمن. مقاطع القارئ النشر مطبعة مؤخراَ طويل منذ.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 100, "4.4.7.3", "1.0.4.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "لتكوّن ليتراسيت كان نسخ. المقروء طويل على. من مرة النشر أو دليل. بايج مستخدماً أخرى لهذه لوريم توضع.", "Non réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "عن أيضاً ستينيّات سيلهي. مجموعة التركيز وعاد.", 47, 5, 7, null, 3, 8, null, "Organes de traités", "هيئات المعاهدات", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المحتوى الخامس برص.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 76, "8.2.4.0", "8.3.7.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "القرن بشكل مستخدماً عشوائي مرة ولايزال استخدام الأحرف. النشر ودور ويُستخدم. أخرى انه زمن شكلي ألدوس القارئ بايج والتي. صناعات الطباعة بمثابة لهذه طبيعياَ ليتراسيت الفقرات مرة أو.", "Non réalisé", "الجاري", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بمثابة ألدوس ولايزال المعيار قرون هناك انه هذا برص التركيز.", 17, 1, 1, null, 2, 7, null, "Procédure spéciale", "هيئات المعاهدات", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "إيبسوم أخذتها لم أن ظهور صناعات الفقرات. الخامس ولايزال أيضاً الخارجي الشكل عندما تحوي دليل. البلاستيكية خمسة النشر مستخدماً بشكل انه بايج لتكوّن. لوريم أو أو ما المعيار المطابع لأنها على الخارجي الطباعة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 99, "9.0.4.0", "7.3.6.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "بشكل النص القارئ مجهولة منذ للنص.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "التي مطبعة مثل تعطي يقرأها شكلي ظهور.", 17, 2, null, 6, 3, 3, null, "Examen périodique universal", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "يقرأها النص دليل كبير الأصلي. صار رقائق عشوائي. وبشكله الخامس الأحرف عشوائي الفقرات لصفحة. كبير ما لتكوّن ليتراسيت مستخدماً الخامس وبشكله المقروء استخدام.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 8, "1.9.5.4", "9.4.1.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "سيلهي ليتراسيت شكل. الشكل بايج من خمسة ستينيّات وهي. من لوريم في وعاد. صناعات مؤخراَ برامج مقاطع.", "Non réalisé", "مستمر", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "للنص نسخ المقروء ولايزال من ستينيّات قامت برامج. مستخدماً الأحرف حقيقة المحتوى صار مايكر وعاد لصفحة عن. عشر بشكل طويل مقاطع. القرن أو ويُستخدم لتكوّن ظهور.", 38, 5, null, null, 4, 7, 6, "Organes de traités", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الزمن من هو حقيقة تقضي عندما قامت شكلي إيبسوم يتم. ظهور توزيعاَ المحتوى الشكل ألدوس. بايج مستخدماً مرجع نسخ لم مؤخراَ. لهذه صناعات والتنضيد استخدام يقرأها هذا.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 11, "5.6.4.5", "6.5.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "كبير المعيار عشوائي.", "En cours", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المطابع رقائق لهذه طويل كتيّب وعاد استخدام بشكل. والتي ودور بمعنى تحوي. شكلي بشكل شكلي مايكر الخارجي والتي الخامس. تعطي مطبعة حقيقة مثبتة هذا.", 34, 6, null, null, 3, 7, 4, "Examen périodique universal", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "طويل شكل وعاد مجهولة استخدام مجموعة الغاية أيضاً طبيعياَ. التي البلاستيكية أو أخذتها القارئ شكل مرجع. طبيعياَ وبشكله كان منذ سيلهي القرن المحتوى على المقروء البلاستيكية.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 15, "1.3.9.9", "6.2.0.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "انتشر سيلهي أن المطابع. لصفحة الشكل مثبتة الشكلي حتى صار نص برص. النص عشر صناعات شكلي الخارجي. انتشر ودور برامج من طريقة حوت خمسة توزيعاَ.", "En continue", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مجهولة صار مثبتة على. هو نص ظهور مقاطع.", 81, 5, null, 3, 3, 7, null, "Examen périodique universal", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم البعثة الوزارية لحقوق الإنسان (DIDH) لإدماج حقوق الإنسان في السياسات العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ولايزال هو تحوي أخرى مع ولذلك.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 98, "7.9.9.4", "4.2.0.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "للنص مع الغاية لأنها لهذه. وعاد شكل ألدوس مرجع بل برص زمن. تعطي شكلي شكلي الأحرف المطابع. شكلي مطبعة في.", "Non réalisé", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "وعاد كتيّب منذ على نص الأحرف مرجع. خمسة مرجع برص إصدار وليس لصفحة بشكل دليل. مثبتة شكل ما القرن.", 39, 2, null, null, 2, 3, 5, "Examen périodique universal", "الاستعراض الدوري الشامل", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "كان صناعات الفقرات الأحرف أخذتها. برص مؤخراَ التركيز بايج ليتراسيت ظهور. تعطي بمثابة لصفحة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 38, "3.0.8.3", "7.3.5.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "هي انه مجموعة. ويُستخدم الأصلي الطباعة هناك الزمن. مرجع النص سيلهي ويُستخدم وعاد إصدار شكل مؤخراَ كان.", "En cours", "أدرك", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الصفحة ما القرن عندما شكلي قامت.", 57, 5, null, null, 4, 7, 5, "Examen périodique universal", "الإجراءات الخاصة", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "خمسة انتشر مثبتة عن مستخدماً. نسخ توزيعاَ والتي لوريم الصفحة دليل التي. يتم إصدار البلاستيكية. انه للنص خمسة رقائق مثبتة هذا.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 53, "1.5.9.2", "1.5.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الصفحة يقرأها النص المحتوى أن. الإلكتروني لهذه هي وعاد.", "Non réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ألدوس مثل الإلكتروني برامج الأصلي مؤخراَ يتم. مرجع توضع الشكلي انه للنص والتي. ألدوس التركيز القرن قرون. طويل شكلي الخارجي هناك كتيّب الشكلي هناك هو.", 50, 4, null, null, 2, 7, 1, "Procédure spéciale", "هيئات المعاهدات", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "مبادرة إقليمية لتعزيز قدرات المجتمعات الريفية في منطقة طنجة تطوان من حيث الجنس وتكافؤ الفرص", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "ما ببساطة يقرأها طويل مرة. زمن مثبتة هذا ويُستخدم عندما ودور انتشر. بايج لتكوّن مجهولة لهذه مجموعة. ألدوس منذ والتنضيد ودور مايكر مرة لصفحة حقيقة.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 55, "0.9.8.5", "6.1.5.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "المحتوى برامج إصدار مطبعة الزمن ظهور. عشر كتيّب ليتراسيت انتشر الخارجي.", "Réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الخامس زمن الخارجي تعطي وهي ودور كبير.", 19, 4, 5, null, 1, 7, null, "Examen périodique universal", "الإجراءات الخاصة", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "برنامج دعم تنفيذ إستراتيجية الوفد العام لإدارة السجون وإعادة الإدماج", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "طريقة القرن ويُستخدم.", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "CodeRecommendationAr", "Complement", "ComplementAr", "Etat", "EtatAr", "EtatAvancement", "EtatAvancementAr", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "MecanismeAr", "Nom", "NomAr", "Observation", "ObservationAr", "PieceJointe" },
                values: new object[] { 24, "4.5.4.8", "4.9.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "الشكلي الخارجي ليتراسيت ألدوس الزمن. كبير كبير مجموعة المطابع لتكوّن الشكلي ويُستخدم رقائق. وعاد التي مطبعة ستينيّات وبشكله. أخرى لهذه حتى تعطي توزيعاَ التركيز ولذلك الإلكتروني.", "Non réalisé", "غير محققة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "مجهولة شكل الخارجي أو الخارجي والتي طويل ما هي. وعاد قامت لم كتيّب.", 72, 6, null, 3, 4, 7, null, "Examen périodique universal", "هيئات المعاهدات", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "دعم تحسين استقبال المستخدمين في الخدمة العامة", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "النشر التركيز إصدار وعاد شكل لوريم بشكل دليل وعاد. لتكوّن عشوائي عن الشكل. مثل بايج بشكل إيبسوم منذ.", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 79, "ipsa", "منذ", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 61, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 80, "et", "بايج", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 72, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 17, "saepe", "على", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 72, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 21, "quibusdam", "إصدار", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 7, "quibusdam", "دليل", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 22, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 71, "libero", "أو", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 32, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 10, "aut", "عشر", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 29, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 6, "sed", "الخارجي", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 29, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 38, "autem", "أيضاً", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 10, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 30, "omnis", "بمثابة", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 61, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 61, "molestiae", "ظهور", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 54, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 47, "error", "ما", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 30, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 12, "laudantium", "الخامس", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 30, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 85, "iste", "الزمن", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 91, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 60, "dicta", "الأصلي", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 91, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 13, "a", "دليل", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 51, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 56, "quisquam", "وهي", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 78, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 84, "quos", "الفقرات", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 64, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 64, "molestias", "انتشر", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 85, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 19, "ut", "تعطي", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 85, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 82, "omnis", "طريقة", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 72, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 28, "assumenda", "هي", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 61, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 98, "molestias", "التي", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 88, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 54, "dignissimos", "الأصلي", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 28, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 3, "est", "شكلي", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 57, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 92, "magni", "الصفحة", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 41, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 18, "quod", "تحوي", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 27, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 44, "rem", "الإلكتروني", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 86, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 29, "est", "كتيّب", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 86, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 51, "quis", "هي", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 46, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 49, "aut", "حتى", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 46, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 16, "voluptates", "على", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 46, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 11, "atque", "برص", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 46, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 2, "qui", "أن", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 46, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 20, "fugiat", "القارئ", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 14, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 1, "omnis", "انتشر", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 1, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 90, "occaecati", "مايكر", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 96, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 75, "dolorem", "عشر", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 8, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 35, "natus", "من", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 21, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 78, "dolor", "أخرى", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 99, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 25, "qui", "دليل", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 99, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 45, "aut", "خمسة", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 6, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 37, "maiores", "مطبعة", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 6, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 81, "expedita", "القارئ", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 38, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 69, "dolorum", "مجهولة", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 57, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 52, "esse", "تحوي", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 57, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 22, "qui", "بمعنى", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 57, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 26, "odit", "يتم", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 96, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 14, "facere", "بايج", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 41, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 41, "dolores", "التي", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 71, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 43, "facere", "القرن", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 73, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 55, "aspernatur", "البلاستيكية", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 48, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 8, "voluptas", "منذ", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 75, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 31, "minus", "ودور", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 31, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 46, "perspiciatis", "ببساطة", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 52, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 15, "natus", "أخرى", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 52, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 65, "quibusdam", "الخامس", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 15, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 87, "sint", "أيضاً", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 5, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 96, "aliquam", "بشكل", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 44, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 4, "ducimus", "مقاطع", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 44, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 63, "incidunt", "لينتشر", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 43, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 77, "ut", "الغاية", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 34, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 72, "eaque", "برص", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 34, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 9, "et", "وهي", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 34, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 73, "aut", "مجهولة", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 16, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 32, "quos", "شكلي", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 2, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 48, "saepe", "إصدار", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 59, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 40, "dolor", "النص", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 59, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 27, "illo", "هو", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 59, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 99, "exercitationem", "القرن", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 82, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 94, "labore", "أو", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 82, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 86, "voluptatibus", "ودور", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 28, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 57, "aut", "هي", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 34, "temporibus", "ليتراسيت", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 13, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 58, "quia", "صار", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 13, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 66, "maiores", "توزيعاَ", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 13, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 24, "ut", "بايج", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 58, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 59, "est", "خمسة", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 45, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 5, "quo", "الفقرات", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 45, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 53, "placeat", "طويل", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 93, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 74, "sed", "وليس", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 92, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 33, "consequatur", "لوريم", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 7, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 67, "placeat", "بشكل", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 33, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 93, "quae", "للنص", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 87, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 91, "et", "لينتشر", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 60, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 42, "ipsum", "إصدار", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 60, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 89, "odit", "المحتوى", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 73, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 97, "autem", "الخارجي", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 80, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 70, "tempora", "ببساطة", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 63, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 100, "ducimus", "المقروء", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 20, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 23, "explicabo", "يتم", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 20, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 88, "cumque", "كبير", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 19, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 83, "eum", "وليس", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 39, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 76, "quia", "في", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 94, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 50, "fugit", "عندما", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 94, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 39, "perspiciatis", "شكل", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 94, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 62, "quia", "مقاطع", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 71, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 95, "sit", "مجموعة", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 13, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 36, "dignissimos", "بايج", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 80, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "CodeAr", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[] { 68, "velit", "لصفحة", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 70, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/ergonomic-cotton-ball", 3, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/hierarchy", 6, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/suriname/divide/designer", 6, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/handcrafted/static/synergize", 4, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/next-generation/alarm/payment", 3, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/investment-account", 6, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/connecting", 6, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/garden--outdoors/sharable/granite", 5, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/rustic-soft-chips/rubber", 2, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/awesome-frozen-pizza", 5, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/tan/monaco/gorgeous-wooden-towels", 6, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/fantastic-concrete-cheese/street", 1, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/applications/online", 7, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/movies-electronics--computers", 4, 33 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/frozen/profound/forward", 1, 53 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/granite/grove", 1, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/analyst/buckinghamshire", 5, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/hill/deliverables", 5, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/outdoors", 2, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/efficient/legacy", 3, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/target/incredible-granite-tuna", 7, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/dong", 6, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/crossroad/networks/cultivate", 4, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/incredible-soft-computer/games-health--sports", 4, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/integration", 5, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/view/toys-outdoors--music/plastic", 6, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/knowledge-user/users/fantastic", 1, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/capacitor/handcrafted-rubber-soap", 3, 99 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/handcrafted", 6, 40 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/input/sleek-wooden-shirt/croatian-kuna", 4, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/personal-loan-account", 4, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/back-end", 7, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/override/buckinghamshire", 3, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/money-market-account/input/array", 6, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/alaska/soft/trail", 3, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/rupiah/investment-account/jordan", 6, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/blockchains/blue", 5, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/small-concrete-mouse", 5, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/project", 4, 15 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/ram", 4, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/indexing/input/synergize", 4, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/greens", 1, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/deposit/lime", 2, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/invoice/slovakia-slovak-republic/forecast", 7, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/sql/small/right-sized", 5, 34 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/netherlands-antillian-guilder/directional", 1, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/director", 5, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/kenya", 5, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/beauty--outdoors/cedi/sleek-wooden-shoes", 1, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/cohesive/hawaii/handmade", 7, 13 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/ergonomic-wooden-pizza", 2, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/toys--shoes", 2, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/programming/programming/transition", 7, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/chief/hong-kong", 3, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/trail/gb/gambia", 6, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/tan", 4, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/copy/licensed-rubber-soap/bedfordshire", 5, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/spurs/italy/frozen", 6, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/yemeni-rial/bandwidth", 1, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/http/music-clothing--outdoors", 1, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/secured-line", 4, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/interactive/e-tailers", 7, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/gb/rest", 3, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/money-market-account/out-of-the-box", 3, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/croatian-kuna", 5, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/xml/indexing", 4, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/backing-up", 5, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/invoice/compress/orchestrator", 7, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/neutral/feed", 6, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/architect/mobile/communities", 7, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/gorgeous-cotton-shirt/steel/island", 3, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/computers--industrial", 6, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/ai/jbod/triple-buffered", 5, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/automotive/adapter", 5, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/pink/primary", 4, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/buckinghamshire", 2, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/grocery--clothing/home-loan-account/turquoise", 4, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/connect/georgia/digital", 1, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/uniform", 2, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/client-server/multi-tiered/coordinator", 3, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/metal/input", 7, 28 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/well-modulated/quantify", 1, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/circuit/steel", 1, 38 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/fuchsia/deposit/optical", 3, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/definition", 2, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/sudan/awesome-soft-computer/maximize", 4, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/awesome/withdrawal/fresh", 5, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/centers/object-based/quantify", 2, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/frozen/personal-loan-account/handcrafted-plastic-towels", 3, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/arizona/kids", 4, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/adaptive", 3, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/circuit", 5, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/infrastructure", 7, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/index/coordinator", 4, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/reduced", 1, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/springs", 3, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/transmitter/applications", 5, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/coves/workforce", 1, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/purple/kiribati", 7, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/handmade-wooden-shoes/avon/oval", 6, 86 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 2, new DateTime(2020, 5, 17, 17, 14, 5, 789, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 4, new DateTime(2020, 4, 9, 23, 24, 8, 226, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 4, new DateTime(2019, 9, 26, 0, 36, 37, 376, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 3, new DateTime(2019, 9, 17, 0, 25, 3, 518, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 3, new DateTime(2019, 7, 26, 8, 29, 53, 901, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 4, new DateTime(2020, 6, 20, 2, 30, 13, 915, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 2, new DateTime(2019, 8, 13, 7, 7, 38, 636, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 5, new DateTime(2020, 3, 17, 13, 5, 56, 70, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 6, new DateTime(2020, 1, 25, 14, 47, 56, 965, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 4, new DateTime(2020, 7, 11, 10, 35, 22, 17, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 6, new DateTime(2019, 10, 19, 19, 31, 56, 901, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 1, new DateTime(2019, 8, 10, 5, 47, 46, 322, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 5, new DateTime(2019, 8, 6, 11, 11, 50, 8, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 6, new DateTime(2020, 7, 2, 3, 19, 4, 212, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 2, new DateTime(2019, 12, 19, 17, 20, 29, 954, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 2, new DateTime(2019, 8, 4, 11, 40, 35, 703, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 6, new DateTime(2019, 11, 25, 3, 24, 50, 152, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 4, new DateTime(2019, 7, 22, 22, 52, 48, 530, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 6, new DateTime(2020, 4, 22, 1, 35, 48, 940, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 5, new DateTime(2020, 1, 1, 17, 17, 44, 846, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 6, new DateTime(2020, 1, 21, 14, 44, 9, 645, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 6, new DateTime(2020, 6, 29, 19, 56, 52, 770, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 3, new DateTime(2020, 3, 4, 0, 22, 19, 591, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 4, new DateTime(2020, 7, 11, 13, 32, 2, 515, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 6, new DateTime(2019, 10, 11, 10, 15, 47, 958, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 4, new DateTime(2019, 7, 24, 17, 20, 36, 764, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 3, new DateTime(2020, 4, 22, 10, 48, 40, 699, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 5, new DateTime(2019, 11, 22, 6, 7, 39, 229, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 3, new DateTime(2019, 11, 6, 21, 35, 33, 64, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 2, new DateTime(2020, 3, 14, 11, 10, 3, 712, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 3, new DateTime(2020, 5, 2, 17, 27, 43, 676, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 6, new DateTime(2019, 12, 4, 10, 35, 50, 700, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 5, new DateTime(2019, 9, 13, 7, 11, 58, 945, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 1, new DateTime(2020, 1, 23, 13, 11, 39, 178, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 2, new DateTime(2019, 8, 16, 12, 51, 38, 112, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 6, new DateTime(2019, 8, 14, 7, 51, 39, 423, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 4, new DateTime(2020, 5, 13, 0, 19, 57, 93, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 5, new DateTime(2020, 5, 9, 17, 5, 20, 570, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 2, new DateTime(2019, 9, 3, 1, 2, 39, 647, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 1, new DateTime(2019, 10, 12, 21, 30, 2, 370, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 4, new DateTime(2020, 7, 16, 19, 17, 52, 868, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 6, new DateTime(2020, 4, 13, 4, 11, 16, 697, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 3, new DateTime(2019, 11, 8, 6, 18, 55, 728, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 1, new DateTime(2019, 11, 16, 20, 57, 46, 680, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 6, new DateTime(2020, 2, 27, 7, 57, 32, 202, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 3, new DateTime(2019, 11, 12, 22, 10, 11, 825, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 5, new DateTime(2020, 2, 10, 19, 14, 50, 15, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 5, new DateTime(2019, 10, 25, 20, 34, 32, 523, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 4, new DateTime(2019, 7, 30, 11, 21, 0, 8, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 4, new DateTime(2020, 7, 6, 14, 47, 8, 131, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 4, new DateTime(2019, 9, 21, 4, 7, 44, 4, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 1, new DateTime(2020, 6, 26, 18, 33, 12, 375, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 1, new DateTime(2020, 4, 10, 21, 17, 7, 373, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 1, new DateTime(2020, 2, 26, 20, 53, 1, 566, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 5, new DateTime(2019, 12, 18, 5, 7, 12, 909, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 4, new DateTime(2019, 9, 17, 16, 40, 43, 998, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 1, new DateTime(2019, 11, 20, 17, 51, 33, 593, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 4, new DateTime(2019, 10, 28, 10, 25, 50, 251, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 4, new DateTime(2020, 6, 30, 17, 20, 17, 103, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 2, new DateTime(2019, 12, 23, 7, 4, 45, 291, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 1, new DateTime(2019, 10, 3, 20, 45, 31, 474, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 1, new DateTime(2020, 2, 25, 15, 45, 20, 315, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 6, new DateTime(2019, 9, 19, 15, 6, 7, 380, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 1, new DateTime(2019, 7, 22, 16, 52, 58, 108, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 3, new DateTime(2019, 12, 27, 20, 1, 22, 786, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 1, new DateTime(2020, 7, 1, 1, 42, 57, 695, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 1, new DateTime(2020, 6, 8, 20, 40, 34, 23, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 2, new DateTime(2019, 10, 21, 19, 10, 48, 781, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 4, new DateTime(2019, 9, 24, 18, 16, 35, 570, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 2, new DateTime(2019, 10, 23, 9, 56, 51, 2, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 5, new DateTime(2020, 4, 9, 16, 39, 4, 647, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 4, new DateTime(2020, 3, 22, 21, 1, 33, 795, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 2, new DateTime(2020, 4, 18, 6, 45, 18, 146, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 2, new DateTime(2019, 11, 2, 9, 33, 16, 906, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 6, new DateTime(2020, 4, 1, 8, 34, 48, 870, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 6, new DateTime(2020, 3, 21, 23, 8, 50, 418, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 1, new DateTime(2020, 2, 28, 18, 42, 22, 33, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 5, new DateTime(2020, 6, 25, 22, 30, 31, 880, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 2, new DateTime(2019, 8, 4, 17, 2, 50, 868, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 4, new DateTime(2019, 9, 22, 4, 22, 35, 672, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 4, new DateTime(2020, 1, 20, 12, 22, 9, 934, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 5, new DateTime(2019, 12, 21, 20, 16, 56, 312, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 4, new DateTime(2020, 7, 2, 23, 5, 43, 365, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 6, new DateTime(2019, 11, 20, 23, 48, 58, 397, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 5, new DateTime(2019, 8, 15, 2, 48, 30, 99, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 2, new DateTime(2019, 8, 25, 0, 48, 11, 794, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 6, new DateTime(2020, 4, 25, 1, 42, 21, 399, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 1, new DateTime(2020, 4, 8, 14, 1, 27, 168, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 1, new DateTime(2019, 7, 27, 10, 19, 33, 330, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 1, new DateTime(2019, 10, 2, 15, 47, 33, 508, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 2, new DateTime(2020, 3, 16, 0, 21, 32, 531, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 5, new DateTime(2020, 5, 14, 11, 2, 24, 648, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 2, new DateTime(2020, 2, 15, 10, 26, 1, 23, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 3, new DateTime(2020, 5, 16, 4, 30, 17, 428, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 1, new DateTime(2020, 4, 7, 18, 5, 40, 130, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 3, new DateTime(2020, 5, 30, 4, 20, 36, 128, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 2, new DateTime(2019, 8, 27, 12, 48, 49, 622, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 1, new DateTime(2019, 9, 23, 0, 40, 12, 189, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 2, new DateTime(2019, 12, 29, 9, 7, 14, 408, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 3, new DateTime(2019, 10, 1, 23, 37, 36, 981, DateTimeKind.Local).AddTicks(6998) });

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
