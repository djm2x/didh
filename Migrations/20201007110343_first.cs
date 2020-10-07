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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(nullable: true),
                    LabelAr = table.Column<string>(nullable: true),
                    Abv = table.Column<string>(nullable: true),
                    AbvAr = table.Column<string>(nullable: true)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(nullable: true),
                    LabelAr = table.Column<string>(nullable: true),
                    Abv = table.Column<string>(nullable: true),
                    AbvAr = table.Column<string>(nullable: true)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(nullable: true),
                    LabelAr = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    NomAr = table.Column<string>(nullable: true),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    NomAr = table.Column<string>(nullable: true),
                    CodeRecommendation = table.Column<string>(nullable: true),
                    CodeRecommendationAr = table.Column<string>(nullable: true),
                    Mecanisme = table.Column<string>(nullable: true),
                    IdCycle = table.Column<int>(nullable: true),
                    IdAxe = table.Column<int>(nullable: true),
                    IdSousAxe = table.Column<int>(nullable: true),
                    IdOrgane = table.Column<int>(nullable: true),
                    IdVisite = table.Column<int>(nullable: true),
                    IdPays = table.Column<int>(nullable: true),
                    Etat = table.Column<string>(nullable: true),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: false),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                columns: new[] { "Id", "Abv", "AbvAr", "Label", "LabelAr" },
                values: new object[,]
                {
                    { 1, "Développement démocratique et primauté du Droit", "", "la promotion, le développement démocratique et la primauté du droit", "تعزيز البناء الديمقراطي وسيادة القانون" },
                    { 2, "Interaction avec SNU des DH", "", "l’interaction avec le système onusien des droits de l'homme", "مواصلة الانخراط والتعاون مع المنظومة الأممية لحقوق الإنسان" },
                    { 3, "Harmonisation Juridique", "", "la promotion et la protection des droits de l'homme, à travers la législation et l’harmonisation avec les normes internationales, constitué d’un sous-thème se rapportant à la législation", "النهوض بحقوق الإنسان وحمايتها عبر التشريع والملاءمة مع المعايير الدولية" },
                    { 4, "DESC", "", "la promotion des droits économiques, sociaux, culturels et environnementaux", "النهوض بالحقوق الاقتصادية والاجتماعية والثقافية والبيئية" },
                    { 5, "Droits civils et Politiques", "", "la protection et la promotion des droits civils et politiques", "حماية الحقوق المدنية والسياسية والنهوض بها" },
                    { 6, "Droits Catégoriels ", "", "la promotion et la protection des droits catégoriels", "النهوض بالحقوق الفئوية وحمايتها" },
                    { 7, "Education et culture des DH", "", "la promotion de la culture des droits de l'homme par l'éducation et la formation", "النهوض بثقافة حقوق الإنسان من خلال التربية والتكوين" },
                    { 8, "Cadre institutionnel des DH", "", "la promotion du cadre institutionnel pour la protection et la promotion des droits de l'homme", "الإطار المؤسساتي لحماية حقوق الإنسان والنهوض بها" },
                    { 9, "Recommandations d'ordre général", "", "des recommandations d'ordre général", "التوصيات العامة" }
                });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 1, "3ème cycle (2017-2022)", "الجولة الثالثة من آلية الاستعراض الدوري الشامل  )شتنبر 2017)" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[,]
                {
                    { 10, "Categorie 1", new DateTime(2020, 5, 11, 4, 29, 29, 192, DateTimeKind.Local).AddTicks(8774), "Dolores ipsa dolorum. Officia autem vero sit ex quasi molestias blanditiis. Quo soluta harum. Ut distinctio sunt aliquam iste. Aut saepe et rerum quo. Numquam distinctio adipisci et eveniet officiis praesentium omnis natus vel. Aspernatur ipsum ad. Officia aspernatur consequatur facilis praesentium quia. Voluptatem ex cum. Culpa minus est assumenda a molestiae qui voluptate eos.", "perferendis" },
                    { 9, "Categorie 1", new DateTime(2020, 6, 22, 9, 46, 38, 841, DateTimeKind.Local).AddTicks(7220), "Occaecati tempore rerum. Quia consectetur praesentium facere ullam. Voluptas quo reprehenderit ipsum rerum sint sint ipsam est porro. Laboriosam et sit tempore fugit. Impedit similique molestias consequatur aut doloremque vitae voluptatem. Non sapiente odit est repellendus voluptatem quo est odit. Soluta impedit quia earum voluptatem. Sit reiciendis est sit consequatur iste tempore explicabo. Facere sit autem et dignissimos nobis nemo. Debitis officia tenetur quia debitis non aut et quia. Ea et tenetur et. Atque explicabo omnis illo ea eos tenetur quis.", "voluptatibus" },
                    { 8, "Categorie 1", new DateTime(2020, 9, 25, 9, 40, 45, 882, DateTimeKind.Local).AddTicks(1403), "Quisquam ea fugiat ipsa architecto dolor dolor corrupti deserunt aliquid. Facilis vel magni pariatur. Quibusdam non suscipit ipsam tempora quaerat ea. Reprehenderit architecto temporibus odio voluptatum vel id molestias. Vel animi quo perspiciatis totam nemo. Cumque voluptatem at aut nostrum fuga quam id. Et repellendus neque nam mollitia expedita praesentium repellat odit et. Reprehenderit id perferendis dolor maxime quisquam consectetur iusto non perferendis. Sit modi et. Sapiente ea voluptatum iusto voluptas expedita amet. Omnis accusantium dignissimos nulla eos est eos. Iusto vel nemo ipsam delectus dolore architecto eos similique. Voluptatibus architecto aut nulla blanditiis itaque.", "repellat" },
                    { 7, "Categorie 1", new DateTime(2020, 1, 28, 14, 9, 2, 648, DateTimeKind.Local).AddTicks(4207), "Et iusto ut ratione voluptatum dolores hic dolorum. Aut natus nostrum eveniet quisquam voluptatum quia facere. Blanditiis eius omnis qui. Quaerat odio aut aliquam. Enim sit temporibus ut saepe. Numquam odit vero et hic beatae nihil. Cumque ea molestias doloribus facilis minus. Beatae qui quae. Enim voluptates eius adipisci reiciendis impedit deserunt et distinctio nemo. Sit sit qui exercitationem quas consequatur voluptatem. Adipisci autem excepturi vel rerum. Facere ducimus ut occaecati enim ut minus maxime perspiciatis qui.", "qui" },
                    { 6, "Categorie 1", new DateTime(2020, 7, 29, 7, 31, 33, 603, DateTimeKind.Local).AddTicks(6810), "Et maxime voluptatum qui impedit aut unde distinctio ducimus quia. Eum consequuntur dolores nostrum fuga asperiores quo amet molestias. Sed voluptas deleniti in iusto temporibus. Error accusamus eveniet. Qui consequuntur sunt tenetur. Quo ipsum id sit eius sit sunt. Officiis omnis doloribus. Voluptas quisquam nihil nihil omnis molestias iure. Asperiores nihil ad sit ut explicabo culpa molestiae in expedita. Ea suscipit quasi. Perspiciatis qui quos velit sed.", "saepe" },
                    { 5, "Categorie 1", new DateTime(2020, 8, 17, 16, 30, 47, 997, DateTimeKind.Local).AddTicks(3519), "Blanditiis perspiciatis molestias. Veritatis ex magni et aut. Qui ut est magni fugiat. Est autem enim magnam aut quibusdam perferendis repudiandae dolorum. Inventore illum quaerat nobis et quasi asperiores at laborum dolore. Fuga commodi eius labore voluptate voluptas voluptatum aperiam. Nihil sit aperiam. Debitis qui dolor excepturi doloribus. Provident deserunt qui architecto exercitationem ipsam distinctio quis. Voluptas ad officiis occaecati officia eaque aspernatur perferendis. Perferendis cumque aperiam. Debitis ut similique debitis dolor eveniet consequatur. Necessitatibus atque et tenetur porro.", "ducimus" },
                    { 4, "Categorie 1", new DateTime(2019, 12, 29, 13, 57, 22, 57, DateTimeKind.Local).AddTicks(7832), "Inventore magni sunt ullam et exercitationem. Facilis repellat sint nisi. Eum molestias dolores qui corporis. Nostrum eum sed asperiores laboriosam pariatur quia. Est illum ipsam quaerat. Repudiandae accusantium soluta adipisci fuga aut cumque et. Dolorum odio sed quibusdam nisi ut eos quis nobis. Veniam nihil occaecati possimus tenetur et. Labore reiciendis molestiae sunt consequatur sit id repellendus molestiae. Voluptatem enim accusamus magni animi.", "consequatur" },
                    { 3, "Categorie 1", new DateTime(2020, 10, 7, 11, 23, 5, 579, DateTimeKind.Local).AddTicks(2472), "Dolores laborum quia qui maiores voluptatem ipsa minima mollitia autem. Minima labore laudantium sit velit ut non quis iste dolores. Molestiae et quod id. Et minima quo perspiciatis qui aut incidunt aperiam doloribus in. Iste facere rerum delectus quidem et. Saepe consequatur ut sit aut qui repellendus et ut. Eveniet sit quos voluptas dolore et ut repellat omnis. Et nemo consequatur molestiae consectetur. Cupiditate et sed libero ipsum animi repellat. Nulla minus quisquam dolorem ipsum aliquam possimus aut alias. Eos consequatur vitae provident enim nobis. Delectus debitis dolor sed officia.", "repudiandae" },
                    { 2, "Categorie 1", new DateTime(2019, 10, 8, 11, 6, 23, 452, DateTimeKind.Local).AddTicks(632), "Voluptatem ut sint. Corrupti fuga numquam placeat eos quidem. Ipsam et tempore nostrum dolorum molestias voluptatum est accusamus sed. Excepturi qui voluptatibus aut sequi natus. Hic et sit corporis non. Facere reiciendis aut enim id. Quas dolores ut soluta illo. Et suscipit et omnis ea harum repellendus eveniet eos. Veritatis atque vel rem et vel repudiandae maiores expedita. Deserunt quia ut. Et dolorem ipsum id cumque a perspiciatis est. Et ut tempora facere ipsum dolore optio sint enim corrupti.", "ea" },
                    { 1, "Categorie 1", new DateTime(2019, 11, 19, 13, 35, 39, 268, DateTimeKind.Local).AddTicks(6126), "Iste cum quia sapiente dolores eligendi qui tenetur et autem. Consequuntur exercitationem quasi animi debitis laborum. Omnis iure facilis omnis non itaque. Voluptatem neque voluptate repellat iste. Iure harum qui ut. In ea explicabo ipsum quisquam. Aut laboriosam enim fugit voluptatibus. Alias ut blanditiis consequatur sed. Ex dolor maxime. Est incidunt provident minus. Enim nam sit quos voluptatum et tempora deleniti magnam ex. Nam quis libero deserunt et labore veniam.", "saepe" }
                });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "LibelleAr", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[,]
                {
                    { 1, "", "", "Examen-2", "مراجعة-2", "", "", "", "" },
                    { 2, "", "", "Examen-3", "مراجعة-3", "", "", "", "" },
                    { 3, "", "", "Examen-4", "مراجعة-4", "", "", "", "" },
                    { 4, "", "", "Examen-5", "مراجعة-5", "", "", "", "" },
                    { 5, "", "", "Examen-6", "مراجعة-6", "", "", "", "" },
                    { 6, "", "", "Examen-7", "مراجعة-7", "", "", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Organes",
                columns: new[] { "Id", "Abv", "AbvAr", "Label", "LabelAr" },
                values: new object[,]
                {
                    { 9, "SPT", "SPT", "Le Sous-Comité pour la prévention de la torture (SPT)", "اللجنة الفرعية لمنع التعذيب (SPT)" },
                    { 8, "CRPD", "CRPD", "Comité des droits des personnes handicapées (CRPD)", "اللجنة المعنية بحقوق الأشخاص ذوي الإعاقة (CRPD)" },
                    { 7, "CRC", "CRC", "Le Comité des droits de l'enfant (CRC)", "لجنة حقوق الطفل (CRC)" },
                    { 6, "CEDAW", "CEDAW", "Le Comité pour l'élimination de la discrimination à l'égard des femmes (CEDAW)", "لجنة القضاء على التمييز ضد المرأة (CEDAW)" },
                    { 4, "CESCR", "CESCR", "Le Comité des droits économiques, sociaux et culturels  (CESCR)", "لجنة الحقوق الاقتصادية والاجتماعية والثقافية (CESCR)" },
                    { 3, "CCPR", "CCPR", "Le Comité des droits de l'homme (CCPR)", "اللجنة المعنية بحقوق الإنسان (CCPR)" },
                    { 2, "CAT", "CAT", "Le Comité contre la torture (CAT)", "لجنة مناهضة التعذيب (CAT)" },
                    { 1, "CERD", "CERD", "Le Comité pour l’élimination de la discrimination raciale (CERD)", "لجنة القضاء على التمييز العنصري (CERD)" },
                    { 5, "CMW", "CMW", "Le Comité des travailleurs migrants (CMW)", "اللجنة المعنية بالعمال المهاجرين (CMW)" }
                });

            migrationBuilder.InsertData(
                table: "Organismes",
                columns: new[] { "Id", "Adresse", "Label", "LabelAr", "Tel", "Type" },
                values: new object[,]
                {
                    { 28, "", "Justice", "العدل", "", "PE" },
                    { 29, "", "Marocains Résidant à l’Etranger", "المغاربة المقيمون بالخارج", "", "PE" },
                    { 30, "", "Médiateur", "الوسيط", "", "IN" },
                    { 31, "", "Observatoire National des Droits de l’Enfant", "المرصد الوطني لحقوق الطفل", "", "Autre" },
                    { 32, "", "Parlement", "البرلمان", "", "Autre" },
                    { 33, "", "Santé", "الصحة", "", "PE" },
                    { 34, "", "Tourisme", "السياحة", "", "PE" },
                    { 35, "", "Transport", "النقل", "", "PE" },
                    { 36, "", "IRCAM", "المعهد الملكي للثقافة الأمازيغية", "", "IN" },
                    { 38, "", "Relations avec parlement", "العلاقات مع البرلمان", "", "PE" },
                    { 39, "", "Agriculture", "الفلاحة", "", "PE" },
                    { 40, "", "Education nationale", "التربية الوطنية", "", "PE" },
                    { 43, "", "ANELCA", "الوكالة الوطنية لمحاربة الأمية", "", "Autre" },
                    { 44, "", "Conseil Supérieur de l’Education, de la Formation et de la Recherche Scientifique", "المجلس الأعلى للتربية والتكوين والبحث العلمي", "", "IN" },
                    { 45, "", "Conseil Economique Social et Environnemental", "المجلس الاقتصادي والاجتماعي والبيئي", "", "IN" },
                    { 46, "", "Environnement", "البيئة", "", "PE" },
                    { 47, "", "Pêche maritime", "الصيد البحري", "", "PE" },
                    { 48, "", "Conseil de la communauté marocaine à l’étranger", "مجلس الجالية المغربية بالخارج", "", "IN" },
                    { 49, "", "ONGs", "undefined", "", "" },
                    { 50, "", "Partis Politiques", "undefined", "", "" },
                    { 51, "", "Affaires générales du gouvernement", "undefined", "", "" },
                    { 52, "", "Rabita Mohammedia des Oulémas", "undefined", "", "" },
                    { 53, "", "Eaux et Forets", "undefined", "", "PE" },
                    { 41, "", "Formation professionnelle", "التكوين المهني", "", "PE" },
                    { 27, "", "Jeunesse et Sports", "الشباب والرياضة", "", "PE" },
                    { 42, "", "Enseignement supérieur", "التعليم العالي", "", "PE" },
                    { 25, "", "HACA", "الهيأة العليا للاتصال السمعي البصري", "", "PE" },
                    { 1, "", "HCP", "المندوبية السامية للتخطيط", "", "IN" },
                    { 2, "", "INPPLC", "الهيئة الوطنية للنزاهة و الوقاية من الرشوة و محاربتها", "", "IN" },
                    { 3, "", "Affaires Etrangères", "الشؤون الخارجية", "", "PE" },
                    { 4, "", "CNDH", "المجلس الوطني لحقوق الإنسان", "", "IN" },
                    { 5, "", "Communication", "الاتصال", "", "PE" },
                    { 6, "", "Présidence du Ministère Public", "رئاسة النيابة العامة", "", "PJ" },
                    { 7, "", "Chef du Gouvernement", "رئاسة الحكومة", "", "PE" },
                    { 8, "", "Commerce et Industrie", "التجارة والصناعة", "", "PE" },
                    { 9, "", "Conseil Supérieur de l’Autorité Judiciaire", "المجلس الأعلى للسلطة القضائية", "", "PJ" },
                    { 11, "", "Défense Nationale", "الدفاع الوطني", "", "PE" },
                    { 26, "", "Intérieur", "الداخلية", "", "PE" },
                    { 12, "", "Développement Social et Solidarité", "التنمية الاجتماعية والتضامن", "", "PE" },
                    { 10, "", "Culture", "الثقافة", "", "PE" },
                    { 14, "", "DGSN", "الأمن الوطني", "", "PE" },
                    { 24, "", "Habous et des Affaires Islamiques", "الأوقاف والشؤون الإسلامية", "", "PE" },
                    { 23, "", "Habitat", "السكنى", "", "PE" },
                    { 13, "", "DGAPR", "إدارة السجون", "", "PE" },
                    { 21, "", "Fonction Publique", "الوظيفة العمومية", "", "PE" },
                    { 20, "", "Equipement", "التجهيز", "", "PE" },
                    { 22, "", "Gendarmerie Royale", "الدرك الملكي", "", "PE" },
                    { 18, "", "Emploi", "الشغل", "", "PE" },
                    { 17, "", "Economie et Finances", "الاقتصاد والمالية", "", "PE" },
                    { 16, "", "Eau", "الماء", "", "PE" },
                    { 15, "", "Droits de l’Homme", "حقوق الإنسان", "", "PE" },
                    { 19, "", "Energie et Mines", "الطاقة والمعادن", "", "PE" }
                });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[,]
                {
                    { 10, 2020, "", "", "Session 10", "جلسة 10" },
                    { 15, 2020, "", "", "Session 15", "جلسة 15" },
                    { 14, 2020, "", "", "Session 14", "جلسة 14" },
                    { 13, 2020, "", "", "Session 13", "جلسة 13" },
                    { 12, 2020, "", "", "Session 12", "جلسة 12" },
                    { 11, 2020, "", "", "Session 11", "جلسة 11" },
                    { 9, 2020, "", "", "Session 9", "جلسة 9" },
                    { 6, 2020, "", "", "Session 6", "جلسة 6" },
                    { 7, 2020, "", "", "Session 7", "جلسة 7" },
                    { 8, 2020, "", "", "Session 8", "جلسة 8" },
                    { 5, 2020, "", "", "Session 5", "جلسة 5" },
                    { 4, 2020, "", "", "Session 4", "جلسة 4" },
                    { 3, 2020, "", "", "Session 3", "جلسة 3" },
                    { 2, 2020, "", "", "Session 2", "جلسة 2" },
                    { 1, 2020, "", "", "Session 1", "جلسة 1" }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Id", "Nom", "NomAr" },
                values: new object[,]
                {
                    { 68, "Pakistan", "باكستان" },
                    { 69, "Paraguay", "باراغواي" },
                    { 70, "Pays-Bas", "هولندا" },
                    { 73, "Portugal", "البرتغال" },
                    { 72, "Philippines", "الفلبين" },
                    { 67, "Ouganda", "أوغندا" },
                    { 74, "Qatar", "دولة قطر" },
                    { 75, "République centrafricaine", "جمهورية أفريقيا الوسطى" },
                    { 71, "Pérou", "بيرو" },
                    { 66, "Oman", "سلطنة عمان" },
                    { 61, "Monténégro", "الجبل الأسود" },
                    { 63, "Namibie", "ناميبيا" },
                    { 62, "Myanmar", "ميانمار" },
                    { 60, "Mexique", "المكسيك" },
                    { 59, "Mauritanie", "موريتانيا" },
                    { 58, "Maurice", "موريشيوس" },
                    { 54, "Liban", "لبنان" },
                    { 57, "Maldives", "جزر المالديف" },
                    { 56, "Madagascar", "مدغشقر" },
                    { 55, "Libye", "ليبيا" },
                    { 76, "République de Corée", "جمهورية كوريا" },
                    { 64, "Niger", "النيجر" },
                    { 77, "République démocratique populaire lao", "جمهورية لاو الديمقراطية الشعبية" },
                    { 98, "Zambie", "زامبيا" },
                    { 79, "Roumanie", "رومانيا" },
                    { 53, "Lettonie", "لاتفيا" },
                    { 101, "Irlande", "أيرلندا" },
                    { 100, "Arménie", "أرمينيا" },
                    { 99, "Sri Lanka", "سيريلانكا" },
                    { 97, "Yémen", "اليمن" },
                    { 96, "Viet Nam", "فييت نام" },
                    { 95, "Ukraine", "أوكرانيا" },
                    { 94, "Turquie", "تركيا" },
                    { 93, "Tunisie", "تونس" },
                    { 92, "Togo", "توجو" },
                    { 78, "République islamique d’Iran", "جمهورية ايران الاسلامية" },
                    { 91, "Thaïlande", "تايلاند" },
                    { 89, "Suède", "السويد" },
                    { 88, "Soudan du Sud", "جنوب السودان" },
                    { 87, "Soudan", "السودان" },
                    { 86, "Slovénie", "سلوفينيا" },
                    { 85, "Singapour", "سنغافورة" },
                    { 84, "Sierra Leone", "سيراليون" },
                    { 83, "Serbie", "صربيا" },
                    { 82, "Sénégal", "السنغال" },
                    { 81, "Rwanda", "رواندا" },
                    { 80, "Royaume-Uni de Grande-Bretagne et d’Irlande du Nord", "المملكة المتحدة لبريطانيا العظمى وأيرلندا الشمالية" },
                    { 90, "Suisse", "سويسري" },
                    { 52, "Koweït", "الكويت" },
                    { 65, "Norvège", "النرويج" },
                    { 50, "Jordanie", "الأردن" },
                    { 22, "Côte d’Ivoire", "ساحل العاج" },
                    { 21, "Congo", "الكونغو" },
                    { 19, "Chine", "الصين" },
                    { 18, "Chili", "تشيلي" },
                    { 17, "Canada", "كندا" },
                    { 16, "Burundi", "بوروندي" },
                    { 15, "Brunéi Darussalam", "بروناي دار السلام" },
                    { 14, "Brésil", "البرازيل" },
                    { 13, "Botswana", "بوتسوانا" },
                    { 12, "Belgique", "بلجيكا" },
                    { 11, "Bangladesh", "بنغلاديش" },
                    { 10, "Bahreïn", "البحرين" },
                    { 9, "Azerbaïdjan", "أذربيجان" },
                    { 8, "Autriche", "النمسا" },
                    { 7, "Australie", "أستراليا" },
                    { 6, "Argentine", "الأرجنتين" },
                    { 5, "Arabie saoudite", "العربية السعودية" },
                    { 4, "Angola", "أنغولا" },
                    { 3, "Allemagne", "ألمانيا" },
                    { 2, "Albanie", "ألبانيا" },
                    { 1, "Afrique du Sud", "إفريقيا الجنوبية" },
                    { 23, "Croatie", "كرواتيا" },
                    { 25, "Cuba", "كوبا" },
                    { 20, "Chypre", "قبرص" },
                    { 27, "Djibouti", "جيبوتي" },
                    { 49, "Italie", "إيطاليا" },
                    { 48, "Islande", "أيسلندا" },
                    { 47, "Iraq", "العراق" },
                    { 46, "Indonésie", "إندونيسيا" },
                    { 45, "Hongrie", "هنغاريا" },
                    { 44, "Honduras", "هندوراس" },
                    { 26, "Danemark", "الدنمارك" },
                    { 42, "Guatemala", "غواتيمالا" },
                    { 41, "Grèce", "اليونان" },
                    { 40, "Ghana", "غانا" },
                    { 38, "Géorgie", "جورجيا" },
                    { 43, "Haïti", "هايتي" },
                    { 37, "Gabon", "الغابون" },
                    { 51, "Kenya", "كينيا" },
                    { 29, "Émirats arabes unis", "الإمارات العربية المتحدة" },
                    { 30, "Équateur", "إكوادور" },
                    { 31, "Espagne", "إسبانيا" },
                    { 28, "Égypte", "مصر" },
                    { 33, "État de Palestine", "دولة فلسطين" },
                    { 34, "États-Unis d’Amérique", "الولايات المتحدة الأمريكية" },
                    { 35, "Éthiopie", "أثيوبيا" },
                    { 36, "France", "فرنسا" },
                    { 32, "Estonie", "إستونيا" }
                });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[,]
                {
                    { 1, "Administrateur", "مدير" },
                    { 2, "Superviseur", "مشرف" },
                    { 3, "Point focal", "	المخاطب الرئيسي" },
                    { 4, "Propriétaire", "مالك" }
                });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[,]
                {
                    { 10, 2020, "", "sous theme 10", "Droits catégoriels" },
                    { 15, 2020, "", "sous theme 15", "Droits catégoriels" },
                    { 14, 2020, "", "sous theme 14", "Droits catégoriels" },
                    { 13, 2020, "", "sous theme 13", "Droits catégoriels" },
                    { 12, 2020, "", "sous theme 12", "Droits thématiques" },
                    { 11, 2020, "", "sous theme 11", "Droits catégoriels" },
                    { 9, 2020, "", "sous theme 9", "Droits catégoriels" },
                    { 7, 2020, "", "sous theme 7", "Droits catégoriels" },
                    { 8, 2020, "", "sous theme 8", "Droits thématiques" },
                    { 6, 2020, "", "sous theme 6", "Droits thématiques" },
                    { 5, 2020, "", "sous theme 5", "Droits catégoriels" },
                    { 4, 2020, "", "sous theme 4", "Droits thématiques" },
                    { 3, 2020, "", "sous theme 3", "Droits thématiques" },
                    { 2, 2020, "", "sous theme 2", "Droits thématiques" },
                    { 1, 2020, "", "sous theme 1", "Droits catégoriels" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[] { 867, null, "R59", "ت.59", "", "Non réalisé", "", 0, null, null, null, null, null, null, "Organes de traités", "Appliquer pleinement les indicateurs liés au handicap pour le suivi de la mise en œuvre des objectifs de développement durable et de tenir compte des liens qui existent entre l’article 31 de la Convention et la cible 17.8 des objectifs de développement durable afin de disposer d’un beaucoup plus grand nombre de données de qualité, actualisées et exactes, ventilées par niveau de revenu, sexe, âge, race, appartenance ethnique, statut migratoire (notamment le statut de demandeur d’asile et de réfugié), handicap et emplacement géographique, et selon d’autres caractéristiques propres au pays. Il recommande en outre à l’État partie d’utiliser l’ensemble des questions proposées par le Groupe de Washington sur les statistiques des incapacités pour son recensement et les enquêtes sur les ménages.", "-      التطبيق الكامل للمؤشرات ذات الصلة بالإعاقة لرصد تنفيذ أهداف التنمية المستدامة، وإيلاء الاهتمام للصلات القائمة بين المادة ٣١ من الاتفاقية والغاية 17-18 من هذه الأهداف، من أجل تحقيق زيادة كبيرة في توافر بيانات عالية الجودة ومناسبة التوقيت وموثوقة ومفصلة حسب الدخل، ونوع الجنس، والسن، والعرق، والانتماء الإثني، والوضع كمهاجر (بما في ذلك وضع طالب اللجوء ووضع اللاجئ)، والإعاقة، والموقع الجغرافي وغيرها من الخصائص ذات الصلة في سياقها الوطني. وتوصي الدولةَ الطرف كذلك باستخدام المجموعة الكاملة من الأسئلة التي أصدرها فريق واشنطن المعني بإحصاءات الإعاقة من أجل إجراء التعدادات واستقصاءات الأسر المعيشية.", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[,]
                {
                    { 66, "", "", new DateTime(2020, 5, 26, 16, 45, 23, 764, DateTimeKind.Local).AddTicks(3327), new DateTime(2020, 8, 19, 23, 31, 9, 943, DateTimeKind.Local).AddTicks(8969), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 67, "", "", new DateTime(2020, 5, 21, 10, 37, 11, 300, DateTimeKind.Local).AddTicks(8924), new DateTime(2019, 11, 1, 7, 5, 46, 20, DateTimeKind.Local).AddTicks(4269), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 68, "", "", new DateTime(2020, 9, 12, 19, 32, 53, 553, DateTimeKind.Local).AddTicks(3639), new DateTime(2020, 1, 26, 3, 29, 47, 369, DateTimeKind.Local).AddTicks(5689), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 69, "", "", new DateTime(2020, 9, 24, 9, 12, 33, 728, DateTimeKind.Local).AddTicks(6771), new DateTime(2020, 7, 30, 13, 18, 6, 711, DateTimeKind.Local).AddTicks(4958), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 52, "", "", new DateTime(2020, 3, 29, 3, 51, 46, 0, DateTimeKind.Local).AddTicks(7625), new DateTime(2020, 6, 22, 1, 52, 41, 993, DateTimeKind.Local).AddTicks(8443), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 71, "", "", new DateTime(2020, 4, 16, 8, 52, 56, 335, DateTimeKind.Local).AddTicks(8720), new DateTime(2019, 12, 18, 14, 8, 5, 246, DateTimeKind.Local).AddTicks(9575), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 72, "", "", new DateTime(2020, 1, 26, 3, 36, 46, 923, DateTimeKind.Local).AddTicks(6086), new DateTime(2020, 10, 4, 14, 32, 17, 979, DateTimeKind.Local).AddTicks(8171), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 65, "", "", new DateTime(2019, 10, 11, 3, 34, 30, 161, DateTimeKind.Local).AddTicks(4698), new DateTime(2019, 10, 29, 22, 27, 54, 96, DateTimeKind.Local).AddTicks(8092), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 73, "", "", new DateTime(2019, 11, 11, 1, 37, 12, 950, DateTimeKind.Local).AddTicks(8520), new DateTime(2020, 6, 13, 10, 23, 12, 396, DateTimeKind.Local).AddTicks(8668), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 70, "", "", new DateTime(2020, 1, 13, 18, 15, 55, 42, DateTimeKind.Local).AddTicks(8712), new DateTime(2020, 6, 19, 14, 54, 28, 508, DateTimeKind.Local).AddTicks(2229), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 64, "", "", new DateTime(2020, 5, 11, 10, 58, 41, 321, DateTimeKind.Local).AddTicks(8109), new DateTime(2020, 2, 26, 5, 43, 8, 694, DateTimeKind.Local).AddTicks(1381), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 60, "", "", new DateTime(2020, 5, 26, 10, 14, 46, 299, DateTimeKind.Local).AddTicks(8830), new DateTime(2020, 4, 17, 14, 56, 45, 563, DateTimeKind.Local).AddTicks(9442), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 62, "", "", new DateTime(2020, 5, 16, 15, 38, 29, 722, DateTimeKind.Local).AddTicks(2839), new DateTime(2020, 8, 8, 11, 27, 47, 707, DateTimeKind.Local).AddTicks(3060), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 61, "", "", new DateTime(2020, 6, 10, 0, 0, 34, 888, DateTimeKind.Local).AddTicks(5270), new DateTime(2020, 9, 13, 10, 23, 59, 759, DateTimeKind.Local).AddTicks(6883), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 74, "", "", new DateTime(2019, 11, 4, 8, 54, 59, 233, DateTimeKind.Local).AddTicks(3013), new DateTime(2020, 7, 8, 16, 4, 12, 982, DateTimeKind.Local).AddTicks(2984), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 59, "", "", new DateTime(2020, 6, 26, 17, 29, 13, 245, DateTimeKind.Local).AddTicks(2475), new DateTime(2019, 11, 21, 13, 59, 2, 674, DateTimeKind.Local).AddTicks(2540), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 58, "", "", new DateTime(2019, 10, 18, 16, 5, 51, 713, DateTimeKind.Local).AddTicks(1680), new DateTime(2020, 2, 29, 17, 0, 11, 911, DateTimeKind.Local).AddTicks(9420), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 57, "", "", new DateTime(2019, 12, 2, 23, 8, 18, 999, DateTimeKind.Local).AddTicks(1084), new DateTime(2020, 4, 13, 21, 53, 14, 336, DateTimeKind.Local).AddTicks(2339), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" },
                    { 56, "", "", new DateTime(2020, 5, 5, 6, 40, 30, 409, DateTimeKind.Local).AddTicks(676), new DateTime(2020, 4, 8, 4, 0, 24, 544, DateTimeKind.Local).AddTicks(5702), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 55, "", "", new DateTime(2020, 3, 5, 21, 58, 19, 999, DateTimeKind.Local).AddTicks(8696), new DateTime(2020, 6, 9, 19, 11, 36, 139, DateTimeKind.Local).AddTicks(3413), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 54, "", "", new DateTime(2020, 5, 5, 23, 56, 0, 364, DateTimeKind.Local).AddTicks(9142), new DateTime(2020, 10, 3, 15, 40, 35, 856, DateTimeKind.Local).AddTicks(6854), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 53, "", "", new DateTime(2019, 12, 28, 0, 47, 51, 614, DateTimeKind.Local).AddTicks(5837), new DateTime(2019, 10, 17, 18, 56, 56, 984, DateTimeKind.Local).AddTicks(2576), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 63, "", "", new DateTime(2020, 6, 16, 23, 19, 4, 296, DateTimeKind.Local).AddTicks(5678), new DateTime(2020, 1, 6, 2, 47, 53, 419, DateTimeKind.Local).AddTicks(9654), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 75, "", "", new DateTime(2020, 3, 18, 9, 32, 22, 314, DateTimeKind.Local).AddTicks(5599), new DateTime(2020, 3, 4, 14, 0, 32, 35, DateTimeKind.Local).AddTicks(2224), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 80, "", "", new DateTime(2020, 5, 2, 10, 24, 57, 398, DateTimeKind.Local).AddTicks(1239), new DateTime(2020, 6, 21, 23, 37, 21, 388, DateTimeKind.Local).AddTicks(1030), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 77, "", "", new DateTime(2019, 10, 24, 8, 43, 0, 964, DateTimeKind.Local).AddTicks(8642), new DateTime(2019, 12, 23, 18, 25, 32, 788, DateTimeKind.Local).AddTicks(5775), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 99, "", "", new DateTime(2020, 5, 30, 14, 48, 14, 767, DateTimeKind.Local).AddTicks(2471), new DateTime(2020, 2, 1, 14, 21, 3, 324, DateTimeKind.Local).AddTicks(339), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 98, "", "", new DateTime(2020, 1, 10, 18, 44, 47, 845, DateTimeKind.Local).AddTicks(4876), new DateTime(2020, 3, 23, 1, 45, 46, 974, DateTimeKind.Local).AddTicks(1539), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 97, "", "", new DateTime(2019, 10, 30, 19, 25, 3, 644, DateTimeKind.Local).AddTicks(5737), new DateTime(2020, 3, 23, 0, 56, 31, 880, DateTimeKind.Local).AddTicks(7038), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 96, "", "", new DateTime(2019, 11, 4, 6, 16, 12, 285, DateTimeKind.Local).AddTicks(1435), new DateTime(2020, 8, 18, 19, 43, 57, 716, DateTimeKind.Local).AddTicks(6750), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 95, "", "", new DateTime(2020, 6, 6, 8, 23, 59, 769, DateTimeKind.Local).AddTicks(4864), new DateTime(2020, 6, 2, 10, 58, 57, 571, DateTimeKind.Local).AddTicks(4835), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 94, "", "", new DateTime(2020, 9, 26, 6, 58, 41, 823, DateTimeKind.Local).AddTicks(6348), new DateTime(2020, 3, 13, 19, 7, 3, 116, DateTimeKind.Local).AddTicks(3299), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 93, "", "", new DateTime(2020, 5, 15, 5, 56, 35, 141, DateTimeKind.Local).AddTicks(2092), new DateTime(2020, 3, 19, 3, 27, 6, 10, DateTimeKind.Local).AddTicks(9770), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 92, "", "", new DateTime(2019, 12, 16, 5, 21, 10, 739, DateTimeKind.Local).AddTicks(2506), new DateTime(2020, 1, 4, 23, 24, 18, 564, DateTimeKind.Local).AddTicks(4143), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 91, "", "", new DateTime(2020, 3, 3, 8, 15, 15, 349, DateTimeKind.Local).AddTicks(8310), new DateTime(2020, 1, 3, 3, 37, 39, 936, DateTimeKind.Local).AddTicks(9650), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 90, "", "", new DateTime(2019, 12, 11, 18, 43, 35, 569, DateTimeKind.Local).AddTicks(9408), new DateTime(2020, 6, 17, 2, 27, 44, 981, DateTimeKind.Local).AddTicks(1588), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 76, "", "", new DateTime(2020, 7, 21, 23, 15, 51, 394, DateTimeKind.Local).AddTicks(1235), new DateTime(2020, 4, 21, 15, 7, 2, 545, DateTimeKind.Local).AddTicks(8691), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 89, "", "", new DateTime(2020, 8, 25, 21, 45, 57, 20, DateTimeKind.Local).AddTicks(715), new DateTime(2020, 1, 28, 10, 50, 49, 882, DateTimeKind.Local).AddTicks(8655), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 87, "", "", new DateTime(2020, 5, 5, 18, 47, 13, 61, DateTimeKind.Local).AddTicks(94), new DateTime(2020, 8, 19, 9, 32, 51, 877, DateTimeKind.Local).AddTicks(918), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 86, "", "", new DateTime(2020, 4, 22, 5, 49, 59, 532, DateTimeKind.Local).AddTicks(6769), new DateTime(2020, 10, 3, 20, 21, 28, 257, DateTimeKind.Local).AddTicks(8156), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 85, "", "", new DateTime(2020, 1, 8, 14, 34, 21, 345, DateTimeKind.Local).AddTicks(5027), new DateTime(2020, 9, 4, 5, 20, 37, 854, DateTimeKind.Local).AddTicks(9634), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 84, "", "", new DateTime(2020, 7, 12, 20, 2, 27, 540, DateTimeKind.Local).AddTicks(4808), new DateTime(2020, 4, 8, 14, 13, 48, 394, DateTimeKind.Local).AddTicks(9962), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 83, "", "", new DateTime(2020, 4, 13, 3, 55, 36, 365, DateTimeKind.Local).AddTicks(6683), new DateTime(2020, 1, 25, 21, 33, 13, 427, DateTimeKind.Local).AddTicks(2171), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 82, "", "", new DateTime(2019, 11, 22, 17, 20, 36, 75, DateTimeKind.Local).AddTicks(4243), new DateTime(2020, 5, 24, 18, 21, 42, 488, DateTimeKind.Local).AddTicks(2092), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 81, "", "", new DateTime(2020, 1, 24, 1, 7, 25, 388, DateTimeKind.Local).AddTicks(4880), new DateTime(2020, 6, 25, 12, 29, 33, 998, DateTimeKind.Local).AddTicks(2527), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 100, "", "", new DateTime(2020, 6, 28, 14, 32, 47, 777, DateTimeKind.Local).AddTicks(245), new DateTime(2019, 11, 3, 17, 58, 17, 333, DateTimeKind.Local).AddTicks(7314), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 79, "", "", new DateTime(2019, 10, 14, 11, 45, 4, 236, DateTimeKind.Local).AddTicks(1425), new DateTime(2019, 11, 25, 6, 24, 57, 275, DateTimeKind.Local).AddTicks(149), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 78, "", "", new DateTime(2020, 1, 17, 19, 44, 12, 558, DateTimeKind.Local).AddTicks(4751), new DateTime(2020, 2, 26, 4, 9, 1, 310, DateTimeKind.Local).AddTicks(1947), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 88, "", "", new DateTime(2020, 2, 1, 6, 54, 55, 417, DateTimeKind.Local).AddTicks(5264), new DateTime(2020, 8, 16, 18, 48, 54, 64, DateTimeKind.Local).AddTicks(6487), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 51, "", "", new DateTime(2020, 8, 23, 1, 48, 36, 687, DateTimeKind.Local).AddTicks(1856), new DateTime(2020, 1, 12, 23, 50, 46, 466, DateTimeKind.Local).AddTicks(672), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 20, "", "", new DateTime(2019, 11, 11, 8, 21, 9, 558, DateTimeKind.Local).AddTicks(6883), new DateTime(2020, 6, 4, 5, 56, 24, 94, DateTimeKind.Local).AddTicks(5499), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 49, "", "", new DateTime(2020, 8, 18, 22, 43, 31, 75, DateTimeKind.Local).AddTicks(3955), new DateTime(2019, 12, 12, 16, 25, 8, 649, DateTimeKind.Local).AddTicks(5002), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 22, "", "", new DateTime(2019, 12, 13, 18, 44, 0, 333, DateTimeKind.Local).AddTicks(1165), new DateTime(2019, 11, 9, 16, 21, 52, 430, DateTimeKind.Local).AddTicks(4651), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" },
                    { 50, "", "", new DateTime(2019, 11, 9, 1, 2, 46, 79, DateTimeKind.Local).AddTicks(477), new DateTime(2020, 2, 7, 2, 17, 17, 671, DateTimeKind.Local).AddTicks(2113), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 19, "", "", new DateTime(2020, 8, 22, 14, 14, 9, 885, DateTimeKind.Local).AddTicks(6955), new DateTime(2020, 1, 16, 3, 12, 13, 221, DateTimeKind.Local).AddTicks(3201), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 18, "", "", new DateTime(2019, 11, 17, 23, 37, 42, 767, DateTimeKind.Local).AddTicks(4841), new DateTime(2019, 11, 27, 12, 9, 32, 145, DateTimeKind.Local).AddTicks(4009), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 17, "", "", new DateTime(2019, 10, 23, 1, 48, 31, 795, DateTimeKind.Local).AddTicks(8432), new DateTime(2020, 10, 3, 18, 22, 57, 853, DateTimeKind.Local).AddTicks(4910), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 16, "", "", new DateTime(2020, 4, 11, 4, 33, 20, 963, DateTimeKind.Local).AddTicks(5702), new DateTime(2019, 12, 19, 11, 41, 50, 502, DateTimeKind.Local).AddTicks(8292), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 15, "", "", new DateTime(2019, 12, 18, 11, 49, 5, 969, DateTimeKind.Local).AddTicks(9073), new DateTime(2019, 10, 17, 17, 5, 19, 154, DateTimeKind.Local).AddTicks(2311), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 14, "", "", new DateTime(2020, 8, 23, 16, 24, 31, 469, DateTimeKind.Local).AddTicks(2938), new DateTime(2020, 1, 27, 15, 46, 40, 243, DateTimeKind.Local).AddTicks(9138), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 13, "", "", new DateTime(2020, 8, 5, 15, 41, 54, 914, DateTimeKind.Local).AddTicks(6598), new DateTime(2019, 11, 19, 23, 43, 3, 23, DateTimeKind.Local).AddTicks(9537), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 12, "", "", new DateTime(2020, 9, 21, 17, 47, 55, 575, DateTimeKind.Local).AddTicks(9248), new DateTime(2020, 2, 5, 10, 17, 7, 885, DateTimeKind.Local).AddTicks(1234), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 11, "", "", new DateTime(2020, 5, 1, 17, 14, 23, 612, DateTimeKind.Local).AddTicks(6241), new DateTime(2020, 1, 4, 3, 7, 46, 823, DateTimeKind.Local).AddTicks(9532), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 10, "", "", new DateTime(2019, 11, 8, 2, 33, 14, 610, DateTimeKind.Local).AddTicks(836), new DateTime(2020, 8, 4, 13, 21, 2, 601, DateTimeKind.Local).AddTicks(907), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 9, "", "", new DateTime(2020, 6, 12, 9, 53, 10, 99, DateTimeKind.Local).AddTicks(9547), new DateTime(2019, 11, 24, 5, 47, 42, 215, DateTimeKind.Local).AddTicks(4397), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 8, "", "", new DateTime(2020, 7, 4, 14, 59, 53, 807, DateTimeKind.Local).AddTicks(985), new DateTime(2019, 11, 14, 7, 27, 47, 271, DateTimeKind.Local).AddTicks(5024), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 7, "", "", new DateTime(2019, 10, 23, 8, 24, 14, 751, DateTimeKind.Local).AddTicks(9000), new DateTime(2019, 10, 21, 11, 9, 52, 585, DateTimeKind.Local).AddTicks(5899), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 6, "", "", new DateTime(2019, 11, 25, 3, 35, 23, 693, DateTimeKind.Local).AddTicks(3282), new DateTime(2020, 6, 6, 1, 20, 1, 103, DateTimeKind.Local).AddTicks(3852), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 5, "", "", new DateTime(2020, 8, 3, 17, 33, 28, 935, DateTimeKind.Local).AddTicks(3852), new DateTime(2020, 4, 25, 19, 34, 19, 596, DateTimeKind.Local).AddTicks(411), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 4, "", "", new DateTime(2020, 8, 17, 19, 22, 8, 526, DateTimeKind.Local).AddTicks(7381), new DateTime(2019, 11, 4, 10, 46, 42, 938, DateTimeKind.Local).AddTicks(4816), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 3, "", "", new DateTime(2020, 6, 5, 23, 19, 20, 41, DateTimeKind.Local).AddTicks(3819), new DateTime(2019, 10, 25, 7, 23, 12, 896, DateTimeKind.Local).AddTicks(9560), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 2, "", "", new DateTime(2020, 2, 7, 7, 31, 33, 718, DateTimeKind.Local).AddTicks(36), new DateTime(2020, 8, 8, 10, 45, 44, 713, DateTimeKind.Local).AddTicks(7196), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 1, "", "", new DateTime(2020, 8, 22, 14, 38, 29, 591, DateTimeKind.Local).AddTicks(5089), new DateTime(2020, 9, 27, 21, 51, 58, 559, DateTimeKind.Local).AddTicks(6464), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 23, "", "", new DateTime(2020, 2, 16, 15, 20, 23, 291, DateTimeKind.Local).AddTicks(3926), new DateTime(2020, 7, 8, 9, 54, 13, 917, DateTimeKind.Local).AddTicks(7868), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 24, "", "", new DateTime(2020, 1, 8, 22, 53, 37, 756, DateTimeKind.Local).AddTicks(4562), new DateTime(2020, 2, 22, 21, 2, 10, 813, DateTimeKind.Local).AddTicks(9671), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 21, "", "", new DateTime(2020, 1, 18, 20, 39, 27, 440, DateTimeKind.Local).AddTicks(7466), new DateTime(2020, 4, 23, 20, 12, 20, 141, DateTimeKind.Local).AddTicks(6670), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 26, "", "", new DateTime(2020, 4, 23, 11, 38, 19, 459, DateTimeKind.Local).AddTicks(9410), new DateTime(2019, 10, 16, 12, 59, 41, 69, DateTimeKind.Local).AddTicks(5952), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 48, "", "", new DateTime(2020, 5, 8, 12, 22, 27, 16, DateTimeKind.Local).AddTicks(7859), new DateTime(2019, 10, 21, 15, 33, 53, 224, DateTimeKind.Local).AddTicks(2144), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 47, "", "", new DateTime(2020, 5, 27, 15, 56, 53, 867, DateTimeKind.Local).AddTicks(9004), new DateTime(2020, 4, 19, 11, 49, 37, 202, DateTimeKind.Local).AddTicks(5229), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 46, "", "", new DateTime(2020, 3, 21, 1, 30, 45, 685, DateTimeKind.Local).AddTicks(5798), new DateTime(2020, 2, 10, 10, 56, 35, 507, DateTimeKind.Local).AddTicks(4051), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 45, "", "", new DateTime(2020, 6, 19, 7, 10, 37, 388, DateTimeKind.Local).AddTicks(8618), new DateTime(2020, 8, 27, 9, 4, 28, 491, DateTimeKind.Local).AddTicks(3425), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 44, "", "", new DateTime(2019, 12, 9, 16, 46, 43, 255, DateTimeKind.Local).AddTicks(7438), new DateTime(2019, 11, 17, 23, 5, 59, 415, DateTimeKind.Local).AddTicks(8890), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 43, "", "", new DateTime(2020, 6, 15, 5, 51, 30, 571, DateTimeKind.Local).AddTicks(694), new DateTime(2020, 7, 10, 16, 9, 51, 792, DateTimeKind.Local).AddTicks(6203), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 42, "", "", new DateTime(2020, 1, 30, 9, 45, 25, 990, DateTimeKind.Local).AddTicks(6191), new DateTime(2019, 10, 18, 9, 54, 34, 854, DateTimeKind.Local).AddTicks(8325), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 25, "", "", new DateTime(2020, 2, 3, 20, 13, 20, 805, DateTimeKind.Local).AddTicks(2775), new DateTime(2019, 10, 10, 13, 11, 1, 10, DateTimeKind.Local).AddTicks(8659), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 40, "", "", new DateTime(2020, 6, 3, 2, 41, 55, 813, DateTimeKind.Local).AddTicks(6833), new DateTime(2020, 1, 27, 8, 49, 58, 699, DateTimeKind.Local).AddTicks(4273), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 39, "", "", new DateTime(2020, 5, 26, 3, 59, 46, 338, DateTimeKind.Local).AddTicks(985), new DateTime(2019, 11, 22, 5, 2, 24, 42, DateTimeKind.Local).AddTicks(5227), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 38, "", "", new DateTime(2020, 2, 17, 9, 16, 14, 886, DateTimeKind.Local).AddTicks(2870), new DateTime(2020, 4, 30, 14, 33, 54, 230, DateTimeKind.Local).AddTicks(710), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 41, "", "", new DateTime(2019, 12, 12, 3, 12, 32, 26, DateTimeKind.Local).AddTicks(2976), new DateTime(2020, 4, 23, 17, 57, 46, 421, DateTimeKind.Local).AddTicks(3497), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 36, "", "", new DateTime(2019, 10, 25, 17, 15, 49, 173, DateTimeKind.Local).AddTicks(4734), new DateTime(2020, 9, 17, 9, 57, 46, 157, DateTimeKind.Local).AddTicks(6235), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 37, "", "", new DateTime(2020, 5, 26, 16, 53, 12, 751, DateTimeKind.Local).AddTicks(2207), new DateTime(2020, 8, 7, 16, 13, 57, 875, DateTimeKind.Local).AddTicks(8418), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 28, "", "", new DateTime(2020, 6, 4, 20, 44, 48, 675, DateTimeKind.Local).AddTicks(7133), new DateTime(2020, 8, 24, 2, 3, 24, 290, DateTimeKind.Local).AddTicks(7271), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 29, "", "", new DateTime(2020, 9, 19, 13, 9, 32, 376, DateTimeKind.Local).AddTicks(5939), new DateTime(2020, 8, 16, 4, 24, 0, 213, DateTimeKind.Local).AddTicks(9163), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 30, "", "", new DateTime(2020, 6, 28, 8, 0, 8, 519, DateTimeKind.Local).AddTicks(2422), new DateTime(2020, 1, 23, 3, 41, 17, 471, DateTimeKind.Local).AddTicks(5918), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 27, "", "", new DateTime(2020, 4, 7, 16, 25, 58, 803, DateTimeKind.Local).AddTicks(3102), new DateTime(2020, 9, 8, 20, 35, 2, 840, DateTimeKind.Local).AddTicks(1441), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 32, "", "", new DateTime(2020, 7, 14, 2, 6, 34, 630, DateTimeKind.Local).AddTicks(2787), new DateTime(2020, 4, 29, 9, 52, 51, 0, DateTimeKind.Local).AddTicks(8565), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 33, "", "", new DateTime(2020, 7, 6, 16, 21, 0, 405, DateTimeKind.Local).AddTicks(4253), new DateTime(2020, 1, 18, 1, 33, 0, 694, DateTimeKind.Local).AddTicks(4734), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 34, "", "", new DateTime(2020, 5, 7, 3, 31, 2, 922, DateTimeKind.Local).AddTicks(7308), new DateTime(2019, 11, 16, 16, 34, 31, 291, DateTimeKind.Local).AddTicks(2736), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 35, "", "", new DateTime(2020, 8, 23, 9, 42, 34, 828, DateTimeKind.Local).AddTicks(6264), new DateTime(2020, 7, 21, 12, 13, 1, 450, DateTimeKind.Local).AddTicks(4005), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 31, "", "", new DateTime(2020, 3, 17, 7, 16, 35, 683, DateTimeKind.Local).AddTicks(9686), new DateTime(2020, 3, 6, 16, 36, 0, 805, DateTimeKind.Local).AddTicks(2049), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[,]
                {
                    { 8, new DateTime(2020, 10, 7, 12, 3, 42, 9, DateTimeKind.Local).AddTicks(8413), "", "", "", "La rapporteuse spéciale dans le domaine des droits culturels", "المقررة الخاصة في مجال الحقوق الثقافية", "" },
                    { 1, new DateTime(2020, 10, 7, 12, 3, 42, 5, DateTimeKind.Local).AddTicks(7867), "", "", "", "la Rapporteuse spéciale sur le droit à l’alimentation", "المقررة الخاصة المعنية بالحق في الغذاء", "" },
                    { 2, new DateTime(2020, 10, 7, 12, 3, 42, 9, DateTimeKind.Local).AddTicks(8319), "", "", "", "La Rapporteuse spéciale sur les formes contemporaines de racisme, de discrimination raciale, de xénophobie et de l’intolérance qui y est associée", "المقررة الخاصة المعنية بالأشكال المعاصرة للعنصرية والتمييز العنصري وكره الأجانب وما يتصل بذلك من تعصب", "" },
                    { 3, new DateTime(2020, 10, 7, 12, 3, 42, 9, DateTimeKind.Local).AddTicks(8391), "", "", "", "Rapporteur spécial sur la torture et autres peines ou traitements cruels, inhumains ou dégradants", "المقرر الخاص المعني بالتعذيب وغيره من ضروب المعاملة أو العقوبة القاسية", "" },
                    { 4, new DateTime(2020, 10, 7, 12, 3, 42, 9, DateTimeKind.Local).AddTicks(8399), "", "", "", "la Rapporteuse spéciale sur la traite des êtres humains, en particulier les femmes et les enfants", "المقررة الخاصة المعنية بالاتجار بالأشخاص، لا سيما النساء والأطفال", "" },
                    { 6, new DateTime(2020, 10, 7, 12, 3, 42, 9, DateTimeKind.Local).AddTicks(8404), "", "", "", "Le groupe de travail chargé de la question de la discrimination à l’égard des femmes, dans la législation et dans la pratique", "العامل المعني بمسألة التمييز ضد المرأة في القانون والممارسة", "" },
                    { 7, new DateTime(2020, 10, 7, 12, 3, 42, 9, DateTimeKind.Local).AddTicks(8409), "", "", "", "Le groupe de travail sur la détention arbitraire", "الفريق العامل المعني بالاحتجاز التعسفي", "" },
                    { 9, new DateTime(2020, 10, 7, 12, 3, 42, 9, DateTimeKind.Local).AddTicks(8418), "", "", "", "l’Experte indépendante sur les droits de l’homme et la solidarité internationale", "الخبيرة المستقلة المعنية بحقوق الإنسان والتضامن الدولي", "" }
                });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[,]
                {
                    { 93, new DateTime(2020, 10, 7, 13, 0, 23, 479, DateTimeKind.Local).AddTicks(9299), new DateTime(2020, 10, 8, 8, 57, 35, 993, DateTimeKind.Local).AddTicks(3382), new DateTime(2020, 10, 8, 7, 32, 19, 793, DateTimeKind.Local).AddTicks(6077), 27, "", "http://louis.name", "aliquid" },
                    { 47, new DateTime(2020, 10, 7, 21, 11, 8, 409, DateTimeKind.Local).AddTicks(1183), new DateTime(2020, 10, 7, 18, 36, 45, 653, DateTimeKind.Local).AddTicks(1611), new DateTime(2020, 10, 8, 0, 34, 48, 615, DateTimeKind.Local).AddTicks(4245), 1, "", "https://léa.info", "saepe" },
                    { 68, new DateTime(2020, 10, 7, 18, 1, 28, 790, DateTimeKind.Local).AddTicks(7860), new DateTime(2020, 10, 7, 13, 39, 59, 401, DateTimeKind.Local).AddTicks(6893), new DateTime(2020, 10, 8, 3, 46, 10, 340, DateTimeKind.Local).AddTicks(490), 3, "", "https://clémence.fr", "consequuntur" },
                    { 73, new DateTime(2020, 10, 8, 9, 13, 56, 672, DateTimeKind.Local).AddTicks(9621), new DateTime(2020, 10, 8, 7, 59, 49, 895, DateTimeKind.Local).AddTicks(9941), new DateTime(2020, 10, 7, 12, 57, 24, 354, DateTimeKind.Local).AddTicks(8224), 3, "", "https://tom.net", "quisquam" },
                    { 37, new DateTime(2020, 10, 7, 20, 18, 5, 943, DateTimeKind.Local).AddTicks(2442), new DateTime(2020, 10, 8, 2, 20, 12, 526, DateTimeKind.Local).AddTicks(326), new DateTime(2020, 10, 8, 4, 6, 59, 508, DateTimeKind.Local).AddTicks(7456), 4, "", "http://océane.eu", "consequatur" },
                    { 41, new DateTime(2020, 10, 7, 14, 23, 43, 217, DateTimeKind.Local).AddTicks(9489), new DateTime(2020, 10, 8, 5, 43, 31, 672, DateTimeKind.Local).AddTicks(8850), new DateTime(2020, 10, 7, 14, 51, 18, 444, DateTimeKind.Local).AddTicks(2577), 5, "", "http://quentin.info", "aut" },
                    { 65, new DateTime(2020, 10, 8, 11, 19, 17, 34, DateTimeKind.Local).AddTicks(2630), new DateTime(2020, 10, 8, 4, 23, 21, 925, DateTimeKind.Local).AddTicks(5947), new DateTime(2020, 10, 7, 18, 20, 21, 173, DateTimeKind.Local).AddTicks(821), 6, "", "http://louis.com", "sit" },
                    { 78, new DateTime(2020, 10, 8, 6, 56, 6, 476, DateTimeKind.Local).AddTicks(5650), new DateTime(2020, 10, 7, 23, 47, 21, 456, DateTimeKind.Local).AddTicks(3210), new DateTime(2020, 10, 8, 1, 43, 52, 479, DateTimeKind.Local).AddTicks(9221), 6, "", "https://baptiste.org", "dolore" },
                    { 10, new DateTime(2020, 10, 8, 10, 59, 40, 958, DateTimeKind.Local).AddTicks(8252), new DateTime(2020, 10, 7, 18, 17, 19, 747, DateTimeKind.Local).AddTicks(8112), new DateTime(2020, 10, 7, 15, 27, 11, 7, DateTimeKind.Local).AddTicks(7262), 7, "", "https://adam.info", "maiores" },
                    { 53, new DateTime(2020, 10, 8, 2, 15, 36, 168, DateTimeKind.Local).AddTicks(5497), new DateTime(2020, 10, 8, 6, 21, 35, 540, DateTimeKind.Local).AddTicks(9259), new DateTime(2020, 10, 8, 2, 3, 51, 392, DateTimeKind.Local).AddTicks(8926), 7, "", "http://maëlle.name", "voluptatem" },
                    { 12, new DateTime(2020, 10, 8, 5, 53, 13, 688, DateTimeKind.Local).AddTicks(3347), new DateTime(2020, 10, 8, 4, 8, 31, 300, DateTimeKind.Local).AddTicks(4008), new DateTime(2020, 10, 7, 17, 7, 22, 102, DateTimeKind.Local).AddTicks(2336), 8, "", "https://mathilde.fr", "sunt" },
                    { 52, new DateTime(2020, 10, 7, 12, 59, 43, 74, DateTimeKind.Local).AddTicks(7708), new DateTime(2020, 10, 8, 2, 9, 27, 823, DateTimeKind.Local).AddTicks(8918), new DateTime(2020, 10, 8, 3, 0, 25, 245, DateTimeKind.Local).AddTicks(6930), 11, "", "https://rayan.fr", "dolor" },
                    { 56, new DateTime(2020, 10, 7, 21, 29, 51, 940, DateTimeKind.Local).AddTicks(7700), new DateTime(2020, 10, 7, 14, 51, 27, 440, DateTimeKind.Local).AddTicks(7670), new DateTime(2020, 10, 8, 3, 10, 48, 596, DateTimeKind.Local).AddTicks(5903), 11, "", "https://tom.name", "voluptas" },
                    { 89, new DateTime(2020, 10, 7, 15, 20, 16, 55, DateTimeKind.Local).AddTicks(8348), new DateTime(2020, 10, 8, 8, 42, 25, 477, DateTimeKind.Local).AddTicks(7962), new DateTime(2020, 10, 7, 13, 46, 43, 771, DateTimeKind.Local).AddTicks(9720), 12, "", "https://ethan.fr", "earum" },
                    { 81, new DateTime(2020, 10, 7, 15, 47, 15, 833, DateTimeKind.Local).AddTicks(7692), new DateTime(2020, 10, 7, 22, 55, 32, 258, DateTimeKind.Local).AddTicks(6358), new DateTime(2020, 10, 8, 10, 4, 31, 723, DateTimeKind.Local).AddTicks(127), 13, "", "https://lucie.net", "cumque" },
                    { 13, new DateTime(2020, 10, 7, 12, 46, 24, 238, DateTimeKind.Local).AddTicks(547), new DateTime(2020, 10, 8, 6, 33, 19, 983, DateTimeKind.Local).AddTicks(7190), new DateTime(2020, 10, 7, 14, 38, 43, 674, DateTimeKind.Local).AddTicks(4070), 14, "", "http://antoine.fr", "beatae" },
                    { 27, new DateTime(2020, 10, 8, 1, 45, 20, 236, DateTimeKind.Local).AddTicks(1811), new DateTime(2020, 10, 7, 12, 12, 2, 873, DateTimeKind.Local).AddTicks(1983), new DateTime(2020, 10, 8, 6, 27, 25, 423, DateTimeKind.Local).AddTicks(1241), 1, "", "http://ambre.net", "non" },
                    { 76, new DateTime(2020, 10, 8, 8, 13, 56, 22, DateTimeKind.Local).AddTicks(2200), new DateTime(2020, 10, 8, 6, 7, 42, 565, DateTimeKind.Local).AddTicks(6900), new DateTime(2020, 10, 8, 10, 1, 56, 793, DateTimeKind.Local).AddTicks(9121), 63, "", "http://mael.org", "nihil" },
                    { 50, new DateTime(2020, 10, 8, 2, 13, 40, 195, DateTimeKind.Local).AddTicks(9168), new DateTime(2020, 10, 8, 10, 8, 58, 339, DateTimeKind.Local).AddTicks(6980), new DateTime(2020, 10, 8, 5, 45, 48, 829, DateTimeKind.Local).AddTicks(763), 64, "", "http://sacha.org", "est" },
                    { 66, new DateTime(2020, 10, 8, 10, 6, 19, 163, DateTimeKind.Local).AddTicks(7053), new DateTime(2020, 10, 7, 17, 10, 25, 608, DateTimeKind.Local).AddTicks(326), new DateTime(2020, 10, 7, 17, 3, 50, 169, DateTimeKind.Local).AddTicks(193), 64, "", "http://charlotte.org", "atque" },
                    { 45, new DateTime(2020, 10, 8, 9, 25, 43, 6, DateTimeKind.Local).AddTicks(8778), new DateTime(2020, 10, 8, 7, 35, 30, 906, DateTimeKind.Local).AddTicks(1477), new DateTime(2020, 10, 8, 8, 26, 47, 327, DateTimeKind.Local).AddTicks(4835), 77, "", "http://marie.net", "voluptatem" },
                    { 20, new DateTime(2020, 10, 7, 15, 56, 3, 842, DateTimeKind.Local).AddTicks(7078), new DateTime(2020, 10, 7, 15, 32, 49, 843, DateTimeKind.Local).AddTicks(5506), new DateTime(2020, 10, 8, 1, 11, 26, 615, DateTimeKind.Local).AddTicks(5113), 77, "", "http://maëlys.org", "aut" },
                    { 94, new DateTime(2020, 10, 8, 7, 41, 47, 72, DateTimeKind.Local).AddTicks(9328), new DateTime(2020, 10, 7, 22, 48, 23, 272, DateTimeKind.Local).AddTicks(3388), new DateTime(2020, 10, 8, 11, 4, 16, 204, DateTimeKind.Local).AddTicks(5480), 75, "", "https://lola.name", "ea" },
                    { 44, new DateTime(2020, 10, 8, 4, 34, 9, 971, DateTimeKind.Local).AddTicks(3515), new DateTime(2020, 10, 8, 4, 11, 24, 424, DateTimeKind.Local).AddTicks(1818), new DateTime(2020, 10, 7, 12, 8, 36, 559, DateTimeKind.Local).AddTicks(2175), 73, "", "https://jade.net", "porro" },
                    { 91, new DateTime(2020, 10, 7, 23, 16, 11, 533, DateTimeKind.Local).AddTicks(1995), new DateTime(2020, 10, 7, 15, 46, 36, 536, DateTimeKind.Local).AddTicks(6731), new DateTime(2020, 10, 7, 14, 43, 14, 561, DateTimeKind.Local).AddTicks(5991), 72, "", "https://gabriel.info", "ad" },
                    { 6, new DateTime(2020, 10, 8, 6, 27, 11, 572, DateTimeKind.Local).AddTicks(2404), new DateTime(2020, 10, 8, 4, 16, 49, 451, DateTimeKind.Local).AddTicks(5993), new DateTime(2020, 10, 8, 10, 53, 0, 263, DateTimeKind.Local).AddTicks(9362), 72, "", "https://evan.info", "sit" },
                    { 83, new DateTime(2020, 10, 7, 15, 55, 16, 432, DateTimeKind.Local).AddTicks(8231), new DateTime(2020, 10, 7, 19, 17, 20, 403, DateTimeKind.Local).AddTicks(6004), new DateTime(2020, 10, 7, 22, 16, 15, 780, DateTimeKind.Local).AddTicks(3396), 71, "", "http://carla.info", "nulla" },
                    { 17, new DateTime(2020, 10, 7, 13, 58, 51, 387, DateTimeKind.Local).AddTicks(9669), new DateTime(2020, 10, 8, 10, 38, 42, 949, DateTimeKind.Local).AddTicks(9784), new DateTime(2020, 10, 7, 12, 59, 33, 15, DateTimeKind.Local).AddTicks(9176), 14, "", "http://sacha.info", "laudantium" },
                    { 21, new DateTime(2020, 10, 8, 6, 45, 24, 834, DateTimeKind.Local).AddTicks(1751), new DateTime(2020, 10, 8, 5, 44, 19, 488, DateTimeKind.Local).AddTicks(7363), new DateTime(2020, 10, 8, 2, 20, 4, 542, DateTimeKind.Local).AddTicks(1269), 70, "", "https://justine.fr", "consequatur" },
                    { 35, new DateTime(2020, 10, 8, 10, 38, 51, 788, DateTimeKind.Local).AddTicks(6565), new DateTime(2020, 10, 8, 2, 48, 15, 344, DateTimeKind.Local).AddTicks(531), new DateTime(2020, 10, 8, 4, 39, 59, 761, DateTimeKind.Local).AddTicks(3229), 68, "", "https://lucas.net", "rerum" },
                    { 14, new DateTime(2020, 10, 8, 0, 21, 28, 913, DateTimeKind.Local).AddTicks(7415), new DateTime(2020, 10, 7, 18, 31, 28, 990, DateTimeKind.Local).AddTicks(9041), new DateTime(2020, 10, 7, 18, 18, 34, 993, DateTimeKind.Local).AddTicks(8956), 68, "", "http://jeanne.eu", "quam" },
                    { 88, new DateTime(2020, 10, 8, 4, 57, 42, 960, DateTimeKind.Local).AddTicks(9720), new DateTime(2020, 10, 8, 1, 32, 32, 705, DateTimeKind.Local).AddTicks(9924), new DateTime(2020, 10, 7, 14, 41, 53, 683, DateTimeKind.Local).AddTicks(4861), 67, "", "https://adam.net", "dolores" },
                    { 49, new DateTime(2020, 10, 7, 18, 49, 24, 466, DateTimeKind.Local).AddTicks(6512), new DateTime(2020, 10, 8, 7, 55, 58, 839, DateTimeKind.Local).AddTicks(1757), new DateTime(2020, 10, 7, 19, 47, 52, 761, DateTimeKind.Local).AddTicks(6477), 67, "", "http://sacha.org", "voluptatibus" },
                    { 32, new DateTime(2020, 10, 8, 8, 24, 41, 315, DateTimeKind.Local).AddTicks(1028), new DateTime(2020, 10, 8, 11, 8, 3, 90, DateTimeKind.Local).AddTicks(6694), new DateTime(2020, 10, 8, 1, 26, 12, 590, DateTimeKind.Local).AddTicks(1691), 66, "", "https://maëlle.eu", "tempore" },
                    { 25, new DateTime(2020, 10, 8, 9, 26, 48, 550, DateTimeKind.Local).AddTicks(8572), new DateTime(2020, 10, 8, 7, 27, 1, 59, DateTimeKind.Local).AddTicks(816), new DateTime(2020, 10, 8, 0, 36, 37, 47, DateTimeKind.Local).AddTicks(7927), 66, "", "http://océane.org", "incidunt" },
                    { 77, new DateTime(2020, 10, 8, 1, 35, 51, 857, DateTimeKind.Local).AddTicks(9392), new DateTime(2020, 10, 7, 22, 21, 6, 585, DateTimeKind.Local).AddTicks(4883), new DateTime(2020, 10, 8, 1, 27, 56, 76, DateTimeKind.Local).AddTicks(4536), 64, "", "https://clémence.com", "unde" },
                    { 9, new DateTime(2020, 10, 8, 2, 42, 53, 48, DateTimeKind.Local).AddTicks(3072), new DateTime(2020, 10, 7, 19, 43, 13, 619, DateTimeKind.Local).AddTicks(9543), new DateTime(2020, 10, 8, 10, 34, 33, 916, DateTimeKind.Local).AddTicks(6632), 70, "", "https://lilou.fr", "exercitationem" },
                    { 40, new DateTime(2020, 10, 7, 12, 43, 37, 118, DateTimeKind.Local).AddTicks(5128), new DateTime(2020, 10, 7, 15, 42, 18, 409, DateTimeKind.Local).AddTicks(2694), new DateTime(2020, 10, 7, 15, 48, 56, 869, DateTimeKind.Local).AddTicks(3902), 15, "", "https://justine.org", "et" },
                    { 48, new DateTime(2020, 10, 7, 15, 34, 52, 466, DateTimeKind.Local).AddTicks(4109), new DateTime(2020, 10, 7, 19, 12, 20, 898, DateTimeKind.Local).AddTicks(6861), new DateTime(2020, 10, 7, 20, 40, 14, 790, DateTimeKind.Local).AddTicks(6231), 17, "", "https://célia.fr", "consequatur" },
                    { 63, new DateTime(2020, 10, 8, 8, 38, 30, 976, DateTimeKind.Local).AddTicks(8111), new DateTime(2020, 10, 8, 5, 30, 45, 263, DateTimeKind.Local).AddTicks(985), new DateTime(2020, 10, 8, 1, 43, 45, 163, DateTimeKind.Local), 18, "", "https://mael.eu", "cupiditate" },
                    { 23, new DateTime(2020, 10, 7, 12, 4, 32, 525, DateTimeKind.Local).AddTicks(1470), new DateTime(2020, 10, 7, 20, 45, 24, 851, DateTimeKind.Local).AddTicks(9265), new DateTime(2020, 10, 8, 1, 10, 37, 606, DateTimeKind.Local).AddTicks(173), 38, "", "http://sarah.info", "sunt" },
                    { 24, new DateTime(2020, 10, 7, 15, 23, 49, 405, DateTimeKind.Local).AddTicks(2637), new DateTime(2020, 10, 7, 14, 59, 28, 979, DateTimeKind.Local).AddTicks(7915), new DateTime(2020, 10, 8, 11, 23, 12, 297, DateTimeKind.Local).AddTicks(1649), 39, "", "http://lilou.net", "aliquam" },
                    { 87, new DateTime(2020, 10, 7, 14, 11, 30, 828, DateTimeKind.Local).AddTicks(6300), new DateTime(2020, 10, 8, 6, 9, 20, 337, DateTimeKind.Local).AddTicks(2578), new DateTime(2020, 10, 7, 15, 33, 53, 193, DateTimeKind.Local).AddTicks(9404), 40, "", "http://lucie.com", "quia" },
                    { 97, new DateTime(2020, 10, 7, 19, 2, 37, 373, DateTimeKind.Local).AddTicks(5835), new DateTime(2020, 10, 8, 11, 30, 26, 188, DateTimeKind.Local).AddTicks(6867), new DateTime(2020, 10, 7, 15, 16, 9, 989, DateTimeKind.Local).AddTicks(8643), 41, "", "http://valentin.fr", "et" },
                    { 72, new DateTime(2020, 10, 8, 10, 18, 36, 150, DateTimeKind.Local).AddTicks(6084), new DateTime(2020, 10, 8, 11, 56, 1, 899, DateTimeKind.Local).AddTicks(3911), new DateTime(2020, 10, 8, 7, 27, 20, 222, DateTimeKind.Local).AddTicks(7575), 42, "", "https://noémie.fr", "ut" },
                    { 1, new DateTime(2020, 10, 8, 3, 54, 25, 332, DateTimeKind.Local).AddTicks(6561), new DateTime(2020, 10, 7, 15, 8, 3, 256, DateTimeKind.Local).AddTicks(92), new DateTime(2020, 10, 7, 19, 50, 48, 712, DateTimeKind.Local).AddTicks(4187), 43, "", "https://romane.org", "atque" },
                    { 54, new DateTime(2020, 10, 8, 6, 59, 52, 795, DateTimeKind.Local).AddTicks(5817), new DateTime(2020, 10, 8, 1, 50, 47, 193, DateTimeKind.Local).AddTicks(1285), new DateTime(2020, 10, 7, 22, 7, 14, 546, DateTimeKind.Local).AddTicks(992), 45, "", "https://maëlys.eu", "quis" },
                    { 79, new DateTime(2020, 10, 7, 16, 47, 23, 375, DateTimeKind.Local).AddTicks(4479), new DateTime(2020, 10, 8, 8, 17, 41, 752, DateTimeKind.Local).AddTicks(8577), new DateTime(2020, 10, 7, 12, 47, 49, 658, DateTimeKind.Local).AddTicks(5161), 34, "", "http://jade.name", "aperiam" },
                    { 57, new DateTime(2020, 10, 8, 10, 43, 28, 678, DateTimeKind.Local).AddTicks(7805), new DateTime(2020, 10, 7, 13, 35, 5, 410, DateTimeKind.Local).AddTicks(1420), new DateTime(2020, 10, 7, 13, 11, 38, 655, DateTimeKind.Local).AddTicks(9538), 45, "", "http://océane.fr", "vel" },
                    { 30, new DateTime(2020, 10, 8, 9, 12, 32, 822, DateTimeKind.Local).AddTicks(694), new DateTime(2020, 10, 8, 1, 10, 49, 480, DateTimeKind.Local).AddTicks(9020), new DateTime(2020, 10, 8, 9, 19, 10, 202, DateTimeKind.Local).AddTicks(9775), 46, "", "https://tom.com", "repellendus" },
                    { 34, new DateTime(2020, 10, 8, 10, 10, 34, 929, DateTimeKind.Local).AddTicks(4176), new DateTime(2020, 10, 8, 5, 31, 0, 76, DateTimeKind.Local).AddTicks(4031), new DateTime(2020, 10, 7, 15, 4, 7, 806, DateTimeKind.Local).AddTicks(4953), 46, "", "https://théo.name", "quos" },
                    { 55, new DateTime(2020, 10, 7, 21, 1, 20, 419, DateTimeKind.Local).AddTicks(3290), new DateTime(2020, 10, 7, 20, 49, 38, 339, DateTimeKind.Local).AddTicks(6534), new DateTime(2020, 10, 7, 12, 14, 37, 819, DateTimeKind.Local).AddTicks(9796), 47, "", "http://thomas.eu", "rerum" },
                    { 67, new DateTime(2020, 10, 8, 0, 49, 33, 895, DateTimeKind.Local).AddTicks(8830), new DateTime(2020, 10, 7, 18, 29, 20, 724, DateTimeKind.Local).AddTicks(1795), new DateTime(2020, 10, 7, 21, 36, 49, 75, DateTimeKind.Local).AddTicks(6059), 49, "", "https://mohamed.net", "possimus" },
                    { 74, new DateTime(2020, 10, 7, 20, 23, 42, 762, DateTimeKind.Local).AddTicks(3576), new DateTime(2020, 10, 8, 10, 2, 51, 116, DateTimeKind.Local).AddTicks(756), new DateTime(2020, 10, 8, 1, 52, 4, 164, DateTimeKind.Local).AddTicks(2576), 49, "", "https://yanis.fr", "inventore" },
                    { 11, new DateTime(2020, 10, 7, 19, 58, 3, 48, DateTimeKind.Local).AddTicks(2127), new DateTime(2020, 10, 7, 21, 43, 6, 953, DateTimeKind.Local).AddTicks(5932), new DateTime(2020, 10, 7, 16, 5, 9, 1, DateTimeKind.Local).AddTicks(4126), 54, "", "https://louna.name", "et" },
                    { 33, new DateTime(2020, 10, 8, 6, 53, 46, 767, DateTimeKind.Local).AddTicks(6652), new DateTime(2020, 10, 8, 0, 22, 59, 54, DateTimeKind.Local).AddTicks(6839), new DateTime(2020, 10, 7, 22, 21, 11, 60, DateTimeKind.Local).AddTicks(2425), 56, "", "http://baptiste.eu", "voluptate" },
                    { 70, new DateTime(2020, 10, 8, 9, 58, 43, 14, DateTimeKind.Local).AddTicks(9241), new DateTime(2020, 10, 8, 3, 33, 43, 213, DateTimeKind.Local).AddTicks(5943), new DateTime(2020, 10, 7, 18, 19, 18, 486, DateTimeKind.Local).AddTicks(9079), 45, "", "http://louna.info", "et" },
                    { 95, new DateTime(2020, 10, 7, 19, 55, 27, 756, DateTimeKind.Local).AddTicks(9000), new DateTime(2020, 10, 8, 1, 37, 38, 390, DateTimeKind.Local).AddTicks(2706), new DateTime(2020, 10, 7, 16, 46, 59, 54, DateTimeKind.Local).AddTicks(5258), 79, "", "http://mohamed.org", "laboriosam" },
                    { 26, new DateTime(2020, 10, 7, 23, 54, 14, 250, DateTimeKind.Local).AddTicks(5634), new DateTime(2020, 10, 8, 7, 14, 42, 485, DateTimeKind.Local).AddTicks(9852), new DateTime(2020, 10, 8, 4, 12, 44, 878, DateTimeKind.Local).AddTicks(6525), 34, "", "https://kylian.org", "blanditiis" },
                    { 98, new DateTime(2020, 10, 8, 1, 20, 10, 114, DateTimeKind.Local).AddTicks(5803), new DateTime(2020, 10, 7, 21, 39, 11, 911, DateTimeKind.Local).AddTicks(6542), new DateTime(2020, 10, 8, 9, 39, 59, 191, DateTimeKind.Local).AddTicks(9255), 31, "", "https://mathéo.org", "doloribus" },
                    { 90, new DateTime(2020, 10, 7, 22, 38, 47, 697, DateTimeKind.Local).AddTicks(1238), new DateTime(2020, 10, 7, 21, 21, 40, 75, DateTimeKind.Local).AddTicks(1902), new DateTime(2020, 10, 8, 2, 1, 21, 589, DateTimeKind.Local).AddTicks(1236), 18, "", "http://alice.name", "praesentium" },
                    { 64, new DateTime(2020, 10, 7, 17, 33, 19, 841, DateTimeKind.Local).AddTicks(2026), new DateTime(2020, 10, 7, 13, 38, 9, 946, DateTimeKind.Local).AddTicks(3356), new DateTime(2020, 10, 8, 6, 28, 52, 1, DateTimeKind.Local).AddTicks(7076), 20, "", "https://louna.info", "et" },
                    { 84, new DateTime(2020, 10, 7, 12, 31, 52, 673, DateTimeKind.Local).AddTicks(661), new DateTime(2020, 10, 7, 14, 13, 59, 831, DateTimeKind.Local).AddTicks(247), new DateTime(2020, 10, 7, 17, 17, 14, 666, DateTimeKind.Local).AddTicks(7470), 20, "", "http://juliette.eu", "rem" },
                    { 58, new DateTime(2020, 10, 8, 5, 14, 29, 369, DateTimeKind.Local).AddTicks(3484), new DateTime(2020, 10, 8, 11, 16, 52, 644, DateTimeKind.Local).AddTicks(4221), new DateTime(2020, 10, 7, 14, 9, 19, 323, DateTimeKind.Local).AddTicks(4103), 21, "", "https://lucie.eu", "qui" },
                    { 4, new DateTime(2020, 10, 8, 11, 43, 39, 1, DateTimeKind.Local).AddTicks(2549), new DateTime(2020, 10, 7, 20, 28, 31, 155, DateTimeKind.Local).AddTicks(6615), new DateTime(2020, 10, 7, 18, 10, 34, 758, DateTimeKind.Local).AddTicks(5061), 22, "", "https://noa.eu", "maxime" },
                    { 7, new DateTime(2020, 10, 7, 13, 9, 7, 573, DateTimeKind.Local).AddTicks(8181), new DateTime(2020, 10, 8, 9, 17, 30, 585, DateTimeKind.Local).AddTicks(181), new DateTime(2020, 10, 8, 8, 13, 2, 87, DateTimeKind.Local).AddTicks(7139), 22, "", "http://lucas.net", "praesentium" },
                    { 42, new DateTime(2020, 10, 7, 16, 4, 32, 388, DateTimeKind.Local).AddTicks(5252), new DateTime(2020, 10, 8, 10, 29, 47, 801, DateTimeKind.Local).AddTicks(7816), new DateTime(2020, 10, 8, 3, 11, 11, 331, DateTimeKind.Local).AddTicks(4360), 22, "", "https://louna.name", "quo" },
                    { 16, new DateTime(2020, 10, 8, 2, 17, 24, 82, DateTimeKind.Local).AddTicks(9716), new DateTime(2020, 10, 8, 3, 44, 21, 65, DateTimeKind.Local).AddTicks(989), new DateTime(2020, 10, 8, 10, 58, 41, 203, DateTimeKind.Local).AddTicks(601), 32, "", "http://anaïs.org", "in" },
                    { 31, new DateTime(2020, 10, 7, 19, 12, 2, 314, DateTimeKind.Local).AddTicks(559), new DateTime(2020, 10, 7, 14, 53, 29, 447, DateTimeKind.Local).AddTicks(3571), new DateTime(2020, 10, 8, 7, 42, 21, 451, DateTimeKind.Local).AddTicks(3445), 23, "", "http://lina.org", "perspiciatis" },
                    { 22, new DateTime(2020, 10, 8, 2, 27, 35, 134, DateTimeKind.Local).AddTicks(8999), new DateTime(2020, 10, 8, 1, 8, 7, 460, DateTimeKind.Local).AddTicks(2153), new DateTime(2020, 10, 7, 20, 37, 44, 66, DateTimeKind.Local).AddTicks(2094), 61, "", "https://jade.fr", "aut" },
                    { 19, new DateTime(2020, 10, 8, 6, 30, 5, 9, DateTimeKind.Local).AddTicks(7339), new DateTime(2020, 10, 7, 14, 6, 5, 777, DateTimeKind.Local).AddTicks(7765), new DateTime(2020, 10, 7, 13, 10, 25, 112, DateTimeKind.Local).AddTicks(8137), 28, "", "http://marie.name", "iure" },
                    { 100, new DateTime(2020, 10, 7, 20, 18, 48, 213, DateTimeKind.Local).AddTicks(5047), new DateTime(2020, 10, 8, 1, 37, 4, 8, DateTimeKind.Local).AddTicks(6705), new DateTime(2020, 10, 7, 23, 54, 25, 741, DateTimeKind.Local).AddTicks(4877), 28, "", "http://paul.info", "repellat" },
                    { 29, new DateTime(2020, 10, 8, 9, 50, 43, 108, DateTimeKind.Local).AddTicks(2951), new DateTime(2020, 10, 7, 21, 3, 42, 475, DateTimeKind.Local).AddTicks(4546), new DateTime(2020, 10, 8, 5, 6, 5, 668, DateTimeKind.Local).AddTicks(5900), 29, "", "http://lucas.fr", "quibusdam" },
                    { 96, new DateTime(2020, 10, 8, 6, 29, 9, 583, DateTimeKind.Local).AddTicks(6419), new DateTime(2020, 10, 7, 15, 9, 22, 134, DateTimeKind.Local).AddTicks(530), new DateTime(2020, 10, 8, 6, 28, 55, 552, DateTimeKind.Local).AddTicks(2168), 30, "", "https://clara.fr", "voluptate" },
                    { 18, new DateTime(2020, 10, 8, 0, 53, 46, 331, DateTimeKind.Local).AddTicks(1994), new DateTime(2020, 10, 8, 7, 11, 47, 27, DateTimeKind.Local).AddTicks(3808), new DateTime(2020, 10, 7, 12, 33, 42, 831, DateTimeKind.Local).AddTicks(5323), 31, "", "https://baptiste.com", "sed" },
                    { 80, new DateTime(2020, 10, 7, 22, 9, 42, 921, DateTimeKind.Local).AddTicks(7403), new DateTime(2020, 10, 7, 13, 10, 47, 310, DateTimeKind.Local).AddTicks(6747), new DateTime(2020, 10, 7, 16, 27, 49, 119, DateTimeKind.Local).AddTicks(191), 31, "", "http://mael.info", "autem" },
                    { 60, new DateTime(2020, 10, 8, 4, 19, 35, 416, DateTimeKind.Local).AddTicks(3534), new DateTime(2020, 10, 8, 10, 45, 2, 253, DateTimeKind.Local).AddTicks(7079), new DateTime(2020, 10, 8, 4, 13, 13, 20, DateTimeKind.Local).AddTicks(6014), 26, "", "https://maeva.org", "sit" },
                    { 85, new DateTime(2020, 10, 8, 8, 45, 59, 495, DateTimeKind.Local).AddTicks(5222), new DateTime(2020, 10, 8, 5, 27, 32, 746, DateTimeKind.Local).AddTicks(5819), new DateTime(2020, 10, 8, 9, 34, 53, 83, DateTimeKind.Local).AddTicks(6767), 59, "", "https://quentin.fr", "rem" },
                    { 99, new DateTime(2020, 10, 8, 5, 17, 10, 111, DateTimeKind.Local).AddTicks(2503), new DateTime(2020, 10, 8, 11, 23, 49, 299, DateTimeKind.Local).AddTicks(6010), new DateTime(2020, 10, 8, 2, 34, 1, 789, DateTimeKind.Local).AddTicks(5257), 79, "", "http://lola.fr", "non" },
                    { 36, new DateTime(2020, 10, 7, 21, 38, 48, 19, DateTimeKind.Local).AddTicks(1301), new DateTime(2020, 10, 7, 20, 21, 57, 874, DateTimeKind.Local).AddTicks(6313), new DateTime(2020, 10, 7, 22, 32, 1, 730, DateTimeKind.Local).AddTicks(1143), 83, "", "https://sacha.fr", "eum" },
                    { 39, new DateTime(2020, 10, 8, 10, 43, 35, 131, DateTimeKind.Local).AddTicks(9398), new DateTime(2020, 10, 8, 6, 31, 46, 887, DateTimeKind.Local).AddTicks(4281), new DateTime(2020, 10, 8, 5, 10, 52, 893, DateTimeKind.Local).AddTicks(4369), 80, "", "https://mathilde.eu", "quas" },
                    { 2, new DateTime(2020, 10, 8, 2, 15, 6, 507, DateTimeKind.Local).AddTicks(1007), new DateTime(2020, 10, 7, 23, 27, 1, 484, DateTimeKind.Local).AddTicks(8780), new DateTime(2020, 10, 8, 11, 34, 12, 101, DateTimeKind.Local).AddTicks(2337), 100, "", "https://laura.com", "incidunt" },
                    { 28, new DateTime(2020, 10, 7, 14, 18, 58, 878, DateTimeKind.Local).AddTicks(4465), new DateTime(2020, 10, 8, 7, 19, 17, 850, DateTimeKind.Local).AddTicks(3839), new DateTime(2020, 10, 8, 1, 18, 58, 690, DateTimeKind.Local).AddTicks(1484), 99, "", "https://carla.info", "consequatur" },
                    { 5, new DateTime(2020, 10, 7, 13, 27, 48, 170, DateTimeKind.Local).AddTicks(9486), new DateTime(2020, 10, 8, 11, 8, 1, 545, DateTimeKind.Local).AddTicks(8656), new DateTime(2020, 10, 7, 23, 28, 26, 981, DateTimeKind.Local).AddTicks(24), 98, "", "http://lina.name", "quam" },
                    { 59, new DateTime(2020, 10, 8, 0, 51, 4, 544, DateTimeKind.Local).AddTicks(8737), new DateTime(2020, 10, 7, 16, 52, 2, 860, DateTimeKind.Local).AddTicks(5241), new DateTime(2020, 10, 8, 5, 32, 43, 774, DateTimeKind.Local).AddTicks(9266), 96, "", "https://ethan.org", "modi" },
                    { 86, new DateTime(2020, 10, 7, 15, 2, 29, 249, DateTimeKind.Local).AddTicks(115), new DateTime(2020, 10, 7, 19, 14, 6, 635, DateTimeKind.Local).AddTicks(6477), new DateTime(2020, 10, 7, 15, 42, 21, 707, DateTimeKind.Local).AddTicks(4112), 95, "", "http://lina.com", "quos" },
                    { 38, new DateTime(2020, 10, 7, 13, 13, 30, 542, DateTimeKind.Local).AddTicks(6526), new DateTime(2020, 10, 7, 16, 10, 26, 87, DateTimeKind.Local).AddTicks(8551), new DateTime(2020, 10, 7, 19, 23, 15, 839, DateTimeKind.Local).AddTicks(8316), 95, "", "http://victor.net", "debitis" },
                    { 92, new DateTime(2020, 10, 7, 20, 30, 46, 383, DateTimeKind.Local).AddTicks(7356), new DateTime(2020, 10, 7, 16, 7, 20, 717, DateTimeKind.Local).AddTicks(4179), new DateTime(2020, 10, 8, 9, 5, 12, 77, DateTimeKind.Local).AddTicks(3616), 94, "", "https://louis.org", "facere" },
                    { 82, new DateTime(2020, 10, 7, 16, 24, 36, 842, DateTimeKind.Local).AddTicks(2601), new DateTime(2020, 10, 7, 22, 17, 13, 493, DateTimeKind.Local).AddTicks(3981), new DateTime(2020, 10, 7, 14, 8, 58, 772, DateTimeKind.Local).AddTicks(9813), 94, "", "http://julie.net", "facere" },
                    { 43, new DateTime(2020, 10, 8, 3, 1, 20, 634, DateTimeKind.Local).AddTicks(5837), new DateTime(2020, 10, 7, 14, 20, 0, 616, DateTimeKind.Local).AddTicks(5928), new DateTime(2020, 10, 8, 9, 9, 12, 456, DateTimeKind.Local).AddTicks(4982), 60, "", "https://célia.org", "atque" },
                    { 3, new DateTime(2020, 10, 7, 14, 7, 10, 502, DateTimeKind.Local).AddTicks(387), new DateTime(2020, 10, 7, 18, 28, 33, 285, DateTimeKind.Local).AddTicks(8221), new DateTime(2020, 10, 8, 5, 39, 18, 725, DateTimeKind.Local).AddTicks(417), 91, "", "http://marie.eu", "distinctio" },
                    { 15, new DateTime(2020, 10, 7, 12, 41, 56, 150, DateTimeKind.Local).AddTicks(8444), new DateTime(2020, 10, 8, 7, 26, 15, 660, DateTimeKind.Local).AddTicks(2090), new DateTime(2020, 10, 8, 1, 16, 30, 558, DateTimeKind.Local).AddTicks(7260), 90, "", "http://justine.com", "harum" },
                    { 61, new DateTime(2020, 10, 8, 10, 43, 50, 192, DateTimeKind.Local).AddTicks(4664), new DateTime(2020, 10, 7, 16, 5, 38, 502, DateTimeKind.Local).AddTicks(3516), new DateTime(2020, 10, 8, 0, 7, 45, 309, DateTimeKind.Local).AddTicks(7380), 89, "", "https://mélissa.eu", "numquam" },
                    { 75, new DateTime(2020, 10, 7, 21, 21, 32, 9, DateTimeKind.Local).AddTicks(472), new DateTime(2020, 10, 7, 21, 22, 30, 862, DateTimeKind.Local).AddTicks(3196), new DateTime(2020, 10, 7, 22, 3, 28, 501, DateTimeKind.Local).AddTicks(3347), 88, "", "http://lena.org", "iste" },
                    { 62, new DateTime(2020, 10, 8, 5, 54, 42, 647, DateTimeKind.Local).AddTicks(4106), new DateTime(2020, 10, 8, 4, 45, 6, 941, DateTimeKind.Local).AddTicks(3925), new DateTime(2020, 10, 8, 6, 6, 24, 255, DateTimeKind.Local).AddTicks(3148), 88, "", "https://quentin.info", "sunt" },
                    { 51, new DateTime(2020, 10, 7, 15, 50, 45, 182, DateTimeKind.Local).AddTicks(8978), new DateTime(2020, 10, 8, 0, 24, 57, 565, DateTimeKind.Local).AddTicks(5982), new DateTime(2020, 10, 7, 20, 21, 2, 31, DateTimeKind.Local).AddTicks(2162), 88, "", "https://elisa.org", "quia" },
                    { 8, new DateTime(2020, 10, 8, 6, 29, 24, 796, DateTimeKind.Local).AddTicks(1512), new DateTime(2020, 10, 8, 10, 45, 53, 639, DateTimeKind.Local).AddTicks(6254), new DateTime(2020, 10, 7, 22, 30, 8, 465, DateTimeKind.Local).AddTicks(1707), 88, "", "https://alexis.net", "recusandae" },
                    { 46, new DateTime(2020, 10, 8, 8, 40, 43, 300, DateTimeKind.Local).AddTicks(1408), new DateTime(2020, 10, 7, 13, 55, 49, 12, DateTimeKind.Local).AddTicks(486), new DateTime(2020, 10, 8, 3, 7, 27, 489, DateTimeKind.Local).AddTicks(7418), 87, "", "https://benjamin.org", "in" },
                    { 71, new DateTime(2020, 10, 8, 2, 37, 29, 372, DateTimeKind.Local).AddTicks(2311), new DateTime(2020, 10, 8, 11, 18, 12, 78, DateTimeKind.Local).AddTicks(9059), new DateTime(2020, 10, 8, 3, 59, 9, 273, DateTimeKind.Local).AddTicks(2778), 92, "", "http://romane.fr", "totam" },
                    { 69, new DateTime(2020, 10, 8, 2, 26, 1, 770, DateTimeKind.Local).AddTicks(5180), new DateTime(2020, 10, 8, 5, 38, 40, 108, DateTimeKind.Local).AddTicks(8371), new DateTime(2020, 10, 8, 9, 43, 54, 905, DateTimeKind.Local).AddTicks(7960), 85, "", "http://romain.eu", "voluptas" }
                });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 867, 12, new DateTime(2020, 10, 7, 12, 3, 42, 383, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 180, null, "R91P6", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "Veiller à ce qu’une suite soit donnée aux recommandations de la commission consultative sur la régionalisation concernant l’égalité entre les sexes dans le cadre de la mise en place du système de gouvernance des régions et d’autres collectivités territoriales envisagé dans la Constitution; les fonds de développement social et de solidarité interrégionale prévus par la Constitution doivent intégrer dans leur travail les principes de la budgétisation axée sur la parité.", "null", "", "" },
                    { 179, null, "R91P3P4", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "c) Revoir la représentation des femmes au Conseil des ministres pour faire en sorte que les objectifs d’égalité formelle et effective entre les hommes et les femmes soient atteints ;  d) Revoir les règles de procédure régissant la prise de décisions aux échelons supérieurs des organes exécutif, législatif et judiciaire pour faire en sorte que l’objectif de la parité soit pris en compte", "null", "", "" },
                    { 178, null, "R90", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "a) le Conseil national des droits de l’homme et d’autres institutions nationales indépendantes doivent intensifier leurs efforts volontaristes pour faire face à la discrimination à l’égard des femmes en droit et en pratique en tant que partie intégrante des processus de protection et de promotion des droits de l’homme et de bonne gouvernance, notamment par le biais de systèmes indépendants de surveillance des droits de l’homme accessibles à toutes les femmes; b) Renforcer l’exécution de leurs mandats aux niveaux régional et local par des mesures spéciales pour assurer au niveau local l’accès des femmes qui sont victimes de multiples formes de discrimination.", "null", "", "" },
                    { 177, null, "R89P8", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "- Le Gouvernement devrait assurer un processus de consultation vaste et ouvert avec toutes les parties prenantes en faisant fond sur le travail accompli par le Conseil national des droits de l’homme, et faire en sorte que cette autorité coopère avec lui", "null", "", "" },
                    { 156, null, "R98", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 4, "Procédure spéciale", "-    La participation et la collaboration des organisations de la société civile sont essentielles dans le cadre de 35. À cet égard, des mesures devraient être prises immédiatement, d’une part, pour fournir l’appui nécessaire aux organisations de la société civile qui aident les victimes, notamment en leur proposant un accompagnement psychologique, et d’autre part, pour établir le cadre juridique requis. Les organisations de la société civile et les organismes d’aide aux victimes devraient être en mesure d’exercer leurs activités dans toutes les régions du pays.", "null", "", "" },
                    { 175, null, "R89P8", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "- Accélérer la création d’une autorité pour la parité et la lutte contre la discrimination à l’égard des femmes en tant qu’organisation faîtière pour consolider les acquis en matière d’égalité et d’élimination de la discrimination à l’égard des femmes.", "null", "", "" },
                    { 157, null, "R96P1", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 4, "Procédure spéciale", "-    Renforcer les relations de partenariat avec les pays d’origine dans toutes les régions, y compris l’Afrique subsaharienne et l’Asie du Sud‑Est, ainsi que de coopérer aux fins de l’échange d’informations et de la fourniture d’un appui juridique mutuel", "null", "", "" },
                    { 181, null, "R92", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "Les partis politiques instituent divers moyens de garantir l’intégration des femmes dans les listes électorales", "null", "", "" },
                    { 155, null, "R88P2", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 4, "Procédure spéciale", "-    Les agents de l’Inspection du travail devraient être habilités à surveiller les conditions de travail de ces employés, qui sont souvent plus exposés que quiconque au risque d’être victimes de la traite.", "null", "", "" },
                    { 176, null, "R89P8", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "- Le futur organisme devrait avoir pour tâches d’établir le bilan des progrès accomplis, de repérer les problèmes persistants et de proposer et d’exécuter des mesures en vue d’accomplir d’autres progrès.", "null", "", "" },
                    { 182, null, "R93P1", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "Revoir le fonds social pour le développement créé en vertu de la Constitution afin qu’il consacre une part équitable de ses ressources aux femmes, en particulier aux femmes rurales et aux femmes victimes de violence, de façon à les aider à jouir de leurs droits fondamentaux", "null", "", "" },
                    { 187, null, "R94", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "Le Groupe de travail recommande au Conseil national des droits de l’homme et à d’autres organismes nationaux indépendants de mettre en place, là où il n’en existe pas, des mécanismes efficaces de surveillance et de protection sensibles à la condition des femmes et capables d’atteindre les communautés pauvres et rurales et, notamment, de faire face à la discrimination extrême dont sont victimes les travailleuses dans les champs de fraises du nord du Maroc.", "null", "", "" },
                    { 184, null, "R93P2", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "Prendre des mesures pour faire en sorte que les conseils locaux soient plus soucieux des questions de parité entre les sexes et de promouvoir, en tant que moyen d’autonomiser davantage la femme, la capacité individuelle et collective des femmes locales de participer véritablement à la vie publique au niveau local", "null", "", "" },
                    { 185, null, "R93P4P5", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "Accélérer l’entrée en service du Fonds pour la famille et les déboursements pour aider les bénéficiaires qui sont dans le besoin- Renouveler le programme Tamkine et assurer sa viabilité, et faire bénéficier de ses prestations les groupes de femmes rurales et d’autres femmes marginalisées", "null", "", "" },
                    { 186, null, "R93P6", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "Elargir la protection juridique aux organisations caritatives qui fournissent une assistance et une protection aux groupes de femmes vulnérables et assurer un appui continu et d’une plus vaste portée de la part de l’État", "null", "", "" },
                    { 154, null, "R86", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 4, "Procédure spéciale", "-    Davantage de ressources, financières et autres, devraient être allouées à l’aide aux victimes de la traite, et des programmes et des institutions parrainés ou soutenus par l’État devraient être créés et développés de sorte que les victimes puissent bénéficier de soins à court et à long terme.", "null", "", "" },
                    { 211, null, "R83P12", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 7, "Procédure spéciale", "Afin de lutter contre le surpeuplement dans les prisons, utiliser des alternatives à la détention préventive en conformité avec les Règles minima des Nations Unies pour l’élaboration de mesures non privatives de liberté (Règles de Tokyo) et étudier la dépénalisation possible de certaines infractions et la réduction possible des peines de prison. - Un système pourrait être conçu pour organiser la caution et l’usage plus fréquent des sanctions non privatives de liberté dans le cas d’infractions moins graves", "null", "", "" },
                    { 212, null, "R83P13", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 7, "Procédure spéciale", "-       Continuer de s’engager à renforcer le 4 et lui fournir tous les moyens nécessaires pour assurer son bon fonctionnement ;", "null", "", "" },
                    { 213, null, "R83P14P2", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 7, "Procédure spéciale", "-       … établir un mécanisme national de prévention efficace, conformément à l’article 17 du Protocole facultatif ; et lancer un processus de consultation inclusif de tous les acteurs concernés, y compris les organisations de la société civile", "null", "", "" },
                    { 214, null, "R83P15", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 7, "Procédure spéciale", "-       Allouer des crédits pour équiper le mécanisme national de prévention des ressources humaines et autres suffisantes pour lui permettre d’inspecter régulièrement tous les lieux de détention, de recevoir des plaintes, d’engager des poursuites et de les suivre jusqu’à leur conclusion;", "null", "", "" },
                    { 248, null, "R73P3", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 8, "Procédure spéciale", "Renforcer la politique globale de développement national, de la planification et de la conception à la mise en œuvre et l’exécution, au suivi, à l’examen et à l’évaluation et à la cohérence et l’harmonisation des politiques entre les divers ministères, y compris ceux qui œuvrent en faveur de la coopération internationale pour le développement. Il est fortement recommandé qu’un seul service soit investi d’une fonction de contrôle à cet égard, de façon à optimiser les ressources et à éviter les doubles emplois", "null", "", "" },
                    { 249, null, "R73P4", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 8, "Procédure spéciale", "Mettre en œuvre des consultations plus systématiques et approfondies aux fins de la planification, de la mise en œuvre, du suivi et de l’évaluation des programmes de développement, y compris les programmes d’aide au développement, avec la participation effective de la société civile et des collectivités concernées", "null", "", "" },
                    { 250, null, "R73P6-1", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 8, "Procédure spéciale", "Collaborer avec les acteurs de la société civile, y compris les organisations de défense des droits de l’homme et les partenaires de développement, afin de mettre en place un cadre de suivi des fonds étrangers reçus par les acteurs de la société civile. Ce cadre devrait se fonder sur l’impartialité et l’objectivité, le principe de responsabilité, la transparence et l’équité, et être entièrement compatible avec la liberté d’association", "null", "", "" },
                    { 251, null, "R73P3", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 8, "Procédure spéciale", "Mettre en place un cadre tripartite, composé de représentants du Gouvernement, des partenaires de développement et de la société civile, qui soit chargé de suivre la mise en œuvre et les résultats des programmes d’aide au développement", "null", "", "" },
                    { 252, null, "R74P1", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 8, "Procédure spéciale", "Consulter toutes les parties prenantes concernées par les programmes d’aide au développement et intégrer pleinement les approches fondées sur les droits de l’homme à tous les stades du processus, de la planification à la mise en œuvre, au suivi et à l’évaluation", "null", "", "" },
                    { 183, null, "null", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 6, "Procédure spéciale", "null", "null", "", "" },
                    { 153, null, "R85", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 4, "Procédure spéciale", "-    le Gouvernement devrait faire beaucoup plus d’efforts pour protéger et aider toutes les victimes de la traite, y compris les hommes et les garçons, en veillant au plein respect de leurs droits de l’homme, et devrait faire en sorte que les enquêtes menées sur les affaires de traite soient axées sur une approche fondée sur les droits de l’homme.", "null", "", "" },
                    { 129, null, "R98", "ت.98", "", "Non réalisé", "", 0, 9, null, null, null, null, 3, "Procédure spéciale", "-    Le Rapporteur spécial invite la communauté internationale à appuyer le Maroc dans ses efforts pour appliquer les recommandations ci-dessus, et notamment pour reformer son système judiciaire, mettre en place un cadre de prévention de la torture et des mauvais traitements et un mécanisme national de prévention efficace et dispenser à la police et au personnel pénitentiaire la formation voulue.", "-          يطلب المقرر الخاص إلى المجتمع الدولي أن يدعم جهود المغرب الرامية إلى تطبيق التوصيات المذكورة، خاصة إصلاح نظامه القانوني، ووضع إطار للوقاية من التعذيب وسوء المعاملة، وإنشاء آلية وقائية وطنية، وتوفير التدريب المناسب لأفراد الشرطة وموظفي السجون.", "", "" },
                    { 151, null, "R83P1", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 4, "Procédure spéciale", "-    Mettre en place un système de détection adapté, doté de ressources suffisantes, devrait être mis en place. Ce système devrait comporter des outils et des protocoles spécifiques permettant de repérer les victimes de la traite", "null", "", "" },
                    { 36, null, "R72", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 1, "Procédure spéciale", "-   Revoir régulièrement les politiques qui ont trait aux importations et aux secours d’urgence afin de garantir la sécurité alimentaire.", "null", "", "" },
                    { 37, null, "R86", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 1, "Procédure spéciale", "-   Promouvoir la mise en place d’une budgétisation tenant compte des questions de genre comme outil permettant d’évaluer les politiques publiques du point de vue du genre", "null", "", "" },
                    { 38, null, "R96P2", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 1, "Procédure spéciale", "Pour les provinces marocaines du sud :- Suivre la mise en œuvre des programmes relatifs aux jeunes", "null", "", "" },
                    { 67, null, "R88", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 2, "Procédure spéciale", "-       Le Conseil national des droits de l’homme doit jouer un rôle de premier plan pour favoriser une meilleure compréhension des droits de l’homme en ce qui concerne le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, qui se manifestent tous même dans des sociétés comme celle du Maroc, pays dont l’identité nationale est traditionnellement marquée par la diversité et la multiculturalité.", "null", "", "" },
                    { 68, null, "R89", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 2, "Procédure spéciale", "-       Le Conseil national des droits de l’homme doit jouer un rôle moteur dans l’adoption et la mise en œuvre à l’échelle nationale d’un plan d’action pour combattre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, conformément à la Déclaration et au Programme d’action de Durban.", "null", "", "" },
                    { 69, null, "R92", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 2, "Procédure spéciale", "-       Le Conseil national des droits de l’homme doit poursuivre son important travail de sensibilisation au racisme, à la discrimination raciale, à la xénophobie et à l’intolérance qui y est associée, de signalement des cas et d’assistance aux victimes dans tous les contextes.", "null", "", "" },
                    { 70, null, "R70P3", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 2, "Procédure spéciale", "-       Adopter un plan d’action national de lutte contre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée.", "null", "", "" },
                    { 71, null, "R93", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 2, "Procédure spéciale", "-       l’Union européenne et de ses États membres doivent cesser de faire pression sur les gouvernements africains pour qu’ils limitent la liberté de circulation des Africains et qu’ils fassent de la sécurisation des frontières contre les migrations une priorité en appliquant des pratiques inhumaines, notamment en ayant recours à la discrimination raciale.", "null", "", "" },
                    { 72, null, "R94", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 2, "Procédure spéciale", "-       l’Union européenne et de ses États membres doivent appliquer une approche régionale de gouvernance des migrations qui soit fondée sur les droits de l’homme et qui comprenne des voies légales de migration.", "null", "", "" },
                    { 73, null, "R95", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 2, "Procédure spéciale", "-       Les organismes des Nations Unies chargés des questions relatives aux réfugiés et aux migrants doivent fournir d’urgence une aide humanitaire aux migrants noirs d’origine subsaharienne qui vivent dans la forêt de Tanger ainsi qu’aux autres migrants victimes de graves violations des droits de l’homme dans tout le pays, en particulier les femmes et les enfants qui sont au quotidien la cible de violences, notamment sexuelles, commises par les réseaux de passeurs et de trafiquants, entre autres.", "null", "", "" },
                    { 74, null, "R96", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 2, "Procédure spéciale", "-       Les organismes des Nations Unies chargés des questions relatives aux réfugiés et aux migrants doivent veiller à ce qu’une approche fondée sur les droits de l’homme soit au cœur de tout le travail effectué, à l’échelle nationale et locale, auprès des migrants, des demandeurs d’asile et des réfugiés en situation régulière et irrégulière, en mettant particulièrement l’accent sur la promotion de leurs droits à la non-discrimination et à l’égalité", "null", "", "" },
                    { 116, null, "R88P7", "ت.88.ف.7", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    mettre en place un mécanisme d’enquête pénale et de poursuites indépendant qui n’ait aucun lien avec l’organe chargé de l’enquête ou des poursuites dans la procédure engagée contre la victime présumée; de donner effet au droit de plainte et de faire en sorte que les défendeurs qui comparaissent devant le mécanisme aient une bonne chance de formuler leurs allégations au sujet des tortures et des mauvais traitements qu’ils ont pu subir", "-          (ز) إنشاء آلية للتحقيق الجنائي والملاحقة تكون فعالة ومستقلة ولا ترتبط بالهيئة المكلفة بالتحقيق في الدعاوى المقامة على من يدعون أنهم ضحايا وبملاحقتهم؛ وإعمال الحق في الشكوى؛ والتأكد من إتاحة الفرصة أمام المدّعى عليهم الذين يمثلون أولاً أمام الآلية كي يتحدثوا عما يدعونه من تعرضهم للتعذيب أو سوء المعاملة؛", "", "" },
                    { 152, null, "R84", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 4, "Procédure spéciale", "Étant donné que l’on ne dispose pas de données fiables au sujet de la traite, il est urgent de mettre au point un mécanisme de collecte de données sur les affaires de traite, ainsi que sur les formes de traite, les différentes manifestations de ce phénomène et les tendances observées dans ce domaine. - Ces données sont essentielles à l’élaboration de mesures réfléchies de lutte contre la traite.", "null", "", "" },
                    { 117, null, "R88P12", "ت.88.ف.12", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    Fournir au Ministère de l’26 tout le soutien logistique et financier nécessaire pour lui permettre d’appliquer le projet envisagé par le Ministère de la justice et des libertés visant à effectuer un enregistrement vidéo de toutes les déclarations faites à la police pendant l’enquête et l’interrogatoire. De telles mesures ne doivent pas se substituer à la représentation légale pendant toutes les phases de l’interrogatoire mais la compléter", "-          (ل) إمداد وزارة الداخلية بكل الدعم اللوجستي والمالي اللازم لتنفيذ مشروع وزير العدل والحريات الداعي إلى تسجيل جميع بيانات الشرطة بالصورة والصوت أثناء التحقيق والاستجواب. وينبغي النظر إلى هذا الأسلوب على أنه يكمل التمثيل القضائي في جميع مراحل الاستجواب؛", "", "" },
                    { 119, null, "R88P14-2", "ت.88.ف.14ج2", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    Créer un mécanisme national de prévention de la torture efficace conformément à l’article 17 du Protocole facultatif, et entamer un processus de consultation de toutes les parties prenantes sans exception, notamment les organisations de la société civile", "-          (ن)  ....إنشاء آلية وقاية وطنية فعالة وفقاً للمادة 17 من البروتوكول الاختياري؛ وبدء عملية تشاور يشارك فيها جميع الفاعلين المعنيين بالموضوع، مثل منظمات المجتمع المدني؛", "", "" },
                    { 120, null, "R88P15", "ت.88.ف.15", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    Ouvrir les crédits nécessaires pour doter le mécanisme national de prévention des ressources humaines et autres dont il a besoin pour inspecter régulièrement tous les lieux de détention, recevoir des plaintes, engager des poursuites et les suivre jusqu’à leur terme", "-          (س) رصد ميزانية لإمداد آلية الوقاية الوطنية بما يكفي من موارد بشرية وغيرها حتى يتسنى لها تفتيش جميع أماكن الاحتجاز بانتظام، وتلقي الشكاوى، ورفع دعاوى ومتابعتها حتى نهايتها؛", "", "" },
                    { 121, null, "R88P16", "ت.88.ف.16", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    Renforcer la confiance et la coopération entre l’État et la société civile de façon que toutes les organisations non gouvernementales soient en mesure de collaborer de manière plus efficace avec les mécanismes nationaux et internationaux et d’effectuer un travail de sensibilisation sur la base de dossiers bien documentés", "-          (ع) ترسيخ الثقة وتوثيق التعاون بين الدول والمجتمع المدني بحيث تستطيع المنظمات غير الحكومية العمل بمزيد من الفاعلية مع الآليات الوطنية والدولية، والدعوة على أساس حالات موثقة توثيقاً جيداً؛", "", "" },
                    { 122, null, "R88P17", "ت.88.ف.17", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    Faciliter l’accès des organisations de la société civile aux établissements pénitentiaires et de renforcer le partenariat avec ces institutions pour qu’elles puissent jouer leur rôle de sensibilisation et de propagation de la culture des droits de l’homme et contribuer à l’amélioration de la formation des superviseurs et du personnel des établissements pénitentiaires.", "-          (ف) تسهيل زيارة منظمات المجتمع المدني الإصلاحيات، وتوطيد الشراكة معها لمساعدتها على أداء دورها في التوعية، ونشر ثقافة حقوق الإنسان، والمساهمة في الارتقاء بمستوى تدريب المشرفين عليها وموظفيها.", "", "" },
                    { 123, null, "R93P4", "ت.93.ف.4", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "Exercer un contrôle judiciaire sur les établissements pénitentiaires ;- Renforcer les pouvoirs des juges d’application de façon à leur permettre de contrôler de manière effective ces établissements, de surveiller l’application des peines et de vérifier leur validité ;- Renforcer le droit d’appel des personnes soumises à des mesures disciplinaires", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي:-  (د) فرض المراقبة القضائية على الإصلاحيات؛ وتدعيم سلطات القضاة المكلفين بتنفيذ الأحكام بحيث يستطيعون مراقبة تلك المؤسسات بفعالية، ورصد إنفاذ العقوبات، والتحقيق في صلاحيته؛ وتعزيز حق المتضررين من الإجراءات التأديبية في الاستئناف؛", "", "" },
                    { 125, null, "R94P2", "ت.94.ف. 2", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    Pour ce qui est des établissements psychiatriques, faire en sorte que le Bureau du Procureur général et le 4 effectuent des visites dans les établissements psychiatriques comme prévu par la loi.", "بخصوص المصحات النفسية، يوصي المقرر الخاص الحكومة بما يلي: (ب) زيارة النيابة العامة والمجلس الوطني لحقوق الإنسان المصحات النفسية، عملاً بالقانون.", "", "" },
                    { 126, null, "R95P1", "ت.95.ف.1", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    Faire en sorte que les plus hautes autorités, en particulier celles qui sont responsables de l’application de la loi, déclarent sans équivoque qu’elles ne toléreront pas le recours à la torture ou aux mauvais traitements par leurs subordonnés et que les auteurs de tels actes auront à en rendre compte ;", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي: (أ) السعي إلى أن تعلن أعلى السلطات، خاصة المعنية بأنشطة إنفاذ القوانين، بكامل الوضوح أنها لن تتساهل مع ممارسة المرؤوسين التعذيب أو إساءتهم المعاملة، ومساءلة الجناة؛", "", "" },
                    { 127, null, "R97P4", "ت.97.ف.4", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "En ce qui concerne les provinces marocaines du Sud -L’établissement d’un mécanisme régional intergouvernementales de surveillance des droits de l’homme, robuste, comme une mesure importante visant à instaurer la confiance et qui peut contribuer à améliorer la situation en ce qui concerne le respect des droits de l’homme et, en particulier, l’interdiction de la torture et autres peines ou traitements cruels, inhumains ou dégradants.", "فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي: (د)  من شأن المنطقة بكاملها أن تستفيد من إنشاء آلية حكومية دولية إقليمية متينة لحقوق الإنسان بوصفها إجراء مهماً لبناء الثقة قد يساعد على تحسين وضع التقيد بحقوق الإنسان، خاصة ما يتعلق بحظر التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة.", "", "" },
                    { 128, null, "R97P2", "ت.97.ف.2", "", "Non réalisé", "", 0, 9, null, null, null, null, 3, "Procédure spéciale", "En ce qui concerne les provinces marocaines du Sud : - Reconsidérer la compétence du tribunal militaire pour connaître d’affaires concernant des civils dans le cas des 23 Sahraouis en détention à la prison 1 de Salé et de veiller à ce qu’en principe, les civils ne soient pas condamnés par des tribunaux militaires- Ouvrir des enquêtes sérieuses et impartiales pour établir les faits exacts dans cette affaire et déterminer quelle est la responsabilité des membres de la police ou des forces de sécurité ; et d’enquêter sur toutes les allégations de torture et de mauvais traitements", "فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي:-  (ب) إعادة النظر في الولاية القضائية للمحكمة العسكرية في القضايا المدنية في حالة 23 رجلاً صحراوياً محتجزاً في 'سجن سَلا 1'، ومنع محاكمة محاكم عسكرية مدنيين مبدئياً؛ وإجراء تحقيقات نزيهة وفعالة للتأكد مما حدث حقيقة، وتحديد مسؤولية أفراد الشرطة أو قوات الأمن؛ والتحقيق في جميع ادعاءات التعذيب وسوء المعاملة؛", "", "" },
                    { 148, null, "R95P2", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 4, "Procédure spéciale", "-    …De nouvelles mesures devraient être prises pour que les victimes de la traite qui ont besoin d’une protection internationale soient dûment identifiées et aiguillées vers le système d’asile, selon que de besoin.", "null", "", "" },
                    { 149, null, "R81", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 4, "Procédure spéciale", "-    Mettre au point, d’entente avec toutes les parties prenantes, notamment les organisations de la société civile, un plan national d’action qui définisse clairement les objectifs à atteindre et les responsabilités de chacun et fixe des indicateurs clairs permettant de mesurer les progrès accomplis et l’efficacité des mesures prises pour lutter contre la traite des êtres humains", "null", "", "" },
                    { 150, null, "R82", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 4, "Procédure spéciale", "créer un organisme national qui serait chargé de coordonner les différentes activités menées par les organismes gouvernementaux dans le domaine de lutte contre la traite- envisager de nommer un rapporteur spécial, chargé de surveiller la mise en œuvre de la législation relative à la traite et des mesures prises dans ce domaine et de mesurer leurs effets sur la situation des droits de l’homme.", "null", "", "" },
                    { 118, null, "R88P13", "ت.88.ف.13", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    Mettre en place des mécanismes de plainte indépendants, efficaces et accessibles dans tous les lieux de détention en installant des lignes d’assistance téléphonique ou des boîtes confidentielles de dépôt de plaintes, et de faire en sorte que chaque détenu ait un accès sans entrave et sans surveillance au procureur sur sa demande et que les plaignants ne soient pas soumis à des représailles", "-          (م) إنشاء آليات شكوى مستقلة وفعالة وميسرة في جميع أماكن الاحتجاز بواسطة تركيب خطوط هاتف مباشرة أو صناديق لوضع الشكاوى سراً، وضمان اتصال كل محتجز بالمدعي العام دون عوائق أو مراقبة بناء على الطلب، وعدم الانتقام من الشاكين؛", "", "" },
                    { 124, null, "R93P5", "ت.93.ف.5", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    faciliter la surveillance exercée par les commissions régionales, au moyen d’inspections régulières et effectives des prisons et de la présentation de rapports sur la situation des prisons et des prisonniers, de façon à améliorer la situation dans les prisons et à donner effet aux droits des prisonniers ;", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي:   (ﻫ) تسهيل الرصد الذي تتولاه اللجان الإقليمية لتحسين الأوضاع في السجون، وإعمال حقوق السجناء، عن طريق الزيارات المنتظمة والفعالة إلى السجون، وتقديم التقارير عن أوضاع السجون والسجناء؛", "", "" },
                    { 254, null, "R73P1-1", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 8, "Procédure spéciale", "Fournir des informations simplifiées et largement accessibles sur les accords internationaux signés par le Maroc, notamment les accords économiques et commerciaux, et l’incidence de ces accords sur la population marocaine. Ces informations ne devraient pas être seulement accessibles sur des sites Web, afin de ne pas exclure ceux qui n’ont pas accès à Internet.", "null", "", "" },
                    { 687, null, "R28P4", "ت.28.ف4.", "", "Non réalisé", "", 0, 7, null, 5, null, null, null, "Organes de traités", "d) Organiser, pour les fonctionnaires de police et les agents de contrôle aux frontières, des formations sur le respect des droits de l’homme, le non-usage de la violence et plus particulièrement sur le contenu de la Convention.", @"اتخاذ تدابير بتكثيف الجهود في سبيل الإسراع في معالجة مشاكل سوء المعاملة وغير ذلك من أعمال العنف المرتكبة في حق العمال المهاجرين وأفراد أسرهم، أياً كان مرتكبوها. وعلى وجه الخصوص، توصي اللجنة الدولة الطرف باتخاذ التدابير التالية: 
                 (د) تدريب موظفي الشرطة ومراقبة الحدود على احترام حقوق الإنسان وعدم استعمال العنف، وبخاصة على محتوى الاتفاقية.", "", "" },
                    { 803, null, "R53P1", "ت.53.ف.1", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Compte tenu de l’article 23 de la Convention et de son Observation générale no 9 (2006) sur les droits des enfants handicapés, le Comité demande instamment au Maroc d’adopter une approche du handicap fondée sur les droits de l’homme et recommande en particulier:
                a) D’organiser la collecte de données sur les enfants handicapés et de mettre en place un système efficace de diagnostic du handicap, qui est nécessaire pour élaborer des politiques et des programmes en faveur des enfants handicapés;", @"تحث اللجنة المملكة المغربية، في ضوء المادة 23 من الاتفاقية وتعليقها العام     رقم 9(2006) بشأن حقوق الأطفال ذوي الإعاقة، على انتهاج نهج يقوم على حقوق الإنسان في التعاطي مع الإعاقة، وتوصيها بالآتي تحديداً: 
                - (أ) تنظيم جمع البيانات عن الأطفال ذوي الإعاقة ووضع نظام تشخيص يتسم بالكفاءة، وهو أمر ضروري لوضع سياسات وبرامج تلائم الأطفال ذوي الإعاقة", "", "" },
                    { 802, null, "R51P3P4P5", "ت.51.ف.3.ف.4.ف5", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"(Kafala) Le Comité recommande au Maroc:
                c) D’assurer un suivi approprié des enfants placés sous le régime de la kafalah;
                d) De prendre toutes les mesures nécessaires pour prévenir et punir l’exploitation d’enfants par le biais du système de la kafalah;
                e) Abroger la circulaire 40S/2 de 2012.", @"(ج) ضمان متابعة صحيحة الأطفال المكفولين؛ 
                - (د) اتخاذ جميع التدابير اللازمة لمنع استغلال الأطفال من خلال نظام الكفالة ومعاقبة الجناة؛ 
                - (هـ) إلغاء المنشور رقم 40/س2 الصادر في عام 2012.", "", "" },
                    { 801, null, "R49P1P3P4P6P7P8P9", "ت.49.ف.1.ف3.ف.4.ف5.ف.6.ف.7.ف8.ف.9", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Appelant l’attention sur les lignes directrices relatives à la protection de remplacement pour les enfants (résolution 64/142 de l’Assemblée générale, annexe), le Comité demande au Maroc:
                a) De faire en sorte que la pauvreté financière et matérielle ou les situations qui en résultent directement et exclusivement ne soient jamais l’unique raison de retirer un enfant à ses parents, de placer l’enfant dans une structure de protection de remplacement ou d’empêcher la réinsertion sociale de l’enfant;
                c) De renforcer les mécanismes de détection précoce des enfants vivant dans des conditions difficiles et de mettre en place des programmes de soutien aux parents et aux mères célibataires, ainsi que des programmes communautaires, en vue de réduire rapidement le recours au placement d’enfants en institution;
                d) De soutenir l’Entraide nationale, qui est chargée d’appliquer la loi no 14 05, et d’allouer les ressources nécessaires au projet de réforme des établissements de protection sociale lancé en 2012 en vue d’améliorer les conditions de vie des enfants placés en institution;
                f) De procéder périodiquement à un examen approfondi des placements d’enfants en institution et de créer des mécanismes pour recevoir et examiner les plaintes émanant d’enfants;
                g) De prendre toutes les mesures nécessaires pour réduire la durée du séjour des enfants en institution et de faire en sorte qu’ils ne soient plus séparés de leurs frères et sœurs et transférés d’un centre à un autre et que leur soit assuré un environnement stable qui favorise l’instauration et le maintien de relations constructives avec les adultes et les enfants;
                h) De faciliter, lorsque l’intérêt supérieur de l’enfant le requiert, les contacts entre l’enfant et sa famille biologique de façon à encourager et à appuyer le regroupement lorsqu’il est possible;
                i) De retirer d’urgence des hôpitaux les enfants abandonnés qui continuent d’y vivre et faire en sorte qu’ils puissent bénéficier d’un placement de type familial.", @"لفت اللجنة انتباه المملكة المغربية إلى المبادئ التوجيهية للرعاية البديلة للأطفال (مرفق قرار الجمعية العامة 64/142) وحثتها على ما يلي: 
                - (أ) ضمان ألا يكون الفقر المالي والمادي أو الظروف المنسوبة مباشرة وحصراً إلى هذا الفقر أبداً المبرر الأوحد لحرمان طفل من رعاية الوالدين أو قبوله في مؤسسة للرعاية البديلة أو منعه من الاندماج في المجتمع مجدداً؛ 
                -  (ج) ترسيخ آليات الكشف المبكر عن الأطفال الذين يعانون ظروفاً صعبة، ووضع برامج لدعم الوالدين والأمهات غير المتزوجات والبرامج المجتمعية بهدف التعجيل بالحد من إيداع الأطفال في المؤسسات؛ 
                - (د) دعم التعاون الوطني، المكلف بتنفيذ القانون رقم 14-05، وتخصيص الموارد اللازمة لمشروع إصلاح مؤسسات الحماية الاجتماعية الذي استُهل في عام 2012 لتحسين ظروف معيشة الأطفال المودعين في المؤسسات؛ 
                -  (و) إجراء مراجعة شاملة ودورية لمسألة إيداع الأطفال في مؤسسات الرعاية، وإنشاء آليات لتلقي شكاوى الأطفال والبت فيها؛
                - (ز) اتخاذ جميع التدابير اللازمة لتقليص مدة بقاء الأطفال في المؤسسات، وضمان عدم فصلهم أبداً عن أشقائهم ونقلهم من مركز إلى آخر، وتوفير الرعاية لهم في بيئة مستقرة تلائم إقامة علاقات إيجابية مع البالغين والأطفال والحفاظ عليها؛
                - (ح) تيسير الاتصال بين الطفل وأسرته البيولوجية، متى كان ذلك يصب في مصلحته العليا، لتشجيع لمّ الشمل ودعمه ما أمكن؛
                (ط) نقل الأطفال المهملين من المستشفيات على جناح السرعة، وضمان إمكان إيداعهم في إطار شبيه بالأسرة", "", "" },
                    { 799, null, "R39P1P3P4P6", "ت.39.ف.1.ف.3.ف4.ف.6", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Le Comité recommande au Maroc de tenir compte de l’Observation générale no 13 (2011) sur le droit de l’enfant d’être protégé contre toutes les formes de violence, et en particulier de mettre en place, en étroite coopération avec la société civile, un système de protection des enfants bien coordonné et bien financé. Le Maroc devrait en particulier:
                a) Créer une base de données nationale sur tous les cas de violence dans la famille à l’égard des enfants et procéder à une évaluation complète de l’ampleur, des causes et de la nature d’une telle violence;
                c) Prendre d’urgence des mesures pour régler le problème que posent les conditions de vie des enfants se trouvant dans les centres de sauvegarde, faire sortir sans délai de ces centres les enfants marginalisés et défavorisés et faire en sorte qu’ils bénéficient de programmes de placement auprès d’un parent ou d’une institution et retrouvent leur famille lorsque leur intérêt supérieur le requiert;
                d) Mettre rapidement en place des groupes de protection des enfants et appuyer ces groupes dans les hôpitaux et les postes de police des lieux où il n’en existe pas encore, en particulier dans les zones rurales et les régions reculées, et établir des mécanismes de recours dans les institutions de protection de remplacement et les centres de détention et doter tous ces mécanismes des ressources humaines, financières et techniques nécessaires pour leur permettre de protéger efficacement les enfants contre toutes les formes de violence;
                f) Continuer de fournir des subventions aux organisations non gouvernementales spécialisées qui exécutent des programmes de prévention et de réadaptation en faveur des enfants qui risquent d’être victimes de la violence;
                :", @"الأخذ في الحسبان التعليق العام  رقم 13(2011) بشأن حق الطفل في التحرر من جميع أشكال العنف، ووضع نظاماً لحماية الطفل منسقاً تنسيقاً جيداً وممولاً تمويلاً كافياً بتعاون وثيق مع المجتمع المدني و الاضطلاع بما يلي خاصةً:
                - (أ) إنشاء قاعدة بيانات وطنية تضم جميع حالات العنف المنزلي الممارس على الأطفال، وإجراء تقييم شامل لمدى انتشار هذا العنف وأسبابه وطبيعته؛ 
                -  (ج) اتخاذ تدابير عاجلة لمعالجة الأوضاع المعيشية للأطفال في مراكز حماية الطفولة، ونقل الأطفال المهمشين والمحرومين من هذه المراكز دون إبطاء، وضمان استفادتهم من برامج رعاية ذوي القربى والحضانة ولمّ شملهم بأسرهم متى كان ذلك يصب في مصلحتهم العليا؛
                - (د) المسارعة إلى إنشاء وحدات لحماية الأطفال ووحدات دعم في المستشفيات ومراكز الشرطة في المناطق التي لم تُنشأ فيها بعد، ولا سيما في المناطق الريفية والنائية، وإنشاء آليات تظلم في مؤسسات الرعاية البديلة ومراكز الاحتجاز، وإمداد جميع هذه الآليات بما يلزم من موارد بشرية ومالية وتقنية كي يتسنى لها حماية الأطفال من جميع أشكال العنف بفاعلية؛
                -  (و) مواصلة تقديم المنح إلى المنظمات غير الحكومية المتخصصة التي تنفذ برامج الوقاية وإعادة التأهيل للأطفال المعرضين للعنف أو ضحاياه؛", "", "" },
                    { 798, null, "R29P1", "ت.29.ف.1", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 12 (2009) sur le droit de l’enfant d’être entendu et lui recommande:
                a) De revoir les critères d’éligibilité au 32des enfants en vue d’assurer que les enfants soient élus par leurs pairs dans le cadre d’un processus démocratique et que les enfants de tous les segments de la société soient dûment représentés", "تلفت اللجنة انتباه الدولة الطرف إلى تعليقها العام رقم 12(2009) بشأن حق الطفل في أن يُستمع إليه، وتوصيها بالآتي:", "", "" },
                    { 796, null, "R25P3", "ت.25.ف.3", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", "c) faire en sorte que la politique intégrée de l’enfance actuellement en cours d’élaboration aborde en priorité la situation des enfants les plus marginalisés ou défavorisés et, notamment, les différents types de discrimination dont sont victimes les filles, les enfants handicapés et les enfants vivant dans les zones rurales et les régions reculées.", "-           (ج) التأكد من أن السياسة المندمجة للطفولة قيد الإعداد تولي الأولوية لوضع الأطفال الأكثر تهميشاً وحرماناً، خاصة أنواع التمييز المتعددة التي تعانيها الفتيات والأطفال ذوو الإعاقة والأطفال الذين يعيشون في المناطق الريفية والنائية.", "", "" },
                    { 795, null, "R23 P2", "ت.23.ف.2", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 16 (2013) sur les obligations des États concernant les incidences du secteur des entreprises sur les droits de l’enfant et, en particulier, lui recommande:
                b) D’établir des mécanismes de surveillance pour faire en sorte que les violations des droits de l’enfant fassent l’objet d’enquêtes et donnent lieu à des réparations de façon à améliorer le respect de l’obligation de rendre des comptes et la transparence", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 16(2013) بشأن التزامات الدولة المتعلقة بالآثار التي يحدثها قطاع الأعمال على حقوق الأطفال، وتوصيها خاصة بالآتي:
                (ب) إنشاء آليات رصد للتحقيق في انتهاكات حقوق الطفل و جبر الأضرار المترتبة عليها، و ذلك بهدف تعزيز المسؤولية و الشفافية؛", "", "" },
                    { 794, null, "R21", "ت.21", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Renforcer le cadre de coopération avec les organisations qui s’occupent des enfants lors de l’élaboration, de l’application et d’évaluation des décisions et projets en faveur des enfants, comme le prévoit le paragraphe 3 de l’article 12 de la Constitution, et de songer, à cette fin, à établir un cadre officiel de coopération avec les organisations de la société civile. 
                - faire en sorte que les organisations de la société civile, qui jouent un rôle important en la matière, continuent de bénéficier d’un soutien public qui leur permette de mener une action cohérente et durable en faveur des enfants, tout en renforçant la capacité de répondre aux besoins de protection des enfants.", @"توطيد إطار التعاون مع منظمات حقوق الطفل عند وضع القرارات والمشاريع المتعلقة بالأطفال وتنفيذها وتقييمها، تمشياً مع الفقرة 3 من المادة 12 من الدستور، 
                - النظر، لهذا الغرض، في إنشاء إطار رسمي للتعاون مع منظمات المجتمع المدني. 
                - مواصلة الدولة  دعمها المالي لمنظمات المجتمع المدني التي تؤدي خدمات جليلة في ذلك الصدد بحيث تكون الأنشطة التي يستفيد منها الأطفال متسقة ومستدامة", "", "" },
                    { 793, null, "R19", "ت.19", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", "Prendre des mesures en vue d’adopter rapidement la loi portant réforme du mandat du Conseil national des droits de l’homme de façon à créer un mécanisme spécialisé dans la surveillance des droits de l’enfant habilité à recevoir les plaintes émanant d’enfants, à enquêter sur ces plaintes et les traiter dans le respect de la sensibilité de l’enfant.", "-           الإسراع باتخاذ تدابير على وجه السرعة لاعتماد القانون الذي يعدّل ولاية المجلس الوطني لحقوق الإنسان بغية إنشاء آلية محددة لرصد حقوق الطفل يمكنها تلقي شكاوى الأطفال والتحقيق فيها ومعالجتها بطريقة ملائمة للطفل.", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 792, null, "R17", "ت.17", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Dans l’optique des articles 2, 3, 4 et 6 de la Convention, le Comité recommande au Maroc:
                a) De suivre une démarche axée sur les droits de l’enfant lors de l’élaboration du budget de l’État en mettant en place un système de suivi de l’allocation et de l’utilisation des ressources destinées aux enfants pour l’ensemble du budget, et d’utiliser ce système de suivi pour procéder à des études d’impact pour déterminer la manière dont les investissements dans un secteur donné peuvent servir «l’intérêt supérieur de l’enfant», en veillant à ce que la différence d’impact de ces investissements sur les filles et les garçons soit mesurée;
                b) D’effectuer une évaluation complète des ressources budgétaires requises et d’établir des lignes de crédit claires dans l’optique d’une réduction progressive des disparités dans les indicateurs relatifs aux droits de l’enfant;
                c) D’assurer une budgétisation transparente et une budgétisation participative au moyen d’un dialogue public, en particulier avec les enfants, et de veiller à ce que les autorités locales rendent dûment compte de leurs actions;
                d) De définir des lignes budgétaires stratégiques pour les enfants défavorisés ou vulnérables, dont la situation peut requérir des mesures sociales volontaristes, et de veiller à ce que ces lignes soient préservées même en cas de crise économique, de catastrophe naturelle ou d’autres situations d’urgence; et
                e) De prendre immédiatement des mesures pour lutter contre la corruption et renforcer les moyens dont disposent les institutions pour détecter efficacement cette pratique, enquêter sur les cas de corruption et en poursuivre les auteur", @"في ضوء يوم المناقشة العامة الذي أجرته اللجنة في عام 2007 بشأن 'الموارد المخصصة لإعمال حقوق الطفل - مسؤولية الدول'، ومع التركيز على المواد 2 و3 و4 و6 من الاتفاقية، توصي اللجنة الدولة الطرف بما يلي: 
                - (أ) انتهاج نهج يراعي حقوق الطفل لدى وضع ميزانية الدولة، من خلال تنفيذ نظام لتتبُّع تخصيص الموارد واستخدامها لفائدة الطفل على نطاق الميزانية ككل. وينبغي للدولة الطرف أن تتوسل أيضاً بنظام التتبُّع هذا لتقييم الكيفية التي يمكن أن تؤثِّر بها الاستثمارات في أي قطاع من القطاعات على نحو يخدم 'المصالح الفضلى للطفل'، مع التأكد من قياس تَمايُز آثار هذه الاستثمارات على الفتيات والفتيان؛ 
                - (ب) إجراء تقييم شامل للاحتياجات من الميزانية وتوخّي الشفافية في تخصيص اعتمادات الميزانية قصد التصدي تدريجياً للتفاوت في مؤشرات حقوق الطفل؛ 
                - (ج) وضع ميزانية يُتوخى فيها الشفافية وتقوم على المشاركة بواسطة حوار علني، لا سيما مع الأطفال، من أجل إخضاع السلطات المحلية للمساءلة على الوجه المطلوب؛ 
                - (د) تحديد بنود ميزانية استراتيجية خاصة بالأطفال الذين يعيشون حالات حرمان أو استضعاف قد تستلزم اتخاذ تدابير اجتماعية إيجابية والتأكد من أن تلك البنود محمية حتى في أوقات الأزمات الاقتصادية أو الكوارث الطبيعية أو غيرها من الطوارئ؛
                - (هـ) اتخاذ تدابير فورية لمكافحة الفساد وتعزيز القدرات المؤسسية لكشفه والتحقيق فيه ومحاكمة مرتكبيه بفعالية.", "", "" },
                    { 791, null, "R15", "ت.15", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Coordonner de manière effective et efficace l’application de toutes les dispositions de la Convention, ainsi que la politique intégrée de l’enfance, à la fois entre les ministères et entre les autorités nationales, régionales et locales. 
                - Doter l’organe de coordination des ressources humaines, techniques et financières dont il a besoin pour opérer efficacement, et devrait nommer des autorités pour assurer cette coordination aux niveaux régional et local", @"العمل على تنسيق وتنفيذ جميع أحكام الاتفاقية بفاعلية وكفاءة ، بما في ذلك السياسة المندمجة لحماية الطفولة، سواء فيما بين الوزارات              أو فيما بين السلطات الوطنية والإقليمية والمحلية. 
                - تأمين الموارد البشرية والتقنية والمالية اللازمة لهيئة التنسيق لإدارة عملياتها بفاعلية
                -  إنشاء  هيئات إقليمية ومحلية لهذا الغرض.", "", "" },
                    { 790, null, "R13", "ت.13", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Faire en sorte que la politique intégrée en faveur de l’enfance englobe la protection des enfants et s’étende à tous les domaines visés par la Convention et tous les enfants, une attention particulière devant être accordée aux plus vulnérables et aux plus défavorisés d’entre eux. 
                - Etablir, sur la base de cette politique et en partenariat avec les organisations de la société civile, les stratégies requises pour son application, et de consacrer suffisamment de ressources humaines, techniques et financières à cet objectif.", @"الحرص على أن تشمل السياسية المندمجة لحماية الطفولة حماية الأطفال وكل المجالات التي تغطيها الاتفاقية، وكذلك جميعَ الأطفال، على أن يحظى أضعف الأطفال وأشدهم حرماناً باهتمام خاص.
                - توصي اللجنة المملكة المغربية بأن ترسم، بناء على هذه السياسة وفي إطار الشراكة مع منظمات المجتمع المدني، استراتيجيات مناسبة لتنفيذها، وبأن تخصص لهذا الغرض الموارد البشرية والتقنية والمالية الكافية.", "", "" },
                    { 736, null, "R21P3P4", "ت.21.ف3.ف.4", "", "Non réalisé", "", 0, 8, null, 6, null, null, null, "Organes de traités", @"Entreprendre des études sur les causes et l’ampleur de la violence à l’égard des femmes et des filles, y compris la violence sexuelle et la violence dans la famille. 
                - Recueillir des données ventilées sur toutes les formes de violence à l’égard des femmes,", @"إجراء دراسات عن أسباب العنف الموجه ضد النساء والفتيات ونطاقه، بما في ذلك العنف الجنسي والأسري. 
                -جمع بيانات مصنفة عن جميع أشكال العنف ضد المرأة،", "", "" },
                    { 804, null, "R65 P3", "ت.65.ف.3", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", "c) Renforcer l’inspection du travail, autoriser, par la loi, les inspecteurs à entrer chez les particuliers et accorder la priorité à des interventions visant à faire cesser l’exploitation économique des enfants", "-           (ج) تدعيم تفتيش العمل وتخويل المفتشين، قانوناً، دخول المنازل الخاصة وترتيب تدخلاتهم حسب الأولوية لإنقاذ الأطفال من الاستغلال الاقتصادي؛", "", "" },
                    { 735, null, "R11P4", "ت.11.ف.4", "", "Non réalisé", "", 0, 8, null, 6, null, null, null, "Organes de traités", "Prévoir des procédures précises pour le dépôt des plaintes pour discrimination à l’égard des femmes, des sanctions correspondant à ces actes de discrimination et des voies de recours efficaces pour les femmes dont les droits ont été bafoués.", "وضع إجراءات واضحة لتقديم الشكاوى بشأن التمييز ضد المرأة، والتنصيص على جزاءات كافية لأفعال التمييز، وتكفل إتاحة سبل الانتصاف الفعالة للنساء اللائي انتهكت حقوقهن", "", "" },
                    { 686, null, "R30P2", "ت.30.ف2.", "", "Non réalisé", "", 0, 7, null, 5, null, null, null, "Organes de traités", "Mener des campagnes de sensibilisation auprès des praticiens de la santé sur les droits des travailleurs migrants.", "تنظيم حملات لتوعية العاملين في قطاع الصحة بحقوق العمال المهاجرين.", "", "" },
                    { 685, null, "R48P5", "ت.48.ف5.", "", "Non réalisé", "", 0, 7, null, 5, null, null, null, "Organes de traités", @"Rendre les mesures nécessaires pour que la stratégie nationale de lutte contre le trafic des êtres humains comprenne notamment les mesures suivantes :
                 e) Renforcer la formation des policiers et autres membres des forces de l’ordre, des juges et des procureurs, des inspecteurs du travail, des enseignants ainsi que du personnel des services de santé, des ambassades et des consulats de l’État partie.", @"اتخاذ التدابير اللازمة كي تتضمن الاستراتيجية الوطنية لمحاربة الاتجار بالبشر التدابير التالية على وجه الخصوص:
                 (ﻫ) تعزيز تدريب الشرطة وسائر أفراد قوات حفظ النظام والقضاة وأعضاء النيابة العامة ومفتشي العمل والمدرسين والعاملين في قطاع الصحة وفي سفارات الدولة الطرف وقنصلياتها.", "", "" },
                    { 684, null, "R18P1P3", "ت.18.ف1.ف3.", "", "Non réalisé", "", 0, 7, null, 5, null, null, null, "Organes de traités", @"a) Intensifier de manière concrète la formation de tous les fonctionnaires qui travaillent dans le domaine des migrations de travail, en particulier les fonctionnaires de police et les agents de contrôle aux frontières, ainsi que les fonctionnaires s’occupant des travailleurs migrants au niveau local et les agents consulaires;
                c) Poursuivre la collaboration avec les organisations de la société civile pour diffuser et promouvoir la Convention.", @"(أ) العمل على تكثيف تدريب جميع الموظفين العاملين في مجال الهجرة لأغراض العمل على نحو ملموس، لا سيما موظفو الشرطة ومراقبة الحدود، وكذلك الموظفون المعنيون على الصعيد المحلي بالعمال المهاجرين وموظفو القنصليات؛
                (ج) مواصلة التعاون مع منظمات المجتمع المدني من أجل نشر الاتفاقية وترويجها.", "", "" },
                    { 612, null, "R36P6", "ت.36.ف.6", "", "Non réalisé", "", 0, 8, null, 3, null, null, null, "Organes de traités", "e) prévenir et éliminer le recours excessif à la force par les agents des forces de l’ordre en renforçant notamment les mécanismes de contrôle et de responsabilisation (migrants et demandeurs d’asil);", "-           (ه) منع لجوء قوات الأمن في استخدام القوة المفرطة و التخلص من هذه الممارسة، لا سيما بتدعيم آليات المراقبة والمساءلة؛", "", "" },
                    { 611, null, "R24P5", "ت.24.ف5", "", "Non réalisé", "", 0, 8, null, 3, null, null, null, "Organes de traités", "Accélérer le processus d’adoption de la loi établissant le mécanisme national de prévention de la torture.", "-           (ه) تسريع عملية اعتماد القانون المنشئ للآلية الوطنية لمنع التعذيب.", "", "" },
                    { 571, null, "R22P1P2", "ت.22.ف.1.ف.2", "", "Non réalisé", "", 0, 8, null, 2, null, null, null, "Organes de traités", @"S’assurer que le mécanisme national de contrôle et de surveillance des lieux de détention qui doit être prochainement établi soit également compétent pour inspecter les autres lieux de privation de liberté, tels que les hôpitaux psychiatriques. En outre, il devrait faire en sorte qu’il soit donné suite aux résultats de ce processus de contrôle. 
                - Le mécanisme en question devrait prévoir des visites périodiques et inopinées de manière à prévenir la torture et autres peines ou traitements cruels, inhumains ou dégradants.", @"التأكد   من قدرة الآلية الوطنية لرصد ومراقبة مرافق الاحتجاز، التي يجب أن تنشأ قريباً، وعلى تفتيش أماكن الاحتجاز الأخرى، مثل مستشفيات الأمراض النفسانية.
                -  كفالة متابعة نتائج عملية الرصد التي وينبغي أن تشمل آلية الوطنية لرصد ومراقبة مرافق الاحتجاز زيارات دورية ومفاجئة من شأنها أن تمنع حدوث التعذيب وغيره من ضروب المعاقبة أو المعاملة القاسية أو اللاإنسانية أو المهينة", "", "" },
                    { 570, null, "R18P1P2", "ت.18.ف.1.ف.2", "", "Non réalisé", "", 0, 8, null, 2, null, null, null, "Organes de traités", @"S’assurer que le mécanisme national de contrôle des lieux de détention soit en mesure d’assurer une surveillance et une inspection effectives de tous les lieux de détention, et qu’une suite soit donnée aux résultats de ces contrôles.
                - Ledit mécanisme devrait prévoir les visites périodiques et inopinées des observateurs nationaux et internationaux de sorte de prévenir la torture et autres peines ou traitements cruels, inhumains ou dégradants", @"ا التأكد من قدرة الآلية الوطنية لرصد أماكن الاحتجاز على ضمان مراقبة جميع أماكن الاحتجاز وتفتيشها بفعالية، ومتابعة نتائج التفتيش هذه.
                - تضمين الآلية المذكورة زيارات دورية ومفاجئة يقوم بها مراقبون وطنيون ودوليون لمنع حدوث التعذيب وغيره من ضروب العقوبة أو المعاملة القاسية أو اللاإنسانية أو المهينة.", "", "" },
                    { 569, null, "R6P3P4", "ت.6.ف.3.ف4", "", "Non réalisé", "", 0, 8, null, 2, null, null, null, "Organes de traités", @"Prévoir l’interdiction de toute amnistie éventuelle des crimes de torture et de tout pardon en violation de la Convention, notamment par : 
                - L’instauration d’un mécanisme visant à protéger les subordonnés qui refusent d’obéir aux ordre des supérieurs ou d’une autorité publique qui peuvent être invoqués pour justifier la torture
                - Diffuser l’interdiction d’obéir audits ordres ainsi que les mécanismes de protection y afférents auprès de l’ensemble des forces de l’ordre", @"إنشاء آلية تهدف إلى حماية المرؤوسين الذين يرفضون الانصياع لمثل أوامر رؤسائهم التي قد تبرر ممارسة التعذيب   
                - نشر حظر الانصياع لمثل هذا الأمر وآليات الحماية المتصلة به على نطاق واسع في أوساط جميع قوات إنفاذ القانون", "", "" },
                    { 511, null, "R19", "ت.19", "", "Non réalisé", "", 0, 8, null, 1, null, null, null, "Organes de traités", "veiller à la pleine application des articles 21, 73, 74 et 120 du Code de procédure pénale, afin de garantir un service d’interprétation, notamment en procédant à la formation de plus d’ interprètes assermentés, et de s’assurer que des justiciables appartenant à des catégories vulnérables et ne parlant pas l’arabe, notamment les amazighs, les saharawis, les noirs, les migrants, les réfugiés, les demandeurs d’asile, puissent bénéficier d’une bonne administration de la justice.", "ضمان التطبيق الكامل للمواد 21 و73 و74 و120 من قانون المسطرة الجنائية وبأن تكفل خدمات الترجمة الفورية، خاصة عن طريق تدريب عدد أكبر من المترجمين الفوريين المحلفين، وضمان استفادة المتقاضين من الفئات الضعيفة غير المتحدثة باللغة العربية من نظام جيد لإقامة العدل، لا سيما منهم الأمازيغ والصحراويون والزنوج والمهاجرون واللاجئون وطالبو اللجوء.", "", "" },
                    { 510, null, "R18P3", "ت.18.ف.3", "", "Non réalisé", "", 0, 8, null, 1, null, null, null, "Organes de traités", "Envisager d’adopter la méthode du «testing» pour récolter des preuves de discrimination raciale.", "التفكير في اعتماد أسلوب 'الاختبار' للحصول على أدلة على التمييز العنصري.", "", "" },
                    { 653, null, "R34P3", "ت.34.ف.3", "", "Non réalisé", "", 0, 9, null, null, null, null, null, "Organes de traités", "-             En attendant la promulgation de ces lois, le Comité invite l’État partie à faciliter la constitution des syndicats sur la base de l’article 8 du Pacte.", "-          تيسير تكوين النقابات استناداً إلى المادة 8 من العهد ريثما تسن هذه القوانين.", "", "" },
                    { 652, null, "R16", "ت.16", "", "Non réalisé", "", 0, 9, null, null, null, null, null, "Organes de traités", @"Combattre toute discrimination ou stigmatisation contre les lesbiennes, les gays, les bisexuels et les transgenres fondée sur leur orientation sexuelle et 
                - punir les auteurs de violence motivée par la haine envers ces personnes. Le Comité lui recommande enfin de veiller à ce que ces personnes puissent exercer tous les droits consacrés par le Pacte", @"مكافحة أي شكل من أشكال التمييز أو الوصم ضد المثليات والمثليين ومزدوجي الميل الجنسي ومغايري الهوية الجنسانية القائم على أساس ميلهم الجنسي، ومعاقبة مرتكبي أعمال العنف بدافع كره أولئك الأشخاص. 
                - الحرص على تمكين هؤلاء الأشخاص من ممارسة جميع الحقوق المكرسة في العهد", "", "" },
                    { 800, null, "R47P2", "ت.47.ف.2", "", "Non réalisé", "", 0, 7, null, null, null, null, null, "Organes de traités", "-…élaborer et appliquer une politique pour protéger les droits des adolescentes enceintes et de leurs enfants……….", "-          ووضع وتنفيذ سياسة لحماية حقوق المراهقات الحوامل والمراهقات الأمهات وأطفالهن،", "", "" },
                    { 253, null, "R74P2", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 8, "Procédure spéciale", "Assurer l’égalité des chances en ce qui concerne l’accès des acteurs de la société civile aux fonds d’aide au développement, s’agissant en particulier des organisations locales des zones rurales et reculées, qui sont souvent exclues par manque d’accès à l’information. - Envisager de modifier la procédure actuelle d’appel à propositions, en tenant compte de la situation dans les zones reculées où il n’y a pas d’accès à Internet", "null", "", "" },
                    { 805, null, "R67", "ت.67", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", "Mettre en place une coordination Trans sectorielle et de procéder à des interventions multidisciplinaires, auxquelles participeraient de nombreuses parties prenantes à différents niveaux, afin de faire en sorte que les enfants des rues soient convenablement vêtus, logés, soignés et bénéficient de possibilités d’éducation, notamment d’une formation pour l’acquisition de compétences professionnelles ou pour la vie quotidienne, de façon à favoriser leur plein développement.", "-          إنشاء تنسيقية متعددة القطاعات وإجراء تدخلات متعددة التخصصات يشارك فيها فاعلون عدة من مستويات شتى بحيث يوفَّر لأطفال الشوارع الغذاء الكافي والملبس الكريم والسكن اللائق والرعاية الصحية الملائمة وفرص التعليم المناسبة، بما فيها التدريب المهني والتدريب على المهارات الحياتية، وذلك لدعم نمائهم الكامل.", "", "" },
                    { 797, null, "R27", "ت.27", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 14 (2013) sur le droit de l’enfant à ce que son intérêt supérieur soit une considération primordiale, et lui recommande de redoubler d’efforts pour faire en sorte que ce droit soit dûment intégré et appliqué uniformément dans toutes les procédures législatives, administratives et judiciaires, ainsi que dans la totalité des politiques, programmes et projets concernant les enfants et ayant un impact sur eux. 
                - Le Maroc est encouragé à définir des procédures et des critères destinés à guider toutes les personnes investies d’une autorité pour déterminer l’intérêt supérieur de l’enfant dans chaque domaine et lui attribuer le poids voulu en tant que considération primordiale.", "-          تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 14(2013) بشأن حق الطفل في إيلاء الاعتبار الأول لمصالحه الفُضلى، وتوصيها بتعزيز جهودها بحيث يراعى هذا الحق حق المراعاة ويطبق دوماً في جميع الإجراءات التشريعية والإدارية والقضائية وفي السياسيات والبرامج والمشاريع التي تعني الأطفال وتؤثر فيهم.", "", "" },
                    { 807, null, "R75P5", "ت.75.ف.5", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", @"mettre le système de justice pour mineurs en totale conformité avec la Convention, en particulier avec les articles 37, 39 et 40, ainsi qu’avec d’autres normes applicables et avec l’Observation générale no 10 (2007) du Comité sur les droits de l’enfant dans le système de justice pour mineurs, en particulier:
                e) Mettre en place des programmes de réinsertion sociale dûment financés pour les enfants en conflit avec la loi", @"تحث اللجنة المملكة لمغربية على التوفيق التام بين نظامها لعدالة الأحداث والاتفاقية، لا سيما المواد 37 و39 و40، وكذلك مع معايير أخرى متصلة بالموضوع ومع تعليق اللجنة العام رقم 10(2007) بشأن حقوق الطفل في قضاء الأحداث. وتحثها خاصة على الآتي:
                -  (ه) وضع برامج إدماج اجتماعي ممولة تمويلاً كافياً للأطفال الجانحين؛", "", "" },
                    { 472, null, "R144.37", "37.144", "", "Non réalisé", "", 0, 9, 1, null, 97, null, null, "Examen périodique universal", "Poursuivre ses mesures visant à consolider les principes des droits de l’homme et des libertés publiques", "مواصلة سيره على طريق توطيد مبدأي حقوق الإنسان والحريات العامة", "", "" },
                    { 470, null, "R144.62", "62.144", "", "Non réalisé", "", 0, 8, 1, null, 92, null, null, "Examen périodique universal", "Poursuivre les efforts du Gouvernement visant à doter l’institution nationale des droits de l’homme des ressources budgétaires suffisantes", "مواصلة الحكومة جهودها لتزويد المؤسسة الوطنية لحقوق الإنسان بالموارد الكافية", "", "" },
                    { 462, null, "R144.52", "52.144", "", "Non réalisé", "", 0, 8, 1, null, 90, null, null, "Examen périodique universal", "Veiller à ce qu’un mécanisme national de prévention soit mis sur pied rapidement et que le mécanisme s’appuie sur une base juridique et reçoive les ressources humaines et les moyens financiers nécessaires pour s’acquitter de son mandat en toute indépendance et de manière efficace", "ضمان الإسراع في إنشاء آلية وطنية لمنع التعذيب، وأن ترتكز تلك الآلية على أساس قانوني وأن تحصل على الموارد البشرية والمالية اللازمة لأداء وظيفتها على نحوٍ مستقل وكفء", "", "" },
                    { 476, null, "R144.4", "43.144", "", "Non réalisé", "", 0, 9, 1, null, 82, null, null, "Examen périodique universal", "Renforcer les réalisations dans le domaine de la consolidation des droits de l’homme", "توطيد الإنجازات التي تحققت في مجال ترسيخ حقوق الإنسان", "", "" },
                    { 806, null, "R77P1", "ت.77.ف.1", "", "Non réalisé", "", 0, 7, null, 7, null, null, null, "Organes de traités", "-                    Prendre toutes les mesures voulues pour donner pleinement effet aux recommandations qui figurent dans les présentes observations finales.", "اتخاذ جميع التدابير المناسبة لضمان تنفيذ التوصيات الواردة في هذه الملاحظات الختامية تنفيذاً تاماً.", "", "" },
                    { 471, null, "R144.67", "67.144", "", "Non réalisé", "", 0, 8, 1, null, 72, null, null, "Examen périodique universal", "Veiller à ce que des ressources humaines et financières suffisantes soient allouées à la mise en œuvre de programmes et d’activités sur les droits de l’homme", "ضمان تخصيص ما يكفي من الموارد البشرية والمالية لتنفيذ البرامج والأنشطة المتعلقة بحقوق الإنسان", "", "" },
                    { 454, null, "R144.42", "42.144", "", "Non réalisé", "", 0, 8, 1, null, 72, null, null, "Examen périodique universal", "Continuer à mettre en place des politiques et des programmes publics relatifs aux droits de l’homme, y compris sur le rôle effectif des parlementaires dans la promotion et la protection des droits de l’homme", "مواصلة وضع سياسيات وبرامج حول حقوق الإنسان، تشمل الدور الفعال الذي يلعبه البرلمانيون في تعزيز وحماية حقوق الإنسان", "", "" },
                    { 478, null, "R144.88", "88.144", "", "Non réalisé", "", 0, 9, 1, null, 71, null, null, "Examen périodique universal", "Poursuivre les efforts visant à retirer les mines terrestres et autres restes explosifs de guerre", "مواصلة الجهود لإزالة الألغام الأرضية وغيرها من المتفجرات من مخلفات الحرب", "", "" },
                    { 453, null, "R144.33", "33.144", "", "Non réalisé", "", 0, 8, 1, null, 66, null, null, "Examen périodique universal", "Continuer de renforcer son cadre institutionnel pour la promotion et la protection des droits de l’homme", "مواصلة توطيد الإطار المؤسساتي بغية تعزيز وحماية حقوق الإنسان", "", "" },
                    { 469, null, "R144.60", "60.144", "", "Non réalisé", "", 0, 8, 1, null, 59, null, null, "Examen périodique universal", "Continuer d’améliorer le rôle et les capacités de l’institution nationale des droits de l’homme, qui a conservé son statut A en mars 2016, en pleine conformité avec les Principes concernant le statut des institutions nationales pour la promotion et la protection des droits de l’homme (Principes de Paris)", "مواصلة ترسيخ دور المؤسسة الوطنية لحقوق الإنسان وقدرتها، وهي التي حصلت مجدداً على المركز ألف في آذار/مارس 2016 في امتثالٍ تام للمبادئ المتعلقة بمركز المؤسسات الوطنية لتعزيز وحماية حقوق الإنسان (مبادئ باريس)", "", "" },
                    { 468, null, "R144.59", "59.144", "", "Non réalisé", "", 0, 8, 1, null, 56, null, null, "Examen périodique universal", "Renforcer les mesures prises par le Conseil national pour la promotion et la protection des droits de l’homme, en particulier par l’intermédiaire de ses commissions sur l’ensemble du territoire", "تقوية العمل الذي يقوم به المجلس الوطني لحقوق الإنسان من أجل تعزيز وحماية حقوق الإنسان، ولا سيما عن طريق لجانه الموجودة في جميع أنحاء البلد", "", "" },
                    { 463, null, "R144.53", "53.144", "", "Non réalisé", "", 0, 8, 1, null, 56, null, null, "Examen périodique universal", "Mettre en place un mécanisme de protection des droits des personnes handicapées", "إنشاء آلية لحماية حقوق الأشخاص ذوي الإعاقة", "", "" },
                    { 457, null, "R144.47", "47.144", "", "Non réalisé", "", 0, 8, 1, null, 52, null, null, "Examen périodique universal", "Mettre en place l’Autorité pour la parité et la lutte contre toutes les formes de discrimination", "إنشاء هيئة المناصفة ومكافحة كل أشكال التمييز", "", "" },
                    { 466, null, "R144.56", "56.144", "", "Non réalisé", "", 0, 8, 1, null, 75, null, null, "Examen périodique universal", "Soutenir l’action pour la promotion et la protection des droits de l’homme menée par le Conseil national des droits de l’homme par l’intermédiaire de ses commissions régionales sur tout le territoire", "دعم العمل على تعزيز وحماية حقوق الإنسان الذي يقوم به المجلس الوطني لحقوق الإنسان بواسطة لجانه الجهوية في جميع أنحاء البلد", "", "" },
                    { 475, null, "R144.41", "41.144", "", "Non réalisé", "", 0, 9, 1, null, 46, null, null, "Examen périodique universal", "Accélérer la mise en œuvre de la régionalisation avancée, en tant que moyen de promouvoir la participation des citoyens, en particulier des femmes et des jeunes, des 12 régions du Royaume, à la gouvernance politique et économique du pays () ;", "تسريع تنفيذ الجهوية المتقدمة باعتبارها وسيلة من وسائل زيادة تعزيز مشارکة المواطنین، ولا سیما النساء والشباب، في الحوكمة السیاسیة والاقتصادية في البلد في مناطق المملكة البالغ عددها 12 منطقة", "", "" },
                    { 456, null, "R144.46", "46.144", "", "Non réalisé", "", 0, 8, 1, null, 50, null, null, "Examen périodique universal", "Poursuivre les efforts visant à soutenir les comités régionaux du Conseil national des droits de l’homme, en particulier dans les provinces du sud", "مواصلة الجهود لدعم دور اللجان الإقليمية للمجلس الوطني لحقوق الإنسان، ولا سيما في الأقاليم الجنوبية", "", "" },
                    { 464, null, "R144.54", "54.144", "", "Non réalisé", "", 0, 8, 1, null, 10, null, null, "Examen périodique universal", "Créer un mécanisme national pour la protection des droits des personnes handicapées", "إنشاء آلية وطنية لحماية حقوق الأشخاص ذوي الإعاقة", "", "" },
                    { 465, null, "R144.55", "55.144", "", "Non réalisé", "", 0, 8, 1, null, 10, null, null, "Examen périodique universal", "Continuer à promouvoir le rôle des institutions nationales de protection des droits de l’homme en appuyant les activités des comités régionaux du Conseil national des droits de l’homme dans diverses régions, en particulier dans les villes de Laayoune et Dakhla, dans les provinces du sud", "مواصلة تعزيز دور المؤسسات الوطنية لحماية حقوق الإنسان عن طريق دعم أنشطة اللجان الجهوية للمجلس الوطني لحقوق الإنسان في مختلف المناطق، ولا سيما في مدينتي العيون والداخلة في الأقاليم الجنوبية", "", "" },
                    { 461, null, "R144.51", "51.144", "", "Non réalisé", "", 0, 8, 1, null, 31, null, null, "Examen périodique universal", "Intensifier les efforts pour combattre la torture et les autres mauvais traitements commis par des agents de l’État par la mise en place d’un mécanisme national indépendant et efficace pour la prévention de la torture", "تكثيف الجهود لمكافحة حالات التعذيب وغيره من ضروب المعاملة السيئة على يد أعوان الدولة، وذلك بإنشاء آلية وطنية لمنع التعذيب تكون مستقلة وفعالة", "", "" },
                    { 473, null, "R144.39", "39.144", "", "Non réalisé", "", 0, 9, 1, null, 35, null, null, "Examen périodique universal", "Continuer d’allouer les fonds nécessaires à la mise en œuvre de projets visant à accroître l’intégration des droits de l’homme dans les politiques publiques", "مواصلة تخصيص التمويل المطلوب لتنفيذ مشاريع بهدف زيادة إدماج حقوق الإنسان في السياسات العامة", "", "" },
                    { 455, null, "R144.45", "45.144", "", "Non réalisé", "", 0, 8, 1, null, 37, null, null, "Examen périodique universal", "Accélérer le processus de création de l’Autorité pour la parité et la lutte contre toutes les formes de discrimination", "تسريع عملية إنشاء هيئة المناصفة ومكافحة كل أشكال التمييز", "", "" },
                    { 477, null, "R144.141", "141.144", "", "Non réalisé", "", 0, 9, 1, null, 27, null, null, "Examen périodique universal", "Poursuivre et accélérer les efforts visant à promouvoir les droits économiques, sociaux et culturels pour l’ensemble de la population", "مواصلة الجهود وتسريعها بغرض تعزيز الحقوق الاقتصادية والاجتماعية والثقافية لجميع السكان", "", "" },
                    { 467, null, "R144.57", "57.144.", "", "Non réalisé", "", 0, 8, 1, null, 37, null, null, "Examen périodique universal", "Poursuivre ses efforts en vue de mettre en place et consolider les institutions et mécanismes nationaux de promotion et de protection des droits de l’homme", "مواصلة الجهود لإنشاء وتوطيد مؤسسات وآليات وطنية بغرض تعزيز وحماية حقوق الإنسان", "", "" },
                    { 474, null, "R144.40", "40.144", "", "Non réalisé", "", 0, 9, 1, null, 37, null, null, "Examen périodique universal", "Consolider l’expérience de la régionalisation et poursuivre la participation des jeunes et des femmes dans toutes les régions du Royaume, y compris dans les provinces méridionales", "تكريس تجربة الجهوية ومواصلة مشاركة الشباب والنساء في جميع مناطق المملكة، بما فيها الأقاليم الجنوبية", "", "" },
                    { 458, null, "R144.48", "48.144", "", "Non réalisé", "", 0, 8, 1, null, 40, null, null, "Examen périodique universal", "Établir un mécanisme national de prévention indépendant, efficace et doté de ressources suffisantes conformément au Protocole facultatif se rapportant à la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "إنشاء آلية وقائية وطنية مستقلة وفعالة ومزوَّدة بقدر جيد من الموارد بما يتفق مع متطلبات البروتوكول الاختياري لاتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة", "", "" },
                    { 459, null, "R144.49", "49.144", "", "Non réalisé", "", 0, 8, 1, null, 41, null, null, "Examen périodique universal", "Accélérer le processus de création du mécanisme national de prévention de la torture", "تسريع عملية إنشاء الآلية الوطنية لمنع التعذيب", "", "" },
                    { 460, null, "R144.50", "50.144", "", "Non réalisé", "", 0, 8, 1, null, 42, null, null, "Examen périodique universal", "Rationaliser le processus de création du mécanisme national de prévention de la torture, et assurer une participation large et sans exclusive audit mécanisme", "ترشيد عملية إنشاء الآلية الوطنية لمنع التعذيب عن طريق ضمان المشاركة الواسعة والشاملة في تلك الآلية", "", "" }
                });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[,]
                {
                    { 12, 4, "Les droits culturels", "الحقوق الثقافية" },
                    { 17, 4, "Le droit et l’accès à l’eau", "الحق في الولوج إلى الماء" },
                    { 16, 4, "Le droit au développement", "الحق في التنمية" },
                    { 15, 4, "Le droit au travail", "الحق في الشغل" },
                    { 14, 4, "Le droit à l’éducation", "الحق في والتعليم" },
                    { 13, 4, "Le droit à la santé", "الحق في الصحة" },
                    { 18, 4, "Le droit à un logement convenable", "الحق في السكن اللائق" },
                    { 11, 4, "La lutte contre la pauvreté et la vulnérabilité", "محاربة الفقر والهشاشة" },
                    { 5, 2, "La ratification et l'adhésion aux mécanismes internationaux relatifs aux droits de l'homme", "المصادقة أو الانضمام للصكوك الدولية" },
                    { 9, 3, "Législation", "التشريع" },
                    { 8, 2, "Le suivi des résultats des conférences et des déclarations internationales", "متابعة نتائج وتوصيات المؤتمرات الدولية" },
                    { 7, 2, "La coopération avec les mécanismes onusiens des droits de l'homme", "التعاون مع الآليات الأممية لحقوق الإنسان" },
                    { 2, 1, "La réforme du système de la justice", "إصلاح منظومة العدالة" },
                    { 6, 2, "L’interaction avec les PS du Conseil des droits de l’Homme", "التفاعل مع آلية الإجراءات الخاصة" },
                    { 3, 1, "La mise en œuvre des dispositions de la constitution relatives aux droits de l’Homme", "تطبيق المقتضيات الدستورية المتعلقة بحقوق الإنسان" },
                    { 4, 1, "La mise en œuvre du plan d'action national dans le domaine de la démocratie et des droits de l'homme", "إعمال خطة العمل الوطنية في مجال الديمقراطية وحقوق الإنسان" },
                    { 19, 4, "Le Droit à l’environnement et au développement durable", "الحق في البيئة والتنمية المستدامة" },
                    { 10, 3, "Harmonisation", "الملاءمة" },
                    { 20, 5, "La protection du droit à la vie, l’éradication de toutes les formes de torture et de mauvais traitements et la lutte contre l’impunité", "الحق في الحياة ومناهضة كافة أشكال التعذيب والإفلات من العقاب" },
                    { 1, 1, "Le renforcement de l'Etat de droit et la séparation des pouvoirs", "تعزيز حكم القانون وفصل السلط" },
                    { 22, 5, "La réparation des victimes de violations flagrantes des droits de l’homme", "جبر ضرر ضحايا انتهاكات حقوق الإنسان" },
                    { 37, 7, "Diffusion de la culture des droits de l’Homme", "نشر ثقافة حقوق الإنسان" },
                    { 36, 7, "Education et formation aux droits de l’Homme", "التدريب والتكوين في مجال حقوق الإنسان" },
                    { 35, 6, "La lutte contre la traite des êtres humains", "مكافحة الاتجار بالبشر" },
                    { 34, 6, "La promotion et la protection des droits de l’homme des migrants", "النهوض بحقوق المهاجرين وحمايتها" },
                    { 33, 6, "La promotion et la protection des droits des personnes handicapées", "النهوض بحقوق الأشخاص المعاقين" },
                    { 21, 5, "La promotion du statut des prisonniers", "النهوض بوضعية السجناء" },
                    { 30, 6, "La promotion et la protection des droits des femmes", "النهوض بحقوق المرأة وحمايتها" },
                    { 32, 6, "La promotion et la protection des droits des enfants", "النهوض بحقوق الطفل وحمايتها" },
                    { 28, 5, "Les garanties relatives aux droits de l’homme dans la lutte contre le terrorisme", "ضمانات حقوق الإنسان في إطار مكافحة الإرهاب" },
                    { 27, 5, "La garantie de la liberté de conscience et de croyance", "ضمان حرية الضمير والمعتقد" },
                    { 26, 5, "La promotion du droit à l’information et le droit à la vie privée", "النهوض بالحق في المعلومة والحق في الخصوصية" },
                    { 25, 5, "La garantie de la liberté de réunion et d’association", "ضمان حرية التجمع وتكوين الجمعيات" },
                    { 24, 5, "La protection de la liberté d’opinion et d’expression", "حماية حرية الرأي والتعبير" },
                    { 23, 5, "La promotion de la participation à la vie publique et la vie politique", "النهوض بالمشاركة في الحياة العامة والحياة السياسية" },
                    { 29, 5, "Droit à l’identité et d’enregistrement des naissances", "الحق في الهوية وتسجيل المواليد" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Actif", "Adresse", "Email", "Fix", "IdOrganisme", "IdProfil", "Nom", "Password", "Prenom", "Tel", "Username" },
                values: new object[,]
                {
                    { 1, true, "Temara", "mourabit@angular.io", "05 ## ## ## ##", 1, 1, "mourabit", "123", "mohamed", "06 ## ## ## ##", "mourabit" },
                    { 2, true, "Temara", "mehdi@angular.io", "05 ## ## ## ##", 2, 2, "mehdi", "123", "mehdi", "06 ## ## ## ##", "mehdi" },
                    { 4, true, "Temara", "soufiane@angular.io", "05 ## ## ## ##", 4, 3, "soufiane", "123", "soufiane", "06 ## ## ## ##", "soufiane" },
                    { 3, true, "Temara", "ahmed@angular.io", "05 ## ## ## ##", 4, 4, "ahmed", "123", "ahmed", "06 ## ## ## ##", "ahmed" }
                });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[,]
                {
                    { 254, 47, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4729) },
                    { 477, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6229) },
                    { 477, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6225) },
                    { 477, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6222) },
                    { 477, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6219) },
                    { 477, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6215) },
                    { 465, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6134) },
                    { 464, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6130) },
                    { 807, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9542) },
                    { 807, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9538) },
                    { 807, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9534) },
                    { 807, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9530) },
                    { 806, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9527) },
                    { 805, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9523) },
                    { 461, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6120) },
                    { 805, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9520) },
                    { 804, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9512) },
                    { 803, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9508) },
                    { 802, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9505) },
                    { 802, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9501) },
                    { 801, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9498) },
                    { 801, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9494) },
                    { 801, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9490) },
                    { 801, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9486) },
                    { 799, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9474) },
                    { 799, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9471) },
                    { 799, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9467) },
                    { 799, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9463) },
                    { 799, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9460) },
                    { 805, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9516) },
                    { 473, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6181) },
                    { 473, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6184) },
                    { 473, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6188) },
                    { 466, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6137) },
                    { 471, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6171) },
                    { 471, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6168) },
                    { 471, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6164) },
                    { 454, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6090) },
                    { 478, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6232) },
                    { 453, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6087) },
                    { 453, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6083) },
                    { 453, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6080) },
                    { 453, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6077) },
                    { 453, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6073) },
                    { 469, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6154) },
                    { 468, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6151) },
                    { 463, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6127) },
                    { 457, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6107) },
                    { 457, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6104) },
                    { 456, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6100) },
                    { 475, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6205) },
                    { 460, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6117) },
                    { 459, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6114) },
                    { 458, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6110) },
                    { 474, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6202) },
                    { 467, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6147) },
                    { 467, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6144) },
                    { 455, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6097) },
                    { 455, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6093) },
                    { 473, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6199) },
                    { 473, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6195) },
                    { 473, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6191) },
                    { 798, 31, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9456) },
                    { 797, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9453) },
                    { 796, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9450) },
                    { 795, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9446) },
                    { 684, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8437) },
                    { 684, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8432) },
                    { 684, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8429) },
                    { 684, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8426) },
                    { 684, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8422) },
                    { 684, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8419) },
                    { 684, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8416) },
                    { 612, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7736) },
                    { 612, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7733) },
                    { 612, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7729) },
                    { 611, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7726) },
                    { 611, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7722) },
                    { 571, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7296) },
                    { 570, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7292) },
                    { 569, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7289) },
                    { 569, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7285) },
                    { 569, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7282) },
                    { 569, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7278) },
                    { 569, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7271) },
                    { 511, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6492) },
                    { 511, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6485) },
                    { 510, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6482) },
                    { 653, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8141) },
                    { 653, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8137) },
                    { 652, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8134) },
                    { 652, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8130) },
                    { 800, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9483) },
                    { 800, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9478) },
                    { 254, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4726) },
                    { 684, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8440) },
                    { 466, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6140) },
                    { 684, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8444) },
                    { 685, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8450) },
                    { 795, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9443) },
                    { 795, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9439) },
                    { 794, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9436) },
                    { 793, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9433) },
                    { 793, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9429) },
                    { 792, 2, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9426) },
                    { 792, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9423) },
                    { 792, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9419) },
                    { 791, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9416) },
                    { 790, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9412) },
                    { 736, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8967) },
                    { 736, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8963) },
                    { 736, 1, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8960) },
                    { 736, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8956) },
                    { 735, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8953) },
                    { 735, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8950) },
                    { 687, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8494) },
                    { 687, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8491) },
                    { 687, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8488) },
                    { 687, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8484) },
                    { 686, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8481) },
                    { 685, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8477) },
                    { 685, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8474) },
                    { 685, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8471) },
                    { 685, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8467) },
                    { 685, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8464) },
                    { 685, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8460) },
                    { 685, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8457) },
                    { 685, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8454) },
                    { 685, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8447) },
                    { 476, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6209) },
                    { 511, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6489) },
                    { 462, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6124) },
                    { 182, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4135) },
                    { 181, 50, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4132) },
                    { 181, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4128) },
                    { 180, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4125) },
                    { 180, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4122) },
                    { 179, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4118) },
                    { 179, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4115) },
                    { 179, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4112) },
                    { 178, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4108) },
                    { 177, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4105) },
                    { 176, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4101) },
                    { 175, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4098) },
                    { 157, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3962) },
                    { 157, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3958) },
                    { 156, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3954) },
                    { 156, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3951) },
                    { 155, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3948) },
                    { 154, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3944) },
                    { 154, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3941) },
                    { 154, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3938) },
                    { 153, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3934) },
                    { 153, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3931) },
                    { 153, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3928) },
                    { 152, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3924) },
                    { 152, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3921) },
                    { 152, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3917) },
                    { 152, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3914) },
                    { 152, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3911) },
                    { 151, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3907) },
                    { 183, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4138) },
                    { 151, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3904) },
                    { 184, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4142) },
                    { 186, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4149) },
                    { 254, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4719) },
                    { 253, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4716) },
                    { 476, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6212) },
                    { 254, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4723) },
                    { 253, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4713) },
                    { 253, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4709) },
                    { 252, 51, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4702) },
                    { 251, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4699) },
                    { 251, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4695) },
                    { 251, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4688) },
                    { 250, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4685) },
                    { 250, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4681) },
                    { 250, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4677) },
                    { 249, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4673) },
                    { 249, 51, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4669) },
                    { 249, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4665) },
                    { 248, 45, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4662) },
                    { 248, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4658) },
                    { 248, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4654) },
                    { 248, 51, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4650) },
                    { 248, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4647) },
                    { 214, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4400) },
                    { 213, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4396) },
                    { 212, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4393) },
                    { 211, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4390) },
                    { 211, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4386) },
                    { 211, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4383) },
                    { 187, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4156) },
                    { 187, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4153) },
                    { 185, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4146) },
                    { 151, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3901) },
                    { 252, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4706) },
                    { 150, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3894) },
                    { 118, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3587) },
                    { 118, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3584) },
                    { 118, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3580) },
                    { 118, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3577) },
                    { 117, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3573) },
                    { 117, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3570) },
                    { 116, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3567) },
                    { 116, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3563) },
                    { 74, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3240) },
                    { 74, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3236) },
                    { 73, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3233) },
                    { 73, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3230) },
                    { 72, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3226) },
                    { 72, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3223) },
                    { 71, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3220) },
                    { 71, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3216) },
                    { 70, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3211) },
                    { 69, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3205) },
                    { 68, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3201) },
                    { 67, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3197) },
                    { 38, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2939) },
                    { 38, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2936) },
                    { 38, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2932) },
                    { 37, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2928) },
                    { 472, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6174) },
                    { 151, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3897) },
                    { 470, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6157) },
                    { 470, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6161) },
                    { 472, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6178) },
                    { 119, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3590) },
                    { 120, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3594) },
                    { 36, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2925) },
                    { 121, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3601) },
                    { 120, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3598) },
                    { 149, 49, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3891) },
                    { 149, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3881) },
                    { 149, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3877) },
                    { 148, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3874) },
                    { 149, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3887) },
                    { 148, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3870) },
                    { 129, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3675) },
                    { 129, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3672) },
                    { 149, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3884) },
                    { 129, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3665) },
                    { 128, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3662) },
                    { 128, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3659) },
                    { 128, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3655) },
                    { 129, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3669) },
                    { 127, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3648) },
                    { 121, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3604) },
                    { 122, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3608) },
                    { 127, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3652) },
                    { 123, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3614) },
                    { 124, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3618) },
                    { 124, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3621) },
                    { 125, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3624) },
                    { 123, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3611) },
                    { 125, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3631) },
                    { 126, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3635) },
                    { 126, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3638) },
                    { 126, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3641) },
                    { 126, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3645) },
                    { 125, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3628) }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 415, null, "R144.218P1", "218.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 84, 32, null, "Examen périodique universal", "Renforcer les mesures visant à éliminer les mariages d’enfants", "تقوية التدابير الرامية إلى القضاء التام على زواج الأطفال ......", "", "" },
                    { 423, null, "R144.228P2", "228.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 38, 32, null, "Examen périodique universal", "Accélérer encore les efforts visant à promouvoir les droits des enfants, en particulier ceux qui sont handicapés", "زيادة تسريع الجهود المبذولة لأجل تعزيز حقوق... والطفل، وخاصة ذوي الإعاقة منهم", "", "" },
                    { 422, null, "R144.138P1", "138.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 94, 32, null, "Examen périodique universal", "Retirer toute référence dans les documents d’identité qui permettrait de repérer les enfants nés hors mariage", "سحب أي إشارة في وثائق الهوية من شأنها أن تمكّن من تحديد الأطفال المولودين خارج إطار الزواج.......", "", "" },
                    { 421, null, "R144.227P2", "227.144. ج.2", "", "Non réalisé", "", 0, 6, 1, null, 20, 32, null, "Examen périodique universal", "Poursuivre ses efforts pour assurer la protection et la promotion des droits des groupes vulnérables, notamment et les enfants", "مواصلة جهوده من أجل حماية وتعزيز حقوق الإنسان للفئات الضعيفة بما فيها..... الأطفال", "", "" },
                    { 420, null, "R144.226", "226.144", "", "Non réalisé", "", 0, 6, 1, null, 95, 32, null, "Examen périodique universal", "Interdire et incriminer expressément l’enrôlement et l’utilisation dans des hostilités d’enfants de moins de 18 ans", "حظر وتجريم تجنيد الأطفال دون سن 18 واستخدامهم في الأعمال العدائية حظراً وتجريماً صريحين", "", "" },
                    { 419, null, "R144.225", "225.144", "", "Non réalisé", "", 0, 6, 1, null, 57, 32, null, "Examen périodique universal", "Poursuivre ses efforts pour lutter contre le travail des enfants par la mise en œuvre effective de la loi sur les conditions de travail et d’18 des travailleurs domestiques", "مواصلة جهوده في سبيل مكافحة عمالة الأطفال عن طريق التنفيذ الفعال لقانون العمال المنزليين وظروف الاستخدام", "", "" },
                    { 418, null, "R144.224P1", "224.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 79, 32, null, "Examen périodique universal", "Continuer à renforcer les politiques publiques pertinentes pour la promotion et la protection des droits de l’homme, en particulier les droits des enfants", "مواصلة تقوية السياسات العامة ذات الصلة لتعزيز وحماية حقوق الإنسان، وبخاصة حقوق الطفل....", "", "" },
                    { 417, null, "R144.223", "223.144", "", "Non réalisé", "", 0, 6, 1, null, 77, 32, null, "Examen périodique universal", "Poursuivre les efforts pour faire en sorte que les enfants et adolescents vulnérables vivant en milieu rural aient accès à une éducation et à des services de santé de qualité", "مواصلة الجهود من أجل كفالة حصول الأطفال والمراهقين الضعيفة حالهم في المجتمعات الريفية على التعليم الجيد وخدمات الرعاية الصحية الجيدة", "", "" },
                    { 416, null, "R144.222 P1", "222.144. ج.1", "", "Non réalisé", "", 0, 6, 1, null, 19, 32, null, "Examen périodique universal", "Prendre des mesures plus efficaces pour mieux protéger les droits des enfants", "اتخاذ تدابير أكثر نجوعاً من أجل توفير حماية أفضل لحقوق الطفل....... وغير ذلك من الفئات الضعيفة", "", "" },
                    { 414, null, "R144.217", "217.144", "", "Non réalisé", "", 0, 6, 1, null, 23, 32, null, "Examen périodique universal", "Éliminer la pratique néfaste du mariage précoce et sensibiliser le public et les parents pour la protection efficace des mineures", "القضاء على الممارسة الضارة المتمثلة في الزواج المبكر وتوعية الجمهور والآباء والأمهات من أجل حماية الفتيات القاصرات حمايةً فعالة", "", "" },
                    { 844, null, "R15P4", "ت.15.ف.4", "", "Non réalisé", "", 0, 6, null, 8, null, 30, null, "Organes de traités", "Mettre en place des mécanismes efficaces permettant de faire en sorte que les femmes et les filles handicapées qui sont victimes de violence et de maltraitance soient protégées et qu’elles puissent bénéficier de soins médicaux, d’un soutien psychologique et de services juridiques au même titre que les autres.", @"تماشياً مع التعليق العام رقم 3(2016) بشأن النساء والفتيات ذوات الإعاقة والغاية 5-2 من أهداف التنمية المستدامة، توصي اللجنة الدولة الطرف بالقضاء على جميع أشكال العنف ضد النساء والفتيات في المجالين العام والخاص، بما في ذلك الاتجار بالبشر والاستغلال الجنسي وغير ذلك من أشكال الاستغلال. وتوصي الدولة الطرف أيضاً بما يلي:‬‬‬‬ ‬‬
                -  (د) وضع آليات فعالة لضمان حماية ضحايا العنف والاعتداء من النساء والفتيات ذوات الإعاقة وضمان إمكانية حصولهن على خدمات الرعاية الطبية والرعاية النفسية - الاجتماعية والخدمات القانونية على قدم المساواة مع الآخرين", "", "" },
                    { 412, null, "R144.139", "139.144", "", "Non réalisé", "", 0, 6, 1, null, 94, 32, null, "Examen périodique universal", "Éliminer les frais pour les actes de naissance et faciliter la délivrance d’un certificat de naissance à tous les enfants réfugiés qui n’en ont pas encore", "إلغاء الرسوم المفروضة على إصدار شهادات الميلاد وتيسير إصدار شهادات الميلاد لجميع الأطفال اللاجئين الذين لا يملكون شهادة ميلاد بعد", "", "" },
                    { 411, null, "R144.136", "136.144", "", "Non réalisé", "", 0, 6, 1, null, 83, 32, null, "Examen périodique universal", "Améliorer les procédures actuelles d’enregistrement des enfants pour garantir l’égalité entre les enfants et l’égalité de traitement juridique sans aucune discrimination", "تحسين الإجراءات المتّبعة في تسجيل الأطفال من أجل ضمان المساواة بين الأطفال والمعاملة القانونية المتساوية لهم دونما تمييز", "", "" },
                    { 410, null, "R144.135", "135.144", "", "Non réalisé", "", 0, 6, 1, null, 71, 32, null, "Examen périodique universal", "Envisager d’éliminer des documents d’identité toutes les données qui pourraient conduire à une discrimination contre les enfants nés hors mariage", "النظر في إلغاء جميع البيانات من وثائق الهوية التي من شأنها أن تؤدي إلى تمييز في حق الأطفال المولودين خارج إطار الزواج", "", "" },
                    { 207, null, "R83P22", "null", "", "Non réalisé", "", 0, 6, null, null, null, 32, 7, "Procédure spéciale", "-       Fournir des procureurs spécialisés et des officiers de police judiciaire specialises pour les cas de jeunes délinquants", "null", "", "" },
                    { 206, null, "R83P20", "null", "", "Non réalisé", "", 0, 6, null, null, null, 32, 7, "Procédure spéciale", "Mettre en place un système de visites régulières dans les postes de police avec un accent particulier sur les délinquants juvéniles, ne pas placer les mineurs dans les prisons ordinaires mais plutôt dans des centres de protection de l’enfance- Enquêter sur toutes les plaintes de torture et de mauvais traitements des mineurs, notamment des allégations de châtiments corporels", "null", "", "" },
                    { 139, null, "R99P1-2", "null", "", "Non réalisé", "", 0, 6, null, null, null, 32, 4, "Procédure spéciale", "En ce qui les provinces marocaines du sud :- a) …………. prendre des mesures concrètes pour améliorer la situation des employés de maison et lutter contre le travail des enfants et l’exploitation sexuelle des femmes et des enfants", "null", "", "" },
                    { 111, null, "R91P3", "ت.91.ف.3", "", "Non réalisé", "", 0, 6, null, null, null, 32, 3, "Procédure spéciale", "-    Pour ce qui est des mineurs, le Rapporteur spécial recommande au Gouvernement de déployer des procureurs et des fonctionnaires de police judiciaire spécialisés dans les affaires concernant des délinquants mineurs.", "فيما يتعلق بالأحداث، يوصي المقرر الخاص الحكومة بما يلي: (ج) توفير خدمات مدعين عامين متخصصين وموظفين في الشرطة القضائية متخصصين في قضايا الجانحين الأحداث.", "", "" },
                    { 110, null, "R91P1", "ت.91.ف.1", "", "Non réalisé", "", 0, 6, null, null, null, 32, 3, "Procédure spéciale", "-    Organiser des visites régulières dans les postes de police en accordant une attention particulière aux délinquants mineurs, de ne pas placer des mineurs dans des prisons ordinaires mais de renforcer les centres de protection des enfants et d’enquêter sur toutes les plaintes de torture et de mauvais traitements émanant de mineurs, en particulier sur les allégations relatives aux châtiments corporels;", "فيما يتعلق بالأحداث، يوصي المقرر الخاص الحكومة بما يلي:- (أ) زيارة مراكز الشرطة بانتظام، مع التركيز خصوصاً على الأحداث الجانحين؛ وعدم حبسهم في سجون عادية وإنما تدعيم هيكلية مراكز حماية الأطفال؛ والتحقيق في جميع شكاوى تعذيبهم أو إساءة معاملتهم، لا سيما الادعاءات المتعلقة بالعقوبة البدنية؛", "", "" },
                    { 26, null, "R89", "null", "", "Non réalisé", "", 0, 6, null, null, null, 32, 1, "Procédure spéciale", "-   Redoubler d’efforts pour allouer des ressources suffisantes à l’amélioration et à la protection de l’alimentation des enfants, et pour concevoir, adopter et mettre en œuvre des politiques et des programmes coordonnés dans ce domaine, en particulier en milieu rural", "null", "", "" },
                    { 25, null, "R88", "null", "", "Non réalisé", "", 0, 6, null, null, null, 32, 1, "Procédure spéciale", "-   Veiller à ce que le budget de l’État reflète la volonté de réaliser les droits des enfants en allouant des ressources équitables et suffisantes aux services essentiels pour les enfants, notamment en garantissant le droit de l’enfant à une alimentation saine et équilibrée.", "null", "", "" },
                    { 845, null, "R35P1", "ت.35.ف. 1", "", "Non réalisé", "", 0, 6, null, 8, null, 30, null, "Organes de traités", "Adopter des mesures concrètes et efficaces pour faire en sorte que les personnes handicapées, en particulier les femmes et les filles victimes de violence sexiste et les enfants victimes de mauvais traitements, aient accès à des services et à des informations, notamment des permanences téléphoniques, des refuges, des services d’appui aux victimes et des services de consultation et de conseil, ainsi qu’à des mécanismes de plainte qui soient chargés, entre autres, d’accorder des indemnisations aux victimes et d’imposer des sanctions contre les auteurs de ces actes ;", "-       (أ) اعتماد تدابير ملموسة وفعالة لضمان إمكانية وصول الأشخاص ذوي الإعاقة، ولا سيما النساء والفتيات ذوات الإعاقة من ضحايا العنف الجنساني والأطفال ذوي الإعاقة من ضحايا سوء المعاملة، إلى الخدمات والمعلومات، بما في ذلك خطوط الاتصال المباشر ومراكز الإيواء وخدمات دعم الضحايا، والمشورة والنصح، وإلى آليات تقديم الشكاوى المخولة، في جملة أمور، بتقديم تعويضات وفرض جزاءات على الجناة؛", "", "" },
                    { 644, null, "R38 P2", "ت.38.ف.2", "", "Non réalisé", "", 0, 6, null, null, null, 30, null, "Organes de traités", "Prendre des mesures pour enquêter et poursuivre les auteurs et permettre aux victimes de la violence faites aux femmes au foyer d’accéder à des moyens de recours utiles et à une protection immédiate, y compris par la mise en place de foyers d’accueil en nombre suffisant.", "-          اتخاذ التدابير اللازمة للتحقيق في أعمال العنف المنزلي وملاحقة مرتكبيه وتمكين ضحاياه من الوصول إلى سبل الانتصاف الفعالة والحصول على حماية فورية بطرق منها إنشاء عدد كاف من مراكز الإيواء.", "", "" },
                    { 605, null, "R22P2", "ت.22.ف2", "", "Non réalisé", "", 0, 6, null, 3, null, 30, null, "Organes de traités", @"Veiller à garantir un accès effectif à l’avortement légal, notamment en éliminant les conditions contraignantes envisagées dans le projet de loi. 
                - Promouvoir et garantir l’accès à la contraception, à l’éducation et aux services de santé sexuelle et reproductive.", @"الحرص على توفير سبل فعالة إلى الإجهاض القانوني، لا سيما بإلغاء الشروط الصارمة المقترح إدراجها في مشروع القانون.
                -  تشجيع اللجوء إلى وسائل منع الحمل والتعليم وخدمات الصحة الجنسية والإنجابية وتكفلها", "", "" },
                    { 413, null, "P2R144.184", "184.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 59, 32, null, "Examen périodique universal", "Poursuivre les efforts louables visant à promouvoir et protéger les droits des enfants", ".......مواصلة الجهود الحميدة الرامية إلى تعزيز حماية حقوق", "", "" },
                    { 424, null, "P2R144.191", "191.144", "", "Non réalisé", "", 0, 6, 1, null, 62, 32, null, "Examen périodique universal", "Prendre des mesures appropriées pour prévenir le mariage des mineurs", "اتخاذ تدابير مناسبة، مع مراعاة التزاماته الدولية، لمنع زواج القاصرين", "", "" },
                    { 847, null, "R39P2", "ت.39.ف.2", "", "Non réalisé", "", 0, 6, null, 8, null, 32, null, "Organes de traités", "De mettre en place une stratégie pour la désinstitutionnalisation des personnes handicapées qui comprenne des dispositions relatives à la collecte de données, en particulier en ce qui concerne les enfants handicapés abandonnés vivant en institution, ainsi qu’un calendrier précis et des indicateurs", "-       (ب) وضع استراتيجية لإنهاء رعاية الأشخاص ذوي الإعاقة داخل المؤسسات تتضمن بنوداً لجمع البيانات، ولا سيما عن الأطفال ذوي الإعاقة المُسيَّبين في المؤسسات، وإطاراً زمنياً ومؤشرات واضحين؛", "", "" },
                    { 426, null, "R144.91", "91.144", "", "Non réalisé", "", 0, 6, 1, null, 69, 32, null, "Examen périodique universal", "Mettre en place une 9 interdisant les châtiments corporels et les mauvais traitements infligés aux garçons et aux filles", "وضع تشريعات تحظر العقوبة البدنية وإساءة معاملة البنين والبنات", "", "" },
                    { 59, null, "R82", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Renforcer les mesures visant à éliminer les obstacles administratifs et les autres obstacles structurels à l’intégration des réfugiés et des migrants", "null", "", "" },
                    { 58, null, "R81", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Adopter et promouvoir une approche multipartite dans l’élaboration d’un cadre permanent relatif à la régularisation des migrants", "null", "", "" },
                    { 57, null, "R80", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Garantir des voies de migration supplémentaires systématisées, notamment en attendant la finalisation des projets de loi nationaux sur les migrations et l’asile en cours d’examen par le 32", "null", "", "" },
                    { 852, null, "R31P2", "ت.31.ف.2", "", "Non réalisé", "", 0, 6, null, 8, null, 33, null, "Organes de traités", "Prévoir une voie de recours pour les personnes handicapées qui risquent d’être privées de liberté, notamment d’être placées en institution ou internées, en s’inspirant notamment, à cette fin, des directives du Comité relatives à l’article 14 de la Convention.", "-      ….. واستحداث سبل تظلم قانوني للأشخاص ذوي الإعاقة المعرضين لخطر سلب حريتهم، بما في ذلك من خلال إيداعهم مؤسسات الرعاية أو حبسهم، وبالاسترشاد، في تحقيق هذه الغاية، بالمبادئ التوجيهية التي وضعتها اللجنة بشأن المادة 14 من الاتفاقية.", "", "" },
                    { 851, null, "R29P1", "ت.29.ف.1", "", "Non réalisé", "", 0, 6, null, 8, null, 33, null, "Organes de traités", "Prendre des mesures pour garantir que toutes les personnes handicapées, en particulier celles qui présentent un handicap psychosocial ou intellectuel, ainsi que les personnes sourdes et malentendantes, aient accès à la justice, et à l’information et aux communications dans des formats accessibles, notamment en braille, sur des supports tactiles, en langue facile (Easy Read) et en langue des signes", "-       (أ) اعتماد تدابير لضمان إمكانية اللجوء إلى القضاء لجميع الأشخاص ذوي الإعاقة، ولا سيما الأشخاص ذوي الإعاقة النفسية - الاجتماعية و/أو العقلية، والصم وضعاف السمع، وضمان إمكانية وصولهم إلى خدمات الإعلام والاتصال باستعمال أشكال ميسرة، مثل طريقة برايل، وأشكال الاتصال عن طريق اللمس والأشكال التي تسهل قراءتها ولغة الإشارة؛", "", "" },
                    { 850, null, "R25", "ت.25", "", "Non réalisé", "", 0, 6, null, 8, null, 33, null, "Organes de traités", "Le Comité recommande à l’État partie d’adopter une stratégie de réduction des risques de catastrophe qui soit accessible aux personnes handicapées et les prenne en considération, dans toutes les situations de risque, conformément au Cadre de Sendai pour la réduction des risques de catastrophe 2015-2030.", "-      اعتماد استراتيجية للحد من مخاطر الكوارث تنص على تيسير إمكانية الوصول وشمول الأشخاص ذوي الإعاقة في جميع حالات الخطر، تماشياً مع إطار سينداي للحد من مخاطر الكوارث 2015-2030.", "", "" },
                    { 849, null, "R13P3", "ت.13.ف.3", "", "Non réalisé", "", 0, 6, null, 8, null, 33, null, "Organes de traités", "Prévoir des mesures en faveur des personnes handicapées qui ont été victimes d’actes de discrimination fondée sur le handicap, notamment de veiller à ce que ces personnes puissent obtenir réparation et être indemnisées, et d’infliger des sanctions aux auteurs de tels actes", "-       (ج) وضع تدابير، بما في ذلك التعويض وجبر الضرر، للأشخاص ذوي الإعاقة الذين تعرضوا للتمييز بسبب الإعاقة، وفرض جزاءات على الجناة.", "", "" },
                    { 848, null, "R9P2", "ت.9.ف.2", "", "Non réalisé", "", 0, 6, null, 8, null, 33, null, "Organes de traités", "- Adopter des mesures concrètes pour protéger toutes les personnes handicapées, y compris celles qui présentent un handicap psychosocial ou intellectuel et celles qui appartiennent à des minorités nationales, ethniques, religieuses ou linguistiques, telles que les Amazighs, les Noirs, les migrants, les réfugiés et les demandeurs d’asile", "-       (أ) ........ واعتماد تدابير محددة لحماية جميع الأشخاص ذوي الإعاقة، بمن فيهم الأشخاص ذوو الإعاقة النفسية - الاجتماعية و/أو العقلية والأشخاص ذوو الإعاقة الذين ينتمون إلى أقليات قومية، أو إثنية أو دينية أو لغوية، مثل الأمازيغ والسود والمهاجرين واللاجئين وطالبي اللجوء، ...........؛", "", "" },
                    { 645, null, "R24P2P3", "ت.24.ف.2.ف.3", "", "Non réalisé", "", 0, 6, null, null, null, 33, null, "Organes de traités", @"Prendre toutes les mesures nécessaires pour permettre aux personnes handicapées de jouir pleinement de leurs droits économiques, sociaux et culturels. 
                - Appliquer le quota de 7 % et prendre toute autre mesure spéciale pour faciliter l’accès des personnes handicapées à l’emploi, à l’éducation et aux soins de santé.", @"اتخاذ جميع التدابير اللازمة لكي يتسنى للأشخاص ذوي الإعاقة التمتع كلياً بحقوقهم الاقتصادية والاجتماعية والثقافية. 
                - تطبيق حصة 7 في المائة واتخاذ أي من التدابير الخاصة الأخرى لتيسير إمكانية حصول الأشخاص ذوي الإعاقة على العمل والتعليم والرعاية الصحية.", "", "" },
                    { 439, null, "R144.231", "231.144", "", "Non réalisé", "", 0, 6, 1, null, 56, 33, null, "Examen périodique universal", "Intégrer la langue des signes dans les médias publics et assurer la formation des interprètes dans ce domaine", "إدماج لغة الإشارة في وسائط الإعلام العامة وتوفير التدريب للمترجمين في هذا المجال", "", "" },
                    { 438, null, "R144.230", "230.144", "", "Non réalisé", "", 0, 6, 1, null, 55, 33, null, "Examen périodique universal", "Continuer à renforcer la mise en œuvre des politiques publiques concernant les personnes handicapées", "مواصلة تقوية تنفيذ السياسات العامة المتعلقة بالأشخاص ذوي الإعاقة", "", "" },
                    { 437, null, "R144.229", "229.144", "", "Non réalisé", "", 0, 6, 1, null, 45, 33, null, "Examen périodique universal", "Continuer de prendre des mesures globales pour mieux intégrer les personnes handicapées dans la société", "مواصلة اتخاذ تدابير شاملة لتحسين اندماج الأشخاص ذوي الإعاقة في المجتمع", "", "" },
                    { 436, null, "R144.227P1", "227.144. ج.1", "", "Non réalisé", "", 0, 6, 1, null, 20, 33, null, "Examen périodique universal", "Poursuivre ses efforts pour assurer la protection et la promotion des droits des groupes vulnérables, notamment les personnes handicapées", "مواصلة جهوده من أجل حماية وتعزيز حقوق الإنسان للفئات الضعيفة بما فيها الأشخاص ذوي الإعاقة.....", "", "" },
                    { 425, null, "R144.90", "90.144", "", "Non réalisé", "", 0, 6, 1, null, 43, 32, null, "Examen périodique universal", "Mettre en œuvre les recommandations issues du deuxième cycle figurant dans le document A/HRC/21/3 (par. 129.62 et 129.65) et interdire sans équivoque les châtiments corporels en tous lieux, y compris à la maison, dans les institutions de protection de remplacement, dans les crèches et dans les écoles", "تنفيذ التوصيات المنبثقة عن الجولة الثانية، الواردة في الوثيقة A/HRC/21/3، الفقرتان 129‑62 و129‑65، وحظر العقوبة البدنية حظراً لا يدع مجالاً للشك، في جميع الأماكن وحتى داخل المنزل وفي مؤسسات الرعاية البديلة وفي دور الحضانة النهارية وفي المدارس", "", "" },
                    { 435, null, "R144.224P3", "224.144 ج.3", "", "Non réalisé", "", 0, 6, 1, null, 79, 33, null, "Examen périodique universal", "Continuer à renforcer les politiques publiques pertinentes pour la promotion et la protection des droits de l’homme, en particulier les droits des personnes handicapées", "مواصلة تقوية السياسات العامة ذات الصلة لتعزيز وحماية حقوق الإنسان،..... وبخاصة حقوق الأشخاص ذوي الإعاقة", "", "" },
                    { 433, null, "R144.167", "167.144", "", "Non réalisé", "", 0, 6, 1, null, 30, 33, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir l’éducation inclusive en renforçant l’accès à l’éducation pour les personnes handicapées", "مواصلة الجهود لتعزيز التعليم الجامع عن طريق تيسير حصول الأشخاص ذوي الإعاقة على التعليم", "", "" },
                    { 232, null, "R88P3", "ت.88.ف.3", "", "Non réalisé", "", 0, 6, null, null, null, 33, 8, "Procédure spéciale", "Davantage d’investissements devraient être réalisés dans le renforcement des capacités et dans l’aménagement des centres de culture pour les rendre plus accessibles aux personnes handicapées.", "-    زيادة الاستثمار في بناء القدرات وجعل الاستفادة من هذه المراكز أمراً أسهل بالنسبة للأشخاص ذوي الإعاقة.", "", "" },
                    { 27, null, "R93", "null", "", "Non réalisé", "", 0, 6, null, null, null, 33, 1, "Procédure spéciale", "-   Intégrer pleinement la problématique du handicap dans les politiques et les programmes relatifs à la nutrition, les politiques relatives à la santé maternelle et infantile et les initiatives plus générales en matière de santé.", "null", "", "" },
                    { 846, null, "R17", "ت.17", "", "Non réalisé", "", 0, 6, null, 8, null, 32, null, "Organes de traités", "Légiférer et prendre des mesures concrètes pour garantir que les enfants handicapés, notamment ceux qui ont été abandonnés, soient suffisamment protégés contre la violence, l’exploitation et la maltraitance, y compris les châtiments corporels, et que les auteurs de tels actes soient punis.", "اعتماد تشريعات وتدابير ملموسة تضمن تمتع الأطفال ذوي الإعاقة، بمن فيهم الأطفال ذوو الإعاقة المُسيَّبون، بحماية كافية من التعرض للعنف والاستغلال والاعتداء، بما في ذلك العقوبة البدنية، وتضمن إنزال العقوبة بالجناة.", "", "" },
                    { 725, null, "R21P7", "ت.21.ف.7", "", "Non réalisé", "", 0, 6, null, 6, null, 32, null, "Organes de traités", "veiller au respect de la législation relative au travail des enfants, afin de protéger les filles contre les formes multiples de discrimination.", "ضمان إنفاذ القيود المفروضة على عمل الأطفال وذلك لحماية الطفلة من شتى أشكال التمييز", "", "" },
                    { 678, null, "R38", "ت.38", "", "Non réalisé", "", 0, 6, null, 5, null, 32, null, "Organes de traités", "Prendre les mesures nécessaires pour assurer à tout enfant de travailleur migrant, y compris ceux en situation irrégulière, l’enregistrement de sa naissance.", "اتخاذ التدابير اللازمة لضمان تسجيل كل طفل من أبناء العمال المهاجرين، بمن فيهم الموجودون في وضع غير قانوني.", "", "" },
                    { 606, null, "R48", "ت.48", "", "Non réalisé", "", 0, 6, null, 3, null, 32, null, "Organes de traités", "Appliquer rigoureusement les dispositions légales relatives au travail et à l’exploitation des enfants en vue d’éliminer ces pratiques, poursuivre ses efforts de sensibilisation de la population et renforcer les mécanismes de surveillance.", "-          تنفيذ الأحكام القانونية المتعلقة بالعمل واستغلال الأطFفال بصرامة قصد القضاء على هذه الممارسات، ومواصلة جهود توعية السكان التي تبذلها الدولة، وتوطّيد آليات المراقبة.", "", "" },
                    { 432, null, "R144.201", "201.144", "", "Non réalisé", "", 0, 6, 1, null, 51, 32, null, "Examen périodique universal", "Poursuivre la mise en conformité de la 9, des politiques et des programmes qui établissent les droits de l’enfant afin d’empêcher que les enfants travaillent dans des conditions nocives, mettre un terme aux mariages précoces et criminaliser toutes les formes d’exploitation des enfants", "مواصلة مواءمة تشريعاته وسياساته وبرامجه التي تكرس حقوق الطفل من أجل منع عمل الأطفال في ظروف مؤذية ووقف حالات الزواج المبكر وتجريم جميع أشكال استغلال الأطفال", "", "" },
                    { 431, null, "R144.219", "219.144", "", "Non réalisé", "", 0, 6, 1, null, 89, 32, null, "Examen périodique universal", "Prendre des mesures pour contrecarrer la tendance des autorisations judiciaires de mariage entre mineurs, notamment en apportant les modifications nécessaires au Code de la", "اتخاذ تدابير من أجل مقاومة الميل إلى استصدار أذون قضائية لحالات زواج تهمُّ قاصرين بوسائل منها إجراء التعديلات الضرورية لمدونة الأسرة", "", "" },
                    { 430, null, "R144.218P2", "218.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 84, 32, null, "Examen périodique universal", "Renforcer les mesures visant à éliminer les mariages d’enfants et accélérer l’adoption de la loi abolissant le mariage forcé des enfants", "......... الإسراع بسَنّ التشريع الذي يلغي تزويج الأطفال كرهاً", "", "" },
                    { 429, null, "R144.159", "159.144", "", "Non réalisé", "", 0, 6, 1, null, 94, 32, null, "Examen périodique universal", "Adopter un projet de loi réglementant les conditions de travail des travailleurs domestiques", "اعتماد مشروع قانون يحدد شروط عمل العمال المنزليين", "", "" },
                    { 428, null, "R144.134P2", "134.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 3, 32, null, "Examen périodique universal", "permettre la pleine reconnaissance juridique des enfants nés hors mariage", "...... السماح بالاعتراف القانوني التام بالأطفال المولودين خارج إطار الزواج.....", "", "" },
                    { 427, null, "R144.130P1P3", "130.144 ج.1 و ج.3", "", "Non réalisé", "", 0, 6, 1, null, 18, 32, null, "Examen périodique universal", "Analyser la 9 existante et abroger toutes les règles qui sont contraires au principe de l’égalité entre les enfants ou qui constituent une discrimination à l’égard des droits de l’enfant", "تحليل التشريعات القائمة وإلغاء جميع القواعد التي تتنافى مع مبدأ المساواة بين الأطفال أو التي تشكل تمييزاً في حق الطفل", "", "" },
                    { 434, null, "R144.222P2", "222.144. ج.2", "", "Non réalisé", "", 0, 6, 1, null, 19, 33, null, "Examen périodique universal", "Prendre des mesures plus efficaces pour mieux protéger les droits des personnes handicapées", "اتخاذ تدابير أكثر نجوعاً من أجل توفير حماية أفضل لحقوق.... الأشخاص ذوي الإعاقة.... وغير ذلك من الفئات الضعيفة", "", "" },
                    { 604, null, "R16P2P3", "ت.16.ف.2.ف.3", "", "Non réalisé", "", 0, 6, null, 3, null, 30, null, "Organes de traités", @"b) faciliter le dépôt de plaintes pour violences en veillant à ce que les cas de violence à l’égard des femmes fassent l’objet d’enquêtes approfondies, que les auteurs soient poursuivis et condamnés, et que les victimes aient accès à des recours utiles et ne soient pas poursuivies pour relations sexuelles hors mariage ; 
                c) garantir une prise en charge légale, médicale et psychologique des victimes de violences domestiques et sexuelles, améliorer les services des structures d’accueil et les dispositifs de prise en charge des victimes.", @"(ب) تيسير تقديم الشكاوى من العنف بحيث يحقَّق في قضايا العنف بالنساء تحقيقاً متعمقاً، وملاحقة الجناة وإدانتهم، وتوفير سبل انتصاف فعالة للضحايا وعدم ملاحقتهم بسبب علاقاتهم الجنسية خارج نطاق الزواج؛ 
                - (ج) توفير الرعاية القانونية والطبية والنفسية لضحايا العنف المنزلي والجنسي، وتحسين خدمات مرافق الرعاية وترتيبات رعاية الضحايا.", "", "" },
                    { 383, null, "R144.207", "207.144", "", "Non réalisé", "", 0, 6, 1, null, 31, 30, null, "Examen périodique universal", "Accomplir de nouveaux progrès dans la lutte contre toutes les formes de discrimination et de violence à l’égard des femmes en mettant en service l’Autorité pour l’égalité des sexes et la lutte contre toutes les formes de discrimination", "إحراز مزيد من التقدم في محاربة جميع أشكال التمييز والعنف على المرأة وبدئ هيئة المناصفة ومكافحة كل أشكال التمييز عملها", "", "" },
                    { 562, null, "R23P2P4", "ت.23.ف.2.ف.4", "", "Non réalisé", "", 0, 6, null, 2, null, 30, null, "Organes de traités", @"Veiller à ce que les femmes et les filles victimes de violences aient immédiatement accès à des moyens de protection, y compris des foyers d’accueil, qu’elles puissent obtenir réparation et que les auteurs soient poursuivis et punis comme il convient.
                - procéder à des études sur les causes et l’ampleur de la violence à l’encontre des femmes et des filles, y compris la violence sexuelle et la violence dans la famille
                .", @"ضمان وصول النساء والفتيات ضحايا العنف فوراً إلى وسائل الحماية، بما في ذلك دور الإيواء، وعلى تمكينهن من الحصول على تعويضات، وعلى مقاضاة الجناة ومعاقبتهم على النحو المناسب.
                - إجراء دراسات بشأن أسباب ومدى انتشار العنف المرتكب في حق النساء والفتيات، بما في ذلك العنف الجنسي والعنف الأُسري.", "", "" },
                    { 377, null, "R144.184P1", "184.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 59, 30, null, "Examen périodique universal", "Poursuivre les efforts louables visant à promouvoir et protéger les droits des femmes", "مواصلة الجهود الحميدة الرامية إلى تعزيز حماية حقوق النساء", "", "" },
                    { 376, null, "R144.183", "183.144", "", "Non réalisé", "", 0, 6, 1, null, 77, 30, null, "Examen périodique universal", "Continuer de promouvoir l’égalité des sexes et la participation des femmes à la vie politique et aux services publics", "مواصلة تشجيع المساواة بين الجنسين وإشراك المرأة في الحياة السياسية والوظيفة العمومية", "", "" },
                    { 375, null, "R144.182", "182.144", "", "Non réalisé", "", 0, 6, 1, null, 28, 30, null, "Examen périodique universal", "Continuer à promouvoir l’égalité entre hommes et femmes dans les politiques publiques", "مواصلة تعزيز المساواة بين الرجال والنساء في السياسات العامة", "", "" },
                    { 374, null, "R144.69", "69.144", "", "Non réalisé", "", 0, 6, 1, null, 93, 30, null, "Examen périodique universal", "Poursuivre les efforts visant à élaborer un cadre national pour le développement humain qui tienne compte de l’égalité des sexes et de la non‑discrimination", "مواصلة الجهود الرامية إلى صوغ إطار وطني للتنمية البشرية يضع في الاعتبار المساواة بين الجنسين وعدم التمييز", "", "" },
                    { 231, null, "R89", "ت.89", "", "Non réalisé", "", 0, 6, null, null, null, 30, 8, "Procédure spéciale", "Pour garantir une égalité effective des sexes au bénéfice des femmes assurant une direction spirituelle, les femmes devraient pouvoir devenir membres à part entière des conseils religieux à tous les niveaux, y compris les institutions chargées d’émettre des fatwa, et être autorisées à exercer des fonctions de supervision dans les mosquées, que ce soit par l’enseignement ou la prédication.", "-    لضمان مساواة فعالة بين الجنسين للنساء اللواتي يقدمن إرشادات دينية، ينبغي أن تكون النساء قادرات على الانضمام- كأعضاء كاملي العضوية- إلى المجالس الدينية على جميع المستويات، بما في ذلك مؤسسات الفتوى، وأن يُسمح لهن بممارسة الإشراف الديني داخل المساجد، سواء من خلال الدروس أو الوعظ.", "", "" },
                    { 230, null, "R86P6-2", "ت.86.ف.6ج2", "", "Non réalisé", "", 0, 6, null, null, null, 30, 8, "Procédure spéciale", "Tenir compte des droits de l’homme, de l’égalité des sexes et de la justice sociale dans l’élaboration du plan national de développement culturel.", "-    (و) وضع خطة عمل وطنية للتنمية الثقافية تضمن بشكل فعال إبراز التنوع الثقافي؛ ..... وينبغي أن تساهم مفاهيم حقوق الإنسان والمساواة بين الجنسين والعدالة الاجتماعية في إعداد خطة وطنية للتنمية الثقافية.", "", "" },
                    { 171, null, "R89P10", "null", "", "Non réalisé", "", 0, 6, null, null, null, 30, 6, "Procédure spéciale", "Approuver et appliquer l’Agenda du Gouvernement pour l’égalité 2011-2015. Toutes les politiques et programmes dotés d’objectifs en matière d’égalité et de non-discrimination devraient faire l’objet d’une évaluation régulière pour s’assurer qu’ils permettront d’atteindre ces objectifs", "null", "", "" },
                    { 170, null, "R89P9", "null", "", "Non réalisé", "", 0, 6, null, null, null, 30, 6, "Procédure spéciale", "Transposer à l’échelon régional, provincial et communal les progrès notables accomplis au niveau national dans le domaine de l’intégration et de la budgétisation axée sur la parité au sein des organismes publics", "null", "", "" },
                    { 169, null, "R89P6", "null", "", "Non réalisé", "", 0, 6, null, null, null, 30, 6, "Procédure spéciale", "Rassembler des informations étayées par des faits sur l’application de l’obligation qu’a l’État partie d’agir avec la diligence voulue pour prévenir, interdire et punir les violations des normes internationales relatives à l’égalité et à la non-discrimination,  et pour assurer aux femmes en temps voulu des moyens de recours abordables et accessibles, y compris judiciaires;", "null", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 109, null, "R92P2", "ت.92.ف.2", "", "Non réalisé", "", 0, 6, null, null, null, 30, 3, "Procédure spéciale", "-    En ce qui concerne les femmes, réduire le taux de surpeuplement des prisons en prenant des mesures de remplacement des peines privatives de liberté, en particulier dans le cas des femmes ayant des enfants.", "عن النساء، يوصي المقرر الخاص الحكومة بما يلي:  (ب) تقليص نسبة الاكتظاظ بتنفيذ تدابير بديلة، لا سيما لفائدة النساء والأطفال.", "", "" },
                    { 108, null, "R92P1", "ت.92.ف.1", "", "Non réalisé", "", 0, 6, null, null, null, 30, 3, "Procédure spéciale", "-    Donner effet à la protection des prisonnières contre toutes les violences fondées sur le sexe", "عن النساء، يوصي المقرر الخاص الحكومة بما يلي:  (أ) تعزيز حماية السجينات من جميع أشكال العنف الجنساني؛", "", "" },
                    { 24, null, "R81", "null", "", "Non réalisé", "", 0, 6, null, null, null, 30, 1, "Procédure spéciale", "-   Appliquer les dispositions du Code des habous et prendre des mesures pour éliminer les obstacles socioculturels empêchant les femmes d’exercer leur droit à la terre.", "null", "", "" },
                    { 23, null, "R79", "null", "", "Non réalisé", "", 0, 6, null, null, null, 30, 1, "Procédure spéciale", "-   Prendre toutes les mesures nécessaires pour éliminer les préjugés et pratiques néfastes qui empêchent les femmes d’exercer leurs droits, conformément aux obligations qui incombent au Maroc en vertu de la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes", "null", "", "" },
                    { 776, null, "R31P1P2P3", "ت.31.ف.1.ف2ف.ف3", "", "Non réalisé", "", 0, 5, null, 7, null, 29, null, "Organes de traités", @"Adopter toutes les mesures nécessaires en vue d’une application effective des modifications apportées à la loi sur la nationalité et à modifier le paragraphe 7 de l’article 16 de la loi no 37-99 pour faire en sorte que toutes les mères, sans distinction aucune, puissent transmettre leur nom de famille à leurs enfants;
                b) Faire en sorte que tous les enfants nés sur le territoire de l’État partie, quel que soit le statut de leurs parents ou la nature de leur permis de résidence, soient enregistrés et obtiennent immédiatement un bulletin de naissance officiel sans obstacle indu;
                c) Abolir les frais imposés pour l’obtention d’un bulletin de naissance, prolonger le court délai d’enregistrement des nouveau-nés (trente jours) et faciliter la délivrance de bulletins de naissance à tous les enfants réfugiés qui n’en possèdent pas encore un;", @"(أ) اتخاذ جميع التدابير اللازمة لتنفيذ إصلاح قانون الجنسية تنفيذاً فعالاً، وتعديل الفقرة 7 من المادة 16 من القانون رقم 37-99 بحيث تستطيع جميع الأمهات، دون تمييز، نقل أسمائهن العائلية إلى أطفالهن؛
                - (ب) تأمين تسجيل جميع الأطفال المولودين على أراضيها، بصرف النظر عن وضع والديهم أو تصاريح إقامتهم القانونية، وتوفير شهادات ميلاد رسمية لهم على الفور، دون أي حواجز لا مبرر لها؛ 
                - (ج) إلغاء رسوم شهادات الميلاد، وتمديد فترة تسجيل الوِلْدان القصيرة (30 يوماً) وتيسير تقديم شهادات الميلاد لجميع أطفال اللاجئين الذين لا يزالون يفتقرون إليها", "", "" },
                    { 229, null, "R86P2-1-2", "ت.86.ف.2ج1ج2", "", "Non réalisé", "", 0, 5, null, null, null, 29, 8, "Procédure spéciale", "veiller à ce que les officiers de l’état civil observent pleinement les dispositions de la circulaire du 9 avril 2010 sur le choix des prénoms du Ministère des affaires 26es. - ouvrir en temps voulu des recours effectifs aux individus dont on a refusé d’inscrire les enfants sous le prénom choisi. Dans un tel cas, les officiers d’état civil devraient répondre par écrit aux demandeurs, en temps voulu, en indiquant clairement les raisons de leur refus et les possibilités de recours.", "(ب) ضمان تقيد سجلات الحالة المدنية تقيدا تاما بأحكام مذكروزارة الداخلية المؤرخة 9 نيسان/أبريل 2010 والمتعلقة باختيار الأسماء.-   إتاحة الوصول إلى سبل الانتصاف في الوقت المناسب وبشكل فعال للأشخاص الذين حرموا من تسجيل أسماء أطفالهم. وفي هذه الحالة، ينبغي أن يقدم موظفو الحالة المدنية ردوداً خطية إلى أصحاب الطلبات، في الوقت المناسب، مع الإشارة بوضوح لأسباب هذا الرفض وإمكانيات الطعن فيه.", "", "" },
                    { 602, null, "R18P3", "ت.18.ف.3", "", "Non réalisé", "", 0, 5, null, 3, null, 28, null, "Organes de traités", "Réduire la durée initiale de la garde à vue à quarante-huit heures au maximum, y compris pour les affaires liées au terrorisme, et permettre l’accès à un avocat dès le début de la détention.", "-          تقليص المدة الأولية للاحتجاز لدى الشرطة إلى 48 ساعة على أقصى تقدير، بما في ذلك في القضايا المرتبطة بالإرهاب، والسماح بتوكيل محام منذ بداية الاحتجاز.", "", "" },
                    { 561, null, "R8P3", "ت.8.ف.3", "", "Non réalisé", "", 0, 5, null, 2, null, 28, null, "Organes de traités", "-            Conformément aux résolutions du Conseil de sécurité, notamment 1456 (2003) et 1566 (2004), et à d’autres résolutions pertinentes, les mesures de lutte contre le terrorisme doivent être appliquées dans le plein respect du droit international relatif aux droits de l’homme.", "-          يجب، وفقاً لقرارات مجلس الأمن، وخاصة القرارين 1456(2003) و1566(2004) والقرارات الأخرى الوثيقة الصلة بالموضوع، تطبيق تدابير مكافحة الإرهاب في نطاق الاحترام التام للقانون الدولي المتعلق بحقوق الإنسان.", "", "" },
                    { 503, null, "R15", "ت.15", "", "Non réalisé", "", 0, 5, null, 1, null, 28, null, "Organes de traités", "Assurer l’application des garanties juridiques fondamentales aux personnes soupçonnées de terrorisme, en particulier des étrangers, en tenant compte de la Déclaration adoptée par le Comité, le 8 mars 2002 sur la discrimination raciale et les mesures de lutte contre le terrorisme (A/57/18, paragraphe 514).", "الحرص على ضمان تطبيق الضمانات القانونية الأساسية على الأشخاص الذين يُشتبه في تورطهم في الإرهاب، خاصةً إذا كانوا يحملون جنسية أجنبية، مع اعتبار الإعلان الذي اعتمدته اللجنة في 8 آذار/مارس 2002 بشأن التمييز العنصري وتدابير مكافحة الإرهاب (A/57/18، الفقرة 514).", "", "" },
                    { 601, null, "R40", "ت.40", "", "Non réalisé", "", 0, 5, null, 3, null, 27, null, "Organes de traités", "Eliminer toute disposition législative ou pratique discriminatoire qui viole la liberté de pensée, de conscience et de religion et s’assurer que le projet de Code pénal, actuellement en discussion, est pleinement conforme à l’article 18 du Pacte.", "-          إلغاء كل حكم أو ممارسة تنطوي على تمييز تنتهك حرية الفكر والوجدان والدين، وكفالة التوافق التام لمشروع القانون الجنائي، قيد النقاش حالياً، مع المادة 18 من العهد.", "", "" },
                    { 373, null, "P1R 144.111", "111.144. ج.1", "", "Non réalisé", "", 0, 5, 1, null, 51, 27, null, "Examen périodique universal", "Supprimer les pratiques restrictives à l’encontre des chrétiens et d’autres minorités conformément au droit international", "إزالة الممارسات التقييدية في حق المسيحيين وأقليات أخرى.. .......", "", "" },
                    { 56, null, "R87", "null", "", "Non réalisé", "", 0, 5, null, null, null, 27, 2, "Procédure spéciale", "-       Veiller à ce que tous les Marocains, y compris les membres de minorités religieuses, jouissent pleinement de leur droit à la liberté de pensée, de conscience et de religion dans des conditions d’égalité", "null", "", "" },
                    { 677, null, "R18P2", "ت.18.ف2", "", "Non réalisé", "", 0, 5, null, 5, null, 26, null, "Organes de traités", "-       Adopter les mesures pratiques pour garantir l’accès des travailleurs migrants à l’information et leur fournir une orientation sur les droits que leur reconnaît la Convention", "اعتماد تدابير عملية لضمان وصول العمال المهاجرين إلى المعلومات وإرشادهم فيما يتعلق بحقوقهم المعترف بها في الاتفاقية؛", "", "" },
                    { 600, null, "R38", "ت.38", "", "Non réalisé", "", 0, 5, null, 3, null, 26, null, "Organes de traités", @"Prendre toutes les mesures nécessaires pour faire en sorte que les activités de surveillance soient conformes aux obligations découlant du Pacte, notamment de l’article 17, et pour garantir que toute immixtion dans la vie privée soit conforme aux principes de légalité, de proportionnalité et de nécessité. 
                - Etablir des mécanismes de contrôle indépendants pour prévenir les abus.", @"اتخاذ جميع التدابير اللازمة بحيث تتوافق أنشطة المراقبة التي تضطلع بها مع التزاماتها بمقتضى العهد، خاصة المادة 17، وبحيث يتوافق أي تدخل في الخصوصية مع مبادئ الشرعية والتناسب والضرورة. 
                - إنشاء آليات رقابة مستقلة لمنع التجاوزات", "", "" },
                    { 599, null, "R46", "ت.46", "", "Non réalisé", "", 0, 5, null, 3, null, 25, null, "Organes de traités", @"s’assurer que la loi relative aux manifestations pacifiques est appliquée conformément aux dispositions du Pacte et que l’exercice de ce droit ne fait pas l’objet de restrictions autres que celles autorisées en vertu du Pacte.
                -  Prendre en considération les propositions formulées en novembre 2015 par le Conseil national des droits de l’homme au sujet des rassemblements publics.", @"التأكد من أن القانون المتعلق بالمظاهرات السلمية ينفذ وفقاً لأحكام العهد، وألا تقيَّد ممارسة هذا الحق إلا بالقيود التي يجيزها العهد. 
                - الأخذ في الحسبان المقترحات التي قدمها المجلس الوطني لحقوق الإنسان في تشرين الثاني/نوفمبر 2015 بشأن التجمعات العامة.", "", "" },
                    { 598, null, "R42", "ت.42", "", "Non réalisé", "", 0, 5, null, 3, null, 25, null, "Organes de traités", @"Prendre toutes les mesures nécessaires pour mettre un terme aux violations de la liberté d’association et aux pratiques ayant pour effet de restreindre ce droit au-delà des restrictions strictes permises par le paragraphe 2 de l’article 22 du Pacte. 
                - Veiller à ce que les défenseurs des droits de l’homme puissent opérer libres de toute influence indue de l’État partie et sans craindre de représailles ou de restrictions injustifiées de leurs activités.", @"التعجيل باتخاذ التدابير اللازمة لوضع حد لانتهاكات حرية تكوين الجمعيات وللممارسات التي تقيّد هذا الحق تقييداً يتجاوز القيود الصارمة التي تبيحها الفقرة 2 من المادة 22 من العهد. 
                - تمكين المدافعين عن حقوق الإنسان من العمل بمنأى عن أي تأثير من الدولة لا مبرر له ودون خوف من الانتقام أو تقييد أنشطتهم دون مبرر.", "", "" },
                    { 60, null, "R83", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Veiller à ce que la politique migratoire nationale fondée sur les droits de l’homme soit appliquée uniformément à tous les échelons de l’administration.", "null", "", "" },
                    { 372, null, "R144.114P2", "114.144.ج.2", "", "Non réalisé", "", 0, 5, 1, null, 36, 25, null, "Examen périodique universal", "Garantir pleinement les libertés d’association et prendre toutes les mesures nécessaires pour veiller à ce que les défenseurs des droits de l’homme puissent s’acquitter de leur mission", "ضمان حرية تكوين الجمعيات ضماناً تاماً بغية كفالة تمكين المدافعين عن حقوق الإنسان من أداء مهماتهم", "", "" },
                    { 378, null, "R144.187", "187.144", "", "Non réalisé", "", 0, 6, 1, null, 43, 30, null, "Examen périodique universal", "Comme suite aux recommandations issues du deuxième cycle figurant dans le document A/HRC/21/3 (par. 129.19, 129.22, 129.27, 129.39, 129.40, 129.43, 129.78, 129.88, 129.93 et 131.7), intensifier les efforts visant à améliorer les droits économiques, sociaux et culturels de la population féminine, avec leur pleine participation", "متابعة للتوصيات المنبثقة عن الجولة الثانية والواردة في الوثيقة A/HRC/21/3، الفقرات 129-19 و129-22 و129-27 و129-39 و129-40 و129-43 و129-78 و129-88 و129-93 و131-7، وتكثيف الجهود من أجل تحسين التمتع بالحقوق الاقتصادية والاجتماعية والثقافية مع مشاركة النساء مشاركة تامة", "", "" },
                    { 603, null, "R14P2", "ت.14.ف.2", "", "Non réalisé", "", 0, 6, null, 3, null, 30, null, "Organes de traités", "b) Prendre des mesures appropriées pour faire reculer la polygamie, en vue de la faire disparaître", "(ب) I95 اتخاذ التدابير المناسبة للحد من تعدد الزوجات قصد إلغاء هذه الممارسة", "", "" },
                    { 379, null, "R144.190", "190.144", "", "Non réalisé", "", 0, 6, 1, null, 36, 30, null, "Examen périodique universal", "Prendre toutes les mesures nécessaires afin de renforcer la lutte contre la violence domestique et les violences sexuelles envers les femmes", "اتخاذ جميع التدابير الضرورية لتشديد مكافحة العنف المنزلي والعنف الجنسي الذي يمارَس على النساء", "", "" },
                    { 381, null, "R144.193", "193.144", "", "Non réalisé", "", 0, 6, 1, null, 93, 30, null, "Examen périodique universal", "Continuer de s’employer à lutter contre les violences faites aux femmes", "مواصلة الجهود لمكافحة العنف على المرأة", "", "" },
                    { 504, null, "R17", "ت.17", "", "Non réalisé", "", 0, 6, null, 1, null, 30, null, "Organes de traités", "Prendre toutes les mesures nécessaires afin de s’assurer de la pleine application du Code de la famille de manière uniforme sur tout le territoire national et d’éviter que certaines catégories parmi les plus vulnérables de sa population, en particulier les femmes et les enfants résidant dans les régions éloignées, ne soient victimes de doubles ou multiples discriminations.", "اتخاذ جميع التدابير الضرورية لضمان تطبيق كامل وموحد لمدونة الأسرة في جميع أنحاء الإقليم الوطني ولتفادي وقوع فئات معينة من أضعف السكان، وخاصةً النساء والأطفال في المناطق النائية، ضحية التمييز المزدوج أو المتعدد. وتذكّر اللجنة الدولة الطرف خصوصاً بتوصيتها العامة رقم 25(2000) بشأن أبعاد التمييز العنصري المتعلقة بنوع الجنس.", "", "" },
                    { 409, null, "R144.185P1", "185.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 89, 30, null, "Examen périodique universal", "….revoir toutes les lois et pratiques qui établissent une discrimination fondée sur le sexe et les mettre en conformité avec le droit international et les normes internationales, et prendre des mesures pour améliorer encore la protection des femmes victimes de la violence", "........ استعراض جميع القوانين والممارسات التي تشكل تمييزاً على أساس نوع الجنس وجعلها متوائمة مع القانون الدولي والمعايير الدولية واتخاذ خطوات من أجل زيادة تحسين حماية النساء اللواتي يتعرضن للعنف", "", "" },
                    { 408, null, "R144.210", "210.144", "", "Non réalisé", "", 0, 6, 1, null, 86, 30, null, "Examen périodique universal", "Régler le nouveau protocole de la loi sur l’avortement pour donner aux femmes le droit d’avorter en cas d’inceste ou de viol, sur base du rapport de police seulement", "تعديل قانون الإجهاض الجديد لمنح النساء الحق في الإجهاض في حالات التعرض لزنا المحارم والاغتصاب بناءً على محضر الشرطة فقط", "", "" },
                    { 407, null, "R144.196P1", "196.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 14, 30, null, "Examen périodique universal", "Poursuivre ses efforts tendant à améliorer la 9 concernant la violence à l’égard des femmes", "مواصلة الجهود من أجل تحسين التشريعات المتعلقة بالعنف على المرأة بما يتفق مع المعايير الدولية بأن تتناول أبعاد الوقاية والحماية والمساعدة، ............", "", "" },
                    { 406, null, "R144.209", "209.144", "", "Non réalisé", "", 0, 6, 1, null, 67, 30, null, "Examen périodique universal", "Mettre en place une 9 spécifique pour prévenir les violences faites aux femmes, mener des enquêtes sur ces actes et les réprimer", "وضع تشريع محدد لمنع العنف على المرأة والتحقيق فيه والمعاقبة عليه", "", "" },
                    { 405, null, "R144.208", "208.144", "", "Non réalisé", "", 0, 6, 1, null, 90, 30, null, "Examen périodique universal", "Adopter et appliquer une loi globale et non discriminatoire sur la violence à l’égard des femmes et des filles", "اعتماد وتنفيذ قانون شامل ولا تمييزي بشأ�� العنف على النساء والبنات", "", "" },
                    { 404, null, "R144.206", "206.144", "", "Non réalisé", "", 0, 6, 1, null, 86, 30, null, "Examen périodique universal", "Accélérer la promulgation de la loi sur la violence à l’égard des femmes et l’adoption de la définition internationale de la violence fondée sur le genre", "الإسراع في سنّ القانون المتعلق بالعنف على المرأة واعتماد التعريف العالمي للعنف القائم على أساس نوع الجنس", "", "" },
                    { 403, null, "R144.205", "205.144", "", "Non réalisé", "", 0, 6, 1, null, 76, 30, null, "Examen périodique universal", "Renforcer la 9 pour assurer l’égalité entre les sexes, en particulier pour prévenir la violence à l’égard des femmes, et mettre un terme aux mariages précoces et forcés", "تقوية التشريعات وتشديدها لكفالة المساواة بين الجنسين وخاصة لمنع العنف على المرأة ووقف حالات الزواج المبكر والقسري", "", "" },
                    { 402, null, "R144.204", "204.144", "", "Non réalisé", "", 0, 6, 1, null, 69, 30, null, "Examen périodique universal", "Adopter une loi générale sur la violence à l’égard des femmes, conformément aux normes internationales, en fournissant les moyens de sa mise en œuvre effective", "اعتماد قانون عام متعلق بالعنف على المرأة بما يتفق مع المعايير الدولية مع توفير وسائل تنفيذه تنفيذاً فعالاً", "", "" },
                    { 401, null, "R144.203", "203.144", "", "Non réalisé", "", 0, 6, 1, null, 65, 30, null, "Examen périodique universal", "Mettre en œuvre la loi sur la violence à l’égard des femmes rapidement", "تنفيذ القانون المتعلق بالعنف على المرأة بصورة عاجلة", "", "" },
                    { 399, null, "R144.200", "200.144", "", "Non réalisé", "", 0, 6, 1, null, 50, 30, null, "Examen périodique universal", "Accélérer le processus d’adoption du projet de loi sur l’élimination de la violence à l’égard des femmes", "تسريع عملية اعتماد مشروع القانون المتعلق بالقضاء على العنف على المرأة", "", "" },
                    { 398, null, "R144.199", "199.144", "", "Non réalisé", "", 0, 6, 1, null, 49, 30, null, "Examen périodique universal", "Renforcer le cadre juridique visant à prévenir la discrimination et la violence à l’égard des femmes, notamment la violence familiale", "تقوية الإطار القانوني منعاً للتمييز والعنف على المرأة، ولا سيما العنف المنزلي", "", "" },
                    { 397, null, "R144.198", "198.144", "", "Non réalisé", "", 0, 6, 1, null, 3, 30, null, "Examen périodique universal", "Mettre en œuvre des mesures adéquates pour assurer la protection complète et efficace des femmes contre la violence familiale et accélérer le processus de rédaction d’un projet de loi conforme aux normes internationales dans ce domaine", "تنفيذ تدابير كافية لضمان توفير الحماية الشاملة والفعالة للنساء من العنف المنزلي وتسريع عملية صياغة مشروع قانون يتماشى مع المعايير الدولية لتوفير الحماية الشاملة والفعالة للنساء من العنف المنزلي", "", "" },
                    { 396, null, "R144.197", "197.144", "", "Non réalisé", "", 0, 6, 1, null, 17, 30, null, "Examen périodique universal", "Ériger en infraction le viol conjugal et les menaces de violence dans le cadre de son projet de loi 103.13 sur la lutte contre la violence à l’égard des femmes et mettre en œuvre des programmes, financés par l’État, pour soutenir les victimes", "تجريم الاغتصاب في إطار الزواج والتهديدات بالعنف كجزء من مشروع القانون 103-13 المتعلق بمكافحة العنف على المرأة وتنفيذ برامج برعاية الدولة لمساندة الضحايا", "", "" },
                    { 395, null, "R144.195", "195.144", "", "Non réalisé", "", 0, 6, 1, null, 12, 30, null, "Examen périodique universal", "Accélérer l’adoption du projet de loi no 103.13 sur la violence à l’égard des femmes, tout en tenant compte de l’importance de l’élargissement de la protection destinée aux femmes victimes de violence, et ériger en infraction le viol conjugal", "تسريع اعتماد مشروع القانون 103-13 المتعلق بالعنف على المرأة، مع مراعاة أهمية توسيع نطاق الحماية ليشمل النساء ضحايا العنف ولتجريم الاغتصاب في إطار الزواج", "", "" },
                    { 394, null, "R144.194", "194.144", "", "Non réalisé", "", 0, 6, 1, null, 7, 30, null, "Examen périodique universal", "Modifier la 9 interne pour supprimer toutes les formes de discrimination sexiste et protéger les droits des femmes et des enfants", "تعديل التشريعات الداخلية لإزالة جميع أشكال التمييز القائم على نوع الجنس ولحماية حقوق المرأة والطفل", "", "" },
                    { 393, null, "R144.189", "189.144", "", "Non réalisé", "", 0, 6, 1, null, 18, 30, null, "Examen périodique universal", "Renforcer le cadre juridique existant pour protéger les femmes contre toutes les formes de violence et éliminer toutes les normes juridiques à caractère sexiste", "تقوية الإطار القانوني القائم من أجل حماية النساء من جميع أشكال العنف وإزالة جميع القواعد القانونية التمييزية القائمة على نوع الجنس", "", "" },
                    { 392, null, "R144.188", "188.144", "", "Non réalisé", "", 0, 6, 1, null, 44, 30, null, "Examen périodique universal", "Adopter une 9 complète et globale visant à éliminer la discrimination et toutes les formes de violence à l’égard des femmes et à les promouvoir dans tous les domaines, notamment le domaine économique", "اعتماد تشريعات شاملة ومتكاملة للقضاء على التمييز وعلى جميع أشكال العنف على المرأة ولتشجيع ارتقائها في جميع المجالات بما فيها المجال الاقتصادي", "", "" },
                    { 391, null, "R144.133", "133.144", "", "Non réalisé", "", 0, 6, 1, null, 26, 30, null, "Examen périodique universal", "Abroger les dispositions qui privent les femmes de la tutelle légale des enfants mineurs sur un pied d’égalité avec les hommes", "إلغاء الأحكام القانونية التي تحرم النساء من ممارسة الوصاية القانونية على الأطفال القصّر على قدم المساواة مع الرجال", "", "" },
                    { 390, null, "R144.132", "132.144", "", "Non réalisé", "", 0, 6, 1, null, 21, 30, null, "Examen périodique universal", "Abolir la disposition empêchant les Marocaines de transmettre leur nationalité à leur mari étranger", "إلغاء النص القانوني الذي يمنع النساء المغربيات من نقل جنسيتهن إلى أزواجهن الأجانب", "", "" },
                    { 389, null, "R144.228P1", "228.144 ج.1", "", "Non réalisé", "", 0, 6, 1, null, 38, 30, null, "Examen périodique universal", "Accélérer encore les efforts visant à promouvoir les droits des femmes en particulier ceux qui sont handicapés", "زيادة تسريع الجهود المبذولة لأجل تعزيز حقوق المرأة...... ولا سيما ذوي الإعاقات منهم", "", "" },
                    { 388, null, "R144.221", "221.144.", "", "Non réalisé", "", 0, 6, 1, null, 50, 30, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir la participation politique des femmes", "مواصلة الجهود الرامية إلى تعزيز مشاركة المرأة في الحياة السياسية", "", "" },
                    { 387, null, "R144.220", "220.144", "", "Non réalisé", "", 0, 6, 1, null, 30, 30, null, "Examen périodique universal", "Renforcer la promotion de la participation politique des femmes et des jeunes", "زيادة تعزيز مشاركة المرأة والشباب في الحياة السياسية", "", "" },
                    { 386, null, "R144.214", "214.144", "", "Non réalisé", "", 0, 6, 1, null, 83, 30, null, "Examen périodique universal", "Adopter des mesures appropriées en vue d’intégrer davantage les femmes dans les activités économiques et de leur garantir le droit à l’égalité de traitement et l’égalité de rémunération pour un travail de valeur égale", "اعتماد التدابير المناسبة بغية إدماج النساء أكثر في الأنشطة الاقتصادية وضمان حقهن في المعاملة المتساوية والأجر المتساوي لقاء العمل ذي القيمة المتساوية", "", "" },
                    { 385, null, "R144.212", "212.144", "", "Non réalisé", "", 0, 6, 1, null, 41, 30, null, "Examen périodique universal", "Prendre des mesures supplémentaires sur la violence familiale", "اتخاذ مزيد من التدابير بشأن العنف المنزلي", "", "" },
                    { 384, null, "R144.211", "211.144", "", "Non réalisé", "", 0, 6, 1, null, 91, 30, null, "Examen périodique universal", "Intensifier les efforts pour combattre la violence à l’égard des femmes en appliquant strictement les lois pertinentes et améliorer les mécanismes d’assistance aux victimes", "تكثيف الجهود لمكافحة العنف على المرأة بتطبيق القوانين ذات الصلة تطبيقاً صارماً وبتحسين آليات مساندة الضحايا", "", "" },
                    { 382, null, "R144.198P1", "198.144", "", "Non réalisé", "", 0, 6, 1, null, 3, 30, null, "Examen périodique universal", "Mettre en œuvre des mesures adéquates pour assurer la protection complète et efficace des femmes contre la violence familiale", "تنفيذ تدابير كافية لضمان توفير الحماية الشاملة والفعالة للنساء من العنف المنزلي وتسريع عملية صياغة مشروع قانون يتماشى مع المعايير الدولية لتوفير الحماية الشاملة والفعالة للنساء من العنف المنزلي", "", "" },
                    { 380, null, "R144.192", "192.144", "", "Non réalisé", "", 0, 6, 1, null, 85, 30, null, "Examen périodique universal", "Continuer à mettre en place des mesures concrètes aux niveaux local et national pour garantir l’égalité des sexes et lutter contre la discrimination à l’égard des femmes", "مواصلة استحداث تدابير عملية على الصعيدين المحلي والوطني لضمان المساواة بين الجنسين ومكافحة التمييز في حق المرأة", "", "" },
                    { 61, null, "R84", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Éliminer toutes les pratiques de profilage racial et toutes les autres pratiques discriminatoires d’application de la loi sur l’immigration, y compris les réinstallations forcées, les arrestations et détentions arbitraires, le confinement régional des Africains noirs d’origine subsaharienne et le recours excessif à la force à leur égard.", "null", "", "" },
                    { 448, null, "R144.38", "38.144", "", "Non réalisé", "", 0, 7, 1, null, 28, 36, null, "Examen périodique universal", "Continuer à intégrer les droits de l’homme dans différents secteurs et organismes nationaux", "مواصلة تعميم منظور حقوق الإنسان في مختلف الهيئات والقطاعات الوطنية", "", "" },
                    { 112, null, "R88P11", "ت.88.ف.11", "", "Non réalisé", "", 0, 6, null, null, null, 34, 3, "Procédure spéciale", "-    veiller à ce que le principe de non-refoulement énoncé à l’article 3 de la Convention contre la torture soit pleinement appliqué, notamment dans le cas des migrants, des réfugiés et des demandeurs d’asile, pour que nul ne soit expulsé vers un pays où il risque d’être soumis à la torture;", "-          (ك) ضمان تطبيق مبدأ عدم الإعادة القسرية المنصوص عليه في المادة 3 من اتفاقية مناهضة التعذيب تطبيقاً تاماً، مثلاً على المهاجرين واللاجئين وملتمسي اللجوء، بحيث لا يسلّم الناس إلى أي بلد يحتمل أن يعذبوا فيه؛", "", "" },
                    { 648, null, "R18P1P2", "ت.18.ف.1.ف.2", "", "Non réalisé", "", 0, 7, null, null, null, 37, null, "Organes de traités", @"Tenant compte de son observation générale no 16 (2005) sur le droit égal de l’homme et de la femme au bénéfice de tous les droits économiques, sociaux et culturels, le Comité recommande de :
                - a) Combattre la discrimination contre les femmes à travers notamment des campagnes de sensibilisation auprès de la population, en particulier des chefs religieux et traditionnels en vue de l’élimination de toute forme de discrimination fondée sur le sexe………
                - b) Abolir la polygamie et de mener des campagnes de sensibilisation pour éliminer les stéréotypes sexistes et promouvoir les droits des femmes", @"في ضوء تعليقها العام رقم 16(2005) بشأن المساواة بين الرجل والمرأة في حق التمتع بجميع الحقوق الاقتصادية والاجتماعية والثقافية، توصي اللجنة بما يلي:
                -  (أ)مكافحة التمييز ضد المرأة بوسائل منها تنظيم حملات للتوعية في أوساط السكان، وبخاصة في صفوف الزعماء الدينيين والتقليديين، من أجل القضاء على جميع أشكال التمييز الجنساني. 
                -  ب) إلغاء تعدد الزوجات وتنظيم حملات توعية للقضاء على التنميط الجنساني وتعزيز حقوق المرأة؛", "", "" },
                    { 610, null, "R51", "ت.51", "", "Non réalisé", "", 0, 7, null, 3, null, 37, null, "Organes de traités", @"Assurer une large diffusion du Pacte, du sixième rapport périodique, des réponses écrites à la liste de points établie par le Comité et des observations finales afin de sensibiliser les autorités judiciaires, législatives et administratives, la société civile, les organisations non gouvernementales œuvrant dans le pays et le grand public aux droits consacrés par le Pacte. 
                veiller à ce que le rapport et les présentes observations finales soient traduits dans les langues officielles", "نشر نص العهد، والتقرير الدوري السادس، والردود الخطية على قائمة المسائل التي وضعتها اللجنة، وهذه الملاحظات الختامية، على نطاق واسع من أجل توعية السلطات القضائية والتشريعية والإدارية، والمجتمع المدني، والمنظمات غير الحكومية العاملة في البلد، وعامة الناس، بالحقوق التي يكرسها العهد. وينبغي أن تترجم التقرير وهذه الملاحظات الختامية إلى لغتيها الرسميتين.", "", "" },
                    { 568, null, "R32", "ت.32", "", "Non réalisé", "", 0, 7, null, 2, null, 37, null, "Organes de traités", "-            Diffuser largement les rapports soumis au Comité, ainsi que les conclusions et recommandations de celui-ci, par le biais des sites Internet officiels, des médias et des organisations non gouvernementales.", "-           النشر، على نطاق واسع، للتقارير التي تم تقديمها إلى اللجنة وكذلك استنتاجات اللجنة وتوصياتها، عن طريق مواقع الانترنت الرسمية وعبر وسائل الإعلام والمنظمات غير الحكومية.", "", "" },
                    { 567, null, "R24P2", "ت.24.ف.2", "", "Non réalisé", "", 0, 7, null, 2, null, 37, null, "Organes de traités", "-            sensibiliser le public aux formes positives, participatives et non violentes de discipline des enfants", "-          توعية الجمهور فيما يتعلق بأشكال التأديب الإيجابية التشاركية لا على الأشكال العنيفة.", "", "" },
                    { 509, null, "R20P2", "ت.20.ف2", "", "Non réalisé", "", 0, 7, null, 1, null, 37, null, "Organes de traités", "- Poursuivre les initiatives de sensibilisation et d’éducation du public, à la diversité multiculturelle, à l’entente et à la tolérance, notamment à l’égard de certaines catégories vulnérables, en particulier de certains amazighs, des saharawis, des noirs, des non-ressortissants, des réfugiés et des demandeurs d’asile.", "- مواصلة تنفيذ مبادرات تحسيس عامة الناس وتثقيفهم بشأن التنوع الثقافي والوئام والتسامح، خصوصاً تجاه بعض الفئات الضعيفة، وخاصة بعض الأمازيغ والصحراويين والزنوج وغير المواطنين واللاجئين وطالبي اللجوء.", "", "" },
                    { 508, null, "R18P2", "ت.18.ف.2", "", "Non réalisé", "", 0, 7, null, 1, null, 37, null, "Organes de traités", "Informer la population, en particulier les catégories vulnérables et notamment les Amazighs, les Sahraouis, les noirs, les non-ressortissants, les réfugiés et les demandeurs d’asile, de toutes les voies de recours juridiques disponibles, de simplifier ces recours et d’en faciliter l’accès", "إعلام السكان، وخاصة الفئات الضعيفة ولا سيما الأمازيغ والصحراويون والزنوج وغير المواطنين واللاجئون وطالبو اللجوء، بجميع سبل الانتصاف القانونية المتاحة، وتبسيط تلك السبل وتسهيل اللجوء إليها", "", "" },
                    { 452, null, "R144.63", "63.144", "", "Non réalisé", "", 0, 7, 1, null, 54, 37, null, "Examen périodique universal", "Redoubler d’efforts pour promouvoir la culture des droits de l’homme et l’éducation aux droits de l’homme", "بذل المزيد من الجهود لتعزيز ثقافة حقوق الإنسان والتثقيف في ميدان حقوق الإنسان", "", "" },
                    { 245, null, "R73P1-2", "null", "", "Non réalisé", "", 0, 7, null, null, null, 37, 8, "Procédure spéciale", "Les nouveaux objectifs de développement durable, le document final de la troisième Conférence internationale sur le financement du développement et l’accord sur le climat issu de la vingt et unième session de la Conférence des Parties à la Convention-cadre des Nations Unies sur les changements climatiques devraient être diffusés sous une présentation simplifiée auprès du plus grand nombre, afin que le public puisse prendre connaissance de leurs conséquences directes pour le Maroc", "null", "", "" },
                    { 174, null, "R89P12", "null", "", "Non réalisé", "", 0, 7, null, null, null, 37, 6, "Procédure spéciale", "Mettre l’enseignement, les médias et d’autres moyens au service d’une sensibilisation accrue aux questions juridiques et d’une meilleure connaissance de ces questions, s’agissant notamment des moyens d’obtenir une réparation d’ordre judiciaire et sous toute autre forme en cas de violation des droits de l’homme et de combattre les obstacles culturels et sociaux à l’égalité et au respect des droits fondamentaux des femmes au Maroc", "null", "", "" },
                    { 147, null, "R89", "null", "", "Non réalisé", "", 0, 7, null, null, null, 37, 4, "Procédure spéciale", "Des efforts de sensibilisation et de renforcement des capacités devraient être entrepris d’urgence afin que les affaires de traite fassent l’objet de mesures centrées sur la victime. - Le Gouvernement devrait également redoubler d’efforts pour sensibiliser le grand public à toutes les formes de traite des êtres humains, afin de mieux faire comprendre ce qui constitue une forme de traite", "null", "", "" },
                    { 66, null, "R77", "null", "", "Non réalisé", "", 0, 7, null, null, null, 37, 2, "Procédure spéciale", "-       Redoubler d’efforts pour éliminer les préjugés, les stéréotypes négatifs et la stigmatisation et prendre des mesures efficaces visant à promouvoir la tolérance et la compréhension, conformément à l’article 7 de la Convention internationale sur l’élimination de toutes les formes de discrimination raciale", "null", "", "" },
                    { 857, null, "R35P2", "ت.35.ف. 2", "", "Non réalisé", "", 0, 7, null, 8, null, 36, null, "Organes de traités", "Dispenser une formation aux familles des personnes handicapées, aux personnes qui s’occupent de ces dernières, aux professionnels de la santé et aux agents des forces de l’ordre pour leur permettre de reconnaître toutes les formes d’exploitation, de violence et de maltraitance, et de mieux communiquer et travailler avec les personnes handicapées qui sont victimes d’actes de violence ;", "-       (ب) توفير التدريب للأسر ومقدمي الرعاية، والموظفين الصحيين، وموظفي إنفاذ القوانين بشأن التعرف على جميع أشكال الاستغلال والعنف والاعتداء، والتواصل والعمل الفعالين مع الأشخاص ذوي الإعاقة من ضحايا العنف؛", "", "" },
                    { 649, null, "R12P3", "ت.12.ف.3", "", "Non réalisé", "", 0, 8, null, null, null, 37, null, "Organes de traités", "-            c) Encourager l’instance nationale de la probité, de la prévention et de la lutte contre la corruption à faire figurer dans ses rapports annuels une description des cas de corruption traités par elle pour dissuader la commission de tels actes et renforcer l’application effective de la loi", "-          (ج) تشجيع الهيئة الوطنية للنزاهة والوقاية من الرشوة ومحاربتها على تضمين تقاريرها السنوية وصفاً لحالات الفساد التي عالجتها ردعاً لمرتكبي هذه الأفعال وتعزيزاً لتطبيق القانون على نحو فعال؛", "", "" },
                    { 856, null, "R29P3", "ت.29.ف.3", "", "Non réalisé", "", 0, 7, null, 8, null, 36, null, "Organes de traités", "c) Veiller à ce que des programmes de formation et des campagnes de sensibilisation et d’information soient régulièrement mis en œuvre à l’intention du personnel des tribunaux, des juges, des procureurs et des responsables de l’application des lois, notamment de la police et de l’administration pénitentiaire, sur la nécessité d’assurer l’accès des personnes handicapées à la justice", "-       (ج) ضمان استمرارية برامج التدريب وحملات التوعية والإعلام التي تستهدف موظفي المحاكم والقضاة والمدعين العامين والموظفين المكلفين بإنفاذ القوانين، بمن فيهم أفراد الشرطة وموظفو السجون، بشأن ضرورة تيسير إمكانية اللجوء إلى القضاء للأشخاص ذوي الإعاقة؛", "", "" },
                    { 854, null, "R21", "ت.21", "", "Non réalisé", "", 0, 7, null, 8, null, 36, null, "Organes de traités", @"a) Renforcer, avec la participation des personnes handicapées par l’intermédiaire des organisations qui les représentent et avec le concours des médias, les campagnes de sensibilisation visant à réaffirmer la valeur et la dignité des personnes handicapées ;
                b) Sensibiliser les responsables politiques, notamment les responsables des pouvoirs législatif, exécutif et judiciaire, aux dispositions de la Convention et du Protocole facultatif s’y rapportant et de s’assurer de leur soutien aux fins de la mise en œuvre des recommandations figurant dans les observations finales du Comité ;
                c) Engager un dialogue au sein de la société, en y associant les responsables des communautés et les dignitaires religieux, en vue de prévenir la stigmatisation de toutes les catégories de personnes handicapées ;
                d) Concevoir des campagnes de sensibilisation et de réviser les supports pédagogiques pour éviter la confusion pouvant résulter du fait d’avoir une orientation sexuelle différente et d’être une personne handicapée.", @"(أ) العمل، بمشاركة الأشخاص ذوي الإعاقة، من خلال المنظمات التي تمثلهم، وبانخراط وسائط الإعلام، على تعزيز حملات التوعية العامة الرامية إلى إعادة تأكيد قيمة الأشخاص ذوي الإعاقة وكرامتهم؛ 
                - (ب) إذكاء الوعي في أوساط السياسيين، بما في ذلك في أوساط السلطات التشريعية والتنفيذية والقضائية، بشأن الاتفاقية وبروتوكولها الاختياري وتأمين دعمها في تنفيذ التوصيات الواردة في الملاحظات الختامية للجنة؛
                - (ج) عقد حوار في المجتمع، ينخرط فيه زعماء المجتمع المحلي والزعماء الدينيون، بهدف منع وصم الأشخاص ذوي الإعاقة بجميع فئاتهم؛
                - (د) إعداد حملات لإذكاء الوعي ومراجعة المواد التعليمية لمنع الخلط المحتمل بين شخص له ميل جنسي مختلف وشخص من ذوي الإعاقة", "", "" },
                    { 853, null, "R15 P1P2", "ت.15.ف.1.ف.2", "", "Non réalisé", "", 0, 7, null, 8, null, 36, null, "Organes de traités", @"conformément à son observation générale no 3 (2016) sur les femmes et les filles handicapées et à la cible 5.2 des objectifs de développement durable, Le Comité recommande de mettre fin à toute forme de violence à l’égard des femmes et des filles handicapées dans les sphères tant publique que privée, notamment à la traite et à l’exploitation, sexuelle et autre. Il recommande également :
                a) …… et de mener des campagnes de sensibilisation pour battre en brèche les stéréotypes, les préjugés et les mythes sur les femmes et les filles handicapées 
                b) Sensibiliser la population à toutes les formes de discrimination à l’égard des femmes et de tenir compte des points de vue des femmes qui s’occupent d’enfants handicapés dans les politiques de lutte contre la discrimination sexiste", @"تماشياً مع التعليق العام رقم 3(2016) بشأن النساء والفتيات ذوات الإعاقة والغاية 5-2 من أهداف التنمية المستدامة، توصي اللجنة الدولة الطرف بالقضاء على جميع أشكال العنف ضد النساء والفتيات في المجالين العام والخاص، بما في ذلك الاتجار بالبشر والاستغلال الجنسي وغير ذلك من أشكال الاستغلال. وتوصي الدولة الطرف أيضاً بما يلي:‬‬‬‬ ‬‬
                -  (أ) ......، وتنظيم حملات توعية عامة لمكافحة القوالب النمطية ومواقف التحيز والخرافات السائدة عنها؛ 
                -  (ب) التوعية بجميع أشكال التمييز ضد المرأة، والأخذ بوجهات نظر النساء اللواتي يتعهدن أطفالاً من ذوي الإعاقة بالرعاية في السياسات العامة المتعلقة بالتصدي للتمييز الجنساني؛", "", "" },
                    { 781, null, "R75P4", "ت.75.ف.4", "", "Non réalisé", "", 0, 7, null, 7, null, 36, null, "Organes de traités", @"Mettre le système de justice pour mineurs en totale conformité avec la Convention, en particulier avec les articles 37, 39 et 40, ainsi qu’avec d’autres normes applicables et avec l’Observation générale no 10 (2007) du Comité sur les droits de l’enfant dans le système de justice pour mineurs, en particulier:
                d) Assurer le renforcement des capacités et la spécialisation de toutes les parties prenantes dans le système de justice, notamment les magistrats, les agents pénitentiaires et les avocats en ce qui concerne les dispositions de la Convention;", @"تحث اللجنة المملكة لمغربية على التوفيق التام بين نظامها لعدالة الأحداث والاتفاقية، لا سيما المواد 37 و39 و40، وكذلك مع معايير أخرى متصلة بالموضوع ومع تعليق اللجنة العام رقم 10(2007) بشأن حقوق الطفل في قضاء الأحداث. وتحثها خاصة على الآتي:
                -  (د) ضمان بناء قدرات جميع العاملين في سلك القضاء وتخصصهم                 فيما يتعلق بأحكام الاتفاقية، بمن فيهم القضاة وموظفو السجون والمحامون؛", "", "" },
                    { 780, null, "R49P5", "ت.49.ف.5", "", "Non réalisé", "", 0, 7, null, 7, null, 36, null, "Organes de traités", @"Appelant l’attention sur les lignes directrices relatives à la protection de remplacement pour les enfants (résolution 64/142 de l’Assemblée générale, annexe), le Comité demande au Maroc:
                e) De faire en sorte que l’ensemble du personnel des institutions de protection sociale reçoive la formation requise aux droits de l’enfant, notamment à la façon de procéder pour signaler les cas de mauvais traitement, et de fournir toutes les ressources humaines techniques et financières nécessaires pour améliorer la situation des enfants;", @"لفت اللجنة انتباه المملكة المغربية إلى المبادئ التوجيهية للرعاية البديلة للأطفال (مرفق قرار الجمعية العامة 64/142) وحثتها على ما يلي:  
                - (هـ)  ضمان تدريب جميع الموظفين العاملين في المؤسسات تدريباً كافياً في مجال حقوق الطفل، بما في ذلك بشأن الكيفية التي يمكن بها الإبلاغ عن حالات سوء المعاملة، وتوفير جميع الموارد البشرية والتقنية والمالية اللازمة لتحسين أوضاع الأطفال", "", "" },
                    { 779, null, "R35P2", "ت.35.ف.2", "", "Non réalisé", "", 0, 7, null, 7, null, 36, null, "Organes de traités", "…….. dispenser aux agents de la force publique la formation requise aux normes régissant le traitement des enfants qui ont affaire à la justice ou sont en conflit avec la loi……………………", "-          توفير التدريب المناسب لموظفي إنفاذ القانون على قواعد ومعايير معاملة الأطفال الخاضعين لإجراءات قضائية أو المخالفين للقانون", "", "" },
                    { 728, null, "R17P1P2", "ت.17.ف.1.ف.2", "", "Non réalisé", "", 0, 7, null, 6, null, 36, null, "Organes de traités", @"Intensifier ses campagnes de sensibilisation et la formation relative à la nouvelle législation, ainsi qu’aux dispositions de la Convention à l’intention des procureurs, des avocats et des magistrats, de façon à ancrer dans le pays une culture juridique favorisant l’égalité des sexes et la non-discrimination. 

                - Faire mieux connaître aux femmes leurs droits en mettant en place des programmes de vulgarisation et une assistance juridiques s’inscrivant dans la durée.", @"كثيف حملات التوعية والتدريب بشأن التشريعات المعتمدة حديثا، فضلا عن أحكام الاتفاقية، في أوساط المدعين العامين والمحامين والقضاة، كيما يتسنى غرس ثقافة قانونية مساندة لمساواة المرأة مع الرجل وعدم التمييز 
                -زيادة تثقيف النساء بحقوقهن عن طريق تنفيذ برامج مستديمة لمحو الأمية القانونية وتقديم المساعدة القانونية. وتشجع اللجنة الدولة الطرف على مواصلة ما تقوم به من إصلاحات بالتشاور مع المجتمع المدني. ولا سيما المنظمات النسائية.", "", "" },
                    { 647, null, "R12P4", "ت.12.ف.4", "", "Non réalisé", "", 0, 7, null, null, null, 36, null, "Organes de traités", "-            d)  Mener des campagnes de sensibilisation auprès des responsables politiques, des magistrats, des 32aires et des fonctionnaires sur la nécessité d’appliquer strictement la loi anticorruption et de tendre vers son élimination complète.", "-(د) تنظيم حملات توعية في أوساط المسؤولين السياسيين والقضاة والبرلمانيين والموظفين بشأن ضرورة تطبيق قانون محاربة الرشوة تطبيقاً صارماً والسعي إلى القضاء عليها قضاء تاماً.", "", "" },
                    { 646, null, "R10P3", "ت.10.ف.3", "", "Non réalisé", "", 0, 7, null, null, null, 36, null, "Organes de traités", "-            Mener des campagnes de sensibilisation auprès des juges, des avocats et de la population en général sur les dispositions du Pacte et sur sa primauté sur les lois internes permettant son application directe.", "-          تنظيم حملات توعية في أوساط القضاة والمحامين وعامة الجمهور بشأن أحكام العهد، وأولويته على التشريعات المحلية بما يسمح تطبيقه على نحو مباشر. وتوجه اللجنة انتباه الدولة الطرف إلى تعليقها العام رقم 9(1998) بشأن التطبيق المحلي للعهد.", "", "" },
                    { 609, null, "R36P5", "ت.36.ف.5", "", "Non réalisé", "", 0, 7, null, 3, null, 36, null, "Organes de traités", "e) prévenir et éliminer le recours excessif à la force par les agents des forces de l’ordre en renforçant notamment les formations à cet égard (migrants et demandeurs asil) ;", "-          (ه) منع لجوء قوات الأمن في استخدام القوة المفرطة و التخلص من هذه الممارسة، لا سيما بتدعيم التدريب في هذا الصدد", "", "" },
                    { 608, null, "R6P1", "ت.6.ف.1", "", "Non réalisé", "", 0, 7, null, null, null, 36, null, "Organes de traités", "Poursuivre les efforts pour sensibiliser les juges, les avocats, les procureurs et autres personnes participant à l’administration de la justice aux dispositions du Pacte, de sorte que celles-ci soient prises en compte devant et par les tribunaux nationaux.", "-          مواصلة الجهود لتوعية القضاة والمحامين والمدعين العامين وغيرهم من المعنيين بإقامة العدل بأحكام العهد بحيث تراعَى هذه الأحكام أمام المحاكم وتراعيها المحاكم.", "", "" },
                    { 566, null, "R28", "ت.28", "", "Non réalisé", "", 0, 7, null, 2, null, 36, null, "Organes de traités", @"Continuer à concevoir des programmes de formation, et à renforcer ces derniers, pour que tous les fonctionnaires – forces de l’ordre, services de renseignement, agents de sécurité, militaires, personnel pénitentiaire et personnel médical des prisons ou des hôpitaux psychiatriques – connaissent bien les dispositions de la Convention; que les violations signalées ne soient pas tolérées; que ces violations donnent lieu à des enquêtes et que les auteurs soient poursuivis. 
                - S’assurer que tous les personnels concernés, y compris les membres du corps médical, apprennent à détecter les signes de torture et de mauvais traitements grâce à des formations spécifiques s’appuyant sur le Manuel pour enquêter efficacement sur la torture et autres peines ou traitements cruels, inhumains ou dégradants (Protocole d’Istanbul). 
                - évaluer l’efficacité et l’incidence de ces programmes de formation et de cet enseignement", @"مواصلة وضع برامج التدريب، وتعزيز تلك البرامج ليتسنى لجميع الموظفين - العاملين ضمن قوات إنقاذ القانون، وأجهزة الاستخبارات، وأفراد الأمن، والعسكريين، وموظفي السجون، وموظفي القطاع الطبي العاملين في السجون أوفي مستشفيات الأمراض النفسانية - من معرفة أحكام الاتفاقية تمام المعرفة، ولكيلا يُتسامح في أمر الانتهاكات التي يبلغ عنها، وأن يحقق في ِشأن تلك الانتهاكات، وأن يلاحَق مرتكبوها قضائياً. وعلاوة على ذلك، 
                - التأكد من تعلّم جميع الموظفين المعنيين، بمن فيهم الطواقم الطبية، كيفية كشف علامات التعذيب وسوء المعاملة عن طريق تنظيم دورات خاصة تعتمد على دليل التحري والتوثيق الفعالين بشأن التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة (بروتوكول اسطنبول). وأخيراً، ينبغي أن تقيّم الدولة الطرف فعالية وتأثير هذه البرامج التدريبية وهذا التعليم.", "", "" },
                    { 507, null, "R20P1", "ت.20.ف1", "", "Non réalisé", "", 0, 7, null, 1, null, 36, null, "Organes de traités", "Accentue ses efforts de formation aux droits de l’homme, en particulier à la lutte contre la discrimination raciale, de même que ses efforts de sensibilisation à la tolérance, à l’entente interraciale ou interethnique et aux relations interculturelles auprès des agents chargés de l’application des lois, notamment des personnels de police et de gendarmerie, de la justice, de l’administration pénitentiaire, des avocats, ainsi que des enseignants.", "- بذل مزيد من الجهود للتدريب على حقوق الإنسان، وخاصة على مكافحة التمييز العنصري، ومزيد من جهود التحسيس كذلك في صفوف الموظفين المكلفين بإنفاذ القوانين، ولا سيما العاملين في الشرطة والدرك والقضاء وإدارة السجون، وفي صفوف المحامين والمدرِّسين، بقيم التسامح والوئام بين الأعراق أو الإثنيات والعلاقات بين الثقافات.", "", "" },
                    { 855, null, "R27P3", "ت.27.ف.3", "", "Non réalisé", "", 0, 7, null, 8, null, 36, null, "Organes de traités", "Concevoir des programmes de renforcement des capacités à l’intention des fonctionnaires concernant le droit des personnes handicapées à la reconnaissance de leur personnalité juridique dans des conditions d’égalité et le système de prise de décisions assistée, et de sensibiliser les personnes handicapées, leur famille et la société à ce droit et à ce système.", "تماشياً مع التعليق العام رقم 1(2014) بشأن الاعتراف بالأشخاص ذوي الإعاقة على قدم المساواة مع الآخرين أمام القانون، توصي اللجنة بما يلي:", "", "" },
                    { 650, null, "R30P3", "ت.30.ف.3", "", "Non réalisé", "", 0, 8, null, null, null, 37, null, "Organes de traités", "-            Mettre sur pied un mécanisme d’inspection pour contrôler les conditions de travail des employés de maison.", "-          نشاء آلية تفتيش لرصد ظروف عمل العمال المنزليين.", "", "" },
                    { 651, null, "R32P2", "ت.32.ف.2", "", "Non réalisé", "", 0, 8, null, null, null, 37, null, "Organes de traités", "-            Prendre des mesures pour que les victimes (Harcèlement sexuel, notamment dans le milieu du travail) puissent déposer plainte sans craindre des représailles et aient accès aux voies de recours et à une réparation adéquate.", "-          اتخاذ جميع التدابير التي تمكن ضحايا التحرش الجنسي لا سيما في مكان العمل من تقديم شكاوى دون خوف من الانتقام، ومن الوصول إلى سبل الانتصاف والحصول على الجبر المناسب.", "", "" },
                    { 688, null, "R20P4", "ت.20.ف4", "", "Non réalisé", "", 0, 7, null, 5, null, 37, null, "Organes de traités", "Mener des campagnes de sensibilisation et d’éducation au sujet de toutes les formes de discrimination raciale.", "تنظيم حملات توعية وتثقيف في هذا المجال.", "", "" },
                    { 228, null, "R86P5", "ت.86.ف.5", "", "Non réalisé", "", 0, 5, null, null, null, 25, 8, "Procédure spéciale", "Revoir ses pratiques en matière d’enregistrement des associations afin d’assurer le respect intégral du droit à la liberté d’association, sans aucune discrimination", "(ﻫ) استعراض الممارسات المتصلة بتسجيل الجمعيات من أجل ضمان الاحترام التام للحق في حرية تكوين الجمعيات، دون أي تمييز؛", "", "" },
                    { 866, null, "R63P1P2", "ت.63.ف.1.ف.2", "", "Non réalisé", "", 0, 7, null, 8, null, 37, null, "Organes de traités", @"a) préciser le rôle de la commission interministérielle chargée d’appuyer la mise en œuvre de la Convention et celui des différents points de contact et, en particulier, d’adopter des mesures visant à renforcer l’efficacité de la commission et des points de contact ;
                b) mettre en place un mécanisme et un système de points de contact aux niveaux régional et local pour mettre en œuvre la Convention ;", @"(أ) تحديد أدوار اللجنة الوزارية المكلفة بدعم تنفيذ الاتفاقية وأدوار جهات التنسيق المعنية، والقيام، على وجه الخصوص، باعتماد تدابير ترمي إلى تعزيز كفاءة اللجنة وجهات التنسيق؛
                -  (ب) وضع آلية ونظام لجهات التنسيق على الصعيدين الإقليمي والمحلي من أجل تنفيذ الاتفاقية؛", "", "" },
                    { 865, null, "R35P3", "ت.35.ف. 3", "", "Non réalisé", "", 0, 7, null, 8, null, 37, null, "Organes de traités", "Mettre en place un mécanisme indépendant chargé de protéger les personnes handicapées contre les actes de violence et les mauvais traitements, de contrôler, conformément au paragraphe 3 de l’article 16 de la Convention, les établissements et programmes destinés aux personnes handicapées et de fournir les ressources budgétaires nécessaires pour que ces établissements et programmes soient fonctionnels et efficaces.", "-       (ج) إنشاء آلية مستقلة لمنع تعرض الأشخاص ذوي الإعاقة للعنف والاعتداء؛ ورصد المرافق والبرامج المعدة لخدمة الأشخاص ذوي الإعاقة، تماشياً مع المادة 16(3) من الاتفاقية؛ ورصد المخصصات اللازمة في الميزانية لضمان تشغيل هذه المرافق وفعاليتها.", "", "" },
                    { 864, null, "R33P4", "ت.33.ف.4", "", "Non réalisé", "", 0, 7, null, 8, null, 37, null, "Organes de traités", "Habiliter le Conseil national des droits de l’homme, en sa qualité de mécanisme national de prévention, à surveiller tous les lieux dans lesquels les personnes handicapées peuvent être privées de liberté, en application du Protocole facultatif se rapportant à la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants.", "-           (ج) تمكين المجلس الوطني لحقوق الإنسان، بوصفه الآلية الوقائية الوطنية، من رصد جميع الأماكن التي يمكن أن يُسلَب فيها الأشخاص ذوو الإعاقة حريتهم، تماشياً مع البروتوكول الاختياري لاتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة.", "", "" },
                    { 863, null, "R29P2P4", "ت.29.ف.2.ف.4", "", "Non réalisé", "", 0, 7, null, 8, null, 37, null, "Organes de traités", @"b) Prévoir, au sein du secteur judiciaire, des aménagements effectifs à la procédure en faveur des personnes handicapées, en fonction de leur sexe et de leur âge ;
                d) Prendre les mesures qui s’imposent pour soutenir les personnes handicapées et leur donner les moyens de travailler dans le système de justice, notamment en qualité de juges ou de procureurs, en leur apportant tout l’appui nécessaire, afin d’améliorer l’accès des personnes handicapées à la justice.", @"(ب) توفير ترتيبات إجرائية فعالة، داخل القضاء، للأشخاص ذوي الإعاقة، بحسب نوع الجنس والسن؛ 
                - (ج) ضمان استمرارية برامج التدريب وحملات التوعية والإعلام التي تستهدف موظفي المحاكم والقضاة والمدعين العامين والموظفين المكلفين بإنفاذ القوانين، بمن فيهم أفراد الشرطة وموظفو السجون، بشأن ضرورة تيسير إمكانية اللجوء إلى القضاء للأشخاص ذوي الإعاقة؛", "", "" },
                    { 862, null, "R27P2", "ت.27.ف.2", "", "Non réalisé", "", 0, 7, null, 8, null, 37, null, "Organes de traités", "Instituer et développer, à l’intention des personnes handicapées, des mécanismes de prise de décisions assistée qui respectent leur autonomie, leurs droits, leur volonté et leurs préférences, dans tous les domaines", "تماشياً مع التعليق العام رقم 1(2014) بشأن الاعتراف بالأشخاص ذوي الإعاقة على قدم المساواة مع الآخرين أمام القانون، توصي اللجنة بما يلي: (ب) استحداث وتطوير آليات لتقديم الدعم للأشخاص ذوي الإعاقة في اتخاذ القرارات تحترم استقلاليتهم وحقوقهم وإرادتهم وأفضلياتهم في جميع مجالات الحياة؛", "", "" },
                    { 861, null, "R23P2", "ت.23.ف2", "", "Non réalisé", "", 0, 7, null, 8, null, 37, null, "Organes de traités", "b) De mettre en place un mécanisme visant à contrôler le respect des normes d’accessibilité dans tous les domaines visés par la Convention, de veiller au respect de la loi no 10-03 relative aux accessibilités et d’infliger des sanctions en cas de non-respect", "-          (ب) وضع آلية لرصد الامتثال لمعايير تيسير إمكانية الوصول في جميع المجالات التي تشملها الاتفاقية، وضمان إنفاذ القانون 10-03 المتعلق بالولوجيات وفرض جزاءات في حالة عدم الامتثال للقانون؛", "", "" },
                    { 860, null, "R19", "ت.19", "", "Non réalisé", "", 0, 7, null, 8, null, 37, null, "Organes de traités", "Instituer un mécanisme permettant d’assurer une concertation effective avec les enfants handicapés, par l’intermédiaire des organisations qui les représentent, et de veiller à ce que les enfants handicapés soient pleinement intégrés au forum national des enfants, au 32de l’enfant et dans les conseils des enfants à l’échelle des municipalités et des gouvernorats, dans des conditions d’égalité avec les autres enfants.", "-      اعتماد آلية لإجراء مشاورات فعلية مع الأطفال ذوي الإعاقة من خلال المنظمات التي تمثلهم، وبضمان الإدماج الكامل للأطفال ذوي الإعاقة في المنتدى الوطني للأطفال، وبرلمان الطفل ومجالس الطفولة في المحافظات والمجالس البلدية، على قدم المساواة مع غيرهم من الأطفال.", "", "" },
                    { 859, null, "R68", "ت.68", "", "Non réalisé", "", 0, 7, null, 8, null, 37, null, "Organes de traités", "-Diffuser largement les présentes observations finales, notamment auprès des organisations non gouvernementales et des organisations de personnes handicapées, ainsi qu’auprès des personnes handicapées elles-mêmes et de leurs proches, dans les langues nationales et minoritaires, notamment en langue des signes, et sous des formes accessibles. Il lui demande aussi de les diffuser sur le site Web public consacré aux droits de l’homme.", "نشر هذه الملاحظات الختامية على نطاق واسع، بما يشمل المنظمات غير الحكومية ومنظمات الأشخاص ذوي الإعاقة، والأشخاص ذوي الإعاقة أنفسهم وأفراد أسرهم، باللغات الوطنية ولغات الأقليات، بما في ذلك لغة الإشارة، وفي أشكال يسهل الاطلاع عليها، وإتاحتها في موقع الحكومة الشبكي المتعلق بحقوق الإنسان.", "", "" },
                    { 858, null, "R37P2", "ت.37.ف.2", "", "Non réalisé", "", 0, 7, null, 8, null, 37, null, "Organes de traités", "Sensibiliser la population aux effets néfastes de ces pratiques et de renforcer les mécanismes visant à garantir que le consentement éclairé des personnes handicapées soit obtenu pour les traitements médicaux et chirurgicaux.", "-      .إذكاء الوعي بشأن مضار هذه الممارسات وبتعزيز الآليات الرامية إلى ضمان موافقة الأشخاص ذوي الإعاقة، موافقة مستنيرة، على أي علاج طبي أو جراحي.", "", "" },
                    { 789, null, "R77P2", "ت.77.ف.2", "", "Non réalisé", "", 0, 7, null, 7, null, 37, null, "Organes de traités", "-                        Diffuser largement dans les langues du pays les troisième et quatrième rapports périodiques, les réponses écrites du Maroc et les présentes observations finales.", "إشاعة التقرير الجامع للتقريرين الدوريين الثالث والرابع والردود الخطية الملاحظات الختامية ، بلغات البلد،.", "", "" },
                    { 788, null, "R53P5", "ت.53.ف.5", "", "Non réalisé", "", 0, 7, null, 7, null, 37, null, "Organes de traités", @"Adopter une approche du handicap fondée sur les droits de l’homme et recommande en particulier
                e) D’entreprendre des campagnes de sensibilisation destinées aux autorités, au public et aux familles pour combattre la stigmatisation des enfants handicapés et les préjugés à leur égard et promouvoir une image positive des enfants et des adultes handicapés.", @"تحث اللجنة المملكة المغربية، في ضوء المادة 23 من الاتفاقية وتعليقها العام     رقم 9(2006) بشأن حقوق الأطفال ذوي الإعاقة، على انتهاج نهج يقوم على حقوق الإنسان في التعاطي مع الإعاقة، وتوصيها بالآتي تحديداً: 
                -  (هـ) تنظيم حملات توعية موجهة إلى الحكومة والأسر والناس عامة لمكافحة الوصم والتحامل على الأطفال ذوي الإعاقة، وتقديم صورة إيجابية عن الأطفال والبالغين ذوي الإعاقة.", "", "" },
                    { 787, null, "R47P3", "ت.47.ف.3", "", "Non réalisé", "", 0, 7, null, 7, null, 37, null, "Organes de traités", "Eliminer la stigmatisation associée aux grossesses hors mariage et prendre des mesures concrètes devraient pour promouvoir une parenté et un comportement sexuel responsables en accordant une attention particulière à la sensibilisation des garçons et des hommes.", @"كافحة الوصم المقترن بالحمل خارج إطار الزواج والقضاء عليه. 
                - اتخاذ تدابير فاعلة لإذكاء الوعي بالمسؤولية الوالدية والسلوك الجنسي المسؤول، مع إيلاء اهتمام خاص لتوعية الفتيان والرجال.", "", "" },
                    { 786, null, "R41P3", "ت.41.ف.3", "", "Non réalisé", "", 0, 7, null, 7, null, 37, null, "Organes de traités", "Exécuter des activités de sensibilisation pour combattre la stigmatisation des victimes d’exploitation et d’abus sexuels, notamment d’inceste, et de mettre en place des mécanismes accessibles, confidentiels, adaptés aux enfants et efficaces pour dénoncer de telles violations.", "تنفيذ أنشطة للتوعية من أجل مكافحة وصم ضحايا الاستغلال والاعتداء الجنسيين، بما في ذلك زنى المحارم، وتوفير قنوات ميسّرة وسرية وفعالة ومواتية للأطفال للإبلاغ عن تلك الانتهاكات.", "", "" },
                    { 785, null, "R39P5P7", "ت.39.ف.5.ف.7", "", "Non réalisé", "", 0, 7, null, 7, null, 37, null, "Organes de traités", @"Tenir compte de l’Observation générale no 13 (2011) sur le droit de l’enfant d’être protégé contre toutes les formes de violence, et en particulier de mettre en place, en étroite coopération avec la société civile, un système de protection des enfants bien coordonné et bien financé, en particulier:
                e) Renforcer davantage les programmes de sensibilisation et d’éducation, notamment les campagnes organisées avec la participation des enfants en vue d’informer ces derniers des mécanismes de protection auxquels ils peuvent avoir accès;
                g) Faire face aux causes profondes de la violence et des sévices et prendre des mesures concrètes pour changer les attitudes, les traditions, les coutumes et les comportements qui souvent servent de prétexte à la pratique de la violence dans la famille, en particulier à l’égard des filles.", @"الأخذ في الحسبان التعليق العام رقم 13(2011) بشأن حق الطفل في التحرر من جميع أشكال العنف، ووضع نظام لحماية الطفل منسق تنسيقاً جيداً وممولاً تمويلاً كافياً بتعاون وثيق مع المجتمع المدني والاضطلاع بما يلي خاصةً:
                -  (هـ) مواصلة الارتقاء بمستوى برامج التوعية والتثقيف، بسبل منها تنظيم حملات يشارك فيها الأطفال من أجل إعلام الأطفال بآليات الحماية التي يمكنهم اللجوء إليها؛ 
                -  (ز) اجتثاث جذور العنف وإساءة المعاملة، واتخاذ تدابير عملية لتغيير المواقف والتقاليد والعادات والسلوكيات التي تبرر في الغالب العنف المنزلي، خاصة على الفتيات", "", "" },
                    { 784, null, "R37P3", "ت.37.ف.3", "", "Non réalisé", "", 0, 7, null, 7, null, 37, null, "Organes de traités", @"Renvoyant à son Observation générale no 8 (2006) relative aux droits de l’enfant et à une protection contre les châtiments corporels et les autres formes cruelles ou dégradantes de châtiment, le Comité invite le Maroc à:
                c) Organiser des campagnes publiques soutenues d’éducation, de sensibilisation et de mobilisation sociale associant les enfants, les familles, les collectivités et les chefs religieux sur les effets physiques et psychologiques néfastes des châtiments corporels en vue de faire évoluer les mentalités à l’égard de cette pratique et de promouvoir des formes d’éducation et de discipline constructives non violentes et participatives en remplacement des châtiments corporels;", @"ففي ضوء تعليق اللجنة العام رقم 8(2006) بشأن حق الطفل في الحماية من العقوبة البدنية وغيرها من ضروب العقوبة القاسية أو المهينة، تحث اللجنة الدولة المملكة المغربية على ما يلي: 
                -  (ج) وضع برامج مستمرة للتثقيف العام والتوعية والتعبئة الاجتماعية عن الأضرار البدنية والنفسية المترتبة على العقوبة البدنية يشارك فيها الأطفال، والأسر، والمجتمعات المحلية، والقيادات الدينية، بهدف تغيير الموقف العام من هذه الممارسة وتشجيع أشكال إيجابية وخالية من العنف وقائمة على المشاركة لتنشئة الأطفال تكون بديلاً للعقوبة البدنية", "", "" },
                    { 783, null, "R29P2", "ت.29.ف.2", "", "Non réalisé", "", 0, 7, null, 7, null, 37, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 12 (2009) sur le droit de l’enfant d’être entendu et lui recommande:
                b) D’exécuter des programmes et des activités de sensibilisation en vue de promouvoir une participation active et autonome de tous les enfants à la vie de la famille, de la collectivité et de l’école, notamment dans le cadre des conseils d’élèves, en accordant une attention particulière aux filles et aux enfants vulnérables.", @"تلفت اللجنة انتباه الدولة الطرف إلى تعليقها العام رقم 12(2009) بشأن حق الطفل في أن يُستمع إليه، وتوصيها بالآتي: 
                - (ب) تنفيذ برامج وأنشطة توعية لتشجيع مشاركة جميع الأطفال الجادة والقوية داخل الأسرة والمجتمع والمدرسة، بما في ذلك داخل هيئات مجالس التلاميذ، مع إيلاء اهتمام خاص للفتيات والأطفال المستضعفين", "", "" },
                    { 782, null, "R23P3", "ت.23.ف.3", "", "Non réalisé", "", 0, 7, null, 7, null, 37, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 16 (2013) sur les obligations des États concernant les incidences du secteur des entreprises sur les droits de l’enfant et, en particulier, lui recommande :
                c) D’entreprendre des campagnes de sensibilisation auprès du secteur du tourisme et du grand public à la prévention du tourisme pédophile et de diffuser largement la Charte d’honneur pour le tourisme et le code mondial d’éthique du tourisme de l’Organisation mondiale du tourisme auprès des agences de voyages et du secteur du tourisme;", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 16(2013) بشأن التزامات الدولة المتعلقة بالآثار التي يحدثها قطاع الأعمال على حقوق الأطفال، وتوصيها خاصة بالآتي: 
                - (ج) تنظيم حملات توعية بمشاركة قطاع السياحة وعامة الناس عن منع سياحة الجنس مع الأطفال، وإشاعة ميثاق الشرف للعاملين في السياحة والمدونة العالمية لأخلاقيات السياحة التي وضعتها منظمة السياحة العالمية بين وكلاء السفر وفي قطاع السياحة؛", "", "" },
                    { 734, null, "R52", "ت.52", "", "Non réalisé", "", 0, 7, null, 6, null, 37, null, "Organes de traités", @"Les présentes observations finales doivent être largement diffusées la population du pays, en particulier les membres de l’administration et les responsables politiques, soit au courant des mesures prises pour assurer l’égalité de droit et de fait entre les sexes et sache quelles mesures restent à prendre à cet égard. 
                - Diffuser largement, surtout auprès des associations féminines et des organisations de défense des droits de l’homme, le texte de la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes et de son Protocole facultatif; les recommandations générales du comité; la Déclaration et le Programme d'action de Beijing; et les textes issus de la vingt-troisième session extraordinaire de l’Assemblée générale, intitulée  « Les femmes en l’an 2000 : égalité entre les sexes, développement et paix pour le XXIe siècle ».", @"نشر الملاحظات الختامية على أوسع نطاق ممكن من أجل توعية الشعب المغربي، ولا سيما المديرين الحكوميين والسياسيين، بالخطوات التي اتخذت لكفالة المساواة بين المرأة والرجل قانونيا وفعليا، وبالخطوات التي يتعين اتخاذها مستقبلا في هذا الصدد. 
                -مواصلة نشر اتفاقية القضاء على جميع أشكال التمييز ضد المرأة والبروتوكول الاختياري الملحق بها، على أوسع نطاق، لا سيما بين المنظمات النسائية ومنظمات حقوق الإنسان؛ وكذلك التوصيات العامة للجنة المعنية بالقضاء على التمييز ضد المرأة؛ وإعلان ومنهاج عمل بيجين؛ ونتائج الدورة الاستثنائية الثالثة والعشرين للجمعية العامة المعنونة ”المرأة عام 2000: المساواة بين الجنسين والتنمية والسلام في القرن الحادي والعشرين“.", "", "" },
                    { 733, null, "R31P2", "ت.31.ف.2", "", "Non réalisé", "", 0, 7, null, 6, null, 37, null, "Organes de traités", "Multiplier les campagnes de sensibilisation à l’importance des soins de santé, en y incluant des informations sur la propagation des maladies sexuellement transmissibles et du VIH/sida ainsi que sur la prévention des grossesses non désirées grâce à la planification familiale et à l’éducation sexuelle.", "توصي اللجنة، في ضوء توصيتها العامة رقم 24، بأن تزيد الدولة من حملات التوعية بأهمية الرعاية الصحية ويشمل ذلك المعلومات المتعلقة بانتشار الأمراض التي تنتقل عن طريق الاتصال الجنسي والإصابة بفيروس نقص المناعة البشرية/الإيدز والمعلومات المتصلة بمنع الحمل غير المرغوب فيه من خلال تنظيم الأسرة والتثقيف الجنسي.", "", "" },
                    { 732, null, "R27P5", "ت.27.ف.5", "", "Non réalisé", "", 0, 7, null, 6, null, 37, null, "Organes de traités", "Sensibiliser l’opinion à l’importance de l’éducation en tant que droit fondamental et condition de l’autonomisation des femmes et à prendre des mesures pour modifier les attitudes traditionnelles qui tendent à perpétuer la discrimination.", "-رفع مستوى الوعي عموما بأهمية التعليم كحق من حقوق الإنسان وكأساس لتمكين المرأة، وعلى اتخاذ خطوات للتغلب على أنماط السلوك التقليدية التي تعمل على استدامة التمييز", "", "" },
                    { 731, null, "R25P3", "ت.25.ف.3", "", "Non réalisé", "", 0, 7, null, 6, null, 37, null, "Organes de traités", "Lancer des campagnes d’information pour attirer l’attention sur l’importance de la participation des femmes à la prise de décisions dans l’ensemble de la société, y compris dans les secteurs public et privé.", "الاضطلاع بحملات لإذكاء الوعي بشأن الأهمية التي تكتسبها مشاركة المرأة في عملية اتخاذ القرار بالنسبة للمجتمع بأسره، بما في ذلك في القطاعين العام والخاص.", "", "" },
                    { 730, null, "R19", "ت.19", "", "Non réalisé", "", 0, 7, null, 6, null, 37, null, "Organes de traités", @"S’attaquer aux stéréotypes concernant le rôle et les responsabilités des femmes et des hommes dans la famille et la société, notamment les schémas et normes cachés qui perpétuent la discrimination directe et indirecte à l’égard des femmes et des filles dans tous les domaines de la vie.
                - Redoubler d’efforts dans la conception et l’application de programmes complets de sensibilisation visant à favoriser une meilleure compréhension de l’égalité entre les hommes et les femmes à tous les échelons de la société afin de modifier les comportements stéréotypés et les normes culturelles négatives relatives au rôle des femmes et des hommes dans la famille et dans la société, conformément à l’article 5 a) de la Convention. 
                - Inciter les médias à donner une image favorable des femmes et à promouvoir l’égalité de statut et de responsabilités des femmes et des hommes dans la société", @"معالجة المواقف النمطية تجاه الأدوار والمسؤوليات المنوطة بالنساء والرجال، بما في ذلك الأنماط والأعراف الثقافية الخفية التي تعمل على إدامة التمييز المباشر وغير المباشر ضد المرأة والفتاة في كافة مناحي الحياة. 
                -مضاعفة جهودها الرامية إلى تصميم وتنفيذ برامج توعية شاملة لتحسين فهم المساواة بين المرأة والرجل على جميع مستويات المجتمع، وذلك بغرض تغيير المواقف النمطية والأعراف الثقافية السلبية بشأن المسؤوليات والأدوار المنوطة بالنساء والرجال في الأسرة والمجتمع، عملا بالمادة 5 (أ) من الاتفاقية. 
                -تشجيع وسائط الإعلام على تقديم صورة إيجابية عن المرأة وعن تكافؤ المركز والمسؤوليات بين المرأة والرجل في المجتمع", "", "" },
                    { 729, null, "R13P2", "ت.13.ف.2", "", "Non réalisé", "", 0, 7, null, 6, null, 37, null, "Organes de traités", "Diffuser largement le texte de la Convention et de les recommandations générales auprès de toutes les parties prenantes, y compris les ministères, les 32aires, les autorités judiciaires, les partis politiques, les organisations non gouvernementales, le secteur privé et le public en général.", "-نشر الاتفاقية وتوصياتها العامة على أوسع نطاق بين جميع أصحاب المصلحة، بما في ذلك الوزارات الحكومية وأعضاء البرلمان والسلطات القضائية، والأحزاب السياسية والمنظمات غير الحكومية والقطاع الخاص وعامة الجمهور.", "", "" },
                    { 691, null, "R46", "ت.46", "", "Non réalisé", "", 0, 8, null, 5, null, 37, null, "Organes de traités", "S’assurer que les autorités consulaires ou diplomatiques fournissent des renseignements et une aide appropriée aux travailleurs migrants marocains et aux membres de leurs familles vivant à l’étranger, y compris ceux en situation irrégulière.", "كفالة  تقديم السلطات القنصلية أو الدبلوماسية معلومات ومساعدة مناسبة إلى العمال المهاجرين المغاربة وأفراد أسرهم المقيمين بالخارج، بمن فيهم الموجودون في وضع غير قانوني.", "", "" },
                    { 690, null, "R32P2", "ت.32.ف.2", "", "Non réalisé", "", 0, 8, null, 5, null, 37, null, "Organes de traités", "Créer des mécanismes de surveillance qui garantissent que les reconduites à la frontière des migrants sont faites dans le strict respect des normes internationales relatives aux migrants.", "إنشاء آليات مراقبة تكفل تنفيذ عمليات إعادة المهاجرين إلى الحدود في إطار تقيد صارم بالقواعد الدولية المتعلقة بالمهاجرين.", "", "" },
                    { 689, null, "R51", "ت.51", "", "Non réalisé", "", 0, 7, null, 5, null, 37, null, "Organes de traités", "diffuser largement les présentes observations finales, notamment auprès des organismes publics et du pouvoir judiciaire, des organisations non gouvernementales et autres membres de la société civile, et de prendre des mesures pour les faire connaître aux migrants marocains à l’étranger ainsi qu’aux travailleurs migrants étrangers en transit ou résidant au Maroc.", "تعميم الملاحظات الختامية على نطاق واسع، لا سيما على المؤسسات العامة والسلطة القضائية والمنظمات غير الحكومية وجهات المجتمع المدني الأخرى، واعتماد تدابير من أجل إطلاع المهاجرين المغاربة في الخارج والعمال المهاجرين الأجانب العابرين للمغرب أو المقيمين به على هذه الملاحظات.", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 451, null, "R144.66", "66.144", "", "Non réalisé", "", 0, 7, 1, null, 76, 36, null, "Examen périodique universal", "Promouvoir l’éducation et la formation des agents de la 21 aux droits de l’homme, en veillant à la fourniture des ressources nécessaires, à tous les niveaux. Les employés de l’administration à l’échelon local, qui ont l’influence la plus directe sur la population, manquent le plus souvent de formation aux droits de l’homme ou des ressources nécessaires pour satisfaire aux normes internationales sur les droits de l’homme", "تعزيز التثقيف في ميدان حقوق الإنسان وتدريب الموظفين العموميين، إلى جانب التزويد بالموارد الضرورية على جميع المستويات. فموظفو الحكومات المحلية، الذين لهم الأثر الأكثر مباشرَة على الناس، كثيراً ما يفتقرون إلى تدريب في ميدان حقوق الإنسان أو إلى الموارد لتلبية المعايير الدولية في ميدان حقوق الإنسان", "", "" },
                    { 450, null, "R144.65", "65.144", "", "Non réalisé", "", 0, 7, 1, null, 54, 36, null, "Examen périodique universal", "Continuer de former les fonctionnaires aux droits de l’homme", "مواصلة تدريب المسؤولين العموميين على حقوق الإنسان", "", "" },
                    { 449, null, "R144.64", "64.144", "", "Non réalisé", "", 0, 7, 1, null, 9, 36, null, "Examen périodique universal", "Poursuivre l’expérience positive consistant à organiser des programmes de renforcement des capacités en matière de droits de l’homme à l’intention des organismes chargés de faire respecter la loi", "مواصلة التجربة الإيجابية المتمثلة في تنظيم برامج لبناء القدرات في ميدان حقوق الإنسان لفائدة وكالات إنفاذ القانون", "", "" },
                    { 247, null, "R74P3", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 8, "Procédure spéciale", "Dans le cadre de leur partenariat, prévoir à l’intention de la société civile et des collectivités des activités d’éducation, de formation et de renforcement des capacités dans le domaine des droits de l’homme, afin de leur permettre d’être de véritables acteurs de leur propre développement.", "null", "", "" },
                    { 445, null, "R144.108", "108.144", "", "Non réalisé", "", 0, 6, 1, null, 44, 35, null, "Examen périodique universal", "Renforcer ses mécanismes nationaux et la coopération internationale pour lutter contre la traite des êtres humains et, en particulier, le tourisme sexuel impliquant des enfants", "تقوية آلياته الوطنية والتعاون الدولي على مكافحة الاتجار بالأشخاص ولا سيما سياحة الجنس التي يُستخدم فيها أطفال", "", "" },
                    { 143, null, "R99P2-2", "null", "", "Non réalisé", "", 0, 6, null, null, null, 35, 4, "Procédure spéciale", "En ce qui les provinces marocaines du sud :- b) …..prendre de nouvelles mesures pour réduire la vulnérabilité des victimes potentielles de la traite assurer une protection adéquate aux migrants et aux membres de leur famille", "null", "", "" },
                    { 142, null, "R93", "null", "", "Non réalisé", "", 0, 6, null, null, null, 35, 4, "Procédure spéciale", "-    Les peines et les sanctions infligées aux personnes qui se rendent coupables de travail forcé devraient être plus lourdes, de façon à dissuader les trafiquants qui recrutent à cette fin.", "null", "", "" },
                    { 141, null, "R91", "null", "", "Non réalisé", "", 0, 6, null, null, null, 35, 4, "Procédure spéciale", "Redoubler les efforts pour poursuivre les trafiquants tout en garantissant leur droit à un procès équitable dans le cadre d’une approche de la justice pénale fondée sur les droits de l’homme, et pour établir le cadre juridique et les procédures nécessaires en vue d’assurer la protection des victimes et des témoins. - En ce qui concerne les Marocains vivant à l’étranger, le Gouvernement devrait définir et mettre en œuvre des mesures judiciaires efficaces pour protéger les Marocaines prises au piège des réseaux de prostitution à l’étranger.", "null", "", "" },
                    { 778, null, "R63", "ت.63", "", "Non réalisé", "", 0, 6, null, 7, null, 34, null, "Organes de traités", @"Le Comité recommande à l’État partie d’accélérer l’adoption d’un cadre juridique et institutionnel pour assurer le respect, en toutes circonstances, des droits des enfants migrants, des enfants demandeurs d’asile et des enfants réfugiés non accompagnés, conformément au droit international relatif aux réfugiés et aux droits de l’homme. 
                L’État partie devrait veiller à ce que :
                a) Les enfants migrants, réfugiés et demandeurs d’asile ne soient pas arrêtés, détenus arbitrairement et renvoyés en violation de la loi ;
                b) Une enquête pour déterminer les responsabilités dans le renvoi de cinq enfants dans le désert en 2013 soit menée, des sanctions soient prises contre les responsables et des mesures soient adoptées pour prévenir qu’une telle situation ne se reproduise ;
                c) Des mesures soient prises rapidement pour assurer aux enfants migrants, réfugiés et demandeurs d’asile un meilleur accès aux services de protection se trouvant dans les hôpitaux et pour améliorer la situation sanitaire dans le Centre d’accueil pour migrants.", @"توصي اللجنة المملكة المغربية بأن تعجل باعتماد إطار قانوني ومؤسسي يكفل احترام حقوق الأطفال بلا مرافق والمهاجرين وملتمسي اللجوء واللاجئين في كل الأحوال وفقاً للقانون الدولي للاجئين ولحقوق الإنسان. وينبغي للدولة الطرف أن تكفل ما يلي:
                -  (أ) عدم انتهاكها القانون بالقبض على الأطفال اللاجئين وملتمسي اللجوء واحتجازهم تعسفاً وطردهم؛
                - (ب) إجراء تحقيق لتحديد المسؤوليات عن طرد 5 أطفال في الصحراء في عام 2013، ومعاقبة الجناة، واتخاذ تدابير لمنع تكرار هذا الوضع؛
                - (ج) الت��جيل باتخاذ تدابير لتيسير دخول الأطفال ملتمسي اللجوء واللاجئين والمهاجرين وحدات الحماية الموجودة في المشافي، وتحسين الأوضاع الصحية في مراكز استقبال المهاجرين.", "", "" },
                    { 777, null, "R31P3", "ت.31.ف3", "", "Non réalisé", "", 0, 6, null, 7, null, 34, null, "Organes de traités", "c) Abolir les frais imposés pour l’obtention d’un bulletin de naissance, prolonger le court délai d’enregistrement des nouveau-nés (trente jours) et faciliter la délivrance de bulletins de naissance à tous les enfants réfugiés qui n’en possèdent pas encore un;", "-           (ج) إلغاء رسوم شهادات الميلاد، وتمديد فترة تسجيل الوِلْدان القصيرة (30 يوماً) وتيسير تقديم شهادات الميلاد لجميع أطفال اللاجئين الذين لا يزالون يفتقرون إليها؛", "", "" },
                    { 726, null, "R45P3", "ت.45.ف.3", "", "Non réalisé", "", 0, 6, null, 6, null, 34, null, "Organes de traités", "Permettre aux réfugiés et demandeurs d’asile de bénéficier des services publics, d’octroyer des permis de travail à ceux d’entre eux qui sont en situation régulière et à garantir leur droit à la sécurité notamment en ce qui concerne les femmes et les enfants.", "السماح للاجئين وملتمسي اللجوء بإمكانية الحصول على الخدمات العامة، وتوفير تصاريح عمل لأولئك اللاجئين وملتمسي اللجوء الذين لديهم وثائق، وأن تكفل حقهم في الأمن، لا سيما بالنسبة إلى النساء والأطفال.", "", "" },
                    { 682, null, "R24", "ت.24", "", "Non réalisé", "", 0, 6, null, 5, null, 34, null, "Organes de traités", "Prendre les mesures nécessaires pour s’assurer que tous les travailleurs migrants et les membres de leur famille puissent librement quitter l’État partie, y compris les travailleurs migrants marocains et les membres de leur famille.", "اتخاذ التدابير اللازمة لضمان إمكانية أن يغادر الدولة بحرية جميع العمال المهاجرين وأفراد أسرهم، بمن فيهم العمال المهاجرون المغاربة وأفراد أسرهم، انسجاما مع مقتضيات المادة 8 من الاتفاقية.", "", "" },
                    { 681, null, "R22", "ت.22", "", "Non réalisé", "", 0, 6, null, 5, null, 34, null, "Organes de traités", @"Diffuser de l’information auprès des travailleurs migrants et des membres de leur famille, y compris ceux en situation irrégulière, les informer des recours judiciaires ou autres qui leur sont ouverts et de traiter leurs plaintes le plus efficacement possible. 
                - Garantir que les travailleurs migrants et les membres de leur famille, y compris ceux en situation irrégulière, aient les mêmes possibilités que les nationaux de porter plainte et d’exercer un recours utile devant les tribunaux s’ils ont été atteints dans les droits que leur reconnaît la Convention.", @"تعميم المعلومات على العمال المهاجرين وأفراد أسرهم بمن فيهم الموجودون في وضع غير قانوني، وإبلاغهم بسبل الانتصاف القضائية أو غير ذلك من سبل الانتصاف المتاحة لهم، ومعالجة شكاواهم بأقصى قدر ممكن من الفعالية.
                كفالة أن يُتاح للعمال المهاجرين وأفراد أسرهم، بمن فيهم الموجودون في وضع غير قانوني، الإمكانات ذاتها التي تتاح للمواطنين من أجل رفع الشكاوى والاستفادة من سبيل انتصاف فعال أمام المحاكم في حال انتهاك حقوقهم المعترف بها في الاتفاقية.", "", "" },
                    { 680, null, "R20P2", "ت.20.ف2", "", "Non réalisé", "", 0, 6, null, 5, null, 34, null, "Organes de traités", "prendre sans délai des mesures efficaces pour lutter contre la stigmatisation sociale et raciale envers les travailleurs migrants, particulièrement les travailleurs migrants subsahariens.", "-          المبادر إلى اتخاذ تدابير فعالة من أجل مكافحة الوصم الاجتماعي والعنصري الذي يتعرض له العمال المهاجرون، لا سيما المنحدرون من أفريقيا جنوب الصحراء.", "", "" },
                    { 679, null, "R10P2P3", "ت.10.ف2.ف3.", "", "Non réalisé", "", 0, 6, null, 5, null, 34, null, "Organes de traités", @"Veiller à ce que la politique globale migratoire en cours d’élaboration se réfère aux différents instruments internationaux des droits de l’homme et plus particulièrement à la Convention. 
                - Renforcer les mesures visant à surveiller l’application de la 9 relative aux travailleurs migrants, ainsi que celle de la Convention", @"الحرص على استرشاد السياسة العامة التي تجري صياغتها فيما يتعلق بالهجرة بمختلف الصكوك الدولية لحقوق الإنسان، لا سيما الاتفاقية.
                وتعزيز التدابير الرامية إلى مراقبة تطبيق التشريعات المتعلقة بالعمال المهاجرين وتطبيق الاتفاقية في مرحلة لاحقة.", "", "" },
                    { 607, null, "R36P2P3P4", "ت.36.ف.2.ف.3.ف.4", "", "Non réalisé", "", 0, 6, null, 3, null, 34, null, "Organes de traités", @"b) poursuivre et renforcer les efforts pour régulariser la situation de personnes ayant besoin d’une protection internationale, notamment les réfugiés syriens, en leur octroyant un statut légal et des cartes nationales de réfugiés, afin de garantir leur droit à la non-discrimination, y compris l’accès au marché formel de l’emploi ;
                 c) établir des procédures de détermination du statut de réfugié aux points d’entrée dans le pays, y compris dans les aéroports ;
                 d) mettre un terme aux arrestations collectives et cesser de participer aux opérations d’expulsions collectives de migrants opérées notamment à proximité des villes autonomes espagnoles de Ceuta et Melilla ;", @"(ب) ومواصلة وتعزيز الجهود لتسوية وضع الأشخاص الذين يحتاجون إلى الحماية الدولية، بمن فيهم اللاجئون السوريون، بمنحهم صفة قانونية وبطاقات وطنية للاجئين، من أجل ضمان حقهم في عدم التمييز، بما في ذلك دخول سوق العمل الرسمية؛
                -  (ج) العمل بإجراءات تحديد صفة اللاجئ في نقاط دخول البلد، بما فيها المطارات؛
                -  (د) وضع حد للاعتقالات الجماعية، والتوقف عن المشاركة في عمليات الطرد الجماعي للمهاجرين، خاصة بالقرب من مدينتي سبتة ومليلية الإسبانيتين المستقلتين ذاتياً؛", "", "" },
                    { 564, null, "R26P1P2P3", "ت.26.ف.1.ف.2ف.3", "", "Non réalisé", "", 0, 6, null, 2, null, 34, null, "Organes de traités", @"Prendre des mesures visant à garantir que les garanties légales régissant les reconduites à la frontière des migrants illégaux et l’expulsion des étrangers soient toujours mises en œuvre dans la pratique et que les reconduites et les expulsions soient conformes à la loi marocaine. 
                - Mener des enquêtes impartiales et efficaces sur les allégations selon lesquelles des expulsions de migrants se seraient accompagnées d’un recours excessif à la force ou de mauvais traitements à l’endroit des migrants. 
                - Faire en sorte que les responsables soient traduits en justice et qu’il leur soit infligé des peines à la mesure de la gravité de leurs actes.", @"اتخاذ تدابير تكفل تطبيق الضمانات القانونية التي تحكم اقتياد المهاجرين غير الشرعيين إلى الحدود وطرد الأجانب عملياً على الدوام، وأن تكون عمليات الاقتياد والطرد منسجمة مع القانون المغربي. 
                - إجراء تحقيقات نزيهة وفعالة في الادعاءات التي تفيد باحتمال الاستخدام المفرط للقوة وإساءة معاملة المهاجرين في سياق عمليات 
                -  تقديم المسؤولين عن ذلك إلى العدالة وإنزال عقوبات عليهم تتناسب مع جسامة أفعالهم.", "", "" },
                    { 563, null, "R25P2", "ت.25.ف.2", "", "Non réalisé", "", 0, 6, null, 2, null, 34, null, "Organes de traités", @"Développer les instruments institutionnels et administratifs propres à mettre en œuvre cette protection, notamment en renforçant sa coopération avec le Haut-Commissariat des Nations Unies pour les réfugiés et en octroyant au Haut-Commissariat un statut d’observateur au cours du processus de réforme du système d’asile. 
                - S’assurer de la mise en place des procédures et des mécanismes propres à garantir l’identification systématique des demandeurs d’asile potentiels à tous les points d’entrée sur le territoire marocain. 
                - Permettre à ces personnes de déposer leur demande d’asile. 
                - Faire en sorte que lesdits mécanismes garantissent que la décision rendue soit susceptible d’un recours avec effet suspensif et que la personne ne soit pas refoulée vers un pays où existe un risque de torture", @"تطوير الأدوات المؤسسية والإدارية القادرة على تنفيذ هذه الحماية، لا سيما بتعزيز تعاونها مع المفوضية السامية لشؤون اللاجئين وبمنح المفوضية السامية صفة مراقب في سياق عملية إصلاح نظام اللجوء. 
                -  وضع إجراءات وآليات قادرة على ضمان تحديد هوية طالبي اللجوء المحتملين بصورة منهجية في جميع نقاط الدخول إلى الأراضي المغربية.
                -  تمكين هؤلاء الأشخاص من تقديم طلبات لجوئهم. 
                - تضمين هذه الآليات أيضاً إمكانية تعرض القرارات المتخذة للطعن وأن يقترن ذلك بوقف التنفيذ وعدم إبعاد الشخص المعني إلى بلد يواجه فيه خطر التعذيب", "", "" },
                    { 506, null, "R14", "ت.14", "", "Non réalisé", "", 0, 6, null, 1, null, 34, null, "Organes de traités", "Prendre des mesures visant à protéger les non-ressortissants dépourvus de titre de séjour contre la discrimination raciale et la xénophobie, à veiller à l’application de toutes garanties juridiques relatives à leur détention, ainsi qu’à faciliter leur accès aux tribunaux. Le Comité recommande également à l’Etat partie de garantir l’application correcte du principe de non-refoulement.", "-اتخاذ تدابير لحماية غير المواطنين الذين لا يملكون رخصة إقامة من التمييز العنصري ومن كراهية الأجانب", "", "" },
                    { 505, null, "R13P2", "ت.13.ف.2", "", "Non réalisé", "", 0, 6, null, 1, null, 34, null, "Organes de traités", "Garantir la protection des droits des réfugiés et des demandeurs d’asile, notamment en ce qui concerne l’accès à l’emploi et l’accès au logement, ainsi que leur protection contre la discrimination raciale", "ضمان حماية حقوق اللاجئين وطالبي اللجوء فيما يخص الحصول على العمل والسكن وحماية تلك الفئات من الناس من أي تمييز عنصري.", "", "" },
                    { 444, null, "R144.241", "241.144", "", "Non réalisé", "", 0, 6, 1, null, 82, 34, null, "Examen périodique universal", "Envisager de partager avec d’autres pays l’expérience marocaine en matière de protection et de promotion des droits des migrants", "النظر في تبادل الخبرة المغربية مع بلدان أخرى فيما يتعلق بحماية وتعزيز حقوق المهاجرين", "", "" },
                    { 443, null, "R144.238", "238.144", "", "Non réalisé", "", 0, 6, 1, null, 27, 34, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir et protéger les droits des migrants", "مواصلة الجهود الرامية إلى تعزيز وحماية حقوق المهاجرين", "", "" },
                    { 442, null, "R144.237", "237.144", "", "Non réalisé", "", 0, 6, 1, null, 75, 34, null, "Examen périodique universal", "Poursuivre la mise en œuvre de la politique de promotion et de protection effectives des droits des migrants () ;", "مواصلة تنفيذ سياسة التعزيز والحماية الفعّالين لحقوق المهاجرين", "", "" },
                    { 441, null, "R144.224P2", "224.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 79, 34, null, "Examen périodique universal", "Continuer à renforcer les politiques publiques pertinentes pour la promotion et la protection des droits de l’homme, en particulier les droits des demandeurs d’asile () ;", "مواصلة تقوية السياسات العامة ذات الصلة لتعزيز وحماية حقوق الإنسان، وبخاصة حقوق... المهاجرين وملتمسي اللجوء ...", "", "" },
                    { 440, null, "R144.222P3", "222.144. ج.3", "", "Non réalisé", "", 0, 6, 1, null, 19, 34, null, "Examen périodique universal", "Prendre des mesures plus efficaces pour mieux protéger les droits des migrants", "اتخاذ تدابير أكثر نجوعاً من أجل توفير حماية أفضل.... المهاجرين وغير ذلك من الفئات الضعيفة", "", "" },
                    { 210, null, "R83P19", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 7, "Procédure spéciale", "-       Envisager différentes mesures non privatives de liberté, telles que l’obligation de faire rapport, avant de recourir à la détention des migrants, réfugiés et demandeurs d’asile ;", "null", "", "" },
                    { 209, null, "R83P18", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 7, "Procédure spéciale", "S’assurer que les garanties juridiques régissant la pratique de reconduite à la frontière des migrants sans papiers et l’expulsion de ressortissants étrangers soient effectivement appliquées et que de telles pratiques et expulsions soient effectuées conformément au droit international et national. - Le Gouvernement devrait demander des enquêtes impartiales et efficaces sur les allégations de mauvais traitements ou d’usage excessif de la force lors des expulsions de migrants. Il convient également de s’assurer que les responsables soient traduits en justice et condamnés à des peines proportionnelles à la gravité de leurs actes", "null", "", "" },
                    { 208, null, "R83P17", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 7, "Procédure spéciale", "-       Prendre toutes les mesures nécessaires pour empêcher les arrestations massives et autres actes de violence et enquêter sur les rapports concernant les violences commises contre les migrants sub-sahariens, les réfugiés et les demandeurs d’asile", "null", "", "" },
                    { 140, null, "R99P1-1", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 4, "Procédure spéciale", "En ce qui les provinces marocaines du sud :- a) prendre des mesures concrètes pour améliorer la situation des migrants en situation irrégulière…………", "null", "", "" },
                    { 114, null, "R90P3", "ت.90.ف.3", "", "Non réalisé", "", 0, 6, null, null, null, 34, 3, "Procédure spéciale", "-    Respecter les droits de l’homme fondamentaux des migrants, des réfugiés et des demandeurs d’asile et de leur assurer l’accès aux établissements de santé et aux soins médicaux sans crainte d’être arrêtés.", "-          (ب) احترام الحقوق الإنسانية الأساسية للمهاجرين واللاجئين وملتمسي اللجوء، وتيسير دخولهم المرافق الصحية وتلقيهم الرعاية الطبية دون خوف من اعتقالهم.", "", "" },
                    { 113, null, "R90P2", "ت.90.ف.2", "", "Non réalisé", "", 0, 6, null, null, null, 34, 3, "Procédure spéciale", "-    Prendre toutes les mesures nécessaires pour prévenir d’autres violences et enquêter sur les informations faisant état d’actes de violence subis par des migrants, des réfugiés et des demandeurs d’asile subsahariens", "-          (أ) اتخاذ جميع التدابير اللازمة لمنع حدوث المزيد من أعمال العنف، والتحقيق في التقارير التي تتحدث عن تلك الأعمال في حق المهاجرين واللاجئين وملتمسي اللجوء من الصحراء الغربية؛", "", "" },
                    { 446, null, "R144.109", "109.144", "", "Non réalisé", "", 0, 6, 1, null, 74, 35, null, "Examen périodique universal", "Poursuivre les efforts visant à lutter contre la traite des êtres humains et veiller à ce qu’une attention particulière soit accordée aux groupes vulnérables en appliquant la loi adoptée à cet égard", "مواصلة الجهود لمكافحة الاتجار بالبشر وضمان إيلاء عناية خاصة للفئات الضعيفة عند تطبيق القانون المعتمَد في هذا الشأن", "", "" },
                    { 62, null, "R85", "null", "", "Non réalisé", "", 0, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Fournir une aide humanitaire d’urgence à toutes les personnes victimes de graves violations des droits de l’homme dans le contexte migratoire, sans distinction de race, d’appartenance ethnique, d’origine nationale, d’ascendance ou de statut migratoire, en particulier à celles qui risquent de subir une discrimination croisée en raison de leur sexe, de leur identité de genre, de leur orientation sexuelle, d’un handicap ou de toute autre situation", "null", "", "" },
                    { 447, null, "R144.110P1", "110.144.ج.1", "", "Non réalisé", "", 0, 6, 1, null, 80, 35, null, "Examen périodique universal", "Élaborer une stratégie nationale pour lutter contre l’esclavage moderne", "وضع استراتيجية وطنية للتصدي للعبودية المعاصرة", "", "" },
                    { 683, null, "R48P2P3P4", "ت48.ف2.ف3.ف4", "", "Non réalisé", "", 0, 6, null, 5, null, 35, null, "Organes de traités", @"Prendre les mesures nécessaires pour que la stratégie nationale de lutte contre le trafic des êtres humains comprenne notamment les mesures suivantes :
                b) Collecter systématiquement des données ventilées sur la traite des personnes ;
                c) Intensifier les campagnes de prévention, en particulier dans les zones frontalières où les victimes de la traite sont les plus nombreuses ; 
                d) Mettre en place des mécanismes efficaces d’identification, de protection et d’assistance à toutes les victimes de la traite, en particulier en leur offrant des centres d’accueil et en lançant des projets pour les aider à reconstruire leur vie;", @"اتخاذ التدابير اللازمة كي تتضمن الاستراتيجية الوطنية لمحاربة الاتجار بالبشر التدابير التالية على وجه الخصوص:
                 (ب) القيام على نحو منهجي بجمع بيانات مُصنَّفة عن ظاهرة الاتجار بالبشر؛
                 (ج) تكثيف حملات الوقاية، لا سيما في المناطق الحدودية حيث يوجد العدد الأكبر من ضحايا الاتجار؛
                 (د) إقرار آليات فعالة لتحديد جميع ضحايا الاتجار وحمايتهم ومساعدتهم، لا سيما بتوفير مراكز لاستقبالهم ومباشرة مشاريع لمساعدتهم على إعادة بناء حياتهم؛", "", "" },
                    { 246, null, "R73P5", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 8, "Procédure spéciale", "Allouer des ressources supplémentaires au renforcement des capacités à tous les niveaux de la mise en œuvre des activités de développement, compte tenu en particulier de la décentralisation imminente- Il est suggéré que la Délégation interministérielle aux droits de l’homme intensifie, en coordination avec le Conseil national des droits de l’homme et autres partenaires, les programmes de formation aux droits de l’homme, en particulier ceux qui sont destinés aux fonctionnaires œuvrant à la prestation de services publics. Cela améliorerait la transparence et constituerait une mesure positive en vue de prévenir le favoritisme et la corruption dans la 21", "null", "", "" },
                    { 240, null, "R87", "ت.87", "", "Non réalisé", "", 0, 9, null, null, null, 36, 8, "Procédure spéciale", "lors du recensement de 2014, des informations doivent être recueillies sur la composition de la population, l’usage des langues arabe, amazighe et autres, et sur tout autre indicateur de la diversité ethnique et culturelle de la population.", "-       توصي الخبيرة المستقلة أيضاً بأن تُجمع، خلال التعداد السكاني لعام 2014، معلومات عن تركيبة السكان، واستخدام اللغتين العربية والأمازيغية وغيرهما من اللغات، وأي مؤشر آخر على التنوع الإثني والثقافي للسكان. وفي هذا الصدد، قد ترغب الحكومة في التماس مساعدة اليونسكو فيما يخص عملها المتعلق بالمؤشرات الثقافية.", "", "" },
                    { 239, null, "R90P1P2", "ت.90.ق.1.ف.2", "", "Non réalisé", "", 0, 8, null, null, null, 36, 8, "Procédure spéciale", "- Apporter un appui juridique, financier et institutionnel à la proposition relative aux «trésors humains vivants»", "إنشاء آليات تسمح للأشخاص باتخاذ قرارات فعالة ومجدية والمشاركة في تحديد التراث الثقافي وتفسيره وتعزيزه وحمايته. - توفير الدعم القانوني والمالي والمؤسسي لمقترح 'الكنوز البشرية الحية'. وينبغي للمغرب أيضاً", "", "" },
                    { 238, null, "R90P1P2", "ت.90.ق.1.ف.2", "", "Non réalisé", "", 0, 8, null, null, null, 36, 8, "Procédure spéciale", "- Mettre en place des mécanismes permettant une participation effective et digne de ce nom, notamment en matière de prise de décisions, de la population au recensement, à l’interprétation, à la promotion et à la protection du patrimoine culturel.", "إنشاء آليات تسمح للأشخاص باتخاذ قرارات فعالة ومجدية والمشاركة في تحديد التراث الثقافي وتفسيره وتعزيزه وحمايته. - توفير الدعم القانوني والمالي والمؤسسي لمقترح 'الكنوز البشرية الحية'. وينبغي للمغرب أيضاً", "", "" },
                    { 237, null, "R86P1-5", "ت.86.ف1ج5", "", "Non réalisé", "", 0, 8, null, null, null, 36, 8, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en veillant à ce que les chaînes de télévision et stations de radio qui diffusent leurs programmes en langue arabe diffusent également au moins 30 % de ceux-ci en langue amazighe, comme le prévoit la loi; des mesures supplémentaires devraient aussi être prises pour élaborer des programmes aux niveaux national et régional afin d’appuyer les activités menées pour promouvoir la connaissance du patrimoine culturel et la diversité culturelle dans le cadre des émissions pédagogiques et destinées à la jeunesse et pour associer les médias nationaux à cette action", "(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:- 5-ضمان قيام قنوات وسائط الإعلام التي تبث برامجها باللغة العربية ببث ما لا يقل عن 30 في المائة من برامجها باللغة الأمازيغية، مثلما ينص على ذلك القانون؛ وينبغي اتخاذ مزيد من التدابير لإعداد برامج على الصعيدين الوطني والإقليمي من أجل دعم الجهود الرامية إلى تعزيز معرفة التراث الثقافي والتنوع في البرامج التعليمية والشبابية، وتعبئة وسائط الإعلام الوطنية للدعوة إلى هذا النهج؛", "", "" },
                    { 236, null, "R86P1-4", "ت.86.ف1ج4", "", "Non réalisé", "", 0, 8, null, null, null, 36, 8, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en fournissant des fonds et une assistance adéquats dans le cadre de mesures de renforcement des capacités pour promouvoir l’utilisation de la langue amazighe dans l’éducation et la vie publique; en particulier, une assistance financière supplémentaire devrait être apportée à l’IRCAM afin que ces ouvrages et publications soient largement distribués dans les zones rurales", "(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:- 4-تقديم التمويل والمساعدة الكافيين لتدابير بناء القدرات من أجل تعزيز استخدام اللغة الأمازيغية في التعليم والحياة العامة؛ وبصورة خاصة، ينبغي تقديم مزيد من المساعدة المالية للمعهد الملكي للثقافة الأمازيغية لضمان توزيع الكتب والمنشورات ذات الصلة على نطاق واسع في المناطق الريفية؛", "", "" },
                    { 235, null, "R88P1", "ت.88.ف.1", "", "Non réalisé", "", 0, 8, null, null, null, 36, 8, "Procédure spéciale", "Adoption d’une procédure plus efficace, plus simple et plus conviviale de présentation des projets culturels à l’INDH et aux autres institutions de développement est cruciale pour autonomiser le secteur culturel de la société civile et susciter une participation plus active aux niveaux régional et national.", "-       اعتماد عملية أكثر فعالية وبساطة وسهولة في الاستعمال لتقديم الطلبات فيما يخص المشاريع الثقافية التي تدخل في إطار المبادرة الوطنية للتنمية البشرية وغيرها من الوكالات الإنمائية، لتمكين القطاع المدني الثقافي والسماح بمشاركة أكثر فعالية على الصعيدين الإقليمي والوطني.", "", "" },
                    { 234, null, "R83P2", "ت.83.ف.2", "", "Non réalisé", "", 0, 8, null, null, null, 36, 8, "Procédure spéciale", "Les nouvelles lois et mesures relatives à la mise en œuvre de nouvelles dispositions constitutionnelles, en particulier celles qui concernent les droits et la diversité culturels exigent l’adoption de politiques et stratégies pertinentes, et ceux qui sont chargés de mettre celles-ci en œuvre doivent recevoir une formation et des orientations à cet effet.", "-       تتطلب القوانين والتدابير الجديدة  المتعلقة بإنفاذ الأحكام الدستورية الجديدة، لا سيما تلك الخاصة بالحقوق الثقافية والتنوع الثقافي اعتماد سياسات واستراتيجيات مناسبة وينبغي أن تقترن بتدريب مناسب وتوجيه صحيح للمسؤولين المكلفين بتطبيقها.", "", "" },
                    { 233, null, "R86P1-6", "ت.86.ف1ج6", "", "Non réalisé", "", 0, 7, null, null, null, 36, 8, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en encourageant les fonctionnaires et administrateurs fournissant des services publics aux locuteurs amazighs, les juges et les avocats à améliorer leurs connaissances linguistiques et en veillant à ce que des interprètes de langue amazighe soient formés et disponibles auprès des tribunaux ;", "(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:- - تعزيز المهارات اللغوية في صفوف الموظفين الحكوميين والإداريين الذين يقدمون خدمات عامة للناطقين بالأمازيغية، وفي صفوف القضاة والمحاميين، وضمان تدريب وتوفر مترجمين شفويين لدى المحاكم", "", "" },
                    { 173, null, "R91P5", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 6, "Procédure spéciale", "Faciliter l’accès des 32aires des deux sexes, en particulier ceux qui sont élus pour la première fois, aux services de renforcement des capacités, de façon à accroître leurs connaissances des obligations internationales de l’État en matière de droits de l’homme et de tous les aspects des droits fondamentaux des femmes ainsi que des techniques de rédaction juridique et d’autres tâches législatives; dans les environnements où les hommes prédominent, les femmes devraient bénéficier d’une formation pour développer leur sens de la direction et leur confiance en elle-même;", "null", "", "" },
                    { 172, null, "R89P11", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 6, "Procédure spéciale", "Prendre d’autres mesures pour sensibiliser et former l’ensemble du personnel et des services du secteur de la justice en ce qui concerne les obligations de l’État dans le domaine des droits de l’homme, ainsi que leur place et leur incorporation dans l’ordre juridique interne. - Le Ministère de l’26, le Ministère de la justice et le Ministère de la solidarité, de la femme, de la famille et du développement social sont encouragés à assurer une sensibilisation accrue de la société à tous les aspects de la violence à l’égard des femmes et à intégrer l’information sur la prévention effective de la violence fondée sur le sexe et de la lutte contre cette violence dans les programmes de formation de la police, et de la justice et des secteurs juridique et social", "null", "", "" },
                    { 146, null, "R99P2-1", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 4, "Procédure spéciale", "En ce qui les provinces marocaines du sud :- b) Renforcer encore les capacités actuelles pour permettre de détecter les cas de traite des êtres humains…….", "null", "", "" },
                    { 145, null, "R90", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 4, "Procédure spéciale", "-    Organiser des programmes de formation à l’application des instruments juridiques internationaux au profit des avocats et autres professionnels pour pouvoir appliquer les lois et les normes internationales relatives aux droits de l’homme.", "null", "", "" },
                    { 144, null, "R83P2", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 4, "Procédure spéciale", "……..Former le personnel des organismes d’application des lois, en particulier les policiers, les agents des services d’immigration et les inspecteurs du travail. - Le personnel ainsi formé devrait être mieux à même de repérer rapidement et sans se tromper les victimes de la traite et de les orienter vers les services voulus. - Distinguer clairement les migrants en situation irrégulière des victimes de la traite, ces deux catégories de personnes devant être soumises à des lois et à des procédures distinctes.", "null", "", "" },
                    { 115, null, "R95P2", "ت.95.ف.2", "", "Non réalisé", "", 0, 7, null, null, null, 36, 3, "Procédure spéciale", "-    sensibiliser davantage l’ensemble du personnel chargé d’appliquer la loi à son rôle de prévention de la torture et des mauvais traitements au moyen de cours obligatoires de formation aux normes internationales relatives à l’interdiction de la torture, aux dispositions régissant les enquêtes en cas de torture et de mauvais traitements, et aux techniques d’interrogatoire et de renforcer les programmes de formation sur la façon de déceler, de signaler et de prévenir la torture, destinés aux professionnels de la santé et de l’administration de la justice;", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي:- (ب) إذكاء وعي جميع موظفي إنفاذ القانون بدورهم في منع التعذيب وسوء المعاملة بواسطة التدريب الإلزامي على المعايير الدولية المتعلقة بمنع التعذيب والأحكام المنظمة للتحقيقات في التعذيب وسوء المعاملة وأساليب الاستجواب، واستحداث المزيد من البرامج التدريبية التي ينبغي تقديمها أثناء دورات التأهيل المهني للعاملين في مجالي الصحة والقانون بشأن كشف التعذيب والإبلاغ عنه وتوقيه؛", "", "" },
                    { 65, null, "R91", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 2, "Procédure spéciale", "-       Accroître les ressources des bureaux régionaux du Conseil national des droits de l’homme et leur procurer des possibilités de formation sur les obligations internationales en matière de droits de l’homme pour combattre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, en prêtant particulièrement attention aux variations locales dans les manifestations de ces problèmes", "null", "", "" },
                    { 64, null, "R90", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 2, "Procédure spéciale", "-       Renforcer les capacités et les compétences des bureaux régionaux du Conseil national des droits de l’homme en matière de lutte contre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, en accordant une attention particulière aux dynamiques régionales qui influent sur l’égalité raciale.", "null", "", "" },
                    { 63, null, "R76", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 2, "Procédure spéciale", "-       Renforcer les mesures préventives d’éducation, de formation et de sensibilisation de sorte que tous les agents publics, y compris ceux qui sont responsables de l’administration des services publics, s’abstiennent de toute forme de racisme, de discrimination raciale, de xénophobie et d’intolérance qui y est associée.", "null", "", "" },
                    { 35, null, "R90P2", "null", "", "Non réalisé", "", 0, 8, null, null, null, 36, 1, "Procédure spéciale", "-   Renforcer le rôle des travailleurs sociaux et veiller à ce que ceux-ci soient rémunérés en conséquence, afin de garantir le contrôle effectif du respect du droit de l’enfant à une alimentation suffisante et équilibrée et de promouvoir une alimentation équilibrée auprès des familles.", "null", "", "" },
                    { 34, null, "R87", "null", "", "Non réalisé", "", 0, 8, null, null, null, 36, 1, "Procédure spéciale", "Veiller à ce que les dispositifs de protection sociale bénéficient aux groupes les plus pauvres et les plus désavantagés, notamment à ceux vivant en milieu rural, en s’employant à mieux identifier les personnes admissibles ; - -Veiller à ce que les cibles des programmes soient choisies de manière transparente et éliminer la corruption à tous les niveaux du système", "null", "", "" },
                    { 33, null, "R74", "null", "", "Non réalisé", "", 0, 8, null, null, null, 36, 1, "Procédure spéciale", "-   Élargir les mécanismes de suivi existants pour que les permis de pêche annuels soient délivrés de manière transparente, conformément aux règles internationales relatives à la pêche", "null", "", "" },
                    { 32, null, "R70", "null", "", "Non réalisé", "", 0, 8, null, null, null, 36, 1, "Procédure spéciale", "-   Renforcer les mécanismes de suivi et d’évaluation afin que les projets d’intensification agricole lancés dans le cadre du pilier I du Plan Maroc Vert soient écologiquement viables et qu’ils ne conduisent pas à l’épuisement des ressources.", "null", "", "" },
                    { 31, null, "R69", "null", "", "Non réalisé", "", 0, 8, null, null, null, 36, 1, "Procédure spéciale", "Promouvoir une société civile indépendante, qui permettra au Maroc de renforcer l’engagement qu’il a pris de garantir le respect des droits de l’homme et des libertés fondamentales à l’avenir. - Encourager la société civile à incorporer les droits économiques, sociaux et culturels, en particulier le droit à l’alimentation, dans son programme.", "null", "", "" },
                    { 30, null, "R67P1", "null", "", "Non réalisé", "", 0, 8, null, null, null, 36, 1, "Procédure spéciale", "-   Garantir la bonne application des lois en vigueur en renforçant les mécanismes de suivi et de responsabilisation", "null", "", "" },
                    { 29, null, "R66P2", "null", "", "Non réalisé", "", 0, 8, null, null, null, 36, 1, "Procédure spéciale", "Désigner les autorités et les organismes responsables de la mise en œuvre et mettre en place des mécanismes adéquats de suivi et de responsabilisation se rapportant à la loi-cadre relative au droit à l’alimentation à mettre en place. - Garantir la pleine participation de tous les acteurs concernés, notamment des plus vulnérables face à la faim et à la malnutrition", "null", "", "" },
                    { 28, null, "R78", "null", "", "Non réalisé", "", 0, 7, null, null, null, 36, 1, "Procédure spéciale", "-   Sensibiliser les populations locales, en particulier les femmes et les jeunes, et faciliter leur participation, avec l’appui des organisations non gouvernementales, aux mesures de développement visant à combattre les effets des changements climatiques", "null", "", "" },
                    { 727, null, "R23P1", "ت.23.ف.1", "", "Non réalisé", "", 0, 6, null, 6, null, 35, null, "Organes de traités", @"Adopter des mesures efficaces pour prévenir et combattre la traite des êtres humains, notamment des femmes et des filles, et d’enquêter de manière approfondie sur les affaires de cette nature, conformément à l’article 6 de la Convention et à sa recommandation générale no 19. 
                -Renforcer la coopération internationale visant à lutter contre la traite, à engager des poursuites contre les trafiquants, à leur infliger des peines proportionnelles à la gravité des crimes qu’ils commettent, et à protéger les droits fondamentaux des femmes et des filles victimes de l’exploitation et de la traite, en prenant notamment des mesures pour leur réadaptation et leur réintégration sociale.", @"اعتماد تدابير فعالة لمنع ومكافحة الاتجار بالأشخاص، ولا سيما النساء والفتيات، وإجراء تحقيقات مستفيضة في هذه القضايا، وذلك وفقا للمادة 6 من الاتفاقية والتوصية العامة رقم 19. 
                 -توطيد جهود التعاون الدولي لمنع الاتجار وملاحقة الضالعين فيه قضائيا ومعاقبتهم حسب جسامة جرمهم، وكفالة حماية حقوق الإنسان الواجبة للنساء والفتيات من ضحايا الاستغلال والاتجار، بسبل منها اتخاذ التدابير اللازمة لتأهيلهن وإدماجهن في المجتمع", "", "" },
                    { 565, null, "R27P2P3", "ت.27.ف.2.ف.3", "", "Non réalisé", "", 0, 6, null, 2, null, 35, null, "Organes de traités", @"Créer des conditions propices à l’exercice par les femmes et des enfants victimes de la traite de leur droit de déposer plainte. 
                - Procéder rapidement à des enquêtes impartiales et efficaces sur toutes les allégations de traite, de même que veiller à ce que les responsables soient traduits en justice et que des peines à la mesure de la gravité de leurs actes leur soient infligées", @"قمع عملية الاتجار وحماية الضحايا، بتوفير الحماية لهم وبضمان حصول الضحايا على خدمات تأهيلية وكذلك على خدمات طبية واجتماعية وقانونية، وعلى خدمات التوعية عند الحاجة. وينبغي كذلك أن تهيئ الدولة الطرف ظروفاً مواتية لممارسة الضحايا حقهم في تقديم الشكاوى. 
                - إجراء تحقيقات نزيهة وفعالة بشأن جميع الادعاءات المتعلقة بالاتجار بالبشر، وضمان تقديم المسؤولين عنها إلى العدالة، ومعاقبتهم عقاباً يتناسب مع جسامة ممارساتهم.", "", "" },
                    { 55, null, "R79P7", "null", "", "Non réalisé", "", 0, 5, null, null, null, 25, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne les libertés de réunion pacifique et d’association", "null", "", "" },
                    { 400, null, "R144.202", "202.144", "", "Non réalisé", "", 0, 6, 1, null, 60, 30, null, "Examen périodique universal", "Adopter une 9 spécifique sur la violence à l’égard des femmes, y compris les dispositions pénales et civiles nécessaires pour remédier à la violence familiale et au harcèlement sexuel des femmes et des filles", "اعتماد تشريعات محددة بشأن العنف على المرأة تتضمن أحكاماً جنائية ومدنية ضرورية للتصدي للعنف المنزلي والتحرش الجنسي بالنساء والفتيات", "", "" },
                    { 371, null, "R144.244", "244.144", "", "Non réalisé", "", 0, 5, 1, null, 48, 24, null, "Examen périodique universal", "Élaborer et appliquer des mesures indépendantes et crédibles qui garantissent le plein respect des droits de l’homme au Sahara occidental, notamment la liberté d’expression et de réunion", "وضع وتنفيذ تدابير مستقلة وموثوقة لضمان الاحترام الكامل لحقوق الإنسان في الصحراء الغربية بما فيها حرية التعبير والتجمع", "", "" },
                    { 193, null, "R83P26", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 7, "Procédure spéciale", "-       Adopter rapidement le projet de loi sur les tribunaux militaires afin de s’assurer que les civils ne soient pas condamnés par un tribunal militaire et d’examiner les jugements rendus par le tribunal militaire dans le cas des 25 personnes sahraouies du camp de Gdeim Izik.", "null", "", "" },
                    { 218, null, "R86P2-3", "ت.86.ف.2ج3", "", "Non réalisé", "", 0, 3, null, null, null, 9, 8, "Procédure spéciale", "-          envisager d’adopter une nouvelle loi reconnaissant le droit de chacun de choisir librement le prénom de ses enfants dans sa propre langue;", "- التفكير أيضاً في اعتماد قانون جديد يقر حق كل شخص في اختيار اسم طفله بحرية بلغته الخاصة؛", "", "" },
                    { 284, null, "R144.107", "107.144", "", "Non réalisé", "", 0, 3, 1, null, 40, 9, null, "Examen périodique universal", "Adopter les amendements proposés au Code de procédure pénale pour assurer le respect des garanties en détention", "اعتماد التعديلات المقترَحة لقانون المسطرة الجنائية من أجل ضمان احترام الضمانات والتدابير الوقائية أثناء الاحتجاز", "", "" },
                    { 285, null, "R144.128", "128.44", "", "Non réalisé", "", 0, 3, 1, null, 80, 9, null, "Examen périodique universal", "Réviser le Code pénal et le Code de procédure pénale dans le cadre de la réforme en cours du secteur de la 28", "مراجعة القانون الجنائي وقانون المسطرة الجنائية كجزء من عملية الإصلاح الجارية لقطاع القضاء", "", "" },
                    { 286, null, "R144.34", "34.144", "", "Non réalisé", "", 0, 3, 1, null, 95, 9, null, "Examen périodique universal", "Adopter et appliquer une 9 complète contre la discrimination", "اعتماد وتطبيق قانون شامل مناهض للتمييز", "", "" },
                    { 287, null, "R144.72", "72.144", "", "Non réalisé", "", 0, 3, 1, null, 17, 9, null, "Examen périodique universal", "Interdire la discrimination et ériger en infraction la violence envers des personnes en raison de leur orientation sexuelle ou de leur identité de genre", "حظر التمييز وتجريم العنف على الأشخاص على أساس ميلهم الجنسي أو هويتهم الجنسانية", "", "" },
                    { 288, null, "R144.73", "73.144", "", "Non réalisé", "", 0, 3, 1, null, 36, 9, null, "Examen périodique universal", "Mettre fin aux formes de discrimination (notamment juridiques) auxquelles se heurtent les lesbiennes, gays, bisexuels, transgenres et intersexués", "إنهاء أشكال التمييز (بما فيها الأشكال القانونية) التي يتعرض لها المثليات والمثليون ومزدوجو الميل الجنسي ومغايرو الهوية الجنسانية وحاملو صفات الجنسين", "", "" },
                    { 289, null, "R144.75 P1P3", "75.144. ج.1 ج.3", "", "Non réalisé", "", 0, 3, 1, null, 31, 9, null, "Examen périodique universal", "Garantir les mêmes droits à tous les citoyens, y compris ceux de la communauté des lesbiennes, gays, bisexuels, transgenres et intersexué en éliminant toutes les lois discriminatoires sur la base de l’orientation sexuelle", "ضمان تمتع جميع المواطنين بالحقوق نفسها، بمن فيهم المثليات والمثليون ومزدوجو الميل الجنسي ومغايرو الهوية الجنسانية وحاملو صفات الجنسين، ..... وإلغاء جميع التشريعات التمييزية على أساس الميل الجنسي", "", "" },
                    { 290, null, "R144.76", "76.144", "", "Non réalisé", "", 0, 3, 1, null, 45, 9, null, "Examen périodique universal", "Adopter et appliquer une 9 complète contre la discrimination qui contienne une interdiction générale de toutes formes de discrimination directe et indirecte", "تطبيق واعتماد قانون شامل لمكافحة التمييز يتضمن حظراً عاماً لجميع أشكال التمييز المباشرة منها وغير المباشرة", "", "" },
                    { 291, null, "R144.78", "78.144", "", "Non réalisé", "", 0, 3, 1, null, 1, 9, null, "Examen périodique universal", "Adopter une 9 complète contre la discrimination", "اعتماد قانون شامل لمكافحة التمييز", "", "" },
                    { 292, null, "R144.79", "79.144", "", "Non réalisé", "", 0, 3, 1, null, 6, 9, null, "Examen périodique universal", "Prendre des mesures d’urgence pour révoquer les normes qui criminalisent et stigmatisent les lesbiennes, les gays, les bisexuels, les transgenres et les intersexués, et poursuivre et punir les auteurs d’actes de discrimination et de violence à leur égard", "اتخاذ تدابير عاجلة لإلغاء الأحكام التي تجرّم وتصم المثليات والمثليين ومزدوجي الميل الجنسي ومغايري الهوية الجنسانية وحاملي صفات الجنسين، والتحقيقُ مع مرتكبي أفعال التمييز والعنف في حقهم ومعاقبتُهم", "", "" },
                    { 293, null, "R144.120", "120.144", "", "Non réalisé", "", 0, 3, 1, null, 101, 9, null, "Examen périodique universal", "Créer et maintenir, en droit et dans la pratique, un environnement sûr et favorable pour la société civile et les défenseurs des droits de l’homme, y compris au Sahara occidental et en ce qui le concerne, grâce à une révision du Code pénal, et supprimer les restrictions à la liberté d’expression, revoir le système d’enregistrement des associations et de notification des réunions et veiller à une application cohérente des règles à tous les rassemblements pacifiques indépendamment de leur objet", "إنشاء بيئة آمنة وممكّنة، في القانون والممارسة، والمحافظة عليها لفائدة المجتمع المدني والمدافعين عن حقوق الإنسان حتى في الصحراء الغربية وفيما يتعلق بها عن طريق مراجعة القانون الجنائي وإزالة القيود المفروضة على حرية التعبير واستعراض نظام تسجيل الجمعيات والإشعار بالتجمعات والتطبيق المتّسق للقواعد على جميع التجمعات السلمية بصرف النظر عن موضوعها", "", "" },
                    { 294, null, "R144.85", "85.144", "", "Non réalisé", "", 0, 3, 1, null, 45, 9, null, "Examen périodique universal", "Réviser les dispositions du Code pénal sur le terrorisme et définir les infractions liées au terrorisme plus clairement et précisément", "مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب ووضعُ تعريف أوضح وأدق للجرائم المرتبطة بالإرهاب", "", "" },
                    { 295, null, "R144.239", "239.144", "", "Non réalisé", "", 0, 3, 1, null, 44, 9, null, "Examen périodique universal", "Réexaminer complètement la 9 nationale sur les migrations et l’asile", "استعراض التشريعات الوطنية بشأن الهجرة واللجوء استعراضاً مفصلاً", "", "" },
                    { 490, null, "R9", "ت.9", "", "Non réalisé", "", 0, 3, null, 1, null, 9, null, "Organes de traités", "Le Comité recommande à l’État partie d’amender sa 9 ou d’adopter une 9 spécifique relative à l’interdiction de la discrimination raciale qui soit en pleine conformité avec l’article premier de la Convention.", "تعديل التشريعات الوطنية أو اعتماد تشريع يتناول تحديداً حظر التمييز العنصري على نحو يتماشى تماماً مع المادة 1 من الاتفاقية.", "", "" },
                    { 491, null, "R11P4", "ت.11.ف.4", "", "Non réalisé", "", 0, 3, null, 1, null, 9, null, "Organes de traités", "Envisager l’inscription dans la constitution de la langue amazigh comme langue officielle", "التفكير في إدراج اللغة الأمازيغية كلغة رسمية في الدستور", "", "" },
                    { 492, null, "R12", "ت.12", "", "Non réalisé", "", 0, 3, null, 1, null, 9, null, "Organes de traités", "clarifier la signification et la portée dans sa 9 de la notion de «prénom à caractère marocain» et garantir pleinement l’application par les officiers d’état civil de la circulaire du Ministère de l’26 de mars 2010 relative aux choix des prénoms, afin d’assurer pour tous l’inscription de prénoms, en particulier des prénoms amazighs", "توضيح معنى ونطاق مفهوم 'مغربية الاسم' في التشريعات. وضمان تطبيق ضباط الحالة المدنية لما نص عليه تعميم وزارة الداخلية المؤرخ في آذار/مارس 2010 المتعلق باختيار الأسماء والذي يضمن لجميع المواطنين تسجيل الأسماء، وخاصة الأمازيغية منها.", "", "" },
                    { 493, null, "R13P1", "ت.13.ف.1", "", "Non réalisé", "", 0, 3, null, 1, null, 9, null, "Organes de traités", "Etablir un cadre juridique et institutionnel visant à clarifier les procédures d’asile", "إنشاء إطار قانوني ومؤسسي تكون الغاية منه توضيح إجراءات اللجوء", "", "" },
                    { 494, null, "R18P1P4", "ت.18.ف1.ف.4", "", "Non réalisé", "", 0, 3, null, 1, null, 9, null, "Organes de traités", "Promouvoir la 9 relative à la discrimination raciale,Le Comité recommande en outre que dans la 9 de l’État partie la charge de la preuve soit renversée lorsque les faits de discrimination raciale relèvent de la matière civile", "تعزيز التشريع المتعلق بالتمييز العنصري .وضع عبء ا الإثبات في التشريعاتُ الوطنية على الطرف المدعى عليه بالنسبة لأفعال التمييز العنصري الواقعة في سياق قضايا مدنية", "", "" },
                    { 529, null, "R5P1", "ت.5.ف.1", "", "Non réalisé", "", 0, 3, null, 2, null, 9, null, "Organes de traités", "S’assurer que les projets de loi actuellement devant le 32étendent le champ d’application de la définition de la torture, conformément à l’article premier de la Convention contre la torture.", "العمل على أن تتضمن مشاريع القوانين المعروضة حالياً على البرلمان توسيعا لنطاق تطبيق تعريف التعذيب وفقاً للمادة الأولى من اتفاقية مناهضة التعذيب.", "", "" },
                    { 530, null, "R25P1", "ت.25.ف.1", "", "Non réalisé", "", 0, 3, null, 2, null, 9, null, "Organes de traités", "établir un cadre juridique en vue de garantir les droits des réfugiés et des demandeurs d’asile.E50", "-          وضع إطار قانوني لضمان حقوق اللاجئين وطالبي اللجوء", "", "" },
                    { 531, null, "R6P1", "ت.6.ف.1", "", "Non réalisé", "", 0, 3, null, 2, null, 9, null, "Organes de traités", "S’assurer que le cadre juridique prévoie l’interdiction de toute amnistie éventuelle des crimes de torture et de tout pardon en violation de la Convention.", "العمل على أن ينصّ الإطار القانوني على حظر أي عفو عام محتمل عن جرائم التعذيب وحظر أي عفو ينتهك الاتفاقية.", "", "" },
                    { 532, null, "R6P1", "ت.6.ف.1", "", "Non réalisé", "", 0, 3, null, 2, null, 9, null, "Organes de traités", "-            S’assurer que le cadre juridique prévoie l’interdiction de toute amnistie éventuelle des crimes de torture et de tout pardon en violation de la Convention.", "العمل على أن ينصّ الإطار القانوني على حظر أي عفو عام محتمل عن جرائم التعذيب وحظر أي عفو ينتهك الاتفاقية.", "", "" },
                    { 533, null, "R7P1", "ت.7.ف.1", "", "Non réalisé", "", 0, 3, null, 2, null, 9, null, "Organes de traités", "-            Veiller à ce que les projets de loi actuellement à l’étude garantissent à toute personne suspectée le droit de bénéficier dans la pratique des garanties fondamentales prévues par la loi, qui incluent notamment que l’intéressé ait accès à un avocat dès son arrestation, qu’il soit examiné par un médecin indépendant, qu’il puisse contacter un proche, qu’il soit informé de ses droits – comme des charges retenues contre lui –, et qu’il soit présenté immédiatement devant un juge.", "-          الحرص على أن تتضمن مشاريع القوانين قيد البحث حالياً لكل مشتبه فيه الحق في الاستفادة عملياً من الضمانات الأساسية التي ينص عليها القانون والتي تشمل الحق في الوصول إلى محام لحظة إيقافه، وفي أن يتولى طبيب مستقل فحصه، وفي أن يتمكن من الاتصال بأحد أقاربه، وفي أن يطلع على حقوقه وعلى التهم الموجهة إليه كذلك، وفي أن يُعرض فوراً على قاض.", "", "" },
                    { 534, null, "R23P1P3", "ت.23.ف.1.ف.3", "", "Non réalisé", "", 0, 3, null, 2, null, 9, null, "Organes de traités", "Promulguer au plus vite une 9 sur la violence faite aux femmes et aux filles de manière à ériger en infractions pénales toutes les formes de violence à l’encontre des femmes. Modifier sans plus tarder le Code pénal de manière à criminaliser le viol conjugal et à s’assurer que les auteurs de viols n’échappent pas aux poursuites pénales quand ils épousent leur victime", "سنّ قانون في أسرع وقت بشأن العنف المرتكب في حق النساء والفتيات، بصفة تجرم جميع أشكال العنف ضد النساء.  تعديل، القانون الجنائي بصفة تجرم الاغتصاب في إطار الزواج وضمان عدم إفلات المغتصبين من الملاحقة الجنائية في حالة زواجهم من الضحية", "", "" },
                    { 535, null, "R25P1", "ت.25.ف.1", "", "Non réalisé", "", 0, 3, null, 2, null, 9, null, "Organes de traités", "établir un cadre juridique en vue de garantir les droits des réfugiés et des demandeurs d’asile.", "وضع إطار قانوني لضمان حقوق اللاجئين وطالبي اللجوء", "", "" },
                    { 536, null, "R27P1", "ت.27.ف.1", "", "Non réalisé", "", 0, 3, null, 2, null, 9, null, "Organes de traités", "Intensifier les efforts pour prévenir et combattre la traite des femmes et des enfants, notamment en adoptant une loi spécifique sur la prévention, la répression de la traite et la protection des victimes,", "-          تكثيف الجهود لمنع ومكافحة الاتجار بالنساء والأطفال، لا سيما عن طريق سن قانون محدد بشأن منع حدوثه", "", "" },
                    { 164, null, "R91P2", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 6, "Procédure spéciale", "Institutionnaliser, en modifiant les lois sur les élections, les mesures spéciales visant à augmenter le nombre de femmes aux postes électifs, aux niveaux national et local, de façon à satisfaire aux normes internationales ; - les listes nationales dans lesquelles un nombre déterminé de sièges est réservé aux femmes devraient être conservées et les quotas augmentés. - Les femmes devraient avoir la possibilité de présenter leur candidature pour une réélection sur les listes nationales. - Une augmentation des quotas, qui réponde aux normes internationales, devrait être effectuée dans les élections locales", "null", "", "" },
                    { 163, null, "R91P1", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 6, "Procédure spéciale", "Accélérer l’élaboration des lois organiques appelées à définir les conditions et les modalités d’exercice, par tous les citoyens, femmes et hommes du droit de présenter des motions en matière législative et des pétitions aux pouvoirs publics; de telles lois devraient prévoir des mesures spéciales pour renforcer l’accès effectif des femmes pauvres et marginalisées à ce droit, y compris la mobilisation de ressources pour le renforcement des capacités des groupes locaux de femmes", "null", "", "" },
                    { 162, null, "R89P4P5", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 6, "Procédure spéciale", "Combler les lacunes dans la protection juridique des droits des femmes et des groupes qui ont besoin d’une protection particulière, notamment les travailleurs domestiques et les travailleurs migrants, et faire en sorte que les groupes de femmes vulnérables bénéficient de l’égale protection de la loi. - Les projets de loi sur la violence à l’égard des femmes et la violence au foyer devraient être réexaminés à la lumière des observations finales du Comité contre la torture. Le Code pénal, qui est en cours de modification, devrait être revu dans le sens du respect des principes et des normes internationaux et adopté. Ses articles 475 et 490 devraient être abrogés- Entamer un examen complet de l’application de toutes les lois et dispositions préjudiciables aux femmes et aux filles, y compris, entre autres, le Code de la famille, le Code de la nationalité, le Code pénal et le Code du travail. Cet examen devrait se faire avec la participation active des organisations de la société civile, notamment celles qui ont suivi les décisions des tribunaux dans des affaires relatives au mariage précoce et à la polygamie ;", "null", "", "" },
                    { 136, null, "R92", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 4, "Procédure spéciale", "Une réforme pénale devrait être entreprise et des systèmes de protection des victimes et des témoins devraient être institués. - Parallèlement à la réforme pénale, des modifications devraient être apportées au Code pénal et un cadre juridique plus vaste devrait être établi, qui exempte les victimes de la traite des peines encourues pour prostitution, pour immigration illégale et pour d’autres infractions connexes résultant directement de la traite", "null", "", "" },
                    { 743, null, "R65 P5", "ت.65.ف.5", "", "Non réalisé", "", 0, 2, null, 7, null, 7, null, "Organes de traités", "Solliciter à cet égard l’assistance technique du programme international sur l’élimination du travail des enfants de l’OIT", "(ه) التماس المساعدة التقنية في هذا الصدد من البرنامج الدولي لمنظمة العمل الدولية للقضاء على عمل الأطفال", "", "" },
                    { 744, null, "R71", "ت.71", "", "Non réalisé", "", 0, 2, null, 7, null, 7, null, "Organes de traités", "Donner suite aux recommandations qui figurent dans ses observations finales concernant le rapport initial du Maroc au titre du Protocole facultatif à la Convention relative aux droits de l’enfant, concernant la vente d’enfants, la prostitution des enfants et la pornographie mettant en scène des enfants, et faire figurer des informations complètes à cet égard dans son prochain rapport périodique.", "-          نفيذ التوصيات الواردة في ملاحظات اللجنة الختامية بشأن تقرير الدولة الطرف الأولي بمقتضى البروتوكول الاختياري المتعلق ببيع الأطفال واستغلال الأطفال في البغاء وفي المواد الإباحية وتقديم معلومات شاملة في هذا الصدد في تقريرها الدوري القادم.", "", "" },
                    { 745, null, "R75P6", "ت.75.ف.6", "", "Non réalisé", "", 0, 2, null, 7, null, 7, null, "Organes de traités", @"Le Comité exhorte le Maroc à mettre son système de justice pour mineurs en totale conformité avec la Convention, en particulier avec les articles 37, 39 et 40, ainsi qu’avec d’autres normes applicables et avec l’Observation générale no 10 (2007) du Comité sur les droits de l’enfant dans le système de justice pour mineurs. Il exhorte en particulier le Maroc à:
                f) Utiliser les outils d’assistance technique mis au point par le groupe inter institutions sur la justice pour mineurs et ses membres, notamment l’Office des Nations Unies contre la drogue et le crime.", @"تحث اللجنة المملكة لمغربية على التوفيق التام بين نظامها لعدالة الأحداث والاتفاقية، لا سيما المواد 37 و39 و40، وكذلك مع معايير أخرى متصلة بالموضوع ومع تعليق اللجنة العام رقم 10(2007) بشأن حقوق الطفل في قضاء الأحداث. وتحثها خاصة على الآتي:
                -  (و) توظيف أدوات المساعدة التقنية التي وضعها الفريق المشترك بين الوكالات المعني بقضاء الأحداث وأعضاؤه، بما في ذلك مكتب الأمم المتحدة المعني بالمخدرات والجريمة.", "", "" },
                    { 746, null, "R78", "ت.78", "", "Non réalisé", "", 0, 2, null, 7, null, 7, null, "Organes de traités", @"Soumettre les cinquième et sixième rapports en un seul document d’ici à juillet 2020 et à y faire figurer des informations sur la suite donnée aux présentes observations finales. 
                - Le rapport devrait être conforme aux directives harmonisées du Comité pour l’établissement des rapports portant spécifiquement sur l’application de la Convention, adoptées le 1er octobre 2010 (CRC/C/58/Rev.2 et Corr.1) et ne devrait pas excéder 21 200 mots (voir résolution 68/268 de l’Assemblée générale, par. 16). 
                - Si l’État partie soumet un rapport dont le nombre de pages dépasse la limite fixée, il sera invité à le raccourcir et à le soumettre à nouveau conformément à la résolution susmentionnée. S’il n’est pas en mesure de remanier son rapport et de le soumettre à nouveau, la traduction de ce rapport aux fins d’examen par le Comité ne pourra être garantie", @"تقديم التقرير الجامع للتقريرين الدوريين الثالث والرابع بحلول 20 تموز/يوليه 2020 وتضمينه معلومات عن متابعة هذه الملاحظات. 
                - التقيد في إعداد التقرير بالمبادئ التوجيهية المنسقة لتقديم التقارير الخاصة بمعاهدة بعينها، التي اعتمدتها اللجنة في 1 تشرين الأول/أكتوبر 2010 (الوثيقتان CRC/C/58/Rev.2 وCorr.1)، وألا يتجاوز عدد كلماتها 200 21 كلمة (انظر قرار الجمعية العامة رقم 68/268، الفقرة 16). 
                - إن تجاوز عدد كلمات التقرير المقدَّم الحد الأقصى المنصوص عليه، طُلب من الدولة الطرف أن تقلّص حجمه عملاً بالقرار السالف الذكر. وإذا تعذّر على الدولة الطرف مراجعة التقرير وتقديمه من جديد، لم يمكن تأمين ترجمة التقرير كي تنظر فيه هيئة المعاهدة.", "", "" },
                    { 747, null, "R79", "ت.79", "", "Non réalisé", "", 0, 2, null, 7, null, 7, null, "Organes de traités", @"Soumettre un document de base actualisé conformément aux prescriptions applicables au document de base figurant dans les directives harmonisées pour l’établissement de rapports, qui ont été approuvées en juin 2006 à la cinquième réunion intercomités des organes créés en vertu d’instruments internationaux relatifs aux droits de l’homme (HRI/GEN/2/Rev.6, chap. I). 
                - La limite fixée pour le document de base commun est de 42 400 mots, comme l’a décidé l’Assemblée générale dans sa résolution 68/268 (par. 16).", @"تقديم وثيقة أساسية محدَّثة وفقاً لمتطلبات الوثيقة الأساسية المشتركة الواردة في المبادئ التوجيهية المنسقة لتقديم التقارير، كما أقرها الاجتماع الخامس المشترك بين لجان هيئات معاهدات حقوق الإنسان في حزيران/يونيه 2006 (الوثيقة HRI/GEN/2/Rev.6، الفصل الأول). 
                - يصل الحد الأقصى لعدد الكلمات في الوثيقة الأساسية المشتركة إلى 400 42 كلمة، وفقاً لما حددته الجمعية العامة في قرارها رقم 68/268 (الفقرة 16).", "", "" },
                    { 809, null, "P65", "ت.65", "", "Non réalisé", "", 0, 2, null, 8, null, 7, null, "Organes de traités", "-                    faire parvenir au Comité, dans un délai de douze mois, des renseignements sur l’adoption des présentes observations finales et, conformément au paragraphe 2 de l’article 35 de la Convention, sur les mesures prises pour mettre en œuvre les recommandations figurant aux paragraphes 11 et 15.", "موافاة اللجنة المعنية، في غضون 12 شهراً من اعتماد هذه الملاحظات الختامية ووفقاً للمادة 35(2) من الاتفاقية، بمعلومات عن التدابير المتخذة لتنفيذ توصيات اللجنة الواردة في الفقرتين 11 و15.", "", "" },
                    { 810, null, "R66", "ت.66", "", "Non réalisé", "", 0, 2, null, 8, null, 7, null, "Organes de traités", @"mettre en œuvre les recommandations figurant dans les présentes observations finales. 
                - transmettre les présentes observations finales, pour examen et suite à donner, aux membres du Gouvernement et du 32, aux responsables des différents ministères, aux autorités locales, aux organisations de personnes handicapées et aux membres des professions concernées, tels les professionnels de l’éducation, de la santé et du droit, ainsi qu’aux médias, en utilisant pour ce faire les stratégies de communication sociale modernes", @"تنفيذ التوصيات الواردة في هذه الملاحظات الختامية. 
                - إحالة هذه الملاحظات الختامية، للنظر فيها واتخاذ إجراءات بشأنها، إلى أعضاء الحكومة والبرلمان والمسؤولين في الوزارات المختصة والسلطات المحلية ومنظمات الأشخاص ذوي الإعاقة وأعضاء المجموعات المهنية المعنية، مثل العاملين في التعليم والمهن الطبية والقانونية، وكذلك إلى وسائط الإعلام، باستخدام استراتيجيات التواصل الاجتماعي الحديثة", "", "" },
                    { 811, null, "R67", "ت.67", "", "Non réalisé", "", 0, 2, null, 8, null, 7, null, "Organes de traités", "-                    associer les organisations de la société civile, en particulier les organisations de personnes handicapées, à l’élaboration de ses rapports périodiques.", "-           إشراك منظمات المجتمع المدني، ولا سيما منظمات الأشخاص ذوي ��لإعاقة، في إعداد التقرير الدوري.", "", "" },
                    { 812, null, "R69", "ت.69", "", "Non réalisé", "", 0, 2, null, 8, null, 7, null, "Organes de traités", @"soumettre le rapport valant deuxième à quatrième rapports périodiques le 2 mai 2023 au plus tard et d’y faire figurer des renseignements sur la mise en œuvre des recommandations formulées dans les présentes observations finales. 
                - envisager de soumettre ce rapport selon la procédure simplifiée de présentation des rapports, dans le cadre de laquelle le Comité établit une liste de points au moins un an avant la date prévue pour la soumission du rapport. Les réponses de l’État partie à cette liste de points constituent son rapport périodique", @"تقديم التقرير الجامع للتقارير الدورية الثاني إلى الرابع بحلول 2 أيار/مايو 2023 وتضمينه معلومات عن تنفيذ التوصيات الواردة في هذه الملاحظات الختامية. 
                - النظر في تقديم التقارير المذكورة أعلاه عملاً بإجراء اللجنة المبسط لتقديم التقارير، الذي تعد اللجنة بموجبه قائمة مسائل قبل التاريخ المحدد لتقديم تقرير الدولة الطرف أو تقاريرها الموحدة بسنة واحدة على الأقل. وتشكل ردود الدولة الطرف على قائمة المسائل هذه تقريرها.", "", "" },
                    { 489, null, "R22", "ت.22", "", "Non réalisé", "", 0, 2, null, 1, null, 8, null, "Organes de traités", "A la lumière de sa Recommandation générale no. 33 (2009) sur le suivi de la Conférence d’examen de Durban, le Comité recommande à l’État partie de tenir compte de la Déclaration et du Programme d’action de Durban adoptés en septembre 2001 par la Conférence mondiale contre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, ainsi que du document final de la Conférence d’examen de Durban, qui s’est tenue à Genève en avril 2009, lorsqu’il applique la Convention dans son ordre juridique interne.", "القيان بإنفاذ إعلان وبرنامج عمل ديربان اللذين اعتمدا في أيلول/سبتمبر 2001 أثناء المؤتمر العالمي لمناهضة العنصرية والتمييز العنصري وكراهية الأجانب وما يتصل بذلك من تعصب، على ضوء توصية اللجنة العامة رقم 33(2009) بشأن متابعة مؤتمر استعراض نتائج ديربان، مع مراعاة الوثيقة الختامية لهذا المؤتمر  الذي عُقد في جنيف في نيسان/أبريل 2009، عندما تكون بصدد إدراج أحكام الاتفاقية في نظامها القانوني الداخلي. وتطلب اللجنة إلى الدولة الطرف أن تورد في تقريرها الدوري المقبل معلومات محددة عن خطط العمل وغيرها من التدابير المتخذة لتنفيذ إعلان وبرنامج عمل ديربان على الصعيد الوطني.", "", "" },
                    { 2, null, "R66P1", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 1, "Procédure spéciale", "-   Élaborer et adopter une loi-cadre relative au droit à l’alimentation prévoyant des plans de mise en œuvre pour chaque région ainsi qu’un calendrier des opérations. Cette loi devrait également prévoir les mesures budgétaires et fiscales nécessaires afin d’être viable dans la durée", "null", "", "" },
                    { 3, null, "R92", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 1, "Procédure spéciale", "-   Adopter au plus vite le projet de loi n o 97.13 relatif à la protection et à la promotion des droits des personnes en situation de handicap, actuellement examiné par le 32, afin de garantir la protection juridique des personnes handicapées", "null", "", "" },
                    { 43, null, "R71", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 2, "Procédure spéciale", "-       Adopter des dispositions législatives et des mesures concrètes pour faire en sorte que l’élimination du racisme, de la discrimination raciale, de la xénophobie et de l’intolérance qui y est associée soit intégrée aux travaux et au mandat des organes chargés de promouvoir les droits de l’homme, l’égalité et la non-discrimination.", "null", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 580, null, "R8", "ت.8", "", "Non réalisé", "", 0, 3, null, 3, null, 9, null, "Organes de traités", "Rappelant l’observation générale no 29 (2001) sur les dérogations au Pacte en période d’état d’urgence, le Royaume du Maroc est appelé à :", "سنّ تشريع يتضمن أحكاماً واضحة عن حالة الطوارئ بحيث لا يمكن تعطيل العمل بالحقوق التي تحميها الفقرة 2 من المادة 4 من العهد بأي حال من الأحوال، وكفالة تَوافق مقتضيات أي استثناء من ذلك مع العهد، عملا بما جاء في التعليق العام للجنة رقم 29(2001) بشأن عدم التقيّد بأحكام العهد أثناء حالات الطوارئ.", "", "" },
                    { 44, null, "R78P1", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 2, "Procédure spéciale", "-       Adopter sans délai la loi organique nécessaire pour donner à l’amazigh le statut constitutionnel de langue officielle", "null", "", "" },
                    { 82, null, "R87P2", "ت.87.ف.2", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    Modifier l’article 224 du Code pénal pour mettre la définition du fonctionnaire public en conformité avec la définition de l’agent de la 21 ou toute autre personne agissant à titre officiel qui figure dans la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "-          (ب) تعديل المادة 224 من القانون الجنائي بحيث يتوافق تعريف الموظف العمومي مع تعريف موظف الخدمة المدنية أو غيره من الأشخاص الذين يعملون بصفة رسمية، الوارد في اتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة؛", "", "" },
                    { 83, null, "R87P3", "ت.87.ف.3", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    veiller à ce qu’aucune personne reconnue coupable d’actes de torture ou faisant l’objet de poursuites pour de tels actes ne puisse bénéficier d’une mesure d’amnistie", "-          (ج)  التأكد من عدم استفادة أي شخص مدان أو محكوم عليه بسبب ارتكابه جريمة التعذيب من أي عفو؛", "", "" },
                    { 84, null, "R87P4", "ت.87.ف.4", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    inclure dans le Code pénal une disposition expresse établissant que l’ordre d’un supérieur ou d’une autorité publique ne peut être invoqué pour justifier la torture, et mettre en place un mécanisme pour la protection des subordonnés qui refusent d’obéir à un ordre visant à torturer une personne en détention", "-          (د) إدراج حكم محدد في القانون الجنائي ينص على أنه لا يجوز الاحتجاج بصدور أمر من موظف سام أو سلطة عامة لتبرير التعذيب، وتوفير آلية لحماية المرؤوسين الذين يرفضون إطاعة أوامر تعذيب أشخاص محتجزين لديهم؛", "", "" },
                    { 85, null, "R87P5", "ت.87.ف.5", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier la loi (no 03-03) contre le terrorisme de façon à réduire le délai de garde à vue de quatre-vingt-seize heures (renouvelables deux fois)", "-          (ﻫ) تعديل قانون مكافحة الإرهاب (03-03) لتقليص مدة الحبس الاحتياطي البالغة 96 يوماً (والقابلة للتجديد مرتين)؛", "", "" },
                    { 86, null, "R87P6", "ت.87.ف.6", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier l’article 290 du Code de procédure pénale de façon à appliquer aux infractions pénales la règle de la preuve qui régit les délits et contraventions afin que tous les rapports établis par la police pour des procès pénaux soient considérés comme des éléments de preuve parmi d’autres sans présomption quant à leur véracité", "-          (و) مراجعة المادة 290 من قانون الإجراءات الجنائية كي تشمل معايير الاستدلال، التي تحكم الجرائم والتي يُعمل بها أصلاً، الجنحَ والمخالفات، بحيث يُتعامل مع جميع بيانات المحاكمات الجنائية التي تعدها الشرطة على أنها دليل واحد في جملة أدلة، دون افتراض صدقها؛", "", "" },
                    { 87, null, "R87P7", "ت.87.ف.7", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier le Code de procédure pénale pour qu’il dispose qu’en cas d’allégation de torture ou de mauvais traitements, la charge de la preuve incombe à l’accusation, qui doit montrer au-delà de tout doute raisonnable que les aveux soumis au tribunal n’ont pas été obtenus par des moyens illicites", "-          (ز) تعديل قانون الإجراءات الجنائية بحيث ينص على أنه متى كان ادعاء بالتعذيب أو سوء المعاملة، كان على الادعاء أن يثبت، دون أي شك معقول، أن كل اعتراف من الاعترافات لم يُنتزع بأساليب غير مشروعة؛", "", "" },
                    { 88, null, "R87P8", "ت.87.ف.8", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier l’article 84 de la loi (no 23/98) sur les prisons de façon à habiliter les directeurs régionaux à autoriser les organisations de la société civile à visiter les établissements pénitentiaires, et de modifier l’article 10 du décret d’application de la loi no 23/98 afin d’élargir le champ des activités des organisations non gouvernementales dans ce domaine", "-          (ح) تعديل المادة 84 من قانون السجون (رقم 23/98) بحيث يخول المديرين الإقليميين سلطة الترخيص لمنظمات المجتمع المدني بزيارة المؤسسة؛ وتعديل المادة 10 من المرسوم التنفيذي للقانون رقم 23/98 بحيث توسع نطاق أنشطة المنظمات غير الحكومية في هذا المجال؛", "", "" },
                    { 89, null, "R87P9", "ت.87.ف.9", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier l’article 134 du Code pénal pour faire en sorte que les auteurs d’infraction souffrant d’une maladie mentale soient placés dans un établissement psychiatrique, quelle que soit la gravité de l’infraction commise", "-          (ط) تعديل المادة 134 من القانون الجنائي بحيث تنص على إيداع جميع المجرمين المصابين بخلل عقلي في مصحة نفسية، بصرف النظر عن درجة خطورة الجرم.", "", "" },
                    { 90, null, "R91P2", "ت.91.ف.2", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    Modifier l’article 473 du Code de procédure pénale de façon à porter de 12 à 18 ans l’âge auquel un délinquant mineur peut être emprisonné et à souligner que l’emprisonnement des délinquants mineurs est une mesure exceptionnelle ;", "فيما يتعلق بالأحداث، يوصي المقرر الخاص الحكومة بما يلي:  (ب) تعديل المادة 473 من قانون الإجراءات الجنائية لزيادة العمر الذي يُسمح فيه بسجن الحدث الجانح من 12 إلى 18 عاماً، والتشديد على أن سجن الأحداث الجانحين إجراء استثنائي؛", "", "" },
                    { 91, null, "R88P2", "ت.88.ف.2", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    Assurer, par des modifications apportées à la législation, que l’accès à un avocat choisi par le suspect lui-même soit garanti dès l’arrestation, sans surveillance policière et sans avoir à obtenir l’autorisation préalable du Procureur, y compris en cas de menace contre la sécurité et de terrorisme. Cet accès doit être accordé en application de la loi et tout fonctionnaire qui refuserait de l’accorder devrait être sanctionné", "ب) التأكد، بواسطة تعديل التشريعات، من أن توكيل المحامين من اختيار المشتبه فيهم مكفول منذ اللحظة الأولى من إلقاء القبض، دون حضور محقق ودون اشتراط إذن من المدعي العام، بما في ذلك قضايا تهديد الأمن القومي والإرهاب. وينبغي منح ذلك الحق قانوناً، وتأديب كل موظف يحول دون ذلك؛", "", "" },
                    { 133, null, "R80P2", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 4, "Procédure spéciale", "-    Accélérer l’adoption des modifications à apporter au Code pénal, puis à promulguer et à appliquer des textes législatifs spécifiques contre la traite, dans un délai déterminé", "null", "", "" },
                    { 134, null, "R87", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 4, "Procédure spéciale", "-    Tout projet de modification ou de loi relative à la traite des êtres humains devrait être axé sur une approche fondée sur les droits de l’homme et comporter des dispositions relatives à l’indemnisation des victimes et aux recours effectifs dont celles-ci disposent.", "null", "", "" },
                    { 135, null, "R80P3/R88P1", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 4, "Procédure spéciale", "-    Le champ d’application de la législation du travail devrait être élargi de sorte que les employés de maison bénéficient d’une protection suffisante.", "null", "", "" },
                    { 81, null, "R87P1", "ت.87.ف.1", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "Modifier l’article 231-1 du Code pénal pour faire en sorte que la complicité ou le consentement exprès ou tacite des fonctionnaires chargés d’appliquer la loi et des forces de sécurité ou de toute autre personne agissant à titre officiel soient expressément visés", "-          (أ) تعديل المادة 231-1 من القانون الجنائي بحيث تشمل تحديداً تواطؤ موظفي إنفاذ القانون أو غيرهم من الأشخاص الذين يتصرفون بصفة رسمية أو موافقتهم الصريحة أو الضمنية؛", "", "" },
                    { 742, null, "R57P4", "ت.57.ف.4", "", "Non réalisé", "", 0, 2, null, 7, null, 7, null, "Organes de traités", @"Renvoyant à son Observation générale no 4 (2003) sur la santé et le développement de l’adolescent, le Comité demande instamment à l’État partie:
                d) De solliciter une assistance technique auprès, entre autres, du Programme commun des Nations Unies sur le VIH/sida (ONUSIDA) et l’UNICEF.", @"تشير اللجنة إلى تعليقها العام رقم 4(2003) بشأن صحة المراهقين ونموهم، وتحث الدولة الطرف على ما يلي:
                - (د) التماس المساعدة التقنية من جهات مثل برنامج الأمم المتحدة المشترك بين منظمات الأمم المتحدة لمكافحة الإيدز واليونيسيف", "", "" },
                    { 581, null, "R8", "ت.8", "", "Non réalisé", "", 0, 3, null, 3, null, 9, null, "Organes de traités", "- Elaborer une 9 comportant des dispositions claires sur l’état d’exception, de façon à ce que les droits protégés par le paragraphe 2 de l’article 4 du Pacte ne puissent être suspendus en aucune circonstance,", "سنّ تشريع يتضمن أحكاماً واضحة عن حالة الطوارئ بحيث لا يمكن تعطيل العمل بالحقوق التي تحميها الفقرة 2 من المادة 4 من العهد بأي حال من الأحوال، وكفالة تَوافق مقتضيات أي استثناء من ذلك مع العهد، عملا بما جاء في التعليق العام للجنة رقم 29(2001) بشأن عدم التقيّد بأحكام العهد أثناء حالات الطوارئ.", "", "" },
                    { 583, null, "R26", "ت.26", "", "Non réalisé", "", 0, 3, null, 3, null, 9, null, "Organes de traités", "L’État partie devrait veiller à ce que la réforme législative en cours fixe la durée normale de la garde à vue à quarante-huit heures et garantisse à toute personne arrêtée l’accès immédiat à un avocat dès le début de la détention.", "الحرص على أن يحدد الإصلاح التشريعي الجاري المدة العادية للاحتجاز لدى الشرطة بـ 48 ساعة، ويتيح  لكل شخص يلقى عليه القبض إمكانية توكيل محام منذ بداية الاحتجاز.", "", "" },
                    { 195, null, "R83P3", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 7, "Procédure spéciale", "-       Modifier la loi antiterroriste (no 03-03) en vue de remédier à la définition vague du crime de terrorisme et de réduire la durée de la garde à vue qui est de quatre-vingt-seize heures renouvelables deux fois", "null", "", "" },
                    { 196, null, "R83P4", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 7, "Procédure spéciale", "Modifier le Code de procédure pénale pour indiquer qu’en cas d’allégation de torture ou de mauvais traitements, la charge de la preuve incombe à l’accusation qui devra prouver, hors de tout doute raisonnable, que les aveux n’ont pas été obtenus par des moyens illégaux. - Les allégations de torture et de mauvais traitements devraient être admises à n’importe quel stade du procès et les tribunaux devraient être tenus de lancer des enquêtes d’office chaque fois qu’il y a des motifs raisonnables de suspecter des actes de torture ou de mauvais traitements", "null", "", "" },
                    { 197, null, "R83P21", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 7, "Procédure spéciale", "-       Étudier l’amendement de l’article 473 du Code de procédure pénale visant à reculer l’âge auquel un jeune délinquant peut être incarcéré de12à 18 ans, et souligner que l’emprisonnement des jeunes délinquants est une mesure exceptionnelle ;", "null", "", "" },
                    { 198, null, "R83P24", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 7, "Procédure spéciale", "-       Envisager de modifier l’article 134 du Code pénal afin de s’assurer que tous les délinquants souffrant d’une incapacité mentale soient placés dans un établissement psychiatrique, quelle que soit la gravité de l’infraction", "null", "", "" },
                    { 243, null, "R73P6-2", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 9, "Procédure spéciale", "Envisager de faire figurer des dispositions sur la question relative à la mise  en place un cadre de suivi des fonds étrangers reçus par les acteurs de la société civile dans le projet de loi sur la société civile, conformément aux normes internationales relatives aux droits de l’homme mentionnées dans le rapport du Rapporteur spécial sur le droit de réunion pacifique et la liberté d’association (A/HRC/23/39)", "null", "", "" },
                    { 296, null, "R144.31", "31.144", "", "Non réalisé", "", 0, 3, 1, null, 32, 10, null, "Examen périodique universal", "Faire en sorte que le Code pénal soit pleinement en conformité avec le Pacte international relatif aux droits civils et politiques", "ضمان أن يكون القانون الجنائي متوافقاً تماماً مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 297, null, "R144.35", "35.144", "", "Non réalisé", "", 0, 3, 1, null, 40, 10, null, "Examen périodique universal", "Prendre des mesures pour mettre la définition de la torture en conformité avec celle énoncée dans la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "اتخاذ خطوات لجعل تعريف التعذيب متوافقاً مع متطلبات اتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة", "", "" },
                    { 298, null, "R144.86", "86.144", "", "Non réalisé", "", 0, 3, 1, null, 2, 10, null, "Examen périodique universal", "Réviser les dispositions du Code pénal sur le terrorisme en vue de définir précisément les infractions liées au terrorisme et veiller à ce que la 9 soit en conformité avec le Pacte international relatif aux droits civils et politiques", "مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب بغية وضع تعريف دقيق للجرائم المرتبطة بالإرهاب، وضمان أن تكون التشريعات متسقة مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 299, null, "R144.86", "86.144", "", "Non réalisé", "", 0, 3, 1, null, 2, 10, null, "Examen périodique universal", "Réviser les dispositions du Code pénal sur le terrorisme en vue de définir précisément les infractions liées au terrorisme et veiller à ce que la législation soit en conformité avec le Pacte international relatif aux droits civils et politiques", "مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب بغية وضع تعريف دقيق للجرائم المرتبطة بالإرهاب، وضمان أن تكون التشريعات متسقة مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 300, null, "R144.116", "116.14", "", "Non réalisé", "", 0, 3, 1, null, 70, 10, null, "Examen périodique universal", "Examiner les dispositions du Code pénal relatives à la liberté d’expression à la lumière de l’article 19 du Pacte international relatif aux droits civils et politiques", "استعراض أحكام القانون الجنائي المتعلقة بحرية التعبير بما يتوافق مع المادة 19 من العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 301, null, "R144.12 P2", "12.144ج.2", "", "Non réalisé", "", 0, 3, 1, null, 8, 10, null, "Examen périodique universal", "mettre la législation nationale en conformité avec les dispositions du Statut de Rome de la Cour pénale internationale", "...... جعل التشريعات الوطنية متسقة مع أحكام نظام روما الأساسي للمحكمة الجنائية الدولية", "", "" },
                    { 302, null, "R144.14 P2", "14.144ج.2", "", "Non réalisé", "", 0, 3, 1, null, 53, 10, null, "Examen périodique universal", "rendre la législation nationale pleinement conforme au Statut de Rome de la Cour pénale internationale, comme cela a été recommandé précédemment", "......جعل التشريعات الوطنية متسقة مع أحكام نظام روما الأساسي للمحكمة الجنائية الدولية وفق ما تمّت التوصية به سابقاً", "", "" },
                    { 303, null, "R144.14 P2", "14.144ج.2", "", "Non réalisé", "", 0, 3, 1, null, 53, 10, null, "Examen périodique universal", "rendre lalégislation nationale pleinement conforme au Statut de Rome de la Cour pénale internationale, comme cela a été recommandé précédemment", "......جعل التشريعات الوطنية متسقة مع أحكام نظام روما الأساسي للمحكمة الجنائية الدولية وفق ما تمّت التوصية به سابقاً", "", "" },
                    { 304, null, "R144.15 P2", "15.144. ج.2", "", "Non réalisé", "", 0, 3, 1, null, 65, 10, null, "Examen périodique universal", "adapter pleinement sa législation à toutes les obligations énoncées dans le Statut de Rome de la Cour pénale internationale", "...... التشريعات الوطنية متسقة اتساقاً كاملاً مع جميع الالتزامات الناشئة عن نظام روما الأساسي للمحكمة الجنائية الدولية", "", "" },
                    { 305, null, "R144.36P2", "36.144. ج.2", "", "Non réalisé", "", 0, 3, 1, null, 42, 10, null, "Examen périodique universal", "mettre la législation nationale en conformité avec le Statut de Rome de la Cour pénale internationale", "......مواءمة التشريعات مع أحكامه نظام روما الأساسي للمحكمة الجنائية الدولية", "", "" },
                    { 306, null, "R144.112", "112.144", "", "Non réalisé", "", 0, 3, 1, null, 98, 10, null, "Examen périodique universal", "Veiller à ce que les dispositions pertinentes du Code pénal soient mises en conformité avec les obligations du Maroc en vertu du Pacte international relatif aux droits civils et politiques, en particulier en ce qui concerne la liberté d’expression et d’opinion", "ضمان جعل الأحكام ذات الصلة من قانون المسطرة الجنائية أو من القانون الجنائي متماشية مع التزامات المغرب الناشئة عن العهد الدولي الخاص بالحقوق المدنية والسياسية ولا سيما فيما يتعلق بحرية الكلام والرأي", "", "" },
                    { 307, null, "R144.103", "103.144", "", "Non réalisé", "", 0, 3, 1, null, 20, 10, null, "Examen périodique universal", "Accélérer le processus de révision du cadre juridique régissant les prisons afin de l’harmoniser avec les normes internationales", "تسريع عملية مراجعة الإطار القانوني الذي ينظم السجون بهدف مواءمته مع المعايير الدولية", "", "" },
                    { 308, null, "R144.106", "106.144", "", "Non réalisé", "", 0, 3, 1, null, 68, 10, null, "Examen périodique universal", "Accélérer le processus de révision du cadre législatif régissant les prisons en vue de l’harmoniser avec la Constitution de 2011 et les normes internationales", "تسريع عملية مراجعة الإطار التشريعي الذي ينظم السجون بغية مواءمته مع دستور عام 2011 ومع المعايير الدولية", "", "" },
                    { 309, null, "R144.240", "240.144", "", "Non réalisé", "", 0, 3, 1, null, 67, 10, null, "Examen périodique universal", "Accélérer l’examen du cadre juridique en matière de migration et d’asile afin de l’aligner sur le Pacte international relatif aux droits civils et politiques", "تسريع استعراض الإطار القانوني المتعلق بالهجرة واللجوء بهدف مواءمته مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 495, null, "R8", "ت.8", "", "Non réalisé", "", 0, 3, null, 1, null, 10, null, "Organes de traités", "Consacrer dans la constitution le principe de la primauté des traités internationaux sur la 9 interne, afin de lui donner une portée générale et de permettre aux justiciables d’invoquer devant les tribunaux les dispositions pertinentes de la Convention.", "تكريس مبدأ أسبقية المعاهدات الدولية على التشريعات الداخلية في الدستور حتى تعطي لهذا المبدأ قوةً حجية عامة ويتمكن بذلك المتقاضون الاعتداد أمام المحاكم بأحكام الاتفاقية ذات الصلة بقضاياهم.", "", "" },
                    { 496, null, "R10", "ت.10", "", "Non réalisé", "", 0, 3, null, 1, null, 10, null, "Organes de traités", "Inclure dans le Code pénal des dispositions donnant pleinement effet à l’article 4 de la Convention, en particulier une incrimination spécifique sur la diffusion d’idées racistes. prévoir dans sa 9 pénale le motif raciste comme circonstance aggravante de la discrimination raciale.", "إدراج أحكام في القانون الجنائي تفعل المادة 4 من الاتفاقية تفعيلاً كاملاً، وبخاصة تجريم نشر الأفكار العنصرية على وجه التحديد، وذلك في إطار الإصلاح العام المقبل لنظام العدالة وفق التوصية العامة  رقم 1(1972) و7(1985) و15(1993) التي أضفت على أحكام المادة 4 طابعاً آمراً ووقائياً.إ دراج الدافع العنصري بوصفه ظرفاً مشدداً للتمييز العنصري في التشريعات الجنائية", "", "" },
                    { 497, null, "R10", "ت.10", "", "Non réalisé", "", 0, 3, null, 1, null, 10, null, "Organes de traités", "null", "null", "", "" },
                    { 498, null, "R16", "ت.16", "", "Non réalisé", "", 0, 3, null, 1, null, 10, null, "Organes de traités", "réviser le Code de la nationalité afin de permettre à la femme marocaine de transmettre sa nationalité à son époux d’origine étrangère à égalité avec les hommes de nationalité marocaine.", "مراجعة قانون الجنسية لكي يتيح للمرأة المغربية نقل جنسيتها إلى زوجها الأجنبي من أجل المساواة في الحقوق بينها وبين الرجل الذي يحمل الجنسية المغربية.", "", "" },
                    { 537, null, "R6P2", "ت.6.ف.2", "", "Non réalisé", "", 0, 3, null, 2, null, 10, null, "Organes de traités", "Modifier la 9 de façon à établir explicitement que l’ordre d’un supérieur ou d’une autorité publique ne saurait être invoqué pour justifier la torture.", "-          تعديل التشريعات لتنص صراحة على عدم جواز الاعتداد بأمر موظف أعلى رتبة أو سلطة عمومية لتبرير التعذيب.", "", "" },
                    { 538, null, "R8P1P2", "ت.8.ف.1.ف.2", "", "Non réalisé", "", 0, 3, null, 2, null, 10, null, "Organes de traités", @"Revoir la loi antiterroriste n° 03-03 afin de mieux définir le terrorisme, de réduire la durée maximale de la garde à vue au strict minimum et de permettre l’accès à un avocat dès le début de la détention. 
                - Le Comité rappelle qu’en vertu de la Convention contre la torture, aucune circonstance exceptionnelle quelle qu’elle soit ne saurait être invoquée pour justifier la torture", "-          مراجعة القانون المتعلق بمكافحة الإرهاب 03-03 لتعريف الإرهاب بشكل أدق وتقليص المدة القصوى للحبس الاحتياطي إلى أدنى حد ممكن وإتاحة الوصول إلى محام فور بداية الاحتجاز.", "", "" },
                    { 539, null, "R13P1", "ت.13.ف.1", "", "Non réalisé", "", 0, 3, null, 2, null, 10, null, "Organes de traités", "Modifier la législation afin de garantir à toutes les personnes civiles d’être jugées exclusivement par des juridictions civiles.", "تعديل التشريعات لكي تضمن محاكمة جميع المدنيين أمام المحاكم المدنية دون غيرها.", "", "" },
                    { 540, null, "R6P2", "ت.6.ف.2", "", "Non réalisé", "", 0, 3, null, 2, null, 10, null, "Organes de traités", "Modifier la législation de sorte que celle-ci stipule explicitement que l’ordre d’un supérieur ou d’une autorité publique ne saurait être invoqué pour justifier la torture.", "-           تعديل التشريعات لتكرس صراحة عدم جواز الاعتداد بأمر موظف أعلى رتبة أو سلطة عمومية لتبرير التعذيب.", "", "" },
                    { 194, null, "R83P1", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 7, "Procédure spéciale", "Garantir, par des modifications de la législation, que l’accès à un avocat choisi par le suspect lui-même soit accordé dès l’arrestation, sans la présence d’un enquêteur et sans nécessiter l’autorisation du Procureur, y compris dans les affaires touchant à la sécurité nationale et de terrorisme. - Cet accès devrait être garanti par la loi et tout fonctionnaire qui refuserait d’accorder l’accès à un avocat devrait être sanctionné", "null", "", "" },
                    { 165, null, "R89P1", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 6, "Procédure spéciale", "Mettre toutes les lois nationales en conformité avec les instruments internationaux relatifs aux droits de l’homme auxquels le Maroc est partie et de modifier ou d’abroger les dispositions discriminatoires qui subsistent dans les lois nationales", "null", "", "" },
                    { 137, null, "R80P1", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 4, "Procédure spéciale", "-    Veiller à la pleine application, en droit interne, du Protocole additionnel à la Convention des Nations Unies contre la criminalité transnationale organisée visant à prévenir, réprimer et punir la traite des personnes, en particulier des femmes et des enfants, qui impose à l’État de prévenir et de combattre la traite des êtres humains.", "null", "", "" },
                    { 45, null, "R70P1P2", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 2, "Procédure spéciale", "Adopter un cadre juridique et politique global de lutte contre la discrimination qui met en application l’intégralité des dispositions relatives à l’égalité raciale de la Convention internationale sur l’élimination de toutes les formes de discrimination raciale, conformément aux recommandations du Comité pour l’élimination de la discrimination raciale. - Afin de garantir la pleine conformité avec l’article premier de la Convention, réviser la législation existante ou adopter une nouvelle loi de façon à interdire expressément la discrimination raciale telle que définie dans la Convention.", "null", "", "" },
                    { 584, null, "R36 P9", "ت.36.ف.9", "", "Non réalisé", "", 0, 3, null, 3, null, 9, null, "Organes de traités", "f)…….. adopter un cadre juridique pour prévenir l’apatridie.", "-           (و)  ........اعتماد إطار قانوني لمنع انعدام الجنسية", "", "" },
                    { 619, null, "R14P1", "ت.14.ف.1", "", "Non réalisé", "", 0, 3, null, null, null, 9, null, "Organes de traités", @"Tenant en compte son observation générale no 20 (2009) sur la non-discrimination dans l’exercice des droits économiques, sociaux et culturels, le Comité appelle à :
                a) Adopter et mettre en œuvre une loi anti discrimination complète, qui devrait interdire de manière générale toute forme de discrimination, directe et indirecte, et qui autorise la mise en œuvre de mesures spéciales temporaires en faveur des groupes défavorisés ou marginalisés ;", @"رجوعا إلى تعليقها العام رقم 20(2009) بشأن عدم التمييز في الحقوق الاقتصادية والاجتماعية والثقافية، تدعو اللجنة إلى:
                (أ) اعتماد وتنفيذ قانون شامل لمكافحة التمييز يحظر بصفة عامة جميع أشكال التمييز، المباشر منه وغير المباشر، ويجيز تنفيذ التدابير الخاصة المؤقتة لمصلحة الفئات المحرومة أو المهمشة؛", "", "" },
                    { 620, null, "R18P1", "ت.18.ف.1", "", "Non réalisé", "", 0, 3, null, null, null, 9, null, "Organes de traités", @"Tenant compte de son observation générale no 16 (2005) sur le droit égal de l’homme et de la femme au bénéfice de tous les droits économiques, sociaux et culturels, le Comité recommande de :
                - a) …Prendre en considération les avis des parties prenantes en vue de l’adoption des différentes lois pendantes, notamment la loi 79.14 relative à l’Autorité pour la parité et la lutte contre toutes les formes de discrimination", @"في ضوء تعليقها العام رقم 16(2005) بشأن المساواة بين الرجل والمرأة في حق التمتع بجميع الحقوق الاقتصادية والاجتماعية والثقافية، توصي اللجنة بما يلي:
                (أ) ..... الأخذ بآراء الجهات صاحبة المصلحة من أجل اعتماد مختلف القوانين المعلقة، بما في ذلك القانون رقم 79-14 المتعلق بهيئة المناصفة ومكافحة كل أشكال التمييز", "", "" },
                    { 621, null, "R30P1P2", "ت.30.ف.1.ف.2", "", "Non réalisé", "", 0, 3, null, null, null, 9, null, "Organes de traités", @"Adopter le projet de loi fixant les conditions de travail et d’emploi des employés de maison. 
                - S’assurer que cette loi établisse l’âge minimum à 18 ans et garantisse que les travailleurs domestiques jouissent de conditions de travail justes et favorables comme d’autres travailleurs", @"اعتماد مشروع القانون الذي يحدد شروط عمل العمال المنزليين وتشغيلهم. 
                - الحرص على أن يحدد هذا القانون سن 18 عاماً سناً دنيا، ويضمن تمتع العمال المنزليين بشروط عمل عادلة وملائمة إسوة بغيرهم من العمال.", "", "" },
                    { 622, null, "R32P1", "ت.32.ف.1", "", "Non réalisé", "", 0, 3, null, null, null, 9, null, "Organes de traités", "-            Accélérer l’adoption du projet de loi sur le harcèlement sexuel, en particulier sur le lieu de travail, mais aussi le harcèlement sexuel sous toutes ses formes et en tout lieu, incluant des peines à la mesure de la gravité de cette infraction.", "-          الإسراع في اعتماد مشروع القانون بشأن التحرش الجنسي لا سيما في مكان العمل، فضلاً عن التحرش الجنسي بجميع أشكاله وفي أي مكان كان، على أن يتضمن عقوبات تتناسب مع خطورة الجريمة.", "", "" },
                    { 623, null, "R34P2", "ت.34.ف.2", "", "Non réalisé", "", 0, 3, null, null, null, 9, null, "Organes de traités", "-            Adopter les lois relatives à l’exercice du droit de grève et aux syndicats professionnels.", "-          اعتماد القوانين المتعلقة بممارسة الحق في الإضراب وبالنقابات المهنية.", "", "" },
                    { 624, null, "R24P1", "ت.24.ف.1", "", "Non réalisé", "", 0, 3, null, null, null, 9, null, "Organes de traités", "-            Accélérer l’adoption de la loi relative à la promotion et à la protection des droits des personnes handicapés et de promouvoir son application.", "-          الإسراع في اعتماد القانون المتعلق بتعزيز وحماية حقوق الأشخاص ذوي الإعاقة الذكر والتشجيع على تطبيقه.", "", "" },
                    { 625, null, "R38P1", "ت.38.ف.1", "", "Non réalisé", "", 0, 3, null, null, null, 9, null, "Organes de traités", "-            Adopter une 9 globale sur les violences faites aux femmes conformément aux normes internationales en la matière et de veiller à son application en vue d’éliminer toutes les formes de violence à l’égard des femmes, y compris le viol conjugal", "-          اعتماد تشريعات شاملة بشأن العنف ضد المرأة بما يتماشى مع المعايير الدولية في هذا المجال، وبالحرص على تطبيق هذه التشريعات بغية القضاء على جميع أشكال العنف ضد المرأة بما في ذلك الاغتصاب الزوجي.", "", "" },
                    { 626, null, "R50P1", "ت.50.ف.1", "", "Non réalisé", "", 0, 3, null, null, null, 9, null, "Organes de traités", "-            Adopter, le plus rapidement possible, le projet de loi organique sur la langue amazighe comme une des langues officielles de l’État", "-          اعتماد مشروع القانون الأساسي بشأن اللغة الأمازيغية باعتبارها من اللغات الرسمية للدولة في أقرب وقت ممكن", "", "" },
                    { 662, null, "R20P1P3", "ت.20.ف1.ف 3.", "", "Non réalisé", "", 0, 3, null, 5, null, 9, null, "Organes de traités", @"veiller à ce que tous les travailleurs migrants et les membres de leur famille se trouvant sur son territoire ou relevant de sa juridiction jouissent sans discrimination aucune des droits reconnus par la Convention, conformément à l’article 7. 

                - adopter une loi contre le racisme et toute discrimination raciale", @"تمتيع جميع العمال المهاجرين وأفراد أسرهم الموجودين في إقليم المملكة المغربية  أو الخاضعين لولايتها، دون أي تمييز كان، بالحقوق المعترف بها في الاتفاقية، وفقاً للمادة 7. 
                - وتدعو اللجنة الدولة الطرف إلى اعتماد قانون لمناهضة العنصرية وجميع أشكال التمييز العنصري،", "", "" },
                    { 663, null, "R32P1", "ت.32.ف.1", "", "Non réalisé", "", 0, 3, null, 5, null, 9, null, "Organes de traités", "-       Prendre les mesures appropriées pour mettre en place un cadre juridique régissant les procédures d’expulsion/de renvoi conformément aux dispositions de la Convention et de prendre en compte l’observation générale no 2 du Comité qui énonce en particulier que les intéressés ont le droit de faire valoir les raisons pour lesquelles ils ne devraient pas être expulsés et de faire examiner leur cas par une autorité compétente.", ". اتخاذ التدابير المناسبة لوضع إطار قانوني ينظم إجراءات الطرد/الإعادة وفقاً لأحكام الاتفاقية، كما توصيها بأن تضع في اعتبارها تعليقها العام رقم 2 الذي ينص تحديدا ًعلى أن من حق الأشخاص المعنيين بيان الأسباب التي تبرر ضرورة عدم طردهم، وعرض حالتهم على سلطة مختصة", "", "" },
                    { 843, null, "R43P1", "ت.43.ف.1", "", "Non réalisé", "", 0, 5, null, 8, null, 24, null, "Organes de traités", "- a) Adopter des mesures concrètes afin de créer une langue des signes marocaine unifiée qui sera reconnue comme langue officielle des personnes sourdes et enseignée dans les écoles, de constituer un vivier d’interprètes en langue des signes qualifiés et d’enseignants formés à la traduction en format tactile, en braille et en langue facile (Easy Read) et de veiller à ce que les chaînes de télévision diffusent le journal télévisé et des programmes dans des formats accessibles, en particulier pour les personnes sourdes ou malentendantes ;", "-       (أ) اعتماد تدابير محددة لوضع لغة إشارة مغربية موحدة تحظى بالاعتراف بوصفها لغة رسمية للصم وتُدرس في المدارس، وتكوين مجموعة من مترجمي ومدرسي لغة الإشارة المؤهلين والمدربين على استخدام وسائل الاتصال عن طريق اللمس، ومهارات ترجمة النصوص إلى أشكال يسهل الاطلاع عليها وباستخدام طريقة برايل، وضمان تقديم الأخبار والبرامج بالأشكال الميسرة في المحطات التلفزيونية، ولا سيما للصم وضعاف السمع؛", "", "" },
                    { 665, null, "R48P1", "ت.48.ف.1", "", "Non réalisé", "", 0, 3, null, 5, null, 9, null, "Organes de traités", @"Prendre les mesures nécessaires pour que la stratégie nationale de lutte contre le trafic des êtres humains comprenne notamment les mesures suivantes :
                a) Adopter une loi relative à la lutte contre la traite des personnes et à la protection des victimes de la traite ;", @"اتخاذ التدابير اللازمة كي تتضمن الاستراتيجية الوطنية لمحاربة الاتجار بالبشر التدابير التالية على وجه الخصوص:
                 (أ) اعتماد قانون لمكافحة الاتجار بالبشر وحماية ضحاياه؛", "", "" },
                    { 582, null, "R8", "ت.8", "", "Non réalisé", "", 0, 3, null, 3, null, 9, null, "Organes de traités", "- Veiller à ce que les conditions requises pour une dérogation soient conformes au Pacte.", "سنّ تشريع يتضمن أحكاماً واضحة عن حالة الطوارئ بحيث لا يمكن تعطيل العمل با��حقوق التي تحميها الفقرة 2 من المادة 4 من العهد بأي حال من الأحوال، وكفالة تَوافق مقتضيات أي استثناء من ذلك مع العهد، عملا بما جاء في التعليق العام للجنة رقم 29(2001) بشأن عدم التقيّد بأحكام العهد أثناء حالات الطوارئ.", "", "" },
                    { 706, null, "R11P1P2P3", "ت.11.ف.1.ف.2.ف.3", "", "Non réalisé", "", 0, 3, null, 6, null, 9, null, "Organes de traités", @"Incorporer le principe d’égalité des sexes dans la Constitution ou dans les autres dispositions de son droit interne, conformément à l’alinéa a) de l’article 2 de la Convention
                - Inscrire explicitement la définition de la discrimination figurant à l’article premier de la Convention dans sa législation nationale. 
                - Promulguer et de faire appliquer une loi générale relative à l’égalité des sexes, qui aurait une valeur contraignante dans les secteurs public comme privé, et de faire connaître aux femmes les droits qui sont les leurs en vertu de ces textes.", @"إدماج مبدأ المساواة بين المرأة والرجل في الدستور، أو في قانون آخر مناسب، بما يتماشى وأحكام المادة 2 (أ) من الاتفاقية، 
                -تضمين التشريعات الوطنية التعريف الكامل للتمييز الوارد في المادة 1 من الاتفاقية. 
                -سن وتنفيذ قانون شامل عن المساواة بين الجنسين يكون ملزما للقطاعين العام والخاص كليهما، وتثقيف النساء بحقوقهن بموجب ذلك القانون.", "", "" },
                    { 749, null, "R65 P2", "ت.65.ف.2", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", "b) veiller à ce que les lois qui interdisent l’emploi d’enfants âgés de moins de 15 ans et les formes dangereuses de travail des enfants âgés de moins de 18 ans, y compris le travail domestique, soient effectivement appliquées et que les personnes qui exploitent les enfants soient dûment sanctionnées;", "-           (ب) السهر على إنفاذ فعال للقوانين التي تحظر تشغيل الأطفال دون             سن 15 وأشكال عمل الأطفال دون سن 18 المحفوفة بالمخاطر، بما في ذلك الخدمة المنزلية، ومعاقبة من يستغلون الأطفال وفق القانون.", "", "" },
                    { 750, null, "R23P1", "ت.23.ف.1", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 16 (2013) sur les obligations des États concernant les incidences du secteur des entreprises sur les droits de l’enfant et, en particulier, lui recommande :
                a) D’examiner et d’adapter son cadre législatif concernant la responsabilité juridique des entreprises commerciales et de leurs filiales gérées dans l’État partie ou ayant des activités sur son territoire, en particulier dans le secteur du tourisme", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 16(2013) بشأن التزامات الدولة المتعلقة بالآثار التي يحدثها قطاع الأعمال على حقوق الأطفال، وتوصيها خاصة بالآتي: 
                - (أ) النظر في إطارها التشريعي المتعلق بالمساءلة القانونية للشركات الخاصة وفروعها العاملة في إقليم الدولة الطرف أو التي تدار انطلاقاً منها، خاصة في قطاع السياحة، وتكييف ذلك الإطار", "", "" },
                    { 751, null, "R33", "ت.33", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", "Autoriser, par la loi, les femmes et les enfants à entamer les procédures pour établir la paternité sur la base d’analyses de l’ADN.", "-          إباحة إثبات الأبوة على أساس اختبار الحَمْض النَّوَوِي الرِّيْبِيِّ المنْزُوع الأوكسِجين للنساء والأطفال قانوناً.", "", "" },
                    { 752, null, "R37P2", "ت.37.ف.2", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", @"Renvoyant à son Observation générale no 8 (2006) relative aux droits de l’enfant et à une protection contre les châtiments corporels et les autres formes cruelles ou dégradantes de châtiment, le Comité invite le Maroc à:
                       b) Faire réellement appliquer les lois interdisant les châtiments corporels et veiller à ce que des poursuites soient systématiquement engagées contre les personnes qui usent de violence envers les enfants", @"في ضوء تعليق اللجنة العام رقم 8(2006) بشأن حق الطفل في الحماية من العقوبة البدنية وغيرها من ضروب العقوبة القاسية أو المهينة، تحث اللجنة الدولة المملكة المغربية على ما يلي: 
                -  (ب) التأكد من تنفيذ القوانين التي تحظر العقوبة البدنية تنفيذاً فعّالاً ومن اتخاذ إجراءات قانونية بصورة منهجية ضد كل من أساء معاملة الأطفال؛", "", "" },
                    { 753, null, "R39P2", "ت.39.ف.2", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", @"Le Comité recommande au Maroc de tenir compte de l’Observation générale no 13 (2011) sur le droit de l’enfant d’être protégé contre toutes les formes de violence, et en particulier de mettre en place, en étroite coopération avec la société civile, un système de protection des enfants bien coordonné et bien financé. Le Maroc devrait en particulier:
                b) Mettre en place un cadre juridique complet, ainsi qu’un cadre national de coordination pour prévenir, interdire et punir toutes les formes de délaissement, de sévices et de violence, notamment dans la famille, à l’égard de tous les enfants jusqu’à l’âge de 18 ans;", @"الأخذ في الحسبان التعليق العام  رقم 13(2011) بشأن حق الطفل في التحرر من جميع أشكال العنف، ووضع نظاماً لحماية الطفل منسقاً تنسيقاً جيداً وممولاً تمويلاً كافياً بتعاون وثيق مع المجتمع المدني و الاضطلاع بما يلي خاصةً:
                -  (ب) وضع إطار قانوني شامل، إضافة إلى إطار تنسيق وطني، لمنع جميع أشكال الإهمال وإساءة المعاملة والعنف، بما فيه العنف المنزلي، التي يتعرض لها كل الأطفال حتى سن 18؛", "", "" },
                    { 754, null, "R43", "ت.43", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", "Le Comité appelle le Maroc sur les nombreuses conséquences néfastes des mariages précoces et lui demande instamment de ne pas ramener à 16 ans l’âge minimum du mariage et de prendre des mesures concrètes pour mettre fin à la pratique des mariages précoces et forcés.", "-          تلفت اللجنة انتباه الدولة الطرف إلى العواقب الوخيمة الكثيرة الناشئة عن الزواج المبكر، وتحثها على الامتناع عن خفض الحد الأدنى لسن الزواج إلى 16 عاماً وعلى اتخاذ تدابير فعالة من أجل وضع حد للزواج المبكر والزواج بالإكراه.", "", "" },
                    { 755, null, "R49P2", "ت.49.ف.2", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", @"Appelant l’attention sur les lignes directrices relatives à la protection de remplacement pour les enfants (résolution 64/142 de l’Assemblée générale, annexe), le Comité demande instamment au Maroc :
                b) D’achever le processus d’adoption du projet de loi sur la protection de remplacement en accordant la priorité à d’autres solutions que le placement en institution, en particulier au placement auprès d’un parent, au placement en famille d’accueil et au renforcement des programmes visant à prévenir le placement dans des structures de remplacement;", @"لفت اللجنة انتباه المملكة المغربية إلى المبادئ التوجيهية للرعاية البديلة للأطفال (مرفق قرار الجمعية العامة 64/142) وحثتها على ما يلي: 
                -  (ب) وضع الصيغة النهائية لعملية اعتماد مشروع القانون عن الرعاية البديلة، مع إيلاء الأولوية لبدائل المؤسسات، لا سيما رعاية ذوي القربى والحضانة وبرامج توثيق الأواصر الأسرية توقياً للإيداع خارج البيت", "", "" },
                    { 813, null, "R13P1P2", "ت.13.ف1.ف.2", "", "Non réalisé", "", 0, 3, null, 8, null, 9, null, "Organes de traités", @"Définir dans la législation nationale le refus d’aménagement raisonnable comme constituant une forme de discrimination fondée sur le handicap 
                - Introduire expressément dans la législation nationale une protection contre les formes de discrimination multiples et croisées fondées sur le sexe, le genre, l’âge, le handicap, l’origine nationale, l’appartenance ethnique et le statut migratoire, et de prévoir des sanctions effectives en cas de non-respect", @"(أ) إدراج الحرمان من الترتيبات التيسيرية المعقولة في التشريعات الوطنية باعتباره من أشكال التمييز بسبب الإعاقة.
                -  (ب) إدراج حكم في القانون الوطني ينص على توفير حماية صريحة من التعرض لأشكال التمييز المتعدد الجوانب والمتقاطع بسبب الجنس والسن والإعاقة والأصل القومي والأصل الإثني والوضع كمهاجر، وعلى فرض جزاءات فعالة ضد الجناة", "", "" },
                    { 814, null, "R15P1", "ت.15.ف.1", "", "Non réalisé", "", 0, 3, null, 8, null, 9, null, "Organes de traités", @"conformément à son observation générale no 3 (2016) sur les femmes et les filles handicapées et à la cible 5.2 des objectifs de développement durable, Le Comité recommande de mettre fin à toute forme de violence à l’égard des femmes et des filles handicapées dans les sphères tant publique que privée, notamment à la traite et à l’exploitation, sexuelle et autre. Il recommande également :
                a) D’intégrer la question des droits des femmes et des filles handicapées dans la législation sur l’égalité des sexes, ainsi que dans les lois et les politiques relatives au handicap,….", @"تماشياً مع التعليق العام رقم 3(2016) بشأن النساء والفتيات ذوات الإعاقة والغاية 5-2 من أهداف التنمية المستدامة، توصي اللجنة الدولة الطرف بالقضاء على جميع أشكال العنف ضد النساء والفتيات في المجالين العام والخاص، بما في ذلك الاتجار بالبشر والاستغلال الجنسي وغير ذلك من أشكال الاستغلال. وتوصي الدولة الطرف أيضاً بما يلي:‬‬‬‬ ‬‬
                -  (أ) ......، وتنظيم حملات توعية عامة لمكافحة القوالب النمطية ومواقف التحيز والخرافات السائدة عنها؛ 
                -  (ب) التوعية بجميع أشكال التمييز ضد المرأة، والأخذ بوجهات نظر النساء اللواتي يتعهدن أطفالاً من ذوي الإعاقة بالرعاية في السياسات العامة المتعلقة بالتصدي للتمييز الجنساني", "", "" },
                    { 815, null, "R39P1", "ت.39.ف.1", "", "Non réalisé", "", 0, 3, null, 8, null, 9, null, "Organes de traités", "Reconnaître dans sa législation le droit subjectif des personnes handicapées de vivre de façon indépendante et d’être incluses dans la société", "(أ) الاعتراف في التشريعات بالحق الذاتي للأشخاص ذوي الإعاقة في العيش المستقل وإدماجهم في المجتمع‬ المحلي؛", "", "" },
                    { 816, null, "R43P2P3", "ت.43.ف.2ف.3", "", "Non réalisé", "", 0, 3, null, 8, null, 9, null, "Organes de traités", @"b) Adopter des lois et des mesures visant à garantir que les propriétaires et les concepteurs de sites Web rendent leurs sites accessibles aux personnes handicapées, en particulier aux personnes aveugles et malvoyantes 
                - c) Accélérer l’adoption du projet de loi sur le droit à l’accès à l’information et d’en éliminer toute restriction qui entrave la jouissance de ce droit par les personnes handicapées", @"(ب) اعتماد تشريعات وتدابير مناسبة تضمن أن يوفر أصحاب المواقع الشبكية ومصمموها إمكانية الوصول إلى مواقعهم للأشخاص ذوي الإعاقة، ولا سيما للمكفوفين وذوي العاهات البصرية؛
                -  (ج) تسريع إجراءات اعتماد مشروع القانون المتعلق بالحق في الحصول على المعلومات، وإلغاء أي قيود فيه تعوق تمتع الأشخاص ذوي الإعاقة بهذا الحق.", "", "" },
                    { 817, null, "R63P3", "ت.63.ف.3", "", "Non réalisé", "", 0, 3, null, 8, null, 9, null, "Organes de traités", "Accélérer l’adoption par le 32du projet de loi relatif au Conseil national des droits de l’homme conférant à celui-ci les pouvoirs d’un mécanisme indépendant de protection, de promotion et de suivi de l’application de la Convention, conformément aux dispositions de l’article 33 de la Convention, et d’allouer au Conseil des ressources budgétaires et humaines suffisantes ;", "-       (ج) إسراع البرلمان في اعتماد مشروع القانون المتعلق بالمجلس الوطني لحقوق الإنسان الذي يعترف بصلاحية المجلس ممارسة الاختصاصات المخولة لآلية مستقلة لحماية الاتفاقية وتعزيزها ورصد تنفيذها، وفقاً للأحكام الواردة في المادة ٣٣ من الاتفاقية، ورصد ما يكفي من مخصصات الميزانية والموارد البشرية للمجلس؛", "", "" },
                    { 4, null, "R67P2", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 1, "Procédure spéciale", "-   Veiller à ce que les lois en cours de révision soient conformes aux normes internationales relatives aux droits de l’homme.", "null", "", "" },
                    { 748, null, "R11", "ت.11", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", @"Poursuivre et renforcer les efforts pour mettre l’ensemble de la législation, en particulier le Code de la famille, en conformité avec la Convention et pour abroger rapidement toutes les dispositions qui sont discriminatoires à l’égard des filles et des femmes et nuisent à tous les enfants, telles que celles concernant l’héritage et la polygamie. 
                - Songer à élaborer un code de l’enfance qui englobe tous les domaines de la Convention et à faire en sorte que les ressources humaines, financières et techniques nécessaires soient effectivement affectées à l’application de la législation relative aux enfants", @"مواصلة وتعزيز الجهود الرامية إلى جعل جميع التشريعات الوطنية، وبخاصة مدونة الأسرة، تتوافق مع الاتفاقية، 
                - الإسراع بإلغاء جميع الأحكام التي تنطوي على تمييز في حق الفتيات والنساء وتضر بجميع الأطفال، من قبيل أحك��م الميراث وتعدد الزوجات. وتشجعها على النظر في وضع قانون للطفل يشمل جميع مجالات الاتفاقية، والتأكد من أن الموارد البشرية والمالية والتقنية اللازمة تُرصد فعلاً لتنفيذ التشريعات المتعلقة بالأطفال", "", "" },
                    { 541, null, "R19P2", "ت.19.ف.2", "", "Non réalisé", "", 0, 3, null, 2, null, 10, null, "Organes de traités", "-            Modifier la 9 pour permettre le recours aux mesures de substitution à la mise en détention préventive, conformément aux Règles minima des Nations Unies pour l’élaboration de mesures non privatives de liberté (Règles de Tokyo). À cet effet, il pourrait développer un système de cautionnement et de recours plus fréquent aux peines non privatives de liberté pour les infractions les moins graves.", "تعديل التشريعات لتتيح اللجوء إلى تدابير بديلة عن الاحتجاز الوقائي وفقاً لقواعد الأمم المتحدة النموذجية الدنيا للتدابير غير الاحتجازية (قواعد طوكيو) والنظر في إمكانية تطوير نظام للكفالة، وزيادة اللجوء إلى عقوبات غير سالبة للحرية فيما يتعلق بالمخالفات الأقل خطورة. ، وذلك ومكافحة اكتظاظ السجون", "", "" },
                    { 741, null, "R23P4", "ت.23.ف.4", "", "Non réalisé", "", 0, 2, null, 7, null, 7, null, "Organes de traités", @"Le Comité appelle l’attention de l’État partie sur son Observation générale no 16 (2013) sur les obligations des États concernant les incidences du secteur des entreprises sur les droits de l’enfant et, en particulier, lui recommande :
                d) De renforcer sa coopération internationale contre le tourisme pédophile par le biais d’accords multilatéraux, régionaux et bilatéraux pour la prévention et l’élimination de ce phénomène.", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 16(2013) بشأن التزامات الدولة المتعلقة بالآثار التي يحدثها قطاع الأعمال على حقوق الأطفال، وتوصيها خاصة بالآتي: 
                - (أ) النظر في إطارها التشريعي المتعلق بالمساءلة القانونية للشركات الخاصة وفروعها العاملة في إقليم الدولة الطرف أو التي تدار انطلاقاً منها، خاصة في قطاع السياحة، وتكييف ذلك الإطار", "", "" },
                    { 704, null, "R49", "ت.49", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", "-S’appuyer pleinement, pour s’acquitter de ses obligations en vertu de la Convention, sur la Déclaration et le Programme d’action de Beijing, qui renforcent les dispositions de la Convention, et inclure des informations à ce sujet dans son prochain rapport périodique.", "استخدام بصورة كاملة، عند تنفيذ الالتزامات بموجب الاتفاقية، إعلان ومنهاج عمل بيجين لأنهما يعززان أحكام الاتفاقية، وإدراج معلومات بشأن هذه المسألة في التقرير الدوري المقبل.", "", "" },
                    { 268, null, "R144.1", "null", "", "Non réalisé", "", 0, 2, 1, null, 73, 5, null, "Examen périodique universal", "-adhérer au premier Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques", "null", "", "" },
                    { 269, null, "R144.4", "4.144", "", "Non réalisé", "", 0, 2, 1, null, 65, 5, null, "Examen périodique universal", "Envisager de ratifier le deuxième Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques", "النظر في التصديق على البروتوكول الاختياري الثاني الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 270, null, "R144.6", "6.144", "", "Non réalisé", "", 0, 2, 1, null, 73, 5, null, "Examen périodique universal", "Ratifier le Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels", "التصديق على البروتوكول الاختياري الثاني الملحق بالعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية ()", "", "" },
                    { 271, null, "R144.7", "7.144", "", "Non réalisé", "", 0, 2, 1, null, 49, 5, null, "Examen périodique universal", "Signer et ratifier le Protocole facultatif à la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes", "التوقيع والتصديق على البروتوكول الاختياري الثاني الملحق باتفاقية القضاء على جميع أشكال التمييز ضد المرأة ()؛", "", "" },
                    { 272, null, "R144.9", "9.144", "", "Non réalisé", "", 0, 2, 1, null, 61, 5, null, "Examen périodique universal", "Ratifier le Protocole facultatif à la Convention relative aux droits de l’enfant établissant une procédure de présentation de communications", "التصديق على البروتوكول الاختياري لاتفاقية حقوق الطفل المتعلق بإجراء البلاغات", "", "" },
                    { 273, null, "R144.10", "10.144", "", "Non réalisé", "", 0, 2, 1, null, 38, 5, null, "Examen périodique universal", "Accélérer la procédure de ratification du Protocole facultatif à la Convention relative aux droits de l’enfant établissant une procédure de présentation de communications", "تسريع عملية التصديق على البروتوكول الاختياري لاتفاقية حقوق الطفل المتعلق بإجراء تقديم البلاغات", "", "" },
                    { 274, null, "R144.16", "16.144.", "", "Non réalisé", "", 0, 2, 1, null, 72, 5, null, "Examen périodique universal", "Ratifier la convention (no 189) de l’OIT sur les travailleuses et travailleurs domestiques, 2011", "التصديق على اتفاقية العمال المنزليين، 2011 (رقم 189)، لمنظمة العمل الدولية", "", "" },
                    { 275, null, "R144.110 P2", "110.144.ج.2", "", "Non réalisé", "", 0, 2, 1, null, 80, 5, null, "Examen périodique universal", "Ratifier le Protocole de 2014 à la Convention sur le travail forcé de l’Organisation internationale du Travail", "التصديق على بروتوكول عام 2014 لاتفاقية منظمة العمل الدولية لإلغاء السخرة", "", "" },
                    { 276, null, "R144.242", "242.144.", "", "Non réalisé", "", 0, 2, 1, null, 51, 5, null, "Examen périodique universal", "Adhérer aux conventions relatives au statut des apatrides et à la réduction des cas d’apatridie pour accorder la nationalité aux enfants qui, autrement, demeureraient apatrides et les incorporer dans le droit interne", "الانضمام إلى الاتفاقيات المتعلقة بمركز الأشخاص عديمي الجنسية وإدراج أحكامها في قانونه الداخلي والحد من حالات انعدام الجنسية عن طريق منح الجنسية للأطفال الذين سيظلون بلا جنسية ما لم يُمنَحوا الجنسية المغربية", "", "" },
                    { 277, null, "R144.19", "19.144", "", "Non réalisé", "", 0, 2, 1, null, 8, 5, null, "Examen périodique universal", "Envisager d’adresser une invitation permanente aux titulaires de mandat au titre des procédures spéciales", "النظر في توجيه دعوة دائمة إلى المكلفين بولايات في إطار الإجراءات الخاصة", "", "" },
                    { 479, null, "R21", "ت.21", "", "Non réalisé", "", 0, 2, null, 1, null, 5, null, "Organes de traités", "Envisager de ratifier les traités internationaux relatifs aux droits de l’homme auxquels il n’est pas encore partie mais qui pourraient avoir un rapport avec la  question de la discrimination raciale qui est en voie de trouver une solution et faire écho à l’histoire récente du Maroc, tels que la Convention internationale pour la protection de toutes les personnes contre les disparitions forcées adoptée en 2006.", "التفكير في التصديق على المعاهدات الدولية المتعلقة بحقوق الإنسان التي لم تنضم إليها المملكة المغربية بعد والتي قد تكون ذات صلة بمسألة التمييز العنصري التي هي مسألة في طريق الحل وإيجاد صدى لها في تاريخ المغرب الحديث، كالاتفاقية الدولية لحماية جميع الأشخاص من الاختفاء القسري، التي اعتُمدت في عام 2006.", "", "" },
                    { 480, null, "R24", "ت.24", "", "Non réalisé", "", 0, 2, null, 1, null, 5, null, "Organes de traités", "Ratifier les modifications apportées au paragraphe 6 de l’article 8 de la Convention, adoptées le 15 janvier 1992 à la quatorzième réunion des Etats parties à la Convention et approuvées par l’Assemblée générale dans sa résolution 47/111 en date du 16 décembre 1992. A cet égard, il renvoie à la résolution 61/148 de l’Assemblée générale, par laquelle l’Assemblée a demandé instamment aux Etats parties à la Convention d’accélérer leurs procédures internes de ratification des modifications et d’informer par écrit le Secrétaire général, dans les meilleurs délais, de leur acceptation de ces modifications.", "التصديق على التعديل الذي أُجري على الفقرة 6 من المادة 8 من الاتفاقية والذي اعتُمد في 15 كانون الثاني/يناير 1992 أثناء الدورة الرابعة عشرة للدول الأطراف في الاتفاقية (انظر مرفق الوثيقة CERD/SP/45) وأقرته الجمعية العامة في قرارها 47/111. وفي هذا الصدد، تشير اللجنة إلى الفقرة 14 من قرار الجمعية العامة 61/148 التي حثت فيها الجمعيةُ العامة بقوة الدول الأطراف في الاتفاقية على التعجيل باتخاذ إجراءاتها الداخلية للتصديق على التعديل وعلى إخطار الأمين العام بموافقتها عليه كتابةً وفي أسرع وقت ممكن.", "", "" },
                    { 512, null, "R21P1", "ت.21ف.1", "", "Non réalisé", "", 0, 2, null, 2, null, 5, null, "Organes de traités", "Envisager de ratifier le deuxième Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques, visant à abolir la peine de mort.", "النظر في التصديق على البروتوكول الاختياري الثاني الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية، الذي يرمي إلى إلغاء عقوبة الإعدام.", "", "" },
                    { 513, null, "R25P3", "ت.25.ف.3", "", "Non réalisé", "", 0, 2, null, 2, null, 5, null, "Organes de traités", "-            Envisager d’adhérer à la Convention relative au statut des apatrides (1954) et à la Convention sur la réduction des cas d’apatridie (1961).", "النظر في الانضمام إلى الاتفاقية المتعلقة بوضع الأشخاص عديمي الجنسية لعام 1954 وإلى اتفاقية خفض حالات انعدام الجنسية لعام 1966.", "", "" },
                    { 514, null, "R31P1", "ت.31.ف.1", "", "Non réalisé", "", 0, 2, null, 2, null, 5, null, "Organes de traités", "-            envisager d’adhérer au Protocole facultatif se rapportant à la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "النظر في الانضمام إلى البروتوكول الاختياري لاتفاقية مناهضة التعذيب وغيره من ضروب المعاملة القاسية أو اللاإنسانية أو المهينة، ونظام روما الأساسي للمحكمة الجنائية الدولية.", "", "" },
                    { 515, null, "R31P2", "ت.31.ف.2", "", "Non réalisé", "", 0, 2, null, 2, null, 5, null, "Organes de traités", "envisager d’adhérer au Statut de Rome de la Cour pénale internationale.", "النظر في الانضمام إلى ونظام روما الأساسي للمحكمة الجنائية الدولية.", "", "" },
                    { 573, null, "R6P3", "ت.6.ف.3", "", "Non réalisé", "", 0, 2, null, 3, null, 5, null, "Organes de traités", "Mener à terme, dans les meilleurs délais, le processus d’adhésion au premier Protocole facultatif se rapportant au Pacte, qui prévoit l’examen de communications individuelles.", "-          إنهاء عملية الانضمام إلى البروتوكول الاختياري الأول الملحق بالعهد، الذي ينص على النظر في البلاغات الفردية، في أقرب وقت ممكن.", "", "" },
                    { 574, null, "R20P2", "ت.20.ف.2", "", "Non réalisé", "", 0, 2, null, 3, null, 5, null, "Organes de traités", "- Envisager d’adhérer au deuxième Protocole facultatif se rapportant au Pacte, visant à abolir la peine de mort.", "النظر في إمكانية الانضمام إلى البروتوكول الاختياري الثاني الملحق بالعهد، الهادف إلى إلغاء عقوبة الإعدام.", "", "" },
                    { 575, null, "R36 P8", "ت.36.ف.8", "", "Non réalisé", "", 0, 2, null, 3, null, 5, null, "Organes de traités", "-Envisager la ratification des Conventions de 1954 et 1961 relatives à l’apatridie", "-          (و)  النظر في التصديق على اتفاقيتي عام 1954 و1961 المتعلقتين بانعدام الجنسية، ...", "", "" },
                    { 614, null, "R51", "ت.51", "", "Non réalisé", "", 0, 2, null, null, null, 5, null, "Organes de traités", "-            Ratifier Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels le plus tôt possible.", "تشجع اللجنة المملكة المغربية على التصديق على البروتوكول الاختياري ا��ملحق بالعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية في أقرب وقت ممكن.", "", "" },
                    { 654, null, "R14", "ت.14", "", "Non réalisé", "", 0, 2, null, 5, null, 5, null, "Organes de traités", "Poursuivre les actions allant dans le sens de la ratification des Conventions nos 97, 143 et 189 de l’OIT.", "مواصلة الإجراءات الرامية إلى التصديق على اتفاقيات منظمة العمل الدولية رقم 97 و143 و189", "", "" },
                    { 655, null, "R12", "ت.12", "", "Non réalisé", "", 0, 2, null, 5, null, 5, null, "Organes de traités", "Poursuivre les actions pour faire les déclarations prévues aux articles 76 et 77 de la Convention.", "مواصلة الإجراءات الرامية إلى تقديم الإعلانين المنصوص عليهما في المادتين 76 و77 من الاتفاقية.", "", "" },
                    { 692, null, "R15", "ت.15", "", "Non réalisé", "", 0, 2, null, 6, null, 5, null, "Organes de traités", @"Notifier, dans les meilleurs délais, au Secrétaire général, en sa qualité de dépositaire de la Convention, la levée des réserves et déclarations
                - continuer de prendre les mesures voulues pour lever toutes ses déclarations et réserves au sujet des articles 2 et 16 de la Convention, qui sont contraires à l’objet et au but de la Convention,  afin que les marocaines puissent se prévaloir de toutes les dispositions de la Convention", @"إشعار الأمين العام للأمم المتحدة، بصفته وديع الاتفاقية، بسحب التحفظات والتصريحات على الاتفاقية في أقرب وقت ممكن.
                - مواصلة اتخاذ الخطوات الضرورية لسحب كل ما تبقى من تصريحات وتحفظات على المادتين 2 و 16 من الاتفاقية، لأنها من وجهة نظر اللجنة تتعارض مع موضوع الاتفاقية وهدفها، وذلك من أجل أن تستفيد المرأة المغربية من جميع أحكام الاتفاقية", "", "" },
                    { 693, null, "R23P2", "ت.23.ف.2", "", "Non réalisé", "", 0, 2, null, 6, null, 5, null, "Organes de traités", "Ratifier le Protocole additionnel à la Convention des Nations Unies contre la criminalité transnationale organisée visant à prévenir, réprimer et punir la traite des personnes, en particulier des femmes et des enfants…...", "التصديق على بروتوكول منع وقمع ومعاقبة الاتجار بالأشخاص، وبخاصة النساء والأطفال، المكمل لاتفاقية الأمم المتحدة لمكافحة الجريمة المنظمة العابرة للحدود الوطنية،", "", "" },
                    { 694, null, "R47", "ت.47", "", "Non réalisé", "", 0, 2, null, 6, null, 5, null, "Organes de traités", "Signer et ratifier le Protocole facultatif relatif à la Convention et accepter la modification du paragraphe 1 de l’article 20 de la Convention relatif à la durée des réunions du Comité.", "التوقيع على البروتوكول الاختياري للاتفاقية والتصديق عليه، وقبول التعديل الذي أدخل على الفقرة 1 من المادة 20 من الاتفاقية، والمتعلق بمواعيد اجتماعات اللجنة.", "", "" },
                    { 695, null, "R51", "ت.51", "", "Non réalisé", "", 0, 2, null, 6, null, 5, null, "Organes de traités", "Envisager de ratifier les instruments auxquels le Maroc n’est pas encore partie, à savoir la Convention internationale pour la protection de toutes les personnes contre les disparitions forcées et la Convention relative aux droits des personnes handicapées.", "النظر في التصديق على المعاهدات التي لم تصبح بعد طرفاً فيها، وهما الاتفاقية الدولية لحماية جميع الأشخاص من الاختفاء القسري واتفاقية حقوق الأشخاص ذوي الإعاقة.", "", "" },
                    { 737, null, "R9", "ت.9", "", "Non réalisé", "", 0, 2, null, 7, null, 5, null, "Organes de traités", "Retirer la déclaration interprétative concernant le paragraphe 1 de l’article 14 de la Convention.", "-          تشجع اللجنة المملكة المغربية على سحب الإعلان التفسيري بشأن الفقرة 1 من المادة 14 من الاتفاقية، تمشياً مع توصياتها السابقة (الوثيقة CRC/C/15/Add.211  لعام 2003، الفقرة 8)، وفي ضوء إعلان وبرنامج عمل فيينا لعام 1993.", "", "" },
                    { 267, null, "R144.1", "1.144", "", "Non réalisé", "", 0, 2, 1, null, 7, 5, null, "Examen périodique universal", "-Ratifier le premier Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques", "التصديق على البروتوكول الاختياري الأول الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية والانضمام إلى البروتوكول الاختياري الأول الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 241, null, "R73P8-1", "null", "", "Non réalisé", "", 0, 2, null, null, null, 5, 9, "Procédure spéciale", "Envisager de ratifier les Protocoles facultatifs se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels et au Pacte international relatif aux droits civils et politiques", "null", "", "" },
                    { 216, null, "R91", "ت.91", "", "Non réalisé", "", 0, 2, null, null, null, 5, 8, "Procédure spéciale", "Ratifier le Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels.", "-       التصديق على البروتوكول الاختياري للعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية.", "", "" },
                    { 191, null, "R83P14P1", "null", "", "Non réalisé", "", 0, 2, null, null, null, 5, 7, "Procédure spéciale", "-       Prendre des mesures concrètes et durables pour parachever le processus de ratification du Protocole facultatif à la Convention contre la torture", "null", "", "" },
                    { 40, null, "R79P2", "null", "", "Non réalisé", "", 0, 1, null, null, null, 1, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’accès à la justice", "null", "", "" },
                    { 75, null, "R88P4", "ت.88.ف.4", "", "Non réalisé", "", 0, 1, null, null, null, 1, 3, "Procédure spéciale", "-    Faire en sorte que les déclarations ou les aveux d’une personne privée de liberté, qui ne sont pas faits en présence d’un juge et avec l’assistance d’un avocat, n’aient aucune valeur probante dans les procédures contre cette personne ;", "-          (د) ضمان ألا يكون لبيانات شخص مسلوب الحرية أو اعترافاته، غير تلك المدلى بها بحضور قاض أو بمساعدة محام، أي قوة مقنعة في الإجراءات المتعلقة بذلك الشخص؛", "", "" },
                    { 76, null, "R88P5", "ت.88.ف.5", "", "Non réalisé", "", 0, 1, null, null, null, 1, 3, "Procédure spéciale", "-    Faire en sorte que les rapports établis par la police judiciaire pendant l’enquête restent irrecevables dans le cadre d’un procès tant que l’accusation, à qui incombe la charge de la preuve, n’a pas prouvé leur véracité et leur validité juridique, conformément au Code de procédure pénale ;", "-          (ﻫ) التأكد من عدم قبول تقارير الشرطة القضائية المعدة إبّان مرحلة التحقيق في المحاكم حتى يثبت الادعاء صحتها وصلاحيتها القانونية وفقاً لقانون الإجراءات الجنائية؛", "", "" },
                    { 77, null, "R88P9", "ت.88.ف.9", "", "Non réalisé", "", 0, 1, null, null, null, 1, 3, "Procédure spéciale", "faire en sorte que le personnel médical des lieux de détention soit véritablement indépendant des organes chargés d’appliquer la loi et reçoive une formation au sujet du Protocole d’Istanbul ;-  autoriser l’accès à des examens médicaux indépendants effectués sans surveillance ni ingérence de la part d’agents chargés d’appliquer la loi ou de procureurs et d’assurer l’accès en temps voulu à des examens médicaux indépendants, au moment de l’arrestation, lors d’un transfert vers un autre lieu de détention ou sur demande;", "ط) التأكد من أن العاملين الطبيين في أماكن الاحتجاز مستقلون تماماً عن موظفي إنفاذ القانون، ومدربون على بروتوكول اسطنبول؛        الترخيص في الفحوص الطبية المستقلة دون تدخل العاملين في مجال إنفاذ القانون أو المدعين العامين أو حضورهم؛ وضمان تلك الفحوص في الوقت المناسب عند إلقاء القبض أو النقل إلى مكان احتجاز آخر أو عند الطلب؛", "", "" },
                    { 188, null, "R83P2", "null", "", "Non réalisé", "", 0, 1, null, null, null, 1, 7, "Procédure spéciale", "-       S’assurer que tous les suspects aient le droit de bénéficier, dans la pratique, des autres garanties fondamentales prévues par la loi, notamment le droit d’être examiné par un médecin indépendant, de communiquer avec un proche ou un ami, d’être informés de leurs droits et des charges retenues contre eux, et d’être traduits devant un juge sans délai", "null", "", "" },
                    { 189, null, "R83P9", "null", "", "Non réalisé", "", 0, 1, null, null, null, 1, 7, "Procédure spéciale", "-       Renforcer les efforts pour lutter contre la détention au secret, conformément à l’article 23 de la Constitution", "null", "", "" },
                    { 255, null, "R144.44P1", "44.144.ج.1", "", "Non réalisé", "", 0, 1, 1, null, 96, 1, null, "Examen périodique universal", "Poursuivre les réformes visant à consolider l’état de droit et les mécanismes nationaux de protection des droits de l’homme", "مواصلة الإصلاحات بقصد توطيد سيادة القانون لحماية حقوق الإنسان", "", "" },
                    { 256, null, "R144.123", "123.144", "", "Non réalisé", "", 0, 1, 1, null, 34, 1, null, "Examen périodique universal", "Mener des enquêtes complètes, impartiales et indépendantes sur toutes les allégations de corruption ou d’abus par les forces de sécurité et en poursuivre les responsables, le cas échéant", "إجراء تحقيقات كاملة ونزيهة ومستقلة في جميع ادعاءات الفساد أو الاعتداء على يد قوات الأمن وملاحقة المسؤولين عنها، عند الاقتضاء", "", "" },
                    { 257, null, "R144.124", "124.144", "", "Non réalisé", "", 0, 1, 1, null, 7, 1, null, "Examen périodique universal", "Prendre des mesures supplémentaires pour garantir l’indépendance du pouvoir judiciaire, ce qui est important pour garantir un procès équitable conformément aux normes internationales des droits de l’homme", "القيام بخطوات أخرى من أجل ضمان استقلال القضاء، وهو أمر مهم لضمان إجراء محاكمات عادلة بما يتفق مع المعايير الدولية لحقوق الإنسان", "", "" },
                    { 572, null, "R34", "ت.34", "", "Non réalisé", "", 0, 1, null, 3, null, 1, null, "Organes de traités", "a) Garantir et protéger la pleine indépendance et impartialité des juges et s’assurer qu’ils peuvent exercer les fonctions judiciaires sans aucune pression ou interférence ; et b) Veiller à ce que toutes les procédures judiciaires soient conduites dans le plein respect des garanties d’un procès équitable inscrites à l’article 14 du Pacte.", "ضمان وحماية استقلال القضاة وحيادهم على النحو الأكمل، والتأكد من أنهم يستطيعون أداء مهامهم القضائية دون أي ضغط أو تدخل -    الحرص على اتباع الإجراءات القضائية في ظل احترام ضمانات المحاكمة العادلة المذكورة في المادة 14 من العهد احتراماً كاملاً.", "", "" },
                    { 613, null, "R12P1P2", "ت.12.ف.1.ف.2", "", "Non réalisé", "", 0, 1, null, null, null, 1, null, "Organes de traités", @"a) Redoubler d’efforts pour lutter efficacement contre la corruption et garantir la transparence dans la conduite des affaires publiques, notamment en appliquant la loi no 113.12 et en tenant compte des observations des organisations de la société civile;
                - b) Veiller à la protection des dénonciateurs et des témoins en garantissant si nécessaire leur anonymat et en les protégeant contre toute forme de représailles ainsi que de fournir une compensation aux victimes", @"(أ) مضاعفة الجهود من أجل مكافحة الفساد وضمان الشفافية في تسيير الشؤون العامة بطرق منها تطبيق القانون رقم 113-12 والأخذ بملاحظات منظمات المجتمع المدني؛
                - (ب) الحرص على حماية المبلغين والشهود بضمان عدم الكشف عن هويتهم، عند الاقتضاء، وحمايتهم من التعرض لأي شكل من أشكال الانتقام ومنح تعويض للضحايا", "", "" },
                    { 190, null, "R83P11", "null", "", "Non réalisé", "", 0, 1, null, null, null, 2, 7, "Procédure spéciale", "-       Réformer le système judiciaire afin de garantir que toutes les personnes en détention préventive bénéficient d’un procès équitable et rapide", "null", "", "" },
                    { 258, null, "R144.125", "125.144", "", "Non réalisé", "", 0, 1, 1, null, 52, 2, null, "Examen périodique universal", "Mener à bien la réforme de la 28", "إكمال إصلاحات القضاء", "", "" },
                    { 738, null, "R31P4", "ت.31.ف.4", "", "Non réalisé", "", 0, 2, null, 7, null, 5, null, "Organes de traités", "Songer à ratifier la Convention de 1961 sur la réduction des cas d’apatridie.", "-           (د) النظر في التصديق على اتفاقية تخفيض حالات انعدام الجنسية                لعام 1961.", "", "" },
                    { 259, null, "R144.126", "126.144", "", "Non réalisé", "", 0, 1, 1, null, 99, 2, null, "Examen périodique universal", "Accélérer la mise en œuvre de la charte sur la réforme du système judiciaire", "تسريع تنفيذ ميثاق إصلاح منظومة العدالة", "", "" },
                    { 158, null, "R89P7", "null", "", "Non réalisé", "", 0, 1, null, null, null, 3, 6, "Procédure spéciale", "Adopter une approche globale et intégrée de la rédaction de toutes les lois d’application et organiques relatives aux institutions qui tirent leur mandat de la Constitution, afin d’assurer, dans toutes ces institutions, la cohérence et l’homogénéité requises, notamment l’application du principe de l’égalité des sexes et la réalisation des objectifs en matière d’égalité entre les hommes et les femmes, conformément aux normes internationales.  Les efforts de coordination entre le Gouvernement, le Conseil national des droits de l’homme, la société civile et d’autres partenaires devraient viser à assurer l’application effective des dispositions constitutionnelles", "null", "", "" },
                    { 215, null, "R83P1", "ت.83.ف.1", "", "Non réalisé", "", 0, 1, null, null, null, 3, 8, "Procédure spéciale", "De nouvelles dispositions constitutionnelles, en particulier celles qui concernent les droits et la diversité culturels, devraient être effectivement appliquées au moyen de textes législatifs, y compris tous les décrets pertinents, comme le stipule la Constitution", "ينبغي إنفاذ الأحكام الدستورية الجديدة، لا سيما تلك المتعلقة بالحقوق الثقافية والتنوع الثقافي، إنفاذاً فعالاً من خلال اعتماد قوانين، بما فيها جميع القوانين الفرعية المناسبة، مثلما ينص على ذلك الدستور. - تتطلب القوانين والتدابير الجديدة  المتعلقة بإنفاذ الأحكام الدستورية الجديدة، لا سيما تلك الخاصة بالحقوق الثقافية والتنوع الثقافي اعتماد سياسات واستراتيجيات مناسبة وينبغي أن تقترن بتدريب مناسب وتوجيه صحيح للمسؤولين المكلفين بتطبيقها.", "", "" },
                    { 261, null, "R144.117", "117.144", "", "Non réalisé", "", 0, 1, 1, null, 89, 3, null, "Examen périodique universal", "Veiller à ce que les dispositions de la Constitution sur la liberté de la presse, la liberté d’opinion et d’expression et la liberté de réunion et d’association soient respectées, y compris pour les personnes qui veulent exprimer leurs vues sur la situation du et au Sahara occidental", "ضمان احترام أحكام الدستور المتعلقة بحرية الصحافة وحرية الرأي والتعبير وحرية التجمع وتكوين الجمعيات، حتى للأشخاص الذين يريدون التعبير عن آرائهم بشأن الحالة في الصحراء الغربية ووضعها السياسي", "", "" },
                    { 262, null, "R144.114P2", "114.144.ج.2", "", "Non réalisé", "", 0, 1, 1, null, 36, 3, null, "Examen périodique universal", "Garantir pleinement les libertés d’expression et prendre toutes les mesures nécessaires pour veiller à ce que les défenseurs des droits de l’homme puissent s’acquitter de leur mission", "ضمان حرية تكوين الجمعيات ضماناً تاماً بغية كفالة تمكين المدافعين عن حقوق الإنسان من أداء مهماتهم", "", "" },
                    { 263, null, "R144.121", "121.144", "", "Non réalisé", "", 0, 1, 1, null, 89, 3, null, "Examen périodique universal", "Lever les obstacles à l’enregistrement des associations non gouvernementales auprès des autorités", "إزالة العوائق التي تمنع الجمعيات غير الحكومية من التماس تسجيلها من قِبل السلطات", "", "" },
                    { 264, null, "R144.122", "122.144", "", "Non réalisé", "", 0, 1, 1, null, 34, 3, null, "Examen périodique universal", "Approuver les demandes de licence pour toutes les associations non gouvernementales demandant l’enregistrement conformément à la loi, y compris les organisations qui défendent les membres des populations minoritaires", "الموافقة على طلبات الترخيص لجميع الجمعيات غير الحكومية التي تلتمس التسجيل وفقاً للقانون، بما فيها الجمعيات التي تدافع عن أفراد الأقليات من السكان", "", "" },
                    { 265, null, "R144.58P1", "58.144. ج.1", "", "Non réalisé", "", 0, 1, 1, null, 48, 3, null, "Examen périodique universal", "Veiller à établir des procédures régissant l’enregistrement des organisations de la société civile", "ضمان وضع إجراءات تحكم تسجيل منظمات المجتمع المدني ......", "", "" },
                    { 266, null, "R144.61P1", "61.144. ج.1", "", "Non réalisé", "", 0, 1, 1, null, 65, 3, null, "Examen périodique universal", "Veiller à ce que les procédures régissant l’enregistrement des organisations de la société civile, soient conformes aux normes internationales", "ضمان أن تكون الآليات التي تنظم تسجيل منظمات المجتمع المدني..... متوافقة مع المعايير الدولية", "", "" },
                    { 1, null, "R65", "null", "", "Non réalisé", "", 0, 2, null, null, null, 5, 1, "Procédure spéciale", "Ratifier le Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels", "null", "", "" },
                    { 78, null, "R88P14-1", "ت.88.ف.14ج1", "", "Non réalisé", "", 0, 2, null, null, null, 5, 3, "Procédure spéciale", "-    prendre des mesures concrètes pour accélérer la ratification du Protocole facultatif à la Convention contre la torture", "-          (ن) اتخاذ تدابير ملموسة لتسريع عملية التصديق على البروتوكول الاختياري الملحق باتفاقية مناهضة التعذيب.....", "", "" },
                    { 130, null, "R96P2", "null", "", "Non réalisé", "", 0, 2, null, null, null, 5, 4, "Procédure spéciale", "-    Envisager de ratifier la Convention no 189 de l’OIT sur les travailleuses et travailleurs domestiques.", "null", "", "" },
                    { 159, null, "R89P2", "null", "", "Non réalisé", "", 0, 2, null, null, null, 5, 6, "Procédure spéciale", "Retirer toutes les déclarations restantes au sujet de la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes, en particulier celles concernant l’article 2 et le paragraphe 4 de l’article 15, ainsi que la réserve à cet instrument", "null", "", "" },
                    { 160, null, "R89P3", "null", "", "Non réalisé", "", 0, 2, null, null, null, 5, 6, "Procédure spéciale", "Signer et ratifier le Protocole facultatif à la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes ou y adhérer, et ratifier la Convention pour la protection de toutes les personnes contre les disparitions forcées", "null", "", "" },
                    { 260, null, "R144.127", "127.144", "", "Non réalisé", "", 0, 1, 1, null, 87, 2, null, "Examen périodique universal", "Parachever le processus de réforme du système judiciaire et garantir l’indépendance du pouvoir judiciaire en conformité avec les exigences constitutionnelles", "مواصلة إتمام عملية إصلاح منظومة العدالة وضمان استقلال القضاء بما يتفق مع مقتضيات الدستور ذات الصلة", "", "" },
                    { 705, null, "R50", "ت.50", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", "Veiller à ce que la réalisation des objectifs du Millénaire pour le développement passe nécessairement par l’application intégrale de la Convention et que le principe de l’égalité des sexes et les dispositions de la Convention soient expressément pris en considération dans toutes les initiatives visant à la réalisation des objectifs du Millénaire pour le développement et inclure des informations à ce sujet dans son prochain rapport périodique.", "العمل على إدماج منظور جنساني في جميع الجهود الرامية إلى تحقيق الأهداف الإنمائية للألفية، وعلى أن تتجلى أحكام الاتفاقية صراحة في جميع الجهود الرامية إلى بلوغ الأهداف الإنمائية للألفية وتضمين معلومات عن ذلك في تقريرها الدوري المقبل.", "", "" },
                    { 739, null, "R65 P4", "ت.65.ف.4", "", "Non réalisé", "", 0, 2, null, 7, null, 5, null, "Organes de traités", "Songer à ratifier la Convention no 189 (2011) de l’Organisation internationale du Travail (OIT), sur les travailleuses et travailleurs domestiques ;", "-           (د) النظر في التصديق على اتفاقية منظمة العمل الدولية رقم 189 بشأن العمل اللائق للعمال المنزليين", "", "" },
                    { 808, null, "R57", "ت.57", "", "Non réalisé", "", 0, 2, null, 8, null, 5, null, "Organes de traités", "-                    mener rapidement à terme le processus de ratification du Traité de Marrakech visant à faciliter l’accès des aveugles, des déficients visuels et des personnes ayant d’autres difficultés de lecture des textes imprimés aux œuvres publiées", "-          تسريع الإجراءات لاستكمال عملية التصديق على معاهدة مراكش لتيسير النفاذ إلى المصنفات المنشورة لفائدة الأشخاص المكفوفين أو معاقي البصر أو ذوي إعاقات أخرى في قراءة المطبوعات.", "", "" },
                    { 524, null, "R20P2", "ت.20.ف.2", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "Fournir au Comité des informations sur tout décès en détention résultant d’actes de torture, de mauvais traitements ou d’une négligence volontaire.", "تقديم معلومات إلى اللجنة عن كل حالة وفاة في الحجز نتيجة التعذيب وسوء المعاملة أو الإهمال المتعمد.", "", "" },
                    { 525, null, "R26P4", "ت.26.ف.4", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "-  Fournir dans le prochain rapport des informations détaillées sur les lieux de détention et les régimes de détention des étrangers en attente d’expulsion ainsi que des données ventilées par année, genre, lieu, durée de détention et raison justifiant la détention et l’expulsion.", "تضمين التقرير القادم معلومات مفصلة عن أماكن الاحتجاز وعن أنظمة حبس الأجانب في انتظار طردهم وبيانات مصنّفة حسب السنة ونوع الجنس ومكان ومدة الاحتجاز والسبب الذي يبرر الاحتجاز والطرد.", "", "" },
                    { 526, null, "R26P4", "ت.26.ف.4", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "Fournir dans le prochain rapport des informations détaillées sur les lieux de détention et les régimes de détention des étrangers en attente d’expulsion ainsi que des données ventilées par année, genre, lieu, durée de détention et raison justifiant la détention et l’expulsion.", "تضمين التقرير القادم معلومات مفصلة عن أماكن الاحتجاز وعن أنظمة حبس الأجانب في انتظار طردهم وبيانات مصنّفة حسب السنة ونوع الجنس ومكان ومدة الاحتجاز والسبب الذي يبرر الاحتجاز والطرد.", "", "" },
                    { 527, null, "R35", "ت.35", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "Soumettre le prochain rapport périodique, qui sera le cinquième, le 25 novembre 2015 au plus tard.", "تقديم التقرير الدوري المقبل، وهو الخامس، في موعد لا يتجاوز 25 نونبر 2015 على أبعد تقدير. القبول، قبل 25 نونبر 2012، بتقديم التقرير طبقاً للإجراء الاختياري الذي يتمثل في إحالة اللجنة إلى الدولة الطرف مجموعة أسئلة تمهيداً للتقرير الدوري. وستشكل ردود الدولة الطرف على هذه المجموعة من الأسئلة التقرير الدوري المقبل للدولة الطرف بموجب المادة 19 من الاتفاقية.", "", "" },
                    { 528, null, "R35", "ت.35", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "Accepter, avant le 25 novembre 2012, de soumettre le rapport selon la procédure facultative qui consiste en la transmission par le Comité à l’État partie d’une liste de questions préalable au rapport périodique.", "تقديم التقرير الدوري المقبل، وهو الخامس، في موعد لا يتجاوز 25 نونبر 2015 على أبعد تقدير. القبول، قبل 25 نونبر 2012، بتقديم التقرير طبقاً للإجراء الاختياري الذي يتمثل في إحالة اللجنة إلى الدولة الطرف مجموعة أسئلة تمهيداً للتقرير الدوري. وستشكل ردود الدولة الطرف على هذه المجموعة من الأسئلة التقرير الدوري المقبل للدولة الطرف بموجب المادة 19 من الاتفاقية.", "", "" },
                    { 576, null, "R52", "ت.52", "", "Non réalisé", "", 0, 2, null, 3, null, 7, null, "Organes de traités", "Faire parvenir, dans un délai d’un an à compter de l’adoption des présentes observations finales, des renseignements sur la suite donnée aux recommandations faites par le Comité aux paragraphes 18 (lutte contre le terrorisme), 24 (interdiction de la torture et des mauvais traitements) et 42 (liberté d’association et activités des défenseurs des droits de l’homme)", "-          تقديم، معلومات عن تنفيذها التوصيات التي قدمتها اللجنة في الفقرات 18 (مكافحة الإرهاب)، و24 (حظر التعذيب وسوء المعاملة)، و42 (حرية تكوين الجمعيات وأنشطة المدافعين عن حقوق الإنسان) في غضون عام من اعتماد هذه الملاحظات الختامية، وذلك عملاً بالفقرة 5 من المادة 71 من النظام الداخلي للجنة،", "", "" },
                    { 577, null, "R53", "ت.53", "", "Non réalisé", "", 0, 2, null, 3, null, 7, null, "Organes de traités", "- Soumettre le prochain rapport périodique le 4 novembre 2020 au plus tard et y faire figurer des renseignements précis et à jour sur la mise en œuvre des recommandations faites dans les présentes observations finales et sur l’application du Pacte dans son ensemble.", "-           تقديم التقرير الدوري المقبل بحلول 4 تشرين الثاني/نوفمبر 2020 على أقصى تقدير، وتضمينه معلومات محددة ومحدثة عن تنفيذ التوصيات المقدمة في هذه الملاحظات الختامية وعن تنفيذ العهد ككل.", "", "" },
                    { 578, null, "R53", "ت.53", "", "Non réalisé", "", 0, 2, null, 3, null, 7, null, "Organes de traités", "- Consulter largement la société civile et les organisations non gouvernementales présentes dans le pays aux fins de l’élaboration du rapport.", "-          إجراء مشاورات واسعة مع المجتمع المدني والمنظمات غير الحكومية العاملة في البلد عند إعداد التقرير.وفقاً لقرار الجمعية العامة 68/268، على ألا يتجاوز عدد كلماته 200 21 كلمة.", "", "" },
                    { 579, null, "R53", "ت.53", "", "Non réalisé", "", 0, 2, null, 3, null, 7, null, "Organes de traités", "- Accepter, d’ici le 4 novembre 2017, la procédure simplifiée d’établissement des rapports, qui consiste pour le Comité à transmettre une liste de points à l’État partie avant que celui-ci ne soumette le rapport périodique. Les réponses de l’État partie à cette liste constitueront dès lors le prochain rapport périodique devant être soumis conformément à l’article 40 du Pacte.", "-          القبول، بحلول 4 تشرين الثاني/نوفمبر 2017، الإجراء المبسط لتقديم التقارير الذي يتمثل في إحالة اللجنة قائمة مسائل إلى الدولة الطرف قبل أن تقدم تقريرها الدوري. وهكذا، تكون ردود الدولة الطرف على قائمة المسائل هذه بمثابة التقرير الدوري المقبل الذي يقدم بموجب المادة 40 من العهد.", "", "" },
                    { 615, null, "R10P2", "ت.10.ف.2", "", "Non réalisé", "", 0, 2, null, null, null, 7, null, "Organes de traités", "-            Inclure, dans le prochain rapport périodique, des informations relatives aux décisions judiciaires ou administratives prises dans le sens de l’10 de l’ordre juridique interne avec le pacte.", "-          تضمين التقرير الدوري المقبل معلومات عن القرارات القضائية أو الإدارية المتخذة لتطبيق العهد في النظام القانوني الداخلي", "", "" },
                    { 616, null, "R52P1P2", "ت.52.ف.1.ف.2", "", "Non réalisé", "", 0, 2, null, null, null, 7, null, "Organes de traités", @"Encourager une collecte systématique de données et d’élaborer et d’utiliser des statistiques sur les indicateurs des droits de l’homme, dont les droits économiques, sociaux et culturels, fondées sur de telles données.
                - Faire figurer dans le prochain rapport périodique des données statistiques annuelles comparatives sur l’exercice de chaque droit énoncé dans le Pacte, ventilées par âge, sexe, population rurale/urbaine et autres critères pertinents, en prêtant une attention particulière à la situation des groupes défavorisés.", @"تشجع اللجنة المملكة المغربية على التجميع المنهجي للبيانات وإعداد إحصاءات تتعلق بمؤشرات حقوق الإنسان، بما في ذلك الحقوق الاقتصادية والاجتماعية والثقافية، واستخدام هذه الإحصاءات.
                - تضمين التقرير الدوري المقبل بيانات إحصائية سنوية مقارنة عن التمتع بكل حق يكفله العهد، تكون مصنفة بحسب السن والجنس وسكان المدن/الأرياف وأية معايير أخرى ذات صلة، مع إيلاء اهتمام خاص لوضع الفئات المحرومة.", "", "" },
                    { 617, null, "R53P1P2", "ت.53.ف.1.ف.2", "", "Non réalisé", "", 0, 2, null, null, null, 7, null, "Organes de traités", "-            Diffuser largement les présentes observations finales dans tous les secteurs de la société, en particulier auprès des agents de l’État, des autorités judiciaires, des 32aires, des avocats et des organisations de la société civile, et de l’informer, dans le prochain rapport périodique, des mesures prises pour les mettre en œuvre.", "-          نشر هذه الملاحظات الختامية على نطاق واسع وعلى جميع صُعُد المجتمع، وبخاصة في أوساط الموظفين العموميين والسلطات القضائية والبرلمانيين والمحامين ومنظمات المجتمع المدني، وتبليغ اللجنة في التقرير الدوري المقبل بما تم اتخاذه من تدابير لتنفيذ هذه الملاحظات.", "", "" },
                    { 618, null, "R54", "ت.54", "", "Non réalisé", "", 0, 2, null, null, null, 7, null, "Organes de traités", "-            Présenter son cinquième rapport périodique, conformément aux directives adoptées par le Comité en 2008 (E/C.12/2008/2), d’ici au 31 octobre 2020.", "-          تقديم التقرير الدوري الخامس، وفقاً للمبادئ التوجيهية التي اعتمدتها اللجنة في عام 2008 (E/C.12/2008/2)، بحلول 31 أكتوبر 2020.", "", "" },
                    { 656, null, "R16", "ت.16", "", "Non réalisé", "", 0, 2, null, 5, null, 7, null, "Organes de traités", "faire figurer dans le prochain rapport périodique des données ventilées sur les domaines et les conditions dans lesquels les travailleurs migrants sont employés, y compris ceux en situation irrégulière, ainsi que sur leur jouissance des droits qui leur sont reconnus par la Convention et fournir  des renseignements sur le nombre de travailleurs migrants marocains et de membres de leur famille se trouvant à l’étranger, y compris ceux qui sont en situation irrégulière.                                         - faire figurer dans le prochain rapport périodique des données ventilées sur les domaines et les conditions dans lesquels les travailleurs migrants sont employés, y compris ceux en situation irrégulière, ainsi que sur leur jouissance des droits qui leur sont reconnus par la Convention et fournir  des renseignements sur le nombre de travailleurs migrants marocains et de membres de leur famille se trouvant à l’étranger, y compris ceux qui sont en situation irrégulière.", "تضمين تقريرها الدوري المقبل بيانات مصنفة عن:  - مجالات وظروف عمل العمال المهاجرين بمن فيهم العمال الموجودون في وضع غير قانوني، وعن مدى تمتعهم بالحقوق المعترف بها في الاتفاقية. - عدد العمال المهاجرين المغاربة وأفراد أسرهم في الخارج، بمن فيهم الموجودون في وضع غير قانوني. -   في غياب المعلومات الدقيقة، تود اللجنة الحصول على بيانات موثوق بها تستند إلى استقصاءات أو تقديرات ذات مصداقية.", "", "" },
                    { 657, null, "R49", "ت.49", "", "Non réalisé", "", 0, 2, null, 5, null, 7, null, "Organes de traités", "-       faire figurer dans le deuxième rapport périodique des renseignements détaillés sur les mesures   prises pour donner suite aux recommandations formulées dans les présentes observations finales et prendre toutes les dispositions voulues pour que lesdites recommandations soient appliquées.", "تضمين التقرير الدوري الثاني معلومات مفصَّلة عما اتخذته الدولة من تدابير لتنفيذ التوصيات المقدمة في هذه الملاحظات الختامية. واتخاذ جميع التدابير المطلوبة لضمان تنفيذ هذه التوصيات.", "", "" },
                    { 658, null, "R50", "ت.50", "", "Non réalisé", "", 0, 2, null, 5, null, 7, null, "Organes de traités", "associer à l’élaboration du deuxième rapport périodique les organisations de la société civile travaillant dans le domaine de la migration au niveau national.", "- إشراك منظمات المجتمع المدني العاملة في مجال الهجرة على الصعيد الوطني في إعداد تقريرها الدوري الثاني.", "", "" },
                    { 659, null, "R53", "ت.53", "", "Non réalisé", "", 0, 2, null, 5, null, 7, null, "Organes de traités", "Assurer une large participation de tous les ministères et organismes publics à l’établissement du prochain rapport et de consulter à cette occasion diverses organisations de défense des droits des travailleurs migrants et des droits de l’homme.", "- كفالة مشاركة جميع الوزارات والهيئات الحكومية مشاركة واسعة في إعداد التقرير المُقبل والتشاور بهذه المناسبة مع منظمات شتى للدفاع عن حقوق العمال المهاجرين وحقوق الإنسان.", "", "" },
                    { 660, null, "R52", "ت.52", "", "Non réalisé", "", 0, 2, null, 5, null, 7, null, "Organes de traités", "-soumettre le deuxième rapport périodique le 13 septembre 2018 au plus tard. -opter pour la procédure simplifiée de soumission de rapports, suivant laquelle le Comité établit à l’intention de l’État partie une liste de points à traiter. Les réponses de l’État partie à cette liste constituent son rapport aux fins de l’article 73 de la Convention et le dispensent de soumettre son rapport selon la formule classique. Cette nouvelle procédure facultative a été adoptée par le Comité à sa quatorzième session, en avril 2011 (voir A/66/48, par. 26).", "52- تقديم التقرير الدوري الثاني في موعد أقصاه 13 سبتمبر 2018.", "", "" },
                    { 661, null, "R54", "ت.54", "", "Non réalisé", "", 0, 2, null, 5, null, 7, null, "Organes de traités", "suivre les directives harmonisées concernant l’établissement des rapports destinés aux organes créés en vertu d’instruments internationaux relatifs aux droits de l’homme (HRI/GEN/2/Rev.6), notamment les directives portant sur le document de bases communes et les rapports propres à chaque instrument. Le document propre à la Convention ne devrait pas dépasser 40 pages et le document de base commun mis à jour ne devrait pas dépasser 80 pages.", @"اتباع المبادئ التوجيهية المنسَّقة لتقديم التقارير بموجب المعاهدات الدولية لحقوق الإنسان (HRI/GEN/2/Rev.6)، بما في ذلك المبادئ التوجيهية لتقديم وثيقة أساسية موحَّدة ووثائق خاصة بمعاهدات بعينها. 
                ينبغي ألا يتجاوز حجم الوثيقة الخاصة بالاتفاقية 40 صفحة والوثيقة الأساسية الموحدة المُحدَّثة 80 صفحة.", "", "" },
                    { 696, null, "R9", "ت.9", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", @"appliquer، de manière systématique et constante, toutes les dispositions de la Convention, 
                - les sujets de préoccupation et recommandations figurant dans les présentes observations finales doivent faire l’objet d’une attention prioritaire de la part de l’État partie jusqu’à la soumission du prochain rapport périodique. 
                - le Maroc doit axer ses activités de mise en œuvre sur ces questions et à faire rapport sur les mesures prises et les résultats obtenus dans son prochain rapport périodique. 
                - le Maroc doit soumettre les présentes observations finales à tous les ministères compétents, au 32et aux autorités judiciaires afin d’en assurer l’application pleine et entière.
                -  le Maroc est encouragé à poursuivre ses réformes en concertation avec la société civile, en particulier les organisations de femmes.", @"تذكر اللجنة بالتزام المغرب بتنفيذ جميع أحكام الاتفاقية على نحو منهجي ومستمر، 
                - ترى اللجنة أن الشواغل والتوصيات المحددة في هذه ا��تعليقات الختامية تتطلب الأولوية من حيث العناية من الآن وإلى حين تقديم التقرير المرحلي المقبل. وعليه، فإن  
                - تدعو اللجنة   إلى أن يتم التركيز على المجالات التي حددتها في أنشطة التنفيذ التي تضطلع بها، وأن تبلغ المملكة المغربية في تقريرها الدوري المقبل عن الإجراءات المتخذة والنتائج المحققة. 
                -تدعو اللجنة المغرب إلى عرض هذه التعليقات الختامية على البرلمان وكافة الوزارات الحكومية المعنية والسلطات القضائية لكفالة تنفيذها تنفيذا كاملا.", "", "" },
                    { 697, null, "R17P3", "ت.17.ف.3", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", "Fournir, dans son prochain rapport périodique, des renseignements détaillés concernant les voies de recours disponibles en cas de discrimination, les affaires de discrimination portées devant le Médiateur et les tribunaux et les suites qui leur sont données", "- تضمين التقرير الدوري المقبل معلومات مفصلة عن سبل الانتصاف المتاحة في حالات التمييز، وعن الشكاوى المقدمة في الحالات المتصلة بالتمييز ضد المرأة أمام ديوان المظالم والمحاكم، وعن النتائج التي أسفرت عنها.", "", "" },
                    { 698, null, "R21P5", "ت.21.ف.5", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", "Présenter, dans le prochain rapport, des informations sur les lois et politiques en vigueur visant à lutter contre les violences familiales y compris le viol conjugal et de rendre compte des effets des mesures prises", "تضمين التقرير المقبل معلومات عن القوانين والسياسات المعمول بها للتصدي للعنف الأسري بما في ذلك الاغتصاب الزوجي وعن أثر التدابير المتخذة في هذا الصدد.", "", "" },
                    { 699, null, "R45P1", "ت.45.ف.1", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", "Continuer à renforcer la coopération avec le Haut-Commissariat des Nations Unies pour les réfugiés (HCR)", "مواصلة تقوية التعاون مع مفوضية الأمم المتحدة لشؤون اللاجئين", "", "" },
                    { 700, null, "R53", "ت.53", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", "répondre aux préoccupations exprimées dans les présentes observations dans le prochain rapport périodique que le Maroc présentera en application de l’article 18 de la Convention et présenter dans un rapport unique, en 2014, le  cinquième rapport périodique, qui devait être soumis en juillet 2010, et le sixième rapport périodique, prévu pour juillet 2014.", "الاستجابة للشواغل المعرب عنها في التعليقات الختامية الحالية وذلك في التقرير الذي سيقدم بموجب المادة 18 من الاتفاقية. ‎          تقديم التقرير الدوري ‏الخامس، الذي يحل موعد تقديمه في تموز/يوليه 2010، والتقرير الدوري السادس، الذي يحل موعد ‏تقديمه في تموز/يوليه 2014، في تقرير موحد في تموز/يوليه 2014.", "", "" },
                    { 701, null, "R23P3", "ت.23.ف.3", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", "communiquer, dans le prochain rapport périodique, des données statistiques sur la traite et l’exploitation.", "موافاة اللجنة، في التقرير الدوري المقبل، ببيانات إحصائية تتعلق بالاتجار بالأشخاص واستغلالهم.", "", "" },
                    { 702, null, "R46", "ت.46", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", @"Améliorer la collecte et l’analyse de données statistiques et inclure dans le prochain rapport des données statistiques sur la situation des femmes, ventilées par âge, zone de résidence urbaine ou rurale, appartenance ethnique et origine régionale, Sahara occidental compris, de façon à donner une idée claire de la situation des femmes et indiquer l’impact des mesures prises et les résultats obtenus en ce qui concerne l’égalité effective entre les sexes.
                -Indiquer l’impact des mesures prises et les résultats obtenus en ce qui concerne l’égalité effective entre les sexes.", @"تعزيز عملية جمع البيانات وتحليلها، وتضمين التقرير المقبل بيانات إحصائية وتحليلات عن وضع المرأة، مصنفة حسب السن، وحسب المناطق الريفية والحضرية، والعرق، والدين، متضمنة الصحراء الغربية، لتقديم صورة واضحة لحالة المرأة في الدولة الطرف. 
                -توضيح تأثير التدابير المتخذة والنتائج المحققة في التطبيق العملي على التحقيق الفعلي لمساواة المرأة بالرجل.", "", "" },
                    { 703, null, "R48", "ت.48", "", "Non réalisé", "", 0, 2, null, 6, null, 7, null, "Organes de traités", "Associer tous les ministères et organismes publics à l’élaboration du prochain rapport et consulter les organisations non gouvernementales à cette occasion. Soumettre le rapport à l’examen de son 32avant de le lui présenter.", "كفالة المشاركة الواسعة لجميع الوزارات والهيئات العامة في إعداد التقرير التالي، ومواصلة التشاور مع المنظمات غير الحكومية خلال تلك المرحلة. وإشراك البرلمان في مناقشة التقرير قبل تقديمه إلى اللجنة.", "", "" },
                    { 523, null, "R17P3", "ت.17ف.3", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "Prendre toutes mesures correctives appropriées et informer le Comité de ses conclusions sur les aveux sous la contrainte mentionnés dans le paragraphe 17 des observations.", "-          اتخاذ جميع الإجراءات التصحيحية المناسبة وإبلاغ اللجنة بالنتائج التي تخلص إليها بخصوص القضايا المثارة حول التصريحات المنتزعة تحت التعذيب المشار إليها في الفقرة 17 من التوصيات", "", "" },
                    { 522, null, "R17P3", "ت.17ف.3", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "-            Prendre toutes mesures correctives appropriées et informer le Comité de ses conclusions sur les aveux sous la contrainte mentionnés dans le paragraphe 17 des observations.", "-          اتخاذ جميع الإجراءات التصحيحية المناسبة وإبلاغ اللجنة بالنتائج التي تخلص إليها بخصوص القضايا المثارة حول التصريحات المنتزعة تحت التعذيب المشار إليها في الفقرة 17 من التوصيات", "", "" },
                    { 521, null, "R9P4P5", "ت.9.ف.4.ف.5", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "Respecter les obligations internationales et se conformer aux décisions finales et provisoires du Comité dans les cas individuels qui lui sont soumis en vertu de l’article 22 de la Convention. Dans le cas de M. Ktiti, le Maroc devrait décider d’annuler son extradition vers son pays d’origine, de manière définitive, sous peine de violer l’article 3 de la Convention", "احترام الالتزامات الدولية والامتثال للقرارات النهائية والقرارات المؤقتة التي تصدر عن اللجنة في القضايا الفردية المعروضة عليها بموجب المادة 22 من الاتفاقية. فيما يتعلق بقضية السيد كتيتي، ينبغي أن يصدر المغرب قراراً يقضي نهائياً بإلغاء تسليمه إلى بلده الأصلي، وإلا فإنّه سيُعدّ منتهكاً لأحكام المادة 3 من الاتفاقية.", "", "" },
                    { 520, null, "R23P5", "ت.23.ف.5", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "-            Présenter dans le prochain rapport au Comité des informations sur les lois et les politiques en vigueur pour lutter contre les violences envers les femmes et rendre compte des effets des mesures prises.", "تقديم، معلومات عن القوانين والسياسات السارية لمكافحة أعمال العنف المرتكبة في حق المرأة في التقرير المقبل إلى اللجنة، وتقديم معلومات عن آثار التدابير المتخذة.", "", "" },
                    { 41, null, "R86", "null", "", "Non réalisé", "", 0, 2, null, null, null, 6, 2, "Procédure spéciale", "-       Inviter le Rapporteur spécial sur les droits de l’homme des migrants à effectuer une visite de pays", "null", "", "" },
                    { 278, null, "R144.20", "20.144", "", "Non réalisé", "", 0, 2, 1, null, 22, 6, null, "Examen périodique universal", "Continuer d’interagir de manière constructive avec les mécanismes des procédures spéciales du Conseil des droits de l’homme", "مواصلة التحاور بشكلٍ بنّاء مع آليات الإجراءات الخاصة التابعة لمجلس حقوق الإنسان", "", "" },
                    { 279, null, "R144.21", "21.144", "", "Non réalisé", "", 0, 2, 1, null, 42, 6, null, "Examen périodique universal", "Adresser une invitation permanente aux titulaires de mandat au titre des procédures spéciales du Conseil des droits de l’homme", "توجيه دعوة دائمة إلى المكلفين بولايات في إطار الإجراءات الخاصة التابعة لمجلس حقوق الإنسان", "", "" },
                    { 280, null, "R144.22", "22.144", "", "Non réalisé", "", 0, 2, 1, null, 53, 6, null, "Examen périodique universal", "Adresser une invitation permanente aux titulaires de mandat au titre des procédures spéciales, comme cela a été précédemment recommandé", "توجيه دعوة دائمة للإجراءات الخاصة، مثلما سبقت التوصية بذلك", "", "" },
                    { 281, null, "R144.23", "23.144", "", "Non réalisé", "", 0, 2, 1, null, 73, 6, null, "Examen périodique universal", "Prendre des mesures concrètes pour renforcer sa coopération avec les procédures spéciales de l’ONU, notamment celles du Conseil des droits de l’homme", "اتخاذ خطوات حقيقية من أجل تعزيز التعاون مع الإجراءات الخاصة التابعة للأمم المتحدة، ولا سيما مع إجراءات مجلس حقوق الإنسان", "", "" },
                    { 516, null, "R30", "ت.30", "", "Non réalisé", "", 0, 2, null, 2, null, 6, null, "Organes de traités", "Intensifier la coopération avec les mécanismes des droits de l’homme de l’ONU, notamment en autorisant les visites, entre autres :du Groupe de travail sur la détention arbitraire, de la Rapporteuse spéciale sur la traite des êtres humains, en particulier les femmes et les enfants et du Rapporteur spécial sur le droit de réunion et d’association pacifiques", "تكثيف التعاون مع آليات حقوق الإنسان التابعة للأمم المتحدة، خاصة بترخيص الزيارات والتي من بينها: زيارة فريق العمل المعني بالاحتجاز التعسفي، زيارة المقررة الخاصة المعنية بالاتجار بالبشر، وخاصة النساء والأطفال، زيارة المقرر الخاص المعني بحرية التجمع وتكوين الجمعيات", "", "" },
                    { 42, null, "R69", "null", "", "Non réalisé", "", 0, 2, null, null, null, 7, 2, "Procédure spéciale", "-       Soumettre sans plus tarder le rapport unique valant dix-neuvième, vingtième et vingt et unième rapports périodiques au Comité pour l’élimination de la discrimination raciale.", "null", "", "" },
                    { 79, null, "R90P1", "ت.90.ف.1", "", "Non réalisé", "", 0, 2, null, null, null, 7, 3, "Procédure spéciale", "-    Collaborer plus étroitement avec le Haut-Commissariat des Nations Unies aux droits de l’homme, le Rapporteur spécial sur les droits de l’homme des migrants et d’autres organismes des Nations Unies, tels que le Haut-Commissariat des Nations Unies pour les réfugiés", "-          فيما يتعلق بالمهاجرين واللاجئين وملتمسي اللجوء، يوصي المقرر الخاص الحكومة بأن توثق تعاونها مع مفوضية الأمم المتحدة السامية لحقوق الإنسان، والمقرر الخاص المعني بحقوق الإنسان للمهاجرين، ووكالات أخرى تابعة للأمم المتحدة، مثل مفوضية الأمم المتحدة السامية لشؤون اللاجئين؛ كما يوصيها بما يلي:", "", "" },
                    { 80, null, "R97P3", "ت.97.ف.3", "", "Non réalisé", "", 0, 2, null, null, null, 7, 3, "Procédure spéciale", "En ce qui concerne les provinces marocaines du Sud - Trouver des moyens pour renforcer encore plus la protection des droits de l’homme internationalement reconnus, notamment en adressant des invitations aux titulaires de mandat au titre des procédures spéciales de l’Organisation des Nations Unies, en renforçant la coopération avec la société civile et l’institution nationale des droits de l’homme et en facilitant la présence d’organisations non gouvernementales régionales", "فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي:- (ج) استحداث جميع الوسائل الممكنة لتعزيز حماية حقوق الإنسان المعترف بها دولياً بسبل منها دعوة آليات الإجراءات الخاصة التابعة للأمم المتحدة؛ وتدعيم التعاون مع المجتمع المدني والمؤسسة الوطنية لحقوق الإنسان؛ وتسهيل حضور المنظمات غير الحكومية الدولية؛", "", "" },
                    { 131, null, "R95P1", "null", "", "Non réalisé", "", 0, 2, null, null, null, 7, 4, "Procédure spéciale", "-    Poursuivre la collaboration étroite avec les organisations internationales et les organismes des Nations Unies compétents, notamment avec le HCR et l’OIM, afin de permettre aux victimes de la traite de retourner saines et sauves dans leur pays, en tenant dûment compte, s’il y a lieu, de la nécessité de leur garantir une protection internationale.", "null", "", "" },
                    { 132, null, "R97", "null", "", "Non réalisé", "", 0, 2, null, null, null, 7, 4, "Procédure spéciale", "collaborer avec les organisations internationales et bilatérales aux fins de l’hébergement et de l’indemnisation des victimes de la traite.  Envisager la possibilité d’utiliser les revenus issus du blanchiment d’argent ou les avoirs confisqués aux trafiquants comme ressources complémentaires pour financer l’aide aux victimes", "null", "", "" },
                    { 161, null, "R89P13", "null", "", "Non réalisé", "", 0, 2, null, null, null, 7, 6, "Procédure spéciale", "Solliciter l’assistance technique de l’Organisation des Nations Unies en vue d’accroître la sensibilisation aux obligations internationales de l’État et d’en promouvoir le respect, notamment en ce qui concerne l’égalité et les droits fondamentaux des femmes, en s’appuyant sur l’attachement du Maroc à la coopération avec tous les organes et organismes des Nations Unies.", "null", "", "" },
                    { 192, null, "R83P16", "null", "", "Non réalisé", "", 0, 2, null, null, null, 7, 7, "Procédure spéciale", "-       En ce qui concerne les migrants en situation irrégulière, réfugiés et demandeurs d’asile, travailler en coopération plus étroite avec le Haut-Commissariat des Nations Unies pour les réfugiés ; le Haut-Commissariat des Nations Unies aux droits de l’homme ; le Rapporteur spécial sur les droits de l’homme des migrants et d’autres organismes des Nations Unies", "null", "", "" },
                    { 740, null, "R76", "ت.76", "", "Non réalisé", "", 0, 2, null, 7, null, 5, null, "Organes de traités", "Ratifier les principaux instruments relatifs aux droits de l’homme auxquels le Maroc n’est pas encore partie, à savoir le Protocole facultatif à la Convention relative aux droits de l’enfant établissant une procédure de présentation de communications ainsi que les protocoles facultatifs à d’autres instruments de l’ONU relatifs aux droits de l’homme.", "-          التصديق على الصكوك الأساسية لحقوق الإنسان التي لا تعد المملكة المغربية طرفاً فيها بعد، أي البروتوكول الاختياري لاتفاقية حقوق الطفل المتعلق بإجراء تقديم البلاغات، إضافة إلى البروتوكولات الاختيارية لصكوك الأمم المتحدة الأخرى في مجال حقوق الإنسان، وذلك لمواصلة الارتقاء بمستوى إعمال حقوق الطفل.", "", "" },
                    { 217, null, "R90P3", "ت.90.ق.3", "", "Non réalisé", "", 0, 2, null, null, null, 7, 8, "Procédure spéciale", "Intensifier les efforts pour appliquer la Convention pour la sauvegarde du patrimoine culturel immatériel.", "إنشاء آليات تسمح للأشخاص باتخاذ قرارات فعالة ومجدية والمشاركة في تحديد التراث الثقافي وتفسيره وتعزيزه وحمايته. - توفير الدعم القانوني والمالي والمؤسسي لمقترح 'الكنوز البشرية الحية'. وينبغي للمغرب أيضاً - الدفع قدما بالجهود فيما يتعلق بتنفيذ اتفاقية صون التراث الثقافي غير المادي.", "", "" },
                    { 282, null, "R144.17", "17.144", "", "Non réalisé", "", 0, 2, 1, null, 80, 7, null, "Examen périodique universal", "Adopter un processus de sélection ouvert, fondé sur le mérite, pour sélectionner les candidats nationaux aux élections aux organes conventionnels de l’ONU", "اعتماد إجراء اختيار علني وقائم على الجدارة والاستحقاق عند اختيار المرشحين الوطنيين لانتخاب أعضاءٍ في هيئات معاهدات الأمم المتحدة", "", "" },
                    { 283, null, "R144.29", "29.144.", "", "Non réalisé", "", 0, 2, 1, null, 84, 7, null, "Examen périodique universal", "Continuer de travailler avec le HCDH et le Haut-Commissariat des Nations Unies pour les réfugiés pour rétablir le programme d’aide humanitaire à la population du Sahara occidental", "مواصلة العمل مع مفوضية الأمم المتحدة السامية لحقوق الإنسان ومع مكتب مفوضية الأمم المتحدة السامية لشؤون اللاجئين من أجل إعادة العمل ببرنامج المعونة الإنسانية لسكان الصحراء الغربية", "", "" },
                    { 481, null, "R7", "ت.7", "", "Non réalisé", "", 0, 2, null, 1, null, 7, null, "Organes de traités", "A la lumière de sa Recommandation générale no.8 (1990) concernant l’interprétation et l’application des paragraphes 1 et 4 de l’article premier de la Convention et conformément aux paragraphes 10 à 12 des directives révisées concernant l’établissement de rapports (CERD/C/2007/1), le Comité recommande à l’État partie de fournir des renseignements sur la composition de sa population, l’utilisation de langues maternelles, les langues communément parlées et d’autres indicateurs de la diversité ethnique, ainsi que toute autre information émanant d’études socio-économiques ciblées menées à titre volontaire, dans le plein respect de la vie privée et de l’anonymat des personnes concernées, afin qu’il puisse évaluer la situation de sa population sur le plan économique, social et culturel.", "في ضوء توصيتها العامة رقم 8 (1990) المتعلقة بتفسير وتطبيق أحكام     الفقرتين 1 و4 من المادة 1 من الاتفاقية وفي ضوء الفقرات 10 إلى 12 من مبادئها التوجيهية المنقحة المتعلقة بصياغة التقارير الدورية (CERD/C/2007/1)، توصي اللجنة الدولة الطرف بتقديم معلومات عن تكوين سكانها، وعن استخدام اللغات الأم، وعن اللغات الشائعة، وعن أي مؤشر آخر يتعلق بالتنوع العرقي. وتوصي اللجنة كذلك بأن تبلَّغ بأي معلومات أخرى مستقاة من دراسات اجتماعية واقتصادية محددة الهدف تُجرى على نحو طوعي مع الاحترام الكامل لحرمة الحياة الخاصة وإغفال هويات الأشخاص المعنيين، حتى يتسنى لها تقييم وضع سكانها على الصعيد الاقتصادي والاجتماعي والثقافي.", "", "" },
                    { 482, null, "R18P5", "ت.18.ف.5", "", "Non réalisé", "", 0, 2, null, 1, null, 7, null, "Organes de traités", "fournir dans le prochain rapport des données complètes sur les plaintes déposées, les poursuites engagées, les condamnations et les peines prononcées pour des faits de discrimination raciale.", "تضمين التقرير المقبل بيانات كاملة عن الشكاوى المقدمة والملاحقات التي شُرع فيها والإدانات والعقوبات المنطوق بها في قضايا تتعلق بأفعال التمييز العنصري.", "", "" },
                    { 483, null, "R23", "ت.23", "", "Non réalisé", "", 0, 2, null, 1, null, 7, null, "Organes de traités", "Poursuivre les consultations et d’approfondir son dialogue avec les organisations de la société civile œuvrant dans le domaine de la protection des droits de l’homme, en particulier avec celles qui luttent contre la discrimination raciale, en vue de l’élaboration du prochain rapport périodique.", "مواصلة التشاور مع منظمات المجتمع المدني العاملة في مجال حماية حقوق الإنسان، ولا سيما في مكافحة التمييز العنصري، وتعميق الحوار معها عند صياغة التقرير الدوري المقبل.", "", "" },
                    { 484, null, "R28", "ت.28", "", "Non réalisé", "", 0, 2, null, 1, null, 7, null, "Organes de traités", "faire figurer dans le prochain rapport périodique des informations détaillées sur les mesures concrètes prises pour appliquer les recommandations7, 9, 10, 18, 20 et 26", "تقديم معلومات مفصلة في التقرير الدوري المقبل عن التدابير الملموسة والمناسبة المتخذة لتنفيذ التوصيات الواردة في الفقرات 7 و9 و10 و18 و20 الواردة في الفقرات 7 و9 و10 و18 و20 تنفيذاً فعالاً.", "", "" },
                    { 485, null, "R25", "ت.25", "", "Non réalisé", "", 0, 2, null, 1, null, 7, null, "Organes de traités", "mettre les rapports à la disposition du public dès leur soumission et de diffuser également ses observations finales sur ces rapports dans la langue officielle et les autres langues communément utilisées, selon le cas.", "إتاحة التقارير الدورية لعامة الجمهور حال تقديمها، ونشر الملاحظات الختامية التي تعتمدها باللغة الرسمية وباللغات الأخرى الشائع استخدامها، حسب الاقتضاء، عند الفراغ من النظر في تلك التقارير.", "", "" },
                    { 486, null, "R26", "ت.26", "", "Non réalisé", "", 0, 2, null, 1, null, 7, null, "Organes de traités", "Présenter une version mise à jour  du document de base en 2002 document de base présenté en 2002, qui devrait comporter de 60 à 80 pages, conformément aux directives harmonisées concernant l’établissement des rapports établis au titre des instruments internationaux relatifs aux droits de l’homme, à savoir celles qui se rapportent au document de base commun, telles qu’adoptées par la cinquième réunion inter comités des organes crées en vertu des traités relatifs aux droits de l’homme tenue en juin 2006 (HRI/GEN/2/Rev.4).", "تقديم نسخة محيَّنة للوثيقة الأساسية التي سبق ت إحالتها في عام 2002، من 60 إلى 80 صفحة، وفقاً للمبادئ التوجيهية المنسقة لتقديم التقارير بموجب المعاهدات الدولية لحقوق الإنسان، ولا سيما ما يتصل منها بالوثيقة الأساسية المشتركة، بالصيغة المعتمدة في الاجتماع الخامس المشترك بين لجان هيئات معاهدات حقوق الإنسان المعقود في حزيران/يونيه 2006 (HRI/GEN/2/Rev.4).", "", "" },
                    { 487, null, "R27", "ت.27", "", "Non réalisé", "", 0, 2, null, 1, null, 7, null, "Organes de traités", "Fournir, dans un délai d’un an à compter de l’adoption des présentes observations finales, des informations sur la suite qu’il aura donnée aux recommandations contenues dans les paragraphes 11,13 et 14 ci-dessus, et ce conformément au au paragraphe 1 de l’article 9 de la Convention et à l’article 65 de son règlement 26 modifié", "تقديم معلومات بشأن متابعتها للتوصيات الواردة في الفقرات 11 و13 و14 أعلاه، في غضون سنة واحدة من اعتماد هذه الاستنتاجات، عملا بأحكام الفقرة 1 من المادة 9 من الاتفاقية والمادة 65 من نظام اللجنة الداخلي المعدل", "", "" },
                    { 488, null, "R29", "ت.29", "", "Non réalisé", "", 0, 2, null, 1, null, 7, null, "Organes de traités", "soumettre le dix-neuvième, vingtième et vingt-unième rapports périodiques en un seul document, attendu le 17 janvier 2013, qui tiendra compte des directives concernant l’élaboration des documents propres au Comité pour l’élimination de la discrimination raciale, adoptées par le Comité à sa soixante et onzième session (CERD/C/2007/1) et qui ne devrait pas dépasser 40 pages et traitera tous les points soulevés dans les présentes observations finales.", "تقديم الدولة الطرف التقارير الدورية المقبلة التاسع عشر والعشرين والحادي والعشرين في وثيقة واحدة، لا تتعدى 40 صفحة، في موعد أقصاه 17 كانون الثاني/يناير 2014، مع مراعاة المبادئ التوجيهية المتعلقة بإعداد الوثائق الخاصة بلجنة القضاء على التمييز العنصري، التي اعتمدتها اللجنة في دورتها الحادية والسبعين (CERD/C/2007/1)، على أن يتم تناول جميع النقاط المثارة في هذه الملاحظات الختامية في تلك الوثيقة.", "", "" },
                    { 517, null, "R33", "ت.33", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "fournir, avant le 25 novembre 2012, des renseignements sur la suite qui aura été donnée aux recommandations formulées visant à: 1) assurer ou renforcer les garanties juridiques des personnes détenues; 2) mener des enquêtes promptes, impartiales et effectives; 3) poursuivre les suspects et sanctionner les auteurs, de torture ou de mauvais traitements; et 4) octroyer les réparations visées aux paragraphes 7, 11, 15 et 28 du présent document. Informer le comité de la suite qui aura été donnée aux recommandations qu’il lui a adressées sur la loi contre le terrorisme au paragraphe 8 du présent document", "تقديم معلومات إلى اللجنة، قبل 25 نونبر 2012، عن متابعة التوصيات المقدمة والتي تهدف إلى:حماية وتعزيز الضمانات القانونية للأشخاص المعتقلين؛إجراء تحقيقات فورية ونزيهة وفعالة؛ ملاحقة المتهمين ومعاقبة ممارسي التعذيب وسوء المعاملة؛منح التعويضات المشار إليها في الفقرات 7 و11 و15 و28 من هذه الوثيقة. وعلاوة على ذلك، تطلب اللجنة من الدولة الطرف معلومات ذات صلة عن تنفيذ التوصيات التي قدمتها إليها بشأن قانون مكافحة الإرهاب المذكور في الفقرة 8 من هذه الوثيقة", "", "" },
                    { 518, null, "R34", "ت.34", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "-            Mettre à jour, si nécessaire, le document de base en date du 15 avril 2002 (HRI/CORE/1/Add.23/Rev.1 et Corr.1), conformément aux instructions relatives au document de base commun qui figurent dans les Directives harmonisées concernant l’établissement des rapports destinés aux organes créés en vertu d’instruments internationaux relatifs aux droits de l’homme (HRI/GEN/2/Rev.6).", "تحديث الوثيقة الأساسية المؤرخة في 15 أبريل 2002 (HRI/CORE/1/Add.23/Rev.1 وCorr.1)، وفق التعليمات المتعلقة بالوثيقة الأساسية الموحدة والواردة في المبادئ التوجيهية المنسقة المتعلقة بإعداد التقارير المقدمة بموجب الصكوك الدولية لحقوق الإنسان (HRI/GEN/2/Rev.6).", "", "" },
                    { 519, null, "R23P5", "ت.23.ف.5", "", "Non réalisé", "", 0, 2, null, 2, null, 7, null, "Organes de traités", "Présenter dans le prochain rapport au Comité des informations sur les lois et les politiques en vigueur pour lutter contre les violences envers les femmes et rendre compte des effets des mesures prises.", "تقديم، معلومات عن القوانين والسياسات السارية لمكافحة أعمال العنف المرتكبة في حق المرأة في التقرير المقبل إلى اللجنة، وتقديم معلومات عن آثار التدابير المتخذة.", "", "" },
                    { 242, null, "R73P8-2", "null", "", "Non réalisé", "", 0, 2, null, null, null, 7, 9, "Procédure spéciale", "L’Experte indépendante encourage le Gouvernement à redoubler d’efforts en vue de soumettre ses rapports en temps voulu aux organes conventionnels des droits de l’homme pertinents", "null", "", "" },
                    { 542, null, "R18P4", "ت.18.ف.4", "", "Non réalisé", "", 0, 3, null, 2, null, 10, null, "Organes de traités", "-            Modifier la 9 afin d’octroyer également aux organisations non gouvernementales la possibilité d’effectuer des visites régulières, indépendantes, inopinées et illimitées dans les lieux de détention.", "تعديل التشريعات لتتيح أيضاً للمنظمات غير الحكومية إمكانية إجراء زيارات منتظمة ومستقلة ومفاجئة وغير محدودة لأماكن الاحتجاز.", "", "" },
                    { 664, null, "R26", "ت.26", "", "Non réalisé", "", 0, 3, null, 5, null, 9, null, "Organes de traités", "Compte tenu de son observation générale no 2 (2013) sur les droits des travailleurs migrants en situation irrégulière et des membres de leur famille, le Comité considère que l’entrée ou la sortie d’un travailleur migrant de l’État partie, sans la documentation requise, ainsi que le séjour au-delà de la durée de validité d’un permis de séjour ne peuvent être considérés comme des infractions pénales. Par conséquent, le Comité recommande à l’État partie de dépénaliser la migration irrégulière et de prévoir des sanctions administratives adéquates.", "إلغاء تجريم الهجرة غير الشرعية وإقرار عقوبات إدارية مناسبة  اعتبارا للتعليق العام للجنة رقم 2(2013) بشأن حقوق العمال المهاجرين الذين هم في وضع غير نظامي وأفراد أسرهم ولكونها  ترى ان دخول عامل مهاجر الدولة الطرف أو خروجه منها دون حمل الوثائق المطلوبة، وإقامته بها لفترة تتجاوز تاريخ صلاحية تصريح إقامته أمور لا يمكن أن تعتبر جرائم.", "", "" },
                    { 544, null, "R29P3", "ت.29.ف.3", "", "Non réalisé", "", 0, 3, null, 2, null, 10, null, "Organes de traités", "Inclure dans la 9 des dispositions sur le droit des personnes victimes de torture d’être indemnisées de manière équitable et adéquate du préjudice ainsi subi.", "إدراج أحكاماً بشأن حق ضحايا التعذيب في الحصول على تعويض منصف ومناسب عن الضرر الذي لحق بهم في التشريعات الوطنية.", "", "" },
                    { 244, null, "R73P2", "null", "", "Non réalisé", "", 0, 4, null, null, null, 16, 9, "Procédure spéciale", "Élaborer une politique générale nationale sur le développement humain qui tienne compte des droits de l’homme et se fonde sur les normes internationales en la matière, notamment l’égalité et la non-discrimination. - Intégrer dans tous les programmes et politiques de développement de tous les secteurs une démarche tenant compte de la problématique hommes-femmes.- Dans le cadre d’une approche du développement fondée sur les droits de l’homme, la planification et la mise en œuvre de mesures de développement doivent être mûrement réfléchies, ciblées et progressives afin d’instaurer des conditions favorables à l’exercice et à la réalisation des droits de l’homme", "null", "", "" },
                    { 353, null, "R144.82", "82.144", "", "Non réalisé", "", 0, 4, 1, null, 5, 16, null, "Examen périodique universal", "Continuer à élaborer et à mettre en œuvre des programmes de développement et à améliorer les capacités économiques dans l’ensemble du pays, y compris dans les provinces du sud du Maroc", "مواصلة وضع وتنفيذ برامج إنمائية، وتحسين القدرات الاقتصادية للبلد ككل بما فيه الأقاليم الجنوبية للمغرب", "", "" },
                    { 354, null, "R 144.153", "153.144", "", "Non réalisé", "", 0, 4, 1, null, 19, 16, null, "Examen périodique universal", "Continuer à promouvoir le développement économique et social afin de relever le niveau de vie de la population régulièrement, dans le but de fournir une base solide à la jouissance de tous les droits de l’homme", "مواصلة تشجيع التنمية الاقتصادية والاجتماعية من أجل الرفع المطّرد من مستويات معيشة السكان وذلك لتزويدهم بأساس متين للتمتع بجميع حقوق الإنسان", "", "" },
                    { 355, null, "R144.81", "81.144", "", "Non réalisé", "", 0, 4, 1, null, 66, 16, null, "Examen périodique universal", "Poursuivre les efforts visant à réaliser les objectifs stratégiques nationaux pour le développement durable (2015-2020)", "مواصلة الجهود من أجل تحقيق الأهداف الوطنية الاستراتيجية للتنمية المستدامة (2015‑2020)", "", "" },
                    { 356, null, "R144.83", "83.144", "", "Non réalisé", "", 0, 4, 1, null, 25, 16, null, "Examen périodique universal", "Accélérer la mise en œuvre de la politique nationale sur les changements climatiques", "تسريع تنفيذ السياسة الوطنية المتعلقة بتغير المناخ", "", "" },
                    { 357, null, "R144.84", "84.144", "", "Non réalisé", "", 0, 4, 1, null, 46, 16, null, "Examen périodique universal", "Renforcer l’intégration des droits environnementaux dans l’élaboration et la mise en œuvre des stratégies de développement", "زيادة تعميم مراعاة الحقوق البيئية في وضع الاستراتيجيات الإنمائية وتنفيذها", "", "" },
                    { 358, null, "R144.157", "157.144", "", "Non réalisé", "", 0, 4, 1, null, 29, 16, null, "Examen périodique universal", "Continuer de renforcer la promotion des droits environnementaux par leur incorporation dans les plans de développement social et économique pour l’ensemble du Royaume", "الاستمرار في تعزيز الحقوق البيئية وذلك بإدراجها في خطط التنمية الاجتماعية والاقتصادية في جميع أنحاء المملكة", "", "" },
                    { 502, null, "R11P6", "·          ت.11.ف.6", "", "Non réalisé", "", 0, 4, null, 1, null, 16, null, "Organes de traités", "Mettre un accent particulier sur le développement des régions habitées par les amazighs, et ce dans le cadre de la Commission consultative de Régionalisation", "تنمية المناطق التي يسكنها الأمازيغ وذلك في إطار اللجنة الاستشارية للهيكلة الإقليمية.", "", "" },
                    { 833, null, "R53P2", "ت.53.ف.2", "", "Non réalisé", "", 0, 4, null, 8, null, 16, null, "Organes de traités", "b) Tenir compte des liens entre l’article 28 de la Convention et la cible 10.2 des objectifs de développement durable afin d’autonomiser toutes les personnes et de favoriser leur intégration économique, indépendamment du handicap.", "-       (ب) إيلاء الاهتمام للصلات القائمة بين المادة 28 من الاتفاقية والغاية 10-2 من أهداف التنمية المستدامة، بهدف تمكين وتعزيز الإدماج الاجتماعي والاقتصادي والسياسي للجميع، بغض النظر عن الإعاقة.", "", "" },
                    { 708, null, "R29P4", "ت.29.ف.4", "", "Non réalisé", "", 0, 3, null, 6, null, 17, null, "Organes de traités", "Promulguer rapidement la législation voulue pour réglementer l’emploi des travailleuses domestiques", "سن تشريعات مناسبة لتنظيم عمل النساء العاملات بالخدمة المنزلية", "", "" },
                    { 52, null, "R79P5", "null", "", "Non réalisé", "", 0, 4, null, null, null, 18, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne les droits fonciers", "null", "", "" },
                    { 643, null, "R44", "ت.44", "", "Non réalisé", "", 0, 4, null, null, null, 18, null, "Organes de traités", @"a) prendre des mesures concrètes pour veiller à ce que les ressources allouées aux programmes de logement soient uniformément et équitablement réparties entre les différentes régions et entre les zones rurales urbaines ;
                - b) renforcer les activités d’amélioration des conditions de vie pour offrir un logement abordable à la population, notamment à ceux qui vivent dans les zones rurales ainsi que dans les bidonvilles urbains et ruraux. Veiller également à ce que les projets de relogement comportent également un volet d’appui aux personnes les plus démunies ;
                - c) résoudre la question des sans-abri en leur offrant un logement et de s’assurer que les victimes d’expulsions forcées bénéficient d’un relogement ou d’une indemnisation adéquate.", @"(أ) اتخاذ تدابير ملموسة لضمان توزيع الموارد المخصصة لبرامج الإسكان توزيعاً متساوياً وعادلاً بين مختلف المناطق وبين المناطق الحضرية والمناطق الريفية؛
                - (ب) تعزيز الأنشطة الرامية إلى تحسين الظروف المعيشية من أجل توفير مساكن ميسورة التكلفة للسكان، ولا سيما لسكان المناطق الريفية وسكان أحياء الصفيح في المدن والأرياف. وتوصيها كذلك بالحرص على إدراج شق يتعلق بتقديم الدعم للسكان الأشد عوزاً في مشاريع إعادة الإسكان؛
                - (ج) إيجاد حل لمشكلة المشردين بتوفير السكن لهم وضمان إعادة إسكان ضحايا الإخلاء القسري أو تقديم تعويضات كافية لهم.
                في هذا الصدد، تحيل اللجنة الدولة الطرف إلى تعليقها العام رقم 7(1997) بشأن الحق في السكن الملائم: حالات إخلاء المساكن بالإكراه، وتعليقها العام رقم 4(1991) بشأن الحق في السكن الملائم.", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 19, null, "R73", "null", "", "Non réalisé", "", 0, 4, null, null, null, 19, 1, "Procédure spéciale", "-   Créer des conditions permettant aux agriculteurs d’adopter des pratiques agro écologiques et dispenser une formation sur les différentes méthodes de lutte contre les organismes nuisibles afin d’éviter l’utilisation excessive des pesticides synthétiques.", "null", "", "" },
                    { 20, null, "R76", "null", "", "Non réalisé", "", 0, 4, null, null, null, 19, 1, "Procédure spéciale", "-   Promouvoir le maintien et la gestion de la biodiversité agricole afin de garantir une diversité génétique permettant de préserver les ressources naturelles nécessaires à la résilience des agriculteurs, à l’innovation agricole et à l’adaptation de l’agriculture aux changements climatiques.", "null", "", "" },
                    { 21, null, "R77", "null", "", "Non réalisé", "", 0, 4, null, null, null, 19, 1, "Procédure spéciale", "-   Mieux appliquer les lois environnementales afin de protéger les bassins versants, les forêts et les rivières, qui sont les premières sources de nourriture. Mettre en place des mécanismes permettant de prévenir l’érosion des sols et les inondations et de renforcer la biodiversité.", "null", "", "" },
                    { 709, null, "R35", "ت.35", "", "Non réalisé", "", 0, 3, null, 6, null, 19, null, "Organes de traités", "Veiller à la stricte application de l’âge minimum fixé dans le Code de la famille et modifier le Code afin que le mariage d’enfants ne puisse être autorisé que dans des conditions juridiques contraignantes, strictes et exceptionnelles.", "كفالة التنفيذ الدقيق للأحكام المتعلقة بالحد الأدنى لسن الزواج الواردة في مدونة الأسرة وتعديل مدونــة الأســرة لعدم التصــريح بزواج الأطفال إلا بشــروط قانونية إلزامية دقيقة استثنائيــة.", "", "" },
                    { 53, null, "R75", "null", "", "Non réalisé", "", 0, 5, null, null, null, 20, 2, "Procédure spéciale", "-       Prendre des mesures concrètes pour renforcer le principe de responsabilité pour tous les actes de discrimination raciale et de xénophobie, en veillant à ce que les allégations de tels actes fassent l’objet d’enquêtes approfondies et, s’il y a lieu, de poursuites et de sanctions, même dans les cas où les violations des droits ne résultent pas directement d’une politique ou de mesures délibérées du Gouvernement.", "null", "", "" },
                    { 95, null, "R88P6", "ت.88.ف.6", "", "Non réalisé", "", 0, 5, null, null, null, 20, 3, "Procédure spéciale", "-    diligenter des enquêtes impartiales et approfondies sur toutes les allégations de torture et de traitements cruels, inhumains ou dégradants, sans qu’il soit nécessaire qu’une plainte soit déposée par écrit, conformément à l’article 13 de la Convention contre la torture; de mettre en place des procédures pour enquêter d’office sur tout cas de torture et de mauvais traitements quelle que soit la manière dont il est invoqué, même lorsque les victimes n’utilisent pas les procédures prescrites par la loi pour soumettre leur plainte", "-          (و) التعجيل بإجراء تحقيقات فورية ونزيهة وشاملة في جميع ادعاءات التعذيب وغيره من أشكال المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة، دون الحاجة إلى شكوى خطية، عملاً بالمادة 13 من اتفاقية مناهضة التعذيب؛ ووضع إجراءات للتحقيق، بحكم الوظيفة، في أي قضية تعذيب أو سوء معاملة تثار بأي وسيلة من الوسائل، حتى عندما لا يقدم الضحايا شكاوى بالطرق القانونية؛", "", "" },
                    { 96, null, "R88P10", "ت.88.ف.10", "", "Non réalisé", "", 0, 5, null, null, null, 20, 3, "Procédure spéciale", "Engager des procédures judiciaires au sujet de tous les cas de violations commises par le passé pendant les «années de plomb» (1956-1999) révélées par l’Instance équité et réconciliation", "-          (ي) رفع دعاوى قضائية بشأن جميع الحالات التي كشفت عنها هيئة الإنصاف والمصالحة والمتعلقة بانتهاكات سنوات الرّصاص (1956-1999)؛", "", "" },
                    { 97, null, "R89", "ت.89", "", "Non réalisé", "", 0, 5, null, null, null, 20, 3, "Procédure spéciale", "En ce qui concerne les manifestations, le Rapporteur spécial recommande au Gouvernement de se conformer aux normes internationales, telles que les «Principes de base relatifs au recours à la force et l’utilisation des armes à feu par les responsables de l’application des lois», qui, s’agissant du respect de la vie et de l’intégrité physique, sont fondées sur les principes de nécessité et de proportionnalité; et de promouvoir encore plus la prévention des actes de torture ou des mauvais traitements dont sont victimes les manifestants, les enquêtes sur ces actes et les poursuites engagées contre leurs auteurs.", "-          يوصي المقرر الخاص الحكومة بأن تتصرف وفق المعايير الدولية، مثل 'المبادئ الأساسية بشأن استخدام القوة والأسلحة النارية من جانب الموظفين المكلفين بإنفاذ القوانين‏'، التي تقوم على مبدأي الضرورة والتناسب المتعلقين بالحق في الحياة والسلامة الجسدية، إضافة إلى منع تعذيب المحتجين أو إساءة معاملتهم، والتحقيق في هاتين الممارستين.", "", "" },
                    { 98, null, "R96", "ت.96", "", "Non réalisé", "", 0, 5, null, null, null, 20, 3, "Procédure spéciale", "-    Agir pour prévenir les représailles, y compris sous la forme d’actes d’intimidation, de mesures disciplinaires et de mauvais traitements, à l’encontre de détenus, de victimes de la torture et de membres de leur famille, d’activistes et d’autres personnes qui se sont entretenus avec le Rapporteur spécial pendant sa visite, et d’enquêter rapidement sur les actes de représailles et de punir leurs auteurs.", "-          يحث المقرر الخاص الحكومة على أن تمنع بالفعل الأعمال الانتقامية، مثل التخويف، والتدابير التأديبية، وسوء المعاملة، في حق السجناء، وضحايا التعذيب وأفراد أسرهم، والمناضلين وغيرهم ممن تحدثوا إلى المقرر الخاص أثناء زيارته، والتعجيل بالتحقيق في تلك الأعمال ومعاقبة مقترفيها.", "", "" },
                    { 99, null, "R97P1", "ت.97.ف.1", "", "Non réalisé", "", 0, 5, null, null, null, 20, 3, "Procédure spéciale", "En ce qui concerne les provinces marocaines du Sud - Enquêter rapidement sur toutes les allégations faisant état d’actes de torture et de mauvais traitements pendant et après les manifestations et à la prison de Laâyoune; - Tenir les auteurs responsables de ces actes et d’accorder une indemnisation aux victimes ;", "فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي:- (أ) التحقيق بسرعة في جميع ادعاءات التعذيب وسوء المعاملة أثناء المظاهرات وبعدها وفي سجن العيون؛  مساءلة الجناة؛ وتعويض الضحايا؛", "", "" },
                    { 199, null, "R83P5", "null", "", "Non réalisé", "", 0, 5, null, null, null, 20, 7, "Procédure spéciale", "-       Prendre toutes les mesures nécessaires pour s’assurer que les condamnations pénales sont fondées sur des preuves autres que les aveux des accusés, en particulier lorsque ces personnes se rétractent lors du procès, et s’assurer que, sauf dans les cas impliquant des accusations de torture, les déclarations faites sous la torture ne sont pas invoquées comme preuve dans une procédure, conformément à l’article 15 de la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "null", "", "" },
                    { 200, null, "R83P6", "null", "", "Non réalisé", "", 0, 5, null, null, null, 20, 7, "Procédure spéciale", "-       S’assurer que les rapports établis par la police judiciaire au cours de l’enquête restent inadmissibles au cours du procès jusqu’à ce que les preuves de leur véracité et de leur validité juridique soient confirmées conformément au Code de procédure pénale", "null", "", "" },
                    { 201, null, "R83P7", "null", "", "Non réalisé", "", 0, 5, null, null, null, 20, 7, "Procédure spéciale", "-       Réviser les condamnations pénales fondées uniquement sur des aveux afin d’identifier les cas où la condamnation est fondée sur des aveux obtenus par la torture ou des mauvais traitements et prendre les mesures correctives appropriées", "null", "", "" },
                    { 202, null, "R83P8", "null", "", "Non réalisé", "", 0, 5, null, null, null, 20, 7, "Procédure spéciale", "-       Veiller strictement à l’enregistrement dès l’arrestation, en particulier dans les affaires concernant la sécurité nationale et le terrorisme, et faire en sorte que les chefs de poste de police, les agents de la police judiciaire et les fonctionnaires de police, y compris les membres de la DST, soient tenus pénalement responsables de toute détention non reconnue", "null", "", "" },
                    { 203, null, "R83P10", "null", "", "Non réalisé", "", 0, 5, null, null, null, 20, 7, "Procédure spéciale", "-       Mener des enquêtes efficaces et impartiales sur tous les cas de «transfèrements secrets» dans lesquels l’État pourrait avoir joué un rôle : mettre en lumière les faits entourant ces cas, poursuivre et punir les responsables de ces transfèrements", "null", "", "" },
                    { 168, null, "R93P3", "null", "", "Non réalisé", "", 0, 4, null, null, null, 16, 6, "Procédure spéciale", "Revoir l’Initiative nationale pour le développement humain afin de faire en sorte qu’elle tienne compte des questions de parité entre les sexes et mette à profit le rôle plus actif des femmes à tous les niveaux (national, régional et local) et à toutes les étapes (conception, exécution et évaluation)", "null", "", "" },
                    { 832, null, "R51", "ت.51", "", "Non réalisé", "", 0, 4, null, 8, null, 15, null, "Organes de traités", @"a) Adopter un plan à long terme pour garantir l’accès des personnes handicapées au marché du travail général et de définir des objectifs et des mesures spécifiques concernant l’accès à l’emploi des femmes et des jeunes handicapés. Dans le cadre de ces mesures, l’État partie devrait notamment prévoir la mise en place de partenariats public-privé avec les coopératives et le secteur privé afin d’accroître l’employabilité des personnes handicapées ; 
                b) Instaurer l’obligation juridique, pour les employeurs dans tous les secteurs de l’économie, de procéder à des aménagements raisonnables sur le lieu de travail des personnes handicapées ; 
                c) Ne plus utiliser des listes de postes réservés aux personnes handicapées et de veiller à ce que ces dernières bénéficient d’une formation et aient accès à tous les types d’emploi sur un pied d’égalité avec les autres ; 
                d) Tenir compte des liens entre l’article 27 de la Convention et la cible 8.5 des objectifs de développement durable afin de garantir l’avènement d’un plein emploi productif et de conditions de travail décentes pour tous, y compris les personnes handicapées.", @"(أ) اعتماد خطة طويلة الأجل لضمان وصول الأشخاص ذوي الإعاقة إلى سوق العمل المفتوحة، ووضع أهداف وتدابير محددة بشأن حصول النساء والشباب ذوي الإعاقة على فرص عمل. وينبغي للدولة الطرف أن تُضمِّن تلك التدابير إقامة شراكات بين القطاعين العام والخاص والتعاونيات والقطاع الخاص من أجل زيادة إمكانية تشغيل الأشخاص ذوي الإعاقة؛ 
                -  (ب) إرساء التزام قانوني بأن يوفر أرباب العمل في جميع قطاعات الاقتصاد الترتيبات التيسيرية المعقولة للأشخاص ذوي الإعاقة في مكان العمل؛ 
                -  (ج) وقف استخدام قوائم الوظائف المخصصة للأشخاص ذوي الإعاقة فقط، وضمان تدريب وتمكين الأشخاص ذوي الإعاقة ليزاولوا جميع أنواع العمل على قدم المساواة مع الآخرين؛ 
                -  (د) إيلاء الاهتمام للصلات القائمة بين المادة 27 من الاتفاقية والغاية 8-5 من أهداف التنمية المستدامة، وذلك بغرض تحقيق العمالة الكاملة والمنتجة وتوفير العمل اللائق للجميع، بمن في ذلك الأشخاص ذوو الإعاقة. ‬‬‬‬", "", "" },
                    { 722, null, "R27P4", "ت.27.ف.4", "", "Non réalisé", "", 0, 4, null, 6, null, 15, null, "Organes de traités", "-       Accorder une attention particulière aux jeunes filles employées de maison, afin de s’assurer qu’il ne s’agit pas de mineures de moins de 15 ans et qu’elles ont pu poursuivre leur scolarité au moins jusqu’à cet âge", "-إيلاء عناية خاصة إلى الفتيات اللاتي يعملن بالخدمة في المنازل لكفالة منع من كن دون سن الخامسة عشرة من العمل للسماح لهن بمواصلة الدراسة حتى هذه السن على الأقل.", "", "" },
                    { 721, null, "R21P6", "ت.21.ف.6", "", "Non réalisé", "", 0, 4, null, 6, null, 15, null, "Organes de traités", "-       adopter des mesures de protection des employées de maison", "- توفير الحماية للمشتغلات بالخدمة في المنازل", "", "" },
                    { 500, null, "R11P1P5", "·          ت.11.ف.1.ف.5", "", "Non réalisé", "", 0, 4, null, 1, null, 14, null, "Organes de traités", "Intensifier ses efforts en vue de promouvoir la langue et la culture amazighes, notamment par leur enseignement et à assurer également l'alphabétisationdes amazighs dans cette langue", "·          -بذل المزيد من الجهود بغية تعزيز اللغة والثقافة الأمازيغيتين، لا سيما عن طريق تعليمهما", "", "" },
                    { 638, null, "R48", "ت.48", "", "Non réalisé", "", 0, 4, null, null, null, 14, null, "Organes de traités", @"Redoubler les efforts pour offrir l’enseignement primaire, secondaire et universitaire en amazigh, augmenter la présence de cette langue dans la télévision et régler définitivement la question des prénoms amazighs.
                - Prendre des mesures pour garantir aux Amazighs et aux Sahraouis la jouissance pleine et sans restriction de leur droit de participer à la vie culturelle.
                - Prendre des mesures additionnelles pour protéger la diversité culturelle et permettre aux Amazighs et aux Sahraouis de préserver, de promouvoir, d’exprimer et de diffuser leur identité, leur histoire, leur culture, leur langue, leurs traditions et leurs coutumes.
                - Continuer à faciliter l’accès à la culture et à la science pour tous, y compris l’accès à Internet, en particulier pour les personnes handicapées et les personnes les plus démunies de sa population.", "-          اتخاذ تدابير عاجلة لمعالجة المشاكل المتعلقة بنوعية التعليم العام والتسرب والرسوب المدرسيين.", "", "" },
                    { 669, null, "R40", "ت.40", "", "Non réalisé", "", 0, 4, null, 5, null, 14, null, "Organes de traités", "-  Prendre toutes les mesures nécessaires pour s’assurer que les enfants des travailleurs migrants, y compris ceux en situation irrégulière, aient accès à l’éducation sur la base de l’égalité de traitement.", "اتخاذ جميع التدابير اللازمة لضمان حصول أبناء العمال المهاجرين، بمن فيهم الموجودون في وضع غير قانوني، على التعليم على أساس المساواة في المعاملة.", "", "" },
                    { 670, null, "R40", "ت.40", "", "Non réalisé", "", 0, 4, null, 5, null, 14, null, "Organes de traités", "-  Mettre en place des programmes, politiques et des mécanismes pour prévenir la discrimination dans le système scolaire.", "وضع برامج وسياسات وآليات لمنع التمييز في النظام المدرسي. وتدعو اللجنة الدولة الطرف إلى اتخاذ جميع التدابير اللازمة لتضمين تقريرها الدوري المقبل بيانات مُصنَّفة بحسب الجنس والسن والجنسية فيما يتعلق بعدد أطفال العمال المهاجرين في مؤسسات التعليم الابتدائي والثانوي، بما يشمل الحالات التي يكون فيها الأطفال أو آباؤهم في وضع غير قانوني.", "", "" },
                    { 707, null, "R21P1P2", "ت.21.ف1.ف.2", "", "Non réalisé", "", 0, 3, null, 6, null, 14, null, "Organes de traités", @"Promulguer au plus vite, conformément à la recommandation générale no 19, une législation visant la violence à l’égard des femmes et des filles, notamment la violence dans la famille, pour ériger en infraction pénale toutes les formes de violence à l’égard des femmes et veiller à ce que les femmes et les filles victimes de violence aient immédiatement accès à des moyens de protection, y compris à des foyers d’accueil, et puissent obtenir réparation et à ce que les auteurs soient poursuivis et punis comme il convient.
                    
                -Modifier le Code pénal pour criminaliser le viol conjugal et s’assurer que les auteurs de viols n’échappent pas aux poursuites pénales quand ils épousent leur victime", @"إصدار تشريع بشأن العنف ضد النساء والفتيات، بما في ذلك العنف الأسري، بحيث يكفل هذا التشريع تجريم جميع أشكال العنف ضد المرأة، وحصول النساء والفتيات من ضحايا العنف على سبل الحماية الفورية، بما فيها الملاجئ ووسائل الانتصاف، ومحاكمة مرتكبي هذه الجرائم وإنزال العقوبة المناسبة بهم. 
                -إدخال تعديل على قانون العقوبات لضمان تجريم الاغتصاب الزوجي وعدم إيقاف الإجراءات الجنائية ضد الجناة حين يتزوجون ضحاياهم.", "", "" },
                    { 718, null, "R27P1P2P3", "ت.27.ف.1.ف.2.ف.3", "", "Non réalisé", "", 0, 4, null, 6, null, 14, null, "Organes de traités", @"Prendre des mesures pour garantir l’accès des femmes et des filles à tous les niveaux d’éducation. Ces mesures pourront porter sur les cantines, l’internat, les installations sanitaires, l’eau et l’électricité, qui ont un impact direct sur l’accès à l’éducation, notamment en milieu rural. 
                - Adopter des mesures temporaires spéciales, conformément au paragraphe 1 de l’article 4 de la Convention et à la recommandation générale 25 du Comité,  afin d’assurer la scolarisation régulière et continue des filles. 
                - Poursuivre les efforts visant à améliorer le niveau d’alphabétisation des femmes et des filles grâce à l’adoption de programmes complets d’enseignement scolaire et extrascolaire, d’éducation des adultes et de formation et à mettre l’accent sur le recrutement et la formation d’enseignants supplémentaires, l’élaboration de matériel pédagogique intégrant la problématique hommes-femmes et le suivi et l’évaluation des progrès réalisés par rapport à des objectifs assortis de délais", @"إتاحة فرصة الالتحاق بالتعليم بكافة مراحله للفتيات والنساء. وقد تشمل هذه التدابير توفير المقاصف، ومرافق السكن الدراسي، ومرافق الصرف الصحي الملائمة، وتوافر المياه والكهرباء، وهي أمور لها أثرها المباشر على إعمال حق المرأة في الحصول على التعليم وخاصة في المناطق الريفية. 
                -اعتماد تدابير استثنائية مؤقتة لكفالة إبقاء الفتيات في المدارس وفقا لما جاء في الفقرة 1 من المادة 4 من الاتفاقية وفي التوصية العامة رقم 25 للجنة،
                -مواصلة تعزيز الجهود لتحسين مستوى الإلمام بالقراءة والكتابة لدى الفتيات والنساء، وذلك عن طريق اعتماد برامج شاملة للتعليم النظامي وغير النظامي، وتعليم الكبار وتدريبهم، وزيادة التدريب وفرص العمل المتاحة للمدرسين، ووضع مواد تعليمية مراعية للمنظور الجنساني، ورصد وتقييم التقدم المحرز نحو تحقيق أهداف محددة بأطر زمنية. 
                -رفع مستوى الوعي عموما بأهمية التعليم كحق من حقوق الإنسان وكأساس لتمكين المرأة، وعلى اتخاذ خطوات للتغلب على أنماط السلوك التقليدية التي تعمل على استدامة التمييز", "", "" },
                    { 719, null, "R33P1", "ت.33.ف.1", "", "Non réalisé", "", 0, 4, null, 6, null, 14, null, "Organes de traités", "Prendre des mesures temporaires spéciales, conformément au paragraphe 1 de l’article 4 de la Convention, pour s’assurer que les femmes rurales jouissent de leurs droits politiques, sociaux, économiques et culturels sans aucune discrimination, notamment en ce qui concerne l’accès à l’éducation", "اتخاذ تدابير خاصة مؤقتة، على النحو المنصوص عليه في الفقرة 1 من المادة 4 من الاتفاقية، لكفالة تمتع المرأة الريفية بحقوقها السياسية والاجتماعية والاقتصادية والثقافية دونما تمييز، لا سيما فيما يتصل بالحق في الحصول على التعليم", "", "" },
                    { 769, null, "R53P2P4", "ت.53.ف.2.ف.4", "", "Non réalisé", "", 0, 4, null, 7, null, 14, null, "Organes de traités", @"le Comité demande instamment au Maroc d’adopter une approche du handicap fondée sur les droits de l’homme et recommande en particulier:
                b) D’adopter des mesures globales pour développer l’enseignement inclusif et faire en sorte qu’il ait la priorité sur le placement d’enfants dans des institutions et des classes spécialisées. À cette fin, le Comité demande instamment à l’État partie de retirer des centres de sauvegarde les enfants qui y ont été placés;
                d) De former le personnel et les enseignants spécialisés appelés à s’occuper de classes intégrées fournissant un soutien individualisé et toute l’attention voulue aux enfants ayant des difficultés d’apprentissage", @"تحث اللجنة المملكة المغربية، في ضوء المادة 23 من الاتفاقية وتعليقها العام     رقم 9(2006) بشأن حقوق الأطفال ذوي الإعاقة، على انتهاج نهج يقوم على حقوق الإنسان في التعاطي مع الإعاقة، وتوصيها بالآتي تحديداً: 
                -  (ب) اتخاذ تدابير جامعة لتطوير التعليم الشامل وضمان أولويته على إيداع الأطفال في مؤسسات وفصول متخصصة. ولتحقيق هذا الغرض، تحث اللجنة الدولة الطرف على أن تسارع إلى نقل الأطفال ذوي الإعاقة الذين أودعوا مراكز حماية الطفولة؛
                -  (د) تدريب وتعيين معلمين ومهنيين متخصصين في الفصول المدمجة لتقديم دعم فردي وتوجيه كل الاهتمام للأطفال الذين يعانون صعوبات في التعلّم", "", "" },
                    { 770, null, "R61", "ت.61", "", "Non réalisé", "", 0, 4, null, 7, null, 14, null, "Organes de traités", @"Le Comité recommande au Maroc:
                a) De redoubler d’efforts pour assurer la scolarisation de tous les enfants aux niveaux primaire et secondaire en prenant des mesures ciblées pour toucher les enfants privés d’enseignement;
                b) De procéder à une évaluation correcte des lacunes du programme d’urgence pour 2009-2012 et d’adopter, sur la base des enseignements tirés de cette évaluation, toutes les mesures nécessaires pour assurer une utilisation et un contrôle effectifs et efficaces des ressources financières allouées au système éducatif;
                c) D’évaluer et de mesurer les conséquences du développement rapide de l’enseignement privé dans l’État partie et d’y faire face et faire en sorte que les enseignants du secteur public contribuent à l’amélioration du système éducatif au Maroc plutôt que d’être utilisés par le secteur privé, en appliquant efficacement la circulaire ministérielle no 109 du 3 septembre 2008;
                d) De prendre les mesures nécessaires pour améliorer la qualité de l’enseignement, notamment en dispensant aux enseignants une formation de qualité, et de développer et promouvoir la qualité de la formation professionnelle pour améliorer les qualifications des enfants et des jeunes, en particulier celles de ceux qui ont abandonné l’école;
                e) D’allouer des ressources financières suffisantes au développement et à l’expansion de l’éducation à la prime enfance dans les zones rurales, selon une approche globale et intégrée du développement et de la prise en charge de la petite enfance", @"(أ) تدعيم جهودها الرامية إلى ضمان التحاق جميع الأطفال بالتعليم الابتدائي والثانوي باتخاذ تدابير محددة الغرض موجهة إلى الأطفال المحرومين من التعليم؛
                - (ب) إجراء تقييم صحيح للثغرات الموجودة في البرنامج                  الاستعجالي 2009-2012؛ وفي ضوء العبر المستخلصة، اتخاذ كل ما يلزم من تدابير تكفل استعمال الموارد المالية المخصصة لمنظومة التعليم ومراقبتها بفعالية وكفاءة؛
                - (ج) تقييم عواقب التطور السريع للتعليم الخاص في الدولة الطرف والتعامل معها، وضمان إسهام المعلمين العاملين في القطاع العام في تحسين التعليم في المغرب بدلاً من أن يستخدمهم القطاع الخاص، وذلك بإنفاذ المنشور الوزاري رقم 109  المؤرخ 3 أيلول/سبتمبر 2008 بفعالية؛
                - (د) اتخاذ التدابير اللازمة لتحسين نوعية التعليم، لا سيما بتدريب المعلمين تدريباً جيداً، وتطوير التعليم المهني الجيد وتشجيعه لتعزيز مهارات الأطفال والشباب، خاصة من تسربوا من المدرسة؛
                - (ه) رصد ما يكفي من موارد مالية لتطوير التعليم قبل المدرسة في المناطق الريفية وتوسيع نطاقه اعتماداً على سياسة شاملة وكلية بشأن الرعاية قبل المدرسة وتطويرها.", "", "" },
                    { 771, null, "R65P1", "ت.65.ف.1", "", "Non réalisé", "", 0, 4, null, 7, null, 14, null, "Organes de traités", "a) prendre immédiatement des mesures vigoureuses pour faire cesser l’emploi de filles comme domestiques dans des conditions abusives, d’assurer à ces filles une éducation, notamment une formation professionnelle et de fournir des informations détaillées dans le prochain rapport périodique sur les mesures prises et les résultats obtenus;", "-          (أ) اتخاذ تدابير فورية وحازمة لانتشال الفتيات العاملات خادمات منازل من ظروف العمل الظالمة، وتوفير التعليم لهن، بما فيه التدريب المهني، وإمداد اللجنة في تقريرها الدوري المقبل بمعلومات وافية عن تلك التدابير وما تمخضت عنه من نتائج؛", "", "" },
                    { 831, null, "R47", "ت.47", "", "Non réalisé", "", 0, 4, null, 8, null, 14, null, "Organes de traités", @"a) Adopter, de mettre en œuvre et de superviser un plan complet qui prévoit la mise en place d’un système éducatif inclusif sur l’ensemble de son territoire, en allouant les ressources nécessaires à la création d’un environnement pédagogique accessible ;
                b) Mettre en place, à l’intention des enseignants, un programme permanent de formation à l’éducation inclusive, qui comprenne, de préférence, une formation à la langue des signes et à l’élaboration d’outils méthodologiques pour l’enseignement ; 
                c) Mener régulièrement des campagnes d’information dans des formats accessibles, notamment en langue facile (Easy Read), afin de promouvoir la scolarisation de toutes les personnes handicapées, en particulier des femmes et des enfants handicapés et des personnes handicapées vivant dans des zones rurales ;
                d) Adopter une stratégie pour l’aménagement raisonnable des écoles et des autres établissements d’enseignement, en veillant à l’accessibilité et en offrant des supports pédagogiques ainsi qu’une assistance et une technologie d’appui dans la salle de classe ;
                e) Tenir compte des liens entre l’article 24 de la Convention et les cibles 4.5 et 4.a des objectifs de développement durable afin d’assurer l’égalité d’accès à tous les niveaux d’enseignement et de formation professionnelle, ainsi que de construire des établissements scolaires qui soient accessibles à tous et sûrs et de rénover les infrastructures existantes à cette même fin.", @"(أ) اعتماد وتنفيذ خطة شاملة لوضع نظام للتعليم الجامع في جميع أنحاء إقليمها والإشراف على هذه الخطة، وتخصيص الموارد لتهيئة بيئات تعليمية يسهل الانخراط فيها؛
                -  (ب) وضع برنامج دائم لتدريب المعلمين على التعليم الجامع، ويفضل أن يشمل ذلك التدريب على لغة الإشارة، واستحداث أدوات منهجية للتدريس؛ 
                -  (ج) تنفيذ حملات إعلامية دورية باستعمال أشكال يسهل الاطلاع عليها، بما في ذلك الأشكال التي تسهل قراءتها، لتشجيع التحاق جميع الأشخاص ذوي الإعاقة، ولا سيما النساء والأطفال ذوي الإعاقة والأشخاص الذين يعيشون في المناطق الريفية، بالتعليم؛
                -  (د) اعتماد استراتيجية لتوفير الترتيبات التيسيرية المعقولة في المدارس والمؤسسات التعليمية الأخرى، بما في ذلك من خلال توفير الدعم التكنولوجي والدعم في الصفوف الدراسية والمواد التعليمية وتيسير إمكانية الوصول؛
                -  (هـ) إيلاء الاهتمام للصلات القائمة بين المادة 24 من الاتفاقية والغايتيْن 4-5 و4-أ من أهداف التنمية المستدامة، من أجل ضمان تكافؤ فرص الوصول إلى جميع مستويات التعليم والتدريب المهني وبناء مرافق تعليمية آمنة وتراعي حالة الإعاقة ورفع مستوى المرافق التعليمية القائمة.‬‬‬‬‬", "", "" },
                    { 17, null, "R91", "null", "", "Non réalisé", "", 0, 4, null, null, null, 15, 1, "Procédure spéciale", "Redoubler d’efforts pour réduire sensiblement le taux de chômage en ciblant les femmes et les jeunes, - Accroître le nombre de programmes de requalification et de 41 et technique, - Adopter des mesures visant à inciter les employeurs à créer des emplois et à recruter des femmes et des jeunes selon qu’il convient.", "null", "", "" },
                    { 18, null, "R95P2P4", "null", "", "Non réalisé", "", 0, 4, null, null, null, 15, 1, "Procédure spéciale", "Pour les provinces marocaines du sud :- Etablir des mécanismes visant à réduire sensiblement le taux de chômage- Adopter des mesures qui incitent les employeurs à recruter des jeunes sans aucune discrimination.", "null", "", "" },
                    { 204, null, "R83P23", "null", "", "Non réalisé", "", 0, 5, null, null, null, 20, 7, "Procédure spéciale", "Prendre des mesures efficaces en vue de prévenir les représailles, y compris l’intimidation, les mesures disciplinaires et les mauvais traitements contre les détenus, victimes de détention arbitraire et leurs familles, et d’autres personnes qui ont parlé au Groupe de travail lors de sa visite ; - Enquêter rapidement et punir les auteurs d’actes de représailles ;", "null", "", "" },
                    { 51, null, "R79P3", "null", "", "Non réalisé", "", 0, 4, null, null, null, 15, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’accès à l’emploi", "null", "", "" },
                    { 347, null, "R144.152", "152.144", "", "Non réalisé", "", 0, 4, 1, null, 11, 15, null, "Examen périodique universal", "Poursuivre ses efforts louables pour réduire le taux de chômage élevé qui prévaut dans le pays", "مواصلة عمله الجيد على الحد من معدل البطالة المرتفع في البلد", "", "" },
                    { 348, null, "R144.154", "154.144", "", "Non réalisé", "", 0, 4, 1, null, 47, 15, null, "Examen périodique universal", "Renforcer les lois favorisant la réduction des taux de chômage et accroître les possibilités d’emploi  afin de contribuer à la réalisation d’un développement durable", "تجديد القوانين الرامية إلى الحد من معدلات البطالة وزيادة فرص العمل للمساهمة في تحقيق التنمية المستدامة", "", "" },
                    { 349, null, "R144.154", "154.144", "", "Non réalisé", "", 0, 4, 1, null, 47, 15, null, "Examen périodique universal", "Renforcer les lois favorisant la réduction des taux de chômage et accroître les possibilités d’18 afin de contribuer à la réalisation d’un développement durable", "تجديد القوانين الرامية إلى الحد من معدلات البطالة وزيادة فرص العمل للمساهمة في تحقيق التنمية المستدامة", "", "" },
                    { 350, null, "R144.155", "155.144", "", "Non réalisé", "", 0, 4, 1, null, 55, 15, null, "Examen périodique universal", "Poursuivre ses efforts pour réduire le taux de chômage chez les jeunes, notamment par le renforcement des programmes de formation professionnelle", "مواصلة الجهود لأجل الحد من معدلات البطالة في صفوف الشباب بوسائل منها تقوية برامج التدريب المهني", "", "" },
                    { 351, null, "R144.156", "156.144", "", "Non réalisé", "", 0, 4, 1, null, 69, 15, null, "Examen périodique universal", "Établir des dialogues visant à engager une coopération qui permettra l’application de pratiques optimales et de plans visant à réduire le chômage, le sous-emploi et le travail informel, et renforcer les politiques de création d’emplois et d’emploi  des jeunes", "إقامة حوارات للانخراط في التعاون الذي سيتيح تطبيق الممارسات والخطط الفضلى للحد من البطالة وقلة فرص العمل والعمل في القطاع غير النظامي، وتقوية السياسات الرامية إلى إنشاء فرص العمل وإلى عمالة الشباب", "", "" },
                    { 352, null, "R144.158", "158.144", "", "Non réalisé", "", 0, 4, 1, null, 85, 15, null, "Examen périodique universal", "Continuer à mettre en œuvre des politiques et à développer des infrastructures permettant d’accroître l’accès à l’emploi , en particulier pour les jeunes", "مواصلة تنفيذ السياسات وتطوير الهياكل الأساسية التي تزيد من الفرص في الحصول على العمل خاصةً في صفوف الشباب", "", "" },
                    { 501, null, "R11P2", "·          ت.11.ف.2", "", "Non réalisé", "", 0, 4, null, 1, null, 15, null, "Organes de traités", "Prendre les mesures nécessaires pour s’assurer que des amazighs ne soient victimes d’aucune forme de discrimination raciale, notamment dans l’accès à l’emploi", "اتخاذ التدابير اللازمة لضمان عدم تعرض الأمازيغ لأي شكل من أشكال التمييز العنصري، لا سيما في التوظيف", "", "" },
                    { 639, null, "R18P3", "ت.18.ف.3", "", "Non réalisé", "", 0, 4, null, null, null, 15, null, "Organes de traités", @"Tenant compte de son observation générale no 16 (2005) sur le droit égal de l’homme et de la femme au bénéfice de tous les droits économiques, sociaux et culturels, le Comité recommande de :

                - c) - Identifier les obstacles rencontrés par les femmes dans l’emploi et la vie professionnelle et prendre des mesures appropriées, y compris des mesures ciblées, pour la conciliation de la vie familiale avec le monde du travail, qui permettent d’augmenter le taux de participation des femmes. 
                Continuer à œuvrer pour atteindre un pourcentage acceptable de postes bien rémunérés et à responsabilités occupés par les femmes en adoptant des mesures temporaires spéciales le cas échéant.", "في ضوء تعليقها العام رقم 16(2005) بشأن المساواة بين الرجل والمرأة في حق التمتع بجميع الحقوق الاقتصادية والاجتماعية والثقافية، توصي اللجنة بما يلي:", "", "" },
                    { 640, null, "R20", "ت.20", "", "Non réalisé", "", 0, 4, null, null, null, 15, null, "Organes de traités", @"Prendre les mesures nécessaires pour garantir, en droit comme en pratique, des recours efficaces et accessibles pour la protection du droit du travail. 
                - créer des tribunaux spécialisés en matière de contentieux du travail", @"اتخاذ التدابير اللازمة لكي تضمن، في القانون وفي الممارسة العملية،
                - توفر س��ل انتصاف فعالة وميسرة من أجل حماية قانون العمل. وتشجعها على إنشاء محاكم متخصصة في منازعات العمل.", "", "" },
                    { 641, null, "R22", "ت.22", "", "Non réalisé", "", 0, 4, null, null, null, 15, null, "Organes de traités", "-            Redoubler d’efforts pour réduire sensiblement le taux de chômage en ciblant les femmes et les jeunes, y compris par des programmes de requalification et de formation professionnelle et technique, en plus des mesures incitatives pour les employeurs.", "-          مضاعفة جهودها من أجل خفض معدل البطالة بنسبة كبيرة من خلال استهداف النساء والشباب، بوسائل منها وضع برامج لإعادة التأهيل والتدريب المهني والتقني بالإضافة إلى وضع تدابير تحفيزية لأرباب العمل. وفي هذا الصدد، تدعو اللجنة الدولة الطرف إلى الرجوع إلى تعليقها العام رقم 18(2005) بشأن الحق في العمل.", "", "" },
                    { 642, null, "R28", "ت.28", "", "Non réalisé", "", 0, 4, null, null, null, 15, null, "Organes de traités", @"Renforcer les efforts pour réguler l’économie informelle et le travail indépendant, notamment en intégrant ces travailleurs dans les régimes de sécurité sociale et en améliorant progressivement leurs conditions de travail.
                -  Etendre de façon systématique les services de l’inspection du travail au secteur informel et aux zones rurales, et s’attaquer plus fermement aux obstacles à la création d’emplois dans l’économie formelle.
                À cet égard, le comité encourage le gouvernement marocain à s’inspirer de la recommandation de 2015 de l’Organisation internationale du Travail sur la transition de l’économie informelle vers l’économie formelle (no 204).", @"تعزيز الجهود من أجل تنظيم الاقتصاد غير النظامي والعمل المستقل بوسائل منها إدماج هؤلاء العمال في أنظمة الضمان الاجتماعي والعمل على تحسين ظروف عملهم تدريجياً. 
                - توسيع نطاق خدمات تفتيش العمل بصورة منهجية لتشمل القطاع غير النظامي والمناطق الريفية، وبالتصدي بحزم أكبر للعقبات التي تحول دون توفير فرص العمل في الاقتصاد النظامي. 
                وفي هذا الصدد، تشجع الدولة الطرف على استلهام توصية منظمة العمل الدولية لعام 2015 بشأن الانتقال من الاقتصاد غير النظامي إلى الاقتصاد النظامي (التوصية رقم 204).", "", "" },
                    { 671, null, "R44", "ت.44", "", "Non réalisé", "", 0, 4, null, 5, null, 15, null, "Organes de traités", @"Prendre les mesures nécessaires pour assurer la réinsertion des Marocains qui sont revenus dans l’État partie. 
                - Prendre, conformément à l’article 67 de la Convention, des mesures effectives à l’égard des Marocains expulsés du territoire algérien. 
                - Fournir des informations sur ce sujet dans le prochain rapport périodique. 
                - Fournir des informations sur les efforts de coopération internationale menés en application de l’article 64 de la Convention", @"اتخاذ التدابير اللازمة لضمان إعادة إدماج المغاربة العائدين إلى البلد. 
                وفقاً للمادة 67 من الاتفاقية، اتخاذ تدابير فعالة لفائدة المغاربة المطرودين من الأراضي الجزائرية. 
                تضمين التقرير الدوري المُقبل معلومات عن هذا الموضوع. 
                تقديم معلومات عن جهود التعاون الدولي المبذولة طبقاً للمادة 64 من الاتفاقية.", "", "" },
                    { 720, null, "R29P1P2P3P5", "ت.29.ف.1ف.2ف.3.ف.5", "", "Non réalisé", "", 0, 4, null, 6, null, 15, null, "Organes de traités", @"Considérer comme prioritaire la réalisation de l’égalité de facto avec les hommes sur le marché de l’emploi, afin d’appliquer intégralement l’article 11 de la Convention. 
                - Renforcer les mesures d’inspection pour assurer une meilleure application de la législation du travail 
                - prendre des mesures volontaristes pour éliminer la ségrégation par profession, tant horizontale que verticale, et combler l’écart salarial entre hommes et femmes
                - Adopter une politique d’emploi soucieuse de l’égalité entre les sexes pour réglementer le travail des femmes dans le secteur informel et améliorer leur accès aux emplois dans le secteur formel.", @"إيلاء الأولوية لتحقيق المساواة الفعلية بين المرأة والرجل في سوق العمل بحيث يتم الامتثال التام للمادة 11 من الاتفاقية. 
                -تعزيز تدابير التفتيش المتصلة بالعمال لكفالة تنفيذ أفضل لمدونة الشغل،
                 -اتخاذ تدابير استباقية للقضاء على العزل المهني عموديا وأفقيا وتضييق بل وسد الفجوة في الأجور بين النساء والرجال. 
                -اعتماد سياسات تصل بالعمالة لتنظيم عمل النساء في القطاع غير النظامي وتعزيز وصولهن إلى سوق العمل النظامي.", "", "" },
                    { 346, null, "R144.142", "142.144", "", "Non réalisé", "", 0, 4, 1, null, 5, 15, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir et protéger les droits économiques et sociaux au moyen de stratégies de développement encourageant l’investissement et l’emploi", "مواصلة الجهود من أجل تعزيز وحماية الحقوق الاقتصادية والاجتماعية عن طريق تنفيذ استراتيجية إنمائية لتشجيع الاستثمار والعمالة", "", "" },
                    { 205, null, "R83P25", "null", "", "Non réalisé", "", 0, 5, null, null, null, 20, 7, "Procédure spéciale", "-       En ce qui concerne Laâyoune, au Sahara occidental, enquêter rapidement sur toutes les allégations de torture et de mauvais traitements dans le cadre d’arrestations, pendant et après les manifestations ainsi qu’à la prison de Laâyoune; éviter les cas de privation de liberté arbitraire; tenir les auteurs responsables et indemniser les victimes;", "null", "", "" },
                    { 359, null, "R144.93", "93.144", "", "Non réalisé", "", 0, 5, 1, null, 49, 20, null, "Examen périodique universal", "Intensifier le débat national en vue d’abolir la peine de mort", "تكثيف المناقشات الوطنية بقصد إلغاء عقوبة الإعدام", "", "" },
                    { 360, null, "R144.94 P1", "94.144.ج.1", "", "Non réalisé", "", 0, 5, 1, null, 61, 20, null, "Examen périodique universal", "Maintenir le moratoire sur la peine de mort et intensifier le dialogue sur la peine capitale et son impact", "الإبقاء على الوقف الاختياري لعقوبة الإعدام وتكثيف الحوار بشأن عقوبة الإعدام وآثارها..........", "", "" },
                    { 100, null, "R88P1", "ت.88.ف.1", "", "Non réalisé", "", 0, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Veiller strictement à l’enregistrement des détenus dès leur arrestation, en particulier dans les affaires concernant la sécurité nationale et le terrorisme, et de faire en sorte que les chefs de poste de police, les agents de la police judiciaire et les fonctionnaires de police, y compris les membres de la DST, soient tenus pénalement responsables de toute détention non reconnue;", "-          (أ) التأكد من التقيد الصارم بالتسجيل منذ الوهلة الأولى من إلقاء القبض، خاصة في حالات الأمن القومي والمشتبه في ارتكابهم أعمالاً إرهابية؛ والتأكد من المساءلة الجنائية لمديري مراكز الشرطة والمحققين والموظفين التنفيذيين، بمن فيهم العاملون في إدارة مراقبة التراب الوطني (المخابرات)، عن أي احتجاز غير معترف به؛", "", "" },
                    { 101, null, "R88P3", "ت.88.ف.3", "", "Non réalisé", "", 0, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Mettre un terme à la pratique de l’isolement cellulaire et de la détention secrète, conformément à l’article 23 de la Constitution ;", "-          (ج) إنهاء ممارسة الحبس الانفرادي والاحتجاز السري، عملاً بالمادة 23 من الدستور؛", "", "" },
                    { 102, null, "R93P1", "ت.93.ف.1", "", "Non réalisé", "", 0, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Réduire fortement le taux de surpeuplement", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي: (أ) تقليص نسبة الاكتظاظ تقليصاً شديداً؛", "", "" },
                    { 103, null, "R93P2", "ت.93.ف.2", "", "Non réalisé", "", 0, 5, null, null, null, 21, 3, "Procédure spéciale", "Allouer des ressources budgétaires suffisantes pour assurer des soins de santé convenables ;- Améliorer la qualité de la nourriture et faire en sorte que les mineurs soient séparés des adultes et les détenus avant jugement des condamnés ;- Renforcer et améliorer le système d’application des peines de façon qu’il vise à assurer la réadaptation et la réinsertion des délinquants ; - Créer des possibilités d’instruction et de travail et des activités récréatives pour les détenus", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي:- (ب) تخصيص ميزانية كافية لتوفير الرعاية الصحية، وتحسين نوعية الغذاء، وفصل القُصّر عن البالغين والسجناء الذين لم تصدر بعد في حقهم أحكام عن المدانين؛ وتعزيز وتحسين نظام تطبيق الأحكام الذي يهدف إلى إعادة تأهيل الجناة وإعادة إدماجهم؛ وتوفير فرص تعليمية ومهنية وأنشطة ترفيهية للسجناء؛", "", "" },
                    { 104, null, "R93P3", "ت.93.ف.3", "", "Non réalisé", "", 0, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Transférer les prisonniers condamnés à la peine de mort et ceux qui exécutent une peine de réclusion à perpétuité dans des établissements ouverts ou semi-ouverts ;", "-          (ج) نقل السجناء المحكوم عليهم بالإعدام وبالسجن المؤبّد إلى مرافق مفتوحة أو شبه مفتوحة؛", "", "" },
                    { 105, null, "R93P6", "ت.93.ف.6", "", "Non réalisé", "", 0, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Fournir les soins dentaires et psychiatriques requis et assurer les interventions psychologiques voulues, de manière générale", "-          (و) توفير خدمات طب الأسنان والطب النفسي المناسبة، إضافة إلى التدخلات النفسية، والأخذ بذلك على أنه قاعدة عامة.", "", "" },
                    { 367, null, "R144.102", "102.144", "", "Non réalisé", "", 0, 5, 1, null, 75, 21, null, "Examen périodique universal", "Poursuivre les programmes socioéconomiques pour les détenus aux fins de leur réinsertion socioprofessionnelle à leur sortie de prison, en particulier en faveur des femmes et des jeunes", "مواصلة تنفيذ البرامج الاجتماعية والاقتصادية لصالح المساجين في إطار إعادة إدماجهم اجتماعياً ومهنياً بعد احتجازهم، ولا سيما لفائدة النساء والشباب", "", "" },
                    { 368, null, "R144.104", "104.144", "", "Non réalisé", "", 0, 5, 1, null, 41, 21, null, "Examen périodique universal", "Prendre les mesures nécessaires pour résoudre le problème de la surpopulation carcérale", "اتخاذ التدابير الضرورية لحل مشكلة اكتظاظ السجون", "", "" },
                    { 369, null, "R144.105", "105.144", "", "Non réalisé", "", 0, 5, 1, null, 51, 21, null, "Examen périodique universal", "Continuer à améliorer les conditions de détention dans les établissements pénitentiaires, réduire la surpopulation et adopter des mesures de substitution à la détention provisoire, et fournir des soins médicaux appropriés aux détenus", "مواصلة تحسين الظروف في السجون والحد من الاكتظاظ واعتماد بدائل عن الاحتجاز قبل المحاكمة وتوفير الرعاية الطبية الكافية للسجناء", "", "" },
                    { 559, null, "R19P1", "ت.19.ف1", "", "Non réalisé", "", 0, 5, null, 2, null, 21, null, "Organes de traités", "-            Poursuivre l’effort de construction de nouveaux établissements pénitentiaires et de rénovation des anciens, et continuer d’accroître les ressources allouées au fonctionnement des établissements pénitentiaires, notamment pour la nourriture et les soins médicaux.", "-           مواصلة الجهود فيما يتعلق ببناء مرافق احتجاز جديدة وترميم القديم منها، والاستمرار في زيادة الموارد المخصصة لتشغيل مرافق الاحتجاز، لا سيما فيما يتصل بالغذاء والرعاية الطبية لجعل ظروف الاحتجاز في جميع أنحاء الأراضي المغربية موافقة لمجموعة القواعد النموذجية الدنيا لمعاملة السجناء.", "", "" },
                    { 597, null, "R30", "ت.30", "", "Non réalisé", "", 0, 4, null, 3, null, 21, null, "Organes de traités", "Redoubler d’efforts pour remédier au problème de la surpopulation carcérale, notamment en mettant en place une politique de recours aux peines de substitution à la privation de liberté.", "-          بذل المزيد من الجهود لحل مشكلة الاكتظاظ في السجون، لا سيما بوضع سياسة لبدائل سلب الحرية.", "", "" },
                    { 106, null, "R95P4", "ت.95.ف.4", "", "Non réalisé", "", 0, 5, null, null, null, 22, 3, "Procédure spéciale", "Faire en sorte que les victimes obtiennent une réparation et une indemnisation équitable et suffisante, y compris les moyens d’une réadaptation aussi complète que possible ;                        Etablir des mécanismes et des programmes, notamment les structures requises au sein du Ministère de la santé, pour fournir à toutes les victimes des services de réadaptation, et de financer les services privés médicaux, juridiques et autres, y compris ceux administrés par des organisations non gouvernementales, prestataires de services médicaux, psychologiques et de réadaptation sociale", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي:  (ج) اتباع الإدارات المعنية بالصحة في السجون لوزارة الصحة، الأمر الذي يُفترض أن يسهم في تقديم خدمات طبية فائقة الجودة؛ ...استحداث آليات وبرامج، مثل البنى التحتية المناسبة داخل وزارة الصحة، وإعادة تأهيل الضحايا، وتمويل المرافق الطبية والقانونية وغيرها، مثل تلك التي تديرها المنظمات غير الحكومية، التي تقدم خدمات إعادة التأهيل الطبي والنفسي والاجتماعي؛", "", "" },
                    { 107, null, "R95P5", "ت.95.ف.5", "", "Non réalisé", "", 0, 5, null, null, null, 22, 3, "Procédure spéciale", "-    Envisager un financement bilatéral direct des organisations de la société civile qui apportent un soutien aux victimes et aux membres de leur famille, et de mettre en place des services spécialisés au sein du système de santé national. Le Fonds de contributions volontaires des Nations Unies pour les victimes de la torture est invité à examiner les demandes d’aide émanant d’ONG œuvrant pour assurer aux personnes qui ont été torturées l’accès à des soins médicaux et à des recours judiciaires.", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي: ... (ﻫ) النظر في التمويل الثنائي المباشر لمنظمات المجتمع المدني التي تساعد الضحايا وأسرهم، واستحداث إدارات متخصصة داخل النظام الصحي الوطني. ويُدعى صندوق الأمم المتحدة للتبرعات لضحايا التعذيب إلى النظر في طلبات المساعدة المقدمة من المنظمات غير الحكومية العاملة في مجال مساعدة ضحايا التعذيب على الحصول على الخدمات الطبية والانتصاف القانوني.", "", "" },
                    { 834, null, "R33P1P3", "ت.33.ف.1.ف.3", "", "Non réalisé", "", 0, 5, null, 8, null, 20, null, "Organes de traités", @"Légiférer et de prendre des mesures concrètes sur le plan administratif pour protéger les personnes handicapées, en particulier les femmes qui présentent un handicap intellectuel ou psychosocial, contre la torture et autres peines ou traitements cruels, inhumains ou dégradants.
                - Prendre des mesures concrètes pour garantir que, dans la pratique, les personnes handicapées ne soient pas soumises à des procédures et à des expérimentations médicales sans y avoir consenti librement et en connaissance de cause", @"(أ) اعتماد أحكام قانونية وتدابير إدارية ملموسة لحماية الأشخاص ذوي الإعاقة، ولا سيما النساء ذوات الإعاقة العقلية و/أو النفسية - الاجتماعية، من التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة،    
                -  (ب) اعتماد تدابير ملموسة تضمن، في الممارسة العملية، عدم إخضاع الأشخاص ذوي الإعاقة لإجراءات وتجارب طبية من دون موافقتهم الحرة والمستنيرة؛", "", "" },
                    { 560, null, "R29P1P2", "ت.29.ف.1.ف.2.", "", "Non réalisé", "", 0, 5, null, 2, null, 22, null, "Organes de traités", @"S’assurer que le Conseil national des droits de l’homme, qui a été désigné pour finaliser les travaux de l’IER, continue de s’efforcer d’élucider les cas de disparitions forcées intervenues entre 1956 et 1999 restés non élucidés, y compris les cas liés au Sahara occidental.
                -            Intensifier les efforts pour assurer aux victimes de torture et de mauvais traitements une réparation sous la forme d’une indemnisation équitable et suffisante et d’une réadaptation aussi complète que possible.", @"التأكد من استمرار المجلس الوطني لحقوق الإنسان، الذي أنيطت به مهمة استكمال أعمال هيئة الإنصاف والمصالحة، في بذل الجهد لتوضيح ملابسات حالات الاختفاء القسري التي وقعت بين عامي 1956 و1999 والتي لم توضح بعد، بما في ذلك القضايا المتعلقة بالصحراء الغربية. 
                - تكثيف الجهود لإنصاف ضحايا التعذيب وسوء المعاملة في شكل تعويض منصف وكاف وإعادة تأهيلهم على أكمل وجه ممكن.", "", "" },
                    { 22, null, "R80", "null", "", "Non réalisé", "", 0, 5, null, null, null, 23, 1, "Procédure spéciale", "-   Renforcer la participation des femmes à l’examen des questions relatives au droit à l’alimentation, en particulier au niveau de la prise de décisions. Il faudrait prévoir la pleine participation des femmes vivant dans des zones reculées à la vie politique.", "null", "", "" },
                    { 676, null, "R42", "ت.42", "", "Non réalisé", "", 0, 5, null, 5, null, 23, null, "Organes de traités", "Prendre des mesures pour assurer l’exercice du droit de vote à tous les travailleurs migrants marocains qui vivent à l’étranger.", "اتخاذ تدابير لضمان حق التصويت لجميع العمال المهاجرين المغاربة المقيمين في الخارج.", "", "" },
                    { 723, null, "R25P1P2", "ت.25.ف.1.ف.2", "", "Non réalisé", "", 0, 5, null, 6, null, 23, null, "Organes de traités", @"Prendre des dispositions législatives efficaces et s’inscrivant dans la durée pour accroître la représentation des femmes à tous les niveaux de la vie politique, y compris des mesures temporaires spéciales, en application du paragraphe 1 de l’article 4 de la Convention. 
                - Instituer des quotas pour les candidates aux élections municipales de 2009 et adopter des mesures temporaires spéciales qui permettent d’accroître la représentation des femmes aux postes de prise de décisions dans tous les domaines d’activité", @"اتخاذ التدابير القانونية الفعالة والمستدامة لزيادة التمثيل السياسي للمرأة على جميع المستويات، بما في ذلك اتخاذ تدابير استثنائية مؤقتة وفقا للفقرة 1 من المادة 4 من الاتفاقية، بدلا من الاعتماد على تعهدات أخلاقية تقطعها الأحزاب السياسية لخدمة أهداف بعينها. 
                تخصيص حصص قانونية للمرأة في الانتخابات البلدية لعام 2009 واعتماد تدابير استثنائية مؤقتة لزيادة نسبة تمثيل المرأة في مناصب اتخاذ القرار في جميع الأوساط", "", "" },
                    { 724, null, "R33P3", "ت.33.ف.3", "", "Non réalisé", "", 0, 5, null, 6, null, 23, null, "Organes de traités", "Le comité recommande également que les femmes participent pleinement à la formulation et à l’exécution de toutes les politiques et de tous les programmes sectoriels.", "إدماج تدابير خاصة مؤقتة، على النحو المنصوص عليه في الفقرة 1 من المادة 4 من الاتفاقية، لكفالة تمتع المرأة الريفية بحقوقها السياسية والاجتماعية والاقتصادية والثقافية دونما تمييز إدماجا تاما في عملية صوغ وتنفيذ جميع السياسات والبرامج في شتى القطاعات.", "", "" },
                    { 836, null, "R9P3", "ت.9.ف.3", "", "Non réalisé", "", 0, 5, null, 8, null, 23, null, "Organes de traités", "- Associer toutes les personnes handicapées à l’élaboration des politiques publiques et des plans d’action qu’il entend mettre en œuvre dans le domaine du handicap pour s’acquitter des obligations mises à sa charge par le paragraphe 1 c) de l’article 4 et de supprimer toute distinction entre les personnes handicapées titulaires d’une carte d’invalidité et les autres.", "-       (ب) شمول جميع الأشخاص ذوي الإعاقة في عملية وضع السياسات العامة وخطط العمل في مجال الإعاقة الرامية إلى تنفيذ التزاماتها بموجب المادة ٤(1)(ج) وإلغاء أي تمييز بين الأشخاص ذوي الإعاقة الذين يحملون بطاقة الإعاقة ومن لا يحملونها.", "", "" },
                    { 837, null, "R11", "ت.11", "", "Non réalisé", "", 0, 5, null, 8, null, 23, null, "Organes de traités", @"Instituer des mécanismes permettant d’assurer la participation et la consultation effectives et constructives des personnes handicapées, par l’intermédiaire des organisations qui les représentent et de façon régulière, et d’allouer des ressources budgétaires suffisantes de façon à encourager la participation constructive des personnes handicapées ;
                - Encourager et soutenir la participation des organisations de femmes, d’enfants et de jeunes handicapés et de personnes présentant un handicap intellectuel ou psychosocial, d’élaborer des mécanismes de consultation à l’intention des personnes présentant un handicap intellectuel et de diffuser des informations au sujet de ces mécanismes dans des formats qui soient accessibles à ces personnes.", @"(أ) إنشاء آليات لضمان إشراك ومشاورة الأشخاص ذوي الإعاقة بشكل فعلي ومجد ومنتظم، من خلال المنظمات التي تمثلهم، وضمان توفير موارد كافية في الميزانية من أجل تعزيز مشاركتهم مشاركة مجدية؛
                -  (ب) تشجيع ودعم مشاركة المنظمات التي تمثل النساء والأطفال والشباب من ذوي الإعاقة والأشخاص ذوي الإعاقة العقلية و/أو النفسية - الاجتماعية، ووضع آليات لإجراء عمليات التشاور وتوفير المعلومات عنها في أشكال يسهل الاطلاع عليها للأشخاص ذوي الإعاقة العقلية", "", "" },
                    { 838, null, "R23P1P3", "ت.23.ف.1.ف.3", "", "Non réalisé", "", 0, 5, null, 8, null, 23, null, "Organes de traités", @"Concevoir un plan stratégique visant à assurer l’accessibilité des technologies de l’information et des communications, dans lequel il établira des directives concernant la passation de marchés de biens et de services, et d’associer les personnes handicapées et les organisations qui les représentent à ce processus 
                - De tenir compte des liens entre l’article 9 de la Convention et les cibles 11.2 et 11.7 des objectifs de développement durable, afin d’assurer l’accès de tous à des systèmes de transport sûrs, accessibles et viables, à un coût abordable, notamment en développant les transports publics, une attention particulière devant être accordée aux personnes handicapées, et d’assurer l’accès de tous, en particulier des personnes handicapées, à des espaces verts et à des espaces publics sûrs, inclusifs et accessibles", @"(أ) وضع خطة استراتيجية لتوفير تكنولوجيا معلومات واتصالات يمكن الوصول إليها، وتحدد فيها المبادئ التوجيهية لشراء السلع والخدمات، وضمان إشراك الأشخاص ذوي الإعاقة والمنظمات التي تمثلهم في هذه العملية؛
                -  (ج) إيلاء اهتمام للصلات القائمة بين المادة 9 من الاتفاقية والغايتين 11-2 و11-7 من أهداف التنمية المستدامة، من أجل إتاحة استفادة الجميع من نظم نقل آمن وفي المتناول وميسر ومستدام، ولا سيما من خلال توسيع شبكة النقل العام، مع إيلاء اهتمام خاص لاحتياجات الأشخاص ذوي الإعاقة وتعميم الوصول إلى المساحات العامة الآمنة والشاملة والميسرة والخضراء، وبخاصة للأشخاص ذوي الإعاقة.", "", "" },
                    { 839, null, "R39P4", "ت.39.ف.4", "", "Non réalisé", "", 0, 5, null, 8, null, 23, null, "Organes de traités", "Adopter des mesures aux niveaux national et local pour garantir l’accessibilité des services et des équipements sociaux pour toutes les personnes handicapées dans tous les domaines de la vie", "(د)  اعتماد تدابير على الصعيدين الوطني والمحلي لضمان إمكانية وصول الأشخاص ذوي الإعاقة كافة إلى الخدمات والمرافق المجتمعية في جميع مجالات الحياة", "", "" },
                    { 840, null, "R55", "ت.55", "", "Non réalisé", "", 0, 5, null, 8, null, 23, null, "Organes de traités", "Adopter un plan pour garantir l’accessibilité des lieux de vote, notamment par la fourniture de matériel de vote et d’informations électorales dans des formats accessibles à toutes les personnes handicapées, et d’assurer une formation adéquate aux membres du personnel électoral sur les droits des personnes handicapées à toutes les étapes du processus électoral.", "-      اعتماد خطة لضمان إمكانية الوصول إلى مكان الاقتراع، بما في ذلك من خلال توفير المواد الانتخابية والمعلومات في أشكال يسهل الاطلاع عليها لجميع الأشخاص ذوي الإعاقة، وتوفير التدريب الملائم لموظفي الانتخابات بشأن حقوق الأشخاص ذوي الإعاقة في جميع مراحل العملية الانتخابية.", "", "" },
                    { 841, null, "R61", "ت.61", "", "Non réalisé", "", 0, 5, null, 8, null, 23, null, "Organes de traités", "Adopter des mesures visant à assurer la participation effective et l’inclusion et la consultation des personnes handicapées et des organisations qui les représentent dans le cadre des programmes de coopération internationale.", "-      اعتماد تدابير تضمن إشراك واحتواء ومشاورة الأشخاص ذوي الإعاقة والمنظمات التي تمثلهم، فعلياً، في سياق برامج التعاون الدولي.", "", "" },
                    { 842, null, "R63P4", "ت.63.ف.4", "", "Non réalisé", "", 0, 5, null, 8, null, 23, null, "Organes de traités", "Assurer la participation permanente des personnes handicapées, par l’intermédiaire de leurs organisations représentatives, au processus de suivi de la mise œuvre de la Convention, notamment en fournissant les fonds nécessaires.", "-       (د) ضمان المشاركة الدائمة للأشخاص ذوي الإعاقة، من خلال المنظمات التي تمثلهم، في عملية رصد الاتفاقية، بما في ذلك عن طريق توفير التمويل اللازم.", "", "" },
                    { 54, null, "R79P6", "null", "", "Non réalisé", "", 0, 5, null, null, null, 24, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne les libertés d’opinion et d’expression", "null", "", "" },
                    { 370, null, "R144.115", "115.144", "", "Non réalisé", "", 0, 5, 1, null, 74, 24, null, "Examen périodique universal", "Poursuivre les travaux visant à renforcer la liberté d’expression par l’application de la loi portant création du Conseil national de la presse", "مواصلة العمل على تعزيز حرية التعبير عن طريق تنفيذ القانون المنشئ للمجلس الوطني للصحافة", "", "" },
                    { 835, null, "R33P2", "ت.33.ف.2", "", "Non réalisé", "", 0, 5, null, 8, null, 22, null, "Organes de traités", "Prendre des mesures pour soutenir les victimes de tels actes en leur offrant une assistance juridique et un accompagnement psychologique et en veillant à ce que des mesures d’indemnisation et de réparation soient ordonnées en leur faveur", "-          (أ) اعتماد أحكام قانونية وتدابير إدارية ملموسة لحماية الأشخاص ذوي الإعاقة، ولا سيما النساء ذوات الإعاقة العقلية و/أو النفسية - الاجتماعية، من التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة، واعتماد تدابير ترمي إلى دعم هؤلاء الضحايا من خلال إسداء النصح القانوني والمشورة لهم وتعويضهم وجبر ضررهم؛", "", "" },
                    { 345, null, "R144.180", "180.144", "", "Non réalisé", "", 0, 4, 1, null, 29, 14, null, "Examen périodique universal", "Promouvoir des programmes qui encouragent l’éducation des enfants, notamment des filles dans les villages, et bénéficient aux groupes vulnérables", "النهوض بالبرامج التي تشجع تعليم الأطفال وخاصة الفتيات في القرى ولصالح الفئات الهشة", "", "" },
                    { 775, null, "R69P2", "ت.69.ف.2", "", "Non réalisé", "", 0, 5, null, 7, null, 20, null, "Organes de traités", "L’État partie devrait également prendre des mesures pour mettre fin à l’impunité de ceux qui se livrent à la traite des enfants.", "متابعة الملاحظات الختامية والتوصيات التي سبق أن قدمتها اللجنة بشأن البروتوكول الاختياري لاتفاقية حقوق الطفل بشأن بيع الأطفال واستغلال الأطفال في البغاء وفي المواد الإباحية", "", "" },
                    { 773, null, "R37P1P4", "ت.37.ف.1.ف.4", "", "Non réalisé", "", 0, 5, null, 7, null, 20, null, "Organes de traités", @"Renvoyant à son Observation générale no 8 (2006) relative aux droits de l’enfant et à une protection contre les châtiments corporels et les autres formes cruelles ou dégradantes de châtiment, le Comité invite le Maroc à:
                a) Interdire sans équivoque les châtiments corporels dans tous les contextes;
                 d) Assurer la participation de l’ensemble de la société, y compris les enfants, à la conception et à la mise en œuvre de stratégies de prévention des châtiments corporels", @"في ضوء تعليق اللجنة العام رقم 8(2006) بشأن حق الطفل في الحماية من العقوبة البدنية وغيرها من ضروب العقوبة القاسية أو المهينة، تحث اللجنة الدولة المملكة المغربية على ما يلي: 
                - (أ) حظر العقوبة البدنية في جميع الأماكن صراحةً؛
                -  (د) تهيئة سبل انخراط ومشاركة المجتمع ككل، بما فيه الأطفال، في وضع وتنفيذ استراتيجيات تقي الأطفال العقوبة البدنية. 
                ة.", "", "" },
                    { 361, null, "R144.95P1P3", "95.144. ج.1 و ج.3", "", "Non réalisé", "", 0, 5, 1, null, 2, 20, null, "Examen périodique universal", "Poursuivre le débat national en cours relatif à l’abolition de la peine de mort", "مواصلة النقاش الوطني الحالي بشأن إلغاء عقوبة الإعدام....... والنظر في إضفاء الصفة الرسمية على الوقف الاختياري لتنفيذها بحكم الواقع الذي يُطبَّق حالياً", "", "" },
                    { 362, null, "R144.96P1", "96.144. ج.1", "", "Non réalisé", "", 0, 5, 1, null, 81, 20, null, "Examen périodique universal", "Maintenir son moratoire de fait sur l’application de la peine de mort", "الإبقاء على الوقف الاختياري بحكم الواقع على استخدام عقوبة الإعدام....", "", "" },
                    { 363, null, "R144.97", "97.144", "", "Non réalisé", "", 0, 5, 1, null, 1, 20, null, "Examen périodique universal", "Poursuivre le débat national sur l’abolition de la peine de mort", "مواصلة النقاش الوطني بشأن إلغاء عقوبة الإعدام", "", "" },
                    { 364, null, "R144.98", "98.144", "", "Non réalisé", "", 0, 5, 1, null, 95, 20, null, "Examen périodique universal", "Envisager d’officialiser le moratoire de fait sur la peine de mort", "النظر في إضفاء الصفة الرسمية على الوقف الاختياري لتنفيذ عقوبة الإعدام بحكم الواقع", "", "" },
                    { 365, null, "R144.99", "99.144", "", "Non réalisé", "", 0, 5, 1, null, 63, 20, null, "Examen périodique universal", "Envisager d’abolir la peine capitale", "النظر في إلغاء عقوبة الإعدام", "", "" },
                    { 366, null, "R144.101P1", "101.144. ج.1", "", "Non réalisé", "", 0, 5, 1, null, 8, 20, null, "Examen périodique universal", "Maintenir le moratoire sur la peine de mort", ".........الإبقاء على الوقف الاختياري لعقوبة الإعدام.......", "", "" },
                    { 545, null, "R5P2", "ت.5.ف.2", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", "-            S’assurer que quiconque se rend coupable ou complice d’actes de torture, tente de commettre de tels actes ou participe à leur commission fasse l’objet d’une enquête, de poursuites et d’un châtiment sans pouvoir bénéficier d’un délai de prescription.", "خضوع كل من يرتكب أفعال تعذيب أو يتواطأ على ارتكابها أو يحاول اقترافها أو يشارك فيها للتحقيق والملاحقة والمعاقبة دون أن يتسنى له الاستفادة من أي أجل تقادم.", "", "" },
                    { 546, null, "R7P2", "ت.7.ف.2", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", "-            Prendre des mesures pour permettre l’accès à un avocat dès le début de la garde à vue, sans aucune autorisation préalable, et mettre en place un régime effectif d’aide juridictionnelle gratuite, en particulier pour les personnes se trouvant en situation de risque ou appartenant à des groupes en situation de vulnérabilité.", "-          اتخاذ خطوات لإتاحة الوصول إلى محام منذ بداية الحبس الاحتياطي دون إذن مسبق، وأن تنشئ نظاماً فعلياً للمساعدة القانونية المجانية، يستفيد منه بصفة خاصة الأشخاص المعرضون للخطر أو المنتمون إلى فئات ضعيفة.", "", "" },
                    { 547, null, "R9P1P2P3", "ت.9.ف.1ف.2ف.3", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", @"N’expulse ,ne renvoyer ou n’extrader une personne vers un État où il y a des motifs sérieux de croire qu’elle risque d’être soumise à la torture.
                - Examiner minutieusement, sur le fond, chaque cas particulier, y compris la situation générale en matière de torture dans le pays de retour.
                - Etablir et mettre en œuvre des procédures bien définies pour obtenir des assurances diplomatiques, des mécanismes judiciaires appropriés de contrôle et des dispositifs efficaces de suivi en cas de refoulement.", @"الإحجام عن طرد أو إبعاد أو تسليم أي شخص باتجاه دولة توجد بشأنها أسباب وجيهة تدعو إلى الاعتقاد بأن الشخص قد يتعرض فيها للتعذيب. 
                - البحث في كل حالة على حدة بحثاً دقيقاً من حيث الأسس الموضوعية، بما في ذلك الحالة العامة المتعلقة بالتعذيب في البلد الذي يُعاد إليه الشخص المعني.
                - وضع وتنفيذ إجراءات محددة جيداً للحصول على هذه الضمانات الدبلوماسية وإنشاء الآليات القضائية المناسبة للرصد، وآليات فعالة للمتابعة في حالات الإبعاد.", "", "" },
                    { 548, null, "R10", "ت.10", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", "Prendre immédiatement des mesures concrètes pour enquêter sur les actes de torture, et poursuivre et punir leurs auteurs. -Garantir que les membres des forces de l’ordre n’utilisent pas la torture, notamment en réaffirmant clairement l’interdiction absolue de la torture, en condamnant publiquement la pratique de la torture, en particulier par la police, le personnel pénitentiaire et les membres de la DST, et en faisant clairement savoir que quiconque commet de tels actes, s’en rend complice ou y participe en sera tenu personnellement responsable devant la loi, fera l’objet de poursuites pénales et se verra infliger des peines appropriées", @"اتخاذ خطوات ملموسة للتحقيق في أعمال التعذيب وملاحقة مرتكبيه ومعاقبتهم. 
                - ضمان ألا يمارس أفراد الشرطة التعذيب، وخاصة بالتوكيد مجدّداً وبوضوح على الحظر المطلق للتعذيب وعبر الإدانة العلنية لممارسة التعذيب لا سيما من جانب الشرطة وموظفي السجون وأفراد مديرية مراقبة التراب الوطني، وعبر الإعلان الواضح عن أن كل من يرتكب مثل هذه الأعمال ويتواطأ فيها أو يشارك فيها سيُحمّل مسؤولية شخصية على ذلك أمام القانون وسيكون عرضة للملاحقة الجنائية، وسينال العقوبات المناسبة.", "", "" },
                    { 549, null, "R11", "ت.11", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", @"Faire en sorte qu’aucun individu placé sous le contrôle de l’Etat à un moment donné ne fasse l’objet de tels «transfèrements secrets». Le transfèrement, le refoulement, la détention et l’interrogation des personnes dans de telles conditions constituent en eux-mêmes une violation de la Convention. 
                - Mener des investigations effectives et impartiales et, le cas échéant, faire toute la lumière sur les cas de «transfèrements secrets» dans lesquels il a pu jouer un rôle. Il devrait poursuivre et punir les auteurs de ces transfèrements.", @"كفالة عدم تعرض أي فرد وضع تحت سلطة الدولة في وقت مّا 'لعمليات ترحيل' ' المنفَّذة في سياق الحرب الدولية على الإرهاب. فترحيل وإبعاد واحتجاز واستجواب الأشخاص في مثل تلك الظروف أمور تمثل في حد ذاتها انتهاكاً للاتفاقية. 
                - إجراء تحقيقات فعالة ونزيهة وتسليط الضوء، عند الضرورة، على 'عمليات الترحيل السري' التي قد لعبت فيها دوراً وإحالة منفذي عمليات الإبعاد إلى القضاء ومعاقبتهم", "", "" },
                    { 550, null, "R13P2", "ت.13.ف.2", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", "-            Renforcer les mesures prises pour que des enquêtes approfondies, impartiales et efficaces soient menées rapidement sur les violences et les décès survenus à l’occasion du démantèlement du camp de GdeimIzik, et que les responsables soient traduits en justice.", "-          تعزيز التدابير المتخذة من أجل إجراء تحقيقات مسهبة ونزيهة وفعالة على وجه السرعة في أعمال العنف وفي حالات الوفيات التي وقعت أثناء تفكيك مخيم اكديم الزيك، وتقديم المسؤولين عن هذه الأفعال إلى العدالة.", "", "" },
                    { 551, null, "R15", "ت.15", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", @"Garantir que toute personne arrêtée et détenue bénéficie des procédures judiciaires en vigueur et que les garanties fondamentales consacrées par le droit positif soient respectées : par exemple, l’accès du détenu à un avocat et à un médecin indépendant, son droit à ce que les membres de sa famille soient informés de son arrestation et de son lieu de détention, et sa présentation devant un juge. 
                - Prendre des mesures en vue de garantir que les registres, les procès-verbaux et tous les documents officiels relatifs à l’arrestation et à la détention des personnes soient tenus avec la plus grande rigueur et que tous les éléments se rapportant à l’arrestation et à la détention y soient consignés et attestés à la fois par les officiers de police judiciaire et par la personne concernée. 
                - S’assurer que des enquêtes approfondies, impartiales et efficaces soient menées rapidement sur toutes les allégations d’arrestation et de détention arbitraires et les responsables éventuels traduits en justice. 
                - Faire en sorte que nul ne soit gardé dans un centre de détention secret placé de facto sous son contrôle effectif et ouvrir une enquête impartiale et efficace sur l’existence de tels lieux de détention. Tous les lieux de détention devraient être soumis à un système régulier de contrôle et de surveillance", @"كفالة استفادة كل شخص معتقل ومحتجز من الإجراءات القانونية السارية وكفالة الضمانات الأساسية المكرسة في القانون الوضعي: ومن الأمثلة على ذلك: السماح للمعتقل بالوصول إلى محام وإلى طبيب مستقل، ومنحه الحق في إخطار أسرته باعتقاله وبمكان احتجازه ومثوله أمام قاض. 
                - اتخاذ تدابير لضمان مسك السجلات والمحاضر وجميع الوثائق الرسمية المتعلقة باعتقال واحتجاز الأشخاص وفق أكبر قدر من الصرامة، وأن تدون فيها جميع العناصر المتصلة بالاعتقال والاحتجاز وأن يشهد عليها كل من ضباط الشرطة القضائية والشخص المعني.
                -  التأكد من إجراء تحقيقات مسهبة ونزيهة وفعالة على وجه السرعة بشأن جميع المزاعم المتعلقة بحالات الاعتقال والاحتجاز التعسفية وأن تتم إحالة من يحتمل مسؤوليتهم عنها إلى العدالة.
                - كفالة ألا يُحتفظ بأي شخص في مركز احتجاز سري خاضع لسيطرة الدولة الفعلية بحكم الواقع. وكما أكدته اللجنة مراراً، يعد احتجاز أشخاص في ظل هذه الظروف انتهاكاً للاتفاقية. 
                - فتح تحقيق نزيه وفعال بشأن مدى وجود مراكز احتجاز من هذا القبيل. ويجب أن تخضع كل أماكن الاحتجاز السرية للرصد والمراقبة على نحو منتظم", "", "" },
                    { 774, null, "R41P1P2", "ت.41.ف.1.ف.2", "", "Non réalisé", "", 0, 5, null, 7, null, 20, null, "Organes de traités", @"Prendre toutes les mesures requises pour faire en sorte que les filles qui avaient été forcées à épouser la personne qui a abusé d’elles avant l’abrogation de l’article 475 du Code pénal reçoivent l’aide dont elles ont besoin pour échapper à des situations dans lesquelles elles sont victimes d’abus.
                - Faire en sorte que tous les enfants soumis à une quelconque forme d’exploitation et d’abus sexuels soient traités en tant que victimes et ne fassent jamais l’objet de sanctions pénales", @"اتخاذ جميع التدابير التي تؤمّن للفتيات اللائي أكرهن على الزواج ممن اعتدوا عليهن قبل إلغاء المادة 475 من القانون الجنائي الدعم اللازم ليخلصن من الحالات التعسفية. 
                - ضمان معاملة جميع الأطفال المعرضين لأي شكل من أشكال الاستغلال والاعتداء الجنسيين معاملة الضحايا وألا يعرضوا أبداً لعقوبات جنائية", "", "" },
                    { 552, null, "R16P1P3", "ت.16.ف.1.ف.3", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", @"Faire en sorte que toutes les allégations de torture et de mauvais traitements fassent rapidement l’objet d’une enquête efficace et impartiale et que les auteurs soient poursuivis et condamnés à des peines proportionnées à la gravité de leurs actes, comme le requiert l’article 4 de la Convention. 
                - Veiller à ce que, dans la pratique, les plaignants et les témoins soient protégés contre tout mauvais traitement et tout acte d’intimidation liés à leur plainte ou à leur témoignage.", @"إجراء تحقيق فعال ونزيه بشأن جميع مزاعم التعذيب وإساءة المعاملة، وملاحقة مرتكبيها قضائياً وإدانتهم بأحكام تتناسب مع جسامة أفعالهم، وفقاً لما تنص عليه المادة 4 من الاتفاقية
                - الحرص على حماية المشتكين والشهود من أي سوء معاملة ومن أي ترهيب بسبب شكواهم أو شهادتهم", "", "" },
                    { 554, null, "R20P1P3", "ت.20.ف.1.ف.3", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", @"Enquêter rapidement et de manière approfondie et impartiale sur tous les décès en détention et poursuivre les personnes responsables, le cas échéant. 
                - Veiller à ce que les examens soient effectués par des médecins légistes indépendants, et accepter les conclusions de ces examens comme preuves dans les procédures pénales et civiles", @"إجراء تحقيقات عاجلة مسهبة ونزيهة في جميع حالات الوفيات في الحجز، وملاحقة المسؤولين عنها عند اللزوم. 
                - الحرص على أن يتم إجراء الفحوصات من قبل أطباء شرعيين مستقلين وأن تقبل نتائج تلك الفحوصات كدليل يعتد به في الإجراءات الجنائية والمدنية.", "", "" },
                    { 555, null, "R21P2P3P4", "ت.21.ف.2.ف.3.ف.4", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", @"Poursuivre son moratoire de facto sur l’application des peines capitales, faire en sorte que sa 9 prévoie la possibilité de commuer les condamnations à mort et 
                - Veiller à ce que tous les condamnés à mort bénéficient de la protection assurée par la Convention. 
                - Faire en sorte que ces derniers soient traités avec humanité, et qu’ils puissent, en particulier, bénéficier des visites de leur famille et de leurs avocats", @"الاستمرار في التوقف الفعلي عن تنفيذ عقوبة الإعدام
                - العمل على أن تتيح التشريعات إمكانية تخفيف أحكام الإعدام، وأن يستفيد جميع المحكوم عليهم بالإعدام من الحماية التي توفرها الاتفاقية. 
                -كفالة معاملة هؤلاء المحكوم عليهم بالإعدام معاملة إنسانية، وبخاصة إتاحة الفرصة أمامهم لتلقي زيارات عائلاتهم ومحاميهم.", "", "" },
                    { 556, null, "R22P3P4", "ت.22.ف.3.ف.4", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", @"Faire en sorte que des médecins légistes formés à la détection des signes de torture soient présents pendant ces visites. 
                - S’assurer que les patients détenus dans ces institutions contre leur gré soient en mesure de faire appel de la décision d’internement et d’avoir accès à un médecin de leur choix", @"كفالة أن يحضر زيارات أماكن الاحتجاز بما فيها المستشفيات أطباء شرعيون مدربون على كشف علامات التعذيب. 
                - تمكين المرضى المعتقلين في تلك المؤسسات بدون إرادتهم من إمكانية طلب استئناف قرار الاعتقال وإمكانية الاتصال بطبيب من اختيارهم", "", "" },
                    { 557, null, "R22P3P4", "ت.22.ف.3.ف.4", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", @"-Faire en sorte que des médecins légistes formés à la détection des signes de torture soient présents pendant ces visites. 
                - S’assurer que les patients détenus dans ces institutions contre leur gré soient en mesure de faire appel de la décision d’internement et d’avoir accès à un médecin de leur choix", @"كفالة أن يحضر زيارات أماكن الاحتجاز بما فيها المستشفيات أطباء شرعيون مدربون على كشف علامات التعذيب. 
                - تمكين المرضى المعتقلين في تلك المؤسسات بدون إرادتهم من إمكانية طلب استئناف قرار الاعتقال وإمكانية الاتصال بطبيب من اختيارهم", "", "" },
                    { 558, null, "R18P3", "ت.18.ف.3", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", "-            Faire en sorte que des médecins légistes formés à la détection des signes de torture soient présents pendant les visites périodiques et inopinées des observateurs nationaux et internationaux, prévues par le mécanisme national de contrôle des lieux de détention", "-          العمل على حضور الزيارات لأماكن الاحتجاز من قبل أطباء شرعيين مدربين على كشف علامات التعذيب.", "", "" },
                    { 594, null, "R20P1", "ت.20.ف.1", "", "Non réalisé", "", 0, 4, null, 3, null, 20, null, "Organes de traités", "- Poursuivre le débat national en cours relatif à l’abolition de la peine de mort et envisager d’officialiser le moratoire de fait observé actuellement. Il devrait par ailleurs", "-          متواصلة المناقشة الوطنية الحالية بشأن إلغاء عقوبة الإعدام والنظر في إضفاء طابع رسمي على الوقف الاختياري الفعلي المعمول به حالياً.", "", "" },
                    { 595, null, "R24P1P2P3P4", "ت.24.ف.1.ف.2.ف.3.ف.4", "", "Non réalisé", "", 0, 4, null, 3, null, 20, null, "Organes de traités", @"a) Prendre des mesures fortes pour éradiquer la torture et les traitements cruels, inhumains ou dégradants et pour enquêter efficacement, poursuivre et punir ces actes ; 
                b) Procéder sans délai à des expertises médicales pour toutes les allégations de torture et de mauvais traitements ; 
                c) Veiller à l’application effective, dans la pratique, de l’interdiction des aveux forcés et de l’irrecevabilité des éléments de preuve entachés de torture ; 
                d) Offrir des recours utiles et garantir réparation aux victimes ;", @"(أ) اتخاذ تدابير صارمة لاستئصال التعذيب والمعاملة القاسية أو اللاإنسانية أو المهينة، وللتحقيق بفعالية في هذه الأعمال وملاحقة مرتكبيها ومعاقبتهم؛ 
                - (ب) إجراء فحوص طبية فورية في جميع ادعاءات التعذيب وسوء المعاملة؛ 
                - (ج) والحرص على التطبيق الفعال، في الواقع، لحظر الاعترافات القسرية وعدم قبول الأدلة المشوبة بالتعذيب؛ 
                - (د) وتوفير سبل انتصاف فعالة ومنح تعويضات للضحايا؛ 
                - (ه) وتسريع عملية اعتماد القانون المنشئ للآلية الوطنية لمنع التعذيب.", "", "" },
                    { 596, null, "R28", "ت.28", "", "Non réalisé", "", 0, 4, null, 3, null, 20, null, "Organes de traités", "Poursuivre et accélérer ses efforts pour élucider tous les cas de disparition forcée, y compris ceux liés au Sahara occidental, et procéder sans délai à des enquêtes en vue d’identifier, juger et punir les responsables de disparitions forcées.", "-          مواصلة تكثيف الجهود لتجلية جميع حالات الاختفاء القسري، بما فيها تلك المتصلة بالصحراء الغربية، والتعجيل بالتحقيق فيها لتحديد هوية الجناة ومحاكمتهم ومعاقبتهم.", "", "" },
                    { 672, null, "R28P1P2P3", "ت.28.ف1.ف.2.ف3.", "", "Non réalisé", "", 0, 5, null, 5, null, 20, null, "Organes de traités", "prendre des mesures et intensifier les efforts visant à remédier d’urgence aux problèmes des mauvais traitements et autres actes de violence commis contre les travailleurs migrants et les membres de leur famille, quels que soient les auteurs de ces actes. En particulier, le Comité recommande de prendre les mesures suivantes :", @"اتخاذ تدابير وتكثيف الجهود في سبيل الإسراع في معالجة مشاكل سوء المعاملة وغير ذلك من أعمال العنف المرتكبة في حق العمال المهاجرين وأفراد أسرهم، أياً كان مرتكبوها. وعلى وجه الخصوص، اتخاذ التدابير التالية: 
                (أ) ضمان وصول العمال المهاجرين وأفراد أسرهم إلى آليات تظلم مستقلة وإلى خدمات مشورة قانونية ومترجمين فوريين؛
                 (ب) ضمان إجراء تحريات وتحقيقات في كل فعل من أفعال التعذيب أو المعاملة القاسية أو اللاإنسانية أو المهينة وكل اعتداء على حياة العمال المهاجرين؛
                (ج) ضمان محاكمة المسؤولين عن تلك الأفعال وإدانتهم على النحو السليم؛", "", "" },
                    { 673, null, "R28P1P2P3", "ت.28.ف1.ف.2.ف3.", "", "Non réalisé", "", 0, 5, null, 5, null, 20, null, "Organes de traités", "a) Veiller à ce que les travailleurs migrants et les membres de leur famille aient accès à des mécanismes de plaintes indépendants, ainsi qu’à des services de conseils légaux et à des interprètes ;", @"اتخاذ تدابير وتكثيف الجهود في سبيل الإسراع في معالجة مشاكل سوء المعاملة وغير ذلك من أعمال العنف المرتكبة في حق العمال المهاجرين وأفراد أسرهم، أياً كان مرتكبوها. وعلى وجه الخصوص، اتخاذ التدابير التالية: 
                (أ) ضمان وصول العمال المهاجرين وأفراد أسرهم إلى آليات تظلم مستقلة وإلى خدمات مشورة قانونية ومترجمين فوريين؛
                 (ب) ضمان إجراء تحريات وتحقيقات في كل فعل من أفعال التعذيب أو المعاملة القاسية أو اللاإنسانية أو المهينة وكل اعتداء على حياة العمال المهاجرين؛
                (ج) ضمان محاكمة المسؤولين عن تلك الأفعال وإدانتهم على النحو السليم؛", "", "" },
                    { 674, null, "R28P1P2P3", "ت.28.ف1.ف.2.ف3.", "", "Non réalisé", "", 0, 5, null, 5, null, 20, null, "Organes de traités", @"prendre des mesures et intensifier les efforts visant à remédier d’urgence aux problèmes des mauvais traitements et autres actes de violence commis contre les travailleurs migrants et les membres de leur famille, quels que soient les auteurs de ces actes. En particulier, le Comité recommande de prendre les mesures suivantes :
                a) Veiller à ce que les travailleurs migrants et les membres de leur famille aient accès à des mécanismes de plaintes indépendants, ainsi qu’à des services de conseils légaux et à des interprètes ;
                b) Veiller à ce que tout acte de torture ou traitement cruel, inhumain ou dégradant, ainsi que toute atteinte à la vie des travailleurs migrants fassent l’objet d’enquêtes et d’investigations; 
                c) Veiller à ce que les responsables soient jugés et condamnés de façon appropriée", @"اتخاذ تدابير وتكثيف الجهود في سبيل الإسراع في معالجة مشاكل سوء المعاملة وغير ذلك من أعمال العنف المرتكبة في حق العمال المهاجرين وأفراد أسرهم، أياً كان مرتكبوها. وعلى وجه الخصوص، اتخاذ التدابير التالية: 
                (أ) ضمان وصول العمال المهاجرين وأفراد أسرهم إلى آليات تظلم مستقلة وإلى خدمات مشورة قانونية ومترجمين فوريين؛
                 (ب) ضمان إجراء تحريات وتحقيقات في كل فعل من أفعال التعذيب أو المعاملة القاسية أو اللاإنسانية أو المهينة وكل اعتداء على حياة العمال المهاجرين؛
                (ج) ضمان محاكمة المسؤولين عن تلك الأفعال وإدانتهم على النحو السليم؛", "", "" },
                    { 675, null, "R34", "ت.34", "", "Non réalisé", "", 0, 5, null, 5, null, 20, null, "Organes de traités", @"Prendre des mesures adéquates pour mettre un terme aux abus et aux violations dont sont victimes les travailleurs migrants et les membres de leur famille. 
                - Créer un mécanisme de surveillance des activités des autorités marocaines chargées des procédures de migration ou impliquées dans ces procédures afin de garantir que les abus et les violations commis à l’encontre de travailleurs migrants et des membres de leur famille, tels que la confiscation et la destruction de leurs documents d’identité, fassent l’objet d’une enquête et que les responsables soient poursuivis et sanctionnés, conformément à l’article 21 de la Convention", "اتخاذ تدابير مناسبة لوضع حدٍ للتجاوزات والانتهاكات التي يتعرض لها العمال المهاجرون وأفراد أسرهم. وعلى وجه الخصوص، إنشاء آلية لمراقبة أنشطة السلطات المغربية المعنية بإجراءات الهجرة أو المشاركة في هذه الإجراءات بغية ضمان التحقيق في التجاوزات والانتهاكات المرتكبة في حق العمال المهاجرين وأفراد أسرهم مثل مصادرة وثائق هويتهم وإتلافها، وضمان مقاضاة المسؤولين عن تلك الأفعال ومعاقبتهم، وفقاً للمادة 21 من الاتفاقية.", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 772, null, "R35 P1", "ت.35.ف.1", "", "Non réalisé", "", 0, 5, null, 7, null, 20, null, "Organes de traités", @"Enquêter sur tous les cas de torture et de mauvais traitements et poursuive les auteurs, en veillant à ce que l’enfant maltraité ne soit pas stigmatisé dans le cadre des procédures judiciaires et à ce que sa vie privée soit protégée. 
                - Equiper toutes les structures d’accueil et les centres de détention pour enfants de caméras de surveillance à même de détecter toute maltraitance et mettre à la disposition des enfants des mécanismes de recours accessibles et sûrs. Tous les auteurs de sévices devraient être tenus responsables et sévèrement punis
                .", @"التحقيق في حالات إساءة المعاملة ومقاضاة مقترفيها، وعلى الحرص على عدم وقوع الطفل المساء إليه ضحيةً في الإجراءات القانونية وعلى حماية خصوصيته
                - تجهيز كل مؤسسات استقبال/مراكز احتجاز الأطفال بآلات التصوير لكشف أي اعتداء عليهم، وتوفير آليات تظلّم ميسّرة ومأمونة للأطفال. وينبغي مساءلة جميع الجناة ومعاقبتهم عقاباً شديداً.", "", "" },
                    { 553, null, "R17P1P2", "ت.17ف.1.ف.2", "", "Non réalisé", "", 0, 5, null, 2, null, 20, null, "Organes de traités", @"Prendre toutes mesures nécessaires pour garantir que les condamnations pénales soient prononcées sur la foi de preuves autres que les aveux de l’inculpé, notamment lorsque l’inculpé revient sur ses aveux durant le procès, et que les déclarations faites sous la torture ne soient pas invoquées comme éléments de preuve au cours de la procédure, si ce n’est contre la personne accusée de torture, conformément aux dispositions de la Convention.
                - Examiner les condamnations pénales prononcées exclusivement sur la foi d’aveux afin d’identifier dans quels cas la condamnation s’est fondée sur des aveux obtenus sous la torture ou par des mauvais traitements", @"اتخاذ التدابير اللازمة لضمان استناد الإدانات الجنائية إلى أدلة أخرى غير اعترافات المتهم، خاصة حينما يتراجع المهم عن اعترافاته أثناء المحاكمة، وألا يعتد بالتصريحات المنتزعة تحت التعذيب كدليل يمكن استخدامه أثناء الإجراءات، إلا إذا كانت هذه الإجراءات ضد الشخص المتهم بارتكاب التعذيب، وذلك وفقاً لأحكام الاتفاقية.
                - مراجعة الإدانات الجنائية الصادرة بالاستناد إلى الاعترافات فقط، حتى يتسنى تحديد الحالات التي استندت فيها الإدانة إلى اعترافات منتزعة تحت التعذيب أو سوء المعاملة", "", "" },
                    { 543, null, "R24P1", "ت.24.ف1", "", "Non réalisé", "", 0, 3, null, 2, null, 10, null, "Organes de traités", "-            Modifier la 9 afin d’interdire le recours aux châtiments corporels dans l’éducation des enfants, tant au sein de la famille que dans les centres de protection de l’enfance.", "-          تعديل التشريعات بهدف منع اللجوء إلى العقاب البدني في سياق تربية الأطفال سواء داخل الأسرة أو داخل مراكز حماية الطفل.", "", "" },
                    { 39, null, "R74", "null", "", "Non réalisé", "", 0, 1, null, null, null, 1, 2, "Procédure spéciale", "Donner à toutes les personnes les moyens de faire valoir leurs droits, en garantissant à toutes les victimes de discrimination ou d’intolérance raciale et xénophobe un accès effectif à la justice et à des voies de recours adéquates. - Mieux faire connaître les voies de recours disponibles et en faciliter l’accès, notamment en supprimant les obstacles linguistiques et en fournissant des informations adéquates et accessibles sur les droits et les recours dont disposent les groupes et les personnes en situation de vulnérabilité.", "null", "", "" },
                    { 330, null, "R144.162", "162.144", "", "Non réalisé", "", 0, 4, 1, null, 43, 14, null, "Examen périodique universal", "Comme suite aux recommandations issues du deuxième cycle figurant aux paragraphes 129.98, 129.102, 129.111, 129.116, 129.117 et 130.9 du document A/HRC/21/3, accroître les investissements dans l’enseignement public en vue d’augmenter les salaires des enseignants et de mettre en place des programmes de formation professionnelle et technique", "متابعة التوصيات المنبثقة عن الجولة الثانية والواردة في الوثيقة A/HRC/21/3 الفقرات 129-98 و129-102 و129-111 و129-116 و129-117 و130-9، وزيادة الاستثمارات في التعليم العام وذلك بزيادة مرتبات المدرسين واستحداث برامج تدريب مهني وفني", "", "" },
                    { 166, null, "R93P7", "null", "", "Non réalisé", "", 0, 4, null, null, null, 13, 6, "Procédure spéciale", "Assurer l’accès au droit à la santé, y compris aux services de santé sexuelle et reproductive et d’information", "null", "", "" },
                    { 94, null, "R95P3", "ت.95.ف.3", "", "Non réalisé", "", 0, 4, null, null, null, 13, 3, "Procédure spéciale", "-    Rattacher les services de santé destinés aux prisonniers au Ministère de la santé, ce qui devrait contribuer à des soins médicaux de meilleure qualité", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي:  (ج) اتباع الإدارات المعنية بالصحة في السجون لوزارة الصحة، الأمر الذي يُفترض أن يسهم في تقديم خدمات طبية فائقة الجودة؛", "", "" },
                    { 93, null, "R94P1", "ت.94.ف.1", "", "Non réalisé", "", 0, 4, null, null, null, 13, 3, "Procédure spéciale", "-    Pour ce qui est des établissements psychiatriques, appliquer les dispositions des articles 3 et 4 du décret d’application de la loi (no 23/98) sur les prisons, notamment en ce qui concerne le non-recours à la violence contre les prisonniers, et d’interdire l’isolement cellulaire ;", "بخصوص المصحات النفسية، يوصي المقرر الخاص الحكومة بما يلي: ...(أ) تطبيق أحكام المادتين 3 و4 من المرسوم التنفيذي لقانون السجون (رقم 23/98)، لا سيما ما تعلق بالامتناع عن استخدام العنف في حق السجناء، وحظر الحبس الانفرادي؛", "", "" },
                    { 92, null, "R88P8", "ت.88.ف.8", "", "Non réalisé", "", 0, 4, null, null, null, 13, 3, "Procédure spéciale", "-    Investir dans les domaines de la psychiatrie et de la médecine légale ainsi que dans la formation spécialisée d’experts médico-légaux capables de se prononcer sur les cas de torture et de mauvais traitements, conformément aux normes internationales, notamment le Protocole d’Istanbul; de renforcer les moyens médicolégaux du parquet et des tribunaux;", "-          (ح) الاستثمار في الطب النفسي والطب الشرعي، وكذلك في تدريب خبراء الطب الشرعي على تقييم سوء المعاملة والتعذيب، تماشياً مع المعايير الدولية، مثل بروتوكول اسطنبول؛ وتدعيم قدرات الادعاء والقضاء في مجال الطب الشرعي؛", "", "" },
                    { 49, null, "R79P4", "null", "", "Non réalisé", "", 0, 4, null, null, null, 13, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’accès aux services de santé", "null", "", "" },
                    { 14, null, "R90P1", "null", "", "Non réalisé", "", 0, 4, null, null, null, 13, 1, "Procédure spéciale", "-   Faciliter, dans des conditions d’égalité, l’accès aux services de santé primaires, réduire la mortalité maternelle, juvénile et infantile et promouvoir de bonnes pratiques d’allaitement, conformément aux recommandations formulées par le Comité des droits de l’enfant", "null", "", "" },
                    { 13, null, "R84", "null", "", "Non réalisé", "", 0, 4, null, null, null, 13, 1, "Procédure spéciale", "-   Mieux faire appliquer le Code international de commercialisation des substituts du lait maternel et créer un système de suivi indépendant.", "null", "", "" },
                    { 12, null, "R83", "null", "", "Non réalisé", "", 0, 4, null, null, null, 13, 1, "Procédure spéciale", "-   Sensibiliser la population aux meilleures pratiques d’allaitement et aider les femmes et leur famille à adopter les meilleures pratiques en ce qui concerne l’alimentation des nourrissons et des jeunes enfants", "null", "", "" },
                    { 11, null, "R82", "null", "", "Non réalisé", "", 0, 4, null, null, null, 13, 1, "Procédure spéciale", "-   Prendre des mesures pour promouvoir une alimentation saine auprès des femmes et souligner les risques sanitaires associés au surpoids et à l’obésité", "null", "", "" },
                    { 636, null, "R50P2P3P4P5", "ت.50.ف.2.ف.3ف.4.ف.5", "", "Non réalisé", "", 0, 4, null, null, null, 12, null, "Organes de traités", @"Redoubler les efforts pour offrir l’enseignement primaire, secondaire et universitaire en amazigh, augmenter la présence de cette langue dans la télévision et régler définitivement la question des prénoms amazighs.
                - Prendre des mesures pour garantir aux Amazighs et aux Sahraouis la jouissance pleine et sans restriction de leur droit de participer à la vie culturelle.
                - Prendre des mesures additionnelles pour protéger la diversité culturelle et permettre aux Amazighs et aux Sahraouis de préserver, de promouvoir, d’exprimer et de diffuser leur identité, leur histoire, leur culture, leur langue, leurs traditions et leurs coutumes.
                - Continuer à faciliter l’accès à la culture et à la science pour tous, y compris l’accès à Internet, en particulier pour les personnes handicapées et les personnes les plus démunies de sa population", @"تكثيف الجهود من أجل توفير التعليم الابتدائي والثانوي والجامعي باللغة الأمازيغية، وزيادة الحيز المخصص لها في التلفزيون، وإيجاد حل نهائي لمسألة الأسماء الأمازيغية. 
                - اتخاذ تدابير تكفل للأمازيغ والصحراويين التمتع كلياً بحقهم في المشاركة في الحياة الثقافية دون تقييد. 
                - اتخاذ تدابير إضافية لحماية التنوع الثقافي، وتمكين الأمازيغ والصحراويين من صون هويتهم وتاريخهم وثقافتهم ولغتهم وعاداتهم وتقاليدهم وتعزيزها والتعبير عنها ونشرها. 
                - المضي في تيسير سبل تمتع الجميع بالثقافة والعلوم، بما في ذلك تيسير إمكانية الوصول إلى شبكة الإنترنت، ولا سيما للأشخاص ذوي الإعاقة وللسكان الأشد عوزاً. وفي هذا الصدد، تحيل اللجنة الدولة الطرف إلى تعليقها العام رقم 21(2009) بشأن حق كل فرد في المشاركة في الحياة الثقافية.", "", "" },
                    { 635, null, "R14P3", "ت.14.ف.3", "", "Non réalisé", "", 0, 4, null, null, null, 12, null, "Organes de traités", @"Tenant en compte son observation générale no 20 (2009) sur la non-discrimination dans l’exercice des droits économiques, sociaux et culturels, le Comité appelle à :
                - Prendre des mesures pour assurer aux Amazighs la pleine jouissance de leurs droits consacrés par le Pacte en adoptant si nécessaire des mesures spéciales temporaires", @"رجوعا إلى تعليقها العام رقم 20(2009) بشأن عدم التمييز في الحقوق الاقتصادية والاجتماعية والثقافية، تدعو اللجنة إلى:
                - - (ج) اتخاذ تدابير تكفل للأمازيغ التمتع كلياً بحقوقهم المنصوص عليها في العهد من خلال اعتماد تدابير خاصة مؤقتة عند الاقتضاء؛", "", "" },
                    { 593, null, "R50", "-          ت.50", "", "Non réalisé", "", 0, 4, null, 3, null, 12, null, "Organes de traités", "Accélérer ses efforts en vue de l’adoption prochaine d’une loi organique sur la langue amazighe, pour promouvoir l’accès des Amazighs à un enseignement dans leur langue, et permettre l’utilisation de la langue amazighe lors de procédures judiciaires et administratives ainsi que l’enregistrement des prénoms amazighs.", "تسريع جهودها لاعتماد القانون التنظيمي المتعلق باللغة الأمازيغية قريباً، من أجل تشجيع حصول الأمازيغ على التعليم بلغتهم، والسماح باستعمال الأمازيغية في الإجراءات القضائية والإدارية، إضافة إلى تسجيل الأسماء الأمازيغية.", "", "" },
                    { 326, null, "R144.236", "236.144", "", "Non réalisé", "", 0, 4, 1, null, 84, 12, null, "Examen périodique universal", "Garantir un accès plein et égal aux ressources socioéconomiques (y compris l’accès à l’enseignement supérieur et aux cours de langue traditionnelle) pour les populations amazighes et saharienne/sahraouie", "ضمان الوصول التام والمتساوي إلى الموارد الاجتماعية والاقتصادية (بما في ذلك الحصول على التعليم الجامعي وعلى دروس في اللغات التقليدية) للسكان الأمازيغ والصحراويين", "", "" },
                    { 325, null, "R144.235", "235.144", "", "Non réalisé", "", 0, 4, 1, null, 60, 12, null, "Examen périodique universal", "Continuer d’adopter les mesures législatives et les politiques de protection nécessaires pour assurer l’éducation aux populations amazighes et sahraouies à tous les niveaux, ainsi que la pleine jouissance de leurs droits de manifester et de participer à la vie culturelle du pays, en préservant leurs traditions et leur identité", "مواصلة اعتماد تدابير تشريعية وسياسات الحماية الضرورية لكفالة التعليم للسكان الأمازيغ والصحراويين في جميع المستويات، إلى جانب التمتع الكامل بحقوقهم في التظاهر والمشاركة في الحياة الثقافية في البلد بما يحفظ تقاليدهم وهويتهم", "", "" },
                    { 324, null, "R144.234", "234.144", "", "Non réalisé", "", 0, 4, 1, null, 16, 12, null, "Examen périodique universal", "Poursuivre les efforts en vue de la promotion et de la préservation du patrimoine culturel saharo-hassani, tel que consacré dans la Constitution de 2011", "مواصلة الجهود باتجاه تعزيز التراث الثقافي الصحراوي الحسّاني والمحافظة عليه، مثلما هو مكرّس في دستور عام 2011", "", "" },
                    { 323, null, "R144.233", "233.144", "", "Non réalisé", "", 0, 4, 1, null, 16, 12, null, "Examen périodique universal", "Poursuivre les efforts visant à introduire l’enseignement de la langue et de la culture amazighe", "مواصلة جهوده لتوفير تعليم اللغة والثقافة الأمازيغيتين", "", "" },
                    { 322, null, "R144.232", "232.144", "", "Non réalisé", "", 0, 4, 1, null, 11, 12, null, "Examen périodique universal", "Poursuivre ses efforts appréciables en faveur du développement des langues nationales et promouvoir et protéger la langue et les patrimoines culturels amazighs", "مواصلة جهوده المحمودة باتجاه تطوير اللغات الوطنية وتعزيز وحماية اللغة والتراث الثقافي الأمازيغيين", "", "" },
                    { 321, null, "144.181", "181.144", "", "Non réalisé", "", 0, 4, 1, null, 29, 12, null, "Examen périodique universal", "Poursuivre les efforts de promotion des droits culturels par des programmes visant à protéger et revitaliser la diversité du patrimoine culturel constitutif de l’identité marocaine, y compris le patrimoine hassani dans les provinces du sud", "مواصلة الجهود لتعزيز الحقوق الثقافية عن طريق برامج لحماية وإنعاش تنوع التراث الثقافي الذي يشكل الهوية المغربية بما فيه التراث الحساني في الأقاليم الجنوبية", "", "" },
                    { 224, null, "R88P2P4", "ت.88.ف.2.ف.4", "", "Non réalisé", "", 0, 4, null, null, null, 12, 8, "Procédure spéciale", "Procéder à des investissements pour entretenir les infrastructures et développer les maisons de la culture et des jeunes existantes - Créer les possibilités et les conditions voulues pour que les jeunes, les femmes et les personnes handicapées puissent contribuer à la vie culturelle de la société. Des mesures concertées sont nécessaires pour garantir le financement de projets pour les jeunes, comme le groupe des «filles cavalières» de Khemisset", "الاستثمار في صيانة الهياكل الأساسية ومواصلة تطوير المراكز الثقافية والشبابية القائمة؛- خلق فرص وظروف ملائمة للشباب والمرأة والأشخاص ذوي الإعاقة لكي يساهموا في الحياة الثقافية للمجتمع. ولا بد من تدابير تتضافر فيها الجهود من أجل ضمان الحصول على تمويل للمشاريع الخاصة بالشباب، مثل مشروع الفتيات الفارسات في مدينة الخميسات.", "", "" },
                    { 223, null, "R86P6-1", "ت.86.ف.6ج1", "", "Non réalisé", "", 0, 4, null, null, null, 12, 8, "Procédure spéciale", "Elaborer un plan national d’action pour le développement culturel qui garantisse effectivement l’expression de la diversité culturelle. En particulier, de promouvoir les valeurs positives de la diversité culturelle par l’éducation, dans les médias et au moyen de programmes spéciaux destinés aux personnes handicapées. À cette fin, des ressources adéquates devraient être consacrées à la mise en œuvre des stratégies, politiques et programmes aux niveaux central, régional et local.", "-    (و) وضع خطة عمل وطنية للتنمية الثقافية تضمن بشكل فعال إبراز التنوع الثقافي؛ وعلى الخصوص، ترويج القيم الإيجابية للتنوع الثقافي من خلال التعليم ووسائط الإعلام وبرامج خاصة للأشخاص ذوي الإعاقة. ولتحقيق هذا الهدف، ينبغي تخصيص موارد كافية لتنفيذ الاستراتيجيات والسياسات والبرامج المناسبة على الصعيد المركزي والإقليمي والمحلي.", "", "" },
                    { 222, null, "R86P3-2", "ت.86.ف.4ج2", "", "Non réalisé", "", 0, 4, null, null, null, 12, 8, "Procédure spéciale", "Respecter le droit d’avoir accès au patrimoine culturel de sa propre communauté et à celui des autres et d’en jouir, y compris l’histoire des communautés, leurs figures emblématiques et leur patrimoine linguistique", "-    (ج) ..... ينبغي للمغرب أن يحترم حق الفرد في الوصول إلى التراث الثقافي لجماعته وللآخرين والتمتع به، بما فيه تاريخ المجتمعات المحلية وشخصياتها البارزة وتراثها اللغوي؛", "", "" },
                    { 221, null, "R86P1-2", "ت.86.ف.1ج2", "", "Non réalisé", "", 0, 4, null, null, null, 12, 8, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en allouant des subventions aux artistes, théâtres et associations culturelles amazighs, y compris aux groupes d’artistes amazighs qui voyagent à l’étranger et représentent la culture marocaine", "(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:- تخصيص إعانات للفنانين الأمازيغ والمسارح والجمعيات الثقافية الأمازيغية، بما في ذلك الفنانون الأمازيغ ضمن الفرق التي تسافر إلى الخارج لتمثيل ثقافة المغرب", "", "" },
                    { 220, null, "R85", "ت.85", "", "Non réalisé", "", 0, 4, null, null, null, 12, 8, "Procédure spéciale", "Envisager la diversité culturelle comme une ressource inestimable pour associer chacun à la vie du pays, et à prendre des mesures pour qu’il soit tenu compte de la diversité culturelle et du patrimoine culturel des diverses populations du pays, notamment en assurant la promotion de ces cultures par l’éducation, dans les médias et au moyen d’activités culturelles, en améliorant les compétences interculturelles de toutes les institutions officielles et en encourageant le bilinguisme dans la 21.", "-    النظر إلى التنوع الثقافي كمورد لا يقدر بثمن لإدماج الجميع، واتخاذ تدابير لتعميم التنوع الثقافي والتراث الثقافي لسكان البلد المتنوعين عن طريق جملة أمور منها الترويج لهذه الثقافات من خلال التثقيف ووسائط الإعلام والأنشطة الثقافية، وتعزيز الكفاءات متعددة الثقافات لدى جميع المؤسسات الرسمية وتشجيع المهارات ثنائية اللغة في صفوف الموظفين الحكوميين.", "", "" },
                    { 219, null, "R85", "ت.85", "", "Non réalisé", "", 0, 4, null, null, null, 12, 8, "Procédure spéciale", "Envisager la diversité culturelle comme une ressource inestimable pour associer chacun à la vie du pays, et à prendre des mesures pour qu’il soit tenu compte de la diversité culturelle et du patrimoine culturel des diverses populations du pays, notamment en assurant la promotion de ces cultures par l’éducation, dans les médias et au moyen d’activités culturelles, en améliorant les compétences interculturelles de toutes les institutions officielles et en encourageant le bilinguisme dans la fonction publique.", "-    النظر إلى التنوع الثقافي كمورد لا يقدر بثمن لإدماج الجميع، واتخاذ تدابير لتعميم التنوع الثقافي والتراث الثقافي لسكان البلد المتنوعين عن طريق جملة أمور منها الترويج لهذه الثقافات من خلال التثقيف ووسائط الإعلام والأنشطة الثقافية، وتعزيز الكفاءات متعددة الثقافات لدى جميع المؤسسات الرسمية وتشجيع المهارات ثنائية اللغة في صفوف الموظفين الحكوميين.", "", "" },
                    { 48, null, "R78P2", "null", "", "Non réalisé", "", 0, 4, null, null, null, 12, 2, "Procédure spéciale", "-       Prendre des mesures provisoires pour prévenir et atténuer toutes les formes de discrimination linguistique et culturelle dans tous les domaines.", "null", "", "" },
                    { 47, null, "R72", "null", "", "Non réalisé", "", 0, 4, null, null, null, 12, 2, "Procédure spéciale", "-       Recueillir au moyen d’indicateurs des données fiables et ventilées qui rendent fidèlement compte de la diversité raciale, culturelle et ethnique de la population marocaine, y compris de la diversité linguistique − dont témoignent bien les indicateurs qui mesurent l’utilisation de la langue orale et le degré d’alphabétisation", "null", "", "" },
                    { 827, null, "R53P1", "ت.53.ف.1", "", "Non réalisé", "", 0, 4, null, 8, null, 11, null, "Organes de traités", "a) mettre en place un régime de protection sociale visant à garantir un niveau de vie suffisant aux personnes handicapées, notamment au moyen de systèmes d’indemnisation sous forme d’allocations qui permettront aux personnes handicapées de couvrir les dépenses liées au handicap", @"(أ) وضع نظام للحماية الاجتماعية يرمي إلى كفالة تمتع الأشخاص ذوي الإعاقة بمستوى معيشي لائق، بما في ذلك عن طريق أنظمة التعويض على شكل بدلات تمكن الأشخاص ذوي الإعاقة من تغطية النفقات المرتبطة بالإعاقة؛
                -  (ب) إيلاء الاهتمام للصلات القائمة بين المادة 28 من الاتفاقية والغاية 10-2 من أهداف التنمية المستدامة، بهدف تمكين وتعزيز الإدماج الاجتماعي والاقتصادي والسياسي للجميع، بغض النظر عن الإعاقة. ‬", "", "" },
                    { 327, null, "R144.160", "160.144", "", "Non réalisé", "", 0, 4, 1, null, 15, 13, null, "Examen périodique universal", "Continuer de fournir une couverture médicale de base à sa population, notamment aux personnes âgées", "مواصلة توفير التغطية الطبية الأساسية لجميع سكانه بمن فيهم المسنون", "", "" },
                    { 328, null, "R144.163", "163.144", "", "Non réalisé", "", 0, 4, 1, null, 76, 13, null, "Examen périodique universal", "Améliorer l’accès aux services de santé dans les zones rurales, en particulier pour réduire la mortalité et la morbidité maternelles", "زيادة الفرص في الحصول على خدمات الرعاية الصحية في الأرياف لأهداف منها الحد من معدلات وفيات الأمهات واعتلالهن", "", "" },
                    { 329, null, "R144.164", "164.144", "", "Non réalisé", "", 0, 4, 1, null, 91, 13, null, "Examen périodique universal", "Continuer de promouvoir les soins et consultations prénatals pour réduire la nécessité du transport d’urgence au moment de l’accouchement et réduire ainsi le risque de décès chez les mères et les enfants", "زيادة تحسين خدمات الرعاية الصحية قبل الولادة واستشارات الطبيب للحد من ضرورة النقل العاجل عند المخاض ومن ثم الحد من خطر وفيات الأمهات والأطفال", "", "" },
                    { 499, null, "R11P3", "·          ت.11.ف.3", "", "Non réalisé", "", 0, 4, null, 1, null, 13, null, "Organes de traités", "Prendre les mesures nécessaires pour s’assurer que des amazighs ne soient victimes d’aucune forme de discrimination raciale, notamment dans l’accès aux services de santé.", "اتخاذ التدابير اللازمة لضمان عدم تعرض الأمازيغ لأي شكل من أشكال التمييز العنصري، لا سيما وفي الحصول على الخدمات الصحية.", "", "" },
                    { 828, null, "R37P1", "ت.37.ف.1", "", "Non réalisé", "", 0, 4, null, 8, null, 13, null, "Organes de traités", "Interdire et d’incriminer la pratique des interventions chirurgicales correctrices pratiquées sur les personnes intersexuées handicapées sans leur consentement préalable et éclairé ainsi que la pratique de la stérilisation forcée, notamment la castration chimique", "-      حظر وتجريم الممارسة المتمثلة في إخضاع الأشخاص ذوي الإعاقة من حاملي صفات الجنسين لعمليات جراحية تصحيحية من دون الحصول على موافقة مسبقة ومستنيرة، وممارسة التعقيم القسري، بما في ذلك الإخصاء الكيميائي القسري", "", "" },
                    { 829, null, "R45P2", "ت.45.ف.2", "", "Non réalisé", "", 0, 4, null, 8, null, 13, null, "Organes de traités", "Prendre des mesures pour fournir aux personnes handicapées un accès, dans des formats adaptés, à des programmes d’information sur la santé sexuelle et procréative et la planification familiale", "-       (ب) اتخاذ تدابير ترمي إلى تمكين الأشخاص ذوي الإعاقة من الحصول، في أشكال ملائمة، على المعلومات المتعلقة بالصحة الجنسية والإنجابية وتنظيم الأسرة، .....", "", "" },
                    { 830, null, "R49", "ت.49", "", "Non réalisé", "", 0, 4, null, 8, null, 13, null, "Organes de traités", @"a) D’adopter une stratégie visant à garantir que les personnes handicapées aient accès aux services de santé et de veiller à ce que cette stratégie couvre notamment le développement d’infrastructures accessibles, la formation des professionnels de la santé aux droits des personnes handicapées et la fourniture d’informations sur les traitements médicaux dans des formats accessibles, notamment pour les personnes présentant un handicap intellectuel ou psychosocial ;
                b) veiller à ce que les informations sur les droits en matière de sexualité et de procréation soient diffusées dans des formats accessibles à toutes les personnes handicapées ; 
                c) Etablir des protocoles visant à garantir aux personnes handicapées le droit au consentement libre et éclairé dans le cadre de la mise en œuvre du plan national relatif à la santé et au handicap pour la période 2015-2021 ;
                d) Tenir compte des liens entre l’article 25 de la Convention et la cible 3.7 des objectifs de développement durable afin d’assurer l’accès de tous à des services de soins de santé sexuelle et procréative", @"الخدمات الصحية، تشمل في جملة عناصر إيجاد مرافق يسهل الوصول إليها، وتدريب العاملين في المجال الصحي على حقوق الأشخاص ذوي الإعاقة، وتوفير المعلومات في أشكال يسهل الاطلاع عليها عن العلاجات الصحية، بما في ذلك للأشخاص ذوي الإعاقة العقلية و/أو النفسية - الاجتماعية؛
                -  (ب) ضمان نشر المعلومات المتعلقة بالحقوق الجنسية والإنجابية بأشكال ميسرة لجميع الأشخاص ذوي الإعاقة؛ 
                -  (ج) وضع بروتوكولات ترمي إلى ضمان حق الأشخاص ذوي الإعاقة في إعطاء موافقة حرة ومستنيرة في إطار تنفيذ مخطط العمل الوطني للصحة والإعاقة 2015-2021؛
                -  (د) إيلاء الاهتمام للصلات القائمة بين المادة 25 من الاتفاقية والغاية 3-7 من أهداف التنمية المستدامة، من أجل ضمان حصول الجميع على خدمات الرعاية الصحية الجنسية والإنجابية.‬", "", "" },
                    { 15, null, "R95P1P3", "null", "", "Non réalisé", "", 0, 4, null, null, null, 14, 1, "Procédure spéciale", "Pour les provinces marocaines du sud :-  Veiller à ce que les ressources éducatives profitent à la population locale- Elaborer des programmes de formation technique à l’intention des Sahraouis", "null", "", "" },
                    { 16, null, "R96P1", "null", "", "Non réalisé", "", 0, 4, null, null, null, 14, 1, "Procédure spéciale", "Pour les provinces marocaines du sud :- Suivre la mise en œuvre des programmes relatifs à l’éducation", "null", "", "" },
                    { 50, null, "R79P1", "null", "", "Non réalisé", "", 0, 4, null, null, null, 14, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’éducation", "null", "", "" },
                    { 167, null, "R93P8", "null", "", "Non réalisé", "", 0, 4, null, null, null, 14, 6, "Procédure spéciale", "Assurer l’accès à l’éducation pour les filles rurales, y compris par des mesures supplémentaires et efficaces pour faciliter leur participation dans l’enseignement primaire et secondaire.", "null", "", "" },
                    { 225, null, "R86P1-3", "ت.86.ف.1ج3", "", "Non réalisé", "", 0, 4, null, null, null, 14, 8, "Procédure spéciale", "- Renforcer l’appui à la promotion et à la préservation de la culture amazighe en réformant le secteur de l’éducation pour garantir l’utilisation de la langue amazighe dans tous les domaines, et faire figurer des manuels en langue amazighe dans la liste officielle des ouvrages distribués gratuitement dans toutes les écoles établie par le Ministère de l’éducation nationale", "(أ)  زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي: 3-إصلاح قطاع التعليم من أجل ضمان استخدام اللغة الأمازيغية في جميع المجالات التعليمية، وإدراج الكتب المدرسية المكتوبة باللغة الأمازيغية في القائمة الرسمية للكتب التي تعدها وزارة التربية لتوزيعها بالمجان في جميع المدارس؛", "", "" },
                    { 226, null, "R86P3-1", "ت.86.ف.4ج1", "", "Non réalisé", "", 0, 4, null, null, null, 14, 8, "Procédure spéciale", "Abroger la circulaire no 122 du 7 janvier 2002 du Ministère de l’éducation nationale stipulant que le nom non arabe d’un certain nombre d’écoles doit être remplacé par un nom arabe, et d’abroger tout autre texte législatif ou réglementaire comparable", "-    (ج) إلغاء مذكرة وزارة التربية رقم 122 المؤرخة 7 كانون الثاني/ يناير 2002 التي تنص على تغيير الأسماء غير العربية لعدد من المدارس بأسماء عربية، وإلغاء أي تشريعات أخرى من هذا القبيل. ....", "", "" },
                    { 227, null, "R86P4", "ت.86.ف.4", "", "Non réalisé", "", 0, 4, null, null, null, 14, 8, "Procédure spéciale", "Réviser les manuels scolaires d’histoire et d’autres disciplines afin de refléter la diversité du pays, en veillant à une représentation adéquate de la diversité culturelle entre les auteurs, ainsi qu’au sein du comité indépendant chargé d’approuver les manuels. De plus, les programmes de formation des enseignants devraient comprendre des méthodologies reflétant la richesse de la diversité culturelle marocaine de la manière la plus interactive et novatrice possible", "-    (د) تنقيح مادة التاريخ وغيرها من المواد في الكتب المدرسية لتعبر عن التنوع الذي يزخر به البلد، مع ضمان تمثيل كافٍ للتنوع الثقافي بين المؤلفين، وكذلك في لجنة الاستعراض المستقلة التي توافق على الكتب المدرسية. وبالإضافة إلى ذلك، ينبغي أن تشمل برامج تدريب المدرسين منهجيات تعبر عن ثراء التنوع الثقافي المغربي بأكثر الأساليب تفاعلاً وابتكاراً.", "", "" },
                    { 766, null, "R53P3", "ت.53.ف.3", "", "Non réalisé", "", 0, 4, null, 7, null, 13, null, "Organes de traités", @"Adopter une approche du handicap fondée sur les droits de l’homme et recommande en particulier :
                c) D’adopter sans délai des mesures pour faire en sorte que les enfants handicapés aient accès aux soins de santé, y compris aux programmes de dépistage et d’intervention précoces;", @"تحث اللجنة المملكة المغربية، في ضوء المادة 23 من الاتفاقية وتعليقها العام     رقم 9(2006) بشأن حقوق الأطفال ذوي الإعاقة، على انتهاج نهج يقوم على حقوق الإنسان في التعاطي مع الإعاقة، وتوصيها بالآتي تحديداً: 
                -  (ج) اتخاذ تدابير فورية تكفل للأطفال ذوي الإعاقة تلقي الرعاية الصحية، بما فيها برامج الكشف والتدخل المبكرين؛", "", "" },
                    { 331, null, "R144.165", "165.144", "", "Non réalisé", "", 0, 4, 1, null, 100, 14, null, "Examen périodique universal", "Prendre de nouvelles mesures ciblées pour promouvoir l’éducation inclusive pour tous", "اتخاذ مزيد من التدابير المحددة الهدف بغية تعزيز التعليم الجامع", "", "" },
                    { 332, null, "R144.166", "166.144", "", "Non réalisé", "", 0, 4, 1, null, 16, 14, null, "Examen périodique universal", "Mettre en œuvre la vision stratégique pour la réforme de l’éducation sur la période 2015-2030 (16) ;", "تنفيذ الرؤية الاستراتيجية لإصلاح التعليم للفترة ما بين عامي 2015 و2030", "", "" },
                    { 826, null, "R45P1", "ت.45.ف.1", "", "Non réalisé", "", 0, 4, null, 8, null, 11, null, "Organes de traités", "Prendre des mesures pour fournir un soutien aux familles de personnes handicapées, notamment aux parents handicapés, afin de leur permettre d’élever leurs enfants à la maison", "-       (أ) اتخاذ تدابير لضمان تقديم الدعم لأسر الأشخاص ذوي الإعاقة، بمن فيهم الآباء ذوو الإعاقة، من أجل تنشئة أطفالهم في المنزل؛", "", "" },
                    { 333, null, "R144.168", "168.144", "", "Non réalisé", "", 0, 4, 1, null, 58, 14, null, "Examen périodique universal", "Continuer de renforcer le droit à l’éducation", "مواصلة تكريس الحق في التعليم", "", "" },
                    { 335, null, "R144.170", "170.144", "", "Non réalisé", "", 0, 4, 1, null, 71, 14, null, "Examen périodique universal", "Envisager d’éliminer les différences en matière de scolarisation entre les villes et les zones rurales, entre filles et garçons et parmi les minorités", "النظر في القضاء على التفاوتات في التعليم ما بين الحواضر والأرياف وما بين الفتيات والفتيان وما بين الأقليات", "", "" },
                    { 336, null, "R144.171", "171.144", "", "Non réalisé", "", 0, 4, 1, null, 73, 14, null, "Examen périodique universal", "Mettre en œuvre des mesures visant à garantir l’éducation inclusive pour tous dans l’enseignement primaire, secondaire et universitaire", "تنفيذ تدابير لضمان حصول الجميع على التعليم في المراحل الابتدائية والثانوية والجامعية", "", "" },
                    { 337, null, "R144.172", "172.144", "", "Non réalisé", "", 0, 4, 1, null, 79, 14, null, "Examen périodique universal", "Prendre des mesures supplémentaires dans le domaine de la promotion des droits économiques, sociaux et culturels, notamment dans le secteur de l’éducation, en mettant un accent particulier sur la scolarisation des filles et des garçons dans les zones rurales", "القيام بخطوات أخرى في مجال تعزيز الحقوق الاقتصادية والاجتماعية والثقافية وخاصة في قطاع التعليم مع التركيز بوجه خاص على تسجيل فتيات وفتيان الأرياف في المدارس", "", "" },
                    { 338, null, "R144.173", "173.144", "", "Non réalisé", "", 0, 4, 1, null, 5, 14, null, "Examen périodique universal", "Soutenir le droit à l’éducation en mettant en œuvre la vision stratégique pour réformer le système éducatif sur la période 2015-2030", "دعم الحق في التعليم عن طريق تنفيذ الرؤية الاستراتيجية لنظام التعليم للفترة ما بين عامي 2015 و2030", "", "" },
                    { 339, null, "R144.174", "174.144", "", "Non réalisé", "", 0, 4, 1, null, 88, 14, null, "Examen périodique universal", "Renforcer et appuyer la promotion de l’éducation des enfants économiquement vulnérables", "دعم تشجيع التعليم لفائدة الأطفال ضعيفي الحالة الاقتصادية", "", "" },
                    { 340, null, "R144.175", "175.144", "", "Non réalisé", "", 0, 4, 1, null, 33, 14, null, "Examen périodique universal", "Poursuivre les efforts pour veiller à ce que tous les enfants soient inscrits à l’école élémentaire et étudier les mesures nécessaires pour toucher les enfants privés d’éducation", "مواصل�� الجهود لضمان تسجيل جميع الأطفال في المدرسة الابتدائية والنظر في اتخاذ التدابير الضرورية لمساعدة الأطفال المحرومين من التعليم", "", "" },
                    { 341, null, "R144.176", "176.144", "", "Non réalisé", "", 0, 4, 1, null, 87, 14, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir le droit à l’éducation en luttant contre le phénomène de l’abandon scolaire", "مواصلة الجهود من أجل تعزيز الحق في التعليم عن طريق مكافحة ظاهرة تسرب الأطفال من المدارس", "", "" },
                    { 342, null, "R144.177", "177.144", "", "Non réalisé", "", 0, 4, 1, null, 93, 14, null, "Examen périodique universal", "Poursuivre les efforts visant à réformer le système éducatif public et à améliorer la qualité de l’enseignement public pour instaurer l’égalité des chances entre les classes sociales", "مواصلة الجهود لإصلاح نظام التعليم العام وتحسين نوعية التعليم العام توخياً لتحقيق المساواة في الفرص بين الطبقات الاجتماعية", "", "" },
                    { 343, null, "R144.178", "178.144", "", "Non réalisé", "", 0, 4, 1, null, 94, 14, null, "Examen périodique universal", "Intensifier les efforts pour s’assurer que tous les enfants dont scolarisés aux niveaux primaire et secondaire", "زيادة الجهود المبذولة لضمان تسجيل جميع الأطفال في المدارس في المرحلتين الابتدائية والثانوية", "", "" },
                    { 717, null, "R33P2", "ت.33.ف.2", "", "Non réalisé", "", 0, 4, null, 6, null, 13, null, "Organes de traités", "Prendre des mesures temporaires spéciales, conformément au paragraphe 1 de l’article 4 de la Convention, pour s’assurer que les femmes rurales jouissent de leurs droits politiques, sociaux, économiques et culturels sans aucune discrimination, notamment en ce qui concerne l’accès à la santé.", "اتخاذ تدابير خاصة مؤقتة، على النحو المنصوص عليه في الفقرة 1 من المادة 4 من الاتفاقية، لكفالة تمتع المرأة الريفية بحقوقها السياسية والاجتماعية والاقتصادية والثقافية دونما تمييز، لا سيما فيما يتصل بالحق في والوصول إلى مرافق الرعاية الصحية.", "", "" },
                    { 716, null, "R31P1", "ت.31.ف.1", "", "Non réalisé", "", 0, 4, null, 6, null, 13, null, "Organes de traités", "Améliorer l’accès des femmes aux soins de santé primaires, notamment pour ce qui est de la santé procréative et des moyens de planification de la famille. Dans l’esprit de sa recommandation générale 24", "زيادة فرص حصول المرأة على خدمات الرعاية الصحية الأساسية، بما فيها رعاية الصحة الإنجابية ووسائل تنظيم الأسرة.", "", "" },
                    { 668, null, "R30P1", "ت.30ف.1", "", "Non réalisé", "", 0, 4, null, 5, null, 13, null, "Organes de traités", "-  Mettre en place des mesures effectives qui assurent aux travailleurs migrants et aux membres de leur famille, y compris ceux en situation irrégulière, l’accès aux soins médicaux d’urgence, ainsi qu’aux services sanitaires de base.", "اعتماد تدابير فعالة تكفل للعمال المهاجرين وأفراد أسرهم، بمن فيهم الموجودون في وضع غير قانوني، الحصول على الرعاية الطبية في حالات الطوارئ وعلى الخدمات الصحية الأساسية", "", "" },
                    { 637, null, "R46P1", "ت.46.ف.1", "", "Non réalisé", "", 0, 4, null, null, null, 13, null, "Organes de traités", "-            - Fournir à tous des installations, des services, des biens et des informations de qualité pour la santé sexuelle et procréative, en particulier dans les zones rurales, en formant et en augmentant le nombre d’auxiliaires de santé et en sensibilisant les femmes et les hommes aux besoins de santé sexuelle et procréative", "-          تزويد الجميع، لا سيما في المناطق الريفية، بتجهيزات وخدمات وسلع ومعلومات ذات جودة لتوفير خدمات الصحة الجنسية والإنجابية، عن طريق تدريب المعاونين الصحيين وزيادة عددهم، وتوعية النساء والرجال باحتياجات الصحة الجنسية والإنجابية.", "", "" },
                    { 334, null, "R144.169", "169.144", "", "Non réalisé", "", 0, 4, 1, null, 64, 14, null, "Examen périodique universal", "Mettre en place une stratégie ou un plan d’action pour lutter contre l’analphabétisme", "وضع استراتيجية أو خطة عمل لمكافحة الأمية", "", "" },
                    { 768, null, "R57P1P3", "ت.57.ف.1.ف.3", "", "Non réalisé", "", 0, 4, null, 7, null, 13, null, "Organes de traités", @"Renvoyant à son Observation générale no 4 (2003) sur la santé et le développement de l’adolescent, le Comité demande instamment au Maroc:
                a) D’adopter une politique globale de la santé sexuelle et génésique des adolescents et de faire en sorte que l’éducation dans ce domaine fasse partie du programme scolaire obligatoire, une attention particulière devant être accordée à la prévention de la grossesse précoce et des infections transmises sexuellement;
                c) De faire face au phénomène de la consommation de drogues par les enfants et les adolescents, notamment en leur fournissant des informations précises et objectives et en leur permettant d’acquérir des compétences pratiques de façon à prévenir la consommation de substances toxiques (y compris le tabac et l’alcool), et de mettre en place des services de traitement de la toxicomanie et de réduction des risques qui soient accessibles et adaptés aux jeunes;", @"تشير اللجنة إلى تعليقها العام رقم 4(2003) بشأن صحة المراهقين ونموهم، وتحث الدولة الطرف على ما يلي:
                -  (أ) اعتماد سياسة شاملة في ميدان الصحة الجنسية والإنجابية للمراهقين، وضمان أن التثقيف في هذا المجال جزء من المقررات الدراسية الإلزامية، مع الاهتمام خاصة بالوقاية من الحمل المبكر والأمراض المنقولة جنسياً؛
                -  (ج) التصدي لظاهرة معاقرة الأطفال والمراهقين المخدرات بوسائل منها إمدادهم بمعلومات صحيحة وموضوعية وتعليمهم مهارات الحياة لتوقي تعاطيهم مواد الإدمان، بما فيها التبغ والكحول، واستحداث علاج لإدمان المخدرات ميسور وملائم للشباب وتوفير خدمات للحد من أضرارها", "", "" },
                    { 825, null, "R41", "ت.41", "", "Non réalisé", "", 0, 4, null, 8, null, 11, null, "Organes de traités", "Adopter des mesures pour faciliter l’acquisition des aides à la mobilité et des appareils et accessoires fonctionnels, notamment les technologies d’assistance, les aides humaines ou animalières et les services de médiateur, et de mettre en place des mesures concrètes visant à simplifier les procédures administratives s’appliquant aux exemptions fiscales et douanières spéciales accordées pour l’achat de véhicules automobiles adaptés.", "-      اعتماد تدابير لتيسير الحصول على ما يلزم من وسائل وأجهزة مساعدة على التنقل، بما في ذلك التكنولوجيات المساعدة والمساعدة البشرية والوسطاء، ووضع تدابير محددة لتبسيط الإجراءات الإدارية المطبقة بشأن الإعفاءات الجمركية والضريبية الخاصة الممنوحة لشراء المركبات الآلية المعدة للمقعدين.", "", "" },
                    { 765, null, "R59", "ت.59", "", "Non réalisé", "", 0, 4, null, 7, null, 11, null, "Organes de traités", @"Prendre toutes les mesures nécessaires, notamment des mesures de discrimination positives, pour faire face aux disparités économiques dont souffrent les régions rurales et les banlieues urbaines et qui font que des enfants ne jouissent pas de leurs droits sur un pied d’égalité avec les autres. 
                - Mesurer l’incidence des programmes de protection sociale et revoir ces programmes pour faire en sorte qu’ils soient durables et accessibles aux enfants les plus vulnérables et les plus défavorisés;
                - Songer à tenir des consultations ciblées avec les familles, les enfants et les organisations de la société civile qui s’occupent des droits de l’enfant sur la question de la pauvreté des enfants.", @"اتخاذ جميع التدابير اللازمة، بما فيها سياسات التمييز الإيجابي، لتضييق الفوارق الاقتصادية التي تضر بالمناطق الريفية وضواحي المدن والتي تؤدي بعدم تمتع الأطفال بحقوقهم على قدم المساواة. 
                - تقييم آثار برامج الضمان الاجتماعي ومراجعتها بحيث تكون مستدامة وميسّرة لأكثر الأطفال استضعافاً وحرماناً.
                - النظر في عقد مشاورات محددة الغرض مع الأسر والأطفال ومنظمات المجتمع المدني المعنية بحقوق الأطفال لمعالجة قضية فقر الأطفال", "", "" },
                    { 763, null, "R75P1P2P3", "ت.75.ف.1.ف.2.ف.3", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", @"Mettre le système de justice pour mineurs en totale conformité avec la Convention, en particulier avec les articles 37, 39 et 40, ainsi qu’avec d’autres normes applicables et avec l’Observation générale no 10 (2007) du Comité sur les droits de l’enfant dans le système de justice pour mineurs, en particulier:
                a) Veiller à ce que la détention, notamment la détention avant jugement, soit une mesure de dernier recours appliquée pour la période la plus courte possible, même en cas d’infraction très grave et qu’elle fasse l’objet d’un réexamen régulier en vue de sa levée;
                b) Faire en sorte que les enfants en conflit avec la loi bénéficient d’une aide juridictionnelle compétente et indépendante dès le début de la procédure, y compris en cas de flagrant délit;
                C)  Promouvoir des mesures de substitution à la détention telles que la déjudiciarisation, la probation, la médiation, l’accompagnement psychologique et les travaux d’intérêt général, chaque fois que cela est possible;", @"تحث اللجنة المملكة لمغربية على التوفيق التام بين نظامها لعدالة الأحداث والاتفاقية، لا سيما المواد 37 و39 و40، وكذلك مع معايير أخرى متصلة بالموضوع ومع تعليق اللجنة العام رقم 10(2007) بشأن حقوق الطفل في قضاء الأحداث. وتحثها خاصة على الآتي:
                - (أ) ضمان عدم اللجوء إلى الاحتجاز، بما فيه الاحتجاز السابق للمحاكمة، إلا عند الضرورة القصوى ولأقصر مدة ممكنة، حتى عن الجرائم الخطرة جداً، وإعادة النظر فيه بانتظام للتخلي عنه؛
                - (ب) ضمان تقديم مساعدة قانونية مؤهلة ومستقلة للأطفال الجانحين في مرحلة مبكرة من الدعوى وطوال الإجراءات القانونية، حتى في حالات التلبس بالجريمة؛
                - (ج) تشجيع التدابير البديلة للاحتجاز ما أمكن، مثل عدم اللجوء إلى القضاء أو الإفراج تحت المراقبة أو الوساطة أو التوجيه أو الخدمة المجتمعية؛", "", "" },
                    { 762, null, "R57P2", "ت.57.ف.2", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", "b)       De dépénaliser l’avortement et de revoir sa législation en vue de garantir l’intérêt supérieur des adolescentes enceintes, et de faire en sorte que, par la loi et dans la pratique, les opinions de l’enfant soient toujours entendues et respectées dans les décisions relatives à l’avortement;", @"تشير اللجنة إلى تعليقها العام رقم 4(2003) بشأن صحة المراهقين ونموهم، وتحث الدولة الطرف على ما يلي:
                - (ب) رفع الصفة الجرمية عن الإجهاض ومراجعة تشريعاتها بحيث تكفل المصالح الفضلى للمراهقات الحوامل، واتخاذ الإجراءات القانونية والعملية لضمان الاستماع إلى آراء الطفل واحترامها دائماً عندما يتعلق الأمر بقرارات الإجهاض", "", "" },
                    { 761, null, "R57P2", "ت.57.ف.2", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", "Renvoyant à son Observation générale no 4 (2003) sur la santé et le développement de l’adolescent, le Comité demande instamment au Maroc:", @"تشير اللجنة إلى تعليقها العام رقم 4(2003) بشأن صحة المراهقين ونموهم، وتحث الدولة الطرف على ما يلي:
                - (ب) رفع الصفة الجرمية عن الإجهاض ومراجعة تشريعاتها بحيث تكفل المصالح الفضلى للمراهقات الحوامل، واتخاذ الإجراءات القانونية والعملية لضمان الاستماع إلى آراء الطفل واحترامها دائماً عندما يتعلق الأمر بقرارات الإجهاض", "", "" },
                    { 760, null, "R47P1", "ت.47.ف.1", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", "Abroger l’article 490 du Code pénal de façon à assurer aux mères célibataires le soutien dont elles ont besoin pour s’occuper de leurs enfants,", "-          إلغاء المادة 490 من القانون الجنائي، وتقديم الدعم اللازم للأمهات غير المتزوجات لإقدارهن على رعاية أطفالهن،", "", "" },
                    { 759, null, "R45", "ت.45", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", @"Revoir la loi provisoire sur le statut personnel pour faire en sorte que toutes ses dispositions qui sont discriminatoires à l’égard des femmes et des filles et qui nuisent à leurs enfants, telles que celles qui autorisent la polygamie, soient abrogées. 
                - Eliminer toute forme de discrimination à l’égard des enfants nés d’un mariage entre une musulmane et un non-musulman conformément à sa Constitution.", "تنقيح مدونة الأحوال الشخصية المؤقتة وضمان إلغاء جميع الأحكام التي تنطوي على تمييز في حق النساء والفتيات وتؤثر سلباً في أطفالهن، كتلك التي تجيز تعدد الزوجات. وتحثها أيضاً على القضاء على كل أشكال التمييز في حق الأطفال المولودين من زواج بين مسلمة وغير مسلم، عملاً بالدستور", "", "" },
                    { 758, null, "R25P1P2", "ت.25.ف.1.ف.2", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", @"a) prendre sans délai des mesures pour modifier le paragraphe 7 de l’article 16 de la loi n° 37-99 et de retirer des documents d’identité toute mention qui permettrait d’identifier des enfants comme nés hors mariage;
                b) abroger toutes les dispositions qui sont discriminatoires à l’égard des filles et des enfants nés hors mariage, en particulier dans le Code de la famille;", @"(أ) التعجيل بتعديل الفقرة 7 من المادة 16 من القانون رقم 37-99، وحذف أي إشارة في وثائق الهوية تؤدي إلى تحديد هوية الأطفال على أنهم وُلِدوا خارج إطار الزواج؛ 
                - (ب) إلغاء جميع الأحكام القانونية، ولا سيما تلك الواردة في مدونة الأسرة التي تنطوي على تمييز في حق الفتيات والفتيان المولودين خارج إطار الزواج؛", "", "" },
                    { 757, null, "R69P1", "ت.69.ف.1", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", "Adopter la législation contre la traite et faire en sorte qu’elle soit pleinement adaptée aux spécificités de la traite des enfants", "-          اعتماد تشريعات عن الاتجار وضمان أنها تعالج خصوصيات الاتجار بالأطفال وتتصدى لها. وينبغي للدولة الطرف أن تتخذ أيضاً تدابير حازمة لوضع حد لإفلات المتجرين بالأطفال من العقاب.", "", "" },
                    { 756, null, "R51P1", "ت.51.ف.1", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", "a) modifier sa législation régissant le système de la kafalah en vue de la rendre pleinement conforme à la Convention", "-          (أ) تعديل التشريعات التي تحكم نظام الكفالة بحيث تتقيد كلياً بالاتفاقية؛", "", "" },
                    { 714, null, "R45P2", "ت.45.ف.2", "", "Non réalisé", "", 0, 3, null, 6, null, 10, null, "Organes de traités", "Adopter une législation nationale relative aux réfugiés qui soit conforme à la Convention relative au statut des réfugiés et à son Protocole.", @"اعتماد تشريع وطني للاجئين، امتثالا للاتفاقية المتعلقة بمركز اللاجئين والبروتوكول الملحق بها. 
                السماح للاجئين وملتمسي اللجوء بإمكانية الحصول على الخدمات العامة، وتوفير تصاريح عمل لأولئك اللاجئين وملتمسي اللجوء الذين لديهم وثائق، وأن تكفل حقهم في الأمن، لا سيما بالنسبة إلى النساء والأطفال", "", "" },
                    { 713, null, "R41", "ت.41", "", "Non réalisé", "", 0, 3, null, 6, null, 10, null, "Organes de traités", "Modifier sans délai toute disposition du Code de la nationalité portant atteinte aux droits des femmes afin de l’harmoniser avec la Convention et s’acquitter de cette tâche en consultation avec des organisations féminines.", "-القيام دون إبطاء بتعديل جميع النصوص التمييزية التي تؤثر على حقوق المرأة، والواردة في مدونة الجنسية، لمواءمتها مع الاتفاقية على نحو تام. وتحــث اللجنة الدولة الطرف على القيـام بتلك المهمة بالتشاور مع المنظمات النسائيـة.", "", "" },
                    { 712, null, "R39", "ت.39", "", "Non réalisé", "", 0, 3, null, 6, null, 10, null, "Organes de traités", @"Assurer l’égalité entre les hommes et les femmes dans le mariage et en cas de dissolution du mariage, en donnant aux femmes des droits égaux dans le mariage et dans les relations familiales. 
                - Modifier sans délai toutes les dispositions du Code de la famille discriminatoires à l’égard des femmes, notamment celles portant sur le divorce, la garde et la tutelle des enfants et la succession. 
                - Promulguer des dispositions législatives pour faire en sorte qu’en cas de dissolution du mariage, les femmes aient des droits égaux sur les biens acquis pendant le mariage, conformément à l’alinéa h) du paragraphe 1 de l’article 16 de la Convention et à la recommandation générale 21 du Comité.
                - Opérer ces modifications en consultation avec des organisations féminines", @"كفالة المساواة بين المرأة والرجل خلال الزواج وبعد فسخه من خلال كفالة المساواة بينهما خلال الزواج وفي العلاقات الأسرية. 
                -تعديل جميع ما تبقى من أحكام تمييزية، بما في ذلك الأحكام المتصلة بالطلاق وحضانة الأطفال والوصاية القانونية عليهم والميراث. 
                - وضع نصوص قانونية تكفل أن يكون للمرأة، بعد فسخ الزواج، نفس الحقوق التي يتمتع بها الرجل بالنسبة للممتلكات التي تمت حيازتها خلال الزواج، تمشيا مع الفقرة 1 (ح) من المادة 16 من الاتفاقية والتوصية العامة رقم 21 للجنة. وتشجــع اللجنة الدولة الطرف على إجراء تلك التعــديلات بالتشاور مع المنظمات النسائية.", "", "" },
                    { 711, null, "R37", "ت.37", "", "Non réalisé", "", 0, 3, null, 6, null, 10, null, "Organes de traités", "Modifier le Code de la famille afin d’interdire la polygamie, institution qui contrevient au droit des femmes à l’égalité avec les hommes. Il exhorte en outre l’État partie à éliminer du Code toute autre trace de discrimination à l’égard des femmes.", @"في ضوء توصيتها العامة 21، تحث اللجنة الدولة الطرف على تعديل مدونة الأسرة بها لحظر تعدد الزوجات، حيث أنه يتناقض مع حق المرأة في المساواة مع الرجل. 
                -تحث الدولة الطرف على القضاء على أي تمييز آخر ضد النساء مما قد يكون باقيا في تلك المدونة.", "", "" },
                    { 710, null, "R13P1P2", "ت.13.ف.1.ف.2", "", "Non réalisé", "", 0, 3, null, 6, null, 10, null, "Organes de traités", @"Définir clairement le statut des conventions internationales dans son cadre législatif interne, en garantissant la primauté des instruments internationaux, dont la Convention, sur la législation nationale 
                - Veiller à ce que les dispositions de son droit interne soient conformes à ces instruments", @"تحديد مركز الاتفاقيات الدولية بوضوح ضمن الإطار القانوني المحلي، وإعطاء الأولوية للصكوك الدولية، بما فيها الاتفاقية، على التشريعات الوطنية، 
                -كفالة اتساق التشريعات الوطنية مع الصكوك الدولية.", "", "" },
                    { 667, null, "R36", "ت.36", "", "Non réalisé", "", 0, 3, null, 5, null, 10, null, "Organes de traités", @"Se conformer, dans le projet de loi sur les travailleurs domestiques, aux dispositions de la Convention, et de prendre en compte les éléments prévus dans l’observation générale no 1 (2010) du Comité sur les travailleurs domestiques migrants, à savoir :
                a) Des inspections du travail pour surveiller les conditions de travail des travailleurs domestiques migrants ;
                b) L’imposition de sanctions et autres pénalités aux employeurs qui exploitent des travailleurs domestiques migrants ou qui les soumettent au travail forcé et leur infligent des sévices, en particulier dans le cadre de l’économie informelle ;
                c) L’accès à des mécanismes efficaces pour porter plainte contre les employeurs et obtenir que ceux qui sont responsables de pratiques abusives soient poursuivis et sanctionnés.", @"الامتثال لأحكام الاتفاقية في مشروع القانون المتعلق بالعمال المنزليين والأخذ بعين الاعتبار العناصر المنصوص عليها في تعليق اللجنة العام رقم 1(2010) بشأن العمال المنزليين المهاجرين، وعلى وجه التحديد العناصر التالية:
                 (أ) إجراء عمليات تفتيش العمل لمراقبة ظروف عمل العمال المنزليين المهاجرين؛
                (ب) فرض عقوبات وجزاءات أخرى على أصحاب العمل الذين يستغلون العمال المنزليين المهاجرين أو الذين يُخضعونهم للعمل الجبري ويسيئون معاملتهم، لا سيما في إطار الاقتصاد غير المنظَّم؛
                (ج) إتاحة الوصول إلى آليات فعالة لتقديم شكاوى ضد أصحاب العمل وكفالة مقاضاة المسؤولين عن الممارسات المؤذية ومعاقبتهم.", "", "" },
                    { 666, null, "R10P1", "ت.10.ف1", "", "Non réalisé", "", 0, 3, null, 5, null, 10, null, "Organes de traités", "Prendre les mesures pour mettre en harmonie la loi no 02-03 avec les dispositions de la Convention, en vue d’étendre la protection des droits consacrés dans la Convention à tous les travailleurs migrants et aux membres de leur famille dans l’État partie.", ". اتخاذ تدابير لمواءمة القانون رقم 2-3 مع أحكام الاتفاقية، بغية توسيع نطاق حماية الحقوق المكرسة في الاتفاقية ليشمل جميع العمال المهاجرين وأفراد أسرهم في الدولة الطرف.", "", "" },
                    { 630, null, "R46P2", "ت.46.ف.2", "", "Non réalisé", "", 0, 3, null, null, null, 10, null, "Organes de traités", "-            Abroger la 9 concernant l’interdiction totale de l’avortement afin d’adopter une 9 compatible avec les droits de la femme et de prendre des mesures pour prévenir les avortements dangereux.", "-          إلغاء التشريع المتعلق بالحظر الكامل للإجهاض تمهيداً لاعتماد تشريعات تتماشى مع حقوق المرأة وباتخاذ تدابير لمنع الإجهاض غير المأمون.", "", "" },
                    { 629, null, "R40", "ت.40", "", "Non réalisé", "", 0, 3, null, null, null, 10, null, "Organes de traités", @"Amender le projet de loi pour fixer l’âge minimum de mariage à 18 ans. 
                - Abroger l’article 20 du Code de la famille, qui permet au juge d’autoriser un mariage avant l’âge légal de 18 ans.
                - Veiller à ce que le mariage soit contracté avec le libre consentement des futurs époux.", @"تعديل مشروع القانون لتحديد الثامنة عشرة سناً دُنيا للزواج،
                -  إلغاء المادة 20 من قانون الأسرة التي تجيز للقاضي إعطاء الإذن بالزواج قبل السن القانونية المحددة، وهي سن 18 عاماً، 
                - الحرص على أن يعقد الزواج برضا الطرفين رضا لا إكراه فيه.", "", "" },
                    { 628, null, "R34P1", "ت.34.ف.1", "", "Non réalisé", "", 0, 3, null, null, null, 10, null, "Organes de traités", "-            Réviser l’article 288 du Code pénal, conformément à l’article 8 du Pacte, et de faciliter la constitution des syndicats.", "-          تنقيح المادة 288 من القانون الجنائي وفقاً للمادة 8 من العهد، وتيسير تكوين النقابات.", "", "" },
                    { 627, null, "R10P1", "ت.10.ف.1", "", "Non réalisé", "", 0, 3, null, null, null, 10, null, "Organes de traités", "-            Prendre les mesures nécessaires pour donner effet au Pacte dans l’ordre juridique interne.", "-          اتخاذ التدابير اللازمة لتطبيق العهد في النظام القانوني الداخلي", "", "" },
                    { 592, null, "R44", "ت.44", "", "Non réalisé", "", 0, 3, null, 3, null, 10, null, "Organes de traités", "Réviser toutes les dispositions pertinentes du Code pénal pour les rendre conformes à l’article 19 du Pacte et veiller à ce que les restrictions à l’exercice de la liberté d’expression et d’association soient conformes aux prescriptions strictes du paragraphe 3 de l’article 19.", "-          تنقيح جميع أحكام القانون الجنائي المتصلة بالموضوع بحيث تتوافق مع المادة 19 من العهد، والحرص على تَوافُق القيود المفروضة على حرية التعبير وتكوين الجمعيات مع الشروط الصارمة التي تنص عليها الفقرة 3 من المادة 19.", "", "" },
                    { 591, null, "R36P1P7", "ت.36.ف.1ف.7", "", "Non réalisé", "", 0, 3, null, 3, null, 10, null, "Organes de traités", @"a) accélérer le processus de révision du cadre juridique régissant la migration et l’asile pour le rendre conforme aux dispositions du Pacte, y compris l’adoption du projet de loi no 26-14 ;
                 f) lever les barrières juridiques à l’enregistrement des nouveau-nés et à la reconnaissance des mariages entre réfugiés et demandeurs d’asile, réviser le Code de la nationalité de 2007 pour garantir la transmission de la nationalité à tous les enfants nés au Maroc", @"(أ) تسريع عملية تنقيح الإطار القانوني الذي ينظم الهجرة واللجوء لجعله يتوافق مع أحكام العهد، بما في ذلك اعتماد مشروع القانون رقم 26-14؛ 
                - (و) إزالة الحواجز القانونية أمام تسجيل المواليد والاعتراف بالزواج بين اللاجئين وملتمسي اللجوء، وتنقيح قانون الجنسية لعام 2007 بحيث يكفل نقل الجنسية إلى جميع الأطفال المولودين في المغرب", "", "" },
                    { 590, null, "R32", "ت.32", "", "Non réalisé", "", 0, 3, null, 3, null, 10, null, "Organes de traités", "Réviser la 9 pour faire en sorte que l’emprisonnement ne soit en aucun cas utilisé comme moyen d’assurer l’exécution d’obligations contractuelles.", "تنقيح التشريعات بحيث لا يستخدم السجن وسيلةً لإنفاذ الالتزامات التعاقدية.", "", "" },
                    { 589, null, "R22P1", "ت.22.ف.1", "", "Non réalisé", "", 0, 3, null, 3, null, 10, null, "Organes de traités", "Accélérer la révision de la 9 afin d’introduire d’autres exceptions à l’interdiction de l’avortement, notamment lorsque la grossesse résulte d’un viol ou d’un inceste ou lorsque le fœtus présente des malformations mortelles, et veiller à ce que les femmes ne soient pas conduites, du fait de restrictions dans la 9, à recourir à des avortements clandestins qui mettent en danger leur vie et leur santé.", "-          تسريع تنقيح التشريعات  من أجل إدراج استثناءات إضافية من حظر الإجهاض، ومن جملتها عندما يكون الحمل نتيجة اغتصاب أو سفاح أو عندما يعاني الجنين من تشوهات فتاكة، وأن تحرص على ألا تُضطر النساء، بسبب القيود التي تنص عليها التشريعات، إلى اللجوء إلى الإجهاض السري الذي يعرض حياتهن وصحتهن للخطر.", "", "" },
                    { 588, null, "R18P1P2", "ت.18.ف.1.ف2", "", "Non réalisé", "", 0, 3, null, 3, null, 10, null, "Organes de traités", @"réviser les dispositions du Code pénal relatives au terrorisme et définir les infractions liées au terrorisme en fonction de leur objet mais aussi définir la nature de ces actes avec suffisamment de précision 
                - veiller à ce que cette 9 n’impose pas de restriction injustifiée à l’exercice des droits consacrés par le Pacte", @"مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب، وتحديد الجرائم المتصلة بالإرهاب من حيث موضوعها، وأيضاً تحديد طبيعة هذه الأعمال بما يكفي من الدقة، 
                - التأكد من أن ذلك التشريع لا يفرض قيوداً لا مبرر لها على ممارسة الحقوق التي يكرسها العهد.", "", "" },
                    { 587, null, "R16P1", "ت.16.ف.1", "", "Non réalisé", "", 0, 3, null, 3, null, 10, null, "Organes de traités", "a) Amender rapidement la 9 nationale en vue de garantir la protection adéquate des femmes contre la violence et le harcèlement sexuel ;", "-           (أ) التسريع بتعديل التشريعات الوطنية لتوفير الحماية المناسبة للنساء من العنف والتحرش الجنسي؛", "", "" },
                    { 586, null, "R14P1P3", "ت.14.ف.1.ف.3", "", "Non réalisé", "", 0, 3, null, 3, null, 10, null, "Organes de traités", @"a) Abroger ou modifier toutes les dispositions discriminatoires envers les femmes afin de donner plein effet au principe d’égalité consacré par la Constitution ;
                 c) Réviser les dispositions légales permettant de déroger à l’âge minimum du mariage.", @"(أ) إلغاء أو تعديل جميع الأحكام التي تنطوي على تمييز في حق المرأة من أجل إعمال مبدأ المساواة الذي يكرسه الدستور إعمالاً تاماً؛ 
                - (ب) واتخاذ التدابير المناسبة للحد من تعدد الزوجات قصد إلغاء هذه الممارسة؛ 
                - (ج) وتنقيح الأحكام القانونية التي تجيز الاستثناءات من الحد الأدنى لسن الزواج.", "", "" },
                    { 585, null, "R6P2", "ت.6.ف.2", "", "Non réalisé", "", 0, 3, null, 3, null, 10, null, "Organes de traités", "Accélérer la réforme législative visant à garantir la pleine conformité du droit interne avec les traités internationaux dûment ratifiés", "تسريع الإصلاح التشريعي الذي يهدف إلى جعل القانون المحلي يتوافق كلياً مع المعاهدات الدولية التي صدقت عليها وفق الأصول؛", "", "" },
                    { 818, null, "R7", "ت.7", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "Harmoniser et actualiser les définitions du handicap énoncées dans ses diverses lois et politiques et de les rendre conformes à l’approche axée sur les droits de l’homme consacrée par la Convention.", "-      مواءمة وتحديث تعريف الإعاقة في مختلف القوانين والسياسات وجعلها تتماشى مع نموذج حقوق الإنسان في تناول مسألة الإعاقة المنصوص عليه في الاتفاقية.", "", "" },
                    { 819, null, "R9P1", "ت.9.ف.1", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "Réviser la loi-cadre n° 97-13 pour la rendre conforme à la Convention……… Préciser le délai d’entrée en vigueur de cette loi", "-       (أ) تنقيح القانون الإطار 97-13 لجعله يتماشى مع الاتفاقية ......ء، وتحديد الإطار الزمني لدخول القانون حيز النفاذ؛", "", "" },
                    { 820, null, "R15 P3", "ت.15.ف.3", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "b) Réviser le projet de loi no 103-13 relatif à la lutte contre la violence à l’égard des femmes de sorte qu’il tienne compte de la question du handicap, des risques particuliers de violence sexiste auxquels sont exposées les femmes et les filles handicapées, en particulier les femmes qui présentent un handicap psychosocial ou intellectuel, et des obstacles à la protection de ces femmes contre la violence sexiste ;", "-       (ج) تنقيح مشروع القانون 103-13 المتعلق بمحاربة العنف ضد النساء، بهدف تضمينه منظور الإعاقة ومعالجة المخاطر المحددة التي ينطوي عليها العنف الجنساني والحواجز التي تحول دون حماية النساء والفتيات ذوات الإعاقة، ولا سيما النساء ذوات الإعاقة النفسية - الاجتماعية و/أو العقلية؛", "", "" },
                    { 821, null, "R27P1", "ت.27.ف.1", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "a) Abroger les dispositions du Code de la famille et d’autres textes de loi qui limitent la personnalité juridique des personnes handicapées, en particulier des personnes qui présentent un handicap psychosocial ou intellectuel", @"تماشياً مع التعليق العام رقم 1(2014) بشأن الاعتراف بالأشخاص ذوي الإعاقة على قدم المساواة مع الآخرين أمام القانون، توصي اللجنة بما يلي:‬
                -  (أ) إلغاء ما ورد في مدونة الأسرة وفي قوانين أخرى من أحكام تقيد الأهلية القانونية للأشخاص ذوي الإعاقة، ولا سيما الأشخاص ذوي الإعاقة النفسية - الاجتماعية و/أو العقلية؛", "", "" },
                    { 764, null, "R51P2", "ت.51.ف.2", "", "Non réalisé", "", 0, 4, null, 7, null, 11, null, "Organes de traités", "b) Empêcher le placement automatique d’enfants nés hors mariage et d’enfants vivant dans la pauvreté sous le régime de la kafalah en fournissant aux mères célibataires et/ou aux parents le soutien nécessaire pour qu’ils puissent prendre en charge leurs enfants;", "-           (ب) منع الكفالة التلقائية للأطفال غير المولودين خارج إطار الزواج والأطفال الفقراء عن طريق إمداد الأمهات غير المتزوجات و/أو الوالدين بما يلزم من دعم لرعاية أطفالهم؛", "", "" },
                    { 715, null, "R43", "ت.43", "", "Non réalisé", "", 0, 4, null, 6, null, 11, null, "Organes de traités", "Prendre des mesures, dans le cadre de ses efforts d’intégration de la problématique hommes-femmes et de son Initiative nationale pour le développement humain, pour remédier à la vulnérabilité des femmes démunies, notamment en garantissant leur représentation dans les instances participatives qui gèrent les programmes de réduction de la pauvreté. Il exhorte l’État partie à recourir à cet effet à des mesures temporaires spéciales au titre du paragraphe 1 de l’article 4.", "اتخاذ تدابير من خلال الجهود المبذولة في مجال التعميم، وفي المبادرة الوطنية للتنمية البشرية، لمعالجة تعرض المرأة على وجه التحديد لمخاطر الفقر، ومن بينها الجهود الرامية لكفالة تمثيل المرأة في النُهج التشاركية المتبعة في إدارة برامج تخفيف حدة الفقر. وتحث اللجنة الدولة الطرف على أن تستخدم في هذا الصدد التدابير الخاصة المؤقتة عملا بالفقرة 1 من المادة 4 من الاتفاقية والتوصية العامة رقم 25.", "", "" },
                    { 634, null, "R42", "ت.42", "", "Non réalisé", "", 0, 4, null, null, null, 11, null, "Organes de traités", "-            Intensifier les efforts pour réduire la pauvreté, notamment en utilisant une stratégie de réduction de la pauvreté fondée sur les droits de l’homme qui cible spécifiquement les besoins des individus et des groupes défavorisés et marginalisés, en allouant des ressources financières suffisantes ou autres ressources pour sa mise en œuvre et en veillant à ce que ces ressources soient équitablement réparties entre tous ceux touchés par la pauvreté.", @"تكثيف الجهود للحد من الفقر بطرق خاصة منها وضع استراتيجية للحد من الفقر تقوم على حقوق الإنسان وتركز تحديداً على احتياجات المحرومين والمهمشين، أفراداً وجماعات، وذلك بتخصيص ما يكفي من الموارد المالية وغير المالية لتنفيذ هذه الاستراتيجية، 
                - الحرص على توزيع هذه الموارد توزيعاً عادلاً بين جميع ضحايا الفقر.
                - وفي هذا الصدد، تحيل اللجنة الدولة الطرف إلى بيانها بشأن الفقر والعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية (2001).", "", "" },
                    { 633, null, "R36", "ت.36", "", "Non réalisé", "", 0, 4, null, null, null, 11, null, "Organes de traités", @"Continuer le déploiement du système de sécurité sociale afin de parvenir à une couverture élargie de la population. 
                - Faire respecter l’obligation d’affiliation à la sécurité sociale par les entreprises privées, surtout en milieu rural, et d’améliorer la couverture sociale des salariés du secteur agricole tout en s’assurant que ces mesures se basent sur des institutions solides et des procédures accessibles à tous.", @"مواصلة توسيع نطاق نظام الضمان الاجتماعي من أجل زيادة عدد السكان المشمولين به. 
                - ضمان التزام الشركات الخاصة بالانخراط في مؤسسات الضمان الاجتماعي، ولا سيما في المناطق الريفية، 
                - تحسين التغطية الاجتماعية للعاملين في القطاع الزراعي مع ضمان الاستناد في هذه التدابير إلى مؤسسات راسخة وإجراءات تكون في متناول الجميع. 
                توجه اللجنة نظر الدولة الطرف إلى تعليقها العام رقم 19(2007) بشأن الحق في الضمان الاجتماعي وإلى إعلانها المتعلق بالأرضيات الوطنية للحماية الاجتماعية (2015).", "", "" },
                    { 632, null, "R26", "ت.26", "", "Non réalisé", "", 0, 4, null, null, null, 11, null, "Organes de traités", @"Garantir que le salaire minimum national s’applique à tous les secteurs, publics et privés, y compris au sein de l’économie informelle. 
                - Améliorer le salaire minimum agricole afin qu’il garantisse une existence décente aux travailleurs et aux membres de leur famille. 
                - Faire respecter le principe légal de salaire minimum, qui soit régulièrement réexaminé et fixé à un montant suffisant pour permettre à tous les travailleurs et travailleuses et aux membres de leur famille d ’avoir un niveau de vie décent.", @"ضمان تطبيق الحد الأدنى الوطني للأجور في جميع القطاعات، العام منها والخاص، بما في ذلك في الاقتصاد غير النظامي.
                - تحسين الحد الأدنى لأجر العامل الزراعي لكي يضمن العيش الكريم للعمال وأسرهم. 
                - ضمان الالتزام بمبدأ الحد الأدنى للأجر المقرر قانوناً ومراجعته بانتظام وتحديده عند مبلغ يكفي لتوفير مستوى عيش لائق لجميع العمال والعاملات ولأفراد أسرهم.", "", "" },
                    { 631, null, "R14P2P4", "ت.14.ف.2.ف.4", "", "Non réalisé", "", 0, 4, null, null, null, 11, null, "Organes de traités", @"Tenant en compte son observation générale no 20 (2009) sur la non-discrimination dans l’exercice des droits économiques, sociaux et culturels, le Comité appelle à :
                 b) Prendre toutes les mesures nécessaires pour remédier aux disparités régionales qui ne permettent pas à toute la population de jouir sur un pied d’égalité des droits économiques, sociaux et culturels.
                - d) Assurer que les femmes, les personnes handicapées, les demandeurs d’asile, les réfugiés, les migrants, les Sahraouis, les enfants nés hors mariage et les homosexuels puissent jouir des droits reconnus par le Pacte, en particulier l’accès à l’emploi, aux services sociaux, aux soins de santé et à l’éducation.", @"(ج) اتخاذ تدابير تكفل للأمازيغ التمتع كلياً بحقوقهم المنصوص عليها في العهد من خلال اعتماد تدابير خاصة مؤقتة عند الاقتضاء؛
                - - (ب) اتخاذ جميع التدابير التصحيحية اللازمة لمعالجة الفوارق بين الأقاليم التي تحول دون تمتع جميع السكان بالحقوق الاقتصادية والاجتماعية والثقافية على قدم المساواة؛
                - - (د) الحرص على تمكين النساء والأشخاص ذوي الإعاقة وملتمسي اللجوء واللاجئين والمهاجرين، والصحراويين والأطفال غير الشرعيين والمثليين من التمتع بحقوقهم المعترف بها في العهد، بما في ذلك إمكانية الحصول على العمل والخدمات الاجتماعية والرعاية الصحية والتعليم", "", "" },
                    { 320, null, "144.161", "161.144", "", "Non réalisé", "", 0, 4, 1, null, 25, 11, null, "Examen périodique universal", "Améliorer le système de protection sociale en vue d’étendre la couverture sociale et médicale à toute personne", "تحسين نظام الحماية الاجتماعية بهدف توسيع نطاق التغطية الاجتماعية والطبية لتشمل كل فرد", "", "" },
                    { 319, null, "R144.151", "151.144", "", "Non réalisé", "", 0, 4, 1, null, 33, 11, null, "Examen périodique universal", "Assurer une répartition équitable des ressources entre les zones rurales et les zones urbaines", "ضمان التوزيع المنصف للموارد بين الأرياف والحواضر", "", "" },
                    { 318, null, "R144.150", "150.144", "", "Non réalisé", "", 0, 4, 1, null, 15, 11, null, "Examen périodique universal", "Continuer d’adopter des mesures visant à améliorer la vie des personnes vulnérables dans le pays", "مواصلة اعتماد تدابير لتحسين عيشة ضعاف الحال في البلد", "", "" },
                    { 317, null, "R144.149", "149.144", "", "Non réalisé", "", 0, 4, 1, null, 88, 11, null, "Examen périodique universal", "Partager avec d’autres pays son expérience dans le domaine du développement humain et de la réduction de la pauvreté", "تبادل تجربته مع غيره في مجال التنمية البشرية والحد من الفقر", "", "" },
                    { 316, null, "R144.148", "148.144", "", "Non réalisé", "", 0, 4, 1, null, 68, 11, null, "Examen périodique universal", "Continuer de renforcer les programmes visant à réduire la pauvreté dans le cadre de l’Initiative nationale pour le développement humain", "مواصلة تقوية البرامج للحد من الفقر من خلال المبادرة الوطنية للتنمية البشرية", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 344, null, "R144.179", "179.144", "", "Non réalisé", "", 0, 4, 1, null, 13, 14, null, "Examen périodique universal", "Examiner et, le cas échéant, adapter les programmes scolaires et préscolaires et l’enseignement et les pratiques scolaires pour favoriser l’élimination de la discrimination fondée sur le sexe et des stéréotypes sexistes, ainsi que pour promouvoir l’autonomisation des filles à un âge précoce", "استعراض المناهج التعليمية وتكييفها عند الضرورة، وكذلك استعراض ممارسات التدريس والمدارس من أجل القضاء على التمييز القائم على نوع الجنس والقوالب النمطية القائمة على نوع الجنس إلى جانب تعزيز تمكين الفتيات منذ سن مبكرة", "", "" },
                    { 315, null, "R144.147", "147.144", "", "Non réalisé", "", 0, 4, 1, null, 78, 11, null, "Examen périodique universal", "Poursuivre les efforts pour réduire la pauvreté et combler l’écart de revenu entre les différentes régions et entre les zones rurales et les zones urbaines", "مواصلة الجهود الرامية إلى الحد من الفقر وسد الفارق في الدخل بين منطقة وأخرى وبين الأرياف والحواضر", "", "" },
                    { 824, null, "R39P3", "ت.39.ف.3", "", "Non réalisé", "", 0, 4, null, 8, null, 11, null, "Organes de traités", "D’adopter un plan aux niveaux national et régional pour développer, dans les zones urbaines et les zones rurales, des services de soutien communautaire qui comprennent, entre autres, l’assistance personnelle, les subventions et le soutien aux familles d’enfants handicapés et aux parents handicapés, notamment en ce qui concerne la fourniture d’appareils et d’accessoires fonctionnels, de guides et d’interprètes en langue des signes", "-       (ج) اعتماد خطة على الصعيدين الوطني والإقليمي لتطوير خدمات الدعم المجتمعية في المناطق الحضرية والريفية، ويشمل ذلك تقديم المساعدة الشخصية والمنح والدعم لأسر الأطفال ذوي الإعاقة والآباء ذوي الإعاقة، بما في ذلك تقديم الدعم اللازم لتوفير الأجهزة المعينة، والمرشدين ومفسري لغة الإشارة؛", "", "" },
                    { 314, null, "R144.146", "146.144", "", "Non réalisé", "", 0, 4, 1, null, 28, 11, null, "Examen périodique universal", "Poursuivre la mise en œuvre de politiques de lutte contre la pauvreté et de promotion du développement économique", "مواصلة تنفيذ السياسات الرامية إلى مكافحة الفقر وتشجيع التنمية الاقتصادية", "", "" },
                    { 312, null, "R144.144", "144.144", "", "Non réalisé", "", 0, 4, 1, null, 4, 11, null, "Examen périodique universal", "Continuer de promouvoir la consolidation de sa politique sociale et lutter contre la pauvreté et les inégalités, qui sont toujours présentes", "مواصلة تشجيع تكامل سياساته الاجتماعية ومكافحة الفقر وعدم المساواة اللذين لا يزالان موجودين", "", "" },
                    { 311, null, "R144.143", "143.144", "", "Non réalisé", "", 0, 4, 1, null, 78, 11, null, "Examen périodique universal", "Améliorer l’identification des bénéficiaires des régimes de protection sociale", "تحسين وسائل تحديد ذوي الأهلية للاستفادة من خطط الحماية الاجتماعية", "", "" },
                    { 310, null, "R144.140", "140.144", "", "Non réalisé", "", 0, 4, 1, null, 96, 11, null, "Examen périodique universal", "Allouer davantage de ressources à la mise en œuvre de politiques nationales en faveur des groupes sociaux vulnérables", "تخصيص مزيد من الموارد لتنفيذ السياسات الوطنية لصالح الفئات الاجتماعية الضعيفة", "", "" },
                    { 138, null, "R94", "null", "", "Non réalisé", "", 0, 4, null, null, null, 11, 4, "Procédure spéciale", "-    En sus des mesures juridiques et des politiques adoptées pour lutter contre la traite des êtres humains, des efforts devraient être faits pour remédier aux causes profondes de ce problème, notamment l’exclusion sociale, la pauvreté, les inégalités et la discrimination.", "null", "", "" },
                    { 46, null, "R73", "null", "", "Non réalisé", "", 0, 4, null, null, null, 11, 2, "Procédure spéciale", "-       Envisager l’adoption de mesures spéciales pour garantir aux groupes défavorisés, dans des conditions d’égalité, la pleine jouissance des droits de l’homme et des libertés fondamentales.", "null", "", "" },
                    { 10, null, "R96P3", "null", "", "Non réalisé", "", 0, 4, null, null, null, 11, 1, "Procédure spéciale", "Pour les provinces marocaines du sud : - Offrir à la population locale les mêmes possibilités d’éducation et d’emploi, en vue de réduire la pauvreté et d’assurer la sécurité alimentaire et nutritionnelle de tous, conformément au droit international.", "null", "", "" },
                    { 9, null, "R94", "null", "", "Non réalisé", "", 0, 4, null, null, null, 11, 1, "Procédure spéciale", "Pour les provinces marocaines du sud : - Adopter une stratégie de réduction de la pauvreté fondée sur les droits de l’homme qui cible spécifiquement les besoins des individus et des groupes défavorisés et marginalisés, en allouant des ressources financières suffisantes ou autres ressources pour sa mise en œuvre et en veillant à ce que ces ressources soient équitablement réparties entre tous ceux touchés par la pauvreté, conformément aux recommandations du Comité des droits économiques, sociaux et culturels.", "null", "", "" },
                    { 8, null, "R85", "null", "", "Non réalisé", "", 0, 4, null, null, null, 11, 1, "Procédure spéciale", "-   Revoir, examiner et modifier les politiques et les programmes concernant la réduction de la pauvreté afin que les préoccupations relatives au genre soient réellement prises en compte", "null", "", "" },
                    { 7, null, "R75", "null", "", "Non réalisé", "", 0, 4, null, null, null, 11, 1, "Procédure spéciale", "-   Faire des populations urbaines pauvres, des petits agriculteurs et des communautés côtières qui sont particulièrement vulnérables face aux effets des changements climatiques les premiers bénéficiaires des évaluations des vulnérabilités, ainsi que des ressources financières et de l’appui destinés à l’adaptation et à l’atténuation", "null", "", "" },
                    { 6, null, "R71", "null", "", "Non réalisé", "", 0, 4, null, null, null, 11, 1, "Procédure spéciale", "-   Élaborer des programmes visant à renforcer les organisations communautaires en leur dispensant les formations voulues et en leur offrant l’appui nécessaire pour les aider à assurer elles-mêmes leur développement et à diversifier les activités agricoles, afin de créer de nouvelles possibilités d’emploi.", "null", "", "" },
                    { 5, null, "R68", "null", "", "Non réalisé", "", 0, 4, null, null, null, 11, 1, "Procédure spéciale", "-   Affecter des ressources suffisantes à la mise en œuvre des mesures de réduction de la pauvreté énoncées dans l’Initiative nationale pour le développement humain, en accordant une attention particulière aux disparités structurelles en matière de mise en œuvre et en ciblant les besoins des personnes et des groupes désavantagés et marginalisés, en particulier de ceux vivant dans des zones reculées.", "null", "", "" },
                    { 823, null, "R45P3", "ت.45.ف.3", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "Modifier le Code de la famille afin de faire en sorte que les personnes présentant un handicap psychosocial ou intellectuel puissent exercer leur droit au mariage", "-       (ب)......وتعديل مدونة الأسرة لضمان تمتع الأشخاص ذوي الإعاقة النفسية - اجتماعية و/أو العقلية بالحق في الزواج.", "", "" },
                    { 822, null, "R31P1", "ت.31.ف.1", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "Abroger les dispositions qui prévoient la privation de liberté d’adultes et d’enfants handicapés en raison de leur handicap, de mettre un terme à cette pratique", "-      إلغاء الأحكام والممارسات التي تجيز حرمان الأشخاص ذوي الإعاقة، أطفالاً وبالغين، من حريتهم بسبب الإعاقة", "", "" },
                    { 313, null, "R144.145", "145.144", "", "Non réalisé", "", 0, 4, 1, null, 22, 11, null, "Examen périodique universal", "Poursuivre les efforts visant à protéger les droits économiques et sociaux par la mise en œuvre de programmes de lutte contre la pauvreté, dans le cadre de l’Initiative nationale de développement humain", "مواصلة الجهود من أجل حماية الحقوق الاقتصادية والاجتماعية عن طريق تنفيذ برامج مكافحة الفقر في إطار المبادرة الوطنية للتنمية البشرية", "", "" },
                    { 767, null, "R55", "ت.55", "", "Non réalisé", "", 0, 4, null, 7, null, 13, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 15 (2013) sur le droit de l’enfant de jouir du meilleur état de santé possible, et lui recommande:
                a) De veiller à ce que des ressources suffisantes soient allouées au secteur de la santé et d’élaborer et d’appliquer des politiques et des programmes complets pour améliorer l’état de santé des enfants et favoriser un accès plus large et dans des conditions d’égalité des mères et des enfants à des services de santé primaires de qualité dans toutes les régions du pays de façon à mettre fin aux disparités dans l’accès aux soins;
                b) De prendre des mesures plus efficaces pour lutter contre la mortalité liée à la maternité et infantile et améliorer le statut nutritionnel des jeunes enfants;
                c) Solliciter à cet égard une assistance financière et technique auprès, entre autres, du Fonds des Nations Unies pour l’enfance (UNICEF) et de l’Organisation mondiale de la Santé.", @"بشأن حق الطفل في التمتع بأعلى مستوى صحي يمكن بلوغه، وتوصيها بالآتي:
                - (أ) الحرص على تخصيص موارد كافية لقطاع الصحة واستخدامها بفاعلية، ووضع سياسات وبرامج شاملة وتنفيذها لتحسين الوضع الصحي للأطفال وتسهيل تلقي الأمهات والأطفال مزيداً من الخدمات الصحية الأولية الجيدة وعلى قدم المساواة مع غيرهم من الشرائح في جميع مناطق البلاد للحد من التفاوت في الحصول على الخدمات الصحية؛
                - (ب) اتخاذ تدابير أكثر لعالية للتقليل من وفيات الأمهات والرضع ومعالجة الوضع الغذائي للصغار؛
                - (ج) التماس المساعدة المالية والتقنية في هذا الصدد من جهات مثل اليونيسيف ومنظمة الصحة العالمية", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "DetailAr", "IdRapport", "IdUser" },
                values: new object[,]
                {
                    { 9, "necessitatibus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 68, 1 },
                    { 87, "sed", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 28, 1 },
                    { 83, "non", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 58, 2 },
                    { 62, "commodi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 4, 1 },
                    { 85, "dignissimos", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 4, 1 },
                    { 2, "quo", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 7, 1 },
                    { 12, "quia", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 42, 2 },
                    { 52, "voluptatem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 42, 1 },
                    { 81, "voluptatem", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 42, 2 },
                    { 17, "adipisci", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 60, 3 },
                    { 37, "consequatur", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 60, 1 },
                    { 47, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 60, 3 },
                    { 63, "eos", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 93, 1 },
                    { 57, "sit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 100, 3 },
                    { 99, "quis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 100, 1 },
                    { 100, "ea", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 100, 2 },
                    { 53, "omnis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 29, 3 },
                    { 35, "enim", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 18, 1 },
                    { 43, "nemo", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 80, 1 },
                    { 44, "itaque", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 16, 3 },
                    { 68, "quas", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 26, 2 },
                    { 82, "rem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 26, 2 },
                    { 6, "iste", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 79, 2 },
                    { 95, "aut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 84, 1 },
                    { 28, "iure", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 23, 2 },
                    { 93, "omnis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 84, 1 },
                    { 51, "quis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 90, 3 },
                    { 29, "eum", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 65, 2 },
                    { 58, "ab", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 65, 3 },
                    { 67, "voluptatum", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 65, 2 },
                    { 15, "illum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 10, 2 },
                    { 5, "cupiditate", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 53, 2 },
                    { 64, "molestiae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 53, 3 },
                    { 78, "vero", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 53, 1 },
                    { 18, "itaque", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 12, 1 },
                    { 46, "voluptate", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 12, 1 },
                    { 50, "ducimus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 12, 1 },
                    { 69, "dolores", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 52, 2 },
                    { 73, "harum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 89, 2 },
                    { 40, "beatae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 81, 3 },
                    { 60, "quisquam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 81, 2 },
                    { 75, "nam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 13, 3 },
                    { 39, "voluptatem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 17, 1 },
                    { 89, "optio", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 17, 1 },
                    { 16, "veniam", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 48, 1 },
                    { 45, "pariatur", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 63, 3 },
                    { 79, "eius", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 63, 3 },
                    { 84, "ut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 63, 3 },
                    { 31, "nulla", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 64, 1 },
                    { 23, "deserunt", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 27, 2 },
                    { 7, "veritatis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 87, 1 },
                    { 70, "ut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 97, 1 },
                    { 56, "consequatur", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 6, 2 },
                    { 91, "omnis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 6, 1 },
                    { 25, "ipsam", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 91, 2 },
                    { 27, "dolorum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 91, 3 },
                    { 13, "totam", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 44, 3 },
                    { 36, "nostrum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 39, 3 },
                    { 26, "nemo", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 36, 1 },
                    { 41, "veritatis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 36, 2 },
                    { 86, "non", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 36, 2 },
                    { 20, "esse", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 69, 2 },
                    { 10, "magnam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 8, 1 },
                    { 11, "vero", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 8, 3 },
                    { 61, "eos", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 8, 3 },
                    { 76, "possimus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 75, 1 },
                    { 32, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 61, 1 },
                    { 88, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 61, 3 },
                    { 59, "distinctio", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 3, 2 },
                    { 96, "maiores", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 71, 3 },
                    { 1, "id", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 82, 1 },
                    { 80, "nostrum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 86, 2 },
                    { 97, "corrupti", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 86, 3 },
                    { 54, "voluptatem", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 6, 1 },
                    { 55, "autem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 97, 3 },
                    { 8, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 21, 1 },
                    { 90, "est", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 9, 2 },
                    { 71, "necessitatibus", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 97, 1 },
                    { 14, "quos", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 1, 3 },
                    { 22, "corporis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 54, 2 },
                    { 49, "aperiam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 70, 2 },
                    { 72, "consequatur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 70, 2 },
                    { 74, "sed", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 30, 2 },
                    { 19, "molestias", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 67, 3 },
                    { 48, "aut", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 11, 1 },
                    { 65, "nostrum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 33, 2 },
                    { 33, "quam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 43, 3 },
                    { 42, "sunt", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 43, 3 },
                    { 24, "doloribus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 66, 1 },
                    { 38, "rerum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 66, 3 },
                    { 98, "dolores", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 25, 1 },
                    { 4, "aut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 32, 2 },
                    { 30, "cum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 32, 3 },
                    { 34, "quisquam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 49, 3 },
                    { 94, "libero", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 49, 3 },
                    { 77, "dicta", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 14, 1 },
                    { 66, "aut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 35, 1 },
                    { 21, "autem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 9, 2 },
                    { 92, "delectus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 9, 2 },
                    { 3, "repudiandae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 24, 1 }
                });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[,]
                {
                    { 7, "/utilize", 7, 87 },
                    { 1, "/bandwidth/sky-blue/berkshire", 5, 95 },
                    { 82, "/tanzanian-shilling/west-virginia/hack", 1, 95 },
                    { 41, "/one-to-one", 5, 85 },
                    { 61, "/quantifying/olive/bridge", 7, 85 },
                    { 86, "/parsing", 2, 2 },
                    { 33, "/home-beauty--jewelery", 5, 12 },
                    { 13, "/arkansas", 6, 81 },
                    { 14, "/integrate", 7, 81 },
                    { 37, "/automotive--tools/hollow", 2, 81 },
                    { 45, "/money-market-account", 7, 17 },
                    { 47, "/handmade-rubber-pants/invoice/taiwan", 7, 17 },
                    { 26, "/web", 1, 37 },
                    { 46, "/revolutionary/checking-account/intelligent-steel-salad", 3, 63 },
                    { 6, "/protocol", 7, 57 },
                    { 17, "/reboot/oklahoma", 6, 100 },
                    { 77, "/developer/kids-games--clothing/row", 6, 100 },
                    { 100, "/neural", 1, 53 },
                    { 11, "/orchid/connecting/moderator", 1, 35 },
                    { 79, "/manat/markets", 7, 35 },
                    { 84, "/european-unit-of-account-9e.u.a.-9/granite/brooks", 3, 43 },
                    { 64, "/cyan/buckinghamshire/transmitter", 4, 68 },
                    { 71, "/handmade-wooden-keyboard/compelling", 2, 93 },
                    { 98, "/payment", 4, 51 },
                    { 92, "/structure/checking-account/health--home", 3, 51 },
                    { 78, "/intelligent-concrete-chips", 5, 84 },
                    { 44, "/reverse-engineered", 6, 23 },
                    { 32, "/invoice", 4, 9 },
                    { 40, "/white/accounts/cotton", 1, 9 },
                    { 49, "/money-market-account", 6, 29 },
                    { 99, "/pre-emptive", 3, 29 },
                    { 91, "/static/credit-card-account/solid-state", 5, 15 },
                    { 94, "/ftp/application/alaska", 2, 15 },
                    { 31, "/digital/hacking", 4, 5 },
                    { 27, "/deploy", 6, 64 },
                    { 65, "/array/invoice", 1, 78 },
                    { 16, "/metal/minnesota/mobile", 4, 82 },
                    { 51, "/shoes", 2, 18 },
                    { 85, "/cyan/deposit", 2, 69 },
                    { 21, "/new-jersey/total/strategy", 5, 73 },
                    { 52, "/fuchsia", 3, 73 },
                    { 2, "/indexing", 3, 40 },
                    { 59, "/virtual/intangible/haptic", 2, 40 },
                    { 72, "/beauty", 2, 40 },
                    { 76, "/ports", 1, 60 },
                    { 43, "/stable/investment-account/frozen", 5, 39 },
                    { 23, "/global/sensor/monitoring", 5, 16 },
                    { 55, "/copy/interfaces/intelligent-frozen-towels", 7, 16 },
                    { 39, "/money-market-account", 5, 50 },
                    { 89, "/tanzanian-shilling/payment", 2, 28 },
                    { 12, "/payment", 5, 97 },
                    { 60, "/markets/tonga", 4, 14 },
                    { 8, "/solution-oriented", 7, 21 },
                    { 57, "/refined-fresh-soap/bandwidth/pci", 5, 21 },
                    { 62, "/vortals", 1, 90 },
                    { 69, "/clear-thinking/handmade-soft-bacon/mesh", 1, 90 },
                    { 70, "/games/transform/fantastic-wooden-fish", 7, 92 },
                    { 56, "/red", 2, 8 },
                    { 22, "/mission-critical", 4, 54 },
                    { 93, "/ergonomic/checking-account", 3, 54 },
                    { 42, "/wooden/multi-tasking/indexing", 2, 56 },
                    { 48, "/integration/evolve", 7, 91 },
                    { 83, "/ports", 1, 91 },
                    { 25, "/bypassing", 2, 25 },
                    { 54, "/ivory", 6, 27 },
                    { 95, "/bedfordshire", 5, 27 },
                    { 24, "/syrian-pound/tangible/hdd", 1, 61 },
                    { 97, "/savings-account", 7, 76 },
                    { 50, "/self-enabling/credit-card-account", 4, 32 },
                    { 75, "/director", 5, 88 },
                    { 18, "/secured", 1, 80 },
                    { 3, "/persevering", 1, 97 },
                    { 80, "/mount", 4, 7 },
                    { 87, "/connecticut", 6, 66 },
                    { 19, "/overriding/parsing/strategist", 7, 66 },
                    { 5, "/solution-oriented/interface", 1, 91 },
                    { 68, "/lebanon/seize/tunnel", 1, 77 },
                    { 10, "/station", 1, 22 },
                    { 9, "/input/crossing/cross-media", 1, 66 },
                    { 38, "/metrics/european-unit-of-account-17e.u.a", 7, 22 },
                    { 4, "/interactions/navigate", 5, 72 },
                    { 36, "/progressive", 5, 72 },
                    { 81, "/array/copying", 2, 74 },
                    { 20, "/rustic-concrete-bacon/navigating/orchestrator", 4, 19 },
                    { 29, "/steel/developer", 1, 19 },
                    { 15, "/hills/interface/wyoming", 4, 33 },
                    { 58, "/corner/compressing/berkshire", 2, 42 },
                    { 63, "/us-dollar/navigate/accounts", 4, 38 },
                    { 67, "/rustic/swaziland", 2, 65 },
                    { 90, "/streamline", 1, 94 },
                    { 88, "/group/outdoors/avon", 6, 4 },
                    { 30, "/international/road/jewelery--sports", 2, 30 },
                    { 34, "/rustic/matrix", 7, 30 },
                    { 35, "/nebraska", 4, 34 },
                    { 66, "/cross-platform", 4, 34 },
                    { 73, "/withdrawal/parse", 6, 34 },
                    { 28, "/generating/functionality/intelligent-granite-car", 3, 94 },
                    { 74, "/system/rich/fresh-thinking", 4, 94 },
                    { 53, "/wooden/texas/cotton", 6, 98 },
                    { 96, "/dynamic", 3, 94 }
                });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[,]
                {
                    { 392, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5590) },
                    { 392, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5593) },
                    { 392, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5597) },
                    { 393, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5600) },
                    { 395, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5613) },
                    { 394, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5607) },
                    { 394, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5610) },
                    { 391, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5586) },
                    { 393, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5603) },
                    { 390, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5583) },
                    { 385, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5542) },
                    { 390, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5576) },
                    { 390, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5573) },
                    { 389, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5570) },
                    { 388, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5566) },
                    { 388, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5562) },
                    { 387, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5559) },
                    { 387, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5555) },
                    { 386, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5552) },
                    { 386, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5549) },
                    { 385, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5545) },
                    { 395, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5617) },
                    { 390, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5580) },
                    { 396, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5620) },
                    { 406, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5702) },
                    { 396, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5627) },
                    { 407, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5706) },
                    { 384, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5538) },
                    { 406, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5699) },
                    { 405, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5695) },
                    { 405, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5692) },
                    { 404, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5689) },
                    { 404, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5685) },
                    { 403, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5682) },
                    { 403, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5678) },
                    { 402, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5675) },
                    { 402, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5672) },
                    { 401, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5668) },
                    { 401, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5665) },
                    { 401, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5662) },
                    { 400, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5658) },
                    { 400, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5655) },
                    { 399, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5652) },
                    { 399, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5648) },
                    { 398, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5645) },
                    { 398, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5642) },
                    { 397, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5637) },
                    { 397, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5634) },
                    { 397, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5630) },
                    { 396, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5624) },
                    { 384, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5535) },
                    { 169, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4050) },
                    { 383, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5528) },
                    { 24, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2840) },
                    { 24, 24, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2836) },
                    { 23, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2833) },
                    { 776, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9280) },
                    { 776, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9276) },
                    { 229, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4495) },
                    { 229, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4492) },
                    { 229, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4489) },
                    { 229, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4485) },
                    { 602, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7623) },
                    { 602, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7620) },
                    { 561, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7068) },
                    { 561, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7064) },
                    { 503, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6386) },
                    { 503, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6383) },
                    { 503, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6379) },
                    { 601, 24, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7616) },
                    { 601, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7613) },
                    { 601, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7610) },
                    { 373, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5462) },
                    { 56, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3064) },
                    { 56, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3061) },
                    { 56, 24, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3058) },
                    { 108, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3495) },
                    { 383, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5531) },
                    { 109, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3498) },
                    { 169, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4047) },
                    { 382, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5525) },
                    { 382, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5521) },
                    { 381, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5518) },
                    { 381, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5514) },
                    { 380, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5511) },
                    { 379, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5508) },
                    { 379, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5504) },
                    { 378, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5501) },
                    { 377, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5498) },
                    { 377, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5494) },
                    { 377, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5491) },
                    { 376, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5488) },
                    { 376, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5484) },
                    { 376, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5481) },
                    { 375, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5478) },
                    { 374, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5474) },
                    { 374, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5466) },
                    { 231, 24, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4506) },
                    { 230, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4503) },
                    { 230, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4499) },
                    { 171, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4058) },
                    { 170, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4054) },
                    { 407, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5709) },
                    { 169, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4043) },
                    { 408, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5712) },
                    { 605, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7661) },
                    { 408, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5719) },
                    { 425, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5826) },
                    { 425, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5823) },
                    { 425, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5819) },
                    { 424, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5816) },
                    { 423, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5812) },
                    { 422, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5808) },
                    { 421, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5805) },
                    { 420, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5801) },
                    { 419, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5798) },
                    { 418, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5795) },
                    { 425, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5829) },
                    { 417, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5791) },
                    { 417, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5784) },
                    { 416, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5781) },
                    { 416, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5778) },
                    { 415, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5774) },
                    { 415, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5771) },
                    { 414, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5768) },
                    { 414, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5764) },
                    { 413, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5761) },
                    { 413, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5758) },
                    { 412, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5754) },
                    { 417, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5788) },
                    { 426, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5832) },
                    { 426, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5836) },
                    { 427, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5840) },
                    { 433, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5883) },
                    { 232, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4510) },
                    { 27, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2860) },
                    { 847, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9817) },
                    { 846, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9814) },
                    { 725, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8854) },
                    { 725, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8851) },
                    { 725, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8847) },
                    { 678, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8355) },
                    { 606, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7675) },
                    { 606, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7672) },
                    { 606, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7668) },
                    { 432, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5879) },
                    { 432, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5876) },
                    { 432, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5872) },
                    { 431, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5869) },
                    { 431, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5865) },
                    { 430, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5861) },
                    { 430, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5858) },
                    { 429, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5854) },
                    { 428, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5850) },
                    { 428, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5847) },
                    { 427, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5843) },
                    { 412, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5751) },
                    { 411, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5748) },
                    { 411, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5745) },
                    { 411, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5741) },
                    { 605, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7664) },
                    { 677, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8351) },
                    { 605, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7657) },
                    { 605, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7654) },
                    { 604, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7651) },
                    { 604, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7647) },
                    { 604, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7644) },
                    { 604, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7640) },
                    { 604, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7637) },
                    { 604, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7633) },
                    { 603, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7630) },
                    { 603, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7627) },
                    { 562, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7085) },
                    { 562, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7081) },
                    { 562, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7078) },
                    { 562, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7075) },
                    { 562, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7071) },
                    { 504, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6396) },
                    { 504, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6392) },
                    { 504, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6389) },
                    { 409, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5730) },
                    { 409, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5726) },
                    { 409, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5723) },
                    { 644, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8035) },
                    { 408, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5716) },
                    { 844, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9800) },
                    { 845, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9807) },
                    { 410, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5737) },
                    { 410, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5734) },
                    { 207, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4339) },
                    { 207, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4335) },
                    { 206, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4332) },
                    { 206, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4328) },
                    { 206, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4325) },
                    { 206, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4322) },
                    { 206, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4318) },
                    { 139, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3775) },
                    { 139, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3771) },
                    { 111, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3519) },
                    { 111, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3516) },
                    { 111, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3512) },
                    { 110, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3509) },
                    { 110, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3506) },
                    { 110, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3503) },
                    { 26, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2857) },
                    { 26, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2853) },
                    { 25, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2850) },
                    { 25, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2847) },
                    { 25, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2843) },
                    { 845, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9810) },
                    { 844, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9803) },
                    { 677, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8348) },
                    { 370, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5448) },
                    { 677, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8340) },
                    { 553, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6969) },
                    { 553, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6965) },
                    { 552, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6961) },
                    { 552, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6958) },
                    { 552, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6955) },
                    { 552, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6951) },
                    { 551, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6947) },
                    { 551, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6944) },
                    { 551, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6940) },
                    { 551, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6936) },
                    { 551, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6933) },
                    { 551, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6930) },
                    { 550, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6926) },
                    { 550, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6923) },
                    { 550, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6920) },
                    { 549, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6916) },
                    { 549, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6913) },
                    { 548, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6910) },
                    { 548, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6906) },
                    { 548, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6903) },
                    { 548, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6899) },
                    { 548, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6896) },
                    { 548, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6893) },
                    { 553, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6972) },
                    { 547, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6889) },
                    { 553, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6975) },
                    { 554, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6982) },
                    { 595, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7553) },
                    { 594, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7549) },
                    { 594, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7546) },
                    { 594, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7543) },
                    { 558, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7050) },
                    { 558, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7047) },
                    { 558, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7043) },
                    { 558, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7040) },
                    { 558, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7034) },
                    { 558, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7031) },
                    { 557, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7027) },
                    { 557, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7024) },
                    { 557, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7021) },
                    { 557, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7017) },
                    { 557, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7013) },
                    { 556, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7009) },
                    { 555, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7006) },
                    { 555, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7003) },
                    { 555, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6999) },
                    { 555, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6996) },
                    { 554, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6992) },
                    { 554, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6989) },
                    { 554, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6985) },
                    { 554, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6979) },
                    { 595, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7556) },
                    { 547, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6885) },
                    { 546, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6877) },
                    { 359, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5361) },
                    { 359, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5357) },
                    { 205, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4315) },
                    { 204, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4311) },
                    { 204, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4308) },
                    { 204, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4305) },
                    { 204, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4301) },
                    { 204, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4298) },
                    { 203, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4294) },
                    { 203, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4291) },
                    { 203, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4288) },
                    { 203, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4284) },
                    { 202, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4275) },
                    { 202, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4272) },
                    { 202, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4268) },
                    { 202, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4265) },
                    { 201, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4262) },
                    { 200, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4258) },
                    { 200, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4255) },
                    { 200, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4252) },
                    { 200, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4248) },
                    { 200, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4245) },
                    { 199, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4241) },
                    { 359, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5365) },
                    { 547, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6881) },
                    { 359, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5369) },
                    { 361, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5376) },
                    { 546, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6873) },
                    { 546, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6869) },
                    { 546, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6865) },
                    { 546, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6861) },
                    { 545, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6858) },
                    { 545, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6855) },
                    { 545, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6851) },
                    { 545, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6848) },
                    { 545, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6844) },
                    { 366, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5424) },
                    { 365, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5421) },
                    { 365, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5417) },
                    { 365, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5414) },
                    { 365, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5411) },
                    { 364, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5407) },
                    { 363, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5404) },
                    { 363, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5400) },
                    { 363, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5397) },
                    { 363, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5394) },
                    { 362, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5390) },
                    { 361, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5387) },
                    { 361, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5384) },
                    { 361, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5379) },
                    { 360, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5372) },
                    { 677, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8344) },
                    { 595, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7559) },
                    { 595, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7566) },
                    { 840, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9779) },
                    { 839, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9775) },
                    { 838, 35, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9772) },
                    { 838, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9769) },
                    { 838, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9765) },
                    { 837, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9762) },
                    { 836, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9758) },
                    { 724, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8844) },
                    { 723, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8841) },
                    { 723, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8837) },
                    { 723, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8834) },
                    { 676, 48, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8317) },
                    { 676, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8314) },
                    { 676, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8310) },
                    { 22, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2829) },
                    { 22, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2826) },
                    { 22, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2822) },
                    { 835, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9754) },
                    { 835, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9751) },
                    { 835, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9748) },
                    { 560, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7060) },
                    { 560, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7057) },
                    { 107, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3491) },
                    { 841, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9782) },
                    { 107, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3488) },
                    { 842, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9786) },
                    { 54, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3047) },
                    { 677, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8337) },
                    { 677, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8334) },
                    { 677, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8330) },
                    { 677, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8327) },
                    { 677, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8324) },
                    { 677, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8320) },
                    { 600, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7606) },
                    { 600, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7603) },
                    { 600, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7600) },
                    { 600, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7596) },
                    { 599, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7593) },
                    { 599, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7590) },
                    { 598, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7586) },
                    { 372, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5459) },
                    { 372, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5456) },
                    { 228, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4482) },
                    { 55, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3054) },
                    { 843, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9796) },
                    { 843, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9793) },
                    { 843, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9789) },
                    { 371, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5452) },
                    { 434, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5887) },
                    { 54, 25, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3051) },
                    { 54, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3044) },
                    { 595, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7562) },
                    { 107, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3485) },
                    { 106, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3478) },
                    { 774, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9266) },
                    { 774, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9263) },
                    { 773, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9259) },
                    { 772, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9256) },
                    { 772, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9252) },
                    { 772, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9249) },
                    { 772, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9245) },
                    { 772, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9242) },
                    { 675, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8307) },
                    { 675, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8303) },
                    { 675, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8300) },
                    { 675, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8296) },
                    { 675, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8293) },
                    { 675, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8290) },
                    { 675, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8286) },
                    { 674, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8283) },
                    { 674, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8280) },
                    { 674, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8276) },
                    { 673, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8273) },
                    { 672, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8270) },
                    { 596, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7576) },
                    { 596, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7573) },
                    { 595, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7569) },
                    { 775, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9269) },
                    { 106, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3481) },
                    { 775, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9273) },
                    { 834, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9741) },
                    { 597, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7583) },
                    { 597, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7580) },
                    { 559, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7054) },
                    { 369, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5445) },
                    { 369, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5441) },
                    { 368, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5438) },
                    { 368, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5434) },
                    { 367, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5431) },
                    { 367, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5427) },
                    { 105, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3475) },
                    { 105, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3471) },
                    { 104, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3468) },
                    { 104, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3464) },
                    { 103, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3461) },
                    { 103, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3457) },
                    { 103, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3454) },
                    { 103, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3450) },
                    { 102, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3447) },
                    { 101, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3444) },
                    { 100, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3440) },
                    { 100, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3437) },
                    { 100, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3434) },
                    { 834, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9744) },
                    { 834, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9737) },
                    { 435, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5890) },
                    { 58, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3081) },
                    { 437, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5897) },
                    { 781, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9337) },
                    { 781, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9334) },
                    { 781, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9330) },
                    { 780, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9327) },
                    { 780, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9324) },
                    { 779, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9320) },
                    { 779, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9317) },
                    { 779, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9313) },
                    { 779, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9310) },
                    { 779, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9307) },
                    { 853, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9861) },
                    { 728, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8902) },
                    { 728, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8895) },
                    { 728, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8892) },
                    { 728, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8889) },
                    { 728, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8885) },
                    { 647, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8086) },
                    { 647, 2, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8083) },
                    { 647, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8080) },
                    { 647, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8076) },
                    { 647, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8073) },
                    { 647, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8070) },
                    { 728, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8899) },
                    { 853, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9865) },
                    { 854, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9868) },
                    { 854, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9872) },
                    { 66, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3190) },
                    { 66, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3187) },
                    { 66, 52, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3183) },
                    { 66, 24, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3179) },
                    { 66, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3176) },
                    { 66, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3173) },
                    { 66, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3169) },
                    { 857, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9926) },
                    { 857, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9923) },
                    { 857, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9919) },
                    { 857, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9916) },
                    { 856, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9913) },
                    { 856, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9909) },
                    { 856, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9906) },
                    { 856, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9902) },
                    { 855, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9899) },
                    { 854, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9895) },
                    { 854, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9892) },
                    { 854, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9889) },
                    { 854, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9885) },
                    { 854, 24, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9882) },
                    { 854, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9878) },
                    { 854, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9875) },
                    { 646, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8065) },
                    { 646, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8062) },
                    { 646, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8059) },
                    { 646, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8055) },
                    { 451, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6053) },
                    { 451, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6050) },
                    { 451, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6046) },
                    { 451, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6043) },
                    { 451, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6040) },
                    { 451, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6036) },
                    { 450, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6033) },
                    { 450, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6030) },
                    { 449, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6026) },
                    { 449, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6022) },
                    { 449, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6019) },
                    { 449, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6016) },
                    { 449, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6012) },
                    { 448, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6009) },
                    { 448, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6005) },
                    { 448, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6002) },
                    { 247, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4643) },
                    { 247, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4640) },
                    { 247, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4637) },
                    { 247, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4633) },
                    { 246, 2, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4630) },
                    { 246, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4627) },
                    { 246, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4623) },
                    { 451, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6063) },
                    { 66, 25, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3194) },
                    { 507, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6419) },
                    { 507, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6427) },
                    { 646, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8052) },
                    { 609, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7715) },
                    { 609, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7711) },
                    { 609, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7708) },
                    { 608, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7704) },
                    { 608, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7700) },
                    { 608, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7697) },
                    { 566, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7191) },
                    { 566, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7186) },
                    { 566, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7180) },
                    { 566, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7174) },
                    { 566, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7168) },
                    { 566, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7163) },
                    { 566, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7158) },
                    { 566, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7153) },
                    { 566, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7147) },
                    { 507, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6450) },
                    { 507, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6447) },
                    { 507, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6444) },
                    { 507, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6440) },
                    { 507, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6437) },
                    { 507, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6434) },
                    { 507, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6430) },
                    { 507, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6423) },
                    { 147, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3857) },
                    { 147, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3860) },
                    { 147, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3863) },
                    { 786, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9392) },
                    { 786, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9389) },
                    { 786, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9386) },
                    { 785, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9382) },
                    { 785, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9379) },
                    { 785, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9375) },
                    { 785, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9372) },
                    { 784, 24, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9368) },
                    { 784, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9365) },
                    { 784, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9361) },
                    { 784, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9357) },
                    { 783, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9354) },
                    { 783, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9351) },
                    { 783, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9347) },
                    { 782, 34, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9344) },
                    { 782, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9341) },
                    { 734, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8946) },
                    { 734, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8943) },
                    { 733, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8940) },
                    { 732, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8936) },
                    { 731, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8933) },
                    { 731, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8929) },
                    { 730, 25, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8926) },
                    { 787, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9396) },
                    { 730, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8923) },
                    { 788, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9399) },
                    { 788, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9406) },
                    { 866, 12, new DateTime(2020, 10, 7, 12, 3, 42, 383, DateTimeKind.Local).AddTicks(1) },
                    { 865, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9998) }
                });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[,]
                {
                    { 865, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9994) },
                    { 865, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9991) },
                    { 864, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9988) },
                    { 864, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9984) },
                    { 863, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9980) },
                    { 863, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9977) },
                    { 862, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9973) },
                    { 861, 20, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9970) },
                    { 861, 35, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9967) },
                    { 861, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9963) },
                    { 861, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9960) },
                    { 861, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9956) },
                    { 861, 23, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9953) },
                    { 861, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9950) },
                    { 860, 31, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9946) },
                    { 860, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9943) },
                    { 860, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9940) },
                    { 859, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9936) },
                    { 859, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9933) },
                    { 858, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9930) },
                    { 789, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9409) },
                    { 788, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9402) },
                    { 246, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4620) },
                    { 730, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8919) },
                    { 730, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8912) },
                    { 567, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7254) },
                    { 567, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7210) },
                    { 567, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7204) },
                    { 567, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7198) },
                    { 509, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6478) },
                    { 509, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6474) },
                    { 509, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6471) },
                    { 509, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6467) },
                    { 508, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6464) },
                    { 508, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6461) },
                    { 508, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6457) },
                    { 508, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6454) },
                    { 452, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6070) },
                    { 452, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6066) },
                    { 245, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4613) },
                    { 245, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4610) },
                    { 245, 1, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4606) },
                    { 174, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4095) },
                    { 174, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4091) },
                    { 174, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4088) },
                    { 174, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4085) },
                    { 174, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4081) },
                    { 147, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3867) },
                    { 568, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7260) },
                    { 730, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8916) },
                    { 568, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7266) },
                    { 648, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8090) },
                    { 729, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8909) },
                    { 729, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8906) },
                    { 691, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8550) },
                    { 691, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8546) },
                    { 690, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8521) },
                    { 690, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8518) },
                    { 690, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8514) },
                    { 689, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8511) },
                    { 688, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8508) },
                    { 688, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8504) },
                    { 688, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8501) },
                    { 688, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8498) },
                    { 651, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8127) },
                    { 651, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8124) },
                    { 651, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8120) },
                    { 650, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8117) },
                    { 649, 2, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8113) },
                    { 648, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8110) },
                    { 648, 24, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8107) },
                    { 648, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8103) },
                    { 648, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8100) },
                    { 648, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8096) },
                    { 648, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8093) },
                    { 610, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7718) },
                    { 436, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5893) },
                    { 246, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4617) },
                    { 238, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4562) },
                    { 506, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6413) },
                    { 506, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6409) },
                    { 505, 23, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6406) },
                    { 505, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6402) },
                    { 505, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6399) },
                    { 444, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5968) },
                    { 444, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5965) },
                    { 443, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5961) },
                    { 443, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5958) },
                    { 443, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5955) },
                    { 506, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6416) },
                    { 443, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5951) },
                    { 442, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5945) },
                    { 442, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5941) },
                    { 442, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5938) },
                    { 442, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5934) },
                    { 442, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5931) },
                    { 441, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5928) },
                    { 441, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5924) },
                    { 441, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5921) },
                    { 441, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5918) },
                    { 441, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5914) },
                    { 443, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5948) },
                    { 563, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7088) },
                    { 563, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7092) },
                    { 563, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7095) },
                    { 682, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8399) },
                    { 682, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8395) },
                    { 681, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8392) },
                    { 681, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8389) },
                    { 681, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8385) },
                    { 680, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8382) },
                    { 680, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8379) },
                    { 680, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8375) },
                    { 680, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8372) },
                    { 679, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8369) },
                    { 679, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8365) },
                    { 679, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8362) },
                    { 679, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8359) },
                    { 607, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7693) },
                    { 607, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7689) },
                    { 607, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7685) },
                    { 607, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7682) },
                    { 607, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7679) },
                    { 564, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7113) },
                    { 564, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7108) },
                    { 564, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7105) },
                    { 564, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7102) },
                    { 564, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7098) },
                    { 440, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5910) },
                    { 440, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5907) },
                    { 210, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4379) },
                    { 210, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4376) },
                    { 59, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3088) },
                    { 59, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3085) },
                    { 58, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3078) },
                    { 58, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3074) },
                    { 57, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3071) },
                    { 57, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3068) },
                    { 852, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9858) },
                    { 852, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9854) },
                    { 852, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9848) },
                    { 852, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9844) },
                    { 851, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9841) },
                    { 851, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9838) },
                    { 851, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9834) },
                    { 850, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9831) },
                    { 850, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9827) },
                    { 849, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9824) },
                    { 848, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9820) },
                    { 645, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8048) },
                    { 645, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8045) },
                    { 645, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8042) },
                    { 645, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8038) },
                    { 439, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5903) },
                    { 438, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5900) },
                    { 60, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3105) },
                    { 726, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8857) },
                    { 60, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3108) },
                    { 61, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3115) },
                    { 210, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4373) },
                    { 210, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4369) },
                    { 209, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4366) },
                    { 199, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4238) },
                    { 209, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4359) },
                    { 209, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4356) },
                    { 208, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4352) },
                    { 208, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4349) },
                    { 208, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4346) },
                    { 208, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4342) },
                    { 140, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3782) },
                    { 140, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3778) },
                    { 114, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3536) },
                    { 113, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3533) },
                    { 113, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3529) },
                    { 112, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3526) },
                    { 112, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3523) },
                    { 62, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3136) },
                    { 62, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3132) },
                    { 61, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3129) },
                    { 61, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3126) },
                    { 61, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3122) },
                    { 61, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3119) },
                    { 61, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3112) },
                    { 726, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8861) },
                    { 726, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8864) },
                    { 726, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8868) },
                    { 144, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3829) },
                    { 144, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3826) },
                    { 144, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3823) },
                    { 144, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3819) },
                    { 144, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3816) },
                    { 144, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3812) },
                    { 115, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3560) },
                    { 115, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3556) },
                    { 115, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3553) },
                    { 115, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3550) },
                    { 115, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3546) },
                    { 115, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3543) },
                    { 115, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3540) },
                    { 65, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3166) },
                    { 64, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3163) },
                    { 63, 25, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3159) },
                    { 63, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3156) },
                    { 63, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3152) },
                    { 63, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3149) },
                    { 63, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3146) },
                    { 63, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3142) },
                    { 63, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3139) },
                    { 35, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2921) },
                    { 145, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3833) },
                    { 34, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2918) },
                    { 145, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3836) },
                    { 145, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3843) },
                    { 237, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4559) },
                    { 237, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4555) },
                    { 236, 36, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4552) },
                    { 236, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4549) },
                    { 236, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4545) },
                    { 236, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4542) },
                    { 236, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4538) },
                    { 236, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4535) },
                    { 235, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4531) },
                    { 235, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4528) },
                    { 234, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4525) },
                    { 233, 36, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4521) },
                    { 233, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4518) },
                    { 233, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4514) },
                    { 173, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4078) },
                    { 172, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4075) },
                    { 172, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4071) },
                    { 172, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4068) },
                    { 172, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4064) },
                    { 172, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4061) },
                    { 146, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3853) },
                    { 146, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3850) },
                    { 145, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3846) },
                    { 145, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3839) },
                    { 240, 1, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4565) },
                    { 34, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2914) },
                    { 33, 47, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2908) },
                    { 447, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5992) },
                    { 446, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5988) },
                    { 446, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5985) },
                    { 446, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5982) },
                    { 445, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5978) },
                    { 445, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5975) },
                    { 445, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5971) },
                    { 143, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3809) },
                    { 143, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3806) },
                    { 143, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3802) },
                    { 142, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3799) },
                    { 141, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3796) },
                    { 141, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3792) },
                    { 141, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3789) },
                    { 141, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3786) },
                    { 778, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9303) },
                    { 778, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9300) },
                    { 778, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9297) },
                    { 778, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9293) },
                    { 778, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9290) },
                    { 777, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9287) },
                    { 777, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9283) },
                    { 726, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8871) },
                    { 447, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5995) },
                    { 34, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2911) },
                    { 447, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5998) },
                    { 565, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7123) },
                    { 32, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2904) },
                    { 31, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2901) },
                    { 31, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2897) },
                    { 31, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2894) },
                    { 31, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2890) },
                    { 31, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2887) },
                    { 30, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2884) },
                    { 30, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2880) },
                    { 30, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2877) },
                    { 29, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2874) },
                    { 29, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2870) },
                    { 29, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2867) },
                    { 28, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2864) },
                    { 727, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8882) },
                    { 727, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8878) },
                    { 727, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8874) },
                    { 683, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8412) },
                    { 683, 11, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8409) },
                    { 683, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8406) },
                    { 683, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8402) },
                    { 565, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7141) },
                    { 565, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7134) },
                    { 565, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7129) },
                    { 565, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7118) },
                    { 209, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4363) },
                    { 199, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4234) },
                    { 199, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4227) },
                    { 218, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4420) },
                    { 218, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4416) },
                    { 193, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4187) },
                    { 193, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4183) },
                    { 164, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4020) },
                    { 164, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4016) },
                    { 163, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4013) },
                    { 162, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4009) },
                    { 162, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4006) },
                    { 162, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4003) },
                    { 162, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3999) },
                    { 162, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3996) },
                    { 162, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3993) },
                    { 136, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3748) },
                    { 136, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3744) },
                    { 136, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3741) },
                    { 136, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3738) },
                    { 136, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3734) },
                    { 135, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3731) },
                    { 134, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3728) },
                    { 134, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3724) },
                    { 134, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3721) },
                    { 133, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3717) },
                    { 133, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3714) },
                    { 91, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3380) },
                    { 218, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4424) },
                    { 284, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4880) },
                    { 285, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4884) },
                    { 286, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4887) },
                    { 494, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6314) },
                    { 493, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6311) },
                    { 493, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6307) },
                    { 493, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6304) },
                    { 492, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6301) },
                    { 491, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6297) },
                    { 490, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6294) },
                    { 490, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6291) },
                    { 295, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4951) },
                    { 295, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4948) },
                    { 294, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4944) },
                    { 293, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4941) },
                    { 91, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3377) },
                    { 293, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4937) },
                    { 292, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4930) },
                    { 291, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4927) },
                    { 291, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4923) },
                    { 290, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4919) },
                    { 290, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4916) },
                    { 289, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4913) },
                    { 289, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4909) },
                    { 288, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4905) },
                    { 288, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4902) },
                    { 287, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4899) },
                    { 287, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4894) },
                    { 286, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4891) },
                    { 292, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4933) },
                    { 91, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3373) },
                    { 90, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3370) },
                    { 90, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3366) },
                    { 3, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2678) },
                    { 2, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2674) },
                    { 2, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2671) },
                    { 2, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2667) },
                    { 2, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2660) },
                    { 2, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2636) },
                    { 489, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6286) },
                    { 489, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6283) },
                    { 812, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9570) },
                    { 812, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9566) },
                    { 811, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9563) },
                    { 810, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9560) },
                    { 43, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2962) },
                    { 810, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9556) },
                    { 809, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9549) },
                    { 747, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9028) },
                    { 747, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9024) },
                    { 746, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9021) },
                    { 746, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9018) },
                    { 745, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9014) },
                    { 745, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9011) },
                    { 744, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9008) },
                    { 743, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9004) },
                    { 742, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9000) },
                    { 741, 34, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8997) },
                    { 741, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8993) },
                    { 809, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9552) },
                    { 529, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6662) },
                    { 43, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2966) },
                    { 44, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2973) },
                    { 90, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3363) },
                    { 89, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3360) },
                    { 89, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3355) },
                    { 89, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3352) },
                    { 88, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3348) },
                    { 88, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3345) },
                    { 88, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3342) },
                    { 87, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3338) },
                    { 87, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3335) },
                    { 87, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3331) },
                    { 86, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3328) },
                    { 86, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3325) },
                    { 44, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2969) },
                    { 86, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3321) },
                    { 85, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3314) },
                    { 85, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3311) },
                    { 84, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3307) },
                    { 84, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3304) },
                    { 84, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3300) },
                    { 83, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3297) },
                    { 83, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3293) },
                    { 83, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3290) },
                    { 82, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3286) },
                    { 82, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3282) },
                    { 82, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3278) },
                    { 81, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3274) },
                    { 85, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3318) },
                    { 530, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6665) },
                    { 530, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6668) },
                    { 530, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6672) },
                    { 755, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9090) },
                    { 755, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9086) },
                    { 755, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9083) },
                    { 754, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9078) },
                    { 754, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9075) },
                    { 754, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9072) },
                    { 753, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9068) },
                    { 753, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9065) },
                    { 752, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9062) },
                    { 752, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9058) },
                    { 751, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9055) },
                    { 751, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9051) },
                    { 755, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9093) },
                    { 751, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9048) },
                    { 750, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9041) },
                    { 749, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9038) },
                    { 748, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9035) },
                    { 748, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9031) },
                    { 706, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8690) },
                    { 706, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8687) },
                    { 706, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8683) },
                    { 706, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8680) },
                    { 706, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8676) },
                    { 665, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8228) },
                    { 665, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8225) },
                    { 665, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8222) },
                    { 750, 34, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9045) },
                    { 664, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8218) },
                    { 813, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9574) },
                    { 813, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9581) },
                    { 194, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4194) },
                    { 194, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4190) },
                    { 165, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4030) },
                    { 165, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4026) },
                    { 165, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4023) },
                    { 137, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3758) },
                    { 137, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3754) },
                    { 137, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3751) },
                    { 45, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2979) },
                    { 45, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2976) },
                    { 4, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2689) },
                    { 4, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2685) },
                    { 813, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9577) },
                    { 4, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2681) },
                    { 817, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9622) },
                    { 817, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9618) },
                    { 816, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9615) },
                    { 816, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9611) },
                    { 816, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9608) },
                    { 816, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9605) },
                    { 815, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9601) },
                    { 815, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9598) },
                    { 815, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9594) },
                    { 814, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9591) },
                    { 814, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9588) },
                    { 814, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9584) },
                    { 817, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9625) },
                    { 705, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8673) },
                    { 664, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8215) },
                    { 663, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8208) },
                    { 583, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7389) },
                    { 582, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7386) },
                    { 582, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7382) },
                    { 581, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7379) },
                    { 580, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7375) },
                    { 536, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6746) },
                    { 536, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6743) },
                    { 536, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6739) },
                    { 536, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6736) },
                    { 535, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6732) },
                    { 535, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6729) },
                    { 535, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6725) },
                    { 583, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7393) },
                    { 535, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6722) },
                    { 534, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6714) },
                    { 534, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6711) },
                    { 534, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6707) },
                    { 534, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6703) },
                    { 533, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6700) },
                    { 533, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6696) },
                    { 533, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6692) },
                    { 533, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6689) },
                    { 532, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6685) },
                    { 532, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6682) },
                    { 532, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6679) },
                    { 531, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6675) },
                    { 535, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6718) },
                    { 664, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8212) },
                    { 583, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7396) },
                    { 584, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7404) },
                    { 662, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8205) },
                    { 662, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8201) },
                    { 626, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7855) },
                    { 626, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7851) },
                    { 626, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7847) },
                    { 625, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7844) },
                    { 625, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7840) },
                    { 625, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7837) },
                    { 624, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7833) },
                    { 624, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7830) },
                    { 623, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7827) },
                    { 623, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7823) },
                    { 584, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7400) },
                    { 622, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7820) },
                    { 622, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7813) },
                    { 622, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7810) },
                    { 621, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7807) },
                    { 621, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7803) },
                    { 620, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7800) },
                    { 620, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7797) },
                    { 619, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7793) },
                    { 619, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7790) },
                    { 619, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7786) },
                    { 584, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7414) },
                    { 584, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7411) },
                    { 584, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7407) },
                    { 622, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7817) },
                    { 705, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8670) },
                    { 704, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8666) },
                    { 704, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8663) },
                    { 573, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7315) },
                    { 573, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7310) },
                    { 515, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6543) },
                    { 515, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6540) },
                    { 515, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6536) },
                    { 515, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6533) },
                    { 514, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6530) },
                    { 514, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6526) },
                    { 514, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6523) },
                    { 514, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6519) },
                    { 513, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6516) },
                    { 513, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6513) },
                    { 573, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7318) },
                    { 513, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6509) },
                    { 512, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6502) },
                    { 512, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6499) },
                    { 512, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6495) },
                    { 480, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6242) },
                    { 479, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6239) },
                    { 479, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6235) },
                    { 277, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4849) },
                    { 276, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4846) },
                    { 275, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4842) },
                    { 275, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4839) },
                    { 274, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4836) },
                    { 274, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4832) },
                    { 513, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6506) },
                    { 273, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4829) },
                    { 574, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7321) },
                    { 574, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7328) },
                    { 695, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8601) },
                    { 695, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8597) },
                    { 694, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8594) },
                    { 694, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8590) },
                    { 694, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8587) },
                    { 694, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8583) },
                    { 693, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8580) },
                    { 693, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8577) },
                    { 693, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8573) },
                    { 693, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8570) },
                    { 693, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8567) },
                    { 692, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8563) },
                    { 574, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7325) },
                    { 692, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8560) },
                    { 692, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8553) },
                    { 655, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8155) },
                    { 655, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8151) },
                    { 654, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8148) },
                    { 654, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8144) },
                    { 614, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7754) },
                    { 614, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7751) },
                    { 575, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7354) },
                    { 575, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7350) },
                    { 575, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7347) },
                    { 575, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7335) },
                    { 574, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7331) },
                    { 692, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8557) },
                    { 695, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8604) },
                    { 272, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4825) },
                    { 270, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4819) },
                    { 259, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4767) },
                    { 259, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4764) },
                    { 259, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4760) },
                    { 258, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4757) },
                    { 190, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4169) },
                    { 613, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7747) },
                    { 613, 2, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7744) },
                    { 613, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7740) },
                    { 572, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7306) },
                    { 572, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7303) },
                    { 572, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7299) },
                    { 257, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4753) },
                    { 260, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4770) },
                    { 256, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4750) },
                    { 256, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4743) },
                    { 256, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4739) },
                    { 255, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4736) },
                    { 255, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4733) },
                    { 189, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4166) },
                    { 189, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4163) },
                    { 188, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4159) },
                    { 77, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3253) },
                    { 77, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3250) },
                    { 76, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3246) },
                    { 75, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3243) },
                    { 40, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2946) },
                    { 256, 2, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4746) },
                    { 271, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4822) },
                    { 158, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3966) },
                    { 215, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4403) },
                    { 269, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4815) },
                    { 267, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4811) },
                    { 241, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4569) },
                    { 216, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4410) },
                    { 191, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4173) },
                    { 160, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3986) },
                    { 160, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3982) },
                    { 160, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3979) },
                    { 159, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3976) },
                    { 159, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3972) },
                    { 130, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3682) },
                    { 130, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3679) },
                    { 158, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3969) },
                    { 78, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3257) },
                    { 266, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4808) },
                    { 265, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4804) },
                    { 264, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4801) },
                    { 263, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4798) },
                    { 262, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4794) },
                    { 262, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4791) },
                    { 262, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4787) },
                    { 262, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4784) },
                    { 262, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4781) },
                    { 261, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4777) },
                    { 261, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4774) },
                    { 215, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4406) },
                    { 1, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2146) },
                    { 195, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4197) },
                    { 695, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8607) },
                    { 737, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8970) },
                    { 615, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7769) },
                    { 615, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7766) },
                    { 615, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7762) },
                    { 615, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7758) },
                    { 579, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7372) },
                    { 578, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7368) },
                    { 577, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7365) },
                    { 576, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7361) },
                    { 576, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7358) },
                    { 528, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6658) },
                    { 527, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6654) },
                    { 526, 22, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6651) },
                    { 616, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7773) },
                    { 525, 14, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6642) },
                    { 525, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6635) },
                    { 525, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6632) },
                    { 525, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6628) },
                    { 524, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6625) },
                    { 524, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6621) },
                    { 524, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6618) },
                    { 524, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6615) },
                    { 523, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6611) },
                    { 523, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6608) },
                    { 522, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6604) },
                    { 521, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6601) },
                    { 521, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6597) },
                    { 525, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6639) },
                    { 521, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6594) },
                    { 616, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7776) },
                    { 618, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7783) },
                    { 703, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8660) },
                    { 702, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8656) },
                    { 702, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8652) },
                    { 701, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8649) },
                    { 701, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8645) },
                    { 700, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8642) },
                    { 699, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8638) },
                    { 698, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8635) },
                    { 698, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8631) },
                    { 698, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8628) },
                    { 697, 30, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8625) },
                    { 697, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8621) },
                    { 617, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7779) },
                    { 697, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8618) },
                    { 661, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8197) },
                    { 661, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8194) }
                });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[,]
                {
                    { 660, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8190) },
                    { 660, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8187) },
                    { 659, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8183) },
                    { 658, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8180) },
                    { 657, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8176) },
                    { 657, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8173) },
                    { 656, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8170) },
                    { 656, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8166) },
                    { 656, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8162) },
                    { 656, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8158) },
                    { 696, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8614) },
                    { 695, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8611) },
                    { 521, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6591) },
                    { 520, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6584) },
                    { 132, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3704) },
                    { 132, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3701) },
                    { 131, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3692) },
                    { 131, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3689) },
                    { 131, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3685) },
                    { 80, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3270) },
                    { 80, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3267) },
                    { 80, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3263) },
                    { 79, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3260) },
                    { 42, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2959) },
                    { 42, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2956) },
                    { 516, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6550) },
                    { 132, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3707) },
                    { 516, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6546) },
                    { 280, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4859) },
                    { 279, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4856) },
                    { 278, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4852) },
                    { 41, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2952) },
                    { 41, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2949) },
                    { 808, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9545) },
                    { 740, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8990) },
                    { 739, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8987) },
                    { 739, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8983) },
                    { 738, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8980) },
                    { 738, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8977) },
                    { 738, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8973) },
                    { 281, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4863) },
                    { 520, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6587) },
                    { 132, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3711) },
                    { 192, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4176) },
                    { 519, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6581) },
                    { 518, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6577) },
                    { 518, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6574) },
                    { 517, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6571) },
                    { 517, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6567) },
                    { 517, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6564) },
                    { 517, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6560) },
                    { 517, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6556) },
                    { 517, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6553) },
                    { 488, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6280) },
                    { 487, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6276) },
                    { 486, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6273) },
                    { 161, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3989) },
                    { 485, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6269) },
                    { 483, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6263) },
                    { 482, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6259) },
                    { 482, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6256) },
                    { 481, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6253) },
                    { 481, 1, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6249) },
                    { 481, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6246) },
                    { 283, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4869) },
                    { 282, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4866) },
                    { 242, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4576) },
                    { 242, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4572) },
                    { 217, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4413) },
                    { 192, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4179) },
                    { 484, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6266) },
                    { 199, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4231) },
                    { 195, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4200) },
                    { 196, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4207) },
                    { 16, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2771) },
                    { 15, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2768) },
                    { 15, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2765) },
                    { 830, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9700) },
                    { 829, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9697) },
                    { 828, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9694) },
                    { 768, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9219) },
                    { 768, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9215) },
                    { 768, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9212) },
                    { 767, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9209) },
                    { 767, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9205) },
                    { 766, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9202) },
                    { 766, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9199) },
                    { 717, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8783) },
                    { 717, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8779) },
                    { 716, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8776) },
                    { 668, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8249) },
                    { 637, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8005) },
                    { 499, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6341) },
                    { 329, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5180) },
                    { 328, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5176) },
                    { 327, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5172) },
                    { 166, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4033) },
                    { 94, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3394) },
                    { 94, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3390) },
                    { 50, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3024) },
                    { 167, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4037) },
                    { 225, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4472) },
                    { 226, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4475) },
                    { 500, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6348) },
                    { 500, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6344) },
                    { 345, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5259) },
                    { 344, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5255) },
                    { 343, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5252) },
                    { 342, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5249) },
                    { 341, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5245) },
                    { 340, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5242) },
                    { 339, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5238) },
                    { 338, 44, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5235) },
                    { 338, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5232) },
                    { 337, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5228) },
                    { 93, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3387) },
                    { 336, 42, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5225) },
                    { 335, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5218) },
                    { 334, 24, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5215) },
                    { 334, 43, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5211) },
                    { 333, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5208) },
                    { 332, 42, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5205) },
                    { 332, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5200) },
                    { 332, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5196) },
                    { 331, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5193) },
                    { 330, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5190) },
                    { 330, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5186) },
                    { 330, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5183) },
                    { 227, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4478) },
                    { 336, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5222) },
                    { 92, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3383) },
                    { 49, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3020) },
                    { 14, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2761) },
                    { 221, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4444) },
                    { 221, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4441) },
                    { 220, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4437) },
                    { 219, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4434) },
                    { 219, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4431) },
                    { 219, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4427) },
                    { 48, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3017) },
                    { 48, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3013) },
                    { 47, 1, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3010) },
                    { 47, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3007) },
                    { 827, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9690) },
                    { 826, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9686) },
                    { 222, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4448) },
                    { 825, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9683) },
                    { 765, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9195) },
                    { 765, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9191) },
                    { 764, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9188) },
                    { 764, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9184) },
                    { 715, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8773) },
                    { 715, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8769) },
                    { 634, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7970) },
                    { 634, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7967) },
                    { 634, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7963) },
                    { 634, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7960) },
                    { 633, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7957) },
                    { 633, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7953) },
                    { 824, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9680) },
                    { 638, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8008) },
                    { 223, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4451) },
                    { 223, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4458) },
                    { 13, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2758) },
                    { 12, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2754) },
                    { 11, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2750) },
                    { 636, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8001) },
                    { 636, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7998) },
                    { 636, 42, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7994) },
                    { 636, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7991) },
                    { 635, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7988) },
                    { 635, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7984) },
                    { 635, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7981) },
                    { 635, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7977) },
                    { 635, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7973) },
                    { 223, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4454) },
                    { 593, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7539) },
                    { 325, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5166) },
                    { 324, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5162) },
                    { 323, 36, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5159) },
                    { 323, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5156) },
                    { 323, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5152) },
                    { 322, 36, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5149) },
                    { 322, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5146) },
                    { 321, 36, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5142) },
                    { 321, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5139) },
                    { 224, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4468) },
                    { 224, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4464) },
                    { 223, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4461) },
                    { 326, 10, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5169) },
                    { 669, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8252) },
                    { 670, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8256) },
                    { 707, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8693) },
                    { 502, 34, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6372) },
                    { 502, 20, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6368) },
                    { 502, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6364) },
                    { 502, 47, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6361) },
                    { 502, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6358) },
                    { 502, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6354) },
                    { 358, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5354) },
                    { 357, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5350) },
                    { 356, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5347) },
                    { 355, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5344) },
                    { 354, 45, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5340) },
                    { 354, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5337) },
                    { 502, 19, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6375) },
                    { 354, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5334) },
                    { 353, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5327) },
                    { 353, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5324) },
                    { 244, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4603) },
                    { 244, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4599) },
                    { 244, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4596) },
                    { 244, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4593) },
                    { 244, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4589) },
                    { 168, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4040) },
                    { 832, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9718) },
                    { 832, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9714) },
                    { 832, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9711) },
                    { 722, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8831) },
                    { 353, 45, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5330) },
                    { 722, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8827) },
                    { 833, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9727) },
                    { 833, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9734) },
                    { 99, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3430) },
                    { 99, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3427) },
                    { 98, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3423) },
                    { 98, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3419) },
                    { 98, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3416) },
                    { 97, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3412) },
                    { 96, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3408) },
                    { 96, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3405) },
                    { 95, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3401) },
                    { 95, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3398) },
                    { 53, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3041) },
                    { 53, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3037) },
                    { 833, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9730) },
                    { 709, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8717) },
                    { 709, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8710) },
                    { 21, 53, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2819) },
                    { 21, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2815) },
                    { 21, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2812) },
                    { 20, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2809) },
                    { 20, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2805) },
                    { 19, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2802) },
                    { 19, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2799) },
                    { 643, 23, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8031) },
                    { 52, 23, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3034) },
                    { 708, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8707) },
                    { 708, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8703) },
                    { 709, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8713) },
                    { 632, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7950) },
                    { 721, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8824) },
                    { 720, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8817) },
                    { 51, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3027) },
                    { 18, 1, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2795) },
                    { 18, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2792) },
                    { 17, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2788) },
                    { 17, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2785) },
                    { 17, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2782) },
                    { 17, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2778) },
                    { 17, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2775) },
                    { 831, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9707) },
                    { 831, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9704) },
                    { 771, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9239) },
                    { 771, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9235) },
                    { 51, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3031) },
                    { 771, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9232) },
                    { 770, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9225) },
                    { 769, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9222) },
                    { 719, 42, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8810) },
                    { 719, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8806) },
                    { 719, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8803) },
                    { 719, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8800) },
                    { 718, 16, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8796) },
                    { 718, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8793) },
                    { 718, 20, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8790) },
                    { 718, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8786) },
                    { 707, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8700) },
                    { 707, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8697) },
                    { 770, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9229) },
                    { 721, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8821) },
                    { 346, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5262) },
                    { 346, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5270) },
                    { 720, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8813) },
                    { 671, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8266) },
                    { 671, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8263) },
                    { 671, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8259) },
                    { 642, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8028) },
                    { 642, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8025) },
                    { 641, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8021) },
                    { 640, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8018) },
                    { 640, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8015) },
                    { 639, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8011) },
                    { 501, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6351) },
                    { 352, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5320) },
                    { 346, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5266) },
                    { 352, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5317) },
                    { 351, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5310) },
                    { 351, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5307) },
                    { 351, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5303) },
                    { 350, 41, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5300) },
                    { 350, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5297) },
                    { 349, 1, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5293) },
                    { 349, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5290) },
                    { 349, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5287) },
                    { 348, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5283) },
                    { 347, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5280) },
                    { 347, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5277) },
                    { 347, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5273) },
                    { 352, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5313) },
                    { 632, 21, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7946) },
                    { 632, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7943) },
                    { 631, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7934) },
                    { 588, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7470) },
                    { 588, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7467) },
                    { 588, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7463) },
                    { 587, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7460) },
                    { 587, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7457) },
                    { 587, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7453) },
                    { 587, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7450) },
                    { 586, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7446) },
                    { 586, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7443) },
                    { 586, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7440) },
                    { 586, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7436) },
                    { 585, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7433) },
                    { 588, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7473) },
                    { 585, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7429) },
                    { 585, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7422) },
                    { 585, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7418) },
                    { 544, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6840) },
                    { 544, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6837) },
                    { 544, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6833) },
                    { 543, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6830) },
                    { 543, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6827) },
                    { 543, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6823) },
                    { 543, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6820) },
                    { 542, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6816) },
                    { 542, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6813) },
                    { 541, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6810) },
                    { 585, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7426) },
                    { 541, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6806) },
                    { 588, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7477) },
                    { 589, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7484) },
                    { 629, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7893) },
                    { 629, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7890) },
                    { 629, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7886) },
                    { 629, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7883) },
                    { 628, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7879) },
                    { 628, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7875) },
                    { 628, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7872) },
                    { 627, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7869) },
                    { 627, 9, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7865) },
                    { 627, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7861) },
                    { 627, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7858) },
                    { 592, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7536) },
                    { 589, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7480) },
                    { 592, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7532) },
                    { 592, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7526) },
                    { 592, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7522) },
                    { 591, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7519) },
                    { 591, 15, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7515) },
                    { 591, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7512) },
                    { 591, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7508) },
                    { 591, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7505) },
                    { 590, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7501) },
                    { 590, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7498) },
                    { 590, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7495) },
                    { 589, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7491) },
                    { 589, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7488) },
                    { 592, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7529) },
                    { 630, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7897) },
                    { 541, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6803) },
                    { 540, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6795) },
                    { 304, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5016) },
                    { 304, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5012) },
                    { 304, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5009) },
                    { 303, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5005) },
                    { 302, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5001) },
                    { 302, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4998) },
                    { 301, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4995) },
                    { 301, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4991) },
                    { 301, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4987) },
                    { 300, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4983) },
                    { 300, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4980) },
                    { 300, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4976) },
                    { 305, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5019) },
                    { 299, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4973) },
                    { 297, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4966) },
                    { 297, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4962) },
                    { 296, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4958) },
                    { 296, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4955) },
                    { 243, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4586) },
                    { 243, 38, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4582) },
                    { 243, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4579) },
                    { 198, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4224) },
                    { 198, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4221) },
                    { 197, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4217) },
                    { 197, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4214) },
                    { 196, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4210) },
                    { 298, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4969) },
                    { 541, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6799) },
                    { 305, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5022) },
                    { 306, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5029) },
                    { 540, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6792) },
                    { 540, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6789) },
                    { 540, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6785) },
                    { 539, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6782) },
                    { 539, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6779) },
                    { 538, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6775) },
                    { 538, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6772) },
                    { 538, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6768) },
                    { 538, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6765) },
                    { 537, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6761) },
                    { 537, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6758) },
                    { 537, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6754) },
                    { 305, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5026) },
                    { 537, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6750) },
                    { 498, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6334) },
                    { 498, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6331) },
                    { 497, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6328) },
                    { 496, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6324) },
                    { 496, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6321) },
                    { 495, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6318) },
                    { 309, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5050) },
                    { 309, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5046) },
                    { 308, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5043) },
                    { 307, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5039) },
                    { 306, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5036) },
                    { 306, 5, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5033) },
                    { 498, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(6338) },
                    { 196, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(4204) },
                    { 630, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7900) },
                    { 630, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7907) },
                    { 310, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5053) },
                    { 138, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3768) },
                    { 138, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3764) },
                    { 138, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3761) },
                    { 46, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3003) },
                    { 46, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(3000) },
                    { 46, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2997) },
                    { 46, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2993) },
                    { 46, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2989) },
                    { 46, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2986) },
                    { 46, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2983) },
                    { 10, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2747) },
                    { 310, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5057) },
                    { 10, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2743) },
                    { 10, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2736) },
                    { 10, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2733) },
                    { 9, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2729) },
                    { 9, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2726) },
                    { 8, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2722) },
                    { 8, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2718) },
                    { 8, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2715) },
                    { 8, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2711) },
                    { 7, 46, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2707) },
                    { 7, 47, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2704) },
                    { 7, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2700) },
                    { 6, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2696) },
                    { 10, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2739) },
                    { 5, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2692) },
                    { 310, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5060) },
                    { 312, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5067) },
                    { 631, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7931) },
                    { 631, 40, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7928) },
                    { 631, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7924) },
                    { 631, 8, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7921) },
                    { 631, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7917) },
                    { 631, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7914) },
                    { 320, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5135) },
                    { 320, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5132) },
                    { 319, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5128) },
                    { 318, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5125) },
                    { 317, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5122) },
                    { 317, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5118) },
                    { 311, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5063) },
                    { 316, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5115) },
                    { 315, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5108) },
                    { 315, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5105) },
                    { 315, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5102) },
                    { 314, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5098) },
                    { 314, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5095) },
                    { 314, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5092) },
                    { 313, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5088) },
                    { 313, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5085) },
                    { 313, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5080) },
                    { 312, 39, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5077) },
                    { 312, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5074) },
                    { 312, 17, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5070) },
                    { 315, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(5112) },
                    { 630, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7904) },
                    { 823, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9676) },
                    { 823, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9670) },
                    { 757, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9114) },
                    { 757, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9111) },
                    { 757, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9108) },
                    { 756, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9104) },
                    { 756, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9101) },
                    { 756, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9097) },
                    { 714, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8766) },
                    { 714, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8763) },
                    { 713, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8759) },
                    { 713, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8756) },
                    { 713, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8752) },
                    { 713, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8749) },
                    { 758, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9118) },
                    { 712, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8746) },
                    { 712, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8739) },
                    { 711, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8736) },
                    { 711, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8730) },
                    { 711, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8727) },
                    { 710, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8724) },
                    { 710, 7, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8720) },
                    { 667, 18, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8245) },
                    { 666, 29, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8242) },
                    { 666, 3, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8238) },
                    { 666, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8235) },
                    { 666, 26, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8232) },
                    { 630, 4, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(7911) },
                    { 712, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(8742) },
                    { 823, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9673) },
                    { 758, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9121) },
                    { 758, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9134) },
                    { 822, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9666) },
                    { 822, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9663) },
                    { 822, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9659) },
                    { 821, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9656) },
                    { 821, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9652) },
                    { 821, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9649) },
                    { 820, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9645) },
                    { 820, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9642) },
                    { 819, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9638) },
                    { 819, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9635) },
                    { 818, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9632) },
                    { 818, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9628) },
                    { 758, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9125) },
                    { 763, 27, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9181) },
                    { 763, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9174) },
                    { 763, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9171) },
                    { 762, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9168) },
                    { 762, 33, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9164) },
                    { 762, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9161) },
                    { 761, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9158) },
                    { 760, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9154) },
                    { 760, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9151) },
                    { 760, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9148) },
                    { 759, 32, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9144) },
                    { 759, 12, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9141) },
                    { 759, 28, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9138) },
                    { 763, 13, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(9178) },
                    { 39, 6, new DateTime(2020, 10, 7, 12, 3, 42, 382, DateTimeKind.Local).AddTicks(2942) }
                });

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
