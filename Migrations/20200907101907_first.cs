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
                values: new object[] { 10, "Categorie 1", new DateTime(2020, 2, 6, 9, 24, 39, 684, DateTimeKind.Local).AddTicks(7680), "Et tempore sed quia qui maxime. Sint voluptas voluptas vel et. Earum quia excepturi nihil ut placeat eos. Earum officia sed sapiente commodi. Earum aperiam ut doloremque ducimus numquam aperiam est. Voluptas sed itaque incidunt odio. Consequatur perferendis laborum dolorum ullam vitae veritatis eveniet consectetur. Possimus exercitationem quia quo dicta repellat. Modi illo ex deleniti. Consequatur commodi officia deleniti suscipit dolor sit.", "molestias" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 9, "Categorie 1", new DateTime(2019, 11, 13, 22, 45, 27, 367, DateTimeKind.Local).AddTicks(6893), "Aut pariatur veniam odio. Voluptatem eius unde consectetur. Id modi voluptatem commodi necessitatibus nobis ut. Itaque aut quia distinctio iste omnis laudantium quam. Consequatur est voluptas ipsum et velit dolores a asperiores accusamus. Deserunt natus voluptatem ducimus perspiciatis eum quia porro. Dignissimos neque nulla. Consequatur voluptate quaerat perferendis ducimus nostrum occaecati reiciendis minus corporis. Vero nihil nihil vel. Sit voluptate eveniet.", "ut" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 8, "Categorie 1", new DateTime(2020, 7, 25, 23, 16, 36, 749, DateTimeKind.Local).AddTicks(3018), "Similique tempora aut aut possimus vero facilis. Aut eos et nihil doloremque labore temporibus consequatur mollitia. Aut ut magnam quas eum a voluptas. Doloremque ad assumenda. Rerum consequatur corrupti officia. Id quo voluptate dolores voluptas ipsum. Qui sed tempore. Eos assumenda inventore modi a nostrum. Voluptatem enim et nulla voluptatem. Maxime dolorem consequatur asperiores. Reiciendis repudiandae itaque odio consequatur illo provident consectetur.", "eum" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 7, "Categorie 1", new DateTime(2019, 10, 12, 11, 30, 24, 15, DateTimeKind.Local).AddTicks(3615), "Iste consequatur velit voluptas voluptatibus quo sed qui. Dolor quas vel at non illum hic. Officia qui et aut dolor magnam facilis sed quidem eum. Et molestiae veniam minus voluptatem enim. Quas ut facere ut aut est aspernatur. Occaecati deserunt asperiores vero quae et labore voluptatem dolore id. Similique est fugit omnis facilis ut aut distinctio soluta expedita. Est sed qui est enim velit dolores labore facere ipsam. Accusamus minus illo. Omnis dolor omnis libero. Eaque consequuntur ex cumque temporibus reprehenderit maiores odit alias delectus. Esse aliquam dolorum illum debitis ad qui mollitia dolorem necessitatibus. Pariatur officia omnis.", "suscipit" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 6, "Categorie 1", new DateTime(2019, 11, 7, 8, 46, 26, 832, DateTimeKind.Local).AddTicks(1219), "At libero deserunt delectus voluptatem. Earum similique quam rerum adipisci tempore est expedita minus. Commodi repudiandae repellat. Voluptas molestias qui velit officiis ipsam placeat officiis. Rem eum voluptatem itaque aliquam voluptas. Ullam soluta quam ullam sunt totam et voluptas est nobis. Sint ut et autem ad hic. Quos nisi dicta dolor explicabo quo sed et. Hic fugit officiis. Sint voluptas vel qui soluta dolores cumque explicabo. Impedit quaerat quisquam amet voluptates.", "hic" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 4, "Categorie 1", new DateTime(2020, 2, 8, 22, 20, 58, 629, DateTimeKind.Local).AddTicks(6002), "Optio qui mollitia debitis error. Distinctio doloribus ea exercitationem. Ducimus sint voluptate aut laboriosam distinctio in aliquam sint illo. Est est ab et molestias recusandae quia ullam et. Et animi facere tempore est ex facere eum facilis et. Et quo eos minima vel recusandae ipsum. Quos error quibusdam. Eveniet explicabo doloribus eum. Quisquam qui dolor inventore autem illo sit ipsam expedita laboriosam. Corporis facilis officiis ad iusto aliquam aspernatur saepe. Laboriosam eligendi alias aperiam. Aut commodi quidem vel vero.", "qui" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 3, "Categorie 1", new DateTime(2019, 10, 17, 3, 51, 1, 25, DateTimeKind.Local).AddTicks(231), "Cumque repudiandae perferendis magni perferendis et sit minus harum dolores. Est officiis deleniti quo. Ipsum soluta est impedit totam est ea voluptate. Architecto ut recusandae voluptatem qui voluptatem. Vel sit est sint repellat odio dicta vel pariatur. Odit totam eligendi sunt pariatur enim tempora laborum molestiae et. Beatae ducimus illo omnis est est earum itaque in rem. Ut autem sapiente perspiciatis nihil quia est minus mollitia quibusdam. Quas perspiciatis necessitatibus porro accusamus tempora distinctio nihil et. Ea consequatur minus aut porro. Reprehenderit placeat ratione debitis ducimus quos sed incidunt ipsam laborum. Id et molestiae optio nemo. Modi rerum excepturi distinctio.", "animi" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 2, "Categorie 1", new DateTime(2020, 2, 5, 20, 0, 7, 690, DateTimeKind.Local).AddTicks(361), "Ea neque beatae harum est et rerum et. Error nam eius suscipit ad. Natus nam ullam atque repudiandae. Sint repellat eligendi enim qui porro. Quod suscipit repellat suscipit quis recusandae cum vitae dicta. Quis repudiandae vel nam. Ullam a ut culpa quis. Tenetur ut cumque. Repellendus sit necessitatibus dolorem eum quia ad repellendus. Omnis repellat error voluptas pariatur ea animi dolore voluptatum. Aut similique aut quisquam sit optio. Delectus accusamus nisi quisquam temporibus et ullam mollitia.", "modi" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 1, "Categorie 1", new DateTime(2019, 9, 8, 2, 8, 15, 422, DateTimeKind.Local).AddTicks(3126), "Minus nemo nobis magni voluptates libero. Omnis autem odit minima iure. Enim nihil nulla pariatur ut consequatur voluptatem labore laudantium nemo. Veritatis voluptatem officia. Reprehenderit molestias explicabo. Recusandae possimus id natus modi quis voluptatibus ea sunt. Provident enim ut consequatur unde sit vero ipsam. Consequatur commodi exercitationem aliquam ut repellat natus et facilis. Et neque et. Esse qui dolorem. Eos dolorum error sint est qui excepturi recusandae.", "quis" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 5, "Categorie 1", new DateTime(2020, 6, 30, 1, 46, 19, 362, DateTimeKind.Local).AddTicks(6741), "Nam sint fugiat corrupti fugiat expedita nulla sapiente nesciunt. Odio optio nulla eligendi occaecati repellendus facilis. Explicabo rerum est accusantium qui maxime omnis repellendus eligendi eum. Et omnis fugit omnis voluptas non ex id voluptas ut. Nisi vel sed ea. Animi neque tempore fugit deserunt non qui. Rerum adipisci rerum consectetur sunt qui quae. Praesentium voluptatem ea fugiat quia et consequatur atque neque sit. Qui vero exercitationem incidunt corrupti quia ratione nesciunt fuga sit. Ut officia dolor deserunt necessitatibus. Similique dolorem excepturi eaque eius enim aut ea. Sunt ad soluta sequi.", "et" });

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
                values: new object[] { 73, new DateTime(2020, 4, 28, 23, 59, 37, 273, DateTimeKind.Local).AddTicks(1298), "1,3,5", 73, 6, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2020, 6, 30, 6, 13, 54, 342, DateTimeKind.Local).AddTicks(5581), "1,2,6", 72, 5, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2020, 5, 6, 22, 24, 10, 118, DateTimeKind.Local).AddTicks(1064), "0,3,5", 71, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2020, 8, 14, 7, 40, 53, 195, DateTimeKind.Local).AddTicks(4787), "0,3,4", 70, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2019, 12, 23, 1, 26, 51, 85, DateTimeKind.Local).AddTicks(7300), "1,2,6", 69, 3, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2019, 10, 18, 0, 25, 55, 367, DateTimeKind.Local).AddTicks(9561), "1,2,4", 68, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2019, 10, 27, 18, 54, 17, 421, DateTimeKind.Local).AddTicks(8783), "0,3,5", 67, 5, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2020, 4, 30, 4, 28, 8, 715, DateTimeKind.Local).AddTicks(4401), "1,3,4", 66, 5, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2020, 7, 23, 4, 11, 39, 95, DateTimeKind.Local).AddTicks(2161), "1,2,4", 65, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2019, 12, 9, 21, 58, 15, 7, DateTimeKind.Local).AddTicks(3493), "0,3,5", 64, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2020, 6, 11, 5, 22, 3, 433, DateTimeKind.Local).AddTicks(1924), "1,3,4", 63, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2020, 5, 30, 21, 32, 59, 757, DateTimeKind.Local).AddTicks(6628), "1,2,4", 61, 5, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2019, 10, 25, 13, 4, 33, 613, DateTimeKind.Local).AddTicks(9593), "1,2,4", 60, 1, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2019, 11, 15, 12, 10, 45, 427, DateTimeKind.Local).AddTicks(1188), "1,2,4", 59, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2020, 6, 22, 19, 32, 2, 480, DateTimeKind.Local).AddTicks(9403), "1,3,4", 58, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2020, 7, 3, 4, 27, 5, 718, DateTimeKind.Local).AddTicks(3697), "1,2,6", 57, 3, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2019, 10, 2, 0, 30, 50, 73, DateTimeKind.Local).AddTicks(7852), "1,3,6", 56, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2019, 11, 7, 3, 43, 16, 766, DateTimeKind.Local).AddTicks(9814), "1,2,4", 55, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2019, 9, 26, 12, 16, 11, 17, DateTimeKind.Local).AddTicks(6939), "1,3,5", 54, 1, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2020, 3, 26, 4, 56, 25, 662, DateTimeKind.Local).AddTicks(8260), "1,3,4", 53, 3, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2020, 8, 7, 23, 24, 27, 170, DateTimeKind.Local).AddTicks(4350), "1,2,4", 74, 1, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2020, 2, 7, 16, 16, 18, 127, DateTimeKind.Local).AddTicks(4297), "0,3,5", 62, 4, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2020, 7, 29, 14, 33, 35, 358, DateTimeKind.Local).AddTicks(2764), "0,3,5", 75, 4, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2020, 6, 4, 9, 44, 13, 419, DateTimeKind.Local).AddTicks(9449), "0,3,4", 93, 6, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2020, 8, 15, 0, 38, 49, 480, DateTimeKind.Local).AddTicks(5409), "0,3,5", 77, 2, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2020, 8, 25, 14, 51, 32, 946, DateTimeKind.Local).AddTicks(3499), "0,3,5", 100, 1, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2020, 7, 5, 16, 10, 40, 974, DateTimeKind.Local).AddTicks(7900), "1,3,5", 99, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2019, 9, 11, 22, 32, 54, 674, DateTimeKind.Local).AddTicks(3431), "1,3,4", 98, 1, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2020, 1, 15, 13, 46, 15, 93, DateTimeKind.Local).AddTicks(8825), "1,2,5", 97, 4, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2020, 2, 5, 17, 43, 58, 63, DateTimeKind.Local).AddTicks(3548), "0,3,5", 96, 1, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2020, 2, 22, 14, 0, 20, 297, DateTimeKind.Local).AddTicks(9026), "0,3,5", 95, 5, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2019, 10, 15, 19, 56, 0, 634, DateTimeKind.Local).AddTicks(2205), "1,2,4", 94, 1, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2020, 7, 15, 1, 26, 36, 404, DateTimeKind.Local).AddTicks(7291), "0,3,4", 52, 4, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2020, 2, 12, 5, 53, 8, 116, DateTimeKind.Local).AddTicks(4654), "1,3,4", 92, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2020, 7, 21, 7, 33, 47, 336, DateTimeKind.Local).AddTicks(1725), "0,2,6", 91, 5, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2020, 7, 29, 16, 17, 27, 956, DateTimeKind.Local).AddTicks(2204), "1,3,5", 76, 5, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2020, 6, 13, 6, 11, 23, 101, DateTimeKind.Local).AddTicks(6292), "1,2,6", 90, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2019, 12, 30, 18, 0, 49, 521, DateTimeKind.Local).AddTicks(9777), "0,3,6", 88, 2, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2019, 10, 6, 12, 46, 15, 274, DateTimeKind.Local).AddTicks(1087), "1,3,5", 87, 2, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2019, 11, 4, 13, 6, 31, 54, DateTimeKind.Local).AddTicks(6372), "1,2,6", 86, 3, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2020, 1, 9, 12, 40, 13, 199, DateTimeKind.Local).AddTicks(5830), "1,2,5", 85, 1, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2020, 1, 13, 16, 25, 10, 778, DateTimeKind.Local).AddTicks(8363), "1,3,4", 83, 6, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2019, 9, 18, 11, 23, 55, 145, DateTimeKind.Local).AddTicks(4257), "0,2,6", 82, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2020, 1, 30, 5, 58, 4, 604, DateTimeKind.Local).AddTicks(4241), "0,2,6", 81, 6, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2020, 7, 5, 18, 31, 49, 525, DateTimeKind.Local).AddTicks(3036), "1,2,5", 80, 2, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2020, 4, 4, 19, 36, 30, 408, DateTimeKind.Local).AddTicks(6177), "0,3,4", 79, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2020, 5, 13, 5, 21, 50, 299, DateTimeKind.Local).AddTicks(6518), "1,3,4", 78, 4, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2020, 7, 27, 8, 49, 26, 419, DateTimeKind.Local).AddTicks(924), "1,2,5", 89, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2019, 12, 6, 2, 46, 22, 300, DateTimeKind.Local).AddTicks(7972), "0,3,5", 51, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2020, 8, 9, 6, 26, 33, 796, DateTimeKind.Local).AddTicks(3699), "0,2,4", 84, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2019, 11, 7, 15, 53, 0, 231, DateTimeKind.Local).AddTicks(1299), "1,2,6", 49, 4, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2020, 6, 6, 17, 43, 38, 664, DateTimeKind.Local).AddTicks(9700), "1,2,5", 22, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2020, 5, 18, 18, 4, 9, 533, DateTimeKind.Local).AddTicks(1656), "1,3,4", 21, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2019, 12, 26, 3, 45, 37, 625, DateTimeKind.Local).AddTicks(4569), "0,2,4", 20, 2, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2020, 2, 29, 17, 24, 55, 969, DateTimeKind.Local).AddTicks(6220), "1,3,4", 19, 5, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2019, 12, 18, 11, 37, 46, 140, DateTimeKind.Local).AddTicks(8090), "1,3,5", 18, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2020, 2, 12, 3, 3, 40, 631, DateTimeKind.Local).AddTicks(122), "1,3,5", 17, 2, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2020, 6, 16, 1, 45, 10, 126, DateTimeKind.Local).AddTicks(7210), "1,3,6", 15, 3, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2020, 5, 30, 14, 29, 27, 140, DateTimeKind.Local).AddTicks(7324), "1,3,5", 14, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2020, 1, 23, 18, 48, 57, 632, DateTimeKind.Local).AddTicks(5842), "0,2,5", 13, 4, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2020, 9, 1, 0, 57, 2, 906, DateTimeKind.Local).AddTicks(6843), "1,2,6", 12, 1, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 1, 26, 2, 6, 21, 283, DateTimeKind.Local).AddTicks(3186), "1,3,4", 23, 3, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2020, 5, 25, 22, 16, 10, 933, DateTimeKind.Local).AddTicks(5217), "1,3,6", 11, 4, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2020, 7, 22, 21, 56, 43, 845, DateTimeKind.Local).AddTicks(4180), "0,3,5", 9, 1, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2020, 6, 26, 5, 20, 4, 336, DateTimeKind.Local).AddTicks(3895), "1,2,6", 8, 6, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2020, 2, 19, 5, 39, 31, 749, DateTimeKind.Local).AddTicks(8095), "1,3,5", 7, 1, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2020, 6, 27, 1, 8, 57, 430, DateTimeKind.Local).AddTicks(4920), "1,2,4", 6, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2020, 3, 1, 15, 51, 50, 731, DateTimeKind.Local).AddTicks(5159), "1,2,5", 5, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2019, 11, 2, 19, 8, 11, 406, DateTimeKind.Local).AddTicks(608), "0,2,4", 4, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2020, 1, 12, 1, 34, 53, 293, DateTimeKind.Local).AddTicks(3354), "1,2,5", 3, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2019, 11, 10, 7, 36, 17, 891, DateTimeKind.Local).AddTicks(3402), "1,3,4", 2, 6, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2020, 1, 30, 13, 0, 35, 255, DateTimeKind.Local).AddTicks(6325), "0,3,4", 1, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2019, 10, 24, 21, 23, 8, 8, DateTimeKind.Local).AddTicks(6362), "1,2,6", 50, 2, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2020, 2, 8, 17, 5, 15, 776, DateTimeKind.Local).AddTicks(2376), "0,2,5", 10, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2020, 3, 16, 19, 33, 11, 417, DateTimeKind.Local).AddTicks(9018), "1,3,5", 24, 4, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2020, 8, 31, 5, 53, 5, 504, DateTimeKind.Local).AddTicks(6662), "0,3,4", 16, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2020, 7, 7, 13, 23, 43, 683, DateTimeKind.Local).AddTicks(165), "1,2,6", 26, 3, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2020, 9, 2, 3, 3, 45, 598, DateTimeKind.Local).AddTicks(4090), "1,3,6", 48, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2020, 4, 4, 0, 8, 10, 825, DateTimeKind.Local).AddTicks(6489), "0,2,6", 47, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2020, 4, 18, 10, 18, 24, 907, DateTimeKind.Local).AddTicks(4928), "0,2,5", 46, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2019, 12, 28, 11, 46, 46, 507, DateTimeKind.Local).AddTicks(5630), "1,2,6", 25, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2020, 8, 21, 3, 54, 3, 420, DateTimeKind.Local).AddTicks(2918), "0,2,4", 44, 4, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2019, 11, 11, 17, 25, 57, 218, DateTimeKind.Local).AddTicks(6884), "0,2,5", 43, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2019, 10, 30, 6, 7, 20, 405, DateTimeKind.Local).AddTicks(5999), "1,2,4", 42, 1, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2020, 3, 15, 13, 24, 54, 748, DateTimeKind.Local).AddTicks(4589), "1,2,5", 41, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2020, 4, 24, 23, 10, 4, 886, DateTimeKind.Local).AddTicks(6592), "1,3,6", 40, 1, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2020, 3, 4, 20, 17, 27, 674, DateTimeKind.Local).AddTicks(1511), "1,2,4", 39, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2020, 2, 10, 9, 54, 29, 817, DateTimeKind.Local).AddTicks(9284), "1,2,5", 38, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2019, 10, 24, 15, 44, 39, 425, DateTimeKind.Local).AddTicks(9253), "0,2,6", 37, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2019, 11, 19, 21, 17, 9, 666, DateTimeKind.Local).AddTicks(67), "0,2,6", 45, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2020, 9, 2, 23, 58, 55, 267, DateTimeKind.Local).AddTicks(1705), "1,3,4", 35, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2020, 5, 30, 7, 9, 7, 90, DateTimeKind.Local).AddTicks(7235), "0,2,4", 34, 4, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2019, 10, 19, 14, 10, 43, 576, DateTimeKind.Local).AddTicks(1742), "0,3,5", 33, 2, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2019, 12, 2, 1, 1, 3, 657, DateTimeKind.Local).AddTicks(3037), "0,2,6", 27, 3, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2020, 7, 10, 17, 9, 17, 628, DateTimeKind.Local).AddTicks(8249), "1,3,5", 32, 5, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2020, 7, 6, 12, 19, 38, 291, DateTimeKind.Local).AddTicks(2537), "0,3,5", 31, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2020, 3, 10, 5, 54, 26, 531, DateTimeKind.Local).AddTicks(9082), "0,3,6", 30, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2019, 10, 10, 3, 59, 41, 264, DateTimeKind.Local).AddTicks(5608), "0,3,4", 29, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2020, 8, 27, 17, 27, 36, 585, DateTimeKind.Local).AddTicks(7959), "0,3,6", 28, 3, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2020, 3, 10, 20, 19, 14, 242, DateTimeKind.Local).AddTicks(617), "1,2,6", 36, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

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
                values: new object[] { 15, 2020, "", "sous theme 15", "Droits catégoriels" });

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
                values: new object[] { 11, 2020, "", "sous theme 11", "Droits catégoriels" });

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
                values: new object[] { 4, 2020, "", "sous theme 4", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 7, 2020, "", "sous theme 7", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 3, 2020, "", "sous theme 3", "Droits catégoriels" });

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
                values: new object[] { 66, "", "", new DateTime(2019, 11, 22, 14, 39, 26, 928, DateTimeKind.Local).AddTicks(527), new DateTime(2020, 1, 31, 22, 55, 12, 706, DateTimeKind.Local).AddTicks(6965), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 67, "", "", new DateTime(2019, 12, 16, 23, 40, 20, 271, DateTimeKind.Local).AddTicks(6560), new DateTime(2019, 10, 24, 13, 7, 27, 832, DateTimeKind.Local).AddTicks(5422), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 68, "", "", new DateTime(2020, 3, 21, 7, 23, 2, 55, DateTimeKind.Local).AddTicks(9529), new DateTime(2020, 2, 26, 11, 29, 12, 263, DateTimeKind.Local).AddTicks(3536), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 69, "", "", new DateTime(2020, 3, 3, 0, 27, 42, 853, DateTimeKind.Local).AddTicks(2680), new DateTime(2019, 11, 6, 22, 4, 10, 230, DateTimeKind.Local).AddTicks(6983), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 72, "", "", new DateTime(2020, 5, 18, 23, 33, 58, 673, DateTimeKind.Local).AddTicks(5803), new DateTime(2019, 9, 19, 10, 18, 55, 23, DateTimeKind.Local).AddTicks(1528), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 71, "", "", new DateTime(2019, 12, 14, 1, 21, 28, 593, DateTimeKind.Local).AddTicks(4938), new DateTime(2020, 2, 5, 13, 55, 10, 473, DateTimeKind.Local).AddTicks(3154), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 65, "", "", new DateTime(2020, 4, 30, 2, 25, 48, 192, DateTimeKind.Local).AddTicks(958), new DateTime(2020, 1, 2, 5, 18, 44, 281, DateTimeKind.Local).AddTicks(5864), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 73, "", "", new DateTime(2019, 9, 30, 10, 23, 22, 902, DateTimeKind.Local).AddTicks(7323), new DateTime(2020, 2, 10, 11, 24, 33, 137, DateTimeKind.Local).AddTicks(9470), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 74, "", "", new DateTime(2020, 5, 24, 8, 40, 54, 959, DateTimeKind.Local).AddTicks(8572), new DateTime(2020, 9, 7, 8, 58, 32, 962, DateTimeKind.Local).AddTicks(8907), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 70, "", "", new DateTime(2020, 5, 7, 15, 8, 36, 253, DateTimeKind.Local).AddTicks(3190), new DateTime(2020, 4, 9, 5, 59, 52, 489, DateTimeKind.Local).AddTicks(160), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 64, "", "", new DateTime(2020, 1, 30, 2, 48, 12, 863, DateTimeKind.Local).AddTicks(6571), new DateTime(2019, 11, 20, 21, 10, 12, 289, DateTimeKind.Local).AddTicks(9257), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 62, "", "", new DateTime(2020, 5, 9, 13, 36, 55, 573, DateTimeKind.Local).AddTicks(894), new DateTime(2020, 7, 26, 1, 14, 37, 931, DateTimeKind.Local).AddTicks(2401), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 53, "", "", new DateTime(2020, 3, 9, 1, 45, 18, 825, DateTimeKind.Local).AddTicks(7936), new DateTime(2020, 3, 21, 14, 22, 55, 942, DateTimeKind.Local).AddTicks(6817), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 61, "", "", new DateTime(2020, 5, 1, 18, 25, 52, 353, DateTimeKind.Local).AddTicks(75), new DateTime(2019, 12, 23, 9, 53, 3, 613, DateTimeKind.Local).AddTicks(3473), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 60, "", "", new DateTime(2019, 10, 9, 23, 9, 14, 407, DateTimeKind.Local).AddTicks(3625), new DateTime(2020, 8, 30, 23, 15, 3, 800, DateTimeKind.Local).AddTicks(1977), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 59, "", "", new DateTime(2019, 9, 29, 16, 18, 25, 999, DateTimeKind.Local).AddTicks(5013), new DateTime(2019, 10, 16, 11, 26, 58, 344, DateTimeKind.Local).AddTicks(9613), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 58, "", "", new DateTime(2019, 11, 6, 5, 6, 36, 504, DateTimeKind.Local).AddTicks(8231), new DateTime(2019, 11, 19, 16, 53, 56, 362, DateTimeKind.Local).AddTicks(9598), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 57, "", "", new DateTime(2019, 12, 25, 14, 27, 32, 46, DateTimeKind.Local).AddTicks(8084), new DateTime(2020, 3, 12, 18, 43, 32, 825, DateTimeKind.Local).AddTicks(7799), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 56, "", "", new DateTime(2020, 5, 9, 12, 9, 33, 827, DateTimeKind.Local).AddTicks(6916), new DateTime(2020, 7, 17, 3, 40, 0, 330, DateTimeKind.Local).AddTicks(6257), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 55, "", "", new DateTime(2019, 10, 12, 13, 42, 22, 656, DateTimeKind.Local).AddTicks(1458), new DateTime(2020, 2, 26, 4, 7, 34, 330, DateTimeKind.Local).AddTicks(9861), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 54, "", "", new DateTime(2020, 5, 13, 17, 25, 41, 321, DateTimeKind.Local).AddTicks(2731), new DateTime(2019, 10, 2, 17, 36, 17, 551, DateTimeKind.Local).AddTicks(962), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 75, "", "", new DateTime(2020, 1, 17, 2, 19, 55, 939, DateTimeKind.Local).AddTicks(9235), new DateTime(2020, 8, 2, 22, 58, 25, 238, DateTimeKind.Local).AddTicks(480), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 63, "", "", new DateTime(2020, 5, 9, 14, 30, 6, 919, DateTimeKind.Local).AddTicks(6945), new DateTime(2020, 4, 5, 13, 34, 37, 617, DateTimeKind.Local).AddTicks(2129), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 76, "", "", new DateTime(2020, 3, 8, 3, 51, 30, 98, DateTimeKind.Local).AddTicks(3006), new DateTime(2020, 3, 15, 13, 59, 54, 367, DateTimeKind.Local).AddTicks(6278), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 91, "", "", new DateTime(2020, 8, 21, 20, 38, 28, 642, DateTimeKind.Local).AddTicks(6797), new DateTime(2020, 2, 28, 9, 11, 1, 325, DateTimeKind.Local).AddTicks(893), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 78, "", "", new DateTime(2020, 5, 1, 19, 18, 8, 141, DateTimeKind.Local).AddTicks(27), new DateTime(2020, 7, 1, 10, 48, 0, 190, DateTimeKind.Local).AddTicks(6133), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 52, "", "", new DateTime(2020, 5, 1, 10, 59, 12, 433, DateTimeKind.Local).AddTicks(6362), new DateTime(2020, 3, 15, 18, 46, 21, 666, DateTimeKind.Local).AddTicks(7316), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 100, "", "", new DateTime(2019, 12, 10, 1, 52, 3, 820, DateTimeKind.Local).AddTicks(4848), new DateTime(2019, 12, 5, 20, 6, 4, 328, DateTimeKind.Local).AddTicks(1680), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 99, "", "", new DateTime(2019, 10, 3, 6, 25, 17, 892, DateTimeKind.Local).AddTicks(4200), new DateTime(2019, 11, 5, 6, 39, 46, 734, DateTimeKind.Local).AddTicks(9022), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 98, "", "", new DateTime(2019, 12, 9, 21, 12, 10, 379, DateTimeKind.Local).AddTicks(6342), new DateTime(2019, 12, 26, 17, 5, 27, 549, DateTimeKind.Local).AddTicks(8811), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 97, "", "", new DateTime(2020, 5, 28, 17, 17, 47, 152, DateTimeKind.Local).AddTicks(9470), new DateTime(2020, 3, 22, 18, 52, 21, 515, DateTimeKind.Local).AddTicks(4534), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 96, "", "", new DateTime(2020, 6, 1, 12, 20, 12, 124, DateTimeKind.Local).AddTicks(4553), new DateTime(2019, 10, 10, 16, 39, 30, 592, DateTimeKind.Local).AddTicks(4371), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 95, "", "", new DateTime(2020, 4, 12, 3, 54, 28, 877, DateTimeKind.Local).AddTicks(8767), new DateTime(2020, 2, 12, 13, 45, 9, 877, DateTimeKind.Local).AddTicks(2112), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 94, "", "", new DateTime(2020, 3, 15, 1, 37, 24, 774, DateTimeKind.Local).AddTicks(1776), new DateTime(2019, 12, 8, 19, 14, 5, 401, DateTimeKind.Local).AddTicks(700), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 93, "", "", new DateTime(2019, 12, 22, 17, 49, 43, 640, DateTimeKind.Local).AddTicks(1465), new DateTime(2020, 2, 3, 22, 45, 19, 983, DateTimeKind.Local).AddTicks(2607), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 92, "", "", new DateTime(2020, 7, 22, 11, 1, 34, 754, DateTimeKind.Local).AddTicks(1317), new DateTime(2020, 3, 25, 13, 5, 20, 771, DateTimeKind.Local).AddTicks(5113), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 77, "", "", new DateTime(2020, 4, 18, 6, 11, 21, 547, DateTimeKind.Local).AddTicks(991), new DateTime(2020, 7, 15, 12, 58, 5, 126, DateTimeKind.Local).AddTicks(3523), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 90, "", "", new DateTime(2020, 5, 22, 16, 19, 22, 229, DateTimeKind.Local).AddTicks(7500), new DateTime(2020, 8, 8, 3, 36, 6, 632, DateTimeKind.Local).AddTicks(6232), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 88, "", "", new DateTime(2019, 9, 8, 11, 33, 59, 563, DateTimeKind.Local).AddTicks(3664), new DateTime(2019, 9, 26, 20, 16, 20, 761, DateTimeKind.Local).AddTicks(1586), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 87, "", "", new DateTime(2019, 12, 21, 6, 45, 6, 137, DateTimeKind.Local).AddTicks(6784), new DateTime(2020, 9, 2, 7, 55, 18, 809, DateTimeKind.Local).AddTicks(9028), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 86, "", "", new DateTime(2019, 12, 3, 23, 43, 42, 635, DateTimeKind.Local).AddTicks(4141), new DateTime(2019, 11, 10, 16, 22, 12, 170, DateTimeKind.Local).AddTicks(9611), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 85, "", "", new DateTime(2020, 3, 29, 13, 57, 43, 603, DateTimeKind.Local).AddTicks(5282), new DateTime(2020, 4, 1, 2, 18, 31, 366, DateTimeKind.Local).AddTicks(7274), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 84, "", "", new DateTime(2019, 11, 12, 3, 45, 17, 724, DateTimeKind.Local).AddTicks(8474), new DateTime(2019, 10, 30, 15, 35, 10, 80, DateTimeKind.Local).AddTicks(2459), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 83, "", "", new DateTime(2019, 12, 6, 19, 56, 30, 752, DateTimeKind.Local).AddTicks(1871), new DateTime(2020, 8, 19, 14, 10, 55, 573, DateTimeKind.Local).AddTicks(4379), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 82, "", "", new DateTime(2020, 8, 20, 14, 53, 42, 11, DateTimeKind.Local).AddTicks(6169), new DateTime(2019, 10, 24, 12, 45, 50, 325, DateTimeKind.Local).AddTicks(825), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 81, "", "", new DateTime(2019, 11, 6, 6, 54, 40, 243, DateTimeKind.Local).AddTicks(2969), new DateTime(2019, 9, 9, 10, 40, 36, 721, DateTimeKind.Local).AddTicks(2917), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 80, "", "", new DateTime(2020, 4, 9, 12, 31, 27, 632, DateTimeKind.Local).AddTicks(5908), new DateTime(2019, 11, 14, 0, 28, 18, 774, DateTimeKind.Local).AddTicks(7344), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 79, "", "", new DateTime(2020, 6, 18, 7, 16, 58, 95, DateTimeKind.Local).AddTicks(9019), new DateTime(2019, 10, 18, 22, 21, 56, 351, DateTimeKind.Local).AddTicks(9646), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 89, "", "", new DateTime(2020, 5, 23, 6, 6, 43, 738, DateTimeKind.Local).AddTicks(4237), new DateTime(2020, 4, 20, 17, 22, 26, 507, DateTimeKind.Local).AddTicks(4329), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 51, "", "", new DateTime(2020, 1, 5, 15, 51, 40, 680, DateTimeKind.Local).AddTicks(6433), new DateTime(2019, 10, 8, 4, 44, 1, 952, DateTimeKind.Local).AddTicks(7843), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 8, "", "", new DateTime(2019, 12, 26, 6, 4, 53, 785, DateTimeKind.Local).AddTicks(7992), new DateTime(2019, 9, 25, 1, 49, 44, 887, DateTimeKind.Local).AddTicks(3768), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 49, "", "", new DateTime(2020, 6, 25, 13, 57, 55, 605, DateTimeKind.Local).AddTicks(3620), new DateTime(2020, 1, 23, 6, 9, 59, 624, DateTimeKind.Local).AddTicks(5434), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 22, "", "", new DateTime(2020, 6, 7, 3, 23, 42, 617, DateTimeKind.Local).AddTicks(9372), new DateTime(2020, 3, 8, 21, 22, 34, 464, DateTimeKind.Local).AddTicks(3647), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 21, "", "", new DateTime(2019, 12, 24, 2, 53, 37, 577, DateTimeKind.Local).AddTicks(701), new DateTime(2019, 10, 15, 12, 46, 57, 544, DateTimeKind.Local).AddTicks(9248), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 20, "", "", new DateTime(2020, 4, 19, 23, 30, 56, 154, DateTimeKind.Local).AddTicks(3914), new DateTime(2020, 5, 12, 19, 55, 19, 642, DateTimeKind.Local).AddTicks(8204), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 19, "", "", new DateTime(2019, 12, 27, 16, 53, 45, 789, DateTimeKind.Local).AddTicks(7297), new DateTime(2019, 12, 25, 16, 33, 27, 656, DateTimeKind.Local).AddTicks(4055), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 18, "", "", new DateTime(2019, 10, 31, 1, 51, 37, 437, DateTimeKind.Local).AddTicks(4304), new DateTime(2020, 2, 15, 5, 43, 42, 348, DateTimeKind.Local).AddTicks(3093), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 17, "", "", new DateTime(2020, 6, 25, 21, 46, 45, 604, DateTimeKind.Local).AddTicks(5368), new DateTime(2020, 1, 18, 21, 51, 33, 465, DateTimeKind.Local).AddTicks(4989), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 16, "", "", new DateTime(2019, 11, 9, 0, 9, 58, 148, DateTimeKind.Local).AddTicks(9593), new DateTime(2020, 5, 7, 10, 29, 48, 590, DateTimeKind.Local).AddTicks(3444), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 15, "", "", new DateTime(2020, 4, 4, 3, 43, 12, 120, DateTimeKind.Local).AddTicks(2429), new DateTime(2020, 5, 6, 22, 38, 20, 705, DateTimeKind.Local).AddTicks(2664), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 14, "", "", new DateTime(2020, 5, 29, 3, 26, 42, 869, DateTimeKind.Local).AddTicks(5599), new DateTime(2019, 12, 1, 12, 56, 28, 711, DateTimeKind.Local).AddTicks(6705), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 13, "", "", new DateTime(2020, 3, 2, 17, 45, 45, 373, DateTimeKind.Local).AddTicks(331), new DateTime(2019, 11, 19, 21, 24, 23, 217, DateTimeKind.Local).AddTicks(2372), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 12, "", "", new DateTime(2019, 11, 28, 15, 40, 33, 49, DateTimeKind.Local).AddTicks(2193), new DateTime(2020, 5, 8, 22, 4, 57, 143, DateTimeKind.Local).AddTicks(799), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 11, "", "", new DateTime(2019, 10, 26, 10, 19, 25, 984, DateTimeKind.Local).AddTicks(9741), new DateTime(2020, 3, 4, 5, 50, 29, 402, DateTimeKind.Local).AddTicks(6882), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 10, "", "", new DateTime(2019, 10, 15, 3, 37, 40, 553, DateTimeKind.Local).AddTicks(8099), new DateTime(2020, 8, 21, 9, 9, 53, 687, DateTimeKind.Local).AddTicks(9869), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 9, "", "", new DateTime(2019, 10, 12, 10, 35, 40, 363, DateTimeKind.Local).AddTicks(1071), new DateTime(2020, 9, 4, 6, 12, 11, 619, DateTimeKind.Local).AddTicks(9605), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 7, "", "", new DateTime(2020, 4, 17, 11, 43, 55, 361, DateTimeKind.Local).AddTicks(9331), new DateTime(2020, 4, 3, 7, 34, 6, 380, DateTimeKind.Local).AddTicks(6651), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 6, "", "", new DateTime(2019, 12, 11, 17, 6, 6, 54, DateTimeKind.Local).AddTicks(5134), new DateTime(2020, 6, 20, 0, 45, 56, 550, DateTimeKind.Local).AddTicks(6603), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 5, "", "", new DateTime(2019, 12, 13, 19, 26, 11, 561, DateTimeKind.Local).AddTicks(2859), new DateTime(2020, 7, 1, 18, 11, 13, 925, DateTimeKind.Local).AddTicks(6921), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 4, "", "", new DateTime(2020, 4, 26, 20, 22, 54, 394, DateTimeKind.Local).AddTicks(6073), new DateTime(2019, 10, 28, 20, 4, 32, 0, DateTimeKind.Local).AddTicks(3859), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 3, "", "", new DateTime(2019, 11, 22, 5, 5, 32, 44, DateTimeKind.Local).AddTicks(52), new DateTime(2020, 6, 5, 2, 9, 17, 711, DateTimeKind.Local).AddTicks(8179), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 2, "", "", new DateTime(2020, 6, 16, 19, 11, 53, 951, DateTimeKind.Local).AddTicks(1792), new DateTime(2020, 3, 21, 9, 36, 20, 426, DateTimeKind.Local).AddTicks(5923), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 50, "", "", new DateTime(2020, 6, 14, 14, 37, 38, 255, DateTimeKind.Local).AddTicks(2872), new DateTime(2019, 10, 16, 11, 42, 53, 444, DateTimeKind.Local).AddTicks(4003), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 23, "", "", new DateTime(2020, 5, 21, 8, 46, 21, 316, DateTimeKind.Local).AddTicks(7688), new DateTime(2019, 9, 22, 15, 4, 44, 566, DateTimeKind.Local).AddTicks(8009), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 24, "", "", new DateTime(2019, 10, 25, 17, 45, 16, 746, DateTimeKind.Local).AddTicks(1858), new DateTime(2020, 6, 17, 10, 39, 26, 736, DateTimeKind.Local).AddTicks(2176), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 1, "", "", new DateTime(2020, 4, 13, 11, 19, 15, 386, DateTimeKind.Local).AddTicks(3209), new DateTime(2020, 3, 13, 23, 17, 41, 285, DateTimeKind.Local).AddTicks(9448), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 26, "", "", new DateTime(2020, 2, 6, 11, 15, 41, 430, DateTimeKind.Local).AddTicks(2824), new DateTime(2020, 5, 30, 13, 40, 47, 720, DateTimeKind.Local).AddTicks(2999), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 25, "", "", new DateTime(2020, 4, 18, 14, 0, 8, 807, DateTimeKind.Local).AddTicks(2998), new DateTime(2020, 7, 27, 19, 36, 18, 547, DateTimeKind.Local).AddTicks(1136), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 47, "", "", new DateTime(2019, 9, 7, 11, 25, 19, 547, DateTimeKind.Local).AddTicks(9938), new DateTime(2019, 9, 16, 17, 45, 43, 158, DateTimeKind.Local).AddTicks(7892), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 46, "", "", new DateTime(2020, 5, 22, 11, 36, 25, 60, DateTimeKind.Local).AddTicks(8568), new DateTime(2020, 1, 9, 14, 8, 12, 782, DateTimeKind.Local).AddTicks(4527), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 45, "", "", new DateTime(2019, 11, 28, 13, 14, 43, 995, DateTimeKind.Local).AddTicks(9896), new DateTime(2020, 7, 27, 5, 40, 20, 945, DateTimeKind.Local).AddTicks(2218), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 44, "", "", new DateTime(2019, 11, 23, 5, 47, 12, 557, DateTimeKind.Local).AddTicks(270), new DateTime(2019, 10, 25, 12, 9, 41, 731, DateTimeKind.Local).AddTicks(120), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 43, "", "", new DateTime(2019, 9, 29, 13, 11, 35, 813, DateTimeKind.Local).AddTicks(7815), new DateTime(2019, 12, 22, 5, 54, 35, 640, DateTimeKind.Local).AddTicks(7210), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 42, "", "", new DateTime(2020, 6, 18, 1, 53, 53, 350, DateTimeKind.Local).AddTicks(7098), new DateTime(2020, 5, 11, 4, 37, 50, 959, DateTimeKind.Local).AddTicks(4757), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 41, "", "", new DateTime(2020, 4, 15, 1, 26, 21, 598, DateTimeKind.Local).AddTicks(881), new DateTime(2020, 2, 3, 23, 9, 44, 313, DateTimeKind.Local).AddTicks(8410), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 40, "", "", new DateTime(2019, 11, 19, 17, 0, 9, 856, DateTimeKind.Local).AddTicks(1099), new DateTime(2020, 4, 11, 12, 47, 24, 258, DateTimeKind.Local).AddTicks(7006), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 39, "", "", new DateTime(2019, 11, 25, 19, 0, 51, 831, DateTimeKind.Local).AddTicks(7962), new DateTime(2020, 4, 29, 6, 25, 53, 665, DateTimeKind.Local).AddTicks(6469), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 38, "", "", new DateTime(2019, 10, 7, 5, 35, 38, 271, DateTimeKind.Local).AddTicks(7778), new DateTime(2020, 4, 17, 7, 35, 10, 108, DateTimeKind.Local).AddTicks(7617), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 48, "", "", new DateTime(2020, 3, 7, 1, 18, 29, 307, DateTimeKind.Local).AddTicks(9734), new DateTime(2020, 4, 19, 9, 39, 8, 279, DateTimeKind.Local).AddTicks(3541), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 36, "", "", new DateTime(2019, 10, 24, 19, 28, 47, 310, DateTimeKind.Local).AddTicks(451), new DateTime(2020, 3, 20, 23, 10, 34, 684, DateTimeKind.Local).AddTicks(9050), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 27, "", "", new DateTime(2019, 9, 10, 3, 14, 52, 100, DateTimeKind.Local).AddTicks(4117), new DateTime(2020, 8, 10, 21, 44, 48, 268, DateTimeKind.Local).AddTicks(8944), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 37, "", "", new DateTime(2020, 5, 12, 22, 35, 40, 833, DateTimeKind.Local).AddTicks(1775), new DateTime(2020, 7, 28, 16, 57, 10, 414, DateTimeKind.Local).AddTicks(2248), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 29, "", "", new DateTime(2019, 11, 3, 1, 55, 24, 414, DateTimeKind.Local).AddTicks(248), new DateTime(2020, 9, 2, 19, 46, 54, 602, DateTimeKind.Local).AddTicks(2965), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 30, "", "", new DateTime(2019, 12, 23, 20, 55, 43, 57, DateTimeKind.Local).AddTicks(7191), new DateTime(2020, 8, 9, 10, 5, 53, 314, DateTimeKind.Local).AddTicks(2455), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 31, "", "", new DateTime(2020, 2, 22, 0, 26, 31, 841, DateTimeKind.Local).AddTicks(5042), new DateTime(2020, 7, 21, 5, 33, 55, 273, DateTimeKind.Local).AddTicks(4007), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 28, "", "", new DateTime(2020, 5, 3, 7, 46, 49, 966, DateTimeKind.Local).AddTicks(2083), new DateTime(2019, 12, 27, 17, 10, 1, 4, DateTimeKind.Local).AddTicks(228), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 33, "", "", new DateTime(2019, 12, 20, 10, 25, 5, 754, DateTimeKind.Local).AddTicks(708), new DateTime(2020, 7, 5, 11, 38, 35, 557, DateTimeKind.Local).AddTicks(708), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 34, "", "", new DateTime(2019, 10, 22, 8, 53, 37, 209, DateTimeKind.Local).AddTicks(9932), new DateTime(2020, 2, 26, 2, 42, 42, 886, DateTimeKind.Local).AddTicks(9586), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 35, "", "", new DateTime(2019, 12, 31, 4, 57, 43, 238, DateTimeKind.Local).AddTicks(5620), new DateTime(2020, 5, 8, 15, 20, 34, 913, DateTimeKind.Local).AddTicks(1223), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 32, "", "", new DateTime(2020, 1, 3, 19, 24, 39, 221, DateTimeKind.Local).AddTicks(3762), new DateTime(2020, 2, 11, 11, 52, 11, 347, DateTimeKind.Local).AddTicks(2519), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 65, new DateTime(2020, 3, 23, 1, 10, 18, 293, DateTimeKind.Local).AddTicks(5189), "Et sit modi perferendis aut nisi ut esse neque omnis. Iure aut non sit. Atque provident eveniet repudiandae. Tenetur sit consequatur hic atque nulla eum reiciendis. Nihil rem dolor. Tempora deserunt fuga sapiente aut culpa dolorum soluta.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 72, new DateTime(2019, 9, 20, 20, 7, 8, 40, DateTimeKind.Local).AddTicks(531), "Omnis ullam aut ea laboriosam dolorum. Perspiciatis repudiandae est. Enim magni et.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 71, new DateTime(2019, 9, 14, 15, 28, 4, 60, DateTimeKind.Local).AddTicks(8471), "Cumque dolores quae et accusamus. Sequi facilis qui est sed nihil et magnam ullam. Soluta odit rerum et autem. Necessitatibus itaque ea quod fuga similique soluta enim ab. Id rerum nobis aliquam. Impedit veritatis eligendi optio repellat.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 70, new DateTime(2020, 3, 29, 12, 8, 26, 527, DateTimeKind.Local).AddTicks(7490), "Voluptatem facilis sed voluptatem aut et et. Ab et voluptatem aperiam quas et et saepe. Earum necessitatibus quibusdam et dolorem alias qui quos. Odio reiciendis eum facere nemo laboriosam non natus pariatur. Aut facere consequatur non inventore accusantium animi quia.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 69, new DateTime(2019, 9, 12, 3, 52, 16, 127, DateTimeKind.Local).AddTicks(4827), "Quis facilis perferendis reiciendis. Est nam est aut odit deleniti. Corrupti assumenda deserunt.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 68, new DateTime(2019, 10, 29, 2, 26, 27, 299, DateTimeKind.Local).AddTicks(6719), "Autem autem laborum earum rerum aut harum culpa dolorem. Ut expedita sint veniam corrupti ipsam vel reiciendis. Ut quo non maxime reiciendis necessitatibus.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 67, new DateTime(2020, 1, 23, 17, 50, 35, 879, DateTimeKind.Local).AddTicks(2259), "Incidunt odit nobis velit. Facere repudiandae nemo et soluta magnam repellendus amet. Ad deserunt et. Aut est enim corrupti magni autem et aut sequi fugiat.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 66, new DateTime(2020, 3, 14, 10, 33, 51, 296, DateTimeKind.Local).AddTicks(2780), "Praesentium laboriosam nulla molestiae sed error beatae modi tempore repellat. Et non et eos. Aut aliquid cumque est minima nihil. Ut occaecati occaecati ipsam nostrum aperiam. Quisquam fuga qui perspiciatis iure quos magni. Modi et nihil rem omnis deserunt voluptate.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 64, new DateTime(2019, 12, 14, 0, 11, 57, 609, DateTimeKind.Local).AddTicks(6787), "Dolorem quas vel praesentium esse natus qui. Ut amet doloribus sapiente nesciunt itaque. Harum at est nulla reiciendis voluptatem molestiae deserunt aspernatur. Ut omnis adipisci repudiandae iure ex perferendis.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 53, new DateTime(2019, 12, 20, 18, 26, 47, 89, DateTimeKind.Local).AddTicks(9763), "In reprehenderit ipsam quae voluptas. Totam eaque reprehenderit est consequatur ipsa ut non. Tenetur dolores ut ut. Quis quidem nostrum rerum repudiandae amet et fuga.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 62, new DateTime(2020, 3, 7, 1, 51, 35, 705, DateTimeKind.Local).AddTicks(1566), "Explicabo qui eius dolores sint. Sit perferendis sit dignissimos tempora voluptatem. Itaque quis harum dolores et molestias.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 61, new DateTime(2019, 9, 13, 17, 0, 16, 213, DateTimeKind.Local).AddTicks(8668), "Sunt perspiciatis doloribus est molestias saepe nemo libero delectus enim. Quod et dolor sit alias et quia. Corrupti quam blanditiis autem sit quam doloribus quisquam nesciunt facilis.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 60, new DateTime(2019, 12, 6, 5, 12, 4, 701, DateTimeKind.Local).AddTicks(1517), "Consequatur ducimus tempora nemo ea. Numquam et facere quis consequuntur. Facere sunt dolor. Odio voluptas quo minima eum id. Atque labore sit consequuntur non enim molestiae ullam rerum. Exercitationem quo pariatur consequatur qui sed omnis harum.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 59, new DateTime(2019, 12, 14, 3, 15, 9, 801, DateTimeKind.Local).AddTicks(4893), "Consequuntur aspernatur et id nulla voluptatem voluptatem. Vel totam vel aperiam distinctio et facilis quisquam exercitationem. Omnis deleniti et nulla. Molestias omnis ea accusantium voluptas harum ipsum velit.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 58, new DateTime(2020, 1, 10, 20, 8, 47, 940, DateTimeKind.Local).AddTicks(488), "Quidem explicabo ratione. Ut odio facilis vero voluptatem illo animi architecto ducimus. Ab quasi sunt eum quasi. Reprehenderit magni voluptatem repellendus qui qui consequatur.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 57, new DateTime(2019, 10, 27, 16, 22, 19, 192, DateTimeKind.Local).AddTicks(6028), "Error sed aut optio doloribus voluptatem aliquam. Voluptatem voluptas provident dicta. Cumque sunt ut nisi ullam.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 56, new DateTime(2019, 9, 23, 4, 35, 55, 435, DateTimeKind.Local).AddTicks(4165), "Quidem est magni. Inventore deserunt quidem enim et quisquam distinctio ea. Et atque dolor.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 55, new DateTime(2019, 11, 14, 6, 9, 34, 499, DateTimeKind.Local).AddTicks(341), "Aut eos officiis est molestiae est modi aut. Ipsam praesentium nobis est dolorum accusantium quia velit sit quia. Quam atque qui numquam quia vel laboriosam id aut sunt. Molestiae et quia inventore dolorem. Et adipisci amet quisquam eius.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 54, new DateTime(2020, 6, 11, 2, 16, 32, 899, DateTimeKind.Local).AddTicks(5171), "Ipsum sint cupiditate at enim ea et modi animi. Voluptate eaque animi qui fugit eveniet. Est ipsum tempora dolorum. Earum aut quis magni qui et nulla quaerat cum nemo.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 73, new DateTime(2019, 12, 8, 4, 38, 41, 949, DateTimeKind.Local).AddTicks(1702), "Qui perferendis error quae dicta aut ipsa magnam odit quibusdam. Voluptates dolores aliquam suscipit pariatur ut nihil voluptates quo. Sunt explicabo assumenda facilis voluptatem odio recusandae. Odit aperiam dolores quaerat aut veniam. Non magnam rerum et exercitationem consequatur.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 52, new DateTime(2020, 4, 12, 21, 22, 53, 321, DateTimeKind.Local).AddTicks(3652), "Aut dignissimos id saepe sed placeat dolorum. Et dolores repudiandae. Ipsam est delectus eligendi. Aut inventore ea facilis optio facilis aut fugit.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 63, new DateTime(2019, 11, 23, 9, 35, 20, 273, DateTimeKind.Local).AddTicks(7568), "Aliquid occaecati ipsum ratione accusantium consequatur quis nostrum. Placeat dicta animi repellendus nesciunt voluptate. Sequi voluptate consequuntur recusandae odit nesciunt id.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 74, new DateTime(2020, 6, 22, 4, 52, 57, 421, DateTimeKind.Local).AddTicks(2440), "Perferendis autem reprehenderit voluptatem quaerat et aut velit magnam et. Ea itaque provident aut et repellat voluptas nobis est. Aut rerum quidem sit illum. Quam eius facilis nisi tempore earum. Molestiae eos inventore temporibus.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 85, new DateTime(2019, 9, 15, 4, 38, 52, 276, DateTimeKind.Local).AddTicks(5444), "Expedita recusandae harum similique. Facere repellendus provident fugiat dolorem iusto aut saepe delectus repellendus. Est reprehenderit suscipit eos molestias voluptas qui earum. Ducimus accusantium numquam rerum quia quis vel dolorem qui. Vitae expedita iste magnam perspiciatis similique ut. Qui doloribus est architecto amet quisquam quos eum.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 76, new DateTime(2019, 12, 16, 17, 34, 26, 290, DateTimeKind.Local).AddTicks(5780), "Ut et porro ea quaerat necessitatibus provident. Exercitationem ullam atque suscipit voluptas expedita. Et saepe ullam reprehenderit. Autem non qui porro. Earum et nihil aspernatur consequatur sed eos similique et ex. Necessitatibus eius eos similique incidunt quo cum.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 98, new DateTime(2019, 10, 26, 23, 15, 8, 102, DateTimeKind.Local).AddTicks(4294), "Repellat deserunt id similique sed. Numquam quaerat suscipit eum natus aliquid sapiente quo et et. Est et iure minus tempore. Necessitatibus est cumque voluptatem aut qui architecto.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 51, new DateTime(2020, 3, 29, 22, 14, 42, 916, DateTimeKind.Local).AddTicks(1454), "Et fugiat et eveniet magni saepe sunt. Blanditiis qui possimus ipsum libero labore labore enim. Dolores est nisi sit quod. Id non dolorem sed recusandae molestiae qui doloribus. Rem accusantium consequuntur. Qui et itaque laboriosam.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 97, new DateTime(2020, 2, 28, 15, 45, 48, 585, DateTimeKind.Local).AddTicks(4154), "Facilis ea et reprehenderit. At fugit sapiente placeat. Temporibus totam ut aut et in velit.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 96, new DateTime(2020, 2, 25, 19, 32, 20, 312, DateTimeKind.Local).AddTicks(6493), "Illum eius rerum sapiente deleniti consequatur occaecati omnis consequatur. Corporis omnis animi id fugit consequuntur quaerat laudantium ut. Ut deleniti eius nostrum ex repudiandae et rerum unde.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 95, new DateTime(2019, 10, 5, 14, 7, 6, 310, DateTimeKind.Local).AddTicks(9981), "Architecto ipsa harum eum culpa dolor. Quis dolore modi blanditiis maiores ullam aut. Dolorum eum aliquid eligendi vero harum. Natus velit sunt tempora et impedit minus cumque.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 94, new DateTime(2020, 1, 27, 1, 31, 38, 203, DateTimeKind.Local).AddTicks(1629), "Aut et commodi voluptas accusamus aliquam veniam voluptas praesentium quas. Ducimus et nulla voluptatem totam et saepe. Quis cupiditate minus officia minus vel quis voluptatum omnis rem. Veniam beatae laudantium et. Vero pariatur ut ut voluptatem sint necessitatibus aut doloremque. Quis veritatis laborum et id.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 93, new DateTime(2020, 3, 5, 12, 45, 2, 940, DateTimeKind.Local).AddTicks(5782), "Vel autem consectetur incidunt nihil rerum corrupti non. Velit sint et. Rem sed at id et blanditiis iure quia.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 92, new DateTime(2020, 7, 13, 13, 17, 16, 808, DateTimeKind.Local).AddTicks(9722), "Sunt itaque adipisci rerum at vel. Itaque dolor aut possimus hic aut voluptatem. Ducimus occaecati voluptas exercitationem. Cum tempora atque aut soluta est nemo rem. Aliquam sed consequuntur officia.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 91, new DateTime(2020, 5, 16, 6, 33, 35, 76, DateTimeKind.Local).AddTicks(3833), "Fugit velit ut illo aut vitae architecto ut. Nulla fugiat dolores ab quo animi. Quia esse quas sint a dolorem provident dolore. Ex error incidunt id assumenda dolorem id est et. Repudiandae iusto nihil dolore.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 90, new DateTime(2020, 4, 30, 19, 19, 57, 245, DateTimeKind.Local).AddTicks(9559), "Autem omnis veritatis sit consequatur sed. Aut aut molestiae dignissimos recusandae. Voluptas ut est labore temporibus ipsum. Animi nostrum nobis neque non cupiditate quis dolor a ad. Cumque omnis ab suscipit eum. Architecto quaerat molestiae quasi et est blanditiis iste.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 75, new DateTime(2020, 6, 19, 9, 59, 59, 26, DateTimeKind.Local).AddTicks(4842), "Totam quam pariatur. Eveniet sit error non maiores esse illo rerum eaque nulla. Corporis odio dignissimos deserunt adipisci id in sed praesentium. Aut ut maxime non doloribus rem in itaque itaque.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 89, new DateTime(2020, 6, 25, 10, 44, 26, 78, DateTimeKind.Local).AddTicks(9000), "Unde quae corrupti sit quam non ipsam at magni et. Eius nisi vel id. Fuga non eos placeat qui. Qui quibusdam explicabo et ipsa vel magnam quo. Repellat eligendi qui cupiditate molestiae ea.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 87, new DateTime(2020, 8, 17, 1, 14, 57, 666, DateTimeKind.Local).AddTicks(181), "Consequatur maxime harum voluptas sit molestias distinctio. Amet laborum voluptatum nihil et quod mollitia vitae rerum. Magnam enim voluptatem.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 86, new DateTime(2019, 9, 8, 19, 18, 27, 505, DateTimeKind.Local).AddTicks(8880), "Ut eligendi quisquam blanditiis est. Est expedita sed dolorum reiciendis dignissimos nihil. Maiores dolorem eos autem nostrum et fuga dignissimos. Quia quis quo quos qui ut eum fugiat et minus. Minus delectus quo quibusdam.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 84, new DateTime(2020, 5, 22, 18, 55, 6, 19, DateTimeKind.Local).AddTicks(4406), "Similique neque quibusdam non pariatur unde. Numquam nemo et omnis consequatur autem esse dolor. Sit minus culpa consequuntur deserunt cum velit perferendis. Consequuntur sequi exercitationem ex et. Delectus molestiae non ut sequi quas magni.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 83, new DateTime(2020, 2, 13, 17, 22, 28, 212, DateTimeKind.Local).AddTicks(3844), "Et voluptatum tempora eos ut. Quis doloribus molestiae. Ipsam corporis inventore ea voluptas rerum voluptatibus. Cupiditate atque alias earum voluptatem recusandae quas.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 82, new DateTime(2020, 6, 23, 7, 59, 22, 446, DateTimeKind.Local).AddTicks(5779), "Reprehenderit aut aut sed et saepe ipsam adipisci. Ad quia et et inventore consectetur corrupti. Ea et ad molestiae non fuga. Eum quidem ut omnis aut ullam eius sint. Vero beatae expedita. Molestiae ea ullam a dolores voluptatem architecto eos nihil architecto.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 81, new DateTime(2020, 1, 13, 23, 26, 1, 920, DateTimeKind.Local).AddTicks(9774), "Neque sed excepturi animi quia sunt quia et incidunt omnis. Totam et assumenda consequuntur maiores adipisci ad. Fuga ut praesentium nostrum debitis harum in quia.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 80, new DateTime(2020, 2, 18, 21, 20, 42, 569, DateTimeKind.Local).AddTicks(3454), "Dignissimos asperiores facere corporis est perspiciatis. Ut quia eos dolores quos quis consequatur qui omnis rerum. Cupiditate qui quaerat sed ut.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 79, new DateTime(2020, 6, 29, 23, 25, 56, 949, DateTimeKind.Local).AddTicks(3296), "Rerum voluptas praesentium alias sed. Mollitia sed qui repellat maiores rem magni ipsam. Officia laudantium dolor. Cumque omnis reprehenderit. Et eos voluptatibus vitae veniam aut in. Ducimus consequuntur eligendi voluptas reiciendis iusto corrupti perferendis.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 78, new DateTime(2020, 7, 14, 23, 1, 18, 999, DateTimeKind.Local).AddTicks(4400), "Vel aut aut odio vitae ut repudiandae atque. Minus nihil corrupti blanditiis consequatur sit vitae voluptas et cumque. Ratione maiores rerum qui. Hic et illum saepe quos omnis expedita temporibus eligendi laborum. Et totam aut dolorum et dolores.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 77, new DateTime(2020, 4, 13, 11, 0, 2, 669, DateTimeKind.Local).AddTicks(3241), "Quod molestias officia et omnis nobis repellendus accusantium. Repellat ea voluptatem labore eum nostrum non omnis ut. Ut ullam distinctio ut tempore iusto qui tenetur beatae. Autem asperiores nisi ut voluptates sapiente officia. Et commodi aut beatae sit impedit necessitatibus vero perspiciatis.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 88, new DateTime(2020, 3, 24, 19, 3, 50, 931, DateTimeKind.Local).AddTicks(851), "Sit sit nisi aut exercitationem dolorum in quo culpa vel. Architecto voluptatum necessitatibus nobis fuga est nemo quaerat. Eum modi labore quo non sint consequatur.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 50, new DateTime(2019, 12, 5, 23, 34, 3, 772, DateTimeKind.Local).AddTicks(4112), "Veritatis id totam maxime. Voluptatem ut dolor sapiente quis illum et ut qui. Et maxime ipsam illo. Aut magni consequatur.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 26, new DateTime(2020, 5, 20, 9, 17, 15, 931, DateTimeKind.Local).AddTicks(1439), "Quos voluptas molestiae non. Occaecati cumque ut laborum voluptas alias iure voluptate. Et voluptatem dolorem enim commodi beatae deleniti provident. Quas et esse dolorum aut. Adipisci sed odio.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 48, new DateTime(2019, 12, 23, 16, 10, 12, 283, DateTimeKind.Local).AddTicks(5007), "Aut animi ipsum reprehenderit consectetur soluta cumque quia explicabo. Aut quia non voluptatibus. Corporis eius facilis est aut officiis. Voluptatem asperiores voluptas qui numquam a cupiditate.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 20, new DateTime(2020, 8, 15, 9, 59, 0, 616, DateTimeKind.Local).AddTicks(6025), "Numquam ducimus sapiente nulla at atque. Consequatur eaque earum aperiam eius. Voluptas animi consequatur hic ullam.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 19, new DateTime(2020, 6, 22, 14, 40, 25, 907, DateTimeKind.Local).AddTicks(5036), "A quia voluptatem et. Quia cumque vel et reiciendis tenetur porro et. Tenetur maxime dolor dolorum earum quia culpa officia ipsum delectus. Fuga itaque voluptatem consectetur est unde. Nobis quos non.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 18, new DateTime(2019, 11, 4, 15, 13, 3, 700, DateTimeKind.Local).AddTicks(2424), "Aut veritatis aut eius omnis odio dolores sed quo sed. Est facilis ut fugiat qui officiis voluptatibus reprehenderit nisi numquam. Ipsum voluptatem voluptatum qui illum omnis repudiandae quaerat. Qui consequatur velit est eveniet doloribus nobis.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 17, new DateTime(2020, 1, 19, 7, 31, 10, 780, DateTimeKind.Local).AddTicks(4704), "Odit consequuntur dolorem sapiente. Et ut minima. Est sit neque fugit eaque error eaque tenetur voluptas.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 16, new DateTime(2019, 12, 5, 22, 15, 58, 967, DateTimeKind.Local).AddTicks(4774), "Cupiditate et laborum ullam sint laboriosam non placeat beatae. Qui eaque reprehenderit autem temporibus reprehenderit. Minus voluptates nostrum alias officiis. Qui sit aut est quia autem labore dolor tenetur. Explicabo et nobis sit voluptatem excepturi voluptatem at.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 15, new DateTime(2020, 1, 18, 6, 32, 36, 45, DateTimeKind.Local).AddTicks(8718), "Sed veniam voluptate vel eligendi temporibus ratione cumque. Fugiat et nulla iure corrupti earum. Et corrupti et quaerat fugiat esse fugiat. Et et laborum aliquid.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 14, new DateTime(2020, 4, 15, 0, 17, 18, 46, DateTimeKind.Local).AddTicks(3960), "Et sequi et corporis magnam quas quod. Saepe est qui. Minima non perferendis ut consequatur saepe impedit ullam doloremque. Eveniet dolor rerum. Minima labore sit minima suscipit non.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 13, new DateTime(2019, 11, 6, 13, 24, 10, 97, DateTimeKind.Local).AddTicks(888), "Est ipsum sed saepe sint molestiae esse voluptas quas. Repudiandae sed et soluta quo explicabo eius. Quia eos fuga.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 12, new DateTime(2020, 2, 26, 23, 23, 24, 152, DateTimeKind.Local).AddTicks(4856), "Placeat necessitatibus quos ea dolor. Voluptas repudiandae nam vero mollitia optio adipisci ea et natus. Et dolorum quam fugiat soluta minus officiis.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 11, new DateTime(2020, 6, 1, 22, 20, 48, 351, DateTimeKind.Local).AddTicks(4699), "Autem quam placeat quos vel unde doloremque molestiae. Sit fugiat maiores reprehenderit doloribus dolor iusto. Ipsa ut quia. Illum voluptates ipsam officiis sapiente. Ut eligendi est repudiandae corporis provident nostrum sit.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 10, new DateTime(2019, 12, 11, 20, 28, 2, 430, DateTimeKind.Local).AddTicks(3455), "Fuga accusamus sit non illum adipisci dolorum autem maiores autem. Assumenda et doloremque natus molestiae perferendis eum non. Omnis ipsam illo nihil laborum rerum ut et ducimus exercitationem.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 9, new DateTime(2020, 3, 16, 23, 56, 31, 327, DateTimeKind.Local).AddTicks(8311), "Aut dolor eligendi eligendi odit et. Minus asperiores explicabo numquam asperiores expedita blanditiis. Maxime neque enim harum atque commodi et facere. Nemo in dolorem qui esse itaque libero animi. Nihil omnis quia.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 8, new DateTime(2019, 9, 20, 4, 43, 23, 363, DateTimeKind.Local).AddTicks(5585), "Officia aut voluptates ex occaecati. Provident enim accusamus aut rem qui numquam mollitia rem. Ipsa necessitatibus suscipit doloribus et eaque porro odit quia. Quia molestiae dolore enim ratione deleniti quidem repellat id. Ex iure qui ipsum cum ut omnis ex eos. Ratione vel at beatae ducimus minus.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 7, new DateTime(2020, 1, 23, 5, 19, 10, 311, DateTimeKind.Local).AddTicks(7235), "Tenetur odio sit amet provident possimus. Omnis est aliquid officia. Consectetur molestiae voluptatem maxime nam. Non unde quam ut sit sequi ea velit voluptas rerum.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 6, new DateTime(2020, 5, 13, 18, 31, 38, 142, DateTimeKind.Local).AddTicks(5327), "Sequi rem quo velit est sapiente minima dolor consectetur sequi. Quae veritatis ut nobis nihil nisi nostrum dignissimos. Et qui voluptatem deleniti temporibus qui architecto temporibus.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 5, new DateTime(2020, 3, 8, 8, 50, 48, 379, DateTimeKind.Local).AddTicks(3192), "Molestiae doloremque iure. Eius et est cumque velit excepturi nulla deserunt. Voluptatem qui deleniti explicabo ipsa hic perspiciatis maxime rerum. Doloribus laborum et consequatur.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 4, new DateTime(2020, 1, 5, 8, 14, 29, 921, DateTimeKind.Local).AddTicks(4637), "Enim sed est quos occaecati provident. Tempora aut est dolores aspernatur. At explicabo natus et earum corrupti qui architecto assumenda.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 3, new DateTime(2020, 2, 18, 11, 41, 49, 642, DateTimeKind.Local).AddTicks(9106), "Eos enim consectetur minus illo reprehenderit rerum harum aut saepe. Ipsa quibusdam et illo qui sit aperiam ea veniam. Est placeat distinctio totam. Minima labore dolores perferendis illo ut rerum labore suscipit. Suscipit nostrum a. Quod ut quae eum mollitia ipsa quibusdam.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 2, new DateTime(2020, 3, 31, 8, 50, 48, 156, DateTimeKind.Local).AddTicks(1944), "Voluptatem earum ullam enim quis deleniti consequatur qui. Ut iure quam aut ut porro odio. Eaque quae laboriosam voluptates eum. Doloremque beatae omnis nihil quam nulla accusamus consequuntur quos. Voluptas quia rem eum cupiditate voluptatem perferendis. Et ipsum nesciunt minima quam vitae mollitia eos id id.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 1, new DateTime(2020, 7, 14, 8, 5, 48, 39, DateTimeKind.Local).AddTicks(5313), "Velit eligendi et. Doloribus enim rerum tenetur ad aut. Quos quos esse nobis quibusdam nemo quos. Ex tempore reprehenderit nam voluptas necessitatibus similique at ipsa.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 99, new DateTime(2020, 5, 19, 11, 37, 25, 518, DateTimeKind.Local).AddTicks(3106), "Et temporibus facilis est incidunt placeat. Non ea et repudiandae eos et. Perspiciatis sed fugiat soluta accusantium id quia sunt porro sint. Vero et sed quaerat doloribus optio excepturi.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 21, new DateTime(2020, 8, 8, 21, 2, 7, 17, DateTimeKind.Local).AddTicks(4201), "Aut molestiae et doloremque earum soluta molestiae. Sint quos excepturi doloribus dolores et quia. Sapiente suscipit recusandae. Dolore quod sit. Ea saepe voluptas beatae voluptates sit et dolore nam.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 22, new DateTime(2020, 1, 7, 3, 42, 55, 282, DateTimeKind.Local).AddTicks(1618), "Aliquid quia aut voluptate sint est. Suscipit totam quod fuga amet sint qui magnam iusto. Eos aspernatur dicta tempore quae quo. Fuga sit molestiae ut voluptas enim unde et consequuntur. Voluptatibus est alias voluptas modi id reiciendis. Molestiae aut blanditiis.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 23, new DateTime(2020, 5, 17, 10, 52, 49, 398, DateTimeKind.Local).AddTicks(9514), "Dignissimos earum quia ut. Corporis atque voluptatem repellendus amet exercitationem provident aut sequi. Quisquam veritatis consequatur maxime. Et sed sint quos odit et dolorum id. Ut nam explicabo enim explicabo et. Culpa modi minus soluta quia id illo.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 24, new DateTime(2020, 6, 24, 20, 28, 40, 376, DateTimeKind.Local).AddTicks(9747), "Voluptates minus distinctio distinctio deserunt. Quibusdam et accusantium fugiat autem. Soluta placeat accusamus rerum.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 47, new DateTime(2019, 11, 6, 9, 29, 49, 633, DateTimeKind.Local).AddTicks(7664), "Nulla hic atque perspiciatis et corporis sit est. Quia est doloribus minus enim laboriosam quidem tempore. Perspiciatis praesentium sed harum ut consequatur labore accusantium distinctio id. Debitis culpa qui asperiores ea vero quia soluta ratione.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 46, new DateTime(2020, 9, 2, 15, 44, 41, 905, DateTimeKind.Local).AddTicks(9153), "Porro sit quam debitis perferendis velit et. Nemo soluta inventore omnis quia. Eum qui voluptatem nesciunt fuga sit accusamus mollitia et et. Cumque architecto neque est. Eos mollitia perferendis ut non autem. Quia et sit laboriosam.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 45, new DateTime(2020, 3, 22, 13, 24, 48, 616, DateTimeKind.Local).AddTicks(3027), "Sunt veniam est rem sit unde est aut voluptatem tempore. Quia incidunt sint. Et odio quisquam et doloremque et dolor animi. Et nesciunt est reprehenderit in alias excepturi. Qui ea quia rem quos exercitationem. Pariatur et itaque.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 44, new DateTime(2019, 12, 14, 6, 9, 17, 818, DateTimeKind.Local).AddTicks(5856), "Rem sint dolorem ullam culpa voluptas laudantium accusantium quia quasi. Libero perspiciatis quia minus similique. Consequatur veniam quia sint. Dolore voluptas reiciendis aliquid velit. Aut voluptas aliquid qui rerum repudiandae perspiciatis dolores perferendis. Pariatur quidem qui nisi.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 43, new DateTime(2020, 5, 6, 1, 30, 26, 948, DateTimeKind.Local).AddTicks(2822), "Deleniti rerum dolorem assumenda minima iure. Tempora provident et sit ab quo non molestiae. Adipisci consequatur cupiditate aut et quas sed esse perferendis quia.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 42, new DateTime(2020, 5, 25, 23, 15, 0, 199, DateTimeKind.Local).AddTicks(5016), "Quia voluptatem delectus et. Totam sequi ut corporis mollitia omnis perspiciatis sed nisi. Repellendus ea soluta iusto dolore.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 41, new DateTime(2020, 5, 20, 12, 26, 49, 597, DateTimeKind.Local).AddTicks(8135), "Id et neque veniam. Nulla rerum quia cum. Atque doloribus sit consequatur maxime a ut laborum laborum. Assumenda qui similique vero. Totam corporis quod reiciendis suscipit sit beatae enim. Sed molestiae tempore quia error adipisci nihil aut possimus et.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 40, new DateTime(2020, 2, 7, 16, 45, 11, 742, DateTimeKind.Local).AddTicks(5917), "Rerum odio corporis ea esse voluptatem laudantium. Aut autem autem voluptate. Quo aut sit quia et reiciendis sunt placeat. Fugit fuga animi recusandae ad magni vero incidunt. Ea autem ipsa et quia iusto id veritatis quis. Ducimus tenetur dolores.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 39, new DateTime(2020, 8, 7, 0, 41, 5, 534, DateTimeKind.Local).AddTicks(654), "Qui nihil et ipsa nostrum officia ducimus. Laboriosam laborum sed. Libero deserunt rerum nostrum facilis id aut deleniti omnis similique. Non non nam maiores excepturi et quia facere.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 38, new DateTime(2019, 12, 5, 23, 3, 36, 182, DateTimeKind.Local).AddTicks(2608), "Aut facilis nihil doloribus consequatur non dolorem. Sequi corrupti temporibus rerum voluptatem enim deleniti. Asperiores et laboriosam et voluptas dolor porro. Alias exercitationem magni.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 49, new DateTime(2019, 10, 6, 16, 0, 10, 538, DateTimeKind.Local).AddTicks(3222), "Neque voluptate quasi harum totam et eos iste corrupti. Sit velit facilis qui. Nulla non adipisci ut.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 37, new DateTime(2020, 5, 4, 11, 54, 56, 5, DateTimeKind.Local).AddTicks(1080), "Nisi sapiente delectus. Consequuntur et sed tenetur eligendi quod dicta. Maxime esse excepturi itaque. Est asperiores in aliquam consequatur neque quia ea. Blanditiis sed distinctio error quia sit.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 35, new DateTime(2020, 4, 14, 20, 20, 55, 715, DateTimeKind.Local).AddTicks(9059), "Vel nulla et culpa ad alias natus nesciunt ex excepturi. Sit repellendus dicta occaecati exercitationem. Ut sint nihil labore id velit voluptatem neque rerum perspiciatis. Inventore suscipit rerum mollitia est. Dignissimos vero corporis.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 34, new DateTime(2020, 6, 13, 0, 48, 29, 991, DateTimeKind.Local).AddTicks(6696), "Et nisi modi laudantium itaque facilis unde ab. Explicabo soluta aperiam. Voluptates in ab rerum. Quia perspiciatis voluptatem vitae aliquam nihil ipsum hic tempore et. Eum quos deleniti perferendis sit. Vero nobis eum.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 33, new DateTime(2020, 6, 7, 17, 55, 27, 137, DateTimeKind.Local).AddTicks(2368), "Quas culpa consequatur hic voluptas quibusdam repudiandae nulla. Mollitia a dolor qui alias quae dicta qui neque. Quasi impedit eos doloremque. Debitis maxime sed aut libero necessitatibus velit et exercitationem et. Et voluptas veritatis voluptates non ut omnis amet ea laborum.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 32, new DateTime(2020, 3, 6, 8, 3, 19, 799, DateTimeKind.Local).AddTicks(5321), "Reprehenderit possimus autem. Ut nihil ea eum ratione eum. Est aut placeat. Illum id doloribus repellat similique. Facilis rerum repudiandae id.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 31, new DateTime(2019, 11, 1, 17, 44, 18, 772, DateTimeKind.Local).AddTicks(3123), "Eligendi corporis aut labore consectetur doloremque eaque deserunt neque. Aut nihil delectus ex laborum provident. Incidunt iste impedit. Nihil corporis ipsam aut. Iure consequuntur vero sequi voluptates iste necessitatibus.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 30, new DateTime(2019, 9, 15, 22, 9, 50, 280, DateTimeKind.Local).AddTicks(467), "Consequuntur illum neque eius necessitatibus iusto esse ipsum. Suscipit voluptate nisi culpa repellendus fugiat asperiores. Quia consequatur aliquam. Id eligendi corporis.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 29, new DateTime(2020, 4, 4, 23, 5, 45, 298, DateTimeKind.Local).AddTicks(4814), "Aspernatur magnam harum rerum et laudantium temporibus modi quasi. Praesentium qui similique. Pariatur sequi at facere eum corporis dignissimos. Dolores saepe rerum itaque in consequatur nisi ut dolore.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 28, new DateTime(2019, 12, 8, 5, 36, 35, 299, DateTimeKind.Local).AddTicks(4162), "Et excepturi voluptate sint nihil distinctio non est sequi impedit. Excepturi ullam explicabo. Culpa quasi et facere sint enim sequi et. Odit voluptas velit eveniet aut repudiandae dolore labore quis incidunt. Numquam pariatur et commodi et omnis blanditiis ea nobis cum. Atque ad alias veritatis aut nulla molestiae earum.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 27, new DateTime(2019, 12, 21, 4, 47, 8, 711, DateTimeKind.Local).AddTicks(9286), "Expedita non asperiores ea quo corrupti. Voluptatem quia esse quo praesentium soluta ad aut. Sunt et a a nihil ratione tempora ut qui. Quam temporibus error quis odit. Qui cumque ipsum repellendus consequatur cum rerum.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 25, new DateTime(2020, 4, 5, 11, 59, 34, 756, DateTimeKind.Local).AddTicks(6328), "Qui eos quo ad et. Eligendi atque aut sit distinctio quidem aliquid. Distinctio labore alias et sint ullam sapiente qui placeat. Id repellat quis et ipsum sint. Sit aut voluptatibus. Mollitia qui eum non eum.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 36, new DateTime(2020, 7, 8, 1, 26, 59, 19, DateTimeKind.Local).AddTicks(3639), "Eos ut est nobis labore assumenda neque provident. Ut doloremque aut facere non est nulla. Iure praesentium adipisci aut sit fuga. Quisquam optio facilis nam asperiores et sunt nostrum. Similique laudantium incidunt sit voluptatum est est sed cupiditate voluptas. Error animi laboriosam ut quia blanditiis a.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 100, new DateTime(2020, 4, 9, 13, 28, 18, 794, DateTimeKind.Local).AddTicks(4209), "Ipsa nihil rerum labore laudantium aut voluptatibus. Natus sed accusantium mollitia accusamus natus amet vel. Dicta illum quasi est qui autem quas autem.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 9, 7, 23, 27, 18, 355, DateTimeKind.Local).AddTicks(4935), new DateTime(2020, 9, 7, 15, 47, 41, 108, DateTimeKind.Local).AddTicks(1602), new DateTime(2020, 9, 7, 23, 17, 8, 711, DateTimeKind.Local).AddTicks(2864), 45, "", "https://lucas.org", "quod" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 9, 8, 10, 24, 41, 448, DateTimeKind.Local).AddTicks(824), new DateTime(2020, 9, 8, 6, 22, 26, 880, DateTimeKind.Local).AddTicks(1619), new DateTime(2020, 9, 7, 18, 42, 31, 68, DateTimeKind.Local).AddTicks(998), 69, "", "http://théo.eu", "dicta" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 9, 7, 13, 40, 41, 961, DateTimeKind.Local).AddTicks(2398), new DateTime(2020, 9, 8, 8, 59, 20, 733, DateTimeKind.Local).AddTicks(7875), new DateTime(2020, 9, 8, 11, 18, 7, 495, DateTimeKind.Local).AddTicks(6684), 68, "", "https://noémie.org", "id" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 9, 8, 3, 50, 30, 325, DateTimeKind.Local).AddTicks(3867), new DateTime(2020, 9, 8, 4, 40, 34, 385, DateTimeKind.Local).AddTicks(2971), new DateTime(2020, 9, 7, 12, 38, 14, 698, DateTimeKind.Local).AddTicks(117), 68, "", "https://raphaël.org", "harum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 9, 8, 10, 53, 7, 133, DateTimeKind.Local).AddTicks(5230), new DateTime(2020, 9, 7, 21, 51, 28, 749, DateTimeKind.Local).AddTicks(4990), new DateTime(2020, 9, 8, 6, 28, 40, 992, DateTimeKind.Local).AddTicks(2179), 68, "", "http://noah.net", "ipsa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 9, 7, 21, 24, 12, 123, DateTimeKind.Local).AddTicks(696), new DateTime(2020, 9, 7, 14, 55, 20, 502, DateTimeKind.Local).AddTicks(3981), new DateTime(2020, 9, 8, 1, 14, 50, 43, DateTimeKind.Local).AddTicks(317), 67, "", "http://théo.info", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 9, 8, 0, 28, 41, 356, DateTimeKind.Local).AddTicks(9842), new DateTime(2020, 9, 8, 6, 0, 28, 246, DateTimeKind.Local).AddTicks(5241), new DateTime(2020, 9, 8, 10, 51, 24, 618, DateTimeKind.Local).AddTicks(1937), 67, "", "https://mohamed.fr", "iure" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 9, 7, 14, 13, 44, 674, DateTimeKind.Local).AddTicks(5974), new DateTime(2020, 9, 7, 20, 15, 39, 260, DateTimeKind.Local).AddTicks(2273), new DateTime(2020, 9, 8, 9, 38, 39, 125, DateTimeKind.Local).AddTicks(1327), 67, "", "https://antoine.net", "praesentium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 9, 7, 12, 19, 3, 285, DateTimeKind.Local).AddTicks(4753), new DateTime(2020, 9, 7, 14, 26, 31, 787, DateTimeKind.Local).AddTicks(8284), new DateTime(2020, 9, 7, 19, 45, 23, 438, DateTimeKind.Local).AddTicks(1610), 67, "", "https://quentin.net", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 9, 7, 12, 6, 26, 893, DateTimeKind.Local).AddTicks(1633), new DateTime(2020, 9, 8, 10, 18, 18, 320, DateTimeKind.Local).AddTicks(274), new DateTime(2020, 9, 7, 23, 54, 9, 180, DateTimeKind.Local).AddTicks(672), 66, "", "http://clément.info", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 9, 8, 6, 53, 44, 135, DateTimeKind.Local).AddTicks(3242), new DateTime(2020, 9, 7, 17, 10, 21, 116, DateTimeKind.Local).AddTicks(8457), new DateTime(2020, 9, 8, 10, 32, 58, 697, DateTimeKind.Local).AddTicks(6970), 66, "", "https://jade.com", "nemo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 9, 7, 19, 58, 17, 627, DateTimeKind.Local).AddTicks(8623), new DateTime(2020, 9, 8, 7, 25, 37, 312, DateTimeKind.Local).AddTicks(2231), new DateTime(2020, 9, 7, 19, 23, 51, 445, DateTimeKind.Local).AddTicks(7091), 66, "", "http://louna.com", "soluta" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 9, 8, 4, 46, 44, 56, DateTimeKind.Local).AddTicks(2245), new DateTime(2020, 9, 7, 19, 49, 59, 462, DateTimeKind.Local).AddTicks(8354), new DateTime(2020, 9, 8, 8, 56, 4, 945, DateTimeKind.Local).AddTicks(8756), 69, "", "http://sarah.org", "quidem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 9, 8, 2, 47, 34, 123, DateTimeKind.Local).AddTicks(1238), new DateTime(2020, 9, 7, 20, 50, 47, 547, DateTimeKind.Local).AddTicks(2520), new DateTime(2020, 9, 7, 12, 27, 19, 221, DateTimeKind.Local).AddTicks(5309), 65, "", "http://maeva.name", "quas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 9, 7, 13, 29, 0, 311, DateTimeKind.Local).AddTicks(1956), new DateTime(2020, 9, 7, 21, 59, 45, 550, DateTimeKind.Local).AddTicks(8234), new DateTime(2020, 9, 7, 19, 53, 44, 504, DateTimeKind.Local).AddTicks(4456), 64, "", "http://charlotte.name", "minus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 9, 8, 2, 40, 6, 711, DateTimeKind.Local).AddTicks(2374), new DateTime(2020, 9, 8, 8, 6, 26, 928, DateTimeKind.Local).AddTicks(3991), new DateTime(2020, 9, 7, 12, 56, 48, 786, DateTimeKind.Local).AddTicks(2345), 62, "", "http://maxence.net", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 9, 7, 16, 9, 42, 961, DateTimeKind.Local).AddTicks(3205), new DateTime(2020, 9, 8, 10, 23, 54, 224, DateTimeKind.Local).AddTicks(5281), new DateTime(2020, 9, 7, 12, 40, 51, 740, DateTimeKind.Local).AddTicks(7734), 61, "", "http://valentin.name", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 9, 7, 16, 12, 53, 490, DateTimeKind.Local).AddTicks(2428), new DateTime(2020, 9, 7, 17, 32, 52, 886, DateTimeKind.Local).AddTicks(5837), new DateTime(2020, 9, 8, 4, 59, 40, 322, DateTimeKind.Local).AddTicks(1954), 60, "", "http://gabriel.name", "reiciendis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 9, 7, 12, 24, 38, 537, DateTimeKind.Local).AddTicks(5285), new DateTime(2020, 9, 7, 19, 17, 30, 947, DateTimeKind.Local).AddTicks(6523), new DateTime(2020, 9, 7, 12, 52, 58, 863, DateTimeKind.Local).AddTicks(3319), 59, "", "https://laura.fr", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 9, 8, 7, 47, 28, 263, DateTimeKind.Local).AddTicks(2095), new DateTime(2020, 9, 7, 13, 51, 1, 684, DateTimeKind.Local).AddTicks(6743), new DateTime(2020, 9, 7, 14, 1, 48, 12, DateTimeKind.Local).AddTicks(8134), 58, "", "https://raphaël.name", "voluptate" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 9, 7, 21, 13, 10, 702, DateTimeKind.Local).AddTicks(3166), new DateTime(2020, 9, 7, 21, 8, 59, 625, DateTimeKind.Local).AddTicks(8280), new DateTime(2020, 9, 8, 7, 13, 8, 217, DateTimeKind.Local).AddTicks(2823), 54, "", "https://jade.net", "sapiente" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 9, 7, 22, 52, 54, 872, DateTimeKind.Local).AddTicks(5247), new DateTime(2020, 9, 7, 20, 10, 41, 677, DateTimeKind.Local).AddTicks(4773), new DateTime(2020, 9, 7, 17, 8, 58, 221, DateTimeKind.Local).AddTicks(7880), 52, "", "https://juliette.net", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 9, 8, 10, 16, 26, 519, DateTimeKind.Local).AddTicks(1923), new DateTime(2020, 9, 7, 17, 7, 4, 956, DateTimeKind.Local).AddTicks(737), new DateTime(2020, 9, 7, 21, 9, 59, 7, DateTimeKind.Local).AddTicks(3872), 50, "", "http://manon.name", "necessitatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 9, 7, 14, 7, 58, 55, DateTimeKind.Local).AddTicks(858), new DateTime(2020, 9, 7, 13, 22, 27, 174, DateTimeKind.Local).AddTicks(8670), new DateTime(2020, 9, 8, 7, 58, 42, 425, DateTimeKind.Local).AddTicks(8242), 49, "", "http://quentin.eu", "nihil" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 9, 8, 3, 40, 28, 243, DateTimeKind.Local).AddTicks(3126), new DateTime(2020, 9, 7, 23, 44, 42, 846, DateTimeKind.Local).AddTicks(6871), new DateTime(2020, 9, 8, 8, 26, 25, 170, DateTimeKind.Local).AddTicks(2586), 47, "", "http://kylian.name", "velit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 9, 7, 22, 48, 13, 332, DateTimeKind.Local).AddTicks(4314), new DateTime(2020, 9, 8, 0, 54, 35, 29, DateTimeKind.Local).AddTicks(1118), new DateTime(2020, 9, 7, 18, 21, 34, 917, DateTimeKind.Local).AddTicks(8143), 64, "", "http://enzo.net", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 9, 8, 0, 3, 23, 823, DateTimeKind.Local).AddTicks(5305), new DateTime(2020, 9, 7, 16, 15, 13, 541, DateTimeKind.Local).AddTicks(2006), new DateTime(2020, 9, 8, 7, 38, 12, 795, DateTimeKind.Local).AddTicks(3032), 69, "", "http://hugo.info", "fugiat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 9, 7, 21, 26, 19, 243, DateTimeKind.Local).AddTicks(3875), new DateTime(2020, 9, 8, 9, 9, 52, 63, DateTimeKind.Local).AddTicks(8906), new DateTime(2020, 9, 8, 1, 41, 47, 240, DateTimeKind.Local).AddTicks(5628), 72, "", "https://elisa.info", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 9, 7, 14, 8, 16, 382, DateTimeKind.Local).AddTicks(9450), new DateTime(2020, 9, 7, 17, 5, 8, 897, DateTimeKind.Local).AddTicks(8284), new DateTime(2020, 9, 8, 0, 46, 43, 189, DateTimeKind.Local).AddTicks(6709), 73, "", "https://charlotte.net", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 9, 8, 8, 14, 54, 422, DateTimeKind.Local).AddTicks(4693), new DateTime(2020, 9, 7, 22, 22, 31, 193, DateTimeKind.Local).AddTicks(4356), new DateTime(2020, 9, 7, 19, 31, 16, 786, DateTimeKind.Local).AddTicks(2357), 97, "", "http://alice.info", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 9, 8, 4, 30, 42, 949, DateTimeKind.Local).AddTicks(215), new DateTime(2020, 9, 7, 22, 13, 46, 595, DateTimeKind.Local).AddTicks(6030), new DateTime(2020, 9, 7, 15, 31, 40, 127, DateTimeKind.Local).AddTicks(9849), 97, "", "https://nicolas.net", "praesentium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 9, 8, 10, 17, 4, 221, DateTimeKind.Local).AddTicks(6213), new DateTime(2020, 9, 7, 16, 5, 33, 559, DateTimeKind.Local).AddTicks(1544), new DateTime(2020, 9, 8, 2, 3, 17, 610, DateTimeKind.Local).AddTicks(5901), 96, "", "http://axel.net", "dolorum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 9, 7, 23, 46, 39, 794, DateTimeKind.Local).AddTicks(3611), new DateTime(2020, 9, 8, 0, 55, 42, 33, DateTimeKind.Local).AddTicks(2926), new DateTime(2020, 9, 8, 4, 6, 42, 914, DateTimeKind.Local).AddTicks(835), 95, "", "http://mattéo.name", "labore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 9, 7, 14, 19, 49, 342, DateTimeKind.Local).AddTicks(5481), new DateTime(2020, 9, 8, 0, 52, 44, 666, DateTimeKind.Local).AddTicks(2187), new DateTime(2020, 9, 8, 5, 59, 20, 429, DateTimeKind.Local).AddTicks(2932), 95, "", "http://maxime.org", "voluptatum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 9, 8, 8, 40, 13, 290, DateTimeKind.Local).AddTicks(6488), new DateTime(2020, 9, 8, 6, 59, 45, 817, DateTimeKind.Local).AddTicks(7278), new DateTime(2020, 9, 8, 1, 40, 36, 944, DateTimeKind.Local).AddTicks(6381), 94, "", "http://arthur.name", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 9, 7, 21, 12, 33, 861, DateTimeKind.Local).AddTicks(8018), new DateTime(2020, 9, 8, 10, 48, 24, 415, DateTimeKind.Local).AddTicks(5066), new DateTime(2020, 9, 8, 8, 15, 41, 11, DateTimeKind.Local).AddTicks(9773), 94, "", "https://yanis.com", "excepturi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 9, 7, 19, 5, 22, 629, DateTimeKind.Local).AddTicks(1101), new DateTime(2020, 9, 7, 21, 41, 9, 792, DateTimeKind.Local).AddTicks(5783), new DateTime(2020, 9, 7, 12, 54, 10, 22, DateTimeKind.Local).AddTicks(8124), 91, "", "http://julien.info", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 9, 7, 17, 5, 23, 706, DateTimeKind.Local).AddTicks(2426), new DateTime(2020, 9, 8, 10, 11, 23, 484, DateTimeKind.Local).AddTicks(5799), new DateTime(2020, 9, 8, 6, 56, 4, 134, DateTimeKind.Local).AddTicks(5831), 86, "", "https://yanis.info", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 9, 8, 2, 20, 2, 33, DateTimeKind.Local).AddTicks(7772), new DateTime(2020, 9, 7, 13, 15, 59, 915, DateTimeKind.Local).AddTicks(2682), new DateTime(2020, 9, 8, 0, 13, 0, 763, DateTimeKind.Local).AddTicks(7882), 85, "", "https://eva.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 9, 7, 20, 44, 38, 606, DateTimeKind.Local).AddTicks(5902), new DateTime(2020, 9, 7, 16, 42, 16, 965, DateTimeKind.Local).AddTicks(4029), new DateTime(2020, 9, 7, 12, 3, 47, 709, DateTimeKind.Local).AddTicks(5785), 84, "", "http://adrien.fr", "culpa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 9, 8, 9, 4, 10, 330, DateTimeKind.Local).AddTicks(5935), new DateTime(2020, 9, 8, 2, 31, 34, 187, DateTimeKind.Local).AddTicks(9853), new DateTime(2020, 9, 8, 1, 56, 51, 184, DateTimeKind.Local).AddTicks(5582), 82, "", "http://célia.org", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 9, 7, 12, 20, 10, 873, DateTimeKind.Local).AddTicks(7748), new DateTime(2020, 9, 7, 15, 4, 47, 718, DateTimeKind.Local).AddTicks(1360), new DateTime(2020, 9, 7, 21, 6, 36, 415, DateTimeKind.Local).AddTicks(4452), 82, "", "http://pauline.net", "repellendus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 9, 7, 13, 36, 34, 511, DateTimeKind.Local).AddTicks(5155), new DateTime(2020, 9, 8, 5, 12, 5, 208, DateTimeKind.Local).AddTicks(1331), new DateTime(2020, 9, 7, 16, 51, 7, 665, DateTimeKind.Local).AddTicks(3064), 82, "", "http://océane.com", "voluptatum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 9, 7, 14, 41, 31, 607, DateTimeKind.Local).AddTicks(9775), new DateTime(2020, 9, 7, 12, 56, 12, 452, DateTimeKind.Local).AddTicks(1889), new DateTime(2020, 9, 7, 18, 40, 23, 632, DateTimeKind.Local).AddTicks(4818), 82, "", "http://maëlle.fr", "suscipit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 9, 8, 4, 53, 22, 505, DateTimeKind.Local).AddTicks(5236), new DateTime(2020, 9, 8, 1, 53, 13, 662, DateTimeKind.Local).AddTicks(3168), new DateTime(2020, 9, 7, 18, 51, 15, 818, DateTimeKind.Local).AddTicks(5410), 81, "", "http://enzo.org", "culpa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 9, 7, 18, 15, 26, 745, DateTimeKind.Local).AddTicks(573), new DateTime(2020, 9, 7, 22, 21, 50, 955, DateTimeKind.Local).AddTicks(3598), new DateTime(2020, 9, 8, 5, 50, 58, 763, DateTimeKind.Local).AddTicks(593), 80, "", "https://louise.name", "delectus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 9, 8, 9, 4, 7, 188, DateTimeKind.Local).AddTicks(9564), new DateTime(2020, 9, 8, 4, 19, 57, 67, DateTimeKind.Local).AddTicks(5096), new DateTime(2020, 9, 7, 23, 59, 40, 750, DateTimeKind.Local).AddTicks(6380), 79, "", "http://maëlle.net", "fugiat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 9, 8, 7, 14, 49, 468, DateTimeKind.Local).AddTicks(3793), new DateTime(2020, 9, 7, 19, 30, 42, 811, DateTimeKind.Local).AddTicks(1278), new DateTime(2020, 9, 8, 6, 28, 48, 988, DateTimeKind.Local).AddTicks(4829), 78, "", "http://nicolas.name", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 9, 8, 6, 9, 44, 996, DateTimeKind.Local).AddTicks(4218), new DateTime(2020, 9, 7, 19, 9, 48, 351, DateTimeKind.Local).AddTicks(701), new DateTime(2020, 9, 8, 4, 24, 17, 866, DateTimeKind.Local).AddTicks(2255), 77, "", "http://louise.info", "sed" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 9, 8, 4, 19, 16, 833, DateTimeKind.Local).AddTicks(661), new DateTime(2020, 9, 8, 10, 39, 16, 247, DateTimeKind.Local).AddTicks(2521), new DateTime(2020, 9, 7, 18, 43, 4, 936, DateTimeKind.Local).AddTicks(4439), 77, "", "http://nicolas.net", "labore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 9, 7, 22, 53, 42, 672, DateTimeKind.Local).AddTicks(1170), new DateTime(2020, 9, 7, 13, 41, 16, 642, DateTimeKind.Local).AddTicks(2728), new DateTime(2020, 9, 8, 8, 38, 33, 27, DateTimeKind.Local).AddTicks(8506), 76, "", "https://romain.eu", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 9, 8, 4, 13, 10, 253, DateTimeKind.Local).AddTicks(4544), new DateTime(2020, 9, 8, 0, 24, 8, 36, DateTimeKind.Local).AddTicks(947), new DateTime(2020, 9, 8, 9, 47, 6, 722, DateTimeKind.Local).AddTicks(4172), 75, "", "https://victor.eu", "a" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 9, 7, 17, 22, 56, 746, DateTimeKind.Local).AddTicks(7967), new DateTime(2020, 9, 7, 16, 4, 8, 643, DateTimeKind.Local).AddTicks(105), new DateTime(2020, 9, 8, 9, 38, 24, 53, DateTimeKind.Local).AddTicks(7121), 75, "", "https://valentin.fr", "magni" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 9, 7, 20, 10, 28, 645, DateTimeKind.Local).AddTicks(7632), new DateTime(2020, 9, 8, 5, 8, 54, 995, DateTimeKind.Local).AddTicks(6738), new DateTime(2020, 9, 8, 6, 20, 12, 279, DateTimeKind.Local).AddTicks(4570), 74, "", "https://charlotte.fr", "amet" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 9, 7, 22, 37, 52, 454, DateTimeKind.Local).AddTicks(9426), new DateTime(2020, 9, 8, 0, 42, 33, 74, DateTimeKind.Local).AddTicks(7220), new DateTime(2020, 9, 8, 10, 46, 15, 18, DateTimeKind.Local).AddTicks(9661), 47, "", "https://tom.eu", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 9, 7, 14, 2, 28, 834, DateTimeKind.Local).AddTicks(7294), new DateTime(2020, 9, 7, 15, 5, 54, 763, DateTimeKind.Local).AddTicks(3957), new DateTime(2020, 9, 7, 18, 57, 31, 190, DateTimeKind.Local).AddTicks(2208), 46, "", "https://léa.net", "odit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 9, 7, 12, 19, 37, 359, DateTimeKind.Local).AddTicks(1749), new DateTime(2020, 9, 8, 3, 56, 43, 862, DateTimeKind.Local).AddTicks(5954), new DateTime(2020, 9, 7, 19, 15, 46, 805, DateTimeKind.Local).AddTicks(1654), 100, "", "https://alicia.fr", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 9, 8, 3, 3, 3, 116, DateTimeKind.Local).AddTicks(7126), new DateTime(2020, 9, 7, 15, 27, 44, 205, DateTimeKind.Local).AddTicks(9450), new DateTime(2020, 9, 7, 12, 36, 13, 231, DateTimeKind.Local).AddTicks(3034), 43, "", "http://valentin.org", "corporis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 9, 8, 8, 22, 19, 724, DateTimeKind.Local).AddTicks(8680), new DateTime(2020, 9, 8, 8, 30, 1, 574, DateTimeKind.Local).AddTicks(5872), new DateTime(2020, 9, 8, 1, 48, 47, 395, DateTimeKind.Local).AddTicks(9632), 22, "", "https://enzo.com", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 9, 7, 11, 42, 51, 728, DateTimeKind.Local).AddTicks(3548), new DateTime(2020, 9, 8, 6, 7, 45, 916, DateTimeKind.Local).AddTicks(4199), new DateTime(2020, 9, 8, 1, 44, 33, 565, DateTimeKind.Local).AddTicks(7413), 20, "", "https://léa.com", "ipsum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 9, 7, 15, 59, 28, 135, DateTimeKind.Local).AddTicks(770), new DateTime(2020, 9, 7, 20, 7, 10, 588, DateTimeKind.Local).AddTicks(7693), new DateTime(2020, 9, 7, 18, 16, 8, 918, DateTimeKind.Local).AddTicks(9258), 20, "", "https://maxence.eu", "consectetur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 9, 7, 17, 13, 23, 214, DateTimeKind.Local).AddTicks(7199), new DateTime(2020, 9, 7, 11, 47, 56, 891, DateTimeKind.Local).AddTicks(9777), new DateTime(2020, 9, 7, 23, 13, 28, 88, DateTimeKind.Local).AddTicks(8961), 19, "", "http://océane.net", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 9, 7, 19, 34, 36, 445, DateTimeKind.Local).AddTicks(7993), new DateTime(2020, 9, 7, 22, 48, 58, 218, DateTimeKind.Local).AddTicks(6412), new DateTime(2020, 9, 7, 14, 5, 29, 260, DateTimeKind.Local).AddTicks(2044), 99, "", "https://julien.com", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 9, 8, 4, 13, 25, 936, DateTimeKind.Local).AddTicks(4792), new DateTime(2020, 9, 7, 15, 2, 16, 475, DateTimeKind.Local).AddTicks(1662), new DateTime(2020, 9, 8, 10, 17, 21, 668, DateTimeKind.Local).AddTicks(3852), 18, "", "https://manon.org", "quae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 9, 7, 23, 13, 25, 855, DateTimeKind.Local).AddTicks(977), new DateTime(2020, 9, 7, 16, 47, 19, 308, DateTimeKind.Local).AddTicks(9282), new DateTime(2020, 9, 7, 14, 24, 2, 952, DateTimeKind.Local).AddTicks(1323), 15, "", "http://pauline.org", "iure" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 9, 7, 19, 28, 18, 784, DateTimeKind.Local).AddTicks(6785), new DateTime(2020, 9, 7, 12, 13, 33, 960, DateTimeKind.Local).AddTicks(8743), new DateTime(2020, 9, 7, 18, 29, 27, 386, DateTimeKind.Local).AddTicks(4526), 14, "", "https://julien.eu", "neque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 9, 8, 6, 26, 29, 487, DateTimeKind.Local).AddTicks(4521), new DateTime(2020, 9, 8, 8, 37, 31, 483, DateTimeKind.Local).AddTicks(1555), new DateTime(2020, 9, 7, 11, 44, 36, 263, DateTimeKind.Local).AddTicks(745), 24, "", "https://clément.name", "ab" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 9, 7, 22, 42, 25, 980, DateTimeKind.Local).AddTicks(659), new DateTime(2020, 9, 7, 23, 24, 37, 444, DateTimeKind.Local).AddTicks(1086), new DateTime(2020, 9, 7, 18, 46, 36, 690, DateTimeKind.Local).AddTicks(4833), 12, "", "http://valentin.name", "nesciunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 9, 7, 17, 5, 25, 903, DateTimeKind.Local).AddTicks(2633), new DateTime(2020, 9, 7, 23, 34, 23, 258, DateTimeKind.Local).AddTicks(38), new DateTime(2020, 9, 8, 6, 25, 29, 534, DateTimeKind.Local).AddTicks(421), 8, "", "http://alice.eu", "id" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 9, 7, 15, 45, 2, 962, DateTimeKind.Local).AddTicks(6586), new DateTime(2020, 9, 8, 4, 22, 51, 465, DateTimeKind.Local).AddTicks(8864), new DateTime(2020, 9, 7, 11, 32, 23, 885, DateTimeKind.Local).AddTicks(302), 8, "", "https://louis.info", "quod" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 9, 7, 17, 8, 24, 368, DateTimeKind.Local).AddTicks(8888), new DateTime(2020, 9, 7, 14, 2, 26, 491, DateTimeKind.Local).AddTicks(4053), new DateTime(2020, 9, 7, 21, 35, 38, 406, DateTimeKind.Local).AddTicks(1695), 7, "", "http://marie.name", "aliquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 9, 7, 19, 47, 25, 591, DateTimeKind.Local).AddTicks(9720), new DateTime(2020, 9, 8, 2, 31, 39, 314, DateTimeKind.Local).AddTicks(620), new DateTime(2020, 9, 8, 10, 2, 12, 368, DateTimeKind.Local).AddTicks(8952), 6, "", "http://arthur.eu", "officia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 9, 7, 21, 21, 10, 43, DateTimeKind.Local).AddTicks(780), new DateTime(2020, 9, 8, 1, 34, 27, 808, DateTimeKind.Local).AddTicks(2488), new DateTime(2020, 9, 7, 22, 6, 34, 489, DateTimeKind.Local).AddTicks(2574), 4, "", "https://noah.fr", "amet" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 9, 8, 3, 21, 44, 574, DateTimeKind.Local).AddTicks(9847), new DateTime(2020, 9, 8, 5, 49, 26, 705, DateTimeKind.Local).AddTicks(1149), new DateTime(2020, 9, 8, 4, 51, 4, 24, DateTimeKind.Local).AddTicks(2135), 2, "", "https://enzo.fr", "totam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 9, 7, 11, 55, 31, 879, DateTimeKind.Local).AddTicks(4934), new DateTime(2020, 9, 7, 22, 39, 38, 370, DateTimeKind.Local).AddTicks(4758), new DateTime(2020, 9, 8, 2, 56, 22, 508, DateTimeKind.Local).AddTicks(3353), 2, "", "https://adam.org", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 9, 7, 14, 47, 48, 738, DateTimeKind.Local).AddTicks(2871), new DateTime(2020, 9, 8, 8, 39, 9, 389, DateTimeKind.Local).AddTicks(5762), new DateTime(2020, 9, 8, 9, 24, 15, 162, DateTimeKind.Local).AddTicks(9930), 1, "", "http://pierre.name", "quo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 9, 8, 1, 23, 34, 217, DateTimeKind.Local).AddTicks(9964), new DateTime(2020, 9, 7, 21, 55, 38, 411, DateTimeKind.Local).AddTicks(8731), new DateTime(2020, 9, 8, 9, 4, 21, 325, DateTimeKind.Local).AddTicks(4248), 11, "", "https://ethan.org", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 9, 8, 9, 45, 11, 211, DateTimeKind.Local).AddTicks(3277), new DateTime(2020, 9, 8, 11, 6, 23, 541, DateTimeKind.Local).AddTicks(8134), new DateTime(2020, 9, 8, 8, 17, 1, 974, DateTimeKind.Local).AddTicks(7177), 24, "", "http://mathilde.net", "dicta" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 9, 8, 7, 37, 15, 117, DateTimeKind.Local).AddTicks(8277), new DateTime(2020, 9, 7, 23, 23, 47, 159, DateTimeKind.Local).AddTicks(6012), new DateTime(2020, 9, 7, 22, 52, 55, 676, DateTimeKind.Local).AddTicks(2621), 19, "", "https://maëlle.name", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 9, 7, 20, 25, 24, 431, DateTimeKind.Local).AddTicks(5666), new DateTime(2020, 9, 7, 19, 54, 32, 625, DateTimeKind.Local).AddTicks(2764), new DateTime(2020, 9, 8, 5, 40, 40, 408, DateTimeKind.Local).AddTicks(1086), 26, "", "https://jeanne.net", "pariatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 9, 7, 14, 40, 43, 365, DateTimeKind.Local).AddTicks(1332), new DateTime(2020, 9, 7, 18, 50, 46, 792, DateTimeKind.Local).AddTicks(8747), new DateTime(2020, 9, 8, 8, 8, 22, 706, DateTimeKind.Local).AddTicks(7710), 43, "", "http://lou.info", "natus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 9, 7, 11, 55, 3, 990, DateTimeKind.Local).AddTicks(3680), new DateTime(2020, 9, 7, 17, 40, 18, 372, DateTimeKind.Local).AddTicks(1689), new DateTime(2020, 9, 7, 12, 48, 27, 867, DateTimeKind.Local).AddTicks(6225), 42, "", "https://lucas.name", "dolore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 9, 8, 9, 25, 18, 673, DateTimeKind.Local).AddTicks(9078), new DateTime(2020, 9, 8, 10, 58, 12, 336, DateTimeKind.Local).AddTicks(1360), new DateTime(2020, 9, 7, 11, 20, 6, 294, DateTimeKind.Local).AddTicks(4501), 25, "", "http://mathis.eu", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 9, 8, 4, 31, 42, 29, DateTimeKind.Local).AddTicks(6374), new DateTime(2020, 9, 7, 12, 34, 11, 448, DateTimeKind.Local).AddTicks(2474), new DateTime(2020, 9, 7, 23, 48, 18, 869, DateTimeKind.Local).AddTicks(5140), 40, "", "http://zoe.info", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 9, 7, 15, 7, 41, 535, DateTimeKind.Local).AddTicks(147), new DateTime(2020, 9, 7, 12, 42, 24, 372, DateTimeKind.Local).AddTicks(5577), new DateTime(2020, 9, 7, 23, 51, 39, 350, DateTimeKind.Local).AddTicks(7513), 39, "", "http://mélissa.org", "praesentium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 9, 7, 12, 34, 55, 353, DateTimeKind.Local).AddTicks(2416), new DateTime(2020, 9, 7, 14, 1, 19, 768, DateTimeKind.Local).AddTicks(8985), new DateTime(2020, 9, 8, 1, 59, 8, 415, DateTimeKind.Local).AddTicks(5382), 39, "", "https://clément.info", "aspernatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 9, 7, 16, 23, 16, 918, DateTimeKind.Local).AddTicks(2284), new DateTime(2020, 9, 7, 22, 16, 3, 881, DateTimeKind.Local).AddTicks(6826), new DateTime(2020, 9, 8, 2, 7, 56, 777, DateTimeKind.Local).AddTicks(2176), 39, "", "https://maeva.com", "labore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 9, 7, 15, 9, 8, 185, DateTimeKind.Local).AddTicks(6079), new DateTime(2020, 9, 7, 14, 32, 21, 527, DateTimeKind.Local).AddTicks(4100), new DateTime(2020, 9, 7, 11, 23, 30, 789, DateTimeKind.Local).AddTicks(9102), 38, "", "http://louise.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 9, 8, 2, 29, 37, 401, DateTimeKind.Local).AddTicks(8820), new DateTime(2020, 9, 7, 13, 54, 20, 996, DateTimeKind.Local).AddTicks(9666), new DateTime(2020, 9, 8, 3, 55, 35, 214, DateTimeKind.Local).AddTicks(9081), 36, "", "https://léo.eu", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 9, 8, 9, 51, 41, 767, DateTimeKind.Local).AddTicks(9236), new DateTime(2020, 9, 7, 16, 17, 34, 353, DateTimeKind.Local).AddTicks(2377), new DateTime(2020, 9, 7, 21, 43, 33, 345, DateTimeKind.Local).AddTicks(9316), 41, "", "http://lina.name", "optio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 9, 7, 14, 8, 29, 762, DateTimeKind.Local).AddTicks(8002), new DateTime(2020, 9, 7, 16, 2, 47, 969, DateTimeKind.Local).AddTicks(4596), new DateTime(2020, 9, 8, 6, 57, 47, 902, DateTimeKind.Local).AddTicks(325), 31, "", "http://maëlle.fr", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 9, 7, 20, 13, 35, 777, DateTimeKind.Local).AddTicks(1747), new DateTime(2020, 9, 7, 21, 23, 41, 940, DateTimeKind.Local).AddTicks(9656), new DateTime(2020, 9, 8, 3, 48, 25, 99, DateTimeKind.Local).AddTicks(8206), 31, "", "https://nicolas.fr", "quidem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 9, 8, 7, 14, 31, 578, DateTimeKind.Local).AddTicks(8671), new DateTime(2020, 9, 7, 13, 20, 6, 698, DateTimeKind.Local).AddTicks(9679), new DateTime(2020, 9, 7, 22, 47, 48, 242, DateTimeKind.Local).AddTicks(4970), 30, "", "https://romain.eu", "sapiente" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 9, 8, 1, 32, 54, 563, DateTimeKind.Local).AddTicks(7668), new DateTime(2020, 9, 8, 2, 10, 7, 987, DateTimeKind.Local).AddTicks(198), new DateTime(2020, 9, 8, 5, 55, 29, 813, DateTimeKind.Local).AddTicks(604), 30, "", "http://louise.com", "ducimus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 9, 8, 6, 32, 45, 360, DateTimeKind.Local).AddTicks(9109), new DateTime(2020, 9, 8, 1, 45, 58, 757, DateTimeKind.Local).AddTicks(9954), new DateTime(2020, 9, 7, 17, 29, 40, 254, DateTimeKind.Local).AddTicks(6464), 28, "", "http://sacha.com", "quisquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 9, 8, 5, 34, 28, 360, DateTimeKind.Local).AddTicks(9924), new DateTime(2020, 9, 8, 4, 14, 33, 835, DateTimeKind.Local).AddTicks(759), new DateTime(2020, 9, 7, 14, 40, 21, 179, DateTimeKind.Local).AddTicks(9771), 28, "", "https://rayan.com", "iste" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 9, 7, 16, 54, 34, 446, DateTimeKind.Local).AddTicks(2067), new DateTime(2020, 9, 7, 16, 17, 44, 391, DateTimeKind.Local).AddTicks(7751), new DateTime(2020, 9, 7, 16, 52, 41, 197, DateTimeKind.Local).AddTicks(1033), 27, "", "https://jeanne.com", "ipsam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 9, 8, 2, 30, 43, 957, DateTimeKind.Local).AddTicks(2858), new DateTime(2020, 9, 8, 5, 55, 18, 715, DateTimeKind.Local).AddTicks(8971), new DateTime(2020, 9, 7, 19, 14, 7, 22, DateTimeKind.Local).AddTicks(9954), 27, "", "https://mohamed.org", "corrupti" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 9, 7, 15, 59, 13, 95, DateTimeKind.Local).AddTicks(8240), new DateTime(2020, 9, 8, 5, 7, 19, 318, DateTimeKind.Local).AddTicks(8653), new DateTime(2020, 9, 7, 16, 36, 31, 532, DateTimeKind.Local).AddTicks(3681), 26, "", "https://ambre.fr", "debitis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 9, 7, 11, 45, 53, 17, DateTimeKind.Local).AddTicks(5249), new DateTime(2020, 9, 8, 2, 13, 50, 51, DateTimeKind.Local).AddTicks(5976), new DateTime(2020, 9, 7, 14, 3, 33, 8, DateTimeKind.Local).AddTicks(4554), 32, "", "https://raphaël.name", "corporis" });

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
                values: new object[] { 1, "1.9.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 1, 1, null, 2, 1, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 25, "4.5.9.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 90, 6, 10, null, 1, 4, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 22, "0.2.4.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 28, 5, 6, null, 2, 4, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 21, "5.2.7.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 6, null, 4, 3, 4, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 13, "5.4.6.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 3, 6, null, 1, 4, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 81, "2.5.1.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 13, 7, null, 4, 1, 10, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 80, "7.9.9.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 59, 4, null, null, 4, 10, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 77, "1.8.4.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 6, null, null, 2, 10, 7, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 59, "8.2.9.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 59, 6, null, null, 1, 10, 4, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 55, "6.7.9.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 38, 6, 10, null, 4, 10, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 24, "2.9.7.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 2, null, 4, 2, 10, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 5, "5.9.5.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 77, 5, null, null, 4, 10, 1, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 98, "5.5.9.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 25, 1, null, null, 2, 9, 5, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 96, "0.8.7.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 86, 3, null, 3, 3, 9, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 89, "8.4.7.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 4, null, null, 3, 9, 2, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 88, "8.0.3.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 21, 1, 10, null, 3, 9, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 87, "2.8.0.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 60, 1, null, 4, 4, 9, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 73, "2.5.9.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 6, 7, null, 4, 9, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 63, "8.7.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 32, 4, null, 3, 3, 9, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 50, "8.6.9.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 21, 2, null, null, 1, 9, 9, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 49, "3.8.8.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 6, 4, 2, null, 1, 9, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 39, "9.5.5.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 5, null, 4, 3, 9, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 32, "0.4.3.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 7, null, null, 2, 4, 6, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 34, "2.2.1.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 1, 9, null, 2, 4, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 48, "0.7.0.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 1, null, 5, 4, 4, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 52, "4.0.5.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 85, 7, 2, null, 3, 4, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 85, "6.5.3.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 6, 10, null, 4, 6, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 82, "0.3.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 85, 1, 4, null, 3, 6, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 66, "7.8.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 7, 6, null, 4, 3, 6, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 62, "3.1.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 4, null, null, 3, 6, 5, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 40, "4.9.0.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 6, 8, null, 1, 6, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 36, "7.5.1.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 5, null, 2, 1, 6, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 31, "6.5.6.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 60, 3, 9, null, 4, 6, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 27, "8.8.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 2, null, 4, 3, 6, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 15, "2.2.1.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 48, 6, null, 5, 2, 6, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 95, "0.2.5.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 7, null, null, 4, 5, 9, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 23, "3.3.2.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 41, 2, null, null, 3, 9, 4, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 93, "7.2.1.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 19, 6, null, 4, 2, 5, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 68, "1.5.0.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 68, 7, null, null, 3, 5, 10, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 47, "0.0.4.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 91, 6, null, null, 3, 5, 5, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 37, "6.1.8.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 36, 6, 4, null, 1, 5, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 16, "6.3.0.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 6, 8, null, 3, 5, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 11, "4.5.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 50, 2, null, null, 2, 5, 5, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 2, "9.2.2.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 1, null, null, 2, 5, 3, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 100, "0.2.1.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 89, 4, 6, null, 3, 4, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 94, "1.3.5.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 9, 6, 4, null, 2, 4, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 91, "7.4.0.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 5, 3, null, 4, 4, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 76, "3.2.4.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 3, 2, null, 1, 4, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 86, "6.0.2.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 40, 2, null, null, 4, 5, 1, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 61, "8.7.8.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 65, 1, 1, null, 1, 8, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 90, "3.2.2.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 77, 1, null, 4, 3, 6, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 54, "8.5.7.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 2, null, 5, 1, 8, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 97, "9.7.9.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 64, 2, 3, null, 3, 2, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 78, "6.4.1.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 4, null, 4, 4, 2, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 75, "6.1.3.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 3, null, 6, 4, 2, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 72, "5.1.1.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 6, null, 2, 4, 2, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 70, "0.8.3.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 13, 2, 8, null, 3, 2, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 69, "5.9.1.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 28, 1, null, 1, 4, 2, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 60, "1.7.0.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 7, null, 3, 1, 2, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 42, "0.6.8.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 3, 7, null, 2, 1, 2, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 30, "2.5.9.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 38, 7, null, 2, 2, 2, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 26, "8.8.2.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 80, 2, null, null, 1, 2, 9, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 20, "4.9.6.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 34, 7, null, null, 1, 2, 3, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 19, "3.5.4.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 72, 2, 8, null, 1, 2, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 14, "5.4.1.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 7, null, null, 3, 2, 5, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 84, "3.8.9.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 64, 7, null, 5, 2, 1, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 67, "9.3.5.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 16, 1, 6, null, 3, 1, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 64, "6.8.0.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 43, 7, 8, null, 1, 1, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 58, "1.7.3.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 6, 9, null, 4, 1, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 44, "3.0.5.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 72, 5, null, null, 4, 1, 3, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 41, "8.5.1.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 77, 6, null, null, 1, 1, 6, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 12, "5.1.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 48, 5, null, 2, 1, 1, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 57, "9.0.6.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 3, null, 5, 1, 8, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 3, "3.0.8.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 6, 6, null, 3, 1, 3, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 8, "9.6.9.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 4, null, null, 2, 3, 7, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 33, "6.8.5.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 19, 3, null, 5, 4, 2, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 35, "5.2.7.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 83, 3, null, null, 2, 3, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 28, "4.6.7.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 64, 7, 1, null, 4, 3, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 29, "9.9.2.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 63, 4, null, null, 2, 8, 7, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 17, "1.1.8.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 10, 6, null, null, 1, 8, 3, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 10, "5.8.9.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 19, 6, 1, null, 4, 8, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 7, "3.5.8.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 46, 7, 6, null, 2, 8, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 6, "7.1.3.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 81, 1, null, 6, 2, 8, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 99, "8.8.9.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 5, null, 6, 4, 7, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 83, "3.0.1.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 52, 1, null, null, 1, 7, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 79, "5.2.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 8, 4, 7, null, 4, 7, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 65, "0.1.7.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 6, null, null, 3, 7, 4, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 56, "3.8.8.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 3, null, null, 3, 7, 4, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 92, "2.6.2.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 5, null, null, 4, 7, 9, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 45, "2.9.1.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 73, 4, null, 1, 4, 8, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 38, "0.6.3.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 74, 5, null, null, 2, 7, 7, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 46, "1.2.1.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 2, 1, null, 2, 3, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 51, "3.5.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 6, null, 5, 2, 3, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 53, "5.6.0.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 50, 3, null, null, 3, 3, 8, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 71, "7.9.9.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 77, 6, null, null, 4, 3, 9, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 43, "5.4.9.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 76, 5, 3, null, 3, 3, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 4, "2.4.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 2, 10, null, 2, 7, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 9, "9.1.1.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 31, 7, null, 1, 4, 7, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 18, "6.6.3.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 43, 6, null, 4, 3, 7, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 74, "5.5.2.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 5, null, null, 1, 3, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "iure", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 75, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "perspiciatis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 35, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "omnis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 35, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "repudiandae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 52, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "odio", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 36, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "itaque", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 23, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "quis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 16, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "in", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 16, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "deserunt", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 94, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "unde", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 92, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "voluptatem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 9, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "alias", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 98, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "atque", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 98, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "autem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 37, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "sed", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 37, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "dolorem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 6, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "inventore", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 6, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "voluptatibus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 74, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "velit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 97, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "autem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 9, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "aliquid", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 35, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "officia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 98, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "ipsum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 50, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "reiciendis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 41, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "alias", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 32, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 12, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "velit", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 41, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "qui", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 61, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 61, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "officia", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 34, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "veniam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 42, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "et", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 58, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "quis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 58, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "consequatur", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 13, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "impedit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 13, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "ex", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 21, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "hic", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 43, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "laborum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 100, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "laboriosam", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 28, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "nisi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 28, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "qui", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 28, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "voluptas", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 28, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "ut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 91, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "doloremque", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 91, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "qui", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 87, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "vero", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 87, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "quo", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 55, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "eligendi", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 100, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "iste", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 84, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 2, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "earum", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 20, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "non", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 29, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "sed", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 29, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "consequatur", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 11, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "quis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 53, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "officia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 53, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "in", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 53, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "necessitatibus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 59, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "dolorem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 80, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "ea", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 80, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "unde", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 49, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "commodi", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 85, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "pariatur", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 46, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "animi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 46, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "minus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 68, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "eum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 68, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "asperiores", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 48, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 7, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "aut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "optio", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "et", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 15, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "aut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 45, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "quia", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 81, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "a", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 93, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 93, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "delectus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 1, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "in", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 20, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "beatae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 22, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "nihil", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 22, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "omnis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 18, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "consectetur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 77, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "amet", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 77, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "non", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 78, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "quia", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 24, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "vero", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 24, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "doloribus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 79, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 20, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "id", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 79, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "neque", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 56, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 56, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "debitis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 56, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "maxime", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 56, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "quis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 83, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "ipsam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 26, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "hic", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 26, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "dolores", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 26, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "sunt", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 26, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "sint", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 1, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "reprehenderit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 56, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "non", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 45, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/incredible-cotton-pizza/home-loan-account", 6, 34 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/ukraine", 4, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/smtp/extension", 5, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/bottom-line", 6, 19 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/generic", 3, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/synergies", 4, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/grey", 1, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/world-class", 4, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/global/seychelles-rupee", 7, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/models", 1, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/navigating/payment", 4, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/circuit/coordinator", 4, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/frozen", 1, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/vision-oriented/payment", 5, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/cambridgeshire/synergize/syrian-pound", 1, 29 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/digital/cross-platform", 4, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/soft", 1, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/client-driven/platinum/practical-fresh-towels", 6, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/rubber", 5, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/nauru/sleek-cotton-gloves/guernsey", 5, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/transmitter/factors", 6, 46 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/cambridgeshire/borders", 2, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/louisiana/licensed", 5, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/proactive/deposit", 2, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/taiwan/circuit/mobility", 6, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/tunnel", 5, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/fundamental", 7, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/home/pci/synthesize", 3, 100 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/central", 7, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/technician/liaison/grocery-toys--sports", 7, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/yemeni-rial/cocos-keeling-islands", 6, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/lodge/firewall/unbranded-plastic-computer", 6, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/smtp/refined/schemas", 2, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/tasty/rest", 4, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/shoals", 6, 6 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/quantify/utilisation", 5, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/impactful/synchronised", 2, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/bedfordshire/rufiyaa", 4, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/navigate/cotton/virgin-islands-u.s", 5, 27 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/incredible-concrete-sausages/convertible-marks/handmade", 2, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/intelligent-concrete-fish", 6, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/idaho", 3, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/conglomeration/garden", 2, 15 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/thx/cotton/iowa", 1, 63 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/ib", 5, 63 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/neural", 4, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/web-readiness", 2, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/lime", 1, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/platforms", 6, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/navigate", 5, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/monitor", 4, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/circles/springs/plain", 6, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/port/withdrawal", 7, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/ukraine/ivory", 6, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/executive/north-dakota", 6, 99 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/cultivate/developer/national", 3, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/brook", 5, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/sdd", 3, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/specialist/systemic/district", 6, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/buckinghamshire/alliance/hack", 2, 33 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/afghani", 1, 68 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/technician", 4, 75 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/ergonomic-soft-towels/investment-account", 2, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/mandatory/withdrawal", 2, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/circle/global", 4, 94 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/json/bleeding-edge/auxiliary", 1, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/integrated/tertiary", 7, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/highway", 6, 38 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/expedite/awesome-fresh-chips/fantastic-wooden-chair", 1, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/innovate/protocol", 6, 4 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/handcrafted-wooden-gloves/falls", 2, 13 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/adp/product/seamless", 4, 40 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/french-southern-territories", 4, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/viaduct/hdd/haptic", 2, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/shoals/investment-account/hard-drive", 2, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/web/us-dollar/generic", 4, 52 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/compatible/transmitting", 1, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/pci/ergonomic", 3, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/national/oregon/portals", 4, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/grey/sports--tools/invoice", 7, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/montana/auto-loan-account", 1, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/auto-loan-account/new-mexico", 1, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/automotive--games", 6, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/mews", 3, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/texas/tactics", 6, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/generic-plastic-cheese/responsive", 1, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/massachusetts/purple", 4, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/interface/navigating/panel", 2, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/developer/haptic", 7, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/pricing-structure/ergonomic", 4, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/syrian-pound/profit-focused/western-sahara", 1, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/planner/payment/sleek-steel-mouse", 1, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/compressing/estate/customer", 5, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/optimization/array", 4, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/plastic", 7, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/indexing", 7, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/initiative/oregon/green", 6, 82 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/transmitting/gb/architectures", 7, 52 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/rustic/back-up", 7, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/fantastic-plastic-pants/mobility/back-end", 4, 40 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 5, new DateTime(2020, 4, 25, 18, 54, 52, 736, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 6, new DateTime(2020, 5, 16, 19, 20, 30, 681, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 1, new DateTime(2020, 1, 4, 14, 28, 34, 632, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 6, new DateTime(2020, 8, 8, 16, 37, 1, 929, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 2, new DateTime(2020, 1, 10, 16, 6, 58, 355, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 2, new DateTime(2020, 8, 8, 4, 0, 14, 630, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 5, new DateTime(2020, 4, 30, 8, 13, 32, 78, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 5, new DateTime(2020, 6, 22, 16, 24, 28, 669, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 1, new DateTime(2020, 8, 12, 7, 6, 38, 727, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 2, new DateTime(2020, 1, 22, 21, 55, 57, 463, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 4, new DateTime(2019, 11, 24, 22, 40, 25, 43, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 5, new DateTime(2020, 6, 17, 20, 45, 37, 556, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 6, new DateTime(2020, 7, 12, 16, 54, 1, 287, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 1, new DateTime(2019, 11, 3, 12, 46, 24, 388, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 6, new DateTime(2019, 12, 14, 6, 21, 9, 820, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 3, new DateTime(2019, 11, 7, 1, 14, 50, 820, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 6, new DateTime(2019, 12, 18, 17, 38, 7, 830, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 3, new DateTime(2020, 8, 7, 18, 5, 51, 698, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 1, new DateTime(2020, 3, 18, 5, 52, 29, 128, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 4, new DateTime(2020, 8, 14, 2, 19, 17, 941, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 2, new DateTime(2019, 10, 28, 14, 0, 39, 49, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 4, new DateTime(2020, 3, 19, 11, 29, 42, 778, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 5, new DateTime(2020, 9, 7, 5, 0, 40, 745, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 4, new DateTime(2020, 7, 18, 7, 48, 33, 511, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 2, new DateTime(2019, 10, 27, 13, 41, 22, 723, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 2, new DateTime(2020, 1, 14, 13, 14, 43, 979, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 3, new DateTime(2020, 1, 9, 4, 15, 9, 982, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 2, new DateTime(2020, 7, 25, 2, 44, 59, 788, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 4, new DateTime(2020, 2, 17, 11, 37, 58, 734, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 3, new DateTime(2020, 2, 19, 11, 35, 59, 159, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 4, new DateTime(2020, 2, 11, 13, 33, 2, 938, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 5, new DateTime(2019, 12, 10, 4, 40, 10, 873, DateTimeKind.Local).AddTicks(854) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 3, new DateTime(2020, 1, 13, 18, 55, 52, 739, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 5, new DateTime(2020, 1, 10, 17, 5, 6, 344, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 4, new DateTime(2019, 9, 17, 11, 55, 42, 591, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 1, new DateTime(2020, 1, 27, 22, 16, 3, 242, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 4, new DateTime(2020, 7, 28, 8, 27, 56, 579, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 5, new DateTime(2020, 8, 1, 15, 49, 38, 242, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 4, new DateTime(2020, 7, 18, 7, 0, 24, 107, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 2, new DateTime(2020, 4, 20, 1, 44, 10, 914, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 3, new DateTime(2020, 3, 5, 0, 31, 32, 45, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 1, new DateTime(2020, 2, 4, 4, 23, 26, 887, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 1, new DateTime(2019, 9, 16, 5, 20, 6, 845, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 2, new DateTime(2020, 8, 17, 15, 57, 56, 893, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 3, new DateTime(2020, 5, 17, 11, 50, 57, 862, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 5, new DateTime(2020, 4, 8, 3, 41, 10, 256, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 1, new DateTime(2019, 10, 25, 2, 13, 44, 495, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 5, new DateTime(2019, 11, 1, 12, 10, 2, 820, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 6, new DateTime(2019, 9, 26, 15, 31, 4, 449, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 2, new DateTime(2019, 12, 28, 13, 58, 10, 70, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 6, new DateTime(2020, 8, 4, 4, 28, 10, 190, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 6, new DateTime(2020, 4, 14, 19, 6, 19, 955, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 3, new DateTime(2020, 4, 3, 16, 22, 10, 261, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 2, new DateTime(2020, 1, 8, 19, 6, 17, 936, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 1, new DateTime(2020, 3, 16, 16, 6, 30, 444, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 3, new DateTime(2020, 1, 11, 3, 1, 56, 632, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 6, new DateTime(2020, 7, 27, 21, 34, 59, 477, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 1, new DateTime(2020, 1, 22, 8, 17, 19, 955, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 2, new DateTime(2020, 2, 25, 0, 1, 29, 148, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 5, new DateTime(2020, 1, 7, 11, 48, 47, 163, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 1, new DateTime(2020, 7, 24, 4, 36, 12, 993, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 1, new DateTime(2020, 4, 24, 22, 6, 20, 385, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 4, new DateTime(2019, 10, 16, 5, 26, 16, 984, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 3, new DateTime(2020, 1, 2, 20, 55, 31, 339, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 4, new DateTime(2019, 10, 2, 11, 9, 1, 644, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 4, new DateTime(2020, 1, 6, 13, 13, 33, 699, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 4, new DateTime(2019, 10, 7, 23, 28, 41, 612, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 2, new DateTime(2019, 9, 15, 21, 31, 29, 141, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 1, new DateTime(2020, 8, 16, 14, 0, 37, 3, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 6, new DateTime(2019, 12, 28, 9, 27, 33, 747, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 5, new DateTime(2019, 11, 17, 2, 50, 4, 356, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 5, new DateTime(2019, 12, 28, 19, 39, 6, 804, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 4, new DateTime(2020, 8, 8, 23, 33, 59, 893, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 6, new DateTime(2019, 9, 15, 10, 35, 27, 973, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 2, new DateTime(2019, 11, 20, 18, 29, 24, 252, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 6, new DateTime(2020, 8, 1, 1, 14, 20, 980, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 4, new DateTime(2020, 8, 6, 10, 39, 34, 597, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 3, new DateTime(2020, 6, 20, 18, 5, 5, 278, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 5, new DateTime(2020, 1, 7, 7, 51, 11, 868, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 4, new DateTime(2020, 1, 12, 22, 49, 11, 661, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 2, new DateTime(2020, 8, 22, 8, 1, 7, 211, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 2, new DateTime(2019, 11, 25, 11, 13, 38, 133, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 6, new DateTime(2019, 11, 16, 14, 58, 28, 888, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 5, new DateTime(2019, 9, 24, 10, 47, 34, 94, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 6, new DateTime(2020, 2, 8, 14, 46, 14, 855, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 1, new DateTime(2020, 3, 2, 17, 4, 30, 720, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 1, new DateTime(2020, 4, 15, 13, 13, 50, 576, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 4, new DateTime(2020, 3, 28, 7, 5, 13, 250, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 1, new DateTime(2020, 8, 23, 15, 12, 56, 106, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 5, new DateTime(2019, 9, 14, 1, 23, 27, 864, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 1, new DateTime(2019, 9, 18, 18, 25, 12, 824, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 4, new DateTime(2019, 9, 20, 5, 21, 18, 327, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 4, new DateTime(2019, 12, 22, 17, 11, 33, 318, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 2, new DateTime(2020, 3, 31, 5, 32, 34, 690, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 3, new DateTime(2020, 6, 10, 18, 20, 14, 399, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 1, new DateTime(2020, 5, 16, 4, 57, 16, 388, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 1, new DateTime(2020, 7, 31, 20, 23, 8, 348, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 5, new DateTime(2020, 2, 13, 6, 29, 43, 437, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 3, new DateTime(2020, 7, 14, 12, 46, 24, 222, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 2, new DateTime(2020, 8, 18, 5, 8, 50, 173, DateTimeKind.Local).AddTicks(5863) });

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
