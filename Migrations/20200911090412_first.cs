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
                values: new object[] { 10, "Categorie 1", new DateTime(2019, 11, 22, 11, 29, 0, 842, DateTimeKind.Local).AddTicks(3587), "Optio cum exercitationem sit explicabo dolor. Pariatur est nesciunt. Fugit pariatur illum voluptatem doloremque. Beatae repellendus velit doloribus illum nulla eum. Quas ut commodi. Quas atque omnis suscipit aliquam dolorem sed voluptatum molestiae molestiae. Et aut nostrum repellat modi veritatis neque dolorem sint modi. Quia ipsum voluptatem qui aut eum. Ut officia perspiciatis quisquam non ratione. Sed omnis mollitia asperiores aperiam iste quidem voluptatem. Cumque voluptatibus cupiditate pariatur id doloribus nisi velit dignissimos optio. Nesciunt deserunt sit.", "a" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 9, "Categorie 1", new DateTime(2020, 4, 18, 1, 41, 46, 395, DateTimeKind.Local).AddTicks(9985), "Dolore eaque quam magni quia perspiciatis quia velit eius cumque. Facere debitis id vel consectetur rerum quis beatae. Qui tempora molestiae vel sed voluptatem asperiores voluptatibus totam. Consectetur harum enim aspernatur rerum illo. Sed ratione natus voluptatibus. Illo totam dolores. Ullam exercitationem blanditiis tempore est dolore. Expedita sint voluptatem aut eaque perferendis ut. Nisi rerum et molestias explicabo dignissimos dolor. Omnis repellat aliquid tempora sint officiis iusto ipsum praesentium. Porro at cumque cupiditate autem assumenda rerum sit expedita culpa. Earum sequi occaecati quia aut rerum quasi magnam a.", "est" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 8, "Categorie 1", new DateTime(2020, 1, 29, 1, 48, 57, 224, DateTimeKind.Local).AddTicks(8830), "Et eveniet qui ut et alias minus numquam. Dolore beatae et placeat dolores et dolorum. Eos ipsa illo rerum est. Repellat qui molestiae molestiae asperiores ipsa et adipisci et sint. Tempora harum et porro cum debitis ipsum ducimus cum ad. Quia ut dolor nam dicta quaerat officiis cum. Placeat dolores voluptatem in ducimus sunt sunt quod quia. Ab in rerum accusamus et et omnis. Sit neque aut et explicabo id ut voluptas. Magnam sit tenetur. Quia dolorem quasi magni explicabo laborum nam ut odit. Et ad dolorem modi voluptatem. Doloremque enim eos sed.", "quisquam" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 7, "Categorie 1", new DateTime(2019, 12, 17, 1, 34, 1, 340, DateTimeKind.Local).AddTicks(5847), "Neque eum adipisci voluptas repellendus id itaque nostrum unde eligendi. Provident explicabo voluptates consequuntur. Ipsam ratione provident ut impedit eos eligendi. Veritatis qui expedita delectus magnam fuga qui dolorum molestias. Odit nobis ut in inventore repellendus officia omnis. Et ullam non exercitationem velit ut architecto quod. Sapiente aliquam dolor ullam eligendi quia ut sapiente beatae. Eaque et sapiente est accusantium qui et dignissimos in quod. Maxime soluta recusandae. Dolorem sunt magni non. Dolorum dolor aut et distinctio aliquam. Aut doloribus est enim explicabo nihil laborum.", "quos" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 6, "Categorie 1", new DateTime(2019, 9, 21, 22, 37, 25, 166, DateTimeKind.Local).AddTicks(1490), "Rem aut eum vitae optio aut totam sed ad iste. Quae odit quia sapiente nam. Ut et deleniti cumque omnis facere quo accusantium. Ut quam hic officiis doloremque et veniam libero sit minima. Unde ipsam distinctio numquam harum mollitia at asperiores quas vel. Incidunt qui nisi error. Quia adipisci impedit eius doloribus illo autem omnis. Magnam ea cupiditate. Voluptas odio officiis nobis. Fugit doloremque qui ut et dolorem ut nulla. Non et amet iste non laudantium iure. Voluptatum dolorum inventore.", "et" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 4, "Categorie 1", new DateTime(2019, 12, 18, 22, 23, 5, 325, DateTimeKind.Local).AddTicks(6303), "Rerum eum nesciunt aut ut quia a quam libero. Voluptatem est est adipisci dolores et numquam aspernatur temporibus ex. Nobis magnam qui. Exercitationem accusantium modi quasi tenetur. Excepturi asperiores est officia nemo ab placeat saepe eos. Vel dolorum laborum veniam vel nemo aut cumque rerum. Eaque facere consequatur est sed in voluptas facilis. Explicabo minus ut quo vitae placeat expedita. Id amet culpa laudantium sed non in libero et rerum. Omnis doloribus sit. Amet numquam qui omnis doloribus repudiandae iure.", "ut" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 3, "Categorie 1", new DateTime(2020, 7, 23, 11, 19, 42, 757, DateTimeKind.Local).AddTicks(3549), "Odit magnam non fugiat. Commodi aut quia. Omnis corporis mollitia et laboriosam. Et accusamus et. Rem aperiam officiis fugiat ut molestiae accusantium enim qui. Eos rerum aspernatur voluptas aut ex vel alias. Earum ipsam consequatur sed libero quidem fugiat. Necessitatibus est explicabo nulla aut consequatur earum fugiat non incidunt. Qui voluptates repellat illo ex molestias. Eos quia possimus autem voluptatibus id. Quis iste unde laudantium repudiandae sed adipisci excepturi tenetur.", "aut" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 2, "Categorie 1", new DateTime(2020, 5, 21, 18, 33, 1, 66, DateTimeKind.Local).AddTicks(4414), "Eum fugiat aut debitis suscipit laborum nobis qui quisquam magnam. Molestiae ducimus consequuntur nisi quod illum laudantium minima. Quae eos ut enim illo repudiandae tenetur autem quia. Ut qui sunt maiores dolores velit voluptas pariatur repellendus. Atque eaque est non quod quaerat. Maxime qui minima totam perspiciatis veniam voluptas aut et. Quos dolorem quam distinctio enim cumque. Et qui ex laudantium harum non velit ut soluta vel. Consequatur velit eos similique quibusdam. Quia facilis voluptas.", "natus" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 1, "Categorie 1", new DateTime(2020, 9, 9, 2, 13, 17, 646, DateTimeKind.Local).AddTicks(912), "Unde recusandae sit odit at voluptatum qui iure. Debitis dolore minus vel. Fugit sit omnis nihil odit doloremque necessitatibus earum veritatis minus. Nulla rerum quo voluptas et sint ullam dolorem. Et suscipit repellendus laborum. Distinctio necessitatibus eum officia sint illo fugiat delectus rerum culpa. Et iusto magni. Dolor id accusamus animi commodi consequatur officia accusamus perspiciatis culpa. Hic et qui consequatur omnis. Neque dolorem dignissimos eos. Ex qui cum. Debitis dolore magni qui sed beatae ipsum eos ducimus praesentium. Sit magnam officiis quasi sit veniam.", "ut" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 5, "Categorie 1", new DateTime(2019, 10, 13, 6, 27, 5, 999, DateTimeKind.Local).AddTicks(7894), "Voluptas quae aperiam et provident. Nesciunt eum voluptate excepturi corporis ad quo. Molestiae odit dolores itaque expedita sunt et beatae non. Dolores quaerat maiores libero. Numquam blanditiis exercitationem. Repudiandae dolorem provident quidem neque. Sunt reprehenderit est. Aut aut earum maiores earum natus aut. Autem et perferendis tempore nobis. Officiis voluptate enim unde corrupti quis consectetur inventore aut.", "veniam" });

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
                values: new object[] { 73, new DateTime(2020, 1, 21, 3, 42, 56, 477, DateTimeKind.Local).AddTicks(9825), "0,2,4", 73, 1, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2020, 8, 6, 1, 50, 36, 645, DateTimeKind.Local).AddTicks(8582), "1,2,6", 72, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2020, 8, 16, 15, 1, 59, 987, DateTimeKind.Local).AddTicks(2016), "1,3,5", 71, 4, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2020, 2, 27, 5, 46, 35, 769, DateTimeKind.Local).AddTicks(9903), "1,3,4", 70, 1, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2020, 1, 19, 14, 41, 25, 243, DateTimeKind.Local).AddTicks(1440), "1,2,5", 69, 5, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2020, 3, 4, 12, 56, 27, 314, DateTimeKind.Local).AddTicks(3563), "1,2,4", 68, 6, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2020, 2, 3, 6, 23, 54, 2, DateTimeKind.Local).AddTicks(1480), "1,3,6", 67, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2020, 1, 26, 19, 47, 30, 441, DateTimeKind.Local).AddTicks(7484), "0,2,4", 66, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2020, 1, 12, 2, 50, 8, 749, DateTimeKind.Local).AddTicks(7193), "1,2,6", 65, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2019, 11, 23, 14, 4, 58, 112, DateTimeKind.Local).AddTicks(8214), "0,2,5", 64, 2, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2020, 1, 24, 8, 42, 10, 805, DateTimeKind.Local).AddTicks(1077), "1,3,5", 63, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2020, 8, 26, 13, 24, 43, 197, DateTimeKind.Local).AddTicks(4538), "1,2,4", 61, 1, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2019, 10, 1, 14, 55, 16, 140, DateTimeKind.Local).AddTicks(8303), "0,3,5", 60, 3, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2020, 5, 30, 16, 21, 38, 537, DateTimeKind.Local).AddTicks(9896), "1,2,4", 59, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2020, 6, 3, 9, 56, 23, 784, DateTimeKind.Local).AddTicks(4971), "1,2,5", 58, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2020, 4, 29, 19, 41, 50, 37, DateTimeKind.Local).AddTicks(8815), "0,3,4", 57, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2020, 7, 2, 3, 15, 4, 603, DateTimeKind.Local).AddTicks(6060), "1,3,4", 56, 1, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2020, 3, 1, 10, 12, 47, 876, DateTimeKind.Local).AddTicks(6050), "1,2,4", 55, 3, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2020, 6, 30, 12, 56, 43, 678, DateTimeKind.Local).AddTicks(6208), "0,3,6", 54, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2020, 4, 16, 19, 32, 14, 447, DateTimeKind.Local).AddTicks(8027), "0,3,6", 53, 1, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2020, 3, 21, 10, 51, 48, 302, DateTimeKind.Local).AddTicks(9379), "0,2,5", 74, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2019, 10, 9, 17, 11, 4, 514, DateTimeKind.Local).AddTicks(6614), "1,3,4", 62, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2020, 4, 22, 17, 1, 5, 590, DateTimeKind.Local).AddTicks(5309), "1,2,4", 75, 5, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2019, 12, 13, 5, 51, 26, 154, DateTimeKind.Local).AddTicks(923), "1,2,5", 93, 5, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2020, 2, 1, 5, 26, 35, 83, DateTimeKind.Local).AddTicks(2817), "1,2,6", 77, 4, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2020, 9, 3, 5, 10, 55, 304, DateTimeKind.Local).AddTicks(4720), "0,2,6", 100, 5, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2019, 10, 7, 21, 17, 24, 801, DateTimeKind.Local).AddTicks(7493), "0,2,4", 99, 4, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2020, 1, 3, 22, 47, 44, 356, DateTimeKind.Local).AddTicks(2625), "1,2,6", 98, 5, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2019, 10, 4, 13, 46, 31, 2, DateTimeKind.Local).AddTicks(6722), "1,2,5", 97, 6, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2020, 7, 14, 23, 12, 37, 606, DateTimeKind.Local).AddTicks(3010), "1,3,6", 96, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2020, 2, 24, 9, 21, 26, 748, DateTimeKind.Local).AddTicks(3550), "1,3,6", 95, 5, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2020, 5, 27, 13, 12, 43, 569, DateTimeKind.Local).AddTicks(5322), "1,2,4", 94, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2020, 1, 8, 18, 2, 17, 102, DateTimeKind.Local).AddTicks(6640), "1,2,6", 52, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2020, 8, 19, 22, 23, 23, 32, DateTimeKind.Local).AddTicks(5849), "1,3,4", 92, 1, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2020, 4, 20, 12, 38, 0, 353, DateTimeKind.Local).AddTicks(3513), "0,3,5", 91, 6, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2019, 9, 27, 18, 31, 41, 591, DateTimeKind.Local).AddTicks(8671), "0,2,5", 76, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2020, 3, 10, 11, 33, 35, 175, DateTimeKind.Local).AddTicks(7226), "1,3,4", 90, 2, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2020, 3, 16, 10, 34, 33, 617, DateTimeKind.Local).AddTicks(3808), "0,2,5", 88, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2020, 8, 28, 4, 4, 29, 98, DateTimeKind.Local).AddTicks(6926), "1,2,6", 87, 5, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2020, 4, 18, 16, 34, 16, 224, DateTimeKind.Local).AddTicks(6467), "1,2,4", 86, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2020, 3, 28, 22, 56, 2, 293, DateTimeKind.Local).AddTicks(6545), "1,3,4", 85, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2020, 2, 17, 14, 45, 18, 78, DateTimeKind.Local).AddTicks(6143), "0,3,4", 83, 1, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2020, 1, 7, 3, 50, 49, 650, DateTimeKind.Local).AddTicks(1496), "1,2,5", 82, 4, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2019, 10, 11, 12, 1, 44, 574, DateTimeKind.Local).AddTicks(6872), "1,3,6", 81, 4, "Nouvelle visite a été ajouter", 4, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2019, 9, 30, 1, 53, 10, 905, DateTimeKind.Local).AddTicks(2106), "0,2,6", 80, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2019, 10, 16, 17, 35, 57, 212, DateTimeKind.Local).AddTicks(1380), "0,3,6", 79, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2019, 12, 18, 6, 38, 55, 471, DateTimeKind.Local).AddTicks(2077), "0,3,6", 78, 2, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2019, 9, 30, 13, 30, 3, 399, DateTimeKind.Local).AddTicks(163), "0,3,6", 89, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2019, 11, 5, 17, 38, 39, 306, DateTimeKind.Local).AddTicks(486), "1,3,5", 51, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2019, 11, 14, 13, 32, 19, 540, DateTimeKind.Local).AddTicks(1005), "0,3,5", 84, 3, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2019, 11, 4, 2, 20, 20, 468, DateTimeKind.Local).AddTicks(1690), "0,3,5", 49, 3, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2020, 2, 4, 20, 59, 24, 389, DateTimeKind.Local).AddTicks(5040), "1,3,6", 22, 1, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2020, 3, 14, 20, 15, 53, 710, DateTimeKind.Local).AddTicks(4484), "0,3,5", 21, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2019, 12, 1, 7, 22, 36, 861, DateTimeKind.Local).AddTicks(1402), "0,2,4", 20, 5, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2019, 12, 31, 4, 10, 33, 662, DateTimeKind.Local).AddTicks(8045), "0,2,5", 19, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2019, 10, 8, 0, 11, 19, 79, DateTimeKind.Local).AddTicks(4629), "0,2,6", 18, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2019, 12, 1, 21, 52, 17, 443, DateTimeKind.Local).AddTicks(3124), "1,3,6", 17, 4, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2020, 8, 30, 19, 34, 11, 858, DateTimeKind.Local).AddTicks(4370), "0,3,5", 15, 6, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2020, 7, 5, 5, 1, 55, 480, DateTimeKind.Local).AddTicks(4492), "0,3,5", 14, 5, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2020, 3, 2, 17, 52, 25, 120, DateTimeKind.Local).AddTicks(5657), "0,3,6", 13, 4, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2019, 12, 19, 7, 56, 22, 67, DateTimeKind.Local).AddTicks(544), "1,3,5", 12, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2020, 5, 29, 20, 33, 25, 40, DateTimeKind.Local).AddTicks(2868), "1,3,6", 23, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2019, 12, 2, 1, 52, 7, 637, DateTimeKind.Local).AddTicks(824), "1,2,4", 11, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2020, 2, 9, 4, 44, 41, 597, DateTimeKind.Local).AddTicks(4628), "1,3,5", 9, 3, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2019, 11, 10, 9, 35, 29, 843, DateTimeKind.Local).AddTicks(37), "0,2,5", 8, 6, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2019, 9, 13, 18, 58, 20, 425, DateTimeKind.Local).AddTicks(9695), "1,3,4", 7, 3, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2020, 8, 26, 7, 57, 21, 803, DateTimeKind.Local).AddTicks(6445), "1,3,4", 6, 4, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2019, 12, 12, 22, 43, 38, 464, DateTimeKind.Local).AddTicks(1801), "1,3,5", 5, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2020, 8, 7, 12, 1, 37, 532, DateTimeKind.Local).AddTicks(436), "0,2,5", 4, 2, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2019, 10, 11, 1, 26, 25, 619, DateTimeKind.Local).AddTicks(526), "0,2,5", 3, 2, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2020, 8, 7, 7, 50, 29, 325, DateTimeKind.Local).AddTicks(2942), "0,3,6", 2, 6, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2020, 6, 29, 5, 58, 13, 866, DateTimeKind.Local).AddTicks(4370), "0,2,5", 1, 2, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2020, 5, 1, 23, 4, 13, 274, DateTimeKind.Local).AddTicks(5361), "1,3,6", 50, 5, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2019, 12, 17, 10, 35, 35, 245, DateTimeKind.Local).AddTicks(7388), "0,3,5", 10, 4, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2020, 8, 5, 10, 6, 31, 167, DateTimeKind.Local).AddTicks(6845), "0,3,4", 24, 5, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2020, 3, 25, 3, 8, 33, 58, DateTimeKind.Local).AddTicks(9239), "1,3,4", 16, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2020, 8, 21, 11, 49, 55, 941, DateTimeKind.Local).AddTicks(5963), "1,3,4", 26, 3, "Nouveau traité a été ajoutée", 4, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2020, 7, 14, 13, 47, 49, 930, DateTimeKind.Local).AddTicks(3472), "0,3,4", 48, 6, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2020, 3, 26, 11, 6, 10, 496, DateTimeKind.Local).AddTicks(86), "1,2,4", 47, 1, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2019, 9, 17, 0, 20, 7, 643, DateTimeKind.Local).AddTicks(5587), "1,3,5", 46, 2, "Nouveau synthèse a été ajoutée", 2, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2020, 2, 1, 17, 14, 58, 518, DateTimeKind.Local).AddTicks(9042), "0,2,6", 25, 6, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2020, 2, 21, 9, 52, 43, 859, DateTimeKind.Local).AddTicks(1158), "1,3,5", 44, 6, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2020, 4, 30, 7, 51, 59, 624, DateTimeKind.Local).AddTicks(7785), "1,2,5", 43, 5, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2019, 11, 23, 18, 2, 10, 627, DateTimeKind.Local).AddTicks(7846), "1,2,6", 42, 1, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2019, 11, 16, 0, 51, 9, 182, DateTimeKind.Local).AddTicks(5271), "0,2,5", 41, 4, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2019, 9, 25, 0, 49, 49, 698, DateTimeKind.Local).AddTicks(7498), "0,2,5", 40, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2020, 6, 27, 23, 45, 14, 443, DateTimeKind.Local).AddTicks(2035), "0,3,6", 39, 6, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2019, 11, 17, 21, 18, 35, 409, DateTimeKind.Local).AddTicks(7349), "0,2,4", 38, 3, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2020, 1, 20, 9, 54, 36, 52, DateTimeKind.Local).AddTicks(4321), "1,3,5", 37, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2019, 10, 31, 18, 2, 12, 588, DateTimeKind.Local).AddTicks(3856), "1,2,5", 45, 5, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2019, 11, 7, 11, 17, 45, 593, DateTimeKind.Local).AddTicks(1037), "0,2,4", 35, 5, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2020, 6, 2, 14, 25, 19, 130, DateTimeKind.Local).AddTicks(7012), "1,2,4", 34, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2020, 7, 10, 20, 32, 22, 742, DateTimeKind.Local).AddTicks(4955), "1,2,4", 33, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2020, 4, 10, 17, 36, 1, 120, DateTimeKind.Local).AddTicks(9882), "1,3,5", 27, 3, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2020, 8, 6, 21, 44, 0, 892, DateTimeKind.Local).AddTicks(1473), "0,3,5", 32, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2020, 8, 9, 14, 52, 13, 545, DateTimeKind.Local).AddTicks(2807), "0,3,5", 31, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2020, 6, 19, 6, 37, 49, 249, DateTimeKind.Local).AddTicks(764), "1,3,4", 30, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2019, 12, 18, 22, 32, 29, 700, DateTimeKind.Local).AddTicks(4307), "0,2,6", 29, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2020, 5, 19, 19, 55, 31, 502, DateTimeKind.Local).AddTicks(5068), "0,2,4", 28, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2019, 11, 5, 13, 0, 55, 403, DateTimeKind.Local).AddTicks(9101), "0,3,5", 36, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

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
                values: new object[] { 14, 2020, "", "sous theme 14", "Droits catégoriels" });

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
                values: new object[] { 10, 2020, "", "sous theme 10", "Droits thématiques" });

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
                values: new object[] { 3, 2020, "", "sous theme 3", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 2, 2020, "", "sous theme 2", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 1, 2020, "", "sous theme 1", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 66, "", "", new DateTime(2020, 7, 7, 9, 19, 58, 624, DateTimeKind.Local).AddTicks(9841), new DateTime(2020, 3, 29, 5, 53, 19, 396, DateTimeKind.Local).AddTicks(3160), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 67, "", "", new DateTime(2019, 12, 14, 5, 21, 28, 649, DateTimeKind.Local).AddTicks(5679), new DateTime(2019, 12, 11, 0, 27, 46, 496, DateTimeKind.Local).AddTicks(3803), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 68, "", "", new DateTime(2019, 10, 24, 23, 23, 8, 580, DateTimeKind.Local).AddTicks(6191), new DateTime(2020, 5, 15, 5, 52, 17, 712, DateTimeKind.Local).AddTicks(6836), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 69, "", "", new DateTime(2019, 11, 9, 3, 21, 1, 974, DateTimeKind.Local).AddTicks(9020), new DateTime(2020, 9, 7, 23, 12, 39, 690, DateTimeKind.Local).AddTicks(5679), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 72, "", "", new DateTime(2019, 9, 12, 2, 44, 16, 212, DateTimeKind.Local).AddTicks(110), new DateTime(2020, 9, 3, 3, 31, 50, 686, DateTimeKind.Local).AddTicks(2096), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 71, "", "", new DateTime(2019, 11, 29, 1, 28, 22, 973, DateTimeKind.Local).AddTicks(4590), new DateTime(2019, 9, 23, 0, 24, 12, 198, DateTimeKind.Local).AddTicks(9709), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 65, "", "", new DateTime(2019, 9, 15, 11, 23, 38, 937, DateTimeKind.Local).AddTicks(226), new DateTime(2020, 8, 22, 0, 50, 14, 365, DateTimeKind.Local).AddTicks(8353), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 73, "", "", new DateTime(2019, 10, 17, 20, 14, 48, 196, DateTimeKind.Local).AddTicks(5648), new DateTime(2020, 7, 30, 3, 54, 23, 443, DateTimeKind.Local).AddTicks(8296), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 74, "", "", new DateTime(2020, 2, 7, 15, 46, 59, 456, DateTimeKind.Local).AddTicks(7184), new DateTime(2020, 8, 5, 18, 3, 44, 931, DateTimeKind.Local).AddTicks(5876), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 70, "", "", new DateTime(2020, 5, 6, 11, 32, 27, 987, DateTimeKind.Local).AddTicks(3820), new DateTime(2019, 12, 31, 12, 36, 33, 339, DateTimeKind.Local).AddTicks(1677), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 64, "", "", new DateTime(2020, 3, 22, 10, 34, 14, 810, DateTimeKind.Local).AddTicks(3106), new DateTime(2020, 1, 25, 11, 5, 8, 781, DateTimeKind.Local).AddTicks(641), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 62, "", "", new DateTime(2020, 4, 14, 18, 55, 53, 348, DateTimeKind.Local).AddTicks(1348), new DateTime(2020, 6, 5, 14, 0, 48, 833, DateTimeKind.Local).AddTicks(121), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 53, "", "", new DateTime(2020, 1, 17, 20, 22, 21, 727, DateTimeKind.Local).AddTicks(1222), new DateTime(2019, 9, 21, 4, 15, 46, 123, DateTimeKind.Local).AddTicks(4205), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 61, "", "", new DateTime(2020, 1, 2, 1, 31, 31, 922, DateTimeKind.Local).AddTicks(1483), new DateTime(2019, 9, 20, 20, 44, 34, 521, DateTimeKind.Local).AddTicks(7846), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 60, "", "", new DateTime(2020, 1, 6, 6, 2, 20, 663, DateTimeKind.Local).AddTicks(7945), new DateTime(2019, 12, 16, 3, 49, 11, 567, DateTimeKind.Local).AddTicks(3534), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 59, "", "", new DateTime(2020, 1, 27, 23, 54, 58, 78, DateTimeKind.Local).AddTicks(2951), new DateTime(2019, 9, 23, 16, 9, 30, 949, DateTimeKind.Local).AddTicks(3741), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 58, "", "", new DateTime(2019, 10, 11, 20, 52, 28, 223, DateTimeKind.Local).AddTicks(3796), new DateTime(2020, 8, 15, 9, 2, 48, 238, DateTimeKind.Local).AddTicks(6248), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 57, "", "", new DateTime(2019, 12, 24, 22, 24, 53, 859, DateTimeKind.Local).AddTicks(3656), new DateTime(2020, 6, 25, 7, 16, 49, 350, DateTimeKind.Local).AddTicks(1195), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 56, "", "", new DateTime(2020, 5, 7, 7, 33, 48, 331, DateTimeKind.Local).AddTicks(9597), new DateTime(2019, 10, 10, 22, 37, 13, 444, DateTimeKind.Local).AddTicks(6120), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 55, "", "", new DateTime(2020, 3, 2, 12, 46, 5, 655, DateTimeKind.Local).AddTicks(3211), new DateTime(2020, 8, 2, 7, 4, 24, 395, DateTimeKind.Local).AddTicks(4794), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 54, "", "", new DateTime(2019, 12, 24, 18, 59, 11, 472, DateTimeKind.Local).AddTicks(7147), new DateTime(2020, 1, 1, 21, 50, 17, 731, DateTimeKind.Local).AddTicks(4987), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 75, "", "", new DateTime(2020, 7, 25, 20, 28, 3, 398, DateTimeKind.Local).AddTicks(2869), new DateTime(2020, 6, 14, 21, 54, 50, 185, DateTimeKind.Local).AddTicks(6982), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 63, "", "", new DateTime(2020, 6, 12, 23, 34, 14, 537, DateTimeKind.Local).AddTicks(153), new DateTime(2019, 9, 19, 19, 10, 32, 714, DateTimeKind.Local).AddTicks(6791), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 76, "", "", new DateTime(2019, 12, 4, 5, 20, 49, 385, DateTimeKind.Local).AddTicks(7293), new DateTime(2019, 10, 7, 19, 33, 0, 423, DateTimeKind.Local).AddTicks(3), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 91, "", "", new DateTime(2020, 8, 16, 20, 17, 37, 535, DateTimeKind.Local).AddTicks(2561), new DateTime(2020, 4, 6, 22, 31, 15, 872, DateTimeKind.Local).AddTicks(4559), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 78, "", "", new DateTime(2020, 2, 4, 11, 57, 59, 871, DateTimeKind.Local).AddTicks(7311), new DateTime(2019, 10, 4, 10, 45, 3, 150, DateTimeKind.Local).AddTicks(8699), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 52, "", "", new DateTime(2020, 5, 18, 2, 27, 20, 281, DateTimeKind.Local).AddTicks(8196), new DateTime(2020, 6, 29, 13, 20, 19, 111, DateTimeKind.Local).AddTicks(6955), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 100, "", "", new DateTime(2020, 9, 2, 4, 40, 47, 761, DateTimeKind.Local).AddTicks(9412), new DateTime(2020, 2, 17, 5, 34, 28, 49, DateTimeKind.Local).AddTicks(3641), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 99, "", "", new DateTime(2020, 7, 8, 21, 12, 41, 10, DateTimeKind.Local).AddTicks(5198), new DateTime(2020, 1, 11, 9, 29, 30, 353, DateTimeKind.Local).AddTicks(6072), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 98, "", "", new DateTime(2020, 2, 17, 16, 59, 0, 418, DateTimeKind.Local).AddTicks(7590), new DateTime(2020, 3, 21, 12, 44, 48, 517, DateTimeKind.Local).AddTicks(5321), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 97, "", "", new DateTime(2020, 5, 12, 7, 1, 34, 642, DateTimeKind.Local).AddTicks(8237), new DateTime(2020, 6, 25, 16, 48, 22, 798, DateTimeKind.Local).AddTicks(1979), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 96, "", "", new DateTime(2020, 7, 8, 18, 21, 26, 737, DateTimeKind.Local).AddTicks(2149), new DateTime(2019, 10, 29, 12, 19, 35, 16, DateTimeKind.Local).AddTicks(2658), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 95, "", "", new DateTime(2019, 9, 16, 20, 58, 21, 329, DateTimeKind.Local).AddTicks(8072), new DateTime(2019, 10, 6, 18, 9, 52, 713, DateTimeKind.Local).AddTicks(9422), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 94, "", "", new DateTime(2019, 10, 8, 19, 34, 55, 123, DateTimeKind.Local).AddTicks(6054), new DateTime(2020, 6, 11, 7, 4, 19, 997, DateTimeKind.Local).AddTicks(1471), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 93, "", "", new DateTime(2020, 1, 13, 6, 56, 52, 491, DateTimeKind.Local).AddTicks(649), new DateTime(2019, 11, 8, 14, 3, 9, 876, DateTimeKind.Local).AddTicks(3027), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 92, "", "", new DateTime(2020, 2, 10, 12, 19, 37, 556, DateTimeKind.Local).AddTicks(6664), new DateTime(2020, 2, 7, 12, 0, 40, 746, DateTimeKind.Local).AddTicks(2961), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 77, "", "", new DateTime(2019, 12, 22, 20, 0, 14, 653, DateTimeKind.Local).AddTicks(9277), new DateTime(2020, 4, 3, 0, 39, 10, 589, DateTimeKind.Local).AddTicks(9543), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 90, "", "", new DateTime(2020, 6, 12, 7, 9, 20, 619, DateTimeKind.Local).AddTicks(7372), new DateTime(2019, 9, 12, 12, 35, 37, 639, DateTimeKind.Local).AddTicks(6106), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 88, "", "", new DateTime(2020, 5, 12, 14, 25, 10, 628, DateTimeKind.Local).AddTicks(1014), new DateTime(2020, 1, 25, 1, 36, 24, 469, DateTimeKind.Local).AddTicks(974), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 87, "", "", new DateTime(2019, 9, 13, 5, 7, 6, 77, DateTimeKind.Local).AddTicks(8631), new DateTime(2020, 8, 17, 8, 4, 23, 724, DateTimeKind.Local).AddTicks(8159), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 86, "", "", new DateTime(2019, 11, 27, 17, 28, 38, 45, DateTimeKind.Local).AddTicks(4889), new DateTime(2019, 12, 11, 12, 59, 16, 317, DateTimeKind.Local).AddTicks(9754), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 85, "", "", new DateTime(2019, 12, 18, 9, 42, 35, 991, DateTimeKind.Local).AddTicks(1085), new DateTime(2020, 7, 17, 23, 38, 40, 328, DateTimeKind.Local).AddTicks(4927), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 84, "", "", new DateTime(2019, 11, 27, 11, 54, 33, 75, DateTimeKind.Local).AddTicks(6288), new DateTime(2020, 5, 31, 23, 9, 21, 564, DateTimeKind.Local).AddTicks(625), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 83, "", "", new DateTime(2020, 3, 5, 8, 20, 40, 524, DateTimeKind.Local).AddTicks(2254), new DateTime(2019, 9, 14, 18, 43, 33, 860, DateTimeKind.Local).AddTicks(6548), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 82, "", "", new DateTime(2020, 5, 28, 16, 29, 4, 657, DateTimeKind.Local).AddTicks(6274), new DateTime(2020, 1, 3, 19, 10, 2, 972, DateTimeKind.Local).AddTicks(4948), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 81, "", "", new DateTime(2019, 9, 11, 13, 50, 29, 846, DateTimeKind.Local).AddTicks(655), new DateTime(2019, 10, 18, 22, 5, 57, 685, DateTimeKind.Local).AddTicks(2765), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 80, "", "", new DateTime(2020, 3, 23, 7, 47, 43, 459, DateTimeKind.Local).AddTicks(7520), new DateTime(2020, 2, 16, 1, 39, 2, 508, DateTimeKind.Local).AddTicks(8760), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 79, "", "", new DateTime(2020, 9, 11, 0, 12, 49, 708, DateTimeKind.Local).AddTicks(436), new DateTime(2019, 11, 19, 12, 12, 34, 478, DateTimeKind.Local).AddTicks(1724), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 89, "", "", new DateTime(2019, 12, 21, 20, 58, 47, 743, DateTimeKind.Local).AddTicks(9066), new DateTime(2020, 7, 5, 23, 34, 34, 237, DateTimeKind.Local).AddTicks(3712), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 51, "", "", new DateTime(2019, 10, 8, 10, 0, 56, 778, DateTimeKind.Local).AddTicks(3043), new DateTime(2020, 4, 8, 21, 36, 21, 604, DateTimeKind.Local).AddTicks(8728), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 8, "", "", new DateTime(2020, 7, 10, 2, 36, 3, 371, DateTimeKind.Local).AddTicks(1170), new DateTime(2020, 7, 31, 8, 4, 36, 994, DateTimeKind.Local).AddTicks(1924), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 49, "", "", new DateTime(2020, 8, 5, 21, 57, 23, 692, DateTimeKind.Local).AddTicks(6968), new DateTime(2020, 1, 17, 9, 28, 21, 85, DateTimeKind.Local).AddTicks(3908), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 22, "", "", new DateTime(2020, 5, 11, 10, 56, 2, 581, DateTimeKind.Local).AddTicks(4975), new DateTime(2020, 1, 6, 21, 18, 9, 313, DateTimeKind.Local).AddTicks(298), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 21, "", "", new DateTime(2019, 11, 26, 13, 42, 59, 175, DateTimeKind.Local).AddTicks(7736), new DateTime(2020, 3, 24, 4, 54, 53, 858, DateTimeKind.Local).AddTicks(7059), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 20, "", "", new DateTime(2020, 6, 9, 21, 39, 54, 977, DateTimeKind.Local).AddTicks(4431), new DateTime(2020, 4, 17, 13, 43, 7, 21, DateTimeKind.Local).AddTicks(9994), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 19, "", "", new DateTime(2019, 12, 7, 2, 2, 47, 768, DateTimeKind.Local).AddTicks(6633), new DateTime(2020, 9, 10, 9, 9, 32, 108, DateTimeKind.Local).AddTicks(4119), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 18, "", "", new DateTime(2019, 10, 9, 9, 2, 39, 341, DateTimeKind.Local).AddTicks(3486), new DateTime(2020, 1, 2, 3, 13, 30, 310, DateTimeKind.Local).AddTicks(4493), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 17, "", "", new DateTime(2020, 5, 2, 17, 58, 37, 738, DateTimeKind.Local).AddTicks(9726), new DateTime(2020, 8, 11, 8, 40, 50, 831, DateTimeKind.Local).AddTicks(8089), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 16, "", "", new DateTime(2020, 1, 11, 3, 16, 8, 78, DateTimeKind.Local).AddTicks(6944), new DateTime(2019, 11, 27, 18, 13, 17, 465, DateTimeKind.Local).AddTicks(804), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 15, "", "", new DateTime(2020, 5, 9, 4, 50, 48, 515, DateTimeKind.Local).AddTicks(7597), new DateTime(2019, 12, 12, 1, 56, 37, 790, DateTimeKind.Local).AddTicks(5049), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 14, "", "", new DateTime(2020, 4, 14, 11, 53, 53, 337, DateTimeKind.Local).AddTicks(9301), new DateTime(2020, 8, 31, 10, 39, 15, 682, DateTimeKind.Local).AddTicks(300), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 13, "", "", new DateTime(2020, 7, 10, 21, 49, 49, 977, DateTimeKind.Local).AddTicks(6762), new DateTime(2020, 2, 8, 20, 42, 43, 715, DateTimeKind.Local).AddTicks(9885), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 12, "", "", new DateTime(2020, 7, 11, 21, 17, 28, 624, DateTimeKind.Local).AddTicks(9785), new DateTime(2020, 6, 2, 22, 22, 50, 784, DateTimeKind.Local).AddTicks(8772), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 11, "", "", new DateTime(2019, 11, 5, 8, 1, 18, 189, DateTimeKind.Local).AddTicks(4368), new DateTime(2019, 9, 21, 0, 34, 42, 858, DateTimeKind.Local).AddTicks(9639), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 10, "", "", new DateTime(2020, 7, 3, 7, 1, 44, 283, DateTimeKind.Local).AddTicks(3726), new DateTime(2019, 11, 24, 12, 2, 46, 917, DateTimeKind.Local).AddTicks(5749), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 9, "", "", new DateTime(2019, 10, 10, 8, 4, 16, 573, DateTimeKind.Local).AddTicks(8244), new DateTime(2020, 8, 12, 5, 8, 43, 736, DateTimeKind.Local).AddTicks(2810), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 7, "", "", new DateTime(2019, 11, 23, 6, 13, 2, 746, DateTimeKind.Local).AddTicks(5724), new DateTime(2019, 11, 28, 20, 17, 0, 846, DateTimeKind.Local).AddTicks(3841), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 6, "", "", new DateTime(2020, 5, 19, 16, 45, 37, 157, DateTimeKind.Local).AddTicks(3398), new DateTime(2019, 11, 26, 22, 31, 33, 98, DateTimeKind.Local).AddTicks(8820), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 5, "", "", new DateTime(2019, 10, 3, 5, 50, 16, 922, DateTimeKind.Local).AddTicks(1153), new DateTime(2020, 4, 23, 17, 14, 22, 452, DateTimeKind.Local).AddTicks(1064), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 4, "", "", new DateTime(2020, 3, 1, 19, 15, 16, 367, DateTimeKind.Local).AddTicks(8235), new DateTime(2020, 6, 29, 2, 32, 18, 3, DateTimeKind.Local).AddTicks(5603), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 3, "", "", new DateTime(2020, 1, 14, 1, 52, 27, 7, DateTimeKind.Local).AddTicks(4354), new DateTime(2020, 5, 4, 14, 4, 23, 675, DateTimeKind.Local).AddTicks(5863), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 2, "", "", new DateTime(2020, 5, 16, 11, 43, 12, 461, DateTimeKind.Local).AddTicks(1806), new DateTime(2019, 10, 30, 0, 35, 56, 460, DateTimeKind.Local).AddTicks(8580), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 50, "", "", new DateTime(2020, 8, 27, 18, 13, 0, 436, DateTimeKind.Local).AddTicks(4059), new DateTime(2019, 11, 25, 22, 31, 24, 862, DateTimeKind.Local).AddTicks(3948), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 23, "", "", new DateTime(2019, 11, 6, 8, 58, 4, 251, DateTimeKind.Local).AddTicks(683), new DateTime(2019, 12, 3, 18, 36, 59, 431, DateTimeKind.Local).AddTicks(7798), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 24, "", "", new DateTime(2020, 6, 12, 23, 54, 50, 285, DateTimeKind.Local).AddTicks(4989), new DateTime(2020, 7, 21, 4, 59, 58, 314, DateTimeKind.Local).AddTicks(3067), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 1, "", "", new DateTime(2020, 7, 9, 1, 41, 24, 343, DateTimeKind.Local).AddTicks(8856), new DateTime(2020, 1, 1, 4, 15, 9, 234, DateTimeKind.Local).AddTicks(612), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 26, "", "", new DateTime(2020, 8, 26, 0, 8, 4, 824, DateTimeKind.Local).AddTicks(181), new DateTime(2019, 11, 12, 7, 49, 25, 990, DateTimeKind.Local).AddTicks(3), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 25, "", "", new DateTime(2020, 7, 26, 8, 28, 32, 879, DateTimeKind.Local).AddTicks(9070), new DateTime(2020, 4, 21, 4, 23, 20, 543, DateTimeKind.Local).AddTicks(2855), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 47, "", "", new DateTime(2019, 12, 4, 9, 45, 14, 702, DateTimeKind.Local).AddTicks(9068), new DateTime(2020, 6, 30, 0, 46, 22, 881, DateTimeKind.Local).AddTicks(1983), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 46, "", "", new DateTime(2020, 6, 1, 21, 23, 19, 372, DateTimeKind.Local).AddTicks(5431), new DateTime(2019, 12, 20, 2, 58, 50, 68, DateTimeKind.Local).AddTicks(699), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 45, "", "", new DateTime(2020, 5, 26, 11, 33, 41, 860, DateTimeKind.Local).AddTicks(8555), new DateTime(2019, 12, 20, 16, 56, 0, 796, DateTimeKind.Local).AddTicks(13), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 44, "", "", new DateTime(2020, 7, 2, 13, 57, 34, 475, DateTimeKind.Local).AddTicks(6732), new DateTime(2019, 12, 2, 13, 56, 13, 681, DateTimeKind.Local).AddTicks(5429), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 43, "", "", new DateTime(2020, 9, 6, 4, 53, 23, 823, DateTimeKind.Local).AddTicks(5475), new DateTime(2019, 11, 7, 11, 29, 32, 698, DateTimeKind.Local).AddTicks(7790), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 42, "", "", new DateTime(2019, 11, 9, 15, 42, 24, 125, DateTimeKind.Local).AddTicks(4071), new DateTime(2020, 4, 24, 10, 28, 7, 298, DateTimeKind.Local).AddTicks(5699), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 41, "", "", new DateTime(2019, 9, 30, 14, 40, 33, 730, DateTimeKind.Local).AddTicks(7249), new DateTime(2019, 11, 1, 18, 22, 13, 969, DateTimeKind.Local).AddTicks(4328), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 40, "", "", new DateTime(2019, 11, 7, 8, 43, 51, 806, DateTimeKind.Local).AddTicks(8886), new DateTime(2020, 4, 7, 13, 38, 31, 549, DateTimeKind.Local).AddTicks(1824), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 39, "", "", new DateTime(2020, 3, 15, 18, 35, 57, 588, DateTimeKind.Local).AddTicks(195), new DateTime(2020, 6, 10, 20, 58, 32, 262, DateTimeKind.Local).AddTicks(8053), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 38, "", "", new DateTime(2020, 6, 25, 0, 6, 44, 170, DateTimeKind.Local).AddTicks(8244), new DateTime(2020, 4, 25, 6, 55, 34, 742, DateTimeKind.Local).AddTicks(9507), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 48, "", "", new DateTime(2019, 9, 18, 8, 35, 13, 915, DateTimeKind.Local).AddTicks(9939), new DateTime(2020, 1, 4, 23, 46, 24, 814, DateTimeKind.Local).AddTicks(4122), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 36, "", "", new DateTime(2019, 12, 27, 16, 39, 30, 420, DateTimeKind.Local).AddTicks(4030), new DateTime(2019, 11, 25, 10, 38, 17, 596, DateTimeKind.Local).AddTicks(847), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 27, "", "", new DateTime(2019, 10, 27, 0, 48, 31, 369, DateTimeKind.Local).AddTicks(1355), new DateTime(2020, 6, 10, 14, 52, 19, 629, DateTimeKind.Local).AddTicks(7730), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 37, "", "", new DateTime(2020, 5, 23, 10, 57, 47, 736, DateTimeKind.Local).AddTicks(5096), new DateTime(2019, 12, 23, 11, 58, 54, 79, DateTimeKind.Local).AddTicks(2883), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 29, "", "", new DateTime(2019, 10, 15, 7, 21, 42, 166, DateTimeKind.Local).AddTicks(9582), new DateTime(2019, 10, 8, 9, 2, 49, 982, DateTimeKind.Local).AddTicks(7313), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 30, "", "", new DateTime(2019, 9, 16, 0, 40, 1, 416, DateTimeKind.Local).AddTicks(2787), new DateTime(2020, 4, 16, 5, 18, 51, 990, DateTimeKind.Local).AddTicks(9584), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 31, "", "", new DateTime(2019, 10, 30, 23, 30, 54, 121, DateTimeKind.Local).AddTicks(5721), new DateTime(2019, 10, 12, 10, 14, 6, 134, DateTimeKind.Local).AddTicks(8761), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 28, "", "", new DateTime(2020, 2, 27, 2, 48, 38, 47, DateTimeKind.Local).AddTicks(6113), new DateTime(2019, 11, 11, 23, 7, 17, 679, DateTimeKind.Local).AddTicks(431), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 33, "", "", new DateTime(2020, 6, 4, 20, 16, 2, 277, DateTimeKind.Local).AddTicks(1182), new DateTime(2020, 9, 9, 3, 58, 57, 68, DateTimeKind.Local).AddTicks(9053), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 34, "", "", new DateTime(2020, 7, 18, 17, 56, 41, 707, DateTimeKind.Local).AddTicks(7773), new DateTime(2019, 11, 16, 4, 22, 14, 962, DateTimeKind.Local).AddTicks(2692), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 35, "", "", new DateTime(2019, 11, 19, 9, 53, 59, 114, DateTimeKind.Local).AddTicks(1845), new DateTime(2020, 8, 1, 4, 7, 58, 588, DateTimeKind.Local).AddTicks(1168), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 32, "", "", new DateTime(2020, 5, 30, 7, 3, 11, 315, DateTimeKind.Local).AddTicks(7712), new DateTime(2020, 1, 29, 8, 15, 5, 296, DateTimeKind.Local).AddTicks(7996), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 65, new DateTime(2019, 9, 30, 17, 44, 54, 120, DateTimeKind.Local).AddTicks(2611), "Impedit omnis laboriosam dolorem sunt quas. Incidunt animi nihil ullam sint. Unde distinctio ut officia beatae et omnis corrupti enim. Inventore ut qui officia ad est sint. Soluta sequi eius est. Placeat officiis tempora voluptatibus unde.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 72, new DateTime(2020, 4, 26, 8, 17, 18, 846, DateTimeKind.Local).AddTicks(2221), "Itaque ipsam id consequatur omnis in omnis enim molestiae eius. Quisquam minus sunt et deserunt qui vel perspiciatis tenetur. Rerum omnis voluptas error consectetur aperiam magni deserunt repellat. Placeat aliquid aliquam.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 71, new DateTime(2020, 8, 24, 23, 56, 27, 844, DateTimeKind.Local).AddTicks(4105), "Et molestiae atque dolores in optio temporibus inventore praesentium amet. Sed odio hic aut et. Libero saepe inventore est totam corrupti ipsum qui. Ratione non ullam voluptatem omnis sequi libero. Eius iusto eligendi illo ad excepturi sint expedita. Ut et harum accusantium tenetur dolor dolorem iste.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 70, new DateTime(2020, 4, 6, 2, 51, 7, 636, DateTimeKind.Local).AddTicks(8181), "Facilis optio est. Quia consectetur cum non corporis quo dolorem qui maiores. Totam et amet dolor.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 69, new DateTime(2020, 8, 13, 14, 35, 54, 169, DateTimeKind.Local).AddTicks(2115), "Vel laudantium sit dolores animi officiis temporibus quo ut. Commodi quia quidem. Sequi error inventore ab.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 68, new DateTime(2019, 12, 12, 21, 10, 11, 958, DateTimeKind.Local).AddTicks(7851), "Laborum quia est repudiandae. Iste blanditiis et reprehenderit ut qui maiores asperiores. Molestias illum necessitatibus dolores a atque pariatur reiciendis. Qui ut animi. Inventore sunt eaque omnis quae laboriosam ullam. Facilis rerum cumque.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 67, new DateTime(2020, 3, 19, 17, 59, 35, 878, DateTimeKind.Local).AddTicks(7860), "Nesciunt incidunt aliquam ipsum totam qui voluptatum et quas. Voluptatem quia quidem sit. Inventore excepturi minus qui iusto dolor. Quaerat aut amet rem soluta ut dolore laborum sed. Quidem repellendus quia aliquid est. Magni ipsam vel est.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 66, new DateTime(2020, 4, 20, 22, 25, 25, 527, DateTimeKind.Local).AddTicks(8681), "Eaque et pariatur sit sed quis pariatur. Doloribus iusto sequi minima deleniti facere sint ipsa molestias nobis. Et commodi culpa eos suscipit animi quo. Tempore incidunt qui voluptas ut consequatur quibusdam dolor libero.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 64, new DateTime(2020, 4, 30, 1, 2, 25, 424, DateTimeKind.Local).AddTicks(325), "Voluptatibus laborum velit nam inventore repellendus in eaque perspiciatis. Molestiae optio qui aut. Cumque et corrupti. Doloribus unde ea omnis veritatis voluptas totam excepturi cum.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 53, new DateTime(2019, 12, 31, 12, 28, 26, 964, DateTimeKind.Local).AddTicks(2230), "Fuga sit et voluptates vel illum expedita assumenda eos ut. Minus vitae eaque placeat numquam qui quo aperiam nihil est. Blanditiis delectus atque et officiis. Est consequatur deserunt fuga dolor reprehenderit delectus. Sed aliquid possimus voluptas asperiores quaerat blanditiis nihil cumque esse.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 62, new DateTime(2020, 3, 29, 18, 54, 0, 342, DateTimeKind.Local).AddTicks(7546), "Ipsa enim dolor. Officiis et totam tempora. Adipisci et aut aut deserunt facilis repudiandae alias voluptatum veritatis.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 61, new DateTime(2020, 8, 28, 4, 30, 7, 910, DateTimeKind.Local).AddTicks(2130), "Quo aut ipsam amet veniam. Accusamus nostrum et doloribus sed quos omnis delectus sunt. Hic libero consequatur. Laudantium non harum dicta ad sunt qui assumenda. Et ut quis quos quis. Culpa rerum nesciunt quo doloremque inventore sed ut deserunt voluptatem.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 60, new DateTime(2019, 9, 18, 4, 37, 13, 739, DateTimeKind.Local).AddTicks(7683), "Iure nihil assumenda ipsa ullam autem sequi rerum nostrum. Numquam odio alias saepe ad alias laudantium est voluptas. Ex fuga quod soluta tenetur ut. Repellendus non eum. Qui aliquid qui et dolores ut sit.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 59, new DateTime(2019, 10, 20, 5, 43, 7, 3, DateTimeKind.Local).AddTicks(2198), "Aut consequatur eligendi. Aut quod vero magnam vel asperiores nihil ut ullam vel. Qui corrupti eveniet doloribus in consectetur quo consequatur tempora. Est corporis quas et rerum. Facere consectetur dolor doloremque officiis.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 58, new DateTime(2020, 8, 1, 8, 36, 39, 513, DateTimeKind.Local).AddTicks(1518), "Natus a soluta doloremque voluptas. Consequatur minima dolorem et assumenda. Dolores et enim rerum et non molestiae sit assumenda quaerat. Debitis ducimus quo esse. Nihil quidem vitae voluptas placeat voluptas. Ut dignissimos officiis.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 57, new DateTime(2020, 5, 20, 17, 27, 8, 972, DateTimeKind.Local).AddTicks(1857), "Occaecati velit quasi voluptate unde. Voluptatibus et dolorem quia et sed sint eum reprehenderit. Reprehenderit qui sit quidem voluptatem et molestiae. Et et molestiae. Vero voluptates doloremque est libero beatae delectus perferendis aut.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 56, new DateTime(2020, 5, 19, 10, 32, 19, 510, DateTimeKind.Local).AddTicks(8025), "Molestias sunt eum illo blanditiis inventore. Consequuntur natus facilis consequuntur ut est veniam consequatur corrupti. Officiis nesciunt vero ad. Itaque qui magni sit voluptatem et cumque omnis repellendus.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 55, new DateTime(2020, 4, 24, 20, 21, 54, 834, DateTimeKind.Local).AddTicks(4916), "Laudantium in fuga voluptatem aliquam esse. Accusantium est quo omnis. Sunt commodi dolorem assumenda error velit quia. Ut magnam cupiditate laudantium voluptate voluptatibus. Enim exercitationem occaecati vel in quis officiis.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 54, new DateTime(2020, 7, 23, 14, 33, 5, 766, DateTimeKind.Local).AddTicks(8314), "Nostrum numquam beatae tempora ea natus quo molestiae rerum rerum. Quia ab cum. Tenetur est quasi quibusdam soluta. Vitae consectetur et sint consequatur doloremque. Et omnis quia sint quo. Ullam voluptate cumque dolorem est reprehenderit cumque molestiae consequatur eveniet.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 73, new DateTime(2020, 2, 1, 17, 24, 19, 804, DateTimeKind.Local).AddTicks(2840), "Itaque eveniet reprehenderit fugit in omnis corporis modi id et. Consequatur nam quis velit velit doloribus voluptas aut et ea. Et porro molestiae aut quia consequatur voluptatum. Perspiciatis ad molestiae.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 52, new DateTime(2020, 7, 26, 8, 0, 19, 485, DateTimeKind.Local).AddTicks(5927), "Dicta voluptate optio architecto et qui ratione. Harum aperiam est eum et sint quisquam. Minima reprehenderit deserunt delectus suscipit voluptatem similique distinctio est. Voluptatem eligendi harum. Ipsum minus consequatur voluptatem.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 63, new DateTime(2020, 7, 21, 17, 27, 32, 873, DateTimeKind.Local).AddTicks(9671), "Et molestiae eos eaque itaque. Illo aut fuga. Laborum aperiam quas laboriosam. Ad aut velit dolore facilis esse. Non possimus hic ut ut error odit harum rerum magnam. Odio et rerum voluptas et quis.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 74, new DateTime(2020, 1, 30, 12, 36, 1, 127, DateTimeKind.Local).AddTicks(3948), "Voluptatem alias quaerat ut molestiae necessitatibus harum harum odio. Earum inventore excepturi laborum nisi modi. Reprehenderit ut cum est nostrum rerum itaque. Provident optio nobis odio dolore voluptas aliquid dolorem.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 85, new DateTime(2019, 12, 25, 9, 54, 41, 178, DateTimeKind.Local).AddTicks(6878), "Facere sequi voluptatem. Quia doloribus maiores blanditiis consequatur. Numquam numquam qui eligendi voluptates natus neque fugiat maxime.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 76, new DateTime(2019, 11, 18, 5, 41, 14, 824, DateTimeKind.Local).AddTicks(2668), "Molestias voluptas ut voluptas facere id et unde natus magni. Facere id expedita. Eius omnis eos est. Magni quo amet quia recusandae iste. Est itaque voluptatem odit magnam et.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 98, new DateTime(2020, 6, 26, 7, 15, 56, 201, DateTimeKind.Local).AddTicks(3391), "Aspernatur iure rem. Quaerat et harum sapiente molestiae accusantium eos officia. Explicabo asperiores incidunt consequuntur inventore sit esse placeat. Et repellendus eum ipsum. Dolorem veniam et. Officia sint tempora.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 51, new DateTime(2020, 3, 22, 2, 21, 3, 324, DateTimeKind.Local).AddTicks(9037), "At adipisci quibusdam magni minus consequatur quam dicta eligendi. Eligendi soluta dignissimos dolorem facilis commodi cupiditate. Temporibus sed rerum sunt et quia neque in. Pariatur nihil ipsa similique autem doloribus consequatur.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 97, new DateTime(2019, 10, 3, 21, 1, 56, 629, DateTimeKind.Local).AddTicks(5867), "Voluptas placeat nobis expedita culpa cum et dolorem doloribus. Veritatis repellat id incidunt. Mollitia sapiente delectus corrupti praesentium ut in. Et accusamus placeat molestias nisi laboriosam nihil.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 96, new DateTime(2020, 8, 7, 13, 48, 33, 667, DateTimeKind.Local).AddTicks(5381), "Qui reprehenderit aspernatur rerum ut unde necessitatibus voluptatem. Quis libero dicta eius molestiae quia ratione. Impedit nihil aut architecto laudantium a recusandae. Commodi atque necessitatibus qui sit pariatur quasi consequuntur magnam itaque. Quibusdam hic aut sunt eos quia a et deserunt.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 95, new DateTime(2020, 3, 28, 2, 29, 39, 464, DateTimeKind.Local).AddTicks(822), "Optio consequatur magni suscipit nostrum et eius alias. Vel placeat cum consequuntur debitis quia molestias. Ipsa consequatur ut laboriosam aperiam porro maiores. Consectetur dolor soluta blanditiis est quos amet nemo praesentium temporibus. Vitae aliquam eveniet quo rerum quidem accusantium facilis cupiditate maiores. Veniam ipsam aut et voluptates.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 94, new DateTime(2019, 9, 28, 13, 19, 59, 17, DateTimeKind.Local).AddTicks(4130), "Commodi qui est dolorem ut. Quia reiciendis rerum quia quaerat. Culpa laboriosam sed itaque et dignissimos voluptate. Consectetur corrupti ad. Deserunt consectetur et eos. Id blanditiis enim nam iure nesciunt odio deleniti.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 93, new DateTime(2020, 6, 8, 22, 49, 0, 156, DateTimeKind.Local).AddTicks(7276), "Dolore porro et blanditiis impedit cupiditate quo. Perspiciatis amet dolores perferendis. Laboriosam perspiciatis reprehenderit hic officiis voluptate suscipit earum.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 92, new DateTime(2020, 8, 19, 8, 35, 9, 720, DateTimeKind.Local).AddTicks(2773), "Impedit ullam qui ea iste. Necessitatibus eligendi et quis eos tenetur qui est harum et. Ut dolorem illum id.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 91, new DateTime(2020, 6, 21, 18, 21, 21, 221, DateTimeKind.Local).AddTicks(6963), "Dolores quis non quo ab provident magnam. Beatae quam ut modi et vitae. Nesciunt ut quis. Magnam saepe et.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 90, new DateTime(2020, 3, 17, 23, 42, 37, 503, DateTimeKind.Local).AddTicks(1485), "Occaecati neque necessitatibus numquam eum. Consectetur odio eius in alias tempore. Sed voluptatibus perspiciatis dolorem quae dolore nobis iste modi.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 75, new DateTime(2020, 2, 8, 15, 56, 19, 557, DateTimeKind.Local).AddTicks(9269), "Fugit quod dicta quibusdam tempore maxime. Quam natus recusandae recusandae cumque illum. Autem optio qui eos. Quia modi eveniet consectetur rerum. Consectetur laborum officia incidunt. Repellat autem et non ad.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 89, new DateTime(2020, 6, 16, 4, 15, 52, 325, DateTimeKind.Local).AddTicks(5152), "Omnis esse laborum et perspiciatis quo. Tenetur molestias perspiciatis sint consequatur. Nemo atque id molestiae. Blanditiis vel nulla nostrum possimus. Aut quae laudantium.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 87, new DateTime(2020, 6, 3, 4, 9, 53, 772, DateTimeKind.Local).AddTicks(384), "Delectus maxime non quibusdam. Reprehenderit aspernatur possimus illum sequi consequatur nulla. Sint temporibus dolores eum. Fugit animi eaque consequatur minus et quis et reiciendis corrupti.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 86, new DateTime(2019, 11, 13, 20, 39, 56, 283, DateTimeKind.Local).AddTicks(1367), "Qui consequatur ratione nulla itaque. Et eum et. Explicabo accusamus omnis. Voluptates quis et id neque quaerat.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 84, new DateTime(2020, 5, 2, 18, 52, 51, 908, DateTimeKind.Local).AddTicks(4446), "Explicabo delectus totam non perferendis molestiae ad dolores. Accusantium nihil est vitae commodi rerum adipisci ut quae. Ipsa voluptates rerum quia non.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 83, new DateTime(2020, 4, 1, 13, 36, 1, 619, DateTimeKind.Local).AddTicks(7964), "Voluptate sed sit corrupti illo autem et ad est. Perferendis autem animi placeat. Necessitatibus vitae tenetur molestiae id quibusdam. Quos ad ut recusandae. Necessitatibus repudiandae odit aspernatur et.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 82, new DateTime(2020, 2, 6, 18, 19, 57, 192, DateTimeKind.Local).AddTicks(3793), "Velit qui eaque impedit. Facere sed temporibus nam reiciendis amet laudantium dicta quo ut. Voluptas natus porro aspernatur necessitatibus omnis. Accusantium sit quis consequatur quisquam eveniet culpa voluptatem. Qui quis sunt voluptate ratione. Et qui non aut.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 81, new DateTime(2020, 1, 29, 4, 32, 26, 543, DateTimeKind.Local).AddTicks(2169), "Explicabo provident atque magni id optio beatae et excepturi est. Voluptatem voluptas quas eius consequuntur nesciunt quas quo. Assumenda et ducimus est incidunt sit recusandae sint. Velit omnis odit sunt. Ipsum non sed iusto id.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 80, new DateTime(2020, 5, 27, 18, 46, 33, 873, DateTimeKind.Local).AddTicks(376), "Ipsa quaerat harum enim. Qui fuga dicta est illo est amet. Ut laudantium id error non. Optio molestiae velit consequatur eos vitae consequatur non odit aut.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 79, new DateTime(2019, 12, 25, 10, 47, 34, 884, DateTimeKind.Local).AddTicks(3476), "Cumque excepturi magni sed hic voluptatibus. Laborum vitae consequatur quis tenetur sequi dolores autem sed. Sequi voluptas cumque consequatur quis cumque. Qui qui assumenda soluta minus.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 78, new DateTime(2020, 4, 30, 10, 40, 48, 205, DateTimeKind.Local).AddTicks(7647), "Neque deserunt repellat quia itaque blanditiis qui beatae culpa. Harum quod est voluptas pariatur et consequuntur velit. Vero inventore eveniet qui velit ea aliquam est.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 77, new DateTime(2020, 8, 1, 15, 18, 42, 898, DateTimeKind.Local).AddTicks(679), "Consectetur qui omnis et accusantium aut. Et assumenda qui ipsa inventore. Ducimus veniam dolores voluptas libero eos omnis fugiat adipisci minima. Est exercitationem voluptatem omnis molestias eos nulla enim nostrum. Rerum sequi est et. Vitae et est repellendus debitis error aut nostrum expedita.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 88, new DateTime(2019, 9, 26, 8, 28, 12, 50, DateTimeKind.Local).AddTicks(7663), "Harum aut ad consequuntur officia nam harum asperiores fugit id. Perspiciatis non excepturi eius autem. Tempora at et et.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 50, new DateTime(2020, 3, 11, 9, 50, 19, 866, DateTimeKind.Local).AddTicks(4113), "Atque doloribus odio nisi. Qui tenetur architecto nobis et et et. Molestiae nulla quis saepe dolorem dolor voluptas in. Eum ipsa et soluta ut.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 26, new DateTime(2019, 11, 20, 13, 37, 56, 131, DateTimeKind.Local).AddTicks(4321), "Qui est vel consectetur quo. Nesciunt qui amet eaque. Aut quis quo sed quia et quam.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 48, new DateTime(2020, 8, 24, 23, 58, 4, 721, DateTimeKind.Local).AddTicks(3400), "Laboriosam ducimus minus magni asperiores facere. Qui maxime omnis quia sint. Incidunt error cum eos. Inventore veritatis impedit delectus.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 20, new DateTime(2019, 12, 9, 21, 32, 10, 993, DateTimeKind.Local).AddTicks(3589), "Occaecati quo facilis odio ratione. Sint ullam harum suscipit possimus et perferendis in sequi. Et et iusto et dolorem reprehenderit nihil alias sit. Voluptatem qui optio.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 19, new DateTime(2020, 3, 5, 4, 26, 45, 184, DateTimeKind.Local).AddTicks(199), "Voluptatem ad quos repellendus officia beatae assumenda. Quis unde quam ipsam quasi iure ab harum. Numquam quasi distinctio eum.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 18, new DateTime(2020, 6, 13, 16, 0, 8, 874, DateTimeKind.Local).AddTicks(9347), "Veniam expedita aut cum qui unde culpa autem officia recusandae. Adipisci officia ullam laudantium minima perferendis reprehenderit alias aut. Saepe est dolore iusto id voluptatum et unde sint. At maxime labore omnis facere quidem.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 17, new DateTime(2019, 10, 3, 5, 45, 25, 982, DateTimeKind.Local).AddTicks(7172), "Accusantium voluptatum velit sunt id ea id. Aut quis et tempora est ea debitis quibusdam quaerat blanditiis. Est est maxime illum non esse repellendus at sequi. Numquam aliquid ad doloremque dolores veritatis velit. Dolore et assumenda quidem ut pariatur quia. Reiciendis dolor autem incidunt accusantium.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 16, new DateTime(2020, 4, 19, 2, 55, 19, 828, DateTimeKind.Local).AddTicks(2542), "Quo quis asperiores repellat nisi. Aperiam provident voluptatem deleniti ducimus omnis qui. Consequuntur earum reiciendis in qui enim debitis. Nobis deserunt voluptatem qui omnis placeat totam. Possimus sunt rerum recusandae laboriosam libero quia quis pariatur et. Ut sed ut id odit dolorem.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 15, new DateTime(2020, 7, 1, 7, 31, 22, 728, DateTimeKind.Local).AddTicks(3656), "Tenetur est vitae aut ut assumenda. Voluptas possimus aut et dolor dolores hic itaque. Animi quibusdam tenetur excepturi tempore. Ab a ipsum consequatur. Incidunt non aut ex. Amet accusamus omnis nesciunt occaecati dolores.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 14, new DateTime(2019, 9, 30, 6, 7, 22, 735, DateTimeKind.Local).AddTicks(8654), "Ex occaecati minus modi eum reprehenderit illo pariatur quaerat autem. Est ad rerum molestiae iusto blanditiis placeat officiis. Voluptatem et natus ullam enim minus enim rerum et. Placeat quo perferendis corporis illum ratione. Quas consequatur id dolore modi. Ab et quae nobis ex est magni exercitationem sint nemo.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 13, new DateTime(2020, 6, 6, 7, 38, 36, 896, DateTimeKind.Local).AddTicks(7209), "Dolores reprehenderit optio assumenda unde inventore deserunt voluptatum sit earum. Voluptatem explicabo ratione maiores id sunt eligendi omnis facilis. Labore perferendis voluptatem. Enim quia nam eaque qui adipisci asperiores corporis quasi modi. Corporis qui a labore cumque similique.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 12, new DateTime(2020, 8, 14, 14, 35, 59, 517, DateTimeKind.Local).AddTicks(5343), "Ipsa enim itaque consequatur doloribus quisquam. Alias officia quas ullam nostrum ipsa recusandae quia illo. Veritatis et quas laboriosam.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 11, new DateTime(2020, 5, 11, 10, 13, 3, 546, DateTimeKind.Local).AddTicks(860), "Quis ratione consequatur nemo rerum doloribus enim autem rerum. Libero et est. Aut id omnis pariatur tempora non consequatur sequi vitae et. Est cum adipisci pariatur itaque aut ipsum modi architecto.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 10, new DateTime(2019, 10, 20, 12, 47, 1, 499, DateTimeKind.Local).AddTicks(8455), "Nesciunt qui rerum doloribus consequatur sit. Itaque esse atque ipsa voluptatum voluptatem aperiam perspiciatis. Facilis sit iure et omnis atque iure aperiam.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 9, new DateTime(2020, 8, 4, 20, 15, 40, 380, DateTimeKind.Local).AddTicks(7245), "Voluptatem est sit in voluptate ad ab eum. Corrupti quibusdam facere vel nostrum veritatis quam quia. Dicta magnam et perspiciatis voluptas voluptatem. Cum et aperiam repellat quaerat impedit enim consequatur omnis. Ipsum quaerat possimus ut.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 8, new DateTime(2020, 5, 9, 2, 44, 54, 616, DateTimeKind.Local).AddTicks(8047), "Voluptates aut placeat architecto illo. Aut iusto aliquam illum dignissimos sequi hic quasi sequi. Non accusamus tenetur suscipit optio minima quasi facere.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 7, new DateTime(2020, 7, 1, 15, 13, 7, 32, DateTimeKind.Local).AddTicks(1480), "Minus maxime qui aliquam nemo est eligendi voluptate. Consectetur earum dolorem hic laborum ratione optio. Eos voluptates quos nulla nostrum deserunt dolor sit. Dolores voluptas ut est. Dolore unde aut eos voluptas ex nesciunt ea magnam.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 6, new DateTime(2020, 6, 15, 15, 52, 17, 364, DateTimeKind.Local).AddTicks(2811), "Exercitationem perspiciatis mollitia architecto vitae velit quo. Dolorem id tempore. Enim id illo commodi eius placeat.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 5, new DateTime(2020, 5, 28, 20, 33, 40, 215, DateTimeKind.Local).AddTicks(1416), "Eos unde in odio non unde explicabo enim voluptate. Eligendi quisquam dolorem. Sint enim cum optio. Veniam non quia dolores non eius dolor architecto. Non distinctio ducimus sapiente aut explicabo et quia et.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 4, new DateTime(2020, 5, 24, 7, 30, 42, 174, DateTimeKind.Local).AddTicks(1354), "Voluptatem et aut est nam vitae tempora quas placeat. Rerum recusandae dolor possimus architecto. Illum harum amet eos nihil expedita. Autem et deserunt tempora exercitationem.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 3, new DateTime(2020, 5, 30, 11, 20, 54, 694, DateTimeKind.Local).AddTicks(319), "Sint ut sequi libero omnis et facilis. Vel id eos incidunt est cumque architecto ducimus numquam numquam. Et voluptates eos reiciendis. Omnis a enim ut aspernatur.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 2, new DateTime(2019, 11, 6, 6, 1, 12, 947, DateTimeKind.Local).AddTicks(901), "Laborum sunt molestiae possimus consequatur ea nihil accusamus qui. Molestiae est dolores ut unde magni fugiat placeat dignissimos libero. Dolorem ex numquam culpa accusamus ducimus error necessitatibus dolor. Rem blanditiis voluptatem accusamus.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 1, new DateTime(2019, 9, 18, 21, 8, 45, 605, DateTimeKind.Local).AddTicks(218), "Voluptatem voluptate hic voluptatum esse est. Laudantium hic adipisci aut consequatur commodi molestiae et facere ratione. Dolorem doloribus atque id ad sed est. Itaque dolores ullam deserunt reiciendis tempora eos repudiandae ea id.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 99, new DateTime(2019, 11, 12, 13, 20, 18, 769, DateTimeKind.Local).AddTicks(5087), "Accusantium porro et soluta. Minus neque omnis magnam nisi rem qui. Reprehenderit ea aliquam a voluptatem est voluptas dicta nisi aut. Sit ut omnis libero et libero repellendus maxime.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 21, new DateTime(2020, 8, 2, 2, 55, 31, 738, DateTimeKind.Local).AddTicks(9923), "Iste illo aut nulla. Rerum qui est facere quo debitis. Velit tempore quas doloremque ipsa expedita et. Dolor magni aut.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 22, new DateTime(2019, 11, 13, 18, 53, 12, 693, DateTimeKind.Local).AddTicks(6926), "Id ipsa culpa sed voluptatem est nulla. Optio dolor praesentium. Aperiam qui quidem doloribus consequuntur maxime fugiat deleniti saepe. Unde aspernatur illo enim veritatis nihil quae laudantium. Quis aut debitis dolorem impedit dolores tempore ut.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 23, new DateTime(2020, 8, 25, 19, 44, 54, 314, DateTimeKind.Local).AddTicks(1268), "Adipisci impedit maiores repellendus dolores. Sint commodi veniam. Et itaque dolores deleniti. Aut quo quam illo.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 24, new DateTime(2020, 2, 14, 7, 56, 34, 75, DateTimeKind.Local).AddTicks(1475), "Tempora molestiae vero qui. Voluptate et corrupti sit quis et. Quia minima non accusantium hic. Consequatur vero dolore incidunt numquam. Cupiditate aliquam quo voluptate aliquid aut numquam voluptatem. Eum iste similique neque veritatis rerum officiis et qui id.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 47, new DateTime(2020, 6, 11, 7, 6, 44, 528, DateTimeKind.Local).AddTicks(8591), "Minus dolores fugiat. Autem incidunt eveniet nostrum. Quo ut commodi molestiae ea. Et earum est placeat perspiciatis. Libero nihil et est voluptas praesentium quidem debitis ut illo.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 46, new DateTime(2020, 4, 16, 18, 40, 22, 396, DateTimeKind.Local).AddTicks(1605), "Aut sunt earum sit quae ipsum recusandae laboriosam sit. Rerum temporibus sunt quo aut et. Magnam minima voluptatem quidem et laboriosam ipsa qui quod praesentium. Aut explicabo odit harum ipsum et. Commodi necessitatibus ipsa. At veniam repudiandae aut debitis voluptate pariatur.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 45, new DateTime(2019, 9, 16, 22, 54, 36, 160, DateTimeKind.Local).AddTicks(5034), "Facere quae voluptatem. Aut corporis consequatur. Omnis nobis laboriosam consequatur illum cumque aut magni vitae sunt. Nesciunt qui sint. Fugiat veritatis et accusantium eius magnam quia nisi exercitationem quidem. Labore porro sequi.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 44, new DateTime(2020, 2, 20, 12, 19, 5, 37, DateTimeKind.Local).AddTicks(1559), "Qui natus hic repudiandae eligendi officiis omnis sed a. Excepturi nesciunt ad amet aut dignissimos dolores eveniet voluptatem. Modi ut modi qui explicabo asperiores omnis quam. Et quo ex. Ea aliquam minima eum et accusamus ipsa totam.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 43, new DateTime(2020, 6, 30, 13, 47, 17, 95, DateTimeKind.Local).AddTicks(1569), "Et quae ad voluptatem asperiores quibusdam. Et repudiandae voluptatibus voluptatem dolores voluptas voluptas. Omnis error sint sit eius. Nobis praesentium dolor doloremque ut autem quos.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 42, new DateTime(2020, 7, 8, 2, 7, 24, 300, DateTimeKind.Local).AddTicks(4985), "Autem nam aliquid voluptas enim suscipit sapiente. Repellendus consequatur et porro ex. Et iusto voluptatem sit enim est expedita consequatur ut eius. Totam repellat amet. Accusamus ut facilis velit libero dolores voluptatum voluptate. Tenetur dolor enim.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 41, new DateTime(2020, 7, 27, 1, 30, 53, 856, DateTimeKind.Local).AddTicks(3335), "Qui omnis accusamus voluptatem fugit. Quod delectus odit nemo. Voluptatem alias non praesentium.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 40, new DateTime(2020, 4, 2, 5, 15, 26, 343, DateTimeKind.Local).AddTicks(8758), "Non at quaerat rerum voluptas nemo ducimus ipsam adipisci. Rerum et itaque vero et est expedita iure quisquam amet. Ut error sed aut aut ipsa sit beatae blanditiis. Voluptas nemo aut mollitia et quibusdam velit magni deserunt iure. Qui est qui non magni minus repellat fugit dolor consequuntur.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 39, new DateTime(2020, 3, 7, 16, 25, 55, 763, DateTimeKind.Local).AddTicks(6684), "Sit ut corrupti corporis voluptatibus iste id libero laboriosam omnis. Ea dolorum voluptatem delectus error numquam. Accusantium eaque harum sunt et nostrum nihil. Itaque libero consequatur. Illo quo ut. Fugiat adipisci deserunt est in ratione et officia et voluptas.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 38, new DateTime(2019, 12, 2, 20, 8, 2, 202, DateTimeKind.Local).AddTicks(9181), "Odit dolore et est. Non blanditiis officiis in facilis dolorem saepe est quo necessitatibus. Ut fuga exercitationem pariatur. Et culpa nesciunt eum et at quo. Et vitae hic vel cumque tempore aliquam culpa dolorum. Accusamus vel et eum est.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 49, new DateTime(2020, 5, 2, 9, 29, 55, 790, DateTimeKind.Local).AddTicks(5718), "Quasi expedita facere aut fugiat doloribus. Minima quos asperiores et omnis consectetur qui veniam quia. Sequi rerum deleniti facilis. Vel molestiae quasi aperiam enim temporibus quis doloribus.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 37, new DateTime(2020, 8, 1, 16, 27, 30, 170, DateTimeKind.Local).AddTicks(7604), "Aspernatur sunt quos qui incidunt assumenda hic vel. Fugit qui repellat. Et necessitatibus ducimus distinctio voluptatem quia. Unde quia nulla omnis. Beatae tempora voluptas vitae ut cupiditate tempora. Incidunt libero reprehenderit mollitia dolorem ipsum.", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 35, new DateTime(2019, 12, 12, 7, 27, 10, 866, DateTimeKind.Local).AddTicks(5250), "Cum aut ratione adipisci. Dolorem sed dolores. Natus aliquam laboriosam ut at provident aut.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 34, new DateTime(2020, 5, 5, 4, 59, 47, 888, DateTimeKind.Local).AddTicks(121), "Dolorum officia et consequatur aliquam adipisci. A non vel maxime amet ut consectetur sit. Amet consequatur mollitia facilis tempora explicabo odio et. Et tempora quis quod consectetur repellat.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 33, new DateTime(2020, 6, 12, 17, 51, 56, 50, DateTimeKind.Local).AddTicks(4266), "Possimus ut doloribus ratione ex hic commodi amet quo. Dicta recusandae et ab at modi exercitationem. Doloribus qui aliquid eos ipsam dicta qui aut possimus. Incidunt voluptates et nisi maxime sunt eos fugiat. Odit ea reprehenderit aut quia quae debitis. Placeat animi non veniam quos.", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 32, new DateTime(2020, 9, 5, 10, 17, 42, 355, DateTimeKind.Local).AddTicks(8334), "Nesciunt dolores voluptas aut iusto. Voluptas nam officia et unde non sit. Distinctio voluptatem vel blanditiis qui dolorum sit. Hic molestiae quaerat aliquid officia voluptate et id in. Possimus nisi ipsum enim aut. Quis soluta occaecati in eos porro.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 31, new DateTime(2020, 4, 1, 1, 23, 33, 790, DateTimeKind.Local).AddTicks(5247), "Maiores dignissimos vero soluta animi aliquam nobis magni. Incidunt inventore ipsa dolorem voluptas quaerat a. Aut libero adipisci voluptatem voluptatem totam in cupiditate laudantium corrupti. Eligendi inventore ut qui qui voluptatem eius minus fuga. Ducimus est vel consequatur sed. Et qui sint error perspiciatis laboriosam totam dolores omnis.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 30, new DateTime(2020, 2, 3, 0, 58, 8, 661, DateTimeKind.Local).AddTicks(7213), "Illum est doloribus voluptatum molestias quo ea minus sed. Atque perferendis ab ut. Itaque dolor beatae. Assumenda nisi voluptas aut ullam.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 29, new DateTime(2020, 2, 24, 9, 13, 24, 51, DateTimeKind.Local).AddTicks(1910), "Iure voluptas sit ipsum voluptates repellendus asperiores id. Voluptate architecto nostrum sed inventore id eveniet ea iste ut. Odio delectus nesciunt sunt voluptatem velit.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 28, new DateTime(2019, 10, 18, 6, 9, 33, 925, DateTimeKind.Local).AddTicks(9806), "Nihil fugit at est et enim. Provident rerum doloribus quia eius maiores praesentium reiciendis ea. Quo illum sed.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 27, new DateTime(2020, 1, 22, 7, 56, 46, 210, DateTimeKind.Local).AddTicks(9497), "Nihil sunt neque. Ut possimus dolorem a aut aspernatur aliquam. Reprehenderit nisi vel error autem dolorem nihil ex vel. Fugit amet ratione nulla et aut. Recusandae velit a laborum expedita tenetur et unde dolorum.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 25, new DateTime(2020, 7, 9, 4, 30, 15, 977, DateTimeKind.Local).AddTicks(5659), "Corrupti accusantium veniam tempore ipsum molestiae. Repellat quo velit non modi optio et dolores incidunt quasi. Nihil dolores quisquam ea et necessitatibus corrupti magni ea odit. Alias vitae quisquam sunt ad et voluptas illum. At alias et iste vero sapiente magni.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "زيارة مقرر الأمم المتحدة الخاص المعني بالاتجار بالأشخاص , وخاصة النساء والأطفال , يومي 17 و 21 حزيران (يونيو) 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 36, new DateTime(2019, 10, 18, 21, 48, 24, 871, DateTimeKind.Local).AddTicks(1589), "Odit laborum facere delectus. Numquam id eum nihil fugiat. Rerum assumenda sapiente dicta eius. Perspiciatis veritatis reiciendis earum voluptatem fugiat. Necessitatibus odit necessitatibus expedita.", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "زيارة المقرر الخاص المعني بحقوق الإنسان لضحايا الاتجار بالأشخاص , ولا سيما النساء والأطفال", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[] { 100, new DateTime(2019, 11, 7, 6, 48, 22, 543, DateTimeKind.Local).AddTicks(6009), "Laudantium voluptatum illo libero. Quo deleniti vel voluptas et adipisci. Ut totam necessitatibus et qui eos soluta. Itaque distinctio est sit dolores minima culpa natus qui nemo. In cumque quia.", "", "", "Visite du Rapporteur spécial des Nations Unies sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 9, 12, 9, 55, 38, 494, DateTimeKind.Local).AddTicks(2413), new DateTime(2020, 9, 11, 20, 14, 52, 624, DateTimeKind.Local).AddTicks(141), new DateTime(2020, 9, 11, 16, 20, 44, 184, DateTimeKind.Local).AddTicks(4959), 39, "", "http://julie.eu", "quaerat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 9, 12, 3, 13, 15, 950, DateTimeKind.Local).AddTicks(8293), new DateTime(2020, 9, 11, 14, 56, 57, 70, DateTimeKind.Local).AddTicks(7833), new DateTime(2020, 9, 11, 19, 0, 39, 197, DateTimeKind.Local).AddTicks(9162), 69, "", "http://maeva.com", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 9, 11, 10, 20, 26, 577, DateTimeKind.Local).AddTicks(7417), new DateTime(2020, 9, 12, 5, 54, 8, 385, DateTimeKind.Local).AddTicks(5434), new DateTime(2020, 9, 12, 8, 22, 42, 970, DateTimeKind.Local).AddTicks(3065), 68, "", "http://louna.name", "doloremque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 9, 11, 15, 3, 37, 405, DateTimeKind.Local).AddTicks(1640), new DateTime(2020, 9, 12, 5, 29, 52, 236, DateTimeKind.Local).AddTicks(5711), new DateTime(2020, 9, 12, 0, 55, 38, 544, DateTimeKind.Local).AddTicks(5579), 67, "", "https://clémence.org", "natus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 9, 11, 18, 39, 52, 720, DateTimeKind.Local).AddTicks(7498), new DateTime(2020, 9, 12, 9, 33, 39, 707, DateTimeKind.Local).AddTicks(7910), new DateTime(2020, 9, 12, 8, 37, 11, 172, DateTimeKind.Local).AddTicks(6385), 67, "", "http://jade.net", "commodi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 9, 11, 20, 13, 24, 285, DateTimeKind.Local).AddTicks(8089), new DateTime(2020, 9, 11, 15, 34, 4, 540, DateTimeKind.Local).AddTicks(5370), new DateTime(2020, 9, 12, 5, 42, 27, 174, DateTimeKind.Local).AddTicks(5406), 65, "", "http://zoe.fr", "tenetur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 9, 11, 15, 50, 52, 739, DateTimeKind.Local).AddTicks(4544), new DateTime(2020, 9, 11, 13, 4, 49, 706, DateTimeKind.Local).AddTicks(1432), new DateTime(2020, 9, 11, 19, 30, 57, 505, DateTimeKind.Local).AddTicks(7773), 64, "", "https://mattéo.net", "sed" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 9, 11, 13, 19, 6, 530, DateTimeKind.Local).AddTicks(5044), new DateTime(2020, 9, 12, 8, 40, 50, 448, DateTimeKind.Local).AddTicks(9387), new DateTime(2020, 9, 12, 4, 34, 50, 180, DateTimeKind.Local).AddTicks(3301), 64, "", "https://alexis.net", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 9, 12, 0, 19, 55, 937, DateTimeKind.Local).AddTicks(9528), new DateTime(2020, 9, 11, 22, 26, 10, 851, DateTimeKind.Local).AddTicks(103), new DateTime(2020, 9, 11, 23, 26, 12, 654, DateTimeKind.Local).AddTicks(2074), 64, "", "https://jade.eu", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 9, 12, 6, 17, 41, 312, DateTimeKind.Local).AddTicks(7023), new DateTime(2020, 9, 12, 1, 2, 10, 534, DateTimeKind.Local).AddTicks(8680), new DateTime(2020, 9, 11, 21, 59, 47, 626, DateTimeKind.Local).AddTicks(7264), 60, "", "https://jeanne.eu", "sunt" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 9, 12, 9, 37, 23, 433, DateTimeKind.Local).AddTicks(1115), new DateTime(2020, 9, 11, 13, 21, 56, 398, DateTimeKind.Local).AddTicks(9051), new DateTime(2020, 9, 12, 4, 14, 50, 923, DateTimeKind.Local).AddTicks(3461), 57, "", "http://maëlys.net", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 9, 11, 12, 50, 7, 582, DateTimeKind.Local).AddTicks(9854), new DateTime(2020, 9, 11, 21, 41, 13, 458, DateTimeKind.Local).AddTicks(8404), new DateTime(2020, 9, 11, 16, 7, 36, 701, DateTimeKind.Local).AddTicks(8226), 57, "", "https://baptiste.org", "neque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 9, 12, 0, 20, 50, 723, DateTimeKind.Local).AddTicks(4935), new DateTime(2020, 9, 11, 10, 31, 13, 375, DateTimeKind.Local).AddTicks(9235), new DateTime(2020, 9, 11, 10, 49, 10, 59, DateTimeKind.Local).AddTicks(5228), 70, "", "http://laura.fr", "sit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 9, 11, 16, 59, 40, 944, DateTimeKind.Local).AddTicks(5441), new DateTime(2020, 9, 12, 7, 46, 7, 111, DateTimeKind.Local).AddTicks(8478), new DateTime(2020, 9, 11, 17, 29, 54, 664, DateTimeKind.Local).AddTicks(5403), 53, "", "http://mohamed.eu", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 9, 11, 10, 4, 11, 841, DateTimeKind.Local).AddTicks(850), new DateTime(2020, 9, 11, 18, 47, 42, 641, DateTimeKind.Local).AddTicks(7578), new DateTime(2020, 9, 12, 4, 18, 14, 396, DateTimeKind.Local).AddTicks(1512), 51, "", "http://mohamed.net", "harum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 9, 12, 4, 32, 13, 961, DateTimeKind.Local).AddTicks(9055), new DateTime(2020, 9, 11, 19, 35, 35, 978, DateTimeKind.Local).AddTicks(5779), new DateTime(2020, 9, 11, 12, 13, 21, 330, DateTimeKind.Local).AddTicks(2962), 51, "", "https://lou.name", "amet" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 9, 12, 5, 55, 0, 407, DateTimeKind.Local).AddTicks(1885), new DateTime(2020, 9, 12, 5, 49, 34, 725, DateTimeKind.Local).AddTicks(8327), new DateTime(2020, 9, 11, 20, 51, 24, 119, DateTimeKind.Local).AddTicks(284), 50, "", "https://célia.info", "odit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 9, 11, 18, 53, 22, 654, DateTimeKind.Local).AddTicks(356), new DateTime(2020, 9, 11, 20, 32, 4, 667, DateTimeKind.Local).AddTicks(4612), new DateTime(2020, 9, 11, 14, 0, 56, 93, DateTimeKind.Local).AddTicks(5582), 50, "", "https://maëlys.info", "nihil" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 9, 11, 10, 15, 27, 953, DateTimeKind.Local).AddTicks(9741), new DateTime(2020, 9, 11, 22, 15, 1, 280, DateTimeKind.Local).AddTicks(9544), new DateTime(2020, 9, 12, 4, 57, 39, 101, DateTimeKind.Local).AddTicks(8937), 49, "", "https://lucas.name", "similique" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 9, 11, 20, 15, 52, 321, DateTimeKind.Local).AddTicks(4172), new DateTime(2020, 9, 12, 1, 57, 56, 805, DateTimeKind.Local).AddTicks(1522), new DateTime(2020, 9, 11, 12, 35, 43, 265, DateTimeKind.Local).AddTicks(3637), 49, "", "http://benjamin.name", "quos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 9, 11, 19, 26, 3, 158, DateTimeKind.Local).AddTicks(9931), new DateTime(2020, 9, 11, 18, 11, 59, 421, DateTimeKind.Local).AddTicks(7181), new DateTime(2020, 9, 11, 11, 29, 24, 574, DateTimeKind.Local).AddTicks(4098), 48, "", "https://lisa.net", "blanditiis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 9, 12, 1, 19, 10, 993, DateTimeKind.Local).AddTicks(9885), new DateTime(2020, 9, 11, 22, 39, 12, 934, DateTimeKind.Local).AddTicks(5578), new DateTime(2020, 9, 11, 14, 18, 5, 428, DateTimeKind.Local).AddTicks(5911), 46, "", "https://noah.org", "fugiat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 9, 11, 14, 36, 8, 433, DateTimeKind.Local).AddTicks(4194), new DateTime(2020, 9, 11, 22, 9, 54, 614, DateTimeKind.Local).AddTicks(600), new DateTime(2020, 9, 12, 4, 42, 28, 104, DateTimeKind.Local).AddTicks(4608), 45, "", "https://julien.fr", "necessitatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 9, 11, 18, 24, 16, 163, DateTimeKind.Local).AddTicks(2061), new DateTime(2020, 9, 11, 19, 26, 51, 552, DateTimeKind.Local).AddTicks(2933), new DateTime(2020, 9, 12, 6, 58, 48, 431, DateTimeKind.Local).AddTicks(7296), 44, "", "http://lilou.name", "itaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 9, 12, 8, 16, 52, 414, DateTimeKind.Local).AddTicks(5332), new DateTime(2020, 9, 11, 18, 31, 6, 587, DateTimeKind.Local).AddTicks(4537), new DateTime(2020, 9, 11, 14, 46, 1, 843, DateTimeKind.Local).AddTicks(354), 43, "", "https://romain.com", "veritatis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 9, 12, 1, 48, 12, 902, DateTimeKind.Local).AddTicks(7065), new DateTime(2020, 9, 12, 9, 27, 32, 584, DateTimeKind.Local).AddTicks(8576), new DateTime(2020, 9, 12, 4, 56, 15, 469, DateTimeKind.Local).AddTicks(3157), 52, "", "http://paul.info", "minima" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 9, 12, 6, 43, 1, 746, DateTimeKind.Local).AddTicks(4999), new DateTime(2020, 9, 11, 15, 5, 25, 570, DateTimeKind.Local).AddTicks(5802), new DateTime(2020, 9, 11, 21, 17, 0, 341, DateTimeKind.Local).AddTicks(9981), 70, "", "https://adam.name", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 9, 11, 19, 6, 1, 199, DateTimeKind.Local).AddTicks(9920), new DateTime(2020, 9, 12, 0, 38, 11, 688, DateTimeKind.Local).AddTicks(7993), new DateTime(2020, 9, 11, 18, 49, 41, 437, DateTimeKind.Local).AddTicks(1706), 71, "", "http://chloé.eu", "alias" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 9, 11, 15, 12, 59, 290, DateTimeKind.Local).AddTicks(265), new DateTime(2020, 9, 12, 7, 32, 14, 481, DateTimeKind.Local).AddTicks(5215), new DateTime(2020, 9, 12, 3, 47, 56, 900, DateTimeKind.Local).AddTicks(8386), 74, "", "http://baptiste.name", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 9, 11, 15, 47, 39, 857, DateTimeKind.Local).AddTicks(5796), new DateTime(2020, 9, 11, 14, 42, 11, 380, DateTimeKind.Local).AddTicks(1131), new DateTime(2020, 9, 11, 13, 55, 44, 5, DateTimeKind.Local).AddTicks(8121), 98, "", "http://gabriel.net", "voluptatibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 9, 11, 20, 43, 1, 781, DateTimeKind.Local).AddTicks(568), new DateTime(2020, 9, 11, 17, 10, 46, 233, DateTimeKind.Local).AddTicks(3519), new DateTime(2020, 9, 11, 18, 28, 36, 578, DateTimeKind.Local).AddTicks(5710), 98, "", "http://mélissa.net", "exercitationem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 9, 12, 8, 15, 52, 560, DateTimeKind.Local).AddTicks(2612), new DateTime(2020, 9, 12, 6, 34, 33, 991, DateTimeKind.Local).AddTicks(2976), new DateTime(2020, 9, 12, 4, 45, 7, 462, DateTimeKind.Local).AddTicks(3171), 97, "", "http://louis.com", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 9, 12, 7, 39, 41, 156, DateTimeKind.Local).AddTicks(1860), new DateTime(2020, 9, 11, 14, 55, 11, 667, DateTimeKind.Local).AddTicks(4523), new DateTime(2020, 9, 12, 4, 49, 20, 132, DateTimeKind.Local).AddTicks(6426), 97, "", "https://noémie.fr", "optio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 9, 12, 5, 22, 9, 142, DateTimeKind.Local).AddTicks(9653), new DateTime(2020, 9, 11, 16, 58, 3, 615, DateTimeKind.Local).AddTicks(2792), new DateTime(2020, 9, 12, 2, 21, 40, 585, DateTimeKind.Local).AddTicks(5613), 94, "", "https://maxence.com", "ea" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 9, 12, 0, 12, 6, 260, DateTimeKind.Local).AddTicks(7979), new DateTime(2020, 9, 11, 11, 0, 10, 624, DateTimeKind.Local).AddTicks(6788), new DateTime(2020, 9, 12, 2, 4, 13, 447, DateTimeKind.Local).AddTicks(8891), 94, "", "http://jules.fr", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 9, 11, 11, 13, 34, 962, DateTimeKind.Local).AddTicks(9035), new DateTime(2020, 9, 11, 19, 51, 52, 300, DateTimeKind.Local).AddTicks(6213), new DateTime(2020, 9, 12, 8, 17, 32, 590, DateTimeKind.Local).AddTicks(6581), 94, "", "http://benjamin.org", "repellendus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 9, 12, 5, 19, 0, 442, DateTimeKind.Local).AddTicks(1179), new DateTime(2020, 9, 11, 15, 30, 23, 73, DateTimeKind.Local).AddTicks(5024), new DateTime(2020, 9, 11, 14, 12, 51, 579, DateTimeKind.Local).AddTicks(2371), 93, "", "http://camille.fr", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 9, 11, 23, 10, 38, 463, DateTimeKind.Local).AddTicks(2974), new DateTime(2020, 9, 11, 17, 38, 44, 96, DateTimeKind.Local).AddTicks(5914), new DateTime(2020, 9, 11, 15, 57, 52, 0, DateTimeKind.Local).AddTicks(9504), 92, "", "http://zoe.com", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 9, 12, 2, 58, 40, 353, DateTimeKind.Local).AddTicks(837), new DateTime(2020, 9, 12, 0, 46, 23, 632, DateTimeKind.Local).AddTicks(3392), new DateTime(2020, 9, 11, 11, 52, 36, 283, DateTimeKind.Local).AddTicks(6591), 87, "", "http://alexandre.name", "dolor" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 9, 12, 6, 40, 32, 457, DateTimeKind.Local).AddTicks(9513), new DateTime(2020, 9, 12, 5, 41, 45, 520, DateTimeKind.Local).AddTicks(8539), new DateTime(2020, 9, 11, 23, 21, 19, 308, DateTimeKind.Local).AddTicks(7053), 87, "", "http://maeva.eu", "ea" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 9, 11, 21, 22, 59, 772, DateTimeKind.Local).AddTicks(9998), new DateTime(2020, 9, 11, 17, 13, 25, 24, DateTimeKind.Local).AddTicks(8061), new DateTime(2020, 9, 12, 8, 25, 31, 12, DateTimeKind.Local).AddTicks(22), 86, "", "http://lucie.org", "minima" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 9, 12, 2, 30, 40, 164, DateTimeKind.Local).AddTicks(2080), new DateTime(2020, 9, 12, 5, 6, 51, 723, DateTimeKind.Local).AddTicks(6803), new DateTime(2020, 9, 11, 20, 18, 33, 677, DateTimeKind.Local).AddTicks(8545), 86, "", "https://romain.info", "assumenda" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 9, 12, 6, 47, 30, 231, DateTimeKind.Local).AddTicks(8673), new DateTime(2020, 9, 11, 10, 9, 47, 928, DateTimeKind.Local).AddTicks(7412), new DateTime(2020, 9, 11, 23, 58, 35, 416, DateTimeKind.Local).AddTicks(3120), 85, "", "http://tom.net", "ratione" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 9, 11, 12, 41, 57, 562, DateTimeKind.Local).AddTicks(1065), new DateTime(2020, 9, 11, 13, 3, 38, 799, DateTimeKind.Local).AddTicks(2656), new DateTime(2020, 9, 11, 20, 49, 34, 384, DateTimeKind.Local).AddTicks(2383), 84, "", "http://mattéo.fr", "dolorum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 9, 12, 9, 37, 52, 178, DateTimeKind.Local).AddTicks(2785), new DateTime(2020, 9, 11, 17, 24, 52, 52, DateTimeKind.Local).AddTicks(2608), new DateTime(2020, 9, 12, 2, 3, 52, 271, DateTimeKind.Local).AddTicks(9026), 83, "", "http://lucie.name", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 9, 12, 9, 21, 4, 632, DateTimeKind.Local).AddTicks(3449), new DateTime(2020, 9, 12, 9, 54, 51, 547, DateTimeKind.Local).AddTicks(1614), new DateTime(2020, 9, 11, 21, 12, 35, 93, DateTimeKind.Local).AddTicks(243), 82, "", "http://maëlle.org", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 9, 12, 7, 54, 31, 453, DateTimeKind.Local).AddTicks(9123), new DateTime(2020, 9, 11, 22, 46, 36, 607, DateTimeKind.Local).AddTicks(2671), new DateTime(2020, 9, 11, 11, 44, 55, 48, DateTimeKind.Local).AddTicks(1402), 82, "", "https://mohamed.com", "ratione" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 9, 11, 20, 37, 8, 436, DateTimeKind.Local).AddTicks(410), new DateTime(2020, 9, 11, 21, 10, 26, 793, DateTimeKind.Local).AddTicks(7403), new DateTime(2020, 9, 11, 17, 37, 52, 999, DateTimeKind.Local).AddTicks(7854), 81, "", "https://kylian.info", "odio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 9, 11, 20, 9, 18, 607, DateTimeKind.Local).AddTicks(9219), new DateTime(2020, 9, 12, 1, 34, 59, 397, DateTimeKind.Local).AddTicks(2535), new DateTime(2020, 9, 11, 20, 6, 5, 889, DateTimeKind.Local).AddTicks(5947), 80, "", "https://charlotte.name", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 9, 11, 21, 25, 33, 808, DateTimeKind.Local).AddTicks(928), new DateTime(2020, 9, 11, 15, 49, 57, 554, DateTimeKind.Local).AddTicks(7607), new DateTime(2020, 9, 11, 19, 26, 18, 790, DateTimeKind.Local).AddTicks(7329), 79, "", "https://paul.name", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 9, 11, 16, 24, 40, 45, DateTimeKind.Local).AddTicks(7394), new DateTime(2020, 9, 11, 11, 16, 53, 756, DateTimeKind.Local).AddTicks(3133), new DateTime(2020, 9, 11, 12, 37, 48, 980, DateTimeKind.Local).AddTicks(5539), 79, "", "http://alice.fr", "laudantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 9, 12, 5, 47, 28, 6, DateTimeKind.Local).AddTicks(4752), new DateTime(2020, 9, 12, 3, 20, 18, 859, DateTimeKind.Local).AddTicks(7464), new DateTime(2020, 9, 12, 6, 27, 41, 291, DateTimeKind.Local).AddTicks(272), 79, "", "https://noah.org", "quas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 9, 11, 22, 45, 25, 302, DateTimeKind.Local).AddTicks(7655), new DateTime(2020, 9, 11, 10, 18, 8, 349, DateTimeKind.Local).AddTicks(3624), new DateTime(2020, 9, 11, 14, 19, 12, 846, DateTimeKind.Local).AddTicks(2500), 78, "", "https://evan.eu", "consequuntur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 9, 11, 17, 6, 55, 814, DateTimeKind.Local).AddTicks(3240), new DateTime(2020, 9, 11, 11, 52, 52, 816, DateTimeKind.Local).AddTicks(177), new DateTime(2020, 9, 12, 5, 45, 41, 644, DateTimeKind.Local).AddTicks(2966), 75, "", "https://mathéo.com", "ratione" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 9, 12, 3, 41, 10, 681, DateTimeKind.Local).AddTicks(9997), new DateTime(2020, 9, 11, 21, 53, 51, 161, DateTimeKind.Local).AddTicks(9528), new DateTime(2020, 9, 12, 9, 59, 34, 19, DateTimeKind.Local).AddTicks(150), 42, "", "https://louna.name", "aliquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 9, 11, 21, 24, 20, 3, DateTimeKind.Local).AddTicks(9467), new DateTime(2020, 9, 11, 16, 51, 20, 660, DateTimeKind.Local).AddTicks(5143), new DateTime(2020, 9, 11, 23, 27, 32, 156, DateTimeKind.Local).AddTicks(4518), 40, "", "https://léa.info", "repudiandae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 9, 11, 14, 35, 43, 552, DateTimeKind.Local).AddTicks(5243), new DateTime(2020, 9, 11, 15, 7, 43, 943, DateTimeKind.Local).AddTicks(3562), new DateTime(2020, 9, 12, 9, 6, 19, 746, DateTimeKind.Local).AddTicks(960), 100, "", "https://maëlys.net", "ex" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 9, 11, 10, 36, 41, 833, DateTimeKind.Local).AddTicks(8484), new DateTime(2020, 9, 11, 18, 24, 36, 362, DateTimeKind.Local).AddTicks(3724), new DateTime(2020, 9, 11, 11, 21, 10, 696, DateTimeKind.Local).AddTicks(2998), 38, "", "https://anaïs.org", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 9, 12, 0, 55, 46, 116, DateTimeKind.Local).AddTicks(5144), new DateTime(2020, 9, 11, 16, 59, 2, 85, DateTimeKind.Local).AddTicks(5314), new DateTime(2020, 9, 12, 2, 0, 21, 900, DateTimeKind.Local).AddTicks(401), 14, "", "https://théo.com", "iste" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 9, 11, 18, 29, 37, 928, DateTimeKind.Local).AddTicks(4294), new DateTime(2020, 9, 11, 11, 57, 20, 716, DateTimeKind.Local).AddTicks(9183), new DateTime(2020, 9, 11, 22, 48, 58, 391, DateTimeKind.Local).AddTicks(888), 14, "", "http://axel.info", "itaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 9, 11, 23, 23, 7, 976, DateTimeKind.Local).AddTicks(4322), new DateTime(2020, 9, 11, 14, 55, 3, 305, DateTimeKind.Local).AddTicks(6791), new DateTime(2020, 9, 12, 1, 53, 8, 280, DateTimeKind.Local).AddTicks(1831), 14, "", "http://valentin.net", "aliquam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 9, 12, 8, 2, 49, 53, DateTimeKind.Local).AddTicks(5872), new DateTime(2020, 9, 11, 12, 18, 55, 670, DateTimeKind.Local).AddTicks(9089), new DateTime(2020, 9, 12, 6, 22, 16, 663, DateTimeKind.Local).AddTicks(2507), 13, "", "http://alicia.info", "fugit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 9, 11, 18, 25, 41, 857, DateTimeKind.Local).AddTicks(6518), new DateTime(2020, 9, 12, 9, 53, 52, 46, DateTimeKind.Local).AddTicks(558), new DateTime(2020, 9, 11, 11, 21, 32, 164, DateTimeKind.Local).AddTicks(5800), 100, "", "http://hugo.org", "ipsa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 9, 12, 0, 25, 29, 737, DateTimeKind.Local).AddTicks(5908), new DateTime(2020, 9, 11, 21, 6, 23, 302, DateTimeKind.Local).AddTicks(11), new DateTime(2020, 9, 12, 3, 38, 58, 87, DateTimeKind.Local).AddTicks(1043), 13, "", "http://sarah.fr", "perferendis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 9, 12, 9, 39, 0, 552, DateTimeKind.Local).AddTicks(5204), new DateTime(2020, 9, 11, 12, 3, 34, 24, DateTimeKind.Local).AddTicks(65), new DateTime(2020, 9, 11, 15, 17, 54, 32, DateTimeKind.Local).AddTicks(8656), 11, "", "http://sacha.com", "in" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 9, 11, 12, 20, 15, 752, DateTimeKind.Local).AddTicks(276), new DateTime(2020, 9, 11, 13, 19, 47, 188, DateTimeKind.Local).AddTicks(589), new DateTime(2020, 9, 11, 17, 53, 38, 798, DateTimeKind.Local).AddTicks(8803), 10, "", "http://alice.name", "atque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 9, 12, 3, 30, 2, 636, DateTimeKind.Local).AddTicks(9003), new DateTime(2020, 9, 11, 20, 24, 8, 803, DateTimeKind.Local).AddTicks(7375), new DateTime(2020, 9, 11, 22, 10, 42, 254, DateTimeKind.Local).AddTicks(5177), 15, "", "http://léa.eu", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 9, 12, 8, 38, 59, 879, DateTimeKind.Local).AddTicks(9548), new DateTime(2020, 9, 11, 20, 29, 35, 312, DateTimeKind.Local).AddTicks(6889), new DateTime(2020, 9, 12, 6, 15, 12, 296, DateTimeKind.Local).AddTicks(6929), 9, "", "http://evan.net", "quo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 9, 12, 0, 17, 21, 667, DateTimeKind.Local).AddTicks(6167), new DateTime(2020, 9, 12, 2, 14, 32, 525, DateTimeKind.Local).AddTicks(4810), new DateTime(2020, 9, 11, 12, 9, 12, 769, DateTimeKind.Local).AddTicks(211), 6, "", "https://lisa.com", "cum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 9, 11, 11, 44, 44, 847, DateTimeKind.Local).AddTicks(3104), new DateTime(2020, 9, 12, 6, 11, 22, 593, DateTimeKind.Local).AddTicks(3723), new DateTime(2020, 9, 11, 13, 58, 12, 87, DateTimeKind.Local).AddTicks(2861), 6, "", "https://maeva.name", "corrupti" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 9, 12, 0, 3, 16, 302, DateTimeKind.Local).AddTicks(4571), new DateTime(2020, 9, 12, 0, 45, 30, 705, DateTimeKind.Local).AddTicks(61), new DateTime(2020, 9, 12, 6, 40, 27, 849, DateTimeKind.Local).AddTicks(43), 5, "", "http://marie.info", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 9, 12, 0, 26, 27, 190, DateTimeKind.Local).AddTicks(7896), new DateTime(2020, 9, 12, 5, 20, 17, 97, DateTimeKind.Local).AddTicks(7070), new DateTime(2020, 9, 11, 18, 32, 1, 879, DateTimeKind.Local).AddTicks(9319), 5, "", "https://lisa.net", "esse" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 9, 12, 2, 9, 31, 494, DateTimeKind.Local).AddTicks(6051), new DateTime(2020, 9, 12, 9, 15, 26, 165, DateTimeKind.Local).AddTicks(9448), new DateTime(2020, 9, 12, 7, 49, 29, 779, DateTimeKind.Local).AddTicks(3062), 4, "", "https://nicolas.info", "dolor" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 9, 12, 7, 17, 12, 921, DateTimeKind.Local).AddTicks(8166), new DateTime(2020, 9, 11, 12, 6, 46, 482, DateTimeKind.Local).AddTicks(1460), new DateTime(2020, 9, 11, 13, 40, 31, 931, DateTimeKind.Local).AddTicks(2979), 4, "", "http://mathilde.fr", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 9, 11, 12, 57, 26, 131, DateTimeKind.Local).AddTicks(1601), new DateTime(2020, 9, 11, 18, 7, 49, 432, DateTimeKind.Local).AddTicks(6840), new DateTime(2020, 9, 11, 11, 59, 41, 990, DateTimeKind.Local).AddTicks(6183), 3, "", "http://julien.info", "culpa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 9, 11, 18, 20, 12, 844, DateTimeKind.Local).AddTicks(7108), new DateTime(2020, 9, 11, 19, 3, 22, 493, DateTimeKind.Local).AddTicks(9930), new DateTime(2020, 9, 11, 18, 47, 33, 213, DateTimeKind.Local).AddTicks(2835), 3, "", "https://eva.net", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 9, 12, 5, 1, 37, 287, DateTimeKind.Local).AddTicks(6065), new DateTime(2020, 9, 11, 12, 27, 5, 435, DateTimeKind.Local).AddTicks(9050), new DateTime(2020, 9, 12, 7, 7, 42, 509, DateTimeKind.Local).AddTicks(2192), 9, "", "https://maeva.name", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 9, 11, 23, 44, 20, 483, DateTimeKind.Local).AddTicks(9140), new DateTime(2020, 9, 12, 8, 24, 29, 332, DateTimeKind.Local).AddTicks(4333), new DateTime(2020, 9, 11, 10, 32, 53, 613, DateTimeKind.Local).AddTicks(8430), 19, "", "https://mathis.eu", "ea" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 9, 12, 8, 19, 26, 997, DateTimeKind.Local).AddTicks(4406), new DateTime(2020, 9, 11, 10, 32, 23, 317, DateTimeKind.Local).AddTicks(2058), new DateTime(2020, 9, 11, 14, 56, 30, 807, DateTimeKind.Local).AddTicks(7191), 13, "", "http://zoe.net", "sint" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 9, 12, 9, 37, 19, 862, DateTimeKind.Local).AddTicks(3403), new DateTime(2020, 9, 12, 8, 42, 25, 978, DateTimeKind.Local).AddTicks(7767), new DateTime(2020, 9, 11, 13, 59, 26, 709, DateTimeKind.Local).AddTicks(9754), 22, "", "http://thomas.eu", "quidem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 9, 11, 20, 14, 2, 500, DateTimeKind.Local).AddTicks(3270), new DateTime(2020, 9, 11, 16, 17, 27, 790, DateTimeKind.Local).AddTicks(8317), new DateTime(2020, 9, 11, 16, 47, 10, 183, DateTimeKind.Local).AddTicks(4580), 38, "", "http://pauline.name", "quod" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 9, 11, 13, 36, 52, 912, DateTimeKind.Local).AddTicks(7312), new DateTime(2020, 9, 12, 6, 47, 39, 461, DateTimeKind.Local).AddTicks(9923), new DateTime(2020, 9, 12, 0, 17, 38, 40, DateTimeKind.Local).AddTicks(5313), 37, "", "https://léo.com", "pariatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 9, 11, 21, 33, 1, 739, DateTimeKind.Local).AddTicks(7209), new DateTime(2020, 9, 12, 4, 38, 6, 677, DateTimeKind.Local).AddTicks(7958), new DateTime(2020, 9, 12, 6, 7, 16, 185, DateTimeKind.Local).AddTicks(2538), 21, "", "https://sacha.name", "harum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 9, 12, 7, 32, 17, 777, DateTimeKind.Local).AddTicks(2590), new DateTime(2020, 9, 11, 19, 2, 37, 153, DateTimeKind.Local).AddTicks(9452), new DateTime(2020, 9, 12, 5, 13, 55, 318, DateTimeKind.Local).AddTicks(1240), 35, "", "https://théo.net", "molestiae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 9, 12, 4, 15, 20, 119, DateTimeKind.Local).AddTicks(2047), new DateTime(2020, 9, 11, 21, 16, 12, 986, DateTimeKind.Local).AddTicks(5921), new DateTime(2020, 9, 12, 2, 48, 23, 126, DateTimeKind.Local).AddTicks(2965), 35, "", "http://paul.info", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 9, 12, 1, 3, 48, 783, DateTimeKind.Local).AddTicks(578), new DateTime(2020, 9, 11, 10, 20, 20, 527, DateTimeKind.Local).AddTicks(9254), new DateTime(2020, 9, 12, 3, 58, 37, 623, DateTimeKind.Local).AddTicks(4147), 34, "", "http://adrien.net", "facere" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 9, 12, 0, 25, 36, 594, DateTimeKind.Local).AddTicks(413), new DateTime(2020, 9, 12, 0, 15, 5, 645, DateTimeKind.Local).AddTicks(2605), new DateTime(2020, 9, 11, 20, 9, 31, 513, DateTimeKind.Local).AddTicks(1426), 34, "", "http://théo.net", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 9, 12, 0, 56, 58, 760, DateTimeKind.Local).AddTicks(7392), new DateTime(2020, 9, 11, 14, 57, 34, 551, DateTimeKind.Local).AddTicks(3283), new DateTime(2020, 9, 12, 2, 15, 4, 857, DateTimeKind.Local).AddTicks(3113), 33, "", "https://enzo.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 9, 11, 14, 42, 45, 561, DateTimeKind.Local).AddTicks(7020), new DateTime(2020, 9, 12, 4, 2, 40, 556, DateTimeKind.Local).AddTicks(9593), new DateTime(2020, 9, 12, 1, 25, 23, 237, DateTimeKind.Local).AddTicks(8356), 32, "", "http://carla.name", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 9, 12, 1, 57, 44, 192, DateTimeKind.Local).AddTicks(3057), new DateTime(2020, 9, 12, 8, 18, 48, 704, DateTimeKind.Local).AddTicks(5885), new DateTime(2020, 9, 11, 11, 13, 18, 6, DateTimeKind.Local).AddTicks(2865), 36, "", "https://maxime.fr", "impedit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 9, 12, 0, 7, 32, 150, DateTimeKind.Local).AddTicks(7577), new DateTime(2020, 9, 11, 22, 37, 59, 610, DateTimeKind.Local).AddTicks(6746), new DateTime(2020, 9, 11, 16, 55, 30, 363, DateTimeKind.Local).AddTicks(23), 30, "", "http://maëlys.info", "commodi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 9, 12, 2, 39, 25, 572, DateTimeKind.Local).AddTicks(1007), new DateTime(2020, 9, 12, 4, 42, 7, 148, DateTimeKind.Local).AddTicks(5898), new DateTime(2020, 9, 11, 10, 52, 18, 7, DateTimeKind.Local).AddTicks(9703), 30, "", "https://yanis.com", "ratione" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 9, 12, 1, 2, 42, 896, DateTimeKind.Local).AddTicks(7525), new DateTime(2020, 9, 12, 9, 43, 53, 713, DateTimeKind.Local).AddTicks(3927), new DateTime(2020, 9, 12, 8, 12, 4, 676, DateTimeKind.Local).AddTicks(9669), 28, "", "http://maëlys.name", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 9, 12, 5, 49, 36, 143, DateTimeKind.Local).AddTicks(851), new DateTime(2020, 9, 11, 16, 7, 13, 336, DateTimeKind.Local).AddTicks(7110), new DateTime(2020, 9, 11, 11, 48, 29, 101, DateTimeKind.Local).AddTicks(529), 28, "", "https://axel.fr", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 9, 11, 11, 39, 25, 243, DateTimeKind.Local).AddTicks(892), new DateTime(2020, 9, 11, 21, 10, 25, 385, DateTimeKind.Local).AddTicks(173), new DateTime(2020, 9, 11, 15, 24, 2, 565, DateTimeKind.Local).AddTicks(1658), 26, "", "https://tom.net", "facere" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 9, 11, 19, 36, 5, 855, DateTimeKind.Local).AddTicks(9456), new DateTime(2020, 9, 11, 16, 50, 53, 654, DateTimeKind.Local).AddTicks(5051), new DateTime(2020, 9, 12, 1, 52, 18, 608, DateTimeKind.Local).AddTicks(9981), 26, "", "https://sarah.org", "quasi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 9, 11, 19, 14, 12, 616, DateTimeKind.Local).AddTicks(3571), new DateTime(2020, 9, 11, 21, 5, 41, 6, DateTimeKind.Local).AddTicks(7165), new DateTime(2020, 9, 11, 17, 18, 7, 542, DateTimeKind.Local).AddTicks(8071), 26, "", "http://clément.info", "iste" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 9, 12, 7, 49, 54, 144, DateTimeKind.Local).AddTicks(503), new DateTime(2020, 9, 11, 15, 53, 59, 184, DateTimeKind.Local).AddTicks(3897), new DateTime(2020, 9, 12, 6, 54, 35, 342, DateTimeKind.Local).AddTicks(8991), 24, "", "https://valentin.eu", "tempora" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 9, 11, 10, 54, 55, 320, DateTimeKind.Local).AddTicks(4947), new DateTime(2020, 9, 12, 3, 12, 57, 940, DateTimeKind.Local).AddTicks(2249), new DateTime(2020, 9, 11, 21, 14, 3, 183, DateTimeKind.Local).AddTicks(716), 22, "", "http://baptiste.org", "distinctio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 9, 12, 7, 25, 59, 180, DateTimeKind.Local).AddTicks(1170), new DateTime(2020, 9, 11, 11, 32, 20, 199, DateTimeKind.Local).AddTicks(3675), new DateTime(2020, 9, 11, 10, 39, 46, 687, DateTimeKind.Local).AddTicks(6437), 30, "", "http://adam.net", "aut" });

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
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 15, 2018, "3.5.6.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 3, null, 3, 2, 1, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 55, 2015, "9.6.6.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 63, 5, 5, null, 1, 4, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 42, 2018, "0.0.9.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 91, 2, null, 1, 3, 4, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 14, 2020, "5.0.2.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 31, 3, null, null, 4, 4, 4, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 4, 2016, "7.1.8.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 3, 1, null, 3, 4, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 94, 2014, "1.8.3.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 35, 5, 5, null, 3, 10, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 83, 2018, "8.1.7.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 19, 5, null, null, 3, 10, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 77, 2017, "5.2.6.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 50, 3, null, null, 1, 10, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 71, 2017, "8.9.9.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 5, null, null, 2, 10, 10, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 67, 2017, "5.7.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 15, 3, 7, null, 4, 10, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 65, 2017, "8.8.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 3, null, null, 2, 10, 5, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 40, 2019, "4.7.2.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 5, 5, null, 2, 10, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 39, 2020, "7.6.6.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 77, 2, null, 1, 2, 10, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 36, 2015, "3.4.3.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 86, 1, null, 2, 2, 10, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 32, 2015, "2.5.0.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 67, 2, null, null, 2, 10, 2, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 19, 2018, "6.4.4.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 35, 4, 10, null, 1, 10, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 2, 2017, "9.2.6.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 6, null, null, 1, 10, 10, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 98, 2019, "9.4.7.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 15, 4, null, null, 1, 9, 9, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 97, 2019, "6.4.2.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 3, 4, null, 2, 9, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 93, 2018, "9.2.6.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 3, null, 3, 3, 9, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 88, 2020, "1.1.3.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 4, 5, null, 4, 9, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 80, 2016, "0.7.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 70, 2, null, null, 1, 9, 10, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 56, 2017, "3.7.1.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 26, 5, null, null, 4, 4, 3, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 91, 2017, "6.0.7.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 26, 5, 1, null, 2, 4, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 5, 2016, "7.4.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 70, 4, null, null, 1, 5, 3, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 6, 2017, "4.4.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 4, null, 5, 1, 5, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 96, 2017, "2.7.4.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 3, null, 2, 2, 6, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 89, 2019, "1.6.2.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 19, 5, null, null, 2, 6, 9, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 78, 2020, "5.3.7.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 9, 3, null, 6, 3, 6, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 68, 2018, "0.8.9.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 68, 5, null, null, 3, 6, 8, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 63, 2016, "3.6.8.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 2, null, 1, 4, 6, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 51, 2018, "4.4.8.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 4, null, 4, 1, 6, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 29, 2015, "6.9.7.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 1, null, null, 2, 6, 4, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 24, 2017, "3.9.4.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 100, 4, null, 2, 4, 6, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 17, 2016, "1.7.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 86, 6, null, null, 1, 6, 9, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 9, 2018, "8.8.8.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 3, null, 3, 1, 6, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 79, 2019, "0.0.5.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 1, 9, null, 1, 9, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 86, 2018, "6.1.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 84, 5, null, null, 3, 5, 4, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 75, 2016, "6.2.7.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 8, 1, null, 1, 1, 5, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 61, 2014, "0.8.8.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 68, 1, 9, null, 1, 5, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 58, 2018, "5.2.3.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 2, 3, null, 4, 5, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 54, 2014, "6.1.9.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 84, 5, null, 6, 1, 5, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 53, 2019, "5.9.1.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 1, null, null, 3, 5, 1, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 48, 2016, "9.3.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 97, 4, null, 6, 1, 5, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 46, 2015, "9.3.5.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 5, 10, null, 2, 5, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 37, 2015, "5.7.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 4, 2, null, 2, 5, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 26, 2014, "8.7.0.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 7, null, null, 4, 5, 3, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 16, 2014, "1.8.6.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 5, 6, null, 1, 5, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 84, 2018, "7.0.3.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 61, 2, null, 6, 4, 5, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 72, 2014, "7.3.6.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 7, null, 4, 3, 9, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 100, 2020, "1.9.4.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 2, 8, null, 1, 6, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 50, 2018, "5.7.6.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 43, 3, null, null, 1, 9, 7, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 34, 2015, "0.3.1.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 3, 3, null, 4, 3, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 31, 2019, "8.4.6.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 4, 1, 4, null, 2, 3, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 30, 2018, "8.4.3.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 38, 2, null, 1, 1, 3, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 25, 2017, "1.9.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 79, 1, 3, null, 1, 3, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 23, 2018, "4.0.6.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 43, 5, null, null, 3, 3, 1, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 20, 2020, "7.6.5.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 84, 3, null, null, 2, 3, 4, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 13, 2020, "8.8.8.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 45, 7, 1, null, 1, 3, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 81, 2018, "5.2.8.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 43, 6, null, 6, 3, 2, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 73, 2014, "6.2.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 3, 8, null, 3, 2, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 66, 2015, "7.1.2.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 68, 1, null, 2, 1, 2, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 62, 2017, "6.3.5.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 0, 2, null, null, 3, 2, 6, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 49, 2018, "0.3.2.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 86, 4, 4, null, 4, 2, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 41, 2014, "5.7.7.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 32, 7, null, null, 1, 2, 1, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 27, 2019, "7.5.5.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 12, 1, null, 1, 3, 2, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 1, 2019, "2.2.7.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 29, 1, 8, null, 3, 2, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 90, 2015, "3.4.7.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 23, 7, null, 2, 2, 1, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 82, 2019, "4.4.6.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 5, 4, null, 2, 1, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 70, 2019, "0.0.7.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 18, 4, 3, null, 1, 1, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 35, 2020, "2.6.5.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 82, 2, null, null, 1, 1, 10, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 22, 2020, "5.3.8.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 7, 2, null, 3, 1, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 60, 2020, "0.9.0.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 79, 3, null, 6, 4, 9, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 38, 2019, "6.3.4.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 4, null, null, 4, 3, 9, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 59, 2014, "2.1.8.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 86, 5, null, null, 1, 3, 9, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 76, 2017, "4.7.3.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 2, 3, null, 2, 2, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 87, 2017, "3.4.1.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 26, 3, null, 6, 2, 3, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 64, 2020, "9.3.9.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 63, 5, 3, null, 1, 3, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 21, 2020, "6.2.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 2, null, 1, 4, 9, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 7, 2017, "5.9.3.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 77, 7, 1, null, 3, 9, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 3, 2020, "5.7.3.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 52, 6, null, 6, 4, 9, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 99, 2020, "8.7.4.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 16, 7, null, 1, 1, 8, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 95, 2020, "9.0.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 7, 5, null, null, 4, 8, 10, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 92, 2015, "4.2.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 93, 7, null, null, 3, 8, 1, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 45, 2018, "5.8.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 64, 6, null, 1, 4, 8, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 43, 2016, "6.4.5.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 72, 5, 2, null, 4, 8, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 33, 2019, "2.3.6.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 91, 4, null, 2, 1, 8, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 28, 2017, "7.6.0.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 5, 6, null, 3, 8, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 57, 2016, "6.5.9.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 76, 2, null, 2, 1, 8, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 44, 2020, "5.1.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 72, 4, null, null, 3, 9, 10, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 12, 2016, "3.0.5.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 46, 2, null, 2, 2, 8, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 11, 2019, "7.9.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 7, null, null, 3, 7, 1, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 18, 2016, "1.4.6.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 36, 6, null, 2, 2, 7, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 47, 2019, "5.4.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 7, null, null, 2, 7, 2, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 52, 2019, "0.4.9.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 70, 7, 9, null, 3, 7, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 8, 2016, "9.3.9.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 11, 5, null, null, 1, 7, 2, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 74, 2015, "2.9.5.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 1, null, null, 3, 7, 1, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 85, 2016, "2.1.0.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 100, 3, 5, null, 2, 7, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 10, 2019, "8.2.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 24, 2, 6, null, 2, 8, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 69, 2014, "2.8.2.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 69, 1, null, 4, 1, 7, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "fuga", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 71, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "sed", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 31, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "inventore", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 42, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "provident", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 42, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "aliquid", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 30, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "corrupti", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 35, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "accusantium", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 20, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "porro", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 13, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "quidem", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 13, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "dolore", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 71, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "hic", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 51, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 60, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "sunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 32, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "tempora", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 52, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "magnam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 46, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 58, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "eaque", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 58, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "cupiditate", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 58, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "in", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 58, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "temporibus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 17, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "debitis", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 10, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "ullam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 71, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "nisi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 11, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 93, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "quod", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 62, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "sunt", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 51, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "harum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 95, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "possimus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 94, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "voluptas", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 67, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "quia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 67, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "aperiam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 67, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "dicta", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 3, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "qui", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "odit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "aut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 87, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "qui", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 8, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "omnis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 78, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "distinctio", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 53, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "assumenda", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 26, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "consectetur", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 26, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "ab", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 86, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "provident", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 86, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "sit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 1, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "unde", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 1, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 1, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "dolore", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 92, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "modi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 92, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "dolores", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 98, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "praesentium", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 44, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "molestias", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 23, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "sunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 80, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "tenetur", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 61, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "maxime", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 59, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "rem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 56, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "vel", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 99, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "repudiandae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 99, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "eos", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 75, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "sed", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 75, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "aspernatur", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 27, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "at", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 28, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "beatae", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 66, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 64, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 64, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "blanditiis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 36, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "eum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 85, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "rem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 85, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "ut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 85, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "odit", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 68, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "totam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "sunt", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 100, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "sit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 100, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "est", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 57, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "natus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 61, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "recusandae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 9, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "nostrum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 5, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "omnis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 43, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "eius", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 12, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "quam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 12, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "ea", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 45, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "mollitia", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 45, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "maxime", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 45, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "sit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 74, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "omnis", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 96, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "suscipit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 96, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "deleniti", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 96, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "incidunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 69, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 44, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "et", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 40, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "molestias", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 25, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "quam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 41, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "unde", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 19, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "ducimus", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 19, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "ea", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 19, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "consectetur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 91, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 91, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "eius", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 47, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "sit", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 47, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "incidunt", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 23, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "vitae", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 49, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "est", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 57, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/interface/productize", 6, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/coordinator/front-end/online", 6, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/tactics", 4, 70 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/compatible", 5, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/1080p", 2, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/steel", 1, 45 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/handcrafted-steel-pants/5th-generation", 7, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/tcp/ib", 2, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/product/glens", 7, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/us-dollar", 2, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/burundi-franc", 6, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/liaison", 7, 28 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/sexy", 1, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/savings-account", 4, 80 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/cambridgeshire", 5, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/agent/awesome-fresh-towels/outdoors", 1, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/visionary", 6, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/holistic", 7, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/communities/sensor/trail", 7, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/nepalese-rupee/yellow/infrastructures", 3, 49 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/awesome-concrete-soap", 7, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/usability", 6, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/deploy/credit-card-account", 5, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/deposit", 1, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/assurance", 6, 99 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/vortals", 7, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/neural", 7, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/upgradable/mill/visionary", 3, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/matrix/hack", 1, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/panama", 1, 93 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/licensed-rubber-cheese", 2, 18 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/associate/markets", 3, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/common/locks", 4, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/cayman-islands/ergonomic", 6, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/copy", 5, 38 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/functionality", 2, 67 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/rubber/collaboration", 6, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/libyan-dinar/enable", 4, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/digital/applications", 3, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/synthesize/auto-loan-account/buckinghamshire", 7, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/intelligent-cotton-bacon/baby-automotive--tools", 5, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/web/direct/home-loan-account", 5, 95 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/home", 3, 40 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/tunnel/electronics-beauty--computers", 1, 51 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/help-desk/grey/content", 7, 46 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/manager", 7, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/plum", 5, 52 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/practical-soft-cheese", 1, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/payment/district", 7, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/logistical/compressing/incremental", 4, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/smtp/solomon-islands/investor", 2, 12 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/revolutionary/granite/computers", 6, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/withdrawal/via/intermediate", 2, 50 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/roi", 3, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/transmitter/synchronised", 5, 33 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/credit-card-account", 3, 33 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/program/auxiliary/transmit", 7, 33 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/buckinghamshire", 6, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/intuitive", 7, 73 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/directives/plaza/solutions", 1, 42 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/buckinghamshire/regional", 3, 42 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/invoice/generic-frozen-keyboard", 2, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/relationships", 2, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/centralized", 3, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/hacking/deposit", 7, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/nuevo-sol/synergies/facilitate", 1, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/grocery", 2, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/throughput/licensed-wooden-gloves/saudi-riyal", 3, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/ssl/website/blockchains", 6, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/jbod/evolve", 4, 79 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/green/borders/input", 6, 87 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/garden-computers--grocery/encompassing", 3, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/http/avon/red", 4, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/home-loan-account/sleek-rubber-soap", 4, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/hacking/buckinghamshire/payment", 3, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/e-commerce", 3, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/operations/berkshire/northern-mariana-islands", 7, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/human-resource", 1, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/camp/scalable/backing-up", 7, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/concrete/functionalities", 2, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/deposit/pci/berkshire", 3, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/research", 6, 20 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/sticky", 1, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/bolivia", 6, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/payment/best-of-breed/operations", 2, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/capacitor/investor", 4, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/array/holistic", 2, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/designer/licensed-rubber-tuna/berkshire", 1, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/mill/views/ergonomic-granite-tuna", 4, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/orange/e-tailers/json", 2, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/rubber/rustic-rubber-chips/knowledge-base", 1, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/middleware", 3, 41 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/247", 1, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/withdrawal", 1, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/internal/refined/hills", 6, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/trail/intelligent-wooden-bacon/naira", 1, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/personal-loan-account", 1, 83 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/247/png", 2, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/soft/e-markets", 6, 25 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/orchid/refined/facilitator", 3, 53 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 6, new DateTime(2020, 6, 24, 5, 5, 39, 624, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 2, new DateTime(2020, 6, 28, 16, 41, 13, 475, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 5, new DateTime(2020, 6, 5, 22, 50, 3, 332, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 1, new DateTime(2020, 7, 24, 17, 50, 7, 830, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 6, new DateTime(2020, 5, 16, 23, 51, 24, 520, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 1, new DateTime(2019, 10, 6, 18, 23, 23, 160, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 4, new DateTime(2020, 4, 19, 4, 29, 31, 32, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 4, new DateTime(2020, 3, 7, 22, 23, 29, 305, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 4, new DateTime(2020, 1, 14, 14, 4, 28, 928, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 1, new DateTime(2020, 5, 29, 14, 7, 5, 745, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 2, new DateTime(2020, 7, 6, 14, 22, 57, 707, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 5, new DateTime(2019, 10, 29, 21, 48, 2, 903, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 5, new DateTime(2020, 3, 25, 18, 27, 41, 728, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 1, new DateTime(2019, 10, 11, 21, 44, 2, 657, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 4, new DateTime(2020, 7, 26, 9, 20, 35, 12, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 1, new DateTime(2020, 3, 29, 13, 35, 9, 658, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 6, new DateTime(2020, 3, 25, 19, 14, 33, 73, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 4, new DateTime(2020, 9, 6, 6, 16, 46, 159, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 4, new DateTime(2019, 10, 16, 21, 57, 22, 930, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 1, new DateTime(2020, 4, 7, 14, 13, 29, 490, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 3, new DateTime(2019, 9, 13, 4, 55, 45, 437, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 1, new DateTime(2020, 8, 21, 6, 52, 21, 899, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 3, new DateTime(2020, 1, 16, 17, 10, 58, 759, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 1, new DateTime(2020, 1, 18, 12, 8, 46, 472, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 4, new DateTime(2020, 7, 5, 5, 41, 45, 789, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 6, new DateTime(2020, 8, 13, 18, 50, 2, 74, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 5, new DateTime(2020, 4, 26, 4, 11, 4, 620, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 5, new DateTime(2020, 6, 2, 14, 10, 57, 630, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 1, new DateTime(2020, 4, 1, 10, 4, 27, 273, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 1, new DateTime(2019, 11, 17, 4, 32, 59, 195, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 4, new DateTime(2020, 3, 13, 6, 24, 22, 623, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 2, new DateTime(2020, 8, 1, 9, 46, 53, 141, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 4, new DateTime(2020, 8, 23, 18, 3, 37, 962, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 4, new DateTime(2020, 8, 29, 16, 47, 36, 380, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 6, new DateTime(2020, 7, 30, 14, 34, 40, 624, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 6, new DateTime(2020, 2, 6, 5, 48, 24, 769, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 6, new DateTime(2020, 1, 3, 15, 26, 54, 374, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 4, new DateTime(2019, 11, 11, 15, 40, 32, 468, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 3, new DateTime(2020, 5, 30, 16, 21, 55, 182, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 4, new DateTime(2019, 12, 20, 20, 27, 59, 659, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 6, new DateTime(2019, 11, 11, 18, 52, 56, 94, DateTimeKind.Local).AddTicks(1192) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 5, new DateTime(2019, 10, 7, 18, 7, 59, 165, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 3, new DateTime(2020, 2, 14, 8, 18, 31, 70, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 2, new DateTime(2019, 10, 31, 14, 22, 40, 493, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 6, new DateTime(2019, 12, 9, 16, 25, 3, 150, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 3, new DateTime(2020, 3, 29, 8, 31, 15, 35, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 2, new DateTime(2020, 4, 19, 14, 0, 10, 392, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 2, new DateTime(2020, 7, 17, 10, 37, 23, 434, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 3, new DateTime(2020, 8, 1, 16, 37, 39, 216, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 3, new DateTime(2019, 12, 18, 12, 28, 38, 567, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 1, new DateTime(2020, 6, 6, 20, 59, 41, 785, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 6, new DateTime(2019, 11, 27, 16, 10, 40, 97, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 6, new DateTime(2020, 3, 2, 10, 22, 38, 548, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 1, new DateTime(2020, 9, 9, 3, 15, 4, 204, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 5, new DateTime(2019, 10, 10, 20, 43, 49, 881, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 1, new DateTime(2020, 1, 7, 14, 6, 53, 908, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 1, new DateTime(2020, 3, 9, 23, 5, 15, 139, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 3, new DateTime(2020, 9, 6, 22, 51, 38, 131, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 4, new DateTime(2019, 11, 14, 5, 43, 8, 2, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 6, new DateTime(2019, 11, 13, 22, 56, 28, 385, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 3, new DateTime(2020, 8, 11, 19, 16, 42, 221, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 3, new DateTime(2020, 7, 29, 12, 24, 4, 109, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 3, new DateTime(2020, 5, 28, 9, 22, 59, 524, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 3, new DateTime(2020, 2, 20, 3, 24, 20, 733, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 4, new DateTime(2019, 9, 20, 18, 56, 14, 271, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 3, new DateTime(2020, 4, 20, 9, 55, 29, 909, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 2, new DateTime(2019, 10, 14, 21, 43, 57, 768, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 6, new DateTime(2020, 1, 7, 10, 42, 15, 488, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 2, new DateTime(2020, 1, 10, 18, 45, 49, 390, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 4, new DateTime(2019, 11, 25, 16, 56, 31, 897, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 3, new DateTime(2020, 2, 10, 12, 6, 17, 184, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 3, new DateTime(2020, 7, 5, 3, 50, 5, 456, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 6, new DateTime(2020, 4, 4, 14, 5, 20, 5, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 4, new DateTime(2020, 7, 5, 12, 54, 26, 763, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 3, new DateTime(2020, 9, 8, 3, 42, 0, 377, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 1, new DateTime(2020, 6, 23, 17, 20, 18, 90, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 2, new DateTime(2020, 4, 28, 15, 47, 23, 285, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 5, new DateTime(2019, 11, 5, 20, 25, 50, 601, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 1, new DateTime(2020, 8, 12, 23, 19, 47, 162, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 5, new DateTime(2019, 12, 16, 10, 4, 33, 700, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 2, new DateTime(2019, 11, 18, 0, 49, 59, 605, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 4, new DateTime(2019, 9, 26, 13, 6, 56, 199, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 6, new DateTime(2020, 4, 23, 6, 57, 14, 270, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 4, new DateTime(2020, 7, 29, 20, 3, 47, 106, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 2, new DateTime(2020, 3, 19, 6, 40, 35, 84, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 5, new DateTime(2020, 8, 2, 20, 45, 19, 344, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 1, new DateTime(2019, 9, 12, 10, 31, 15, 500, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 3, new DateTime(2020, 3, 10, 18, 9, 28, 282, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 5, new DateTime(2019, 10, 19, 8, 19, 33, 530, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 2, new DateTime(2019, 12, 7, 8, 52, 4, 573, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 3, new DateTime(2020, 4, 9, 12, 17, 10, 196, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 2, new DateTime(2020, 1, 7, 21, 27, 47, 46, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 1, new DateTime(2020, 7, 26, 3, 38, 55, 383, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 5, new DateTime(2020, 6, 29, 11, 30, 45, 543, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 5, new DateTime(2020, 6, 16, 13, 22, 10, 659, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 1, new DateTime(2020, 6, 2, 14, 10, 37, 221, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 5, new DateTime(2019, 12, 11, 11, 14, 25, 121, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 6, new DateTime(2019, 12, 28, 17, 40, 14, 187, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 1, new DateTime(2019, 12, 5, 21, 46, 17, 287, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 3, new DateTime(2020, 3, 24, 20, 17, 57, 179, DateTimeKind.Local).AddTicks(7099) });

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
